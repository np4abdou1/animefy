using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Java.Interop;
using Java.Lang;

namespace Com.Unity3d.Services.Ads.Adunit
{
	// Token: 0x02000232 RID: 562
	[Register("com/unity3d/services/ads/adunit/IAdUnitViewHandler", DoNotGenerateAcw = true)]
	internal class IAdUnitViewHandlerInvoker : Java.Lang.Object, IAdUnitViewHandler, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x17000928 RID: 2344
		// (get) Token: 0x06001ADF RID: 6879 RVA: 0x0004E73C File Offset: 0x0004C93C
		private static IntPtr java_class_ref
		{
			get
			{
				return IAdUnitViewHandlerInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000929 RID: 2345
		// (get) Token: 0x06001AE0 RID: 6880 RVA: 0x0004E760 File Offset: 0x0004C960
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return IAdUnitViewHandlerInvoker._members;
			}
		}

		// Token: 0x1700092A RID: 2346
		// (get) Token: 0x06001AE1 RID: 6881 RVA: 0x0004E767 File Offset: 0x0004C967
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x1700092B RID: 2347
		// (get) Token: 0x06001AE2 RID: 6882 RVA: 0x0004E76F File Offset: 0x0004C96F
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return IAdUnitViewHandlerInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x06001AE3 RID: 6883 RVA: 0x0004E77B File Offset: 0x0004C97B
		public static IAdUnitViewHandler GetObject(IntPtr handle, JniHandleOwnership transfer)
		{
			return Java.Lang.Object.GetObject<IAdUnitViewHandler>(handle, transfer);
		}

