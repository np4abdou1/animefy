using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using Android.Net;
using Android.Runtime;
using Android.Views;
using Java.Interop;
using Java.Lang;

namespace Com.Applovin.Impl.Sdk.NativeAd
{
	// Token: 0x02000147 RID: 327
	[Register("com/applovin/impl/sdk/nativeAd/AppLovinNativeAd", DoNotGenerateAcw = true)]
	internal class IAppLovinNativeAdInvoker : Java.Lang.Object, IAppLovinNativeAd, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x1700040A RID: 1034
		// (get) Token: 0x06000FE6 RID: 4070 RVA: 0x0002E7D8 File Offset: 0x0002C9D8
		private static IntPtr java_class_ref
		{
			get
			{
				return IAppLovinNativeAdInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700040B RID: 1035
		// (get) Token: 0x06000FE7 RID: 4071 RVA: 0x0002E7FC File Offset: 0x0002C9FC
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return IAppLovinNativeAdInvoker._members;
			}
		}

		// Token: 0x1700040C RID: 1036
		// (get) Token: 0x06000FE8 RID: 4072 RVA: 0x0002E803 File Offset: 0x0002CA03
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x1700040D RID: 1037
		// (get) Token: 0x06000FE9 RID: 4073 RVA: 0x0002E80B File Offset: 0x0002CA0B
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return IAppLovinNativeAdInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x06000FEA RID: 4074 RVA: 0x0002E817 File Offset: 0x0002CA17
		public static IAppLovinNativeAd GetObject(IntPtr handle, JniHandleOwnership transfer)
		{
			return Java.Lang.Object.GetObject<IAppLovinNativeAd>(handle, transfer);
		}

