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
	// Token: 0x0200010D RID: 269
	[Register("com/applovin/mediation/adapter/MaxSignalProvider", DoNotGenerateAcw = true)]
	internal class IMaxSignalProviderInvoker : Java.Lang.Object, IMaxSignalProvider, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x17000308 RID: 776
		// (get) Token: 0x06000B36 RID: 2870 RVA: 0x0001E764 File Offset: 0x0001C964
		private static IntPtr java_class_ref
		{
			get
			{
				return IMaxSignalProviderInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000309 RID: 777
		// (get) Token: 0x06000B37 RID: 2871 RVA: 0x0001E788 File Offset: 0x0001C988
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return IMaxSignalProviderInvoker._members;
			}
		}

		// Token: 0x1700030A RID: 778
		// (get) Token: 0x06000B38 RID: 2872 RVA: 0x0001E78F File Offset: 0x0001C98F
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x1700030B RID: 779
		// (get) Token: 0x06000B39 RID: 2873 RVA: 0x0001E797 File Offset: 0x0001C997
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return IMaxSignalProviderInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x06000B3A RID: 2874 RVA: 0x0001E7A3 File Offset: 0x0001C9A3
		public static IMaxSignalProvider GetObject(IntPtr handle, JniHandleOwnership transfer)
		{
			return Java.Lang.Object.GetObject<IMaxSignalProvider>(handle, transfer);
		}

		// Token: 0x06000B3B RID: 2875 RVA: 0x0001E7AC File Offset: 0x0001C9AC
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, IMaxSignalProviderInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'com.applovin.mediation.adapter.MaxSignalProvider'.");
			}
			return handle;
		}

		// Token: 0x06000B3C RID: 2876 RVA: 0x0001E7D7 File Offset: 0x0001C9D7
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x06000B3D RID: 2877 RVA: 0x0001E808 File Offset: 0x0001CA08
		public IMaxSignalProviderInvoker(IntPtr handle, JniHandleOwnership transfer) : base(IMaxSignalProviderInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x06000B3E RID: 2878 RVA: 0x0001E840 File Offset: 0x0001CA40
		private static Delegate GetCollectSignal_Lcom_applovin_mediation_adapter_parameters_MaxAdapterSignalCollectionParameters_Landroid_app_Activity_Lcom_applovin_mediation_adapter_listeners_MaxSignalCollectionListener_Handler()
		{
			if (IMaxSignalProviderInvoker.cb_collectSignal_Lcom_applovin_mediation_adapter_parameters_MaxAdapterSignalCollectionParameters_Landroid_app_Activity_Lcom_applovin_mediation_adapter_listeners_MaxSignalCollectionListener_ == null)
			{
				IMaxSignalProviderInvoker.cb_collectSignal_Lcom_applovin_mediation_adapter_parameters_MaxAdapterSignalCollectionParameters_Landroid_app_Activity_Lcom_applovin_mediation_adapter_listeners_MaxSignalCollectionListener_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLLL_V(IMaxSignalProviderInvoker.n_CollectSignal_Lcom_applovin_mediation_adapter_parameters_MaxAdapterSignalCollectionParameters_Landroid_app_Activity_Lcom_applovin_mediation_adapter_listeners_MaxSignalCollectionListener_));
			}
			return IMaxSignalProviderInvoker.cb_collectSignal_Lcom_applovin_mediation_adapter_parameters_MaxAdapterSignalCollectionParameters_Landroid_app_Activity_Lcom_applovin_mediation_adapter_listeners_MaxSignalCollectionListener_;
		}

		// Token: 0x06000B3F RID: 2879 RVA: 0x0001E864 File Offset: 0x0001CA64
		private static void n_CollectSignal_Lcom_applovin_mediation_adapter_parameters_MaxAdapterSignalCollectionParameters_Landroid_app_Activity_Lcom_applovin_mediation_adapter_listeners_MaxSignalCollectionListener_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			IMaxSignalProvider @object = Java.Lang.Object.GetObject<IMaxSignalProvider>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			IMaxAdapterSignalCollectionParameters object2 = Java.Lang.Object.GetObject<IMaxAdapterSignalCollectionParameters>(native_p0, JniHandleOwnership.DoNotTransfer);
			Activity object3 = Java.Lang.Object.GetObject<Activity>(native_p1, JniHandleOwnership.DoNotTransfer);
			IMaxSignalCollectionListener object4 = Java.Lang.Object.GetObject<IMaxSignalCollectionListener>(native_p2, JniHandleOwnership.DoNotTransfer);
			@object.CollectSignal(object2, object3, object4);
		}

		// Token: 0x06000B40 RID: 2880 RVA: 0x0001E89C File Offset: 0x0001CA9C
		public unsafe void CollectSignal(IMaxAdapterSignalCollectionParameters p0, Activity p1, IMaxSignalCollectionListener p2)
		{
			if (this.id_collectSignal_Lcom_applovin_mediation_adapter_parameters_MaxAdapterSignalCollectionParameters_Landroid_app_Activity_Lcom_applovin_mediation_adapter_listeners_MaxSignalCollectionListener_ == IntPtr.Zero)
			{
				this.id_collectSignal_Lcom_applovin_mediation_adapter_parameters_MaxAdapterSignalCollectionParameters_Landroid_app_Activity_Lcom_applovin_mediation_adapter_listeners_MaxSignalCollectionListener_ = JNIEnv.GetMethodID(this.class_ref, "collectSignal", "(Lcom/applovin/mediation/adapter/parameters/MaxAdapterSignalCollectionParameters;Landroid/app/Activity;Lcom/applovin/mediation/adapter/listeners/MaxSignalCollectionListener;)V");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue((p0 == null) ? IntPtr.Zero : ((Java.Lang.Object)p0).Handle);
			ptr[1] = new JValue((p1 == null) ? IntPtr.Zero : p1.Handle);
			ptr[2] = new JValue((p2 == null) ? IntPtr.Zero : ((Java.Lang.Object)p2).Handle);
			JNIEnv.CallVoidMethod(base.Handle, this.id_collectSignal_Lcom_applovin_mediation_adapter_parameters_MaxAdapterSignalCollectionParameters_Landroid_app_Activity_Lcom_applovin_mediation_adapter_listeners_MaxSignalCollectionListener_, ptr);
		}

		// Token: 0x040003AE RID: 942
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/applovin/mediation/adapter/MaxSignalProvider", typeof(IMaxSignalProviderInvoker));

		// Token: 0x040003AF RID: 943
		private IntPtr class_ref;

		// Token: 0x040003B0 RID: 944
		private static Delegate cb_collectSignal_Lcom_applovin_mediation_adapter_parameters_MaxAdapterSignalCollectionParameters_Landroid_app_Activity_Lcom_applovin_mediation_adapter_listeners_MaxSignalCollectionListener_;

		// Token: 0x040003B1 RID: 945
		private IntPtr id_collectSignal_Lcom_applovin_mediation_adapter_parameters_MaxAdapterSignalCollectionParameters_Landroid_app_Activity_Lcom_applovin_mediation_adapter_listeners_MaxSignalCollectionListener_;
	}
}
