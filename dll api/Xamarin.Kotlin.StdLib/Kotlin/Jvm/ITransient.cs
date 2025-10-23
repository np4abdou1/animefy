using System;
using Android.Runtime;
using Java.Interop;
using Java.Lang.Annotation;

namespace Kotlin.Jvm
{
	// Token: 0x02000172 RID: 370
	[Register("kotlin/jvm/Transient", "", "Kotlin.Jvm.ITransientInvoker")]
	public interface ITransient : IAnnotation, IJavaObject, IDisposable, IJavaPeerable
	{
	}
}