		// Token: 0x06000FEB RID: 4075 RVA: 0x0002E820 File Offset: 0x0002CA20
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, IAppLovinNativeAdInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'com.applovin.impl.sdk.nativeAd.AppLovinNativeAd'.");
			}
			return handle;
		}

		// Token: 0x06000FEC RID: 4076 RVA: 0x0002E84B File Offset: 0x0002CA4B
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x06000FED RID: 4077 RVA: 0x0002E87C File Offset: 0x0002CA7C
		public IAppLovinNativeAdInvoker(IntPtr handle, JniHandleOwnership transfer) : base(IAppLovinNativeAdInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x06000FEE RID: 4078 RVA: 0x0002E8B4 File Offset: 0x0002CAB4
		private static Delegate GetGetAdIdNumberHandler()
		{
			if (IAppLovinNativeAdInvoker.cb_getAdIdNumber == null)
			{
				IAppLovinNativeAdInvoker.cb_getAdIdNumber = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_J(IAppLovinNativeAdInvoker.n_GetAdIdNumber));
			}
			return IAppLovinNativeAdInvoker.cb_getAdIdNumber;
		}

		// Token: 0x06000FEF RID: 4079 RVA: 0x0002E8D8 File Offset: 0x0002CAD8
		private static long n_GetAdIdNumber(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<IAppLovinNativeAd>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).AdIdNumber;
		}

		// Token: 0x1700040E RID: 1038
		// (get) Token: 0x06000FF0 RID: 4080 RVA: 0x0002E8E7 File Offset: 0x0002CAE7
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

		// Token: 0x06000FF1 RID: 4081 RVA: 0x0002E927 File Offset: 0x0002CB27
		private static Delegate GetGetAdvertiserHandler()
		{
			if (IAppLovinNativeAdInvoker.cb_getAdvertiser == null)
			{
				IAppLovinNativeAdInvoker.cb_getAdvertiser = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IAppLovinNativeAdInvoker.n_GetAdvertiser));
			}
			return IAppLovinNativeAdInvoker.cb_getAdvertiser;
		}

		// Token: 0x06000FF2 RID: 4082 RVA: 0x0002E94B File Offset: 0x0002CB4B
		private static IntPtr n_GetAdvertiser(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.NewString(Java.Lang.Object.GetObject<IAppLovinNativeAd>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Advertiser);
		}

		// Token: 0x1700040F RID: 1039
		// (get) Token: 0x06000FF3 RID: 4083 RVA: 0x0002E960 File Offset: 0x0002CB60
		public string Advertiser
		{
			get
			{
				if (this.id_getAdvertiser == IntPtr.Zero)
				{
					this.id_getAdvertiser = JNIEnv.GetMethodID(this.class_ref, "getAdvertiser", "()Ljava/lang/String;");
				}
				return JNIEnv.GetString(JNIEnv.CallObjectMethod(base.Handle, this.id_getAdvertiser), JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x06000FF4 RID: 4084 RVA: 0x0002E9B1 File Offset: 0x0002CBB1
		private static Delegate GetGetBodyHandler()
		{
			if (IAppLovinNativeAdInvoker.cb_getBody == null)
			{
				IAppLovinNativeAdInvoker.cb_getBody = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IAppLovinNativeAdInvoker.n_GetBody));
			}
			return IAppLovinNativeAdInvoker.cb_getBody;
		}

		// Token: 0x06000FF5 RID: 4085 RVA: 0x0002E9D5 File Offset: 0x0002CBD5
		private static IntPtr n_GetBody(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.NewString(Java.Lang.Object.GetObject<IAppLovinNativeAd>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Body);
		}

		// Token: 0x17000410 RID: 1040
		// (get) Token: 0x06000FF6 RID: 4086 RVA: 0x0002E9EC File Offset: 0x0002CBEC
		public string Body
		{
			get
			{
				if (this.id_getBody == IntPtr.Zero)
				{
					this.id_getBody = JNIEnv.GetMethodID(this.class_ref, "getBody", "()Ljava/lang/String;");
				}
				return JNIEnv.GetString(JNIEnv.CallObjectMethod(base.Handle, this.id_getBody), JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x06000FF7 RID: 4087 RVA: 0x0002EA3D File Offset: 0x0002CC3D
		private static Delegate GetGetCallToActionHandler()
		{
			if (IAppLovinNativeAdInvoker.cb_getCallToAction == null)
			{
				IAppLovinNativeAdInvoker.cb_getCallToAction = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IAppLovinNativeAdInvoker.n_GetCallToAction));
			}
			return IAppLovinNativeAdInvoker.cb_getCallToAction;
		}

		// Token: 0x06000FF8 RID: 4088 RVA: 0x0002EA61 File Offset: 0x0002CC61
		private static IntPtr n_GetCallToAction(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.NewString(Java.Lang.Object.GetObject<IAppLovinNativeAd>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).CallToAction);
		}

		// Token: 0x17000411 RID: 1041
		// (get) Token: 0x06000FF9 RID: 4089 RVA: 0x0002EA78 File Offset: 0x0002CC78
		public string CallToAction
		{
			get
			{
				if (this.id_getCallToAction == IntPtr.Zero)
				{
					this.id_getCallToAction = JNIEnv.GetMethodID(this.class_ref, "getCallToAction", "()Ljava/lang/String;");
				}
				return JNIEnv.GetString(JNIEnv.CallObjectMethod(base.Handle, this.id_getCallToAction), JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x06000FFA RID: 4090 RVA: 0x0002EAC9 File Offset: 0x0002CCC9
		private static Delegate GetGetIconUriHandler()
		{
			if (IAppLovinNativeAdInvoker.cb_getIconUri == null)
			{
				IAppLovinNativeAdInvoker.cb_getIconUri = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IAppLovinNativeAdInvoker.n_GetIconUri));
			}
			return IAppLovinNativeAdInvoker.cb_getIconUri;
		}

		// Token: 0x06000FFB RID: 4091 RVA: 0x0002EAED File Offset: 0x0002CCED
		private static IntPtr n_GetIconUri(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<IAppLovinNativeAd>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).IconUri);
		}

		// Token: 0x17000412 RID: 1042
		// (get) Token: 0x06000FFC RID: 4092 RVA: 0x0002EB04 File Offset: 0x0002CD04
		public Android.Net.Uri IconUri
		{
			get
			{
				if (this.id_getIconUri == IntPtr.Zero)
				{
					this.id_getIconUri = JNIEnv.GetMethodID(this.class_ref, "getIconUri", "()Landroid/net/Uri;");
				}
				return Java.Lang.Object.GetObject<Android.Net.Uri>(JNIEnv.CallObjectMethod(base.Handle, this.id_getIconUri), JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x06000FFD RID: 4093 RVA: 0x0002EB55 File Offset: 0x0002CD55
		private static Delegate GetGetMediaViewHandler()
		{
			if (IAppLovinNativeAdInvoker.cb_getMediaView == null)
			{
				IAppLovinNativeAdInvoker.cb_getMediaView = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IAppLovinNativeAdInvoker.n_GetMediaView));
			}
			return IAppLovinNativeAdInvoker.cb_getMediaView;
		}

		// Token: 0x06000FFE RID: 4094 RVA: 0x0002EB79 File Offset: 0x0002CD79
		private static IntPtr n_GetMediaView(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<IAppLovinNativeAd>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).MediaView);
		}

		// Token: 0x17000413 RID: 1043
		// (get) Token: 0x06000FFF RID: 4095 RVA: 0x0002EB90 File Offset: 0x0002CD90
		public AppLovinMediaView MediaView
		{
			get
			{
				if (this.id_getMediaView == IntPtr.Zero)
				{
					this.id_getMediaView = JNIEnv.GetMethodID(this.class_ref, "getMediaView", "()Lcom/applovin/impl/sdk/nativeAd/AppLovinMediaView;");
				}
				return Java.Lang.Object.GetObject<AppLovinMediaView>(JNIEnv.CallObjectMethod(base.Handle, this.id_getMediaView), JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x06001000 RID: 4096 RVA: 0x0002EBE1 File Offset: 0x0002CDE1
		private static Delegate GetGetOptionsViewHandler()
		{
			if (IAppLovinNativeAdInvoker.cb_getOptionsView == null)
			{
				IAppLovinNativeAdInvoker.cb_getOptionsView = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IAppLovinNativeAdInvoker.n_GetOptionsView));
			}
			return IAppLovinNativeAdInvoker.cb_getOptionsView;
		}

		// Token: 0x06001001 RID: 4097 RVA: 0x0002EC05 File Offset: 0x0002CE05
		private static IntPtr n_GetOptionsView(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<IAppLovinNativeAd>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).OptionsView);
		}

		// Token: 0x17000414 RID: 1044
		// (get) Token: 0x06001002 RID: 4098 RVA: 0x0002EC1C File Offset: 0x0002CE1C
		public AppLovinOptionsView OptionsView
		{
			get
			{
				if (this.id_getOptionsView == IntPtr.Zero)
				{
					this.id_getOptionsView = JNIEnv.GetMethodID(this.class_ref, "getOptionsView", "()Lcom/applovin/impl/sdk/nativeAd/AppLovinOptionsView;");
				}
				return Java.Lang.Object.GetObject<AppLovinOptionsView>(JNIEnv.CallObjectMethod(base.Handle, this.id_getOptionsView), JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x06001003 RID: 4099 RVA: 0x0002EC6D File Offset: 0x0002CE6D
		private static Delegate GetGetTitleHandler()
		{
			if (IAppLovinNativeAdInvoker.cb_getTitle == null)
			{
				IAppLovinNativeAdInvoker.cb_getTitle = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IAppLovinNativeAdInvoker.n_GetTitle));
			}
			return IAppLovinNativeAdInvoker.cb_getTitle;
		}

		// Token: 0x06001004 RID: 4100 RVA: 0x0002EC91 File Offset: 0x0002CE91
		private static IntPtr n_GetTitle(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.NewString(Java.Lang.Object.GetObject<IAppLovinNativeAd>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Title);
		}

		// Token: 0x17000415 RID: 1045
		// (get) Token: 0x06001005 RID: 4101 RVA: 0x0002ECA8 File Offset: 0x0002CEA8
		public string Title
		{
			get
			{
				if (this.id_getTitle == IntPtr.Zero)
				{
					this.id_getTitle = JNIEnv.GetMethodID(this.class_ref, "getTitle", "()Ljava/lang/String;");
				}
				return JNIEnv.GetString(JNIEnv.CallObjectMethod(base.Handle, this.id_getTitle), JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x06001006 RID: 4102 RVA: 0x0002ECF9 File Offset: 0x0002CEF9
		private static Delegate GetDestroyHandler()
		{
			if (IAppLovinNativeAdInvoker.cb_destroy == null)
			{
				IAppLovinNativeAdInvoker.cb_destroy = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_V(IAppLovinNativeAdInvoker.n_Destroy));
			}
			return IAppLovinNativeAdInvoker.cb_destroy;
		}

		// Token: 0x06001007 RID: 4103 RVA: 0x0002ED1D File Offset: 0x0002CF1D
		private static void n_Destroy(IntPtr jnienv, IntPtr native__this)
		{
			Java.Lang.Object.GetObject<IAppLovinNativeAd>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Destroy();
		}

		// Token: 0x06001008 RID: 4104 RVA: 0x0002ED2C File Offset: 0x0002CF2C
		public void Destroy()
		{
			if (this.id_destroy == IntPtr.Zero)
			{
				this.id_destroy = JNIEnv.GetMethodID(this.class_ref, "destroy", "()V");
			}
			JNIEnv.CallVoidMethod(base.Handle, this.id_destroy);
		}

		// Token: 0x06001009 RID: 4105 RVA: 0x0002ED6C File Offset: 0x0002CF6C
		private static Delegate GetRegisterViewsForInteraction_Ljava_util_List_Handler()
		{
			if (IAppLovinNativeAdInvoker.cb_registerViewsForInteraction_Ljava_util_List_ == null)
			{
				IAppLovinNativeAdInvoker.cb_registerViewsForInteraction_Ljava_util_List_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(IAppLovinNativeAdInvoker.n_RegisterViewsForInteraction_Ljava_util_List_));
			}
			return IAppLovinNativeAdInvoker.cb_registerViewsForInteraction_Ljava_util_List_;
		}

		// Token: 0x0600100A RID: 4106 RVA: 0x0002ED90 File Offset: 0x0002CF90
		private static void n_RegisterViewsForInteraction_Ljava_util_List_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			IAppLovinNativeAd @object = Java.Lang.Object.GetObject<IAppLovinNativeAd>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			IList<View> p = JavaList<View>.FromJniHandle(native_p0, JniHandleOwnership.DoNotTransfer);
			@object.RegisterViewsForInteraction(p);
		}

		// Token: 0x0600100B RID: 4107 RVA: 0x0002EDB4 File Offset: 0x0002CFB4
		public unsafe void RegisterViewsForInteraction(IList<View> p0)
		{
			if (this.id_registerViewsForInteraction_Ljava_util_List_ == IntPtr.Zero)
			{
				this.id_registerViewsForInteraction_Ljava_util_List_ = JNIEnv.GetMethodID(this.class_ref, "registerViewsForInteraction", "(Ljava/util/List;)V");
			}
			IntPtr intPtr = JavaList<View>.ToLocalJniHandle(p0);
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue(intPtr);
			JNIEnv.CallVoidMethod(base.Handle, this.id_registerViewsForInteraction_Ljava_util_List_, ptr);
			JNIEnv.DeleteLocalRef(intPtr);
		}

		// Token: 0x0600100C RID: 4108 RVA: 0x0002EE25 File Offset: 0x0002D025
		private static Delegate GetUnregisterViewsForInteractionHandler()
		{
			if (IAppLovinNativeAdInvoker.cb_unregisterViewsForInteraction == null)
			{
				IAppLovinNativeAdInvoker.cb_unregisterViewsForInteraction = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_V(IAppLovinNativeAdInvoker.n_UnregisterViewsForInteraction));
			}
			return IAppLovinNativeAdInvoker.cb_unregisterViewsForInteraction;
		}

		// Token: 0x0600100D RID: 4109 RVA: 0x0002EE49 File Offset: 0x0002D049
		private static void n_UnregisterViewsForInteraction(IntPtr jnienv, IntPtr native__this)
		{
			Java.Lang.Object.GetObject<IAppLovinNativeAd>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).UnregisterViewsForInteraction();
		}

		// Token: 0x0600100E RID: 4110 RVA: 0x0002EE58 File Offset: 0x0002D058
		public void UnregisterViewsForInteraction()
		{
			if (this.id_unregisterViewsForInteraction == IntPtr.Zero)
			{
				this.id_unregisterViewsForInteraction = JNIEnv.GetMethodID(this.class_ref, "unregisterViewsForInteraction", "()V");
			}
			JNIEnv.CallVoidMethod(base.Handle, this.id_unregisterViewsForInteraction);
		}

		// Token: 0x04000535 RID: 1333
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/applovin/impl/sdk/nativeAd/AppLovinNativeAd", typeof(IAppLovinNativeAdInvoker));

		// Token: 0x04000536 RID: 1334
		private IntPtr class_ref;

		// Token: 0x04000537 RID: 1335
		private static Delegate cb_getAdIdNumber;

		// Token: 0x04000538 RID: 1336
		private IntPtr id_getAdIdNumber;

		// Token: 0x04000539 RID: 1337
		private static Delegate cb_getAdvertiser;

		// Token: 0x0400053A RID: 1338
		private IntPtr id_getAdvertiser;

		// Token: 0x0400053B RID: 1339
		private static Delegate cb_getBody;

		// Token: 0x0400053C RID: 1340
		private IntPtr id_getBody;

		// Token: 0x0400053D RID: 1341
		private static Delegate cb_getCallToAction;

		// Token: 0x0400053E RID: 1342
		private IntPtr id_getCallToAction;

		// Token: 0x0400053F RID: 1343
		private static Delegate cb_getIconUri;

		// Token: 0x04000540 RID: 1344
		private IntPtr id_getIconUri;

		// Token: 0x04000541 RID: 1345
		private static Delegate cb_getMediaView;

		// Token: 0x04000542 RID: 1346
		private IntPtr id_getMediaView;

		// Token: 0x04000543 RID: 1347
		private static Delegate cb_getOptionsView;

		// Token: 0x04000544 RID: 1348
		private IntPtr id_getOptionsView;

		// Token: 0x04000545 RID: 1349
		private static Delegate cb_getTitle;

		// Token: 0x04000546 RID: 1350
		private IntPtr id_getTitle;

		// Token: 0x04000547 RID: 1351
		private static Delegate cb_destroy;

		// Token: 0x04000548 RID: 1352
		private IntPtr id_destroy;

		// Token: 0x04000549 RID: 1353
		private static Delegate cb_registerViewsForInteraction_Ljava_util_List_;

		// Token: 0x0400054A RID: 1354
		private IntPtr id_registerViewsForInteraction_Ljava_util_List_;

		// Token: 0x0400054B RID: 1355
		private static Delegate cb_unregisterViewsForInteraction;

		// Token: 0x0400054C RID: 1356
		private IntPtr id_unregisterViewsForInteraction;
	}
}
