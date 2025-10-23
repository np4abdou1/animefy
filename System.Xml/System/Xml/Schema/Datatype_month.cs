using System;

namespace System.Xml.Schema
{
	// Token: 0x0200026A RID: 618
	internal class Datatype_month : Datatype_dateTimeBase
	{
		// Token: 0x17000453 RID: 1107
		// (get) Token: 0x060013DF RID: 5087 RVA: 0x0007616D File Offset: 0x0007436D
		public override XmlTypeCode TypeCode
		{
			get
			{
				return XmlTypeCode.GMonth;
			}
		}

		// Token: 0x060013E0 RID: 5088 RVA: 0x00076171 File Offset: 0x00074371
		internal Datatype_month() : base(XsdDateTimeFlags.GMonth)
		{
		}
	}
}
