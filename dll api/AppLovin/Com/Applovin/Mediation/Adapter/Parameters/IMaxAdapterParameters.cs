using System;
using System.Collections.Generic;
using Android.OS;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Com.Applovin.Mediation.Adapter.Parameters
{
	// Token: 0x02000111 RID: 273
	[Register("com/applovin/mediation/adapter/parameters/MaxAdapterParameters", "", "Com.Applovin.Mediation.Adapter.Parameters.IMaxAdapterParametersInvoker")]
	public interface IMaxAdapterParameters : IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x1700032F RID: 815
		// (get) Token: 0x06000B88 RID: 2952
		string AdUnitId { [Register("getAdUnitId", "()Ljava/lang/String;", "GetGetAdUnitIdHandler:Com.Applovin.Mediation.Adapter.Parameters.IMaxAdapterParametersInvoker, AppLovin")] get; }

		// Token: 0x17000330 RID: 816
		// (get) Token: 0x06000B89 RID: 2953
		Bundle CustomParameters { [Register("getCustomParameters", "()Landroid/os/Bundle;", "GetGetCustomParametersHandler:Com.Applovin.Mediation.Adapter.Parameters.IMaxAdapterParametersInvoker, AppLovin")] get; }

		// Token: 0x17000331 RID: 817
		// (get) Token: 0x06000B8A RID: 2954
		bool IsTesting { [Register("isTesting", "()Z", "GetIsTestingHandler:Com.Applovin.Mediation.Adapter.Parameters.IMaxAdapterParametersInvoker, AppLovin")] get; }

		// Token: 0x17000332 RID: 818
		// (get) Token: 0x06000B8B RID: 2955
		IDictionary<string, Java.Lang.Object> LocalExtraParameters { [Register("getLocalExtraParameters", "()Ljava/util/Map;", "GetGetLocalExtraParametersHandler:Com.Applovin.Mediation.Adapter.Parameters.IMaxAdapterParametersInvoker, AppLovin")] get; }

		// Token: 0x17000333 RID: 819
		// (get) Token: 0x06000B8C RID: 2956
		Bundle ServerParameters { [Register("getServerParameters", "()Landroid/os/Bundle;", "GetGetServerParametersHandler:Com.Applovin.Mediation.Adapter.Parameters.IMaxAdapterParametersInvoker, AppLovin")] get; }

		// Token: 0x06000B8D RID: 2957
		[Register("hasUserConsent", "()Ljava/lang/Boolean;", "GetHasUserConsentHandler:Com.Applovin.Mediation.Adapter.Parameters.IMaxAdapterParametersInvoker, AppLovin")]
		Java.Lang.Boolean HasUserConsent();

		// Token: 0x06000B8E RID: 2958
		[Register("isAgeRestrictedUser", "()Ljava/lang/Boolean;", "GetIsAgeRestrictedUserHandler:Com.Applovin.Mediation.Adapter.Parameters.IMaxAdapterParametersInvoker, AppLovin")]
		Java.Lang.Boolean IsAgeRestrictedUser();

		// Token: 0x06000B8F RID: 2959
		[Register("isDoNotSell", "()Ljava/lang/Boolean;", "GetIsDoNotSellHandler:Com.Applovin.Mediation.Adapter.Parameters.IMaxAdapterParametersInvoker, AppLovin")]
		Java.Lang.Boolean IsDoNotSell();
	}
}
