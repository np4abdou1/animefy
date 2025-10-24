using System;
using Android.Runtime;
using Bumptech.Glide.Load;
using Java.Interop;

namespace Bumptech.Glide.Request.Transition
{
	// Token: 0x020000A3 RID: 163
	[Register("com/bumptech/glide/request/transition/TransitionFactory", "", "Bumptech.Glide.Request.Transition.ITransitionFactoryInvoker")]
	[JavaTypeParameters(new string[]
	{
		"R"
	})]
	public interface ITransitionFactory : IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x06000882 RID: 2178
		[Register("build", "(Lcom/bumptech/glide/load/DataSource;Z)Lcom/bumptech/glide/request/transition/Transition;", "GetBuild_Lcom_bumptech_glide_load_DataSource_ZHandler:Bumptech.Glide.Request.Transition.ITransitionFactoryInvoker, Xamarin.Android.Glide")]
		ITransition Build(DataSource p0, bool p1);
	}
}
