using System;

namespace Java.Interop
{
	// Token: 0x02000019 RID: 25
	internal class __TypeRegistrations
	{
		// Token: 0x0600005A RID: 90 RVA: 0x00002058 File Offset: 0x00000258
		public static void RegisterPackages()
		{
			TypeManager.RegisterPackages(new string[]
			{
				"com/google/android/datatransport/runtime/backends",
				"com/google/android/datatransport/runtime",
				"com/google/android/datatransport/runtime/dagger/internal",
				"com/google/android/datatransport/runtime/firebase/transport",
				"com/google/android/datatransport/runtime/logging",
				"com/google/android/datatransport/runtime/retries",
				"com/google/android/datatransport/runtime/scheduling",
				"com/google/android/datatransport/runtime/scheduling/jobscheduling",
				"com/google/android/datatransport/runtime/scheduling/persistence",
				"com/google/android/datatransport/runtime/synchronization",
				"com/google/android/datatransport/runtime/time",
				"com/google/android/datatransport/runtime/util"
			}, new Converter<string, Type>[]
			{
				new Converter<string, Type>(__TypeRegistrations.lookup_com_google_android_datatransport_runtime_backends_package),
				new Converter<string, Type>(__TypeRegistrations.lookup_com_google_android_datatransport_runtime_package),
				new Converter<string, Type>(__TypeRegistrations.lookup_com_google_android_datatransport_runtime_dagger_internal_package),
				new Converter<string, Type>(__TypeRegistrations.lookup_com_google_android_datatransport_runtime_firebase_transport_package),
				new Converter<string, Type>(__TypeRegistrations.lookup_com_google_android_datatransport_runtime_logging_package),
				new Converter<string, Type>(__TypeRegistrations.lookup_com_google_android_datatransport_runtime_retries_package),
				new Converter<string, Type>(__TypeRegistrations.lookup_com_google_android_datatransport_runtime_scheduling_package),
				new Converter<string, Type>(__TypeRegistrations.lookup_com_google_android_datatransport_runtime_scheduling_jobscheduling_package),
				new Converter<string, Type>(__TypeRegistrations.lookup_com_google_android_datatransport_runtime_scheduling_persistence_package),
				new Converter<string, Type>(__TypeRegistrations.lookup_com_google_android_datatransport_runtime_synchronization_package),
				new Converter<string, Type>(__TypeRegistrations.lookup_com_google_android_datatransport_runtime_time_package),
				new Converter<string, Type>(__TypeRegistrations.lookup_com_google_android_datatransport_runtime_util_package)
			});
		}

		// Token: 0x0600005B RID: 91 RVA: 0x00002194 File Offset: 0x00000394
		private static Type Lookup(string[] mappings, string javaType)
		{
			string text = TypeManager.LookupTypeMapping(mappings, javaType);
			if (text == null)
			{
				return null;
			}
			return Type.GetType(text);
		}

		// Token: 0x0600005C RID: 92 RVA: 0x000021B4 File Offset: 0x000003B4
		private static Type lookup_com_google_android_datatransport_runtime_backends_package(string klass)
		{
			if (__TypeRegistrations.package_com_google_android_datatransport_runtime_backends_mappings == null)
			{
				__TypeRegistrations.package_com_google_android_datatransport_runtime_backends_mappings = new string[]
				{
					"com/google/android/datatransport/runtime/backends/BackendRegistryModule:Xamarin.Google.Android.DataTransport.Runtime.Backends.BackendRegistryModule",
					"com/google/android/datatransport/runtime/backends/BackendRequest:Xamarin.Google.Android.DataTransport.Runtime.Backends.BackendRequest",
					"com/google/android/datatransport/runtime/backends/BackendRequest$Builder:Xamarin.Google.Android.DataTransport.Runtime.Backends.BackendRequest/Builder",
					"com/google/android/datatransport/runtime/backends/BackendResponse:Xamarin.Google.Android.DataTransport.Runtime.Backends.BackendResponse",
					"com/google/android/datatransport/runtime/backends/BackendResponse$Status:Xamarin.Google.Android.DataTransport.Runtime.Backends.BackendResponse/Status",
					"com/google/android/datatransport/runtime/backends/CreationContext:Xamarin.Google.Android.DataTransport.Runtime.Backends.CreationContext",
					"com/google/android/datatransport/runtime/backends/CreationContextFactory_Factory:Xamarin.Google.Android.DataTransport.Runtime.Backends.CreationContextFactory_Factory",
					"com/google/android/datatransport/runtime/backends/MetadataBackendRegistry_Factory:Xamarin.Google.Android.DataTransport.Runtime.Backends.MetadataBackendRegistry_Factory",
					"com/google/android/datatransport/runtime/backends/TransportBackendDiscovery:Xamarin.Google.Android.DataTransport.Runtime.Backends.TransportBackendDiscovery"
				};
			}
			return __TypeRegistrations.Lookup(__TypeRegistrations.package_com_google_android_datatransport_runtime_backends_mappings, klass);
		}

