using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Android.Content
{
	// Token: 0x02000295 RID: 661
	[Register("android/content/DialogInterface$OnMultiChoiceClickListener", DoNotGenerateAcw = true)]
	internal class IDialogInterfaceOnMultiChoiceClickListenerInvoker : Java.Lang.Object, IDialogInterfaceOnMultiChoiceClickListener, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x17000570 RID: 1392
		// (get) Token: 0x06001927 RID: 6439 RVA: 0x00040FCC File Offset: 0x0003F1CC
		private static IntPtr java_class_ref
		{
			get
			{
				return IDialogInterfaceOnMultiChoiceClickListenerInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000571 RID: 1393
		// (get) Token: 0x06001928 RID: 6440 RVA: 0x00040FF0 File Offset: 0x0003F1F0
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return IDialogInterfaceOnMultiChoiceClickListenerInvoker._members;
			}
		}

		// Token: 0x17000572 RID: 1394
		// (get) Token: 0x06001929 RID: 6441 RVA: 0x00040FF7 File Offset: 0x0003F1F7
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x17000573 RID: 1395
		// (get) Token: 0x0600192A RID: 6442 RVA: 0x00040FFF File Offset: 0x0003F1FF
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return IDialogInterfaceOnMultiChoiceClickListenerInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x0600192B RID: 6443 RVA: 0x0004100B File Offset: 0x0003F20B
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, IDialogInterfaceOnMultiChoiceClickListenerInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'android.content.DialogInterface.OnMultiChoiceClickListener'.");
			}
			return handle;
		}

		// Token: 0x0600192C RID: 6444 RVA: 0x00041036 File Offset: 0x0003F236
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x0600192D RID: 6445 RVA: 0x00041068 File Offset: 0x0003F268
		public IDialogInterfaceOnMultiChoiceClickListenerInvoker(IntPtr handle, JniHandleOwnership transfer) : base(IDialogInterfaceOnMultiChoiceClickListenerInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x0600192E RID: 6446 RVA: 0x000410A0 File Offset: 0x0003F2A0
		private static Delegate GetOnClick_Landroid_content_DialogInterface_IZHandler()
		{
			if (IDialogInterfaceOnMultiChoiceClickListenerInvoker.cb_onClick_Landroid_content_DialogInterface_IZ == null)
			{
				IDialogInterfaceOnMultiChoiceClickListenerInvoker.cb_onClick_Landroid_content_DialogInterface_IZ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLIZ_V(IDialogInterfaceOnMultiChoiceClickListenerInvoker.n_OnClick_Landroid_content_DialogInterface_IZ));
			}
			return IDialogInterfaceOnMultiChoiceClickListenerInvoker.cb_onClick_Landroid_content_DialogInterface_IZ;
		}

		// Token: 0x0600192F RID: 6447 RVA: 0x000410C4 File Offset: 0x0003F2C4
		private static void n_OnClick_Landroid_content_DialogInterface_IZ(IntPtr jnienv, IntPtr native__this, IntPtr native_dialog, int which, bool isChecked)
		{
			IDialogInterfaceOnMultiChoiceClickListener @object = Java.Lang.Object.GetObject<IDialogInterfaceOnMultiChoiceClickListener>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			IDialogInterface object2 = Java.Lang.Object.GetObject<IDialogInterface>(native_dialog, JniHandleOwnership.DoNotTransfer);
			@object.OnClick(object2, which, isChecked);
		}

		// Token: 0x06001930 RID: 6448 RVA: 0x000410EC File Offset: 0x0003F2EC
		public unsafe void OnClick(IDialogInterface dialog, int which, bool isChecked)
		{
			if (this.id_onClick_Landroid_content_DialogInterface_IZ == IntPtr.Zero)
			{
				this.id_onClick_Landroid_content_DialogInterface_IZ = JNIEnv.GetMethodID(this.class_ref, "onClick", "(Landroid/content/DialogInterface;IZ)V");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue((dialog == null) ? IntPtr.Zero : ((Java.Lang.Object)dialog).Handle);
			ptr[1] = new JValue(which);
			ptr[2] = new JValue(isChecked);
			JNIEnv.CallVoidMethod(base.Handle, this.id_onClick_Landroid_content_DialogInterface_IZ, ptr);
		}

		// Token: 0x04000A90 RID: 2704
		private static readonly JniPeerMembers _members = new XAPeerMembers("android/content/DialogInterface$OnMultiChoiceClickListener", typeof(IDialogInterfaceOnMultiChoiceClickListenerInvoker));

		// Token: 0x04000A91 RID: 2705
		private IntPtr class_ref;

		// Token: 0x04000A92 RID: 2706
		private static Delegate cb_onClick_Landroid_content_DialogInterface_IZ;

		// Token: 0x04000A93 RID: 2707
		private IntPtr id_onClick_Landroid_content_DialogInterface_IZ;
	}
}
