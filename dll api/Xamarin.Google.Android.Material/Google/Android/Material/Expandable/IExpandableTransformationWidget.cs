using System;
using Android.Runtime;
using Java.Interop;

namespace Google.Android.Material.Expandable
{
	// Token: 0x02000047 RID: 71
	[Register("com/google/android/material/expandable/ExpandableTransformationWidget", "", "Google.Android.Material.Expandable.IExpandableTransformationWidgetInvoker")]
	public interface IExpandableTransformationWidget : IExpandableWidget, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x1700006D RID: 109
		// (get) Token: 0x060002C3 RID: 707
		// (set) Token: 0x060002C4 RID: 708
		int ExpandedComponentIdHint { [Register("getExpandedComponentIdHint", "()I", "GetGetExpandedComponentIdHintHandler:Google.Android.Material.Expandable.IExpandableTransformationWidgetInvoker, Xamarin.Google.Android.Material")] get; [Register("setExpandedComponentIdHint", "(I)V", "GetSetExpandedComponentIdHint_IHandler:Google.Android.Material.Expandable.IExpandableTransformationWidgetInvoker, Xamarin.Google.Android.Material")] set; }
	}
}
