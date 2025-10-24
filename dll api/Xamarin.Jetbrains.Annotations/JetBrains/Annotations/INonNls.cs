using System;
using Android.Runtime;
using Java.Interop;
using Java.Lang.Annotation;

namespace JetBrains.Annotations
{
	// Token: 0x02000024 RID: 36
	[Register("org/jetbrains/annotations/NonNls", "", "JetBrains.Annotations.INonNlsInvoker")]
	public interface INonNls : IAnnotation, IJavaObject, IDisposable, IJavaPeerable
	{
	}
}
