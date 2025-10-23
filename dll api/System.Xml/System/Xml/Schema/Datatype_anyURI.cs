using System;

namespace System.Xml.Schema
{
	// Token: 0x0200026D RID: 621
	internal class Datatype_anyURI : Datatype_anySimpleType
	{
		// Token: 0x060013F7 RID: 5111 RVA: 0x00075DF8 File Offset: 0x00073FF8
		internal override XmlValueConverter CreateValueConverter(XmlSchemaType schemaType)
		{
			return XmlMiscConverter.Create(schemaType);
		}

		// Token: 0x17000460 RID: 1120
		// (get) Token: 0x060013F8 RID: 5112 RVA: 0x00075B14 File Offset: 0x00073D14
		internal override FacetsChecker FacetsChecker
		{
			get
			{
				return DatatypeImplementation.stringFacetsChecker;
			}
		}

		// Token: 0x17000461 RID: 1121
		// (get) Token: 0x060013F9 RID: 5113 RVA: 0x000762D0 File Offset: 0x000744D0
		public override XmlTypeCode TypeCode
		{
			get
			{
				return XmlTypeCode.AnyUri;
			}
		}

		// Token: 0x17000462 RID: 1122
		// (get) Token: 0x060013FA RID: 5114 RVA: 0x000762D4 File Offset: 0x000744D4
		public override Type ValueType
		{
			get
			{
				return Datatype_anyURI.atomicValueType;
			}
		}

		// Token: 0x17000463 RID: 1123
		// (get) Token: 0x060013FB RID: 5115 RVA: 0x0000C89B File Offset: 0x0000AA9B
		internal override bool HasValueFacets
		{
			get
			{
				return true;
			}
		}

		// Token: 0x17000464 RID: 1124
		// (get) Token: 0x060013FC RID: 5116 RVA: 0x000762DB File Offset: 0x000744DB
		internal override Type ListValueType
		{
			get
			{
				return Datatype_anyURI.listValueType;
			}
		}

		// Token: 0x17000465 RID: 1125
		// (get) Token: 0x060013FD RID: 5117 RVA: 0x000466F0 File Offset: 0x000448F0
		internal override XmlSchemaWhiteSpace BuiltInWhitespaceFacet
		{
			get
			{
				return XmlSchemaWhiteSpace.Collapse;
			}
		}

		// Token: 0x17000466 RID: 1126
		// (get) Token: 0x060013FE RID: 5118 RVA: 0x000754C5 File Offset: 0x000736C5
		internal override RestrictionFlags ValidRestrictionFlags
		{
			get
			{
				return RestrictionFlags.Length | RestrictionFlags.MinLength | RestrictionFlags.MaxLength | RestrictionFlags.Pattern | RestrictionFlags.Enumeration | RestrictionFlags.WhiteSpace;
			}
		}

		// Token: 0x060013FF RID: 5119 RVA: 0x000762E2 File Offset: 0x000744E2
		internal override int Compare(object value1, object value2)
		{
			if (!((Uri)value1).Equals((Uri)value2))
			{
				return -1;
			}
			return 0;
		}

		// Token: 0x06001400 RID: 5120 RVA: 0x000762FC File Offset: 0x000744FC
		internal override Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, out object typedValue)
		{
			typedValue = null;
			Exception ex = DatatypeImplementation.stringFacetsChecker.CheckLexicalFacets(ref s, this);
			if (ex == null)
			{
				Uri uri;
				ex = XmlConvert.TryToUri(s, out uri);
				if (ex == null)
				{
					string originalString = uri.OriginalString;
					ex = ((StringFacetsChecker)DatatypeImplementation.stringFacetsChecker).CheckValueFacets(originalString, this, false);
					if (ex == null)
					{
						typedValue = uri;
						return null;
					}
				}
			}
			return ex;
		}

		// Token: 0x04000D65 RID: 3429
		private static readonly Type atomicValueType = typeof(Uri);

		// Token: 0x04000D66 RID: 3430
		private static readonly Type listValueType = typeof(Uri[]);
	}
}
