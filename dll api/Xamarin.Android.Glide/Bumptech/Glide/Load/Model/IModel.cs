using System;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Bumptech.Glide.Load.Model
{
	// Token: 0x02000138 RID: 312
	[Register("com/bumptech/glide/load/model/Model", "", "Bumptech.Glide.Load.Model.IModelInvoker")]
	public interface IModel : IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x06000FD1 RID: 4049
		[Register("isEquivalentTo", "(Ljava/lang/Object;)Z", "GetIsEquivalentTo_Ljava_lang_Object_Handler:Bumptech.Glide.Load.Model.IModelInvoker, Xamarin.Android.Glide")]
		bool IsEquivalentTo(Java.Lang.Object p0);
	}
}
