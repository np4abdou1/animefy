using System;
using System.Buffers;

namespace System.Text
{
	// Token: 0x0200026D RID: 621
	internal ref struct ValueUtf8Converter
	{
		// Token: 0x060015A9 RID: 5545 RVA: 0x00059176 File Offset: 0x00057376
		public ValueUtf8Converter(Span<byte> initialBuffer)
		{
			this._arrayToReturnToPool = null;
			this._bytes = initialBuffer;
		}

		// Token: 0x060015AA RID: 5546 RVA: 0x00059188 File Offset: 0x00057388
		public unsafe Span<byte> ConvertAndTerminateString(ReadOnlySpan<char> value)
		{
			int num = Encoding.UTF8.GetMaxByteCount(value.Length) + 1;
			if (this._bytes.Length < num)
			{
				this.Dispose();
				this._arrayToReturnToPool = ArrayPool<byte>.Shared.Rent(num);
				this._bytes = new Span<byte>(this._arrayToReturnToPool);
			}
			int bytes = Encoding.UTF8.GetBytes(value, this._bytes);
			*this._bytes[bytes] = 0;
			return this._bytes.Slice(0, bytes + 1);
		}

		// Token: 0x060015AB RID: 5547 RVA: 0x00059210 File Offset: 0x00057410
		public void Dispose()
		{
			byte[] arrayToReturnToPool = this._arrayToReturnToPool;
			if (arrayToReturnToPool != null)
			{
				this._arrayToReturnToPool = null;
				ArrayPool<byte>.Shared.Return(arrayToReturnToPool, false);
			}
		}

		// Token: 0x04000872 RID: 2162
		private byte[] _arrayToReturnToPool;

		// Token: 0x04000873 RID: 2163
		private Span<byte> _bytes;
	}
}
