using System;
using Android.Runtime;
using Java.Interop;
using Java.Lang.Annotation;

namespace JetBrains.Annotations
{
	// Token: 0x0200002E RID: 46
	[Register("org/jetbrains/annotations/TestOnly", "", "JetBrains.Annotations.ITestOnlyInvoker")]
	public interface ITestOnly : IAnnotation, IJavaObject, IDisposable, IJavaPeerable
	{
	}
}
