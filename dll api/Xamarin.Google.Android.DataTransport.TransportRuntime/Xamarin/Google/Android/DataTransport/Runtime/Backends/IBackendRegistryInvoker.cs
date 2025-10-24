using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Xamarin.Google.Android.DataTransport.Runtime.Backends
{
	// Token: 0x02000092 RID: 146
	[Register("com/google/android/datatransport/runtime/backends/BackendRegistry", DoNotGenerateAcw = true)]
	internal class IBackendRegistryInvoker : Java.Lang.Object, IBackendRegistry, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x170001CF RID: 463
		// (get) Token: 0x06000554 RID: 1364 RVA: 0x000101A4 File Offset: 0x0000E3A4
		private static IntPtr java_class_ref
		{
			get
			{
				return IBackendRegistryInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170001D0 RID: 464
		// (get) Token: 0x06000555 RID: 1365 RVA: 0x000101C8 File Offset: 0x0000E3C8
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return IBackendRegistryInvoker._members;
			}
		}

		// Token: 0x170001D1 RID: 465
		// (get) Token: 0x06000556 RID: 1366 RVA: 0x000101CF File Offset: 0x0000E3CF
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x170001D2 RID: 466
		// (get) Token: 0x06000557 RID: 1367 RVA: 0x000101D7 File Offset: 0x0000E3D7
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return IBackendRegistryInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x06000558 RID: 1368 RVA: 0x000101E3 File Offset: 0x0000E3E3
		public static IBackendRegistry GetObject(IntPtr handle, JniHandleOwnership transfer)
		{
			return Java.Lang.Object.GetObject<IBackendRegistry>(handle, transfer);
		}

		// Token: 0x06000559 RID: 1369 RVA: 0x000101EC File Offset: 0x0000E3EC
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, IBackendRegistryInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'com.google.android.datatransport.runtime.backends.BackendRegistry'.");
			}
			return handle;
		}

		// Token: 0x0600055A RID: 1370 RVA: 0x00010217 File Offset: 0x0000E417
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x0600055B RID: 1371 RVA: 0x00010248 File Offset: 0x0000E448
		public IBackendRegistryInvoker(IntPtr handle, JniHandleOwnership transfer) : base(IBackendRegistryInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x0600055C RID: 1372 RVA: 0x00010280 File Offset: 0x0000E480
		private static Delegate GetGet_Ljava_lang_String_Handler()
		{
			if (IBackendRegistryInvoker.cb_get_Ljava_lang_String_ == null)
			{
				IBackendRegistryInvoker.cb_get_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(IBackendRegistryInvoker.n_Get_Ljava_lang_String_));
			}
			return IBackendRegistryInvoker.cb_get_Ljava_lang_String_;
		}

		// Token: 0x0600055D RID: 1373 RVA: 0x000102A4 File Offset: 0x0000E4A4
		private static IntPtr n_Get_Ljava_lang_String_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			IBackendRegistry @object = Java.Lang.Object.GetObject<IBackendRegistry>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string @string = JNIEnv.GetString(native_p0, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.Get(@string));
		}

		// Token: 0x0600055E RID: 1374 RVA: 0x000102CC File Offset: 0x0000E4CC
		public unsafe ITransportBackend Get(string p0)
		{
			if (this.id_get_Ljava_lang_String_ == IntPtr.Zero)
			{
				this.id_get_Ljava_lang_String_ = JNIEnv.GetMethodID(this.class_ref, "get", "(Ljava/lang/String;)Lcom/google/android/datatransport/runtime/backends/TransportBackend;");
			}
			IntPtr intPtr = JNIEnv.NewString(p0);
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue(intPtr);
			ITransportBackend @object = Java.Lang.Object.GetObject<ITransportBackend>(JNIEnv.CallObjectMethod(base.Handle, this.id_get_Ljava_lang_String_, ptr), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef(intPtr);
			return @object;
		}

		// Token: 0x04000122 RID: 290
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/google/android/datatransport/runtime/backends/BackendRegistry", typeof(IBackendRegistryInvoker));

		// Token: 0x04000123 RID: 291
		private IntPtr class_ref;

		// Token: 0x04000124 RID: 292
		private static Delegate cb_get_Ljava_lang_String_;

		// Token: 0x04000125 RID: 293
		private IntPtr id_get_Ljava_lang_String_;
	}
}
