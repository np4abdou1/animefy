using System;
using Android.Runtime;
using AndroidX.Core.Util;
using Java.Interop;

namespace AndroidX.Core.App
{
	// Token: 0x0200006E RID: 110
	[Register("androidx/core/app/OnPictureInPictureModeChangedProvider", "", "AndroidX.Core.App.IOnPictureInPictureModeChangedProviderInvoker")]
	public interface IOnPictureInPictureModeChangedProvider : IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x0600043E RID: 1086
		[Register("addOnPictureInPictureModeChangedListener", "(Landroidx/core/util/Consumer;)V", "GetAddOnPictureInPictureModeChangedListener_Landroidx_core_util_Consumer_Handler:AndroidX.Core.App.IOnPictureInPictureModeChangedProviderInvoker, Xamarin.AndroidX.Core")]
		void AddOnPictureInPictureModeChangedListener(IConsumer p0);

		// Token: 0x0600043F RID: 1087
		[Register("removeOnPictureInPictureModeChangedListener", "(Landroidx/core/util/Consumer;)V", "GetRemoveOnPictureInPictureModeChangedListener_Landroidx_core_util_Consumer_Handler:AndroidX.Core.App.IOnPictureInPictureModeChangedProviderInvoker, Xamarin.AndroidX.Core")]
		void RemoveOnPictureInPictureModeChangedListener(IConsumer p0);
	}
}
