using System;
using Android.Runtime;
using Java.Interop;

namespace Bumptech.Glide.Request
{
	// Token: 0x0200008E RID: 142
	[Register("com/bumptech/glide/request/RequestCoordinator", "", "Bumptech.Glide.Request.IRequestCoordinatorInvoker")]
	public interface IRequestCoordinator : IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x1700017A RID: 378
		// (get) Token: 0x0600074B RID: 1867
		bool IsAnyResourceSet { [Register("isAnyResourceSet", "()Z", "GetIsAnyResourceSetHandler:Bumptech.Glide.Request.IRequestCoordinatorInvoker, Xamarin.Android.Glide")] get; }

		// Token: 0x1700017B RID: 379
		// (get) Token: 0x0600074C RID: 1868
		IRequestCoordinator Root { [Register("getRoot", "()Lcom/bumptech/glide/request/RequestCoordinator;", "GetGetRootHandler:Bumptech.Glide.Request.IRequestCoordinatorInvoker, Xamarin.Android.Glide")] get; }

		// Token: 0x0600074D RID: 1869
		[Register("canNotifyCleared", "(Lcom/bumptech/glide/request/Request;)Z", "GetCanNotifyCleared_Lcom_bumptech_glide_request_Request_Handler:Bumptech.Glide.Request.IRequestCoordinatorInvoker, Xamarin.Android.Glide")]
		bool CanNotifyCleared(IRequest p0);

		// Token: 0x0600074E RID: 1870
		[Register("canNotifyStatusChanged", "(Lcom/bumptech/glide/request/Request;)Z", "GetCanNotifyStatusChanged_Lcom_bumptech_glide_request_Request_Handler:Bumptech.Glide.Request.IRequestCoordinatorInvoker, Xamarin.Android.Glide")]
		bool CanNotifyStatusChanged(IRequest p0);

		// Token: 0x0600074F RID: 1871
		[Register("canSetImage", "(Lcom/bumptech/glide/request/Request;)Z", "GetCanSetImage_Lcom_bumptech_glide_request_Request_Handler:Bumptech.Glide.Request.IRequestCoordinatorInvoker, Xamarin.Android.Glide")]
		bool CanSetImage(IRequest p0);

		// Token: 0x06000750 RID: 1872
		[Register("onRequestFailed", "(Lcom/bumptech/glide/request/Request;)V", "GetOnRequestFailed_Lcom_bumptech_glide_request_Request_Handler:Bumptech.Glide.Request.IRequestCoordinatorInvoker, Xamarin.Android.Glide")]
		void OnRequestFailed(IRequest p0);

		// Token: 0x06000751 RID: 1873
		[Register("onRequestSuccess", "(Lcom/bumptech/glide/request/Request;)V", "GetOnRequestSuccess_Lcom_bumptech_glide_request_Request_Handler:Bumptech.Glide.Request.IRequestCoordinatorInvoker, Xamarin.Android.Glide")]
		void OnRequestSuccess(IRequest p0);
	}
}
