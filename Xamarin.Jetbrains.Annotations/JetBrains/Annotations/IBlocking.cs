using System;
using Android.Runtime;
using Java.Interop;
using Java.Lang.Annotation;

namespace JetBrains.Annotations
{
	// Token: 0x02000013 RID: 19
	[Register("org/jetbrains/annotations/Blocking", "", "JetBrains.Annotations.IBlockingInvoker")]
	public interface IBlocking : IAnnotation, IJavaObject, IDisposable, IJavaPeerable
	{
	}
}
