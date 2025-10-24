using System;
using Android.Runtime;
using Java.Interop;
using Java.Lang.Annotation;

namespace JetBrains.Annotations
{
	// Token: 0x0200001B RID: 27
	[Register("org/jetbrains/annotations/MustBeInvokedByOverriders", "", "JetBrains.Annotations.IMustBeInvokedByOverridersInvoker")]
	public interface IMustBeInvokedByOverriders : IAnnotation, IJavaObject, IDisposable, IJavaPeerable
	{
	}
}
