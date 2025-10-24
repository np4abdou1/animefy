using System;
using Android.Runtime;
using Java.Interop;
using Java.Lang.Annotation;

namespace Xamarin.Google.ErrorProne.Annotations.Concurrent
{
	// Token: 0x02000050 RID: 80
	[Obsolete("This class is obsoleted in this android platform")]
	[Register("com/google/errorprone/annotations/concurrent/UnlockMethod", "", "Xamarin.Google.ErrorProne.Annotations.Concurrent.IUnlockMethodInvoker")]
	public interface IUnlockMethod : IAnnotation, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x060002A6 RID: 678
		[Register("value", "()[Ljava/lang/String;", "GetValueHandler:Xamarin.Google.ErrorProne.Annotations.Concurrent.IUnlockMethodInvoker, Xamarin.Google.ErrorProne.Annotations")]
		string[] Value();
	}
}
