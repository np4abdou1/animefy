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
	// Token: 0x0200010B RID: 267
	[Register("com/applovin/mediation/adapter/MaxRewardedInterstitialAdapter", DoNotGenerateAcw = true)]
	internal class IMaxRewardedInterstitialAdapterInvoker : Java.Lang.Object, IMaxRewardedInterstitialAdapter, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x17000304 RID: 772
		// (get) Token: 0x06000B26 RID: 2854 RVA: 0x0001E42C File Offset: 0x0001C62C
		private static IntPtr java_class_ref
		{
			get
			{
				return IMaxRewardedInterstitialAdapterInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000305 RID: 773
		// (get) Token: 0x06000B27 RID: 2855 RVA: 0x0001E450 File Offset: 0x0001C650
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return IMaxRewardedInterstitialAdapterInvoker._members;
			}
		}

		// Token: 0x17000306 RID: 774
		// (get) Token: 0x06000B28 RID: 2856 RVA: 0x0001E457 File Offset: 0x0001C657
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x17000307 RID: 775
		// (get) Token: 0x06000B29 RID: 2857 RVA: 0x0001E45F File Offset: 0x0001C65F
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return IMaxRewardedInterstitialAdapterInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x06000B2A RID: 2858 RVA: 0x0001E46B File Offset: 0x0001C66B
		public static IMaxRewardedInterstitialAdapter GetObject(IntPtr handle, JniHandleOwnership transfer)
		{
			return Java.Lang.Object.GetObject<IMaxRewardedInterstitialAdapter>(handle, transfer);
		}

		// Token: 0x06000B2B RID: 2859 RVA: 0x0001E474 File Offset: 0x0001C674
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, IMaxRewardedInterstitialAdapterInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'com.applovin.mediation.adapter.MaxRewardedInterstitialAdapter'.");
			}
			return handle;
		}

		// Token: 0x06000B2C RID: 2860 RVA: 0x0001E49F File Offset: 0x0001C69F
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x06000B2D RID: 2861 RVA: 0x0001E4D0 File Offset: 0x0001C6D0
		public IMaxRewardedInterstitialAdapterInvoker(IntPtr handle, JniHandleOwnership transfer) : base(IMaxRewardedInterstitialAdapterInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x06000B2E RID: 2862 RVA: 0x0001E508 File Offset: 0x0001C708
		private static Delegate GetLoadRewardedInterstitialAd_Lcom_applovin_mediation_adapter_parameters_MaxAdapterResponseParameters_Landroid_app_Activity_Lcom_applovin_mediation_adapter_listeners_MaxRewardedInterstitialAdapterListener_Handler()
		{
			if (IMaxRewardedInterstitialAdapterInvoker.cb_loadRewardedInterstitialAd_Lcom_applovin_mediation_adapter_parameters_MaxAdapterResponseParameters_Landroid_app_Activity_Lcom_applovin_mediation_adapter_listeners_MaxRewardedInterstitialAdapterListener_ == null)
			{
				IMaxRewardedInterstitialAdapterInvoker.cb_loadRewardedInterstitialAd_Lcom_applovin_mediation_adapter_parameters_MaxAdapterResponseParameters_Landroid_app_Activity_Lcom_applovin_mediation_adapter_listeners_MaxRewardedInterstitialAdapterListener_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLLL_V(IMaxRewardedInterstitialAdapterInvoker.n_LoadRewardedInterstitialAd_Lcom_applovin_mediation_adapter_parameters_MaxAdapterResponseParameters_Landroid_app_Activity_Lcom_applovin_mediation_adapter_listeners_MaxRewardedInterstitialAdapterListener_));
			}
			return IMaxRewardedInterstitialAdapterInvoker.cb_loadRewardedInterstitialAd_Lcom_applovin_mediation_adapter_parameters_MaxAdapterResponseParameters_Landroid_app_Activity_Lcom_applovin_mediation_adapter_listeners_MaxRewardedInterstitialAdapterListener_;
		}

		// Token: 0x06000B2F RID: 2863 RVA: 0x0001E52C File Offset: 0x0001C72C
		private static void n_LoadRewardedInterstitialAd_Lcom_applovin_mediation_adapter_parameters_MaxAdapterResponseParameters_Landroid_app_Activity_Lcom_applovin_mediation_adapter_listeners_MaxRewardedInterstitialAdapterListener_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			IMaxRewardedInterstitialAdapter @object = Java.Lang.Object.GetObject<IMaxRewardedInterstitialAdapter>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			IMaxAdapterResponseParameters object2 = Java.Lang.Object.GetObject<IMaxAdapterResponseParameters>(native_p0, JniHandleOwnership.DoNotTransfer);
			Activity object3 = Java.Lang.Object.GetObject<Activity>(native_p1, JniHandleOwnership.DoNotTransfer);
			IMaxRewardedInterstitialAdapterListener object4 = Java.Lang.Object.GetObject<IMaxRewardedInterstitialAdapterListener>(native_p2, JniHandleOwnership.DoNotTransfer);
			@object.LoadRewardedInterstitialAd(object2, object3, object4);
		}

		// Token: 0x06000B30 RID: 2864 RVA: 0x0001E564 File Offset: 0x0001C764
		public unsafe void LoadRewardedInterstitialAd(IMaxAdapterResponseParameters p0, Activity p1, IMaxRewardedInterstitialAdapterListener p2)
		{
			if (this.id_loadRewardedInterstitialAd_Lcom_applovin_mediation_adapter_parameters_MaxAdapterResponseParameters_Landroid_app_Activity_Lcom_applovin_mediation_adapter_listeners_MaxRewardedInterstitialAdapterListener_ == IntPtr.Zero)
			{
				this.id_loadRewardedInterstitialAd_Lcom_applovin_mediation_adapter_parameters_MaxAdapterResponseParameters_Landroid_app_Activity_Lcom_applovin_mediation_adapter_listeners_MaxRewardedInterstitialAdapterListener_ = JNIEnv.GetMethodID(this.class_ref, "loadRewardedInterstitialAd", "(Lcom/applovin/mediation/adapter/parameters/MaxAdapterResponseParameters;Landroid/app/Activity;Lcom/applovin/mediation/adapter/listeners/MaxRewardedInterstitialAdapterListener;)V");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue((p0 == null) ? IntPtr.Zero : ((Java.Lang.Object)p0).Handle);
			ptr[1] = new JValue((p1 == null) ? IntPtr.Zero : p1.Handle);
			ptr[2] = new JValue((p2 == null) ? IntPtr.Zero : ((Java.Lang.Object)p2).Handle);
			JNIEnv.CallVoidMethod(base.Handle, this.id_loadRewardedInterstitialAd_Lcom_applovin_mediation_adapter_parameters_MaxAdapterResponseParameters_Landroid_app_Activity_Lcom_applovin_mediation_adapter_listeners_MaxRewardedInterstitialAdapterListener_, ptr);
		}

		// Token: 0x06000B31 RID: 2865 RVA: 0x0001E628 File Offset: 0x0001C828
		private static Delegate GetShowRewardedInterstitialAd_Lcom_applovin_mediation_adapter_parameters_MaxAdapterResponseParameters_Landroid_app_Activity_Lcom_applovin_mediation_adapter_listeners_MaxRewardedInterstitialAdapterListener_Handler()
		{
			if (IMaxRewardedInterstitialAdapterInvoker.cb_showRewardedInterstitialAd_Lcom_applovin_mediation_adapter_parameters_MaxAdapterResponseParameters_Landroid_app_Activity_Lcom_applovin_mediation_adapter_listeners_MaxRewardedInterstitialAdapterListener_ == null)
			{
				IMaxRewardedInterstitialAdapterInvoker.cb_showRewardedInterstitialAd_Lcom_applovin_mediation_adapter_parameters_MaxAdapterResponseParameters_Landroid_app_Activity_Lcom_applovin_mediation_adapter_listeners_MaxRewardedInterstitialAdapterListener_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLLL_V(IMaxRewardedInterstitialAdapterInvoker.n_ShowRewardedInterstitialAd_Lcom_applovin_mediation_adapter_parameters_MaxAdapterResponseParameters_Landroid_app_Activity_Lcom_applovin_mediation_adapter_listeners_MaxRewardedInterstitialAdapterListener_));
			}
			return IMaxRewardedInterstitialAdapterInvoker.cb_showRewardedInterstitialAd_Lcom_applovin_mediation_adapter_parameters_MaxAdapterResponseParameters_Landroid_app_Activity_Lcom_applovin_mediation_adapter_listeners_MaxRewardedInterstitialAdapterListener_;
		}

		// Token: 0x06000B32 RID: 2866 RVA: 0x0001E64C File Offset: 0x0001C84C
		private static void n_ShowRewardedInterstitialAd_Lcom_applovin_mediation_adapter_parameters_MaxAdapterResponseParameters_Landroid_app_Activity_Lcom_applovin_mediation_adapter_listeners_MaxRewardedInterstitialAdapterListener_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			IMaxRewardedInterstitialAdapter @object = Java.Lang.Object.GetObject<IMaxRewardedInterstitialAdapter>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			IMaxAdapterResponseParameters object2 = Java.Lang.Object.GetObject<IMaxAdapterResponseParameters>(native_p0, JniHandleOwnership.DoNotTransfer);
			Activity object3 = Java.Lang.Object.GetObject<Activity>(native_p1, JniHandleOwnership.DoNotTransfer);
			IMaxRewardedInterstitialAdapterListener object4 = Java.Lang.Object.GetObject<IMaxRewardedInterstitialAdapterListener>(native_p2, JniHandleOwnership.DoNotTransfer);
			@object.ShowRewardedInterstitialAd(object2, object3, object4);
		}

		// Token: 0x06000B33 RID: 2867 RVA: 0x0001E684 File Offset: 0x0001C884
		public unsafe void ShowRewardedInterstitialAd(IMaxAdapterResponseParameters p0, Activity p1, IMaxRewardedInterstitialAdapterListener p2)
		{
			if (this.id_showRewardedInterstitialAd_Lcom_applovin_mediation_adapter_parameters_MaxAdapterResponseParameters_Landroid_app_Activity_Lcom_applovin_mediation_adapter_listeners_MaxRewardedInterstitialAdapterListener_ == IntPtr.Zero)
			{
				this.id_showRewardedInterstitialAd_Lcom_applovin_mediation_adapter_parameters_MaxAdapterResponseParameters_Landroid_app_Activity_Lcom_applovin_mediation_adapter_listeners_MaxRewardedInterstitialAdapterListener_ = JNIEnv.GetMethodID(this.class_ref, "showRewardedInterstitialAd", "(Lcom/applovin/mediation/adapter/parameters/MaxAdapterResponseParameters;Landroid/app/Activity;Lcom/applovin/mediation/adapter/listeners/MaxRewardedInterstitialAdapterListener;)V");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue((p0 == null) ? IntPtr.Zero : ((Java.Lang.Object)p0).Handle);
			ptr[1] = new JValue((p1 == null) ? IntPtr.Zero : p1.Handle);
			ptr[2] = new JValue((p2 == null) ? IntPtr.Zero : ((Java.Lang.Object)p2).Handle);
			JNIEnv.CallVoidMethod(base.Handle, this.id_showRewardedInterstitialAd_Lcom_applovin_mediation_adapter_parameters_MaxAdapterResponseParameters_Landroid_app_Activity_Lcom_applovin_mediation_adapter_listeners_MaxRewardedInterstitialAdapterListener_, ptr);
		}

		// Token: 0x040003A8 RID: 936
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/applovin/mediation/adapter/MaxRewardedInterstitialAdapter", typeof(IMaxRewardedInterstitialAdapterInvoker));

		// Token: 0x040003A9 RID: 937
		private IntPtr class_ref;

		// Token: 0x040003AA RID: 938
		private static Delegate cb_loadRewardedInterstitialAd_Lcom_applovin_mediation_adapter_parameters_MaxAdapterResponseParameters_Landroid_app_Activity_Lcom_applovin_mediation_adapter_listeners_MaxRewardedInterstitialAdapterListener_;

		// Token: 0x040003AB RID: 939
		private IntPtr id_loadRewardedInterstitialAd_Lcom_applovin_mediation_adapter_parameters_MaxAdapterResponseParameters_Landroid_app_Activity_Lcom_applovin_mediation_adapter_listeners_MaxRewardedInterstitialAdapterListener_;

		// Token: 0x040003AC RID: 940
		private static Delegate cb_showRewardedInterstitialAd_Lcom_applovin_mediation_adapter_parameters_MaxAdapterResponseParameters_Landroid_app_Activity_Lcom_applovin_mediation_adapter_listeners_MaxRewardedInterstitialAdapterListener_;

		// Token: 0x040003AD RID: 941
		private IntPtr id_showRewardedInterstitialAd_Lcom_applovin_mediation_adapter_parameters_MaxAdapterResponseParameters_Landroid_app_Activity_Lcom_applovin_mediation_adapter_listeners_MaxRewardedInterstitialAdapterListener_;
	}
}
