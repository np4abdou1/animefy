using System;
using Android.Runtime;
using Java.Interop;
using Java.Lang.Annotation;

namespace Kotlin.Annotation
{
	// Token: 0x0200028A RID: 650
	[Register("kotlin/annotation/Repeatable", "", "Kotlin.Annotation.IRepeatableInvoker")]
	public interface IRepeatable : IAnnotation, IJavaObject, IDisposable, IJavaPeerable
	{
	}
}
