using System;
using Android.Graphics;
using Android.Runtime;
using Java.Interop;

namespace Google.Android.Material.Shape
{
	// Token: 0x02000038 RID: 56
	[Register("com/google/android/material/shape/CornerSize", "", "Google.Android.Material.Shape.ICornerSizeInvoker")]
	public interface ICornerSize : IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x060000E5 RID: 229
		[Register("getCornerSize", "(Landroid/graphics/RectF;)F", "GetGetCornerSize_Landroid_graphics_RectF_Handler:Google.Android.Material.Shape.ICornerSizeInvoker, Xamarin.Google.Android.Material")]
		float GetCornerSize(RectF p0);
	}
}
