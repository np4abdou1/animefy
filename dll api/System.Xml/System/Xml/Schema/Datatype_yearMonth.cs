using System;

namespace System.Xml.Schema
{
	// Token: 0x02000266 RID: 614
	internal class Datatype_yearMonth : Datatype_dateTimeBase
	{
		// Token: 0x1700044F RID: 1103
		// (get) Token: 0x060013D7 RID: 5079 RVA: 0x0007613A File Offset: 0x0007433A
		public override XmlTypeCode TypeCode
		{
			get
			{
				return XmlTypeCode.GYearMonth;
			}
		}

		// Token: 0x060013D8 RID: 5080 RVA: 0x0007613E File Offset: 0x0007433E
		internal Datatype_yearMonth() : base(XsdDateTimeFlags.GYearMonth)
		{
		}
	}
}
