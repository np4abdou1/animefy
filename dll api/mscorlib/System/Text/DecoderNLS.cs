using System;
using System.Runtime.InteropServices;

namespace System.Text
{
	// Token: 0x0200024B RID: 587
	internal class DecoderNLS : Decoder
	{
		// Token: 0x06001436 RID: 5174 RVA: 0x0004FF11 File Offset: 0x0004E111
		internal DecoderNLS(Encoding encoding)
		{
			this._encoding = encoding;
			this._fallback = this._encoding.DecoderFallback;
			this.Reset();
		}

		// Token: 0x06001437 RID: 5175 RVA: 0x0004FF37 File Offset: 0x0004E137
		public override void Reset()
		{
			DecoderFallbackBuffer fallbackBuffer = this._fallbackBuffer;
			if (fallbackBuffer == null)
			{
				return;
			}
			fallbackBuffer.Reset();
		}

		// Token: 0x06001438 RID: 5176 RVA: 0x0004FF49 File Offset: 0x0004E149
		public override int GetCharCount(byte[] bytes, int index, int count)
		{
			return this.GetCharCount(bytes, index, count, false);
		}

		// Token: 0x06001439 RID: 5177 RVA: 0x0004FF58 File Offset: 0x0004E158
		public unsafe override int GetCharCount(byte[] bytes, int index, int count, bool flush)
		{
			if (bytes == null)
			{
				throw new ArgumentNullException("bytes", "Array cannot be null.");
			}
			if (index < 0 || count < 0)
			{
				throw new ArgumentOutOfRangeException((index < 0) ? "index" : "count", "Non-negative number required.");
			}
			if (bytes.Length - index < count)
			{
				throw new ArgumentOutOfRangeException("bytes", "Index and count must refer to a location within the buffer.");
			}
			fixed (byte* reference = MemoryMarshal.GetReference<byte>(bytes))
			{
				byte* ptr = reference;
				return this.GetCharCount(ptr + index, count, flush);
			}
		}

		// Token: 0x0600143A RID: 5178 RVA: 0x0004FFD0 File Offset: 0x0004E1D0
		public unsafe override int GetCharCount(byte* bytes, int count, bool flush)
		{
			if (bytes == null)
			{
				throw new ArgumentNullException("bytes", "Array cannot be null.");
			}
			if (count < 0)
			{
				throw new ArgumentOutOfRangeException("count", "Non-negative number required.");
			}
			this._mustFlush = flush;
			this._throwOnOverflow = true;
			return this._encoding.GetCharCount(bytes, count, this);
		}

		// Token: 0x0600143B RID: 5179 RVA: 0x00050022 File Offset: 0x0004E222
		public override int GetChars(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex)
		{
			return this.GetChars(bytes, byteIndex, byteCount, chars, charIndex, false);
		}

		// Token: 0x0600143C RID: 5180 RVA: 0x00050034 File Offset: 0x0004E234
		public unsafe override int GetChars(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex, bool flush)
		{
			if (bytes == null || chars == null)
			{
				throw new ArgumentNullException((bytes == null) ? "bytes" : "chars", "Array cannot be null.");
			}
			if (byteIndex < 0 || byteCount < 0)
			{
				throw new ArgumentOutOfRangeException((byteIndex < 0) ? "byteIndex" : "byteCount", "Non-negative number required.");
			}
			if (bytes.Length - byteIndex < byteCount)
			{
				throw new ArgumentOutOfRangeException("bytes", "Index and count must refer to a location within the buffer.");
			}
			if (charIndex < 0 || charIndex > chars.Length)
			{
				throw new ArgumentOutOfRangeException("charIndex", "Index was out of range. Must be non-negative and less than the size of the collection.");
			}
			int charCount = chars.Length - charIndex;
			fixed (byte* reference = MemoryMarshal.GetReference<byte>(bytes))
			{
				byte* ptr = reference;
				fixed (char* reference2 = MemoryMarshal.GetReference<char>(chars))
				{
					char* ptr2 = reference2;
					return this.GetChars(ptr + byteIndex, byteCount, ptr2 + charIndex, charCount, flush);
				}
			}
		}

		// Token: 0x0600143D RID: 5181 RVA: 0x000500F8 File Offset: 0x0004E2F8
		public unsafe override int GetChars(byte* bytes, int byteCount, char* chars, int charCount, bool flush)
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
			return this._encoding.GetChars(bytes, byteCount, chars, charCount, this);
		}

		// Token: 0x0600143E RID: 5182 RVA: 0x00050170 File Offset: 0x0004E370
		public unsafe override void Convert(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex, int charCount, bool flush, out int bytesUsed, out int charsUsed, out bool completed)
		{
			if (bytes == null || chars == null)
			{
				throw new ArgumentNullException((bytes == null) ? "bytes" : "chars", "Array cannot be null.");
			}
			if (byteIndex < 0 || byteCount < 0)
			{
				throw new ArgumentOutOfRangeException((byteIndex < 0) ? "byteIndex" : "byteCount", "Non-negative number required.");
			}
			if (charIndex < 0 || charCount < 0)
			{
				throw new ArgumentOutOfRangeException((charIndex < 0) ? "charIndex" : "charCount", "Non-negative number required.");
			}
			if (bytes.Length - byteIndex < byteCount)
			{
				throw new ArgumentOutOfRangeException("bytes", "Index and count must refer to a location within the buffer.");
			}
			if (chars.Length - charIndex < charCount)
			{
				throw new ArgumentOutOfRangeException("chars", "Index and count must refer to a location within the buffer.");
			}
			fixed (byte* reference = MemoryMarshal.GetReference<byte>(bytes))
			{
				byte* ptr = reference;
				fixed (char* reference2 = MemoryMarshal.GetReference<char>(chars))
				{
					char* ptr2 = reference2;
					this.Convert(ptr + byteIndex, byteCount, ptr2 + charIndex, charCount, flush, out bytesUsed, out charsUsed, out completed);
				}
			}
		}

		// Token: 0x0600143F RID: 5183 RVA: 0x0005025C File Offset: 0x0004E45C
		public unsafe override void Convert(byte* bytes, int byteCount, char* chars, int charCount, bool flush, out int bytesUsed, out int charsUsed, out bool completed)
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
			this._throwOnOverflow = false;
			this._bytesUsed = 0;
			charsUsed = this._encoding.GetChars(bytes, byteCount, chars, charCount, this);
			bytesUsed = this._bytesUsed;
			completed = (bytesUsed == byteCount && (!flush || !this.HasState) && (this._fallbackBuffer == null || this._fallbackBuffer.Remaining == 0));
		}

		// Token: 0x17000205 RID: 517
		// (get) Token: 0x06001440 RID: 5184 RVA: 0x00050317 File Offset: 0x0004E517
		public bool MustFlush
		{
			get
			{
				return this._mustFlush;
			}
		}

		// Token: 0x17000206 RID: 518
		// (get) Token: 0x06001441 RID: 5185 RVA: 0x0002ACA4 File Offset: 0x00028EA4
		internal virtual bool HasState
		{
			get
			{
				return false;
			}
		}

		// Token: 0x06001442 RID: 5186 RVA: 0x0005031F File Offset: 0x0004E51F
		internal void ClearMustFlush()
		{
			this._mustFlush = false;
		}

		// Token: 0x04000813 RID: 2067
		private Encoding _encoding;

		// Token: 0x04000814 RID: 2068
		private bool _mustFlush;

		// Token: 0x04000815 RID: 2069
		internal bool _throwOnOverflow;

		// Token: 0x04000816 RID: 2070
		internal int _bytesUsed;
	}
}
