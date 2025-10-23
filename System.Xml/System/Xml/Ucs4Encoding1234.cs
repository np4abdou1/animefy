using System;

namespace System.Xml
{
	// Token: 0x020001AA RID: 426
	internal class Ucs4Encoding1234 : Ucs4Encoding
	{
		// Token: 0x06000ED6 RID: 3798 RVA: 0x000609AA File Offset: 0x0005EBAA
		public Ucs4Encoding1234()
		{
			this.ucs4Decoder = new Ucs4Decoder1234();
		}

		// Token: 0x170002D4 RID: 724
		// (get) Token: 0x06000ED7 RID: 3799 RVA: 0x000609BD File Offset: 0x0005EBBD
		public override string EncodingName
		{
			get
			{
				return "ucs-4 (Bigendian)";
			}
		}

		// Token: 0x06000ED8 RID: 3800 RVA: 0x000609C4 File Offset: 0x0005EBC4
		public override byte[] GetPreamble()
		{
			return new byte[]
			{
				0,
				0,
				254,
				byte.MaxValue
			};
		}
	}
}
