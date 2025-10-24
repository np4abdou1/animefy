using System;

namespace System.Xml
{
	// Token: 0x020001AD RID: 429
	internal class Ucs4Encoding3412 : Ucs4Encoding
	{
		// Token: 0x06000EDF RID: 3807 RVA: 0x00060A40 File Offset: 0x0005EC40
		public Ucs4Encoding3412()
		{
			this.ucs4Decoder = new Ucs4Decoder3412();
		}

		// Token: 0x170002D7 RID: 727
		// (get) Token: 0x06000EE0 RID: 3808 RVA: 0x00060A53 File Offset: 0x0005EC53
		public override string EncodingName
		{
			get
			{
				return "ucs-4 (order 3412)";
			}
		}

		// Token: 0x06000EE1 RID: 3809 RVA: 0x00060A5A File Offset: 0x0005EC5A
		public override byte[] GetPreamble()
		{
			byte[] array = new byte[4];
			array[0] = 254;
			array[1] = byte.MaxValue;
			return array;
		}
	}
}
