using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Android.Gms.Tasks
{
	// Token: 0x0200000B RID: 11
	[Register("com/google/android/gms/tasks/CancellationToken", DoNotGenerateAcw = true)]
	public abstract class CancellationToken : Java.Lang.Object
	{
		// Token: 0x17000010 RID: 16
		// (get) Token: 0x06000085 RID: 133 RVA: 0x0000341C File Offset: 0x0000161C
		internal static IntPtr class_ref
		{
			get
			{
				return CancellationToken._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000011 RID: 17
		// (get) Token: 0x06000086 RID: 134 RVA: 0x00003440 File Offset: 0x00001640
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return CancellationToken._members;
			}
		}

		// Token: 0x17000012 RID: 18
		// (get) Token: 0x06000087 RID: 135 RVA: 0x00003448 File Offset: 0x00001648
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return CancellationToken._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000013 RID: 19
		// (get) Token: 0x06000088 RID: 136 RVA: 0x0000346C File Offset: 0x0000166C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return CancellationToken._members.ManagedPeerType;
			}
		}

		// Token: 0x06000089 RID: 137 RVA: 0x000020B4 File Offset: 0x000002B4
		protected CancellationToken(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x0600008A RID: 138 RVA: 0x00003478 File Offset: 0x00001678
		[Register(".ctor", "()V", "")]
		public CancellationToken() : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			base.SetHandle(CancellationToken._members.InstanceMethods.StartCreateInstance("()V", base.GetType(), null).Handle, JniHandleOwnership.TransferLocalRef);
			CancellationToken._members.InstanceMethods.FinishCreateInstance("()V", this, null);
		}

		// Token: 0x0600008B RID: 139 RVA: 0x000034E6 File Offset: 0x000016E6
		private static Delegate GetIsCancellationRequestedHandler()
		{
			if (CancellationToken.cb_isCancellationRequested == null)
			{
				CancellationToken.cb_isCancellationRequested = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(CancellationToken.n_IsCancellationRequested));
			}
			return CancellationToken.cb_isCancellationRequested;
		}

		// Token: 0x0600008C RID: 140 RVA: 0x0000350A File Offset: 0x0000170A
		private static bool n_IsCancellationRequested(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<CancellationToken>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).IsCancellationRequested;
		}

		// Token: 0x17000014 RID: 20
		// (get) Token: 0x0600008D RID: 141
		public abstract bool IsCancellationRequested { [Register("isCancellationRequested", "()Z", "GetIsCancellationRequestedHandler")] get; }

		// Token: 0x0600008E RID: 142 RVA: 0x00003519 File Offset: 0x00001719
		private static Delegate GetOnCanceledRequested_Lcom_google_android_gms_tasks_OnTokenCanceledListener_Handler()
		{
			if (CancellationToken.cb_onCanceledRequested_Lcom_google_android_gms_tasks_OnTokenCanceledListener_ == null)
			{
				CancellationToken.cb_onCanceledRequested_Lcom_google_android_gms_tasks_OnTokenCanceledListener_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(CancellationToken.n_OnCanceledRequested_Lcom_google_android_gms_tasks_OnTokenCanceledListener_));
			}
			return CancellationToken.cb_onCanceledRequested_Lcom_google_android_gms_tasks_OnTokenCanceledListener_;
		}

		// Token: 0x0600008F RID: 143 RVA: 0x00003540 File Offset: 0x00001740
		private static IntPtr n_OnCanceledRequested_Lcom_google_android_gms_tasks_OnTokenCanceledListener_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			CancellationToken @object = Java.Lang.Object.GetObject<CancellationToken>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			IOnTokenCanceledListener object2 = Java.Lang.Object.GetObject<IOnTokenCanceledListener>(native_p0, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.OnCanceledRequested(object2));
		}

		// Token: 0x06000090 RID: 144
		[Register("onCanceledRequested", "(Lcom/google/android/gms/tasks/OnTokenCanceledListener;)Lcom/google/android/gms/tasks/CancellationToken;", "GetOnCanceledRequested_Lcom_google_android_gms_tasks_OnTokenCanceledListener_Handler")]
		public abstract CancellationToken OnCanceledRequested(IOnTokenCanceledListener p0);

		// Token: 0x04000020 RID: 32
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/google/android/gms/tasks/CancellationToken", typeof(CancellationToken));

		// Token: 0x04000021 RID: 33
		private static Delegate cb_isCancellationRequested;

		// Token: 0x04000022 RID: 34
		private static Delegate cb_onCanceledRequested_Lcom_google_android_gms_tasks_OnTokenCanceledListener_;
	}
}
