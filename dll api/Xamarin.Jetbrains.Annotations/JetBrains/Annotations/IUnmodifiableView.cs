using System;
using Android.Runtime;
using Java.Interop;
using Java.Lang.Annotation;

namespace JetBrains.Annotations
{
	// Token: 0x02000034 RID: 52
	[Register("org/jetbrains/annotations/UnmodifiableView", "", "JetBrains.Annotations.IUnmodifiableViewInvoker")]
	public interface IUnmodifiableView : IAnnotation, IJavaObject, IDisposable, IJavaPeerable
	{
	}
}
