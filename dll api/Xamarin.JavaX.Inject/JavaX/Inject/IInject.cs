using System;
using Android.Runtime;
using Java.Interop;
using Java.Lang.Annotation;

namespace JavaX.Inject
{
	// Token: 0x02000006 RID: 6
	[Register("javax/inject/Inject", "", "JavaX.Inject.IInjectInvoker")]
	public interface IInject : IAnnotation, IJavaObject, IDisposable, IJavaPeerable
	{
	}
}
