using System;
using System.Collections.Generic;
using Android.Gms.Common.Apis;
using Android.OS;
using Android.Runtime;
using Java.Interop;

namespace Android.Gms.Auth.Api.SignIn
{
	// Token: 0x02000018 RID: 24
	[Register("com/google/android/gms/auth/api/signin/GoogleSignInOptionsExtension", "", "Android.Gms.Auth.Api.SignIn.IGoogleSignInOptionsExtensionInvoker")]
	public interface IGoogleSignInOptionsExtension : IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x17000029 RID: 41
		// (get) Token: 0x060000C7 RID: 199
		int ExtensionType { [Register("getExtensionType", "()I", "GetGetExtensionTypeHandler:Android.Gms.Auth.Api.SignIn.IGoogleSignInOptionsExtensionInvoker, Xamarin.GooglePlayServices.Base")] get; }

		// Token: 0x1700002A RID: 42
		// (get) Token: 0x060000C8 RID: 200
		IList<Scope> ImpliedScopes { [Register("getImpliedScopes", "()Ljava/util/List;", "GetGetImpliedScopesHandler:Android.Gms.Auth.Api.SignIn.IGoogleSignInOptionsExtensionInvoker, Xamarin.GooglePlayServices.Base")] get; }

		// Token: 0x060000C9 RID: 201
		[Register("toBundle", "()Landroid/os/Bundle;", "GetToBundleHandler:Android.Gms.Auth.Api.SignIn.IGoogleSignInOptionsExtensionInvoker, Xamarin.GooglePlayServices.Base")]
		Bundle ToBundle();
	}
}
