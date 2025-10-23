using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Android.OS
{
	// Token: 0x020001E9 RID: 489
	[Register("android/os/IInterface", DoNotGenerateAcw = true)]
	internal class IInterfaceInvoker : Java.Lang.Object, IInterface, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x17000394 RID: 916
		// (get) Token: 0x060011DE RID: 4574 RVA: 0x0002F540 File Offset: 0x0002D740
		private static IntPtr java_class_ref
		{
			get
			{
				return IInterfaceInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000395 RID: 917
		// (get) Token: 0x060011DF RID: 4575 RVA: 0x0002F564 File Offset: 0x0002D764
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return IInterfaceInvoker._members;
			}
		}

		// Token: 0x17000396 RID: 918
		// (get) Token: 0x060011E0 RID: 4576 RVA: 0x0002F56B File Offset: 0x0002D76B
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x17000397 RID: 919
		// (get) Token: 0x060011E1 RID: 4577 RVA: 0x0002F573 File Offset: 0x0002D773
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return IInterfaceInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x060011E2 RID: 4578 RVA: 0x0002F57F File Offset: 0x0002D77F
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, IInterfaceInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'android.os.IInterface'.");
			}
			return handle;
		}

		// Token: 0x060011E3 RID: 4579 RVA: 0x0002F5AA File Offset: 0x0002D7AA
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x060011E4 RID: 4580 RVA: 0x0002F5DC File Offset: 0x0002D7DC
		public IInterfaceInvoker(IntPtr handle, JniHandleOwnership transfer) : base(IInterfaceInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x060011E5 RID: 4581 RVA: 0x0002F614 File Offset: 0x0002D814
		private static Delegate GetAsBinderHandler()
		{
			if (IInterfaceInvoker.cb_asBinder == null)
			{
				IInterfaceInvoker.cb_asBinder = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IInterfaceInvoker.n_AsBinder));
			}
			return IInterfaceInvoker.cb_asBinder;
		}

		// Token: 0x060011E6 RID: 4582 RVA: 0x0002F638 File Offset: 0x0002D838
		private static IntPtr n_AsBinder(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<IInterface>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).AsBinder());
		}

		// Token: 0x060011E7 RID: 4583 RVA: 0x0002F64C File Offset: 0x0002D84C
		public IBinder AsBinder()
		{
			if (this.id_asBinder == IntPtr.Zero)
			{
				this.id_asBinder = JNIEnv.GetMethodID(this.class_ref, "asBinder", "()Landroid/os/IBinder;");
			}
			return Java.Lang.Object.GetObject<IBinder>(JNIEnv.CallObjectMethod(base.Handle, this.id_asBinder), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x040007F7 RID: 2039
		private static readonly JniPeerMembers _members = new XAPeerMembers("android/os/IInterface", typeof(IInterfaceInvoker));

		// Token: 0x040007F8 RID: 2040
		private IntPtr class_ref;

		// Token: 0x040007F9 RID: 2041
		private static Delegate cb_asBinder;

		// Token: 0x040007FA RID: 2042
		private IntPtr id_asBinder;
	}
}
