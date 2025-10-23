using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.App;
using Android.Runtime;
using Com.Applovin.Mediation.Adapter.Listeners;
using Com.Applovin.Mediation.Adapter.Parameters;
using Java.Interop;
using Java.Lang;

namespace Com.Applovin.Mediation.Adapter
{
	// Token: 0x02000101 RID: 257
	[Register("com/applovin/mediation/adapter/MaxInterstitialAdapter", DoNotGenerateAcw = true)]
	internal class IMaxInterstitialAdapterInvoker : Java.Lang.Object, IMaxInterstitialAdapter, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x170002F0 RID: 752
		// (get) Token: 0x06000AE5 RID: 2789 RVA: 0x0001D9B4 File Offset: 0x0001BBB4
		private static IntPtr java_class_ref
		{
			get
			{
				return IMaxInterstitialAdapterInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170002F1 RID: 753
		// (get) Token: 0x06000AE6 RID: 2790 RVA: 0x0001D9D8 File Offset: 0x0001BBD8
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return IMaxInterstitialAdapterInvoker._members;
			}
		}

		// Token: 0x170002F2 RID: 754
		// (get) Token: 0x06000AE7 RID: 2791 RVA: 0x0001D9DF File Offset: 0x0001BBDF
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x170002F3 RID: 755
		// (get) Token: 0x06000AE8 RID: 2792 RVA: 0x0001D9E7 File Offset: 0x0001BBE7
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return IMaxInterstitialAdapterInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x06000AE9 RID: 2793 RVA: 0x0001D9F3 File Offset: 0x0001BBF3
		public static IMaxInterstitialAdapter GetObject(IntPtr handle, JniHandleOwnership transfer)
		{
			return Java.Lang.Object.GetObject<IMaxInterstitialAdapter>(handle, transfer);
		}

