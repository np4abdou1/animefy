using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Com.Unity3d.Services.Core.DI
{
	// Token: 0x02000112 RID: 274
	[Register("com/unity3d/services/core/di/IServicesRegistry", DoNotGenerateAcw = true)]
	internal class IServicesRegistryInvoker : Java.Lang.Object, IServicesRegistry, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x17000375 RID: 885
		// (get) Token: 0x06000AA5 RID: 2725 RVA: 0x0001E848 File Offset: 0x0001CA48
		private static IntPtr java_class_ref
		{
			get
			{
				return IServicesRegistryInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000376 RID: 886
		// (get) Token: 0x06000AA6 RID: 2726 RVA: 0x0001E86C File Offset: 0x0001CA6C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return IServicesRegistryInvoker._members;
			}
		}

		// Token: 0x17000377 RID: 887
		// (get) Token: 0x06000AA7 RID: 2727 RVA: 0x0001E873 File Offset: 0x0001CA73
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x17000378 RID: 888
		// (get) Token: 0x06000AA8 RID: 2728 RVA: 0x0001E87B File Offset: 0x0001CA7B
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return IServicesRegistryInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x06000AA9 RID: 2729 RVA: 0x0001E887 File Offset: 0x0001CA87
		public static IServicesRegistry GetObject(IntPtr handle, JniHandleOwnership transfer)
		{
			return Java.Lang.Object.GetObject<IServicesRegistry>(handle, transfer);
		}

		// Token: 0x06000AAA RID: 2730 RVA: 0x0001E890 File Offset: 0x0001CA90
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, IServicesRegistryInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'com.unity3d.services.core.di.IServicesRegistry'.");
			}
			return handle;
		}

		// Token: 0x06000AAB RID: 2731 RVA: 0x0001E8BB File Offset: 0x0001CABB
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x06000AAC RID: 2732 RVA: 0x0001E8EC File Offset: 0x0001CAEC
		public IServicesRegistryInvoker(IntPtr handle, JniHandleOwnership transfer) : base(IServicesRegistryInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x06000AAD RID: 2733 RVA: 0x0001E924 File Offset: 0x0001CB24
		private static Delegate GetResolveService_Lcom_unity3d_services_core_di_ServiceKey_Handler()
		{
			if (IServicesRegistryInvoker.cb_resolveService_Lcom_unity3d_services_core_di_ServiceKey_ == null)
			{
				IServicesRegistryInvoker.cb_resolveService_Lcom_unity3d_services_core_di_ServiceKey_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(IServicesRegistryInvoker.n_ResolveService_Lcom_unity3d_services_core_di_ServiceKey_));
			}
			return IServicesRegistryInvoker.cb_resolveService_Lcom_unity3d_services_core_di_ServiceKey_;
		}

		// Token: 0x06000AAE RID: 2734 RVA: 0x0001E948 File Offset: 0x0001CB48
		private static IntPtr n_ResolveService_Lcom_unity3d_services_core_di_ServiceKey_(IntPtr jnienv, IntPtr native__this, IntPtr native_key)
		{
			IServicesRegistry @object = Java.Lang.Object.GetObject<IServicesRegistry>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			ServiceKey object2 = Java.Lang.Object.GetObject<ServiceKey>(native_key, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.ResolveService(object2));
		}

		// Token: 0x06000AAF RID: 2735 RVA: 0x0001E970 File Offset: 0x0001CB70
		public unsafe Java.Lang.Object ResolveService(ServiceKey key)
		{
			if (this.id_resolveService_Lcom_unity3d_services_core_di_ServiceKey_ == IntPtr.Zero)
			{
				this.id_resolveService_Lcom_unity3d_services_core_di_ServiceKey_ = JNIEnv.GetMethodID(this.class_ref, "resolveService", "(Lcom/unity3d/services/core/di/ServiceKey;)Ljava/lang/Object;");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue((key == null) ? IntPtr.Zero : key.Handle);
			return Java.Lang.Object.GetObject<Java.Lang.Object>(JNIEnv.CallObjectMethod(base.Handle, this.id_resolveService_Lcom_unity3d_services_core_di_ServiceKey_, ptr), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x06000AB0 RID: 2736 RVA: 0x0001E9E9 File Offset: 0x0001CBE9
		private static Delegate GetResolveServiceOrNull_Lcom_unity3d_services_core_di_ServiceKey_Handler()
		{
			if (IServicesRegistryInvoker.cb_resolveServiceOrNull_Lcom_unity3d_services_core_di_ServiceKey_ == null)
			{
				IServicesRegistryInvoker.cb_resolveServiceOrNull_Lcom_unity3d_services_core_di_ServiceKey_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(IServicesRegistryInvoker.n_ResolveServiceOrNull_Lcom_unity3d_services_core_di_ServiceKey_));
			}
			return IServicesRegistryInvoker.cb_resolveServiceOrNull_Lcom_unity3d_services_core_di_ServiceKey_;
		}

		// Token: 0x06000AB1 RID: 2737 RVA: 0x0001EA10 File Offset: 0x0001CC10
		private static IntPtr n_ResolveServiceOrNull_Lcom_unity3d_services_core_di_ServiceKey_(IntPtr jnienv, IntPtr native__this, IntPtr native_key)
		{
			IServicesRegistry @object = Java.Lang.Object.GetObject<IServicesRegistry>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			ServiceKey object2 = Java.Lang.Object.GetObject<ServiceKey>(native_key, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.ResolveServiceOrNull(object2));
		}

		// Token: 0x06000AB2 RID: 2738 RVA: 0x0001EA38 File Offset: 0x0001CC38
		public unsafe Java.Lang.Object ResolveServiceOrNull(ServiceKey key)
		{
			if (this.id_resolveServiceOrNull_Lcom_unity3d_services_core_di_ServiceKey_ == IntPtr.Zero)
			{
				this.id_resolveServiceOrNull_Lcom_unity3d_services_core_di_ServiceKey_ = JNIEnv.GetMethodID(this.class_ref, "resolveServiceOrNull", "(Lcom/unity3d/services/core/di/ServiceKey;)Ljava/lang/Object;");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue((key == null) ? IntPtr.Zero : key.Handle);
			return Java.Lang.Object.GetObject<Java.Lang.Object>(JNIEnv.CallObjectMethod(base.Handle, this.id_resolveServiceOrNull_Lcom_unity3d_services_core_di_ServiceKey_, ptr), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x04000281 RID: 641
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/unity3d/services/core/di/IServicesRegistry", typeof(IServicesRegistryInvoker));

		// Token: 0x04000282 RID: 642
		private IntPtr class_ref;

		// Token: 0x04000283 RID: 643
		private static Delegate cb_resolveService_Lcom_unity3d_services_core_di_ServiceKey_;

		// Token: 0x04000284 RID: 644
		private IntPtr id_resolveService_Lcom_unity3d_services_core_di_ServiceKey_;

		// Token: 0x04000285 RID: 645
		private static Delegate cb_resolveServiceOrNull_Lcom_unity3d_services_core_di_ServiceKey_;

		// Token: 0x04000286 RID: 646
		private IntPtr id_resolveServiceOrNull_Lcom_unity3d_services_core_di_ServiceKey_;
	}
}