		// Token: 0x0600005D RID: 93 RVA: 0x00002228 File Offset: 0x00000428
		private static Type lookup_com_google_android_datatransport_runtime_package(string klass)
		{
			if (__TypeRegistrations.package_com_google_android_datatransport_runtime_mappings == null)
			{
				__TypeRegistrations.package_com_google_android_datatransport_runtime_mappings = new string[]
				{
					"com/google/android/datatransport/runtime/BuildConfig:Xamarin.Google.Android.DataTransport.Runtime.BuildConfig",
					"com/google/android/datatransport/runtime/EncodedPayload:Xamarin.Google.Android.DataTransport.Runtime.EncodedPayload",
					"com/google/android/datatransport/runtime/EventInternal:Xamarin.Google.Android.DataTransport.Runtime.EventInternal",
					"com/google/android/datatransport/runtime/EventInternal$Builder:Xamarin.Google.Android.DataTransport.Runtime.EventInternal/Builder",
					"com/google/android/datatransport/runtime/ExecutionModule_ExecutorFactory:Xamarin.Google.Android.DataTransport.Runtime.ExecutionModule_ExecutorFactory",
					"com/google/android/datatransport/runtime/ForcedSender:Xamarin.Google.Android.DataTransport.Runtime.ForcedSender",
					"com/google/android/datatransport/runtime/ProtoEncoderDoNotUse:Xamarin.Google.Android.DataTransport.Runtime.ProtoEncoderDoNotUse",
					"com/google/android/datatransport/runtime/TransportContext:Xamarin.Google.Android.DataTransport.Runtime.TransportContext",
					"com/google/android/datatransport/runtime/TransportContext$Builder:Xamarin.Google.Android.DataTransport.Runtime.TransportContext/Builder",
					"com/google/android/datatransport/runtime/TransportRuntime:Xamarin.Google.Android.DataTransport.Runtime.TransportRuntime",
					"com/google/android/datatransport/runtime/TransportRuntimeComponent:Xamarin.Google.Android.DataTransport.Runtime.TransportRuntimeComponent",
					"com/google/android/datatransport/runtime/TransportRuntime_Factory:Xamarin.Google.Android.DataTransport.Runtime.TransportRuntime_Factory"
				};
			}
			return __TypeRegistrations.Lookup(__TypeRegistrations.package_com_google_android_datatransport_runtime_mappings, klass);
		}

