using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using Android.Content;
using Android.Runtime;
using Com.Applovin.Sdk;
using Java.Interop;
using Java.Lang;

namespace Com.Applovin.Impl.Sdk
{
	// Token: 0x02000131 RID: 305
	[Register("com/applovin/impl/sdk/EventServiceImpl", DoNotGenerateAcw = true)]
	public class EventServiceImpl : Java.Lang.Object, IAppLovinEventService, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x170003A0 RID: 928
		// (get) Token: 0x06000DE6 RID: 3558 RVA: 0x00025A80 File Offset: 0x00023C80
		internal static IntPtr class_ref
		{
			get
			{
				return EventServiceImpl._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170003A1 RID: 929
		// (get) Token: 0x06000DE7 RID: 3559 RVA: 0x00025AA4 File Offset: 0x00023CA4
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return EventServiceImpl._members;
			}
		}

		// Token: 0x170003A2 RID: 930
		// (get) Token: 0x06000DE8 RID: 3560 RVA: 0x00025AAC File Offset: 0x00023CAC
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return EventServiceImpl._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170003A3 RID: 931
		// (get) Token: 0x06000DE9 RID: 3561 RVA: 0x00025AD0 File Offset: 0x00023CD0
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return EventServiceImpl._members.ManagedPeerType;
			}
		}

		// Token: 0x06000DEA RID: 3562 RVA: 0x000021F0 File Offset: 0x000003F0
		protected EventServiceImpl(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06000DEB RID: 3563 RVA: 0x00025ADC File Offset: 0x00023CDC
		private static Delegate GetGetSuperPropertiesHandler()
		{
			if (EventServiceImpl.cb_getSuperProperties == null)
			{
				EventServiceImpl.cb_getSuperProperties = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(EventServiceImpl.n_GetSuperProperties));
			}
			return EventServiceImpl.cb_getSuperProperties;
		}

		// Token: 0x06000DEC RID: 3564 RVA: 0x00025B00 File Offset: 0x00023D00
		private static IntPtr n_GetSuperProperties(IntPtr jnienv, IntPtr native__this)
		{
			return JavaDictionary<string, Java.Lang.Object>.ToLocalJniHandle(Java.Lang.Object.GetObject<EventServiceImpl>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).SuperProperties);
		}

		// Token: 0x170003A4 RID: 932
		// (get) Token: 0x06000DED RID: 3565 RVA: 0x00025B14 File Offset: 0x00023D14
		public virtual IDictionary<string, Java.Lang.Object> SuperProperties
		{
			[Register("getSuperProperties", "()Ljava/util/Map;", "GetGetSuperPropertiesHandler")]
			get
			{
				return JavaDictionary<string, Java.Lang.Object>.FromJniHandle(EventServiceImpl._members.InstanceMethods.InvokeVirtualObjectMethod("getSuperProperties.()Ljava/util/Map;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x06000DEE RID: 3566 RVA: 0x00025B46 File Offset: 0x00023D46
		private static Delegate GetMaybeTrackAppOpenEventHandler()
		{
			if (EventServiceImpl.cb_maybeTrackAppOpenEvent == null)
			{
				EventServiceImpl.cb_maybeTrackAppOpenEvent = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_V(EventServiceImpl.n_MaybeTrackAppOpenEvent));
			}
			return EventServiceImpl.cb_maybeTrackAppOpenEvent;
		}

		// Token: 0x06000DEF RID: 3567 RVA: 0x00025B6A File Offset: 0x00023D6A
		private static void n_MaybeTrackAppOpenEvent(IntPtr jnienv, IntPtr native__this)
		{
			Java.Lang.Object.GetObject<EventServiceImpl>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).MaybeTrackAppOpenEvent();
		}

		// Token: 0x06000DF0 RID: 3568 RVA: 0x00025B79 File Offset: 0x00023D79
		[Register("maybeTrackAppOpenEvent", "()V", "GetMaybeTrackAppOpenEventHandler")]
		public virtual void MaybeTrackAppOpenEvent()
		{
			EventServiceImpl._members.InstanceMethods.InvokeVirtualVoidMethod("maybeTrackAppOpenEvent.()V", this, null);
		}

		// Token: 0x06000DF1 RID: 3569 RVA: 0x00025B92 File Offset: 0x00023D92
		private static Delegate GetSetSuperProperty_Ljava_lang_Object_Ljava_lang_String_Handler()
		{
			if (EventServiceImpl.cb_setSuperProperty_Ljava_lang_Object_Ljava_lang_String_ == null)
			{
				EventServiceImpl.cb_setSuperProperty_Ljava_lang_Object_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_V(EventServiceImpl.n_SetSuperProperty_Ljava_lang_Object_Ljava_lang_String_));
			}
			return EventServiceImpl.cb_setSuperProperty_Ljava_lang_Object_Ljava_lang_String_;
		}

		// Token: 0x06000DF2 RID: 3570 RVA: 0x00025BB8 File Offset: 0x00023DB8
		private static void n_SetSuperProperty_Ljava_lang_Object_Ljava_lang_String_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			EventServiceImpl @object = Java.Lang.Object.GetObject<EventServiceImpl>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object2 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_p0, JniHandleOwnership.DoNotTransfer);
			string @string = JNIEnv.GetString(native_p1, JniHandleOwnership.DoNotTransfer);
			@object.SetSuperProperty(object2, @string);
		}

		// Token: 0x06000DF3 RID: 3571 RVA: 0x00025BE4 File Offset: 0x00023DE4
		[Register("setSuperProperty", "(Ljava/lang/Object;Ljava/lang/String;)V", "GetSetSuperProperty_Ljava_lang_Object_Ljava_lang_String_Handler")]
		public unsafe virtual void SetSuperProperty(Java.Lang.Object p0, string p1)
		{
			IntPtr intPtr = JNIEnv.NewString(p1);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((p0 == null) ? IntPtr.Zero : p0.Handle);
				ptr[1] = new JniArgumentValue(intPtr);
				EventServiceImpl._members.InstanceMethods.InvokeVirtualVoidMethod("setSuperProperty.(Ljava/lang/Object;Ljava/lang/String;)V", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(p0);
			}
		}

		// Token: 0x06000DF4 RID: 3572 RVA: 0x00025C68 File Offset: 0x00023E68
		private static Delegate GetTrackCheckout_Ljava_lang_String_Ljava_util_Map_Handler()
		{
			if (EventServiceImpl.cb_trackCheckout_Ljava_lang_String_Ljava_util_Map_ == null)
			{
				EventServiceImpl.cb_trackCheckout_Ljava_lang_String_Ljava_util_Map_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_V(EventServiceImpl.n_TrackCheckout_Ljava_lang_String_Ljava_util_Map_));
			}
			return EventServiceImpl.cb_trackCheckout_Ljava_lang_String_Ljava_util_Map_;
		}

		// Token: 0x06000DF5 RID: 3573 RVA: 0x00025C8C File Offset: 0x00023E8C
		private static void n_TrackCheckout_Ljava_lang_String_Ljava_util_Map_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			EventServiceImpl @object = Java.Lang.Object.GetObject<EventServiceImpl>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string @string = JNIEnv.GetString(native_p0, JniHandleOwnership.DoNotTransfer);
			IDictionary<string, string> p = JavaDictionary<string, string>.FromJniHandle(native_p1, JniHandleOwnership.DoNotTransfer);
			@object.TrackCheckout(@string, p);
		}

		// Token: 0x06000DF6 RID: 3574 RVA: 0x00025CB8 File Offset: 0x00023EB8
		[Register("trackCheckout", "(Ljava/lang/String;Ljava/util/Map;)V", "GetTrackCheckout_Ljava_lang_String_Ljava_util_Map_Handler")]
		public unsafe virtual void TrackCheckout(string p0, IDictionary<string, string> p1)
		{
			IntPtr intPtr = JNIEnv.NewString(p0);
			IntPtr intPtr2 = JavaDictionary<string, string>.ToLocalJniHandle(p1);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue(intPtr2);
				EventServiceImpl._members.InstanceMethods.InvokeVirtualVoidMethod("trackCheckout.(Ljava/lang/String;Ljava/util/Map;)V", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				JNIEnv.DeleteLocalRef(intPtr2);
				GC.KeepAlive(p1);
			}
		}

		// Token: 0x06000DF7 RID: 3575 RVA: 0x00025D3C File Offset: 0x00023F3C
		private static Delegate GetTrackEvent_Ljava_lang_String_Handler()
		{
			if (EventServiceImpl.cb_trackEvent_Ljava_lang_String_ == null)
			{
				EventServiceImpl.cb_trackEvent_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(EventServiceImpl.n_TrackEvent_Ljava_lang_String_));
			}
			return EventServiceImpl.cb_trackEvent_Ljava_lang_String_;
		}

		// Token: 0x06000DF8 RID: 3576 RVA: 0x00025D60 File Offset: 0x00023F60
		private static void n_TrackEvent_Ljava_lang_String_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			EventServiceImpl @object = Java.Lang.Object.GetObject<EventServiceImpl>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string @string = JNIEnv.GetString(native_p0, JniHandleOwnership.DoNotTransfer);
			@object.TrackEvent(@string);
		}

		// Token: 0x06000DF9 RID: 3577 RVA: 0x00025D84 File Offset: 0x00023F84
		[Register("trackEvent", "(Ljava/lang/String;)V", "GetTrackEvent_Ljava_lang_String_Handler")]
		public unsafe virtual void TrackEvent(string p0)
		{
			IntPtr intPtr = JNIEnv.NewString(p0);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				EventServiceImpl._members.InstanceMethods.InvokeVirtualVoidMethod("trackEvent.(Ljava/lang/String;)V", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
			}
		}

		// Token: 0x06000DFA RID: 3578 RVA: 0x00025DE0 File Offset: 0x00023FE0
		private static Delegate GetTrackEvent_Ljava_lang_String_Ljava_util_Map_Handler()
		{
			if (EventServiceImpl.cb_trackEvent_Ljava_lang_String_Ljava_util_Map_ == null)
			{
				EventServiceImpl.cb_trackEvent_Ljava_lang_String_Ljava_util_Map_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_V(EventServiceImpl.n_TrackEvent_Ljava_lang_String_Ljava_util_Map_));
			}
			return EventServiceImpl.cb_trackEvent_Ljava_lang_String_Ljava_util_Map_;
		}

		// Token: 0x06000DFB RID: 3579 RVA: 0x00025E04 File Offset: 0x00024004
		private static void n_TrackEvent_Ljava_lang_String_Ljava_util_Map_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			EventServiceImpl @object = Java.Lang.Object.GetObject<EventServiceImpl>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string @string = JNIEnv.GetString(native_p0, JniHandleOwnership.DoNotTransfer);
			IDictionary<string, string> p = JavaDictionary<string, string>.FromJniHandle(native_p1, JniHandleOwnership.DoNotTransfer);
			@object.TrackEvent(@string, p);
		}

		// Token: 0x06000DFC RID: 3580 RVA: 0x00025E30 File Offset: 0x00024030
		[Register("trackEvent", "(Ljava/lang/String;Ljava/util/Map;)V", "GetTrackEvent_Ljava_lang_String_Ljava_util_Map_Handler")]
		public unsafe virtual void TrackEvent(string p0, IDictionary<string, string> p1)
		{
			IntPtr intPtr = JNIEnv.NewString(p0);
			IntPtr intPtr2 = JavaDictionary<string, string>.ToLocalJniHandle(p1);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue(intPtr2);
				EventServiceImpl._members.InstanceMethods.InvokeVirtualVoidMethod("trackEvent.(Ljava/lang/String;Ljava/util/Map;)V", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				JNIEnv.DeleteLocalRef(intPtr2);
				GC.KeepAlive(p1);
			}
		}

		// Token: 0x06000DFD RID: 3581 RVA: 0x00025EB4 File Offset: 0x000240B4
		private static Delegate GetTrackEvent_Ljava_lang_String_Ljava_util_Map_Ljava_util_Map_Handler()
		{
			if (EventServiceImpl.cb_trackEvent_Ljava_lang_String_Ljava_util_Map_Ljava_util_Map_ == null)
			{
				EventServiceImpl.cb_trackEvent_Ljava_lang_String_Ljava_util_Map_Ljava_util_Map_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLLL_V(EventServiceImpl.n_TrackEvent_Ljava_lang_String_Ljava_util_Map_Ljava_util_Map_));
			}
			return EventServiceImpl.cb_trackEvent_Ljava_lang_String_Ljava_util_Map_Ljava_util_Map_;
		}

		// Token: 0x06000DFE RID: 3582 RVA: 0x00025ED8 File Offset: 0x000240D8
		private static void n_TrackEvent_Ljava_lang_String_Ljava_util_Map_Ljava_util_Map_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			EventServiceImpl @object = Java.Lang.Object.GetObject<EventServiceImpl>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string @string = JNIEnv.GetString(native_p0, JniHandleOwnership.DoNotTransfer);
			IDictionary<string, string> p = JavaDictionary<string, string>.FromJniHandle(native_p1, JniHandleOwnership.DoNotTransfer);
			IDictionary<string, string> p2 = JavaDictionary<string, string>.FromJniHandle(native_p2, JniHandleOwnership.DoNotTransfer);
			@object.TrackEvent(@string, p, p2);
		}

		// Token: 0x06000DFF RID: 3583 RVA: 0x00025F10 File Offset: 0x00024110
		[Register("trackEvent", "(Ljava/lang/String;Ljava/util/Map;Ljava/util/Map;)V", "GetTrackEvent_Ljava_lang_String_Ljava_util_Map_Ljava_util_Map_Handler")]
		public unsafe virtual void TrackEvent(string p0, IDictionary<string, string> p1, IDictionary<string, string> p2)
		{
			IntPtr intPtr = JNIEnv.NewString(p0);
			IntPtr intPtr2 = JavaDictionary<string, string>.ToLocalJniHandle(p1);
			IntPtr intPtr3 = JavaDictionary<string, string>.ToLocalJniHandle(p2);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue(intPtr2);
				ptr[2] = new JniArgumentValue(intPtr3);
				EventServiceImpl._members.InstanceMethods.InvokeVirtualVoidMethod("trackEvent.(Ljava/lang/String;Ljava/util/Map;Ljava/util/Map;)V", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				JNIEnv.DeleteLocalRef(intPtr2);
				JNIEnv.DeleteLocalRef(intPtr3);
				GC.KeepAlive(p1);
				GC.KeepAlive(p2);
			}
		}

		// Token: 0x06000E00 RID: 3584 RVA: 0x00025FBC File Offset: 0x000241BC
		private static Delegate GetTrackEventSynchronously_Ljava_lang_String_Handler()
		{
			if (EventServiceImpl.cb_trackEventSynchronously_Ljava_lang_String_ == null)
			{
				EventServiceImpl.cb_trackEventSynchronously_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(EventServiceImpl.n_TrackEventSynchronously_Ljava_lang_String_));
			}
			return EventServiceImpl.cb_trackEventSynchronously_Ljava_lang_String_;
		}

		// Token: 0x06000E01 RID: 3585 RVA: 0x00025FE0 File Offset: 0x000241E0
		private static void n_TrackEventSynchronously_Ljava_lang_String_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			EventServiceImpl @object = Java.Lang.Object.GetObject<EventServiceImpl>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string @string = JNIEnv.GetString(native_p0, JniHandleOwnership.DoNotTransfer);
			@object.TrackEventSynchronously(@string);
		}

		// Token: 0x06000E02 RID: 3586 RVA: 0x00026004 File Offset: 0x00024204
		[Register("trackEventSynchronously", "(Ljava/lang/String;)V", "GetTrackEventSynchronously_Ljava_lang_String_Handler")]
		public unsafe virtual void TrackEventSynchronously(string p0)
		{
			IntPtr intPtr = JNIEnv.NewString(p0);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				EventServiceImpl._members.InstanceMethods.InvokeVirtualVoidMethod("trackEventSynchronously.(Ljava/lang/String;)V", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
			}
		}

		// Token: 0x06000E03 RID: 3587 RVA: 0x00026060 File Offset: 0x00024260
		private static Delegate GetTrackInAppPurchase_Landroid_content_Intent_Ljava_util_Map_Handler()
		{
			if (EventServiceImpl.cb_trackInAppPurchase_Landroid_content_Intent_Ljava_util_Map_ == null)
			{
				EventServiceImpl.cb_trackInAppPurchase_Landroid_content_Intent_Ljava_util_Map_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_V(EventServiceImpl.n_TrackInAppPurchase_Landroid_content_Intent_Ljava_util_Map_));
			}
			return EventServiceImpl.cb_trackInAppPurchase_Landroid_content_Intent_Ljava_util_Map_;
		}

		// Token: 0x06000E04 RID: 3588 RVA: 0x00026084 File Offset: 0x00024284
		private static void n_TrackInAppPurchase_Landroid_content_Intent_Ljava_util_Map_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			EventServiceImpl @object = Java.Lang.Object.GetObject<EventServiceImpl>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Intent object2 = Java.Lang.Object.GetObject<Intent>(native_p0, JniHandleOwnership.DoNotTransfer);
			IDictionary<string, string> p = JavaDictionary<string, string>.FromJniHandle(native_p1, JniHandleOwnership.DoNotTransfer);
			@object.TrackInAppPurchase(object2, p);
		}

		// Token: 0x06000E05 RID: 3589 RVA: 0x000260B0 File Offset: 0x000242B0
		[Register("trackInAppPurchase", "(Landroid/content/Intent;Ljava/util/Map;)V", "GetTrackInAppPurchase_Landroid_content_Intent_Ljava_util_Map_Handler")]
		public unsafe virtual void TrackInAppPurchase(Intent p0, IDictionary<string, string> p1)
		{
			IntPtr intPtr = JavaDictionary<string, string>.ToLocalJniHandle(p1);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((p0 == null) ? IntPtr.Zero : p0.Handle);
				ptr[1] = new JniArgumentValue(intPtr);
				EventServiceImpl._members.InstanceMethods.InvokeVirtualVoidMethod("trackInAppPurchase.(Landroid/content/Intent;Ljava/util/Map;)V", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(p0);
				GC.KeepAlive(p1);
			}
		}

		// Token: 0x040004CD RID: 1229
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/applovin/impl/sdk/EventServiceImpl", typeof(EventServiceImpl));

		// Token: 0x040004CE RID: 1230
		private static Delegate cb_getSuperProperties;

		// Token: 0x040004CF RID: 1231
		private static Delegate cb_maybeTrackAppOpenEvent;

		// Token: 0x040004D0 RID: 1232
		private static Delegate cb_setSuperProperty_Ljava_lang_Object_Ljava_lang_String_;

		// Token: 0x040004D1 RID: 1233
		private static Delegate cb_trackCheckout_Ljava_lang_String_Ljava_util_Map_;

		// Token: 0x040004D2 RID: 1234
		private static Delegate cb_trackEvent_Ljava_lang_String_;

		// Token: 0x040004D3 RID: 1235
		private static Delegate cb_trackEvent_Ljava_lang_String_Ljava_util_Map_;

		// Token: 0x040004D4 RID: 1236
		private static Delegate cb_trackEvent_Ljava_lang_String_Ljava_util_Map_Ljava_util_Map_;

		// Token: 0x040004D5 RID: 1237
		private static Delegate cb_trackEventSynchronously_Ljava_lang_String_;

		// Token: 0x040004D6 RID: 1238
		private static Delegate cb_trackInAppPurchase_Landroid_content_Intent_Ljava_util_Map_;
	}
}
