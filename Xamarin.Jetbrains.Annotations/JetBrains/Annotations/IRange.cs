using System;
using Android.Runtime;
using Java.Interop;
using Java.Lang.Annotation;

namespace JetBrains.Annotations
{
	// Token: 0x0200002C RID: 44
	[Register("org/jetbrains/annotations/Range", "", "JetBrains.Annotations.IRangeInvoker")]
	public interface IRange : IAnnotation, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x0600015E RID: 350
		[Register("from", "()J", "GetFromHandler:JetBrains.Annotations.IRangeInvoker, Xamarin.Jetbrains.Annotations")]
		long From();

		// Token: 0x0600015F RID: 351
		[Register("to", "()J", "GetToHandler:JetBrains.Annotations.IRangeInvoker, Xamarin.Jetbrains.Annotations")]
		long To();
	}
}