		// Token: 0x0600005E RID: 94 RVA: 0x000022B8 File Offset: 0x000004B8
		private static Type lookup_com_google_android_datatransport_runtime_dagger_internal_package(string klass)
		{
			if (__TypeRegistrations.package_com_google_android_datatransport_runtime_dagger_internal_mappings == null)
			{
				__TypeRegistrations.package_com_google_android_datatransport_runtime_dagger_internal_mappings = new string[]
				{
					"com/google/android/datatransport/runtime/dagger/internal/DaggerCollections:Xamarin.Google.Android.DataTransport.Runtime.Dagger.Internal.DaggerCollections",
					"com/google/android/datatransport/runtime/dagger/internal/DelegateFactory:Xamarin.Google.Android.DataTransport.Runtime.Dagger.Internal.DelegateFactory",
					"com/google/android/datatransport/runtime/dagger/internal/DoubleCheck:Xamarin.Google.Android.DataTransport.Runtime.Dagger.Internal.DoubleCheck",
					"com/google/android/datatransport/runtime/dagger/internal/InstanceFactory:Xamarin.Google.Android.DataTransport.Runtime.Dagger.Internal.InstanceFactory",
					"com/google/android/datatransport/runtime/dagger/internal/MapBuilder:Xamarin.Google.Android.DataTransport.Runtime.Dagger.Internal.MapBuilder",
					"com/google/android/datatransport/runtime/dagger/internal/MapFactory:Xamarin.Google.Android.DataTransport.Runtime.Dagger.Internal.MapFactory",
					"com/google/android/datatransport/runtime/dagger/internal/MapProviderFactory:Xamarin.Google.Android.DataTransport.Runtime.Dagger.Internal.MapProviderFactory",
					"com/google/android/datatransport/runtime/dagger/internal/MembersInjectors:Xamarin.Google.Android.DataTransport.Runtime.Dagger.Internal.MembersInjectors",
					"com/google/android/datatransport/runtime/dagger/internal/MemoizedSentinel:Xamarin.Google.Android.DataTransport.Runtime.Dagger.Internal.MemoizedSentinel",
					"com/google/android/datatransport/runtime/dagger/internal/Preconditions:Xamarin.Google.Android.DataTransport.Runtime.Dagger.Internal.Preconditions",
					"com/google/android/datatransport/runtime/dagger/internal/ProviderOfLazy:Xamarin.Google.Android.DataTransport.Runtime.Dagger.Internal.ProviderOfLazy",
					"com/google/android/datatransport/runtime/dagger/internal/SetBuilder:Xamarin.Google.Android.DataTransport.Runtime.Dagger.Internal.SetBuilder",
					"com/google/android/datatransport/runtime/dagger/internal/SetFactory:Xamarin.Google.Android.DataTransport.Runtime.Dagger.Internal.SetFactory",
					"com/google/android/datatransport/runtime/dagger/internal/SetFactory$Builder:Xamarin.Google.Android.DataTransport.Runtime.Dagger.Internal.SetFactory/Builder",
					"com/google/android/datatransport/runtime/dagger/internal/SingleCheck:Xamarin.Google.Android.DataTransport.Runtime.Dagger.Internal.SingleCheck"
				};
			}
			return __TypeRegistrations.Lookup(__TypeRegistrations.package_com_google_android_datatransport_runtime_dagger_internal_mappings, klass);
		}

