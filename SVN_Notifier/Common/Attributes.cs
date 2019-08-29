using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;

namespace CHD.SVN_Notifier
{
	public class Attributes
	{
		#region Description Attribute

		/// <summary>Cache data for speed.</summary>
		static Dictionary<object, string> Descriptions = new Dictionary<object, string>();
		static object DescriptionsLock = new object();

		/// <summary>
		/// Get DescriptionAttribute value from object or enumeration value.
		/// </summary>
		/// <param name="o">Enumeration value or object</param>
		/// <returns>Description, class name, or enumeration property name.</returns>
		public static string GetDescription(object o)
		{
			if (o == null)
				return null;
			lock (DescriptionsLock)
			{
				var type = o.GetType();
				// If enumeration then use value as a key, otherwise use type string.
				var key = type.IsEnum
					? o
					: type.ToString();
				if (Descriptions.ContainsKey(key))
					return Descriptions[key];
				// Set default value.
				var value = type.IsEnum
					? string.Format("{0}", o)
					: type.FullName;
				// If enumeration then specify to get attribute from a field, otherwise from type.
				var ap = type.IsEnum
					? (ICustomAttributeProvider)type.GetField(Enum.GetName(type, o))
					: type;
				if (ap != null)
				{
					var attributes = ap.GetCustomAttributes(typeof(DescriptionAttribute), !type.IsEnum);
					if (attributes.Length > 0)
					{
						var da = (DescriptionAttribute)attributes[0];
						if (da != null)
							value = da.Description;
					}
				}
				Descriptions.Add(key, value);
				return value;
			}
		}

		#endregion


	}
}
