using System;
using System.Runtime.CompilerServices;

namespace Newtonsoft.Json.Utilities
{
	// Token: 0x020000EC RID: 236
	[NullableContext(2)]
	[Nullable(0)]
	internal struct StringBuffer
	{
		// Token: 0x170000DE RID: 222
		// (get) Token: 0x060006ED RID: 1773 RVA: 0x00023F3F File Offset: 0x0002213F
		// (set) Token: 0x060006EE RID: 1774 RVA: 0x00023F47 File Offset: 0x00022147
		public int Position
		{
			get
			{
				return this._position;
			}
			set
			{
				this._position = value;
			}
		}

		// Token: 0x170000DF RID: 223
		// (get) Token: 0x060006EF RID: 1775 RVA: 0x00023F50 File Offset: 0x00022150
		public bool IsEmpty
		{
			get
			{
				return this._buffer == null;
			}
		}

		// Token: 0x060006F0 RID: 1776 RVA: 0x00023F5B File Offset: 0x0002215B
		public StringBuffer(IArrayPool<char> bufferPool, int initalSize)
		{
			this = new StringBuffer(BufferUtils.RentBuffer(bufferPool, initalSize));
		}

		// Token: 0x060006F1 RID: 1777 RVA: 0x00023F6A File Offset: 0x0002216A
		[NullableContext(1)]
		private StringBuffer(char[] buffer)
		{
			this._buffer = buffer;
			this._position = 0;
		}

		// Token: 0x060006F2 RID: 1778 RVA: 0x00023F7C File Offset: 0x0002217C
		public void Append(IArrayPool<char> bufferPool, char value)
		{
			if (this._position == this._buffer.Length)
			{
				this.EnsureSize(bufferPool, 1);
			}
			char[] buffer = this._buffer;
			int position = this._position;
			this._position = position + 1;
			buffer[position] = value;
		}

		// Token: 0x060006F3 RID: 1779 RVA: 0x00023FBC File Offset: 0x000221BC
		[NullableContext(1)]
		public void Append([Nullable(2)] IArrayPool<char> bufferPool, char[] buffer, int startIndex, int count)
		{
			if (this._position + count >= this._buffer.Length)
			{
				this.EnsureSize(bufferPool, count);
			}
			Array.Copy(buffer, startIndex, this._buffer, this._position, count);
			this._position += count;
		}

		// Token: 0x060006F4 RID: 1780 RVA: 0x00024009 File Offset: 0x00022209
		public void Clear(IArrayPool<char> bufferPool)
		{
			if (this._buffer != null)
			{
				BufferUtils.ReturnBuffer(bufferPool, this._buffer);
				this._buffer = null;
			}
			this._position = 0;
		}

		// Token: 0x060006F5 RID: 1781 RVA: 0x00024030 File Offset: 0x00022230
		private void EnsureSize(IArrayPool<char> bufferPool, int appendLength)
		{
			char[] array = BufferUtils.RentBuffer(bufferPool, (this._position + appendLength) * 2);
			if (this._buffer != null)
			{
				Array.Copy(this._buffer, array, this._position);
				BufferUtils.ReturnBuffer(bufferPool, this._buffer);
			}
			this._buffer = array;
		}

		// Token: 0x060006F6 RID: 1782 RVA: 0x0002407B File Offset: 0x0002227B
		[NullableContext(1)]
		public override string ToString()
		{
			return this.ToString(0, this._position);
		}

		// Token: 0x060006F7 RID: 1783 RVA: 0x0002408A File Offset: 0x0002228A
		[NullableContext(1)]
		public string ToString(int start, int length)
		{
			return new string(this._buffer, start, length);
		}

		// Token: 0x170000E0 RID: 224
		// (get) Token: 0x060006F8 RID: 1784 RVA: 0x00024099 File Offset: 0x00022299
		public char[] InternalBuffer
		{
			get
			{
				return this._buffer;
			}
		}

		// Token: 0x040004C3 RID: 1219
		private char[] _buffer;

		// Token: 0x040004C4 RID: 1220
		private int _position;
	}
}
