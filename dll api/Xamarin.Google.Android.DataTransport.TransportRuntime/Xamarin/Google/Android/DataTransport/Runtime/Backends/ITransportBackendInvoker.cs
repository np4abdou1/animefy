using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Xamarin.Google.Android.DataTransport.Runtime.Backends
{
	// Token: 0x02000094 RID: 148
	[Register("com/google/android/datatransport/runtime/backends/TransportBackend", DoNotGenerateAcw = true)]
	internal class ITransportBackendInvoker : Java.Lang.Object, ITransportBackend, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x170001D3 RID: 467
		// (get) Token: 0x06000562 RID: 1378 RVA: 0x00010360 File Offset: 0x0000E560
		private static IntPtr java_class_ref
		{
			get
			{
				return ITransportBackendInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170001D4 RID: 468
		// (get) Token: 0x06000563 RID: 1379 RVA: 0x00010384 File Offset: 0x0000E584
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return ITransportBackendInvoker._members;
			}
		}

		// Token: 0x170001D5 RID: 469
		// (get) Token: 0x06000564 RID: 1380 RVA: 0x0001038B File Offset: 0x0000E58B
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x170001D6 RID: 470
		// (get) Token: 0x06000565 RID: 1381 RVA: 0x00010393 File Offset: 0x0000E593
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return ITransportBackendInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x06000566 RID: 1382 RVA: 0x0001039F File Offset: 0x0000E59F
		public static ITransportBackend GetObject(IntPtr handle, JniHandleOwnership transfer)
		{
			return Java.Lang.Object.GetObject<ITransportBackend>(handle, transfer);
		}

		// Token: 0x06000567 RID: 1383 RVA: 0x000103A8 File Offset: 0x0000E5A8
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, ITransportBackendInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'com.google.android.datatransport.runtime.backends.TransportBackend'.");
			}
			return handle;
		}

		// Token: 0x06000568 RID: 1384 RVA: 0x000103D3 File Offset: 0x0000E5D3
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x06000569 RID: 1385 RVA: 0x00010404 File Offset: 0x0000E604
		public ITransportBackendInvoker(IntPtr handle, JniHandleOwnership transfer) : base(ITransportBackendInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x0600056A RID: 1386 RVA: 0x0001043C File Offset: 0x0000E63C
		private static Delegate GetDecorate_Lcom_google_android_datatransport_runtime_EventInternal_Handler()
		{
			if (ITransportBackendInvoker.cb_decorate_Lcom_google_android_datatransport_runtime_EventInternal_ == null)
			{
				ITransportBackendInvoker.cb_decorate_Lcom_google_android_datatransport_runtime_EventInternal_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(ITransportBackendInvoker.n_Decorate_Lcom_google_android_datatransport_runtime_EventInternal_));
			}
			return ITransportBackendInvoker.cb_decorate_Lcom_google_android_datatransport_runtime_EventInternal_;
		}

		// Token: 0x0600056B RID: 1387 RVA: 0x00010460 File Offset: 0x0000E660
		private static IntPtr n_Decorate_Lcom_google_android_datatransport_runtime_EventInternal_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			ITransportBackend @object = Java.Lang.Object.GetObject<ITransportBackend>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			EventInternal object2 = Java.Lang.Object.GetObject<EventInternal>(native_p0, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.Decorate(object2));
		}

		// Token: 0x0600056C RID: 1388 RVA: 0x00010488 File Offset: 0x0000E688
		public unsafe EventInternal Decorate(EventInternal p0)
		{
			if (this.id_decorate_Lcom_google_android_datatransport_runtime_EventInternal_ == IntPtr.Zero)
			{
				this.id_decorate_Lcom_google_android_datatransport_runtime_EventInternal_ = JNIEnv.GetMethodID(this.class_ref, "decorate", "(Lcom/google/android/datatransport/runtime/EventInternal;)Lcom/google/android/datatransport/runtime/EventInternal;");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue((p0 == null) ? IntPtr.Zero : p0.Handle);
			return Java.Lang.Object.GetObject<EventInternal>(JNIEnv.CallObjectMethod(base.Handle, this.id_decorate_Lcom_google_android_datatransport_runtime_EventInternal_, ptr), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x0600056D RID: 1389 RVA: 0x00010501 File Offset: 0x0000E701
		private static Delegate GetSend_Lcom_google_android_datatransport_runtime_backends_BackendRequest_Handler()
		{
			if (ITransportBackendInvoker.cb_send_Lcom_google_android_datatransport_runtime_backends_BackendRequest_ == null)
			{
				ITransportBackendInvoker.cb_send_Lcom_google_android_datatransport_runtime_backends_BackendRequest_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(ITransportBackendInvoker.n_Send_Lcom_google_android_datatransport_runtime_backends_BackendRequest_));
			}
			return ITransportBackendInvoker.cb_send_Lcom_google_android_datatransport_runtime_backends_BackendRequest_;
		}

		// Token: 0x0600056E RID: 1390 RVA: 0x00010528 File Offset: 0x0000E728
		private static IntPtr n_Send_Lcom_google_android_datatransport_runtime_backends_BackendRequest_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			ITransportBackend @object = Java.Lang.Object.GetObject<ITransportBackend>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			BackendRequest object2 = Java.Lang.Object.GetObject<BackendRequest>(native_p0, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.Send(object2));
		}

		// Token: 0x0600056F RID: 1391 RVA: 0x00010550 File Offset: 0x0000E750
		public unsafe BackendResponse Send(BackendRequest p0)
		{
			if (this.id_send_Lcom_google_android_datatransport_runtime_backends_BackendRequest_ == IntPtr.Zero)
			{
				this.id_send_Lcom_google_android_datatransport_runtime_backends_BackendRequest_ = JNIEnv.GetMethodID(this.class_ref, "send", "(Lcom/google/android/datatransport/runtime/backends/BackendRequest;)Lcom/google/android/datatransport/runtime/backends/BackendResponse;");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue((p0 == null) ? IntPtr.Zero : p0.Handle);
			return Java.Lang.Object.GetObject<BackendResponse>(JNIEnv.CallObjectMethod(base.Handle, this.id_send_Lcom_google_android_datatransport_runtime_backends_BackendRequest_, ptr), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x04000126 RID: 294
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/google/android/datatransport/runtime/backends/TransportBackend", typeof(ITransportBackendInvoker));

		// Token: 0x04000127 RID: 295
		private IntPtr class_ref;

		// Token: 0x04000128 RID: 296
		private static Delegate cb_decorate_Lcom_google_android_datatransport_runtime_EventInternal_;

		// Token: 0x04000129 RID: 297
		private IntPtr id_decorate_Lcom_google_android_datatransport_runtime_EventInternal_;

		// Token: 0x0400012A RID: 298
		private static Delegate cb_send_Lcom_google_android_datatransport_runtime_backends_BackendRequest_;

		// Token: 0x0400012B RID: 299
		private IntPtr id_send_Lcom_google_android_datatransport_runtime_backends_BackendRequest_;
	}
}
