using System;
using Android.Runtime;
using Java.Interop;
using Java.Lang.Annotation;

namespace Xamarin.Google.ErrorProne.Annotations
{
	// Token: 0x02000025 RID: 37
	[Register("com/google/errorprone/annotations/InlineMe", "", "Xamarin.Google.ErrorProne.Annotations.IInlineMeInvoker")]
	public interface IInlineMe : IAnnotation, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x06000118 RID: 280
		[Register("imports", "()[Ljava/lang/String;", "GetImportsHandler:Xamarin.Google.ErrorProne.Annotations.IInlineMeInvoker, Xamarin.Google.ErrorProne.Annotations")]
		string[] Imports();

		// Token: 0x06000119 RID: 281
		[Register("replacement", "()Ljava/lang/String;", "GetReplacementHandler:Xamarin.Google.ErrorProne.Annotations.IInlineMeInvoker, Xamarin.Google.ErrorProne.Annotations")]
		string Replacement();

		// Token: 0x0600011A RID: 282
		[Register("staticImports", "()[Ljava/lang/String;", "GetStaticImportsHandler:Xamarin.Google.ErrorProne.Annotations.IInlineMeInvoker, Xamarin.Google.ErrorProne.Annotations")]
		string[] StaticImports();
	}
}
