using System;

namespace System.Xml
{
	// Token: 0x020001AB RID: 427
	internal class Ucs4Encoding4321 : Ucs4Encoding
	{
		// Token: 0x06000ED9 RID: 3801 RVA: 0x000609DC File Offset: 0x0005EBDC
		public Ucs4Encoding4321()
		{
			this.ucs4Decoder = new Ucs4Decoder4321();
		}

		// Token: 0x170002D5 RID: 725
		// (get) Token: 0x06000EDA RID: 3802 RVA: 0x000609EF File Offset: 0x0005EBEF
		public override string EncodingName
		{
			get
			{
				return "ucs-4";
			}
		}

		// Token: 0x06000EDB RID: 3803 RVA: 0x000609F6 File Offset: 0x0005EBF6
		public override byte[] GetPreamble()
		{
			byte[] array = new byte[4];
			array[0] = byte.MaxValue;
			array[1] = 254;
			return array;
		}
	}
}
