using System;

namespace System.Xml.Schema
{
	// Token: 0x02000267 RID: 615
	internal class Datatype_year : Datatype_dateTimeBase
	{
		// Token: 0x17000450 RID: 1104
		// (get) Token: 0x060013D9 RID: 5081 RVA: 0x00076147 File Offset: 0x00074347
		public override XmlTypeCode TypeCode
		{
			get
			{
				return XmlTypeCode.GYear;
			}
		}

		// Token: 0x060013DA RID: 5082 RVA: 0x0007614B File Offset: 0x0007434B
		internal Datatype_year() : base(XsdDateTimeFlags.GYear)
		{
		}
	}
}
