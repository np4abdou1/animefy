using System;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Bumptech.Glide.Load.Model
{
	// Token: 0x0200013B RID: 315
	[Register("com/bumptech/glide/load/model/ModelLoader", "", "Bumptech.Glide.Load.Model.IModelLoaderInvoker")]
	[JavaTypeParameters(new string[]
	{
		"Model",
		"Data"
	})]
	public interface IModelLoader : IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x06000FEC RID: 4076
		[Register("buildLoadData", "(Ljava/lang/Object;IILcom/bumptech/glide/load/Options;)Lcom/bumptech/glide/load/model/ModelLoader$LoadData;", "GetBuildLoadData_Ljava_lang_Object_IILcom_bumptech_glide_load_Options_Handler:Bumptech.Glide.Load.Model.IModelLoaderInvoker, Xamarin.Android.Glide")]
		ModelLoaderLoadData BuildLoadData(Java.Lang.Object p0, int p1, int p2, Options p3);

		// Token: 0x06000FED RID: 4077
		[Register("handles", "(Ljava/lang/Object;)Z", "GetHandles_Ljava_lang_Object_Handler:Bumptech.Glide.Load.Model.IModelLoaderInvoker, Xamarin.Android.Glide")]
		bool Handles(Java.Lang.Object p0);
	}
}
