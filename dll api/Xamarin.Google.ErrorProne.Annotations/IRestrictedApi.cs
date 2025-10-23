using System;
using Android.Runtime;
using Java.Interop;
using Java.Lang;
using Java.Lang.Annotation;

namespace Xamarin.Google.ErrorProne.Annotations
{
	// Token: 0x02000037 RID: 55
	[Register("com/google/errorprone/annotations/RestrictedApi", "", "Xamarin.Google.ErrorProne.Annotations.IRestrictedApiInvoker")]
	public interface IRestrictedApi : IAnnotation, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x060001CD RID: 461
		[Register("allowedOnPath", "()Ljava/lang/String;", "GetAllowedOnPathHandler:Xamarin.Google.ErrorProne.Annotations.IRestrictedApiInvoker, Xamarin.Google.ErrorProne.Annotations")]
		string AllowedOnPath();

		// Token: 0x060001CE RID: 462
		[Register("allowlistAnnotations", "()[Ljava/lang/Class;", "GetAllowlistAnnotationsHandler:Xamarin.Google.ErrorProne.Annotations.IRestrictedApiInvoker, Xamarin.Google.ErrorProne.Annotations")]
		Class[] AllowlistAnnotations();

		// Token: 0x060001CF RID: 463
		[Register("allowlistWithWarningAnnotations", "()[Ljava/lang/Class;", "GetAllowlistWithWarningAnnotationsHandler:Xamarin.Google.ErrorProne.Annotations.IRestrictedApiInvoker, Xamarin.Google.ErrorProne.Annotations")]
		Class[] AllowlistWithWarningAnnotations();

		// Token: 0x060001D0 RID: 464
		[Register("explanation", "()Ljava/lang/String;", "GetExplanationHandler:Xamarin.Google.ErrorProne.Annotations.IRestrictedApiInvoker, Xamarin.Google.ErrorProne.Annotations")]
		string Explanation();

		// Token: 0x060001D1 RID: 465
		[Register("link", "()Ljava/lang/String;", "GetLinkHandler:Xamarin.Google.ErrorProne.Annotations.IRestrictedApiInvoker, Xamarin.Google.ErrorProne.Annotations")]
		string Link();
	}
}
