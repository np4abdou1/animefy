using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Com.Applovin.Sdk
{
	// Token: 0x02000073 RID: 115
	[Register("com/applovin/sdk/AppLovinAdLoadListener", DoNotGenerateAcw = true)]
	internal class IAppLovinAdLoadListenerInvoker : Java.Lang.Object, IAppLovinAdLoadListener, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x17000137 RID: 311
		// (get) Token: 0x060003D7 RID: 983 RVA: 0x0000A7B4 File Offset: 0x000089B4
		private static IntPtr java_class_ref
		{
			get
			{
				return IAppLovinAdLoadListenerInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000138 RID: 312
		// (get) Token: 0x060003D8 RID: 984 RVA: 0x0000A7D8 File Offset: 0x000089D8
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return IAppLovinAdLoadListenerInvoker._members;
			}
		}

		// Token: 0x17000139 RID: 313
		// (get) Token: 0x060003D9 RID: 985 RVA: 0x0000A7DF File Offset: 0x000089DF
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x1700013A RID: 314
		// (get) Token: 0x060003DA RID: 986 RVA: 0x0000A7E7 File Offset: 0x000089E7
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return IAppLovinAdLoadListenerInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x060003DB RID: 987 RVA: 0x0000A7F3 File Offset: 0x000089F3
		public static IAppLovinAdLoadListener GetObject(IntPtr handle, JniHandleOwnership transfer)
		{
			return Java.Lang.Object.GetObject<IAppLovinAdLoadListener>(handle, transfer);
		}

		// Token: 0x060003DC RID: 988 RVA: 0x0000A7FC File Offset: 0x000089FC
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, IAppLovinAdLoadListenerInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'com.applovin.sdk.AppLovinAdLoadListener'.");
			}
			return handle;
		}

		// Token: 0x060003DD RID: 989 RVA: 0x0000A827 File Offset: 0x00008A27
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x060003DE RID: 990 RVA: 0x0000A858 File Offset: 0x00008A58
		public IAppLovinAdLoadListenerInvoker(IntPtr handle, JniHandleOwnership transfer) : base(IAppLovinAdLoadListenerInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x060003DF RID: 991 RVA: 0x0000A890 File Offset: 0x00008A90
		private static Delegate GetAdReceived_Lcom_applovin_sdk_AppLovinAd_Handler()
		{
			if (IAppLovinAdLoadListenerInvoker.cb_adReceived_Lcom_applovin_sdk_AppLovinAd_ == null)
			{
				IAppLovinAdLoadListenerInvoker.cb_adReceived_Lcom_applovin_sdk_AppLovinAd_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(IAppLovinAdLoadListenerInvoker.n_AdReceived_Lcom_applovin_sdk_AppLovinAd_));
			}
			return IAppLovinAdLoadListenerInvoker.cb_adReceived_Lcom_applovin_sdk_AppLovinAd_;
		}

		// Token: 0x060003E0 RID: 992 RVA: 0x0000A8B4 File Offset: 0x00008AB4
		private static void n_AdReceived_Lcom_applovin_sdk_AppLovinAd_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			IAppLovinAdLoadListener @object = Java.Lang.Object.GetObject<IAppLovinAdLoadListener>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			IAppLovinAd object2 = Java.Lang.Object.GetObject<IAppLovinAd>(native_p0, JniHandleOwnership.DoNotTransfer);
			@object.AdReceived(object2);
		}

		// Token: 0x060003E1 RID: 993 RVA: 0x0000A8D8 File Offset: 0x00008AD8
		public unsafe void AdReceived(IAppLovinAd p0)
		{
			if (this.id_adReceived_Lcom_applovin_sdk_AppLovinAd_ == IntPtr.Zero)
			{
				this.id_adReceived_Lcom_applovin_sdk_AppLovinAd_ = JNIEnv.GetMethodID(this.class_ref, "adReceived", "(Lcom/applovin/sdk/AppLovinAd;)V");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue((p0 == null) ? IntPtr.Zero : ((Java.Lang.Object)p0).Handle);
			JNIEnv.CallVoidMethod(base.Handle, this.id_adReceived_Lcom_applovin_sdk_AppLovinAd_, ptr);
		}

		// Token: 0x060003E2 RID: 994 RVA: 0x0000A950 File Offset: 0x00008B50
		private static Delegate GetFailedToReceiveAd_IHandler()
		{
			if (IAppLovinAdLoadListenerInvoker.cb_failedToReceiveAd_I == null)
			{
				IAppLovinAdLoadListenerInvoker.cb_failedToReceiveAd_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPI_V(IAppLovinAdLoadListenerInvoker.n_FailedToReceiveAd_I));
			}
			return IAppLovinAdLoadListenerInvoker.cb_failedToReceiveAd_I;
		}

		// Token: 0x060003E3 RID: 995 RVA: 0x0000A974 File Offset: 0x00008B74
		private static void n_FailedToReceiveAd_I(IntPtr jnienv, IntPtr native__this, int p0)
		{
			Java.Lang.Object.GetObject<IAppLovinAdLoadListener>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).FailedToReceiveAd(p0);
		}

		// Token: 0x060003E4 RID: 996 RVA: 0x0000A984 File Offset: 0x00008B84
		public unsafe void FailedToReceiveAd(int p0)
		{
			if (this.id_failedToReceiveAd_I == IntPtr.Zero)
			{
				this.id_failedToReceiveAd_I = JNIEnv.GetMethodID(this.class_ref, "failedToReceiveAd", "(I)V");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue(p0);
			JNIEnv.CallVoidMethod(base.Handle, this.id_failedToReceiveAd_I, ptr);
		}

		// Token: 0x040000FB RID: 251
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/applovin/sdk/AppLovinAdLoadListener", typeof(IAppLovinAdLoadListenerInvoker));

		// Token: 0x040000FC RID: 252
		private IntPtr class_ref;

		// Token: 0x040000FD RID: 253
		private static Delegate cb_adReceived_Lcom_applovin_sdk_AppLovinAd_;

		// Token: 0x040000FE RID: 254
		private IntPtr id_adReceived_Lcom_applovin_sdk_AppLovinAd_;

		// Token: 0x040000FF RID: 255
		private static Delegate cb_failedToReceiveAd_I;

		// Token: 0x04000100 RID: 256
		private IntPtr id_failedToReceiveAd_I;
	}
}
