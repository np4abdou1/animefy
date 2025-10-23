using System;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Android.Gms.Common.Api.Internal
{
	// Token: 0x0200002B RID: 43
	[Register("com/google/android/gms/common/api/internal/RemoteCall", "", "Android.Gms.Common.Api.Internal.IRemoteCallInvoker")]
	[JavaTypeParameters(new string[]
	{
		"T",
		"U"
	})]
	public interface IRemoteCall : IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x06000181 RID: 385
		[Register("accept", "(Ljava/lang/Object;Ljava/lang/Object;)V", "GetAccept_Ljava_lang_Object_Ljava_lang_Object_Handler:Android.Gms.Common.Api.Internal.IRemoteCallInvoker, Xamarin.GooglePlayServices.Base")]
		void Accept(Java.Lang.Object p0, Java.Lang.Object p1);
	}
}
