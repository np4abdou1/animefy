using System;

namespace System.Xml.Schema
{
	// Token: 0x02000254 RID: 596
	internal class Datatype_anyAtomicType : Datatype_anySimpleType
	{
		// Token: 0x06001376 RID: 4982 RVA: 0x00075AF5 File Offset: 0x00073CF5
		internal override XmlValueConverter CreateValueConverter(XmlSchemaType schemaType)
		{
			return XmlAnyConverter.AnyAtomic;
		}

		// Token: 0x1700041E RID: 1054
		// (get) Token: 0x06001377 RID: 4983 RVA: 0x0000A216 File Offset: 0x00008416
		internal override XmlSchemaWhiteSpace BuiltInWhitespaceFacet
		{
			get
			{
				return XmlSchemaWhiteSpace.Preserve;
			}
		}

		// Token: 0x1700041F RID: 1055
		// (get) Token: 0x06001378 RID: 4984 RVA: 0x00048B41 File Offset: 0x00046D41
		public override XmlTypeCode TypeCode
		{
			get
			{
				return XmlTypeCode.AnyAtomicType;
			}
		}
	}
}
