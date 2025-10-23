using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.App;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Com.Unity3d.Scar.Adapter.V1950.Scarads
{
	// Token: 0x02000275 RID: 629
	[Register("com/unity3d/scar/adapter/v1950/scarads/ScarInterstitialAd", DoNotGenerateAcw = true)]
	public class ScarInterstitialAd : ScarAdBase
	{
		// Token: 0x17000D4C RID: 3404
		// (get) Token: 0x06002370 RID: 9072 RVA: 0x0005D34C File Offset: 0x0005B54C
		internal new static IntPtr class_ref
		{
			get
			{
				return ScarInterstitialAd._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000D4D RID: 3405
		// (get) Token: 0x06002371 RID: 9073 RVA: 0x0005D370 File Offset: 0x0005B570
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return ScarInterstitialAd._members;
			}
		}

		// Token: 0x17000D4E RID: 3406
		// (get) Token: 0x06002372 RID: 9074 RVA: 0x0005D378 File Offset: 0x0005B578
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return ScarInterstitialAd._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000D4F RID: 3407
		// (get) Token: 0x06002373 RID: 9075 RVA: 0x0005D39C File Offset: 0x0005B59C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return ScarInterstitialAd._members.ManagedPeerType;
			}
		}

		// Token: 0x06002374 RID: 9076 RVA: 0x0005D2AE File Offset: 0x0005B4AE
		protected ScarInterstitialAd(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06002375 RID: 9077 RVA: 0x0005D3A8 File Offset: 0x0005B5A8
		private static Delegate GetShow_Landroid_app_Activity_Handler()
		{
			if (ScarInterstitialAd.cb_show_Landroid_app_Activity_ == null)
			{
				ScarInterstitialAd.cb_show_Landroid_app_Activity_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(ScarInterstitialAd.n_Show_Landroid_app_Activity_));
			}
			return ScarInterstitialAd.cb_show_Landroid_app_Activity_;
		}

		// Token: 0x06002376 RID: 9078 RVA: 0x0005D3CC File Offset: 0x0005B5CC
		private static void n_Show_Landroid_app_Activity_(IntPtr jnienv, IntPtr native__this, IntPtr native_activity)
		{
			ScarAdBase @object = Java.Lang.Object.GetObject<ScarInterstitialAd>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Activity object2 = Java.Lang.Object.GetObject<Activity>(native_activity, JniHandleOwnership.DoNotTransfer);
			@object.Show(object2);
		}

		// Token: 0x06002377 RID: 9079 RVA: 0x0005D3F0 File Offset: 0x0005B5F0
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

		// Token: 0x0400071E RID: 1822
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/unity3d/scar/adapter/v1950/scarads/ScarInterstitialAd", typeof(ScarInterstitialAd));

		// Token: 0x0400071F RID: 1823
		private static Delegate cb_show_Landroid_app_Activity_;
	}
}
