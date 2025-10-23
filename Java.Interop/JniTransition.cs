using System;

namespace Java.Interop
{
	// Token: 0x02000085 RID: 133
	public struct JniTransition : IDisposable
	{
		// Token: 0x06000445 RID: 1093 RVA: 0x0000FE08 File Offset: 0x0000E008
		public JniTransition(IntPtr environmentPointer)
		{
			this.disposed = false;
			this.pendingException = null;
			JniEnvironment.SetEnvironmentPointer(environmentPointer);
		}

		// Token: 0x06000446 RID: 1094 RVA: 0x0000FE1E File Offset: 0x0000E01E
		public void SetPendingException(Exception exception)
		{
			if (this.disposed)
			{
				throw new ObjectDisposedException("JniTransition");
			}
			this.pendingException = exception;
		}

		// Token: 0x06000447 RID: 1095 RVA: 0x0000FE3A File Offset: 0x0000E03A
		public void Dispose()
		{
			if (this.disposed)
			{
				return;
			}
			this.disposed = true;
			if (this.pendingException != null)
			{
				JniEnvironment.Runtime.RaisePendingException(this.pendingException);
				this.pendingException = null;
			}
		}

		// Token: 0x04000134 RID: 308
		private bool disposed;

		// Token: 0x04000135 RID: 309
		private Exception pendingException;
	}
}
