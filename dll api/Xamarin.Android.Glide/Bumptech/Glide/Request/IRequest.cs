using System;
using Android.Runtime;
using Java.Interop;

namespace Bumptech.Glide.Request
{
	// Token: 0x0200008B RID: 139
	[Register("com/bumptech/glide/request/Request", "", "Bumptech.Glide.Request.IRequestInvoker")]
	public interface IRequest : IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x17000165 RID: 357
		// (get) Token: 0x06000715 RID: 1813
		bool IsAnyResourceSet { [Register("isAnyResourceSet", "()Z", "GetIsAnyResourceSetHandler:Bumptech.Glide.Request.IRequestInvoker, Xamarin.Android.Glide")] get; }

		// Token: 0x17000166 RID: 358
		// (get) Token: 0x06000716 RID: 1814
		bool IsCleared { [Register("isCleared", "()Z", "GetIsClearedHandler:Bumptech.Glide.Request.IRequestInvoker, Xamarin.Android.Glide")] get; }

		// Token: 0x17000167 RID: 359
		// (get) Token: 0x06000717 RID: 1815
		bool IsComplete { [Register("isComplete", "()Z", "GetIsCompleteHandler:Bumptech.Glide.Request.IRequestInvoker, Xamarin.Android.Glide")] get; }

		// Token: 0x17000168 RID: 360
		// (get) Token: 0x06000718 RID: 1816
		bool IsRunning { [Register("isRunning", "()Z", "GetIsRunningHandler:Bumptech.Glide.Request.IRequestInvoker, Xamarin.Android.Glide")] get; }

		// Token: 0x06000719 RID: 1817
		[Register("begin", "()V", "GetBeginHandler:Bumptech.Glide.Request.IRequestInvoker, Xamarin.Android.Glide")]
		void Begin();

		// Token: 0x0600071A RID: 1818
		[Register("clear", "()V", "GetClearHandler:Bumptech.Glide.Request.IRequestInvoker, Xamarin.Android.Glide")]
		void Clear();

		// Token: 0x0600071B RID: 1819
		[Register("isEquivalentTo", "(Lcom/bumptech/glide/request/Request;)Z", "GetIsEquivalentTo_Lcom_bumptech_glide_request_Request_Handler:Bumptech.Glide.Request.IRequestInvoker, Xamarin.Android.Glide")]
		bool IsEquivalentTo(IRequest p0);

		// Token: 0x0600071C RID: 1820
		[Register("pause", "()V", "GetPauseHandler:Bumptech.Glide.Request.IRequestInvoker, Xamarin.Android.Glide")]
		void Pause();
	}
}
