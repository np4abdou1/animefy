using System;
using Android.Runtime;
using Java.Interop;
using Java.Lang.Annotation;

namespace JavaX.Inject
{
	// Token: 0x02000011 RID: 17
	[Register("javax/inject/Singleton", "", "JavaX.Inject.ISingletonInvoker")]
	public interface ISingleton : IAnnotation, IJavaObject, IDisposable, IJavaPeerable
	{
	}
}
