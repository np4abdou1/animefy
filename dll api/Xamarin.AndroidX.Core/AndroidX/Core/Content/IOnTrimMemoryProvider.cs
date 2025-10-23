using System;
using Android.Runtime;
using AndroidX.Core.Util;
using Java.Interop;

namespace AndroidX.Core.Content
{
	// Token: 0x0200005A RID: 90
	[Register("androidx/core/content/OnTrimMemoryProvider", "", "AndroidX.Core.Content.IOnTrimMemoryProviderInvoker")]
	public interface IOnTrimMemoryProvider : IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x0600031C RID: 796
		[Register("addOnTrimMemoryListener", "(Landroidx/core/util/Consumer;)V", "GetAddOnTrimMemoryListener_Landroidx_core_util_Consumer_Handler:AndroidX.Core.Content.IOnTrimMemoryProviderInvoker, Xamarin.AndroidX.Core")]
		void AddOnTrimMemoryListener(IConsumer p0);

		// Token: 0x0600031D RID: 797
		[Register("removeOnTrimMemoryListener", "(Landroidx/core/util/Consumer;)V", "GetRemoveOnTrimMemoryListener_Landroidx_core_util_Consumer_Handler:AndroidX.Core.Content.IOnTrimMemoryProviderInvoker, Xamarin.AndroidX.Core")]
		void RemoveOnTrimMemoryListener(IConsumer p0);
	}
}
