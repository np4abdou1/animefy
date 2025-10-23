using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Com.Applovin.Sdk
{
	// Token: 0x02000090 RID: 144
	[Register("com/applovin/sdk/AppLovinSdkConfiguration", DoNotGenerateAcw = true)]
	internal class IAppLovinSdkConfigurationInvoker : Java.Lang.Object, IAppLovinSdkConfiguration, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x17000171 RID: 369
		// (get) Token: 0x060004A6 RID: 1190 RVA: 0x0000C684 File Offset: 0x0000A884
		private static IntPtr java_class_ref
		{
			get
			{
				return IAppLovinSdkConfigurationInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000172 RID: 370
		// (get) Token: 0x060004A7 RID: 1191 RVA: 0x0000C6A8 File Offset: 0x0000A8A8
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return IAppLovinSdkConfigurationInvoker._members;
			}
		}

		// Token: 0x17000173 RID: 371
		// (get) Token: 0x060004A8 RID: 1192 RVA: 0x0000C6AF File Offset: 0x0000A8AF
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x17000174 RID: 372
		// (get) Token: 0x060004A9 RID: 1193 RVA: 0x0000C6B7 File Offset: 0x0000A8B7
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return IAppLovinSdkConfigurationInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x060004AA RID: 1194 RVA: 0x0000C6C3 File Offset: 0x0000A8C3
		public static IAppLovinSdkConfiguration GetObject(IntPtr handle, JniHandleOwnership transfer)
		{
			return Java.Lang.Object.GetObject<IAppLovinSdkConfiguration>(handle, transfer);
		}

		// Token: 0x060004AB RID: 1195 RVA: 0x0000C6CC File Offset: 0x0000A8CC
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, IAppLovinSdkConfigurationInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'com.applovin.sdk.AppLovinSdkConfiguration'.");
			}
			return handle;
		}

		// Token: 0x060004AC RID: 1196 RVA: 0x0000C6F7 File Offset: 0x0000A8F7
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x060004AD RID: 1197 RVA: 0x0000C728 File Offset: 0x0000A928
		public IAppLovinSdkConfigurationInvoker(IntPtr handle, JniHandleOwnership transfer) : base(IAppLovinSdkConfigurationInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x060004AE RID: 1198 RVA: 0x0000C760 File Offset: 0x0000A960
		private static Delegate GetGetConsentDialogStateHandler()
		{
			if (IAppLovinSdkConfigurationInvoker.cb_getConsentDialogState == null)
			{
				IAppLovinSdkConfigurationInvoker.cb_getConsentDialogState = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IAppLovinSdkConfigurationInvoker.n_GetConsentDialogState));
			}
			return IAppLovinSdkConfigurationInvoker.cb_getConsentDialogState;
		}

		// Token: 0x060004AF RID: 1199 RVA: 0x0000C784 File Offset: 0x0000A984
		private static IntPtr n_GetConsentDialogState(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<IAppLovinSdkConfiguration>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ConsentDialogState);
		}

		// Token: 0x17000175 RID: 373
		// (get) Token: 0x060004B0 RID: 1200 RVA: 0x0000C798 File Offset: 0x0000A998
		public AppLovinSdkConfigurationConsentDialogState ConsentDialogState
		{
			get
			{
				if (this.id_getConsentDialogState == IntPtr.Zero)
				{
					this.id_getConsentDialogState = JNIEnv.GetMethodID(this.class_ref, "getConsentDialogState", "()Lcom/applovin/sdk/AppLovinSdkConfiguration$ConsentDialogState;");
				}
				return Java.Lang.Object.GetObject<AppLovinSdkConfigurationConsentDialogState>(JNIEnv.CallObjectMethod(base.Handle, this.id_getConsentDialogState), JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x060004B1 RID: 1201 RVA: 0x0000C7E9 File Offset: 0x0000A9E9
		private static Delegate GetGetCountryCodeHandler()
		{
			if (IAppLovinSdkConfigurationInvoker.cb_getCountryCode == null)
			{
				IAppLovinSdkConfigurationInvoker.cb_getCountryCode = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IAppLovinSdkConfigurationInvoker.n_GetCountryCode));
			}
			return IAppLovinSdkConfigurationInvoker.cb_getCountryCode;
		}

		// Token: 0x060004B2 RID: 1202 RVA: 0x0000C80D File Offset: 0x0000AA0D
		private static IntPtr n_GetCountryCode(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.NewString(Java.Lang.Object.GetObject<IAppLovinSdkConfiguration>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).CountryCode);
		}

		// Token: 0x17000176 RID: 374
		// (get) Token: 0x060004B3 RID: 1203 RVA: 0x0000C824 File Offset: 0x0000AA24
		public string CountryCode
		{
			get
			{
				if (this.id_getCountryCode == IntPtr.Zero)
				{
					this.id_getCountryCode = JNIEnv.GetMethodID(this.class_ref, "getCountryCode", "()Ljava/lang/String;");
				}
				return JNIEnv.GetString(JNIEnv.CallObjectMethod(base.Handle, this.id_getCountryCode), JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x04000155 RID: 341
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/applovin/sdk/AppLovinSdkConfiguration", typeof(IAppLovinSdkConfigurationInvoker));

		// Token: 0x04000156 RID: 342
		private IntPtr class_ref;

		// Token: 0x04000157 RID: 343
		private static Delegate cb_getConsentDialogState;

		// Token: 0x04000158 RID: 344
		private IntPtr id_getConsentDialogState;

		// Token: 0x04000159 RID: 345
		private static Delegate cb_getCountryCode;

		// Token: 0x0400015A RID: 346
		private IntPtr id_getCountryCode;
	}
}
