using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Android.Content
{
	// Token: 0x02000291 RID: 657
	[Register("android/content/DialogInterface$OnDismissListener", DoNotGenerateAcw = true)]
	internal class IDialogInterfaceOnDismissListenerInvoker : Java.Lang.Object, IDialogInterfaceOnDismissListener, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x17000568 RID: 1384
		// (get) Token: 0x0600190F RID: 6415 RVA: 0x00040C28 File Offset: 0x0003EE28
		private static IntPtr java_class_ref
		{
			get
			{
				return IDialogInterfaceOnDismissListenerInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000569 RID: 1385
		// (get) Token: 0x06001910 RID: 6416 RVA: 0x00040C4C File Offset: 0x0003EE4C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return IDialogInterfaceOnDismissListenerInvoker._members;
			}
		}

		// Token: 0x1700056A RID: 1386
		// (get) Token: 0x06001911 RID: 6417 RVA: 0x00040C53 File Offset: 0x0003EE53
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x1700056B RID: 1387
		// (get) Token: 0x06001912 RID: 6418 RVA: 0x00040C5B File Offset: 0x0003EE5B
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return IDialogInterfaceOnDismissListenerInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x06001913 RID: 6419 RVA: 0x00040C67 File Offset: 0x0003EE67
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, IDialogInterfaceOnDismissListenerInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'android.content.DialogInterface.OnDismissListener'.");
			}
			return handle;
		}

		// Token: 0x06001914 RID: 6420 RVA: 0x00040C92 File Offset: 0x0003EE92
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x06001915 RID: 6421 RVA: 0x00040CC4 File Offset: 0x0003EEC4
		public IDialogInterfaceOnDismissListenerInvoker(IntPtr handle, JniHandleOwnership transfer) : base(IDialogInterfaceOnDismissListenerInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x06001916 RID: 6422 RVA: 0x00040CFC File Offset: 0x0003EEFC
		private static Delegate GetOnDismiss_Landroid_content_DialogInterface_Handler()
		{
			if (IDialogInterfaceOnDismissListenerInvoker.cb_onDismiss_Landroid_content_DialogInterface_ == null)
			{
				IDialogInterfaceOnDismissListenerInvoker.cb_onDismiss_Landroid_content_DialogInterface_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(IDialogInterfaceOnDismissListenerInvoker.n_OnDismiss_Landroid_content_DialogInterface_));
			}
			return IDialogInterfaceOnDismissListenerInvoker.cb_onDismiss_Landroid_content_DialogInterface_;
		}

		// Token: 0x06001917 RID: 6423 RVA: 0x00040D20 File Offset: 0x0003EF20
		private static void n_OnDismiss_Landroid_content_DialogInterface_(IntPtr jnienv, IntPtr native__this, IntPtr native_dialog)
		{
			IDialogInterfaceOnDismissListener @object = Java.Lang.Object.GetObject<IDialogInterfaceOnDismissListener>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			IDialogInterface object2 = Java.Lang.Object.GetObject<IDialogInterface>(native_dialog, JniHandleOwnership.DoNotTransfer);
			@object.OnDismiss(object2);
		}

		// Token: 0x06001918 RID: 6424 RVA: 0x00040D44 File Offset: 0x0003EF44
		public unsafe void OnDismiss(IDialogInterface dialog)
		{
			if (this.id_onDismiss_Landroid_content_DialogInterface_ == IntPtr.Zero)
			{
				this.id_onDismiss_Landroid_content_DialogInterface_ = JNIEnv.GetMethodID(this.class_ref, "onDismiss", "(Landroid/content/DialogInterface;)V");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue((dialog == null) ? IntPtr.Zero : ((Java.Lang.Object)dialog).Handle);
			JNIEnv.CallVoidMethod(base.Handle, this.id_onDismiss_Landroid_content_DialogInterface_, ptr);
		}

		// Token: 0x04000A88 RID: 2696
		private static readonly JniPeerMembers _members = new XAPeerMembers("android/content/DialogInterface$OnDismissListener", typeof(IDialogInterfaceOnDismissListenerInvoker));

		// Token: 0x04000A89 RID: 2697
		private IntPtr class_ref;

		// Token: 0x04000A8A RID: 2698
		private static Delegate cb_onDismiss_Landroid_content_DialogInterface_;

		// Token: 0x04000A8B RID: 2699
		private IntPtr id_onDismiss_Landroid_content_DialogInterface_;
	}
}
