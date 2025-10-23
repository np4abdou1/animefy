using System;
using Android.Runtime;
using Java.Interop;
using Java.Lang.Annotation;

namespace JetBrains.Annotations
{
	// Token: 0x02000015 RID: 21
	[Register("org/jetbrains/annotations/BlockingExecutor", "", "JetBrains.Annotations.IBlockingExecutorInvoker")]
	public interface IBlockingExecutor : IAnnotation, IJavaObject, IDisposable, IJavaPeerable
	{
	}
}
