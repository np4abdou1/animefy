using System;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace AndroidX.Core.Util
{
	// Token: 0x0200004A RID: 74
	[Register("androidx/core/util/Consumer", "", "AndroidX.Core.Util.IConsumerInvoker")]
	[JavaTypeParameters(new string[]
	{
		"T"
	})]
	public interface IConsumer : IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x06000118 RID: 280
		[Register("accept", "(Ljava/lang/Object;)V", "GetAccept_Ljava_lang_Object_Handler:AndroidX.Core.Util.IConsumerInvoker, Xamarin.AndroidX.Core")]
		void Accept(Java.Lang.Object t);
	}
}
