using System;

namespace Java.Interop
{
	// Token: 0x02000028 RID: 40
	internal class __TypeRegistrations
	{
		// Token: 0x06000223 RID: 547 RVA: 0x00006874 File Offset: 0x00004A74
		public static void RegisterPackages()
		{
			TypeManager.RegisterPackages(new string[]
			{
				"com/google/android/datatransport/backend/cct",
				"com/google/android/datatransport/cct",
				"com/google/android/datatransport/cct/internal"
			}, new Converter<string, Type>[]
			{
				new Converter<string, Type>(__TypeRegistrations.lookup_com_google_android_datatransport_backend_cct_package),
				new Converter<string, Type>(__TypeRegistrations.lookup_com_google_android_datatransport_cct_package),
				new Converter<string, Type>(__TypeRegistrations.lookup_com_google_android_datatransport_cct_internal_package)
			});
		}

		// Token: 0x06000224 RID: 548 RVA: 0x000068D8 File Offset: 0x00004AD8
		private static Type Lookup(string[] mappings, string javaType)
		{
			string text = TypeManager.LookupTypeMapping(mappings, javaType);
			if (text == null)
			{
				return null;
			}
			return Type.GetType(text);
		}

		// Token: 0x06000225 RID: 549 RVA: 0x000068F8 File Offset: 0x00004AF8
		private static Type lookup_com_google_android_datatransport_backend_cct_package(string klass)
		{
			if (__TypeRegistrations.package_com_google_android_datatransport_backend_cct_mappings == null)
			{
				__TypeRegistrations.package_com_google_android_datatransport_backend_cct_mappings = new string[]
				{
					"com/google/android/datatransport/backend/cct/BuildConfig:Xamarin.Google.Android.DataTransport.Backend.Cct.BuildConfig"
				};
			}
			return __TypeRegistrations.Lookup(__TypeRegistrations.package_com_google_android_datatransport_backend_cct_mappings, klass);
		}

		// Token: 0x06000226 RID: 550 RVA: 0x0000691F File Offset: 0x00004B1F
		private static Type lookup_com_google_android_datatransport_cct_package(string klass)
		{
			if (__TypeRegistrations.package_com_google_android_datatransport_cct_mappings == null)
			{
				__TypeRegistrations.package_com_google_android_datatransport_cct_mappings = new string[]
				{
					"com/google/android/datatransport/cct/CCTDestination:Xamarin.Google.Android.DataTransport.Cct.CCTDestination",
					"com/google/android/datatransport/cct/CctBackendFactory:Xamarin.Google.Android.DataTransport.Cct.CctBackendFactory",
					"com/google/android/datatransport/cct/StringMerger:Xamarin.Google.Android.DataTransport.Cct.StringMerger"
				};
			}
			return __TypeRegistrations.Lookup(__TypeRegistrations.package_com_google_android_datatransport_cct_mappings, klass);
		}

		// Token: 0x06000227 RID: 551 RVA: 0x00006958 File Offset: 0x00004B58
		private static Type lookup_com_google_android_datatransport_cct_internal_package(string klass)
		{
			if (__TypeRegistrations.package_com_google_android_datatransport_cct_internal_mappings == null)
			{
				__TypeRegistrations.package_com_google_android_datatransport_cct_internal_mappings = new string[]
				{
					"com/google/android/datatransport/cct/internal/AndroidClientInfo:Xamarin.Google.Android.DataTransport.Cct.Internal.AndroidClientInfo",
					"com/google/android/datatransport/cct/internal/AndroidClientInfo$Builder:Xamarin.Google.Android.DataTransport.Cct.Internal.AndroidClientInfo/Builder",
					"com/google/android/datatransport/cct/internal/BatchedLogRequest:Xamarin.Google.Android.DataTransport.Cct.Internal.BatchedLogRequest",
					"com/google/android/datatransport/cct/internal/ClientInfo:Xamarin.Google.Android.DataTransport.Cct.Internal.ClientInfo",
					"com/google/android/datatransport/cct/internal/ClientInfo$Builder:Xamarin.Google.Android.DataTransport.Cct.Internal.ClientInfo/Builder",
					"com/google/android/datatransport/cct/internal/ClientInfo$ClientType:Xamarin.Google.Android.DataTransport.Cct.Internal.ClientInfo/ClientType",
					"com/google/android/datatransport/cct/internal/LogEvent:Xamarin.Google.Android.DataTransport.Cct.Internal.LogEvent",
					"com/google/android/datatransport/cct/internal/LogEvent$Builder:Xamarin.Google.Android.DataTransport.Cct.Internal.LogEvent/Builder",
					"com/google/android/datatransport/cct/internal/LogRequest:Xamarin.Google.Android.DataTransport.Cct.Internal.LogRequest",
					"com/google/android/datatransport/cct/internal/LogRequest$Builder:Xamarin.Google.Android.DataTransport.Cct.Internal.LogRequest/Builder",
					"com/google/android/datatransport/cct/internal/LogResponse:Xamarin.Google.Android.DataTransport.Cct.Internal.LogResponse",
					"com/google/android/datatransport/cct/internal/NetworkConnectionInfo:Xamarin.Google.Android.DataTransport.Cct.Internal.NetworkConnectionInfo",
					"com/google/android/datatransport/cct/internal/NetworkConnectionInfo$Builder:Xamarin.Google.Android.DataTransport.Cct.Internal.NetworkConnectionInfo/Builder",
					"com/google/android/datatransport/cct/internal/NetworkConnectionInfo$MobileSubtype:Xamarin.Google.Android.DataTransport.Cct.Internal.NetworkConnectionInfo/MobileSubtype",
					"com/google/android/datatransport/cct/internal/NetworkConnectionInfo$NetworkType:Xamarin.Google.Android.DataTransport.Cct.Internal.NetworkConnectionInfo/NetworkType",
					"com/google/android/datatransport/cct/internal/QosTier:Xamarin.Google.Android.DataTransport.Cct.Internal.QosTier"
				};
			}
			return __TypeRegistrations.Lookup(__TypeRegistrations.package_com_google_android_datatransport_cct_internal_mappings, klass);
		}

		// Token: 0x04000067 RID: 103
		private static string[] package_com_google_android_datatransport_backend_cct_mappings;

		// Token: 0x04000068 RID: 104
		private static string[] package_com_google_android_datatransport_cct_mappings;

		// Token: 0x04000069 RID: 105
		private static string[] package_com_google_android_datatransport_cct_internal_mappings;
	}
}