		// Token: 0x06001AE4 RID: 6884 RVA: 0x0004E784 File Offset: 0x0004C984
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, IAdUnitViewHandlerInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'com.unity3d.services.ads.adunit.IAdUnitViewHandler'.");
			}
			return handle;
		}

		// Token: 0x06001AE5 RID: 6885 RVA: 0x0004E7AF File Offset: 0x0004C9AF
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x06001AE6 RID: 6886 RVA: 0x0004E7E0 File Offset: 0x0004C9E0
		public IAdUnitViewHandlerInvoker(IntPtr handle, JniHandleOwnership transfer) : base(IAdUnitViewHandlerInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x06001AE7 RID: 6887 RVA: 0x0004E818 File Offset: 0x0004CA18
		private static Delegate GetGetViewHandler()
		{
			if (IAdUnitViewHandlerInvoker.cb_getView == null)
			{
				IAdUnitViewHandlerInvoker.cb_getView = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IAdUnitViewHandlerInvoker.n_GetView));
			}
			return IAdUnitViewHandlerInvoker.cb_getView;
		}

		// Token: 0x06001AE8 RID: 6888 RVA: 0x0004E83C File Offset: 0x0004CA3C
		private static IntPtr n_GetView(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<IAdUnitViewHandler>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).View);
		}

		// Token: 0x1700092C RID: 2348
		// (get) Token: 0x06001AE9 RID: 6889 RVA: 0x0004E850 File Offset: 0x0004CA50
		public View View
		{
			get
			{
				if (this.id_getView == IntPtr.Zero)
				{
					this.id_getView = JNIEnv.GetMethodID(this.class_ref, "getView", "()Landroid/view/View;");
				}
				return Java.Lang.Object.GetObject<View>(JNIEnv.CallObjectMethod(base.Handle, this.id_getView), JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x06001AEA RID: 6890 RVA: 0x0004E8A1 File Offset: 0x0004CAA1
		private static Delegate GetCreate_Lcom_unity3d_services_ads_adunit_AdUnitActivity_Handler()
		{
			if (IAdUnitViewHandlerInvoker.cb_create_Lcom_unity3d_services_ads_adunit_AdUnitActivity_ == null)
			{
				IAdUnitViewHandlerInvoker.cb_create_Lcom_unity3d_services_ads_adunit_AdUnitActivity_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_Z(IAdUnitViewHandlerInvoker.n_Create_Lcom_unity3d_services_ads_adunit_AdUnitActivity_));
			}
			return IAdUnitViewHandlerInvoker.cb_create_Lcom_unity3d_services_ads_adunit_AdUnitActivity_;
		}

		// Token: 0x06001AEB RID: 6891 RVA: 0x0004E8C8 File Offset: 0x0004CAC8
		private static bool n_Create_Lcom_unity3d_services_ads_adunit_AdUnitActivity_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			IAdUnitViewHandler @object = Java.Lang.Object.GetObject<IAdUnitViewHandler>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			AdUnitActivity object2 = Java.Lang.Object.GetObject<AdUnitActivity>(native_p0, JniHandleOwnership.DoNotTransfer);
			return @object.Create(object2);
		}

		// Token: 0x06001AEC RID: 6892 RVA: 0x0004E8EC File Offset: 0x0004CAEC
		public unsafe bool Create(AdUnitActivity p0)
		{
			if (this.id_create_Lcom_unity3d_services_ads_adunit_AdUnitActivity_ == IntPtr.Zero)
			{
				this.id_create_Lcom_unity3d_services_ads_adunit_AdUnitActivity_ = JNIEnv.GetMethodID(this.class_ref, "create", "(Lcom/unity3d/services/ads/adunit/AdUnitActivity;)Z");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue((p0 == null) ? IntPtr.Zero : p0.Handle);
			return JNIEnv.CallBooleanMethod(base.Handle, this.id_create_Lcom_unity3d_services_ads_adunit_AdUnitActivity_, ptr);
		}

		// Token: 0x06001AED RID: 6893 RVA: 0x0004E95F File Offset: 0x0004CB5F
		private static Delegate GetDestroyHandler()
		{
			if (IAdUnitViewHandlerInvoker.cb_destroy == null)
			{
				IAdUnitViewHandlerInvoker.cb_destroy = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(IAdUnitViewHandlerInvoker.n_Destroy));
			}
			return IAdUnitViewHandlerInvoker.cb_destroy;
		}

		// Token: 0x06001AEE RID: 6894 RVA: 0x0004E983 File Offset: 0x0004CB83
		private static bool n_Destroy(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<IAdUnitViewHandler>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Destroy();
		}

		// Token: 0x06001AEF RID: 6895 RVA: 0x0004E992 File Offset: 0x0004CB92
		public bool Destroy()
		{
			if (this.id_destroy == IntPtr.Zero)
			{
				this.id_destroy = JNIEnv.GetMethodID(this.class_ref, "destroy", "()Z");
			}
			return JNIEnv.CallBooleanMethod(base.Handle, this.id_destroy);
		}

		// Token: 0x06001AF0 RID: 6896 RVA: 0x0004E9D2 File Offset: 0x0004CBD2
		private static Delegate GetOnCreate_Lcom_unity3d_services_ads_adunit_AdUnitActivity_Landroid_os_Bundle_Handler()
		{
			if (IAdUnitViewHandlerInvoker.cb_onCreate_Lcom_unity3d_services_ads_adunit_AdUnitActivity_Landroid_os_Bundle_ == null)
			{
				IAdUnitViewHandlerInvoker.cb_onCreate_Lcom_unity3d_services_ads_adunit_AdUnitActivity_Landroid_os_Bundle_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_V(IAdUnitViewHandlerInvoker.n_OnCreate_Lcom_unity3d_services_ads_adunit_AdUnitActivity_Landroid_os_Bundle_));
			}
			return IAdUnitViewHandlerInvoker.cb_onCreate_Lcom_unity3d_services_ads_adunit_AdUnitActivity_Landroid_os_Bundle_;
		}

		// Token: 0x06001AF1 RID: 6897 RVA: 0x0004E9F8 File Offset: 0x0004CBF8
		private static void n_OnCreate_Lcom_unity3d_services_ads_adunit_AdUnitActivity_Landroid_os_Bundle_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			IAdUnitViewHandler @object = Java.Lang.Object.GetObject<IAdUnitViewHandler>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			AdUnitActivity object2 = Java.Lang.Object.GetObject<AdUnitActivity>(native_p0, JniHandleOwnership.DoNotTransfer);
			Bundle object3 = Java.Lang.Object.GetObject<Bundle>(native_p1, JniHandleOwnership.DoNotTransfer);
			@object.OnCreate(object2, object3);
		}

		// Token: 0x06001AF2 RID: 6898 RVA: 0x0004EA24 File Offset: 0x0004CC24
		public unsafe void OnCreate(AdUnitActivity p0, Bundle p1)
		{
			if (this.id_onCreate_Lcom_unity3d_services_ads_adunit_AdUnitActivity_Landroid_os_Bundle_ == IntPtr.Zero)
			{
				this.id_onCreate_Lcom_unity3d_services_ads_adunit_AdUnitActivity_Landroid_os_Bundle_ = JNIEnv.GetMethodID(this.class_ref, "onCreate", "(Lcom/unity3d/services/ads/adunit/AdUnitActivity;Landroid/os/Bundle;)V");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue((p0 == null) ? IntPtr.Zero : p0.Handle);
			ptr[1] = new JValue((p1 == null) ? IntPtr.Zero : p1.Handle);
			JNIEnv.CallVoidMethod(base.Handle, this.id_onCreate_Lcom_unity3d_services_ads_adunit_AdUnitActivity_Landroid_os_Bundle_, ptr);
		}

		// Token: 0x06001AF3 RID: 6899 RVA: 0x0004EAB9 File Offset: 0x0004CCB9
		private static Delegate GetOnDestroy_Lcom_unity3d_services_ads_adunit_AdUnitActivity_Handler()
		{
			if (IAdUnitViewHandlerInvoker.cb_onDestroy_Lcom_unity3d_services_ads_adunit_AdUnitActivity_ == null)
			{
				IAdUnitViewHandlerInvoker.cb_onDestroy_Lcom_unity3d_services_ads_adunit_AdUnitActivity_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(IAdUnitViewHandlerInvoker.n_OnDestroy_Lcom_unity3d_services_ads_adunit_AdUnitActivity_));
			}
			return IAdUnitViewHandlerInvoker.cb_onDestroy_Lcom_unity3d_services_ads_adunit_AdUnitActivity_;
		}

		// Token: 0x06001AF4 RID: 6900 RVA: 0x0004EAE0 File Offset: 0x0004CCE0
		private static void n_OnDestroy_Lcom_unity3d_services_ads_adunit_AdUnitActivity_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			IAdUnitViewHandler @object = Java.Lang.Object.GetObject<IAdUnitViewHandler>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			AdUnitActivity object2 = Java.Lang.Object.GetObject<AdUnitActivity>(native_p0, JniHandleOwnership.DoNotTransfer);
			@object.OnDestroy(object2);
		}

		// Token: 0x06001AF5 RID: 6901 RVA: 0x0004EB04 File Offset: 0x0004CD04
		public unsafe void OnDestroy(AdUnitActivity p0)
		{
			if (this.id_onDestroy_Lcom_unity3d_services_ads_adunit_AdUnitActivity_ == IntPtr.Zero)
			{
				this.id_onDestroy_Lcom_unity3d_services_ads_adunit_AdUnitActivity_ = JNIEnv.GetMethodID(this.class_ref, "onDestroy", "(Lcom/unity3d/services/ads/adunit/AdUnitActivity;)V");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue((p0 == null) ? IntPtr.Zero : p0.Handle);
			JNIEnv.CallVoidMethod(base.Handle, this.id_onDestroy_Lcom_unity3d_services_ads_adunit_AdUnitActivity_, ptr);
		}

		// Token: 0x06001AF6 RID: 6902 RVA: 0x0004EB77 File Offset: 0x0004CD77
		private static Delegate GetOnPause_Lcom_unity3d_services_ads_adunit_AdUnitActivity_Handler()
		{
			if (IAdUnitViewHandlerInvoker.cb_onPause_Lcom_unity3d_services_ads_adunit_AdUnitActivity_ == null)
			{
				IAdUnitViewHandlerInvoker.cb_onPause_Lcom_unity3d_services_ads_adunit_AdUnitActivity_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(IAdUnitViewHandlerInvoker.n_OnPause_Lcom_unity3d_services_ads_adunit_AdUnitActivity_));
			}
			return IAdUnitViewHandlerInvoker.cb_onPause_Lcom_unity3d_services_ads_adunit_AdUnitActivity_;
		}

		// Token: 0x06001AF7 RID: 6903 RVA: 0x0004EB9C File Offset: 0x0004CD9C
		private static void n_OnPause_Lcom_unity3d_services_ads_adunit_AdUnitActivity_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			IAdUnitViewHandler @object = Java.Lang.Object.GetObject<IAdUnitViewHandler>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			AdUnitActivity object2 = Java.Lang.Object.GetObject<AdUnitActivity>(native_p0, JniHandleOwnership.DoNotTransfer);
			@object.OnPause(object2);
		}

		// Token: 0x06001AF8 RID: 6904 RVA: 0x0004EBC0 File Offset: 0x0004CDC0
		public unsafe void OnPause(AdUnitActivity p0)
		{
			if (this.id_onPause_Lcom_unity3d_services_ads_adunit_AdUnitActivity_ == IntPtr.Zero)
			{
				this.id_onPause_Lcom_unity3d_services_ads_adunit_AdUnitActivity_ = JNIEnv.GetMethodID(this.class_ref, "onPause", "(Lcom/unity3d/services/ads/adunit/AdUnitActivity;)V");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue((p0 == null) ? IntPtr.Zero : p0.Handle);
			JNIEnv.CallVoidMethod(base.Handle, this.id_onPause_Lcom_unity3d_services_ads_adunit_AdUnitActivity_, ptr);
		}

		// Token: 0x06001AF9 RID: 6905 RVA: 0x0004EC33 File Offset: 0x0004CE33
		private static Delegate GetOnResume_Lcom_unity3d_services_ads_adunit_AdUnitActivity_Handler()
		{
			if (IAdUnitViewHandlerInvoker.cb_onResume_Lcom_unity3d_services_ads_adunit_AdUnitActivity_ == null)
			{
				IAdUnitViewHandlerInvoker.cb_onResume_Lcom_unity3d_services_ads_adunit_AdUnitActivity_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(IAdUnitViewHandlerInvoker.n_OnResume_Lcom_unity3d_services_ads_adunit_AdUnitActivity_));
			}
			return IAdUnitViewHandlerInvoker.cb_onResume_Lcom_unity3d_services_ads_adunit_AdUnitActivity_;
		}

		// Token: 0x06001AFA RID: 6906 RVA: 0x0004EC58 File Offset: 0x0004CE58
		private static void n_OnResume_Lcom_unity3d_services_ads_adunit_AdUnitActivity_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			IAdUnitViewHandler @object = Java.Lang.Object.GetObject<IAdUnitViewHandler>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			AdUnitActivity object2 = Java.Lang.Object.GetObject<AdUnitActivity>(native_p0, JniHandleOwnership.DoNotTransfer);
			@object.OnResume(object2);
		}

		// Token: 0x06001AFB RID: 6907 RVA: 0x0004EC7C File Offset: 0x0004CE7C
		public unsafe void OnResume(AdUnitActivity p0)
		{
			if (this.id_onResume_Lcom_unity3d_services_ads_adunit_AdUnitActivity_ == IntPtr.Zero)
			{
				this.id_onResume_Lcom_unity3d_services_ads_adunit_AdUnitActivity_ = JNIEnv.GetMethodID(this.class_ref, "onResume", "(Lcom/unity3d/services/ads/adunit/AdUnitActivity;)V");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue((p0 == null) ? IntPtr.Zero : p0.Handle);
			JNIEnv.CallVoidMethod(base.Handle, this.id_onResume_Lcom_unity3d_services_ads_adunit_AdUnitActivity_, ptr);
		}

		// Token: 0x06001AFC RID: 6908 RVA: 0x0004ECEF File Offset: 0x0004CEEF
		private static Delegate GetOnStart_Lcom_unity3d_services_ads_adunit_AdUnitActivity_Handler()
		{
			if (IAdUnitViewHandlerInvoker.cb_onStart_Lcom_unity3d_services_ads_adunit_AdUnitActivity_ == null)
			{
				IAdUnitViewHandlerInvoker.cb_onStart_Lcom_unity3d_services_ads_adunit_AdUnitActivity_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(IAdUnitViewHandlerInvoker.n_OnStart_Lcom_unity3d_services_ads_adunit_AdUnitActivity_));
			}
			return IAdUnitViewHandlerInvoker.cb_onStart_Lcom_unity3d_services_ads_adunit_AdUnitActivity_;
		}

		// Token: 0x06001AFD RID: 6909 RVA: 0x0004ED14 File Offset: 0x0004CF14
		private static void n_OnStart_Lcom_unity3d_services_ads_adunit_AdUnitActivity_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			IAdUnitViewHandler @object = Java.Lang.Object.GetObject<IAdUnitViewHandler>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			AdUnitActivity object2 = Java.Lang.Object.GetObject<AdUnitActivity>(native_p0, JniHandleOwnership.DoNotTransfer);
			@object.OnStart(object2);
		}

		// Token: 0x06001AFE RID: 6910 RVA: 0x0004ED38 File Offset: 0x0004CF38
		public unsafe void OnStart(AdUnitActivity p0)
		{
			if (this.id_onStart_Lcom_unity3d_services_ads_adunit_AdUnitActivity_ == IntPtr.Zero)
			{
				this.id_onStart_Lcom_unity3d_services_ads_adunit_AdUnitActivity_ = JNIEnv.GetMethodID(this.class_ref, "onStart", "(Lcom/unity3d/services/ads/adunit/AdUnitActivity;)V");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue((p0 == null) ? IntPtr.Zero : p0.Handle);
			JNIEnv.CallVoidMethod(base.Handle, this.id_onStart_Lcom_unity3d_services_ads_adunit_AdUnitActivity_, ptr);
		}

		// Token: 0x06001AFF RID: 6911 RVA: 0x0004EDAB File Offset: 0x0004CFAB
		private static Delegate GetOnStop_Lcom_unity3d_services_ads_adunit_AdUnitActivity_Handler()
		{
			if (IAdUnitViewHandlerInvoker.cb_onStop_Lcom_unity3d_services_ads_adunit_AdUnitActivity_ == null)
			{
				IAdUnitViewHandlerInvoker.cb_onStop_Lcom_unity3d_services_ads_adunit_AdUnitActivity_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(IAdUnitViewHandlerInvoker.n_OnStop_Lcom_unity3d_services_ads_adunit_AdUnitActivity_));
			}
			return IAdUnitViewHandlerInvoker.cb_onStop_Lcom_unity3d_services_ads_adunit_AdUnitActivity_;
		}

		// Token: 0x06001B00 RID: 6912 RVA: 0x0004EDD0 File Offset: 0x0004CFD0
		private static void n_OnStop_Lcom_unity3d_services_ads_adunit_AdUnitActivity_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			IAdUnitViewHandler @object = Java.Lang.Object.GetObject<IAdUnitViewHandler>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			AdUnitActivity object2 = Java.Lang.Object.GetObject<AdUnitActivity>(native_p0, JniHandleOwnership.DoNotTransfer);
			@object.OnStop(object2);
		}

		// Token: 0x06001B01 RID: 6913 RVA: 0x0004EDF4 File Offset: 0x0004CFF4
		public unsafe void OnStop(AdUnitActivity p0)
		{
			if (this.id_onStop_Lcom_unity3d_services_ads_adunit_AdUnitActivity_ == IntPtr.Zero)
			{
				this.id_onStop_Lcom_unity3d_services_ads_adunit_AdUnitActivity_ = JNIEnv.GetMethodID(this.class_ref, "onStop", "(Lcom/unity3d/services/ads/adunit/AdUnitActivity;)V");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue((p0 == null) ? IntPtr.Zero : p0.Handle);
			JNIEnv.CallVoidMethod(base.Handle, this.id_onStop_Lcom_unity3d_services_ads_adunit_AdUnitActivity_, ptr);
		}

		// Token: 0x0400068D RID: 1677
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/unity3d/services/ads/adunit/IAdUnitViewHandler", typeof(IAdUnitViewHandlerInvoker));

		// Token: 0x0400068E RID: 1678
		private IntPtr class_ref;

		// Token: 0x0400068F RID: 1679
		private static Delegate cb_getView;

		// Token: 0x04000690 RID: 1680
		private IntPtr id_getView;

		// Token: 0x04000691 RID: 1681
		private static Delegate cb_create_Lcom_unity3d_services_ads_adunit_AdUnitActivity_;

		// Token: 0x04000692 RID: 1682
		private IntPtr id_create_Lcom_unity3d_services_ads_adunit_AdUnitActivity_;

		// Token: 0x04000693 RID: 1683
		private static Delegate cb_destroy;

		// Token: 0x04000694 RID: 1684
		private IntPtr id_destroy;

		// Token: 0x04000695 RID: 1685
		private static Delegate cb_onCreate_Lcom_unity3d_services_ads_adunit_AdUnitActivity_Landroid_os_Bundle_;

		// Token: 0x04000696 RID: 1686
		private IntPtr id_onCreate_Lcom_unity3d_services_ads_adunit_AdUnitActivity_Landroid_os_Bundle_;

		// Token: 0x04000697 RID: 1687
		private static Delegate cb_onDestroy_Lcom_unity3d_services_ads_adunit_AdUnitActivity_;

		// Token: 0x04000698 RID: 1688
		private IntPtr id_onDestroy_Lcom_unity3d_services_ads_adunit_AdUnitActivity_;

		// Token: 0x04000699 RID: 1689
		private static Delegate cb_onPause_Lcom_unity3d_services_ads_adunit_AdUnitActivity_;

		// Token: 0x0400069A RID: 1690
		private IntPtr id_onPause_Lcom_unity3d_services_ads_adunit_AdUnitActivity_;

		// Token: 0x0400069B RID: 1691
		private static Delegate cb_onResume_Lcom_unity3d_services_ads_adunit_AdUnitActivity_;

		// Token: 0x0400069C RID: 1692
		private IntPtr id_onResume_Lcom_unity3d_services_ads_adunit_AdUnitActivity_;

		// Token: 0x0400069D RID: 1693
		private static Delegate cb_onStart_Lcom_unity3d_services_ads_adunit_AdUnitActivity_;

		// Token: 0x0400069E RID: 1694
		private IntPtr id_onStart_Lcom_unity3d_services_ads_adunit_AdUnitActivity_;

		// Token: 0x0400069F RID: 1695
		private static Delegate cb_onStop_Lcom_unity3d_services_ads_adunit_AdUnitActivity_;

		// Token: 0x040006A0 RID: 1696
		private IntPtr id_onStop_Lcom_unity3d_services_ads_adunit_AdUnitActivity_;
	}
}
