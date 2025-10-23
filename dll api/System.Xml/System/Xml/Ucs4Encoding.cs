using System;
using System.Text;

namespace System.Xml
{
	// Token: 0x020001A9 RID: 425
	internal class Ucs4Encoding : Encoding
	{
		// Token: 0x170002CE RID: 718
		// (get) Token: 0x06000EC6 RID: 3782 RVA: 0x00060946 File Offset: 0x0005EB46
		public override string WebName
		{
			get
			{
				return this.EncodingName;
			}
		}

		// Token: 0x06000EC7 RID: 3783 RVA: 0x0006094E File Offset: 0x0005EB4E
		public override Decoder GetDecoder()
		{
			return this.ucs4Decoder;
		}

		// Token: 0x06000EC8 RID: 3784 RVA: 0x00060956 File Offset: 0x0005EB56
		public override int GetByteCount(char[] chars, int index, int count)
		{
			return checked(count * 4);
		}

		// Token: 0x06000EC9 RID: 3785 RVA: 0x0001520A File Offset: 0x0001340A
		public override byte[] GetBytes(string s)
		{
			return null;
		}

		// Token: 0x06000ECA RID: 3786 RVA: 0x0000A216 File Offset: 0x00008416
		public override int GetBytes(char[] chars, int charIndex, int charCount, byte[] bytes, int byteIndex)
		{
			return 0;
		}

		// Token: 0x06000ECB RID: 3787 RVA: 0x0000A216 File Offset: 0x00008416
		public override int GetMaxByteCount(int charCount)
		{
			return 0;
		}

		// Token: 0x06000ECC RID: 3788 RVA: 0x0006095B File Offset: 0x0005EB5B
		public override int GetCharCount(byte[] bytes, int index, int count)
		{
			return this.ucs4Decoder.GetCharCount(bytes, index, count);
		}

		// Token: 0x06000ECD RID: 3789 RVA: 0x0006096B File Offset: 0x0005EB6B
		public override int GetChars(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex)
		{
			return this.ucs4Decoder.GetChars(bytes, byteIndex, byteCount, chars, charIndex);
		}

		// Token: 0x06000ECE RID: 3790 RVA: 0x0006097F File Offset: 0x0005EB7F
		public override int GetMaxCharCount(int byteCount)
		{
			return (byteCount + 3) / 4;
		}

		// Token: 0x170002CF RID: 719
		// (get) Token: 0x06000ECF RID: 3791 RVA: 0x0000A216 File Offset: 0x00008416
		public override int CodePage
		{
			get
			{
				return 0;
			}
		}

		// Token: 0x06000ED0 RID: 3792 RVA: 0x0001520A File Offset: 0x0001340A
		public override Encoder GetEncoder()
		{
			return null;
		}

		// Token: 0x170002D0 RID: 720
		// (get) Token: 0x06000ED1 RID: 3793 RVA: 0x00060986 File Offset: 0x0005EB86
		internal static Encoding UCS4_Littleendian
		{
			get
			{
				return new Ucs4Encoding4321();
			}
		}

		// Token: 0x170002D1 RID: 721
		// (get) Token: 0x06000ED2 RID: 3794 RVA: 0x0006098D File Offset: 0x0005EB8D
		internal static Encoding UCS4_Bigendian
		{
			get
			{
				return new Ucs4Encoding1234();
			}
		}

		// Token: 0x170002D2 RID: 722
		// (get) Token: 0x06000ED3 RID: 3795 RVA: 0x00060994 File Offset: 0x0005EB94
		internal static Encoding UCS4_2143
		{
			get
			{
				return new Ucs4Encoding2143();
			}
		}

		// Token: 0x170002D3 RID: 723
		// (get) Token: 0x06000ED4 RID: 3796 RVA: 0x0006099B File Offset: 0x0005EB9B
		internal static Encoding UCS4_3412
		{
			get
			{
				return new Ucs4Encoding3412();
			}
		}

		// Token: 0x04000ABA RID: 2746
		internal Ucs4Decoder ucs4Decoder;
	}
}
