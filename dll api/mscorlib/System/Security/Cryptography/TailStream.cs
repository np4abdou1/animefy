using System;
using System.IO;

namespace System.Security.Cryptography
{
	// Token: 0x020002C1 RID: 705
	internal sealed class TailStream : Stream
	{
		// Token: 0x06001788 RID: 6024 RVA: 0x00060B97 File Offset: 0x0005ED97
		public TailStream(int bufferSize)
		{
			this._Buffer = new byte[bufferSize];
			this._BufferSize = bufferSize;
		}

		// Token: 0x06001789 RID: 6025 RVA: 0x0005E11D File Offset: 0x0005C31D
		public void Clear()
		{
			this.Close();
		}

		// Token: 0x0600178A RID: 6026 RVA: 0x00060BB4 File Offset: 0x0005EDB4
		protected override void Dispose(bool disposing)
		{
			try
			{
				if (disposing)
				{
					if (this._Buffer != null)
					{
						Array.Clear(this._Buffer, 0, this._Buffer.Length);
					}
					this._Buffer = null;
				}
			}
			finally
			{
				base.Dispose(disposing);
			}
		}

		// Token: 0x17000274 RID: 628
		// (get) Token: 0x0600178B RID: 6027 RVA: 0x00060C04 File Offset: 0x0005EE04
		public byte[] Buffer
		{
			get
			{
				return (byte[])this._Buffer.Clone();
			}
		}

		// Token: 0x17000275 RID: 629
		// (get) Token: 0x0600178C RID: 6028 RVA: 0x0002ACA4 File Offset: 0x00028EA4
		public override bool CanRead
		{
			get
			{
				return false;
			}
		}

		// Token: 0x17000276 RID: 630
		// (get) Token: 0x0600178D RID: 6029 RVA: 0x0002ACA4 File Offset: 0x00028EA4
		public override bool CanSeek
		{
			get
			{
				return false;
			}
		}

		// Token: 0x17000277 RID: 631
		// (get) Token: 0x0600178E RID: 6030 RVA: 0x00060C16 File Offset: 0x0005EE16
		public override bool CanWrite
		{
			get
			{
				return this._Buffer != null;
			}
		}

		// Token: 0x17000278 RID: 632
		// (get) Token: 0x0600178F RID: 6031 RVA: 0x00060C21 File Offset: 0x0005EE21
		public override long Length
		{
			get
			{
				throw new NotSupportedException(Environment.GetResourceString("Stream does not support seeking."));
			}
		}

		// Token: 0x17000279 RID: 633
		// (get) Token: 0x06001790 RID: 6032 RVA: 0x00060C21 File Offset: 0x0005EE21
		// (set) Token: 0x06001791 RID: 6033 RVA: 0x00060C21 File Offset: 0x0005EE21
		public override long Position
		{
			get
			{
				throw new NotSupportedException(Environment.GetResourceString("Stream does not support seeking."));
			}
			set
			{
				throw new NotSupportedException(Environment.GetResourceString("Stream does not support seeking."));
			}
		}

		// Token: 0x06001792 RID: 6034 RVA: 0x00002A7D File Offset: 0x00000C7D
		public override void Flush()
		{
		}

		// Token: 0x06001793 RID: 6035 RVA: 0x00060C21 File Offset: 0x0005EE21
		public override long Seek(long offset, SeekOrigin origin)
		{
			throw new NotSupportedException(Environment.GetResourceString("Stream does not support seeking."));
		}

		// Token: 0x06001794 RID: 6036 RVA: 0x00060C21 File Offset: 0x0005EE21
		public override void SetLength(long value)
		{
			throw new NotSupportedException(Environment.GetResourceString("Stream does not support seeking."));
		}

		// Token: 0x06001795 RID: 6037 RVA: 0x00060C32 File Offset: 0x0005EE32
		public override int Read(byte[] buffer, int offset, int count)
		{
			throw new NotSupportedException(Environment.GetResourceString("Stream does not support reading."));
		}

		// Token: 0x06001796 RID: 6038 RVA: 0x00060C44 File Offset: 0x0005EE44
		public override void Write(byte[] buffer, int offset, int count)
		{
			if (this._Buffer == null)
			{
				throw new ObjectDisposedException("TailStream");
			}
			if (count == 0)
			{
				return;
			}
			if (this._BufferFull)
			{
				if (count > this._BufferSize)
				{
					System.Buffer.InternalBlockCopy(buffer, offset + count - this._BufferSize, this._Buffer, 0, this._BufferSize);
					return;
				}
				System.Buffer.InternalBlockCopy(this._Buffer, this._BufferSize - count, this._Buffer, 0, this._BufferSize - count);
				System.Buffer.InternalBlockCopy(buffer, offset, this._Buffer, this._BufferSize - count, count);
				return;
			}
			else
			{
				if (count > this._BufferSize)
				{
					System.Buffer.InternalBlockCopy(buffer, offset + count - this._BufferSize, this._Buffer, 0, this._BufferSize);
					this._BufferFull = true;
					return;
				}
				if (count + this._BufferIndex >= this._BufferSize)
				{
					System.Buffer.InternalBlockCopy(this._Buffer, this._BufferIndex + count - this._BufferSize, this._Buffer, 0, this._BufferSize - count);
					System.Buffer.InternalBlockCopy(buffer, offset, this._Buffer, this._BufferIndex, count);
					this._BufferFull = true;
					return;
				}
				System.Buffer.InternalBlockCopy(buffer, offset, this._Buffer, this._BufferIndex, count);
				this._BufferIndex += count;
				return;
			}
		}

		// Token: 0x040009B0 RID: 2480
		private byte[] _Buffer;

		// Token: 0x040009B1 RID: 2481
		private int _BufferSize;

		// Token: 0x040009B2 RID: 2482
		private int _BufferIndex;

		// Token: 0x040009B3 RID: 2483
		private bool _BufferFull;
	}
}
