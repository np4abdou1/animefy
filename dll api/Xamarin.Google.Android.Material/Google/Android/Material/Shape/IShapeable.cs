using System;
using Android.Runtime;
using Java.Interop;

namespace Google.Android.Material.Shape
{
	// Token: 0x0200003A RID: 58
	[Register("com/google/android/material/shape/Shapeable", "", "Google.Android.Material.Shape.IShapeableInvoker")]
	public interface IShapeable : IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x1700000D RID: 13
		// (get) Token: 0x060000F2 RID: 242
		// (set) Token: 0x060000F3 RID: 243
		ShapeAppearanceModel ShapeAppearanceModel { [Register("getShapeAppearanceModel", "()Lcom/google/android/material/shape/ShapeAppearanceModel;", "GetGetShapeAppearanceModelHandler:Google.Android.Material.Shape.IShapeableInvoker, Xamarin.Google.Android.Material")] get; [Register("setShapeAppearanceModel", "(Lcom/google/android/material/shape/ShapeAppearanceModel;)V", "GetSetShapeAppearanceModel_Lcom_google_android_material_shape_ShapeAppearanceModel_Handler:Google.Android.Material.Shape.IShapeableInvoker, Xamarin.Google.Android.Material")] set; }
	}
}
