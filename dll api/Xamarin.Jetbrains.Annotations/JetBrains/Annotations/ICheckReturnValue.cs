using System;
using Android.Runtime;
using Java.Interop;
using Java.Lang.Annotation;

namespace JetBrains.Annotations
{
	// Token: 0x02000017 RID: 23
	[Register("org/jetbrains/annotations/CheckReturnValue", "", "JetBrains.Annotations.ICheckReturnValueInvoker")]
	public interface ICheckReturnValue : IAnnotation, IJavaObject, IDisposable, IJavaPeerable
	{
	}
}
