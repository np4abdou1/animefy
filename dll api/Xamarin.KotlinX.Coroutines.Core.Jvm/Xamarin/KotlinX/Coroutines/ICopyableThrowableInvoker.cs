using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Xamarin.KotlinX.Coroutines
{
	// Token: 0x0200004E RID: 78
	[NullableContext(1)]
	[Nullable(0)]
	[Register("kotlinx/coroutines/CopyableThrowable", DoNotGenerateAcw = true)]
	internal class ICopyableThrowableInvoker : Java.Lang.Object, ICopyableThrowable, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x170000E1 RID: 225
		// (get) Token: 0x06000305 RID: 773 RVA: 0x0000AB1C File Offset: 0x00008D1C
		private static IntPtr java_class_ref
		{
			get
			{
				return ICopyableThrowableInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170000E2 RID: 226
		// (get) Token: 0x06000306 RID: 774 RVA: 0x0000AB40 File Offset: 0x00008D40
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return ICopyableThrowableInvoker._members;
			}
		}

		// Token: 0x170000E3 RID: 227
		// (get) Token: 0x06000307 RID: 775 RVA: 0x0000AB47 File Offset: 0x00008D47
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x170000E4 RID: 228
		// (get) Token: 0x06000308 RID: 776 RVA: 0x0000AB4F File Offset: 0x00008D4F
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return ICopyableThrowableInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x06000309 RID: 777 RVA: 0x0000AB5B File Offset: 0x00008D5B
		[NullableContext(2)]
		public static ICopyableThrowable GetObject(IntPtr handle, JniHandleOwnership transfer)
		{
			return Java.Lang.Object.GetObject<ICopyableThrowable>(handle, transfer);
		}

		// Token: 0x0600030A RID: 778 RVA: 0x0000AB64 File Offset: 0x00008D64
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, ICopyableThrowableInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'kotlinx.coroutines.CopyableThrowable'.");
			}
			return handle;
		}

		// Token: 0x0600030B RID: 779 RVA: 0x0000AB8F File Offset: 0x00008D8F
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x0600030C RID: 780 RVA: 0x0000ABC0 File Offset: 0x00008DC0
		public ICopyableThrowableInvoker(IntPtr handle, JniHandleOwnership transfer) : base(ICopyableThrowableInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x0600030D RID: 781 RVA: 0x0000ABF8 File Offset: 0x00008DF8
		private static Delegate GetCreateCopyHandler()
		{
			if (ICopyableThrowableInvoker.cb_createCopy == null)
			{
				ICopyableThrowableInvoker.cb_createCopy = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(ICopyableThrowableInvoker.n_CreateCopy));
			}
			return ICopyableThrowableInvoker.cb_createCopy;
		}

		// Token: 0x0600030E RID: 782 RVA: 0x0000AC1C File Offset: 0x00008E1C
		private static IntPtr n_CreateCopy(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<ICopyableThrowable>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).CreateCopy());
		}

		// Token: 0x0600030F RID: 783 RVA: 0x0000AC30 File Offset: 0x00008E30
		[NullableContext(2)]
		public Java.Lang.Object CreateCopy()
		{
			if (this.id_createCopy == IntPtr.Zero)
			{
				this.id_createCopy = JNIEnv.GetMethodID(this.class_ref, "createCopy", "()Ljava/lang/Throwable;");
			}
			return Java.Lang.Object.GetObject<Java.Lang.Object>(JNIEnv.CallObjectMethod(base.Handle, this.id_createCopy), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x040000FD RID: 253
		private static readonly JniPeerMembers _members = new XAPeerMembers("kotlinx/coroutines/CopyableThrowable", typeof(ICopyableThrowableInvoker));

		// Token: 0x040000FE RID: 254
		private IntPtr class_ref;

		// Token: 0x040000FF RID: 255
		[Nullable(2)]
		private static Delegate cb_createCopy;

		// Token: 0x04000100 RID: 256
		private IntPtr id_createCopy;
	}
}
