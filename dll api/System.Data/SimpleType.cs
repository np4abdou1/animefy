using System;
using System.Collections;
using System.Data.Common;
using System.Globalization;
using System.Runtime.Serialization;
using System.Xml;
using System.Xml.Schema;

namespace System.Data
{
	// Token: 0x02000095 RID: 149
	[Serializable]
	internal sealed class SimpleType : ISerializable
	{
		// Token: 0x060008B9 RID: 2233 RVA: 0x0002BE2C File Offset: 0x0002A02C
		internal SimpleType(string baseType)
		{
			this._baseType = baseType;
		}

		// Token: 0x060008BA RID: 2234 RVA: 0x0002BEB4 File Offset: 0x0002A0B4
		internal SimpleType(XmlSchemaSimpleType node)
		{
			this._name = node.Name;
			this._ns = ((node.QualifiedName != null) ? node.QualifiedName.Namespace : "");
			this.LoadTypeValues(node);
		}

		// Token: 0x060008BB RID: 2235 RVA: 0x0002BF6D File Offset: 0x0002A16D
		void ISerializable.GetObjectData(SerializationInfo info, StreamingContext context)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060008BC RID: 2236 RVA: 0x0002BF74 File Offset: 0x0002A174
		internal void LoadTypeValues(XmlSchemaSimpleType node)
		{
			if (node.Content is XmlSchemaSimpleTypeList || node.Content is XmlSchemaSimpleTypeUnion)
			{
				throw ExceptionBuilder.SimpleTypeNotSupported();
			}
			if (node.Content is XmlSchemaSimpleTypeRestriction)
			{
				XmlSchemaSimpleTypeRestriction xmlSchemaSimpleTypeRestriction = (XmlSchemaSimpleTypeRestriction)node.Content;
				XmlSchemaSimpleType xmlSchemaSimpleType = node.BaseXmlSchemaType as XmlSchemaSimpleType;
				if (xmlSchemaSimpleType != null && xmlSchemaSimpleType.QualifiedName.Namespace != "http://www.w3.org/2001/XMLSchema")
				{
					this._baseSimpleType = new SimpleType(node.BaseXmlSchemaType as XmlSchemaSimpleType);
				}
				if (xmlSchemaSimpleTypeRestriction.BaseTypeName.Namespace == "http://www.w3.org/2001/XMLSchema")
				{
					this._baseType = xmlSchemaSimpleTypeRestriction.BaseTypeName.Name;
				}
				else
				{
					this._baseType = xmlSchemaSimpleTypeRestriction.BaseTypeName.ToString();
				}
				if (this._baseSimpleType != null && this._baseSimpleType.Name != null && this._baseSimpleType.Name.Length > 0)
				{
					this._xmlBaseType = this._baseSimpleType.XmlBaseType;
				}
				else
				{
					this._xmlBaseType = xmlSchemaSimpleTypeRestriction.BaseTypeName;
				}
				if (this._baseType == null || this._baseType.Length == 0)
				{
					this._baseType = xmlSchemaSimpleTypeRestriction.BaseType.Name;
					this._xmlBaseType = null;
				}
				if (this._baseType == "NOTATION")
				{
					this._baseType = "string";
				}
				foreach (XmlSchemaObject xmlSchemaObject in xmlSchemaSimpleTypeRestriction.Facets)
				{
					XmlSchemaFacet xmlSchemaFacet = (XmlSchemaFacet)xmlSchemaObject;
					if (xmlSchemaFacet is XmlSchemaLengthFacet)
					{
						this._length = Convert.ToInt32(xmlSchemaFacet.Value, null);
					}
					if (xmlSchemaFacet is XmlSchemaMinLengthFacet)
					{
						this._minLength = Convert.ToInt32(xmlSchemaFacet.Value, null);
					}
					if (xmlSchemaFacet is XmlSchemaMaxLengthFacet)
					{
						this._maxLength = Convert.ToInt32(xmlSchemaFacet.Value, null);
					}
					if (xmlSchemaFacet is XmlSchemaPatternFacet)
					{
						this._pattern = xmlSchemaFacet.Value;
					}
					if (xmlSchemaFacet is XmlSchemaEnumerationFacet)
					{
						this._enumeration = ((!string.IsNullOrEmpty(this._enumeration)) ? (this._enumeration + " " + xmlSchemaFacet.Value) : xmlSchemaFacet.Value);
					}
					if (xmlSchemaFacet is XmlSchemaMinExclusiveFacet)
					{
						this._minExclusive = xmlSchemaFacet.Value;
					}
					if (xmlSchemaFacet is XmlSchemaMinInclusiveFacet)
					{
						this._minInclusive = xmlSchemaFacet.Value;
					}
					if (xmlSchemaFacet is XmlSchemaMaxExclusiveFacet)
					{
						this._maxExclusive = xmlSchemaFacet.Value;
					}
					if (xmlSchemaFacet is XmlSchemaMaxInclusiveFacet)
					{
						this._maxInclusive = xmlSchemaFacet.Value;
					}
				}
			}
			string msdataAttribute = XSDSchema.GetMsdataAttribute(node, "targetNamespace");
			if (msdataAttribute != null)
			{
				this._ns = msdataAttribute;
			}
		}

