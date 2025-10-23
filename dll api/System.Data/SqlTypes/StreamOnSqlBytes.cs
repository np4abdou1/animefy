using System;
using System.Data.Common;
using System.IO;
using System.Runtime.CompilerServices;

namespace System.Data.SqlTypes
{
	// Token: 0x020000B3 RID: 179
	internal sealed class StreamOnSqlBytes : Stream
	{
		// Token: 0x06000AEB RID: 2795 RVA: 0x0003D9A7 File Offset: 0x0003BBA7
		internal StreamOnSqlBytes(SqlBytes sb)
		{
			this._sb = sb;
			this._lPosition = 0L;
		}

		// Token: 0x17000197 RID: 407
		// (get) Token: 0x06000AEC RID: 2796 RVA: 0x0003D9BE File Offset: 0x0003BBBE
		public override bool CanRead
		{
			get
			{
				return this._sb != null && !this._sb.IsNull;
			}
		}

		// Token: 0x17000198 RID: 408
		// (get) Token: 0x06000AED RID: 2797 RVA: 0x0003D9D8 File Offset: 0x0003BBD8
		public override bool CanSeek
		{
			get
			{
				return this._sb != null;
			}
		}

		// Token: 0x17000199 RID: 409
		// (get) Token: 0x06000AEE RID: 2798 RVA: 0x0003D9E3 File Offset: 0x0003BBE3
		public override bool CanWrite
		{
			get
			{
				return this._sb != null && (!this._sb.IsNull || this._sb._rgbBuf != null);
			}
		}

		// Token: 0x1700019A RID: 410
		// (get) Token: 0x06000AEF RID: 2799 RVA: 0x0003DA0C File Offset: 0x0003BC0C
		public override long Length
		{
			get
			{
				this.CheckIfStreamClosed("get_Length");
				return this._sb.Length;
			}
		}

		// Token: 0x1700019B RID: 411
		// (get) Token: 0x06000AF0 RID: 2800 RVA: 0x0003DA24 File Offset: 0x0003BC24
		// (set) Token: 0x06000AF1 RID: 2801 RVA: 0x0003DA37 File Offset: 0x0003BC37
		public override long Position
		{
			get
			{
				this.CheckIfStreamClosed("get_Position");
				return this._lPosition;
			}
			set
			{
				this.CheckIfStreamClosed("set_Position");
				if (value < 0L || value > this._sb.Length)
				{
					throw new ArgumentOutOfRangeException("value");
				}
				this._lPosition = value;
			}
		}

		// Token: 0x06000AF2 RID: 2802 RVA: 0x0003DA6C File Offset: 0x0003BC6C
		public override long Seek(long offset, SeekOrigin origin)
		{
			this.CheckIfStreamClosed("Seek");
			switch (origin)
			{
			case SeekOrigin.Begin:
				if (offset < 0L || offset > this._sb.Length)
				{
					throw new ArgumentOutOfRangeException("offset");
				}
				this._lPosition = offset;
				break;
			case SeekOrigin.Current:
			{
				long num = this._lPosition + offset;
				if (num < 0L || num > this._sb.Length)
				{
					throw new ArgumentOutOfRangeException("offset");
				}
				this._lPosition = num;
				break;
			}
			case SeekOrigin.End:
			{
				long num = this._sb.Length + offset;
				if (num < 0L || num > this._sb.Length)
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

		// Token: 0x06000AF3 RID: 2803 RVA: 0x0003DB3C File Offset: 0x0003BD3C
		public override int Read(byte[] buffer, int offset, int count)
		{
			this.CheckIfStreamClosed("Read");
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
			int num = (int)this._sb.Read(this._lPosition, buffer, offset, count);
			this._lPosition += (long)num;
			return num;
		}

		// Token: 0x06000AF4 RID: 2804 RVA: 0x0003DBB4 File Offset: 0x0003BDB4
		public override void Write(byte[] buffer, int offset, int count)
		{
			this.CheckIfStreamClosed("Write");
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
			this._sb.Write(this._lPosition, buffer, offset, count);
			this._lPosition += (long)count;
		}

		// Token: 0x06000AF5 RID: 2805 RVA: 0x0003DC2C File Offset: 0x0003BE2C
		public override int ReadByte()
		{
			this.CheckIfStreamClosed("ReadByte");
			if (this._lPosition >= this._sb.Length)
			{
				return -1;
			}
			int result = (int)this._sb[this._lPosition];
			this._lPosition += 1L;
			return result;
		}

		// Token: 0x06000AF6 RID: 2806 RVA: 0x0003DC79 File Offset: 0x0003BE79
		public override void WriteByte(byte value)
		{
			this.CheckIfStreamClosed("WriteByte");
			this._sb[this._lPosition] = value;
			this._lPosition += 1L;
		}

		// Token: 0x06000AF7 RID: 2807 RVA: 0x0003DCA7 File Offset: 0x0003BEA7
		public override void SetLength(long value)
		{
			this.CheckIfStreamClosed("SetLength");
			this._sb.SetLength(value);
			if (this._lPosition > value)
			{
				this._lPosition = value;
			}
		}

		// Token: 0x06000AF8 RID: 2808 RVA: 0x0003DCD0 File Offset: 0x0003BED0
		public override void Flush()
		{
			if (this._sb.FStream())
			{
				this._sb._stream.Flush();
			}
		}

		// Token: 0x06000AF9 RID: 2809 RVA: 0x0003DCF0 File Offset: 0x0003BEF0
		protected override void Dispose(bool disposing)
		{
			try
			{
				this._sb = null;
			}
			finally
			{
				base.Dispose(disposing);
			}
		}

		// Token: 0x06000AFA RID: 2810 RVA: 0x0003DD20 File Offset: 0x0003BF20
		private bool FClosed()
		{
			return this._sb == null;
		}

		// Token: 0x06000AFB RID: 2811 RVA: 0x0003DD2B File Offset: 0x0003BF2B
		private void CheckIfStreamClosed([CallerMemberName] string methodname = "")
		{
			if (this.FClosed())
			{
				throw ADP.StreamClosed(methodname);
			}
		}

		// Token: 0x0400039F RID: 927
		private SqlBytes _sb;

		// Token: 0x040003A0 RID: 928
		private long _lPosition;
	}
}
