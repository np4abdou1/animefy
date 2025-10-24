using System;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Xamarin.Google.Android.DataTransport.Runtime.Dagger
{
	// Token: 0x020000AB RID: 171
	[Register("com/google/android/datatransport/runtime/dagger/MembersInjector", "", "Xamarin.Google.Android.DataTransport.Runtime.Dagger.IMembersInjectorInvoker")]
	[JavaTypeParameters(new string[]
	{
		"T"
	})]
	public interface IMembersInjector : IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x06000639 RID: 1593
		[Register("injectMembers", "(Ljava/lang/Object;)V", "GetInjectMembers_Ljava_lang_Object_Handler:Xamarin.Google.Android.DataTransport.Runtime.Dagger.IMembersInjectorInvoker, Xamarin.Google.Android.DataTransport.TransportRuntime")]
		void InjectMembers(Java.Lang.Object p0);
	}
}
