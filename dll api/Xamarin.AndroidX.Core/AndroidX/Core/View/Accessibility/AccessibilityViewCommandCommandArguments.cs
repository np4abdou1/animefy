using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.OS;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace AndroidX.Core.View.Accessibility
{
	// Token: 0x020000C6 RID: 198
	[Register("androidx/core/view/accessibility/AccessibilityViewCommand$CommandArguments", DoNotGenerateAcw = true)]
	public abstract class AccessibilityViewCommandCommandArguments : Java.Lang.Object
	{
		// Token: 0x170002C9 RID: 713
		// (get) Token: 0x06000DFB RID: 3579 RVA: 0x0002996C File Offset: 0x00027B6C
		internal static IntPtr class_ref
		{
			get
			{
				return AccessibilityViewCommandCommandArguments._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170002CA RID: 714
		// (get) Token: 0x06000DFC RID: 3580 RVA: 0x00029990 File Offset: 0x00027B90
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return AccessibilityViewCommandCommandArguments._members;
			}
		}

		// Token: 0x170002CB RID: 715
		// (get) Token: 0x06000DFD RID: 3581 RVA: 0x00029998 File Offset: 0x00027B98
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return AccessibilityViewCommandCommandArguments._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170002CC RID: 716
		// (get) Token: 0x06000DFE RID: 3582 RVA: 0x000299BC File Offset: 0x00027BBC
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return AccessibilityViewCommandCommandArguments._members.ManagedPeerType;
			}
		}

		// Token: 0x06000DFF RID: 3583 RVA: 0x00002384 File Offset: 0x00000584
		protected AccessibilityViewCommandCommandArguments(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06000E00 RID: 3584 RVA: 0x000299C8 File Offset: 0x00027BC8
		[Register(".ctor", "()V", "")]
		public AccessibilityViewCommandCommandArguments() : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			base.SetHandle(AccessibilityViewCommandCommandArguments._members.InstanceMethods.StartCreateInstance("()V", base.GetType(), null).Handle, JniHandleOwnership.TransferLocalRef);
			AccessibilityViewCommandCommandArguments._members.InstanceMethods.FinishCreateInstance("()V", this, null);
		}

		// Token: 0x06000E01 RID: 3585 RVA: 0x00029A36 File Offset: 0x00027C36
		private static Delegate GetSetBundle_Landroid_os_Bundle_Handler()
		{
			if (AccessibilityViewCommandCommandArguments.cb_setBundle_Landroid_os_Bundle_ == null)
			{
				AccessibilityViewCommandCommandArguments.cb_setBundle_Landroid_os_Bundle_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(AccessibilityViewCommandCommandArguments.n_SetBundle_Landroid_os_Bundle_));
			}
			return AccessibilityViewCommandCommandArguments.cb_setBundle_Landroid_os_Bundle_;
		}

		// Token: 0x06000E02 RID: 3586 RVA: 0x00029A5C File Offset: 0x00027C5C
		private static void n_SetBundle_Landroid_os_Bundle_(IntPtr jnienv, IntPtr native__this, IntPtr native_bundle)
		{
			AccessibilityViewCommandCommandArguments @object = Java.Lang.Object.GetObject<AccessibilityViewCommandCommandArguments>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Bundle object2 = Java.Lang.Object.GetObject<Bundle>(native_bundle, JniHandleOwnership.DoNotTransfer);
			@object.SetBundle(object2);
		}

		// Token: 0x06000E03 RID: 3587 RVA: 0x00029A80 File Offset: 0x00027C80
		[Register("setBundle", "(Landroid/os/Bundle;)V", "GetSetBundle_Landroid_os_Bundle_Handler")]
		public unsafe virtual void SetBundle(Bundle bundle)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((bundle == null) ? IntPtr.Zero : bundle.Handle);
				AccessibilityViewCommandCommandArguments._members.InstanceMethods.InvokeVirtualVoidMethod("setBundle.(Landroid/os/Bundle;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(bundle);
			}
		}

		// Token: 0x0400041C RID: 1052
		private static readonly JniPeerMembers _members = new XAPeerMembers("androidx/core/view/accessibility/AccessibilityViewCommand$CommandArguments", typeof(AccessibilityViewCommandCommandArguments));

		// Token: 0x0400041D RID: 1053
		private static Delegate cb_setBundle_Landroid_os_Bundle_;
	}
}
