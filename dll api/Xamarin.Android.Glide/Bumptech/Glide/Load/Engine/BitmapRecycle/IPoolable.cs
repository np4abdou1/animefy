using System;
using Android.Runtime;
using Java.Interop;

namespace Bumptech.Glide.Load.Engine.BitmapRecycle
{
	// Token: 0x02000180 RID: 384
	[Register("com/bumptech/glide/load/engine/bitmap_recycle/Poolable", "", "Bumptech.Glide.Load.Engine.BitmapRecycle.IPoolableInvoker")]
	public interface IPoolable : IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x06001326 RID: 4902
		[Register("offer", "()V", "GetOfferHandler:Bumptech.Glide.Load.Engine.BitmapRecycle.IPoolableInvoker, Xamarin.Android.Glide")]
		void Offer();
	}
}
