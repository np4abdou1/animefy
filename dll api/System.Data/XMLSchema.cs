using System;
using System.ComponentModel;
using System.Data.Common;
using System.Globalization;
using System.Xml;

namespace System.Data
{
	// Token: 0x0200009A RID: 154
	internal class XMLSchema
	{
		// Token: 0x0600090E RID: 2318 RVA: 0x0002E867 File Offset: 0x0002CA67
		internal static TypeConverter GetConverter(Type type)
		{
			return TypeDescriptor.GetConverter(type);
		}

		// Token: 0x0600090F RID: 2319 RVA: 0x0002E870 File Offset: 0x0002CA70
		internal static void SetProperties(object instance, XmlAttributeCollection attrs)
		{
			for (int i = 0; i < attrs.Count; i++)
			{
				if (attrs[i].NamespaceURI == "urn:schemas-microsoft-com:xml-msdata")
				{
					string localName = attrs[i].LocalName;
					string value = attrs[i].Value;
					if (!(localName == "DefaultValue") && !(localName == "RemotingFormat") && (!(localName == "Expression") || !(instance is DataColumn)))
					{
						PropertyDescriptor propertyDescriptor = TypeDescriptor.GetProperties(instance)[localName];
						if (propertyDescriptor != null)
						{
							Type propertyType = propertyDescriptor.PropertyType;
							TypeConverter converter = XMLSchema.GetConverter(propertyType);
							object value2;
							if (converter.CanConvertFrom(typeof(string)))
							{
								value2 = converter.ConvertFromInvariantString(value);
							}
							else if (propertyType == typeof(Type))
							{
								value2 = DataStorage.GetType(value);
							}
							else
							{
								if (!(propertyType == typeof(CultureInfo)))
								{
									throw ExceptionBuilder.CannotConvert(value, propertyType.FullName);
								}
								value2 = new CultureInfo(value);
							}
							propertyDescriptor.SetValue(instance, value2);
						}
					}
				}
			}
		}

		// Token: 0x06000910 RID: 2320 RVA: 0x0002E995 File Offset: 0x0002CB95
		internal static bool FEqualIdentity(XmlNode node, string name, string ns)
		{
			return node != null && node.LocalName == name && node.NamespaceURI == ns;
		}

		// Token: 0x06000911 RID: 2321 RVA: 0x0002E9BC File Offset: 0x0002CBBC
		internal static bool GetBooleanAttribute(XmlElement element, string attrName, string attrNS, bool defVal)
		{
			string attribute = element.GetAttribute(attrName, attrNS);
			if (attribute == null || attribute.Length == 0)
			{
				return defVal;
			}
			if (attribute == "true" || attribute == "1")
			{
				return true;
			}
			if (attribute == "false" || attribute == "0")
			{
				return false;
			}
			throw ExceptionBuilder.InvalidAttributeValue(attrName, attribute);
		}

		// Token: 0x06000912 RID: 2322 RVA: 0x0002EA20 File Offset: 0x0002CC20
		internal static string GenUniqueColumnName(string proposedName, DataTable table)
		{
			if (table.Columns.IndexOf(proposedName) >= 0)
			{
				for (int i = 0; i <= table.Columns.Count; i++)
				{
					string text = proposedName + "_" + i.ToString(CultureInfo.InvariantCulture);
					if (table.Columns.IndexOf(text) < 0)
					{
						return text;
					}
				}
			}
			return proposedName;
		}
	}
}
