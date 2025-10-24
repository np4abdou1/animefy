using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Com.Unity3d.Scar.Adapter.Common
{
	// Token: 0x020002A0 RID: 672
	[Register("com/unity3d/scar/adapter/common/IScarInterstitialAdListenerWrapper", DoNotGenerateAcw = true)]
	internal class IScarInterstitialAdListenerWrapperInvoker : Java.Lang.Object, IScarInterstitialAdListenerWrapper, IScarAdListenerWrapper, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x17000EA6 RID: 3750
		// (get) Token: 0x06002660 RID: 9824 RVA: 0x00062E28 File Offset: 0x00061028
		private static IntPtr java_class_ref
		{
			get
			{
				return IScarInterstitialAdListenerWrapperInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000EA7 RID: 3751
		// (get) Token: 0x06002661 RID: 9825 RVA: 0x00062E4C File Offset: 0x0006104C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return IScarInterstitialAdListenerWrapperInvoker._members;
			}
		}

		// Token: 0x17000EA8 RID: 3752
		// (get) Token: 0x06002662 RID: 9826 RVA: 0x00062E53 File Offset: 0x00061053
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x17000EA9 RID: 3753
		// (get) Token: 0x06002663 RID: 9827 RVA: 0x00062E5B File Offset: 0x0006105B
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return IScarInterstitialAdListenerWrapperInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x06002664 RID: 9828 RVA: 0x00062E67 File Offset: 0x00061067
		public static IScarInterstitialAdListenerWrapper GetObject(IntPtr handle, JniHandleOwnership transfer)
		{
			return Java.Lang.Object.GetObject<IScarInterstitialAdListenerWrapper>(handle, transfer);
		}

		// Token: 0x06002665 RID: 9829 RVA: 0x00062E70 File Offset: 0x00061070
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, IScarInterstitialAdListenerWrapperInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'com.unity3d.scar.adapter.common.IScarInterstitialAdListenerWrapper'.");
			}
			return handle;
		}

		// Token: 0x06002666 RID: 9830 RVA: 0x00062E9B File Offset: 0x0006109B
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x06002667 RID: 9831 RVA: 0x00062ECC File Offset: 0x000610CC
		public IScarInterstitialAdListenerWrapperInvoker(IntPtr handle, JniHandleOwnership transfer) : base(IScarInterstitialAdListenerWrapperInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x06002668 RID: 9832 RVA: 0x00062F04 File Offset: 0x00061104
		private static Delegate GetOnAdFailedToShow_ILjava_lang_String_Handler()
		{
			if (IScarInterstitialAdListenerWrapperInvoker.cb_onAdFailedToShow_ILjava_lang_String_ == null)
			{
				IScarInterstitialAdListenerWrapperInvoker.cb_onAdFailedToShow_ILjava_lang_String_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPIL_V(IScarInterstitialAdListenerWrapperInvoker.n_OnAdFailedToShow_ILjava_lang_String_));
			}
			return IScarInterstitialAdListenerWrapperInvoker.cb_onAdFailedToShow_ILjava_lang_String_;
		}

		// Token: 0x06002669 RID: 9833 RVA: 0x00062F28 File Offset: 0x00061128
		private static void n_OnAdFailedToShow_ILjava_lang_String_(IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1)
		{
			IScarInterstitialAdListenerWrapper @object = Java.Lang.Object.GetObject<IScarInterstitialAdListenerWrapper>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string @string = JNIEnv.GetString(native_p1, JniHandleOwnership.DoNotTransfer);
			@object.OnAdFailedToShow(p0, @string);
		}

		// Token: 0x0600266A RID: 9834 RVA: 0x00062F4C File Offset: 0x0006114C
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

		// Token: 0x0600266B RID: 9835 RVA: 0x00062FD0 File Offset: 0x000611D0
		private static Delegate GetOnAdImpressionHandler()
		{
			if (IScarInterstitialAdListenerWrapperInvoker.cb_onAdImpression == null)
			{
				IScarInterstitialAdListenerWrapperInvoker.cb_onAdImpression = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_V(IScarInterstitialAdListenerWrapperInvoker.n_OnAdImpression));
			}
			return IScarInterstitialAdListenerWrapperInvoker.cb_onAdImpression;
		}

		// Token: 0x0600266C RID: 9836 RVA: 0x00062FF4 File Offset: 0x000611F4
		private static void n_OnAdImpression(IntPtr jnienv, IntPtr native__this)
		{
			Java.Lang.Object.GetObject<IScarInterstitialAdListenerWrapper>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).OnAdImpression();
		}

		// Token: 0x0600266D RID: 9837 RVA: 0x00063003 File Offset: 0x00061203
		public void OnAdImpression()
		{
			if (this.id_onAdImpression == IntPtr.Zero)
			{
				this.id_onAdImpression = JNIEnv.GetMethodID(this.class_ref, "onAdImpression", "()V");
			}
			JNIEnv.CallVoidMethod(base.Handle, this.id_onAdImpression);
		}

		// Token: 0x0600266E RID: 9838 RVA: 0x00063043 File Offset: 0x00061243
		private static Delegate GetOnAdLeftApplicationHandler()
		{
			if (IScarInterstitialAdListenerWrapperInvoker.cb_onAdLeftApplication == null)
			{
				IScarInterstitialAdListenerWrapperInvoker.cb_onAdLeftApplication = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_V(IScarInterstitialAdListenerWrapperInvoker.n_OnAdLeftApplication));
			}
			return IScarInterstitialAdListenerWrapperInvoker.cb_onAdLeftApplication;
		}

		// Token: 0x0600266F RID: 9839 RVA: 0x00063067 File Offset: 0x00061267
		private static void n_OnAdLeftApplication(IntPtr jnienv, IntPtr native__this)
		{
			Java.Lang.Object.GetObject<IScarInterstitialAdListenerWrapper>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).OnAdLeftApplication();
		}

		// Token: 0x06002670 RID: 9840 RVA: 0x00063076 File Offset: 0x00061276
		public void OnAdLeftApplication()
		{
			if (this.id_onAdLeftApplication == IntPtr.Zero)
			{
				this.id_onAdLeftApplication = JNIEnv.GetMethodID(this.class_ref, "onAdLeftApplication", "()V");
			}
			JNIEnv.CallVoidMethod(base.Handle, this.id_onAdLeftApplication);
		}

		// Token: 0x06002671 RID: 9841 RVA: 0x000630B6 File Offset: 0x000612B6
		private static Delegate GetOnAdClickedHandler()
		{
			if (IScarInterstitialAdListenerWrapperInvoker.cb_onAdClicked == null)
			{
				IScarInterstitialAdListenerWrapperInvoker.cb_onAdClicked = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_V(IScarInterstitialAdListenerWrapperInvoker.n_OnAdClicked));
			}
			return IScarInterstitialAdListenerWrapperInvoker.cb_onAdClicked;
		}

		// Token: 0x06002672 RID: 9842 RVA: 0x000630DA File Offset: 0x000612DA
		private static void n_OnAdClicked(IntPtr jnienv, IntPtr native__this)
		{
			Java.Lang.Object.GetObject<IScarInterstitialAdListenerWrapper>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).OnAdClicked();
		}

		// Token: 0x06002673 RID: 9843 RVA: 0x000630E9 File Offset: 0x000612E9
		public void OnAdClicked()
		{
			if (this.id_onAdClicked == IntPtr.Zero)
			{
				this.id_onAdClicked = JNIEnv.GetMethodID(this.class_ref, "onAdClicked", "()V");
			}
			JNIEnv.CallVoidMethod(base.Handle, this.id_onAdClicked);
		}

		// Token: 0x06002674 RID: 9844 RVA: 0x00063129 File Offset: 0x00061329
		private static Delegate GetOnAdClosedHandler()
		{
			if (IScarInterstitialAdListenerWrapperInvoker.cb_onAdClosed == null)
			{
				IScarInterstitialAdListenerWrapperInvoker.cb_onAdClosed = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_V(IScarInterstitialAdListenerWrapperInvoker.n_OnAdClosed));
			}
			return IScarInterstitialAdListenerWrapperInvoker.cb_onAdClosed;
		}

		// Token: 0x06002675 RID: 9845 RVA: 0x0006314D File Offset: 0x0006134D
		private static void n_OnAdClosed(IntPtr jnienv, IntPtr native__this)
		{
			Java.Lang.Object.GetObject<IScarInterstitialAdListenerWrapper>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).OnAdClosed();
		}

		// Token: 0x06002676 RID: 9846 RVA: 0x0006315C File Offset: 0x0006135C
		public void OnAdClosed()
		{
			if (this.id_onAdClosed == IntPtr.Zero)
			{
				this.id_onAdClosed = JNIEnv.GetMethodID(this.class_ref, "onAdClosed", "()V");
			}
			JNIEnv.CallVoidMethod(base.Handle, this.id_onAdClosed);
		}

		// Token: 0x06002677 RID: 9847 RVA: 0x0006319C File Offset: 0x0006139C
		private static Delegate GetOnAdFailedToLoad_ILjava_lang_String_Handler()
		{
			if (IScarInterstitialAdListenerWrapperInvoker.cb_onAdFailedToLoad_ILjava_lang_String_ == null)
			{
				IScarInterstitialAdListenerWrapperInvoker.cb_onAdFailedToLoad_ILjava_lang_String_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPIL_V(IScarInterstitialAdListenerWrapperInvoker.n_OnAdFailedToLoad_ILjava_lang_String_));
			}
			return IScarInterstitialAdListenerWrapperInvoker.cb_onAdFailedToLoad_ILjava_lang_String_;
		}

		// Token: 0x06002678 RID: 9848 RVA: 0x000631C0 File Offset: 0x000613C0
		private static void n_OnAdFailedToLoad_ILjava_lang_String_(IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1)
		{
			IScarAdListenerWrapper @object = Java.Lang.Object.GetObject<IScarInterstitialAdListenerWrapper>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string @string = JNIEnv.GetString(native_p1, JniHandleOwnership.DoNotTransfer);
			@object.OnAdFailedToLoad(p0, @string);
		}

		// Token: 0x06002679 RID: 9849 RVA: 0x000631E4 File Offset: 0x000613E4
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

		// Token: 0x0600267A RID: 9850 RVA: 0x00063268 File Offset: 0x00061468
		private static Delegate GetOnAdLoadedHandler()
		{
			if (IScarInterstitialAdListenerWrapperInvoker.cb_onAdLoaded == null)
			{
				IScarInterstitialAdListenerWrapperInvoker.cb_onAdLoaded = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_V(IScarInterstitialAdListenerWrapperInvoker.n_OnAdLoaded));
			}
			return IScarInterstitialAdListenerWrapperInvoker.cb_onAdLoaded;
		}

		// Token: 0x0600267B RID: 9851 RVA: 0x0006328C File Offset: 0x0006148C
		private static void n_OnAdLoaded(IntPtr jnienv, IntPtr native__this)
		{
			Java.Lang.Object.GetObject<IScarInterstitialAdListenerWrapper>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).OnAdLoaded();
		}

		// Token: 0x0600267C RID: 9852 RVA: 0x0006329B File Offset: 0x0006149B
		public void OnAdLoaded()
		{
			if (this.id_onAdLoaded == IntPtr.Zero)
			{
				this.id_onAdLoaded = JNIEnv.GetMethodID(this.class_ref, "onAdLoaded", "()V");
			}
			JNIEnv.CallVoidMethod(base.Handle, this.id_onAdLoaded);
		}

		// Token: 0x0600267D RID: 9853 RVA: 0x000632DB File Offset: 0x000614DB
		private static Delegate GetOnAdOpenedHandler()
		{
			if (IScarInterstitialAdListenerWrapperInvoker.cb_onAdOpened == null)
			{
				IScarInterstitialAdListenerWrapperInvoker.cb_onAdOpened = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_V(IScarInterstitialAdListenerWrapperInvoker.n_OnAdOpened));
			}
			return IScarInterstitialAdListenerWrapperInvoker.cb_onAdOpened;
		}

		// Token: 0x0600267E RID: 9854 RVA: 0x000632FF File Offset: 0x000614FF
		private static void n_OnAdOpened(IntPtr jnienv, IntPtr native__this)
		{
			Java.Lang.Object.GetObject<IScarInterstitialAdListenerWrapper>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).OnAdOpened();
		}

		// Token: 0x0600267F RID: 9855 RVA: 0x0006330E File Offset: 0x0006150E
		public void OnAdOpened()
		{
			if (this.id_onAdOpened == IntPtr.Zero)
			{
				this.id_onAdOpened = JNIEnv.GetMethodID(this.class_ref, "onAdOpened", "()V");
			}
			JNIEnv.CallVoidMethod(base.Handle, this.id_onAdOpened);
		}

		// Token: 0x06002680 RID: 9856 RVA: 0x0006334E File Offset: 0x0006154E
		private static Delegate GetOnAdSkippedHandler()
		{
			if (IScarInterstitialAdListenerWrapperInvoker.cb_onAdSkipped == null)
			{
				IScarInterstitialAdListenerWrapperInvoker.cb_onAdSkipped = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_V(IScarInterstitialAdListenerWrapperInvoker.n_OnAdSkipped));
			}
			return IScarInterstitialAdListenerWrapperInvoker.cb_onAdSkipped;
		}

		// Token: 0x06002681 RID: 9857 RVA: 0x00063372 File Offset: 0x00061572
		private static void n_OnAdSkipped(IntPtr jnienv, IntPtr native__this)
		{
			Java.Lang.Object.GetObject<IScarInterstitialAdListenerWrapper>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).OnAdSkipped();
		}

		// Token: 0x06002682 RID: 9858 RVA: 0x00063381 File Offset: 0x00061581
		public void OnAdSkipped()
		{
			if (this.id_onAdSkipped == IntPtr.Zero)
			{
				this.id_onAdSkipped = JNIEnv.GetMethodID(this.class_ref, "onAdSkipped", "()V");
			}
			JNIEnv.CallVoidMethod(base.Handle, this.id_onAdSkipped);
		}

		// Token: 0x0400077E RID: 1918
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/unity3d/scar/adapter/common/IScarInterstitialAdListenerWrapper", typeof(IScarInterstitialAdListenerWrapperInvoker));

		// Token: 0x0400077F RID: 1919
		private IntPtr class_ref;

		// Token: 0x04000780 RID: 1920
		private static Delegate cb_onAdFailedToShow_ILjava_lang_String_;

		// Token: 0x04000781 RID: 1921
		private IntPtr id_onAdFailedToShow_ILjava_lang_String_;

		// Token: 0x04000782 RID: 1922
		private static Delegate cb_onAdImpression;

		// Token: 0x04000783 RID: 1923
		private IntPtr id_onAdImpression;

		// Token: 0x04000784 RID: 1924
		private static Delegate cb_onAdLeftApplication;

		// Token: 0x04000785 RID: 1925
		private IntPtr id_onAdLeftApplication;

		// Token: 0x04000786 RID: 1926
		private static Delegate cb_onAdClicked;

		// Token: 0x04000787 RID: 1927
		private IntPtr id_onAdClicked;

		// Token: 0x04000788 RID: 1928
		private static Delegate cb_onAdClosed;

		// Token: 0x04000789 RID: 1929
		private IntPtr id_onAdClosed;

		// Token: 0x0400078A RID: 1930
		private static Delegate cb_onAdFailedToLoad_ILjava_lang_String_;

		// Token: 0x0400078B RID: 1931
		private IntPtr id_onAdFailedToLoad_ILjava_lang_String_;

		// Token: 0x0400078C RID: 1932
		private static Delegate cb_onAdLoaded;

		// Token: 0x0400078D RID: 1933
		private IntPtr id_onAdLoaded;

		// Token: 0x0400078E RID: 1934
		private static Delegate cb_onAdOpened;

		// Token: 0x0400078F RID: 1935
		private IntPtr id_onAdOpened;

		// Token: 0x04000790 RID: 1936
		private static Delegate cb_onAdSkipped;

		// Token: 0x04000791 RID: 1937
		private IntPtr id_onAdSkipped;
	}
}
