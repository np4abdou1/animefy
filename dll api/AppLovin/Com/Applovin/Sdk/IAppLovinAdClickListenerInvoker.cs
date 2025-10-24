using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Com.Applovin.Sdk
{
	// Token: 0x0200006A RID: 106
	[Register("com/applovin/sdk/AppLovinAdClickListener", DoNotGenerateAcw = true)]
	internal class IAppLovinAdClickListenerInvoker : Java.Lang.Object, IAppLovinAdClickListener, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x1700012C RID: 300
		// (get) Token: 0x060003AB RID: 939 RVA: 0x0000A22C File Offset: 0x0000842C
		private static IntPtr java_class_ref
		{
			get
			{
				return IAppLovinAdClickListenerInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700012D RID: 301
		// (get) Token: 0x060003AC RID: 940 RVA: 0x0000A250 File Offset: 0x00008450
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return IAppLovinAdClickListenerInvoker._members;
			}
		}

		// Token: 0x1700012E RID: 302
		// (get) Token: 0x060003AD RID: 941 RVA: 0x0000A257 File Offset: 0x00008457
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x1700012F RID: 303
		// (get) Token: 0x060003AE RID: 942 RVA: 0x0000A25F File Offset: 0x0000845F
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return IAppLovinAdClickListenerInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x060003AF RID: 943 RVA: 0x0000A26B File Offset: 0x0000846B
		public static IAppLovinAdClickListener GetObject(IntPtr handle, JniHandleOwnership transfer)
		{
			return Java.Lang.Object.GetObject<IAppLovinAdClickListener>(handle, transfer);
		}

		// Token: 0x060003B0 RID: 944 RVA: 0x0000A274 File Offset: 0x00008474
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, IAppLovinAdClickListenerInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'com.applovin.sdk.AppLovinAdClickListener'.");
			}
			return handle;
		}

		// Token: 0x060003B1 RID: 945 RVA: 0x0000A29F File Offset: 0x0000849F
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x060003B2 RID: 946 RVA: 0x0000A2D0 File Offset: 0x000084D0
		public IAppLovinAdClickListenerInvoker(IntPtr handle, JniHandleOwnership transfer) : base(IAppLovinAdClickListenerInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x060003B3 RID: 947 RVA: 0x0000A308 File Offset: 0x00008508
		private static Delegate GetAdClicked_Lcom_applovin_sdk_AppLovinAd_Handler()
		{
			if (IAppLovinAdClickListenerInvoker.cb_adClicked_Lcom_applovin_sdk_AppLovinAd_ == null)
			{
				IAppLovinAdClickListenerInvoker.cb_adClicked_Lcom_applovin_sdk_AppLovinAd_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(IAppLovinAdClickListenerInvoker.n_AdClicked_Lcom_applovin_sdk_AppLovinAd_));
			}
			return IAppLovinAdClickListenerInvoker.cb_adClicked_Lcom_applovin_sdk_AppLovinAd_;
		}

		// Token: 0x060003B4 RID: 948 RVA: 0x0000A32C File Offset: 0x0000852C
		private static void n_AdClicked_Lcom_applovin_sdk_AppLovinAd_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			IAppLovinAdClickListener @object = Java.Lang.Object.GetObject<IAppLovinAdClickListener>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			IAppLovinAd object2 = Java.Lang.Object.GetObject<IAppLovinAd>(native_p0, JniHandleOwnership.DoNotTransfer);
			@object.AdClicked(object2);
		}

		// Token: 0x060003B5 RID: 949 RVA: 0x0000A350 File Offset: 0x00008550
		public unsafe void AdClicked(IAppLovinAd p0)
		{
			if (this.id_adClicked_Lcom_applovin_sdk_AppLovinAd_ == IntPtr.Zero)
			{
				this.id_adClicked_Lcom_applovin_sdk_AppLovinAd_ = JNIEnv.GetMethodID(this.class_ref, "adClicked", "(Lcom/applovin/sdk/AppLovinAd;)V");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue((p0 == null) ? IntPtr.Zero : ((Java.Lang.Object)p0).Handle);
			JNIEnv.CallVoidMethod(base.Handle, this.id_adClicked_Lcom_applovin_sdk_AppLovinAd_, ptr);
		}

		// Token: 0x040000E9 RID: 233
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/applovin/sdk/AppLovinAdClickListener", typeof(IAppLovinAdClickListenerInvoker));

		// Token: 0x040000EA RID: 234
		private IntPtr class_ref;

		// Token: 0x040000EB RID: 235
		private static Delegate cb_adClicked_Lcom_applovin_sdk_AppLovinAd_;

		// Token: 0x040000EC RID: 236
		private IntPtr id_adClicked_Lcom_applovin_sdk_AppLovinAd_;
	}
}
