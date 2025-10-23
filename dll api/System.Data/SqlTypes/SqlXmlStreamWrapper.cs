using System;
using System.Data.Common;
using System.IO;

namespace System.Data.SqlTypes
{
	// Token: 0x020000C8 RID: 200
	internal sealed class SqlXmlStreamWrapper : Stream
	{
		// Token: 0x06000DE6 RID: 3558 RVA: 0x00046899 File Offset: 0x00044A99
		internal SqlXmlStreamWrapper(Stream stream)
		{
			this._stream = stream;
			this._lPosition = 0L;
			this._isClosed = false;
		}

		// Token: 0x170001CE RID: 462
		// (get) Token: 0x06000DE7 RID: 3559 RVA: 0x000468B7 File Offset: 0x00044AB7
		public override bool CanRead
		{
			get
			{
				return !this.IsStreamClosed() && this._stream.CanRead;
			}
		}

		// Token: 0x170001CF RID: 463
		// (get) Token: 0x06000DE8 RID: 3560 RVA: 0x000468CE File Offset: 0x00044ACE
		public override bool CanSeek
		{
			get
			{
				return !this.IsStreamClosed() && this._stream.CanSeek;
			}
		}

		// Token: 0x170001D0 RID: 464
		// (get) Token: 0x06000DE9 RID: 3561 RVA: 0x000468E5 File Offset: 0x00044AE5
		public override bool CanWrite
		{
			get
			{
				return !this.IsStreamClosed() && this._stream.CanWrite;
			}
		}

		// Token: 0x170001D1 RID: 465
		// (get) Token: 0x06000DEA RID: 3562 RVA: 0x000468FC File Offset: 0x00044AFC
		public override long Length
		{
			get
			{
				this.ThrowIfStreamClosed("get_Length");
				this.ThrowIfStreamCannotSeek("get_Length");
				return this._stream.Length;
			}
		}

		// Token: 0x170001D2 RID: 466
		// (get) Token: 0x06000DEB RID: 3563 RVA: 0x0004691F File Offset: 0x00044B1F
		// (set) Token: 0x06000DEC RID: 3564 RVA: 0x0004693D File Offset: 0x00044B3D
		public override long Position
		{
			get
			{
				this.ThrowIfStreamClosed("get_Position");
				this.ThrowIfStreamCannotSeek("get_Position");
				return this._lPosition;
			}
			set
			{
				this.ThrowIfStreamClosed("set_Position");
				this.ThrowIfStreamCannotSeek("set_Position");
				if (value < 0L || value > this._stream.Length)
				{
					throw new ArgumentOutOfRangeException("value");
				}
				this._lPosition = value;
			}
		}

		// Token: 0x06000DED RID: 3565 RVA: 0x0004697C File Offset: 0x00044B7C
		public override long Seek(long offset, SeekOrigin origin)
		{
			this.ThrowIfStreamClosed("Seek");
			this.ThrowIfStreamCannotSeek("Seek");
			switch (origin)
			{
			case SeekOrigin.Begin:
				if (offset < 0L || offset > this._stream.Length)
				{
					throw new ArgumentOutOfRangeException("offset");
				}
				this._lPosition = offset;
				break;
			case SeekOrigin.Current:
			{
				long num = this._lPosition + offset;
				if (num < 0L || num > this._stream.Length)
				{
					throw new ArgumentOutOfRangeException("offset");
				}
				this._lPosition = num;
				break;
			}
			case SeekOrigin.End:
			{
				long num = this._stream.Length + offset;
				if (num < 0L || num > this._stream.Length)
				{
					throw new ArgumentOutOfRangeException("offset");
				}
				this._lPosition = num;
				break;
			}
			default:
				throw ADP.InvalidSeekOrigin("offset");
			}
			return this._lPosition;
		}

		// Token: 0x06000DEE RID: 3566 RVA: 0x00046A58 File Offset: 0x00044C58
		public override int Read(byte[] buffer, int offset, int count)
		{
			this.ThrowIfStreamClosed("Read");
			this.ThrowIfStreamCannotRead("Read");
			if (buffer == null)
			{
				throw new ArgumentNullException("buffer");
			}
			if (offset < 0 || offset > buffer.Length)
			{
				throw new ArgumentOutOfRangeException("offset");
			}
			if (count < 0 || count > buffer.Length - offset)
			{
				throw new ArgumentOutOfRangeException("count");
			}
			if (this._stream.CanSeek && this._stream.Position != this._lPosition)
			{
				this._stream.Seek(this._lPosition, SeekOrigin.Begin);
			}
			int num = this._stream.Read(buffer, offset, count);
			this._lPosition += (long)num;
			return num;
		}

