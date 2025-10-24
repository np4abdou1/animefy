using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using Android.Content;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Com.Applovin.Sdk
{
	// Token: 0x02000086 RID: 134
	[Register("com/applovin/sdk/AppLovinEventService", DoNotGenerateAcw = true)]
	internal class IAppLovinEventServiceInvoker : Java.Lang.Object, IAppLovinEventService, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x17000158 RID: 344
		// (get) Token: 0x06000457 RID: 1111 RVA: 0x0000B9C0 File Offset: 0x00009BC0
		private static IntPtr java_class_ref
		{
			get
			{
				return IAppLovinEventServiceInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000159 RID: 345
		// (get) Token: 0x06000458 RID: 1112 RVA: 0x0000B9E4 File Offset: 0x00009BE4
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return IAppLovinEventServiceInvoker._members;
			}
		}

		// Token: 0x1700015A RID: 346
		// (get) Token: 0x06000459 RID: 1113 RVA: 0x0000B9EB File Offset: 0x00009BEB
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x1700015B RID: 347
		// (get) Token: 0x0600045A RID: 1114 RVA: 0x0000B9F3 File Offset: 0x00009BF3
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return IAppLovinEventServiceInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x0600045B RID: 1115 RVA: 0x0000B9FF File Offset: 0x00009BFF
		public static IAppLovinEventService GetObject(IntPtr handle, JniHandleOwnership transfer)
		{
			return Java.Lang.Object.GetObject<IAppLovinEventService>(handle, transfer);
		}

		// Token: 0x0600045C RID: 1116 RVA: 0x0000BA08 File Offset: 0x00009C08
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, IAppLovinEventServiceInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'com.applovin.sdk.AppLovinEventService'.");
			}
			return handle;
		}

		// Token: 0x0600045D RID: 1117 RVA: 0x0000BA33 File Offset: 0x00009C33
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x0600045E RID: 1118 RVA: 0x0000BA64 File Offset: 0x00009C64
		public IAppLovinEventServiceInvoker(IntPtr handle, JniHandleOwnership transfer) : base(IAppLovinEventServiceInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x0600045F RID: 1119 RVA: 0x0000BA9C File Offset: 0x00009C9C
		private static Delegate GetGetSuperPropertiesHandler()
		{
			if (IAppLovinEventServiceInvoker.cb_getSuperProperties == null)
			{
				IAppLovinEventServiceInvoker.cb_getSuperProperties = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IAppLovinEventServiceInvoker.n_GetSuperProperties));
			}
			return IAppLovinEventServiceInvoker.cb_getSuperProperties;
		}

		// Token: 0x06000460 RID: 1120 RVA: 0x0000BAC0 File Offset: 0x00009CC0
		private static IntPtr n_GetSuperProperties(IntPtr jnienv, IntPtr native__this)
		{
			return JavaDictionary<string, Java.Lang.Object>.ToLocalJniHandle(Java.Lang.Object.GetObject<IAppLovinEventService>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).SuperProperties);
		}

		// Token: 0x1700015C RID: 348
		// (get) Token: 0x06000461 RID: 1121 RVA: 0x0000BAD4 File Offset: 0x00009CD4
		public IDictionary<string, Java.Lang.Object> SuperProperties
		{
			get
			{
				if (this.id_getSuperProperties == IntPtr.Zero)
				{
					this.id_getSuperProperties = JNIEnv.GetMethodID(this.class_ref, "getSuperProperties", "()Ljava/util/Map;");
				}
				return JavaDictionary<string, Java.Lang.Object>.FromJniHandle(JNIEnv.CallObjectMethod(base.Handle, this.id_getSuperProperties), JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x06000462 RID: 1122 RVA: 0x0000BB25 File Offset: 0x00009D25
		private static Delegate GetSetSuperProperty_Ljava_lang_Object_Ljava_lang_String_Handler()
		{
			if (IAppLovinEventServiceInvoker.cb_setSuperProperty_Ljava_lang_Object_Ljava_lang_String_ == null)
			{
				IAppLovinEventServiceInvoker.cb_setSuperProperty_Ljava_lang_Object_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_V(IAppLovinEventServiceInvoker.n_SetSuperProperty_Ljava_lang_Object_Ljava_lang_String_));
			}
			return IAppLovinEventServiceInvoker.cb_setSuperProperty_Ljava_lang_Object_Ljava_lang_String_;
		}

		// Token: 0x06000463 RID: 1123 RVA: 0x0000BB4C File Offset: 0x00009D4C
		private static void n_SetSuperProperty_Ljava_lang_Object_Ljava_lang_String_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			IAppLovinEventService @object = Java.Lang.Object.GetObject<IAppLovinEventService>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object2 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_p0, JniHandleOwnership.DoNotTransfer);
			string @string = JNIEnv.GetString(native_p1, JniHandleOwnership.DoNotTransfer);
			@object.SetSuperProperty(object2, @string);
		}

		// Token: 0x06000464 RID: 1124 RVA: 0x0000BB78 File Offset: 0x00009D78
		public unsafe void SetSuperProperty(Java.Lang.Object p0, string p1)
		{
			if (this.id_setSuperProperty_Ljava_lang_Object_Ljava_lang_String_ == IntPtr.Zero)
			{
				this.id_setSuperProperty_Ljava_lang_Object_Ljava_lang_String_ = JNIEnv.GetMethodID(this.class_ref, "setSuperProperty", "(Ljava/lang/Object;Ljava/lang/String;)V");
			}
			IntPtr intPtr = JNIEnv.NewString(p1);
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue((p0 == null) ? IntPtr.Zero : p0.Handle);
			ptr[1] = new JValue(intPtr);
			JNIEnv.CallVoidMethod(base.Handle, this.id_setSuperProperty_Ljava_lang_Object_Ljava_lang_String_, ptr);
			JNIEnv.DeleteLocalRef(intPtr);
		}

		// Token: 0x06000465 RID: 1125 RVA: 0x0000BC0B File Offset: 0x00009E0B
		private static Delegate GetTrackCheckout_Ljava_lang_String_Ljava_util_Map_Handler()
		{
			if (IAppLovinEventServiceInvoker.cb_trackCheckout_Ljava_lang_String_Ljava_util_Map_ == null)
			{
				IAppLovinEventServiceInvoker.cb_trackCheckout_Ljava_lang_String_Ljava_util_Map_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_V(IAppLovinEventServiceInvoker.n_TrackCheckout_Ljava_lang_String_Ljava_util_Map_));
			}
			return IAppLovinEventServiceInvoker.cb_trackCheckout_Ljava_lang_String_Ljava_util_Map_;
		}

		// Token: 0x06000466 RID: 1126 RVA: 0x0000BC30 File Offset: 0x00009E30
		private static void n_TrackCheckout_Ljava_lang_String_Ljava_util_Map_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			IAppLovinEventService @object = Java.Lang.Object.GetObject<IAppLovinEventService>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string @string = JNIEnv.GetString(native_p0, JniHandleOwnership.DoNotTransfer);
			IDictionary<string, string> p = JavaDictionary<string, string>.FromJniHandle(native_p1, JniHandleOwnership.DoNotTransfer);
			@object.TrackCheckout(@string, p);
		}

		// Token: 0x06000467 RID: 1127 RVA: 0x0000BC5C File Offset: 0x00009E5C
		public unsafe void TrackCheckout(string p0, IDictionary<string, string> p1)
		{
			if (this.id_trackCheckout_Ljava_lang_String_Ljava_util_Map_ == IntPtr.Zero)
			{
				this.id_trackCheckout_Ljava_lang_String_Ljava_util_Map_ = JNIEnv.GetMethodID(this.class_ref, "trackCheckout", "(Ljava/lang/String;Ljava/util/Map;)V");
			}
			IntPtr intPtr = JNIEnv.NewString(p0);
			IntPtr intPtr2 = JavaDictionary<string, string>.ToLocalJniHandle(p1);
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue(intPtr);
			ptr[1] = new JValue(intPtr2);
			JNIEnv.CallVoidMethod(base.Handle, this.id_trackCheckout_Ljava_lang_String_Ljava_util_Map_, ptr);
			JNIEnv.DeleteLocalRef(intPtr);
			JNIEnv.DeleteLocalRef(intPtr2);
		}

		// Token: 0x06000468 RID: 1128 RVA: 0x0000BCED File Offset: 0x00009EED
		private static Delegate GetTrackEvent_Ljava_lang_String_Handler()
		{
			if (IAppLovinEventServiceInvoker.cb_trackEvent_Ljava_lang_String_ == null)
			{
				IAppLovinEventServiceInvoker.cb_trackEvent_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(IAppLovinEventServiceInvoker.n_TrackEvent_Ljava_lang_String_));
			}
			return IAppLovinEventServiceInvoker.cb_trackEvent_Ljava_lang_String_;
		}

		// Token: 0x06000469 RID: 1129 RVA: 0x0000BD14 File Offset: 0x00009F14
		private static void n_TrackEvent_Ljava_lang_String_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			IAppLovinEventService @object = Java.Lang.Object.GetObject<IAppLovinEventService>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string @string = JNIEnv.GetString(native_p0, JniHandleOwnership.DoNotTransfer);
			@object.TrackEvent(@string);
		}

		// Token: 0x0600046A RID: 1130 RVA: 0x0000BD38 File Offset: 0x00009F38
		public unsafe void TrackEvent(string p0)
		{
			if (this.id_trackEvent_Ljava_lang_String_ == IntPtr.Zero)
			{
				this.id_trackEvent_Ljava_lang_String_ = JNIEnv.GetMethodID(this.class_ref, "trackEvent", "(Ljava/lang/String;)V");
			}
			IntPtr intPtr = JNIEnv.NewString(p0);
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue(intPtr);
			JNIEnv.CallVoidMethod(base.Handle, this.id_trackEvent_Ljava_lang_String_, ptr);
			JNIEnv.DeleteLocalRef(intPtr);
		}

		// Token: 0x0600046B RID: 1131 RVA: 0x0000BDA9 File Offset: 0x00009FA9
		private static Delegate GetTrackEvent_Ljava_lang_String_Ljava_util_Map_Handler()
		{
			if (IAppLovinEventServiceInvoker.cb_trackEvent_Ljava_lang_String_Ljava_util_Map_ == null)
			{
				IAppLovinEventServiceInvoker.cb_trackEvent_Ljava_lang_String_Ljava_util_Map_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_V(IAppLovinEventServiceInvoker.n_TrackEvent_Ljava_lang_String_Ljava_util_Map_));
			}
			return IAppLovinEventServiceInvoker.cb_trackEvent_Ljava_lang_String_Ljava_util_Map_;
		}

		// Token: 0x0600046C RID: 1132 RVA: 0x0000BDD0 File Offset: 0x00009FD0
		private static void n_TrackEvent_Ljava_lang_String_Ljava_util_Map_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			IAppLovinEventService @object = Java.Lang.Object.GetObject<IAppLovinEventService>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string @string = JNIEnv.GetString(native_p0, JniHandleOwnership.DoNotTransfer);
			IDictionary<string, string> p = JavaDictionary<string, string>.FromJniHandle(native_p1, JniHandleOwnership.DoNotTransfer);
			@object.TrackEvent(@string, p);
		}

		// Token: 0x0600046D RID: 1133 RVA: 0x0000BDFC File Offset: 0x00009FFC
		public unsafe void TrackEvent(string p0, IDictionary<string, string> p1)
		{
			if (this.id_trackEvent_Ljava_lang_String_Ljava_util_Map_ == IntPtr.Zero)
			{
				this.id_trackEvent_Ljava_lang_String_Ljava_util_Map_ = JNIEnv.GetMethodID(this.class_ref, "trackEvent", "(Ljava/lang/String;Ljava/util/Map;)V");
			}
			IntPtr intPtr = JNIEnv.NewString(p0);
			IntPtr intPtr2 = JavaDictionary<string, string>.ToLocalJniHandle(p1);
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue(intPtr);
			ptr[1] = new JValue(intPtr2);
			JNIEnv.CallVoidMethod(base.Handle, this.id_trackEvent_Ljava_lang_String_Ljava_util_Map_, ptr);
			JNIEnv.DeleteLocalRef(intPtr);
			JNIEnv.DeleteLocalRef(intPtr2);
		}

		// Token: 0x0600046E RID: 1134 RVA: 0x0000BE8D File Offset: 0x0000A08D
		private static Delegate GetTrackInAppPurchase_Landroid_content_Intent_Ljava_util_Map_Handler()
		{
			if (IAppLovinEventServiceInvoker.cb_trackInAppPurchase_Landroid_content_Intent_Ljava_util_Map_ == null)
			{
				IAppLovinEventServiceInvoker.cb_trackInAppPurchase_Landroid_content_Intent_Ljava_util_Map_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_V(IAppLovinEventServiceInvoker.n_TrackInAppPurchase_Landroid_content_Intent_Ljava_util_Map_));
			}
			return IAppLovinEventServiceInvoker.cb_trackInAppPurchase_Landroid_content_Intent_Ljava_util_Map_;
		}

		// Token: 0x0600046F RID: 1135 RVA: 0x0000BEB4 File Offset: 0x0000A0B4
		private static void n_TrackInAppPurchase_Landroid_content_Intent_Ljava_util_Map_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			IAppLovinEventService @object = Java.Lang.Object.GetObject<IAppLovinEventService>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Intent object2 = Java.Lang.Object.GetObject<Intent>(native_p0, JniHandleOwnership.DoNotTransfer);
			IDictionary<string, string> p = JavaDictionary<string, string>.FromJniHandle(native_p1, JniHandleOwnership.DoNotTransfer);
			@object.TrackInAppPurchase(object2, p);
		}

		// Token: 0x06000470 RID: 1136 RVA: 0x0000BEE0 File Offset: 0x0000A0E0
		public unsafe void TrackInAppPurchase(Intent p0, IDictionary<string, string> p1)
		{
			if (this.id_trackInAppPurchase_Landroid_content_Intent_Ljava_util_Map_ == IntPtr.Zero)
			{
				this.id_trackInAppPurchase_Landroid_content_Intent_Ljava_util_Map_ = JNIEnv.GetMethodID(this.class_ref, "trackInAppPurchase", "(Landroid/content/Intent;Ljava/util/Map;)V");
			}
			IntPtr intPtr = JavaDictionary<string, string>.ToLocalJniHandle(p1);
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue((p0 == null) ? IntPtr.Zero : p0.Handle);
			ptr[1] = new JValue(intPtr);
			JNIEnv.CallVoidMethod(base.Handle, this.id_trackInAppPurchase_Landroid_content_Intent_Ljava_util_Map_, ptr);
			JNIEnv.DeleteLocalRef(intPtr);
		}

		// Token: 0x04000136 RID: 310
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/applovin/sdk/AppLovinEventService", typeof(IAppLovinEventServiceInvoker));

		// Token: 0x04000137 RID: 311
		private IntPtr class_ref;

		// Token: 0x04000138 RID: 312
		private static Delegate cb_getSuperProperties;

		// Token: 0x04000139 RID: 313
		private IntPtr id_getSuperProperties;

		// Token: 0x0400013A RID: 314
		private static Delegate cb_setSuperProperty_Ljava_lang_Object_Ljava_lang_String_;

		// Token: 0x0400013B RID: 315
		private IntPtr id_setSuperProperty_Ljava_lang_Object_Ljava_lang_String_;

		// Token: 0x0400013C RID: 316
		private static Delegate cb_trackCheckout_Ljava_lang_String_Ljava_util_Map_;

		// Token: 0x0400013D RID: 317
		private IntPtr id_trackCheckout_Ljava_lang_String_Ljava_util_Map_;

		// Token: 0x0400013E RID: 318
		private static Delegate cb_trackEvent_Ljava_lang_String_;

		// Token: 0x0400013F RID: 319
		private IntPtr id_trackEvent_Ljava_lang_String_;

		// Token: 0x04000140 RID: 320
		private static Delegate cb_trackEvent_Ljava_lang_String_Ljava_util_Map_;

		// Token: 0x04000141 RID: 321
		private IntPtr id_trackEvent_Ljava_lang_String_Ljava_util_Map_;

		// Token: 0x04000142 RID: 322
		private static Delegate cb_trackInAppPurchase_Landroid_content_Intent_Ljava_util_Map_;

		// Token: 0x04000143 RID: 323
		private IntPtr id_trackInAppPurchase_Landroid_content_Intent_Ljava_util_Map_;
	}
}
