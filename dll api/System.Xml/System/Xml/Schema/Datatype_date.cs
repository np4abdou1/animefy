using System;

namespace System.Xml.Schema
{
	// Token: 0x02000265 RID: 613
	internal class Datatype_date : Datatype_dateTimeBase
	{
		// Token: 0x1700044E RID: 1102
		// (get) Token: 0x060013D5 RID: 5077 RVA: 0x0007612D File Offset: 0x0007432D
		public override XmlTypeCode TypeCode
		{
			get
			{
				return XmlTypeCode.Date;
			}
		}

		// Token: 0x060013D6 RID: 5078 RVA: 0x00076131 File Offset: 0x00074331
		internal Datatype_date() : base(XsdDateTimeFlags.Date)
		{
		}
	}
}
