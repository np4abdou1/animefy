using System;
using Android.Runtime;
using Bumptech.Glide.Load.Engine;
using Java.Interop;

namespace Bumptech.Glide.Load.Resource.Transcode
{
	// Token: 0x020000E9 RID: 233
	[Register("com/bumptech/glide/load/resource/transcode/ResourceTranscoder", "", "Bumptech.Glide.Load.Resource.Transcode.IResourceTranscoderInvoker")]
	[JavaTypeParameters(new string[]
	{
		"Z",
		"R"
	})]
	public interface IResourceTranscoder : IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x06000BA1 RID: 2977
		[Register("transcode", "(Lcom/bumptech/glide/load/engine/Resource;Lcom/bumptech/glide/load/Options;)Lcom/bumptech/glide/load/engine/Resource;", "GetTranscode_Lcom_bumptech_glide_load_engine_Resource_Lcom_bumptech_glide_load_Options_Handler:Bumptech.Glide.Load.Resource.Transcode.IResourceTranscoderInvoker, Xamarin.Android.Glide")]
		IResource Transcode(IResource p0, Options p1);
	}
}
