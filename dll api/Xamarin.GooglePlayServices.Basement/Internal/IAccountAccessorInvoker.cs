using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.OS;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Android.Gms.Common.Internal
{
	// Token: 0x02000013 RID: 19
	[Register("com/google/android/gms/common/internal/IAccountAccessor", DoNotGenerateAcw = true)]
	internal class IAccountAccessorInvoker : Java.Lang.Object, IAccountAccessor, IInterface, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x17000017 RID: 23
		// (get) Token: 0x06000063 RID: 99 RVA: 0x00002AF0 File Offset: 0x00000CF0
		private static IntPtr java_class_ref
		{
			get
			{
				return IAccountAccessorInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000018 RID: 24
		// (get) Token: 0x06000064 RID: 100 RVA: 0x00002B14 File Offset: 0x00000D14
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return IAccountAccessorInvoker._members;
			}
		}

		// Token: 0x17000019 RID: 25
		// (get) Token: 0x06000065 RID: 101 RVA: 0x00002B1B File Offset: 0x00000D1B
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x1700001A RID: 26
		// (get) Token: 0x06000066 RID: 102 RVA: 0x00002B23 File Offset: 0x00000D23
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return IAccountAccessorInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x06000067 RID: 103 RVA: 0x00002B2F File Offset: 0x00000D2F
		public static IAccountAccessor GetObject(IntPtr handle, JniHandleOwnership transfer)
		{
			return Java.Lang.Object.GetObject<IAccountAccessor>(handle, transfer);
		}

		// Token: 0x06000068 RID: 104 RVA: 0x00002B38 File Offset: 0x00000D38
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, IAccountAccessorInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'com.google.android.gms.common.internal.IAccountAccessor'.");
			}
			return handle;
		}

		// Token: 0x06000069 RID: 105 RVA: 0x00002B63 File Offset: 0x00000D63
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x0600006A RID: 106 RVA: 0x00002B94 File Offset: 0x00000D94
		public IAccountAccessorInvoker(IntPtr handle, JniHandleOwnership transfer) : base(IAccountAccessorInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x0600006B RID: 107 RVA: 0x00002BCC File Offset: 0x00000DCC
		private static Delegate GetAsBinderHandler()
		{
			if (IAccountAccessorInvoker.cb_asBinder == null)
			{
				IAccountAccessorInvoker.cb_asBinder = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IAccountAccessorInvoker.n_AsBinder));
			}
			return IAccountAccessorInvoker.cb_asBinder;
		}

		// Token: 0x0600006C RID: 108 RVA: 0x00002BF0 File Offset: 0x00000DF0
		private static IntPtr n_AsBinder(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<IAccountAccessor>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).AsBinder());
		}

		// Token: 0x0600006D RID: 109 RVA: 0x00002C04 File Offset: 0x00000E04
		public IBinder AsBinder()
		{
			if (this.id_asBinder == IntPtr.Zero)
			{
				this.id_asBinder = JNIEnv.GetMethodID(this.class_ref, "asBinder", "()Landroid/os/IBinder;");
			}
			return Java.Lang.Object.GetObject<IBinder>(JNIEnv.CallObjectMethod(base.Handle, this.id_asBinder), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x04000009 RID: 9
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/google/android/gms/common/internal/IAccountAccessor", typeof(IAccountAccessorInvoker));

		// Token: 0x0400000A RID: 10
		private IntPtr class_ref;

		// Token: 0x0400000B RID: 11
		private static Delegate cb_asBinder;

		// Token: 0x0400000C RID: 12
		private IntPtr id_asBinder;
	}
}