		// Token: 0x06000DEF RID: 3567 RVA: 0x00046B08 File Offset: 0x00044D08
		public override void Write(byte[] buffer, int offset, int count)
		{
			this.ThrowIfStreamClosed("Write");
			this.ThrowIfStreamCannotWrite("Write");
			if (buffer == null)
			{
				throw new ArgumentNullException("buffer");
			}
			if (offset < 0 || offset > buffer.Length)
			{
				throw new ArgumentOutOfRangeException("offset");
			}
			if (count < 0 || count > buffer.Length - offset)
			{
				throw new ArgumentOutOfRangeException("count");
			}
			if (this._stream.CanSeek && this._stream.Position != this._lPosition)
			{
				this._stream.Seek(this._lPosition, SeekOrigin.Begin);
			}
			this._stream.Write(buffer, offset, count);
			this._lPosition += (long)count;
		}

		// Token: 0x06000DF0 RID: 3568 RVA: 0x00046BB8 File Offset: 0x00044DB8
		public override int ReadByte()
		{
			this.ThrowIfStreamClosed("ReadByte");
			this.ThrowIfStreamCannotRead("ReadByte");
			if (this._stream.CanSeek && this._lPosition >= this._stream.Length)
			{
				return -1;
			}
			if (this._stream.CanSeek && this._stream.Position != this._lPosition)
			{
				this._stream.Seek(this._lPosition, SeekOrigin.Begin);
			}
			int result = this._stream.ReadByte();
			this._lPosition += 1L;
			return result;
		}

		// Token: 0x06000DF1 RID: 3569 RVA: 0x00046C4C File Offset: 0x00044E4C
		public override void WriteByte(byte value)
		{
			this.ThrowIfStreamClosed("WriteByte");
			this.ThrowIfStreamCannotWrite("WriteByte");
			if (this._stream.CanSeek && this._stream.Position != this._lPosition)
			{
				this._stream.Seek(this._lPosition, SeekOrigin.Begin);
			}
			this._stream.WriteByte(value);
			this._lPosition += 1L;
		}

		// Token: 0x06000DF2 RID: 3570 RVA: 0x00046CBD File Offset: 0x00044EBD
		public override void SetLength(long value)
		{
			this.ThrowIfStreamClosed("SetLength");
			this.ThrowIfStreamCannotSeek("SetLength");
			this._stream.SetLength(value);
			if (this._lPosition > value)
			{
				this._lPosition = value;
			}
		}

		// Token: 0x06000DF3 RID: 3571 RVA: 0x00046CF1 File Offset: 0x00044EF1
		public override void Flush()
		{
			if (this._stream != null)
			{
				this._stream.Flush();
			}
		}

		// Token: 0x06000DF4 RID: 3572 RVA: 0x00046D08 File Offset: 0x00044F08
		protected override void Dispose(bool disposing)
		{
			try
			{
				this._isClosed = true;
			}
			finally
			{
				base.Dispose(disposing);
			}
		}

		// Token: 0x06000DF5 RID: 3573 RVA: 0x00046D38 File Offset: 0x00044F38
		private void ThrowIfStreamCannotSeek(string method)
		{
			if (!this._stream.CanSeek)
			{
				throw new NotSupportedException(SQLResource.InvalidOpStreamNonSeekable(method));
			}
		}

		// Token: 0x06000DF6 RID: 3574 RVA: 0x00046D53 File Offset: 0x00044F53
		private void ThrowIfStreamCannotRead(string method)
		{
			if (!this._stream.CanRead)
			{
				throw new NotSupportedException(SQLResource.InvalidOpStreamNonReadable(method));
			}
		}

		// Token: 0x06000DF7 RID: 3575 RVA: 0x00046D6E File Offset: 0x00044F6E
		private void ThrowIfStreamCannotWrite(string method)
		{
			if (!this._stream.CanWrite)
			{
				throw new NotSupportedException(SQLResource.InvalidOpStreamNonWritable(method));
			}
		}

		// Token: 0x06000DF8 RID: 3576 RVA: 0x00046D89 File Offset: 0x00044F89
		private void ThrowIfStreamClosed(string method)
		{
			if (this.IsStreamClosed())
			{
				throw new ObjectDisposedException(SQLResource.InvalidOpStreamClosed(method));
			}
		}

		// Token: 0x06000DF9 RID: 3577 RVA: 0x00046D9F File Offset: 0x00044F9F
		private bool IsStreamClosed()
		{
			return this._isClosed || this._stream == null || (!this._stream.CanRead && !this._stream.CanWrite && !this._stream.CanSeek);
		}

		// Token: 0x04000467 RID: 1127
		private Stream _stream;

		// Token: 0x04000468 RID: 1128
		private long _lPosition;

		// Token: 0x04000469 RID: 1129
		private bool _isClosed;
	}
}