		// Token: 0x0600005F RID: 95 RVA: 0x00002364 File Offset: 0x00000564
		private static Type lookup_com_google_android_datatransport_runtime_firebase_transport_package(string klass)
		{
			if (__TypeRegistrations.package_com_google_android_datatransport_runtime_firebase_transport_mappings == null)
			{
				__TypeRegistrations.package_com_google_android_datatransport_runtime_firebase_transport_mappings = new string[]
				{
					"com/google/android/datatransport/runtime/firebase/transport/ClientMetrics:Xamarin.Google.Android.DataTransport.Runtime.Firebase.Transport.ClientMetrics",
					"com/google/android/datatransport/runtime/firebase/transport/ClientMetrics$Builder:Xamarin.Google.Android.DataTransport.Runtime.Firebase.Transport.ClientMetrics/Builder",
					"com/google/android/datatransport/runtime/firebase/transport/GlobalMetrics:Xamarin.Google.Android.DataTransport.Runtime.Firebase.Transport.GlobalMetrics",
					"com/google/android/datatransport/runtime/firebase/transport/GlobalMetrics$Builder:Xamarin.Google.Android.DataTransport.Runtime.Firebase.Transport.GlobalMetrics/Builder",
					"com/google/android/datatransport/runtime/firebase/transport/LogEventDropped:Xamarin.Google.Android.DataTransport.Runtime.Firebase.Transport.LogEventDropped",
					"com/google/android/datatransport/runtime/firebase/transport/LogEventDropped$Builder:Xamarin.Google.Android.DataTransport.Runtime.Firebase.Transport.LogEventDropped/Builder",
					"com/google/android/datatransport/runtime/firebase/transport/LogEventDropped$Reason:Xamarin.Google.Android.DataTransport.Runtime.Firebase.Transport.LogEventDropped/Reason",
					"com/google/android/datatransport/runtime/firebase/transport/LogSourceMetrics:Xamarin.Google.Android.DataTransport.Runtime.Firebase.Transport.LogSourceMetrics",
					"com/google/android/datatransport/runtime/firebase/transport/LogSourceMetrics$Builder:Xamarin.Google.Android.DataTransport.Runtime.Firebase.Transport.LogSourceMetrics/Builder",
					"com/google/android/datatransport/runtime/firebase/transport/StorageMetrics:Xamarin.Google.Android.DataTransport.Runtime.Firebase.Transport.StorageMetrics",
					"com/google/android/datatransport/runtime/firebase/transport/StorageMetrics$Builder:Xamarin.Google.Android.DataTransport.Runtime.Firebase.Transport.StorageMetrics/Builder",
					"com/google/android/datatransport/runtime/firebase/transport/TimeWindow:Xamarin.Google.Android.DataTransport.Runtime.Firebase.Transport.TimeWindow",
					"com/google/android/datatransport/runtime/firebase/transport/TimeWindow$Builder:Xamarin.Google.Android.DataTransport.Runtime.Firebase.Transport.TimeWindow/Builder"
				};
			}
			return __TypeRegistrations.Lookup(__TypeRegistrations.package_com_google_android_datatransport_runtime_firebase_transport_mappings, klass);
		}

		// Token: 0x06000060 RID: 96 RVA: 0x000023FB File Offset: 0x000005FB
		private static Type lookup_com_google_android_datatransport_runtime_logging_package(string klass)
		{
			if (__TypeRegistrations.package_com_google_android_datatransport_runtime_logging_mappings == null)
			{
				__TypeRegistrations.package_com_google_android_datatransport_runtime_logging_mappings = new string[]
				{
					"com/google/android/datatransport/runtime/logging/Logging:Xamarin.Google.Android.DataTransport.Runtime.Logging.Logging"
				};
			}
			return __TypeRegistrations.Lookup(__TypeRegistrations.package_com_google_android_datatransport_runtime_logging_mappings, klass);
		}

		// Token: 0x06000061 RID: 97 RVA: 0x00002422 File Offset: 0x00000622
		private static Type lookup_com_google_android_datatransport_runtime_retries_package(string klass)
		{
			if (__TypeRegistrations.package_com_google_android_datatransport_runtime_retries_mappings == null)
			{
				__TypeRegistrations.package_com_google_android_datatransport_runtime_retries_mappings = new string[]
				{
					"com/google/android/datatransport/runtime/retries/Retries:Xamarin.Google.Android.DataTransport.Runtime.Retries.Retries"
				};
			}
			return __TypeRegistrations.Lookup(__TypeRegistrations.package_com_google_android_datatransport_runtime_retries_mappings, klass);
		}

