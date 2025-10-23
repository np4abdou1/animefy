using System;
using System.IO;
using Java.IO;

namespace Android.Runtime
{
	// Token: 0x020002C9 RID: 713
	[Register("mono/android/runtime/InputStreamAdapter")]
	public sealed class InputStreamAdapter : InputStream
	{
		// Token: 0x170005C4 RID: 1476
		// (get) Token: 0x06001AF4 RID: 6900 RVA: 0x000465F2 File Offset: 0x000447F2
		// (set) Token: 0x06001AF5 RID: 6901 RVA: 0x000465FA File Offset: 0x000447FA
		public Stream BaseStream { get; private set; }

		// Token: 0x06001AF6 RID: 6902 RVA: 0x00046603 File Offset: 0x00044803
		public InputStreamAdapter(Stream stream) : base(JNIEnv.StartCreateInstance("mono/android/runtime/InputStreamAdapter", "()V", Array.Empty<JValue>()), JniHandleOwnership.TransferLocalRef)
		{
			JNIEnv.FinishCreateInstance(base.Handle, "()V", Array.Empty<JValue>());
			this.BaseStream = stream;
		}

		// Token: 0x06001AF7 RID: 6903 RVA: 0x0004663C File Offset: 0x0004483C
		public override void Close()
		{
			this.BaseStream.Close();
		}

		// Token: 0x06001AF8 RID: 6904 RVA: 0x00046649 File Offset: 0x00044849
		public override int Read()
		{
			return this.BaseStream.ReadByte();
		}

		// Token: 0x06001AF9 RID: 6905 RVA: 0x00046656 File Offset: 0x00044856
		public override int Read(byte[] bytes)
		{
			return this.Read(bytes, 0, bytes.Length);
		}

		// Token: 0x06001AFA RID: 6906 RVA: 0x00046664 File Offset: 0x00044864
		public override int Read(byte[] bytes, int offset, int length)
		{
			int num = this.BaseStream.Read(bytes, offset, length);
			if (num == 0)
			{
				return -1;
			}
			return num;
		}

		// Token: 0x06001AFB RID: 6907 RVA: 0x00046688 File Offset: 0x00044888
		public static IntPtr ToLocalJniHandle(Stream value)
		{
			if (value == null)
			{
				return IntPtr.Zero;
			}
			InputStreamInvoker inputStreamInvoker = value as InputStreamInvoker;
			if (inputStreamInvoker != null)
			{
				return JNIEnv.ToLocalJniHandle(inputStreamInvoker.BaseInputStream);
			}
			return JNIEnv.ToLocalJniHandle(new InputStreamAdapter(value));
		}
	}
}
