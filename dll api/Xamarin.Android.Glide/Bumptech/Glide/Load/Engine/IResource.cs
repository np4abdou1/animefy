using System;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Bumptech.Glide.Load.Engine
{
	// Token: 0x02000156 RID: 342
	[Register("com/bumptech/glide/load/engine/Resource", "", "Bumptech.Glide.Load.Engine.IResourceInvoker")]
	[JavaTypeParameters(new string[]
	{
		"Z"
	})]
	public interface IResource : IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x1700048F RID: 1167
		// (get) Token: 0x0600113D RID: 4413
		Class ResourceClass { [Register("getResourceClass", "()Ljava/lang/Class;", "GetGetResourceClassHandler:Bumptech.Glide.Load.Engine.IResourceInvoker, Xamarin.Android.Glide")] get; }

		// Token: 0x17000490 RID: 1168
		// (get) Token: 0x0600113E RID: 4414
		int Size { [Register("getSize", "()I", "GetGetSizeHandler:Bumptech.Glide.Load.Engine.IResourceInvoker, Xamarin.Android.Glide")] get; }

		// Token: 0x0600113F RID: 4415
		[Register("get", "()Ljava/lang/Object;", "GetGetHandler:Bumptech.Glide.Load.Engine.IResourceInvoker, Xamarin.Android.Glide")]
		Java.Lang.Object Get();

		// Token: 0x06001140 RID: 4416
		[Register("recycle", "()V", "GetRecycleHandler:Bumptech.Glide.Load.Engine.IResourceInvoker, Xamarin.Android.Glide")]
		void Recycle();
	}
}
