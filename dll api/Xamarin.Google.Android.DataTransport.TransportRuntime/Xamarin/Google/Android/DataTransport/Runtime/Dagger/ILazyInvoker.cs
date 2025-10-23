using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Xamarin.Google.Android.DataTransport.Runtime.Dagger
{
	// Token: 0x020000A8 RID: 168
	[Register("com/google/android/datatransport/runtime/dagger/Lazy", DoNotGenerateAcw = true)]
	internal class ILazyInvoker : Java.Lang.Object, ILazy, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x170001F9 RID: 505
		// (get) Token: 0x06000614 RID: 1556 RVA: 0x00011F20 File Offset: 0x00010120
		private static IntPtr java_class_ref
		{
			get
			{
				return ILazyInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170001FA RID: 506
		// (get) Token: 0x06000615 RID: 1557 RVA: 0x00011F44 File Offset: 0x00010144
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return ILazyInvoker._members;
			}
		}

		// Token: 0x170001FB RID: 507
		// (get) Token: 0x06000616 RID: 1558 RVA: 0x00011F4B File Offset: 0x0001014B
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x170001FC RID: 508
		// (get) Token: 0x06000617 RID: 1559 RVA: 0x00011F53 File Offset: 0x00010153
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return ILazyInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x06000618 RID: 1560 RVA: 0x00011F5F File Offset: 0x0001015F
		public static ILazy GetObject(IntPtr handle, JniHandleOwnership transfer)
		{
			return Java.Lang.Object.GetObject<ILazy>(handle, transfer);
		}

		// Token: 0x06000619 RID: 1561 RVA: 0x00011F68 File Offset: 0x00010168
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, ILazyInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'com.google.android.datatransport.runtime.dagger.Lazy'.");
			}
			return handle;
		}

		// Token: 0x0600061A RID: 1562 RVA: 0x00011F93 File Offset: 0x00010193
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x0600061B RID: 1563 RVA: 0x00011FC4 File Offset: 0x000101C4
		public ILazyInvoker(IntPtr handle, JniHandleOwnership transfer) : base(ILazyInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x0600061C RID: 1564 RVA: 0x00011FFC File Offset: 0x000101FC
		private static Delegate GetGetHandler()
		{
			if (ILazyInvoker.cb_get == null)
			{
				ILazyInvoker.cb_get = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(ILazyInvoker.n_Get));
			}
			return ILazyInvoker.cb_get;
		}

		// Token: 0x0600061D RID: 1565 RVA: 0x00012020 File Offset: 0x00010220
		private static IntPtr n_Get(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<ILazy>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Get());
		}

		// Token: 0x0600061E RID: 1566 RVA: 0x00012034 File Offset: 0x00010234
		public Java.Lang.Object Get()
		{
			if (this.id_get == IntPtr.Zero)
			{
				this.id_get = JNIEnv.GetMethodID(this.class_ref, "get", "()Ljava/lang/Object;");
			}
			return Java.Lang.Object.GetObject<Java.Lang.Object>(JNIEnv.CallObjectMethod(base.Handle, this.id_get), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x04000171 RID: 369
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/google/android/datatransport/runtime/dagger/Lazy", typeof(ILazyInvoker));

		// Token: 0x04000172 RID: 370
		private IntPtr class_ref;

		// Token: 0x04000173 RID: 371
		private static Delegate cb_get;

		// Token: 0x04000174 RID: 372
		private IntPtr id_get;
	}
}
