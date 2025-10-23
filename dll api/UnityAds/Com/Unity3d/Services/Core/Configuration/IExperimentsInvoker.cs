using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;
using Org.Json;

namespace Com.Unity3d.Services.Core.Configuration
{
	// Token: 0x02000165 RID: 357
	[Register("com/unity3d/services/core/configuration/IExperiments", DoNotGenerateAcw = true)]
	internal class IExperimentsInvoker : Java.Lang.Object, IExperiments, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x17000597 RID: 1431
		// (get) Token: 0x06000F61 RID: 3937 RVA: 0x00029B44 File Offset: 0x00027D44
		private static IntPtr java_class_ref
		{
			get
			{
				return IExperimentsInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000598 RID: 1432
		// (get) Token: 0x06000F62 RID: 3938 RVA: 0x00029B68 File Offset: 0x00027D68
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return IExperimentsInvoker._members;
			}
		}

		// Token: 0x17000599 RID: 1433
		// (get) Token: 0x06000F63 RID: 3939 RVA: 0x00029B6F File Offset: 0x00027D6F
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x1700059A RID: 1434
		// (get) Token: 0x06000F64 RID: 3940 RVA: 0x00029B77 File Offset: 0x00027D77
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return IExperimentsInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x06000F65 RID: 3941 RVA: 0x00029B83 File Offset: 0x00027D83
		public static IExperiments GetObject(IntPtr handle, JniHandleOwnership transfer)
		{
			return Java.Lang.Object.GetObject<IExperiments>(handle, transfer);
		}

