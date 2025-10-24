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
	// Token: 0x02000171 RID: 369
	[Register("com/unity3d/services/core/configuration/InitializeEventsMetricSender", DoNotGenerateAcw = true)]
	public class InitializeEventsMetricSender : Java.Lang.Object, IInitializationListener, IJavaObject, IDisposable, IJavaPeerable, IInitializeEventsMetricSender
	{
		// Token: 0x170005C4 RID: 1476
		// (get) Token: 0x0600104F RID: 4175 RVA: 0x0002BE7C File Offset: 0x0002A07C
		internal static IntPtr class_ref
		{
			get
			{
				return InitializeEventsMetricSender._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170005C5 RID: 1477
		// (get) Token: 0x06001050 RID: 4176 RVA: 0x0002BEA0 File Offset: 0x0002A0A0
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return InitializeEventsMetricSender._members;
			}
		}

		// Token: 0x170005C6 RID: 1478
		// (get) Token: 0x06001051 RID: 4177 RVA: 0x0002BEA8 File Offset: 0x0002A0A8
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return InitializeEventsMetricSender._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170005C7 RID: 1479
		// (get) Token: 0x06001052 RID: 4178 RVA: 0x0002BECC File Offset: 0x0002A0CC
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return InitializeEventsMetricSender._members.ManagedPeerType;
			}
		}

		// Token: 0x06001053 RID: 4179 RVA: 0x000021E8 File Offset: 0x000003E8
		protected InitializeEventsMetricSender(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x170005C8 RID: 1480
		// (get) Token: 0x06001054 RID: 4180 RVA: 0x0002BED8 File Offset: 0x0002A0D8
		public static IInitializeEventsMetricSender Instance
		{
			[Register("getInstance", "()Lcom/unity3d/services/core/configuration/IInitializeEventsMetricSender;", "")]
			get
			{
				return Java.Lang.Object.GetObject<IInitializeEventsMetricSender>(InitializeEventsMetricSender._members.StaticMethods.InvokeObjectMethod("getInstance.()Lcom/unity3d/services/core/configuration/IInitializeEventsMetricSender;", null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x06001055 RID: 4181 RVA: 0x0002BF09 File Offset: 0x0002A109
		private static Delegate GetGetRetryTagsHandler()
		{
			if (InitializeEventsMetricSender.cb_getRetryTags == null)
			{
				InitializeEventsMetricSender.cb_getRetryTags = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(InitializeEventsMetricSender.n_GetRetryTags));
			}
			return InitializeEventsMetricSender.cb_getRetryTags;
		}

		// Token: 0x06001056 RID: 4182 RVA: 0x0002BF2D File Offset: 0x0002A12D
		private static IntPtr n_GetRetryTags(IntPtr jnienv, IntPtr native__this)
		{
			return JavaDictionary<string, string>.ToLocalJniHandle(Java.Lang.Object.GetObject<InitializeEventsMetricSender>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).RetryTags);
		}

		// Token: 0x170005C9 RID: 1481
		// (get) Token: 0x06001057 RID: 4183 RVA: 0x0002BF44 File Offset: 0x0002A144
		public virtual IDictionary<string, string> RetryTags
		{
			[Register("getRetryTags", "()Ljava/util/Map;", "GetGetRetryTagsHandler")]
			get
			{
				return JavaDictionary<string, string>.FromJniHandle(InitializeEventsMetricSender._members.InstanceMethods.InvokeVirtualObjectMethod("getRetryTags.()Ljava/util/Map;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x06001058 RID: 4184 RVA: 0x0002BF76 File Offset: 0x0002A176
		private static Delegate GetConfigRequestDurationHandler()
		{
			if (InitializeEventsMetricSender.cb_configRequestDuration == null)
			{
				InitializeEventsMetricSender.cb_configRequestDuration = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(InitializeEventsMetricSender.n_ConfigRequestDuration));
			}
			return InitializeEventsMetricSender.cb_configRequestDuration;
		}

		// Token: 0x06001059 RID: 4185 RVA: 0x0002BF9A File Offset: 0x0002A19A
		private static IntPtr n_ConfigRequestDuration(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<InitializeEventsMetricSender>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ConfigRequestDuration());
		}

		// Token: 0x0600105A RID: 4186 RVA: 0x0002BFB0 File Offset: 0x0002A1B0
		[Register("configRequestDuration", "()Ljava/lang/Long;", "GetConfigRequestDurationHandler")]
		public virtual Long ConfigRequestDuration()
		{
			return Java.Lang.Object.GetObject<Long>(InitializeEventsMetricSender._members.InstanceMethods.InvokeVirtualObjectMethod("configRequestDuration.()Ljava/lang/Long;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x0600105B RID: 4187 RVA: 0x0002BFE2 File Offset: 0x0002A1E2
		private static Delegate GetDidConfigRequestEnd_ZHandler()
		{
			if (InitializeEventsMetricSender.cb_didConfigRequestEnd_Z == null)
			{
				InitializeEventsMetricSender.cb_didConfigRequestEnd_Z = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPZ_V(InitializeEventsMetricSender.n_DidConfigRequestEnd_Z));
			}
			return InitializeEventsMetricSender.cb_didConfigRequestEnd_Z;
		}

		// Token: 0x0600105C RID: 4188 RVA: 0x0002C006 File Offset: 0x0002A206
		private static void n_DidConfigRequestEnd_Z(IntPtr jnienv, IntPtr native__this, bool success)
		{
			Java.Lang.Object.GetObject<InitializeEventsMetricSender>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).DidConfigRequestEnd(success);
		}

		// Token: 0x0600105D RID: 4189 RVA: 0x0002C018 File Offset: 0x0002A218
		[Register("didConfigRequestEnd", "(Z)V", "GetDidConfigRequestEnd_ZHandler")]
		public unsafe virtual void DidConfigRequestEnd(bool success)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(success);
			InitializeEventsMetricSender._members.InstanceMethods.InvokeVirtualVoidMethod("didConfigRequestEnd.(Z)V", this, ptr);
		}

		// Token: 0x0600105E RID: 4190 RVA: 0x0002C053 File Offset: 0x0002A253
		private static Delegate GetDidConfigRequestStartHandler()
		{
			if (InitializeEventsMetricSender.cb_didConfigRequestStart == null)
			{
				InitializeEventsMetricSender.cb_didConfigRequestStart = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_V(InitializeEventsMetricSender.n_DidConfigRequestStart));
			}
			return InitializeEventsMetricSender.cb_didConfigRequestStart;
		}

		// Token: 0x0600105F RID: 4191 RVA: 0x0002C077 File Offset: 0x0002A277
		private static void n_DidConfigRequestStart(IntPtr jnienv, IntPtr native__this)
		{
			Java.Lang.Object.GetObject<InitializeEventsMetricSender>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).DidConfigRequestStart();
		}

		// Token: 0x06001060 RID: 4192 RVA: 0x0002C086 File Offset: 0x0002A286
		[Register("didConfigRequestStart", "()V", "GetDidConfigRequestStartHandler")]
		public virtual void DidConfigRequestStart()
		{
			InitializeEventsMetricSender._members.InstanceMethods.InvokeVirtualVoidMethod("didConfigRequestStart.()V", this, null);
		}

		// Token: 0x06001061 RID: 4193 RVA: 0x0002C09F File Offset: 0x0002A29F
		private static Delegate GetDidInitStartHandler()
		{
			if (InitializeEventsMetricSender.cb_didInitStart == null)
			{
				InitializeEventsMetricSender.cb_didInitStart = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_V(InitializeEventsMetricSender.n_DidInitStart));
			}
			return InitializeEventsMetricSender.cb_didInitStart;
		}

		// Token: 0x06001062 RID: 4194 RVA: 0x0002C0C3 File Offset: 0x0002A2C3
		private static void n_DidInitStart(IntPtr jnienv, IntPtr native__this)
		{
			Java.Lang.Object.GetObject<InitializeEventsMetricSender>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).DidInitStart();
		}

		// Token: 0x06001063 RID: 4195 RVA: 0x0002C0D2 File Offset: 0x0002A2D2
		[Register("didInitStart", "()V", "GetDidInitStartHandler")]
		public virtual void DidInitStart()
		{
			InitializeEventsMetricSender._members.InstanceMethods.InvokeVirtualVoidMethod("didInitStart.()V", this, null);
		}

		// Token: 0x06001064 RID: 4196 RVA: 0x0002C0EB File Offset: 0x0002A2EB
		private static Delegate GetDidPrivacyConfigRequestEnd_ZHandler()
		{
			if (InitializeEventsMetricSender.cb_didPrivacyConfigRequestEnd_Z == null)
			{
				InitializeEventsMetricSender.cb_didPrivacyConfigRequestEnd_Z = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPZ_V(InitializeEventsMetricSender.n_DidPrivacyConfigRequestEnd_Z));
			}
			return InitializeEventsMetricSender.cb_didPrivacyConfigRequestEnd_Z;
		}

		// Token: 0x06001065 RID: 4197 RVA: 0x0002C10F File Offset: 0x0002A30F
		private static void n_DidPrivacyConfigRequestEnd_Z(IntPtr jnienv, IntPtr native__this, bool success)
		{
			Java.Lang.Object.GetObject<InitializeEventsMetricSender>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).DidPrivacyConfigRequestEnd(success);
		}

		// Token: 0x06001066 RID: 4198 RVA: 0x0002C120 File Offset: 0x0002A320
		[Register("didPrivacyConfigRequestEnd", "(Z)V", "GetDidPrivacyConfigRequestEnd_ZHandler")]
		public unsafe virtual void DidPrivacyConfigRequestEnd(bool success)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(success);
			InitializeEventsMetricSender._members.InstanceMethods.InvokeVirtualVoidMethod("didPrivacyConfigRequestEnd.(Z)V", this, ptr);
		}

		// Token: 0x06001067 RID: 4199 RVA: 0x0002C15B File Offset: 0x0002A35B
		private static Delegate GetDidPrivacyConfigRequestStartHandler()
		{
			if (InitializeEventsMetricSender.cb_didPrivacyConfigRequestStart == null)
			{
				InitializeEventsMetricSender.cb_didPrivacyConfigRequestStart = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_V(InitializeEventsMetricSender.n_DidPrivacyConfigRequestStart));
			}
			return InitializeEventsMetricSender.cb_didPrivacyConfigRequestStart;
		}

		// Token: 0x06001068 RID: 4200 RVA: 0x0002C17F File Offset: 0x0002A37F
		private static void n_DidPrivacyConfigRequestStart(IntPtr jnienv, IntPtr native__this)
		{
			Java.Lang.Object.GetObject<InitializeEventsMetricSender>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).DidPrivacyConfigRequestStart();
		}

		// Token: 0x06001069 RID: 4201 RVA: 0x0002C18E File Offset: 0x0002A38E
		[Register("didPrivacyConfigRequestStart", "()V", "GetDidPrivacyConfigRequestStartHandler")]
		public virtual void DidPrivacyConfigRequestStart()
		{
			InitializeEventsMetricSender._members.InstanceMethods.InvokeVirtualVoidMethod("didPrivacyConfigRequestStart.()V", this, null);
		}

		// Token: 0x0600106A RID: 4202 RVA: 0x0002C1A7 File Offset: 0x0002A3A7
		private static Delegate GetDurationHandler()
		{
			if (InitializeEventsMetricSender.cb_duration == null)
			{
				InitializeEventsMetricSender.cb_duration = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(InitializeEventsMetricSender.n_Duration));
			}
			return InitializeEventsMetricSender.cb_duration;
		}

		// Token: 0x0600106B RID: 4203 RVA: 0x0002C1CB File Offset: 0x0002A3CB
		private static IntPtr n_Duration(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<InitializeEventsMetricSender>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Duration());
		}

		// Token: 0x0600106C RID: 4204 RVA: 0x0002C1E0 File Offset: 0x0002A3E0
		[Register("duration", "()Ljava/lang/Long;", "GetDurationHandler")]
		public virtual Long Duration()
		{
			return Java.Lang.Object.GetObject<Long>(InitializeEventsMetricSender._members.InstanceMethods.InvokeVirtualObjectMethod("duration.()Ljava/lang/Long;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x0600106D RID: 4205 RVA: 0x0002C212 File Offset: 0x0002A412
		private static Delegate GetGetErrorStateTags_Lcom_unity3d_services_core_configuration_ErrorState_Handler()
		{
			if (InitializeEventsMetricSender.cb_getErrorStateTags_Lcom_unity3d_services_core_configuration_ErrorState_ == null)
			{
				InitializeEventsMetricSender.cb_getErrorStateTags_Lcom_unity3d_services_core_configuration_ErrorState_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(InitializeEventsMetricSender.n_GetErrorStateTags_Lcom_unity3d_services_core_configuration_ErrorState_));
			}
			return InitializeEventsMetricSender.cb_getErrorStateTags_Lcom_unity3d_services_core_configuration_ErrorState_;
		}

		// Token: 0x0600106E RID: 4206 RVA: 0x0002C238 File Offset: 0x0002A438
		private static IntPtr n_GetErrorStateTags_Lcom_unity3d_services_core_configuration_ErrorState_(IntPtr jnienv, IntPtr native__this, IntPtr native_errorState)
		{
			InitializeEventsMetricSender @object = Java.Lang.Object.GetObject<InitializeEventsMetricSender>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			ErrorState object2 = Java.Lang.Object.GetObject<ErrorState>(native_errorState, JniHandleOwnership.DoNotTransfer);
			return JavaDictionary<string, string>.ToLocalJniHandle(@object.GetErrorStateTags(object2));
		}

		// Token: 0x0600106F RID: 4207 RVA: 0x0002C260 File Offset: 0x0002A460
		[Register("getErrorStateTags", "(Lcom/unity3d/services/core/configuration/ErrorState;)Ljava/util/Map;", "GetGetErrorStateTags_Lcom_unity3d_services_core_configuration_ErrorState_Handler")]
		public unsafe virtual IDictionary<string, string> GetErrorStateTags(ErrorState errorState)
		{
			IDictionary<string, string> result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((errorState == null) ? IntPtr.Zero : errorState.Handle);
				result = JavaDictionary<string, string>.FromJniHandle(InitializeEventsMetricSender._members.InstanceMethods.InvokeVirtualObjectMethod("getErrorStateTags.(Lcom/unity3d/services/core/configuration/ErrorState;)Ljava/util/Map;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(errorState);
			}
			return result;
		}

		// Token: 0x06001070 RID: 4208 RVA: 0x0002C2D4 File Offset: 0x0002A4D4
		private static Delegate GetInitializationStartTimeStampHandler()
		{
			if (InitializeEventsMetricSender.cb_initializationStartTimeStamp == null)
			{
				InitializeEventsMetricSender.cb_initializationStartTimeStamp = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(InitializeEventsMetricSender.n_InitializationStartTimeStamp));
			}
			return InitializeEventsMetricSender.cb_initializationStartTimeStamp;
		}

		// Token: 0x06001071 RID: 4209 RVA: 0x0002C2F8 File Offset: 0x0002A4F8
		private static IntPtr n_InitializationStartTimeStamp(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<InitializeEventsMetricSender>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).InitializationStartTimeStamp());
		}

		// Token: 0x06001072 RID: 4210 RVA: 0x0002C30C File Offset: 0x0002A50C
		[Register("initializationStartTimeStamp", "()Ljava/lang/Long;", "GetInitializationStartTimeStampHandler")]
		public virtual Long InitializationStartTimeStamp()
		{
			return Java.Lang.Object.GetObject<Long>(InitializeEventsMetricSender._members.InstanceMethods.InvokeVirtualObjectMethod("initializationStartTimeStamp.()Ljava/lang/Long;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x06001073 RID: 4211 RVA: 0x0002C33E File Offset: 0x0002A53E
		private static Delegate GetOnRetryConfigHandler()
		{
			if (InitializeEventsMetricSender.cb_onRetryConfig == null)
			{
				InitializeEventsMetricSender.cb_onRetryConfig = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_V(InitializeEventsMetricSender.n_OnRetryConfig));
			}
			return InitializeEventsMetricSender.cb_onRetryConfig;
		}

		// Token: 0x06001074 RID: 4212 RVA: 0x0002C362 File Offset: 0x0002A562
		private static void n_OnRetryConfig(IntPtr jnienv, IntPtr native__this)
		{
			Java.Lang.Object.GetObject<InitializeEventsMetricSender>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).OnRetryConfig();
		}

		// Token: 0x06001075 RID: 4213 RVA: 0x0002C371 File Offset: 0x0002A571
		[Register("onRetryConfig", "()V", "GetOnRetryConfigHandler")]
		public virtual void OnRetryConfig()
		{
			InitializeEventsMetricSender._members.InstanceMethods.InvokeVirtualVoidMethod("onRetryConfig.()V", this, null);
		}

		// Token: 0x06001076 RID: 4214 RVA: 0x0002C38A File Offset: 0x0002A58A
		private static Delegate GetOnRetryWebviewHandler()
		{
			if (InitializeEventsMetricSender.cb_onRetryWebview == null)
			{
				InitializeEventsMetricSender.cb_onRetryWebview = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_V(InitializeEventsMetricSender.n_OnRetryWebview));
			}
			return InitializeEventsMetricSender.cb_onRetryWebview;
		}

		// Token: 0x06001077 RID: 4215 RVA: 0x0002C3AE File Offset: 0x0002A5AE
		private static void n_OnRetryWebview(IntPtr jnienv, IntPtr native__this)
		{
			Java.Lang.Object.GetObject<InitializeEventsMetricSender>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).OnRetryWebview();
		}

		// Token: 0x06001078 RID: 4216 RVA: 0x0002C3BD File Offset: 0x0002A5BD
		[Register("onRetryWebview", "()V", "GetOnRetryWebviewHandler")]
		public virtual void OnRetryWebview()
		{
			InitializeEventsMetricSender._members.InstanceMethods.InvokeVirtualVoidMethod("onRetryWebview.()V", this, null);
		}

		// Token: 0x06001079 RID: 4217 RVA: 0x0002C3D6 File Offset: 0x0002A5D6
		private static Delegate GetOnSdkInitializationFailed_Ljava_lang_String_Lcom_unity3d_services_core_configuration_ErrorState_IHandler()
		{
			if (InitializeEventsMetricSender.cb_onSdkInitializationFailed_Ljava_lang_String_Lcom_unity3d_services_core_configuration_ErrorState_I == null)
			{
				InitializeEventsMetricSender.cb_onSdkInitializationFailed_Ljava_lang_String_Lcom_unity3d_services_core_configuration_ErrorState_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLLI_V(InitializeEventsMetricSender.n_OnSdkInitializationFailed_Ljava_lang_String_Lcom_unity3d_services_core_configuration_ErrorState_I));
			}
			return InitializeEventsMetricSender.cb_onSdkInitializationFailed_Ljava_lang_String_Lcom_unity3d_services_core_configuration_ErrorState_I;
		}

		// Token: 0x0600107A RID: 4218 RVA: 0x0002C3FC File Offset: 0x0002A5FC
		private static void n_OnSdkInitializationFailed_Ljava_lang_String_Lcom_unity3d_services_core_configuration_ErrorState_I(IntPtr jnienv, IntPtr native__this, IntPtr native_message, IntPtr native_errorState, int code)
		{
			InitializeEventsMetricSender @object = Java.Lang.Object.GetObject<InitializeEventsMetricSender>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string @string = JNIEnv.GetString(native_message, JniHandleOwnership.DoNotTransfer);
			ErrorState object2 = Java.Lang.Object.GetObject<ErrorState>(native_errorState, JniHandleOwnership.DoNotTransfer);
			@object.OnSdkInitializationFailed(@string, object2, code);
		}

		// Token: 0x0600107B RID: 4219 RVA: 0x0002C42C File Offset: 0x0002A62C
		[Register("onSdkInitializationFailed", "(Ljava/lang/String;Lcom/unity3d/services/core/configuration/ErrorState;I)V", "GetOnSdkInitializationFailed_Ljava_lang_String_Lcom_unity3d_services_core_configuration_ErrorState_IHandler")]
		public unsafe virtual void OnSdkInitializationFailed(string message, ErrorState errorState, int code)
		{
			IntPtr intPtr = JNIEnv.NewString(message);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue((errorState == null) ? IntPtr.Zero : errorState.Handle);
				ptr[2] = new JniArgumentValue(code);
				InitializeEventsMetricSender._members.InstanceMethods.InvokeVirtualVoidMethod("onSdkInitializationFailed.(Ljava/lang/String;Lcom/unity3d/services/core/configuration/ErrorState;I)V", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(errorState);
			}
		}

		// Token: 0x0600107C RID: 4220 RVA: 0x0002C4C8 File Offset: 0x0002A6C8
		private static Delegate GetOnSdkInitializedHandler()
		{
			if (InitializeEventsMetricSender.cb_onSdkInitialized == null)
			{
				InitializeEventsMetricSender.cb_onSdkInitialized = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_V(InitializeEventsMetricSender.n_OnSdkInitialized));
			}
			return InitializeEventsMetricSender.cb_onSdkInitialized;
		}

		// Token: 0x0600107D RID: 4221 RVA: 0x0002C4EC File Offset: 0x0002A6EC
		private static void n_OnSdkInitialized(IntPtr jnienv, IntPtr native__this)
		{
			Java.Lang.Object.GetObject<InitializeEventsMetricSender>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).OnSdkInitialized();
		}

		// Token: 0x0600107E RID: 4222 RVA: 0x0002C4FB File Offset: 0x0002A6FB
		[Register("onSdkInitialized", "()V", "GetOnSdkInitializedHandler")]
		public virtual void OnSdkInitialized()
		{
			InitializeEventsMetricSender._members.InstanceMethods.InvokeVirtualVoidMethod("onSdkInitialized.()V", this, null);
		}

		// Token: 0x0600107F RID: 4223 RVA: 0x0002C514 File Offset: 0x0002A714
		private static Delegate GetPrivacyConfigDurationHandler()
		{
			if (InitializeEventsMetricSender.cb_privacyConfigDuration == null)
			{
				InitializeEventsMetricSender.cb_privacyConfigDuration = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(InitializeEventsMetricSender.n_PrivacyConfigDuration));
			}
			return InitializeEventsMetricSender.cb_privacyConfigDuration;
		}

		// Token: 0x06001080 RID: 4224 RVA: 0x0002C538 File Offset: 0x0002A738
		private static IntPtr n_PrivacyConfigDuration(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<InitializeEventsMetricSender>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).PrivacyConfigDuration());
		}

		// Token: 0x06001081 RID: 4225 RVA: 0x0002C54C File Offset: 0x0002A74C
		[Register("privacyConfigDuration", "()Ljava/lang/Long;", "GetPrivacyConfigDurationHandler")]
		public virtual Long PrivacyConfigDuration()
		{
			return Java.Lang.Object.GetObject<Long>(InitializeEventsMetricSender._members.InstanceMethods.InvokeVirtualObjectMethod("privacyConfigDuration.()Ljava/lang/Long;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x06001082 RID: 4226 RVA: 0x0002C57E File Offset: 0x0002A77E
		private static Delegate GetSdkDidInitializeHandler()
		{
			if (InitializeEventsMetricSender.cb_sdkDidInitialize == null)
			{
				InitializeEventsMetricSender.cb_sdkDidInitialize = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_V(InitializeEventsMetricSender.n_SdkDidInitialize));
			}
			return InitializeEventsMetricSender.cb_sdkDidInitialize;
		}

		// Token: 0x06001083 RID: 4227 RVA: 0x0002C5A2 File Offset: 0x0002A7A2
		private static void n_SdkDidInitialize(IntPtr jnienv, IntPtr native__this)
		{
			Java.Lang.Object.GetObject<InitializeEventsMetricSender>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).SdkDidInitialize();
		}

		// Token: 0x06001084 RID: 4228 RVA: 0x0002C5B1 File Offset: 0x0002A7B1
		[Register("sdkDidInitialize", "()V", "GetSdkDidInitializeHandler")]
		public virtual void SdkDidInitialize()
		{
			InitializeEventsMetricSender._members.InstanceMethods.InvokeVirtualVoidMethod("sdkDidInitialize.()V", this, null);
		}

		// Token: 0x06001085 RID: 4229 RVA: 0x0002C5CA File Offset: 0x0002A7CA
		private static Delegate GetSdkInitializeFailed_Ljava_lang_String_Lcom_unity3d_services_core_configuration_ErrorState_Handler()
		{
			if (InitializeEventsMetricSender.cb_sdkInitializeFailed_Ljava_lang_String_Lcom_unity3d_services_core_configuration_ErrorState_ == null)
			{
				InitializeEventsMetricSender.cb_sdkInitializeFailed_Ljava_lang_String_Lcom_unity3d_services_core_configuration_ErrorState_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_V(InitializeEventsMetricSender.n_SdkInitializeFailed_Ljava_lang_String_Lcom_unity3d_services_core_configuration_ErrorState_));
			}
			return InitializeEventsMetricSender.cb_sdkInitializeFailed_Ljava_lang_String_Lcom_unity3d_services_core_configuration_ErrorState_;
		}

		// Token: 0x06001086 RID: 4230 RVA: 0x0002C5F0 File Offset: 0x0002A7F0
		private static void n_SdkInitializeFailed_Ljava_lang_String_Lcom_unity3d_services_core_configuration_ErrorState_(IntPtr jnienv, IntPtr native__this, IntPtr native_message, IntPtr native_errorState)
		{
			InitializeEventsMetricSender @object = Java.Lang.Object.GetObject<InitializeEventsMetricSender>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string @string = JNIEnv.GetString(native_message, JniHandleOwnership.DoNotTransfer);
			ErrorState object2 = Java.Lang.Object.GetObject<ErrorState>(native_errorState, JniHandleOwnership.DoNotTransfer);
			@object.SdkInitializeFailed(@string, object2);
		}

		// Token: 0x06001087 RID: 4231 RVA: 0x0002C61C File Offset: 0x0002A81C
		[Register("sdkInitializeFailed", "(Ljava/lang/String;Lcom/unity3d/services/core/configuration/ErrorState;)V", "GetSdkInitializeFailed_Ljava_lang_String_Lcom_unity3d_services_core_configuration_ErrorState_Handler")]
		public unsafe virtual void SdkInitializeFailed(string message, ErrorState errorState)
		{
			IntPtr intPtr = JNIEnv.NewString(message);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue((errorState == null) ? IntPtr.Zero : errorState.Handle);
				InitializeEventsMetricSender._members.InstanceMethods.InvokeVirtualVoidMethod("sdkInitializeFailed.(Ljava/lang/String;Lcom/unity3d/services/core/configuration/ErrorState;)V", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(errorState);
			}
		}

		// Token: 0x06001088 RID: 4232 RVA: 0x0002C6A0 File Offset: 0x0002A8A0
		private static Delegate GetSdkTokenDidBecomeAvailableWithConfig_ZHandler()
		{
			if (InitializeEventsMetricSender.cb_sdkTokenDidBecomeAvailableWithConfig_Z == null)
			{
				InitializeEventsMetricSender.cb_sdkTokenDidBecomeAvailableWithConfig_Z = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPZ_V(InitializeEventsMetricSender.n_SdkTokenDidBecomeAvailableWithConfig_Z));
			}
			return InitializeEventsMetricSender.cb_sdkTokenDidBecomeAvailableWithConfig_Z;
		}

		// Token: 0x06001089 RID: 4233 RVA: 0x0002C6C4 File Offset: 0x0002A8C4
		private static void n_SdkTokenDidBecomeAvailableWithConfig_Z(IntPtr jnienv, IntPtr native__this, bool withConfig)
		{
			Java.Lang.Object.GetObject<InitializeEventsMetricSender>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).SdkTokenDidBecomeAvailableWithConfig(withConfig);
		}

		// Token: 0x0600108A RID: 4234 RVA: 0x0002C6D4 File Offset: 0x0002A8D4
		[Register("sdkTokenDidBecomeAvailableWithConfig", "(Z)V", "GetSdkTokenDidBecomeAvailableWithConfig_ZHandler")]
		public unsafe virtual void SdkTokenDidBecomeAvailableWithConfig(bool withConfig)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(withConfig);
			InitializeEventsMetricSender._members.InstanceMethods.InvokeVirtualVoidMethod("sdkTokenDidBecomeAvailableWithConfig.(Z)V", this, ptr);
		}

		// Token: 0x0600108B RID: 4235 RVA: 0x0002C70F File Offset: 0x0002A90F
		private static Delegate GetSendMetric_Lcom_unity3d_services_core_request_metrics_Metric_Handler()
		{
			if (InitializeEventsMetricSender.cb_sendMetric_Lcom_unity3d_services_core_request_metrics_Metric_ == null)
			{
				InitializeEventsMetricSender.cb_sendMetric_Lcom_unity3d_services_core_request_metrics_Metric_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(InitializeEventsMetricSender.n_SendMetric_Lcom_unity3d_services_core_request_metrics_Metric_));
			}
			return InitializeEventsMetricSender.cb_sendMetric_Lcom_unity3d_services_core_request_metrics_Metric_;
		}

		// Token: 0x0600108C RID: 4236 RVA: 0x0002C734 File Offset: 0x0002A934
		private static void n_SendMetric_Lcom_unity3d_services_core_request_metrics_Metric_(IntPtr jnienv, IntPtr native__this, IntPtr native_metric)
		{
			InitializeEventsMetricSender @object = Java.Lang.Object.GetObject<InitializeEventsMetricSender>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Metric object2 = Java.Lang.Object.GetObject<Metric>(native_metric, JniHandleOwnership.DoNotTransfer);
			@object.SendMetric(object2);
		}

		// Token: 0x0600108D RID: 4237 RVA: 0x0002C758 File Offset: 0x0002A958
		[Register("sendMetric", "(Lcom/unity3d/services/core/request/metrics/Metric;)V", "GetSendMetric_Lcom_unity3d_services_core_request_metrics_Metric_Handler")]
		public unsafe virtual void SendMetric(Metric metric)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((metric == null) ? IntPtr.Zero : metric.Handle);
				InitializeEventsMetricSender._members.InstanceMethods.InvokeVirtualVoidMethod("sendMetric.(Lcom/unity3d/services/core/request/metrics/Metric;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(metric);
			}
		}

		// Token: 0x0600108E RID: 4238 RVA: 0x0002C7BC File Offset: 0x0002A9BC
		private static Delegate GetSetNewInitFlow_ZHandler()
		{
			if (InitializeEventsMetricSender.cb_setNewInitFlow_Z == null)
			{
				InitializeEventsMetricSender.cb_setNewInitFlow_Z = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPZ_V(InitializeEventsMetricSender.n_SetNewInitFlow_Z));
			}
			return InitializeEventsMetricSender.cb_setNewInitFlow_Z;
		}

		// Token: 0x0600108F RID: 4239 RVA: 0x0002C7E0 File Offset: 0x0002A9E0
		private static void n_SetNewInitFlow_Z(IntPtr jnienv, IntPtr native__this, bool isNewInitFlow)
		{
			Java.Lang.Object.GetObject<InitializeEventsMetricSender>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).SetNewInitFlow(isNewInitFlow);
		}

		// Token: 0x06001090 RID: 4240 RVA: 0x0002C7F0 File Offset: 0x0002A9F0
		[Register("setNewInitFlow", "(Z)V", "GetSetNewInitFlow_ZHandler")]
		public unsafe virtual void SetNewInitFlow(bool isNewInitFlow)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(isNewInitFlow);
			InitializeEventsMetricSender._members.InstanceMethods.InvokeVirtualVoidMethod("setNewInitFlow.(Z)V", this, ptr);
		}

		// Token: 0x06001091 RID: 4241 RVA: 0x0002C82B File Offset: 0x0002AA2B
		private static Delegate GetTokenDurationHandler()
		{
			if (InitializeEventsMetricSender.cb_tokenDuration == null)
			{
				InitializeEventsMetricSender.cb_tokenDuration = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(InitializeEventsMetricSender.n_TokenDuration));
			}
			return InitializeEventsMetricSender.cb_tokenDuration;
		}

		// Token: 0x06001092 RID: 4242 RVA: 0x0002C84F File Offset: 0x0002AA4F
		private static IntPtr n_TokenDuration(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<InitializeEventsMetricSender>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).TokenDuration());
		}

		// Token: 0x06001093 RID: 4243 RVA: 0x0002C864 File Offset: 0x0002AA64
		[Register("tokenDuration", "()Ljava/lang/Long;", "GetTokenDurationHandler")]
		public virtual Long TokenDuration()
		{
			return Java.Lang.Object.GetObject<Long>(InitializeEventsMetricSender._members.InstanceMethods.InvokeVirtualObjectMethod("tokenDuration.()Ljava/lang/Long;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x0400040B RID: 1035
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/unity3d/services/core/configuration/InitializeEventsMetricSender", typeof(InitializeEventsMetricSender));

		// Token: 0x0400040C RID: 1036
		private static Delegate cb_getRetryTags;

		// Token: 0x0400040D RID: 1037
		private static Delegate cb_configRequestDuration;

		// Token: 0x0400040E RID: 1038
		private static Delegate cb_didConfigRequestEnd_Z;

		// Token: 0x0400040F RID: 1039
		private static Delegate cb_didConfigRequestStart;

		// Token: 0x04000410 RID: 1040
		private static Delegate cb_didInitStart;

		// Token: 0x04000411 RID: 1041
		private static Delegate cb_didPrivacyConfigRequestEnd_Z;

		// Token: 0x04000412 RID: 1042
		private static Delegate cb_didPrivacyConfigRequestStart;

		// Token: 0x04000413 RID: 1043
		private static Delegate cb_duration;

		// Token: 0x04000414 RID: 1044
		private static Delegate cb_getErrorStateTags_Lcom_unity3d_services_core_configuration_ErrorState_;

		// Token: 0x04000415 RID: 1045
		private static Delegate cb_initializationStartTimeStamp;

		// Token: 0x04000416 RID: 1046
		private static Delegate cb_onRetryConfig;

		// Token: 0x04000417 RID: 1047
		private static Delegate cb_onRetryWebview;

		// Token: 0x04000418 RID: 1048
		private static Delegate cb_onSdkInitializationFailed_Ljava_lang_String_Lcom_unity3d_services_core_configuration_ErrorState_I;

		// Token: 0x04000419 RID: 1049
		private static Delegate cb_onSdkInitialized;

		// Token: 0x0400041A RID: 1050
		private static Delegate cb_privacyConfigDuration;

		// Token: 0x0400041B RID: 1051
		private static Delegate cb_sdkDidInitialize;

		// Token: 0x0400041C RID: 1052
		private static Delegate cb_sdkInitializeFailed_Ljava_lang_String_Lcom_unity3d_services_core_configuration_ErrorState_;

		// Token: 0x0400041D RID: 1053
		private static Delegate cb_sdkTokenDidBecomeAvailableWithConfig_Z;

		// Token: 0x0400041E RID: 1054
		private static Delegate cb_sendMetric_Lcom_unity3d_services_core_request_metrics_Metric_;

		// Token: 0x0400041F RID: 1055
		private static Delegate cb_setNewInitFlow_Z;

		// Token: 0x04000420 RID: 1056
		private static Delegate cb_tokenDuration;
	}
}
