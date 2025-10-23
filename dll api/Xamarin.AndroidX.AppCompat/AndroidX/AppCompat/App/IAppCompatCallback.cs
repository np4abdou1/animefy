using System;
using Android.Runtime;
using AndroidX.AppCompat.View;
using Java.Interop;

namespace AndroidX.AppCompat.App
{
	// Token: 0x02000059 RID: 89
	[Register("androidx/appcompat/app/AppCompatCallback", "", "AndroidX.AppCompat.App.IAppCompatCallbackInvoker")]
	public interface IAppCompatCallback : IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x06000524 RID: 1316
		[Register("onSupportActionModeFinished", "(Landroidx/appcompat/view/ActionMode;)V", "GetOnSupportActionModeFinished_Landroidx_appcompat_view_ActionMode_Handler:AndroidX.AppCompat.App.IAppCompatCallbackInvoker, Xamarin.AndroidX.AppCompat")]
		void OnSupportActionModeFinished(ActionMode mode);

		// Token: 0x06000525 RID: 1317
		[Register("onSupportActionModeStarted", "(Landroidx/appcompat/view/ActionMode;)V", "GetOnSupportActionModeStarted_Landroidx_appcompat_view_ActionMode_Handler:AndroidX.AppCompat.App.IAppCompatCallbackInvoker, Xamarin.AndroidX.AppCompat")]
		void OnSupportActionModeStarted(ActionMode mode);

		// Token: 0x06000526 RID: 1318
		[Register("onWindowStartingSupportActionMode", "(Landroidx/appcompat/view/ActionMode$Callback;)Landroidx/appcompat/view/ActionMode;", "GetOnWindowStartingSupportActionMode_Landroidx_appcompat_view_ActionMode_Callback_Handler:AndroidX.AppCompat.App.IAppCompatCallbackInvoker, Xamarin.AndroidX.AppCompat")]
		ActionMode OnWindowStartingSupportActionMode(ActionMode.ICallback callback_);
	}
}
