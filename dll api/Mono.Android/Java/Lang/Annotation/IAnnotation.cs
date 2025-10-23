using System;
using Android.Runtime;
using Java.Interop;

namespace Java.Lang.Annotation
{
	// Token: 0x0200040F RID: 1039
	[Register("java/lang/annotation/Annotation", "", "Java.Lang.Annotation.IAnnotationInvoker")]
	public interface IAnnotation : IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x06002D9D RID: 11677
		Class AnnotationType();

		// Token: 0x06002D9E RID: 11678
		bool Equals(Object obj);

		// Token: 0x06002D9F RID: 11679
		int GetHashCode();

		// Token: 0x06002DA0 RID: 11680
		string ToString();
	}
}
