using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Com.Unity3d.Services.Core.Request.Metrics;
using Java.Interop;
using Java.Lang;

namespace Com.Unity3d.Services.Core.Configuration
{
	// Token: 0x0200016D RID: 365
	[Register("com/unity3d/services/core/configuration/IInitializeEventsMetricSender", DoNotGenerateAcw = true)]
	internal class IInitializeEventsMetricSenderInvoker : Java.Lang.Object, IInitializeEventsMetricSender, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x170005B6 RID: 1462
		// (get) Token: 0x06000FDE RID: 4062 RVA: 0x0002AAF8 File Offset: 0x00028CF8
		private static IntPtr java_class_ref
		{
			get
			{
				return IInitializeEventsMetricSenderInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170005B7 RID: 1463
		// (get) Token: 0x06000FDF RID: 4063 RVA: 0x0002AB1C File Offset: 0x00028D1C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return IInitializeEventsMetricSenderInvoker._members;
			}
		}

		// Token: 0x170005B8 RID: 1464
		// (get) Token: 0x06000FE0 RID: 4064 RVA: 0x0002AB23 File Offset: 0x00028D23
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x170005B9 RID: 1465
		// (get) Token: 0x06000FE1 RID: 4065 RVA: 0x0002AB2B File Offset: 0x00028D2B
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return IInitializeEventsMetricSenderInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x06000FE2 RID: 4066 RVA: 0x0002AB37 File Offset: 0x00028D37
		public static IInitializeEventsMetricSender GetObject(IntPtr handle, JniHandleOwnership transfer)
		{
			return Java.Lang.Object.GetObject<IInitializeEventsMetricSender>(handle, transfer);
		}

