using System;

namespace Java.Interop
{
	// Token: 0x02000037 RID: 55
	internal class __TypeRegistrations
	{
		// Token: 0x0600013D RID: 317 RVA: 0x00004618 File Offset: 0x00002818
		public static void RegisterPackages()
		{
			TypeManager.RegisterPackages(new string[]
			{
				"com/google/android/ump"
			}, new Converter<string, Type>[]
			{
				new Converter<string, Type>(__TypeRegistrations.lookup_com_google_android_ump_package)
			});
		}

		// Token: 0x0600013E RID: 318 RVA: 0x00004644 File Offset: 0x00002844
		private static Type Lookup(string[] mappings, string javaType)
		{
			string text = TypeManager.LookupTypeMapping(mappings, javaType);
			if (text == null)
			{
				return null;
			}
			return Type.GetType(text);
		}

		// Token: 0x0600013F RID: 319 RVA: 0x00004664 File Offset: 0x00002864
		private static Type lookup_com_google_android_ump_package(string klass)
		{
			if (__TypeRegistrations.package_com_google_android_ump_mappings == null)
			{
				__TypeRegistrations.package_com_google_android_ump_mappings = new string[]
				{
					"com/google/android/ump/ConsentDebugSettings:Xamarin.Google.UserMesssagingPlatform.ConsentDebugSettings",
					"com/google/android/ump/ConsentDebugSettings$Builder:Xamarin.Google.UserMesssagingPlatform.ConsentDebugSettings/Builder",
					"com/google/android/ump/ConsentRequestParameters:Xamarin.Google.UserMesssagingPlatform.ConsentRequestParameters",
					"com/google/android/ump/ConsentRequestParameters$Builder:Xamarin.Google.UserMesssagingPlatform.ConsentRequestParameters/Builder",
					"com/google/android/ump/FormError:Xamarin.Google.UserMesssagingPlatform.FormError",
					"com/google/android/ump/UserMessagingPlatform:Xamarin.Google.UserMesssagingPlatform.UserMessagingPlatform"
				};
			}
			return __TypeRegistrations.Lookup(__TypeRegistrations.package_com_google_android_ump_mappings, klass);
		}

		// Token: 0x0400006A RID: 106
		private static string[] package_com_google_android_ump_mappings;
	}
}
