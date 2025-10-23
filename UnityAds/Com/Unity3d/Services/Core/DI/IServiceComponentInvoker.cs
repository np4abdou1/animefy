using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Com.Unity3d.Services.Core.DI
{
	// Token: 0x0200010C RID: 268
	[Register("com/unity3d/services/core/di/ServiceComponent", DoNotGenerateAcw = true)]
	internal class IServiceComponentInvoker : Java.Lang.Object, IServiceComponent, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x17000362 RID: 866
		// (get) Token: 0x06000A7A RID: 2682 RVA: 0x0001E3CC File Offset: 0x0001C5CC
		private static IntPtr java_class_ref
		{
			get
			{
				return IServiceComponentInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000363 RID: 867
		// (get) Token: 0x06000A7B RID: 2683 RVA: 0x0001E3F0 File Offset: 0x0001C5F0
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return IServiceComponentInvoker._members;
			}
		}

		// Token: 0x17000364 RID: 868
		// (get) Token: 0x06000A7C RID: 2684 RVA: 0x0001E3F7 File Offset: 0x0001C5F7
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x17000365 RID: 869
		// (get) Token: 0x06000A7D RID: 2685 RVA: 0x0001E3FF File Offset: 0x0001C5FF
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return IServiceComponentInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x06000A7E RID: 2686 RVA: 0x0001E40B File Offset: 0x0001C60B
		public static IServiceComponent GetObject(IntPtr handle, JniHandleOwnership transfer)
		{
			return Java.Lang.Object.GetObject<IServiceComponent>(handle, transfer);
		}

		// Token: 0x06000A7F RID: 2687 RVA: 0x0001E414 File Offset: 0x0001C614
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, IServiceComponentInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'com.unity3d.services.core.di.ServiceComponent'.");
			}
			return handle;
		}

		// Token: 0x06000A80 RID: 2688 RVA: 0x0001E43F File Offset: 0x0001C63F
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x06000A81 RID: 2689 RVA: 0x0001E470 File Offset: 0x0001C670
		public IServiceComponentInvoker(IntPtr handle, JniHandleOwnership transfer) : base(IServiceComponentInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x06000A82 RID: 2690 RVA: 0x0001E4A8 File Offset: 0x0001C6A8
		private static Delegate GetGetServiceProviderHandler()
		{
			if (IServiceComponentInvoker.cb_getServiceProvider == null)
			{
				IServiceComponentInvoker.cb_getServiceProvider = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IServiceComponentInvoker.n_GetServiceProvider));
			}
			return IServiceComponentInvoker.cb_getServiceProvider;
		}

		// Token: 0x06000A83 RID: 2691 RVA: 0x0001E4CC File Offset: 0x0001C6CC
		private static IntPtr n_GetServiceProvider(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<IServiceComponent>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ServiceProvider);
		}

		// Token: 0x17000366 RID: 870
		// (get) Token: 0x06000A84 RID: 2692 RVA: 0x0001E4E0 File Offset: 0x0001C6E0
		public ServiceProvider ServiceProvider
		{
			get
			{
				if (this.id_getServiceProvider == IntPtr.Zero)
				{
					this.id_getServiceProvider = JNIEnv.GetMethodID(this.class_ref, "getServiceProvider", "()Lcom/unity3d/services/core/di/ServiceProvider;");
				}
				return Java.Lang.Object.GetObject<ServiceProvider>(JNIEnv.CallObjectMethod(base.Handle, this.id_getServiceProvider), JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x04000275 RID: 629
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/unity3d/services/core/di/ServiceComponent", typeof(IServiceComponentInvoker));

		// Token: 0x04000276 RID: 630
		private IntPtr class_ref;

		// Token: 0x04000277 RID: 631
		private static Delegate cb_getServiceProvider;

		// Token: 0x04000278 RID: 632
		private IntPtr id_getServiceProvider;
	}
}
