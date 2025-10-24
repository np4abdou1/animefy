using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Com.Applovin.Sdk;
using Java.Interop;
using Java.Lang;

namespace Com.Applovin.Adview
{
	// Token: 0x02000194 RID: 404
	[Register("com/applovin/adview/AppLovinAdViewEventListener", DoNotGenerateAcw = true)]
	internal class IAppLovinAdViewEventListenerInvoker : Java.Lang.Object, IAppLovinAdViewEventListener, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x170004DE RID: 1246
		// (get) Token: 0x060012DA RID: 4826 RVA: 0x00036780 File Offset: 0x00034980
		private static IntPtr java_class_ref
		{
			get
			{
				return IAppLovinAdViewEventListenerInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170004DF RID: 1247
		// (get) Token: 0x060012DB RID: 4827 RVA: 0x000367A4 File Offset: 0x000349A4
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return IAppLovinAdViewEventListenerInvoker._members;
			}
		}

		// Token: 0x170004E0 RID: 1248
		// (get) Token: 0x060012DC RID: 4828 RVA: 0x000367AB File Offset: 0x000349AB
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x170004E1 RID: 1249
		// (get) Token: 0x060012DD RID: 4829 RVA: 0x000367B3 File Offset: 0x000349B3
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return IAppLovinAdViewEventListenerInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x060012DE RID: 4830 RVA: 0x000367BF File Offset: 0x000349BF
		public static IAppLovinAdViewEventListener GetObject(IntPtr handle, JniHandleOwnership transfer)
		{
			return Java.Lang.Object.GetObject<IAppLovinAdViewEventListener>(handle, transfer);
		}

