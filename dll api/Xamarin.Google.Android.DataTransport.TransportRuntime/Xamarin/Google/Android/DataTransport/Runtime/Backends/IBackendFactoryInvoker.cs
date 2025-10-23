using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Xamarin.Google.Android.DataTransport.Runtime.Backends
{
	// Token: 0x02000090 RID: 144
	[Register("com/google/android/datatransport/runtime/backends/BackendFactory", DoNotGenerateAcw = true)]
	internal class IBackendFactoryInvoker : Java.Lang.Object, IBackendFactory, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x170001CB RID: 459
		// (get) Token: 0x06000547 RID: 1351 RVA: 0x0000FFE8 File Offset: 0x0000E1E8
		private static IntPtr java_class_ref
		{
			get
			{
				return IBackendFactoryInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170001CC RID: 460
		// (get) Token: 0x06000548 RID: 1352 RVA: 0x0001000C File Offset: 0x0000E20C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return IBackendFactoryInvoker._members;
			}
		}

		// Token: 0x170001CD RID: 461
		// (get) Token: 0x06000549 RID: 1353 RVA: 0x00010013 File Offset: 0x0000E213
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x170001CE RID: 462
		// (get) Token: 0x0600054A RID: 1354 RVA: 0x0001001B File Offset: 0x0000E21B
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return IBackendFactoryInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x0600054B RID: 1355 RVA: 0x00010027 File Offset: 0x0000E227
		public static IBackendFactory GetObject(IntPtr handle, JniHandleOwnership transfer)
		{
			return Java.Lang.Object.GetObject<IBackendFactory>(handle, transfer);
		}

		// Token: 0x0600054C RID: 1356 RVA: 0x00010030 File Offset: 0x0000E230
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, IBackendFactoryInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'com.google.android.datatransport.runtime.backends.BackendFactory'.");
			}
			return handle;
		}

		// Token: 0x0600054D RID: 1357 RVA: 0x0001005B File Offset: 0x0000E25B
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x0600054E RID: 1358 RVA: 0x0001008C File Offset: 0x0000E28C
		public IBackendFactoryInvoker(IntPtr handle, JniHandleOwnership transfer) : base(IBackendFactoryInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x0600054F RID: 1359 RVA: 0x000100C4 File Offset: 0x0000E2C4
		private static Delegate GetCreate_Lcom_google_android_datatransport_runtime_backends_CreationContext_Handler()
		{
			if (IBackendFactoryInvoker.cb_create_Lcom_google_android_datatransport_runtime_backends_CreationContext_ == null)
			{
				IBackendFactoryInvoker.cb_create_Lcom_google_android_datatransport_runtime_backends_CreationContext_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(IBackendFactoryInvoker.n_Create_Lcom_google_android_datatransport_runtime_backends_CreationContext_));
			}
			return IBackendFactoryInvoker.cb_create_Lcom_google_android_datatransport_runtime_backends_CreationContext_;
		}

		// Token: 0x06000550 RID: 1360 RVA: 0x000100E8 File Offset: 0x0000E2E8
		private static IntPtr n_Create_Lcom_google_android_datatransport_runtime_backends_CreationContext_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			IBackendFactory @object = Java.Lang.Object.GetObject<IBackendFactory>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			CreationContext object2 = Java.Lang.Object.GetObject<CreationContext>(native_p0, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.Create(object2));
		}

		// Token: 0x06000551 RID: 1361 RVA: 0x00010110 File Offset: 0x0000E310
		public unsafe ITransportBackend Create(CreationContext p0)
		{
			if (this.id_create_Lcom_google_android_datatransport_runtime_backends_CreationContext_ == IntPtr.Zero)
			{
				this.id_create_Lcom_google_android_datatransport_runtime_backends_CreationContext_ = JNIEnv.GetMethodID(this.class_ref, "create", "(Lcom/google/android/datatransport/runtime/backends/CreationContext;)Lcom/google/android/datatransport/runtime/backends/TransportBackend;");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue((p0 == null) ? IntPtr.Zero : p0.Handle);
			return Java.Lang.Object.GetObject<ITransportBackend>(JNIEnv.CallObjectMethod(base.Handle, this.id_create_Lcom_google_android_datatransport_runtime_backends_CreationContext_, ptr), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x0400011E RID: 286
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/google/android/datatransport/runtime/backends/BackendFactory", typeof(IBackendFactoryInvoker));

		// Token: 0x0400011F RID: 287
		private IntPtr class_ref;

		// Token: 0x04000120 RID: 288
		private static Delegate cb_create_Lcom_google_android_datatransport_runtime_backends_CreationContext_;

		// Token: 0x04000121 RID: 289
		private IntPtr id_create_Lcom_google_android_datatransport_runtime_backends_CreationContext_;
	}
}
