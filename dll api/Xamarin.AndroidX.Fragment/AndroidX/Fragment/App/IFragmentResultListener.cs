using System;
using Android.OS;
using Android.Runtime;
using Java.Interop;

namespace AndroidX.Fragment.App
{
	// Token: 0x0200004C RID: 76
	[Register("androidx/fragment/app/FragmentResultListener", "", "AndroidX.Fragment.App.IFragmentResultListenerInvoker")]
	public interface IFragmentResultListener : IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x0600042F RID: 1071
		[Register("onFragmentResult", "(Ljava/lang/String;Landroid/os/Bundle;)V", "GetOnFragmentResult_Ljava_lang_String_Landroid_os_Bundle_Handler:AndroidX.Fragment.App.IFragmentResultListenerInvoker, Xamarin.AndroidX.Fragment")]
		void OnFragmentResult(string p0, Bundle p1);
	}
}
