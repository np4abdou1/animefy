using System;
using Android.Runtime;
using Java.Interop;

namespace Google.Android.Material.Expandable
{
	// Token: 0x02000049 RID: 73
	[Register("com/google/android/material/expandable/ExpandableWidget", "", "Google.Android.Material.Expandable.IExpandableWidgetInvoker")]
	public interface IExpandableWidget : IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x17000074 RID: 116
		// (get) Token: 0x060002DA RID: 730
		bool IsExpanded { [Register("isExpanded", "()Z", "GetIsExpandedHandler:Google.Android.Material.Expandable.IExpandableWidgetInvoker, Xamarin.Google.Android.Material")] get; }

		// Token: 0x060002DB RID: 731
		[Register("setExpanded", "(Z)Z", "GetSetExpanded_ZHandler:Google.Android.Material.Expandable.IExpandableWidgetInvoker, Xamarin.Google.Android.Material")]
		bool SetExpanded(bool p0);
	}
}
