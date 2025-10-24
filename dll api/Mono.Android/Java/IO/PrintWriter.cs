using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Java.IO
{
	// Token: 0x02000422 RID: 1058
	[Register("java/io/PrintWriter", DoNotGenerateAcw = true)]
	public class PrintWriter : Writer
	{
		// Token: 0x17000964 RID: 2404
		// (get) Token: 0x06002E3B RID: 11835 RVA: 0x0007E7DA File Offset: 0x0007C9DA
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return PrintWriter._members;
			}
		}

		// Token: 0x17000965 RID: 2405
		// (get) Token: 0x06002E3C RID: 11836 RVA: 0x0007E7E4 File Offset: 0x0007C9E4
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return PrintWriter._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000966 RID: 2406
		// (get) Token: 0x06002E3D RID: 11837 RVA: 0x0007E808 File Offset: 0x0007CA08
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return PrintWriter._members.ManagedPeerType;
			}
		}

		// Token: 0x06002E3E RID: 11838 RVA: 0x0007E814 File Offset: 0x0007CA14
		protected PrintWriter(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06002E3F RID: 11839 RVA: 0x0007E820 File Offset: 0x0007CA20
		public unsafe PrintWriter(Writer @out) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((@out == null) ? IntPtr.Zero : @out.Handle);
				base.SetHandle(PrintWriter._members.InstanceMethods.StartCreateInstance("(Ljava/io/Writer;)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				PrintWriter._members.InstanceMethods.FinishCreateInstance("(Ljava/io/Writer;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(@out);
			}
		}

		// Token: 0x06002E40 RID: 11840 RVA: 0x0007E8D0 File Offset: 0x0007CAD0
		private static Delegate GetCloseHandler()
		{
			if (PrintWriter.cb_close == null)
			{
				PrintWriter.cb_close = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_V(PrintWriter.n_Close));
			}
			return PrintWriter.cb_close;
		}

		// Token: 0x06002E41 RID: 11841 RVA: 0x0007E8F4 File Offset: 0x0007CAF4
		private static void n_Close(IntPtr jnienv, IntPtr native__this)
		{
			Java.Lang.Object.GetObject<PrintWriter>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Close();
		}

		// Token: 0x06002E42 RID: 11842 RVA: 0x0007E903 File Offset: 0x0007CB03
		public override void Close()
		{
			PrintWriter._members.InstanceMethods.InvokeVirtualVoidMethod("close.()V", this, null);
		}

		// Token: 0x06002E43 RID: 11843 RVA: 0x0007E91C File Offset: 0x0007CB1C
		private static Delegate GetFlushHandler()
		{
			if (PrintWriter.cb_flush == null)
			{
				PrintWriter.cb_flush = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_V(PrintWriter.n_Flush));
			}
			return PrintWriter.cb_flush;
		}

		// Token: 0x06002E44 RID: 11844 RVA: 0x0007E940 File Offset: 0x0007CB40
		private static void n_Flush(IntPtr jnienv, IntPtr native__this)
		{
			Java.Lang.Object.GetObject<PrintWriter>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Flush();
		}

		// Token: 0x06002E45 RID: 11845 RVA: 0x0007E94F File Offset: 0x0007CB4F
		public override void Flush()
		{
			PrintWriter._members.InstanceMethods.InvokeVirtualVoidMethod("flush.()V", this, null);
		}

		// Token: 0x04001226 RID: 4646
		private static readonly JniPeerMembers _members = new XAPeerMembers("java/io/PrintWriter", typeof(PrintWriter));

		// Token: 0x04001227 RID: 4647
		private static Delegate cb_close;

		// Token: 0x04001228 RID: 4648
		private static Delegate cb_flush;
	}
}