		// Token: 0x06000062 RID: 98 RVA: 0x0000244C File Offset: 0x0000064C
		private static Type lookup_com_google_android_datatransport_runtime_scheduling_package(string klass)
		{
			if (__TypeRegistrations.package_com_google_android_datatransport_runtime_scheduling_mappings == null)
			{
				__TypeRegistrations.package_com_google_android_datatransport_runtime_scheduling_mappings = new string[]
				{
					"com/google/android/datatransport/runtime/scheduling/DefaultScheduler:Xamarin.Google.Android.DataTransport.Runtime.Scheduling.DefaultScheduler",
					"com/google/android/datatransport/runtime/scheduling/DefaultScheduler_Factory:Xamarin.Google.Android.DataTransport.Runtime.Scheduling.DefaultScheduler_Factory",
					"com/google/android/datatransport/runtime/scheduling/SchedulingConfigModule:Xamarin.Google.Android.DataTransport.Runtime.Scheduling.SchedulingConfigModule",
					"com/google/android/datatransport/runtime/scheduling/SchedulingConfigModule_ConfigFactory:Xamarin.Google.Android.DataTransport.Runtime.Scheduling.SchedulingConfigModule_ConfigFactory",
					"com/google/android/datatransport/runtime/scheduling/SchedulingModule:Xamarin.Google.Android.DataTransport.Runtime.Scheduling.SchedulingModule",
					"com/google/android/datatransport/runtime/scheduling/SchedulingModule_WorkSchedulerFactory:Xamarin.Google.Android.DataTransport.Runtime.Scheduling.SchedulingModule_WorkSchedulerFactory"
				};
			}
			return __TypeRegistrations.Lookup(__TypeRegistrations.package_com_google_android_datatransport_runtime_scheduling_mappings, klass);
		}

		// Token: 0x06000063 RID: 99 RVA: 0x000024A8 File Offset: 0x000006A8
		private static Type lookup_com_google_android_datatransport_runtime_scheduling_jobscheduling_package(string klass)
		{
			if (__TypeRegistrations.package_com_google_android_datatransport_runtime_scheduling_jobscheduling_mappings == null)
			{
				__TypeRegistrations.package_com_google_android_datatransport_runtime_scheduling_jobscheduling_mappings = new string[]
				{
					"com/google/android/datatransport/runtime/scheduling/jobscheduling/AlarmManagerScheduler:Xamarin.Google.Android.DataTransport.Runtime.Scheduling.JobScheduling.AlarmManagerScheduler",
					"com/google/android/datatransport/runtime/scheduling/jobscheduling/AlarmManagerSchedulerBroadcastReceiver:Xamarin.Google.Android.DataTransport.Runtime.Scheduling.JobScheduling.AlarmManagerSchedulerBroadcastReceiver",
					"com/google/android/datatransport/runtime/scheduling/jobscheduling/JobInfoScheduler:Xamarin.Google.Android.DataTransport.Runtime.Scheduling.JobScheduling.JobInfoScheduler",
					"com/google/android/datatransport/runtime/scheduling/jobscheduling/JobInfoSchedulerService:Xamarin.Google.Android.DataTransport.Runtime.Scheduling.JobScheduling.JobInfoSchedulerService",
					"com/google/android/datatransport/runtime/scheduling/jobscheduling/SchedulerConfig:Xamarin.Google.Android.DataTransport.Runtime.Scheduling.JobScheduling.SchedulerConfig",
					"com/google/android/datatransport/runtime/scheduling/jobscheduling/SchedulerConfig$Builder:Xamarin.Google.Android.DataTransport.Runtime.Scheduling.JobScheduling.SchedulerConfig/Builder",
					"com/google/android/datatransport/runtime/scheduling/jobscheduling/SchedulerConfig$ConfigValue:Xamarin.Google.Android.DataTransport.Runtime.Scheduling.JobScheduling.SchedulerConfig/ConfigValue",
					"com/google/android/datatransport/runtime/scheduling/jobscheduling/SchedulerConfig$ConfigValue$Builder:Xamarin.Google.Android.DataTransport.Runtime.Scheduling.JobScheduling.SchedulerConfig/ConfigValue/Builder",
					"com/google/android/datatransport/runtime/scheduling/jobscheduling/SchedulerConfig$Flag:Xamarin.Google.Android.DataTransport.Runtime.Scheduling.JobScheduling.SchedulerConfig/Flag",
					"com/google/android/datatransport/runtime/scheduling/jobscheduling/Uploader:Xamarin.Google.Android.DataTransport.Runtime.Scheduling.JobScheduling.Uploader",
					"com/google/android/datatransport/runtime/scheduling/jobscheduling/Uploader_Factory:Xamarin.Google.Android.DataTransport.Runtime.Scheduling.JobScheduling.Uploader_Factory",
					"com/google/android/datatransport/runtime/scheduling/jobscheduling/WorkInitializer:Xamarin.Google.Android.DataTransport.Runtime.Scheduling.JobScheduling.WorkInitializer",
					"com/google/android/datatransport/runtime/scheduling/jobscheduling/WorkInitializer_Factory:Xamarin.Google.Android.DataTransport.Runtime.Scheduling.JobScheduling.WorkInitializer_Factory"
				};
			}
			return __TypeRegistrations.Lookup(__TypeRegistrations.package_com_google_android_datatransport_runtime_scheduling_jobscheduling_mappings, klass);
		}