		// Token: 0x06000F66 RID: 3942 RVA: 0x00029B8C File Offset: 0x00027D8C
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, IExperimentsInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'com.unity3d.services.core.configuration.IExperiments'.");
			}
			return handle;
		}

		// Token: 0x06000F67 RID: 3943 RVA: 0x00029BB7 File Offset: 0x00027DB7
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x06000F68 RID: 3944 RVA: 0x00029BE8 File Offset: 0x00027DE8
		public IExperimentsInvoker(IntPtr handle, JniHandleOwnership transfer) : base(IExperimentsInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x06000F69 RID: 3945 RVA: 0x00029C20 File Offset: 0x00027E20
		private static Delegate GetGetCurrentSessionExperimentsHandler()
		{
			if (IExperimentsInvoker.cb_getCurrentSessionExperiments == null)
			{
				IExperimentsInvoker.cb_getCurrentSessionExperiments = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IExperimentsInvoker.n_GetCurrentSessionExperiments));
			}
			return IExperimentsInvoker.cb_getCurrentSessionExperiments;
		}

		// Token: 0x06000F6A RID: 3946 RVA: 0x00029C44 File Offset: 0x00027E44
		private static IntPtr n_GetCurrentSessionExperiments(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<IExperiments>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).CurrentSessionExperiments);
		}

		// Token: 0x1700059B RID: 1435
		// (get) Token: 0x06000F6B RID: 3947 RVA: 0x00029C58 File Offset: 0x00027E58
		public JSONObject CurrentSessionExperiments
		{
			get
			{
				if (this.id_getCurrentSessionExperiments == IntPtr.Zero)
				{
					this.id_getCurrentSessionExperiments = JNIEnv.GetMethodID(this.class_ref, "getCurrentSessionExperiments", "()Lorg/json/JSONObject;");
				}
				return Java.Lang.Object.GetObject<JSONObject>(JNIEnv.CallObjectMethod(base.Handle, this.id_getCurrentSessionExperiments), JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x06000F6C RID: 3948 RVA: 0x00029CA9 File Offset: 0x00027EA9
		private static Delegate GetGetExperimentTagsHandler()
		{
			if (IExperimentsInvoker.cb_getExperimentTags == null)
			{
				IExperimentsInvoker.cb_getExperimentTags = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IExperimentsInvoker.n_GetExperimentTags));
			}
			return IExperimentsInvoker.cb_getExperimentTags;
		}

		// Token: 0x06000F6D RID: 3949 RVA: 0x00029CCD File Offset: 0x00027ECD
		private static IntPtr n_GetExperimentTags(IntPtr jnienv, IntPtr native__this)
		{
			return JavaDictionary<string, string>.ToLocalJniHandle(Java.Lang.Object.GetObject<IExperiments>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ExperimentTags);
		}

		// Token: 0x1700059C RID: 1436
		// (get) Token: 0x06000F6E RID: 3950 RVA: 0x00029CE4 File Offset: 0x00027EE4
		public IDictionary<string, string> ExperimentTags
		{
			get
			{
				if (this.id_getExperimentTags == IntPtr.Zero)
				{
					this.id_getExperimentTags = JNIEnv.GetMethodID(this.class_ref, "getExperimentTags", "()Ljava/util/Map;");
				}
				return JavaDictionary<string, string>.FromJniHandle(JNIEnv.CallObjectMethod(base.Handle, this.id_getExperimentTags), JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x06000F6F RID: 3951 RVA: 0x00029D35 File Offset: 0x00027F35
		private static Delegate GetGetExperimentsAsJsonHandler()
		{
			if (IExperimentsInvoker.cb_getExperimentsAsJson == null)
			{
				IExperimentsInvoker.cb_getExperimentsAsJson = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IExperimentsInvoker.n_GetExperimentsAsJson));
			}
			return IExperimentsInvoker.cb_getExperimentsAsJson;
		}

		// Token: 0x06000F70 RID: 3952 RVA: 0x00029D59 File Offset: 0x00027F59
		private static IntPtr n_GetExperimentsAsJson(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<IExperiments>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ExperimentsAsJson);
		}

		// Token: 0x1700059D RID: 1437
		// (get) Token: 0x06000F71 RID: 3953 RVA: 0x00029D70 File Offset: 0x00027F70
		public JSONObject ExperimentsAsJson
		{
			get
			{
				if (this.id_getExperimentsAsJson == IntPtr.Zero)
				{
					this.id_getExperimentsAsJson = JNIEnv.GetMethodID(this.class_ref, "getExperimentsAsJson", "()Lorg/json/JSONObject;");
				}
				return Java.Lang.Object.GetObject<JSONObject>(JNIEnv.CallObjectMethod(base.Handle, this.id_getExperimentsAsJson), JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x06000F72 RID: 3954 RVA: 0x00029DC1 File Offset: 0x00027FC1
		private static Delegate GetIsForwardExperimentsToWebViewEnabledHandler()
		{
			if (IExperimentsInvoker.cb_isForwardExperimentsToWebViewEnabled == null)
			{
				IExperimentsInvoker.cb_isForwardExperimentsToWebViewEnabled = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(IExperimentsInvoker.n_IsForwardExperimentsToWebViewEnabled));
			}
			return IExperimentsInvoker.cb_isForwardExperimentsToWebViewEnabled;
		}

		// Token: 0x06000F73 RID: 3955 RVA: 0x00029DE5 File Offset: 0x00027FE5
		private static bool n_IsForwardExperimentsToWebViewEnabled(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<IExperiments>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).IsForwardExperimentsToWebViewEnabled;
		}

		// Token: 0x1700059E RID: 1438
		// (get) Token: 0x06000F74 RID: 3956 RVA: 0x00029DF4 File Offset: 0x00027FF4
		public bool IsForwardExperimentsToWebViewEnabled
		{
			get
			{
				if (this.id_isForwardExperimentsToWebViewEnabled == IntPtr.Zero)
				{
					this.id_isForwardExperimentsToWebViewEnabled = JNIEnv.GetMethodID(this.class_ref, "isForwardExperimentsToWebViewEnabled", "()Z");
				}
				return JNIEnv.CallBooleanMethod(base.Handle, this.id_isForwardExperimentsToWebViewEnabled);
			}
		}

		// Token: 0x06000F75 RID: 3957 RVA: 0x00029E34 File Offset: 0x00028034
		private static Delegate GetIsNativeTokenEnabledHandler()
		{
			if (IExperimentsInvoker.cb_isNativeTokenEnabled == null)
			{
				IExperimentsInvoker.cb_isNativeTokenEnabled = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(IExperimentsInvoker.n_IsNativeTokenEnabled));
			}
			return IExperimentsInvoker.cb_isNativeTokenEnabled;
		}

		// Token: 0x06000F76 RID: 3958 RVA: 0x00029E58 File Offset: 0x00028058
		private static bool n_IsNativeTokenEnabled(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<IExperiments>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).IsNativeTokenEnabled;
		}

		// Token: 0x1700059F RID: 1439
		// (get) Token: 0x06000F77 RID: 3959 RVA: 0x00029E67 File Offset: 0x00028067
		public bool IsNativeTokenEnabled
		{
			get
			{
				if (this.id_isNativeTokenEnabled == IntPtr.Zero)
				{
					this.id_isNativeTokenEnabled = JNIEnv.GetMethodID(this.class_ref, "isNativeTokenEnabled", "()Z");
				}
				return JNIEnv.CallBooleanMethod(base.Handle, this.id_isNativeTokenEnabled);
			}
		}

		// Token: 0x06000F78 RID: 3960 RVA: 0x00029EA7 File Offset: 0x000280A7
		private static Delegate GetIsNativeWebViewCacheEnabledHandler()
		{
			if (IExperimentsInvoker.cb_isNativeWebViewCacheEnabled == null)
			{
				IExperimentsInvoker.cb_isNativeWebViewCacheEnabled = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(IExperimentsInvoker.n_IsNativeWebViewCacheEnabled));
			}
			return IExperimentsInvoker.cb_isNativeWebViewCacheEnabled;
		}

		// Token: 0x06000F79 RID: 3961 RVA: 0x00029ECB File Offset: 0x000280CB
		private static bool n_IsNativeWebViewCacheEnabled(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<IExperiments>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).IsNativeWebViewCacheEnabled;
		}

		// Token: 0x170005A0 RID: 1440
		// (get) Token: 0x06000F7A RID: 3962 RVA: 0x00029EDA File Offset: 0x000280DA
		public bool IsNativeWebViewCacheEnabled
		{
			get
			{
				if (this.id_isNativeWebViewCacheEnabled == IntPtr.Zero)
				{
					this.id_isNativeWebViewCacheEnabled = JNIEnv.GetMethodID(this.class_ref, "isNativeWebViewCacheEnabled", "()Z");
				}
				return JNIEnv.CallBooleanMethod(base.Handle, this.id_isNativeWebViewCacheEnabled);
			}
		}

		// Token: 0x06000F7B RID: 3963 RVA: 0x00029F1A File Offset: 0x0002811A
		private static Delegate GetIsNewInitFlowEnabledHandler()
		{
			if (IExperimentsInvoker.cb_isNewInitFlowEnabled == null)
			{
				IExperimentsInvoker.cb_isNewInitFlowEnabled = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(IExperimentsInvoker.n_IsNewInitFlowEnabled));
			}
			return IExperimentsInvoker.cb_isNewInitFlowEnabled;
		}

		// Token: 0x06000F7C RID: 3964 RVA: 0x00029F3E File Offset: 0x0002813E
		private static bool n_IsNewInitFlowEnabled(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<IExperiments>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).IsNewInitFlowEnabled;
		}

		// Token: 0x170005A1 RID: 1441
		// (get) Token: 0x06000F7D RID: 3965 RVA: 0x00029F4D File Offset: 0x0002814D
		public bool IsNewInitFlowEnabled
		{
			get
			{
				if (this.id_isNewInitFlowEnabled == IntPtr.Zero)
				{
					this.id_isNewInitFlowEnabled = JNIEnv.GetMethodID(this.class_ref, "isNewInitFlowEnabled", "()Z");
				}
				return JNIEnv.CallBooleanMethod(base.Handle, this.id_isNewInitFlowEnabled);
			}
		}

		// Token: 0x06000F7E RID: 3966 RVA: 0x00029F8D File Offset: 0x0002818D
		private static Delegate GetIsNewLifecycleTimerHandler()
		{
			if (IExperimentsInvoker.cb_isNewLifecycleTimer == null)
			{
				IExperimentsInvoker.cb_isNewLifecycleTimer = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(IExperimentsInvoker.n_IsNewLifecycleTimer));
			}
			return IExperimentsInvoker.cb_isNewLifecycleTimer;
		}

		// Token: 0x06000F7F RID: 3967 RVA: 0x00029FB1 File Offset: 0x000281B1
		private static bool n_IsNewLifecycleTimer(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<IExperiments>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).IsNewLifecycleTimer;
		}

		// Token: 0x170005A2 RID: 1442
		// (get) Token: 0x06000F80 RID: 3968 RVA: 0x00029FC0 File Offset: 0x000281C0
		public bool IsNewLifecycleTimer
		{
			get
			{
				if (this.id_isNewLifecycleTimer == IntPtr.Zero)
				{
					this.id_isNewLifecycleTimer = JNIEnv.GetMethodID(this.class_ref, "isNewLifecycleTimer", "()Z");
				}
				return JNIEnv.CallBooleanMethod(base.Handle, this.id_isNewLifecycleTimer);
			}
		}

		// Token: 0x06000F81 RID: 3969 RVA: 0x0002A000 File Offset: 0x00028200
		private static Delegate GetIsPrivacyRequestEnabledHandler()
		{
			if (IExperimentsInvoker.cb_isPrivacyRequestEnabled == null)
			{
				IExperimentsInvoker.cb_isPrivacyRequestEnabled = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(IExperimentsInvoker.n_IsPrivacyRequestEnabled));
			}
			return IExperimentsInvoker.cb_isPrivacyRequestEnabled;
		}

		// Token: 0x06000F82 RID: 3970 RVA: 0x0002A024 File Offset: 0x00028224
		private static bool n_IsPrivacyRequestEnabled(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<IExperiments>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).IsPrivacyRequestEnabled;
		}

		// Token: 0x170005A3 RID: 1443
		// (get) Token: 0x06000F83 RID: 3971 RVA: 0x0002A033 File Offset: 0x00028233
		public bool IsPrivacyRequestEnabled
		{
			get
			{
				if (this.id_isPrivacyRequestEnabled == IntPtr.Zero)
				{
					this.id_isPrivacyRequestEnabled = JNIEnv.GetMethodID(this.class_ref, "isPrivacyRequestEnabled", "()Z");
				}
				return JNIEnv.CallBooleanMethod(base.Handle, this.id_isPrivacyRequestEnabled);
			}
		}

		// Token: 0x06000F84 RID: 3972 RVA: 0x0002A073 File Offset: 0x00028273
		private static Delegate GetIsScarInitEnabledHandler()
		{
			if (IExperimentsInvoker.cb_isScarInitEnabled == null)
			{
				IExperimentsInvoker.cb_isScarInitEnabled = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(IExperimentsInvoker.n_IsScarInitEnabled));
			}
			return IExperimentsInvoker.cb_isScarInitEnabled;
		}

		// Token: 0x06000F85 RID: 3973 RVA: 0x0002A097 File Offset: 0x00028297
		private static bool n_IsScarInitEnabled(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<IExperiments>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).IsScarInitEnabled;
		}

		// Token: 0x170005A4 RID: 1444
		// (get) Token: 0x06000F86 RID: 3974 RVA: 0x0002A0A6 File Offset: 0x000282A6
		public bool IsScarInitEnabled
		{
			get
			{
				if (this.id_isScarInitEnabled == IntPtr.Zero)
				{
					this.id_isScarInitEnabled = JNIEnv.GetMethodID(this.class_ref, "isScarInitEnabled", "()Z");
				}
				return JNIEnv.CallBooleanMethod(base.Handle, this.id_isScarInitEnabled);
			}
		}

		// Token: 0x06000F87 RID: 3975 RVA: 0x0002A0E6 File Offset: 0x000282E6
		private static Delegate GetIsTwoStageInitializationEnabledHandler()
		{
			if (IExperimentsInvoker.cb_isTwoStageInitializationEnabled == null)
			{
				IExperimentsInvoker.cb_isTwoStageInitializationEnabled = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(IExperimentsInvoker.n_IsTwoStageInitializationEnabled));
			}
			return IExperimentsInvoker.cb_isTwoStageInitializationEnabled;
		}

		// Token: 0x06000F88 RID: 3976 RVA: 0x0002A10A File Offset: 0x0002830A
		private static bool n_IsTwoStageInitializationEnabled(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<IExperiments>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).IsTwoStageInitializationEnabled;
		}

		// Token: 0x170005A5 RID: 1445
		// (get) Token: 0x06000F89 RID: 3977 RVA: 0x0002A119 File Offset: 0x00028319
		public bool IsTwoStageInitializationEnabled
		{
			get
			{
				if (this.id_isTwoStageInitializationEnabled == IntPtr.Zero)
				{
					this.id_isTwoStageInitializationEnabled = JNIEnv.GetMethodID(this.class_ref, "isTwoStageInitializationEnabled", "()Z");
				}
				return JNIEnv.CallBooleanMethod(base.Handle, this.id_isTwoStageInitializationEnabled);
			}
		}

		// Token: 0x06000F8A RID: 3978 RVA: 0x0002A159 File Offset: 0x00028359
		private static Delegate GetIsUpdatePiiFieldsHandler()
		{
			if (IExperimentsInvoker.cb_isUpdatePiiFields == null)
			{
				IExperimentsInvoker.cb_isUpdatePiiFields = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(IExperimentsInvoker.n_IsUpdatePiiFields));
			}
			return IExperimentsInvoker.cb_isUpdatePiiFields;
		}

		// Token: 0x06000F8B RID: 3979 RVA: 0x0002A17D File Offset: 0x0002837D
		private static bool n_IsUpdatePiiFields(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<IExperiments>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).IsUpdatePiiFields;
		}

		// Token: 0x170005A6 RID: 1446
		// (get) Token: 0x06000F8C RID: 3980 RVA: 0x0002A18C File Offset: 0x0002838C
		public bool IsUpdatePiiFields
		{
			get
			{
				if (this.id_isUpdatePiiFields == IntPtr.Zero)
				{
					this.id_isUpdatePiiFields = JNIEnv.GetMethodID(this.class_ref, "isUpdatePiiFields", "()Z");
				}
				return JNIEnv.CallBooleanMethod(base.Handle, this.id_isUpdatePiiFields);
			}
		}

		// Token: 0x06000F8D RID: 3981 RVA: 0x0002A1CC File Offset: 0x000283CC
		private static Delegate GetIsWebAssetAdCachingHandler()
		{
			if (IExperimentsInvoker.cb_isWebAssetAdCaching == null)
			{
				IExperimentsInvoker.cb_isWebAssetAdCaching = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(IExperimentsInvoker.n_IsWebAssetAdCaching));
			}
			return IExperimentsInvoker.cb_isWebAssetAdCaching;
		}

		// Token: 0x06000F8E RID: 3982 RVA: 0x0002A1F0 File Offset: 0x000283F0
		private static bool n_IsWebAssetAdCaching(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<IExperiments>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).IsWebAssetAdCaching;
		}

		// Token: 0x170005A7 RID: 1447
		// (get) Token: 0x06000F8F RID: 3983 RVA: 0x0002A1FF File Offset: 0x000283FF
		public bool IsWebAssetAdCaching
		{
			get
			{
				if (this.id_isWebAssetAdCaching == IntPtr.Zero)
				{
					this.id_isWebAssetAdCaching = JNIEnv.GetMethodID(this.class_ref, "isWebAssetAdCaching", "()Z");
				}
				return JNIEnv.CallBooleanMethod(base.Handle, this.id_isWebAssetAdCaching);
			}
		}

		// Token: 0x06000F90 RID: 3984 RVA: 0x0002A23F File Offset: 0x0002843F
		private static Delegate GetIsWebGestureNotRequiredHandler()
		{
			if (IExperimentsInvoker.cb_isWebGestureNotRequired == null)
			{
				IExperimentsInvoker.cb_isWebGestureNotRequired = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(IExperimentsInvoker.n_IsWebGestureNotRequired));
			}
			return IExperimentsInvoker.cb_isWebGestureNotRequired;
		}

		// Token: 0x06000F91 RID: 3985 RVA: 0x0002A263 File Offset: 0x00028463
		private static bool n_IsWebGestureNotRequired(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<IExperiments>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).IsWebGestureNotRequired;
		}

		// Token: 0x170005A8 RID: 1448
		// (get) Token: 0x06000F92 RID: 3986 RVA: 0x0002A272 File Offset: 0x00028472
		public bool IsWebGestureNotRequired
		{
			get
			{
				if (this.id_isWebGestureNotRequired == IntPtr.Zero)
				{
					this.id_isWebGestureNotRequired = JNIEnv.GetMethodID(this.class_ref, "isWebGestureNotRequired", "()Z");
				}
				return JNIEnv.CallBooleanMethod(base.Handle, this.id_isWebGestureNotRequired);
			}
		}

		// Token: 0x06000F93 RID: 3987 RVA: 0x0002A2B2 File Offset: 0x000284B2
		private static Delegate GetGetNextSessionExperimentsHandler()
		{
			if (IExperimentsInvoker.cb_getNextSessionExperiments == null)
			{
				IExperimentsInvoker.cb_getNextSessionExperiments = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IExperimentsInvoker.n_GetNextSessionExperiments));
			}
			return IExperimentsInvoker.cb_getNextSessionExperiments;
		}

		// Token: 0x06000F94 RID: 3988 RVA: 0x0002A2D6 File Offset: 0x000284D6
		private static IntPtr n_GetNextSessionExperiments(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<IExperiments>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).NextSessionExperiments);
		}

		// Token: 0x170005A9 RID: 1449
		// (get) Token: 0x06000F95 RID: 3989 RVA: 0x0002A2EC File Offset: 0x000284EC
		public JSONObject NextSessionExperiments
		{
			get
			{
				if (this.id_getNextSessionExperiments == IntPtr.Zero)
				{
					this.id_getNextSessionExperiments = JNIEnv.GetMethodID(this.class_ref, "getNextSessionExperiments", "()Lorg/json/JSONObject;");
				}
				return Java.Lang.Object.GetObject<JSONObject>(JNIEnv.CallObjectMethod(base.Handle, this.id_getNextSessionExperiments), JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x06000F96 RID: 3990 RVA: 0x0002A33D File Offset: 0x0002853D
		private static Delegate GetShouldNativeTokenAwaitPrivacyHandler()
		{
			if (IExperimentsInvoker.cb_shouldNativeTokenAwaitPrivacy == null)
			{
				IExperimentsInvoker.cb_shouldNativeTokenAwaitPrivacy = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(IExperimentsInvoker.n_ShouldNativeTokenAwaitPrivacy));
			}
			return IExperimentsInvoker.cb_shouldNativeTokenAwaitPrivacy;
		}

		// Token: 0x06000F97 RID: 3991 RVA: 0x0002A361 File Offset: 0x00028561
		private static bool n_ShouldNativeTokenAwaitPrivacy(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<IExperiments>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ShouldNativeTokenAwaitPrivacy();
		}

		// Token: 0x06000F98 RID: 3992 RVA: 0x0002A370 File Offset: 0x00028570
		public bool ShouldNativeTokenAwaitPrivacy()
		{
			if (this.id_shouldNativeTokenAwaitPrivacy == IntPtr.Zero)
			{
				this.id_shouldNativeTokenAwaitPrivacy = JNIEnv.GetMethodID(this.class_ref, "shouldNativeTokenAwaitPrivacy", "()Z");
			}
			return JNIEnv.CallBooleanMethod(base.Handle, this.id_shouldNativeTokenAwaitPrivacy);
		}

		// Token: 0x0400039C RID: 924
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/unity3d/services/core/configuration/IExperiments", typeof(IExperimentsInvoker));

		// Token: 0x0400039D RID: 925
		private IntPtr class_ref;

		// Token: 0x0400039E RID: 926
		private static Delegate cb_getCurrentSessionExperiments;

		// Token: 0x0400039F RID: 927
		private IntPtr id_getCurrentSessionExperiments;

		// Token: 0x040003A0 RID: 928
		private static Delegate cb_getExperimentTags;

		// Token: 0x040003A1 RID: 929
		private IntPtr id_getExperimentTags;

		// Token: 0x040003A2 RID: 930
		private static Delegate cb_getExperimentsAsJson;

		// Token: 0x040003A3 RID: 931
		private IntPtr id_getExperimentsAsJson;

		// Token: 0x040003A4 RID: 932
		private static Delegate cb_isForwardExperimentsToWebViewEnabled;

		// Token: 0x040003A5 RID: 933
		private IntPtr id_isForwardExperimentsToWebViewEnabled;

		// Token: 0x040003A6 RID: 934
		private static Delegate cb_isNativeTokenEnabled;

		// Token: 0x040003A7 RID: 935
		private IntPtr id_isNativeTokenEnabled;

		// Token: 0x040003A8 RID: 936
		private static Delegate cb_isNativeWebViewCacheEnabled;

		// Token: 0x040003A9 RID: 937
		private IntPtr id_isNativeWebViewCacheEnabled;

		// Token: 0x040003AA RID: 938
		private static Delegate cb_isNewInitFlowEnabled;

		// Token: 0x040003AB RID: 939
		private IntPtr id_isNewInitFlowEnabled;

		// Token: 0x040003AC RID: 940
		private static Delegate cb_isNewLifecycleTimer;

		// Token: 0x040003AD RID: 941
		private IntPtr id_isNewLifecycleTimer;

		// Token: 0x040003AE RID: 942
		private static Delegate cb_isPrivacyRequestEnabled;

		// Token: 0x040003AF RID: 943
		private IntPtr id_isPrivacyRequestEnabled;

		// Token: 0x040003B0 RID: 944
		private static Delegate cb_isScarInitEnabled;

		// Token: 0x040003B1 RID: 945
		private IntPtr id_isScarInitEnabled;

		// Token: 0x040003B2 RID: 946
		private static Delegate cb_isTwoStageInitializationEnabled;

		// Token: 0x040003B3 RID: 947
		private IntPtr id_isTwoStageInitializationEnabled;

		// Token: 0x040003B4 RID: 948
		private static Delegate cb_isUpdatePiiFields;

		// Token: 0x040003B5 RID: 949
		private IntPtr id_isUpdatePiiFields;

		// Token: 0x040003B6 RID: 950
		private static Delegate cb_isWebAssetAdCaching;

		// Token: 0x040003B7 RID: 951
		private IntPtr id_isWebAssetAdCaching;

		// Token: 0x040003B8 RID: 952
		private static Delegate cb_isWebGestureNotRequired;

		// Token: 0x040003B9 RID: 953
		private IntPtr id_isWebGestureNotRequired;

		// Token: 0x040003BA RID: 954
		private static Delegate cb_getNextSessionExperiments;

		// Token: 0x040003BB RID: 955
		private IntPtr id_getNextSessionExperiments;

		// Token: 0x040003BC RID: 956
		private static Delegate cb_shouldNativeTokenAwaitPrivacy;

		// Token: 0x040003BD RID: 957
		private IntPtr id_shouldNativeTokenAwaitPrivacy;
	}
}
