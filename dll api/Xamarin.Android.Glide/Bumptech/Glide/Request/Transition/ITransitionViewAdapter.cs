using System;
using Android.Graphics.Drawables;
using Android.Runtime;
using Android.Views;
using Java.Interop;

namespace Bumptech.Glide.Request.Transition
{
	// Token: 0x0200009F RID: 159
	[Register("com/bumptech/glide/request/transition/Transition$ViewAdapter", "", "Bumptech.Glide.Request.Transition.ITransitionViewAdapterInvoker")]
	public interface ITransitionViewAdapter : IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x170001C2 RID: 450
		// (get) Token: 0x06000860 RID: 2144
		Drawable CurrentDrawable { [Register("getCurrentDrawable", "()Landroid/graphics/drawable/Drawable;", "GetGetCurrentDrawableHandler:Bumptech.Glide.Request.Transition.ITransitionViewAdapterInvoker, Xamarin.Android.Glide")] get; }

		// Token: 0x170001C3 RID: 451
		// (get) Token: 0x06000861 RID: 2145
		View View { [Register("getView", "()Landroid/view/View;", "GetGetViewHandler:Bumptech.Glide.Request.Transition.ITransitionViewAdapterInvoker, Xamarin.Android.Glide")] get; }

		// Token: 0x06000862 RID: 2146
		[Register("setDrawable", "(Landroid/graphics/drawable/Drawable;)V", "GetSetDrawable_Landroid_graphics_drawable_Drawable_Handler:Bumptech.Glide.Request.Transition.ITransitionViewAdapterInvoker, Xamarin.Android.Glide")]
		void SetDrawable(Drawable p0);
	}
}