		// Token: 0x060008BD RID: 2237 RVA: 0x0002C234 File Offset: 0x0002A434
		internal bool IsPlainString()
		{
			return XSDSchema.QualifiedName(this._baseType) == XSDSchema.QualifiedName("string") && string.IsNullOrEmpty(this._name) && this._length == -1 && this._minLength == -1 && this._maxLength == -1 && string.IsNullOrEmpty(this._pattern) && string.IsNullOrEmpty(this._maxExclusive) && string.IsNullOrEmpty(this._maxInclusive) && string.IsNullOrEmpty(this._minExclusive) && string.IsNullOrEmpty(this._minInclusive) && string.IsNullOrEmpty(this._enumeration);
		}

		// Token: 0x17000147 RID: 327
		// (get) Token: 0x060008BE RID: 2238 RVA: 0x0002C2D3 File Offset: 0x0002A4D3
		internal string BaseType
		{
			get
			{
				return this._baseType;
			}
		}

		// Token: 0x17000148 RID: 328
		// (get) Token: 0x060008BF RID: 2239 RVA: 0x0002C2DB File Offset: 0x0002A4DB
		internal XmlQualifiedName XmlBaseType
		{
			get
			{
				return this._xmlBaseType;
			}
		}

		// Token: 0x17000149 RID: 329
		// (get) Token: 0x060008C0 RID: 2240 RVA: 0x0002C2E3 File Offset: 0x0002A4E3
		internal string Name
		{
			get
			{
				return this._name;
			}
		}

		// Token: 0x1700014A RID: 330
		// (get) Token: 0x060008C1 RID: 2241 RVA: 0x0002C2EB File Offset: 0x0002A4EB
		internal string Namespace
		{
			get
			{
				return this._ns;
			}
		}

		// Token: 0x1700014B RID: 331
		// (get) Token: 0x060008C2 RID: 2242 RVA: 0x0002C2F3 File Offset: 0x0002A4F3
		internal int Length
		{
			get
			{
				return this._length;
			}
		}

		// Token: 0x1700014C RID: 332
		// (get) Token: 0x060008C3 RID: 2243 RVA: 0x0002C2FB File Offset: 0x0002A4FB
		// (set) Token: 0x060008C4 RID: 2244 RVA: 0x0002C303 File Offset: 0x0002A503
		internal int MaxLength
		{
			get
			{
				return this._maxLength;
			}
			set
			{
				this._maxLength = value;
			}
		}

		// Token: 0x1700014D RID: 333
		// (get) Token: 0x060008C5 RID: 2245 RVA: 0x0002C30C File Offset: 0x0002A50C
		internal SimpleType BaseSimpleType
		{
			get
			{
				return this._baseSimpleType;
			}
		}

		// Token: 0x1700014E RID: 334
		// (get) Token: 0x060008C6 RID: 2246 RVA: 0x0002C314 File Offset: 0x0002A514
		public string SimpleTypeQualifiedName
		{
			get
			{
				if (this._ns.Length == 0)
				{
					return this._name;
				}
				return this._ns + ":" + this._name;
			}
		}

		// Token: 0x060008C7 RID: 2247 RVA: 0x0002C340 File Offset: 0x0002A540
		internal string QualifiedName(string name)
		{
			if (name.IndexOf(':') == -1)
			{
				return "xs:" + name;
			}
			return name;
		}

		// Token: 0x060008C8 RID: 2248 RVA: 0x0002C35C File Offset: 0x0002A55C
		internal XmlNode ToNode(XmlDocument dc, Hashtable prefixes, bool inRemoting)
		{
			XmlElement xmlElement = dc.CreateElement("xs", "simpleType", "http://www.w3.org/2001/XMLSchema");
			if (this._name != null && this._name.Length != 0)
			{
				xmlElement.SetAttribute("name", this._name);
				if (inRemoting)
				{
					xmlElement.SetAttribute("targetNamespace", "urn:schemas-microsoft-com:xml-msdata", this.Namespace);
				}
			}
			XmlElement xmlElement2 = dc.CreateElement("xs", "restriction", "http://www.w3.org/2001/XMLSchema");
			if (!inRemoting)
			{
				if (this._baseSimpleType != null)
				{
					if (this._baseSimpleType.Namespace != null && this._baseSimpleType.Namespace.Length > 0)
					{
						string text = (prefixes != null) ? ((string)prefixes[this._baseSimpleType.Namespace]) : null;
						if (text != null)
						{
							xmlElement2.SetAttribute("base", text + ":" + this._baseSimpleType.Name);
						}
						else
						{
							xmlElement2.SetAttribute("base", this._baseSimpleType.Name);
						}
					}
					else
					{
						xmlElement2.SetAttribute("base", this._baseSimpleType.Name);
					}
				}
				else
				{
					xmlElement2.SetAttribute("base", this.QualifiedName(this._baseType));
				}
			}
			else
			{
				xmlElement2.SetAttribute("base", (this._baseSimpleType != null) ? this._baseSimpleType.Name : this.QualifiedName(this._baseType));
			}
			if (this._length >= 0)
			{
				XmlElement xmlElement3 = dc.CreateElement("xs", "length", "http://www.w3.org/2001/XMLSchema");
				xmlElement3.SetAttribute("value", this._length.ToString(CultureInfo.InvariantCulture));
				xmlElement2.AppendChild(xmlElement3);
			}
			if (this._maxLength >= 0)
			{
				XmlElement xmlElement3 = dc.CreateElement("xs", "maxLength", "http://www.w3.org/2001/XMLSchema");
				xmlElement3.SetAttribute("value", this._maxLength.ToString(CultureInfo.InvariantCulture));
				xmlElement2.AppendChild(xmlElement3);
			}
			xmlElement.AppendChild(xmlElement2);
			return xmlElement;
		}

