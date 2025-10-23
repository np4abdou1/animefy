using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Com.Unity3d.Ads
{
	// Token: 0x020002D4 RID: 724
	[Register("com/unity3d/ads/IUnityAdsTokenListener", DoNotGenerateAcw = true)]
	internal class IUnityAdsTokenListenerInvoker : Java.Lang.Object, IUnityAdsTokenListener, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x17000F30 RID: 3888
		// (get) Token: 0x0600283D RID: 10301 RVA: 0x00067CD4 File Offset: 0x00065ED4
		private static IntPtr java_class_ref
		{
			get
			{
				return IUnityAdsTokenListenerInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000F31 RID: 3889
		// (get) Token: 0x0600283E RID: 10302 RVA: 0x00067CF8 File Offset: 0x00065EF8
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return IUnityAdsTokenListenerInvoker._members;
			}
		}

		// Token: 0x17000F32 RID: 3890
		// (get) Token: 0x0600283F RID: 10303 RVA: 0x00067CFF File Offset: 0x00065EFF
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x17000F33 RID: 3891
		// (get) Token: 0x06002840 RID: 10304 RVA: 0x00067D07 File Offset: 0x00065F07
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return IUnityAdsTokenListenerInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x06002841 RID: 10305 RVA: 0x00067D13 File Offset: 0x00065F13
		public static IUnityAdsTokenListener GetObject(IntPtr handle, JniHandleOwnership transfer)
		{
			return Java.Lang.Object.GetObject<IUnityAdsTokenListener>(handle, transfer);
		}

		// Token: 0x06002842 RID: 10306 RVA: 0x00067D1C File Offset: 0x00065F1C
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, IUnityAdsTokenListenerInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'com.unity3d.ads.IUnityAdsTokenListener'.");
			}
			return handle;
		}

		// Token: 0x06002843 RID: 10307 RVA: 0x00067D47 File Offset: 0x00065F47
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x06002844 RID: 10308 RVA: 0x00067D78 File Offset: 0x00065F78
		public IUnityAdsTokenListenerInvoker(IntPtr handle, JniHandleOwnership transfer) : base(IUnityAdsTokenListenerInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x06002845 RID: 10309 RVA: 0x00067DB0 File Offset: 0x00065FB0
		private static Delegate GetOnUnityAdsTokenReady_Ljava_lang_String_Handler()
		{
			if (IUnityAdsTokenListenerInvoker.cb_onUnityAdsTokenReady_Ljava_lang_String_ == null)
			{
				IUnityAdsTokenListenerInvoker.cb_onUnityAdsTokenReady_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(IUnityAdsTokenListenerInvoker.n_OnUnityAdsTokenReady_Ljava_lang_String_));
			}
			return IUnityAdsTokenListenerInvoker.cb_onUnityAdsTokenReady_Ljava_lang_String_;
		}

		// Token: 0x06002846 RID: 10310 RVA: 0x00067DD4 File Offset: 0x00065FD4
		private static void n_OnUnityAdsTokenReady_Ljava_lang_String_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			IUnityAdsTokenListener @object = Java.Lang.Object.GetObject<IUnityAdsTokenListener>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string @string = JNIEnv.GetString(native_p0, JniHandleOwnership.DoNotTransfer);
			@object.OnUnityAdsTokenReady(@string);
		}

		// Token: 0x06002847 RID: 10311 RVA: 0x00067DF8 File Offset: 0x00065FF8
		public unsafe void OnUnityAdsTokenReady(string p0)
		{
			if (this.id_onUnityAdsTokenReady_Ljava_lang_String_ == IntPtr.Zero)
			{
				this.id_onUnityAdsTokenReady_Ljava_lang_String_ = JNIEnv.GetMethodID(this.class_ref, "onUnityAdsTokenReady", "(Ljava/lang/String;)V");
			}
			IntPtr intPtr = JNIEnv.NewString(p0);
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue(intPtr);
			JNIEnv.CallVoidMethod(base.Handle, this.id_onUnityAdsTokenReady_Ljava_lang_String_, ptr);
			JNIEnv.DeleteLocalRef(intPtr);
		}

		// Token: 0x04000833 RID: 2099
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/unity3d/ads/IUnityAdsTokenListener", typeof(IUnityAdsTokenListenerInvoker));

		// Token: 0x04000834 RID: 2100
		private IntPtr class_ref;

		// Token: 0x04000835 RID: 2101
		private static Delegate cb_onUnityAdsTokenReady_Ljava_lang_String_;

		// Token: 0x04000836 RID: 2102
		private IntPtr id_onUnityAdsTokenReady_Ljava_lang_String_;
	}
}
