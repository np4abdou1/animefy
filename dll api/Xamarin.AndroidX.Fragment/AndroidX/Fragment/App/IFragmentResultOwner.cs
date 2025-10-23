using System;
using Android.OS;
using Android.Runtime;
using AndroidX.Lifecycle;
using Java.Interop;

namespace AndroidX.Fragment.App
{
	// Token: 0x0200004E RID: 78
	[Register("androidx/fragment/app/FragmentResultOwner", "", "AndroidX.Fragment.App.IFragmentResultOwnerInvoker")]
	public interface IFragmentResultOwner : IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x0600043C RID: 1084
		[Register("clearFragmentResult", "(Ljava/lang/String;)V", "GetClearFragmentResult_Ljava_lang_String_Handler:AndroidX.Fragment.App.IFragmentResultOwnerInvoker, Xamarin.AndroidX.Fragment")]
		void ClearFragmentResult(string p0);

		// Token: 0x0600043D RID: 1085
		[Register("clearFragmentResultListener", "(Ljava/lang/String;)V", "GetClearFragmentResultListener_Ljava_lang_String_Handler:AndroidX.Fragment.App.IFragmentResultOwnerInvoker, Xamarin.AndroidX.Fragment")]
		void ClearFragmentResultListener(string p0);

		// Token: 0x0600043E RID: 1086
		[Register("setFragmentResult", "(Ljava/lang/String;Landroid/os/Bundle;)V", "GetSetFragmentResult_Ljava_lang_String_Landroid_os_Bundle_Handler:AndroidX.Fragment.App.IFragmentResultOwnerInvoker, Xamarin.AndroidX.Fragment")]
		void SetFragmentResult(string p0, Bundle p1);

		// Token: 0x0600043F RID: 1087
		[Register("setFragmentResultListener", "(Ljava/lang/String;Landroidx/lifecycle/LifecycleOwner;Landroidx/fragment/app/FragmentResultListener;)V", "GetSetFragmentResultListener_Ljava_lang_String_Landroidx_lifecycle_LifecycleOwner_Landroidx_fragment_app_FragmentResultListener_Handler:AndroidX.Fragment.App.IFragmentResultOwnerInvoker, Xamarin.AndroidX.Fragment")]
		void SetFragmentResultListener(string p0, ILifecycleOwner p1, IFragmentResultListener p2);
	}
}
