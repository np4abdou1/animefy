using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;
using Org.Json;

namespace Com.Applovin.Impl.Sdk
{
	// Token: 0x02000129 RID: 297
	[Register("com/applovin/impl/sdk/AppLovinAdBase", DoNotGenerateAcw = true)]
	public abstract class AppLovinAdBase : Java.Lang.Object
	{
		// Token: 0x17000375 RID: 885
		// (get) Token: 0x06000D24 RID: 3364 RVA: 0x000232B8 File Offset: 0x000214B8
		// (set) Token: 0x06000D25 RID: 3365 RVA: 0x000232E8 File Offset: 0x000214E8
		[Register("adObject")]
		protected JSONObject AdObject
		{
			get
			{
				return Java.Lang.Object.GetObject<JSONObject>(AppLovinAdBase._members.InstanceFields.GetObjectValue("adObject.Lorg/json/JSONObject;", this).Handle, JniHandleOwnership.TransferLocalRef);
			}
			set
			{
				IntPtr intPtr = JNIEnv.ToLocalJniHandle(value);
				try
				{
					AppLovinAdBase._members.InstanceFields.SetValue("adObject.Lorg/json/JSONObject;", this, new JniObjectReference(intPtr, JniObjectReferenceType.Invalid));
				}
				finally
				{
					JNIEnv.DeleteLocalRef(intPtr);
				}
			}
		}

		// Token: 0x17000376 RID: 886
		// (get) Token: 0x06000D26 RID: 3366 RVA: 0x00023334 File Offset: 0x00021534
		// (set) Token: 0x06000D27 RID: 3367 RVA: 0x00023364 File Offset: 0x00021564
		[Register("adObjectLock")]
		protected Java.Lang.Object AdObjectLock
		{
			get
			{
				return Java.Lang.Object.GetObject<Java.Lang.Object>(AppLovinAdBase._members.InstanceFields.GetObjectValue("adObjectLock.Ljava/lang/Object;", this).Handle, JniHandleOwnership.TransferLocalRef);
			}
			set
			{
				IntPtr intPtr = JNIEnv.ToLocalJniHandle(value);
				try
				{
					AppLovinAdBase._members.InstanceFields.SetValue("adObjectLock.Ljava/lang/Object;", this, new JniObjectReference(intPtr, JniObjectReferenceType.Invalid));
				}
				finally
				{
					JNIEnv.DeleteLocalRef(intPtr);
				}
			}
		}

		// Token: 0x17000377 RID: 887
		// (get) Token: 0x06000D28 RID: 3368 RVA: 0x000233B0 File Offset: 0x000215B0
		// (set) Token: 0x06000D29 RID: 3369 RVA: 0x000233E0 File Offset: 0x000215E0
		[Register("fullResponse")]
		protected JSONObject FullResponse
		{
			get
			{
				return Java.Lang.Object.GetObject<JSONObject>(AppLovinAdBase._members.InstanceFields.GetObjectValue("fullResponse.Lorg/json/JSONObject;", this).Handle, JniHandleOwnership.TransferLocalRef);
			}
			set
			{
				IntPtr intPtr = JNIEnv.ToLocalJniHandle(value);
				try
				{
					AppLovinAdBase._members.InstanceFields.SetValue("fullResponse.Lorg/json/JSONObject;", this, new JniObjectReference(intPtr, JniObjectReferenceType.Invalid));
				}
				finally
				{
					JNIEnv.DeleteLocalRef(intPtr);
				}
			}
		}

		// Token: 0x17000378 RID: 888
		// (get) Token: 0x06000D2A RID: 3370 RVA: 0x0002342C File Offset: 0x0002162C
		// (set) Token: 0x06000D2B RID: 3371 RVA: 0x0002345C File Offset: 0x0002165C
		[Register("fullResponseLock")]
		protected Java.Lang.Object FullResponseLock
		{
			get
			{
				return Java.Lang.Object.GetObject<Java.Lang.Object>(AppLovinAdBase._members.InstanceFields.GetObjectValue("fullResponseLock.Ljava/lang/Object;", this).Handle, JniHandleOwnership.TransferLocalRef);
			}
			set
			{
				IntPtr intPtr = JNIEnv.ToLocalJniHandle(value);
				try
				{
					AppLovinAdBase._members.InstanceFields.SetValue("fullResponseLock.Ljava/lang/Object;", this, new JniObjectReference(intPtr, JniObjectReferenceType.Invalid));
				}
				finally
				{
					JNIEnv.DeleteLocalRef(intPtr);
				}
			}
		}

		// Token: 0x17000379 RID: 889
		// (get) Token: 0x06000D2C RID: 3372 RVA: 0x000234A8 File Offset: 0x000216A8
		internal static IntPtr class_ref
		{
			get
			{
				return AppLovinAdBase._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700037A RID: 890
		// (get) Token: 0x06000D2D RID: 3373 RVA: 0x000234CC File Offset: 0x000216CC
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return AppLovinAdBase._members;
			}
		}

