using System;
using Android.Runtime;
using Java.Interop;
using Java.Lang.Annotation;

namespace JetBrains.Annotations
{
	// Token: 0x02000022 RID: 34
	[Register("org/jetbrains/annotations/NonBlockingExecutor", "", "JetBrains.Annotations.INonBlockingExecutorInvoker")]
	public interface INonBlockingExecutor : IAnnotation, IJavaObject, IDisposable, IJavaPeerable
	{
	}
}
