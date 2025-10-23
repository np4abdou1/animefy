using System;
using Android.Runtime;
using Java.Interop;
using Java.Lang.Annotation;

namespace JavaX.Inject
{
	// Token: 0x0200000F RID: 15
	[Register("javax/inject/Scope", "", "JavaX.Inject.IScopeInvoker")]
	public interface IScope : IAnnotation, IJavaObject, IDisposable, IJavaPeerable
	{
	}
}
