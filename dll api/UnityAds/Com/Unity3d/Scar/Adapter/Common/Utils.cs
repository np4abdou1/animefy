using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Com.Unity3d.Scar.Adapter.Common
{
	// Token: 0x020002A8 RID: 680
	[Register("com/unity3d/scar/adapter/common/Utils", DoNotGenerateAcw = true)]
	public class Utils : Java.Lang.Object
	{
		// Token: 0x17000EC6 RID: 3782
		// (get) Token: 0x060026E7 RID: 9959 RVA: 0x00064498 File Offset: 0x00062698
		internal static IntPtr class_ref
		{
			get
			{
				return Utils._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000EC7 RID: 3783
		// (get) Token: 0x060026E8 RID: 9960 RVA: 0x000644BC File Offset: 0x000626BC
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return Utils._members;
			}
		}

		// Token: 0x17000EC8 RID: 3784
		// (get) Token: 0x060026E9 RID: 9961 RVA: 0x000644C4 File Offset: 0x000626C4
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return Utils._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000EC9 RID: 3785
		// (get) Token: 0x060026EA RID: 9962 RVA: 0x000644E8 File Offset: 0x000626E8
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return Utils._members.ManagedPeerType;
			}
		}

		// Token: 0x060026EB RID: 9963 RVA: 0x000021E8 File Offset: 0x000003E8
		protected Utils(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x060026EC RID: 9964 RVA: 0x000644F4 File Offset: 0x000626F4
		[Register(".ctor", "()V", "")]
		public Utils() : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			base.SetHandle(Utils._members.InstanceMethods.StartCreateInstance("()V", base.GetType(), null).Handle, JniHandleOwnership.TransferLocalRef);
			Utils._members.InstanceMethods.FinishCreateInstance("()V", this, null);
		}

		// Token: 0x060026ED RID: 9965 RVA: 0x00064564 File Offset: 0x00062764
		[Register("runOnUiThread", "(Ljava/lang/Runnable;)V", "")]
		public unsafe static void RunOnUiThread(IRunnable runnable)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((runnable == null) ? IntPtr.Zero : ((Java.Lang.Object)runnable).Handle);
				Utils._members.StaticMethods.InvokeVoidMethod("runOnUiThread.(Ljava/lang/Runnable;)V", ptr);
			}
			finally
			{
				GC.KeepAlive(runnable);
			}
		}

		// Token: 0x060026EE RID: 9966 RVA: 0x000645CC File Offset: 0x000627CC
		[Register("runOnUiThread", "(Ljava/lang/Runnable;J)V", "")]
		public unsafe static void RunOnUiThread(IRunnable runnable, long delay)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((runnable == null) ? IntPtr.Zero : ((Java.Lang.Object)runnable).Handle);
				ptr[1] = new JniArgumentValue(delay);
				Utils._members.StaticMethods.InvokeVoidMethod("runOnUiThread.(Ljava/lang/Runnable;J)V", ptr);
			}
			finally
			{
				GC.KeepAlive(runnable);
			}
		}

		// Token: 0x040007B5 RID: 1973
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/unity3d/scar/adapter/common/Utils", typeof(Utils));
	}
}
