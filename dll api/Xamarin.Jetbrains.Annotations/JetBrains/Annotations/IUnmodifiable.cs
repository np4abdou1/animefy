using System;
using Android.Runtime;
using Java.Interop;
using Java.Lang.Annotation;

namespace JetBrains.Annotations
{
	// Token: 0x02000032 RID: 50
	[Register("org/jetbrains/annotations/Unmodifiable", "", "JetBrains.Annotations.IUnmodifiableInvoker")]
	public interface IUnmodifiable : IAnnotation, IJavaObject, IDisposable, IJavaPeerable
	{
	}
}
