using System;

namespace System.Xml.Schema
{
	// Token: 0x02000274 RID: 628
	internal class Datatype_NMTOKEN : Datatype_token
	{
		// Token: 0x17000477 RID: 1143
		// (get) Token: 0x0600141C RID: 5148 RVA: 0x00015244 File Offset: 0x00013444
		public override XmlTypeCode TypeCode
		{
			get
			{
				return XmlTypeCode.NmToken;
			}
		}

		// Token: 0x17000478 RID: 1144
		// (get) Token: 0x0600141D RID: 5149 RVA: 0x00049468 File Offset: 0x00047668
		public override XmlTokenizedType TokenizedType
		{
			get
			{
				return XmlTokenizedType.NMTOKEN;
			}
		}
	}
}
