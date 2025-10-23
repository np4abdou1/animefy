using System;

namespace System.Xml.Schema
{
	// Token: 0x02000277 RID: 631
	internal class Datatype_ID : Datatype_NCName
	{
		// Token: 0x1700047B RID: 1147
		// (get) Token: 0x06001424 RID: 5156 RVA: 0x000764A9 File Offset: 0x000746A9
		public override XmlTypeCode TypeCode
		{
			get
			{
				return XmlTypeCode.Id;
			}
		}

		// Token: 0x1700047C RID: 1148
		// (get) Token: 0x06001425 RID: 5157 RVA: 0x0000C89B File Offset: 0x0000AA9B
		public override XmlTokenizedType TokenizedType
		{
			get
			{
				return XmlTokenizedType.ID;
			}
		}
	}
}
