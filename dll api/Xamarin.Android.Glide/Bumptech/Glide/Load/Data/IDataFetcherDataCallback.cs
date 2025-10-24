using System;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Bumptech.Glide.Load.Data
{
	// Token: 0x02000191 RID: 401
	[Register("com/bumptech/glide/load/data/DataFetcher$DataCallback", "", "Bumptech.Glide.Load.Data.IDataFetcherDataCallbackInvoker")]
	[JavaTypeParameters(new string[]
	{
		"T"
	})]
	public interface IDataFetcherDataCallback : IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x06001451 RID: 5201
		[Register("onDataReady", "(Ljava/lang/Object;)V", "GetOnDataReady_Ljava_lang_Object_Handler:Bumptech.Glide.Load.Data.IDataFetcherDataCallbackInvoker, Xamarin.Android.Glide")]
		void OnDataReady(Java.Lang.Object p0);

		// Token: 0x06001452 RID: 5202
		[Register("onLoadFailed", "(Ljava/lang/Exception;)V", "GetOnLoadFailed_Ljava_lang_Exception_Handler:Bumptech.Glide.Load.Data.IDataFetcherDataCallbackInvoker, Xamarin.Android.Glide")]
		void OnLoadFailed(Java.Lang.Exception p0);
	}
}
