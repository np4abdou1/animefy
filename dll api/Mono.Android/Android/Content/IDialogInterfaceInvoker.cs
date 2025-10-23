using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Android.Content
{
	// Token: 0x02000298 RID: 664
	[Register("android/content/DialogInterface", DoNotGenerateAcw = true)]
	internal class IDialogInterfaceInvoker : Java.Lang.Object, IDialogInterface, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x17000574 RID: 1396
		// (get) Token: 0x06001935 RID: 6453 RVA: 0x000411C0 File Offset: 0x0003F3C0
		private static IntPtr java_class_ref
		{
			get
			{
				return IDialogInterfaceInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000575 RID: 1397
		// (get) Token: 0x06001936 RID: 6454 RVA: 0x000411E4 File Offset: 0x0003F3E4
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return IDialogInterfaceInvoker._members;
			}
		}

		// Token: 0x17000576 RID: 1398
		// (get) Token: 0x06001937 RID: 6455 RVA: 0x000411EB File Offset: 0x0003F3EB
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x17000577 RID: 1399
		// (get) Token: 0x06001938 RID: 6456 RVA: 0x000411F3 File Offset: 0x0003F3F3
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return IDialogInterfaceInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x06001939 RID: 6457 RVA: 0x000411FF File Offset: 0x0003F3FF
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, IDialogInterfaceInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'android.content.DialogInterface'.");
			}
			return handle;
		}

		// Token: 0x0600193A RID: 6458 RVA: 0x0004122A File Offset: 0x0003F42A
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x0600193B RID: 6459 RVA: 0x0004125C File Offset: 0x0003F45C
		public IDialogInterfaceInvoker(IntPtr handle, JniHandleOwnership transfer) : base(IDialogInterfaceInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x0600193C RID: 6460 RVA: 0x00041294 File Offset: 0x0003F494
		private static Delegate GetCancelHandler()
		{
			if (IDialogInterfaceInvoker.cb_cancel == null)
			{
				IDialogInterfaceInvoker.cb_cancel = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_V(IDialogInterfaceInvoker.n_Cancel));
			}
			return IDialogInterfaceInvoker.cb_cancel;
		}

		// Token: 0x0600193D RID: 6461 RVA: 0x000412B8 File Offset: 0x0003F4B8
		private static void n_Cancel(IntPtr jnienv, IntPtr native__this)
		{
			Java.Lang.Object.GetObject<IDialogInterface>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Cancel();
		}

		// Token: 0x0600193E RID: 6462 RVA: 0x000412C7 File Offset: 0x0003F4C7
		public void Cancel()
		{
			if (this.id_cancel == IntPtr.Zero)
			{
				this.id_cancel = JNIEnv.GetMethodID(this.class_ref, "cancel", "()V");
			}
			JNIEnv.CallVoidMethod(base.Handle, this.id_cancel);
		}

		// Token: 0x0600193F RID: 6463 RVA: 0x00041307 File Offset: 0x0003F507
		private static Delegate GetDismissHandler()
		{
			if (IDialogInterfaceInvoker.cb_dismiss == null)
			{
				IDialogInterfaceInvoker.cb_dismiss = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_V(IDialogInterfaceInvoker.n_Dismiss));
			}
			return IDialogInterfaceInvoker.cb_dismiss;
		}

		// Token: 0x06001940 RID: 6464 RVA: 0x0004132B File Offset: 0x0003F52B
		private static void n_Dismiss(IntPtr jnienv, IntPtr native__this)
		{
			Java.Lang.Object.GetObject<IDialogInterface>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Dismiss();
		}

		// Token: 0x06001941 RID: 6465 RVA: 0x0004133A File Offset: 0x0003F53A
		public void Dismiss()
		{
			if (this.id_dismiss == IntPtr.Zero)
			{
				this.id_dismiss = JNIEnv.GetMethodID(this.class_ref, "dismiss", "()V");
			}
			JNIEnv.CallVoidMethod(base.Handle, this.id_dismiss);
		}

		// Token: 0x04000A96 RID: 2710
		private static readonly JniPeerMembers _members = new XAPeerMembers("android/content/DialogInterface", typeof(IDialogInterfaceInvoker));

		// Token: 0x04000A97 RID: 2711
		private IntPtr class_ref;

		// Token: 0x04000A98 RID: 2712
		private static Delegate cb_cancel;

		// Token: 0x04000A99 RID: 2713
		private IntPtr id_cancel;

		// Token: 0x04000A9A RID: 2714
		private static Delegate cb_dismiss;

		// Token: 0x04000A9B RID: 2715
		private IntPtr id_dismiss;
	}
}
