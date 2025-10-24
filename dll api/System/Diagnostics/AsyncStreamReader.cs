using System;
using System.IO;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;

namespace System.Diagnostics
{
	// Token: 0x020000CA RID: 202
	internal class AsyncStreamReader
	{
		// Token: 0x060005F0 RID: 1520 RVA: 0x000247F8 File Offset: 0x000229F8
		public virtual void Close()
		{
			this.Dispose(true);
		}

		// Token: 0x060005F1 RID: 1521 RVA: 0x00024804 File Offset: 0x00022A04
		protected virtual void Dispose(bool disposing)
		{
			object obj = this.syncObject;
			lock (obj)
			{
				if (disposing && this.stream != null)
				{
					if (this.asyncReadResult != null && !this.asyncReadResult.IsCompleted && this.stream is FileStream)
					{
						SafeHandle safeFileHandle = ((FileStream)this.stream).SafeFileHandle;
						MonoIOError monoIOError;
						while (!this.asyncReadResult.IsCompleted && (MonoIO.Cancel(safeFileHandle, out monoIOError) || monoIOError != MonoIOError.ERROR_NOT_SUPPORTED))
						{
							this.asyncReadResult.AsyncWaitHandle.WaitOne(200);
						}
					}
					this.stream.Close();
				}
				if (this.stream != null)
				{
					this.stream = null;
					this.encoding = null;
					this.decoder = null;
					this.byteBuffer = null;
					this.charBuffer = null;
				}
				if (this.eofEvent != null)
				{
					this.eofEvent.Close();
					this.eofEvent = null;
				}
			}
		}

		// Token: 0x060005F2 RID: 1522 RVA: 0x00024900 File Offset: 0x00022B00
		internal void CancelOperation()
		{
			this.cancelOperation = true;
		}

		// Token: 0x040003D1 RID: 977
		private Stream stream;

		// Token: 0x040003D2 RID: 978
		private Encoding encoding;

		// Token: 0x040003D3 RID: 979
		private Decoder decoder;

		// Token: 0x040003D4 RID: 980
		private byte[] byteBuffer;

		// Token: 0x040003D5 RID: 981
		private char[] charBuffer;

		// Token: 0x040003D6 RID: 982
		private bool cancelOperation;

		// Token: 0x040003D7 RID: 983
		private ManualResetEvent eofEvent;

		// Token: 0x040003D8 RID: 984
		private object syncObject;

		// Token: 0x040003D9 RID: 985
		private IAsyncResult asyncReadResult;
	}
}
