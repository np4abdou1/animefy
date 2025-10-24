using System;

namespace System.Text
{
	// Token: 0x0200024F RID: 591
	[Serializable]
	internal class InternalEncoderBestFitFallback : EncoderFallback
	{
		// Token: 0x0600145D RID: 5213 RVA: 0x000508CC File Offset: 0x0004EACC
		internal InternalEncoderBestFitFallback(Encoding encoding)
		{
			this._encoding = encoding;
		}

		// Token: 0x0600145E RID: 5214 RVA: 0x000508DB File Offset: 0x0004EADB
		public override EncoderFallbackBuffer CreateFallbackBuffer()
		{
			return new InternalEncoderBestFitFallbackBuffer(this);
		}

		// Token: 0x1700020D RID: 525
		// (get) Token: 0x0600145F RID: 5215 RVA: 0x0000B18D File Offset: 0x0000938D
		public override int MaxCharCount
		{
			get
			{
				return 1;
			}
		}

		// Token: 0x06001460 RID: 5216 RVA: 0x000508E4 File Offset: 0x0004EAE4
		public override bool Equals(object value)
		{
			InternalEncoderBestFitFallback internalEncoderBestFitFallback = value as InternalEncoderBestFitFallback;
			return internalEncoderBestFitFallback != null && this._encoding.CodePage == internalEncoderBestFitFallback._encoding.CodePage;
		}

		// Token: 0x06001461 RID: 5217 RVA: 0x00050915 File Offset: 0x0004EB15
		public override int GetHashCode()
		{
			return this._encoding.CodePage;
		}

		// Token: 0x0400081D RID: 2077
		internal Encoding _encoding;

		// Token: 0x0400081E RID: 2078
		internal char[] _arrayBestFit;
	}
}
