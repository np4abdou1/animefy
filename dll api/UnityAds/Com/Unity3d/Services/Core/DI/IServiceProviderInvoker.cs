using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Com.Unity3d.Services.Core.DI
{
	// Token: 0x0200010F RID: 271
	[Register("com/unity3d/services/core/di/IServiceProvider", DoNotGenerateAcw = true)]
	internal class IServiceProviderInvoker : Java.Lang.Object, IServiceProvider, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x1700036C RID: 876
		// (get) Token: 0x06000A8E RID: 2702 RVA: 0x0001E5C4 File Offset: 0x0001C7C4
		private static IntPtr java_class_ref
		{
			get
			{
				return IServiceProviderInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700036D RID: 877
		// (get) Token: 0x06000A8F RID: 2703 RVA: 0x0001E5E8 File Offset: 0x0001C7E8
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return IServiceProviderInvoker._members;
			}
		}

		// Token: 0x1700036E RID: 878
		// (get) Token: 0x06000A90 RID: 2704 RVA: 0x0001E5EF File Offset: 0x0001C7EF
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x1700036F RID: 879
		// (get) Token: 0x06000A91 RID: 2705 RVA: 0x0001E5F7 File Offset: 0x0001C7F7
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return IServiceProviderInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x06000A92 RID: 2706 RVA: 0x0001E603 File Offset: 0x0001C803
		public static IServiceProvider GetObject(IntPtr handle, JniHandleOwnership transfer)
		{
			return Java.Lang.Object.GetObject<IServiceProvider>(handle, transfer);
		}

		// Token: 0x06000A93 RID: 2707 RVA: 0x0001E60C File Offset: 0x0001C80C
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, IServiceProviderInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'com.unity3d.services.core.di.IServiceProvider'.");
			}
			return handle;
		}

		// Token: 0x06000A94 RID: 2708 RVA: 0x0001E637 File Offset: 0x0001C837
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x06000A95 RID: 2709 RVA: 0x0001E668 File Offset: 0x0001C868
		public IServiceProviderInvoker(IntPtr handle, JniHandleOwnership transfer) : base(IServiceProviderInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x06000A96 RID: 2710 RVA: 0x0001E6A0 File Offset: 0x0001C8A0
		private static Delegate GetGetRegistryHandler()
		{
			if (IServiceProviderInvoker.cb_getRegistry == null)
			{
				IServiceProviderInvoker.cb_getRegistry = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IServiceProviderInvoker.n_GetRegistry));
			}
			return IServiceProviderInvoker.cb_getRegistry;
		}

		// Token: 0x06000A97 RID: 2711 RVA: 0x0001E6C4 File Offset: 0x0001C8C4
		private static IntPtr n_GetRegistry(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<IServiceProvider>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Registry);
		}

		// Token: 0x17000370 RID: 880
		// (get) Token: 0x06000A98 RID: 2712 RVA: 0x0001E6D8 File Offset: 0x0001C8D8
		public IServicesRegistry Registry
		{
			get
			{
				if (this.id_getRegistry == IntPtr.Zero)
				{
					this.id_getRegistry = JNIEnv.GetMethodID(this.class_ref, "getRegistry", "()Lcom/unity3d/services/core/di/IServicesRegistry;");
				}
				return Java.Lang.Object.GetObject<IServicesRegistry>(JNIEnv.CallObjectMethod(base.Handle, this.id_getRegistry), JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x06000A99 RID: 2713 RVA: 0x0001E729 File Offset: 0x0001C929
		private static Delegate GetInitializeHandler()
		{
			if (IServiceProviderInvoker.cb_initialize == null)
			{
				IServiceProviderInvoker.cb_initialize = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IServiceProviderInvoker.n_Initialize));
			}
			return IServiceProviderInvoker.cb_initialize;
		}

		// Token: 0x06000A9A RID: 2714 RVA: 0x0001E74D File Offset: 0x0001C94D
		private static IntPtr n_Initialize(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<IServiceProvider>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Initialize());
		}

		// Token: 0x06000A9B RID: 2715 RVA: 0x0001E764 File Offset: 0x0001C964
		public IServicesRegistry Initialize()
		{
			if (this.id_initialize == IntPtr.Zero)
			{
				this.id_initialize = JNIEnv.GetMethodID(this.class_ref, "initialize", "()Lcom/unity3d/services/core/di/IServicesRegistry;");
			}
			return Java.Lang.Object.GetObject<IServicesRegistry>(JNIEnv.CallObjectMethod(base.Handle, this.id_initialize), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x0400027A RID: 634
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/unity3d/services/core/di/IServiceProvider", typeof(IServiceProviderInvoker));

		// Token: 0x0400027B RID: 635
		private IntPtr class_ref;

		// Token: 0x0400027C RID: 636
		private static Delegate cb_getRegistry;

		// Token: 0x0400027D RID: 637
		private IntPtr id_getRegistry;

		// Token: 0x0400027E RID: 638
		private static Delegate cb_initialize;

		// Token: 0x0400027F RID: 639
		private IntPtr id_initialize;
	}
}
