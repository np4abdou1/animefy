using System;

namespace System.Xml.Schema
{
	// Token: 0x02000255 RID: 597
	internal class Datatype_untypedAtomicType : Datatype_anyAtomicType
	{
		// Token: 0x0600137A RID: 4986 RVA: 0x00075A98 File Offset: 0x00073C98
		internal override XmlValueConverter CreateValueConverter(XmlSchemaType schemaType)
		{
			return XmlUntypedConverter.Untyped;
		}

		// Token: 0x17000420 RID: 1056
		// (get) Token: 0x0600137B RID: 4987 RVA: 0x0000A216 File Offset: 0x00008416
		internal override XmlSchemaWhiteSpace BuiltInWhitespaceFacet
		{
			get
			{
				return XmlSchemaWhiteSpace.Preserve;
			}
		}

		// Token: 0x17000421 RID: 1057
		// (get) Token: 0x0600137C RID: 4988 RVA: 0x00048973 File Offset: 0x00046B73
		public override XmlTypeCode TypeCode
		{
			get
			{
				return XmlTypeCode.UntypedAtomic;
			}
		}
	}
}
