using System;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Bumptech.Glide.Load.Data
{
	// Token: 0x02000193 RID: 403
	[Register("com/bumptech/glide/load/data/DataFetcher", "", "Bumptech.Glide.Load.Data.IDataFetcherInvoker")]
	[JavaTypeParameters(new string[]
	{
		"T"
	})]
	public interface IDataFetcher : IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x1700055F RID: 1375
		// (get) Token: 0x06001462 RID: 5218
		Class DataClass { [Register("getDataClass", "()Ljava/lang/Class;", "GetGetDataClassHandler:Bumptech.Glide.Load.Data.IDataFetcherInvoker, Xamarin.Android.Glide")] get; }

		// Token: 0x17000560 RID: 1376
		// (get) Token: 0x06001463 RID: 5219
		DataSource DataSource { [Register("getDataSource", "()Lcom/bumptech/glide/load/DataSource;", "GetGetDataSourceHandler:Bumptech.Glide.Load.Data.IDataFetcherInvoker, Xamarin.Android.Glide")] get; }

		// Token: 0x06001464 RID: 5220
		[Register("cancel", "()V", "GetCancelHandler:Bumptech.Glide.Load.Data.IDataFetcherInvoker, Xamarin.Android.Glide")]
		void Cancel();

		// Token: 0x06001465 RID: 5221
		[Register("cleanup", "()V", "GetCleanupHandler:Bumptech.Glide.Load.Data.IDataFetcherInvoker, Xamarin.Android.Glide")]
		void Cleanup();

		// Token: 0x06001466 RID: 5222
		[Register("loadData", "(Lcom/bumptech/glide/Priority;Lcom/bumptech/glide/load/data/DataFetcher$DataCallback;)V", "GetLoadData_Lcom_bumptech_glide_Priority_Lcom_bumptech_glide_load_data_DataFetcher_DataCallback_Handler:Bumptech.Glide.Load.Data.IDataFetcherInvoker, Xamarin.Android.Glide")]
		void LoadData(Priority p0, IDataFetcherDataCallback p1);
	}
}
