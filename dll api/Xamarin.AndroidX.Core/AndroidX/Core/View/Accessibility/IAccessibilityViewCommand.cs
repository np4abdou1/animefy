using System;
using Android.Runtime;
using Android.Views;
using Java.Interop;

namespace AndroidX.Core.View.Accessibility
{
	// Token: 0x020000C8 RID: 200
	[Register("androidx/core/view/accessibility/AccessibilityViewCommand", "", "AndroidX.Core.View.Accessibility.IAccessibilityViewCommandInvoker")]
	public interface IAccessibilityViewCommand : IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x06000E09 RID: 3593
		[Register("perform", "(Landroid/view/View;Landroidx/core/view/accessibility/AccessibilityViewCommand$CommandArguments;)Z", "GetPerform_Landroid_view_View_Landroidx_core_view_accessibility_AccessibilityViewCommand_CommandArguments_Handler:AndroidX.Core.View.Accessibility.IAccessibilityViewCommandInvoker, Xamarin.AndroidX.Core")]
		bool Perform(View view, AccessibilityViewCommandCommandArguments arguments);
	}
}
