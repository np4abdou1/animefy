using System;
using Android.Runtime;
using Java.Interop;

namespace Google.Android.Material.Snackbar
{
	// Token: 0x02000091 RID: 145
	[Register("com/google/android/material/snackbar/ContentViewCallback", "", "Google.Android.Material.Snackbar.IContentViewCallbackInvoker")]
	public interface IContentViewCallback : IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x060009F8 RID: 2552
		[Register("animateContentIn", "(II)V", "GetAnimateContentIn_IIHandler:Google.Android.Material.Snackbar.IContentViewCallbackInvoker, Xamarin.Google.Android.Material")]
		void AnimateContentIn(int p0, int p1);

		// Token: 0x060009F9 RID: 2553
		[Register("animateContentOut", "(II)V", "GetAnimateContentOut_IIHandler:Google.Android.Material.Snackbar.IContentViewCallbackInvoker, Xamarin.Google.Android.Material")]
		void AnimateContentOut(int p0, int p1);
	}
}
