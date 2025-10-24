using System;
using System.Threading;
using System.Threading.Tasks;

namespace System.IO
{
	// Token: 0x02000226 RID: 550
	internal sealed class ChunkedMemoryStream : Stream
	{
		// Token: 0x06000EF1 RID: 3825 RVA: 0x0004C09A File Offset: 0x0004A29A
		internal ChunkedMemoryStream()
		{
		}

		// Token: 0x06000EF2 RID: 3826 RVA: 0x0004C0A4 File Offset: 0x0004A2A4
		public byte[] ToArray()
		{
			byte[] array = new byte[this._totalLength];
			int num = 0;
			for (ChunkedMemoryStream.MemoryChunk memoryChunk = this._headChunk; memoryChunk != null; memoryChunk = memoryChunk._next)
			{
				Buffer.BlockCopy(memoryChunk._buffer, 0, array, num, memoryChunk._freeOffset);
				num += memoryChunk._freeOffset;
			}
			return array;
		}

		// Token: 0x06000EF3 RID: 3827 RVA: 0x0004C0F0 File Offset: 0x0004A2F0
		public override void Write(byte[] buffer, int offset, int count)
		{
			while (count > 0)
			{
				if (this._currentChunk != null)
				{
					int num = this._currentChunk._buffer.Length - this._currentChunk._freeOffset;
					if (num > 0)
					{
						int num2 = Math.Min(num, count);
						Buffer.BlockCopy(buffer, offset, this._currentChunk._buffer, this._currentChunk._freeOffset, num2);
						count -= num2;
						offset += num2;
						this._totalLength += num2;
						this._currentChunk._freeOffset += num2;
						continue;
					}
				}
				this.AppendChunk((long)count);
			}
		}

		// Token: 0x06000EF4 RID: 3828 RVA: 0x0004C18A File Offset: 0x0004A38A
		public override Task WriteAsync(byte[] buffer, int offset, int count, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested)
			{
				return Task.FromCanceled(cancellationToken);
			}
			this.Write(buffer, offset, count);
			return Task.CompletedTask;
		}

		// Token: 0x06000EF5 RID: 3829 RVA: 0x0004C1AC File Offset: 0x0004A3AC
		private void AppendChunk(long count)
		{
			int num = (this._currentChunk != null) ? (this._currentChunk._buffer.Length * 2) : 1024;
			if (count > (long)num)
			{
				num = (int)Math.Min(count, 1048576L);
			}
			ChunkedMemoryStream.MemoryChunk memoryChunk = new ChunkedMemoryStream.MemoryChunk(num);
			if (this._currentChunk == null)
			{
				this._headChunk = (this._currentChunk = memoryChunk);
				return;
			}
			this._currentChunk._next = memoryChunk;
			this._currentChunk = memoryChunk;
		}

		// Token: 0x17000302 RID: 770
		// (get) Token: 0x06000EF6 RID: 3830 RVA: 0x000023F6 File Offset: 0x000005F6
		public override bool CanRead
		{
			get
			{
				return false;
			}
		}

		// Token: 0x17000303 RID: 771
		// (get) Token: 0x06000EF7 RID: 3831 RVA: 0x000023F6 File Offset: 0x000005F6
		public override bool CanSeek
		{
			get
			{
				return false;
			}
		}

		// Token: 0x17000304 RID: 772
		// (get) Token: 0x06000EF8 RID: 3832 RVA: 0x00009518 File Offset: 0x00007718
		public override bool CanWrite
		{
			get
			{
				return true;
			}
		}

		// Token: 0x17000305 RID: 773
		// (get) Token: 0x06000EF9 RID: 3833 RVA: 0x0004C21E File Offset: 0x0004A41E
		public override long Length
		{
			get
			{
				return (long)this._totalLength;
			}
		}

		// Token: 0x06000EFA RID: 3834 RVA: 0x00004D67 File Offset: 0x00002F67
		public override void Flush()
		{
		}

		// Token: 0x06000EFB RID: 3835 RVA: 0x00047400 File Offset: 0x00045600
		public override Task FlushAsync(CancellationToken cancellationToken)
		{
			return Task.CompletedTask;
		}

		// Token: 0x17000306 RID: 774
		// (get) Token: 0x06000EFC RID: 3836 RVA: 0x00003E34 File Offset: 0x00002034
		// (set) Token: 0x06000EFD RID: 3837 RVA: 0x00003E34 File Offset: 0x00002034
		public override long Position
		{
			get
			{
				throw new NotSupportedException();
			}
			set
			{
				throw new NotSupportedException();
			}
		}

		// Token: 0x06000EFE RID: 3838 RVA: 0x00003E34 File Offset: 0x00002034
		public override int Read(byte[] buffer, int offset, int count)
		{
			throw new NotSupportedException();
		}

		// Token: 0x06000EFF RID: 3839 RVA: 0x00003E34 File Offset: 0x00002034
		public override long Seek(long offset, SeekOrigin origin)
		{
			throw new NotSupportedException();
		}

		// Token: 0x06000F00 RID: 3840 RVA: 0x0004C227 File Offset: 0x0004A427
		public override void SetLength(long value)
		{
			if (this._currentChunk != null)
			{
				throw new NotSupportedException();
			}
			this.AppendChunk(value);
		}

		// Token: 0x04000BE1 RID: 3041
		private ChunkedMemoryStream.MemoryChunk _headChunk;

		// Token: 0x04000BE2 RID: 3042
		private ChunkedMemoryStream.MemoryChunk _currentChunk;

		// Token: 0x04000BE3 RID: 3043
		private int _totalLength;

		// Token: 0x02000227 RID: 551
		private sealed class MemoryChunk
		{
			// Token: 0x06000F01 RID: 3841 RVA: 0x0004C23E File Offset: 0x0004A43E
			internal MemoryChunk(int bufferSize)
			{
				this._buffer = new byte[bufferSize];
			}

			// Token: 0x04000BE4 RID: 3044
			internal readonly byte[] _buffer;

			// Token: 0x04000BE5 RID: 3045
			internal int _freeOffset;

			// Token: 0x04000BE6 RID: 3046
			internal ChunkedMemoryStream.MemoryChunk _next;
		}
	}
}
