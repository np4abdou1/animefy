using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.OS;
using Android.Runtime;
using Com.Applovin.Sdk;
using Java.Interop;
using Java.Lang;
using Org.Json;

namespace Com.Applovin.Impl.Sdk.AD
{
	// Token: 0x02000151 RID: 337
	[Register("com/applovin/impl/sdk/ad/AppLovinAdImpl", DoNotGenerateAcw = true)]
	public abstract class AppLovinAdImpl : AppLovinAdBase, IAppLovinAd, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x17000421 RID: 1057
		// (get) Token: 0x0600103B RID: 4155 RVA: 0x0002F414 File Offset: 0x0002D614
		internal new static IntPtr class_ref
		{
			get
			{
				return AppLovinAdImpl._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000422 RID: 1058
		// (get) Token: 0x0600103C RID: 4156 RVA: 0x0002F438 File Offset: 0x0002D638
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return AppLovinAdImpl._members;
			}
		}

		// Token: 0x17000423 RID: 1059
		// (get) Token: 0x0600103D RID: 4157 RVA: 0x0002F440 File Offset: 0x0002D640
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return AppLovinAdImpl._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000424 RID: 1060
		// (get) Token: 0x0600103E RID: 4158 RVA: 0x0002F464 File Offset: 0x0002D664
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return AppLovinAdImpl._members.ManagedPeerType;
			}
		}

		// Token: 0x0600103F RID: 4159 RVA: 0x00024427 File Offset: 0x00022627
		protected AppLovinAdImpl(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06001040 RID: 4160 RVA: 0x0002F470 File Offset: 0x0002D670
		private static Delegate GetGetAdIdNumberHandler()
		{
			if (AppLovinAdImpl.cb_getAdIdNumber == null)
			{
				AppLovinAdImpl.cb_getAdIdNumber = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_J(AppLovinAdImpl.n_GetAdIdNumber));
			}
			return AppLovinAdImpl.cb_getAdIdNumber;
		}

		// Token: 0x06001041 RID: 4161 RVA: 0x0002F494 File Offset: 0x0002D694
		private static long n_GetAdIdNumber(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<AppLovinAdImpl>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).AdIdNumber;
		}

		// Token: 0x17000425 RID: 1061
		// (get) Token: 0x06001042 RID: 4162 RVA: 0x0002F4A3 File Offset: 0x0002D6A3
		public override long AdIdNumber
		{
			[Register("getAdIdNumber", "()J", "GetGetAdIdNumberHandler")]
			get
			{
				return AppLovinAdImpl._members.InstanceMethods.InvokeVirtualInt64Method("getAdIdNumber.()J", this, null);
			}
		}

		// Token: 0x06001043 RID: 4163 RVA: 0x0002F4BC File Offset: 0x0002D6BC
		private static Delegate GetHasShownHandler()
		{
			if (AppLovinAdImpl.cb_hasShown == null)
			{
				AppLovinAdImpl.cb_hasShown = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(AppLovinAdImpl.n_HasShown));
			}
			return AppLovinAdImpl.cb_hasShown;
		}

		// Token: 0x06001044 RID: 4164 RVA: 0x0002F4E0 File Offset: 0x0002D6E0
		private static bool n_HasShown(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<AppLovinAdImpl>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).HasShown;
		}

		// Token: 0x06001045 RID: 4165 RVA: 0x0002F4EF File Offset: 0x0002D6EF
		private static Delegate GetSetHasShown_ZHandler()
		{
			if (AppLovinAdImpl.cb_setHasShown_Z == null)
			{
				AppLovinAdImpl.cb_setHasShown_Z = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPZ_V(AppLovinAdImpl.n_SetHasShown_Z));
			}
			return AppLovinAdImpl.cb_setHasShown_Z;
		}

		// Token: 0x06001046 RID: 4166 RVA: 0x0002F513 File Offset: 0x0002D713
		private static void n_SetHasShown_Z(IntPtr jnienv, IntPtr native__this, bool p0)
		{
			Java.Lang.Object.GetObject<AppLovinAdImpl>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).HasShown = p0;
		}

		// Token: 0x17000426 RID: 1062
		// (get) Token: 0x06001047 RID: 4167 RVA: 0x0002F523 File Offset: 0x0002D723
		// (set) Token: 0x06001048 RID: 4168 RVA: 0x0002F53C File Offset: 0x0002D73C
		public unsafe virtual bool HasShown
		{
			[Register("hasShown", "()Z", "GetHasShownHandler")]
			get
			{
				return AppLovinAdImpl._members.InstanceMethods.InvokeVirtualBooleanMethod("hasShown.()Z", this, null);
			}
			[Register("setHasShown", "(Z)V", "GetSetHasShown_ZHandler")]
			set
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(value);
				AppLovinAdImpl._members.InstanceMethods.InvokeVirtualVoidMethod("setHasShown.(Z)V", this, ptr);
			}
		}

		// Token: 0x06001049 RID: 4169 RVA: 0x0002F577 File Offset: 0x0002D777
		private static Delegate GetHasVideoUrlHandler()
		{
			if (AppLovinAdImpl.cb_hasVideoUrl == null)
			{
				AppLovinAdImpl.cb_hasVideoUrl = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(AppLovinAdImpl.n_HasVideoUrl));
			}
			return AppLovinAdImpl.cb_hasVideoUrl;
		}

		// Token: 0x0600104A RID: 4170 RVA: 0x0002F59B File Offset: 0x0002D79B
		private static bool n_HasVideoUrl(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<AppLovinAdImpl>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).HasVideoUrl;
		}

		// Token: 0x17000427 RID: 1063
		// (get) Token: 0x0600104B RID: 4171 RVA: 0x0002F5AA File Offset: 0x0002D7AA
		public virtual bool HasVideoUrl
		{
			[Register("hasVideoUrl", "()Z", "GetHasVideoUrlHandler")]
			get
			{
				return AppLovinAdImpl._members.InstanceMethods.InvokeVirtualBooleanMethod("hasVideoUrl.()Z", this, null);
			}
		}

		// Token: 0x0600104C RID: 4172 RVA: 0x0002F5C3 File Offset: 0x0002D7C3
		private static Delegate GetIsVideoAdHandler()
		{
			if (AppLovinAdImpl.cb_isVideoAd == null)
			{
				AppLovinAdImpl.cb_isVideoAd = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(AppLovinAdImpl.n_IsVideoAd));
			}
			return AppLovinAdImpl.cb_isVideoAd;
		}

		// Token: 0x0600104D RID: 4173 RVA: 0x0002F5E7 File Offset: 0x0002D7E7
		private static bool n_IsVideoAd(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<AppLovinAdImpl>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).IsVideoAd;
		}

		// Token: 0x17000428 RID: 1064
		// (get) Token: 0x0600104E RID: 4174 RVA: 0x0002F5F6 File Offset: 0x0002D7F6
		public virtual bool IsVideoAd
		{
			[Register("isVideoAd", "()Z", "GetIsVideoAdHandler")]
			get
			{
				return AppLovinAdImpl._members.InstanceMethods.InvokeVirtualBooleanMethod("isVideoAd.()Z", this, null);
			}
		}

		// Token: 0x0600104F RID: 4175 RVA: 0x0002F60F File Offset: 0x0002D80F
		private static Delegate GetGetMAXAdValuesHandler()
		{
			if (AppLovinAdImpl.cb_getMAXAdValues == null)
			{
				AppLovinAdImpl.cb_getMAXAdValues = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(AppLovinAdImpl.n_GetMAXAdValues));
			}
			return AppLovinAdImpl.cb_getMAXAdValues;
		}

		// Token: 0x06001050 RID: 4176 RVA: 0x0002F633 File Offset: 0x0002D833
		private static IntPtr n_GetMAXAdValues(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<AppLovinAdImpl>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).MAXAdValues);
		}

		// Token: 0x17000429 RID: 1065
		// (get) Token: 0x06001051 RID: 4177 RVA: 0x0002F648 File Offset: 0x0002D848
		public virtual Bundle MAXAdValues
		{
			[Register("getMAXAdValues", "()Landroid/os/Bundle;", "GetGetMAXAdValuesHandler")]
			get
			{
				return Java.Lang.Object.GetObject<Bundle>(AppLovinAdImpl._members.InstanceMethods.InvokeVirtualObjectMethod("getMAXAdValues.()Landroid/os/Bundle;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x06001052 RID: 4178 RVA: 0x0002F67A File Offset: 0x0002D87A
		private static Delegate GetGetOriginalFullResponseHandler()
		{
			if (AppLovinAdImpl.cb_getOriginalFullResponse == null)
			{
				AppLovinAdImpl.cb_getOriginalFullResponse = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(AppLovinAdImpl.n_GetOriginalFullResponse));
			}
			return AppLovinAdImpl.cb_getOriginalFullResponse;
		}

		// Token: 0x06001053 RID: 4179 RVA: 0x0002F69E File Offset: 0x0002D89E
		private static IntPtr n_GetOriginalFullResponse(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<AppLovinAdImpl>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).OriginalFullResponse);
		}

		// Token: 0x1700042A RID: 1066
		// (get) Token: 0x06001054 RID: 4180
		public abstract JSONObject OriginalFullResponse { [Register("getOriginalFullResponse", "()Lorg/json/JSONObject;", "GetGetOriginalFullResponseHandler")] get; }

		// Token: 0x06001055 RID: 4181 RVA: 0x0002F6B2 File Offset: 0x0002D8B2
		private static Delegate GetGetRawFullResponseHandler()
		{
			if (AppLovinAdImpl.cb_getRawFullResponse == null)
			{
				AppLovinAdImpl.cb_getRawFullResponse = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(AppLovinAdImpl.n_GetRawFullResponse));
			}
			return AppLovinAdImpl.cb_getRawFullResponse;
		}

		// Token: 0x06001056 RID: 4182 RVA: 0x0002F6D6 File Offset: 0x0002D8D6
		private static IntPtr n_GetRawFullResponse(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.NewString(Java.Lang.Object.GetObject<AppLovinAdImpl>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).RawFullResponse);
		}

		// Token: 0x1700042B RID: 1067
		// (get) Token: 0x06001057 RID: 4183 RVA: 0x0002F6EC File Offset: 0x0002D8EC
		public virtual string RawFullResponse
		{
			[Register("getRawFullResponse", "()Ljava/lang/String;", "GetGetRawFullResponseHandler")]
			get
			{
				return JNIEnv.GetString(AppLovinAdImpl._members.InstanceMethods.InvokeVirtualObjectMethod("getRawFullResponse.()Ljava/lang/String;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x06001058 RID: 4184 RVA: 0x0002F71E File Offset: 0x0002D91E
		private static Delegate GetGetSizeHandler()
		{
			if (AppLovinAdImpl.cb_getSize == null)
			{
				AppLovinAdImpl.cb_getSize = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(AppLovinAdImpl.n_GetSize));
			}
			return AppLovinAdImpl.cb_getSize;
		}

		// Token: 0x06001059 RID: 4185 RVA: 0x0002F742 File Offset: 0x0002D942
		private static IntPtr n_GetSize(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<AppLovinAdImpl>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Size);
		}

		// Token: 0x1700042C RID: 1068
		// (get) Token: 0x0600105A RID: 4186 RVA: 0x0002F758 File Offset: 0x0002D958
		public virtual AppLovinAdSize Size
		{
			[Register("getSize", "()Lcom/applovin/sdk/AppLovinAdSize;", "GetGetSizeHandler")]
			get
			{
				return Java.Lang.Object.GetObject<AppLovinAdSize>(AppLovinAdImpl._members.InstanceMethods.InvokeVirtualObjectMethod("getSize.()Lcom/applovin/sdk/AppLovinAdSize;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x0600105B RID: 4187 RVA: 0x0002F78A File Offset: 0x0002D98A
		private static Delegate GetGetTypeHandler()
		{
			if (AppLovinAdImpl.cb_getType == null)
			{
				AppLovinAdImpl.cb_getType = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(AppLovinAdImpl.n_GetType));
			}
			return AppLovinAdImpl.cb_getType;
		}

		// Token: 0x0600105C RID: 4188 RVA: 0x0002F7AE File Offset: 0x0002D9AE
		private static IntPtr n_GetType(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<AppLovinAdImpl>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Type);
		}

		// Token: 0x1700042D RID: 1069
		// (get) Token: 0x0600105D RID: 4189 RVA: 0x0002F7C4 File Offset: 0x0002D9C4
		public virtual AppLovinAdType Type
		{
			[Register("getType", "()Lcom/applovin/sdk/AppLovinAdType;", "GetGetTypeHandler")]
			get
			{
				return Java.Lang.Object.GetObject<AppLovinAdType>(AppLovinAdImpl._members.InstanceMethods.InvokeVirtualObjectMethod("getType.()Lcom/applovin/sdk/AppLovinAdType;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x0600105E RID: 4190 RVA: 0x0002F7F6 File Offset: 0x0002D9F6
		private static Delegate GetGetZoneIdHandler()
		{
			if (AppLovinAdImpl.cb_getZoneId == null)
			{
				AppLovinAdImpl.cb_getZoneId = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(AppLovinAdImpl.n_GetZoneId));
			}
			return AppLovinAdImpl.cb_getZoneId;
		}

		// Token: 0x0600105F RID: 4191 RVA: 0x0002F81A File Offset: 0x0002DA1A
		private static IntPtr n_GetZoneId(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.NewString(Java.Lang.Object.GetObject<AppLovinAdImpl>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ZoneId);
		}

		// Token: 0x1700042E RID: 1070
		// (get) Token: 0x06001060 RID: 4192 RVA: 0x0002F830 File Offset: 0x0002DA30
		public virtual string ZoneId
		{
			[Register("getZoneId", "()Ljava/lang/String;", "GetGetZoneIdHandler")]
			get
			{
				return JNIEnv.GetString(AppLovinAdImpl._members.InstanceMethods.InvokeVirtualObjectMethod("getZoneId.()Ljava/lang/String;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x06001061 RID: 4193 RVA: 0x0002F862 File Offset: 0x0002DA62
		private static Delegate GetGetAdValue_Ljava_lang_String_Handler()
		{
			if (AppLovinAdImpl.cb_getAdValue_Ljava_lang_String_ == null)
			{
				AppLovinAdImpl.cb_getAdValue_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(AppLovinAdImpl.n_GetAdValue_Ljava_lang_String_));
			}
			return AppLovinAdImpl.cb_getAdValue_Ljava_lang_String_;
		}

		// Token: 0x06001062 RID: 4194 RVA: 0x0002F888 File Offset: 0x0002DA88
		private static IntPtr n_GetAdValue_Ljava_lang_String_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			AppLovinAdImpl @object = Java.Lang.Object.GetObject<AppLovinAdImpl>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string @string = JNIEnv.GetString(native_p0, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString(@object.GetAdValue(@string));
		}

		// Token: 0x06001063 RID: 4195 RVA: 0x0002F8B0 File Offset: 0x0002DAB0
		[Register("getAdValue", "(Ljava/lang/String;)Ljava/lang/String;", "GetGetAdValue_Ljava_lang_String_Handler")]
		public unsafe virtual string GetAdValue(string p0)
		{
			IntPtr intPtr = JNIEnv.NewString(p0);
			string @string;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				@string = JNIEnv.GetString(AppLovinAdImpl._members.InstanceMethods.InvokeVirtualObjectMethod("getAdValue.(Ljava/lang/String;)Ljava/lang/String;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
			}
			return @string;
		}

		// Token: 0x06001064 RID: 4196 RVA: 0x0002F91C File Offset: 0x0002DB1C
		private static Delegate GetGetAdValue_Ljava_lang_String_Ljava_lang_String_Handler()
		{
			if (AppLovinAdImpl.cb_getAdValue_Ljava_lang_String_Ljava_lang_String_ == null)
			{
				AppLovinAdImpl.cb_getAdValue_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_L(AppLovinAdImpl.n_GetAdValue_Ljava_lang_String_Ljava_lang_String_));
			}
			return AppLovinAdImpl.cb_getAdValue_Ljava_lang_String_Ljava_lang_String_;
		}

		// Token: 0x06001065 RID: 4197 RVA: 0x0002F940 File Offset: 0x0002DB40
		private static IntPtr n_GetAdValue_Ljava_lang_String_Ljava_lang_String_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			AppLovinAdImpl @object = Java.Lang.Object.GetObject<AppLovinAdImpl>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string @string = JNIEnv.GetString(native_p0, JniHandleOwnership.DoNotTransfer);
			string string2 = JNIEnv.GetString(native_p1, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString(@object.GetAdValue(@string, string2));
		}

		// Token: 0x06001066 RID: 4198 RVA: 0x0002F974 File Offset: 0x0002DB74
		[Register("getAdValue", "(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;", "GetGetAdValue_Ljava_lang_String_Ljava_lang_String_Handler")]
		public unsafe virtual string GetAdValue(string p0, string p1)
		{
			IntPtr intPtr = JNIEnv.NewString(p0);
			IntPtr intPtr2 = JNIEnv.NewString(p1);
			string @string;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue(intPtr2);
				@string = JNIEnv.GetString(AppLovinAdImpl._members.InstanceMethods.InvokeVirtualObjectMethod("getAdValue.(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				JNIEnv.DeleteLocalRef(intPtr2);
			}
			return @string;
		}

		// Token: 0x06001067 RID: 4199 RVA: 0x0002FA04 File Offset: 0x0002DC04
		private static Delegate GetSetMaxAdValue_Ljava_lang_String_Ljava_lang_Object_Handler()
		{
			if (AppLovinAdImpl.cb_setMaxAdValue_Ljava_lang_String_Ljava_lang_Object_ == null)
			{
				AppLovinAdImpl.cb_setMaxAdValue_Ljava_lang_String_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_V(AppLovinAdImpl.n_SetMaxAdValue_Ljava_lang_String_Ljava_lang_Object_));
			}
			return AppLovinAdImpl.cb_setMaxAdValue_Ljava_lang_String_Ljava_lang_Object_;
		}

		// Token: 0x06001068 RID: 4200 RVA: 0x0002FA28 File Offset: 0x0002DC28
		private static void n_SetMaxAdValue_Ljava_lang_String_Ljava_lang_Object_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			AppLovinAdImpl @object = Java.Lang.Object.GetObject<AppLovinAdImpl>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string @string = JNIEnv.GetString(native_p0, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object2 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_p1, JniHandleOwnership.DoNotTransfer);
			@object.SetMaxAdValue(@string, object2);
		}

		// Token: 0x06001069 RID: 4201 RVA: 0x0002FA54 File Offset: 0x0002DC54
		[Register("setMaxAdValue", "(Ljava/lang/String;Ljava/lang/Object;)V", "GetSetMaxAdValue_Ljava_lang_String_Ljava_lang_Object_Handler")]
		public unsafe virtual void SetMaxAdValue(string p0, Java.Lang.Object p1)
		{
			IntPtr intPtr = JNIEnv.NewString(p0);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue((p1 == null) ? IntPtr.Zero : p1.Handle);
				AppLovinAdImpl._members.InstanceMethods.InvokeVirtualVoidMethod("setMaxAdValue.(Ljava/lang/String;Ljava/lang/Object;)V", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(p1);
			}
		}

		// Token: 0x0600106A RID: 4202 RVA: 0x0002FAD8 File Offset: 0x0002DCD8
		private static Delegate GetShouldCancelHtmlCachingIfShownHandler()
		{
			if (AppLovinAdImpl.cb_shouldCancelHtmlCachingIfShown == null)
			{
				AppLovinAdImpl.cb_shouldCancelHtmlCachingIfShown = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(AppLovinAdImpl.n_ShouldCancelHtmlCachingIfShown));
			}
			return AppLovinAdImpl.cb_shouldCancelHtmlCachingIfShown;
		}

		// Token: 0x0600106B RID: 4203 RVA: 0x0002FAFC File Offset: 0x0002DCFC
		private static bool n_ShouldCancelHtmlCachingIfShown(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<AppLovinAdImpl>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ShouldCancelHtmlCachingIfShown();
		}

		// Token: 0x0600106C RID: 4204 RVA: 0x0002FB0B File Offset: 0x0002DD0B
		[Register("shouldCancelHtmlCachingIfShown", "()Z", "GetShouldCancelHtmlCachingIfShownHandler")]
		public virtual bool ShouldCancelHtmlCachingIfShown()
		{
			return AppLovinAdImpl._members.InstanceMethods.InvokeVirtualBooleanMethod("shouldCancelHtmlCachingIfShown.()Z", this, null);
		}

		// Token: 0x0400055F RID: 1375
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/applovin/impl/sdk/ad/AppLovinAdImpl", typeof(AppLovinAdImpl));

		// Token: 0x04000560 RID: 1376
		private static Delegate cb_getAdIdNumber;

		// Token: 0x04000561 RID: 1377
		private static Delegate cb_hasShown;

		// Token: 0x04000562 RID: 1378
		private static Delegate cb_setHasShown_Z;

		// Token: 0x04000563 RID: 1379
		private static Delegate cb_hasVideoUrl;

		// Token: 0x04000564 RID: 1380
		private static Delegate cb_isVideoAd;

		// Token: 0x04000565 RID: 1381
		private static Delegate cb_getMAXAdValues;

		// Token: 0x04000566 RID: 1382
		private static Delegate cb_getOriginalFullResponse;

		// Token: 0x04000567 RID: 1383
		private static Delegate cb_getRawFullResponse;

		// Token: 0x04000568 RID: 1384
		private static Delegate cb_getSize;

		// Token: 0x04000569 RID: 1385
		private static Delegate cb_getType;

		// Token: 0x0400056A RID: 1386
		private static Delegate cb_getZoneId;

		// Token: 0x0400056B RID: 1387
		private static Delegate cb_getAdValue_Ljava_lang_String_;

		// Token: 0x0400056C RID: 1388
		private static Delegate cb_getAdValue_Ljava_lang_String_Ljava_lang_String_;

		// Token: 0x0400056D RID: 1389
		private static Delegate cb_setMaxAdValue_Ljava_lang_String_Ljava_lang_Object_;

		// Token: 0x0400056E RID: 1390
		private static Delegate cb_shouldCancelHtmlCachingIfShown;
	}
}
