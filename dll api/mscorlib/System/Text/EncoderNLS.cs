using System;
using System.Runtime.InteropServices;

namespace System.Text
{
	// Token: 0x02000256 RID: 598
	internal class EncoderNLS : Encoder
	{
		// Token: 0x0600148B RID: 5259 RVA: 0x00050F22 File Offset: 0x0004F122
		internal EncoderNLS(Encoding encoding)
		{
			this._encoding = encoding;
			this._fallback = this._encoding.EncoderFallback;
			this.Reset();
		}

		// Token: 0x0600148C RID: 5260 RVA: 0x00050F48 File Offset: 0x0004F148
		public override void Reset()
		{
			this._charLeftOver = '\0';
			if (this._fallbackBuffer != null)
			{
				this._fallbackBuffer.Reset();
			}
		}

		// Token: 0x0600148D RID: 5261 RVA: 0x00050F64 File Offset: 0x0004F164
		public unsafe override int GetByteCount(char[] chars, int index, int count, bool flush)
		{
			if (chars == null)
			{
				throw new ArgumentNullException("chars", "Array cannot be null.");
			}
			if (index < 0 || count < 0)
			{
				throw new ArgumentOutOfRangeException((index < 0) ? "index" : "count", "Non-negative number required.");
			}
			if (chars.Length - index < count)
			{
				throw new ArgumentOutOfRangeException("chars", "Index and count must refer to a location within the buffer.");
			}
			int byteCount;
			fixed (char* reference = MemoryMarshal.GetReference<char>(chars))
			{
				char* ptr = reference;
				byteCount = this.GetByteCount(ptr + index, count, flush);
			}
			return byteCount;
		}

		// Token: 0x0600148E RID: 5262 RVA: 0x00050FE0 File Offset: 0x0004F1E0
		public unsafe override int GetByteCount(char* chars, int count, bool flush)
		{
			if (chars == null)
			{
				throw new ArgumentNullException("chars", "Array cannot be null.");
			}
			if (count < 0)
			{
				throw new ArgumentOutOfRangeException("count", "Non-negative number required.");
			}
			this._mustFlush = flush;
			this._throwOnOverflow = true;
			return this._encoding.GetByteCount(chars, count, this);
		}

		// Token: 0x0600148F RID: 5263 RVA: 0x00051034 File Offset: 0x0004F234
		public unsafe override int GetBytes(char[] chars, int charIndex, int charCount, byte[] bytes, int byteIndex, bool flush)
		{
			if (chars == null || bytes == null)
			{
				throw new ArgumentNullException((chars == null) ? "chars" : "bytes", "Array cannot be null.");
			}
			if (charIndex < 0 || charCount < 0)
			{
				throw new ArgumentOutOfRangeException((charIndex < 0) ? "charIndex" : "charCount", "Non-negative number required.");
			}
			if (chars.Length - charIndex < charCount)
			{
				throw new ArgumentOutOfRangeException("chars", "Index and count must refer to a location within the buffer.");
			}
			if (byteIndex < 0 || byteIndex > bytes.Length)
			{
				throw new ArgumentOutOfRangeException("byteIndex", "Index was out of range. Must be non-negative and less than the size of the collection.");
			}
			int byteCount = bytes.Length - byteIndex;
			fixed (char* reference = MemoryMarshal.GetReference<char>(chars))
			{
				char* ptr = reference;
				fixed (byte* reference2 = MemoryMarshal.GetReference<byte>(bytes))
				{
					byte* ptr2 = reference2;
					return this.GetBytes(ptr + charIndex, charCount, ptr2 + byteIndex, byteCount, flush);
				}
			}
		}

		// Token: 0x06001490 RID: 5264 RVA: 0x000510F8 File Offset: 0x0004F2F8
		public unsafe override int GetBytes(char* chars, int charCount, byte* bytes, int byteCount, bool flush)
		{
			if (chars == null || bytes == null)
			{
				throw new ArgumentNullException((chars == null) ? "chars" : "bytes", "Array cannot be null.");
			}
			if (byteCount < 0 || charCount < 0)
			{
				throw new ArgumentOutOfRangeException((byteCount < 0) ? "byteCount" : "charCount", "Non-negative number required.");
			}
			this._mustFlush = flush;
			this._throwOnOverflow = true;
			return this._encoding.GetBytes(chars, charCount, bytes, byteCount, this);
		}

