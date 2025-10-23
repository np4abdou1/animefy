using System;

namespace System.Xml.Schema
{
	// Token: 0x02000264 RID: 612
	internal class Datatype_time : Datatype_dateTimeBase
	{
		// Token: 0x1700044D RID: 1101
		// (get) Token: 0x060013D3 RID: 5075 RVA: 0x00076129 File Offset: 0x00074329
		public override XmlTypeCode TypeCode
		{
			get
			{
				return XmlTypeCode.Time;
			}
		}

		// Token: 0x060013D4 RID: 5076 RVA: 0x00076120 File Offset: 0x00074320
		internal Datatype_time() : base(XsdDateTimeFlags.Time)
		{
		}
	}
}
