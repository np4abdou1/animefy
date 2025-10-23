using System;
using Android.Runtime;
using AndroidX.Core.Util;
using Java.Interop;

namespace AndroidX.Core.Content
{
	// Token: 0x02000058 RID: 88
	[Register("androidx/core/content/OnConfigurationChangedProvider", "", "AndroidX.Core.Content.IOnConfigurationChangedProviderInvoker")]
	public interface IOnConfigurationChangedProvider : IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x0600030B RID: 779
		[Register("addOnConfigurationChangedListener", "(Landroidx/core/util/Consumer;)V", "GetAddOnConfigurationChangedListener_Landroidx_core_util_Consumer_Handler:AndroidX.Core.Content.IOnConfigurationChangedProviderInvoker, Xamarin.AndroidX.Core")]
		void AddOnConfigurationChangedListener(IConsumer p0);

		// Token: 0x0600030C RID: 780
		[Register("removeOnConfigurationChangedListener", "(Landroidx/core/util/Consumer;)V", "GetRemoveOnConfigurationChangedListener_Landroidx_core_util_Consumer_Handler:AndroidX.Core.Content.IOnConfigurationChangedProviderInvoker, Xamarin.AndroidX.Core")]
		void RemoveOnConfigurationChangedListener(IConsumer p0);
	}
}
