using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.App;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Com.Unity3d.Scar.Adapter.V1920.Scarads
{
	// Token: 0x0200028D RID: 653
	[Register("com/unity3d/scar/adapter/v1920/scarads/ScarInterstitialAd", DoNotGenerateAcw = true)]
	public class ScarInterstitialAd : ScarAdBase
	{
		// Token: 0x17000E5A RID: 3674
		// (get) Token: 0x06002594 RID: 9620 RVA: 0x00060C10 File Offset: 0x0005EE10
		internal new static IntPtr class_ref
		{
			get
			{
				return ScarInterstitialAd._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000E5B RID: 3675
		// (get) Token: 0x06002595 RID: 9621 RVA: 0x00060C34 File Offset: 0x0005EE34
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return ScarInterstitialAd._members;
			}
		}

		// Token: 0x17000E5C RID: 3676
		// (get) Token: 0x06002596 RID: 9622 RVA: 0x00060C3C File Offset: 0x0005EE3C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return ScarInterstitialAd._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000E5D RID: 3677
		// (get) Token: 0x06002597 RID: 9623 RVA: 0x00060C60 File Offset: 0x0005EE60
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return ScarInterstitialAd._members.ManagedPeerType;
			}
		}

		// Token: 0x06002598 RID: 9624 RVA: 0x00060B72 File Offset: 0x0005ED72
		protected ScarInterstitialAd(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06002599 RID: 9625 RVA: 0x00060C6C File Offset: 0x0005EE6C
		private static Delegate GetShow_Landroid_app_Activity_Handler()
		{
			if (ScarInterstitialAd.cb_show_Landroid_app_Activity_ == null)
			{
				ScarInterstitialAd.cb_show_Landroid_app_Activity_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(ScarInterstitialAd.n_Show_Landroid_app_Activity_));
			}
			return ScarInterstitialAd.cb_show_Landroid_app_Activity_;
		}

		// Token: 0x0600259A RID: 9626 RVA: 0x00060C90 File Offset: 0x0005EE90
		private static void n_Show_Landroid_app_Activity_(IntPtr jnienv, IntPtr native__this, IntPtr native_activity)
		{
			ScarAdBase @object = Java.Lang.Object.GetObject<ScarInterstitialAd>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Activity object2 = Java.Lang.Object.GetObject<Activity>(native_activity, JniHandleOwnership.DoNotTransfer);
			@object.Show(object2);
		}

		// Token: 0x0600259B RID: 9627 RVA: 0x00060CB4 File Offset: 0x0005EEB4
		[Register("show", "(Landroid/app/Activity;)V", "GetShow_Landroid_app_Activity_Handler")]
		public unsafe override void Show(Activity activity)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((activity == null) ? IntPtr.Zero : activity.Handle);
				ScarInterstitialAd._members.InstanceMethods.InvokeVirtualVoidMethod("show.(Landroid/app/Activity;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(activity);
			}
		}

		// Token: 0x04000746 RID: 1862
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/unity3d/scar/adapter/v1920/scarads/ScarInterstitialAd", typeof(ScarInterstitialAd));

		// Token: 0x04000747 RID: 1863
		private static Delegate cb_show_Landroid_app_Activity_;
	}
}
