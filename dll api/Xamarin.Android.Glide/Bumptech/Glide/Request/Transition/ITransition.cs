using System;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Bumptech.Glide.Request.Transition
{
	// Token: 0x020000A1 RID: 161
	[Register("com/bumptech/glide/request/transition/Transition", "", "Bumptech.Glide.Request.Transition.ITransitionInvoker")]
	[JavaTypeParameters(new string[]
	{
		"R"
	})]
	public interface ITransition : IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x06000875 RID: 2165
		[Register("transition", "(Ljava/lang/Object;Lcom/bumptech/glide/request/transition/Transition$ViewAdapter;)Z", "GetTransition_Ljava_lang_Object_Lcom_bumptech_glide_request_transition_Transition_ViewAdapter_Handler:Bumptech.Glide.Request.Transition.ITransitionInvoker, Xamarin.Android.Glide")]
		bool Transition(Java.Lang.Object p0, ITransitionViewAdapter p1);
	}
}
