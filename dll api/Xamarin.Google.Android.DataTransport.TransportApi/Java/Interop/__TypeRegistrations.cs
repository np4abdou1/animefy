using System;

namespace Java.Interop
{
	// Token: 0x02000016 RID: 22
	internal class __TypeRegistrations
	{
		// Token: 0x0600008D RID: 141 RVA: 0x000032E7 File Offset: 0x000014E7
		public static void RegisterPackages()
		{
			TypeManager.RegisterPackages(new string[]
			{
				"com/google/android/datatransport"
			}, new Converter<string, Type>[]
			{
				new Converter<string, Type>(__TypeRegistrations.lookup_com_google_android_datatransport_package)
			});
		}

		// Token: 0x0600008E RID: 142 RVA: 0x00003314 File Offset: 0x00001514
		private static Type Lookup(string[] mappings, string javaType)
		{
			string text = TypeManager.LookupTypeMapping(mappings, javaType);
			if (text == null)
			{
				return null;
			}
			return Type.GetType(text);
		}

		// Token: 0x0600008F RID: 143 RVA: 0x00003334 File Offset: 0x00001534
		private static Type lookup_com_google_android_datatransport_package(string klass)
		{
			if (__TypeRegistrations.package_com_google_android_datatransport_mappings == null)
			{
				__TypeRegistrations.package_com_google_android_datatransport_mappings = new string[]
				{
					"com/google/android/datatransport/BuildConfig:Xamarin.Google.Android.DataTransport.BuildConfig",
					"com/google/android/datatransport/Encoding:Xamarin.Google.Android.DataTransport.Encoding",
					"com/google/android/datatransport/Event:Xamarin.Google.Android.DataTransport.Event",
					"com/google/android/datatransport/Priority:Xamarin.Google.Android.DataTransport.Priority"
				};
			}
			return __TypeRegistrations.Lookup(__TypeRegistrations.package_com_google_android_datatransport_mappings, klass);
		}

		// Token: 0x04000023 RID: 35
		private static string[] package_com_google_android_datatransport_mappings;
	}
}
