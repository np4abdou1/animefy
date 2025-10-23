using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Com.Applovin.Sdk
{
	// Token: 0x0200006E RID: 110
	[Register("com/applovin/sdk/AppLovinAdDisplayListener", DoNotGenerateAcw = true)]
	internal class IAppLovinAdDisplayListenerInvoker : Java.Lang.Object, IAppLovinAdDisplayListener, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x17000131 RID: 305
		// (get) Token: 0x060003BE RID: 958 RVA: 0x0000A468 File Offset: 0x00008668
		private static IntPtr java_class_ref
		{
			get
			{
				return IAppLovinAdDisplayListenerInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000132 RID: 306
		// (get) Token: 0x060003BF RID: 959 RVA: 0x0000A48C File Offset: 0x0000868C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return IAppLovinAdDisplayListenerInvoker._members;
			}
		}

		// Token: 0x17000133 RID: 307
		// (get) Token: 0x060003C0 RID: 960 RVA: 0x0000A493 File Offset: 0x00008693
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x17000134 RID: 308
		// (get) Token: 0x060003C1 RID: 961 RVA: 0x0000A49B File Offset: 0x0000869B
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return IAppLovinAdDisplayListenerInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x060003C2 RID: 962 RVA: 0x0000A4A7 File Offset: 0x000086A7
		public static IAppLovinAdDisplayListener GetObject(IntPtr handle, JniHandleOwnership transfer)
		{
			return Java.Lang.Object.GetObject<IAppLovinAdDisplayListener>(handle, transfer);
		}

		// Token: 0x060003C3 RID: 963 RVA: 0x0000A4B0 File Offset: 0x000086B0
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, IAppLovinAdDisplayListenerInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'com.applovin.sdk.AppLovinAdDisplayListener'.");
			}
			return handle;
		}

		// Token: 0x060003C4 RID: 964 RVA: 0x0000A4DB File Offset: 0x000086DB
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x060003C5 RID: 965 RVA: 0x0000A50C File Offset: 0x0000870C
		public IAppLovinAdDisplayListenerInvoker(IntPtr handle, JniHandleOwnership transfer) : base(IAppLovinAdDisplayListenerInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x060003C6 RID: 966 RVA: 0x0000A544 File Offset: 0x00008744
		private static Delegate GetAdDisplayed_Lcom_applovin_sdk_AppLovinAd_Handler()
		{
			if (IAppLovinAdDisplayListenerInvoker.cb_adDisplayed_Lcom_applovin_sdk_AppLovinAd_ == null)
			{
				IAppLovinAdDisplayListenerInvoker.cb_adDisplayed_Lcom_applovin_sdk_AppLovinAd_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(IAppLovinAdDisplayListenerInvoker.n_AdDisplayed_Lcom_applovin_sdk_AppLovinAd_));
			}
			return IAppLovinAdDisplayListenerInvoker.cb_adDisplayed_Lcom_applovin_sdk_AppLovinAd_;
		}

		// Token: 0x060003C7 RID: 967 RVA: 0x0000A568 File Offset: 0x00008768
		private static void n_AdDisplayed_Lcom_applovin_sdk_AppLovinAd_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			IAppLovinAdDisplayListener @object = Java.Lang.Object.GetObject<IAppLovinAdDisplayListener>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			IAppLovinAd object2 = Java.Lang.Object.GetObject<IAppLovinAd>(native_p0, JniHandleOwnership.DoNotTransfer);
			@object.AdDisplayed(object2);
		}

		// Token: 0x060003C8 RID: 968 RVA: 0x0000A58C File Offset: 0x0000878C
		public unsafe void AdDisplayed(IAppLovinAd p0)
		{
			if (this.id_adDisplayed_Lcom_applovin_sdk_AppLovinAd_ == IntPtr.Zero)
			{
				this.id_adDisplayed_Lcom_applovin_sdk_AppLovinAd_ = JNIEnv.GetMethodID(this.class_ref, "adDisplayed", "(Lcom/applovin/sdk/AppLovinAd;)V");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue((p0 == null) ? IntPtr.Zero : ((Java.Lang.Object)p0).Handle);
			JNIEnv.CallVoidMethod(base.Handle, this.id_adDisplayed_Lcom_applovin_sdk_AppLovinAd_, ptr);
		}

		// Token: 0x060003C9 RID: 969 RVA: 0x0000A604 File Offset: 0x00008804
		private static Delegate GetAdHidden_Lcom_applovin_sdk_AppLovinAd_Handler()
		{
			if (IAppLovinAdDisplayListenerInvoker.cb_adHidden_Lcom_applovin_sdk_AppLovinAd_ == null)
			{
				IAppLovinAdDisplayListenerInvoker.cb_adHidden_Lcom_applovin_sdk_AppLovinAd_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(IAppLovinAdDisplayListenerInvoker.n_AdHidden_Lcom_applovin_sdk_AppLovinAd_));
			}
			return IAppLovinAdDisplayListenerInvoker.cb_adHidden_Lcom_applovin_sdk_AppLovinAd_;
		}

		// Token: 0x060003CA RID: 970 RVA: 0x0000A628 File Offset: 0x00008828
		private static void n_AdHidden_Lcom_applovin_sdk_AppLovinAd_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			IAppLovinAdDisplayListener @object = Java.Lang.Object.GetObject<IAppLovinAdDisplayListener>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			IAppLovinAd object2 = Java.Lang.Object.GetObject<IAppLovinAd>(native_p0, JniHandleOwnership.DoNotTransfer);
			@object.AdHidden(object2);
		}

		// Token: 0x060003CB RID: 971 RVA: 0x0000A64C File Offset: 0x0000884C
		public unsafe void AdHidden(IAppLovinAd p0)
		{
			if (this.id_adHidden_Lcom_applovin_sdk_AppLovinAd_ == IntPtr.Zero)
			{
				this.id_adHidden_Lcom_applovin_sdk_AppLovinAd_ = JNIEnv.GetMethodID(this.class_ref, "adHidden", "(Lcom/applovin/sdk/AppLovinAd;)V");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue((p0 == null) ? IntPtr.Zero : ((Java.Lang.Object)p0).Handle);
			JNIEnv.CallVoidMethod(base.Handle, this.id_adHidden_Lcom_applovin_sdk_AppLovinAd_, ptr);
		}

		// Token: 0x040000F0 RID: 240
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/applovin/sdk/AppLovinAdDisplayListener", typeof(IAppLovinAdDisplayListenerInvoker));

		// Token: 0x040000F1 RID: 241
		private IntPtr class_ref;

		// Token: 0x040000F2 RID: 242
		private static Delegate cb_adDisplayed_Lcom_applovin_sdk_AppLovinAd_;

		// Token: 0x040000F3 RID: 243
		private IntPtr id_adDisplayed_Lcom_applovin_sdk_AppLovinAd_;

		// Token: 0x040000F4 RID: 244
		private static Delegate cb_adHidden_Lcom_applovin_sdk_AppLovinAd_;

		// Token: 0x040000F5 RID: 245
		private IntPtr id_adHidden_Lcom_applovin_sdk_AppLovinAd_;
	}
}