		// Token: 0x06000AEA RID: 2794 RVA: 0x0001D9FC File Offset: 0x0001BBFC
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, IMaxInterstitialAdapterInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'com.applovin.mediation.adapter.MaxInterstitialAdapter'.");
			}
			return handle;
		}

		// Token: 0x06000AEB RID: 2795 RVA: 0x0001DA27 File Offset: 0x0001BC27
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x06000AEC RID: 2796 RVA: 0x0001DA58 File Offset: 0x0001BC58
		public IMaxInterstitialAdapterInvoker(IntPtr handle, JniHandleOwnership transfer) : base(IMaxInterstitialAdapterInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x06000AED RID: 2797 RVA: 0x0001DA90 File Offset: 0x0001BC90
		private static Delegate GetLoadInterstitialAd_Lcom_applovin_mediation_adapter_parameters_MaxAdapterResponseParameters_Landroid_app_Activity_Lcom_applovin_mediation_adapter_listeners_MaxInterstitialAdapterListener_Handler()
		{
			if (IMaxInterstitialAdapterInvoker.cb_loadInterstitialAd_Lcom_applovin_mediation_adapter_parameters_MaxAdapterResponseParameters_Landroid_app_Activity_Lcom_applovin_mediation_adapter_listeners_MaxInterstitialAdapterListener_ == null)
			{
				IMaxInterstitialAdapterInvoker.cb_loadInterstitialAd_Lcom_applovin_mediation_adapter_parameters_MaxAdapterResponseParameters_Landroid_app_Activity_Lcom_applovin_mediation_adapter_listeners_MaxInterstitialAdapterListener_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLLL_V(IMaxInterstitialAdapterInvoker.n_LoadInterstitialAd_Lcom_applovin_mediation_adapter_parameters_MaxAdapterResponseParameters_Landroid_app_Activity_Lcom_applovin_mediation_adapter_listeners_MaxInterstitialAdapterListener_));
			}
			return IMaxInterstitialAdapterInvoker.cb_loadInterstitialAd_Lcom_applovin_mediation_adapter_parameters_MaxAdapterResponseParameters_Landroid_app_Activity_Lcom_applovin_mediation_adapter_listeners_MaxInterstitialAdapterListener_;
		}

		// Token: 0x06000AEE RID: 2798 RVA: 0x0001DAB4 File Offset: 0x0001BCB4
		private static void n_LoadInterstitialAd_Lcom_applovin_mediation_adapter_parameters_MaxAdapterResponseParameters_Landroid_app_Activity_Lcom_applovin_mediation_adapter_listeners_MaxInterstitialAdapterListener_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			IMaxInterstitialAdapter @object = Java.Lang.Object.GetObject<IMaxInterstitialAdapter>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			IMaxAdapterResponseParameters object2 = Java.Lang.Object.GetObject<IMaxAdapterResponseParameters>(native_p0, JniHandleOwnership.DoNotTransfer);
			Activity object3 = Java.Lang.Object.GetObject<Activity>(native_p1, JniHandleOwnership.DoNotTransfer);
			IMaxInterstitialAdapterListener object4 = Java.Lang.Object.GetObject<IMaxInterstitialAdapterListener>(native_p2, JniHandleOwnership.DoNotTransfer);
			@object.LoadInterstitialAd(object2, object3, object4);
		}

		// Token: 0x06000AEF RID: 2799 RVA: 0x0001DAEC File Offset: 0x0001BCEC
		public unsafe void LoadInterstitialAd(IMaxAdapterResponseParameters p0, Activity p1, IMaxInterstitialAdapterListener p2)
		{
			if (this.id_loadInterstitialAd_Lcom_applovin_mediation_adapter_parameters_MaxAdapterResponseParameters_Landroid_app_Activity_Lcom_applovin_mediation_adapter_listeners_MaxInterstitialAdapterListener_ == IntPtr.Zero)
			{
				this.id_loadInterstitialAd_Lcom_applovin_mediation_adapter_parameters_MaxAdapterResponseParameters_Landroid_app_Activity_Lcom_applovin_mediation_adapter_listeners_MaxInterstitialAdapterListener_ = JNIEnv.GetMethodID(this.class_ref, "loadInterstitialAd", "(Lcom/applovin/mediation/adapter/parameters/MaxAdapterResponseParameters;Landroid/app/Activity;Lcom/applovin/mediation/adapter/listeners/MaxInterstitialAdapterListener;)V");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue((p0 == null) ? IntPtr.Zero : ((Java.Lang.Object)p0).Handle);
			ptr[1] = new JValue((p1 == null) ? IntPtr.Zero : p1.Handle);
			ptr[2] = new JValue((p2 == null) ? IntPtr.Zero : ((Java.Lang.Object)p2).Handle);
			JNIEnv.CallVoidMethod(base.Handle, this.id_loadInterstitialAd_Lcom_applovin_mediation_adapter_parameters_MaxAdapterResponseParameters_Landroid_app_Activity_Lcom_applovin_mediation_adapter_listeners_MaxInterstitialAdapterListener_, ptr);
		}

		// Token: 0x06000AF0 RID: 2800 RVA: 0x0001DBB0 File Offset: 0x0001BDB0
		private static Delegate GetShowInterstitialAd_Lcom_applovin_mediation_adapter_parameters_MaxAdapterResponseParameters_Landroid_app_Activity_Lcom_applovin_mediation_adapter_listeners_MaxInterstitialAdapterListener_Handler()
		{
			if (IMaxInterstitialAdapterInvoker.cb_showInterstitialAd_Lcom_applovin_mediation_adapter_parameters_MaxAdapterResponseParameters_Landroid_app_Activity_Lcom_applovin_mediation_adapter_listeners_MaxInterstitialAdapterListener_ == null)
			{
				IMaxInterstitialAdapterInvoker.cb_showInterstitialAd_Lcom_applovin_mediation_adapter_parameters_MaxAdapterResponseParameters_Landroid_app_Activity_Lcom_applovin_mediation_adapter_listeners_MaxInterstitialAdapterListener_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLLL_V(IMaxInterstitialAdapterInvoker.n_ShowInterstitialAd_Lcom_applovin_mediation_adapter_parameters_MaxAdapterResponseParameters_Landroid_app_Activity_Lcom_applovin_mediation_adapter_listeners_MaxInterstitialAdapterListener_));
			}
			return IMaxInterstitialAdapterInvoker.cb_showInterstitialAd_Lcom_applovin_mediation_adapter_parameters_MaxAdapterResponseParameters_Landroid_app_Activity_Lcom_applovin_mediation_adapter_listeners_MaxInterstitialAdapterListener_;
		}

		// Token: 0x06000AF1 RID: 2801 RVA: 0x0001DBD4 File Offset: 0x0001BDD4
		private static void n_ShowInterstitialAd_Lcom_applovin_mediation_adapter_parameters_MaxAdapterResponseParameters_Landroid_app_Activity_Lcom_applovin_mediation_adapter_listeners_MaxInterstitialAdapterListener_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			IMaxInterstitialAdapter @object = Java.Lang.Object.GetObject<IMaxInterstitialAdapter>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			IMaxAdapterResponseParameters object2 = Java.Lang.Object.GetObject<IMaxAdapterResponseParameters>(native_p0, JniHandleOwnership.DoNotTransfer);
			Activity object3 = Java.Lang.Object.GetObject<Activity>(native_p1, JniHandleOwnership.DoNotTransfer);
			IMaxInterstitialAdapterListener object4 = Java.Lang.Object.GetObject<IMaxInterstitialAdapterListener>(native_p2, JniHandleOwnership.DoNotTransfer);
			@object.ShowInterstitialAd(object2, object3, object4);
		}

		// Token: 0x06000AF2 RID: 2802 RVA: 0x0001DC0C File Offset: 0x0001BE0C
		public unsafe void ShowInterstitialAd(IMaxAdapterResponseParameters p0, Activity p1, IMaxInterstitialAdapterListener p2)
		{
			if (this.id_showInterstitialAd_Lcom_applovin_mediation_adapter_parameters_MaxAdapterResponseParameters_Landroid_app_Activity_Lcom_applovin_mediation_adapter_listeners_MaxInterstitialAdapterListener_ == IntPtr.Zero)
			{
				this.id_showInterstitialAd_Lcom_applovin_mediation_adapter_parameters_MaxAdapterResponseParameters_Landroid_app_Activity_Lcom_applovin_mediation_adapter_listeners_MaxInterstitialAdapterListener_ = JNIEnv.GetMethodID(this.class_ref, "showInterstitialAd", "(Lcom/applovin/mediation/adapter/parameters/MaxAdapterResponseParameters;Landroid/app/Activity;Lcom/applovin/mediation/adapter/listeners/MaxInterstitialAdapterListener;)V");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue((p0 == null) ? IntPtr.Zero : ((Java.Lang.Object)p0).Handle);
			ptr[1] = new JValue((p1 == null) ? IntPtr.Zero : p1.Handle);
			ptr[2] = new JValue((p2 == null) ? IntPtr.Zero : ((Java.Lang.Object)p2).Handle);
			JNIEnv.CallVoidMethod(base.Handle, this.id_showInterstitialAd_Lcom_applovin_mediation_adapter_parameters_MaxAdapterResponseParameters_Landroid_app_Activity_Lcom_applovin_mediation_adapter_listeners_MaxInterstitialAdapterListener_, ptr);
		}

		// Token: 0x04000394 RID: 916
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/applovin/mediation/adapter/MaxInterstitialAdapter", typeof(IMaxInterstitialAdapterInvoker));

		// Token: 0x04000395 RID: 917
		private IntPtr class_ref;

		// Token: 0x04000396 RID: 918
		private static Delegate cb_loadInterstitialAd_Lcom_applovin_mediation_adapter_parameters_MaxAdapterResponseParameters_Landroid_app_Activity_Lcom_applovin_mediation_adapter_listeners_MaxInterstitialAdapterListener_;

		// Token: 0x04000397 RID: 919
		private IntPtr id_loadInterstitialAd_Lcom_applovin_mediation_adapter_parameters_MaxAdapterResponseParameters_Landroid_app_Activity_Lcom_applovin_mediation_adapter_listeners_MaxInterstitialAdapterListener_;

		// Token: 0x04000398 RID: 920
		private static Delegate cb_showInterstitialAd_Lcom_applovin_mediation_adapter_parameters_MaxAdapterResponseParameters_Landroid_app_Activity_Lcom_applovin_mediation_adapter_listeners_MaxInterstitialAdapterListener_;

		// Token: 0x04000399 RID: 921
		private IntPtr id_showInterstitialAd_Lcom_applovin_mediation_adapter_parameters_MaxAdapterResponseParameters_Landroid_app_Activity_Lcom_applovin_mediation_adapter_listeners_MaxInterstitialAdapterListener_;
	}
}
