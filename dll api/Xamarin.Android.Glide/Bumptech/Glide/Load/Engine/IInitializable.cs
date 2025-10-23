using System;
using Android.Runtime;
using Java.Interop;

namespace Bumptech.Glide.Load.Engine
{
	// Token: 0x02000154 RID: 340
	[Register("com/bumptech/glide/load/engine/Initializable", "", "Bumptech.Glide.Load.Engine.IInitializableInvoker")]
	public interface IInitializable : IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x06001130 RID: 4400
		[Register("initialize", "()V", "GetInitializeHandler:Bumptech.Glide.Load.Engine.IInitializableInvoker, Xamarin.Android.Glide")]
		void Initialize();
	}
}
