using System;

namespace System.Xml.Schema
{
	// Token: 0x02000268 RID: 616
	internal class Datatype_monthDay : Datatype_dateTimeBase
	{
		// Token: 0x17000451 RID: 1105
		// (get) Token: 0x060013DB RID: 5083 RVA: 0x00076155 File Offset: 0x00074355
		public override XmlTypeCode TypeCode
		{
			get
			{
				return XmlTypeCode.GMonthDay;
			}
		}

		// Token: 0x060013DC RID: 5084 RVA: 0x00076159 File Offset: 0x00074359
		internal Datatype_monthDay() : base(XsdDateTimeFlags.GMonthDay)
		{
		}
	}
}