		// Token: 0x06000064 RID: 100 RVA: 0x00002540 File Offset: 0x00000740
		private static Type lookup_com_google_android_datatransport_runtime_scheduling_persistence_package(string klass)
		{
			if (__TypeRegistrations.package_com_google_android_datatransport_runtime_scheduling_persistence_mappings == null)
			{
				__TypeRegistrations.package_com_google_android_datatransport_runtime_scheduling_persistence_mappings = new string[]
				{
					"com/google/android/datatransport/runtime/scheduling/persistence/EventStoreModule:Xamarin.Google.Android.DataTransport.Runtime.Persistence.EventStoreModule",
					"com/google/android/datatransport/runtime/scheduling/persistence/EventStoreModule_DbNameFactory:Xamarin.Google.Android.DataTransport.Runtime.Persistence.EventStoreModule_DbNameFactory",
					"com/google/android/datatransport/runtime/scheduling/persistence/EventStoreModule_PackageNameFactory:Xamarin.Google.Android.DataTransport.Runtime.Persistence.EventStoreModule_PackageNameFactory",
					"com/google/android/datatransport/runtime/scheduling/persistence/EventStoreModule_SchemaVersionFactory:Xamarin.Google.Android.DataTransport.Runtime.Persistence.EventStoreModule_SchemaVersionFactory",
					"com/google/android/datatransport/runtime/scheduling/persistence/EventStoreModule_StoreConfigFactory:Xamarin.Google.Android.DataTransport.Runtime.Persistence.EventStoreModule_StoreConfigFactory",
					"com/google/android/datatransport/runtime/scheduling/persistence/PersistedEvent:Xamarin.Google.Android.DataTransport.Runtime.Persistence.PersistedEvent",
					"com/google/android/datatransport/runtime/scheduling/persistence/SQLiteEventStore:Xamarin.Google.Android.DataTransport.Runtime.Persistence.SQLiteEventStore",
					"com/google/android/datatransport/runtime/scheduling/persistence/SQLiteEventStore_Factory:Xamarin.Google.Android.DataTransport.Runtime.Persistence.SQLiteEventStore_Factory",
					"com/google/android/datatransport/runtime/scheduling/persistence/SchemaManager_Factory:Xamarin.Google.Android.DataTransport.Runtime.Persistence.SchemaManager_Factory"
				};
			}
			return __TypeRegistrations.Lookup(__TypeRegistrations.package_com_google_android_datatransport_runtime_scheduling_persistence_mappings, klass);
		}

		// Token: 0x06000065 RID: 101 RVA: 0x000025B3 File Offset: 0x000007B3
		private static Type lookup_com_google_android_datatransport_runtime_synchronization_package(string klass)
		{
			if (__TypeRegistrations.package_com_google_android_datatransport_runtime_synchronization_mappings == null)
			{
				__TypeRegistrations.package_com_google_android_datatransport_runtime_synchronization_mappings = new string[]
				{
					"com/google/android/datatransport/runtime/synchronization/SynchronizationException:Xamarin.Google.Android.DataTransport.Runtime.Synchronization.SynchronizationException"
				};
			}
			return __TypeRegistrations.Lookup(__TypeRegistrations.package_com_google_android_datatransport_runtime_synchronization_mappings, klass);
		}

