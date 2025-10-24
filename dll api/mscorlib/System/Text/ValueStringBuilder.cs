using System;
using System.Buffers;
using System.Runtime.CompilerServices;

namespace System.Text
{
	// Token: 0x0200026C RID: 620
	internal ref struct ValueStringBuilder
	{
		// Token: 0x0600159B RID: 5531 RVA: 0x00058E26 File Offset: 0x00057026
		public ValueStringBuilder(Span<char> initialBuffer)
		{
			this._arrayToReturnToPool = null;
			this._chars = initialBuffer;
			this._pos = 0;
		}

		// Token: 0x1700022D RID: 557
		// (get) Token: 0x0600159C RID: 5532 RVA: 0x00058E3D File Offset: 0x0005703D
		public int Length
		{
			get
			{
				return this._pos;
			}
		}

		// Token: 0x1700022E RID: 558
		public char this[int index]
		{
			get
			{
				return this._chars[index];
			}
		}

		// Token: 0x0600159E RID: 5534 RVA: 0x00058E53 File Offset: 0x00057053
		public override string ToString()
		{
			string result = new string(this._chars.Slice(0, this._pos));
			this.Dispose();
			return result;
		}

		// Token: 0x0600159F RID: 5535 RVA: 0x00058E78 File Offset: 0x00057078
		public bool TryCopyTo(Span<char> destination, out int charsWritten)
		{
			if (this._chars.Slice(0, this._pos).TryCopyTo(destination))
			{
				charsWritten = this._pos;
				this.Dispose();
				return true;
			}
			charsWritten = 0;
			this.Dispose();
			return false;
		}

		// Token: 0x060015A0 RID: 5536 RVA: 0x00058EBC File Offset: 0x000570BC
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public unsafe void Append(char c)
		{
			int pos = this._pos;
			if (pos < this._chars.Length)
			{
				*this._chars[pos] = c;
				this._pos = pos + 1;
				return;
			}
			this.GrowAndAppend(c);
		}

		// Token: 0x060015A1 RID: 5537 RVA: 0x00058F00 File Offset: 0x00057100
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public unsafe void Append(string s)
		{
			int pos = this._pos;
			if (s.Length == 1 && pos < this._chars.Length)
			{
				*this._chars[pos] = s[0];
				this._pos = pos + 1;
				return;
			}
			this.AppendSlow(s);
		}

		// Token: 0x060015A2 RID: 5538 RVA: 0x00058F50 File Offset: 0x00057150
		private void AppendSlow(string s)
		{
			int pos = this._pos;
			if (pos > this._chars.Length - s.Length)
			{
				this.Grow(s.Length);
			}
			s.AsSpan().CopyTo(this._chars.Slice(pos));
			this._pos += s.Length;
		}

		// Token: 0x060015A3 RID: 5539 RVA: 0x00058FB4 File Offset: 0x000571B4
		public unsafe void Append(char c, int count)
		{
			if (this._pos > this._chars.Length - count)
			{
				this.Grow(count);
			}
			Span<char> span = this._chars.Slice(this._pos, count);
			for (int i = 0; i < span.Length; i++)
			{
				*span[i] = c;
			}
			this._pos += count;
		}

		// Token: 0x060015A4 RID: 5540 RVA: 0x0005901C File Offset: 0x0005721C
		public unsafe void Append(char* value, int length)
		{
			if (this._pos > this._chars.Length - length)
			{
				this.Grow(length);
			}
			Span<char> span = this._chars.Slice(this._pos, length);
			for (int i = 0; i < span.Length; i++)
			{
				*span[i] = *(value++);
			}
			this._pos += length;
		}

		// Token: 0x060015A5 RID: 5541 RVA: 0x00059088 File Offset: 0x00057288
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public Span<char> AppendSpan(int length)
		{
			int pos = this._pos;
			if (pos > this._chars.Length - length)
			{
				this.Grow(length);
			}
			this._pos = pos + length;
			return this._chars.Slice(pos, length);
		}

		// Token: 0x060015A6 RID: 5542 RVA: 0x000590C9 File Offset: 0x000572C9
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void GrowAndAppend(char c)
		{
			this.Grow(1);
			this.Append(c);
		}

		// Token: 0x060015A7 RID: 5543 RVA: 0x000590DC File Offset: 0x000572DC
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Grow(int requiredAdditionalCapacity)
		{
			char[] array = ArrayPool<char>.Shared.Rent(Math.Max(this._pos + requiredAdditionalCapacity, this._chars.Length * 2));
			this._chars.CopyTo(array);
			char[] arrayToReturnToPool = this._arrayToReturnToPool;
			this._chars = (this._arrayToReturnToPool = array);
			if (arrayToReturnToPool != null)
			{
				ArrayPool<char>.Shared.Return(arrayToReturnToPool, false);
			}
		}

		// Token: 0x060015A8 RID: 5544 RVA: 0x0005914C File Offset: 0x0005734C
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public void Dispose()
		{
			char[] arrayToReturnToPool = this._arrayToReturnToPool;
			this = default(ValueStringBuilder);
			if (arrayToReturnToPool != null)
			{
				ArrayPool<char>.Shared.Return(arrayToReturnToPool, false);
			}
		}

		// Token: 0x0400086F RID: 2159
		private char[] _arrayToReturnToPool;

		// Token: 0x04000870 RID: 2160
		private Span<char> _chars;

		// Token: 0x04000871 RID: 2161
		private int _pos;
	}
}
