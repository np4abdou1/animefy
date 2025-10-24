using System;
using Android.Runtime;
using Android.Views;
using Java.Interop;

namespace AndroidX.Core.Internal.View
{
	// Token: 0x02000051 RID: 81
	[Register("androidx/core/internal/view/SupportMenu", "", "AndroidX.Core.Internal.View.ISupportMenuInvoker")]
	public interface ISupportMenu : IMenu, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x0600015D RID: 349
		[Register("setGroupDividerEnabled", "(Z)V", "GetSetGroupDividerEnabled_ZHandler:AndroidX.Core.Internal.View.ISupportMenuInvoker, Xamarin.AndroidX.Core")]
		void SetGroupDividerEnabled(bool isEnabled);
	}
}
