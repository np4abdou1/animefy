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
	// Token: 0x02000105 RID: 261
	[Register("com/applovin/mediation/adapter/MaxNativeAdAdapter", DoNotGenerateAcw = true)]
	internal class IMaxNativeAdAdapterInvoker : Java.Lang.Object, IMaxNativeAdAdapter, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x170002F8 RID: 760
		// (get) Token: 0x06000AFE RID: 2814 RVA: 0x0001DDE4 File Offset: 0x0001BFE4
		private static IntPtr java_class_ref
		{
			get
			{
				return IMaxNativeAdAdapterInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170002F9 RID: 761
		// (get) Token: 0x06000AFF RID: 2815 RVA: 0x0001DE08 File Offset: 0x0001C008
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return IMaxNativeAdAdapterInvoker._members;
			}
		}

		// Token: 0x170002FA RID: 762
		// (get) Token: 0x06000B00 RID: 2816 RVA: 0x0001DE0F File Offset: 0x0001C00F
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x170002FB RID: 763
		// (get) Token: 0x06000B01 RID: 2817 RVA: 0x0001DE17 File Offset: 0x0001C017
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return IMaxNativeAdAdapterInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x06000B02 RID: 2818 RVA: 0x0001DE23 File Offset: 0x0001C023
		public static IMaxNativeAdAdapter GetObject(IntPtr handle, JniHandleOwnership transfer)
		{
			return Java.Lang.Object.GetObject<IMaxNativeAdAdapter>(handle, transfer);
		}

		// Token: 0x06000B03 RID: 2819 RVA: 0x0001DE2C File Offset: 0x0001C02C
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, IMaxNativeAdAdapterInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'com.applovin.mediation.adapter.MaxNativeAdAdapter'.");
			}
			return handle;
		}

		// Token: 0x06000B04 RID: 2820 RVA: 0x0001DE57 File Offset: 0x0001C057
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x06000B05 RID: 2821 RVA: 0x0001DE88 File Offset: 0x0001C088
		public IMaxNativeAdAdapterInvoker(IntPtr handle, JniHandleOwnership transfer) : base(IMaxNativeAdAdapterInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x06000B06 RID: 2822 RVA: 0x0001DEC0 File Offset: 0x0001C0C0
		private static Delegate GetLoadNativeAd_Lcom_applovin_mediation_adapter_parameters_MaxAdapterResponseParameters_Landroid_app_Activity_Lcom_applovin_mediation_adapter_listeners_MaxNativeAdAdapterListener_Handler()
		{
			if (IMaxNativeAdAdapterInvoker.cb_loadNativeAd_Lcom_applovin_mediation_adapter_parameters_MaxAdapterResponseParameters_Landroid_app_Activity_Lcom_applovin_mediation_adapter_listeners_MaxNativeAdAdapterListener_ == null)
			{
				IMaxNativeAdAdapterInvoker.cb_loadNativeAd_Lcom_applovin_mediation_adapter_parameters_MaxAdapterResponseParameters_Landroid_app_Activity_Lcom_applovin_mediation_adapter_listeners_MaxNativeAdAdapterListener_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLLL_V(IMaxNativeAdAdapterInvoker.n_LoadNativeAd_Lcom_applovin_mediation_adapter_parameters_MaxAdapterResponseParameters_Landroid_app_Activity_Lcom_applovin_mediation_adapter_listeners_MaxNativeAdAdapterListener_));
			}
			return IMaxNativeAdAdapterInvoker.cb_loadNativeAd_Lcom_applovin_mediation_adapter_parameters_MaxAdapterResponseParameters_Landroid_app_Activity_Lcom_applovin_mediation_adapter_listeners_MaxNativeAdAdapterListener_;
		}

		// Token: 0x06000B07 RID: 2823 RVA: 0x0001DEE4 File Offset: 0x0001C0E4
		private static void n_LoadNativeAd_Lcom_applovin_mediation_adapter_parameters_MaxAdapterResponseParameters_Landroid_app_Activity_Lcom_applovin_mediation_adapter_listeners_MaxNativeAdAdapterListener_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			IMaxNativeAdAdapter @object = Java.Lang.Object.GetObject<IMaxNativeAdAdapter>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			IMaxAdapterResponseParameters object2 = Java.Lang.Object.GetObject<IMaxAdapterResponseParameters>(native_p0, JniHandleOwnership.DoNotTransfer);
			Activity object3 = Java.Lang.Object.GetObject<Activity>(native_p1, JniHandleOwnership.DoNotTransfer);
			IMaxNativeAdAdapterListener object4 = Java.Lang.Object.GetObject<IMaxNativeAdAdapterListener>(native_p2, JniHandleOwnership.DoNotTransfer);
			@object.LoadNativeAd(object2, object3, object4);
		}

		// Token: 0x06000B08 RID: 2824 RVA: 0x0001DF1C File Offset: 0x0001C11C
		public unsafe void LoadNativeAd(IMaxAdapterResponseParameters p0, Activity p1, IMaxNativeAdAdapterListener p2)
		{
			if (this.id_loadNativeAd_Lcom_applovin_mediation_adapter_parameters_MaxAdapterResponseParameters_Landroid_app_Activity_Lcom_applovin_mediation_adapter_listeners_MaxNativeAdAdapterListener_ == IntPtr.Zero)
			{
				this.id_loadNativeAd_Lcom_applovin_mediation_adapter_parameters_MaxAdapterResponseParameters_Landroid_app_Activity_Lcom_applovin_mediation_adapter_listeners_MaxNativeAdAdapterListener_ = JNIEnv.GetMethodID(this.class_ref, "loadNativeAd", "(Lcom/applovin/mediation/adapter/parameters/MaxAdapterResponseParameters;Landroid/app/Activity;Lcom/applovin/mediation/adapter/listeners/MaxNativeAdAdapterListener;)V");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue((p0 == null) ? IntPtr.Zero : ((Java.Lang.Object)p0).Handle);
			ptr[1] = new JValue((p1 == null) ? IntPtr.Zero : p1.Handle);
			ptr[2] = new JValue((p2 == null) ? IntPtr.Zero : ((Java.Lang.Object)p2).Handle);
			JNIEnv.CallVoidMethod(base.Handle, this.id_loadNativeAd_Lcom_applovin_mediation_adapter_parameters_MaxAdapterResponseParameters_Landroid_app_Activity_Lcom_applovin_mediation_adapter_listeners_MaxNativeAdAdapterListener_, ptr);
		}

		// Token: 0x0400039C RID: 924
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/applovin/mediation/adapter/MaxNativeAdAdapter", typeof(IMaxNativeAdAdapterInvoker));

		// Token: 0x0400039D RID: 925
		private IntPtr class_ref;

		// Token: 0x0400039E RID: 926
		private static Delegate cb_loadNativeAd_Lcom_applovin_mediation_adapter_parameters_MaxAdapterResponseParameters_Landroid_app_Activity_Lcom_applovin_mediation_adapter_listeners_MaxNativeAdAdapterListener_;

		// Token: 0x0400039F RID: 927
		private IntPtr id_loadNativeAd_Lcom_applovin_mediation_adapter_parameters_MaxAdapterResponseParameters_Landroid_app_Activity_Lcom_applovin_mediation_adapter_listeners_MaxNativeAdAdapterListener_;
	}
}
