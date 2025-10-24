using System;

namespace System.Xml.Schema
{
	// Token: 0x0200026E RID: 622
	internal class Datatype_QName : Datatype_anySimpleType
	{
		// Token: 0x06001403 RID: 5123 RVA: 0x00075DF8 File Offset: 0x00073FF8
		internal override XmlValueConverter CreateValueConverter(XmlSchemaType schemaType)
		{
			return XmlMiscConverter.Create(schemaType);
		}

		// Token: 0x17000467 RID: 1127
		// (get) Token: 0x06001404 RID: 5124 RVA: 0x0007636E File Offset: 0x0007456E
		internal override FacetsChecker FacetsChecker
		{
			get
			{
				return DatatypeImplementation.qnameFacetsChecker;
			}
		}

		// Token: 0x17000468 RID: 1128
		// (get) Token: 0x06001405 RID: 5125 RVA: 0x00076375 File Offset: 0x00074575
		public override XmlTypeCode TypeCode
		{
			get
			{
				return XmlTypeCode.QName;
			}
		}

		// Token: 0x17000469 RID: 1129
		// (get) Token: 0x06001406 RID: 5126 RVA: 0x00048B41 File Offset: 0x00046D41
		public override XmlTokenizedType TokenizedType
		{
			get
			{
				return XmlTokenizedType.QName;
			}
		}

		// Token: 0x1700046A RID: 1130
		// (get) Token: 0x06001407 RID: 5127 RVA: 0x000754C5 File Offset: 0x000736C5
		internal override RestrictionFlags ValidRestrictionFlags
		{
			get
			{
				return RestrictionFlags.Length | RestrictionFlags.MinLength | RestrictionFlags.MaxLength | RestrictionFlags.Pattern | RestrictionFlags.Enumeration | RestrictionFlags.WhiteSpace;
			}
		}

		// Token: 0x1700046B RID: 1131
		// (get) Token: 0x06001408 RID: 5128 RVA: 0x00076379 File Offset: 0x00074579
		public override Type ValueType
		{
			get
			{
				return Datatype_QName.atomicValueType;
			}
		}

		// Token: 0x1700046C RID: 1132
		// (get) Token: 0x06001409 RID: 5129 RVA: 0x00076380 File Offset: 0x00074580
		internal override Type ListValueType
		{
			get
			{
				return Datatype_QName.listValueType;
			}
		}

		// Token: 0x1700046D RID: 1133
		// (get) Token: 0x0600140A RID: 5130 RVA: 0x000466F0 File Offset: 0x000448F0
		internal override XmlSchemaWhiteSpace BuiltInWhitespaceFacet
		{
			get
			{
				return XmlSchemaWhiteSpace.Collapse;
			}
		}

		// Token: 0x0600140B RID: 5131 RVA: 0x00076388 File Offset: 0x00074588
		internal override Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, out object typedValue)
		{
			typedValue = null;
			if (s == null || s.Length == 0)
			{
				return new XmlSchemaException("The attribute value cannot be empty.", string.Empty);
			}
			Exception ex = DatatypeImplementation.qnameFacetsChecker.CheckLexicalFacets(ref s, this);
			if (ex == null)
			{
				XmlQualifiedName xmlQualifiedName = null;
				try
				{
					string text;
					xmlQualifiedName = XmlQualifiedName.Parse(s, nsmgr, out text);
				}
				catch (ArgumentException ex)
				{
					return ex;
				}
				catch (XmlException ex)
				{
					return ex;
				}
				ex = DatatypeImplementation.qnameFacetsChecker.CheckValueFacets(xmlQualifiedName, this);
				if (ex == null)
				{
					typedValue = xmlQualifiedName;
					return null;
				}
			}
			return ex;
		}

		// Token: 0x04000D67 RID: 3431
		private static readonly Type atomicValueType = typeof(XmlQualifiedName);

		// Token: 0x04000D68 RID: 3432
		private static readonly Type listValueType = typeof(XmlQualifiedName[]);
	}
}
