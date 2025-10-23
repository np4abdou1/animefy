using System;

namespace System.Xml.Schema
{
	// Token: 0x02000278 RID: 632
	internal class Datatype_IDREF : Datatype_NCName
	{
		// Token: 0x1700047D RID: 1149
		// (get) Token: 0x06001427 RID: 5159 RVA: 0x000764B5 File Offset: 0x000746B5
		public override XmlTypeCode TypeCode
		{
			get
			{
				return XmlTypeCode.Idref;
			}
		}

		// Token: 0x1700047E RID: 1150
		// (get) Token: 0x06001428 RID: 5160 RVA: 0x000466F0 File Offset: 0x000448F0
		public override XmlTokenizedType TokenizedType
		{
			get
			{
				return XmlTokenizedType.IDREF;
			}
		}
	}
}
