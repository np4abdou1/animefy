using System;
using Android.Runtime;
using Java.Interop;

namespace Bumptech.Glide.Load.Model
{
	// Token: 0x02000136 RID: 310
	[Register("com/bumptech/glide/load/model/LazyHeaderFactory", "", "Bumptech.Glide.Load.Model.ILazyHeaderFactoryInvoker")]
	public interface ILazyHeaderFactory : IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x06000FC4 RID: 4036
		[Register("buildHeader", "()Ljava/lang/String;", "GetBuildHeaderHandler:Bumptech.Glide.Load.Model.ILazyHeaderFactoryInvoker, Xamarin.Android.Glide")]
		string BuildHeader();
	}
}
