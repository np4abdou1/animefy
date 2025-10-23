using System;

namespace System.Xml.Schema
{
	// Token: 0x02000256 RID: 598
	internal class Datatype_string : Datatype_anySimpleType
	{
		// Token: 0x0600137E RID: 4990 RVA: 0x00075B0C File Offset: 0x00073D0C
		internal override XmlValueConverter CreateValueConverter(XmlSchemaType schemaType)
		{
			return XmlStringConverter.Create(schemaType);
		}

		// Token: 0x17000422 RID: 1058
		// (get) Token: 0x0600137F RID: 4991 RVA: 0x0000A216 File Offset: 0x00008416
		internal override XmlSchemaWhiteSpace BuiltInWhitespaceFacet
		{
			get
			{
				return XmlSchemaWhiteSpace.Preserve;
			}
		}

		// Token: 0x17000423 RID: 1059
		// (get) Token: 0x06001380 RID: 4992 RVA: 0x00075B14 File Offset: 0x00073D14
		internal override FacetsChecker FacetsChecker
		{
			get
			{
				return DatatypeImplementation.stringFacetsChecker;
			}
		}

		// Token: 0x17000424 RID: 1060
		// (get) Token: 0x06001381 RID: 4993 RVA: 0x00008318 File Offset: 0x00006518
		public override XmlTypeCode TypeCode
		{
			get
			{
				return XmlTypeCode.String;
			}
		}

		// Token: 0x17000425 RID: 1061
		// (get) Token: 0x06001382 RID: 4994 RVA: 0x0000A216 File Offset: 0x00008416
		public override XmlTokenizedType TokenizedType
		{
			get
			{
				return XmlTokenizedType.CDATA;
			}
		}

		// Token: 0x17000426 RID: 1062
		// (get) Token: 0x06001383 RID: 4995 RVA: 0x000754C5 File Offset: 0x000736C5
		internal override RestrictionFlags ValidRestrictionFlags
		{
			get
			{
				return RestrictionFlags.Length | RestrictionFlags.MinLength | RestrictionFlags.MaxLength | RestrictionFlags.Pattern | RestrictionFlags.Enumeration | RestrictionFlags.WhiteSpace;
			}
		}

		// Token: 0x06001384 RID: 4996 RVA: 0x00075B1C File Offset: 0x00073D1C
		internal override Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, out object typedValue)
		{
			typedValue = null;
			Exception ex = DatatypeImplementation.stringFacetsChecker.CheckLexicalFacets(ref s, this);
			if (ex == null)
			{
				ex = DatatypeImplementation.stringFacetsChecker.CheckValueFacets(s, this);
				if (ex == null)
				{
					typedValue = s;
					return null;
				}
			}
			return ex;
		}
	}
}
