using System;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Google.Android.Material.Animation
{
	// Token: 0x0200009D RID: 157
	[Register("com/google/android/material/animation/TransformationCallback", "", "Google.Android.Material.Animation.ITransformationCallbackInvoker")]
	[JavaTypeParameters(new string[]
	{
		"T extends android.view.View"
	})]
	public interface ITransformationCallback : IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x06000B57 RID: 2903
		[Register("onScaleChanged", "(Landroid/view/View;)V", "GetOnScaleChanged_Landroid_view_View_Handler:Google.Android.Material.Animation.ITransformationCallbackInvoker, Xamarin.Google.Android.Material")]
		void OnScaleChanged(Java.Lang.Object p0);

		// Token: 0x06000B58 RID: 2904
		[Register("onTranslationChanged", "(Landroid/view/View;)V", "GetOnTranslationChanged_Landroid_view_View_Handler:Google.Android.Material.Animation.ITransformationCallbackInvoker, Xamarin.Google.Android.Material")]
		void OnTranslationChanged(Java.Lang.Object p0);
	}
}
