using System;
using System.IO;

namespace System.Net
{
	// Token: 0x0200018F RID: 399
	internal sealed class FileWebStream : FileStream, ICloseEx
	{
		// Token: 0x06000AE1 RID: 2785 RVA: 0x00039B2C File Offset: 0x00037D2C
		public FileWebStream(FileWebRequest request, string path, FileMode mode, FileAccess access, FileShare sharing) : base(path, mode, access, sharing)
		{
			this.m_request = request;
		}

		// Token: 0x06000AE2 RID: 2786 RVA: 0x00039B41 File Offset: 0x00037D41
		public FileWebStream(FileWebRequest request, string path, FileMode mode, FileAccess access, FileShare sharing, int length, bool async) : base(path, mode, access, sharing, length, async)
		{
			this.m_request = request;
		}

		// Token: 0x06000AE3 RID: 2787 RVA: 0x00039B5C File Offset: 0x00037D5C
		protected override void Dispose(bool disposing)
		{
			try
			{
				if (disposing && this.m_request != null)
				{
					this.m_request.UnblockReader();
				}
			}
			finally
			{
				base.Dispose(disposing);
			}
		}

		// Token: 0x06000AE4 RID: 2788 RVA: 0x00039B9C File Offset: 0x00037D9C
		void ICloseEx.CloseEx(CloseExState closeState)
		{
			if ((closeState & CloseExState.Abort) != CloseExState.Normal)
			{
				this.SafeFileHandle.Close();
				return;
			}
			this.Close();
		}

		// Token: 0x06000AE5 RID: 2789 RVA: 0x00039BB8 File Offset: 0x00037DB8
		public override int Read(byte[] buffer, int offset, int size)
		{
			this.CheckError();
			int result;
			try
			{
				result = base.Read(buffer, offset, size);
			}
			catch
			{
				this.CheckError();
				throw;
			}
			return result;
		}

		// Token: 0x06000AE6 RID: 2790 RVA: 0x00039BF4 File Offset: 0x00037DF4
		public override void Write(byte[] buffer, int offset, int size)
		{
			this.CheckError();
			try
			{
				base.Write(buffer, offset, size);
			}
			catch
			{
				this.CheckError();
				throw;
			}
		}

		// Token: 0x06000AE7 RID: 2791 RVA: 0x00039C2C File Offset: 0x00037E2C
		public override IAsyncResult BeginRead(byte[] buffer, int offset, int size, AsyncCallback callback, object state)
		{
			this.CheckError();
			IAsyncResult result;
			try
			{
				result = base.BeginRead(buffer, offset, size, callback, state);
			}
			catch
			{
				this.CheckError();
				throw;
			}
			return result;
		}

		// Token: 0x06000AE8 RID: 2792 RVA: 0x00039C6C File Offset: 0x00037E6C
		public override int EndRead(IAsyncResult ar)
		{
			int result;
			try
			{
				result = base.EndRead(ar);
			}
			catch
			{
				this.CheckError();
				throw;
			}
			return result;
		}

		// Token: 0x06000AE9 RID: 2793 RVA: 0x00039CA0 File Offset: 0x00037EA0
		public override IAsyncResult BeginWrite(byte[] buffer, int offset, int size, AsyncCallback callback, object state)
		{
			this.CheckError();
			IAsyncResult result;
			try
			{
				result = base.BeginWrite(buffer, offset, size, callback, state);
			}
			catch
			{
				this.CheckError();
				throw;
			}
			return result;
		}

		// Token: 0x06000AEA RID: 2794 RVA: 0x00039CE0 File Offset: 0x00037EE0
		public override void EndWrite(IAsyncResult ar)
		{
			try
			{
				base.EndWrite(ar);
			}
			catch
			{
				this.CheckError();
				throw;
			}
		}

		// Token: 0x06000AEB RID: 2795 RVA: 0x00039D10 File Offset: 0x00037F10
		private void CheckError()
		{
			if (this.m_request.Aborted)
			{
				throw new WebException(NetRes.GetWebStatusString("net_requestaborted", WebExceptionStatus.RequestCanceled), WebExceptionStatus.RequestCanceled);
			}
		}

		// Token: 0x040007F1 RID: 2033
		private FileWebRequest m_request;
	}
}
