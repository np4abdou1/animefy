using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Com.Applovin.Sdk
{
	// Token: 0x02000092 RID: 146
	[Register("com/applovin/sdk/AppLovinTargetingData", DoNotGenerateAcw = true)]
	internal class IAppLovinTargetingDataInvoker : Java.Lang.Object, IAppLovinTargetingData, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x1700017E RID: 382
		// (get) Token: 0x060004C4 RID: 1220 RVA: 0x0000C890 File Offset: 0x0000AA90
		private static IntPtr java_class_ref
		{
			get
			{
				return IAppLovinTargetingDataInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700017F RID: 383
		// (get) Token: 0x060004C5 RID: 1221 RVA: 0x0000C8B4 File Offset: 0x0000AAB4
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return IAppLovinTargetingDataInvoker._members;
			}
		}

		// Token: 0x17000180 RID: 384
		// (get) Token: 0x060004C6 RID: 1222 RVA: 0x0000C8BB File Offset: 0x0000AABB
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x17000181 RID: 385
		// (get) Token: 0x060004C7 RID: 1223 RVA: 0x0000C8C3 File Offset: 0x0000AAC3
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return IAppLovinTargetingDataInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x060004C8 RID: 1224 RVA: 0x0000C8CF File Offset: 0x0000AACF
		public static IAppLovinTargetingData GetObject(IntPtr handle, JniHandleOwnership transfer)
		{
			return Java.Lang.Object.GetObject<IAppLovinTargetingData>(handle, transfer);
		}

		// Token: 0x060004C9 RID: 1225 RVA: 0x0000C8D8 File Offset: 0x0000AAD8
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, IAppLovinTargetingDataInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'com.applovin.sdk.AppLovinTargetingData'.");
			}
			return handle;
		}

		// Token: 0x060004CA RID: 1226 RVA: 0x0000C903 File Offset: 0x0000AB03
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x060004CB RID: 1227 RVA: 0x0000C934 File Offset: 0x0000AB34
		public IAppLovinTargetingDataInvoker(IntPtr handle, JniHandleOwnership transfer) : base(IAppLovinTargetingDataInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x060004CC RID: 1228 RVA: 0x0000C96C File Offset: 0x0000AB6C
		private static Delegate GetGetEmailHandler()
		{
			if (IAppLovinTargetingDataInvoker.cb_getEmail == null)
			{
				IAppLovinTargetingDataInvoker.cb_getEmail = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IAppLovinTargetingDataInvoker.n_GetEmail));
			}
			return IAppLovinTargetingDataInvoker.cb_getEmail;
		}

		// Token: 0x060004CD RID: 1229 RVA: 0x0000C990 File Offset: 0x0000AB90
		private static IntPtr n_GetEmail(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.NewString(Java.Lang.Object.GetObject<IAppLovinTargetingData>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Email);
		}

		// Token: 0x060004CE RID: 1230 RVA: 0x0000C9A4 File Offset: 0x0000ABA4
		private static Delegate GetSetEmail_Ljava_lang_String_Handler()
		{
			if (IAppLovinTargetingDataInvoker.cb_setEmail_Ljava_lang_String_ == null)
			{
				IAppLovinTargetingDataInvoker.cb_setEmail_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(IAppLovinTargetingDataInvoker.n_SetEmail_Ljava_lang_String_));
			}
			return IAppLovinTargetingDataInvoker.cb_setEmail_Ljava_lang_String_;
		}

		// Token: 0x060004CF RID: 1231 RVA: 0x0000C9C8 File Offset: 0x0000ABC8
		private static void n_SetEmail_Ljava_lang_String_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			IAppLovinTargetingData @object = Java.Lang.Object.GetObject<IAppLovinTargetingData>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string @string = JNIEnv.GetString(native_p0, JniHandleOwnership.DoNotTransfer);
			@object.Email = @string;
		}

		// Token: 0x17000182 RID: 386
		// (get) Token: 0x060004D0 RID: 1232 RVA: 0x0000C9EC File Offset: 0x0000ABEC
		// (set) Token: 0x060004D1 RID: 1233 RVA: 0x0000CA40 File Offset: 0x0000AC40
		public unsafe string Email
		{
			get
			{
				if (this.id_getEmail == IntPtr.Zero)
				{
					this.id_getEmail = JNIEnv.GetMethodID(this.class_ref, "getEmail", "()Ljava/lang/String;");
				}
				return JNIEnv.GetString(JNIEnv.CallObjectMethod(base.Handle, this.id_getEmail), JniHandleOwnership.TransferLocalRef);
			}
			set
			{
				if (this.id_setEmail_Ljava_lang_String_ == IntPtr.Zero)
				{
					this.id_setEmail_Ljava_lang_String_ = JNIEnv.GetMethodID(this.class_ref, "setEmail", "(Ljava/lang/String;)V");
				}
				IntPtr intPtr = JNIEnv.NewString(value);
				JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
				*ptr = new JValue(intPtr);
				JNIEnv.CallVoidMethod(base.Handle, this.id_setEmail_Ljava_lang_String_, ptr);
				JNIEnv.DeleteLocalRef(intPtr);
			}
		}

		// Token: 0x060004D2 RID: 1234 RVA: 0x0000CAB1 File Offset: 0x0000ACB1
		private static Delegate GetGetGenderHandler()
		{
			if (IAppLovinTargetingDataInvoker.cb_getGender == null)
			{
				IAppLovinTargetingDataInvoker.cb_getGender = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IAppLovinTargetingDataInvoker.n_GetGender));
			}
			return IAppLovinTargetingDataInvoker.cb_getGender;
		}

		// Token: 0x060004D3 RID: 1235 RVA: 0x0000CAD5 File Offset: 0x0000ACD5
		private static IntPtr n_GetGender(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<IAppLovinTargetingData>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Gender);
		}

		// Token: 0x060004D4 RID: 1236 RVA: 0x0000CAE9 File Offset: 0x0000ACE9
		private static Delegate GetSetGender_Lcom_applovin_sdk_AppLovinGender_Handler()
		{
			if (IAppLovinTargetingDataInvoker.cb_setGender_Lcom_applovin_sdk_AppLovinGender_ == null)
			{
				IAppLovinTargetingDataInvoker.cb_setGender_Lcom_applovin_sdk_AppLovinGender_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(IAppLovinTargetingDataInvoker.n_SetGender_Lcom_applovin_sdk_AppLovinGender_));
			}
			return IAppLovinTargetingDataInvoker.cb_setGender_Lcom_applovin_sdk_AppLovinGender_;
		}

		// Token: 0x060004D5 RID: 1237 RVA: 0x0000CB10 File Offset: 0x0000AD10
		private static void n_SetGender_Lcom_applovin_sdk_AppLovinGender_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			IAppLovinTargetingData @object = Java.Lang.Object.GetObject<IAppLovinTargetingData>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			AppLovinGender object2 = Java.Lang.Object.GetObject<AppLovinGender>(native_p0, JniHandleOwnership.DoNotTransfer);
			@object.Gender = object2;
		}

		// Token: 0x17000183 RID: 387
		// (get) Token: 0x060004D6 RID: 1238 RVA: 0x0000CB34 File Offset: 0x0000AD34
		// (set) Token: 0x060004D7 RID: 1239 RVA: 0x0000CB88 File Offset: 0x0000AD88
		public unsafe AppLovinGender Gender
		{
			get
			{
				if (this.id_getGender == IntPtr.Zero)
				{
					this.id_getGender = JNIEnv.GetMethodID(this.class_ref, "getGender", "()Lcom/applovin/sdk/AppLovinGender;");
				}
				return Java.Lang.Object.GetObject<AppLovinGender>(JNIEnv.CallObjectMethod(base.Handle, this.id_getGender), JniHandleOwnership.TransferLocalRef);
			}
			set
			{
				if (this.id_setGender_Lcom_applovin_sdk_AppLovinGender_ == IntPtr.Zero)
				{
					this.id_setGender_Lcom_applovin_sdk_AppLovinGender_ = JNIEnv.GetMethodID(this.class_ref, "setGender", "(Lcom/applovin/sdk/AppLovinGender;)V");
				}
				JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
				*ptr = new JValue((value == null) ? IntPtr.Zero : value.Handle);
				JNIEnv.CallVoidMethod(base.Handle, this.id_setGender_Lcom_applovin_sdk_AppLovinGender_, ptr);
			}
		}

		// Token: 0x060004D8 RID: 1240 RVA: 0x0000CBFB File Offset: 0x0000ADFB
		private static Delegate GetGetInterestsHandler()
		{
			if (IAppLovinTargetingDataInvoker.cb_getInterests == null)
			{
				IAppLovinTargetingDataInvoker.cb_getInterests = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IAppLovinTargetingDataInvoker.n_GetInterests));
			}
			return IAppLovinTargetingDataInvoker.cb_getInterests;
		}

		// Token: 0x060004D9 RID: 1241 RVA: 0x0000CC1F File Offset: 0x0000AE1F
		private static IntPtr n_GetInterests(IntPtr jnienv, IntPtr native__this)
		{
			return JavaList<string>.ToLocalJniHandle(Java.Lang.Object.GetObject<IAppLovinTargetingData>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Interests);
		}

		// Token: 0x060004DA RID: 1242 RVA: 0x0000CC33 File Offset: 0x0000AE33
		private static Delegate GetSetInterests_Ljava_util_List_Handler()
		{
			if (IAppLovinTargetingDataInvoker.cb_setInterests_Ljava_util_List_ == null)
			{
				IAppLovinTargetingDataInvoker.cb_setInterests_Ljava_util_List_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(IAppLovinTargetingDataInvoker.n_SetInterests_Ljava_util_List_));
			}
			return IAppLovinTargetingDataInvoker.cb_setInterests_Ljava_util_List_;
		}

		// Token: 0x060004DB RID: 1243 RVA: 0x0000CC58 File Offset: 0x0000AE58
		private static void n_SetInterests_Ljava_util_List_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			IAppLovinTargetingData @object = Java.Lang.Object.GetObject<IAppLovinTargetingData>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			IList<string> interests = JavaList<string>.FromJniHandle(native_p0, JniHandleOwnership.DoNotTransfer);
			@object.Interests = interests;
		}

		// Token: 0x17000184 RID: 388
		// (get) Token: 0x060004DC RID: 1244 RVA: 0x0000CC7C File Offset: 0x0000AE7C
		// (set) Token: 0x060004DD RID: 1245 RVA: 0x0000CCD0 File Offset: 0x0000AED0
		public unsafe IList<string> Interests
		{
			get
			{
				if (this.id_getInterests == IntPtr.Zero)
				{
					this.id_getInterests = JNIEnv.GetMethodID(this.class_ref, "getInterests", "()Ljava/util/List;");
				}
				return JavaList<string>.FromJniHandle(JNIEnv.CallObjectMethod(base.Handle, this.id_getInterests), JniHandleOwnership.TransferLocalRef);
			}
			set
			{
				if (this.id_setInterests_Ljava_util_List_ == IntPtr.Zero)
				{
					this.id_setInterests_Ljava_util_List_ = JNIEnv.GetMethodID(this.class_ref, "setInterests", "(Ljava/util/List;)V");
				}
				IntPtr intPtr = JavaList<string>.ToLocalJniHandle(value);
				JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
				*ptr = new JValue(intPtr);
				JNIEnv.CallVoidMethod(base.Handle, this.id_setInterests_Ljava_util_List_, ptr);
				JNIEnv.DeleteLocalRef(intPtr);
			}
		}

		// Token: 0x060004DE RID: 1246 RVA: 0x0000CD41 File Offset: 0x0000AF41
		private static Delegate GetGetKeywordsHandler()
		{
			if (IAppLovinTargetingDataInvoker.cb_getKeywords == null)
			{
				IAppLovinTargetingDataInvoker.cb_getKeywords = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IAppLovinTargetingDataInvoker.n_GetKeywords));
			}
			return IAppLovinTargetingDataInvoker.cb_getKeywords;
		}

		// Token: 0x060004DF RID: 1247 RVA: 0x0000CD65 File Offset: 0x0000AF65
		private static IntPtr n_GetKeywords(IntPtr jnienv, IntPtr native__this)
		{
			return JavaList<string>.ToLocalJniHandle(Java.Lang.Object.GetObject<IAppLovinTargetingData>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Keywords);
		}

		// Token: 0x060004E0 RID: 1248 RVA: 0x0000CD79 File Offset: 0x0000AF79
		private static Delegate GetSetKeywords_Ljava_util_List_Handler()
		{
			if (IAppLovinTargetingDataInvoker.cb_setKeywords_Ljava_util_List_ == null)
			{
				IAppLovinTargetingDataInvoker.cb_setKeywords_Ljava_util_List_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(IAppLovinTargetingDataInvoker.n_SetKeywords_Ljava_util_List_));
			}
			return IAppLovinTargetingDataInvoker.cb_setKeywords_Ljava_util_List_;
		}

		// Token: 0x060004E1 RID: 1249 RVA: 0x0000CDA0 File Offset: 0x0000AFA0
		private static void n_SetKeywords_Ljava_util_List_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			IAppLovinTargetingData @object = Java.Lang.Object.GetObject<IAppLovinTargetingData>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			IList<string> keywords = JavaList<string>.FromJniHandle(native_p0, JniHandleOwnership.DoNotTransfer);
			@object.Keywords = keywords;
		}

		// Token: 0x17000185 RID: 389
		// (get) Token: 0x060004E2 RID: 1250 RVA: 0x0000CDC4 File Offset: 0x0000AFC4
		// (set) Token: 0x060004E3 RID: 1251 RVA: 0x0000CE18 File Offset: 0x0000B018
		public unsafe IList<string> Keywords
		{
			get
			{
				if (this.id_getKeywords == IntPtr.Zero)
				{
					this.id_getKeywords = JNIEnv.GetMethodID(this.class_ref, "getKeywords", "()Ljava/util/List;");
				}
				return JavaList<string>.FromJniHandle(JNIEnv.CallObjectMethod(base.Handle, this.id_getKeywords), JniHandleOwnership.TransferLocalRef);
			}
			set
			{
				if (this.id_setKeywords_Ljava_util_List_ == IntPtr.Zero)
				{
					this.id_setKeywords_Ljava_util_List_ = JNIEnv.GetMethodID(this.class_ref, "setKeywords", "(Ljava/util/List;)V");
				}
				IntPtr intPtr = JavaList<string>.ToLocalJniHandle(value);
				JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
				*ptr = new JValue(intPtr);
				JNIEnv.CallVoidMethod(base.Handle, this.id_setKeywords_Ljava_util_List_, ptr);
				JNIEnv.DeleteLocalRef(intPtr);
			}
		}

		// Token: 0x060004E4 RID: 1252 RVA: 0x0000CE89 File Offset: 0x0000B089
		private static Delegate GetGetMaximumAdContentRatingHandler()
		{
			if (IAppLovinTargetingDataInvoker.cb_getMaximumAdContentRating == null)
			{
				IAppLovinTargetingDataInvoker.cb_getMaximumAdContentRating = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IAppLovinTargetingDataInvoker.n_GetMaximumAdContentRating));
			}
			return IAppLovinTargetingDataInvoker.cb_getMaximumAdContentRating;
		}

		// Token: 0x060004E5 RID: 1253 RVA: 0x0000CEAD File Offset: 0x0000B0AD
		private static IntPtr n_GetMaximumAdContentRating(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<IAppLovinTargetingData>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).MaximumAdContentRating);
		}

		// Token: 0x060004E6 RID: 1254 RVA: 0x0000CEC1 File Offset: 0x0000B0C1
		private static Delegate GetSetMaximumAdContentRating_Lcom_applovin_sdk_AppLovinAdContentRating_Handler()
		{
			if (IAppLovinTargetingDataInvoker.cb_setMaximumAdContentRating_Lcom_applovin_sdk_AppLovinAdContentRating_ == null)
			{
				IAppLovinTargetingDataInvoker.cb_setMaximumAdContentRating_Lcom_applovin_sdk_AppLovinAdContentRating_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(IAppLovinTargetingDataInvoker.n_SetMaximumAdContentRating_Lcom_applovin_sdk_AppLovinAdContentRating_));
			}
			return IAppLovinTargetingDataInvoker.cb_setMaximumAdContentRating_Lcom_applovin_sdk_AppLovinAdContentRating_;
		}

		// Token: 0x060004E7 RID: 1255 RVA: 0x0000CEE8 File Offset: 0x0000B0E8
		private static void n_SetMaximumAdContentRating_Lcom_applovin_sdk_AppLovinAdContentRating_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			IAppLovinTargetingData @object = Java.Lang.Object.GetObject<IAppLovinTargetingData>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			AppLovinAdContentRating object2 = Java.Lang.Object.GetObject<AppLovinAdContentRating>(native_p0, JniHandleOwnership.DoNotTransfer);
			@object.MaximumAdContentRating = object2;
		}

		// Token: 0x17000186 RID: 390
		// (get) Token: 0x060004E8 RID: 1256 RVA: 0x0000CF0C File Offset: 0x0000B10C
		// (set) Token: 0x060004E9 RID: 1257 RVA: 0x0000CF60 File Offset: 0x0000B160
		public unsafe AppLovinAdContentRating MaximumAdContentRating
		{
			get
			{
				if (this.id_getMaximumAdContentRating == IntPtr.Zero)
				{
					this.id_getMaximumAdContentRating = JNIEnv.GetMethodID(this.class_ref, "getMaximumAdContentRating", "()Lcom/applovin/sdk/AppLovinAdContentRating;");
				}
				return Java.Lang.Object.GetObject<AppLovinAdContentRating>(JNIEnv.CallObjectMethod(base.Handle, this.id_getMaximumAdContentRating), JniHandleOwnership.TransferLocalRef);
			}
			set
			{
				if (this.id_setMaximumAdContentRating_Lcom_applovin_sdk_AppLovinAdContentRating_ == IntPtr.Zero)
				{
					this.id_setMaximumAdContentRating_Lcom_applovin_sdk_AppLovinAdContentRating_ = JNIEnv.GetMethodID(this.class_ref, "setMaximumAdContentRating", "(Lcom/applovin/sdk/AppLovinAdContentRating;)V");
				}
				JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
				*ptr = new JValue((value == null) ? IntPtr.Zero : value.Handle);
				JNIEnv.CallVoidMethod(base.Handle, this.id_setMaximumAdContentRating_Lcom_applovin_sdk_AppLovinAdContentRating_, ptr);
			}
		}

		// Token: 0x060004EA RID: 1258 RVA: 0x0000CFD3 File Offset: 0x0000B1D3
		private static Delegate GetGetPhoneNumberHandler()
		{
			if (IAppLovinTargetingDataInvoker.cb_getPhoneNumber == null)
			{
				IAppLovinTargetingDataInvoker.cb_getPhoneNumber = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IAppLovinTargetingDataInvoker.n_GetPhoneNumber));
			}
			return IAppLovinTargetingDataInvoker.cb_getPhoneNumber;
		}

		// Token: 0x060004EB RID: 1259 RVA: 0x0000CFF7 File Offset: 0x0000B1F7
		private static IntPtr n_GetPhoneNumber(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.NewString(Java.Lang.Object.GetObject<IAppLovinTargetingData>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).PhoneNumber);
		}

		// Token: 0x060004EC RID: 1260 RVA: 0x0000D00B File Offset: 0x0000B20B
		private static Delegate GetSetPhoneNumber_Ljava_lang_String_Handler()
		{
			if (IAppLovinTargetingDataInvoker.cb_setPhoneNumber_Ljava_lang_String_ == null)
			{
				IAppLovinTargetingDataInvoker.cb_setPhoneNumber_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(IAppLovinTargetingDataInvoker.n_SetPhoneNumber_Ljava_lang_String_));
			}
			return IAppLovinTargetingDataInvoker.cb_setPhoneNumber_Ljava_lang_String_;
		}

		// Token: 0x060004ED RID: 1261 RVA: 0x0000D030 File Offset: 0x0000B230
		private static void n_SetPhoneNumber_Ljava_lang_String_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			IAppLovinTargetingData @object = Java.Lang.Object.GetObject<IAppLovinTargetingData>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string @string = JNIEnv.GetString(native_p0, JniHandleOwnership.DoNotTransfer);
			@object.PhoneNumber = @string;
		}

		// Token: 0x17000187 RID: 391
		// (get) Token: 0x060004EE RID: 1262 RVA: 0x0000D054 File Offset: 0x0000B254
		// (set) Token: 0x060004EF RID: 1263 RVA: 0x0000D0A8 File Offset: 0x0000B2A8
		public unsafe string PhoneNumber
		{
			get
			{
				if (this.id_getPhoneNumber == IntPtr.Zero)
				{
					this.id_getPhoneNumber = JNIEnv.GetMethodID(this.class_ref, "getPhoneNumber", "()Ljava/lang/String;");
				}
				return JNIEnv.GetString(JNIEnv.CallObjectMethod(base.Handle, this.id_getPhoneNumber), JniHandleOwnership.TransferLocalRef);
			}
			set
			{
				if (this.id_setPhoneNumber_Ljava_lang_String_ == IntPtr.Zero)
				{
					this.id_setPhoneNumber_Ljava_lang_String_ = JNIEnv.GetMethodID(this.class_ref, "setPhoneNumber", "(Ljava/lang/String;)V");
				}
				IntPtr intPtr = JNIEnv.NewString(value);
				JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
				*ptr = new JValue(intPtr);
				JNIEnv.CallVoidMethod(base.Handle, this.id_setPhoneNumber_Ljava_lang_String_, ptr);
				JNIEnv.DeleteLocalRef(intPtr);
			}
		}

		// Token: 0x060004F0 RID: 1264 RVA: 0x0000D119 File Offset: 0x0000B319
		private static Delegate GetGetYearOfBirthHandler()
		{
			if (IAppLovinTargetingDataInvoker.cb_getYearOfBirth == null)
			{
				IAppLovinTargetingDataInvoker.cb_getYearOfBirth = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IAppLovinTargetingDataInvoker.n_GetYearOfBirth));
			}
			return IAppLovinTargetingDataInvoker.cb_getYearOfBirth;
		}

		// Token: 0x060004F1 RID: 1265 RVA: 0x0000D13D File Offset: 0x0000B33D
		private static IntPtr n_GetYearOfBirth(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<IAppLovinTargetingData>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).YearOfBirth);
		}

		// Token: 0x060004F2 RID: 1266 RVA: 0x0000D151 File Offset: 0x0000B351
		private static Delegate GetSetYearOfBirth_Ljava_lang_Integer_Handler()
		{
			if (IAppLovinTargetingDataInvoker.cb_setYearOfBirth_Ljava_lang_Integer_ == null)
			{
				IAppLovinTargetingDataInvoker.cb_setYearOfBirth_Ljava_lang_Integer_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(IAppLovinTargetingDataInvoker.n_SetYearOfBirth_Ljava_lang_Integer_));
			}
			return IAppLovinTargetingDataInvoker.cb_setYearOfBirth_Ljava_lang_Integer_;
		}

		// Token: 0x060004F3 RID: 1267 RVA: 0x0000D178 File Offset: 0x0000B378
		private static void n_SetYearOfBirth_Ljava_lang_Integer_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			IAppLovinTargetingData @object = Java.Lang.Object.GetObject<IAppLovinTargetingData>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Integer object2 = Java.Lang.Object.GetObject<Integer>(native_p0, JniHandleOwnership.DoNotTransfer);
			@object.YearOfBirth = object2;
		}

		// Token: 0x17000188 RID: 392
		// (get) Token: 0x060004F4 RID: 1268 RVA: 0x0000D19C File Offset: 0x0000B39C
		// (set) Token: 0x060004F5 RID: 1269 RVA: 0x0000D1F0 File Offset: 0x0000B3F0
		public unsafe Integer YearOfBirth
		{
			get
			{
				if (this.id_getYearOfBirth == IntPtr.Zero)
				{
					this.id_getYearOfBirth = JNIEnv.GetMethodID(this.class_ref, "getYearOfBirth", "()Ljava/lang/Integer;");
				}
				return Java.Lang.Object.GetObject<Integer>(JNIEnv.CallObjectMethod(base.Handle, this.id_getYearOfBirth), JniHandleOwnership.TransferLocalRef);
			}
			set
			{
				if (this.id_setYearOfBirth_Ljava_lang_Integer_ == IntPtr.Zero)
				{
					this.id_setYearOfBirth_Ljava_lang_Integer_ = JNIEnv.GetMethodID(this.class_ref, "setYearOfBirth", "(Ljava/lang/Integer;)V");
				}
				JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
				*ptr = new JValue((value == null) ? IntPtr.Zero : value.Handle);
				JNIEnv.CallVoidMethod(base.Handle, this.id_setYearOfBirth_Ljava_lang_Integer_, ptr);
			}
		}

		// Token: 0x060004F6 RID: 1270 RVA: 0x0000D263 File Offset: 0x0000B463
		private static Delegate GetClearAllHandler()
		{
			if (IAppLovinTargetingDataInvoker.cb_clearAll == null)
			{
				IAppLovinTargetingDataInvoker.cb_clearAll = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_V(IAppLovinTargetingDataInvoker.n_ClearAll));
			}
			return IAppLovinTargetingDataInvoker.cb_clearAll;
		}

		// Token: 0x060004F7 RID: 1271 RVA: 0x0000D287 File Offset: 0x0000B487
		private static void n_ClearAll(IntPtr jnienv, IntPtr native__this)
		{
			Java.Lang.Object.GetObject<IAppLovinTargetingData>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ClearAll();
		}

		// Token: 0x060004F8 RID: 1272 RVA: 0x0000D296 File Offset: 0x0000B496
		public void ClearAll()
		{
			if (this.id_clearAll == IntPtr.Zero)
			{
				this.id_clearAll = JNIEnv.GetMethodID(this.class_ref, "clearAll", "()V");
			}
			JNIEnv.CallVoidMethod(base.Handle, this.id_clearAll);
		}

		// Token: 0x0400015B RID: 347
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/applovin/sdk/AppLovinTargetingData", typeof(IAppLovinTargetingDataInvoker));

		// Token: 0x0400015C RID: 348
		private IntPtr class_ref;

		// Token: 0x0400015D RID: 349
		private static Delegate cb_getEmail;

		// Token: 0x0400015E RID: 350
		private static Delegate cb_setEmail_Ljava_lang_String_;

		// Token: 0x0400015F RID: 351
		private IntPtr id_getEmail;

		// Token: 0x04000160 RID: 352
		private IntPtr id_setEmail_Ljava_lang_String_;

		// Token: 0x04000161 RID: 353
		private static Delegate cb_getGender;

		// Token: 0x04000162 RID: 354
		private static Delegate cb_setGender_Lcom_applovin_sdk_AppLovinGender_;

		// Token: 0x04000163 RID: 355
		private IntPtr id_getGender;

		// Token: 0x04000164 RID: 356
		private IntPtr id_setGender_Lcom_applovin_sdk_AppLovinGender_;

		// Token: 0x04000165 RID: 357
		private static Delegate cb_getInterests;

		// Token: 0x04000166 RID: 358
		private static Delegate cb_setInterests_Ljava_util_List_;

		// Token: 0x04000167 RID: 359
		private IntPtr id_getInterests;

		// Token: 0x04000168 RID: 360
		private IntPtr id_setInterests_Ljava_util_List_;

		// Token: 0x04000169 RID: 361
		private static Delegate cb_getKeywords;

		// Token: 0x0400016A RID: 362
		private static Delegate cb_setKeywords_Ljava_util_List_;

		// Token: 0x0400016B RID: 363
		private IntPtr id_getKeywords;

		// Token: 0x0400016C RID: 364
		private IntPtr id_setKeywords_Ljava_util_List_;

		// Token: 0x0400016D RID: 365
		private static Delegate cb_getMaximumAdContentRating;

		// Token: 0x0400016E RID: 366
		private static Delegate cb_setMaximumAdContentRating_Lcom_applovin_sdk_AppLovinAdContentRating_;

		// Token: 0x0400016F RID: 367
		private IntPtr id_getMaximumAdContentRating;

		// Token: 0x04000170 RID: 368
		private IntPtr id_setMaximumAdContentRating_Lcom_applovin_sdk_AppLovinAdContentRating_;

		// Token: 0x04000171 RID: 369
		private static Delegate cb_getPhoneNumber;

		// Token: 0x04000172 RID: 370
		private static Delegate cb_setPhoneNumber_Ljava_lang_String_;

		// Token: 0x04000173 RID: 371
		private IntPtr id_getPhoneNumber;

		// Token: 0x04000174 RID: 372
		private IntPtr id_setPhoneNumber_Ljava_lang_String_;

		// Token: 0x04000175 RID: 373
		private static Delegate cb_getYearOfBirth;

		// Token: 0x04000176 RID: 374
		private static Delegate cb_setYearOfBirth_Ljava_lang_Integer_;

		// Token: 0x04000177 RID: 375
		private IntPtr id_getYearOfBirth;

		// Token: 0x04000178 RID: 376
		private IntPtr id_setYearOfBirth_Ljava_lang_Integer_;

		// Token: 0x04000179 RID: 377
		private static Delegate cb_clearAll;

		// Token: 0x0400017A RID: 378
		private IntPtr id_clearAll;
	}
}
