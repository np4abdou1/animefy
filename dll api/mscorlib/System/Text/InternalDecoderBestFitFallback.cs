using System;

namespace System.Text
{
	// Token: 0x02000244 RID: 580
	[Serializable]
	internal sealed class InternalDecoderBestFitFallback : DecoderFallback
	{
		// Token: 0x0600140D RID: 5133 RVA: 0x0004F99C File Offset: 0x0004DB9C
		internal InternalDecoderBestFitFallback(Encoding encoding)
		{
			this._encoding = encoding;
		}

		// Token: 0x0600140E RID: 5134 RVA: 0x0004F9B3 File Offset: 0x0004DBB3
		public override DecoderFallbackBuffer CreateFallbackBuffer()
		{
			return new InternalDecoderBestFitFallbackBuffer(this);
		}

		// Token: 0x170001FC RID: 508
		// (get) Token: 0x0600140F RID: 5135 RVA: 0x0000B18D File Offset: 0x0000938D
		public override int MaxCharCount
		{
			get
			{
				return 1;
			}
		}

		// Token: 0x06001410 RID: 5136 RVA: 0x0004F9BC File Offset: 0x0004DBBC
		public override bool Equals(object value)
		{
			InternalDecoderBestFitFallback internalDecoderBestFitFallback = value as InternalDecoderBestFitFallback;
			return internalDecoderBestFitFallback != null && this._encoding.CodePage == internalDecoderBestFitFallback._encoding.CodePage;
		}

		// Token: 0x06001411 RID: 5137 RVA: 0x0004F9ED File Offset: 0x0004DBED
		public override int GetHashCode()
		{
			return this._encoding.CodePage;
		}

		// Token: 0x04000805 RID: 2053
		internal Encoding _encoding;

		// Token: 0x04000806 RID: 2054
		internal char[] _arrayBestFit;

		// Token: 0x04000807 RID: 2055
		internal char _cReplacement = '?';
	}
}
