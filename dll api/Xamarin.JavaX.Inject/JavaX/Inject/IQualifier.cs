using System;
using Android.Runtime;
using Java.Interop;
using Java.Lang.Annotation;

namespace JavaX.Inject
{
	// Token: 0x0200000D RID: 13
	[Register("javax/inject/Qualifier", "", "JavaX.Inject.IQualifierInvoker")]
	public interface IQualifier : IAnnotation, IJavaObject, IDisposable, IJavaPeerable
	{
	}
}
