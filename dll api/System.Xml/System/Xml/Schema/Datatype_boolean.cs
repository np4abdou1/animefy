using System;

namespace System.Xml.Schema
{
	// Token: 0x02000257 RID: 599
	internal class Datatype_boolean : Datatype_anySimpleType
	{
		// Token: 0x06001386 RID: 4998 RVA: 0x00075B55 File Offset: 0x00073D55
		internal override XmlValueConverter CreateValueConverter(XmlSchemaType schemaType)
		{
			return XmlBooleanConverter.Create(schemaType);
		}

		// Token: 0x17000427 RID: 1063
		// (get) Token: 0x06001387 RID: 4999 RVA: 0x00074FE6 File Offset: 0x000731E6
		internal override FacetsChecker FacetsChecker
		{
			get
			{
				return DatatypeImplementation.miscFacetsChecker;
			}
		}

		// Token: 0x17000428 RID: 1064
		// (get) Token: 0x06001388 RID: 5000 RVA: 0x0004E9DA File Offset: 0x0004CBDA
		public override XmlTypeCode TypeCode
		{
			get
			{
				return XmlTypeCode.Boolean;
			}
		}

		// Token: 0x17000429 RID: 1065
		// (get) Token: 0x06001389 RID: 5001 RVA: 0x00075B5D File Offset: 0x00073D5D
		public override Type ValueType
		{
			get
			{
				return Datatype_boolean.atomicValueType;
			}
		}

		// Token: 0x1700042A RID: 1066
		// (get) Token: 0x0600138A RID: 5002 RVA: 0x00075B64 File Offset: 0x00073D64
		internal override Type ListValueType
		{
			get
			{
				return Datatype_boolean.listValueType;
			}
		}

		// Token: 0x1700042B RID: 1067
		// (get) Token: 0x0600138B RID: 5003 RVA: 0x000466F0 File Offset: 0x000448F0
		internal override XmlSchemaWhiteSpace BuiltInWhitespaceFacet
		{
			get
			{
				return XmlSchemaWhiteSpace.Collapse;
			}
		}

		// Token: 0x1700042C RID: 1068
		// (get) Token: 0x0600138C RID: 5004 RVA: 0x00075B6B File Offset: 0x00073D6B
		internal override RestrictionFlags ValidRestrictionFlags
		{
			get
			{
				return RestrictionFlags.Pattern | RestrictionFlags.WhiteSpace;
			}
		}

		// Token: 0x0600138D RID: 5005 RVA: 0x00075B70 File Offset: 0x00073D70
		internal override int Compare(object value1, object value2)
		{
			return ((bool)value1).CompareTo(value2);
		}

		// Token: 0x0600138E RID: 5006 RVA: 0x00075B8C File Offset: 0x00073D8C
		internal override Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, out object typedValue)
		{
			typedValue = null;
			Exception ex = DatatypeImplementation.miscFacetsChecker.CheckLexicalFacets(ref s, this);
			if (ex == null)
			{
				bool flag;
				ex = XmlConvert.TryToBoolean(s, out flag);
				if (ex == null)
				{
					typedValue = flag;
					return null;
				}
			}
			return ex;
		}

		// Token: 0x04000D53 RID: 3411
		private static readonly Type atomicValueType = typeof(bool);

		// Token: 0x04000D54 RID: 3412
		private static readonly Type listValueType = typeof(bool[]);
	}
}
