using System;
using Android.Runtime;
using AndroidX.Core.Util;
using Java.Interop;

namespace AndroidX.Core.App
{
	// Token: 0x0200006A RID: 106
	[Register("androidx/core/app/OnMultiWindowModeChangedProvider", "", "AndroidX.Core.App.IOnMultiWindowModeChangedProviderInvoker")]
	public interface IOnMultiWindowModeChangedProvider : IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x0600041C RID: 1052
		[Register("addOnMultiWindowModeChangedListener", "(Landroidx/core/util/Consumer;)V", "GetAddOnMultiWindowModeChangedListener_Landroidx_core_util_Consumer_Handler:AndroidX.Core.App.IOnMultiWindowModeChangedProviderInvoker, Xamarin.AndroidX.Core")]
		void AddOnMultiWindowModeChangedListener(IConsumer p0);

		// Token: 0x0600041D RID: 1053
		[Register("removeOnMultiWindowModeChangedListener", "(Landroidx/core/util/Consumer;)V", "GetRemoveOnMultiWindowModeChangedListener_Landroidx_core_util_Consumer_Handler:AndroidX.Core.App.IOnMultiWindowModeChangedProviderInvoker, Xamarin.AndroidX.Core")]
		void RemoveOnMultiWindowModeChangedListener(IConsumer p0);
	}
}
