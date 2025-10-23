using System;

namespace System.Xml
{
	// Token: 0x020001AC RID: 428
	internal class Ucs4Encoding2143 : Ucs4Encoding
	{
		// Token: 0x06000EDC RID: 3804 RVA: 0x00060A0E File Offset: 0x0005EC0E
		public Ucs4Encoding2143()
		{
			this.ucs4Decoder = new Ucs4Decoder2143();
		}

		// Token: 0x170002D6 RID: 726
		// (get) Token: 0x06000EDD RID: 3805 RVA: 0x00060A21 File Offset: 0x0005EC21
		public override string EncodingName
		{
			get
			{
				return "ucs-4 (order 2143)";
			}
		}

		// Token: 0x06000EDE RID: 3806 RVA: 0x00060A28 File Offset: 0x0005EC28
		public override byte[] GetPreamble()
		{
			return new byte[]
			{
				0,
				0,
				byte.MaxValue,
				254
			};
		}
	}
}
