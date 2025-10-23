using System;
using Android.Runtime;
using Java.Interop;
using Java.Lang.Annotation;

namespace JetBrains.Annotations
{
	// Token: 0x02000020 RID: 32
	[Register("org/jetbrains/annotations/NonBlocking", "", "JetBrains.Annotations.INonBlockingInvoker")]
	public interface INonBlocking : IAnnotation, IJavaObject, IDisposable, IJavaPeerable
	{
	}
}