		// Token: 0x06000FE3 RID: 4067 RVA: 0x0002AB40 File Offset: 0x00028D40
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, IInitializeEventsMetricSenderInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'com.unity3d.services.core.configuration.IInitializeEventsMetricSender'.");
			}
			return handle;
		}

		// Token: 0x06000FE4 RID: 4068 RVA: 0x0002AB6B File Offset: 0x00028D6B
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x06000FE5 RID: 4069 RVA: 0x0002AB9C File Offset: 0x00028D9C
		public IInitializeEventsMetricSenderInvoker(IntPtr handle, JniHandleOwnership transfer) : base(IInitializeEventsMetricSenderInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x06000FE6 RID: 4070 RVA: 0x0002ABD4 File Offset: 0x00028DD4
		private static Delegate GetGetRetryTagsHandler()
		{
			if (IInitializeEventsMetricSenderInvoker.cb_getRetryTags == null)
			{
				IInitializeEventsMetricSenderInvoker.cb_getRetryTags = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IInitializeEventsMetricSenderInvoker.n_GetRetryTags));
			}
			return IInitializeEventsMetricSenderInvoker.cb_getRetryTags;
		}

		// Token: 0x06000FE7 RID: 4071 RVA: 0x0002ABF8 File Offset: 0x00028DF8
		private static IntPtr n_GetRetryTags(IntPtr jnienv, IntPtr native__this)
		{
			return JavaDictionary<string, string>.ToLocalJniHandle(Java.Lang.Object.GetObject<IInitializeEventsMetricSender>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).RetryTags);
		}

		// Token: 0x170005BA RID: 1466
		// (get) Token: 0x06000FE8 RID: 4072 RVA: 0x0002AC0C File Offset: 0x00028E0C
		public IDictionary<string, string> RetryTags
		{
			get
			{
				if (this.id_getRetryTags == IntPtr.Zero)
				{
					this.id_getRetryTags = JNIEnv.GetMethodID(this.class_ref, "getRetryTags", "()Ljava/util/Map;");
				}
				return JavaDictionary<string, string>.FromJniHandle(JNIEnv.CallObjectMethod(base.Handle, this.id_getRetryTags), JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x06000FE9 RID: 4073 RVA: 0x0002AC5D File Offset: 0x00028E5D
		private static Delegate GetConfigRequestDurationHandler()
		{
			if (IInitializeEventsMetricSenderInvoker.cb_configRequestDuration == null)
			{
				IInitializeEventsMetricSenderInvoker.cb_configRequestDuration = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IInitializeEventsMetricSenderInvoker.n_ConfigRequestDuration));
			}
			return IInitializeEventsMetricSenderInvoker.cb_configRequestDuration;
		}

		// Token: 0x06000FEA RID: 4074 RVA: 0x0002AC81 File Offset: 0x00028E81
		private static IntPtr n_ConfigRequestDuration(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<IInitializeEventsMetricSender>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ConfigRequestDuration());
		}

		// Token: 0x06000FEB RID: 4075 RVA: 0x0002AC98 File Offset: 0x00028E98
		public Long ConfigRequestDuration()
		{
			if (this.id_configRequestDuration == IntPtr.Zero)
			{
				this.id_configRequestDuration = JNIEnv.GetMethodID(this.class_ref, "configRequestDuration", "()Ljava/lang/Long;");
			}
			return Java.Lang.Object.GetObject<Long>(JNIEnv.CallObjectMethod(base.Handle, this.id_configRequestDuration), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x06000FEC RID: 4076 RVA: 0x0002ACE9 File Offset: 0x00028EE9
		private static Delegate GetDidConfigRequestEnd_ZHandler()
		{
			if (IInitializeEventsMetricSenderInvoker.cb_didConfigRequestEnd_Z == null)
			{
				IInitializeEventsMetricSenderInvoker.cb_didConfigRequestEnd_Z = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPZ_V(IInitializeEventsMetricSenderInvoker.n_DidConfigRequestEnd_Z));
			}
			return IInitializeEventsMetricSenderInvoker.cb_didConfigRequestEnd_Z;
		}

		// Token: 0x06000FED RID: 4077 RVA: 0x0002AD0D File Offset: 0x00028F0D
		private static void n_DidConfigRequestEnd_Z(IntPtr jnienv, IntPtr native__this, bool p0)
		{
			Java.Lang.Object.GetObject<IInitializeEventsMetricSender>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).DidConfigRequestEnd(p0);
		}

		// Token: 0x06000FEE RID: 4078 RVA: 0x0002AD20 File Offset: 0x00028F20
		public unsafe void DidConfigRequestEnd(bool p0)
		{
			if (this.id_didConfigRequestEnd_Z == IntPtr.Zero)
			{
				this.id_didConfigRequestEnd_Z = JNIEnv.GetMethodID(this.class_ref, "didConfigRequestEnd", "(Z)V");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue(p0);
			JNIEnv.CallVoidMethod(base.Handle, this.id_didConfigRequestEnd_Z, ptr);
		}

		// Token: 0x06000FEF RID: 4079 RVA: 0x0002AD84 File Offset: 0x00028F84
		private static Delegate GetDidConfigRequestStartHandler()
		{
			if (IInitializeEventsMetricSenderInvoker.cb_didConfigRequestStart == null)
			{
				IInitializeEventsMetricSenderInvoker.cb_didConfigRequestStart = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_V(IInitializeEventsMetricSenderInvoker.n_DidConfigRequestStart));
			}
			return IInitializeEventsMetricSenderInvoker.cb_didConfigRequestStart;
		}

		// Token: 0x06000FF0 RID: 4080 RVA: 0x0002ADA8 File Offset: 0x00028FA8
		private static void n_DidConfigRequestStart(IntPtr jnienv, IntPtr native__this)
		{
			Java.Lang.Object.GetObject<IInitializeEventsMetricSender>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).DidConfigRequestStart();
		}

		// Token: 0x06000FF1 RID: 4081 RVA: 0x0002ADB7 File Offset: 0x00028FB7
		public void DidConfigRequestStart()
		{
			if (this.id_didConfigRequestStart == IntPtr.Zero)
			{
				this.id_didConfigRequestStart = JNIEnv.GetMethodID(this.class_ref, "didConfigRequestStart", "()V");
			}
			JNIEnv.CallVoidMethod(base.Handle, this.id_didConfigRequestStart);
		}

		// Token: 0x06000FF2 RID: 4082 RVA: 0x0002ADF7 File Offset: 0x00028FF7
		private static Delegate GetDidInitStartHandler()
		{
			if (IInitializeEventsMetricSenderInvoker.cb_didInitStart == null)
			{
				IInitializeEventsMetricSenderInvoker.cb_didInitStart = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_V(IInitializeEventsMetricSenderInvoker.n_DidInitStart));
			}
			return IInitializeEventsMetricSenderInvoker.cb_didInitStart;
		}

		// Token: 0x06000FF3 RID: 4083 RVA: 0x0002AE1B File Offset: 0x0002901B
		private static void n_DidInitStart(IntPtr jnienv, IntPtr native__this)
		{
			Java.Lang.Object.GetObject<IInitializeEventsMetricSender>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).DidInitStart();
		}

		// Token: 0x06000FF4 RID: 4084 RVA: 0x0002AE2A File Offset: 0x0002902A
		public void DidInitStart()
		{
			if (this.id_didInitStart == IntPtr.Zero)
			{
				this.id_didInitStart = JNIEnv.GetMethodID(this.class_ref, "didInitStart", "()V");
			}
			JNIEnv.CallVoidMethod(base.Handle, this.id_didInitStart);
		}

		// Token: 0x06000FF5 RID: 4085 RVA: 0x0002AE6A File Offset: 0x0002906A
		private static Delegate GetDidPrivacyConfigRequestEnd_ZHandler()
		{
			if (IInitializeEventsMetricSenderInvoker.cb_didPrivacyConfigRequestEnd_Z == null)
			{
				IInitializeEventsMetricSenderInvoker.cb_didPrivacyConfigRequestEnd_Z = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPZ_V(IInitializeEventsMetricSenderInvoker.n_DidPrivacyConfigRequestEnd_Z));
			}
			return IInitializeEventsMetricSenderInvoker.cb_didPrivacyConfigRequestEnd_Z;
		}

		// Token: 0x06000FF6 RID: 4086 RVA: 0x0002AE8E File Offset: 0x0002908E
		private static void n_DidPrivacyConfigRequestEnd_Z(IntPtr jnienv, IntPtr native__this, bool p0)
		{
			Java.Lang.Object.GetObject<IInitializeEventsMetricSender>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).DidPrivacyConfigRequestEnd(p0);
		}

		// Token: 0x06000FF7 RID: 4087 RVA: 0x0002AEA0 File Offset: 0x000290A0
		public unsafe void DidPrivacyConfigRequestEnd(bool p0)
		{
			if (this.id_didPrivacyConfigRequestEnd_Z == IntPtr.Zero)
			{
				this.id_didPrivacyConfigRequestEnd_Z = JNIEnv.GetMethodID(this.class_ref, "didPrivacyConfigRequestEnd", "(Z)V");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue(p0);
			JNIEnv.CallVoidMethod(base.Handle, this.id_didPrivacyConfigRequestEnd_Z, ptr);
		}

		// Token: 0x06000FF8 RID: 4088 RVA: 0x0002AF04 File Offset: 0x00029104
		private static Delegate GetDidPrivacyConfigRequestStartHandler()
		{
			if (IInitializeEventsMetricSenderInvoker.cb_didPrivacyConfigRequestStart == null)
			{
				IInitializeEventsMetricSenderInvoker.cb_didPrivacyConfigRequestStart = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_V(IInitializeEventsMetricSenderInvoker.n_DidPrivacyConfigRequestStart));
			}
			return IInitializeEventsMetricSenderInvoker.cb_didPrivacyConfigRequestStart;
		}

		// Token: 0x06000FF9 RID: 4089 RVA: 0x0002AF28 File Offset: 0x00029128
		private static void n_DidPrivacyConfigRequestStart(IntPtr jnienv, IntPtr native__this)
		{
			Java.Lang.Object.GetObject<IInitializeEventsMetricSender>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).DidPrivacyConfigRequestStart();
		}

		// Token: 0x06000FFA RID: 4090 RVA: 0x0002AF37 File Offset: 0x00029137
		public void DidPrivacyConfigRequestStart()
		{
			if (this.id_didPrivacyConfigRequestStart == IntPtr.Zero)
			{
				this.id_didPrivacyConfigRequestStart = JNIEnv.GetMethodID(this.class_ref, "didPrivacyConfigRequestStart", "()V");
			}
			JNIEnv.CallVoidMethod(base.Handle, this.id_didPrivacyConfigRequestStart);
		}

		// Token: 0x06000FFB RID: 4091 RVA: 0x0002AF77 File Offset: 0x00029177
		private static Delegate GetDurationHandler()
		{
			if (IInitializeEventsMetricSenderInvoker.cb_duration == null)
			{
				IInitializeEventsMetricSenderInvoker.cb_duration = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IInitializeEventsMetricSenderInvoker.n_Duration));
			}
			return IInitializeEventsMetricSenderInvoker.cb_duration;
		}

		// Token: 0x06000FFC RID: 4092 RVA: 0x0002AF9B File Offset: 0x0002919B
		private static IntPtr n_Duration(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<IInitializeEventsMetricSender>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Duration());
		}

		// Token: 0x06000FFD RID: 4093 RVA: 0x0002AFB0 File Offset: 0x000291B0
		public Long Duration()
		{
			if (this.id_duration == IntPtr.Zero)
			{
				this.id_duration = JNIEnv.GetMethodID(this.class_ref, "duration", "()Ljava/lang/Long;");
			}
			return Java.Lang.Object.GetObject<Long>(JNIEnv.CallObjectMethod(base.Handle, this.id_duration), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x06000FFE RID: 4094 RVA: 0x0002B001 File Offset: 0x00029201
		private static Delegate GetInitializationStartTimeStampHandler()
		{
			if (IInitializeEventsMetricSenderInvoker.cb_initializationStartTimeStamp == null)
			{
				IInitializeEventsMetricSenderInvoker.cb_initializationStartTimeStamp = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IInitializeEventsMetricSenderInvoker.n_InitializationStartTimeStamp));
			}
			return IInitializeEventsMetricSenderInvoker.cb_initializationStartTimeStamp;
		}

		// Token: 0x06000FFF RID: 4095 RVA: 0x0002B025 File Offset: 0x00029225
		private static IntPtr n_InitializationStartTimeStamp(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<IInitializeEventsMetricSender>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).InitializationStartTimeStamp());
		}

		// Token: 0x06001000 RID: 4096 RVA: 0x0002B03C File Offset: 0x0002923C
		public Long InitializationStartTimeStamp()
		{
			if (this.id_initializationStartTimeStamp == IntPtr.Zero)
			{
				this.id_initializationStartTimeStamp = JNIEnv.GetMethodID(this.class_ref, "initializationStartTimeStamp", "()Ljava/lang/Long;");
			}
			return Java.Lang.Object.GetObject<Long>(JNIEnv.CallObjectMethod(base.Handle, this.id_initializationStartTimeStamp), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x06001001 RID: 4097 RVA: 0x0002B08D File Offset: 0x0002928D
		private static Delegate GetOnRetryConfigHandler()
		{
			if (IInitializeEventsMetricSenderInvoker.cb_onRetryConfig == null)
			{
				IInitializeEventsMetricSenderInvoker.cb_onRetryConfig = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_V(IInitializeEventsMetricSenderInvoker.n_OnRetryConfig));
			}
			return IInitializeEventsMetricSenderInvoker.cb_onRetryConfig;
		}

		// Token: 0x06001002 RID: 4098 RVA: 0x0002B0B1 File Offset: 0x000292B1
		private static void n_OnRetryConfig(IntPtr jnienv, IntPtr native__this)
		{
			Java.Lang.Object.GetObject<IInitializeEventsMetricSender>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).OnRetryConfig();
		}

		// Token: 0x06001003 RID: 4099 RVA: 0x0002B0C0 File Offset: 0x000292C0
		public void OnRetryConfig()
		{
			if (this.id_onRetryConfig == IntPtr.Zero)
			{
				this.id_onRetryConfig = JNIEnv.GetMethodID(this.class_ref, "onRetryConfig", "()V");
			}
			JNIEnv.CallVoidMethod(base.Handle, this.id_onRetryConfig);
		}

		// Token: 0x06001004 RID: 4100 RVA: 0x0002B100 File Offset: 0x00029300
		private static Delegate GetOnRetryWebviewHandler()
		{
			if (IInitializeEventsMetricSenderInvoker.cb_onRetryWebview == null)
			{
				IInitializeEventsMetricSenderInvoker.cb_onRetryWebview = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_V(IInitializeEventsMetricSenderInvoker.n_OnRetryWebview));
			}
			return IInitializeEventsMetricSenderInvoker.cb_onRetryWebview;
		}

		// Token: 0x06001005 RID: 4101 RVA: 0x0002B124 File Offset: 0x00029324
		private static void n_OnRetryWebview(IntPtr jnienv, IntPtr native__this)
		{
			Java.Lang.Object.GetObject<IInitializeEventsMetricSender>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).OnRetryWebview();
		}

		// Token: 0x06001006 RID: 4102 RVA: 0x0002B133 File Offset: 0x00029333
		public void OnRetryWebview()
		{
			if (this.id_onRetryWebview == IntPtr.Zero)
			{
				this.id_onRetryWebview = JNIEnv.GetMethodID(this.class_ref, "onRetryWebview", "()V");
			}
			JNIEnv.CallVoidMethod(base.Handle, this.id_onRetryWebview);
		}

		// Token: 0x06001007 RID: 4103 RVA: 0x0002B173 File Offset: 0x00029373
		private static Delegate GetPrivacyConfigDurationHandler()
		{
			if (IInitializeEventsMetricSenderInvoker.cb_privacyConfigDuration == null)
			{
				IInitializeEventsMetricSenderInvoker.cb_privacyConfigDuration = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IInitializeEventsMetricSenderInvoker.n_PrivacyConfigDuration));
			}
			return IInitializeEventsMetricSenderInvoker.cb_privacyConfigDuration;
		}

		// Token: 0x06001008 RID: 4104 RVA: 0x0002B197 File Offset: 0x00029397
		private static IntPtr n_PrivacyConfigDuration(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<IInitializeEventsMetricSender>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).PrivacyConfigDuration());
		}

		// Token: 0x06001009 RID: 4105 RVA: 0x0002B1AC File Offset: 0x000293AC
		public Long PrivacyConfigDuration()
		{
			if (this.id_privacyConfigDuration == IntPtr.Zero)
			{
				this.id_privacyConfigDuration = JNIEnv.GetMethodID(this.class_ref, "privacyConfigDuration", "()Ljava/lang/Long;");
			}
			return Java.Lang.Object.GetObject<Long>(JNIEnv.CallObjectMethod(base.Handle, this.id_privacyConfigDuration), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x0600100A RID: 4106 RVA: 0x0002B1FD File Offset: 0x000293FD
		private static Delegate GetSdkDidInitializeHandler()
		{
			if (IInitializeEventsMetricSenderInvoker.cb_sdkDidInitialize == null)
			{
				IInitializeEventsMetricSenderInvoker.cb_sdkDidInitialize = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_V(IInitializeEventsMetricSenderInvoker.n_SdkDidInitialize));
			}
			return IInitializeEventsMetricSenderInvoker.cb_sdkDidInitialize;
		}

		// Token: 0x0600100B RID: 4107 RVA: 0x0002B221 File Offset: 0x00029421
		private static void n_SdkDidInitialize(IntPtr jnienv, IntPtr native__this)
		{
			Java.Lang.Object.GetObject<IInitializeEventsMetricSender>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).SdkDidInitialize();
		}

		// Token: 0x0600100C RID: 4108 RVA: 0x0002B230 File Offset: 0x00029430
		public void SdkDidInitialize()
		{
			if (this.id_sdkDidInitialize == IntPtr.Zero)
			{
				this.id_sdkDidInitialize = JNIEnv.GetMethodID(this.class_ref, "sdkDidInitialize", "()V");
			}
			JNIEnv.CallVoidMethod(base.Handle, this.id_sdkDidInitialize);
		}

		// Token: 0x0600100D RID: 4109 RVA: 0x0002B270 File Offset: 0x00029470
		private static Delegate GetSdkInitializeFailed_Ljava_lang_String_Lcom_unity3d_services_core_configuration_ErrorState_Handler()
		{
			if (IInitializeEventsMetricSenderInvoker.cb_sdkInitializeFailed_Ljava_lang_String_Lcom_unity3d_services_core_configuration_ErrorState_ == null)
			{
				IInitializeEventsMetricSenderInvoker.cb_sdkInitializeFailed_Ljava_lang_String_Lcom_unity3d_services_core_configuration_ErrorState_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_V(IInitializeEventsMetricSenderInvoker.n_SdkInitializeFailed_Ljava_lang_String_Lcom_unity3d_services_core_configuration_ErrorState_));
			}
			return IInitializeEventsMetricSenderInvoker.cb_sdkInitializeFailed_Ljava_lang_String_Lcom_unity3d_services_core_configuration_ErrorState_;
		}

		// Token: 0x0600100E RID: 4110 RVA: 0x0002B294 File Offset: 0x00029494
		private static void n_SdkInitializeFailed_Ljava_lang_String_Lcom_unity3d_services_core_configuration_ErrorState_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			IInitializeEventsMetricSender @object = Java.Lang.Object.GetObject<IInitializeEventsMetricSender>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string @string = JNIEnv.GetString(native_p0, JniHandleOwnership.DoNotTransfer);
			ErrorState object2 = Java.Lang.Object.GetObject<ErrorState>(native_p1, JniHandleOwnership.DoNotTransfer);
			@object.SdkInitializeFailed(@string, object2);
		}

		// Token: 0x0600100F RID: 4111 RVA: 0x0002B2C0 File Offset: 0x000294C0
		public unsafe void SdkInitializeFailed(string p0, ErrorState p1)
		{
			if (this.id_sdkInitializeFailed_Ljava_lang_String_Lcom_unity3d_services_core_configuration_ErrorState_ == IntPtr.Zero)
			{
				this.id_sdkInitializeFailed_Ljava_lang_String_Lcom_unity3d_services_core_configuration_ErrorState_ = JNIEnv.GetMethodID(this.class_ref, "sdkInitializeFailed", "(Ljava/lang/String;Lcom/unity3d/services/core/configuration/ErrorState;)V");
			}
			IntPtr intPtr = JNIEnv.NewString(p0);
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue(intPtr);
			ptr[1] = new JValue((p1 == null) ? IntPtr.Zero : p1.Handle);
			JNIEnv.CallVoidMethod(base.Handle, this.id_sdkInitializeFailed_Ljava_lang_String_Lcom_unity3d_services_core_configuration_ErrorState_, ptr);
			JNIEnv.DeleteLocalRef(intPtr);
		}

		// Token: 0x06001010 RID: 4112 RVA: 0x0002B353 File Offset: 0x00029553
		private static Delegate GetSdkTokenDidBecomeAvailableWithConfig_ZHandler()
		{
			if (IInitializeEventsMetricSenderInvoker.cb_sdkTokenDidBecomeAvailableWithConfig_Z == null)
			{
				IInitializeEventsMetricSenderInvoker.cb_sdkTokenDidBecomeAvailableWithConfig_Z = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPZ_V(IInitializeEventsMetricSenderInvoker.n_SdkTokenDidBecomeAvailableWithConfig_Z));
			}
			return IInitializeEventsMetricSenderInvoker.cb_sdkTokenDidBecomeAvailableWithConfig_Z;
		}

		// Token: 0x06001011 RID: 4113 RVA: 0x0002B377 File Offset: 0x00029577
		private static void n_SdkTokenDidBecomeAvailableWithConfig_Z(IntPtr jnienv, IntPtr native__this, bool p0)
		{
			Java.Lang.Object.GetObject<IInitializeEventsMetricSender>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).SdkTokenDidBecomeAvailableWithConfig(p0);
		}

		// Token: 0x06001012 RID: 4114 RVA: 0x0002B388 File Offset: 0x00029588
		public unsafe void SdkTokenDidBecomeAvailableWithConfig(bool p0)
		{
			if (this.id_sdkTokenDidBecomeAvailableWithConfig_Z == IntPtr.Zero)
			{
				this.id_sdkTokenDidBecomeAvailableWithConfig_Z = JNIEnv.GetMethodID(this.class_ref, "sdkTokenDidBecomeAvailableWithConfig", "(Z)V");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue(p0);
			JNIEnv.CallVoidMethod(base.Handle, this.id_sdkTokenDidBecomeAvailableWithConfig_Z, ptr);
		}

		// Token: 0x06001013 RID: 4115 RVA: 0x0002B3EC File Offset: 0x000295EC
		private static Delegate GetSendMetric_Lcom_unity3d_services_core_request_metrics_Metric_Handler()
		{
			if (IInitializeEventsMetricSenderInvoker.cb_sendMetric_Lcom_unity3d_services_core_request_metrics_Metric_ == null)
			{
				IInitializeEventsMetricSenderInvoker.cb_sendMetric_Lcom_unity3d_services_core_request_metrics_Metric_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(IInitializeEventsMetricSenderInvoker.n_SendMetric_Lcom_unity3d_services_core_request_metrics_Metric_));
			}
			return IInitializeEventsMetricSenderInvoker.cb_sendMetric_Lcom_unity3d_services_core_request_metrics_Metric_;
		}

		// Token: 0x06001014 RID: 4116 RVA: 0x0002B410 File Offset: 0x00029610
		private static void n_SendMetric_Lcom_unity3d_services_core_request_metrics_Metric_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			IInitializeEventsMetricSender @object = Java.Lang.Object.GetObject<IInitializeEventsMetricSender>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Metric object2 = Java.Lang.Object.GetObject<Metric>(native_p0, JniHandleOwnership.DoNotTransfer);
			@object.SendMetric(object2);
		}

		// Token: 0x06001015 RID: 4117 RVA: 0x0002B434 File Offset: 0x00029634
		public unsafe void SendMetric(Metric p0)
		{
			if (this.id_sendMetric_Lcom_unity3d_services_core_request_metrics_Metric_ == IntPtr.Zero)
			{
				this.id_sendMetric_Lcom_unity3d_services_core_request_metrics_Metric_ = JNIEnv.GetMethodID(this.class_ref, "sendMetric", "(Lcom/unity3d/services/core/request/metrics/Metric;)V");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue((p0 == null) ? IntPtr.Zero : p0.Handle);
			JNIEnv.CallVoidMethod(base.Handle, this.id_sendMetric_Lcom_unity3d_services_core_request_metrics_Metric_, ptr);
		}

		// Token: 0x06001016 RID: 4118 RVA: 0x0002B4A7 File Offset: 0x000296A7
		private static Delegate GetSetNewInitFlow_ZHandler()
		{
			if (IInitializeEventsMetricSenderInvoker.cb_setNewInitFlow_Z == null)
			{
				IInitializeEventsMetricSenderInvoker.cb_setNewInitFlow_Z = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPZ_V(IInitializeEventsMetricSenderInvoker.n_SetNewInitFlow_Z));
			}
			return IInitializeEventsMetricSenderInvoker.cb_setNewInitFlow_Z;
		}

		// Token: 0x06001017 RID: 4119 RVA: 0x0002B4CB File Offset: 0x000296CB
		private static void n_SetNewInitFlow_Z(IntPtr jnienv, IntPtr native__this, bool p0)
		{
			Java.Lang.Object.GetObject<IInitializeEventsMetricSender>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).SetNewInitFlow(p0);
		}

		// Token: 0x06001018 RID: 4120 RVA: 0x0002B4DC File Offset: 0x000296DC
		public unsafe void SetNewInitFlow(bool p0)
		{
			if (this.id_setNewInitFlow_Z == IntPtr.Zero)
			{
				this.id_setNewInitFlow_Z = JNIEnv.GetMethodID(this.class_ref, "setNewInitFlow", "(Z)V");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue(p0);
			JNIEnv.CallVoidMethod(base.Handle, this.id_setNewInitFlow_Z, ptr);
		}

		// Token: 0x06001019 RID: 4121 RVA: 0x0002B540 File Offset: 0x00029740
		private static Delegate GetTokenDurationHandler()
		{
			if (IInitializeEventsMetricSenderInvoker.cb_tokenDuration == null)
			{
				IInitializeEventsMetricSenderInvoker.cb_tokenDuration = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IInitializeEventsMetricSenderInvoker.n_TokenDuration));
			}
			return IInitializeEventsMetricSenderInvoker.cb_tokenDuration;
		}

		// Token: 0x0600101A RID: 4122 RVA: 0x0002B564 File Offset: 0x00029764
		private static IntPtr n_TokenDuration(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<IInitializeEventsMetricSender>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).TokenDuration());
		}

		// Token: 0x0600101B RID: 4123 RVA: 0x0002B578 File Offset: 0x00029778
		public Long TokenDuration()
		{
			if (this.id_tokenDuration == IntPtr.Zero)
			{
				this.id_tokenDuration = JNIEnv.GetMethodID(this.class_ref, "tokenDuration", "()Ljava/lang/Long;");
			}
			return Java.Lang.Object.GetObject<Long>(JNIEnv.CallObjectMethod(base.Handle, this.id_tokenDuration), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x040003D4 RID: 980
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/unity3d/services/core/configuration/IInitializeEventsMetricSender", typeof(IInitializeEventsMetricSenderInvoker));

		// Token: 0x040003D5 RID: 981
		private IntPtr class_ref;

		// Token: 0x040003D6 RID: 982
		private static Delegate cb_getRetryTags;

		// Token: 0x040003D7 RID: 983
		private IntPtr id_getRetryTags;

		// Token: 0x040003D8 RID: 984
		private static Delegate cb_configRequestDuration;

		// Token: 0x040003D9 RID: 985
		private IntPtr id_configRequestDuration;

		// Token: 0x040003DA RID: 986
		private static Delegate cb_didConfigRequestEnd_Z;

		// Token: 0x040003DB RID: 987
		private IntPtr id_didConfigRequestEnd_Z;

		// Token: 0x040003DC RID: 988
		private static Delegate cb_didConfigRequestStart;

		// Token: 0x040003DD RID: 989
		private IntPtr id_didConfigRequestStart;

		// Token: 0x040003DE RID: 990
		private static Delegate cb_didInitStart;

		// Token: 0x040003DF RID: 991
		private IntPtr id_didInitStart;

		// Token: 0x040003E0 RID: 992
		private static Delegate cb_didPrivacyConfigRequestEnd_Z;

		// Token: 0x040003E1 RID: 993
		private IntPtr id_didPrivacyConfigRequestEnd_Z;

		// Token: 0x040003E2 RID: 994
		private static Delegate cb_didPrivacyConfigRequestStart;

		// Token: 0x040003E3 RID: 995
		private IntPtr id_didPrivacyConfigRequestStart;

		// Token: 0x040003E4 RID: 996
		private static Delegate cb_duration;

		// Token: 0x040003E5 RID: 997
		private IntPtr id_duration;

		// Token: 0x040003E6 RID: 998
		private static Delegate cb_initializationStartTimeStamp;

		// Token: 0x040003E7 RID: 999
		private IntPtr id_initializationStartTimeStamp;

		// Token: 0x040003E8 RID: 1000
		private static Delegate cb_onRetryConfig;

		// Token: 0x040003E9 RID: 1001
		private IntPtr id_onRetryConfig;

		// Token: 0x040003EA RID: 1002
		private static Delegate cb_onRetryWebview;

		// Token: 0x040003EB RID: 1003
		private IntPtr id_onRetryWebview;

		// Token: 0x040003EC RID: 1004
		private static Delegate cb_privacyConfigDuration;

		// Token: 0x040003ED RID: 1005
		private IntPtr id_privacyConfigDuration;

		// Token: 0x040003EE RID: 1006
		private static Delegate cb_sdkDidInitialize;

		// Token: 0x040003EF RID: 1007
		private IntPtr id_sdkDidInitialize;

		// Token: 0x040003F0 RID: 1008
		private static Delegate cb_sdkInitializeFailed_Ljava_lang_String_Lcom_unity3d_services_core_configuration_ErrorState_;

		// Token: 0x040003F1 RID: 1009
		private IntPtr id_sdkInitializeFailed_Ljava_lang_String_Lcom_unity3d_services_core_configuration_ErrorState_;

		// Token: 0x040003F2 RID: 1010
		private static Delegate cb_sdkTokenDidBecomeAvailableWithConfig_Z;

		// Token: 0x040003F3 RID: 1011
		private IntPtr id_sdkTokenDidBecomeAvailableWithConfig_Z;

		// Token: 0x040003F4 RID: 1012
		private static Delegate cb_sendMetric_Lcom_unity3d_services_core_request_metrics_Metric_;

		// Token: 0x040003F5 RID: 1013
		private IntPtr id_sendMetric_Lcom_unity3d_services_core_request_metrics_Metric_;

		// Token: 0x040003F6 RID: 1014
		private static Delegate cb_setNewInitFlow_Z;

		// Token: 0x040003F7 RID: 1015
		private IntPtr id_setNewInitFlow_Z;

		// Token: 0x040003F8 RID: 1016
		private static Delegate cb_tokenDuration;

		// Token: 0x040003F9 RID: 1017
		private IntPtr id_tokenDuration;
	}
}
