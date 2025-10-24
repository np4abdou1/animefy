using System;

namespace System.Xml.Schema
{
	// Token: 0x02000269 RID: 617
	internal class Datatype_day : Datatype_dateTimeBase
	{
		// Token: 0x17000452 RID: 1106
		// (get) Token: 0x060013DD RID: 5085 RVA: 0x00075833 File Offset: 0x00073A33
		public override XmlTypeCode TypeCode
		{
			get
			{
				return XmlTypeCode.GDay;
			}
		}

		// Token: 0x060013DE RID: 5086 RVA: 0x00076163 File Offset: 0x00074363
		internal Datatype_day() : base(XsdDateTimeFlags.GDay)
		{
		}
	}
}
