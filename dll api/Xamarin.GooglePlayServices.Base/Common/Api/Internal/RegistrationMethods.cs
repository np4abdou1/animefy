using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Android.Gms.Common.Api.Internal
{
	// Token: 0x02000037 RID: 55
	[Register("com/google/android/gms/common/api/internal/RegistrationMethods", DoNotGenerateAcw = true)]
	[JavaTypeParameters(new string[]
	{
		"A extends com.google.android.gms.common.api.Api.AnyClient",
		"L"
	})]
	public class RegistrationMethods : Java.Lang.Object
	{
		// Token: 0x17000081 RID: 129
		// (get) Token: 0x060001EC RID: 492 RVA: 0x00006C3C File Offset: 0x00004E3C
		// (set) Token: 0x060001ED RID: 493 RVA: 0x00006C6C File Offset: 0x00004E6C
		[Register("register")]
		public RegisterListenerMethod Register
		{
			get
			{
				return Java.Lang.Object.GetObject<RegisterListenerMethod>(RegistrationMethods._members.InstanceFields.GetObjectValue("register.Lcom/google/android/gms/common/api/internal/RegisterListenerMethod;", this).Handle, JniHandleOwnership.TransferLocalRef);
			}
			set
			{
				IntPtr intPtr = JNIEnv.ToLocalJniHandle(value);
				try
				{
					RegistrationMethods._members.InstanceFields.SetValue("register.Lcom/google/android/gms/common/api/internal/RegisterListenerMethod;", this, new JniObjectReference(intPtr, JniObjectReferenceType.Invalid));
				}
				finally
				{
					JNIEnv.DeleteLocalRef(intPtr);
				}
			}
		}

		// Token: 0x17000082 RID: 130
		// (get) Token: 0x060001EE RID: 494 RVA: 0x00006CB8 File Offset: 0x00004EB8
		// (set) Token: 0x060001EF RID: 495 RVA: 0x00006CE8 File Offset: 0x00004EE8
		[Register("zaa")]
		public UnregisterListenerMethod Zaa
		{
			get
			{
				return Java.Lang.Object.GetObject<UnregisterListenerMethod>(RegistrationMethods._members.InstanceFields.GetObjectValue("zaa.Lcom/google/android/gms/common/api/internal/UnregisterListenerMethod;", this).Handle, JniHandleOwnership.TransferLocalRef);
			}
			set
			{
				IntPtr intPtr = JNIEnv.ToLocalJniHandle(value);
				try
				{
					RegistrationMethods._members.InstanceFields.SetValue("zaa.Lcom/google/android/gms/common/api/internal/UnregisterListenerMethod;", this, new JniObjectReference(intPtr, JniObjectReferenceType.Invalid));
				}
				finally
				{
					JNIEnv.DeleteLocalRef(intPtr);
				}
			}
		}

		// Token: 0x17000083 RID: 131
		// (get) Token: 0x060001F0 RID: 496 RVA: 0x00006D34 File Offset: 0x00004F34
		// (set) Token: 0x060001F1 RID: 497 RVA: 0x00006D64 File Offset: 0x00004F64
		[Register("zab")]
		public IRunnable Zab
		{
			get
			{
				return Java.Lang.Object.GetObject<IRunnable>(RegistrationMethods._members.InstanceFields.GetObjectValue("zab.Ljava/lang/Runnable;", this).Handle, JniHandleOwnership.TransferLocalRef);
			}
			set
			{
				IntPtr intPtr = JNIEnv.ToLocalJniHandle(value);
				try
				{
					RegistrationMethods._members.InstanceFields.SetValue("zab.Ljava/lang/Runnable;", this, new JniObjectReference(intPtr, JniObjectReferenceType.Invalid));
				}
				finally
				{
					JNIEnv.DeleteLocalRef(intPtr);
				}
			}
		}

		// Token: 0x17000084 RID: 132
		// (get) Token: 0x060001F2 RID: 498 RVA: 0x00006DB0 File Offset: 0x00004FB0
		internal static IntPtr class_ref
		{
			get
			{
				return RegistrationMethods._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000085 RID: 133
		// (get) Token: 0x060001F3 RID: 499 RVA: 0x00006DD4 File Offset: 0x00004FD4
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return RegistrationMethods._members;
			}
		}

		// Token: 0x17000086 RID: 134
		// (get) Token: 0x060001F4 RID: 500 RVA: 0x00006DDC File Offset: 0x00004FDC
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return RegistrationMethods._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000087 RID: 135
		// (get) Token: 0x060001F5 RID: 501 RVA: 0x00006E00 File Offset: 0x00005000
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return RegistrationMethods._members.ManagedPeerType;
			}
		}

		// Token: 0x060001F6 RID: 502 RVA: 0x00003280 File Offset: 0x00001480
		protected RegistrationMethods(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x060001F7 RID: 503 RVA: 0x00006E0C File Offset: 0x0000500C
		[Register("builder", "()Lcom/google/android/gms/common/api/internal/RegistrationMethods$Builder;", "")]
		[JavaTypeParameters(new string[]
		{
			"A extends com.google.android.gms.common.api.Api.AnyClient",
			"L"
		})]
		public static RegistrationMethods.Builder InvokeBuilder()
		{
			return Java.Lang.Object.GetObject<RegistrationMethods.Builder>(RegistrationMethods._members.StaticMethods.InvokeObjectMethod("builder.()Lcom/google/android/gms/common/api/internal/RegistrationMethods$Builder;", null).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x04000066 RID: 102
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/google/android/gms/common/api/internal/RegistrationMethods", typeof(RegistrationMethods));

		// Token: 0x02000038 RID: 56
		[Register("com/google/android/gms/common/api/internal/RegistrationMethods$Builder", DoNotGenerateAcw = true)]
		[JavaTypeParameters(new string[]
		{
			"A extends com.google.android.gms.common.api.Api.AnyClient",
			"L"
		})]
		public class Builder : Java.Lang.Object
		{
			// Token: 0x17000088 RID: 136
			// (get) Token: 0x060001F9 RID: 505 RVA: 0x00006E58 File Offset: 0x00005058
			internal static IntPtr class_ref
			{
				get
				{
					return RegistrationMethods.Builder._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x17000089 RID: 137
			// (get) Token: 0x060001FA RID: 506 RVA: 0x00006E7C File Offset: 0x0000507C
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			public override JniPeerMembers JniPeerMembers
			{
				get
				{
					return RegistrationMethods.Builder._members;
				}
			}

			// Token: 0x1700008A RID: 138
			// (get) Token: 0x060001FB RID: 507 RVA: 0x00006E84 File Offset: 0x00005084
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override IntPtr ThresholdClass
			{
				get
				{
					return RegistrationMethods.Builder._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x1700008B RID: 139
			// (get) Token: 0x060001FC RID: 508 RVA: 0x00006EA8 File Offset: 0x000050A8
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override Type ThresholdType
			{
				get
				{
					return RegistrationMethods.Builder._members.ManagedPeerType;
				}
			}

			// Token: 0x060001FD RID: 509 RVA: 0x00003280 File Offset: 0x00001480
			protected Builder(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
			{
			}

			// Token: 0x060001FE RID: 510 RVA: 0x00006EB4 File Offset: 0x000050B4
			private static Delegate GetBuildHandler()
			{
				if (RegistrationMethods.Builder.cb_build == null)
				{
					RegistrationMethods.Builder.cb_build = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(RegistrationMethods.Builder.n_Build));
				}
				return RegistrationMethods.Builder.cb_build;
			}

			// Token: 0x060001FF RID: 511 RVA: 0x00006ED8 File Offset: 0x000050D8
			private static IntPtr n_Build(IntPtr jnienv, IntPtr native__this)
			{
				return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<RegistrationMethods.Builder>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Build());
			}

			// Token: 0x06000200 RID: 512 RVA: 0x00006EEC File Offset: 0x000050EC
			[Register("build", "()Lcom/google/android/gms/common/api/internal/RegistrationMethods;", "GetBuildHandler")]
			public virtual RegistrationMethods Build()
			{
				return Java.Lang.Object.GetObject<RegistrationMethods>(RegistrationMethods.Builder._members.InstanceMethods.InvokeVirtualObjectMethod("build.()Lcom/google/android/gms/common/api/internal/RegistrationMethods;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}

			// Token: 0x06000201 RID: 513 RVA: 0x00006F1E File Offset: 0x0000511E
			private static Delegate GetOnConnectionSuspended_Ljava_lang_Runnable_Handler()
			{
				if (RegistrationMethods.Builder.cb_onConnectionSuspended_Ljava_lang_Runnable_ == null)
				{
					RegistrationMethods.Builder.cb_onConnectionSuspended_Ljava_lang_Runnable_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(RegistrationMethods.Builder.n_OnConnectionSuspended_Ljava_lang_Runnable_));
				}
				return RegistrationMethods.Builder.cb_onConnectionSuspended_Ljava_lang_Runnable_;
			}

			// Token: 0x06000202 RID: 514 RVA: 0x00006F44 File Offset: 0x00005144
			private static IntPtr n_OnConnectionSuspended_Ljava_lang_Runnable_(IntPtr jnienv, IntPtr native__this, IntPtr native_onConnectionSuspended)
			{
				RegistrationMethods.Builder @object = Java.Lang.Object.GetObject<RegistrationMethods.Builder>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				IRunnable object2 = Java.Lang.Object.GetObject<IRunnable>(native_onConnectionSuspended, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle(@object.OnConnectionSuspended(object2));
			}

			// Token: 0x06000203 RID: 515 RVA: 0x00006F6C File Offset: 0x0000516C
			[Register("onConnectionSuspended", "(Ljava/lang/Runnable;)Lcom/google/android/gms/common/api/internal/RegistrationMethods$Builder;", "GetOnConnectionSuspended_Ljava_lang_Runnable_Handler")]
			public unsafe virtual RegistrationMethods.Builder OnConnectionSuspended(IRunnable onConnectionSuspended)
			{
				RegistrationMethods.Builder @object;
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue((onConnectionSuspended == null) ? IntPtr.Zero : ((Java.Lang.Object)onConnectionSuspended).Handle);
					@object = Java.Lang.Object.GetObject<RegistrationMethods.Builder>(RegistrationMethods.Builder._members.InstanceMethods.InvokeVirtualObjectMethod("onConnectionSuspended.(Ljava/lang/Runnable;)Lcom/google/android/gms/common/api/internal/RegistrationMethods$Builder;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
				}
				finally
				{
					GC.KeepAlive(onConnectionSuspended);
				}
				return @object;
			}

			// Token: 0x06000204 RID: 516 RVA: 0x00006FE4 File Offset: 0x000051E4
			private static Delegate GetRegister_Lcom_google_android_gms_common_api_internal_RemoteCall_Handler()
			{
				if (RegistrationMethods.Builder.cb_register_Lcom_google_android_gms_common_api_internal_RemoteCall_ == null)
				{
					RegistrationMethods.Builder.cb_register_Lcom_google_android_gms_common_api_internal_RemoteCall_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(RegistrationMethods.Builder.n_Register_Lcom_google_android_gms_common_api_internal_RemoteCall_));
				}
				return RegistrationMethods.Builder.cb_register_Lcom_google_android_gms_common_api_internal_RemoteCall_;
			}

			// Token: 0x06000205 RID: 517 RVA: 0x00007008 File Offset: 0x00005208
			private static IntPtr n_Register_Lcom_google_android_gms_common_api_internal_RemoteCall_(IntPtr jnienv, IntPtr native__this, IntPtr native_register)
			{
				RegistrationMethods.Builder @object = Java.Lang.Object.GetObject<RegistrationMethods.Builder>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				IRemoteCall object2 = Java.Lang.Object.GetObject<IRemoteCall>(native_register, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle(@object.Register(object2));
			}

			// Token: 0x06000206 RID: 518 RVA: 0x00007030 File Offset: 0x00005230
			[Register("register", "(Lcom/google/android/gms/common/api/internal/RemoteCall;)Lcom/google/android/gms/common/api/internal/RegistrationMethods$Builder;", "GetRegister_Lcom_google_android_gms_common_api_internal_RemoteCall_Handler")]
			public unsafe virtual RegistrationMethods.Builder Register(IRemoteCall register)
			{
				RegistrationMethods.Builder @object;
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue((register == null) ? IntPtr.Zero : ((Java.Lang.Object)register).Handle);
					@object = Java.Lang.Object.GetObject<RegistrationMethods.Builder>(RegistrationMethods.Builder._members.InstanceMethods.InvokeVirtualObjectMethod("register.(Lcom/google/android/gms/common/api/internal/RemoteCall;)Lcom/google/android/gms/common/api/internal/RegistrationMethods$Builder;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
				}
				finally
				{
					GC.KeepAlive(register);
				}
				return @object;
			}

			// Token: 0x06000207 RID: 519 RVA: 0x000070A8 File Offset: 0x000052A8
			private static Delegate GetSetAutoResolveMissingFeatures_ZHandler()
			{
				if (RegistrationMethods.Builder.cb_setAutoResolveMissingFeatures_Z == null)
				{
					RegistrationMethods.Builder.cb_setAutoResolveMissingFeatures_Z = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPZ_L(RegistrationMethods.Builder.n_SetAutoResolveMissingFeatures_Z));
				}
				return RegistrationMethods.Builder.cb_setAutoResolveMissingFeatures_Z;
			}

			// Token: 0x06000208 RID: 520 RVA: 0x000070CC File Offset: 0x000052CC
			private static IntPtr n_SetAutoResolveMissingFeatures_Z(IntPtr jnienv, IntPtr native__this, bool shouldAutoResolveMissingFeatures)
			{
				return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<RegistrationMethods.Builder>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).SetAutoResolveMissingFeatures(shouldAutoResolveMissingFeatures));
			}

			// Token: 0x06000209 RID: 521 RVA: 0x000070E4 File Offset: 0x000052E4
			[Register("setAutoResolveMissingFeatures", "(Z)Lcom/google/android/gms/common/api/internal/RegistrationMethods$Builder;", "GetSetAutoResolveMissingFeatures_ZHandler")]
			public unsafe virtual RegistrationMethods.Builder SetAutoResolveMissingFeatures(bool shouldAutoResolveMissingFeatures)
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(shouldAutoResolveMissingFeatures);
				return Java.Lang.Object.GetObject<RegistrationMethods.Builder>(RegistrationMethods.Builder._members.InstanceMethods.InvokeVirtualObjectMethod("setAutoResolveMissingFeatures.(Z)Lcom/google/android/gms/common/api/internal/RegistrationMethods$Builder;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}

			// Token: 0x0600020A RID: 522 RVA: 0x0000712D File Offset: 0x0000532D
			private static Delegate GetSetFeatures_arrayLcom_google_android_gms_common_Feature_Handler()
			{
				if (RegistrationMethods.Builder.cb_setFeatures_arrayLcom_google_android_gms_common_Feature_ == null)
				{
					RegistrationMethods.Builder.cb_setFeatures_arrayLcom_google_android_gms_common_Feature_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(RegistrationMethods.Builder.n_SetFeatures_arrayLcom_google_android_gms_common_Feature_));
				}
				return RegistrationMethods.Builder.cb_setFeatures_arrayLcom_google_android_gms_common_Feature_;
			}

			// Token: 0x0600020B RID: 523 RVA: 0x00007154 File Offset: 0x00005354
			private static IntPtr n_SetFeatures_arrayLcom_google_android_gms_common_Feature_(IntPtr jnienv, IntPtr native__this, IntPtr native_features)
			{
				RegistrationMethods.Builder @object = Java.Lang.Object.GetObject<RegistrationMethods.Builder>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				Feature[] array = (Feature[])JNIEnv.GetArray(native_features, JniHandleOwnership.DoNotTransfer, typeof(Feature));
				IntPtr result = JNIEnv.ToLocalJniHandle(@object.SetFeatures(array));
				if (array != null)
				{
					JNIEnv.CopyArray<Feature>(array, native_features);
				}
				return result;
			}

			// Token: 0x0600020C RID: 524 RVA: 0x00007198 File Offset: 0x00005398
			[Register("setFeatures", "([Lcom/google/android/gms/common/Feature;)Lcom/google/android/gms/common/api/internal/RegistrationMethods$Builder;", "GetSetFeatures_arrayLcom_google_android_gms_common_Feature_Handler")]
			public unsafe virtual RegistrationMethods.Builder SetFeatures(params Feature[] features)
			{
				IntPtr intPtr = JNIEnv.NewArray<Feature>(features);
				RegistrationMethods.Builder @object;
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue(intPtr);
					@object = Java.Lang.Object.GetObject<RegistrationMethods.Builder>(RegistrationMethods.Builder._members.InstanceMethods.InvokeVirtualObjectMethod("setFeatures.([Lcom/google/android/gms/common/Feature;)Lcom/google/android/gms/common/api/internal/RegistrationMethods$Builder;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
				}
				finally
				{
					if (features != null)
					{
						JNIEnv.CopyArray<Feature>(intPtr, features);
						JNIEnv.DeleteLocalRef(intPtr);
					}
					GC.KeepAlive(features);
				}
				return @object;
			}

			// Token: 0x0600020D RID: 525 RVA: 0x00007214 File Offset: 0x00005414
			private static Delegate GetSetMethodKey_IHandler()
			{
				if (RegistrationMethods.Builder.cb_setMethodKey_I == null)
				{
					RegistrationMethods.Builder.cb_setMethodKey_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPI_L(RegistrationMethods.Builder.n_SetMethodKey_I));
				}
				return RegistrationMethods.Builder.cb_setMethodKey_I;
			}

			// Token: 0x0600020E RID: 526 RVA: 0x00007238 File Offset: 0x00005438
			private static IntPtr n_SetMethodKey_I(IntPtr jnienv, IntPtr native__this, int methodKey)
			{
				return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<RegistrationMethods.Builder>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).SetMethodKey(methodKey));
			}

			// Token: 0x0600020F RID: 527 RVA: 0x00007250 File Offset: 0x00005450
			[Register("setMethodKey", "(I)Lcom/google/android/gms/common/api/internal/RegistrationMethods$Builder;", "GetSetMethodKey_IHandler")]
			public unsafe virtual RegistrationMethods.Builder SetMethodKey(int methodKey)
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(methodKey);
				return Java.Lang.Object.GetObject<RegistrationMethods.Builder>(RegistrationMethods.Builder._members.InstanceMethods.InvokeVirtualObjectMethod("setMethodKey.(I)Lcom/google/android/gms/common/api/internal/RegistrationMethods$Builder;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}

			// Token: 0x06000210 RID: 528 RVA: 0x00007299 File Offset: 0x00005499
			private static Delegate GetUnregister_Lcom_google_android_gms_common_api_internal_RemoteCall_Handler()
			{
				if (RegistrationMethods.Builder.cb_unregister_Lcom_google_android_gms_common_api_internal_RemoteCall_ == null)
				{
					RegistrationMethods.Builder.cb_unregister_Lcom_google_android_gms_common_api_internal_RemoteCall_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(RegistrationMethods.Builder.n_Unregister_Lcom_google_android_gms_common_api_internal_RemoteCall_));
				}
				return RegistrationMethods.Builder.cb_unregister_Lcom_google_android_gms_common_api_internal_RemoteCall_;
			}

			// Token: 0x06000211 RID: 529 RVA: 0x000072C0 File Offset: 0x000054C0
			private static IntPtr n_Unregister_Lcom_google_android_gms_common_api_internal_RemoteCall_(IntPtr jnienv, IntPtr native__this, IntPtr native_unregister)
			{
				RegistrationMethods.Builder @object = Java.Lang.Object.GetObject<RegistrationMethods.Builder>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				IRemoteCall object2 = Java.Lang.Object.GetObject<IRemoteCall>(native_unregister, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle(@object.Unregister(object2));
			}

			// Token: 0x06000212 RID: 530 RVA: 0x000072E8 File Offset: 0x000054E8
			[Register("unregister", "(Lcom/google/android/gms/common/api/internal/RemoteCall;)Lcom/google/android/gms/common/api/internal/RegistrationMethods$Builder;", "GetUnregister_Lcom_google_android_gms_common_api_internal_RemoteCall_Handler")]
			public unsafe virtual RegistrationMethods.Builder Unregister(IRemoteCall unregister)
			{
				RegistrationMethods.Builder @object;
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue((unregister == null) ? IntPtr.Zero : ((Java.Lang.Object)unregister).Handle);
					@object = Java.Lang.Object.GetObject<RegistrationMethods.Builder>(RegistrationMethods.Builder._members.InstanceMethods.InvokeVirtualObjectMethod("unregister.(Lcom/google/android/gms/common/api/internal/RemoteCall;)Lcom/google/android/gms/common/api/internal/RegistrationMethods$Builder;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
				}
				finally
				{
					GC.KeepAlive(unregister);
				}
				return @object;
			}

			// Token: 0x06000213 RID: 531 RVA: 0x00007360 File Offset: 0x00005560
			private static Delegate GetWithHolder_Lcom_google_android_gms_common_api_internal_ListenerHolder_Handler()
			{
				if (RegistrationMethods.Builder.cb_withHolder_Lcom_google_android_gms_common_api_internal_ListenerHolder_ == null)
				{
					RegistrationMethods.Builder.cb_withHolder_Lcom_google_android_gms_common_api_internal_ListenerHolder_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(RegistrationMethods.Builder.n_WithHolder_Lcom_google_android_gms_common_api_internal_ListenerHolder_));
				}
				return RegistrationMethods.Builder.cb_withHolder_Lcom_google_android_gms_common_api_internal_ListenerHolder_;
			}

			// Token: 0x06000214 RID: 532 RVA: 0x00007384 File Offset: 0x00005584
			private static IntPtr n_WithHolder_Lcom_google_android_gms_common_api_internal_ListenerHolder_(IntPtr jnienv, IntPtr native__this, IntPtr native_holder)
			{
				RegistrationMethods.Builder @object = Java.Lang.Object.GetObject<RegistrationMethods.Builder>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				ListenerHolder object2 = Java.Lang.Object.GetObject<ListenerHolder>(native_holder, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle(@object.WithHolder(object2));
			}

			// Token: 0x06000215 RID: 533 RVA: 0x000073AC File Offset: 0x000055AC
			[Register("withHolder", "(Lcom/google/android/gms/common/api/internal/ListenerHolder;)Lcom/google/android/gms/common/api/internal/RegistrationMethods$Builder;", "GetWithHolder_Lcom_google_android_gms_common_api_internal_ListenerHolder_Handler")]
			public unsafe virtual RegistrationMethods.Builder WithHolder(ListenerHolder holder)
			{
				RegistrationMethods.Builder @object;
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue((holder == null) ? IntPtr.Zero : holder.Handle);
					@object = Java.Lang.Object.GetObject<RegistrationMethods.Builder>(RegistrationMethods.Builder._members.InstanceMethods.InvokeVirtualObjectMethod("withHolder.(Lcom/google/android/gms/common/api/internal/ListenerHolder;)Lcom/google/android/gms/common/api/internal/RegistrationMethods$Builder;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
				}
				finally
				{
					GC.KeepAlive(holder);
				}
				return @object;
			}

			// Token: 0x04000067 RID: 103
			private static readonly JniPeerMembers _members = new XAPeerMembers("com/google/android/gms/common/api/internal/RegistrationMethods$Builder", typeof(RegistrationMethods.Builder));

			// Token: 0x04000068 RID: 104
			private static Delegate cb_build;

			// Token: 0x04000069 RID: 105
			private static Delegate cb_onConnectionSuspended_Ljava_lang_Runnable_;

			// Token: 0x0400006A RID: 106
			private static Delegate cb_register_Lcom_google_android_gms_common_api_internal_RemoteCall_;

			// Token: 0x0400006B RID: 107
			private static Delegate cb_setAutoResolveMissingFeatures_Z;

			// Token: 0x0400006C RID: 108
			private static Delegate cb_setFeatures_arrayLcom_google_android_gms_common_Feature_;

			// Token: 0x0400006D RID: 109
			private static Delegate cb_setMethodKey_I;

			// Token: 0x0400006E RID: 110
			private static Delegate cb_unregister_Lcom_google_android_gms_common_api_internal_RemoteCall_;

			// Token: 0x0400006F RID: 111
			private static Delegate cb_withHolder_Lcom_google_android_gms_common_api_internal_ListenerHolder_;
		}
	}
}
