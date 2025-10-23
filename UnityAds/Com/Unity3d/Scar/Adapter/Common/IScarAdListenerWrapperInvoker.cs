using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Com.Unity3d.Scar.Adapter.Common
{
	// Token: 0x0200029E RID: 670
	[Register("com/unity3d/scar/adapter/common/IScarAdListenerWrapper", DoNotGenerateAcw = true)]
	internal class IScarAdListenerWrapperInvoker : Java.Lang.Object, IScarAdListenerWrapper, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x17000EA2 RID: 3746
		// (get) Token: 0x06002642 RID: 9794 RVA: 0x00062A24 File Offset: 0x00060C24
		private static IntPtr java_class_ref
		{
			get
			{
				return IScarAdListenerWrapperInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000EA3 RID: 3747
		// (get) Token: 0x06002643 RID: 9795 RVA: 0x00062A48 File Offset: 0x00060C48
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return IScarAdListenerWrapperInvoker._members;
			}
		}

		// Token: 0x17000EA4 RID: 3748
		// (get) Token: 0x06002644 RID: 9796 RVA: 0x00062A4F File Offset: 0x00060C4F
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x17000EA5 RID: 3749
		// (get) Token: 0x06002645 RID: 9797 RVA: 0x00062A57 File Offset: 0x00060C57
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return IScarAdListenerWrapperInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x06002646 RID: 9798 RVA: 0x00062A63 File Offset: 0x00060C63
		public static IScarAdListenerWrapper GetObject(IntPtr handle, JniHandleOwnership transfer)
		{
			return Java.Lang.Object.GetObject<IScarAdListenerWrapper>(handle, transfer);
		}

		// Token: 0x06002647 RID: 9799 RVA: 0x00062A6C File Offset: 0x00060C6C
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, IScarAdListenerWrapperInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'com.unity3d.scar.adapter.common.IScarAdListenerWrapper'.");
			}
			return handle;
		}

		// Token: 0x06002648 RID: 9800 RVA: 0x00062A97 File Offset: 0x00060C97
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x06002649 RID: 9801 RVA: 0x00062AC8 File Offset: 0x00060CC8
		public IScarAdListenerWrapperInvoker(IntPtr handle, JniHandleOwnership transfer) : base(IScarAdListenerWrapperInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x0600264A RID: 9802 RVA: 0x00062B00 File Offset: 0x00060D00
		private static Delegate GetOnAdClickedHandler()
		{
			if (IScarAdListenerWrapperInvoker.cb_onAdClicked == null)
			{
				IScarAdListenerWrapperInvoker.cb_onAdClicked = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_V(IScarAdListenerWrapperInvoker.n_OnAdClicked));
			}
			return IScarAdListenerWrapperInvoker.cb_onAdClicked;
		}

		// Token: 0x0600264B RID: 9803 RVA: 0x00062B24 File Offset: 0x00060D24
		private static void n_OnAdClicked(IntPtr jnienv, IntPtr native__this)
		{
			Java.Lang.Object.GetObject<IScarAdListenerWrapper>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).OnAdClicked();
		}

		// Token: 0x0600264C RID: 9804 RVA: 0x00062B33 File Offset: 0x00060D33
		public void OnAdClicked()
		{
			if (this.id_onAdClicked == IntPtr.Zero)
			{
				this.id_onAdClicked = JNIEnv.GetMethodID(this.class_ref, "onAdClicked", "()V");
			}
			JNIEnv.CallVoidMethod(base.Handle, this.id_onAdClicked);
		}

		// Token: 0x0600264D RID: 9805 RVA: 0x00062B73 File Offset: 0x00060D73
		private static Delegate GetOnAdClosedHandler()
		{
			if (IScarAdListenerWrapperInvoker.cb_onAdClosed == null)
			{
				IScarAdListenerWrapperInvoker.cb_onAdClosed = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_V(IScarAdListenerWrapperInvoker.n_OnAdClosed));
			}
			return IScarAdListenerWrapperInvoker.cb_onAdClosed;
		}

		// Token: 0x0600264E RID: 9806 RVA: 0x00062B97 File Offset: 0x00060D97
		private static void n_OnAdClosed(IntPtr jnienv, IntPtr native__this)
		{
			Java.Lang.Object.GetObject<IScarAdListenerWrapper>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).OnAdClosed();
		}

		// Token: 0x0600264F RID: 9807 RVA: 0x00062BA6 File Offset: 0x00060DA6
		public void OnAdClosed()
		{
			if (this.id_onAdClosed == IntPtr.Zero)
			{
				this.id_onAdClosed = JNIEnv.GetMethodID(this.class_ref, "onAdClosed", "()V");
			}
			JNIEnv.CallVoidMethod(base.Handle, this.id_onAdClosed);
		}

		// Token: 0x06002650 RID: 9808 RVA: 0x00062BE6 File Offset: 0x00060DE6
		private static Delegate GetOnAdFailedToLoad_ILjava_lang_String_Handler()
		{
			if (IScarAdListenerWrapperInvoker.cb_onAdFailedToLoad_ILjava_lang_String_ == null)
			{
				IScarAdListenerWrapperInvoker.cb_onAdFailedToLoad_ILjava_lang_String_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPIL_V(IScarAdListenerWrapperInvoker.n_OnAdFailedToLoad_ILjava_lang_String_));
			}
			return IScarAdListenerWrapperInvoker.cb_onAdFailedToLoad_ILjava_lang_String_;
		}

		// Token: 0x06002651 RID: 9809 RVA: 0x00062C0C File Offset: 0x00060E0C
		private static void n_OnAdFailedToLoad_ILjava_lang_String_(IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1)
		{
			IScarAdListenerWrapper @object = Java.Lang.Object.GetObject<IScarAdListenerWrapper>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string @string = JNIEnv.GetString(native_p1, JniHandleOwnership.DoNotTransfer);
			@object.OnAdFailedToLoad(p0, @string);
		}

		// Token: 0x06002652 RID: 9810 RVA: 0x00062C30 File Offset: 0x00060E30
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

		// Token: 0x06002653 RID: 9811 RVA: 0x00062CB4 File Offset: 0x00060EB4
		private static Delegate GetOnAdLoadedHandler()
		{
			if (IScarAdListenerWrapperInvoker.cb_onAdLoaded == null)
			{
				IScarAdListenerWrapperInvoker.cb_onAdLoaded = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_V(IScarAdListenerWrapperInvoker.n_OnAdLoaded));
			}
			return IScarAdListenerWrapperInvoker.cb_onAdLoaded;
		}

		// Token: 0x06002654 RID: 9812 RVA: 0x00062CD8 File Offset: 0x00060ED8
		private static void n_OnAdLoaded(IntPtr jnienv, IntPtr native__this)
		{
			Java.Lang.Object.GetObject<IScarAdListenerWrapper>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).OnAdLoaded();
		}

		// Token: 0x06002655 RID: 9813 RVA: 0x00062CE7 File Offset: 0x00060EE7
		public void OnAdLoaded()
		{
			if (this.id_onAdLoaded == IntPtr.Zero)
			{
				this.id_onAdLoaded = JNIEnv.GetMethodID(this.class_ref, "onAdLoaded", "()V");
			}
			JNIEnv.CallVoidMethod(base.Handle, this.id_onAdLoaded);
		}

		// Token: 0x06002656 RID: 9814 RVA: 0x00062D27 File Offset: 0x00060F27
		private static Delegate GetOnAdOpenedHandler()
		{
			if (IScarAdListenerWrapperInvoker.cb_onAdOpened == null)
			{
				IScarAdListenerWrapperInvoker.cb_onAdOpened = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_V(IScarAdListenerWrapperInvoker.n_OnAdOpened));
			}
			return IScarAdListenerWrapperInvoker.cb_onAdOpened;
		}

		// Token: 0x06002657 RID: 9815 RVA: 0x00062D4B File Offset: 0x00060F4B
		private static void n_OnAdOpened(IntPtr jnienv, IntPtr native__this)
		{
			Java.Lang.Object.GetObject<IScarAdListenerWrapper>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).OnAdOpened();
		}

		// Token: 0x06002658 RID: 9816 RVA: 0x00062D5A File Offset: 0x00060F5A
		public void OnAdOpened()
		{
			if (this.id_onAdOpened == IntPtr.Zero)
			{
				this.id_onAdOpened = JNIEnv.GetMethodID(this.class_ref, "onAdOpened", "()V");
			}
			JNIEnv.CallVoidMethod(base.Handle, this.id_onAdOpened);
		}

		// Token: 0x06002659 RID: 9817 RVA: 0x00062D9A File Offset: 0x00060F9A
		private static Delegate GetOnAdSkippedHandler()
		{
			if (IScarAdListenerWrapperInvoker.cb_onAdSkipped == null)
			{
				IScarAdListenerWrapperInvoker.cb_onAdSkipped = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_V(IScarAdListenerWrapperInvoker.n_OnAdSkipped));
			}
			return IScarAdListenerWrapperInvoker.cb_onAdSkipped;
		}

		// Token: 0x0600265A RID: 9818 RVA: 0x00062DBE File Offset: 0x00060FBE
		private static void n_OnAdSkipped(IntPtr jnienv, IntPtr native__this)
		{
			Java.Lang.Object.GetObject<IScarAdListenerWrapper>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).OnAdSkipped();
		}

		// Token: 0x0600265B RID: 9819 RVA: 0x00062DCD File Offset: 0x00060FCD
		public void OnAdSkipped()
		{
			if (this.id_onAdSkipped == IntPtr.Zero)
			{
				this.id_onAdSkipped = JNIEnv.GetMethodID(this.class_ref, "onAdSkipped", "()V");
			}
			JNIEnv.CallVoidMethod(base.Handle, this.id_onAdSkipped);
		}

		// Token: 0x04000770 RID: 1904
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/unity3d/scar/adapter/common/IScarAdListenerWrapper", typeof(IScarAdListenerWrapperInvoker));

		// Token: 0x04000771 RID: 1905
		private IntPtr class_ref;

		// Token: 0x04000772 RID: 1906
		private static Delegate cb_onAdClicked;

		// Token: 0x04000773 RID: 1907
		private IntPtr id_onAdClicked;

		// Token: 0x04000774 RID: 1908
		private static Delegate cb_onAdClosed;

		// Token: 0x04000775 RID: 1909
		private IntPtr id_onAdClosed;

		// Token: 0x04000776 RID: 1910
		private static Delegate cb_onAdFailedToLoad_ILjava_lang_String_;

		// Token: 0x04000777 RID: 1911
		private IntPtr id_onAdFailedToLoad_ILjava_lang_String_;

		// Token: 0x04000778 RID: 1912
		private static Delegate cb_onAdLoaded;

		// Token: 0x04000779 RID: 1913
		private IntPtr id_onAdLoaded;

		// Token: 0x0400077A RID: 1914
		private static Delegate cb_onAdOpened;

		// Token: 0x0400077B RID: 1915
		private IntPtr id_onAdOpened;

		// Token: 0x0400077C RID: 1916
		private static Delegate cb_onAdSkipped;

		// Token: 0x0400077D RID: 1917
		private IntPtr id_onAdSkipped;
	}
}