		// Token: 0x060012DF RID: 4831 RVA: 0x000367C8 File Offset: 0x000349C8
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, IAppLovinAdViewEventListenerInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'com.applovin.adview.AppLovinAdViewEventListener'.");
			}
			return handle;
		}

		// Token: 0x060012E0 RID: 4832 RVA: 0x000367F3 File Offset: 0x000349F3
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x060012E1 RID: 4833 RVA: 0x00036824 File Offset: 0x00034A24
		public IAppLovinAdViewEventListenerInvoker(IntPtr handle, JniHandleOwnership transfer) : base(IAppLovinAdViewEventListenerInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x060012E2 RID: 4834 RVA: 0x0003685C File Offset: 0x00034A5C
		private static Delegate GetAdClosedFullscreen_Lcom_applovin_sdk_AppLovinAd_Lcom_applovin_adview_AppLovinAdView_Handler()
		{
			if (IAppLovinAdViewEventListenerInvoker.cb_adClosedFullscreen_Lcom_applovin_sdk_AppLovinAd_Lcom_applovin_adview_AppLovinAdView_ == null)
			{
				IAppLovinAdViewEventListenerInvoker.cb_adClosedFullscreen_Lcom_applovin_sdk_AppLovinAd_Lcom_applovin_adview_AppLovinAdView_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_V(IAppLovinAdViewEventListenerInvoker.n_AdClosedFullscreen_Lcom_applovin_sdk_AppLovinAd_Lcom_applovin_adview_AppLovinAdView_));
			}
			return IAppLovinAdViewEventListenerInvoker.cb_adClosedFullscreen_Lcom_applovin_sdk_AppLovinAd_Lcom_applovin_adview_AppLovinAdView_;
		}

		// Token: 0x060012E3 RID: 4835 RVA: 0x00036880 File Offset: 0x00034A80
		private static void n_AdClosedFullscreen_Lcom_applovin_sdk_AppLovinAd_Lcom_applovin_adview_AppLovinAdView_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			IAppLovinAdViewEventListener @object = Java.Lang.Object.GetObject<IAppLovinAdViewEventListener>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			IAppLovinAd object2 = Java.Lang.Object.GetObject<IAppLovinAd>(native_p0, JniHandleOwnership.DoNotTransfer);
			AppLovinAdView object3 = Java.Lang.Object.GetObject<AppLovinAdView>(native_p1, JniHandleOwnership.DoNotTransfer);
			@object.AdClosedFullscreen(object2, object3);
		}

		// Token: 0x060012E4 RID: 4836 RVA: 0x000368AC File Offset: 0x00034AAC
		public unsafe void AdClosedFullscreen(IAppLovinAd p0, AppLovinAdView p1)
		{
			if (this.id_adClosedFullscreen_Lcom_applovin_sdk_AppLovinAd_Lcom_applovin_adview_AppLovinAdView_ == IntPtr.Zero)
			{
				this.id_adClosedFullscreen_Lcom_applovin_sdk_AppLovinAd_Lcom_applovin_adview_AppLovinAdView_ = JNIEnv.GetMethodID(this.class_ref, "adClosedFullscreen", "(Lcom/applovin/sdk/AppLovinAd;Lcom/applovin/adview/AppLovinAdView;)V");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue((p0 == null) ? IntPtr.Zero : ((Java.Lang.Object)p0).Handle);
			ptr[1] = new JValue((p1 == null) ? IntPtr.Zero : p1.Handle);
			JNIEnv.CallVoidMethod(base.Handle, this.id_adClosedFullscreen_Lcom_applovin_sdk_AppLovinAd_Lcom_applovin_adview_AppLovinAdView_, ptr);
		}

		// Token: 0x060012E5 RID: 4837 RVA: 0x00036946 File Offset: 0x00034B46
		private static Delegate GetAdFailedToDisplay_Lcom_applovin_sdk_AppLovinAd_Lcom_applovin_adview_AppLovinAdView_Lcom_applovin_adview_AppLovinAdViewDisplayErrorCode_Handler()
		{
			if (IAppLovinAdViewEventListenerInvoker.cb_adFailedToDisplay_Lcom_applovin_sdk_AppLovinAd_Lcom_applovin_adview_AppLovinAdView_Lcom_applovin_adview_AppLovinAdViewDisplayErrorCode_ == null)
			{
				IAppLovinAdViewEventListenerInvoker.cb_adFailedToDisplay_Lcom_applovin_sdk_AppLovinAd_Lcom_applovin_adview_AppLovinAdView_Lcom_applovin_adview_AppLovinAdViewDisplayErrorCode_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLLL_V(IAppLovinAdViewEventListenerInvoker.n_AdFailedToDisplay_Lcom_applovin_sdk_AppLovinAd_Lcom_applovin_adview_AppLovinAdView_Lcom_applovin_adview_AppLovinAdViewDisplayErrorCode_));
			}
			return IAppLovinAdViewEventListenerInvoker.cb_adFailedToDisplay_Lcom_applovin_sdk_AppLovinAd_Lcom_applovin_adview_AppLovinAdView_Lcom_applovin_adview_AppLovinAdViewDisplayErrorCode_;
		}

		// Token: 0x060012E6 RID: 4838 RVA: 0x0003696C File Offset: 0x00034B6C
		private static void n_AdFailedToDisplay_Lcom_applovin_sdk_AppLovinAd_Lcom_applovin_adview_AppLovinAdView_Lcom_applovin_adview_AppLovinAdViewDisplayErrorCode_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			IAppLovinAdViewEventListener @object = Java.Lang.Object.GetObject<IAppLovinAdViewEventListener>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			IAppLovinAd object2 = Java.Lang.Object.GetObject<IAppLovinAd>(native_p0, JniHandleOwnership.DoNotTransfer);
			AppLovinAdView object3 = Java.Lang.Object.GetObject<AppLovinAdView>(native_p1, JniHandleOwnership.DoNotTransfer);
			AppLovinAdViewDisplayErrorCode object4 = Java.Lang.Object.GetObject<AppLovinAdViewDisplayErrorCode>(native_p2, JniHandleOwnership.DoNotTransfer);
			@object.AdFailedToDisplay(object2, object3, object4);
		}

		// Token: 0x060012E7 RID: 4839 RVA: 0x000369A4 File Offset: 0x00034BA4
		public unsafe void AdFailedToDisplay(IAppLovinAd p0, AppLovinAdView p1, AppLovinAdViewDisplayErrorCode p2)
		{
			if (this.id_adFailedToDisplay_Lcom_applovin_sdk_AppLovinAd_Lcom_applovin_adview_AppLovinAdView_Lcom_applovin_adview_AppLovinAdViewDisplayErrorCode_ == IntPtr.Zero)
			{
				this.id_adFailedToDisplay_Lcom_applovin_sdk_AppLovinAd_Lcom_applovin_adview_AppLovinAdView_Lcom_applovin_adview_AppLovinAdViewDisplayErrorCode_ = JNIEnv.GetMethodID(this.class_ref, "adFailedToDisplay", "(Lcom/applovin/sdk/AppLovinAd;Lcom/applovin/adview/AppLovinAdView;Lcom/applovin/adview/AppLovinAdViewDisplayErrorCode;)V");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue((p0 == null) ? IntPtr.Zero : ((Java.Lang.Object)p0).Handle);
			ptr[1] = new JValue((p1 == null) ? IntPtr.Zero : p1.Handle);
			ptr[2] = new JValue((p2 == null) ? IntPtr.Zero : p2.Handle);
			JNIEnv.CallVoidMethod(base.Handle, this.id_adFailedToDisplay_Lcom_applovin_sdk_AppLovinAd_Lcom_applovin_adview_AppLovinAdView_Lcom_applovin_adview_AppLovinAdViewDisplayErrorCode_, ptr);
		}

		// Token: 0x060012E8 RID: 4840 RVA: 0x00036A63 File Offset: 0x00034C63
		private static Delegate GetAdLeftApplication_Lcom_applovin_sdk_AppLovinAd_Lcom_applovin_adview_AppLovinAdView_Handler()
		{
			if (IAppLovinAdViewEventListenerInvoker.cb_adLeftApplication_Lcom_applovin_sdk_AppLovinAd_Lcom_applovin_adview_AppLovinAdView_ == null)
			{
				IAppLovinAdViewEventListenerInvoker.cb_adLeftApplication_Lcom_applovin_sdk_AppLovinAd_Lcom_applovin_adview_AppLovinAdView_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_V(IAppLovinAdViewEventListenerInvoker.n_AdLeftApplication_Lcom_applovin_sdk_AppLovinAd_Lcom_applovin_adview_AppLovinAdView_));
			}
			return IAppLovinAdViewEventListenerInvoker.cb_adLeftApplication_Lcom_applovin_sdk_AppLovinAd_Lcom_applovin_adview_AppLovinAdView_;
		}

		// Token: 0x060012E9 RID: 4841 RVA: 0x00036A88 File Offset: 0x00034C88
		private static void n_AdLeftApplication_Lcom_applovin_sdk_AppLovinAd_Lcom_applovin_adview_AppLovinAdView_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			IAppLovinAdViewEventListener @object = Java.Lang.Object.GetObject<IAppLovinAdViewEventListener>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			IAppLovinAd object2 = Java.Lang.Object.GetObject<IAppLovinAd>(native_p0, JniHandleOwnership.DoNotTransfer);
			AppLovinAdView object3 = Java.Lang.Object.GetObject<AppLovinAdView>(native_p1, JniHandleOwnership.DoNotTransfer);
			@object.AdLeftApplication(object2, object3);
		}

		// Token: 0x060012EA RID: 4842 RVA: 0x00036AB4 File Offset: 0x00034CB4
		public unsafe void AdLeftApplication(IAppLovinAd p0, AppLovinAdView p1)
		{
			if (this.id_adLeftApplication_Lcom_applovin_sdk_AppLovinAd_Lcom_applovin_adview_AppLovinAdView_ == IntPtr.Zero)
			{
				this.id_adLeftApplication_Lcom_applovin_sdk_AppLovinAd_Lcom_applovin_adview_AppLovinAdView_ = JNIEnv.GetMethodID(this.class_ref, "adLeftApplication", "(Lcom/applovin/sdk/AppLovinAd;Lcom/applovin/adview/AppLovinAdView;)V");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue((p0 == null) ? IntPtr.Zero : ((Java.Lang.Object)p0).Handle);
			ptr[1] = new JValue((p1 == null) ? IntPtr.Zero : p1.Handle);
			JNIEnv.CallVoidMethod(base.Handle, this.id_adLeftApplication_Lcom_applovin_sdk_AppLovinAd_Lcom_applovin_adview_AppLovinAdView_, ptr);
		}

		// Token: 0x060012EB RID: 4843 RVA: 0x00036B4E File Offset: 0x00034D4E
		private static Delegate GetAdOpenedFullscreen_Lcom_applovin_sdk_AppLovinAd_Lcom_applovin_adview_AppLovinAdView_Handler()
		{
			if (IAppLovinAdViewEventListenerInvoker.cb_adOpenedFullscreen_Lcom_applovin_sdk_AppLovinAd_Lcom_applovin_adview_AppLovinAdView_ == null)
			{
				IAppLovinAdViewEventListenerInvoker.cb_adOpenedFullscreen_Lcom_applovin_sdk_AppLovinAd_Lcom_applovin_adview_AppLovinAdView_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_V(IAppLovinAdViewEventListenerInvoker.n_AdOpenedFullscreen_Lcom_applovin_sdk_AppLovinAd_Lcom_applovin_adview_AppLovinAdView_));
			}
			return IAppLovinAdViewEventListenerInvoker.cb_adOpenedFullscreen_Lcom_applovin_sdk_AppLovinAd_Lcom_applovin_adview_AppLovinAdView_;
		}

		// Token: 0x060012EC RID: 4844 RVA: 0x00036B74 File Offset: 0x00034D74
		private static void n_AdOpenedFullscreen_Lcom_applovin_sdk_AppLovinAd_Lcom_applovin_adview_AppLovinAdView_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			IAppLovinAdViewEventListener @object = Java.Lang.Object.GetObject<IAppLovinAdViewEventListener>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			IAppLovinAd object2 = Java.Lang.Object.GetObject<IAppLovinAd>(native_p0, JniHandleOwnership.DoNotTransfer);
			AppLovinAdView object3 = Java.Lang.Object.GetObject<AppLovinAdView>(native_p1, JniHandleOwnership.DoNotTransfer);
			@object.AdOpenedFullscreen(object2, object3);
		}

		// Token: 0x060012ED RID: 4845 RVA: 0x00036BA0 File Offset: 0x00034DA0
		public unsafe void AdOpenedFullscreen(IAppLovinAd p0, AppLovinAdView p1)
		{
			if (this.id_adOpenedFullscreen_Lcom_applovin_sdk_AppLovinAd_Lcom_applovin_adview_AppLovinAdView_ == IntPtr.Zero)
			{
				this.id_adOpenedFullscreen_Lcom_applovin_sdk_AppLovinAd_Lcom_applovin_adview_AppLovinAdView_ = JNIEnv.GetMethodID(this.class_ref, "adOpenedFullscreen", "(Lcom/applovin/sdk/AppLovinAd;Lcom/applovin/adview/AppLovinAdView;)V");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue((p0 == null) ? IntPtr.Zero : ((Java.Lang.Object)p0).Handle);
			ptr[1] = new JValue((p1 == null) ? IntPtr.Zero : p1.Handle);
			JNIEnv.CallVoidMethod(base.Handle, this.id_adOpenedFullscreen_Lcom_applovin_sdk_AppLovinAd_Lcom_applovin_adview_AppLovinAdView_, ptr);
		}

		// Token: 0x04000626 RID: 1574
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/applovin/adview/AppLovinAdViewEventListener", typeof(IAppLovinAdViewEventListenerInvoker));

		// Token: 0x04000627 RID: 1575
		private IntPtr class_ref;

		// Token: 0x04000628 RID: 1576
		private static Delegate cb_adClosedFullscreen_Lcom_applovin_sdk_AppLovinAd_Lcom_applovin_adview_AppLovinAdView_;

		// Token: 0x04000629 RID: 1577
		private IntPtr id_adClosedFullscreen_Lcom_applovin_sdk_AppLovinAd_Lcom_applovin_adview_AppLovinAdView_;

		// Token: 0x0400062A RID: 1578
		private static Delegate cb_adFailedToDisplay_Lcom_applovin_sdk_AppLovinAd_Lcom_applovin_adview_AppLovinAdView_Lcom_applovin_adview_AppLovinAdViewDisplayErrorCode_;

		// Token: 0x0400062B RID: 1579
		private IntPtr id_adFailedToDisplay_Lcom_applovin_sdk_AppLovinAd_Lcom_applovin_adview_AppLovinAdView_Lcom_applovin_adview_AppLovinAdViewDisplayErrorCode_;

		// Token: 0x0400062C RID: 1580
		private static Delegate cb_adLeftApplication_Lcom_applovin_sdk_AppLovinAd_Lcom_applovin_adview_AppLovinAdView_;

		// Token: 0x0400062D RID: 1581
		private IntPtr id_adLeftApplication_Lcom_applovin_sdk_AppLovinAd_Lcom_applovin_adview_AppLovinAdView_;

		// Token: 0x0400062E RID: 1582
		private static Delegate cb_adOpenedFullscreen_Lcom_applovin_sdk_AppLovinAd_Lcom_applovin_adview_AppLovinAdView_;

		// Token: 0x0400062F RID: 1583
		private IntPtr id_adOpenedFullscreen_Lcom_applovin_sdk_AppLovinAd_Lcom_applovin_adview_AppLovinAdView_;
	}
}
