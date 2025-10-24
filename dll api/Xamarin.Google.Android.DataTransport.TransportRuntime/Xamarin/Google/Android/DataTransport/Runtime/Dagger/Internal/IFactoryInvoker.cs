using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;
using JavaX.Inject;

namespace Xamarin.Google.Android.DataTransport.Runtime.Dagger.Internal
{
	// Token: 0x020000E4 RID: 228
	[Register("com/google/android/datatransport/runtime/dagger/internal/Factory", DoNotGenerateAcw = true)]
	internal class IFactoryInvoker : Java.Lang.Object, IFactory, IProvider, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x17000266 RID: 614
		// (get) Token: 0x0600080F RID: 2063 RVA: 0x00016860 File Offset: 0x00014A60
		private static IntPtr java_class_ref
		{
			get
			{
				return IFactoryInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000267 RID: 615
		// (get) Token: 0x06000810 RID: 2064 RVA: 0x00016884 File Offset: 0x00014A84
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return IFactoryInvoker._members;
			}
		}

		// Token: 0x17000268 RID: 616
		// (get) Token: 0x06000811 RID: 2065 RVA: 0x0001688B File Offset: 0x00014A8B
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x17000269 RID: 617
		// (get) Token: 0x06000812 RID: 2066 RVA: 0x00016893 File Offset: 0x00014A93
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return IFactoryInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x06000813 RID: 2067 RVA: 0x0001689F File Offset: 0x00014A9F
		public static IFactory GetObject(IntPtr handle, JniHandleOwnership transfer)
		{
			return Java.Lang.Object.GetObject<IFactory>(handle, transfer);
		}

		// Token: 0x06000814 RID: 2068 RVA: 0x000168A8 File Offset: 0x00014AA8
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, IFactoryInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'com.google.android.datatransport.runtime.dagger.internal.Factory'.");
			}
			return handle;
		}

		// Token: 0x06000815 RID: 2069 RVA: 0x000168D3 File Offset: 0x00014AD3
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x06000816 RID: 2070 RVA: 0x00016904 File Offset: 0x00014B04
		public IFactoryInvoker(IntPtr handle, JniHandleOwnership transfer) : base(IFactoryInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x06000817 RID: 2071 RVA: 0x0001693C File Offset: 0x00014B3C
		private static Delegate GetGetHandler()
		{
			if (IFactoryInvoker.cb_get == null)
			{
				IFactoryInvoker.cb_get = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IFactoryInvoker.n_Get));
			}
			return IFactoryInvoker.cb_get;
		}

		// Token: 0x06000818 RID: 2072 RVA: 0x00016960 File Offset: 0x00014B60
		private static IntPtr n_Get(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<IFactory>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Get());
		}

		// Token: 0x06000819 RID: 2073 RVA: 0x00016974 File Offset: 0x00014B74
		public Java.Lang.Object Get()
		{
			if (this.id_get == IntPtr.Zero)
			{
				this.id_get = JNIEnv.GetMethodID(this.class_ref, "get", "()Ljava/lang/Object;");
			}
			return Java.Lang.Object.GetObject<Java.Lang.Object>(JNIEnv.CallObjectMethod(base.Handle, this.id_get), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x04000244 RID: 580
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/google/android/datatransport/runtime/dagger/internal/Factory", typeof(IFactoryInvoker));

		// Token: 0x04000245 RID: 581
		private IntPtr class_ref;

		// Token: 0x04000246 RID: 582
		private static Delegate cb_get;

		// Token: 0x04000247 RID: 583
		private IntPtr id_get;
	}
}
