using System;
using Android.Runtime;
using Bumptech.Glide.Load.Engine;
using Java.Interop;
using Java.Lang;

namespace Bumptech.Glide.Load
{
	// Token: 0x020000D7 RID: 215
	[Register("com/bumptech/glide/load/ResourceDecoder", "", "Bumptech.Glide.Load.IResourceDecoderInvoker")]
	[JavaTypeParameters(new string[]
	{
		"T",
		"Z"
	})]
	public interface IResourceDecoder : IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x06000AE8 RID: 2792
		[Register("decode", "(Ljava/lang/Object;IILcom/bumptech/glide/load/Options;)Lcom/bumptech/glide/load/engine/Resource;", "GetDecode_Ljava_lang_Object_IILcom_bumptech_glide_load_Options_Handler:Bumptech.Glide.Load.IResourceDecoderInvoker, Xamarin.Android.Glide")]
		IResource Decode(Java.Lang.Object p0, int p1, int p2, Options p3);

		// Token: 0x06000AE9 RID: 2793
		[Register("handles", "(Ljava/lang/Object;Lcom/bumptech/glide/load/Options;)Z", "GetHandles_Ljava_lang_Object_Lcom_bumptech_glide_load_Options_Handler:Bumptech.Glide.Load.IResourceDecoderInvoker, Xamarin.Android.Glide")]
		bool Handles(Java.Lang.Object p0, Options p1);
	}
}
