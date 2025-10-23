using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Android.Views;
using Java.Interop;
using Java.Lang;

namespace Android.Content
{
	// Token: 0x02000293 RID: 659
	[Register("android/content/DialogInterface$OnKeyListener", DoNotGenerateAcw = true)]
	internal class IDialogInterfaceOnKeyListenerInvoker : Java.Lang.Object, IDialogInterfaceOnKeyListener, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x1700056C RID: 1388
		// (get) Token: 0x0600191B RID: 6427 RVA: 0x00040DD8 File Offset: 0x0003EFD8
		private static IntPtr java_class_ref
		{
			get
			{
				return IDialogInterfaceOnKeyListenerInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700056D RID: 1389
		// (get) Token: 0x0600191C RID: 6428 RVA: 0x00040DFC File Offset: 0x0003EFFC
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return IDialogInterfaceOnKeyListenerInvoker._members;
			}
		}

		// Token: 0x1700056E RID: 1390
		// (get) Token: 0x0600191D RID: 6429 RVA: 0x00040E03 File Offset: 0x0003F003
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x1700056F RID: 1391
		// (get) Token: 0x0600191E RID: 6430 RVA: 0x00040E0B File Offset: 0x0003F00B
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return IDialogInterfaceOnKeyListenerInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x0600191F RID: 6431 RVA: 0x00040E17 File Offset: 0x0003F017
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, IDialogInterfaceOnKeyListenerInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'android.content.DialogInterface.OnKeyListener'.");
			}
			return handle;
		}

		// Token: 0x06001920 RID: 6432 RVA: 0x00040E42 File Offset: 0x0003F042
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x06001921 RID: 6433 RVA: 0x00040E74 File Offset: 0x0003F074
		public IDialogInterfaceOnKeyListenerInvoker(IntPtr handle, JniHandleOwnership transfer) : base(IDialogInterfaceOnKeyListenerInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x06001922 RID: 6434 RVA: 0x00040EAC File Offset: 0x0003F0AC
		private static Delegate GetOnKey_Landroid_content_DialogInterface_ILandroid_view_KeyEvent_Handler()
		{
			if (IDialogInterfaceOnKeyListenerInvoker.cb_onKey_Landroid_content_DialogInterface_ILandroid_view_KeyEvent_ == null)
			{
				IDialogInterfaceOnKeyListenerInvoker.cb_onKey_Landroid_content_DialogInterface_ILandroid_view_KeyEvent_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLIL_Z(IDialogInterfaceOnKeyListenerInvoker.n_OnKey_Landroid_content_DialogInterface_ILandroid_view_KeyEvent_));
			}
			return IDialogInterfaceOnKeyListenerInvoker.cb_onKey_Landroid_content_DialogInterface_ILandroid_view_KeyEvent_;
		}

		// Token: 0x06001923 RID: 6435 RVA: 0x00040ED0 File Offset: 0x0003F0D0
		private static bool n_OnKey_Landroid_content_DialogInterface_ILandroid_view_KeyEvent_(IntPtr jnienv, IntPtr native__this, IntPtr native_dialog, int native_keyCode, IntPtr native_e)
		{
			IDialogInterfaceOnKeyListener @object = Java.Lang.Object.GetObject<IDialogInterfaceOnKeyListener>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			IDialogInterface object2 = Java.Lang.Object.GetObject<IDialogInterface>(native_dialog, JniHandleOwnership.DoNotTransfer);
			KeyEvent object3 = Java.Lang.Object.GetObject<KeyEvent>(native_e, JniHandleOwnership.DoNotTransfer);
			return @object.OnKey(object2, (Keycode)native_keyCode, object3);
		}

		// Token: 0x06001924 RID: 6436 RVA: 0x00040F00 File Offset: 0x0003F100
		public unsafe bool OnKey(IDialogInterface dialog, [GeneratedEnum] Keycode keyCode, KeyEvent e)
		{
			if (this.id_onKey_Landroid_content_DialogInterface_ILandroid_view_KeyEvent_ == IntPtr.Zero)
			{
				this.id_onKey_Landroid_content_DialogInterface_ILandroid_view_KeyEvent_ = JNIEnv.GetMethodID(this.class_ref, "onKey", "(Landroid/content/DialogInterface;ILandroid/view/KeyEvent;)Z");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue((dialog == null) ? IntPtr.Zero : ((Java.Lang.Object)dialog).Handle);
			ptr[1] = new JValue((int)keyCode);
			ptr[2] = new JValue((e == null) ? IntPtr.Zero : e.Handle);
			return JNIEnv.CallBooleanMethod(base.Handle, this.id_onKey_Landroid_content_DialogInterface_ILandroid_view_KeyEvent_, ptr);
		}

		// Token: 0x04000A8C RID: 2700
		private static readonly JniPeerMembers _members = new XAPeerMembers("android/content/DialogInterface$OnKeyListener", typeof(IDialogInterfaceOnKeyListenerInvoker));

		// Token: 0x04000A8D RID: 2701
		private IntPtr class_ref;

		// Token: 0x04000A8E RID: 2702
		private static Delegate cb_onKey_Landroid_content_DialogInterface_ILandroid_view_KeyEvent_;

		// Token: 0x04000A8F RID: 2703
		private IntPtr id_onKey_Landroid_content_DialogInterface_ILandroid_view_KeyEvent_;
	}
}
