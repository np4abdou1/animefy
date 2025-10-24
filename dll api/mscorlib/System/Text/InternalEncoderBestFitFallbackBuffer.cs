using System;
using System.Threading;

namespace System.Text
{
	// Token: 0x02000250 RID: 592
	internal sealed class InternalEncoderBestFitFallbackBuffer : EncoderFallbackBuffer
	{
		// Token: 0x1700020E RID: 526
		// (get) Token: 0x06001462 RID: 5218 RVA: 0x00050924 File Offset: 0x0004EB24
		private static object InternalSyncObject
		{
			get
			{
				if (InternalEncoderBestFitFallbackBuffer.s_InternalSyncObject == null)
				{
					object value = new object();
					Interlocked.CompareExchange<object>(ref InternalEncoderBestFitFallbackBuffer.s_InternalSyncObject, value, null);
				}
				return InternalEncoderBestFitFallbackBuffer.s_InternalSyncObject;
			}
		}

		// Token: 0x06001463 RID: 5219 RVA: 0x00050950 File Offset: 0x0004EB50
		public InternalEncoderBestFitFallbackBuffer(InternalEncoderBestFitFallback fallback)
		{
			this._oFallback = fallback;
			if (this._oFallback._arrayBestFit == null)
			{
				object internalSyncObject = InternalEncoderBestFitFallbackBuffer.InternalSyncObject;
				lock (internalSyncObject)
				{
					if (this._oFallback._arrayBestFit == null)
					{
						this._oFallback._arrayBestFit = fallback._encoding.GetBestFitUnicodeToBytesData();
					}
				}
			}
		}

		// Token: 0x06001464 RID: 5220 RVA: 0x000509D0 File Offset: 0x0004EBD0
		public override bool Fallback(char charUnknown, int index)
		{
			this._iCount = (this._iSize = 1);
			this._cBestFit = this.TryBestFit(charUnknown);
			if (this._cBestFit == '\0')
			{
				this._cBestFit = '?';
			}
			return true;
		}

		// Token: 0x06001465 RID: 5221 RVA: 0x00050A0C File Offset: 0x0004EC0C
		public override bool Fallback(char charUnknownHigh, char charUnknownLow, int index)
		{
			if (!char.IsHighSurrogate(charUnknownHigh))
			{
				throw new ArgumentOutOfRangeException("charUnknownHigh", SR.Format("Valid values are between {0} and {1}, inclusive.", 55296, 56319));
			}
			if (!char.IsLowSurrogate(charUnknownLow))
			{
				throw new ArgumentOutOfRangeException("charUnknownLow", SR.Format("Valid values are between {0} and {1}, inclusive.", 56320, 57343));
			}
			this._cBestFit = '?';
			this._iCount = (this._iSize = 2);
			return true;
		}

		// Token: 0x06001466 RID: 5222 RVA: 0x00050A94 File Offset: 0x0004EC94
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

		// Token: 0x06001467 RID: 5223 RVA: 0x00050ACB File Offset: 0x0004ECCB
		public override bool MovePrevious()
		{
			if (this._iCount >= 0)
			{
				this._iCount++;
			}
			return this._iCount >= 0 && this._iCount <= this._iSize;
		}

		// Token: 0x1700020F RID: 527
		// (get) Token: 0x06001468 RID: 5224 RVA: 0x00050B00 File Offset: 0x0004ED00
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

		// Token: 0x06001469 RID: 5225 RVA: 0x00050B13 File Offset: 0x0004ED13
		public override void Reset()
		{
			this._iCount = -1;
			this.charStart = null;
			this.bFallingBack = false;
		}

		// Token: 0x0600146A RID: 5226 RVA: 0x00050B2C File Offset: 0x0004ED2C
		private char TryBestFit(char cUnknown)
		{
			int num = 0;
			int num2 = this._oFallback._arrayBestFit.Length;
			int num3;
			while ((num3 = num2 - num) > 6)
			{
				int i = num3 / 2 + num & 65534;
				char c = this._oFallback._arrayBestFit[i];
				if (c == cUnknown)
				{
					return this._oFallback._arrayBestFit[i + 1];
				}
				if (c < cUnknown)
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
				if (this._oFallback._arrayBestFit[i] == cUnknown)
				{
					return this._oFallback._arrayBestFit[i + 1];
				}
			}
			return '\0';
		}

		// Token: 0x0400081F RID: 2079
		private char _cBestFit;

		// Token: 0x04000820 RID: 2080
		private InternalEncoderBestFitFallback _oFallback;

		// Token: 0x04000821 RID: 2081
		private int _iCount = -1;

		// Token: 0x04000822 RID: 2082
		private int _iSize;

		// Token: 0x04000823 RID: 2083
		private static object s_InternalSyncObject;
	}
}
