using System;

namespace System.Xml.Schema
{
	// Token: 0x0200024B RID: 587
	internal class XsdSimpleValue
	{
		// Token: 0x0600131B RID: 4891 RVA: 0x00073DD4 File Offset: 0x00071FD4
		public XsdSimpleValue(XmlSchemaSimpleType st, object value)
		{
			this.xmlType = st;
			this.typedValue = value;
		}

		// Token: 0x170003F8 RID: 1016
		// (get) Token: 0x0600131C RID: 4892 RVA: 0x00073DEA File Offset: 0x00071FEA
		public XmlSchemaSimpleType XmlType
		{
			get
			{
				return this.xmlType;
			}
		}

		// Token: 0x170003F9 RID: 1017
		// (get) Token: 0x0600131D RID: 4893 RVA: 0x00073DF2 File Offset: 0x00071FF2
		public object TypedValue
		{
			get
			{
				return this.typedValue;
			}
		}

		// Token: 0x04000CCD RID: 3277
		private XmlSchemaSimpleType xmlType;

		// Token: 0x04000CCE RID: 3278
		private object typedValue;
	}
}
