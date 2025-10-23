using System;
using Android.Runtime;
using Java.Interop;

namespace Bumptech.Glide.Request.Target
{
	// Token: 0x020000BA RID: 186
	[Register("com/bumptech/glide/request/target/SizeReadyCallback", "", "Bumptech.Glide.Request.Target.ISizeReadyCallbackInvoker")]
	public interface ISizeReadyCallback : IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x060009CD RID: 2509
		[Register("onSizeReady", "(II)V", "GetOnSizeReady_IIHandler:Bumptech.Glide.Request.Target.ISizeReadyCallbackInvoker, Xamarin.Android.Glide")]
		void OnSizeReady(int p0, int p1);
	}
}
