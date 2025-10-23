using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Android.Views;
using Java.Interop;
using Java.Lang;

namespace AndroidX.Core.View.Accessibility
{
	// Token: 0x020000C9 RID: 201
	[Register("androidx/core/view/accessibility/AccessibilityViewCommand", DoNotGenerateAcw = true)]
	internal class IAccessibilityViewCommandInvoker : Java.Lang.Object, IAccessibilityViewCommand, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x170002CF RID: 719
		// (get) Token: 0x06000E0A RID: 3594 RVA: 0x00029B38 File Offset: 0x00027D38
		private static IntPtr java_class_ref
		{
			get
			{
				return IAccessibilityViewCommandInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170002D0 RID: 720
		// (get) Token: 0x06000E0B RID: 3595 RVA: 0x00029B5C File Offset: 0x00027D5C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return IAccessibilityViewCommandInvoker._members;
			}
		}

		// Token: 0x170002D1 RID: 721
		// (get) Token: 0x06000E0C RID: 3596 RVA: 0x00029B63 File Offset: 0x00027D63
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x170002D2 RID: 722
		// (get) Token: 0x06000E0D RID: 3597 RVA: 0x00029B6B File Offset: 0x00027D6B
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return IAccessibilityViewCommandInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x06000E0E RID: 3598 RVA: 0x00029B77 File Offset: 0x00027D77
		public static IAccessibilityViewCommand GetObject(IntPtr handle, JniHandleOwnership transfer)
		{
			return Java.Lang.Object.GetObject<IAccessibilityViewCommand>(handle, transfer);
		}

		// Token: 0x06000E0F RID: 3599 RVA: 0x00029B80 File Offset: 0x00027D80
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, IAccessibilityViewCommandInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'androidx.core.view.accessibility.AccessibilityViewCommand'.");
			}
			return handle;
		}

		// Token: 0x06000E10 RID: 3600 RVA: 0x00029BAB File Offset: 0x00027DAB
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x06000E11 RID: 3601 RVA: 0x00029BDC File Offset: 0x00027DDC
		public IAccessibilityViewCommandInvoker(IntPtr handle, JniHandleOwnership transfer) : base(IAccessibilityViewCommandInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x06000E12 RID: 3602 RVA: 0x00029C14 File Offset: 0x00027E14
		private static Delegate GetPerform_Landroid_view_View_Landroidx_core_view_accessibility_AccessibilityViewCommand_CommandArguments_Handler()
		{
			if (IAccessibilityViewCommandInvoker.cb_perform_Landroid_view_View_Landroidx_core_view_accessibility_AccessibilityViewCommand_CommandArguments_ == null)
			{
				IAccessibilityViewCommandInvoker.cb_perform_Landroid_view_View_Landroidx_core_view_accessibility_AccessibilityViewCommand_CommandArguments_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_Z(IAccessibilityViewCommandInvoker.n_Perform_Landroid_view_View_Landroidx_core_view_accessibility_AccessibilityViewCommand_CommandArguments_));
			}
			return IAccessibilityViewCommandInvoker.cb_perform_Landroid_view_View_Landroidx_core_view_accessibility_AccessibilityViewCommand_CommandArguments_;
		}

		// Token: 0x06000E13 RID: 3603 RVA: 0x00029C38 File Offset: 0x00027E38
		private static bool n_Perform_Landroid_view_View_Landroidx_core_view_accessibility_AccessibilityViewCommand_CommandArguments_(IntPtr jnienv, IntPtr native__this, IntPtr native_view, IntPtr native_arguments)
		{
			IAccessibilityViewCommand @object = Java.Lang.Object.GetObject<IAccessibilityViewCommand>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			View object2 = Java.Lang.Object.GetObject<View>(native_view, JniHandleOwnership.DoNotTransfer);
			AccessibilityViewCommandCommandArguments object3 = Java.Lang.Object.GetObject<AccessibilityViewCommandCommandArguments>(native_arguments, JniHandleOwnership.DoNotTransfer);
			return @object.Perform(object2, object3);
		}

		// Token: 0x06000E14 RID: 3604 RVA: 0x00029C64 File Offset: 0x00027E64
		public unsafe bool Perform(View view, AccessibilityViewCommandCommandArguments arguments)
		{
			if (this.id_perform_Landroid_view_View_Landroidx_core_view_accessibility_AccessibilityViewCommand_CommandArguments_ == IntPtr.Zero)
			{
				this.id_perform_Landroid_view_View_Landroidx_core_view_accessibility_AccessibilityViewCommand_CommandArguments_ = JNIEnv.GetMethodID(this.class_ref, "perform", "(Landroid/view/View;Landroidx/core/view/accessibility/AccessibilityViewCommand$CommandArguments;)Z");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue((view == null) ? IntPtr.Zero : view.Handle);
			ptr[1] = new JValue((arguments == null) ? IntPtr.Zero : arguments.Handle);
			return JNIEnv.CallBooleanMethod(base.Handle, this.id_perform_Landroid_view_View_Landroidx_core_view_accessibility_AccessibilityViewCommand_CommandArguments_, ptr);
		}

		// Token: 0x0400041F RID: 1055
		private static readonly JniPeerMembers _members = new XAPeerMembers("androidx/core/view/accessibility/AccessibilityViewCommand", typeof(IAccessibilityViewCommandInvoker));

		// Token: 0x04000420 RID: 1056
		private IntPtr class_ref;

		// Token: 0x04000421 RID: 1057
		private static Delegate cb_perform_Landroid_view_View_Landroidx_core_view_accessibility_AccessibilityViewCommand_CommandArguments_;

		// Token: 0x04000422 RID: 1058
		private IntPtr id_perform_Landroid_view_View_Landroidx_core_view_accessibility_AccessibilityViewCommand_CommandArguments_;
	}
}
