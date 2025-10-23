using System;
using Android.Runtime;
using Bumptech.Glide.Load;
using Bumptech.Glide.Load.Engine;
using Java.Interop;
using Java.Lang;

namespace Bumptech.Glide.Request
{
	// Token: 0x02000095 RID: 149
	[Register("com/bumptech/glide/request/ResourceCallback", "", "Bumptech.Glide.Request.IResourceCallbackInvoker")]
	public interface IResourceCallback : IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x17000191 RID: 401
		// (get) Token: 0x06000794 RID: 1940
		Java.Lang.Object Lock { [Register("getLock", "()Ljava/lang/Object;", "GetGetLockHandler:Bumptech.Glide.Request.IResourceCallbackInvoker, Xamarin.Android.Glide")] get; }

		// Token: 0x06000795 RID: 1941
		[Register("onLoadFailed", "(Lcom/bumptech/glide/load/engine/GlideException;)V", "GetOnLoadFailed_Lcom_bumptech_glide_load_engine_GlideException_Handler:Bumptech.Glide.Request.IResourceCallbackInvoker, Xamarin.Android.Glide")]
		void OnLoadFailed(GlideException p0);

		// Token: 0x06000796 RID: 1942
		[Register("onResourceReady", "(Lcom/bumptech/glide/load/engine/Resource;Lcom/bumptech/glide/load/DataSource;Z)V", "GetOnResourceReady_Lcom_bumptech_glide_load_engine_Resource_Lcom_bumptech_glide_load_DataSource_ZHandler:Bumptech.Glide.Request.IResourceCallbackInvoker, Xamarin.Android.Glide")]
		void OnResourceReady(IResource p0, DataSource p1, bool p2);
	}
}
