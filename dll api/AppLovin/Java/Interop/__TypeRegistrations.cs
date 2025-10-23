using System;

namespace Java.Interop
{
	// Token: 0x0200002E RID: 46
	internal class __TypeRegistrations
	{
		// Token: 0x060000A6 RID: 166 RVA: 0x00002090 File Offset: 0x00000290
		public static void RegisterPackages()
		{
			TypeManager.RegisterPackages(new string[]
			{
				"com/applovin/mediation/adapter",
				"com/applovin/mediation",
				"com/applovin/sdk"
			}, new Converter<string, Type>[]
			{
				new Converter<string, Type>(__TypeRegistrations.lookup_com_applovin_mediation_adapter_package),
				new Converter<string, Type>(__TypeRegistrations.lookup_com_applovin_mediation_package),
				new Converter<string, Type>(__TypeRegistrations.lookup_com_applovin_sdk_package)
			});
		}

		// Token: 0x060000A7 RID: 167 RVA: 0x000020F4 File Offset: 0x000002F4
		private static Type Lookup(string[] mappings, string javaType)
		{
			string text = TypeManager.LookupTypeMapping(mappings, javaType);
			if (text == null)
			{
				return null;
			}
			return Type.GetType(text);
		}

		// Token: 0x060000A8 RID: 168 RVA: 0x00002114 File Offset: 0x00000314
		private static Type lookup_com_applovin_mediation_adapter_package(string klass)
		{
			if (__TypeRegistrations.package_com_applovin_mediation_adapter_mappings == null)
			{
				__TypeRegistrations.package_com_applovin_mediation_adapter_mappings = new string[]
				{
					"com/applovin/mediation/adapter/MaxAdapter$InitializationStatus:Com.Applovin.Mediation.Adapter.MaxAdapterInitializationStatus"
				};
			}
			return __TypeRegistrations.Lookup(__TypeRegistrations.package_com_applovin_mediation_adapter_mappings, klass);
		}

		// Token: 0x060000A9 RID: 169 RVA: 0x0000213B File Offset: 0x0000033B
		private static Type lookup_com_applovin_mediation_package(string klass)
		{
			if (__TypeRegistrations.package_com_applovin_mediation_mappings == null)
			{
				__TypeRegistrations.package_com_applovin_mediation_mappings = new string[]
				{
					"com/applovin/mediation/MaxNetworkResponseInfo$AdLoadState:Com.Applovin.Mediation.MaxNetworkResponseInfoAdLoadState"
				};
			}
			return __TypeRegistrations.Lookup(__TypeRegistrations.package_com_applovin_mediation_mappings, klass);
		}

		// Token: 0x060000AA RID: 170 RVA: 0x00002162 File Offset: 0x00000362
		private static Type lookup_com_applovin_sdk_package(string klass)
		{
			if (__TypeRegistrations.package_com_applovin_sdk_mappings == null)
			{
				__TypeRegistrations.package_com_applovin_sdk_mappings = new string[]
				{
					"com/applovin/sdk/AppLovinSdkConfiguration$ConsentDialogState:Com.Applovin.Sdk.AppLovinSdkConfigurationConsentDialogState"
				};
			}
			return __TypeRegistrations.Lookup(__TypeRegistrations.package_com_applovin_sdk_mappings, klass);
		}

		// Token: 0x04000003 RID: 3
		private static string[] package_com_applovin_mediation_adapter_mappings;

		// Token: 0x04000004 RID: 4
		private static string[] package_com_applovin_mediation_mappings;

		// Token: 0x04000005 RID: 5
		private static string[] package_com_applovin_sdk_mappings;
	}
}
