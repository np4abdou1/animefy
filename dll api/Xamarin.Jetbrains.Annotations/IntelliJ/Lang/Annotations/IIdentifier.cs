using System;
using Android.Runtime;
using Java.Interop;
using Java.Lang.Annotation;

namespace IntelliJ.Lang.Annotations
{
	// Token: 0x0200004D RID: 77
	[Register("org/intellij/lang/annotations/Identifier", "", "IntelliJ.Lang.Annotations.IIdentifierInvoker")]
	public interface IIdentifier : IAnnotation, IJavaObject, IDisposable, IJavaPeerable
	{
	}
}