		// Token: 0x06000066 RID: 102 RVA: 0x000025DC File Offset: 0x000007DC
		private static Type lookup_com_google_android_datatransport_runtime_time_package(string klass)
		{
			if (__TypeRegistrations.package_com_google_android_datatransport_runtime_time_mappings == null)
			{
				__TypeRegistrations.package_com_google_android_datatransport_runtime_time_mappings = new string[]
				{
					"com/google/android/datatransport/runtime/time/TestClock:Xamarin.Google.Android.DataTransport.Runtime.Time.TestClock",
					"com/google/android/datatransport/runtime/time/TimeModule:Xamarin.Google.Android.DataTransport.Runtime.Time.TimeModule",
					"com/google/android/datatransport/runtime/time/TimeModule_EventClockFactory:Xamarin.Google.Android.DataTransport.Runtime.Time.TimeModule_EventClockFactory",
					"com/google/android/datatransport/runtime/time/TimeModule_UptimeClockFactory:Xamarin.Google.Android.DataTransport.Runtime.Time.TimeModule_UptimeClockFactory",
					"com/google/android/datatransport/runtime/time/UptimeClock:Xamarin.Google.Android.DataTransport.Runtime.Time.UptimeClock",
					"com/google/android/datatransport/runtime/time/WallTimeClock:Xamarin.Google.Android.DataTransport.Runtime.Time.WallTimeClock"
				};
			}
			return __TypeRegistrations.Lookup(__TypeRegistrations.package_com_google_android_datatransport_runtime_time_mappings, klass);
		}

		// Token: 0x06000067 RID: 103 RVA: 0x00002636 File Offset: 0x00000836
		private static Type lookup_com_google_android_datatransport_runtime_util_package(string klass)
		{
			if (__TypeRegistrations.package_com_google_android_datatransport_runtime_util_mappings == null)
			{
				__TypeRegistrations.package_com_google_android_datatransport_runtime_util_mappings = new string[]
				{
					"com/google/android/datatransport/runtime/util/PriorityMapping:Xamarin.Google.Android.DataTransport.Runtime.Util.PriorityMapping"
				};
			}
			return __TypeRegistrations.Lookup(__TypeRegistrations.package_com_google_android_datatransport_runtime_util_mappings, klass);
		}

		// Token: 0x04000001 RID: 1
		private static string[] package_com_google_android_datatransport_runtime_backends_mappings;

		// Token: 0x04000002 RID: 2
		private static string[] package_com_google_android_datatransport_runtime_mappings;

		// Token: 0x04000003 RID: 3
		private static string[] package_com_google_android_datatransport_runtime_dagger_internal_mappings;

		// Token: 0x04000004 RID: 4
		private static string[] package_com_google_android_datatransport_runtime_firebase_transport_mappings;

		// Token: 0x04000005 RID: 5
		private static string[] package_com_google_android_datatransport_runtime_logging_mappings;

		// Token: 0x04000006 RID: 6
		private static string[] package_com_google_android_datatransport_runtime_retries_mappings;

		// Token: 0x04000007 RID: 7
		private static string[] package_com_google_android_datatransport_runtime_scheduling_mappings;

		// Token: 0x04000008 RID: 8
		private static string[] package_com_google_android_datatransport_runtime_scheduling_jobscheduling_mappings;

		// Token: 0x04000009 RID: 9
		private static string[] package_com_google_android_datatransport_runtime_scheduling_persistence_mappings;

		// Token: 0x0400000A RID: 10
		private static string[] package_com_google_android_datatransport_runtime_synchronization_mappings;

		// Token: 0x0400000B RID: 11
		private static string[] package_com_google_android_datatransport_runtime_time_mappings;

		// Token: 0x0400000C RID: 12
		private static string[] package_com_google_android_datatransport_runtime_util_mappings;
	}
}
