using System;
using Android.Runtime;
using Java.Interop;
using Java.IO;
using Java.Lang;

namespace Bumptech.Glide.Load
{
	// Token: 0x020000CB RID: 203
	[Register("com/bumptech/glide/load/Encoder", "", "Bumptech.Glide.Load.IEncoderInvoker")]
	[JavaTypeParameters(new string[]
	{
		"T"
	})]
	public interface IEncoder : IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x06000A84 RID: 2692
		[Register("encode", "(Ljava/lang/Object;Ljava/io/File;Lcom/bumptech/glide/load/Options;)Z", "GetEncode_Ljava_lang_Object_Ljava_io_File_Lcom_bumptech_glide_load_Options_Handler:Bumptech.Glide.Load.IEncoderInvoker, Xamarin.Android.Glide")]
		bool Encode(Java.Lang.Object p0, File p1, Options p2);
	}
}
