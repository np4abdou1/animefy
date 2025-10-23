using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Com.Unity3d.Services.Core.Configuration
{
	// Token: 0x0200015E RID: 350
	[Register("com/unity3d/services/core/configuration/IConfigurationLoader", DoNotGenerateAcw = true)]
	internal class IConfigurationLoaderInvoker : Java.Lang.Object, IConfigurationLoader, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x1700057B RID: 1403
		// (get) Token: 0x06000F25 RID: 3877 RVA: 0x0002958C File Offset: 0x0002778C
		private static IntPtr java_class_ref
		{
			get
			{
				return IConfigurationLoaderInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700057C RID: 1404
		// (get) Token: 0x06000F26 RID: 3878 RVA: 0x000295B0 File Offset: 0x000277B0
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return IConfigurationLoaderInvoker._members;
			}
		}

		// Token: 0x1700057D RID: 1405
		// (get) Token: 0x06000F27 RID: 3879 RVA: 0x000295B7 File Offset: 0x000277B7
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x1700057E RID: 1406
		// (get) Token: 0x06000F28 RID: 3880 RVA: 0x000295BF File Offset: 0x000277BF
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return IConfigurationLoaderInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x06000F29 RID: 3881 RVA: 0x000295CB File Offset: 0x000277CB
		public static IConfigurationLoader GetObject(IntPtr handle, JniHandleOwnership transfer)
		{
			return Java.Lang.Object.GetObject<IConfigurationLoader>(handle, transfer);
		}

		// Token: 0x06000F2A RID: 3882 RVA: 0x000295D4 File Offset: 0x000277D4
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, IConfigurationLoaderInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'com.unity3d.services.core.configuration.IConfigurationLoader'.");
			}
			return handle;
		}

		// Token: 0x06000F2B RID: 3883 RVA: 0x000295FF File Offset: 0x000277FF
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x06000F2C RID: 3884 RVA: 0x00029630 File Offset: 0x00027830
		public IConfigurationLoaderInvoker(IntPtr handle, JniHandleOwnership transfer) : base(IConfigurationLoaderInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x06000F2D RID: 3885 RVA: 0x00029668 File Offset: 0x00027868
		private static Delegate GetGetLocalConfigurationHandler()
		{
			if (IConfigurationLoaderInvoker.cb_getLocalConfiguration == null)
			{
				IConfigurationLoaderInvoker.cb_getLocalConfiguration = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IConfigurationLoaderInvoker.n_GetLocalConfiguration));
			}
			return IConfigurationLoaderInvoker.cb_getLocalConfiguration;
		}

		// Token: 0x06000F2E RID: 3886 RVA: 0x0002968C File Offset: 0x0002788C
		private static IntPtr n_GetLocalConfiguration(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<IConfigurationLoader>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).LocalConfiguration);
		}

		// Token: 0x1700057F RID: 1407
		// (get) Token: 0x06000F2F RID: 3887 RVA: 0x000296A0 File Offset: 0x000278A0
		public Configuration LocalConfiguration
		{
			get
			{
				if (this.id_getLocalConfiguration == IntPtr.Zero)
				{
					this.id_getLocalConfiguration = JNIEnv.GetMethodID(this.class_ref, "getLocalConfiguration", "()Lcom/unity3d/services/core/configuration/Configuration;");
				}
				return Java.Lang.Object.GetObject<Configuration>(JNIEnv.CallObjectMethod(base.Handle, this.id_getLocalConfiguration), JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x06000F30 RID: 3888 RVA: 0x000296F1 File Offset: 0x000278F1
		private static Delegate GetLoadConfiguration_Lcom_unity3d_services_core_configuration_IConfigurationLoaderListener_Handler()
		{
			if (IConfigurationLoaderInvoker.cb_loadConfiguration_Lcom_unity3d_services_core_configuration_IConfigurationLoaderListener_ == null)
			{
				IConfigurationLoaderInvoker.cb_loadConfiguration_Lcom_unity3d_services_core_configuration_IConfigurationLoaderListener_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(IConfigurationLoaderInvoker.n_LoadConfiguration_Lcom_unity3d_services_core_configuration_IConfigurationLoaderListener_));
			}
			return IConfigurationLoaderInvoker.cb_loadConfiguration_Lcom_unity3d_services_core_configuration_IConfigurationLoaderListener_;
		}

		// Token: 0x06000F31 RID: 3889 RVA: 0x00029718 File Offset: 0x00027918
		private static void n_LoadConfiguration_Lcom_unity3d_services_core_configuration_IConfigurationLoaderListener_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			IConfigurationLoader @object = Java.Lang.Object.GetObject<IConfigurationLoader>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			IConfigurationLoaderListener object2 = Java.Lang.Object.GetObject<IConfigurationLoaderListener>(native_p0, JniHandleOwnership.DoNotTransfer);
			@object.LoadConfiguration(object2);
		}

		// Token: 0x06000F32 RID: 3890 RVA: 0x0002973C File Offset: 0x0002793C
		public unsafe void LoadConfiguration(IConfigurationLoaderListener p0)
		{
			if (this.id_loadConfiguration_Lcom_unity3d_services_core_configuration_IConfigurationLoaderListener_ == IntPtr.Zero)
			{
				this.id_loadConfiguration_Lcom_unity3d_services_core_configuration_IConfigurationLoaderListener_ = JNIEnv.GetMethodID(this.class_ref, "loadConfiguration", "(Lcom/unity3d/services/core/configuration/IConfigurationLoaderListener;)V");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue((p0 == null) ? IntPtr.Zero : ((Java.Lang.Object)p0).Handle);
			JNIEnv.CallVoidMethod(base.Handle, this.id_loadConfiguration_Lcom_unity3d_services_core_configuration_IConfigurationLoaderListener_, ptr);
		}

		// Token: 0x04000389 RID: 905
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/unity3d/services/core/configuration/IConfigurationLoader", typeof(IConfigurationLoaderInvoker));

		// Token: 0x0400038A RID: 906
		private IntPtr class_ref;

		// Token: 0x0400038B RID: 907
		private static Delegate cb_getLocalConfiguration;

		// Token: 0x0400038C RID: 908
		private IntPtr id_getLocalConfiguration;

		// Token: 0x0400038D RID: 909
		private static Delegate cb_loadConfiguration_Lcom_unity3d_services_core_configuration_IConfigurationLoaderListener_;

		// Token: 0x0400038E RID: 910
		private IntPtr id_loadConfiguration_Lcom_unity3d_services_core_configuration_IConfigurationLoaderListener_;
	}
}
