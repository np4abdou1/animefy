using System;
using Android.Runtime;
using Java.Interop;
using JavaX.Inject;

namespace Xamarin.Google.Android.DataTransport.Runtime.Dagger.Internal
{
	// Token: 0x020000E3 RID: 227
	[Register("com/google/android/datatransport/runtime/dagger/internal/Factory", "", "Xamarin.Google.Android.DataTransport.Runtime.Dagger.Internal.IFactoryInvoker")]
	[JavaTypeParameters(new string[]
	{
		"T"
	})]
	public interface IFactory : IProvider, IJavaObject, IDisposable, IJavaPeerable
	{
	}
}
