using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;
using Java.Nio.Channels;

namespace Java.IO
{
	// Token: 0x02000415 RID: 1045
	[Register("java/io/FileInputStream", DoNotGenerateAcw = true)]
	public class FileInputStream : InputStream, ICloseable, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x17000944 RID: 2372
		// (get) Token: 0x06002DD3 RID: 11731 RVA: 0x0007DB37 File Offset: 0x0007BD37
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return FileInputStream._members;
			}
		}

		// Token: 0x17000945 RID: 2373
		// (get) Token: 0x06002DD4 RID: 11732 RVA: 0x0007DB40 File Offset: 0x0007BD40
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return FileInputStream._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000946 RID: 2374
		// (get) Token: 0x06002DD5 RID: 11733 RVA: 0x0007DB64 File Offset: 0x0007BD64
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return FileInputStream._members.ManagedPeerType;
			}
		}

		// Token: 0x06002DD6 RID: 11734 RVA: 0x0007DB70 File Offset: 0x0007BD70
		protected FileInputStream(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06002DD7 RID: 11735 RVA: 0x0007DB7A File Offset: 0x0007BD7A
		private static Delegate GetGetChannelHandler()
		{
			if (FileInputStream.cb_getChannel == null)
			{
				FileInputStream.cb_getChannel = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(FileInputStream.n_GetChannel));
			}
			return FileInputStream.cb_getChannel;
		}

		// Token: 0x06002DD8 RID: 11736 RVA: 0x0007DB9E File Offset: 0x0007BD9E
		private static IntPtr n_GetChannel(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<FileInputStream>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Channel);
		}

		// Token: 0x17000947 RID: 2375
		// (get) Token: 0x06002DD9 RID: 11737 RVA: 0x0007DBB4 File Offset: 0x0007BDB4
		public virtual FileChannel Channel
		{
			get
			{
				return Java.Lang.Object.GetObject<FileChannel>(FileInputStream._members.InstanceMethods.InvokeVirtualObjectMethod("getChannel.()Ljava/nio/channels/FileChannel;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x06002DDA RID: 11738 RVA: 0x0007DBE6 File Offset: 0x0007BDE6
		private static Delegate GetReadHandler()
		{
			if (FileInputStream.cb_read == null)
			{
				FileInputStream.cb_read = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(FileInputStream.n_Read));
			}
			return FileInputStream.cb_read;
		}

		// Token: 0x06002DDB RID: 11739 RVA: 0x0007DC0A File Offset: 0x0007BE0A
		private static int n_Read(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<FileInputStream>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Read();
		}

		// Token: 0x06002DDC RID: 11740 RVA: 0x0007DC19 File Offset: 0x0007BE19
		public override int Read()
		{
			return FileInputStream._members.InstanceMethods.InvokeVirtualInt32Method("read.()I", this, null);
		}

		// Token: 0x04001209 RID: 4617
		private static readonly JniPeerMembers _members = new XAPeerMembers("java/io/FileInputStream", typeof(FileInputStream));

		// Token: 0x0400120A RID: 4618
		private static Delegate cb_getChannel;

		// Token: 0x0400120B RID: 4619
		private static Delegate cb_read;
	}
}
