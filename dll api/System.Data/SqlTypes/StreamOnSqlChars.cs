using System;
using System.Data.Common;
using System.IO;
using System.Runtime.CompilerServices;

namespace System.Data.SqlTypes
{
	// Token: 0x020000B5 RID: 181
	internal sealed class StreamOnSqlChars : SqlStreamChars
	{
		// Token: 0x06000B1B RID: 2843 RVA: 0x0003E478 File Offset: 0x0003C678
		internal StreamOnSqlChars(SqlChars s)
		{
			this._sqlchars = s;
			this._lPosition = 0L;
		}

		// Token: 0x170001A5 RID: 421
		// (get) Token: 0x06000B1C RID: 2844 RVA: 0x0003E48F File Offset: 0x0003C68F
		public override bool IsNull
		{
			get
			{
				return this._sqlchars == null || this._sqlchars.IsNull;
			}
		}

		// Token: 0x170001A6 RID: 422
		// (get) Token: 0x06000B1D RID: 2845 RVA: 0x0003E4A6 File Offset: 0x0003C6A6
		public override long Length
		{
			get
			{
				this.CheckIfStreamClosed("get_Length");
				return this._sqlchars.Length;
			}
		}

		// Token: 0x170001A7 RID: 423
		// (get) Token: 0x06000B1E RID: 2846 RVA: 0x0003E4BE File Offset: 0x0003C6BE
		public override long Position
		{
			get
			{
				this.CheckIfStreamClosed("get_Position");
				return this._lPosition;
			}
		}

		// Token: 0x06000B1F RID: 2847 RVA: 0x0003E4D4 File Offset: 0x0003C6D4
		public override long Seek(long offset, SeekOrigin origin)
		{
			this.CheckIfStreamClosed("Seek");
			switch (origin)
			{
			case SeekOrigin.Begin:
				if (offset < 0L || offset > this._sqlchars.Length)
				{
					throw ADP.ArgumentOutOfRange("offset");
				}
				this._lPosition = offset;
				break;
			case SeekOrigin.Current:
			{
				long num = this._lPosition + offset;
				if (num < 0L || num > this._sqlchars.Length)
				{
					throw ADP.ArgumentOutOfRange("offset");
				}
				this._lPosition = num;
				break;
			}
			case SeekOrigin.End:
			{
				long num = this._sqlchars.Length + offset;
				if (num < 0L || num > this._sqlchars.Length)
				{
					throw ADP.ArgumentOutOfRange("offset");
				}
				this._lPosition = num;
				break;
			}
			default:
				throw ADP.ArgumentOutOfRange("offset");
			}
			return this._lPosition;
		}

		// Token: 0x06000B20 RID: 2848 RVA: 0x0003E5A4 File Offset: 0x0003C7A4
		public override int Read(char[] buffer, int offset, int count)
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
			int num = (int)this._sqlchars.Read(this._lPosition, buffer, offset, count);
			this._lPosition += (long)num;
			return num;
		}

		// Token: 0x06000B21 RID: 2849 RVA: 0x0003E61C File Offset: 0x0003C81C
		public override void Write(char[] buffer, int offset, int count)
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
			this._sqlchars.Write(this._lPosition, buffer, offset, count);
			this._lPosition += (long)count;
		}

		// Token: 0x06000B22 RID: 2850 RVA: 0x0003E691 File Offset: 0x0003C891
		public override void SetLength(long value)
		{
			this.CheckIfStreamClosed("SetLength");
			this._sqlchars.SetLength(value);
			if (this._lPosition > value)
			{
				this._lPosition = value;
			}
		}

		// Token: 0x06000B23 RID: 2851 RVA: 0x0003E6BA File Offset: 0x0003C8BA
		protected override void Dispose(bool disposing)
		{
			this._sqlchars = null;
		}

		// Token: 0x06000B24 RID: 2852 RVA: 0x0003E6C3 File Offset: 0x0003C8C3
		private bool FClosed()
		{
			return this._sqlchars == null;
		}

		// Token: 0x06000B25 RID: 2853 RVA: 0x0003E6CE File Offset: 0x0003C8CE
		private void CheckIfStreamClosed([CallerMemberName] string methodname = "")
		{
			if (this.FClosed())
			{
				throw ADP.StreamClosed(methodname);
			}
		}

		// Token: 0x040003A8 RID: 936
		private SqlChars _sqlchars;

		// Token: 0x040003A9 RID: 937
		private long _lPosition;
	}
}
