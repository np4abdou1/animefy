using System;
using System.IO;
using Java.Interop;
using Java.IO;
using Java.Lang;

namespace Android.Runtime
{
	// Token: 0x020002F0 RID: 752
	public class OutputStreamInvoker : Stream
	{
		// Token: 0x1700060C RID: 1548
		// (get) Token: 0x06001DD0 RID: 7632 RVA: 0x00051BD3 File Offset: 0x0004FDD3
		// (set) Token: 0x06001DD1 RID: 7633 RVA: 0x00051BDB File Offset: 0x0004FDDB
		public OutputStream BaseOutputStream { get; private set; }

		// Token: 0x06001DD2 RID: 7634 RVA: 0x00051BE4 File Offset: 0x0004FDE4
		public OutputStreamInvoker(OutputStream stream)
		{
			if (stream == null)
			{
				throw new ArgumentNullException("stream");
			}
			this.BaseOutputStream = stream;
		}

		// Token: 0x06001DD3 RID: 7635 RVA: 0x00051C04 File Offset: 0x0004FE04
		public override void Close()
		{
			try
			{
				this.BaseOutputStream.Close();
			}
			catch (Java.IO.IOException ex) when (JNIEnv.ShouldWrapJavaException(ex, "Close"))
			{
				throw new System.IO.IOException(ex.Message, ex);
			}
		}

		// Token: 0x06001DD4 RID: 7636 RVA: 0x00051C5C File Offset: 0x0004FE5C
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.BaseOutputStream != null)
			{
				try
				{
					this.BaseOutputStream.Close();
					this.BaseOutputStream.Dispose();
				}
				catch (Java.IO.IOException ex) when (JNIEnv.ShouldWrapJavaException(ex, "Dispose"))
				{
					throw new System.IO.IOException(ex.Message, ex);
				}
			}
		}

		// Token: 0x06001DD5 RID: 7637 RVA: 0x00051CC8 File Offset: 0x0004FEC8
		public override void Flush()
		{
			try
			{
				this.BaseOutputStream.Flush();
			}
			catch (Java.IO.IOException ex) when (JNIEnv.ShouldWrapJavaException(ex, "Flush"))
			{
				throw new System.IO.IOException(ex.Message, ex);
			}
		}

		// Token: 0x06001DD6 RID: 7638 RVA: 0x000029D4 File Offset: 0x00000BD4
		public override int Read(byte[] buffer, int offset, int count)
		{
			throw new NotSupportedException();
		}

		// Token: 0x06001DD7 RID: 7639 RVA: 0x000029D4 File Offset: 0x00000BD4
		public override long Seek(long offset, SeekOrigin origin)
		{
			throw new NotSupportedException();
		}

		// Token: 0x06001DD8 RID: 7640 RVA: 0x000029D4 File Offset: 0x00000BD4
		public override void SetLength(long value)
		{
			throw new NotSupportedException();
		}

		// Token: 0x06001DD9 RID: 7641 RVA: 0x00051D20 File Offset: 0x0004FF20
		public override void Write(byte[] buffer, int offset, int count)
		{
			try
			{
				this.BaseOutputStream.Write(buffer, offset, count);
			}
			catch (Java.IO.IOException ex) when (JNIEnv.ShouldWrapJavaException(ex, "Write"))
			{
				throw new System.IO.IOException(ex.Message, ex);
			}
		}

		// Token: 0x1700060D RID: 1549
		// (get) Token: 0x06001DDA RID: 7642 RVA: 0x00045ABE File Offset: 0x00043CBE
		public override bool CanRead
		{
			get
			{
				return false;
			}
		}

		// Token: 0x1700060E RID: 1550
		// (get) Token: 0x06001DDB RID: 7643 RVA: 0x00045ABE File Offset: 0x00043CBE
		public override bool CanSeek
		{
			get
			{
				return false;
			}
		}

		// Token: 0x1700060F RID: 1551
		// (get) Token: 0x06001DDC RID: 7644 RVA: 0x000468CD File Offset: 0x00044ACD
		public override bool CanWrite
		{
			get
			{
				return true;
			}
		}

		// Token: 0x17000610 RID: 1552
		// (get) Token: 0x06001DDD RID: 7645 RVA: 0x000029D4 File Offset: 0x00000BD4
		public override long Length
		{
			get
			{
				throw new NotSupportedException();
			}
		}

		// Token: 0x17000611 RID: 1553
		// (get) Token: 0x06001DDE RID: 7646 RVA: 0x000029D4 File Offset: 0x00000BD4
		// (set) Token: 0x06001DDF RID: 7647 RVA: 0x000029D4 File Offset: 0x00000BD4
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

		// Token: 0x06001DE0 RID: 7648 RVA: 0x00051D78 File Offset: 0x0004FF78
		public static Stream FromJniHandle(IntPtr handle, JniHandleOwnership transfer)
		{
			return OutputStreamInvoker.FromNative(handle, transfer);
		}

		// Token: 0x06001DE1 RID: 7649 RVA: 0x00051D84 File Offset: 0x0004FF84
		internal static Stream FromNative(IntPtr handle, JniHandleOwnership transfer)
		{
			if (handle == IntPtr.Zero)
			{
				return null;
			}
			IJavaObject javaObject = (IJavaObject)Java.Lang.Object.PeekObject(handle, null);
			if (javaObject == null)
			{
				javaObject = (IJavaObject)TypeManager.CreateInstance(handle, transfer);
			}
			else
			{
				JNIEnv.DeleteRef(handle, transfer);
			}
			return new OutputStreamInvoker((OutputStream)javaObject);
		}
	}
}
