using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Android.Content
{
	// Token: 0x0200028C RID: 652
	[Register("android/content/DialogInterface$OnCancelListener", DoNotGenerateAcw = true)]
	internal class IDialogInterfaceOnCancelListenerInvoker : Java.Lang.Object, IDialogInterfaceOnCancelListener, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x1700055F RID: 1375
		// (get) Token: 0x060018F5 RID: 6389 RVA: 0x0004089C File Offset: 0x0003EA9C
		private static IntPtr java_class_ref
		{
			get
			{
				return IDialogInterfaceOnCancelListenerInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000560 RID: 1376
		// (get) Token: 0x060018F6 RID: 6390 RVA: 0x000408C0 File Offset: 0x0003EAC0
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return IDialogInterfaceOnCancelListenerInvoker._members;
			}
		}

		// Token: 0x17000561 RID: 1377
		// (get) Token: 0x060018F7 RID: 6391 RVA: 0x000408C7 File Offset: 0x0003EAC7
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x17000562 RID: 1378
		// (get) Token: 0x060018F8 RID: 6392 RVA: 0x000408CF File Offset: 0x0003EACF
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return IDialogInterfaceOnCancelListenerInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x060018F9 RID: 6393 RVA: 0x000408DB File Offset: 0x0003EADB
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, IDialogInterfaceOnCancelListenerInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'android.content.DialogInterface.OnCancelListener'.");
			}
			return handle;
		}

		// Token: 0x060018FA RID: 6394 RVA: 0x00040906 File Offset: 0x0003EB06
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x060018FB RID: 6395 RVA: 0x00040938 File Offset: 0x0003EB38
		public IDialogInterfaceOnCancelListenerInvoker(IntPtr handle, JniHandleOwnership transfer) : base(IDialogInterfaceOnCancelListenerInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x060018FC RID: 6396 RVA: 0x00040970 File Offset: 0x0003EB70
		private static Delegate GetOnCancel_Landroid_content_DialogInterface_Handler()
		{
			if (IDialogInterfaceOnCancelListenerInvoker.cb_onCancel_Landroid_content_DialogInterface_ == null)
			{
				IDialogInterfaceOnCancelListenerInvoker.cb_onCancel_Landroid_content_DialogInterface_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(IDialogInterfaceOnCancelListenerInvoker.n_OnCancel_Landroid_content_DialogInterface_));
			}
			return IDialogInterfaceOnCancelListenerInvoker.cb_onCancel_Landroid_content_DialogInterface_;
		}

		// Token: 0x060018FD RID: 6397 RVA: 0x00040994 File Offset: 0x0003EB94
		private static void n_OnCancel_Landroid_content_DialogInterface_(IntPtr jnienv, IntPtr native__this, IntPtr native_dialog)
		{
			IDialogInterfaceOnCancelListener @object = Java.Lang.Object.GetObject<IDialogInterfaceOnCancelListener>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			IDialogInterface object2 = Java.Lang.Object.GetObject<IDialogInterface>(native_dialog, JniHandleOwnership.DoNotTransfer);
			@object.OnCancel(object2);
		}

		// Token: 0x060018FE RID: 6398 RVA: 0x000409B8 File Offset: 0x0003EBB8
		public unsafe void OnCancel(IDialogInterface dialog)
		{
			if (this.id_onCancel_Landroid_content_DialogInterface_ == IntPtr.Zero)
			{
				this.id_onCancel_Landroid_content_DialogInterface_ = JNIEnv.GetMethodID(this.class_ref, "onCancel", "(Landroid/content/DialogInterface;)V");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue((dialog == null) ? IntPtr.Zero : ((Java.Lang.Object)dialog).Handle);
			JNIEnv.CallVoidMethod(base.Handle, this.id_onCancel_Landroid_content_DialogInterface_, ptr);
		}

		// Token: 0x04000A7F RID: 2687
		private static readonly JniPeerMembers _members = new XAPeerMembers("android/content/DialogInterface$OnCancelListener", typeof(IDialogInterfaceOnCancelListenerInvoker));

		// Token: 0x04000A80 RID: 2688
		private IntPtr class_ref;

		// Token: 0x04000A81 RID: 2689
		private static Delegate cb_onCancel_Landroid_content_DialogInterface_;

		// Token: 0x04000A82 RID: 2690
		private IntPtr id_onCancel_Landroid_content_DialogInterface_;
	}
}