		// Token: 0x060008C9 RID: 2249 RVA: 0x0002C54B File Offset: 0x0002A74B
		internal static SimpleType CreateEnumeratedType(string values)
		{
			return new SimpleType("string")
			{
				_enumeration = values
			};
		}

		// Token: 0x060008CA RID: 2250 RVA: 0x0002C55E File Offset: 0x0002A75E
		internal static SimpleType CreateByteArrayType(string encoding)
		{
			return new SimpleType("base64Binary");
		}

		// Token: 0x060008CB RID: 2251 RVA: 0x0002C56A File Offset: 0x0002A76A
		internal static SimpleType CreateLimitedStringType(int length)
		{
			return new SimpleType("string")
			{
				_maxLength = length
			};
		}

		// Token: 0x060008CC RID: 2252 RVA: 0x0002C57D File Offset: 0x0002A77D
		internal static SimpleType CreateSimpleType(StorageType typeCode, Type type)
		{
			if (typeCode == StorageType.Char && type == typeof(char))
			{
				return new SimpleType("string")
				{
					_length = 1
				};
			}
			return null;
		}

		// Token: 0x060008CD RID: 2253 RVA: 0x0002C5A8 File Offset: 0x0002A7A8
		internal string HasConflictingDefinition(SimpleType otherSimpleType)
		{
			if (otherSimpleType == null)
			{
				return "otherSimpleType";
			}
			if (this.MaxLength != otherSimpleType.MaxLength)
			{
				return "MaxLength";
			}
			if (!string.Equals(this.BaseType, otherSimpleType.BaseType, StringComparison.Ordinal))
			{
				return "BaseType";
			}
			if (this.BaseSimpleType != null && otherSimpleType.BaseSimpleType != null && this.BaseSimpleType.HasConflictingDefinition(otherSimpleType.BaseSimpleType).Length != 0)
			{
				return "BaseSimpleType";
			}
			return string.Empty;
		}

		// Token: 0x060008CE RID: 2254 RVA: 0x0002C620 File Offset: 0x0002A820
		internal bool CanHaveMaxLength()
		{
			SimpleType simpleType = this;
			while (simpleType.BaseSimpleType != null)
			{
				simpleType = simpleType.BaseSimpleType;
			}
			return string.Equals(simpleType.BaseType, "string", StringComparison.OrdinalIgnoreCase);
		}

		// Token: 0x060008CF RID: 2255 RVA: 0x0002C654 File Offset: 0x0002A854
		internal void ConvertToAnnonymousSimpleType()
		{
			this._name = null;
			this._ns = string.Empty;
			SimpleType simpleType = this;
			while (simpleType._baseSimpleType != null)
			{
				simpleType = simpleType._baseSimpleType;
			}
			this._baseType = simpleType._baseType;
			this._baseSimpleType = simpleType._baseSimpleType;
			this._xmlBaseType = simpleType._xmlBaseType;
		}

		// Token: 0x040002F3 RID: 755
		private string _baseType;

		// Token: 0x040002F4 RID: 756
		private SimpleType _baseSimpleType;

		// Token: 0x040002F5 RID: 757
		private XmlQualifiedName _xmlBaseType;

		// Token: 0x040002F6 RID: 758
		private string _name = string.Empty;

		// Token: 0x040002F7 RID: 759
		private int _length = -1;

		// Token: 0x040002F8 RID: 760
		private int _minLength = -1;

		// Token: 0x040002F9 RID: 761
		private int _maxLength = -1;

		// Token: 0x040002FA RID: 762
		private string _pattern = string.Empty;

		// Token: 0x040002FB RID: 763
		private string _ns = string.Empty;

		// Token: 0x040002FC RID: 764
		private string _maxExclusive = string.Empty;

		// Token: 0x040002FD RID: 765
		private string _maxInclusive = string.Empty;

		// Token: 0x040002FE RID: 766
		private string _minExclusive = string.Empty;

		// Token: 0x040002FF RID: 767
		private string _minInclusive = string.Empty;

		// Token: 0x04000300 RID: 768
		internal string _enumeration = string.Empty;
	}
}
