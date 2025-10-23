using System;

namespace System.Xml.Schema
{
	// Token: 0x02000253 RID: 595
	internal class Datatype_anySimpleType : DatatypeImplementation
	{
		// Token: 0x0600136A RID: 4970 RVA: 0x00075A98 File Offset: 0x00073C98
		internal override XmlValueConverter CreateValueConverter(XmlSchemaType schemaType)
		{
			return XmlUntypedConverter.Untyped;
		}

		// Token: 0x17000417 RID: 1047
		// (get) Token: 0x0600136B RID: 4971 RVA: 0x00074FE6 File Offset: 0x000731E6
		internal override FacetsChecker FacetsChecker
		{
			get
			{
				return DatatypeImplementation.miscFacetsChecker;
			}
		}

		// Token: 0x17000418 RID: 1048
		// (get) Token: 0x0600136C RID: 4972 RVA: 0x00075A9F File Offset: 0x00073C9F
		public override Type ValueType
		{
			get
			{
				return Datatype_anySimpleType.atomicValueType;
			}
		}

		// Token: 0x17000419 RID: 1049
		// (get) Token: 0x0600136D RID: 4973 RVA: 0x00048B41 File Offset: 0x00046D41
		public override XmlTypeCode TypeCode
		{
			get
			{
				return XmlTypeCode.AnyAtomicType;
			}
		}

		// Token: 0x1700041A RID: 1050
		// (get) Token: 0x0600136E RID: 4974 RVA: 0x00075AA6 File Offset: 0x00073CA6
		internal override Type ListValueType
		{
			get
			{
				return Datatype_anySimpleType.listValueType;
			}
		}

		// Token: 0x1700041B RID: 1051
		// (get) Token: 0x0600136F RID: 4975 RVA: 0x00008318 File Offset: 0x00006518
		public override XmlTokenizedType TokenizedType
		{
			get
			{
				return XmlTokenizedType.None;
			}
		}

		// Token: 0x1700041C RID: 1052
		// (get) Token: 0x06001370 RID: 4976 RVA: 0x0000A216 File Offset: 0x00008416
		internal override RestrictionFlags ValidRestrictionFlags
		{
			get
			{
				return (RestrictionFlags)0;
			}
		}

		// Token: 0x1700041D RID: 1053
		// (get) Token: 0x06001371 RID: 4977 RVA: 0x000466F0 File Offset: 0x000448F0
		internal override XmlSchemaWhiteSpace BuiltInWhitespaceFacet
		{
			get
			{
				return XmlSchemaWhiteSpace.Collapse;
			}
		}

		// Token: 0x06001372 RID: 4978 RVA: 0x00075AAD File Offset: 0x00073CAD
		internal override int Compare(object value1, object value2)
		{
			return string.Compare(value1.ToString(), value2.ToString(), StringComparison.Ordinal);
		}

		// Token: 0x06001373 RID: 4979 RVA: 0x00075AC1 File Offset: 0x00073CC1
		internal override Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, out object typedValue)
		{
			typedValue = XmlComplianceUtil.NonCDataNormalize(s);
			return null;
		}

		// Token: 0x04000D51 RID: 3409
		private static readonly Type atomicValueType = typeof(string);

		// Token: 0x04000D52 RID: 3410
		private static readonly Type listValueType = typeof(string[]);
	}
}
