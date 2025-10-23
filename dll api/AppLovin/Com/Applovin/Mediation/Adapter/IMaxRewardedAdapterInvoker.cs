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
	// Token: 0x02000107 RID: 263
	[Register("com/applovin/mediation/adapter/MaxRewardedAdapter", DoNotGenerateAcw = true)]
	internal class IMaxRewardedAdapterInvoker : Java.Lang.Object, IMaxRewardedAdapter, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x170002FC RID: 764
		// (get) Token: 0x06000B0C RID: 2828 RVA: 0x0001DFFC File Offset: 0x0001C1FC
		private static IntPtr java_class_ref
		{
			get
			{
				return IMaxRewardedAdapterInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170002FD RID: 765
		// (get) Token: 0x06000B0D RID: 2829 RVA: 0x0001E020 File Offset: 0x0001C220
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return IMaxRewardedAdapterInvoker._members;
			}
		}

		// Token: 0x170002FE RID: 766
		// (get) Token: 0x06000B0E RID: 2830 RVA: 0x0001E027 File Offset: 0x0001C227
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x170002FF RID: 767
		// (get) Token: 0x06000B0F RID: 2831 RVA: 0x0001E02F File Offset: 0x0001C22F
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return IMaxRewardedAdapterInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x06000B10 RID: 2832 RVA: 0x0001E03B File Offset: 0x0001C23B
		public static IMaxRewardedAdapter GetObject(IntPtr handle, JniHandleOwnership transfer)
		{
			return Java.Lang.Object.GetObject<IMaxRewardedAdapter>(handle, transfer);
		}

		// Token: 0x06000B11 RID: 2833 RVA: 0x0001E044 File Offset: 0x0001C244
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, IMaxRewardedAdapterInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'com.applovin.mediation.adapter.MaxRewardedAdapter'.");
			}
			return handle;
		}

		// Token: 0x06000B12 RID: 2834 RVA: 0x0001E06F File Offset: 0x0001C26F
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x06000B13 RID: 2835 RVA: 0x0001E0A0 File Offset: 0x0001C2A0
		public IMaxRewardedAdapterInvoker(IntPtr handle, JniHandleOwnership transfer) : base(IMaxRewardedAdapterInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x06000B14 RID: 2836 RVA: 0x0001E0D8 File Offset: 0x0001C2D8
		private static Delegate GetLoadRewardedAd_Lcom_applovin_mediation_adapter_parameters_MaxAdapterResponseParameters_Landroid_app_Activity_Lcom_applovin_mediation_adapter_listeners_MaxRewardedAdapterListener_Handler()
		{
			if (IMaxRewardedAdapterInvoker.cb_loadRewardedAd_Lcom_applovin_mediation_adapter_parameters_MaxAdapterResponseParameters_Landroid_app_Activity_Lcom_applovin_mediation_adapter_listeners_MaxRewardedAdapterListener_ == null)
			{
				IMaxRewardedAdapterInvoker.cb_loadRewardedAd_Lcom_applovin_mediation_adapter_parameters_MaxAdapterResponseParameters_Landroid_app_Activity_Lcom_applovin_mediation_adapter_listeners_MaxRewardedAdapterListener_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLLL_V(IMaxRewardedAdapterInvoker.n_LoadRewardedAd_Lcom_applovin_mediation_adapter_parameters_MaxAdapterResponseParameters_Landroid_app_Activity_Lcom_applovin_mediation_adapter_listeners_MaxRewardedAdapterListener_));
			}
			return IMaxRewardedAdapterInvoker.cb_loadRewardedAd_Lcom_applovin_mediation_adapter_parameters_MaxAdapterResponseParameters_Landroid_app_Activity_Lcom_applovin_mediation_adapter_listeners_MaxRewardedAdapterListener_;
		}

		// Token: 0x06000B15 RID: 2837 RVA: 0x0001E0FC File Offset: 0x0001C2FC
		private static void n_LoadRewardedAd_Lcom_applovin_mediation_adapter_parameters_MaxAdapterResponseParameters_Landroid_app_Activity_Lcom_applovin_mediation_adapter_listeners_MaxRewardedAdapterListener_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			IMaxRewardedAdapter @object = Java.Lang.Object.GetObject<IMaxRewardedAdapter>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			IMaxAdapterResponseParameters object2 = Java.Lang.Object.GetObject<IMaxAdapterResponseParameters>(native_p0, JniHandleOwnership.DoNotTransfer);
			Activity object3 = Java.Lang.Object.GetObject<Activity>(native_p1, JniHandleOwnership.DoNotTransfer);
			IMaxRewardedAdapterListener object4 = Java.Lang.Object.GetObject<IMaxRewardedAdapterListener>(native_p2, JniHandleOwnership.DoNotTransfer);
			@object.LoadRewardedAd(object2, object3, object4);
		}

		// Token: 0x06000B16 RID: 2838 RVA: 0x0001E134 File Offset: 0x0001C334
		public unsafe void LoadRewardedAd(IMaxAdapterResponseParameters p0, Activity p1, IMaxRewardedAdapterListener p2)
		{
			if (this.id_loadRewardedAd_Lcom_applovin_mediation_adapter_parameters_MaxAdapterResponseParameters_Landroid_app_Activity_Lcom_applovin_mediation_adapter_listeners_MaxRewardedAdapterListener_ == IntPtr.Zero)
			{
				this.id_loadRewardedAd_Lcom_applovin_mediation_adapter_parameters_MaxAdapterResponseParameters_Landroid_app_Activity_Lcom_applovin_mediation_adapter_listeners_MaxRewardedAdapterListener_ = JNIEnv.GetMethodID(this.class_ref, "loadRewardedAd", "(Lcom/applovin/mediation/adapter/parameters/MaxAdapterResponseParameters;Landroid/app/Activity;Lcom/applovin/mediation/adapter/listeners/MaxRewardedAdapterListener;)V");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue((p0 == null) ? IntPtr.Zero : ((Java.Lang.Object)p0).Handle);
			ptr[1] = new JValue((p1 == null) ? IntPtr.Zero : p1.Handle);
			ptr[2] = new JValue((p2 == null) ? IntPtr.Zero : ((Java.Lang.Object)p2).Handle);
			JNIEnv.CallVoidMethod(base.Handle, this.id_loadRewardedAd_Lcom_applovin_mediation_adapter_parameters_MaxAdapterResponseParameters_Landroid_app_Activity_Lcom_applovin_mediation_adapter_listeners_MaxRewardedAdapterListener_, ptr);
		}

		// Token: 0x06000B17 RID: 2839 RVA: 0x0001E1F8 File Offset: 0x0001C3F8
		private static Delegate GetShowRewardedAd_Lcom_applovin_mediation_adapter_parameters_MaxAdapterResponseParameters_Landroid_app_Activity_Lcom_applovin_mediation_adapter_listeners_MaxRewardedAdapterListener_Handler()
		{
			if (IMaxRewardedAdapterInvoker.cb_showRewardedAd_Lcom_applovin_mediation_adapter_parameters_MaxAdapterResponseParameters_Landroid_app_Activity_Lcom_applovin_mediation_adapter_listeners_MaxRewardedAdapterListener_ == null)
			{
				IMaxRewardedAdapterInvoker.cb_showRewardedAd_Lcom_applovin_mediation_adapter_parameters_MaxAdapterResponseParameters_Landroid_app_Activity_Lcom_applovin_mediation_adapter_listeners_MaxRewardedAdapterListener_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLLL_V(IMaxRewardedAdapterInvoker.n_ShowRewardedAd_Lcom_applovin_mediation_adapter_parameters_MaxAdapterResponseParameters_Landroid_app_Activity_Lcom_applovin_mediation_adapter_listeners_MaxRewardedAdapterListener_));
			}
			return IMaxRewardedAdapterInvoker.cb_showRewardedAd_Lcom_applovin_mediation_adapter_parameters_MaxAdapterResponseParameters_Landroid_app_Activity_Lcom_applovin_mediation_adapter_listeners_MaxRewardedAdapterListener_;
		}

		// Token: 0x06000B18 RID: 2840 RVA: 0x0001E21C File Offset: 0x0001C41C
		private static void n_ShowRewardedAd_Lcom_applovin_mediation_adapter_parameters_MaxAdapterResponseParameters_Landroid_app_Activity_Lcom_applovin_mediation_adapter_listeners_MaxRewardedAdapterListener_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			IMaxRewardedAdapter @object = Java.Lang.Object.GetObject<IMaxRewardedAdapter>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			IMaxAdapterResponseParameters object2 = Java.Lang.Object.GetObject<IMaxAdapterResponseParameters>(native_p0, JniHandleOwnership.DoNotTransfer);
			Activity object3 = Java.Lang.Object.GetObject<Activity>(native_p1, JniHandleOwnership.DoNotTransfer);
			IMaxRewardedAdapterListener object4 = Java.Lang.Object.GetObject<IMaxRewardedAdapterListener>(native_p2, JniHandleOwnership.DoNotTransfer);
			@object.ShowRewardedAd(object2, object3, object4);
		}

		// Token: 0x06000B19 RID: 2841 RVA: 0x0001E254 File Offset: 0x0001C454
		public unsafe void ShowRewardedAd(IMaxAdapterResponseParameters p0, Activity p1, IMaxRewardedAdapterListener p2)
		{
			if (this.id_showRewardedAd_Lcom_applovin_mediation_adapter_parameters_MaxAdapterResponseParameters_Landroid_app_Activity_Lcom_applovin_mediation_adapter_listeners_MaxRewardedAdapterListener_ == IntPtr.Zero)
			{
				this.id_showRewardedAd_Lcom_applovin_mediation_adapter_parameters_MaxAdapterResponseParameters_Landroid_app_Activity_Lcom_applovin_mediation_adapter_listeners_MaxRewardedAdapterListener_ = JNIEnv.GetMethodID(this.class_ref, "showRewardedAd", "(Lcom/applovin/mediation/adapter/parameters/MaxAdapterResponseParameters;Landroid/app/Activity;Lcom/applovin/mediation/adapter/listeners/MaxRewardedAdapterListener;)V");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue((p0 == null) ? IntPtr.Zero : ((Java.Lang.Object)p0).Handle);
			ptr[1] = new JValue((p1 == null) ? IntPtr.Zero : p1.Handle);
			ptr[2] = new JValue((p2 == null) ? IntPtr.Zero : ((Java.Lang.Object)p2).Handle);
			JNIEnv.CallVoidMethod(base.Handle, this.id_showRewardedAd_Lcom_applovin_mediation_adapter_parameters_MaxAdapterResponseParameters_Landroid_app_Activity_Lcom_applovin_mediation_adapter_listeners_MaxRewardedAdapterListener_, ptr);
		}

		// Token: 0x040003A0 RID: 928
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/applovin/mediation/adapter/MaxRewardedAdapter", typeof(IMaxRewardedAdapterInvoker));

		// Token: 0x040003A1 RID: 929
		private IntPtr class_ref;

		// Token: 0x040003A2 RID: 930
		private static Delegate cb_loadRewardedAd_Lcom_applovin_mediation_adapter_parameters_MaxAdapterResponseParameters_Landroid_app_Activity_Lcom_applovin_mediation_adapter_listeners_MaxRewardedAdapterListener_;

		// Token: 0x040003A3 RID: 931
		private IntPtr id_loadRewardedAd_Lcom_applovin_mediation_adapter_parameters_MaxAdapterResponseParameters_Landroid_app_Activity_Lcom_applovin_mediation_adapter_listeners_MaxRewardedAdapterListener_;

		// Token: 0x040003A4 RID: 932
		private static Delegate cb_showRewardedAd_Lcom_applovin_mediation_adapter_parameters_MaxAdapterResponseParameters_Landroid_app_Activity_Lcom_applovin_mediation_adapter_listeners_MaxRewardedAdapterListener_;

		// Token: 0x040003A5 RID: 933
		private IntPtr id_showRewardedAd_Lcom_applovin_mediation_adapter_parameters_MaxAdapterResponseParameters_Landroid_app_Activity_Lcom_applovin_mediation_adapter_listeners_MaxRewardedAdapterListener_;
	}
}
