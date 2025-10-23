using System;

namespace System.Xml.Schema
{
	// Token: 0x02000279 RID: 633
	internal class Datatype_ENTITY : Datatype_NCName
	{
		// Token: 0x1700047F RID: 1151
		// (get) Token: 0x0600142A RID: 5162 RVA: 0x000764B9 File Offset: 0x000746B9
		public override XmlTypeCode TypeCode
		{
			get
			{
				return XmlTypeCode.Entity;
			}
		}

		// Token: 0x17000480 RID: 1152
		// (get) Token: 0x0600142B RID: 5163 RVA: 0x00046FFF File Offset: 0x000451FF
		public override XmlTokenizedType TokenizedType
		{
			get
			{
				return XmlTokenizedType.ENTITY;
			}
		}
	}
}
