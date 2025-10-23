using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Com.Applovin.Sdk
{
	// Token: 0x02000068 RID: 104
	[Register("com/applovin/sdk/AppLovinAd", DoNotGenerateAcw = true)]
	internal class IAppLovinAdInvoker : Java.Lang.Object, IAppLovinAd, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x17000123 RID: 291
		// (get) Token: 0x0600038C RID: 908 RVA: 0x00009CF4 File Offset: 0x00007EF4
		private static IntPtr java_class_ref
		{
			get
			{
				return IAppLovinAdInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000124 RID: 292
		// (get) Token: 0x0600038D RID: 909 RVA: 0x00009D18 File Offset: 0x00007F18
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return IAppLovinAdInvoker._members;
			}
		}

		// Token: 0x17000125 RID: 293
		// (get) Token: 0x0600038E RID: 910 RVA: 0x00009D1F File Offset: 0x00007F1F
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x17000126 RID: 294
		// (get) Token: 0x0600038F RID: 911 RVA: 0x00009D27 File Offset: 0x00007F27
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return IAppLovinAdInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x06000390 RID: 912 RVA: 0x00009D33 File Offset: 0x00007F33
		public static IAppLovinAd GetObject(IntPtr handle, JniHandleOwnership transfer)
		{
			return Java.Lang.Object.GetObject<IAppLovinAd>(handle, transfer);
		}

		// Token: 0x06000391 RID: 913 RVA: 0x00009D3C File Offset: 0x00007F3C
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, IAppLovinAdInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'com.applovin.sdk.AppLovinAd'.");
			}
			return handle;
		}

		// Token: 0x06000392 RID: 914 RVA: 0x00009D67 File Offset: 0x00007F67
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x06000393 RID: 915 RVA: 0x00009D98 File Offset: 0x00007F98
		public IAppLovinAdInvoker(IntPtr handle, JniHandleOwnership transfer) : base(IAppLovinAdInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x06000394 RID: 916 RVA: 0x00009DD0 File Offset: 0x00007FD0
		private static Delegate GetGetAdIdNumberHandler()
		{
			if (IAppLovinAdInvoker.cb_getAdIdNumber == null)
			{
				IAppLovinAdInvoker.cb_getAdIdNumber = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_J(IAppLovinAdInvoker.n_GetAdIdNumber));
			}
			return IAppLovinAdInvoker.cb_getAdIdNumber;
		}

		// Token: 0x06000395 RID: 917 RVA: 0x00009DF4 File Offset: 0x00007FF4
		private static long n_GetAdIdNumber(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<IAppLovinAd>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).AdIdNumber;
		}

		// Token: 0x17000127 RID: 295
		// (get) Token: 0x06000396 RID: 918 RVA: 0x00009E03 File Offset: 0x00008003
		public long AdIdNumber
		{
			get
			{
				if (this.id_getAdIdNumber == IntPtr.Zero)
				{
					this.id_getAdIdNumber = JNIEnv.GetMethodID(this.class_ref, "getAdIdNumber", "()J");
				}
				return JNIEnv.CallLongMethod(base.Handle, this.id_getAdIdNumber);
			}
		}

		// Token: 0x06000397 RID: 919 RVA: 0x00009E43 File Offset: 0x00008043
		private static Delegate GetIsVideoAdHandler()
		{
			if (IAppLovinAdInvoker.cb_isVideoAd == null)
			{
				IAppLovinAdInvoker.cb_isVideoAd = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(IAppLovinAdInvoker.n_IsVideoAd));
			}
			return IAppLovinAdInvoker.cb_isVideoAd;
		}

		// Token: 0x06000398 RID: 920 RVA: 0x00009E67 File Offset: 0x00008067
		private static bool n_IsVideoAd(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<IAppLovinAd>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).IsVideoAd;
		}

		// Token: 0x17000128 RID: 296
		// (get) Token: 0x06000399 RID: 921 RVA: 0x00009E76 File Offset: 0x00008076
		public bool IsVideoAd
		{
			get
			{
				if (this.id_isVideoAd == IntPtr.Zero)
				{
					this.id_isVideoAd = JNIEnv.GetMethodID(this.class_ref, "isVideoAd", "()Z");
				}
				return JNIEnv.CallBooleanMethod(base.Handle, this.id_isVideoAd);
			}
		}

		// Token: 0x0600039A RID: 922 RVA: 0x00009EB6 File Offset: 0x000080B6
		private static Delegate GetGetSizeHandler()
		{
			if (IAppLovinAdInvoker.cb_getSize == null)
			{
				IAppLovinAdInvoker.cb_getSize = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IAppLovinAdInvoker.n_GetSize));
			}
			return IAppLovinAdInvoker.cb_getSize;
		}

		// Token: 0x0600039B RID: 923 RVA: 0x00009EDA File Offset: 0x000080DA
		private static IntPtr n_GetSize(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<IAppLovinAd>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Size);
		}

		// Token: 0x17000129 RID: 297
		// (get) Token: 0x0600039C RID: 924 RVA: 0x00009EF0 File Offset: 0x000080F0
		public AppLovinAdSize Size
		{
			get
			{
				if (this.id_getSize == IntPtr.Zero)
				{
					this.id_getSize = JNIEnv.GetMethodID(this.class_ref, "getSize", "()Lcom/applovin/sdk/AppLovinAdSize;");
				}
				return Java.Lang.Object.GetObject<AppLovinAdSize>(JNIEnv.CallObjectMethod(base.Handle, this.id_getSize), JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x0600039D RID: 925 RVA: 0x00009F41 File Offset: 0x00008141
		private static Delegate GetGetTypeHandler()
		{
			if (IAppLovinAdInvoker.cb_getType == null)
			{
				IAppLovinAdInvoker.cb_getType = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IAppLovinAdInvoker.n_GetType));
			}
			return IAppLovinAdInvoker.cb_getType;
		}

		// Token: 0x0600039E RID: 926 RVA: 0x00009F65 File Offset: 0x00008165
		private static IntPtr n_GetType(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<IAppLovinAd>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Type);
		}

		// Token: 0x1700012A RID: 298
		// (get) Token: 0x0600039F RID: 927 RVA: 0x00009F7C File Offset: 0x0000817C
		public AppLovinAdType Type
		{
			get
			{
				if (this.id_getType == IntPtr.Zero)
				{
					this.id_getType = JNIEnv.GetMethodID(this.class_ref, "getType", "()Lcom/applovin/sdk/AppLovinAdType;");
				}
				return Java.Lang.Object.GetObject<AppLovinAdType>(JNIEnv.CallObjectMethod(base.Handle, this.id_getType), JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x060003A0 RID: 928 RVA: 0x00009FCD File Offset: 0x000081CD
		private static Delegate GetGetZoneIdHandler()
		{
			if (IAppLovinAdInvoker.cb_getZoneId == null)
			{
				IAppLovinAdInvoker.cb_getZoneId = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IAppLovinAdInvoker.n_GetZoneId));
			}
			return IAppLovinAdInvoker.cb_getZoneId;
		}

		// Token: 0x060003A1 RID: 929 RVA: 0x00009FF1 File Offset: 0x000081F1
		private static IntPtr n_GetZoneId(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.NewString(Java.Lang.Object.GetObject<IAppLovinAd>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ZoneId);
		}

		// Token: 0x1700012B RID: 299
		// (get) Token: 0x060003A2 RID: 930 RVA: 0x0000A008 File Offset: 0x00008208
		public string ZoneId
		{
			get
			{
				if (this.id_getZoneId == IntPtr.Zero)
				{
					this.id_getZoneId = JNIEnv.GetMethodID(this.class_ref, "getZoneId", "()Ljava/lang/String;");
				}
				return JNIEnv.GetString(JNIEnv.CallObjectMethod(base.Handle, this.id_getZoneId), JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x060003A3 RID: 931 RVA: 0x0000A059 File Offset: 0x00008259
		private static Delegate GetGetAdValue_Ljava_lang_String_Handler()
		{
			if (IAppLovinAdInvoker.cb_getAdValue_Ljava_lang_String_ == null)
			{
				IAppLovinAdInvoker.cb_getAdValue_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(IAppLovinAdInvoker.n_GetAdValue_Ljava_lang_String_));
			}
			return IAppLovinAdInvoker.cb_getAdValue_Ljava_lang_String_;
		}

		// Token: 0x060003A4 RID: 932 RVA: 0x0000A080 File Offset: 0x00008280
		private static IntPtr n_GetAdValue_Ljava_lang_String_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			IAppLovinAd @object = Java.Lang.Object.GetObject<IAppLovinAd>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string @string = JNIEnv.GetString(native_p0, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString(@object.GetAdValue(@string));
		}

		// Token: 0x060003A5 RID: 933 RVA: 0x0000A0A8 File Offset: 0x000082A8
		public unsafe string GetAdValue(string p0)
		{
			if (this.id_getAdValue_Ljava_lang_String_ == IntPtr.Zero)
			{
				this.id_getAdValue_Ljava_lang_String_ = JNIEnv.GetMethodID(this.class_ref, "getAdValue", "(Ljava/lang/String;)Ljava/lang/String;");
			}
			IntPtr intPtr = JNIEnv.NewString(p0);
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue(intPtr);
			string @string = JNIEnv.GetString(JNIEnv.CallObjectMethod(base.Handle, this.id_getAdValue_Ljava_lang_String_, ptr), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef(intPtr);
			return @string;
		}

		// Token: 0x060003A6 RID: 934 RVA: 0x0000A11F File Offset: 0x0000831F
		private static Delegate GetGetAdValue_Ljava_lang_String_Ljava_lang_String_Handler()
		{
			if (IAppLovinAdInvoker.cb_getAdValue_Ljava_lang_String_Ljava_lang_String_ == null)
			{
				IAppLovinAdInvoker.cb_getAdValue_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_L(IAppLovinAdInvoker.n_GetAdValue_Ljava_lang_String_Ljava_lang_String_));
			}
			return IAppLovinAdInvoker.cb_getAdValue_Ljava_lang_String_Ljava_lang_String_;
		}

		// Token: 0x060003A7 RID: 935 RVA: 0x0000A144 File Offset: 0x00008344
		private static IntPtr n_GetAdValue_Ljava_lang_String_Ljava_lang_String_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			IAppLovinAd @object = Java.Lang.Object.GetObject<IAppLovinAd>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string @string = JNIEnv.GetString(native_p0, JniHandleOwnership.DoNotTransfer);
			string string2 = JNIEnv.GetString(native_p1, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString(@object.GetAdValue(@string, string2));
		}

		// Token: 0x060003A8 RID: 936 RVA: 0x0000A178 File Offset: 0x00008378
		public unsafe string GetAdValue(string p0, string p1)
		{
			if (this.id_getAdValue_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
			{
				this.id_getAdValue_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID(this.class_ref, "getAdValue", "(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;");
			}
			IntPtr intPtr = JNIEnv.NewString(p0);
			IntPtr intPtr2 = JNIEnv.NewString(p1);
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue(intPtr);
			ptr[1] = new JValue(intPtr2);
			string @string = JNIEnv.GetString(JNIEnv.CallObjectMethod(base.Handle, this.id_getAdValue_Ljava_lang_String_Ljava_lang_String_, ptr), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef(intPtr);
			JNIEnv.DeleteLocalRef(intPtr2);
			return @string;
		}

		// Token: 0x040000D9 RID: 217
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/applovin/sdk/AppLovinAd", typeof(IAppLovinAdInvoker));

		// Token: 0x040000DA RID: 218
		private IntPtr class_ref;

		// Token: 0x040000DB RID: 219
		private static Delegate cb_getAdIdNumber;

		// Token: 0x040000DC RID: 220
		private IntPtr id_getAdIdNumber;

		// Token: 0x040000DD RID: 221
		private static Delegate cb_isVideoAd;

		// Token: 0x040000DE RID: 222
		private IntPtr id_isVideoAd;

		// Token: 0x040000DF RID: 223
		private static Delegate cb_getSize;

		// Token: 0x040000E0 RID: 224
		private IntPtr id_getSize;

		// Token: 0x040000E1 RID: 225
		private static Delegate cb_getType;

		// Token: 0x040000E2 RID: 226
		private IntPtr id_getType;

		// Token: 0x040000E3 RID: 227
		private static Delegate cb_getZoneId;

		// Token: 0x040000E4 RID: 228
		private IntPtr id_getZoneId;

		// Token: 0x040000E5 RID: 229
		private static Delegate cb_getAdValue_Ljava_lang_String_;

		// Token: 0x040000E6 RID: 230
		private IntPtr id_getAdValue_Ljava_lang_String_;

		// Token: 0x040000E7 RID: 231
		private static Delegate cb_getAdValue_Ljava_lang_String_Ljava_lang_String_;

		// Token: 0x040000E8 RID: 232
		private IntPtr id_getAdValue_Ljava_lang_String_Ljava_lang_String_;
	}
}
