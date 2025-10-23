using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Android.Content
{
	// Token: 0x0200028E RID: 654
	[Register("android/content/DialogInterface$OnClickListener", DoNotGenerateAcw = true)]
	internal class IDialogInterfaceOnClickListenerInvoker : Java.Lang.Object, IDialogInterfaceOnClickListener, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x17000563 RID: 1379
		// (get) Token: 0x06001901 RID: 6401 RVA: 0x00040A4C File Offset: 0x0003EC4C
		private static IntPtr java_class_ref
		{
			get
			{
				return IDialogInterfaceOnClickListenerInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000564 RID: 1380
		// (get) Token: 0x06001902 RID: 6402 RVA: 0x00040A70 File Offset: 0x0003EC70
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return IDialogInterfaceOnClickListenerInvoker._members;
			}
		}

		// Token: 0x17000565 RID: 1381
		// (get) Token: 0x06001903 RID: 6403 RVA: 0x00040A77 File Offset: 0x0003EC77
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x17000566 RID: 1382
		// (get) Token: 0x06001904 RID: 6404 RVA: 0x00040A7F File Offset: 0x0003EC7F
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return IDialogInterfaceOnClickListenerInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x06001905 RID: 6405 RVA: 0x00040A8B File Offset: 0x0003EC8B
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, IDialogInterfaceOnClickListenerInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'android.content.DialogInterface.OnClickListener'.");
			}
			return handle;
		}

		// Token: 0x06001906 RID: 6406 RVA: 0x00040AB6 File Offset: 0x0003ECB6
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x06001907 RID: 6407 RVA: 0x00040AE8 File Offset: 0x0003ECE8
		public IDialogInterfaceOnClickListenerInvoker(IntPtr handle, JniHandleOwnership transfer) : base(IDialogInterfaceOnClickListenerInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x06001908 RID: 6408 RVA: 0x00040B20 File Offset: 0x0003ED20
		private static Delegate GetOnClick_Landroid_content_DialogInterface_IHandler()
		{
			if (IDialogInterfaceOnClickListenerInvoker.cb_onClick_Landroid_content_DialogInterface_I == null)
			{
				IDialogInterfaceOnClickListenerInvoker.cb_onClick_Landroid_content_DialogInterface_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLI_V(IDialogInterfaceOnClickListenerInvoker.n_OnClick_Landroid_content_DialogInterface_I));
			}
			return IDialogInterfaceOnClickListenerInvoker.cb_onClick_Landroid_content_DialogInterface_I;
		}

		// Token: 0x06001909 RID: 6409 RVA: 0x00040B44 File Offset: 0x0003ED44
		private static void n_OnClick_Landroid_content_DialogInterface_I(IntPtr jnienv, IntPtr native__this, IntPtr native_dialog, int which)
		{
			IDialogInterfaceOnClickListener @object = Java.Lang.Object.GetObject<IDialogInterfaceOnClickListener>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			IDialogInterface object2 = Java.Lang.Object.GetObject<IDialogInterface>(native_dialog, JniHandleOwnership.DoNotTransfer);
			@object.OnClick(object2, which);
		}

		// Token: 0x0600190A RID: 6410 RVA: 0x00040B68 File Offset: 0x0003ED68
		public unsafe void OnClick(IDialogInterface dialog, int which)
		{
			if (this.id_onClick_Landroid_content_DialogInterface_I == IntPtr.Zero)
			{
				this.id_onClick_Landroid_content_DialogInterface_I = JNIEnv.GetMethodID(this.class_ref, "onClick", "(Landroid/content/DialogInterface;I)V");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue((dialog == null) ? IntPtr.Zero : ((Java.Lang.Object)dialog).Handle);
			ptr[1] = new JValue(which);
			JNIEnv.CallVoidMethod(base.Handle, this.id_onClick_Landroid_content_DialogInterface_I, ptr);
		}

		// Token: 0x04000A83 RID: 2691
		private static readonly JniPeerMembers _members = new XAPeerMembers("android/content/DialogInterface$OnClickListener", typeof(IDialogInterfaceOnClickListenerInvoker));

		// Token: 0x04000A84 RID: 2692
		private IntPtr class_ref;

		// Token: 0x04000A85 RID: 2693
		private static Delegate cb_onClick_Landroid_content_DialogInterface_I;

		// Token: 0x04000A86 RID: 2694
		private IntPtr id_onClick_Landroid_content_DialogInterface_I;
	}
}
