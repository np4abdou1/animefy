using System;

namespace System.Xml.Schema
{
	// Token: 0x02000275 RID: 629
	internal class Datatype_Name : Datatype_token
	{
		// Token: 0x17000479 RID: 1145
		// (get) Token: 0x0600141F RID: 5151 RVA: 0x00076458 File Offset: 0x00074658
		public override XmlTypeCode TypeCode
		{
			get
			{
				return XmlTypeCode.Name;
			}
		}
	}
}
