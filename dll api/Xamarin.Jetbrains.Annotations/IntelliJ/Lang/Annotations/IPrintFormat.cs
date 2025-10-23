using System;
using Android.Runtime;
using Java.Interop;
using Java.Lang.Annotation;

namespace IntelliJ.Lang.Annotations
{
	// Token: 0x02000055 RID: 85
	[Register("org/intellij/lang/annotations/PrintFormat", "", "IntelliJ.Lang.Annotations.IPrintFormatInvoker")]
	public interface IPrintFormat : IAnnotation, IJavaObject, IDisposable, IJavaPeerable
	{
	}
}
