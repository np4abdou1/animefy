using System;
using Android.Content;
using Android.Runtime;
using Bumptech.Glide.Load.Engine;
using Java.Interop;

namespace Bumptech.Glide.Load
{
	// Token: 0x020000DB RID: 219
	[Register("com/bumptech/glide/load/Transformation", "", "Bumptech.Glide.Load.ITransformationInvoker")]
	[JavaTypeParameters(new string[]
	{
		"T"
	})]
	public interface ITransformation : IKey, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x06000B09 RID: 2825
		[Register("transform", "(Landroid/content/Context;Lcom/bumptech/glide/load/engine/Resource;II)Lcom/bumptech/glide/load/engine/Resource;", "GetTransform_Landroid_content_Context_Lcom_bumptech_glide_load_engine_Resource_IIHandler:Bumptech.Glide.Load.ITransformationInvoker, Xamarin.Android.Glide")]
		IResource Transform(Context p0, IResource p1, int p2, int p3);
	}
}
