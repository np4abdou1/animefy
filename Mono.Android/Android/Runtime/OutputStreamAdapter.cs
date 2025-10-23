using System;
using System.IO;
using Java.IO;

namespace Android.Runtime
{
	// Token: 0x020002EF RID: 751
	[Register("mono/android/runtime/OutputStreamAdapter")]
	public class OutputStreamAdapter : OutputStream
	{
		// Token: 0x1700060B RID: 1547
		// (get) Token: 0x06001DC7 RID: 7623 RVA: 0x00051AFE File Offset: 0x0004FCFE
		// (set) Token: 0x06001DC8 RID: 7624 RVA: 0x00051B06 File Offset: 0x0004FD06
		public Stream BaseStream { get; private set; }

		// Token: 0x06001DC9 RID: 7625 RVA: 0x00051B0F File Offset: 0x0004FD0F
		public OutputStreamAdapter(Stream stream) : base(JNIEnv.StartCreateInstance("mono/android/runtime/OutputStreamAdapter", "()V", Array.Empty<JValue>()), JniHandleOwnership.TransferLocalRef)
		{
			JNIEnv.FinishCreateInstance(base.Handle, "()V", Array.Empty<JValue>());
			this.BaseStream = stream;
		}

		// Token: 0x06001DCA RID: 7626 RVA: 0x00051B48 File Offset: 0x0004FD48
		public override void Close()
		{
			this.BaseStream.Close();
		}

		// Token: 0x06001DCB RID: 7627 RVA: 0x00051B55 File Offset: 0x0004FD55
		public override void Flush()
		{
			this.BaseStream.Flush();
		}

		// Token: 0x06001DCC RID: 7628 RVA: 0x00051B62 File Offset: 0x0004FD62
		public override void Write(byte[] buffer)
		{
			this.BaseStream.Write(buffer, 0, (buffer != null) ? buffer.Length : 0);
		}

		// Token: 0x06001DCD RID: 7629 RVA: 0x00051B7A File Offset: 0x0004FD7A
		public override void Write(byte[] buffer, int offset, int length)
		{
			this.BaseStream.Write(buffer, offset, length);
		}

		// Token: 0x06001DCE RID: 7630 RVA: 0x00051B8A File Offset: 0x0004FD8A
		public override void Write(int oneByte)
		{
			this.BaseStream.WriteByte((byte)oneByte);
		}

		// Token: 0x06001DCF RID: 7631 RVA: 0x00051B9C File Offset: 0x0004FD9C
		public static IntPtr ToLocalJniHandle(Stream value)
		{
			if (value == null)
			{
				return IntPtr.Zero;
			}
			OutputStreamInvoker outputStreamInvoker = value as OutputStreamInvoker;
			if (outputStreamInvoker != null)
			{
				return JNIEnv.ToLocalJniHandle(outputStreamInvoker.BaseOutputStream);
			}
			return JNIEnv.ToLocalJniHandle(new OutputStreamAdapter(value));
		}
	}
}
