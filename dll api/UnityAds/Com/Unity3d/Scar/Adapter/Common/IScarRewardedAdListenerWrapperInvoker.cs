using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Com.Unity3d.Scar.Adapter.Common
{
	// Token: 0x020002A2 RID: 674
	[Register("com/unity3d/scar/adapter/common/IScarRewardedAdListenerWrapper", DoNotGenerateAcw = true)]
	internal class IScarRewardedAdListenerWrapperInvoker : Java.Lang.Object, IScarRewardedAdListenerWrapper, IScarAdListenerWrapper, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x17000EAA RID: 3754
		// (get) Token: 0x06002687 RID: 9863 RVA: 0x000633DC File Offset: 0x000615DC
		private static IntPtr java_class_ref
		{
			get
			{
				return IScarRewardedAdListenerWrapperInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000EAB RID: 3755
		// (get) Token: 0x06002688 RID: 9864 RVA: 0x00063400 File Offset: 0x00061600
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return IScarRewardedAdListenerWrapperInvoker._members;
			}
		}

		// Token: 0x17000EAC RID: 3756
		// (get) Token: 0x06002689 RID: 9865 RVA: 0x00063407 File Offset: 0x00061607
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x17000EAD RID: 3757
		// (get) Token: 0x0600268A RID: 9866 RVA: 0x0006340F File Offset: 0x0006160F
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return IScarRewardedAdListenerWrapperInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x0600268B RID: 9867 RVA: 0x0006341B File Offset: 0x0006161B
		public static IScarRewardedAdListenerWrapper GetObject(IntPtr handle, JniHandleOwnership transfer)
		{
			return Java.Lang.Object.GetObject<IScarRewardedAdListenerWrapper>(handle, transfer);
		}

		// Token: 0x0600268C RID: 9868 RVA: 0x00063424 File Offset: 0x00061624
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, IScarRewardedAdListenerWrapperInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'com.unity3d.scar.adapter.common.IScarRewardedAdListenerWrapper'.");
			}
			return handle;
		}

		// Token: 0x0600268D RID: 9869 RVA: 0x0006344F File Offset: 0x0006164F
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x0600268E RID: 9870 RVA: 0x00063480 File Offset: 0x00061680
		public IScarRewardedAdListenerWrapperInvoker(IntPtr handle, JniHandleOwnership transfer) : base(IScarRewardedAdListenerWrapperInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x0600268F RID: 9871 RVA: 0x000634B8 File Offset: 0x000616B8
		private static Delegate GetOnAdFailedToShow_ILjava_lang_String_Handler()
		{
			if (IScarRewardedAdListenerWrapperInvoker.cb_onAdFailedToShow_ILjava_lang_String_ == null)
			{
				IScarRewardedAdListenerWrapperInvoker.cb_onAdFailedToShow_ILjava_lang_String_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPIL_V(IScarRewardedAdListenerWrapperInvoker.n_OnAdFailedToShow_ILjava_lang_String_));
			}
			return IScarRewardedAdListenerWrapperInvoker.cb_onAdFailedToShow_ILjava_lang_String_;
		}

		// Token: 0x06002690 RID: 9872 RVA: 0x000634DC File Offset: 0x000616DC
		private static void n_OnAdFailedToShow_ILjava_lang_String_(IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1)
		{
			IScarRewardedAdListenerWrapper @object = Java.Lang.Object.GetObject<IScarRewardedAdListenerWrapper>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string @string = JNIEnv.GetString(native_p1, JniHandleOwnership.DoNotTransfer);
			@object.OnAdFailedToShow(p0, @string);
		}

		// Token: 0x06002691 RID: 9873 RVA: 0x00063500 File Offset: 0x00061700
		public unsafe void OnAdFailedToShow(int p0, string p1)
		{
			if (this.id_onAdFailedToShow_ILjava_lang_String_ == IntPtr.Zero)
			{
				this.id_onAdFailedToShow_ILjava_lang_String_ = JNIEnv.GetMethodID(this.class_ref, "onAdFailedToShow", "(ILjava/lang/String;)V");
			}
			IntPtr intPtr = JNIEnv.NewString(p1);
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue(p0);
			ptr[1] = new JValue(intPtr);
			JNIEnv.CallVoidMethod(base.Handle, this.id_onAdFailedToShow_ILjava_lang_String_, ptr);
			JNIEnv.DeleteLocalRef(intPtr);
		}

		// Token: 0x06002692 RID: 9874 RVA: 0x00063584 File Offset: 0x00061784
		private static Delegate GetOnAdImpressionHandler()
		{
			if (IScarRewardedAdListenerWrapperInvoker.cb_onAdImpression == null)
			{
				IScarRewardedAdListenerWrapperInvoker.cb_onAdImpression = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_V(IScarRewardedAdListenerWrapperInvoker.n_OnAdImpression));
			}
			return IScarRewardedAdListenerWrapperInvoker.cb_onAdImpression;
		}

		// Token: 0x06002693 RID: 9875 RVA: 0x000635A8 File Offset: 0x000617A8
		private static void n_OnAdImpression(IntPtr jnienv, IntPtr native__this)
		{
			Java.Lang.Object.GetObject<IScarRewardedAdListenerWrapper>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).OnAdImpression();
		}

		// Token: 0x06002694 RID: 9876 RVA: 0x000635B7 File Offset: 0x000617B7
		public void OnAdImpression()
		{
			if (this.id_onAdImpression == IntPtr.Zero)
			{
				this.id_onAdImpression = JNIEnv.GetMethodID(this.class_ref, "onAdImpression", "()V");
			}
			JNIEnv.CallVoidMethod(base.Handle, this.id_onAdImpression);
		}

		// Token: 0x06002695 RID: 9877 RVA: 0x000635F7 File Offset: 0x000617F7
		private static Delegate GetOnUserEarnedRewardHandler()
		{
			if (IScarRewardedAdListenerWrapperInvoker.cb_onUserEarnedReward == null)
			{
				IScarRewardedAdListenerWrapperInvoker.cb_onUserEarnedReward = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_V(IScarRewardedAdListenerWrapperInvoker.n_OnUserEarnedReward));
			}
			return IScarRewardedAdListenerWrapperInvoker.cb_onUserEarnedReward;
		}

		// Token: 0x06002696 RID: 9878 RVA: 0x0006361B File Offset: 0x0006181B
		private static void n_OnUserEarnedReward(IntPtr jnienv, IntPtr native__this)
		{
			Java.Lang.Object.GetObject<IScarRewardedAdListenerWrapper>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).OnUserEarnedReward();
		}

		// Token: 0x06002697 RID: 9879 RVA: 0x0006362A File Offset: 0x0006182A
		public void OnUserEarnedReward()
		{
			if (this.id_onUserEarnedReward == IntPtr.Zero)
			{
				this.id_onUserEarnedReward = JNIEnv.GetMethodID(this.class_ref, "onUserEarnedReward", "()V");
			}
			JNIEnv.CallVoidMethod(base.Handle, this.id_onUserEarnedReward);
		}

		// Token: 0x06002698 RID: 9880 RVA: 0x0006366A File Offset: 0x0006186A
		private static Delegate GetOnAdClickedHandler()
		{
			if (IScarRewardedAdListenerWrapperInvoker.cb_onAdClicked == null)
			{
				IScarRewardedAdListenerWrapperInvoker.cb_onAdClicked = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_V(IScarRewardedAdListenerWrapperInvoker.n_OnAdClicked));
			}
			return IScarRewardedAdListenerWrapperInvoker.cb_onAdClicked;
		}

		// Token: 0x06002699 RID: 9881 RVA: 0x0006368E File Offset: 0x0006188E
		private static void n_OnAdClicked(IntPtr jnienv, IntPtr native__this)
		{
			Java.Lang.Object.GetObject<IScarRewardedAdListenerWrapper>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).OnAdClicked();
		}

		// Token: 0x0600269A RID: 9882 RVA: 0x0006369D File Offset: 0x0006189D
		public void OnAdClicked()
		{
			if (this.id_onAdClicked == IntPtr.Zero)
			{
				this.id_onAdClicked = JNIEnv.GetMethodID(this.class_ref, "onAdClicked", "()V");
			}
			JNIEnv.CallVoidMethod(base.Handle, this.id_onAdClicked);
		}

		// Token: 0x0600269B RID: 9883 RVA: 0x000636DD File Offset: 0x000618DD
		private static Delegate GetOnAdClosedHandler()
		{
			if (IScarRewardedAdListenerWrapperInvoker.cb_onAdClosed == null)
			{
				IScarRewardedAdListenerWrapperInvoker.cb_onAdClosed = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_V(IScarRewardedAdListenerWrapperInvoker.n_OnAdClosed));
			}
			return IScarRewardedAdListenerWrapperInvoker.cb_onAdClosed;
		}

		// Token: 0x0600269C RID: 9884 RVA: 0x00063701 File Offset: 0x00061901
		private static void n_OnAdClosed(IntPtr jnienv, IntPtr native__this)
		{
			Java.Lang.Object.GetObject<IScarRewardedAdListenerWrapper>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).OnAdClosed();
		}

		// Token: 0x0600269D RID: 9885 RVA: 0x00063710 File Offset: 0x00061910
		public void OnAdClosed()
		{
			if (this.id_onAdClosed == IntPtr.Zero)
			{
				this.id_onAdClosed = JNIEnv.GetMethodID(this.class_ref, "onAdClosed", "()V");
			}
			JNIEnv.CallVoidMethod(base.Handle, this.id_onAdClosed);
		}

		// Token: 0x0600269E RID: 9886 RVA: 0x00063750 File Offset: 0x00061950
		private static Delegate GetOnAdFailedToLoad_ILjava_lang_String_Handler()
		{
			if (IScarRewardedAdListenerWrapperInvoker.cb_onAdFailedToLoad_ILjava_lang_String_ == null)
			{
				IScarRewardedAdListenerWrapperInvoker.cb_onAdFailedToLoad_ILjava_lang_String_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPIL_V(IScarRewardedAdListenerWrapperInvoker.n_OnAdFailedToLoad_ILjava_lang_String_));
			}
			return IScarRewardedAdListenerWrapperInvoker.cb_onAdFailedToLoad_ILjava_lang_String_;
		}

		// Token: 0x0600269F RID: 9887 RVA: 0x00063774 File Offset: 0x00061974
		private static void n_OnAdFailedToLoad_ILjava_lang_String_(IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1)
		{
			IScarAdListenerWrapper @object = Java.Lang.Object.GetObject<IScarRewardedAdListenerWrapper>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string @string = JNIEnv.GetString(native_p1, JniHandleOwnership.DoNotTransfer);
			@object.OnAdFailedToLoad(p0, @string);
		}

		// Token: 0x060026A0 RID: 9888 RVA: 0x00063798 File Offset: 0x00061998
		public unsafe void OnAdFailedToLoad(int p0, string p1)
		{
			if (this.id_onAdFailedToLoad_ILjava_lang_String_ == IntPtr.Zero)
			{
				this.id_onAdFailedToLoad_ILjava_lang_String_ = JNIEnv.GetMethodID(this.class_ref, "onAdFailedToLoad", "(ILjava/lang/String;)V");
			}
			IntPtr intPtr = JNIEnv.NewString(p1);
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue(p0);
			ptr[1] = new JValue(intPtr);
			JNIEnv.CallVoidMethod(base.Handle, this.id_onAdFailedToLoad_ILjava_lang_String_, ptr);
			JNIEnv.DeleteLocalRef(intPtr);
		}

		// Token: 0x060026A1 RID: 9889 RVA: 0x0006381C File Offset: 0x00061A1C
		private static Delegate GetOnAdLoadedHandler()
		{
			if (IScarRewardedAdListenerWrapperInvoker.cb_onAdLoaded == null)
			{
				IScarRewardedAdListenerWrapperInvoker.cb_onAdLoaded = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_V(IScarRewardedAdListenerWrapperInvoker.n_OnAdLoaded));
			}
			return IScarRewardedAdListenerWrapperInvoker.cb_onAdLoaded;
		}

		// Token: 0x060026A2 RID: 9890 RVA: 0x00063840 File Offset: 0x00061A40
		private static void n_OnAdLoaded(IntPtr jnienv, IntPtr native__this)
		{
			Java.Lang.Object.GetObject<IScarRewardedAdListenerWrapper>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).OnAdLoaded();
		}

		// Token: 0x060026A3 RID: 9891 RVA: 0x0006384F File Offset: 0x00061A4F
		public void OnAdLoaded()
		{
			if (this.id_onAdLoaded == IntPtr.Zero)
			{
				this.id_onAdLoaded = JNIEnv.GetMethodID(this.class_ref, "onAdLoaded", "()V");
			}
			JNIEnv.CallVoidMethod(base.Handle, this.id_onAdLoaded);
		}

		// Token: 0x060026A4 RID: 9892 RVA: 0x0006388F File Offset: 0x00061A8F
		private static Delegate GetOnAdOpenedHandler()
		{
			if (IScarRewardedAdListenerWrapperInvoker.cb_onAdOpened == null)
			{
				IScarRewardedAdListenerWrapperInvoker.cb_onAdOpened = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_V(IScarRewardedAdListenerWrapperInvoker.n_OnAdOpened));
			}
			return IScarRewardedAdListenerWrapperInvoker.cb_onAdOpened;
		}

		// Token: 0x060026A5 RID: 9893 RVA: 0x000638B3 File Offset: 0x00061AB3
		private static void n_OnAdOpened(IntPtr jnienv, IntPtr native__this)
		{
			Java.Lang.Object.GetObject<IScarRewardedAdListenerWrapper>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).OnAdOpened();
		}

		// Token: 0x060026A6 RID: 9894 RVA: 0x000638C2 File Offset: 0x00061AC2
		public void OnAdOpened()
		{
			if (this.id_onAdOpened == IntPtr.Zero)
			{
				this.id_onAdOpened = JNIEnv.GetMethodID(this.class_ref, "onAdOpened", "()V");
			}
			JNIEnv.CallVoidMethod(base.Handle, this.id_onAdOpened);
		}

		// Token: 0x060026A7 RID: 9895 RVA: 0x00063902 File Offset: 0x00061B02
		private static Delegate GetOnAdSkippedHandler()
		{
			if (IScarRewardedAdListenerWrapperInvoker.cb_onAdSkipped == null)
			{
				IScarRewardedAdListenerWrapperInvoker.cb_onAdSkipped = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_V(IScarRewardedAdListenerWrapperInvoker.n_OnAdSkipped));
			}
			return IScarRewardedAdListenerWrapperInvoker.cb_onAdSkipped;
		}

		// Token: 0x060026A8 RID: 9896 RVA: 0x00063926 File Offset: 0x00061B26
		private static void n_OnAdSkipped(IntPtr jnienv, IntPtr native__this)
		{
			Java.Lang.Object.GetObject<IScarRewardedAdListenerWrapper>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).OnAdSkipped();
		}

		// Token: 0x060026A9 RID: 9897 RVA: 0x00063935 File Offset: 0x00061B35
		public void OnAdSkipped()
		{
			if (this.id_onAdSkipped == IntPtr.Zero)
			{
				this.id_onAdSkipped = JNIEnv.GetMethodID(this.class_ref, "onAdSkipped", "()V");
			}
			JNIEnv.CallVoidMethod(base.Handle, this.id_onAdSkipped);
		}

		// Token: 0x04000792 RID: 1938
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/unity3d/scar/adapter/common/IScarRewardedAdListenerWrapper", typeof(IScarRewardedAdListenerWrapperInvoker));

		// Token: 0x04000793 RID: 1939
		private IntPtr class_ref;

		// Token: 0x04000794 RID: 1940
		private static Delegate cb_onAdFailedToShow_ILjava_lang_String_;

		// Token: 0x04000795 RID: 1941
		private IntPtr id_onAdFailedToShow_ILjava_lang_String_;

		// Token: 0x04000796 RID: 1942
		private static Delegate cb_onAdImpression;

		// Token: 0x04000797 RID: 1943
		private IntPtr id_onAdImpression;

		// Token: 0x04000798 RID: 1944
		private static Delegate cb_onUserEarnedReward;

		// Token: 0x04000799 RID: 1945
		private IntPtr id_onUserEarnedReward;

		// Token: 0x0400079A RID: 1946
		private static Delegate cb_onAdClicked;

		// Token: 0x0400079B RID: 1947
		private IntPtr id_onAdClicked;

		// Token: 0x0400079C RID: 1948
		private static Delegate cb_onAdClosed;

		// Token: 0x0400079D RID: 1949
		private IntPtr id_onAdClosed;

		// Token: 0x0400079E RID: 1950
		private static Delegate cb_onAdFailedToLoad_ILjava_lang_String_;

		// Token: 0x0400079F RID: 1951
		private IntPtr id_onAdFailedToLoad_ILjava_lang_String_;

		// Token: 0x040007A0 RID: 1952
		private static Delegate cb_onAdLoaded;

		// Token: 0x040007A1 RID: 1953
		private IntPtr id_onAdLoaded;

		// Token: 0x040007A2 RID: 1954
		private static Delegate cb_onAdOpened;

		// Token: 0x040007A3 RID: 1955
		private IntPtr id_onAdOpened;

		// Token: 0x040007A4 RID: 1956
		private static Delegate cb_onAdSkipped;

		// Token: 0x040007A5 RID: 1957
		private IntPtr id_onAdSkipped;
	}
}
