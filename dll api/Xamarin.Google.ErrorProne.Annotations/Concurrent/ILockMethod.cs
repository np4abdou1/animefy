using System;
using Android.Runtime;
using Java.Interop;
using Java.Lang.Annotation;

namespace Xamarin.Google.ErrorProne.Annotations.Concurrent
{
	// Token: 0x0200004E RID: 78
	[Obsolete("This class is obsoleted in this android platform")]
	[Register("com/google/errorprone/annotations/concurrent/LockMethod", "", "Xamarin.Google.ErrorProne.Annotations.Concurrent.ILockMethodInvoker")]
	public interface ILockMethod : IAnnotation, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x0600028D RID: 653
		[Register("value", "()[Ljava/lang/String;", "GetValueHandler:Xamarin.Google.ErrorProne.Annotations.Concurrent.ILockMethodInvoker, Xamarin.Google.ErrorProne.Annotations")]
		string[] Value();
	}
}
