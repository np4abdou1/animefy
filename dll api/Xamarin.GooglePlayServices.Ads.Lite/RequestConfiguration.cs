using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Android.Gms.Ads
{
	// Token: 0x02000020 RID: 32
	[Register("com/google/android/gms/ads/RequestConfiguration", DoNotGenerateAcw = true)]
	public class RequestConfiguration : Java.Lang.Object
	{
		// Token: 0x17000051 RID: 81
		// (get) Token: 0x0600011C RID: 284 RVA: 0x00004B40 File Offset: 0x00002D40
		[Register("zza")]
		public static IList Zza
		{
			get
			{
				return JavaList.FromJniHandle(RequestConfiguration._members.StaticFields.GetObjectValue("zza.Ljava/util/List;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x17000052 RID: 82
		// (get) Token: 0x0600011D RID: 285 RVA: 0x00004B70 File Offset: 0x00002D70
		internal static IntPtr class_ref
		{
			get
			{
				return RequestConfiguration._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000053 RID: 83
		// (get) Token: 0x0600011E RID: 286 RVA: 0x00004B94 File Offset: 0x00002D94
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return RequestConfiguration._members;
			}
		}

		// Token: 0x17000054 RID: 84
		// (get) Token: 0x0600011F RID: 287 RVA: 0x00004B9C File Offset: 0x00002D9C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return RequestConfiguration._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000055 RID: 85
		// (get) Token: 0x06000120 RID: 288 RVA: 0x00004BC0 File Offset: 0x00002DC0
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return RequestConfiguration._members.ManagedPeerType;
			}
		}

		// Token: 0x06000121 RID: 289 RVA: 0x000020AC File Offset: 0x000002AC
		protected RequestConfiguration(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06000122 RID: 290 RVA: 0x00004BCC File Offset: 0x00002DCC
		private static Delegate GetGetMaxAdContentRatingHandler()
		{
			if (RequestConfiguration.cb_getMaxAdContentRating == null)
			{
				RequestConfiguration.cb_getMaxAdContentRating = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(RequestConfiguration.n_GetMaxAdContentRating));
			}
			return RequestConfiguration.cb_getMaxAdContentRating;
		}

		// Token: 0x06000123 RID: 291 RVA: 0x00004BF0 File Offset: 0x00002DF0
		private static IntPtr n_GetMaxAdContentRating(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.NewString(Java.Lang.Object.GetObject<RequestConfiguration>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).MaxAdContentRating);
		}

		// Token: 0x17000056 RID: 86
		// (get) Token: 0x06000124 RID: 292 RVA: 0x00004C04 File Offset: 0x00002E04
		public virtual string MaxAdContentRating
		{
			[Register("getMaxAdContentRating", "()Ljava/lang/String;", "GetGetMaxAdContentRatingHandler")]
			get
			{
				return JNIEnv.GetString(RequestConfiguration._members.InstanceMethods.InvokeVirtualObjectMethod("getMaxAdContentRating.()Ljava/lang/String;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x06000125 RID: 293 RVA: 0x00004C36 File Offset: 0x00002E36
		private static Delegate GetGetTagForChildDirectedTreatmentHandler()
		{
			if (RequestConfiguration.cb_getTagForChildDirectedTreatment == null)
			{
				RequestConfiguration.cb_getTagForChildDirectedTreatment = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(RequestConfiguration.n_GetTagForChildDirectedTreatment));
			}
			return RequestConfiguration.cb_getTagForChildDirectedTreatment;
		}

		// Token: 0x06000126 RID: 294 RVA: 0x00004C5A File Offset: 0x00002E5A
		private static int n_GetTagForChildDirectedTreatment(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<RequestConfiguration>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).TagForChildDirectedTreatment;
		}

		// Token: 0x17000057 RID: 87
		// (get) Token: 0x06000127 RID: 295 RVA: 0x00004C69 File Offset: 0x00002E69
		public virtual int TagForChildDirectedTreatment
		{
			[Register("getTagForChildDirectedTreatment", "()I", "GetGetTagForChildDirectedTreatmentHandler")]
			get
			{
				return RequestConfiguration._members.InstanceMethods.InvokeVirtualInt32Method("getTagForChildDirectedTreatment.()I", this, null);
			}
		}

		// Token: 0x06000128 RID: 296 RVA: 0x00004C82 File Offset: 0x00002E82
		private static Delegate GetGetTagForUnderAgeOfConsentHandler()
		{
			if (RequestConfiguration.cb_getTagForUnderAgeOfConsent == null)
			{
				RequestConfiguration.cb_getTagForUnderAgeOfConsent = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(RequestConfiguration.n_GetTagForUnderAgeOfConsent));
			}
			return RequestConfiguration.cb_getTagForUnderAgeOfConsent;
		}

		// Token: 0x06000129 RID: 297 RVA: 0x00004CA6 File Offset: 0x00002EA6
		private static int n_GetTagForUnderAgeOfConsent(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<RequestConfiguration>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).TagForUnderAgeOfConsent;
		}

		// Token: 0x17000058 RID: 88
		// (get) Token: 0x0600012A RID: 298 RVA: 0x00004CB5 File Offset: 0x00002EB5
		public virtual int TagForUnderAgeOfConsent
		{
			[Register("getTagForUnderAgeOfConsent", "()I", "GetGetTagForUnderAgeOfConsentHandler")]
			get
			{
				return RequestConfiguration._members.InstanceMethods.InvokeVirtualInt32Method("getTagForUnderAgeOfConsent.()I", this, null);
			}
		}

		// Token: 0x0600012B RID: 299 RVA: 0x00004CCE File Offset: 0x00002ECE
		private static Delegate GetGetTestDeviceIdsHandler()
		{
			if (RequestConfiguration.cb_getTestDeviceIds == null)
			{
				RequestConfiguration.cb_getTestDeviceIds = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(RequestConfiguration.n_GetTestDeviceIds));
			}
			return RequestConfiguration.cb_getTestDeviceIds;
		}

		// Token: 0x0600012C RID: 300 RVA: 0x00004CF2 File Offset: 0x00002EF2
		private static IntPtr n_GetTestDeviceIds(IntPtr jnienv, IntPtr native__this)
		{
			return JavaList<string>.ToLocalJniHandle(Java.Lang.Object.GetObject<RequestConfiguration>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).TestDeviceIds);
		}

		// Token: 0x17000059 RID: 89
		// (get) Token: 0x0600012D RID: 301 RVA: 0x00004D08 File Offset: 0x00002F08
		public virtual IList<string> TestDeviceIds
		{
			[Register("getTestDeviceIds", "()Ljava/util/List;", "GetGetTestDeviceIdsHandler")]
			get
			{
				return JavaList<string>.FromJniHandle(RequestConfiguration._members.InstanceMethods.InvokeVirtualObjectMethod("getTestDeviceIds.()Ljava/util/List;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x0600012E RID: 302 RVA: 0x00004D3A File Offset: 0x00002F3A
		private static Delegate GetToBuilderHandler()
		{
			if (RequestConfiguration.cb_toBuilder == null)
			{
				RequestConfiguration.cb_toBuilder = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(RequestConfiguration.n_ToBuilder));
			}
			return RequestConfiguration.cb_toBuilder;
		}

		// Token: 0x0600012F RID: 303 RVA: 0x00004D5E File Offset: 0x00002F5E
		private static IntPtr n_ToBuilder(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<RequestConfiguration>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ToBuilder());
		}

		// Token: 0x06000130 RID: 304 RVA: 0x00004D74 File Offset: 0x00002F74
		[Register("toBuilder", "()Lcom/google/android/gms/ads/RequestConfiguration$Builder;", "GetToBuilderHandler")]
		public virtual RequestConfiguration.Builder ToBuilder()
		{
			return Java.Lang.Object.GetObject<RequestConfiguration.Builder>(RequestConfiguration._members.InstanceMethods.InvokeVirtualObjectMethod("toBuilder.()Lcom/google/android/gms/ads/RequestConfiguration$Builder;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x0400003A RID: 58
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/google/android/gms/ads/RequestConfiguration", typeof(RequestConfiguration));

		// Token: 0x0400003B RID: 59
		private static Delegate cb_getMaxAdContentRating;

		// Token: 0x0400003C RID: 60
		private static Delegate cb_getTagForChildDirectedTreatment;

		// Token: 0x0400003D RID: 61
		private static Delegate cb_getTagForUnderAgeOfConsent;

		// Token: 0x0400003E RID: 62
		private static Delegate cb_getTestDeviceIds;

		// Token: 0x0400003F RID: 63
		private static Delegate cb_toBuilder;

		// Token: 0x02000021 RID: 33
		[Register("com/google/android/gms/ads/RequestConfiguration$Builder", DoNotGenerateAcw = true)]
		public class Builder : Java.Lang.Object
		{
			// Token: 0x1700005A RID: 90
			// (get) Token: 0x06000132 RID: 306 RVA: 0x00004DC4 File Offset: 0x00002FC4
			internal static IntPtr class_ref
			{
				get
				{
					return RequestConfiguration.Builder._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x1700005B RID: 91
			// (get) Token: 0x06000133 RID: 307 RVA: 0x00004DE8 File Offset: 0x00002FE8
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			public override JniPeerMembers JniPeerMembers
			{
				get
				{
					return RequestConfiguration.Builder._members;
				}
			}

			// Token: 0x1700005C RID: 92
			// (get) Token: 0x06000134 RID: 308 RVA: 0x00004DF0 File Offset: 0x00002FF0
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override IntPtr ThresholdClass
			{
				get
				{
					return RequestConfiguration.Builder._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x1700005D RID: 93
			// (get) Token: 0x06000135 RID: 309 RVA: 0x00004E14 File Offset: 0x00003014
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override Type ThresholdType
			{
				get
				{
					return RequestConfiguration.Builder._members.ManagedPeerType;
				}
			}

			// Token: 0x06000136 RID: 310 RVA: 0x000020AC File Offset: 0x000002AC
			protected Builder(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
			{
			}

			// Token: 0x06000137 RID: 311 RVA: 0x00004E20 File Offset: 0x00003020
			[Register(".ctor", "()V", "")]
			public Builder() : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (base.Handle != IntPtr.Zero)
				{
					return;
				}
				base.SetHandle(RequestConfiguration.Builder._members.InstanceMethods.StartCreateInstance("()V", base.GetType(), null).Handle, JniHandleOwnership.TransferLocalRef);
				RequestConfiguration.Builder._members.InstanceMethods.FinishCreateInstance("()V", this, null);
			}

			// Token: 0x06000138 RID: 312 RVA: 0x00004E8E File Offset: 0x0000308E
			private static Delegate GetBuildHandler()
			{
				if (RequestConfiguration.Builder.cb_build == null)
				{
					RequestConfiguration.Builder.cb_build = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(RequestConfiguration.Builder.n_Build));
				}
				return RequestConfiguration.Builder.cb_build;
			}

			// Token: 0x06000139 RID: 313 RVA: 0x00004EB2 File Offset: 0x000030B2
			private static IntPtr n_Build(IntPtr jnienv, IntPtr native__this)
			{
				return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<RequestConfiguration.Builder>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Build());
			}

			// Token: 0x0600013A RID: 314 RVA: 0x00004EC8 File Offset: 0x000030C8
			[Register("build", "()Lcom/google/android/gms/ads/RequestConfiguration;", "GetBuildHandler")]
			public virtual RequestConfiguration Build()
			{
				return Java.Lang.Object.GetObject<RequestConfiguration>(RequestConfiguration.Builder._members.InstanceMethods.InvokeVirtualObjectMethod("build.()Lcom/google/android/gms/ads/RequestConfiguration;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}

			// Token: 0x0600013B RID: 315 RVA: 0x00004EFA File Offset: 0x000030FA
			private static Delegate GetSetMaxAdContentRating_Ljava_lang_String_Handler()
			{
				if (RequestConfiguration.Builder.cb_setMaxAdContentRating_Ljava_lang_String_ == null)
				{
					RequestConfiguration.Builder.cb_setMaxAdContentRating_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(RequestConfiguration.Builder.n_SetMaxAdContentRating_Ljava_lang_String_));
				}
				return RequestConfiguration.Builder.cb_setMaxAdContentRating_Ljava_lang_String_;
			}

			// Token: 0x0600013C RID: 316 RVA: 0x00004F20 File Offset: 0x00003120
			private static IntPtr n_SetMaxAdContentRating_Ljava_lang_String_(IntPtr jnienv, IntPtr native__this, IntPtr native_maxAdContentRating)
			{
				RequestConfiguration.Builder @object = Java.Lang.Object.GetObject<RequestConfiguration.Builder>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				string @string = JNIEnv.GetString(native_maxAdContentRating, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle(@object.SetMaxAdContentRating(@string));
			}

			// Token: 0x0600013D RID: 317 RVA: 0x00004F48 File Offset: 0x00003148
			[Register("setMaxAdContentRating", "(Ljava/lang/String;)Lcom/google/android/gms/ads/RequestConfiguration$Builder;", "GetSetMaxAdContentRating_Ljava_lang_String_Handler")]
			public unsafe virtual RequestConfiguration.Builder SetMaxAdContentRating(string maxAdContentRating)
			{
				IntPtr intPtr = JNIEnv.NewString(maxAdContentRating);
				RequestConfiguration.Builder @object;
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue(intPtr);
					@object = Java.Lang.Object.GetObject<RequestConfiguration.Builder>(RequestConfiguration.Builder._members.InstanceMethods.InvokeVirtualObjectMethod("setMaxAdContentRating.(Ljava/lang/String;)Lcom/google/android/gms/ads/RequestConfiguration$Builder;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
				}
				finally
				{
					JNIEnv.DeleteLocalRef(intPtr);
				}
				return @object;
			}

			// Token: 0x0600013E RID: 318 RVA: 0x00004FB4 File Offset: 0x000031B4
			private static Delegate GetSetTagForChildDirectedTreatment_IHandler()
			{
				if (RequestConfiguration.Builder.cb_setTagForChildDirectedTreatment_I == null)
				{
					RequestConfiguration.Builder.cb_setTagForChildDirectedTreatment_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPI_L(RequestConfiguration.Builder.n_SetTagForChildDirectedTreatment_I));
				}
				return RequestConfiguration.Builder.cb_setTagForChildDirectedTreatment_I;
			}

			// Token: 0x0600013F RID: 319 RVA: 0x00004FD8 File Offset: 0x000031D8
			private static IntPtr n_SetTagForChildDirectedTreatment_I(IntPtr jnienv, IntPtr native__this, int tagForChildDirectedTreatment)
			{
				return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<RequestConfiguration.Builder>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).SetTagForChildDirectedTreatment(tagForChildDirectedTreatment));
			}

			// Token: 0x06000140 RID: 320 RVA: 0x00004FF0 File Offset: 0x000031F0
			[Register("setTagForChildDirectedTreatment", "(I)Lcom/google/android/gms/ads/RequestConfiguration$Builder;", "GetSetTagForChildDirectedTreatment_IHandler")]
			public unsafe virtual RequestConfiguration.Builder SetTagForChildDirectedTreatment(int tagForChildDirectedTreatment)
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(tagForChildDirectedTreatment);
				return Java.Lang.Object.GetObject<RequestConfiguration.Builder>(RequestConfiguration.Builder._members.InstanceMethods.InvokeVirtualObjectMethod("setTagForChildDirectedTreatment.(I)Lcom/google/android/gms/ads/RequestConfiguration$Builder;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}

			// Token: 0x06000141 RID: 321 RVA: 0x00005039 File Offset: 0x00003239
			private static Delegate GetSetTagForUnderAgeOfConsent_IHandler()
			{
				if (RequestConfiguration.Builder.cb_setTagForUnderAgeOfConsent_I == null)
				{
					RequestConfiguration.Builder.cb_setTagForUnderAgeOfConsent_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPI_L(RequestConfiguration.Builder.n_SetTagForUnderAgeOfConsent_I));
				}
				return RequestConfiguration.Builder.cb_setTagForUnderAgeOfConsent_I;
			}

			// Token: 0x06000142 RID: 322 RVA: 0x0000505D File Offset: 0x0000325D
			private static IntPtr n_SetTagForUnderAgeOfConsent_I(IntPtr jnienv, IntPtr native__this, int tagForUnderAgeOfConsent)
			{
				return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<RequestConfiguration.Builder>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).SetTagForUnderAgeOfConsent(tagForUnderAgeOfConsent));
			}

			// Token: 0x06000143 RID: 323 RVA: 0x00005074 File Offset: 0x00003274
			[Register("setTagForUnderAgeOfConsent", "(I)Lcom/google/android/gms/ads/RequestConfiguration$Builder;", "GetSetTagForUnderAgeOfConsent_IHandler")]
			public unsafe virtual RequestConfiguration.Builder SetTagForUnderAgeOfConsent(int tagForUnderAgeOfConsent)
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(tagForUnderAgeOfConsent);
				return Java.Lang.Object.GetObject<RequestConfiguration.Builder>(RequestConfiguration.Builder._members.InstanceMethods.InvokeVirtualObjectMethod("setTagForUnderAgeOfConsent.(I)Lcom/google/android/gms/ads/RequestConfiguration$Builder;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}

			// Token: 0x06000144 RID: 324 RVA: 0x000050BD File Offset: 0x000032BD
			private static Delegate GetSetTestDeviceIds_Ljava_util_List_Handler()
			{
				if (RequestConfiguration.Builder.cb_setTestDeviceIds_Ljava_util_List_ == null)
				{
					RequestConfiguration.Builder.cb_setTestDeviceIds_Ljava_util_List_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(RequestConfiguration.Builder.n_SetTestDeviceIds_Ljava_util_List_));
				}
				return RequestConfiguration.Builder.cb_setTestDeviceIds_Ljava_util_List_;
			}

			// Token: 0x06000145 RID: 325 RVA: 0x000050E4 File Offset: 0x000032E4
			private static IntPtr n_SetTestDeviceIds_Ljava_util_List_(IntPtr jnienv, IntPtr native__this, IntPtr native_testDeviceIds)
			{
				RequestConfiguration.Builder @object = Java.Lang.Object.GetObject<RequestConfiguration.Builder>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				IList<string> testDeviceIds = JavaList<string>.FromJniHandle(native_testDeviceIds, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle(@object.SetTestDeviceIds(testDeviceIds));
			}

			// Token: 0x06000146 RID: 326 RVA: 0x0000510C File Offset: 0x0000330C
			[Register("setTestDeviceIds", "(Ljava/util/List;)Lcom/google/android/gms/ads/RequestConfiguration$Builder;", "GetSetTestDeviceIds_Ljava_util_List_Handler")]
			public unsafe virtual RequestConfiguration.Builder SetTestDeviceIds(IList<string> testDeviceIds)
			{
				IntPtr intPtr = JavaList<string>.ToLocalJniHandle(testDeviceIds);
				RequestConfiguration.Builder @object;
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue(intPtr);
					@object = Java.Lang.Object.GetObject<RequestConfiguration.Builder>(RequestConfiguration.Builder._members.InstanceMethods.InvokeVirtualObjectMethod("setTestDeviceIds.(Ljava/util/List;)Lcom/google/android/gms/ads/RequestConfiguration$Builder;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
				}
				finally
				{
					JNIEnv.DeleteLocalRef(intPtr);
					GC.KeepAlive(testDeviceIds);
				}
				return @object;
			}

			// Token: 0x04000040 RID: 64
			private static readonly JniPeerMembers _members = new XAPeerMembers("com/google/android/gms/ads/RequestConfiguration$Builder", typeof(RequestConfiguration.Builder));

			// Token: 0x04000041 RID: 65
			private static Delegate cb_build;

			// Token: 0x04000042 RID: 66
			private static Delegate cb_setMaxAdContentRating_Ljava_lang_String_;

			// Token: 0x04000043 RID: 67
			private static Delegate cb_setTagForChildDirectedTreatment_I;

			// Token: 0x04000044 RID: 68
			private static Delegate cb_setTagForUnderAgeOfConsent_I;

			// Token: 0x04000045 RID: 69
			private static Delegate cb_setTestDeviceIds_Ljava_util_List_;
		}
	}
}
