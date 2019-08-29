using System;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace CHD.SVN_Notifier
{
	public partial class ControlHelper
	{
		#region Apply Grid Border Style

		public static void ApplyBorderStyle(DataGridView grid)
		{
			grid.BackgroundColor = Color.White;
			grid.BorderStyle = BorderStyle.None;
			grid.EnableHeadersVisualStyles = false;
			grid.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
			grid.ColumnHeadersDefaultCellStyle.BackColor = SystemColors.Control;
			grid.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
			grid.RowHeadersDefaultCellStyle.BackColor = SystemColors.Control;
			grid.BackColor = SystemColors.Window;
			grid.DefaultCellStyle.BackColor = SystemColors.Window;
			grid.CellPainting += Grid_CellPainting;
			grid.SelectionChanged += Grid_SelectionChanged;
			grid.CellFormatting += Grid_CellFormatting;
			grid.CellClick += Grid_CellClick;
		}

		static void Grid_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex < 0 || e.ColumnIndex < 0)
				return;
			var grid = (DataGridView)sender;
			// If add new record row.
			if (grid.AllowUserToAddRows && e.RowIndex + 1 == grid.Rows.Count)
				return;
			var column = grid.Columns[e.ColumnIndex];
			var item = (SvnItem)grid.Rows[e.RowIndex].DataBoundItem;
			if (column.DataPropertyName == "Enabled" || column.DataPropertyName == "IsEnabled")
			{
				SetEnabled(item, !GetEnabled(item));
				grid.Invalidate();
			}
		}

		static void Grid_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
		{
			if (e.RowIndex < 0 || e.ColumnIndex < 0)
				return;
			var grid = (DataGridView)sender;
			// If add new record row.
			if (grid.AllowUserToAddRows && e.RowIndex + 1 == grid.Rows.Count)
				return;
			var row = grid.Rows[e.RowIndex];
			if (e.RowIndex > -1 && e.ColumnIndex > -1)
			{
				var item = row.DataBoundItem;
				// If grid is virtual then...
				if (item == null)
				{
					var list = grid.DataSource as IBindingList;
					if (list != null)
						item = list[e.RowIndex];
				}
				var enabled = true;
				if (item != null)
					enabled = GetEnabled(item);
				var fore = enabled ? grid.DefaultCellStyle.ForeColor : SystemColors.ControlDark;
				var selectedBack = enabled ? grid.DefaultCellStyle.SelectionBackColor : SystemColors.ControlDark;
				// Apply style to row header.
				if (row.HeaderCell.Style.ForeColor != fore)
					row.HeaderCell.Style.ForeColor = fore;
				if (row.HeaderCell.Style.SelectionBackColor != selectedBack)
					row.HeaderCell.Style.SelectionBackColor = selectedBack;
				// Apply style to cell
				var cell = grid.Rows[e.RowIndex].Cells[e.ColumnIndex];
				if (cell.Style.ForeColor != fore)
					cell.Style.ForeColor = fore;
				if (cell.Style.SelectionBackColor != selectedBack)
					cell.Style.SelectionBackColor = selectedBack;
			}
		}

		static void Grid_SelectionChanged(object sender, EventArgs e)
		{
			// Sort issue with paint artifcats.
			var grid = (DataGridView)sender;
			grid.Invalidate();
		}

		static void SetEnabled(object item, bool enabled)
		{
			var enabledProperty = item.GetType().GetProperties().FirstOrDefault(x => x.Name == "Enabled" || x.Name == "IsEnabled");
			if (enabledProperty != null)
			{
				enabledProperty.SetValue(item, enabled, null);
			}
		}


		static bool GetEnabled(object item)
		{
			var enabledProperty = item.GetType().GetProperties().FirstOrDefault(x => x.Name == "Enabled" || x.Name == "IsEnabled");
			var enabled = enabledProperty == null ? true : (bool)enabledProperty.GetValue(item, null);
			return enabled;
		}

		static void Grid_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
		{
			// Header and cell borders must be set to "Single" style.
			var grid = (DataGridView)sender;
			var firstVisibleColumn = grid.Columns.Cast<DataGridViewColumn>().Where(x => x.Displayed).Min(x => x.Index);
			var lastVisibleColumn = grid.Columns.Cast<DataGridViewColumn>().Where(x => x.Displayed).Max(x => x.Index);
			var selected = e.RowIndex > -1 ? grid.Rows[e.RowIndex].Selected : false;
			e.Paint(e.CellBounds, DataGridViewPaintParts.All & ~DataGridViewPaintParts.Border);
			var bounds = e.CellBounds;
			var tl = new Point(bounds.X, bounds.Y);
			var tr = new Point(bounds.X + bounds.Width - 1, bounds.Y);
			var bl = new Point(bounds.X, bounds.Y + bounds.Height - 1);
			var br = new Point(bounds.X + bounds.Width - 1, bounds.Y + bounds.Height - 1);
			Color backColor;
			// If top left corner and column header then...
			if (e.RowIndex == -1)
			{
				backColor = selected
					? grid.ColumnHeadersDefaultCellStyle.SelectionBackColor
					: grid.ColumnHeadersDefaultCellStyle.BackColor;
			}
			// If row header then...
			else if (e.ColumnIndex == -1 && e.RowIndex > -1)
			{
				var row = grid.Rows[e.RowIndex];
				backColor = selected
					? row.HeaderCell.Style.SelectionBackColor
					: grid.RowHeadersDefaultCellStyle.BackColor;
			}
			// If normal cell then...
			else
			{
				var row = grid.Rows[e.RowIndex];
				var cell = row.Cells[e.ColumnIndex];
				backColor = selected
					? cell.InheritedStyle.SelectionBackColor
					: cell.InheritedStyle.BackColor;
			}
			// Cell background colour.
			var back = new Pen(backColor, 1);
			// Border colour.
			var border = new Pen(SystemColors.Control, 1);
			// Do not draw borders for selected device.
			Pen c;
			// Top
			e.Graphics.DrawLine(back, tl, tr);
			// Left (only if not first)
			c = !selected && e.ColumnIndex > firstVisibleColumn ? border : back;
			e.Graphics.DrawLine(c, bl, tl);
			// Right (always)
			c = back;
			e.Graphics.DrawLine(c, tr, br);
			// Bottom (always)
			c = border;
			e.Graphics.DrawLine(c, bl, br);
			back.Dispose();
			border.Dispose();
			e.Handled = true;
		}

		#endregion

		#region  Apply ToolStrip Border Style

		public static void ApplyBorderStyle(ToolStrip control)
		{
			control.Renderer = new ToolStripBorderlessRenderer();
		}

		/// <summary>
		/// Remove white borders from toolstrip.
		/// How to use:
		/// toolStrip.Renderer = new ToolStripBorderlessRenderer();
		/// </summary>
		public class ToolStripBorderlessRenderer : ToolStripSystemRenderer
		{
			protected override void OnRenderToolStripBorder(ToolStripRenderEventArgs e)
			{
				if (e.ToolStrip.GetType() == typeof(ToolStrip))
				{
					// skip render border
				}
				else
				{
					// do render border
					base.OnRenderToolStripBorder(e);
				}
			}

		}


		#endregion

	}
}
