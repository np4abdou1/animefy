using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.App;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Com.Unity3d.Scar.Adapter.V1920.Scarads
{
	// Token: 0x02000291 RID: 657
	[Register("com/unity3d/scar/adapter/v1920/scarads/ScarRewardedAd", DoNotGenerateAcw = true)]
	public class ScarRewardedAd : ScarAdBase
	{
		// Token: 0x17000E62 RID: 3682
		// (get) Token: 0x060025AE RID: 9646 RVA: 0x00060F44 File Offset: 0x0005F144
		internal new static IntPtr class_ref
		{
			get
			{
				return ScarRewardedAd._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000E63 RID: 3683
		// (get) Token: 0x060025AF RID: 9647 RVA: 0x00060F68 File Offset: 0x0005F168
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return ScarRewardedAd._members;
			}
		}

		// Token: 0x17000E64 RID: 3684
		// (get) Token: 0x060025B0 RID: 9648 RVA: 0x00060F70 File Offset: 0x0005F170
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return ScarRewardedAd._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000E65 RID: 3685
		// (get) Token: 0x060025B1 RID: 9649 RVA: 0x00060F94 File Offset: 0x0005F194
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return ScarRewardedAd._members.ManagedPeerType;
			}
		}

		// Token: 0x060025B2 RID: 9650 RVA: 0x00060B72 File Offset: 0x0005ED72
		protected ScarRewardedAd(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x060025B3 RID: 9651 RVA: 0x00060FA0 File Offset: 0x0005F1A0
		private static Delegate GetShow_Landroid_app_Activity_Handler()
		{
			if (ScarRewardedAd.cb_show_Landroid_app_Activity_ == null)
			{
				ScarRewardedAd.cb_show_Landroid_app_Activity_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(ScarRewardedAd.n_Show_Landroid_app_Activity_));
			}
			return ScarRewardedAd.cb_show_Landroid_app_Activity_;
		}

		// Token: 0x060025B4 RID: 9652 RVA: 0x00060FC4 File Offset: 0x0005F1C4
		private static void n_Show_Landroid_app_Activity_(IntPtr jnienv, IntPtr native__this, IntPtr native_activity)
		{
			ScarAdBase @object = Java.Lang.Object.GetObject<ScarRewardedAd>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Activity object2 = Java.Lang.Object.GetObject<Activity>(native_activity, JniHandleOwnership.DoNotTransfer);
			@object.Show(object2);
		}

		// Token: 0x060025B5 RID: 9653 RVA: 0x00060FE8 File Offset: 0x0005F1E8
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

		// Token: 0x0400074E RID: 1870
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/unity3d/scar/adapter/v1920/scarads/ScarRewardedAd", typeof(ScarRewardedAd));

		// Token: 0x0400074F RID: 1871
		private static Delegate cb_show_Landroid_app_Activity_;
	}
}
