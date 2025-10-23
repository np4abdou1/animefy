using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Android.Gms.Ads.Initialization
{
	// Token: 0x0200003E RID: 62
	[Register("com/google/android/gms/ads/initialization/OnInitializationCompleteListener", DoNotGenerateAcw = true)]
	internal class IOnInitializationCompleteListenerInvoker : Java.Lang.Object, IOnInitializationCompleteListener, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x170000C8 RID: 200
		// (get) Token: 0x06000264 RID: 612 RVA: 0x00007604 File Offset: 0x00005804
		private static IntPtr java_class_ref
		{
			get
			{
				return IOnInitializationCompleteListenerInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170000C9 RID: 201
		// (get) Token: 0x06000265 RID: 613 RVA: 0x00007628 File Offset: 0x00005828
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return IOnInitializationCompleteListenerInvoker._members;
			}
		}

		// Token: 0x170000CA RID: 202
		// (get) Token: 0x06000266 RID: 614 RVA: 0x0000762F File Offset: 0x0000582F
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x170000CB RID: 203
		// (get) Token: 0x06000267 RID: 615 RVA: 0x00007637 File Offset: 0x00005837
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return IOnInitializationCompleteListenerInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x06000268 RID: 616 RVA: 0x00007643 File Offset: 0x00005843
		public static IOnInitializationCompleteListener GetObject(IntPtr handle, JniHandleOwnership transfer)
		{
			return Java.Lang.Object.GetObject<IOnInitializationCompleteListener>(handle, transfer);
		}

		// Token: 0x06000269 RID: 617 RVA: 0x0000764C File Offset: 0x0000584C
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, IOnInitializationCompleteListenerInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'com.google.android.gms.ads.initialization.OnInitializationCompleteListener'.");
			}
			return handle;
		}

		// Token: 0x0600026A RID: 618 RVA: 0x00007677 File Offset: 0x00005877
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x0600026B RID: 619 RVA: 0x000076A8 File Offset: 0x000058A8
		public IOnInitializationCompleteListenerInvoker(IntPtr handle, JniHandleOwnership transfer) : base(IOnInitializationCompleteListenerInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x0600026C RID: 620 RVA: 0x000076E0 File Offset: 0x000058E0
		private static Delegate GetOnInitializationComplete_Lcom_google_android_gms_ads_initialization_InitializationStatus_Handler()
		{
			if (IOnInitializationCompleteListenerInvoker.cb_onInitializationComplete_Lcom_google_android_gms_ads_initialization_InitializationStatus_ == null)
			{
				IOnInitializationCompleteListenerInvoker.cb_onInitializationComplete_Lcom_google_android_gms_ads_initialization_InitializationStatus_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(IOnInitializationCompleteListenerInvoker.n_OnInitializationComplete_Lcom_google_android_gms_ads_initialization_InitializationStatus_));
			}
			return IOnInitializationCompleteListenerInvoker.cb_onInitializationComplete_Lcom_google_android_gms_ads_initialization_InitializationStatus_;
		}

		// Token: 0x0600026D RID: 621 RVA: 0x00007704 File Offset: 0x00005904
		private static void n_OnInitializationComplete_Lcom_google_android_gms_ads_initialization_InitializationStatus_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			IOnInitializationCompleteListener @object = Java.Lang.Object.GetObject<IOnInitializationCompleteListener>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			IInitializationStatus object2 = Java.Lang.Object.GetObject<IInitializationStatus>(native_p0, JniHandleOwnership.DoNotTransfer);
			@object.OnInitializationComplete(object2);
		}

		// Token: 0x0600026E RID: 622 RVA: 0x00007728 File Offset: 0x00005928
		public unsafe void OnInitializationComplete(IInitializationStatus p0)
		{
			if (this.id_onInitializationComplete_Lcom_google_android_gms_ads_initialization_InitializationStatus_ == IntPtr.Zero)
			{
				this.id_onInitializationComplete_Lcom_google_android_gms_ads_initialization_InitializationStatus_ = JNIEnv.GetMethodID(this.class_ref, "onInitializationComplete", "(Lcom/google/android/gms/ads/initialization/InitializationStatus;)V");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue((p0 == null) ? IntPtr.Zero : ((Java.Lang.Object)p0).Handle);
			JNIEnv.CallVoidMethod(base.Handle, this.id_onInitializationComplete_Lcom_google_android_gms_ads_initialization_InitializationStatus_, ptr);
		}

		// Token: 0x04000094 RID: 148
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/google/android/gms/ads/initialization/OnInitializationCompleteListener", typeof(IOnInitializationCompleteListenerInvoker));

		// Token: 0x04000095 RID: 149
		private IntPtr class_ref;

		// Token: 0x04000096 RID: 150
		private static Delegate cb_onInitializationComplete_Lcom_google_android_gms_ads_initialization_InitializationStatus_;

		// Token: 0x04000097 RID: 151
		private IntPtr id_onInitializationComplete_Lcom_google_android_gms_ads_initialization_InitializationStatus_;
	}
}
