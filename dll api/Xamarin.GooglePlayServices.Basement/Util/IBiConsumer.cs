using System;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Android.Gms.Common.Util
{
	// Token: 0x02000010 RID: 16
	[Register("com/google/android/gms/common/util/BiConsumer", "", "Android.Gms.Common.Util.IBiConsumerInvoker")]
	[JavaTypeParameters(new string[]
	{
		"T",
		"U"
	})]
	public interface IBiConsumer : IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x06000056 RID: 86
		[Register("accept", "(Ljava/lang/Object;Ljava/lang/Object;)V", "GetAccept_Ljava_lang_Object_Ljava_lang_Object_Handler:Android.Gms.Common.Util.IBiConsumerInvoker, Xamarin.GooglePlayServices.Basement")]
		void Accept(Java.Lang.Object p0, Java.Lang.Object p1);
	}
}
