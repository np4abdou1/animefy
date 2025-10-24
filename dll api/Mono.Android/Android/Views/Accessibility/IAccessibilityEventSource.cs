using System;
using Android.Runtime;
using Java.Interop;

namespace Android.Views.Accessibility
{
	// Token: 0x0200018C RID: 396
	[Register("android/view/accessibility/AccessibilityEventSource", "", "Android.Views.Accessibility.IAccessibilityEventSourceInvoker")]
	public interface IAccessibilityEventSource : IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x06000DBF RID: 3519
		void SendAccessibilityEvent([GeneratedEnum] EventTypes eventType);

		// Token: 0x06000DC0 RID: 3520
		void SendAccessibilityEventUnchecked(AccessibilityEvent e);
	}
}
