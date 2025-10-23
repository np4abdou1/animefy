using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.App;
using Android.Runtime;
using Com.Applovin.Mediation.Adapter.Parameters;
using Java.Interop;
using Java.Lang;

namespace Com.Applovin.Mediation.Adapter
{
	// Token: 0x020000FD RID: 253
	[Register("com/applovin/mediation/adapter/MaxAdapter", DoNotGenerateAcw = true)]
	internal class IMaxAdapterInvoker : Java.Lang.Object, IMaxAdapter, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x170002E5 RID: 741
		// (get) Token: 0x06000ABE RID: 2750 RVA: 0x0001D358 File Offset: 0x0001B558
		private static IntPtr java_class_ref
		{
			get
			{
				return IMaxAdapterInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170002E6 RID: 742
		// (get) Token: 0x06000ABF RID: 2751 RVA: 0x0001D37C File Offset: 0x0001B57C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return IMaxAdapterInvoker._members;
			}
		}

		// Token: 0x170002E7 RID: 743
		// (get) Token: 0x06000AC0 RID: 2752 RVA: 0x0001D383 File Offset: 0x0001B583
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x170002E8 RID: 744
		// (get) Token: 0x06000AC1 RID: 2753 RVA: 0x0001D38B File Offset: 0x0001B58B
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return IMaxAdapterInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x06000AC2 RID: 2754 RVA: 0x0001D397 File Offset: 0x0001B597
		public static IMaxAdapter GetObject(IntPtr handle, JniHandleOwnership transfer)
		{
			return Java.Lang.Object.GetObject<IMaxAdapter>(handle, transfer);
		}

