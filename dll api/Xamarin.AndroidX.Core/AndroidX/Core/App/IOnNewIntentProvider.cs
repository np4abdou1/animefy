using System;
using Android.Runtime;
using AndroidX.Core.Util;
using Java.Interop;

namespace AndroidX.Core.App
{
	// Token: 0x0200006C RID: 108
	[Register("androidx/core/app/OnNewIntentProvider", "", "AndroidX.Core.App.IOnNewIntentProviderInvoker")]
	public interface IOnNewIntentProvider : IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x0600042D RID: 1069
		[Register("addOnNewIntentListener", "(Landroidx/core/util/Consumer;)V", "GetAddOnNewIntentListener_Landroidx_core_util_Consumer_Handler:AndroidX.Core.App.IOnNewIntentProviderInvoker, Xamarin.AndroidX.Core")]
		void AddOnNewIntentListener(IConsumer p0);

		// Token: 0x0600042E RID: 1070
		[Register("removeOnNewIntentListener", "(Landroidx/core/util/Consumer;)V", "GetRemoveOnNewIntentListener_Landroidx_core_util_Consumer_Handler:AndroidX.Core.App.IOnNewIntentProviderInvoker, Xamarin.AndroidX.Core")]
		void RemoveOnNewIntentListener(IConsumer p0);
	}
}
