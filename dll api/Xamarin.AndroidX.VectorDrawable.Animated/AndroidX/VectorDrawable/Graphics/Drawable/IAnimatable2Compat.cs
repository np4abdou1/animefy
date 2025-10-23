using System;
using Android.Graphics.Drawables;
using Android.Runtime;
using Java.Interop;

namespace AndroidX.VectorDrawable.Graphics.Drawable
{
	// Token: 0x0200000B RID: 11
	[Register("androidx/vectordrawable/graphics/drawable/Animatable2Compat", "", "AndroidX.VectorDrawable.Graphics.Drawable.IAnimatable2CompatInvoker")]
	public interface IAnimatable2Compat : IAnimatable, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x06000025 RID: 37
		[Register("clearAnimationCallbacks", "()V", "GetClearAnimationCallbacksHandler:AndroidX.VectorDrawable.Graphics.Drawable.IAnimatable2CompatInvoker, Xamarin.AndroidX.VectorDrawable.Animated")]
		void ClearAnimationCallbacks();

		// Token: 0x06000026 RID: 38
		[Register("registerAnimationCallback", "(Landroidx/vectordrawable/graphics/drawable/Animatable2Compat$AnimationCallback;)V", "GetRegisterAnimationCallback_Landroidx_vectordrawable_graphics_drawable_Animatable2Compat_AnimationCallback_Handler:AndroidX.VectorDrawable.Graphics.Drawable.IAnimatable2CompatInvoker, Xamarin.AndroidX.VectorDrawable.Animated")]
		void RegisterAnimationCallback(Animatable2CompatAnimationCallback callback_);

		// Token: 0x06000027 RID: 39
		[Register("unregisterAnimationCallback", "(Landroidx/vectordrawable/graphics/drawable/Animatable2Compat$AnimationCallback;)Z", "GetUnregisterAnimationCallback_Landroidx_vectordrawable_graphics_drawable_Animatable2Compat_AnimationCallback_Handler:AndroidX.VectorDrawable.Graphics.Drawable.IAnimatable2CompatInvoker, Xamarin.AndroidX.VectorDrawable.Animated")]
		bool UnregisterAnimationCallback(Animatable2CompatAnimationCallback callback_);
	}
}
