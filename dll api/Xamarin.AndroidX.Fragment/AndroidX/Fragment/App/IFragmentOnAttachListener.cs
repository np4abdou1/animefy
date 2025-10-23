using System;
using Android.Runtime;
using Java.Interop;

namespace AndroidX.Fragment.App
{
	// Token: 0x02000048 RID: 72
	[Register("androidx/fragment/app/FragmentOnAttachListener", "", "AndroidX.Fragment.App.IFragmentOnAttachListenerInvoker")]
	public interface IFragmentOnAttachListener : IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x0600041E RID: 1054
		[Register("onAttachFragment", "(Landroidx/fragment/app/FragmentManager;Landroidx/fragment/app/Fragment;)V", "GetOnAttachFragment_Landroidx_fragment_app_FragmentManager_Landroidx_fragment_app_Fragment_Handler:AndroidX.Fragment.App.IFragmentOnAttachListenerInvoker, Xamarin.AndroidX.Fragment")]
		void OnAttachFragment(FragmentManager p0, Fragment p1);
	}
}
