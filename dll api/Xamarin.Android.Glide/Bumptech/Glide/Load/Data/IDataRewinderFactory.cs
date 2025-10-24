using System;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Bumptech.Glide.Load.Data
{
	// Token: 0x02000195 RID: 405
	[Register("com/bumptech/glide/load/data/DataRewinder$Factory", "", "Bumptech.Glide.Load.Data.IDataRewinderFactoryInvoker")]
	[JavaTypeParameters(new string[]
	{
		"T"
	})]
	public interface IDataRewinderFactory : IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x17000567 RID: 1383
		// (get) Token: 0x0600147F RID: 5247
		Class DataClass { [Register("getDataClass", "()Ljava/lang/Class;", "GetGetDataClassHandler:Bumptech.Glide.Load.Data.IDataRewinderFactoryInvoker, Xamarin.Android.Glide")] get; }

		// Token: 0x06001480 RID: 5248
		[Register("build", "(Ljava/lang/Object;)Lcom/bumptech/glide/load/data/DataRewinder;", "GetBuild_Ljava_lang_Object_Handler:Bumptech.Glide.Load.Data.IDataRewinderFactoryInvoker, Xamarin.Android.Glide")]
		IDataRewinder Build(Java.Lang.Object p0);
	}
}
