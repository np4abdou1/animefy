using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.OS;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Android.Gms.Common.Internal
{
	// Token: 0x02000015 RID: 21
	[Register("com/google/android/gms/common/internal/ICancelToken", DoNotGenerateAcw = true)]
	internal class ICancelTokenInvoker : Java.Lang.Object, ICancelToken, IInterface, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x1700001B RID: 27
		// (get) Token: 0x06000070 RID: 112 RVA: 0x00002C70 File Offset: 0x00000E70
		private static IntPtr java_class_ref
		{
			get
			{
				return ICancelTokenInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700001C RID: 28
		// (get) Token: 0x06000071 RID: 113 RVA: 0x00002C94 File Offset: 0x00000E94
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return ICancelTokenInvoker._members;
			}
		}

		// Token: 0x1700001D RID: 29
		// (get) Token: 0x06000072 RID: 114 RVA: 0x00002C9B File Offset: 0x00000E9B
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x1700001E RID: 30
		// (get) Token: 0x06000073 RID: 115 RVA: 0x00002CA3 File Offset: 0x00000EA3
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return ICancelTokenInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x06000074 RID: 116 RVA: 0x00002CAF File Offset: 0x00000EAF
		public static ICancelToken GetObject(IntPtr handle, JniHandleOwnership transfer)
		{
			return Java.Lang.Object.GetObject<ICancelToken>(handle, transfer);
		}

		// Token: 0x06000075 RID: 117 RVA: 0x00002CB8 File Offset: 0x00000EB8
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, ICancelTokenInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'com.google.android.gms.common.internal.ICancelToken'.");
			}
			return handle;
		}

		// Token: 0x06000076 RID: 118 RVA: 0x00002CE3 File Offset: 0x00000EE3
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x06000077 RID: 119 RVA: 0x00002D14 File Offset: 0x00000F14
		public ICancelTokenInvoker(IntPtr handle, JniHandleOwnership transfer) : base(ICancelTokenInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x06000078 RID: 120 RVA: 0x00002D4C File Offset: 0x00000F4C
		private static Delegate GetCancelHandler()
		{
			if (ICancelTokenInvoker.cb_cancel == null)
			{
				ICancelTokenInvoker.cb_cancel = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_V(ICancelTokenInvoker.n_Cancel));
			}
			return ICancelTokenInvoker.cb_cancel;
		}

		// Token: 0x06000079 RID: 121 RVA: 0x00002D70 File Offset: 0x00000F70
		private static void n_Cancel(IntPtr jnienv, IntPtr native__this)
		{
			Java.Lang.Object.GetObject<ICancelToken>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Cancel();
		}

		// Token: 0x0600007A RID: 122 RVA: 0x00002D7F File Offset: 0x00000F7F
		public void Cancel()
		{
			if (this.id_cancel == IntPtr.Zero)
			{
				this.id_cancel = JNIEnv.GetMethodID(this.class_ref, "cancel", "()V");
			}
			JNIEnv.CallVoidMethod(base.Handle, this.id_cancel);
		}

		// Token: 0x0600007B RID: 123 RVA: 0x00002DBF File Offset: 0x00000FBF
		private static Delegate GetAsBinderHandler()
		{
			if (ICancelTokenInvoker.cb_asBinder == null)
			{
				ICancelTokenInvoker.cb_asBinder = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(ICancelTokenInvoker.n_AsBinder));
			}
			return ICancelTokenInvoker.cb_asBinder;
		}

		// Token: 0x0600007C RID: 124 RVA: 0x00002DE3 File Offset: 0x00000FE3
		private static IntPtr n_AsBinder(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<ICancelToken>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).AsBinder());
		}

		// Token: 0x0600007D RID: 125 RVA: 0x00002DF8 File Offset: 0x00000FF8
		public IBinder AsBinder()
		{
			if (this.id_asBinder == IntPtr.Zero)
			{
				this.id_asBinder = JNIEnv.GetMethodID(this.class_ref, "asBinder", "()Landroid/os/IBinder;");
			}
			return Java.Lang.Object.GetObject<IBinder>(JNIEnv.CallObjectMethod(base.Handle, this.id_asBinder), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x0400000D RID: 13
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/google/android/gms/common/internal/ICancelToken", typeof(ICancelTokenInvoker));

		// Token: 0x0400000E RID: 14
		private IntPtr class_ref;

		// Token: 0x0400000F RID: 15
		private static Delegate cb_cancel;

		// Token: 0x04000010 RID: 16
		private IntPtr id_cancel;

		// Token: 0x04000011 RID: 17
		private static Delegate cb_asBinder;

		// Token: 0x04000012 RID: 18
		private IntPtr id_asBinder;
	}
}