		// Token: 0x06000AC3 RID: 2755 RVA: 0x0001D3A0 File Offset: 0x0001B5A0
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, IMaxAdapterInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'com.applovin.mediation.adapter.MaxAdapter'.");
			}
			return handle;
		}

		// Token: 0x06000AC4 RID: 2756 RVA: 0x0001D3CB File Offset: 0x0001B5CB
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x06000AC5 RID: 2757 RVA: 0x0001D3FC File Offset: 0x0001B5FC
		public IMaxAdapterInvoker(IntPtr handle, JniHandleOwnership transfer) : base(IMaxAdapterInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x06000AC6 RID: 2758 RVA: 0x0001D434 File Offset: 0x0001B634
		private static Delegate GetGetAdapterVersionHandler()
		{
			if (IMaxAdapterInvoker.cb_getAdapterVersion == null)
			{
				IMaxAdapterInvoker.cb_getAdapterVersion = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IMaxAdapterInvoker.n_GetAdapterVersion));
			}
			return IMaxAdapterInvoker.cb_getAdapterVersion;
		}

		// Token: 0x06000AC7 RID: 2759 RVA: 0x0001D458 File Offset: 0x0001B658
		private static IntPtr n_GetAdapterVersion(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.NewString(Java.Lang.Object.GetObject<IMaxAdapter>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).AdapterVersion);
		}

		// Token: 0x170002E9 RID: 745
		// (get) Token: 0x06000AC8 RID: 2760 RVA: 0x0001D46C File Offset: 0x0001B66C
		public string AdapterVersion
		{
			get
			{
				if (this.id_getAdapterVersion == IntPtr.Zero)
				{
					this.id_getAdapterVersion = JNIEnv.GetMethodID(this.class_ref, "getAdapterVersion", "()Ljava/lang/String;");
				}
				return JNIEnv.GetString(JNIEnv.CallObjectMethod(base.Handle, this.id_getAdapterVersion), JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x06000AC9 RID: 2761 RVA: 0x0001D4BD File Offset: 0x0001B6BD
		private static Delegate GetIsBetaHandler()
		{
			if (IMaxAdapterInvoker.cb_isBeta == null)
			{
				IMaxAdapterInvoker.cb_isBeta = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(IMaxAdapterInvoker.n_IsBeta));
			}
			return IMaxAdapterInvoker.cb_isBeta;
		}

		// Token: 0x06000ACA RID: 2762 RVA: 0x0001D4E1 File Offset: 0x0001B6E1
		private static bool n_IsBeta(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<IMaxAdapter>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).IsBeta;
		}

		// Token: 0x170002EA RID: 746
		// (get) Token: 0x06000ACB RID: 2763 RVA: 0x0001D4F0 File Offset: 0x0001B6F0
		public bool IsBeta
		{
			get
			{
				if (this.id_isBeta == IntPtr.Zero)
				{
					this.id_isBeta = JNIEnv.GetMethodID(this.class_ref, "isBeta", "()Z");
				}
				return JNIEnv.CallBooleanMethod(base.Handle, this.id_isBeta);
			}
		}

		// Token: 0x06000ACC RID: 2764 RVA: 0x0001D530 File Offset: 0x0001B730
		private static Delegate GetGetSdkVersionHandler()
		{
			if (IMaxAdapterInvoker.cb_getSdkVersion == null)
			{
				IMaxAdapterInvoker.cb_getSdkVersion = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IMaxAdapterInvoker.n_GetSdkVersion));
			}
			return IMaxAdapterInvoker.cb_getSdkVersion;
		}

		// Token: 0x06000ACD RID: 2765 RVA: 0x0001D554 File Offset: 0x0001B754
		private static IntPtr n_GetSdkVersion(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.NewString(Java.Lang.Object.GetObject<IMaxAdapter>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).SdkVersion);
		}

		// Token: 0x170002EB RID: 747
		// (get) Token: 0x06000ACE RID: 2766 RVA: 0x0001D568 File Offset: 0x0001B768
		public string SdkVersion
		{
			get
			{
				if (this.id_getSdkVersion == IntPtr.Zero)
				{
					this.id_getSdkVersion = JNIEnv.GetMethodID(this.class_ref, "getSdkVersion", "()Ljava/lang/String;");
				}
				return JNIEnv.GetString(JNIEnv.CallObjectMethod(base.Handle, this.id_getSdkVersion), JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x06000ACF RID: 2767 RVA: 0x0001D5B9 File Offset: 0x0001B7B9
		private static Delegate GetInitialize_Lcom_applovin_mediation_adapter_parameters_MaxAdapterInitializationParameters_Landroid_app_Activity_Lcom_applovin_mediation_adapter_MaxAdapter_OnCompletionListener_Handler()
		{
			if (IMaxAdapterInvoker.cb_initialize_Lcom_applovin_mediation_adapter_parameters_MaxAdapterInitializationParameters_Landroid_app_Activity_Lcom_applovin_mediation_adapter_MaxAdapter_OnCompletionListener_ == null)
			{
				IMaxAdapterInvoker.cb_initialize_Lcom_applovin_mediation_adapter_parameters_MaxAdapterInitializationParameters_Landroid_app_Activity_Lcom_applovin_mediation_adapter_MaxAdapter_OnCompletionListener_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLLL_V(IMaxAdapterInvoker.n_Initialize_Lcom_applovin_mediation_adapter_parameters_MaxAdapterInitializationParameters_Landroid_app_Activity_Lcom_applovin_mediation_adapter_MaxAdapter_OnCompletionListener_));
			}
			return IMaxAdapterInvoker.cb_initialize_Lcom_applovin_mediation_adapter_parameters_MaxAdapterInitializationParameters_Landroid_app_Activity_Lcom_applovin_mediation_adapter_MaxAdapter_OnCompletionListener_;
		}

		// Token: 0x06000AD0 RID: 2768 RVA: 0x0001D5E0 File Offset: 0x0001B7E0
		private static void n_Initialize_Lcom_applovin_mediation_adapter_parameters_MaxAdapterInitializationParameters_Landroid_app_Activity_Lcom_applovin_mediation_adapter_MaxAdapter_OnCompletionListener_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			IMaxAdapter @object = Java.Lang.Object.GetObject<IMaxAdapter>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			IMaxAdapterInitializationParameters object2 = Java.Lang.Object.GetObject<IMaxAdapterInitializationParameters>(native_p0, JniHandleOwnership.DoNotTransfer);
			Activity object3 = Java.Lang.Object.GetObject<Activity>(native_p1, JniHandleOwnership.DoNotTransfer);
			IMaxAdapterOnCompletionListener object4 = Java.Lang.Object.GetObject<IMaxAdapterOnCompletionListener>(native_p2, JniHandleOwnership.DoNotTransfer);
			@object.Initialize(object2, object3, object4);
		}

		// Token: 0x06000AD1 RID: 2769 RVA: 0x0001D618 File Offset: 0x0001B818
		public unsafe void Initialize(IMaxAdapterInitializationParameters p0, Activity p1, IMaxAdapterOnCompletionListener p2)
		{
			if (this.id_initialize_Lcom_applovin_mediation_adapter_parameters_MaxAdapterInitializationParameters_Landroid_app_Activity_Lcom_applovin_mediation_adapter_MaxAdapter_OnCompletionListener_ == IntPtr.Zero)
			{
				this.id_initialize_Lcom_applovin_mediation_adapter_parameters_MaxAdapterInitializationParameters_Landroid_app_Activity_Lcom_applovin_mediation_adapter_MaxAdapter_OnCompletionListener_ = JNIEnv.GetMethodID(this.class_ref, "initialize", "(Lcom/applovin/mediation/adapter/parameters/MaxAdapterInitializationParameters;Landroid/app/Activity;Lcom/applovin/mediation/adapter/MaxAdapter$OnCompletionListener;)V");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue((p0 == null) ? IntPtr.Zero : ((Java.Lang.Object)p0).Handle);
			ptr[1] = new JValue((p1 == null) ? IntPtr.Zero : p1.Handle);
			ptr[2] = new JValue((p2 == null) ? IntPtr.Zero : ((Java.Lang.Object)p2).Handle);
			JNIEnv.CallVoidMethod(base.Handle, this.id_initialize_Lcom_applovin_mediation_adapter_parameters_MaxAdapterInitializationParameters_Landroid_app_Activity_Lcom_applovin_mediation_adapter_MaxAdapter_OnCompletionListener_, ptr);
		}

		// Token: 0x06000AD2 RID: 2770 RVA: 0x0001D6DC File Offset: 0x0001B8DC
		private static Delegate GetOnDestroyHandler()
		{
			if (IMaxAdapterInvoker.cb_onDestroy == null)
			{
				IMaxAdapterInvoker.cb_onDestroy = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_V(IMaxAdapterInvoker.n_OnDestroy));
			}
			return IMaxAdapterInvoker.cb_onDestroy;
		}

		// Token: 0x06000AD3 RID: 2771 RVA: 0x0001D700 File Offset: 0x0001B900
		private static void n_OnDestroy(IntPtr jnienv, IntPtr native__this)
		{
			Java.Lang.Object.GetObject<IMaxAdapter>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).OnDestroy();
		}

		// Token: 0x06000AD4 RID: 2772 RVA: 0x0001D70F File Offset: 0x0001B90F
		public void OnDestroy()
		{
			if (this.id_onDestroy == IntPtr.Zero)
			{
				this.id_onDestroy = JNIEnv.GetMethodID(this.class_ref, "onDestroy", "()V");
			}
			JNIEnv.CallVoidMethod(base.Handle, this.id_onDestroy);
		}

		// Token: 0x04000384 RID: 900
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/applovin/mediation/adapter/MaxAdapter", typeof(IMaxAdapterInvoker));

		// Token: 0x04000385 RID: 901
		private IntPtr class_ref;

		// Token: 0x04000386 RID: 902
		private static Delegate cb_getAdapterVersion;

		// Token: 0x04000387 RID: 903
		private IntPtr id_getAdapterVersion;

		// Token: 0x04000388 RID: 904
		private static Delegate cb_isBeta;

		// Token: 0x04000389 RID: 905
		private IntPtr id_isBeta;

		// Token: 0x0400038A RID: 906
		private static Delegate cb_getSdkVersion;

		// Token: 0x0400038B RID: 907
		private IntPtr id_getSdkVersion;

		// Token: 0x0400038C RID: 908
		private static Delegate cb_initialize_Lcom_applovin_mediation_adapter_parameters_MaxAdapterInitializationParameters_Landroid_app_Activity_Lcom_applovin_mediation_adapter_MaxAdapter_OnCompletionListener_;

		// Token: 0x0400038D RID: 909
		private IntPtr id_initialize_Lcom_applovin_mediation_adapter_parameters_MaxAdapterInitializationParameters_Landroid_app_Activity_Lcom_applovin_mediation_adapter_MaxAdapter_OnCompletionListener_;

		// Token: 0x0400038E RID: 910
		private static Delegate cb_onDestroy;

		// Token: 0x0400038F RID: 911
		private IntPtr id_onDestroy;
	}
}
