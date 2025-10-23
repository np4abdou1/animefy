using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.App;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Com.Unity3d.Scar.Adapter.V1950.Scarads
{
	// Token: 0x02000279 RID: 633
	[Register("com/unity3d/scar/adapter/v1950/scarads/ScarRewardedAd", DoNotGenerateAcw = true)]
	public class ScarRewardedAd : ScarAdBase
	{
		// Token: 0x17000D54 RID: 3412
		// (get) Token: 0x0600238A RID: 9098 RVA: 0x0005D680 File Offset: 0x0005B880
		internal new static IntPtr class_ref
		{
			get
			{
				return ScarRewardedAd._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000D55 RID: 3413
		// (get) Token: 0x0600238B RID: 9099 RVA: 0x0005D6A4 File Offset: 0x0005B8A4
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return ScarRewardedAd._members;
			}
		}

		// Token: 0x17000D56 RID: 3414
		// (get) Token: 0x0600238C RID: 9100 RVA: 0x0005D6AC File Offset: 0x0005B8AC
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return ScarRewardedAd._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000D57 RID: 3415
		// (get) Token: 0x0600238D RID: 9101 RVA: 0x0005D6D0 File Offset: 0x0005B8D0
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return ScarRewardedAd._members.ManagedPeerType;
			}
		}

		// Token: 0x0600238E RID: 9102 RVA: 0x0005D2AE File Offset: 0x0005B4AE
		protected ScarRewardedAd(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x0600238F RID: 9103 RVA: 0x0005D6DC File Offset: 0x0005B8DC
		private static Delegate GetShow_Landroid_app_Activity_Handler()
		{
			if (ScarRewardedAd.cb_show_Landroid_app_Activity_ == null)
			{
				ScarRewardedAd.cb_show_Landroid_app_Activity_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(ScarRewardedAd.n_Show_Landroid_app_Activity_));
			}
			return ScarRewardedAd.cb_show_Landroid_app_Activity_;
		}

		// Token: 0x06002390 RID: 9104 RVA: 0x0005D700 File Offset: 0x0005B900
		private static void n_Show_Landroid_app_Activity_(IntPtr jnienv, IntPtr native__this, IntPtr native_activity)
		{
			ScarAdBase @object = Java.Lang.Object.GetObject<ScarRewardedAd>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Activity object2 = Java.Lang.Object.GetObject<Activity>(native_activity, JniHandleOwnership.DoNotTransfer);
			@object.Show(object2);
		}

		// Token: 0x06002391 RID: 9105 RVA: 0x0005D724 File Offset: 0x0005B924
		[Register("show", "(Landroid/app/Activity;)V", "GetShow_Landroid_app_Activity_Handler")]
		public unsafe override void Show(Activity activity)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((activity == null) ? IntPtr.Zero : activity.Handle);
				ScarRewardedAd._members.InstanceMethods.InvokeVirtualVoidMethod("show.(Landroid/app/Activity;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(activity);
			}
		}

		// Token: 0x04000726 RID: 1830
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/unity3d/scar/adapter/v1950/scarads/ScarRewardedAd", typeof(ScarRewardedAd));

		// Token: 0x04000727 RID: 1831
		private static Delegate cb_show_Landroid_app_Activity_;
	}
}