		// Token: 0x06001491 RID: 5265 RVA: 0x00051170 File Offset: 0x0004F370
		public unsafe override void Convert(char[] chars, int charIndex, int charCount, byte[] bytes, int byteIndex, int byteCount, bool flush, out int charsUsed, out int bytesUsed, out bool completed)
		{
			if (chars == null || bytes == null)
			{
				throw new ArgumentNullException((chars == null) ? "chars" : "bytes", "Array cannot be null.");
			}
			if (charIndex < 0 || charCount < 0)
			{
				throw new ArgumentOutOfRangeException((charIndex < 0) ? "charIndex" : "charCount", "Non-negative number required.");
			}
			if (byteIndex < 0 || byteCount < 0)
			{
				throw new ArgumentOutOfRangeException((byteIndex < 0) ? "byteIndex" : "byteCount", "Non-negative number required.");
			}
			if (chars.Length - charIndex < charCount)
			{
				throw new ArgumentOutOfRangeException("chars", "Index and count must refer to a location within the buffer.");
			}
			if (bytes.Length - byteIndex < byteCount)
			{
				throw new ArgumentOutOfRangeException("bytes", "Index and count must refer to a location within the buffer.");
			}
			fixed (char* reference = MemoryMarshal.GetReference<char>(chars))
			{
				char* ptr = reference;
				fixed (byte* reference2 = MemoryMarshal.GetReference<byte>(bytes))
				{
					byte* ptr2 = reference2;
					this.Convert(ptr + charIndex, charCount, ptr2 + byteIndex, byteCount, flush, out charsUsed, out bytesUsed, out completed);
				}
			}
		}

		// Token: 0x06001492 RID: 5266 RVA: 0x0005125C File Offset: 0x0004F45C
		public unsafe override void Convert(char* chars, int charCount, byte* bytes, int byteCount, bool flush, out int charsUsed, out int bytesUsed, out bool completed)
		{
			if (bytes == null || chars == null)
			{
				throw new ArgumentNullException((bytes == null) ? "bytes" : "chars", "Array cannot be null.");
			}
			if (charCount < 0 || byteCount < 0)
			{
				throw new ArgumentOutOfRangeException((charCount < 0) ? "charCount" : "byteCount", "Non-negative number required.");
			}
			this._mustFlush = flush;
			this._throwOnOverflow = false;
			this._charsUsed = 0;
			bytesUsed = this._encoding.GetBytes(chars, charCount, bytes, byteCount, this);
			charsUsed = this._charsUsed;
			completed = (charsUsed == charCount && (!flush || !this.HasState) && (this._fallbackBuffer == null || this._fallbackBuffer.Remaining == 0));
		}

		// Token: 0x17000216 RID: 534
		// (get) Token: 0x06001493 RID: 5267 RVA: 0x00051317 File Offset: 0x0004F517
		public Encoding Encoding
		{
			get
			{
				return this._encoding;
			}
		}

		// Token: 0x17000217 RID: 535
		// (get) Token: 0x06001494 RID: 5268 RVA: 0x0005131F File Offset: 0x0004F51F
		public bool MustFlush
		{
			get
			{
				return this._mustFlush;
			}
		}

		// Token: 0x17000218 RID: 536
		// (get) Token: 0x06001495 RID: 5269 RVA: 0x00051327 File Offset: 0x0004F527
		internal virtual bool HasState
		{
			get
			{
				return this._charLeftOver > '\0';
			}
		}

		// Token: 0x06001496 RID: 5270 RVA: 0x00051332 File Offset: 0x0004F532
		internal void ClearMustFlush()
		{
			this._mustFlush = false;
		}

		// Token: 0x04000831 RID: 2097
		internal char _charLeftOver;

		// Token: 0x04000832 RID: 2098
		private Encoding _encoding;

		// Token: 0x04000833 RID: 2099
		private bool _mustFlush;

		// Token: 0x04000834 RID: 2100
		internal bool _throwOnOverflow;

		// Token: 0x04000835 RID: 2101
		internal int _charsUsed;
	}
}
