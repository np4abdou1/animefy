using System;
using Android.Runtime;
using Java.Interop;
using Java.Lang.Annotation;

namespace Xamarin.Google.ErrorProne.Annotations.Concurrent
{
	// Token: 0x0200004A RID: 74
	[Register("com/google/errorprone/annotations/concurrent/GuardedBy", "", "Xamarin.Google.ErrorProne.Annotations.Concurrent.IGuardedByInvoker")]
	public interface IGuardedBy : IAnnotation, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x0600025F RID: 607
		[Register("value", "()Ljava/lang/String;", "GetValueHandler:Xamarin.Google.ErrorProne.Annotations.Concurrent.IGuardedByInvoker, Xamarin.Google.ErrorProne.Annotations")]
		string Value();
	}
}