		// Token: 0x1700037B RID: 891
		// (get) Token: 0x06000D2E RID: 3374 RVA: 0x000234D4 File Offset: 0x000216D4
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return AppLovinAdBase._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700037C RID: 892
		// (get) Token: 0x06000D2F RID: 3375 RVA: 0x000234F8 File Offset: 0x000216F8
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return AppLovinAdBase._members.ManagedPeerType;
			}
		}

		// Token: 0x06000D30 RID: 3376 RVA: 0x000021F0 File Offset: 0x000003F0
		protected AppLovinAdBase(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06000D31 RID: 3377 RVA: 0x00023504 File Offset: 0x00021704
		private static Delegate GetGetAdIdNumberHandler()
		{
			if (AppLovinAdBase.cb_getAdIdNumber == null)
			{
				AppLovinAdBase.cb_getAdIdNumber = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_J(AppLovinAdBase.n_GetAdIdNumber));
			}
			return AppLovinAdBase.cb_getAdIdNumber;
		}

		// Token: 0x06000D32 RID: 3378 RVA: 0x00023528 File Offset: 0x00021728
		private static long n_GetAdIdNumber(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<AppLovinAdBase>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).AdIdNumber;
		}

		// Token: 0x1700037D RID: 893
		// (get) Token: 0x06000D33 RID: 3379
		public abstract long AdIdNumber { [Register("getAdIdNumber", "()J", "GetGetAdIdNumberHandler")] get; }

		// Token: 0x06000D34 RID: 3380 RVA: 0x00023537 File Offset: 0x00021737
		private static Delegate GetGetClCodeHandler()
		{
			if (AppLovinAdBase.cb_getClCode == null)
			{
				AppLovinAdBase.cb_getClCode = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(AppLovinAdBase.n_GetClCode));
			}
			return AppLovinAdBase.cb_getClCode;
		}

		// Token: 0x06000D35 RID: 3381 RVA: 0x0002355B File Offset: 0x0002175B
		private static IntPtr n_GetClCode(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.NewString(Java.Lang.Object.GetObject<AppLovinAdBase>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ClCode);
		}

		// Token: 0x1700037E RID: 894
		// (get) Token: 0x06000D36 RID: 3382 RVA: 0x00023570 File Offset: 0x00021770
		public virtual string ClCode
		{
			[Register("getClCode", "()Ljava/lang/String;", "GetGetClCodeHandler")]
			get
			{
				return JNIEnv.GetString(AppLovinAdBase._members.InstanceMethods.InvokeVirtualObjectMethod("getClCode.()Ljava/lang/String;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x06000D37 RID: 3383 RVA: 0x000235A2 File Offset: 0x000217A2
		private static Delegate GetGetCreatedAtMillisHandler()
		{
			if (AppLovinAdBase.cb_getCreatedAtMillis == null)
			{
				AppLovinAdBase.cb_getCreatedAtMillis = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_J(AppLovinAdBase.n_GetCreatedAtMillis));
			}
			return AppLovinAdBase.cb_getCreatedAtMillis;
		}

		// Token: 0x06000D38 RID: 3384 RVA: 0x000235C6 File Offset: 0x000217C6
		private static long n_GetCreatedAtMillis(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<AppLovinAdBase>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).CreatedAtMillis;
		}

		// Token: 0x1700037F RID: 895
		// (get) Token: 0x06000D39 RID: 3385 RVA: 0x000235D5 File Offset: 0x000217D5
		public virtual long CreatedAtMillis
		{
			[Register("getCreatedAtMillis", "()J", "GetGetCreatedAtMillisHandler")]
			get
			{
				return AppLovinAdBase._members.InstanceMethods.InvokeVirtualInt64Method("getCreatedAtMillis.()J", this, null);
			}
		}

		// Token: 0x06000D3A RID: 3386 RVA: 0x000235EE File Offset: 0x000217EE
		private static Delegate GetGetDspNameHandler()
		{
			if (AppLovinAdBase.cb_getDspName == null)
			{
				AppLovinAdBase.cb_getDspName = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(AppLovinAdBase.n_GetDspName));
			}
			return AppLovinAdBase.cb_getDspName;
		}

		// Token: 0x06000D3B RID: 3387 RVA: 0x00023612 File Offset: 0x00021812
		private static IntPtr n_GetDspName(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.NewString(Java.Lang.Object.GetObject<AppLovinAdBase>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).DspName);
		}

		// Token: 0x17000380 RID: 896
		// (get) Token: 0x06000D3C RID: 3388 RVA: 0x00023628 File Offset: 0x00021828
		public virtual string DspName
		{
			[Register("getDspName", "()Ljava/lang/String;", "GetGetDspNameHandler")]
			get
			{
				return JNIEnv.GetString(AppLovinAdBase._members.InstanceMethods.InvokeVirtualObjectMethod("getDspName.()Ljava/lang/String;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x06000D3D RID: 3389 RVA: 0x0002365A File Offset: 0x0002185A
		private static Delegate GetGetFetchLatencyMillisHandler()
		{
			if (AppLovinAdBase.cb_getFetchLatencyMillis == null)
			{
				AppLovinAdBase.cb_getFetchLatencyMillis = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_J(AppLovinAdBase.n_GetFetchLatencyMillis));
			}
			return AppLovinAdBase.cb_getFetchLatencyMillis;
		}

		// Token: 0x06000D3E RID: 3390 RVA: 0x0002367E File Offset: 0x0002187E
		private static long n_GetFetchLatencyMillis(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<AppLovinAdBase>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).FetchLatencyMillis;
		}

		// Token: 0x17000381 RID: 897
		// (get) Token: 0x06000D3F RID: 3391 RVA: 0x0002368D File Offset: 0x0002188D
		public virtual long FetchLatencyMillis
		{
			[Register("getFetchLatencyMillis", "()J", "GetGetFetchLatencyMillisHandler")]
			get
			{
				return AppLovinAdBase._members.InstanceMethods.InvokeVirtualInt64Method("getFetchLatencyMillis.()J", this, null);
			}
		}

		// Token: 0x06000D40 RID: 3392 RVA: 0x000236A6 File Offset: 0x000218A6
		private static Delegate GetGetFetchResponseSizeHandler()
		{
			if (AppLovinAdBase.cb_getFetchResponseSize == null)
			{
				AppLovinAdBase.cb_getFetchResponseSize = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_J(AppLovinAdBase.n_GetFetchResponseSize));
			}
			return AppLovinAdBase.cb_getFetchResponseSize;
		}

		// Token: 0x06000D41 RID: 3393 RVA: 0x000236CA File Offset: 0x000218CA
		private static long n_GetFetchResponseSize(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<AppLovinAdBase>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).FetchResponseSize;
		}

		// Token: 0x17000382 RID: 898
		// (get) Token: 0x06000D42 RID: 3394 RVA: 0x000236D9 File Offset: 0x000218D9
		public virtual long FetchResponseSize
		{
			[Register("getFetchResponseSize", "()J", "GetGetFetchResponseSizeHandler")]
			get
			{
				return AppLovinAdBase._members.InstanceMethods.InvokeVirtualInt64Method("getFetchResponseSize.()J", this, null);
			}
		}

		// Token: 0x06000D43 RID: 3395 RVA: 0x000236F2 File Offset: 0x000218F2
		private static Delegate GetGetPrimaryKeyHandler()
		{
			if (AppLovinAdBase.cb_getPrimaryKey == null)
			{
				AppLovinAdBase.cb_getPrimaryKey = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(AppLovinAdBase.n_GetPrimaryKey));
			}
			return AppLovinAdBase.cb_getPrimaryKey;
		}

		// Token: 0x06000D44 RID: 3396 RVA: 0x00023716 File Offset: 0x00021916
		private static IntPtr n_GetPrimaryKey(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.NewString(Java.Lang.Object.GetObject<AppLovinAdBase>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).PrimaryKey);
		}

		// Token: 0x17000383 RID: 899
		// (get) Token: 0x06000D45 RID: 3397 RVA: 0x0002372C File Offset: 0x0002192C
		public virtual string PrimaryKey
		{
			[Register("getPrimaryKey", "()Ljava/lang/String;", "GetGetPrimaryKeyHandler")]
			get
			{
				return JNIEnv.GetString(AppLovinAdBase._members.InstanceMethods.InvokeVirtualObjectMethod("getPrimaryKey.()Ljava/lang/String;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x06000D46 RID: 3398 RVA: 0x0002375E File Offset: 0x0002195E
		private static Delegate GetGetSecondaryKey1Handler()
		{
			if (AppLovinAdBase.cb_getSecondaryKey1 == null)
			{
				AppLovinAdBase.cb_getSecondaryKey1 = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(AppLovinAdBase.n_GetSecondaryKey1));
			}
			return AppLovinAdBase.cb_getSecondaryKey1;
		}

		// Token: 0x06000D47 RID: 3399 RVA: 0x00023782 File Offset: 0x00021982
		private static IntPtr n_GetSecondaryKey1(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.NewString(Java.Lang.Object.GetObject<AppLovinAdBase>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).SecondaryKey1);
		}

		// Token: 0x17000384 RID: 900
		// (get) Token: 0x06000D48 RID: 3400 RVA: 0x00023798 File Offset: 0x00021998
		public virtual string SecondaryKey1
		{
			[Register("getSecondaryKey1", "()Ljava/lang/String;", "GetGetSecondaryKey1Handler")]
			get
			{
				return JNIEnv.GetString(AppLovinAdBase._members.InstanceMethods.InvokeVirtualObjectMethod("getSecondaryKey1.()Ljava/lang/String;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x06000D49 RID: 3401 RVA: 0x000237CA File Offset: 0x000219CA
		private static Delegate GetGetSecondaryKey2Handler()
		{
			if (AppLovinAdBase.cb_getSecondaryKey2 == null)
			{
				AppLovinAdBase.cb_getSecondaryKey2 = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(AppLovinAdBase.n_GetSecondaryKey2));
			}
			return AppLovinAdBase.cb_getSecondaryKey2;
		}

		// Token: 0x06000D4A RID: 3402 RVA: 0x000237EE File Offset: 0x000219EE
		private static IntPtr n_GetSecondaryKey2(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.NewString(Java.Lang.Object.GetObject<AppLovinAdBase>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).SecondaryKey2);
		}

		// Token: 0x17000385 RID: 901
		// (get) Token: 0x06000D4B RID: 3403 RVA: 0x00023804 File Offset: 0x00021A04
		public virtual string SecondaryKey2
		{
			[Register("getSecondaryKey2", "()Ljava/lang/String;", "GetGetSecondaryKey2Handler")]
			get
			{
				return JNIEnv.GetString(AppLovinAdBase._members.InstanceMethods.InvokeVirtualObjectMethod("getSecondaryKey2.()Ljava/lang/String;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x06000D4C RID: 3404 RVA: 0x00023836 File Offset: 0x00021A36
		private static Delegate GetContainsKeyForAdObject_Ljava_lang_String_Handler()
		{
			if (AppLovinAdBase.cb_containsKeyForAdObject_Ljava_lang_String_ == null)
			{
				AppLovinAdBase.cb_containsKeyForAdObject_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_Z(AppLovinAdBase.n_ContainsKeyForAdObject_Ljava_lang_String_));
			}
			return AppLovinAdBase.cb_containsKeyForAdObject_Ljava_lang_String_;
		}

		// Token: 0x06000D4D RID: 3405 RVA: 0x0002385C File Offset: 0x00021A5C
		private static bool n_ContainsKeyForAdObject_Ljava_lang_String_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			AppLovinAdBase @object = Java.Lang.Object.GetObject<AppLovinAdBase>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string @string = JNIEnv.GetString(native_p0, JniHandleOwnership.DoNotTransfer);
			return @object.ContainsKeyForAdObject(@string);
		}

		// Token: 0x06000D4E RID: 3406 RVA: 0x00023880 File Offset: 0x00021A80
		[Register("containsKeyForAdObject", "(Ljava/lang/String;)Z", "GetContainsKeyForAdObject_Ljava_lang_String_Handler")]
		protected unsafe virtual bool ContainsKeyForAdObject(string p0)
		{
			IntPtr intPtr = JNIEnv.NewString(p0);
			bool result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				result = AppLovinAdBase._members.InstanceMethods.InvokeVirtualBooleanMethod("containsKeyForAdObject.(Ljava/lang/String;)Z", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
			}
			return result;
		}

		// Token: 0x06000D4F RID: 3407 RVA: 0x000238E0 File Offset: 0x00021AE0
		private static Delegate GetGetBooleanFromAdObject_Ljava_lang_String_Ljava_lang_Boolean_Handler()
		{
			if (AppLovinAdBase.cb_getBooleanFromAdObject_Ljava_lang_String_Ljava_lang_Boolean_ == null)
			{
				AppLovinAdBase.cb_getBooleanFromAdObject_Ljava_lang_String_Ljava_lang_Boolean_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_Z(AppLovinAdBase.n_GetBooleanFromAdObject_Ljava_lang_String_Ljava_lang_Boolean_));
			}
			return AppLovinAdBase.cb_getBooleanFromAdObject_Ljava_lang_String_Ljava_lang_Boolean_;
		}

		// Token: 0x06000D50 RID: 3408 RVA: 0x00023904 File Offset: 0x00021B04
		private static bool n_GetBooleanFromAdObject_Ljava_lang_String_Ljava_lang_Boolean_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			AppLovinAdBase @object = Java.Lang.Object.GetObject<AppLovinAdBase>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string @string = JNIEnv.GetString(native_p0, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Boolean object2 = Java.Lang.Object.GetObject<Java.Lang.Boolean>(native_p1, JniHandleOwnership.DoNotTransfer);
			return @object.GetBooleanFromAdObject(@string, object2);
		}

		// Token: 0x06000D51 RID: 3409 RVA: 0x00023930 File Offset: 0x00021B30
		[Register("getBooleanFromAdObject", "(Ljava/lang/String;Ljava/lang/Boolean;)Z", "GetGetBooleanFromAdObject_Ljava_lang_String_Ljava_lang_Boolean_Handler")]
		protected unsafe virtual bool GetBooleanFromAdObject(string p0, Java.Lang.Boolean p1)
		{
			IntPtr intPtr = JNIEnv.NewString(p0);
			bool result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue((p1 == null) ? IntPtr.Zero : p1.Handle);
				result = AppLovinAdBase._members.InstanceMethods.InvokeVirtualBooleanMethod("getBooleanFromAdObject.(Ljava/lang/String;Ljava/lang/Boolean;)Z", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(p1);
			}
			return result;
		}

		// Token: 0x06000D52 RID: 3410 RVA: 0x000239B8 File Offset: 0x00021BB8
		private static Delegate GetGetBooleanFromFullResponse_Ljava_lang_String_ZHandler()
		{
			if (AppLovinAdBase.cb_getBooleanFromFullResponse_Ljava_lang_String_Z == null)
			{
				AppLovinAdBase.cb_getBooleanFromFullResponse_Ljava_lang_String_Z = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLZ_Z(AppLovinAdBase.n_GetBooleanFromFullResponse_Ljava_lang_String_Z));
			}
			return AppLovinAdBase.cb_getBooleanFromFullResponse_Ljava_lang_String_Z;
		}

		// Token: 0x06000D53 RID: 3411 RVA: 0x000239DC File Offset: 0x00021BDC
		private static bool n_GetBooleanFromFullResponse_Ljava_lang_String_Z(IntPtr jnienv, IntPtr native__this, IntPtr native_p0, bool p1)
		{
			AppLovinAdBase @object = Java.Lang.Object.GetObject<AppLovinAdBase>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string @string = JNIEnv.GetString(native_p0, JniHandleOwnership.DoNotTransfer);
			return @object.GetBooleanFromFullResponse(@string, p1);
		}

		// Token: 0x06000D54 RID: 3412 RVA: 0x00023A00 File Offset: 0x00021C00
		[Register("getBooleanFromFullResponse", "(Ljava/lang/String;Z)Z", "GetGetBooleanFromFullResponse_Ljava_lang_String_ZHandler")]
		protected unsafe virtual bool GetBooleanFromFullResponse(string p0, bool p1)
		{
			IntPtr intPtr = JNIEnv.NewString(p0);
			bool result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue(p1);
				result = AppLovinAdBase._members.InstanceMethods.InvokeVirtualBooleanMethod("getBooleanFromFullResponse.(Ljava/lang/String;Z)Z", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
			}
			return result;
		}

		// Token: 0x06000D55 RID: 3413 RVA: 0x00023A70 File Offset: 0x00021C70
		private static Delegate GetGetColorFromAdObject_Ljava_lang_String_IHandler()
		{
			if (AppLovinAdBase.cb_getColorFromAdObject_Ljava_lang_String_I == null)
			{
				AppLovinAdBase.cb_getColorFromAdObject_Ljava_lang_String_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLI_I(AppLovinAdBase.n_GetColorFromAdObject_Ljava_lang_String_I));
			}
			return AppLovinAdBase.cb_getColorFromAdObject_Ljava_lang_String_I;
		}

		// Token: 0x06000D56 RID: 3414 RVA: 0x00023A94 File Offset: 0x00021C94
		private static int n_GetColorFromAdObject_Ljava_lang_String_I(IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1)
		{
			AppLovinAdBase @object = Java.Lang.Object.GetObject<AppLovinAdBase>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string @string = JNIEnv.GetString(native_p0, JniHandleOwnership.DoNotTransfer);
			return @object.GetColorFromAdObject(@string, p1);
		}

		// Token: 0x06000D57 RID: 3415 RVA: 0x00023AB8 File Offset: 0x00021CB8
		[Register("getColorFromAdObject", "(Ljava/lang/String;I)I", "GetGetColorFromAdObject_Ljava_lang_String_IHandler")]
		protected unsafe virtual int GetColorFromAdObject(string p0, int p1)
		{
			IntPtr intPtr = JNIEnv.NewString(p0);
			int result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue(p1);
				result = AppLovinAdBase._members.InstanceMethods.InvokeVirtualInt32Method("getColorFromAdObject.(Ljava/lang/String;I)I", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
			}
			return result;
		}

		// Token: 0x06000D58 RID: 3416 RVA: 0x00023B28 File Offset: 0x00021D28
		private static Delegate GetGetFloatFromAdObject_Ljava_lang_String_FHandler()
		{
			if (AppLovinAdBase.cb_getFloatFromAdObject_Ljava_lang_String_F == null)
			{
				AppLovinAdBase.cb_getFloatFromAdObject_Ljava_lang_String_F = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLF_F(AppLovinAdBase.n_GetFloatFromAdObject_Ljava_lang_String_F));
			}
			return AppLovinAdBase.cb_getFloatFromAdObject_Ljava_lang_String_F;
		}

		// Token: 0x06000D59 RID: 3417 RVA: 0x00023B4C File Offset: 0x00021D4C
		private static float n_GetFloatFromAdObject_Ljava_lang_String_F(IntPtr jnienv, IntPtr native__this, IntPtr native_p0, float p1)
		{
			AppLovinAdBase @object = Java.Lang.Object.GetObject<AppLovinAdBase>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string @string = JNIEnv.GetString(native_p0, JniHandleOwnership.DoNotTransfer);
			return @object.GetFloatFromAdObject(@string, p1);
		}

		// Token: 0x06000D5A RID: 3418 RVA: 0x00023B70 File Offset: 0x00021D70
		[Register("getFloatFromAdObject", "(Ljava/lang/String;F)F", "GetGetFloatFromAdObject_Ljava_lang_String_FHandler")]
		protected unsafe virtual float GetFloatFromAdObject(string p0, float p1)
		{
			IntPtr intPtr = JNIEnv.NewString(p0);
			float result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue(p1);
				result = AppLovinAdBase._members.InstanceMethods.InvokeVirtualSingleMethod("getFloatFromAdObject.(Ljava/lang/String;F)F", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
			}
			return result;
		}

		// Token: 0x06000D5B RID: 3419 RVA: 0x00023BE0 File Offset: 0x00021DE0
		private static Delegate GetGetFloatFromFullResponse_Ljava_lang_String_FHandler()
		{
			if (AppLovinAdBase.cb_getFloatFromFullResponse_Ljava_lang_String_F == null)
			{
				AppLovinAdBase.cb_getFloatFromFullResponse_Ljava_lang_String_F = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLF_F(AppLovinAdBase.n_GetFloatFromFullResponse_Ljava_lang_String_F));
			}
			return AppLovinAdBase.cb_getFloatFromFullResponse_Ljava_lang_String_F;
		}

		// Token: 0x06000D5C RID: 3420 RVA: 0x00023C04 File Offset: 0x00021E04
		private static float n_GetFloatFromFullResponse_Ljava_lang_String_F(IntPtr jnienv, IntPtr native__this, IntPtr native_p0, float p1)
		{
			AppLovinAdBase @object = Java.Lang.Object.GetObject<AppLovinAdBase>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string @string = JNIEnv.GetString(native_p0, JniHandleOwnership.DoNotTransfer);
			return @object.GetFloatFromFullResponse(@string, p1);
		}

		// Token: 0x06000D5D RID: 3421 RVA: 0x00023C28 File Offset: 0x00021E28
		[Register("getFloatFromFullResponse", "(Ljava/lang/String;F)F", "GetGetFloatFromFullResponse_Ljava_lang_String_FHandler")]
		protected unsafe virtual float GetFloatFromFullResponse(string p0, float p1)
		{
			IntPtr intPtr = JNIEnv.NewString(p0);
			float result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue(p1);
				result = AppLovinAdBase._members.InstanceMethods.InvokeVirtualSingleMethod("getFloatFromFullResponse.(Ljava/lang/String;F)F", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
			}
			return result;
		}

		// Token: 0x06000D5E RID: 3422 RVA: 0x00023C98 File Offset: 0x00021E98
		private static Delegate GetGetIntFromAdObject_Ljava_lang_String_IHandler()
		{
			if (AppLovinAdBase.cb_getIntFromAdObject_Ljava_lang_String_I == null)
			{
				AppLovinAdBase.cb_getIntFromAdObject_Ljava_lang_String_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLI_I(AppLovinAdBase.n_GetIntFromAdObject_Ljava_lang_String_I));
			}
			return AppLovinAdBase.cb_getIntFromAdObject_Ljava_lang_String_I;
		}

		// Token: 0x06000D5F RID: 3423 RVA: 0x00023CBC File Offset: 0x00021EBC
		private static int n_GetIntFromAdObject_Ljava_lang_String_I(IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1)
		{
			AppLovinAdBase @object = Java.Lang.Object.GetObject<AppLovinAdBase>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string @string = JNIEnv.GetString(native_p0, JniHandleOwnership.DoNotTransfer);
			return @object.GetIntFromAdObject(@string, p1);
		}

		// Token: 0x06000D60 RID: 3424 RVA: 0x00023CE0 File Offset: 0x00021EE0
		[Register("getIntFromAdObject", "(Ljava/lang/String;I)I", "GetGetIntFromAdObject_Ljava_lang_String_IHandler")]
		protected unsafe virtual int GetIntFromAdObject(string p0, int p1)
		{
			IntPtr intPtr = JNIEnv.NewString(p0);
			int result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue(p1);
				result = AppLovinAdBase._members.InstanceMethods.InvokeVirtualInt32Method("getIntFromAdObject.(Ljava/lang/String;I)I", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
			}
			return result;
		}

		// Token: 0x06000D61 RID: 3425 RVA: 0x00023D50 File Offset: 0x00021F50
		private static Delegate GetGetIntFromFullResponse_Ljava_lang_String_IHandler()
		{
			if (AppLovinAdBase.cb_getIntFromFullResponse_Ljava_lang_String_I == null)
			{
				AppLovinAdBase.cb_getIntFromFullResponse_Ljava_lang_String_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLI_I(AppLovinAdBase.n_GetIntFromFullResponse_Ljava_lang_String_I));
			}
			return AppLovinAdBase.cb_getIntFromFullResponse_Ljava_lang_String_I;
		}

		// Token: 0x06000D62 RID: 3426 RVA: 0x00023D74 File Offset: 0x00021F74
		private static int n_GetIntFromFullResponse_Ljava_lang_String_I(IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1)
		{
			AppLovinAdBase @object = Java.Lang.Object.GetObject<AppLovinAdBase>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string @string = JNIEnv.GetString(native_p0, JniHandleOwnership.DoNotTransfer);
			return @object.GetIntFromFullResponse(@string, p1);
		}

		// Token: 0x06000D63 RID: 3427 RVA: 0x00023D98 File Offset: 0x00021F98
		[Register("getIntFromFullResponse", "(Ljava/lang/String;I)I", "GetGetIntFromFullResponse_Ljava_lang_String_IHandler")]
		protected unsafe virtual int GetIntFromFullResponse(string p0, int p1)
		{
			IntPtr intPtr = JNIEnv.NewString(p0);
			int result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue(p1);
				result = AppLovinAdBase._members.InstanceMethods.InvokeVirtualInt32Method("getIntFromFullResponse.(Ljava/lang/String;I)I", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
			}
			return result;
		}

		// Token: 0x06000D64 RID: 3428 RVA: 0x00023E08 File Offset: 0x00022008
		private static Delegate GetGetIntegerListFromAdObject_Ljava_lang_String_Ljava_util_List_Handler()
		{
			if (AppLovinAdBase.cb_getIntegerListFromAdObject_Ljava_lang_String_Ljava_util_List_ == null)
			{
				AppLovinAdBase.cb_getIntegerListFromAdObject_Ljava_lang_String_Ljava_util_List_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_L(AppLovinAdBase.n_GetIntegerListFromAdObject_Ljava_lang_String_Ljava_util_List_));
			}
			return AppLovinAdBase.cb_getIntegerListFromAdObject_Ljava_lang_String_Ljava_util_List_;
		}

		// Token: 0x06000D65 RID: 3429 RVA: 0x00023E2C File Offset: 0x0002202C
		private static IntPtr n_GetIntegerListFromAdObject_Ljava_lang_String_Ljava_util_List_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			AppLovinAdBase @object = Java.Lang.Object.GetObject<AppLovinAdBase>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string @string = JNIEnv.GetString(native_p0, JniHandleOwnership.DoNotTransfer);
			IList<Integer> p = JavaList<Integer>.FromJniHandle(native_p1, JniHandleOwnership.DoNotTransfer);
			return JavaList<Integer>.ToLocalJniHandle(@object.GetIntegerListFromAdObject(@string, p));
		}

		// Token: 0x06000D66 RID: 3430 RVA: 0x00023E60 File Offset: 0x00022060
		[Register("getIntegerListFromAdObject", "(Ljava/lang/String;Ljava/util/List;)Ljava/util/List;", "GetGetIntegerListFromAdObject_Ljava_lang_String_Ljava_util_List_Handler")]
		protected unsafe virtual IList<Integer> GetIntegerListFromAdObject(string p0, IList<Integer> p1)
		{
			IntPtr intPtr = JNIEnv.NewString(p0);
			IntPtr intPtr2 = JavaList<Integer>.ToLocalJniHandle(p1);
			IList<Integer> result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue(intPtr2);
				result = JavaList<Integer>.FromJniHandle(AppLovinAdBase._members.InstanceMethods.InvokeVirtualObjectMethod("getIntegerListFromAdObject.(Ljava/lang/String;Ljava/util/List;)Ljava/util/List;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				JNIEnv.DeleteLocalRef(intPtr2);
				GC.KeepAlive(p1);
			}
			return result;
		}

		// Token: 0x06000D67 RID: 3431 RVA: 0x00023EF4 File Offset: 0x000220F4
		private static Delegate GetGetJsonObjectFromAdObject_Ljava_lang_String_Lorg_json_JSONObject_Handler()
		{
			if (AppLovinAdBase.cb_getJsonObjectFromAdObject_Ljava_lang_String_Lorg_json_JSONObject_ == null)
			{
				AppLovinAdBase.cb_getJsonObjectFromAdObject_Ljava_lang_String_Lorg_json_JSONObject_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_L(AppLovinAdBase.n_GetJsonObjectFromAdObject_Ljava_lang_String_Lorg_json_JSONObject_));
			}
			return AppLovinAdBase.cb_getJsonObjectFromAdObject_Ljava_lang_String_Lorg_json_JSONObject_;
		}

		// Token: 0x06000D68 RID: 3432 RVA: 0x00023F18 File Offset: 0x00022118
		private static IntPtr n_GetJsonObjectFromAdObject_Ljava_lang_String_Lorg_json_JSONObject_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			AppLovinAdBase @object = Java.Lang.Object.GetObject<AppLovinAdBase>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string @string = JNIEnv.GetString(native_p0, JniHandleOwnership.DoNotTransfer);
			JSONObject object2 = Java.Lang.Object.GetObject<JSONObject>(native_p1, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.GetJsonObjectFromAdObject(@string, object2));
		}

		// Token: 0x06000D69 RID: 3433 RVA: 0x00023F4C File Offset: 0x0002214C
		[Register("getJsonObjectFromAdObject", "(Ljava/lang/String;Lorg/json/JSONObject;)Lorg/json/JSONObject;", "GetGetJsonObjectFromAdObject_Ljava_lang_String_Lorg_json_JSONObject_Handler")]
		protected unsafe virtual JSONObject GetJsonObjectFromAdObject(string p0, JSONObject p1)
		{
			IntPtr intPtr = JNIEnv.NewString(p0);
			JSONObject @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue((p1 == null) ? IntPtr.Zero : p1.Handle);
				@object = Java.Lang.Object.GetObject<JSONObject>(AppLovinAdBase._members.InstanceMethods.InvokeVirtualObjectMethod("getJsonObjectFromAdObject.(Ljava/lang/String;Lorg/json/JSONObject;)Lorg/json/JSONObject;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(p1);
			}
			return @object;
		}

		// Token: 0x06000D6A RID: 3434 RVA: 0x00023FE0 File Offset: 0x000221E0
		private static Delegate GetGetJsonObjectFromFullResponse_Ljava_lang_String_Lorg_json_JSONObject_Handler()
		{
			if (AppLovinAdBase.cb_getJsonObjectFromFullResponse_Ljava_lang_String_Lorg_json_JSONObject_ == null)
			{
				AppLovinAdBase.cb_getJsonObjectFromFullResponse_Ljava_lang_String_Lorg_json_JSONObject_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_L(AppLovinAdBase.n_GetJsonObjectFromFullResponse_Ljava_lang_String_Lorg_json_JSONObject_));
			}
			return AppLovinAdBase.cb_getJsonObjectFromFullResponse_Ljava_lang_String_Lorg_json_JSONObject_;
		}

		// Token: 0x06000D6B RID: 3435 RVA: 0x00024004 File Offset: 0x00022204
		private static IntPtr n_GetJsonObjectFromFullResponse_Ljava_lang_String_Lorg_json_JSONObject_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			AppLovinAdBase @object = Java.Lang.Object.GetObject<AppLovinAdBase>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string @string = JNIEnv.GetString(native_p0, JniHandleOwnership.DoNotTransfer);
			JSONObject object2 = Java.Lang.Object.GetObject<JSONObject>(native_p1, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.GetJsonObjectFromFullResponse(@string, object2));
		}

		// Token: 0x06000D6C RID: 3436 RVA: 0x00024038 File Offset: 0x00022238
		[Register("getJsonObjectFromFullResponse", "(Ljava/lang/String;Lorg/json/JSONObject;)Lorg/json/JSONObject;", "GetGetJsonObjectFromFullResponse_Ljava_lang_String_Lorg_json_JSONObject_Handler")]
		protected unsafe virtual JSONObject GetJsonObjectFromFullResponse(string p0, JSONObject p1)
		{
			IntPtr intPtr = JNIEnv.NewString(p0);
			JSONObject @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue((p1 == null) ? IntPtr.Zero : p1.Handle);
				@object = Java.Lang.Object.GetObject<JSONObject>(AppLovinAdBase._members.InstanceMethods.InvokeVirtualObjectMethod("getJsonObjectFromFullResponse.(Ljava/lang/String;Lorg/json/JSONObject;)Lorg/json/JSONObject;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(p1);
			}
			return @object;
		}

		// Token: 0x06000D6D RID: 3437 RVA: 0x000240CC File Offset: 0x000222CC
		private static Delegate GetGetLongFromAdObject_Ljava_lang_String_JHandler()
		{
			if (AppLovinAdBase.cb_getLongFromAdObject_Ljava_lang_String_J == null)
			{
				AppLovinAdBase.cb_getLongFromAdObject_Ljava_lang_String_J = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLJ_J(AppLovinAdBase.n_GetLongFromAdObject_Ljava_lang_String_J));
			}
			return AppLovinAdBase.cb_getLongFromAdObject_Ljava_lang_String_J;
		}

		// Token: 0x06000D6E RID: 3438 RVA: 0x000240F0 File Offset: 0x000222F0
		private static long n_GetLongFromAdObject_Ljava_lang_String_J(IntPtr jnienv, IntPtr native__this, IntPtr native_p0, long p1)
		{
			AppLovinAdBase @object = Java.Lang.Object.GetObject<AppLovinAdBase>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string @string = JNIEnv.GetString(native_p0, JniHandleOwnership.DoNotTransfer);
			return @object.GetLongFromAdObject(@string, p1);
		}

		// Token: 0x06000D6F RID: 3439 RVA: 0x00024114 File Offset: 0x00022314
		[Register("getLongFromAdObject", "(Ljava/lang/String;J)J", "GetGetLongFromAdObject_Ljava_lang_String_JHandler")]
		protected unsafe virtual long GetLongFromAdObject(string p0, long p1)
		{
			IntPtr intPtr = JNIEnv.NewString(p0);
			long result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue(p1);
				result = AppLovinAdBase._members.InstanceMethods.InvokeVirtualInt64Method("getLongFromAdObject.(Ljava/lang/String;J)J", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
			}
			return result;
		}

		// Token: 0x06000D70 RID: 3440 RVA: 0x00024184 File Offset: 0x00022384
		private static Delegate GetGetLongFromFullResponse_Ljava_lang_String_JHandler()
		{
			if (AppLovinAdBase.cb_getLongFromFullResponse_Ljava_lang_String_J == null)
			{
				AppLovinAdBase.cb_getLongFromFullResponse_Ljava_lang_String_J = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLJ_J(AppLovinAdBase.n_GetLongFromFullResponse_Ljava_lang_String_J));
			}
			return AppLovinAdBase.cb_getLongFromFullResponse_Ljava_lang_String_J;
		}

		// Token: 0x06000D71 RID: 3441 RVA: 0x000241A8 File Offset: 0x000223A8
		private static long n_GetLongFromFullResponse_Ljava_lang_String_J(IntPtr jnienv, IntPtr native__this, IntPtr native_p0, long p1)
		{
			AppLovinAdBase @object = Java.Lang.Object.GetObject<AppLovinAdBase>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string @string = JNIEnv.GetString(native_p0, JniHandleOwnership.DoNotTransfer);
			return @object.GetLongFromFullResponse(@string, p1);
		}

		// Token: 0x06000D72 RID: 3442 RVA: 0x000241CC File Offset: 0x000223CC
		[Register("getLongFromFullResponse", "(Ljava/lang/String;J)J", "GetGetLongFromFullResponse_Ljava_lang_String_JHandler")]
		protected unsafe virtual long GetLongFromFullResponse(string p0, long p1)
		{
			IntPtr intPtr = JNIEnv.NewString(p0);
			long result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue(p1);
				result = AppLovinAdBase._members.InstanceMethods.InvokeVirtualInt64Method("getLongFromFullResponse.(Ljava/lang/String;J)J", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
			}
			return result;
		}

		// Token: 0x06000D73 RID: 3443 RVA: 0x0002423C File Offset: 0x0002243C
		private static Delegate GetGetStringFromAdObject_Ljava_lang_String_Ljava_lang_String_Handler()
		{
			if (AppLovinAdBase.cb_getStringFromAdObject_Ljava_lang_String_Ljava_lang_String_ == null)
			{
				AppLovinAdBase.cb_getStringFromAdObject_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_L(AppLovinAdBase.n_GetStringFromAdObject_Ljava_lang_String_Ljava_lang_String_));
			}
			return AppLovinAdBase.cb_getStringFromAdObject_Ljava_lang_String_Ljava_lang_String_;
		}

		// Token: 0x06000D74 RID: 3444 RVA: 0x00024260 File Offset: 0x00022460
		private static IntPtr n_GetStringFromAdObject_Ljava_lang_String_Ljava_lang_String_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			AppLovinAdBase @object = Java.Lang.Object.GetObject<AppLovinAdBase>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string @string = JNIEnv.GetString(native_p0, JniHandleOwnership.DoNotTransfer);
			string string2 = JNIEnv.GetString(native_p1, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString(@object.GetStringFromAdObject(@string, string2));
		}

		// Token: 0x06000D75 RID: 3445 RVA: 0x00024294 File Offset: 0x00022494
		[Register("getStringFromAdObject", "(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;", "GetGetStringFromAdObject_Ljava_lang_String_Ljava_lang_String_Handler")]
		protected unsafe virtual string GetStringFromAdObject(string p0, string p1)
		{
			IntPtr intPtr = JNIEnv.NewString(p0);
			IntPtr intPtr2 = JNIEnv.NewString(p1);
			string @string;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue(intPtr2);
				@string = JNIEnv.GetString(AppLovinAdBase._members.InstanceMethods.InvokeVirtualObjectMethod("getStringFromAdObject.(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				JNIEnv.DeleteLocalRef(intPtr2);
			}
			return @string;
		}

		// Token: 0x06000D76 RID: 3446 RVA: 0x00024324 File Offset: 0x00022524
		private static Delegate GetGetStringFromFullResponse_Ljava_lang_String_Ljava_lang_String_Handler()
		{
			if (AppLovinAdBase.cb_getStringFromFullResponse_Ljava_lang_String_Ljava_lang_String_ == null)
			{
				AppLovinAdBase.cb_getStringFromFullResponse_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_L(AppLovinAdBase.n_GetStringFromFullResponse_Ljava_lang_String_Ljava_lang_String_));
			}
			return AppLovinAdBase.cb_getStringFromFullResponse_Ljava_lang_String_Ljava_lang_String_;
		}

		// Token: 0x06000D77 RID: 3447 RVA: 0x00024348 File Offset: 0x00022548
		private static IntPtr n_GetStringFromFullResponse_Ljava_lang_String_Ljava_lang_String_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			AppLovinAdBase @object = Java.Lang.Object.GetObject<AppLovinAdBase>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string @string = JNIEnv.GetString(native_p0, JniHandleOwnership.DoNotTransfer);
			string string2 = JNIEnv.GetString(native_p1, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString(@object.GetStringFromFullResponse(@string, string2));
		}

		// Token: 0x06000D78 RID: 3448 RVA: 0x0002437C File Offset: 0x0002257C
		[Register("getStringFromFullResponse", "(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;", "GetGetStringFromFullResponse_Ljava_lang_String_Ljava_lang_String_Handler")]
		protected unsafe virtual string GetStringFromFullResponse(string p0, string p1)
		{
			IntPtr intPtr = JNIEnv.NewString(p0);
			IntPtr intPtr2 = JNIEnv.NewString(p1);
			string @string;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue(intPtr2);
				@string = JNIEnv.GetString(AppLovinAdBase._members.InstanceMethods.InvokeVirtualObjectMethod("getStringFromFullResponse.(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				JNIEnv.DeleteLocalRef(intPtr2);
			}
			return @string;
		}

		// Token: 0x04000498 RID: 1176
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/applovin/impl/sdk/AppLovinAdBase", typeof(AppLovinAdBase));

		// Token: 0x04000499 RID: 1177
		private static Delegate cb_getAdIdNumber;

		// Token: 0x0400049A RID: 1178
		private static Delegate cb_getClCode;

		// Token: 0x0400049B RID: 1179
		private static Delegate cb_getCreatedAtMillis;

		// Token: 0x0400049C RID: 1180
		private static Delegate cb_getDspName;

		// Token: 0x0400049D RID: 1181
		private static Delegate cb_getFetchLatencyMillis;

		// Token: 0x0400049E RID: 1182
		private static Delegate cb_getFetchResponseSize;

		// Token: 0x0400049F RID: 1183
		private static Delegate cb_getPrimaryKey;

		// Token: 0x040004A0 RID: 1184
		private static Delegate cb_getSecondaryKey1;

		// Token: 0x040004A1 RID: 1185
		private static Delegate cb_getSecondaryKey2;

		// Token: 0x040004A2 RID: 1186
		private static Delegate cb_containsKeyForAdObject_Ljava_lang_String_;

		// Token: 0x040004A3 RID: 1187
		private static Delegate cb_getBooleanFromAdObject_Ljava_lang_String_Ljava_lang_Boolean_;

		// Token: 0x040004A4 RID: 1188
		private static Delegate cb_getBooleanFromFullResponse_Ljava_lang_String_Z;

		// Token: 0x040004A5 RID: 1189
		private static Delegate cb_getColorFromAdObject_Ljava_lang_String_I;

		// Token: 0x040004A6 RID: 1190
		private static Delegate cb_getFloatFromAdObject_Ljava_lang_String_F;

		// Token: 0x040004A7 RID: 1191
		private static Delegate cb_getFloatFromFullResponse_Ljava_lang_String_F;

		// Token: 0x040004A8 RID: 1192
		private static Delegate cb_getIntFromAdObject_Ljava_lang_String_I;

		// Token: 0x040004A9 RID: 1193
		private static Delegate cb_getIntFromFullResponse_Ljava_lang_String_I;

		// Token: 0x040004AA RID: 1194
		private static Delegate cb_getIntegerListFromAdObject_Ljava_lang_String_Ljava_util_List_;

		// Token: 0x040004AB RID: 1195
		private static Delegate cb_getJsonObjectFromAdObject_Ljava_lang_String_Lorg_json_JSONObject_;

		// Token: 0x040004AC RID: 1196
		private static Delegate cb_getJsonObjectFromFullResponse_Ljava_lang_String_Lorg_json_JSONObject_;

		// Token: 0x040004AD RID: 1197
		private static Delegate cb_getLongFromAdObject_Ljava_lang_String_J;

		// Token: 0x040004AE RID: 1198
		private static Delegate cb_getLongFromFullResponse_Ljava_lang_String_J;

		// Token: 0x040004AF RID: 1199
		private static Delegate cb_getStringFromAdObject_Ljava_lang_String_Ljava_lang_String_;

		// Token: 0x040004B0 RID: 1200
		private static Delegate cb_getStringFromFullResponse_Ljava_lang_String_Ljava_lang_String_;
	}
}
