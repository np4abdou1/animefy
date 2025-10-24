using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Com.Applovin.Impl.Sdk.Utils
{
	// Token: 0x02000137 RID: 311
	[Register("com/applovin/impl/sdk/utils/AppKilledService", DoNotGenerateAcw = true)]
	public class AppKilledService : Service
	{
		// Token: 0x170003B3 RID: 947
		// (get) Token: 0x06000E42 RID: 3650 RVA: 0x00026A5C File Offset: 0x00024C5C
		internal static IntPtr class_ref
		{
			get
			{
				return AppKilledService._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170003B4 RID: 948
		// (get) Token: 0x06000E43 RID: 3651 RVA: 0x00026A80 File Offset: 0x00024C80
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return AppKilledService._members;
			}
		}

		// Token: 0x170003B5 RID: 949
		// (get) Token: 0x06000E44 RID: 3652 RVA: 0x00026A88 File Offset: 0x00024C88
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return AppKilledService._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170003B6 RID: 950
		// (get) Token: 0x06000E45 RID: 3653 RVA: 0x00026AAC File Offset: 0x00024CAC
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return AppKilledService._members.ManagedPeerType;
			}
		}

		// Token: 0x06000E46 RID: 3654 RVA: 0x00026AB8 File Offset: 0x00024CB8
		protected AppKilledService(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06000E47 RID: 3655 RVA: 0x00026AC4 File Offset: 0x00024CC4
		[Register(".ctor", "()V", "")]
		public AppKilledService() : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			base.SetHandle(AppKilledService._members.InstanceMethods.StartCreateInstance("()V", base.GetType(), null).Handle, JniHandleOwnership.TransferLocalRef);
			AppKilledService._members.InstanceMethods.FinishCreateInstance("()V", this, null);
		}

		// Token: 0x06000E48 RID: 3656 RVA: 0x00026B32 File Offset: 0x00024D32
		private static Delegate GetOnBind_Landroid_content_Intent_Handler()
		{
			if (AppKilledService.cb_onBind_Landroid_content_Intent_ == null)
			{
				AppKilledService.cb_onBind_Landroid_content_Intent_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(AppKilledService.n_OnBind_Landroid_content_Intent_));
			}
			return AppKilledService.cb_onBind_Landroid_content_Intent_;
		}

		// Token: 0x06000E49 RID: 3657 RVA: 0x00026B58 File Offset: 0x00024D58
		private static IntPtr n_OnBind_Landroid_content_Intent_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			Service @object = Java.Lang.Object.GetObject<AppKilledService>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Intent object2 = Java.Lang.Object.GetObject<Intent>(native_p0, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.OnBind(object2));
		}

		// Token: 0x06000E4A RID: 3658 RVA: 0x00026B80 File Offset: 0x00024D80
		[Register("onBind", "(Landroid/content/Intent;)Landroid/os/IBinder;", "GetOnBind_Landroid_content_Intent_Handler")]
		public unsafe override IBinder OnBind(Intent p0)
		{
			IBinder @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((p0 == null) ? IntPtr.Zero : p0.Handle);
				@object = Java.Lang.Object.GetObject<IBinder>(AppKilledService._members.InstanceMethods.InvokeVirtualObjectMethod("onBind.(Landroid/content/Intent;)Landroid/os/IBinder;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(p0);
			}
			return @object;
		}

		// Token: 0x040004E9 RID: 1257
		[Register("ACTION_APP_KILLED")]
		public const string ActionAppKilled = "com.applovin.app_killed";

		// Token: 0x040004EA RID: 1258
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/applovin/impl/sdk/utils/AppKilledService", typeof(AppKilledService));

		// Token: 0x040004EB RID: 1259
		private static Delegate cb_onBind_Landroid_content_Intent_;
	}
}
