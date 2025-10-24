using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Gms.Ads.Rewarded;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Android.Gms.Ads
{
	// Token: 0x0200001D RID: 29
	[Register("com/google/android/gms/ads/OnUserEarnedRewardListener", DoNotGenerateAcw = true)]
	internal class IOnUserEarnedRewardListenerInvoker : Java.Lang.Object, IOnUserEarnedRewardListener, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x17000041 RID: 65
		// (get) Token: 0x060000F3 RID: 243 RVA: 0x00004210 File Offset: 0x00002410
		private static IntPtr java_class_ref
		{
			get
			{
				return IOnUserEarnedRewardListenerInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000042 RID: 66
		// (get) Token: 0x060000F4 RID: 244 RVA: 0x00004234 File Offset: 0x00002434
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return IOnUserEarnedRewardListenerInvoker._members;
			}
		}

		// Token: 0x17000043 RID: 67
		// (get) Token: 0x060000F5 RID: 245 RVA: 0x0000423B File Offset: 0x0000243B
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x17000044 RID: 68
		// (get) Token: 0x060000F6 RID: 246 RVA: 0x00004243 File Offset: 0x00002443
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return IOnUserEarnedRewardListenerInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x060000F7 RID: 247 RVA: 0x0000424F File Offset: 0x0000244F
		public static IOnUserEarnedRewardListener GetObject(IntPtr handle, JniHandleOwnership transfer)
		{
			return Java.Lang.Object.GetObject<IOnUserEarnedRewardListener>(handle, transfer);
		}

		// Token: 0x060000F8 RID: 248 RVA: 0x00004258 File Offset: 0x00002458
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, IOnUserEarnedRewardListenerInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'com.google.android.gms.ads.OnUserEarnedRewardListener'.");
			}
			return handle;
		}

		// Token: 0x060000F9 RID: 249 RVA: 0x00004283 File Offset: 0x00002483
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x060000FA RID: 250 RVA: 0x000042B4 File Offset: 0x000024B4
		public IOnUserEarnedRewardListenerInvoker(IntPtr handle, JniHandleOwnership transfer) : base(IOnUserEarnedRewardListenerInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x060000FB RID: 251 RVA: 0x000042EC File Offset: 0x000024EC
		private static Delegate GetOnUserEarnedReward_Lcom_google_android_gms_ads_rewarded_RewardItem_Handler()
		{
			if (IOnUserEarnedRewardListenerInvoker.cb_onUserEarnedReward_Lcom_google_android_gms_ads_rewarded_RewardItem_ == null)
			{
				IOnUserEarnedRewardListenerInvoker.cb_onUserEarnedReward_Lcom_google_android_gms_ads_rewarded_RewardItem_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(IOnUserEarnedRewardListenerInvoker.n_OnUserEarnedReward_Lcom_google_android_gms_ads_rewarded_RewardItem_));
			}
			return IOnUserEarnedRewardListenerInvoker.cb_onUserEarnedReward_Lcom_google_android_gms_ads_rewarded_RewardItem_;
		}

		// Token: 0x060000FC RID: 252 RVA: 0x00004310 File Offset: 0x00002510
		private static void n_OnUserEarnedReward_Lcom_google_android_gms_ads_rewarded_RewardItem_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			IOnUserEarnedRewardListener @object = Java.Lang.Object.GetObject<IOnUserEarnedRewardListener>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			IRewardItem object2 = Java.Lang.Object.GetObject<IRewardItem>(native_p0, JniHandleOwnership.DoNotTransfer);
			@object.OnUserEarnedReward(object2);
		}

		// Token: 0x060000FD RID: 253 RVA: 0x00004334 File Offset: 0x00002534
		public unsafe void OnUserEarnedReward(IRewardItem p0)
		{
			if (this.id_onUserEarnedReward_Lcom_google_android_gms_ads_rewarded_RewardItem_ == IntPtr.Zero)
			{
				this.id_onUserEarnedReward_Lcom_google_android_gms_ads_rewarded_RewardItem_ = JNIEnv.GetMethodID(this.class_ref, "onUserEarnedReward", "(Lcom/google/android/gms/ads/rewarded/RewardItem;)V");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue((p0 == null) ? IntPtr.Zero : ((Java.Lang.Object)p0).Handle);
			JNIEnv.CallVoidMethod(base.Handle, this.id_onUserEarnedReward_Lcom_google_android_gms_ads_rewarded_RewardItem_, ptr);
		}

		// Token: 0x04000034 RID: 52
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/google/android/gms/ads/OnUserEarnedRewardListener", typeof(IOnUserEarnedRewardListenerInvoker));

		// Token: 0x04000035 RID: 53
		private IntPtr class_ref;

		// Token: 0x04000036 RID: 54
		private static Delegate cb_onUserEarnedReward_Lcom_google_android_gms_ads_rewarded_RewardItem_;

		// Token: 0x04000037 RID: 55
		private IntPtr id_onUserEarnedReward_Lcom_google_android_gms_ads_rewarded_RewardItem_;
	}
}
