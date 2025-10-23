using System;
using Android.Runtime;
using Bumptech.Glide.Load;
using Bumptech.Glide.Load.Engine;
using Bumptech.Glide.Request.Target;
using Java.Interop;
using Java.Lang;

namespace Bumptech.Glide.Request
{
	// Token: 0x02000090 RID: 144
	[Register("com/bumptech/glide/request/RequestListener", "", "Bumptech.Glide.Request.IRequestListenerInvoker")]
	[JavaTypeParameters(new string[]
	{
		"R"
	})]
	public interface IRequestListener : IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x06000770 RID: 1904
		[Register("onLoadFailed", "(Lcom/bumptech/glide/load/engine/GlideException;Ljava/lang/Object;Lcom/bumptech/glide/request/target/Target;Z)Z", "GetOnLoadFailed_Lcom_bumptech_glide_load_engine_GlideException_Ljava_lang_Object_Lcom_bumptech_glide_request_target_Target_ZHandler:Bumptech.Glide.Request.IRequestListenerInvoker, Xamarin.Android.Glide")]
		bool OnLoadFailed(GlideException p0, Java.Lang.Object p1, ITarget p2, bool p3);

		// Token: 0x06000771 RID: 1905
		[Register("onResourceReady", "(Ljava/lang/Object;Ljava/lang/Object;Lcom/bumptech/glide/request/target/Target;Lcom/bumptech/glide/load/DataSource;Z)Z", "GetOnResourceReady_Ljava_lang_Object_Ljava_lang_Object_Lcom_bumptech_glide_request_target_Target_Lcom_bumptech_glide_load_DataSource_ZHandler:Bumptech.Glide.Request.IRequestListenerInvoker, Xamarin.Android.Glide")]
		bool OnResourceReady(Java.Lang.Object p0, Java.Lang.Object p1, ITarget p2, DataSource p3, bool p4);
	}
}
