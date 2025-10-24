using System;
using Android.Runtime;
using Java.Interop;

namespace Bumptech.Glide.Load
{
	// Token: 0x020000D9 RID: 217
	[Register("com/bumptech/glide/load/ResourceEncoder", "", "Bumptech.Glide.Load.IResourceEncoderInvoker")]
	[JavaTypeParameters(new string[]
	{
		"T"
	})]
	public interface IResourceEncoder : IEncoder, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x06000AF9 RID: 2809
		[Register("getEncodeStrategy", "(Lcom/bumptech/glide/load/Options;)Lcom/bumptech/glide/load/EncodeStrategy;", "GetGetEncodeStrategy_Lcom_bumptech_glide_load_Options_Handler:Bumptech.Glide.Load.IResourceEncoderInvoker, Xamarin.Android.Glide")]
		EncodeStrategy GetEncodeStrategy(Options p0);
	}
}
