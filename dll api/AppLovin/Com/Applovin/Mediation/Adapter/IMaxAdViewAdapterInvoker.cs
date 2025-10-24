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
	// Token: 0x020000FF RID: 255
	[Register("com/applovin/mediation/adapter/MaxAdViewAdapter", DoNotGenerateAcw = true)]
	internal class IMaxAdViewAdapterInvoker : Java.Lang.Object, IMaxAdViewAdapter, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x170002EC RID: 748
		// (get) Token: 0x06000AD7 RID: 2775 RVA: 0x0001D76C File Offset: 0x0001B96C
		private static IntPtr java_class_ref
		{
			get
			{
				return IMaxAdViewAdapterInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170002ED RID: 749
		// (get) Token: 0x06000AD8 RID: 2776 RVA: 0x0001D790 File Offset: 0x0001B990
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return IMaxAdViewAdapterInvoker._members;
			}
		}

		// Token: 0x170002EE RID: 750
		// (get) Token: 0x06000AD9 RID: 2777 RVA: 0x0001D797 File Offset: 0x0001B997
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x170002EF RID: 751
		// (get) Token: 0x06000ADA RID: 2778 RVA: 0x0001D79F File Offset: 0x0001B99F
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return IMaxAdViewAdapterInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x06000ADB RID: 2779 RVA: 0x0001D7AB File Offset: 0x0001B9AB
		public static IMaxAdViewAdapter GetObject(IntPtr handle, JniHandleOwnership transfer)
		{
			return Java.Lang.Object.GetObject<IMaxAdViewAdapter>(handle, transfer);
		}

		// Token: 0x06000ADC RID: 2780 RVA: 0x0001D7B4 File Offset: 0x0001B9B4
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, IMaxAdViewAdapterInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'com.applovin.mediation.adapter.MaxAdViewAdapter'.");
			}
			return handle;
		}

		// Token: 0x06000ADD RID: 2781 RVA: 0x0001D7DF File Offset: 0x0001B9DF
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x06000ADE RID: 2782 RVA: 0x0001D810 File Offset: 0x0001BA10
		public IMaxAdViewAdapterInvoker(IntPtr handle, JniHandleOwnership transfer) : base(IMaxAdViewAdapterInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x06000ADF RID: 2783 RVA: 0x0001D848 File Offset: 0x0001BA48
		private static Delegate GetLoadAdViewAd_Lcom_applovin_mediation_adapter_parameters_MaxAdapterResponseParameters_Lcom_applovin_mediation_MaxAdFormat_Landroid_app_Activity_Lcom_applovin_mediation_adapter_listeners_MaxAdViewAdapterListener_Handler()
		{
			if (IMaxAdViewAdapterInvoker.cb_loadAdViewAd_Lcom_applovin_mediation_adapter_parameters_MaxAdapterResponseParameters_Lcom_applovin_mediation_MaxAdFormat_Landroid_app_Activity_Lcom_applovin_mediation_adapter_listeners_MaxAdViewAdapterListener_ == null)
			{
				IMaxAdViewAdapterInvoker.cb_loadAdViewAd_Lcom_applovin_mediation_adapter_parameters_MaxAdapterResponseParameters_Lcom_applovin_mediation_MaxAdFormat_Landroid_app_Activity_Lcom_applovin_mediation_adapter_listeners_MaxAdViewAdapterListener_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLLLL_V(IMaxAdViewAdapterInvoker.n_LoadAdViewAd_Lcom_applovin_mediation_adapter_parameters_MaxAdapterResponseParameters_Lcom_applovin_mediation_MaxAdFormat_Landroid_app_Activity_Lcom_applovin_mediation_adapter_listeners_MaxAdViewAdapterListener_));
			}
			return IMaxAdViewAdapterInvoker.cb_loadAdViewAd_Lcom_applovin_mediation_adapter_parameters_MaxAdapterResponseParameters_Lcom_applovin_mediation_MaxAdFormat_Landroid_app_Activity_Lcom_applovin_mediation_adapter_listeners_MaxAdViewAdapterListener_;
		}

		// Token: 0x06000AE0 RID: 2784 RVA: 0x0001D86C File Offset: 0x0001BA6C
		private static void n_LoadAdViewAd_Lcom_applovin_mediation_adapter_parameters_MaxAdapterResponseParameters_Lcom_applovin_mediation_MaxAdFormat_Landroid_app_Activity_Lcom_applovin_mediation_adapter_listeners_MaxAdViewAdapterListener_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2, IntPtr native_p3)
		{
			IMaxAdViewAdapter @object = Java.Lang.Object.GetObject<IMaxAdViewAdapter>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			IMaxAdapterResponseParameters object2 = Java.Lang.Object.GetObject<IMaxAdapterResponseParameters>(native_p0, JniHandleOwnership.DoNotTransfer);
			MaxAdFormat object3 = Java.Lang.Object.GetObject<MaxAdFormat>(native_p1, JniHandleOwnership.DoNotTransfer);
			Activity object4 = Java.Lang.Object.GetObject<Activity>(native_p2, JniHandleOwnership.DoNotTransfer);
			IMaxAdViewAdapterListener object5 = Java.Lang.Object.GetObject<IMaxAdViewAdapterListener>(native_p3, JniHandleOwnership.DoNotTransfer);
			@object.LoadAdViewAd(object2, object3, object4, object5);
		}

		// Token: 0x06000AE1 RID: 2785 RVA: 0x0001D8AC File Offset: 0x0001BAAC
		public unsafe void LoadAdViewAd(IMaxAdapterResponseParameters p0, MaxAdFormat p1, Activity p2, IMaxAdViewAdapterListener p3)
		{
			if (this.id_loadAdViewAd_Lcom_applovin_mediation_adapter_parameters_MaxAdapterResponseParameters_Lcom_applovin_mediation_MaxAdFormat_Landroid_app_Activity_Lcom_applovin_mediation_adapter_listeners_MaxAdViewAdapterListener_ == IntPtr.Zero)
			{
				this.id_loadAdViewAd_Lcom_applovin_mediation_adapter_parameters_MaxAdapterResponseParameters_Lcom_applovin_mediation_MaxAdFormat_Landroid_app_Activity_Lcom_applovin_mediation_adapter_listeners_MaxAdViewAdapterListener_ = JNIEnv.GetMethodID(this.class_ref, "loadAdViewAd", "(Lcom/applovin/mediation/adapter/parameters/MaxAdapterResponseParameters;Lcom/applovin/mediation/MaxAdFormat;Landroid/app/Activity;Lcom/applovin/mediation/adapter/listeners/MaxAdViewAdapterListener;)V");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue((p0 == null) ? IntPtr.Zero : ((Java.Lang.Object)p0).Handle);
			ptr[1] = new JValue((p1 == null) ? IntPtr.Zero : p1.Handle);
			ptr[2] = new JValue((p2 == null) ? IntPtr.Zero : p2.Handle);
			ptr[3] = new JValue((p3 == null) ? IntPtr.Zero : ((Java.Lang.Object)p3).Handle);
			JNIEnv.CallVoidMethod(base.Handle, this.id_loadAdViewAd_Lcom_applovin_mediation_adapter_parameters_MaxAdapterResponseParameters_Lcom_applovin_mediation_MaxAdFormat_Landroid_app_Activity_Lcom_applovin_mediation_adapter_listeners_MaxAdViewAdapterListener_, ptr);
		}

		// Token: 0x04000390 RID: 912
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/applovin/mediation/adapter/MaxAdViewAdapter", typeof(IMaxAdViewAdapterInvoker));

		// Token: 0x04000391 RID: 913
		private IntPtr class_ref;

		// Token: 0x04000392 RID: 914
		private static Delegate cb_loadAdViewAd_Lcom_applovin_mediation_adapter_parameters_MaxAdapterResponseParameters_Lcom_applovin_mediation_MaxAdFormat_Landroid_app_Activity_Lcom_applovin_mediation_adapter_listeners_MaxAdViewAdapterListener_;

		// Token: 0x04000393 RID: 915
		private IntPtr id_loadAdViewAd_Lcom_applovin_mediation_adapter_parameters_MaxAdapterResponseParameters_Lcom_applovin_mediation_MaxAdFormat_Landroid_app_Activity_Lcom_applovin_mediation_adapter_listeners_MaxAdViewAdapterListener_;
	}
}
