using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Content;
using Android.Runtime;
using Android.Util;
using Java.Interop;
using Java.Lang;

namespace Android.Widget
{
	// Token: 0x020000F3 RID: 243
	[Register("android/widget/Spinner", DoNotGenerateAcw = true)]
	public class Spinner : AbsSpinner, IDialogInterfaceOnClickListener, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x170000F9 RID: 249
		// (get) Token: 0x06000590 RID: 1424 RVA: 0x0000C019 File Offset: 0x0000A219
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return Spinner._members;
			}
		}

		// Token: 0x170000FA RID: 250
		// (get) Token: 0x06000591 RID: 1425 RVA: 0x0000C020 File Offset: 0x0000A220
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return Spinner._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170000FB RID: 251
		// (get) Token: 0x06000592 RID: 1426 RVA: 0x0000C044 File Offset: 0x0000A244
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return Spinner._members.ManagedPeerType;
			}
		}

		// Token: 0x06000593 RID: 1427 RVA: 0x000041D2 File Offset: 0x000023D2
		protected Spinner(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06000594 RID: 1428 RVA: 0x0000C050 File Offset: 0x0000A250
		public unsafe Spinner(Context context, IAttributeSet attrs) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((context == null) ? IntPtr.Zero : context.Handle);
				ptr[1] = new JniArgumentValue((attrs == null) ? IntPtr.Zero : ((Java.Lang.Object)attrs).Handle);
				base.SetHandle(Spinner._members.InstanceMethods.StartCreateInstance("(Landroid/content/Context;Landroid/util/AttributeSet;)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				Spinner._members.InstanceMethods.FinishCreateInstance("(Landroid/content/Context;Landroid/util/AttributeSet;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(context);
				GC.KeepAlive(attrs);
			}
		}

		// Token: 0x06000595 RID: 1429 RVA: 0x0000C12C File Offset: 0x0000A32C
		public unsafe Spinner(Context context, IAttributeSet attrs, int defStyleAttr) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((context == null) ? IntPtr.Zero : context.Handle);
				ptr[1] = new JniArgumentValue((attrs == null) ? IntPtr.Zero : ((Java.Lang.Object)attrs).Handle);
				ptr[2] = new JniArgumentValue(defStyleAttr);
				base.SetHandle(Spinner._members.InstanceMethods.StartCreateInstance("(Landroid/content/Context;Landroid/util/AttributeSet;I)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				Spinner._members.InstanceMethods.FinishCreateInstance("(Landroid/content/Context;Landroid/util/AttributeSet;I)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(context);
				GC.KeepAlive(attrs);
			}
		}

		// Token: 0x06000596 RID: 1430 RVA: 0x0000C21C File Offset: 0x0000A41C
		private static Delegate GetOnClick_Landroid_content_DialogInterface_IHandler()
		{
			if (Spinner.cb_onClick_Landroid_content_DialogInterface_I == null)
			{
				Spinner.cb_onClick_Landroid_content_DialogInterface_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLI_V(Spinner.n_OnClick_Landroid_content_DialogInterface_I));
			}
			return Spinner.cb_onClick_Landroid_content_DialogInterface_I;
		}

		// Token: 0x06000597 RID: 1431 RVA: 0x0000C240 File Offset: 0x0000A440
		private static void n_OnClick_Landroid_content_DialogInterface_I(IntPtr jnienv, IntPtr native__this, IntPtr native_dialog, int which)
		{
			Spinner @object = Java.Lang.Object.GetObject<Spinner>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			IDialogInterface object2 = Java.Lang.Object.GetObject<IDialogInterface>(native_dialog, JniHandleOwnership.DoNotTransfer);
			@object.OnClick(object2, which);
		}

		// Token: 0x06000598 RID: 1432 RVA: 0x0000C264 File Offset: 0x0000A464
		public unsafe virtual void OnClick(IDialogInterface dialog, int which)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((dialog == null) ? IntPtr.Zero : ((Java.Lang.Object)dialog).Handle);
				ptr[1] = new JniArgumentValue(which);
				Spinner._members.InstanceMethods.InvokeVirtualVoidMethod("onClick.(Landroid/content/DialogInterface;I)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(dialog);
			}
		}

		// Token: 0x04000151 RID: 337
		private static readonly JniPeerMembers _members = new XAPeerMembers("android/widget/Spinner", typeof(Spinner));

		// Token: 0x04000152 RID: 338
		private static Delegate cb_onClick_Landroid_content_DialogInterface_I;
	}
}
