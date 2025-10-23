using System;
using System.Threading;

namespace System.Text
{
	// Token: 0x02000245 RID: 581
	internal sealed class InternalDecoderBestFitFallbackBuffer : DecoderFallbackBuffer
	{
		// Token: 0x170001FD RID: 509
		// (get) Token: 0x06001412 RID: 5138 RVA: 0x0004F9FC File Offset: 0x0004DBFC
		private static object InternalSyncObject
		{
			get
			{
				if (InternalDecoderBestFitFallbackBuffer.s_InternalSyncObject == null)
				{
					object value = new object();
					Interlocked.CompareExchange<object>(ref InternalDecoderBestFitFallbackBuffer.s_InternalSyncObject, value, null);
				}
				return InternalDecoderBestFitFallbackBuffer.s_InternalSyncObject;
			}
		}

		// Token: 0x06001413 RID: 5139 RVA: 0x0004FA28 File Offset: 0x0004DC28
		public InternalDecoderBestFitFallbackBuffer(InternalDecoderBestFitFallback fallback)
		{
			this._oFallback = fallback;
			if (this._oFallback._arrayBestFit == null)
			{
				object internalSyncObject = InternalDecoderBestFitFallbackBuffer.InternalSyncObject;
				lock (internalSyncObject)
				{
					if (this._oFallback._arrayBestFit == null)
					{
						this._oFallback._arrayBestFit = fallback._encoding.GetBestFitBytesToUnicodeData();
					}
				}
			}
		}

		// Token: 0x06001414 RID: 5140 RVA: 0x0004FAA8 File Offset: 0x0004DCA8
		public override bool Fallback(byte[] bytesUnknown, int index)
		{
			this._cBestFit = this.TryBestFit(bytesUnknown);
			if (this._cBestFit == '\0')
			{
				this._cBestFit = this._oFallback._cReplacement;
			}
			this._iCount = (this._iSize = 1);
			return true;
		}

		// Token: 0x06001415 RID: 5141 RVA: 0x0004FAEC File Offset: 0x0004DCEC
		public override char GetNextChar()
		{
			this._iCount--;
			if (this._iCount < 0)
			{
				return '\0';
			}
			if (this._iCount == 2147483647)
			{
				this._iCount = -1;
				return '\0';
			}
			return this._cBestFit;
		}

		// Token: 0x170001FE RID: 510
		// (get) Token: 0x06001416 RID: 5142 RVA: 0x0004FB23 File Offset: 0x0004DD23
		public override int Remaining
		{
			get
			{
				if (this._iCount <= 0)
				{
					return 0;
				}
				return this._iCount;
			}
		}

		// Token: 0x06001417 RID: 5143 RVA: 0x0004FB36 File Offset: 0x0004DD36
		public override void Reset()
		{
			this._iCount = -1;
			this.byteStart = null;
		}

		// Token: 0x06001418 RID: 5144 RVA: 0x0000B18D File Offset: 0x0000938D
		internal unsafe override int InternalFallback(byte[] bytes, byte* pBytes)
		{
			return 1;
		}

		// Token: 0x06001419 RID: 5145 RVA: 0x0004FB48 File Offset: 0x0004DD48
		private char TryBestFit(byte[] bytesCheck)
		{
			int num = 0;
			int num2 = this._oFallback._arrayBestFit.Length;
			if (num2 == 0)
			{
				return '\0';
			}
			if (bytesCheck.Length == 0 || bytesCheck.Length > 2)
			{
				return '\0';
			}
			char c;
			if (bytesCheck.Length == 1)
			{
				c = (char)bytesCheck[0];
			}
			else
			{
				c = (char)(((int)bytesCheck[0] << 8) + (int)bytesCheck[1]);
			}
			if (c < this._oFallback._arrayBestFit[0] || c > this._oFallback._arrayBestFit[num2 - 2])
			{
				return '\0';
			}
			int num3;
			while ((num3 = num2 - num) > 6)
			{
				int i = num3 / 2 + num & 65534;
				char c2 = this._oFallback._arrayBestFit[i];
				if (c2 == c)
				{
					return this._oFallback._arrayBestFit[i + 1];
				}
				if (c2 < c)
				{
					num = i;
				}
				else
				{
					num2 = i;
				}
			}
			for (int i = num; i < num2; i += 2)
			{
				if (this._oFallback._arrayBestFit[i] == c)
				{
					return this._oFallback._arrayBestFit[i + 1];
				}
			}
			return '\0';
		}

		// Token: 0x04000808 RID: 2056
		private char _cBestFit;

		// Token: 0x04000809 RID: 2057
		private int _iCount = -1;

		// Token: 0x0400080A RID: 2058
		private int _iSize;

		// Token: 0x0400080B RID: 2059
		private InternalDecoderBestFitFallback _oFallback;

		// Token: 0x0400080C RID: 2060
		private static object s_InternalSyncObject;
	}
}
