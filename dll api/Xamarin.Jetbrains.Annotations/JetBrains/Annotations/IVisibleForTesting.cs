using System;
using Android.Runtime;
using Java.Interop;
using Java.Lang.Annotation;

namespace JetBrains.Annotations
{
	// Token: 0x02000036 RID: 54
	[Register("org/jetbrains/annotations/VisibleForTesting", "", "JetBrains.Annotations.IVisibleForTestingInvoker")]
	public interface IVisibleForTesting : IAnnotation, IJavaObject, IDisposable, IJavaPeerable
	{
	}
}
