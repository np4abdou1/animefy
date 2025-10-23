using System;
using System.Runtime.CompilerServices;

namespace Java.Interop
{
	// Token: 0x020000E5 RID: 229
	[NullableContext(1)]
	[Nullable(0)]
	internal class __TypeRegistrations
	{
		// Token: 0x06000AA6 RID: 2726 RVA: 0x000260EC File Offset: 0x000242EC
		public static void RegisterPackages()
		{
			string[] packages = new string[]
			{
				"kotlinx/coroutines",
				"kotlinx/coroutines/channels",
				"kotlinx/coroutines/flow",
				"kotlinx/coroutines/future",
				"kotlinx/coroutines/intrinsics",
				"kotlinx/coroutines/scheduling",
				"kotlinx/coroutines/selects",
				"kotlinx/coroutines/stream",
				"kotlinx/coroutines/sync",
				"kotlinx/coroutines/time"
			};
			Converter<string, Type>[] array = new Converter<string, Type>[10];
			int num = 0;
			Converter<string, Type> converter;
			if ((converter = __TypeRegistrations.<>O.<0>__lookup_kotlinx_coroutines_package) == null)
			{
				converter = (__TypeRegistrations.<>O.<0>__lookup_kotlinx_coroutines_package = new Converter<string, Type>(__TypeRegistrations.lookup_kotlinx_coroutines_package));
			}
			array[num] = converter;
			int num2 = 1;
			Converter<string, Type> converter2;
			if ((converter2 = __TypeRegistrations.<>O.<1>__lookup_kotlinx_coroutines_channels_package) == null)
			{
				converter2 = (__TypeRegistrations.<>O.<1>__lookup_kotlinx_coroutines_channels_package = new Converter<string, Type>(__TypeRegistrations.lookup_kotlinx_coroutines_channels_package));
			}
			array[num2] = converter2;
			int num3 = 2;
			Converter<string, Type> converter3;
			if ((converter3 = __TypeRegistrations.<>O.<2>__lookup_kotlinx_coroutines_flow_package) == null)
			{
				converter3 = (__TypeRegistrations.<>O.<2>__lookup_kotlinx_coroutines_flow_package = new Converter<string, Type>(__TypeRegistrations.lookup_kotlinx_coroutines_flow_package));
			}
			array[num3] = converter3;
			int num4 = 3;
			Converter<string, Type> converter4;
			if ((converter4 = __TypeRegistrations.<>O.<3>__lookup_kotlinx_coroutines_future_package) == null)
			{
				converter4 = (__TypeRegistrations.<>O.<3>__lookup_kotlinx_coroutines_future_package = new Converter<string, Type>(__TypeRegistrations.lookup_kotlinx_coroutines_future_package));
			}
			array[num4] = converter4;
			int num5 = 4;
			Converter<string, Type> converter5;
			if ((converter5 = __TypeRegistrations.<>O.<4>__lookup_kotlinx_coroutines_intrinsics_package) == null)
			{
				converter5 = (__TypeRegistrations.<>O.<4>__lookup_kotlinx_coroutines_intrinsics_package = new Converter<string, Type>(__TypeRegistrations.lookup_kotlinx_coroutines_intrinsics_package));
			}
			array[num5] = converter5;
			int num6 = 5;
			Converter<string, Type> converter6;
			if ((converter6 = __TypeRegistrations.<>O.<5>__lookup_kotlinx_coroutines_scheduling_package) == null)
			{
				converter6 = (__TypeRegistrations.<>O.<5>__lookup_kotlinx_coroutines_scheduling_package = new Converter<string, Type>(__TypeRegistrations.lookup_kotlinx_coroutines_scheduling_package));
			}
			array[num6] = converter6;
			int num7 = 6;
			Converter<string, Type> converter7;
			if ((converter7 = __TypeRegistrations.<>O.<6>__lookup_kotlinx_coroutines_selects_package) == null)
			{
				converter7 = (__TypeRegistrations.<>O.<6>__lookup_kotlinx_coroutines_selects_package = new Converter<string, Type>(__TypeRegistrations.lookup_kotlinx_coroutines_selects_package));
			}
			array[num7] = converter7;
			int num8 = 7;
			Converter<string, Type> converter8;
			if ((converter8 = __TypeRegistrations.<>O.<7>__lookup_kotlinx_coroutines_stream_package) == null)
			{
				converter8 = (__TypeRegistrations.<>O.<7>__lookup_kotlinx_coroutines_stream_package = new Converter<string, Type>(__TypeRegistrations.lookup_kotlinx_coroutines_stream_package));
			}
			array[num8] = converter8;
			int num9 = 8;
			Converter<string, Type> converter9;
			if ((converter9 = __TypeRegistrations.<>O.<8>__lookup_kotlinx_coroutines_sync_package) == null)
			{
				converter9 = (__TypeRegistrations.<>O.<8>__lookup_kotlinx_coroutines_sync_package = new Converter<string, Type>(__TypeRegistrations.lookup_kotlinx_coroutines_sync_package));
			}
			array[num9] = converter9;
			int num10 = 9;
			Converter<string, Type> converter10;
			if ((converter10 = __TypeRegistrations.<>O.<9>__lookup_kotlinx_coroutines_time_package) == null)
			{
				converter10 = (__TypeRegistrations.<>O.<9>__lookup_kotlinx_coroutines_time_package = new Converter<string, Type>(__TypeRegistrations.lookup_kotlinx_coroutines_time_package));
			}
			array[num10] = converter10;
			TypeManager.RegisterPackages(packages, array);
		}

		// Token: 0x06000AA7 RID: 2727 RVA: 0x0002628C File Offset: 0x0002448C
		[return: Nullable(2)]
		private static Type Lookup(string[] mappings, string javaType)
		{
			string text = TypeManager.LookupTypeMapping(mappings, javaType);
			if (text == null)
			{
				return null;
			}
			return Type.GetType(text);
		}

		// Token: 0x06000AA8 RID: 2728 RVA: 0x000262AC File Offset: 0x000244AC
		[return: Nullable(2)]
		private static Type lookup_kotlinx_coroutines_package(string klass)
		{
			if (__TypeRegistrations.package_kotlinx_coroutines_mappings == null)
			{
				__TypeRegistrations.package_kotlinx_coroutines_mappings = new string[]
				{
					"kotlinx/coroutines/AbstractTimeSourceKt:Xamarin.KotlinX.Coroutines.AbstractTimeSourceKt",
					"kotlinx/coroutines/AwaitKt:Xamarin.KotlinX.Coroutines.AwaitKt",
					"kotlinx/coroutines/BuildersKt:Xamarin.KotlinX.Coroutines.BuildersKt",
					"kotlinx/coroutines/CancellableContinuation$DefaultImpls:Xamarin.KotlinX.Coroutines.CancellableContinuationDefaultImpls",
					"kotlinx/coroutines/CancellableContinuationImplKt:Xamarin.KotlinX.Coroutines.CancellableContinuationImplKt",
					"kotlinx/coroutines/CancellableContinuationKt:Xamarin.KotlinX.Coroutines.CancellableContinuationKt",
					"kotlinx/coroutines/ChildHandle$DefaultImpls:Xamarin.KotlinX.Coroutines.ChildHandleDefaultImpls",
					"kotlinx/coroutines/ChildJob$DefaultImpls:Xamarin.KotlinX.Coroutines.ChildJobDefaultImpls",
					"kotlinx/coroutines/CompletableDeferred$DefaultImpls:Xamarin.KotlinX.Coroutines.CompletableDeferredDefaultImpls",
					"kotlinx/coroutines/CompletableDeferredKt:Xamarin.KotlinX.Coroutines.CompletableDeferredKt",
					"kotlinx/coroutines/CompletableJob$DefaultImpls:Xamarin.KotlinX.Coroutines.CompletableJobDefaultImpls",
					"kotlinx/coroutines/CompletionHandlerException:Xamarin.KotlinX.Coroutines.CompletionHandlerException",
					"kotlinx/coroutines/CompletionHandlerKt:Xamarin.KotlinX.Coroutines.CompletionHandlerKt",
					"kotlinx/coroutines/CompletionHandler_commonKt:Xamarin.KotlinX.Coroutines.CompletionHandler_commonKt",
					"kotlinx/coroutines/CompletionStateKt:Xamarin.KotlinX.Coroutines.CompletionStateKt",
					"kotlinx/coroutines/CopyableThreadContextElement$DefaultImpls:Xamarin.KotlinX.Coroutines.CopyableThreadContextElementDefaultImpls",
					"kotlinx/coroutines/CoroutineContextKt:Xamarin.KotlinX.Coroutines.CoroutineContextKt",
					"kotlinx/coroutines/CoroutineDispatcher:Xamarin.KotlinX.Coroutines.CoroutineDispatcher",
					"kotlinx/coroutines/CoroutineExceptionHandler$DefaultImpls:Xamarin.KotlinX.Coroutines.CoroutineExceptionHandlerDefaultImpls",
					"kotlinx/coroutines/CoroutineExceptionHandler$Key:Xamarin.KotlinX.Coroutines.CoroutineExceptionHandlerKey",
					"kotlinx/coroutines/CoroutineExceptionHandlerKt:Xamarin.KotlinX.Coroutines.CoroutineExceptionHandlerKt",
					"kotlinx/coroutines/CoroutineName:Xamarin.KotlinX.Coroutines.CoroutineName",
					"kotlinx/coroutines/CoroutineName$Key:Xamarin.KotlinX.Coroutines.CoroutineName/Key",
					"kotlinx/coroutines/CoroutineScopeKt:Xamarin.KotlinX.Coroutines.CoroutineScopeKt",
					"kotlinx/coroutines/CoroutineStart:Xamarin.KotlinX.Coroutines.CoroutineStart",
					"kotlinx/coroutines/CoroutineStart$WhenMappings:Xamarin.KotlinX.Coroutines.CoroutineStart/WhenMappings",
					"kotlinx/coroutines/DebugKt:Xamarin.KotlinX.Coroutines.DebugKt",
					"kotlinx/coroutines/DebugStringsKt:Xamarin.KotlinX.Coroutines.DebugStringsKt",
					"kotlinx/coroutines/DefaultExecutorKt:Xamarin.KotlinX.Coroutines.DefaultExecutorKt",
					"kotlinx/coroutines/Deferred$DefaultImpls:Xamarin.KotlinX.Coroutines.DeferredDefaultImpls",
					"kotlinx/coroutines/Delay$DefaultImpls:Xamarin.KotlinX.Coroutines.DelayDefaultImpls",
					"kotlinx/coroutines/DelayKt:Xamarin.KotlinX.Coroutines.DelayKt",
					"kotlinx/coroutines/DispatchedTaskKt:Xamarin.KotlinX.Coroutines.DispatchedTaskKt",
					"kotlinx/coroutines/Dispatchers:Xamarin.KotlinX.Coroutines.Dispatchers",
					"kotlinx/coroutines/DispatchersKt:Xamarin.KotlinX.Coroutines.DispatchersKt",
					"kotlinx/coroutines/EventLoopKt:Xamarin.KotlinX.Coroutines.EventLoopKt",
					"kotlinx/coroutines/EventLoop_commonKt:Xamarin.KotlinX.Coroutines.EventLoop_commonKt",
					"kotlinx/coroutines/ExceptionsKt:Xamarin.KotlinX.Coroutines.ExceptionsKt",
					"kotlinx/coroutines/ExecutorCoroutineDispatcher:Xamarin.KotlinX.Coroutines.ExecutorCoroutineDispatcher",
					"kotlinx/coroutines/ExecutorsKt:Xamarin.KotlinX.Coroutines.ExecutorsKt",
					"kotlinx/coroutines/GlobalScope:Xamarin.KotlinX.Coroutines.GlobalScope",
					"kotlinx/coroutines/InterruptibleKt:Xamarin.KotlinX.Coroutines.InterruptibleKt",
					"kotlinx/coroutines/Job$DefaultImpls:Xamarin.KotlinX.Coroutines.JobDefaultImpls",
					"kotlinx/coroutines/Job$Key:Xamarin.KotlinX.Coroutines.JobKey",
					"kotlinx/coroutines/JobKt:Xamarin.KotlinX.Coroutines.JobKt",
					"kotlinx/coroutines/JobSupport:Xamarin.KotlinX.Coroutines.JobSupport",
					"kotlinx/coroutines/JobSupportKt:Xamarin.KotlinX.Coroutines.JobSupportKt",
					"kotlinx/coroutines/MainCoroutineDispatcher:Xamarin.KotlinX.Coroutines.MainCoroutineDispatcher",
					"kotlinx/coroutines/NonCancellable:Xamarin.KotlinX.Coroutines.NonCancellable",
					"kotlinx/coroutines/NonDisposableHandle:Xamarin.KotlinX.Coroutines.NonDisposableHandle",
					"kotlinx/coroutines/ParentJob$DefaultImpls:Xamarin.KotlinX.Coroutines.ParentJobDefaultImpls",
					"kotlinx/coroutines/RunnableKt:Xamarin.KotlinX.Coroutines.RunnableKt",
					"kotlinx/coroutines/SchedulerTaskKt:Xamarin.KotlinX.Coroutines.SchedulerTaskKt",
					"kotlinx/coroutines/SupervisorKt:Xamarin.KotlinX.Coroutines.SupervisorKt",
					"kotlinx/coroutines/ThreadContextElement$DefaultImpls:Xamarin.KotlinX.Coroutines.ThreadContextElementDefaultImpls",
					"kotlinx/coroutines/ThreadContextElementKt:Xamarin.KotlinX.Coroutines.ThreadContextElementKt",
					"kotlinx/coroutines/ThreadPoolDispatcherKt:Xamarin.KotlinX.Coroutines.ThreadPoolDispatcherKt",
					"kotlinx/coroutines/TimeoutCancellationException:Xamarin.KotlinX.Coroutines.TimeoutCancellationException",
					"kotlinx/coroutines/TimeoutKt:Xamarin.KotlinX.Coroutines.TimeoutKt",
					"kotlinx/coroutines/YieldKt:Xamarin.KotlinX.Coroutines.YieldKt"
				};
			}
			return __TypeRegistrations.Lookup(__TypeRegistrations.package_kotlinx_coroutines_mappings, klass);
		}

		// Token: 0x06000AA9 RID: 2729 RVA: 0x000264F0 File Offset: 0x000246F0
		[return: Nullable(2)]
		private static Type lookup_kotlinx_coroutines_channels_package(string klass)
		{
			if (__TypeRegistrations.package_kotlinx_coroutines_channels_mappings == null)
			{
				__TypeRegistrations.package_kotlinx_coroutines_channels_mappings = new string[]
				{
					"kotlinx/coroutines/channels/ActorKt:Xamarin.KotlinX.Coroutines.Channels.ActorKt",
					"kotlinx/coroutines/channels/ActorScope$DefaultImpls:Xamarin.KotlinX.Coroutines.Channels.ActorScopeDefaultImpls",
					"kotlinx/coroutines/channels/BroadcastChannel$DefaultImpls:Xamarin.KotlinX.Coroutines.Channels.BroadcastChannelDefaultImpls",
					"kotlinx/coroutines/channels/BroadcastChannelKt:Xamarin.KotlinX.Coroutines.Channels.BroadcastChannelKt",
					"kotlinx/coroutines/channels/BroadcastKt:Xamarin.KotlinX.Coroutines.Channels.BroadcastKt",
					"kotlinx/coroutines/channels/BufferOverflow:Xamarin.KotlinX.Coroutines.Channels.BufferOverflow",
					"kotlinx/coroutines/channels/BufferedChannelKt:Xamarin.KotlinX.Coroutines.Channels.BufferedChannelKt",
					"kotlinx/coroutines/channels/Channel$DefaultImpls:Xamarin.KotlinX.Coroutines.Channels.ChannelDefaultImpls",
					"kotlinx/coroutines/channels/Channel$Factory:Xamarin.KotlinX.Coroutines.Channels.ChannelFactory",
					"kotlinx/coroutines/channels/ChannelIterator$DefaultImpls:Xamarin.KotlinX.Coroutines.Channels.ChannelIteratorDefaultImpls",
					"kotlinx/coroutines/channels/ChannelKt:Xamarin.KotlinX.Coroutines.Channels.ChannelKt",
					"kotlinx/coroutines/channels/ChannelResult:Xamarin.KotlinX.Coroutines.Channels.ChannelResult",
					"kotlinx/coroutines/channels/ChannelResult$Companion:Xamarin.KotlinX.Coroutines.Channels.ChannelResult/Companion",
					"kotlinx/coroutines/channels/ChannelsKt:Xamarin.KotlinX.Coroutines.Channels.ChannelsKt",
					"kotlinx/coroutines/channels/ClosedReceiveChannelException:Xamarin.KotlinX.Coroutines.Channels.ClosedReceiveChannelException",
					"kotlinx/coroutines/channels/ClosedSendChannelException:Xamarin.KotlinX.Coroutines.Channels.ClosedSendChannelException",
					"kotlinx/coroutines/channels/ConflatedBroadcastChannel:Xamarin.KotlinX.Coroutines.Channels.ConflatedBroadcastChannel",
					"kotlinx/coroutines/channels/ProduceKt:Xamarin.KotlinX.Coroutines.Channels.ProduceKt",
					"kotlinx/coroutines/channels/ProducerScope$DefaultImpls:Xamarin.KotlinX.Coroutines.Channels.ProducerScopeDefaultImpls",
					"kotlinx/coroutines/channels/ReceiveChannel$DefaultImpls:Xamarin.KotlinX.Coroutines.Channels.ReceiveChannelDefaultImpls",
					"kotlinx/coroutines/channels/SendChannel$DefaultImpls:Xamarin.KotlinX.Coroutines.Channels.SendChannelDefaultImpls",
					"kotlinx/coroutines/channels/TickerChannelsKt:Xamarin.KotlinX.Coroutines.Channels.TickerChannelsKt",
					"kotlinx/coroutines/channels/TickerMode:Xamarin.KotlinX.Coroutines.Channels.TickerMode"
				};
			}
			return __TypeRegistrations.Lookup(__TypeRegistrations.package_kotlinx_coroutines_channels_mappings, klass);
		}

		// Token: 0x06000AAA RID: 2730 RVA: 0x000265E4 File Offset: 0x000247E4
		[return: Nullable(2)]
		private static Type lookup_kotlinx_coroutines_flow_package(string klass)
		{
			if (__TypeRegistrations.package_kotlinx_coroutines_flow_mappings == null)
			{
				__TypeRegistrations.package_kotlinx_coroutines_flow_mappings = new string[]
				{
					"kotlinx/coroutines/flow/FlowKt:Xamarin.KotlinX.Coroutines.Flow.FlowKt",
					"kotlinx/coroutines/flow/LintKt:Xamarin.KotlinX.Coroutines.Flow.LintKt",
					"kotlinx/coroutines/flow/SharedFlowKt:Xamarin.KotlinX.Coroutines.Flow.SharedFlowKt",
					"kotlinx/coroutines/flow/SharingCommand:Xamarin.KotlinX.Coroutines.Flow.SharingCommand",
					"kotlinx/coroutines/flow/SharingStarted$Companion:Xamarin.KotlinX.Coroutines.Flow.SharingStartedCompanion",
					"kotlinx/coroutines/flow/SharingStartedKt:Xamarin.KotlinX.Coroutines.Flow.SharingStartedKt",
					"kotlinx/coroutines/flow/StateFlowKt:Xamarin.KotlinX.Coroutines.Flow.StateFlowKt"
				};
			}
			return __TypeRegistrations.Lookup(__TypeRegistrations.package_kotlinx_coroutines_flow_mappings, klass);
		}

		// Token: 0x06000AAB RID: 2731 RVA: 0x00026646 File Offset: 0x00024846
		[return: Nullable(2)]
		private static Type lookup_kotlinx_coroutines_future_package(string klass)
		{
			if (__TypeRegistrations.package_kotlinx_coroutines_future_mappings == null)
			{
				__TypeRegistrations.package_kotlinx_coroutines_future_mappings = new string[]
				{
					"kotlinx/coroutines/future/FutureKt:Xamarin.KotlinX.Coroutines.Future.FutureKt"
				};
			}
			return __TypeRegistrations.Lookup(__TypeRegistrations.package_kotlinx_coroutines_future_mappings, klass);
		}

		// Token: 0x06000AAC RID: 2732 RVA: 0x0002666D File Offset: 0x0002486D
		[return: Nullable(2)]
		private static Type lookup_kotlinx_coroutines_intrinsics_package(string klass)
		{
			if (__TypeRegistrations.package_kotlinx_coroutines_intrinsics_mappings == null)
			{
				__TypeRegistrations.package_kotlinx_coroutines_intrinsics_mappings = new string[]
				{
					"kotlinx/coroutines/intrinsics/CancellableKt:Xamarin.KotlinX.Coroutines.Intrinsics.CancellableKt",
					"kotlinx/coroutines/intrinsics/UndispatchedKt:Xamarin.KotlinX.Coroutines.Intrinsics.UndispatchedKt"
				};
			}
			return __TypeRegistrations.Lookup(__TypeRegistrations.package_kotlinx_coroutines_intrinsics_mappings, klass);
		}

		// Token: 0x06000AAD RID: 2733 RVA: 0x0002669C File Offset: 0x0002489C
		[return: Nullable(2)]
		private static Type lookup_kotlinx_coroutines_scheduling_package(string klass)
		{
			if (__TypeRegistrations.package_kotlinx_coroutines_scheduling_mappings == null)
			{
				__TypeRegistrations.package_kotlinx_coroutines_scheduling_mappings = new string[]
				{
					"kotlinx/coroutines/scheduling/CoroutineSchedulerKt:Xamarin.KotlinX.Coroutines.Scheduling.CoroutineSchedulerKt",
					"kotlinx/coroutines/scheduling/TasksKt:Xamarin.KotlinX.Coroutines.Scheduling.TasksKt",
					"kotlinx/coroutines/scheduling/WorkQueueKt:Xamarin.KotlinX.Coroutines.Scheduling.WorkQueueKt"
				};
			}
			return __TypeRegistrations.Lookup(__TypeRegistrations.package_kotlinx_coroutines_scheduling_mappings, klass);
		}

		// Token: 0x06000AAE RID: 2734 RVA: 0x000266D4 File Offset: 0x000248D4
		[return: Nullable(2)]
		private static Type lookup_kotlinx_coroutines_selects_package(string klass)
		{
			if (__TypeRegistrations.package_kotlinx_coroutines_selects_mappings == null)
			{
				__TypeRegistrations.package_kotlinx_coroutines_selects_mappings = new string[]
				{
					"kotlinx/coroutines/selects/OnTimeoutKt:Xamarin.KotlinX.Coroutines.Selects.OnTimeoutKt",
					"kotlinx/coroutines/selects/SelectBuilder$DefaultImpls:Xamarin.KotlinX.Coroutines.Selects.SelectBuilderDefaultImpls",
					"kotlinx/coroutines/selects/SelectKt:Xamarin.KotlinX.Coroutines.Selects.SelectKt",
					"kotlinx/coroutines/selects/SelectOldKt:Xamarin.KotlinX.Coroutines.Selects.SelectOldKt",
					"kotlinx/coroutines/selects/SelectUnbiasedKt:Xamarin.KotlinX.Coroutines.Selects.SelectUnbiasedKt",
					"kotlinx/coroutines/selects/WhileSelectKt:Xamarin.KotlinX.Coroutines.Selects.WhileSelectKt"
				};
			}
			return __TypeRegistrations.Lookup(__TypeRegistrations.package_kotlinx_coroutines_selects_mappings, klass);
		}

		// Token: 0x06000AAF RID: 2735 RVA: 0x0002672E File Offset: 0x0002492E
		[return: Nullable(2)]
		private static Type lookup_kotlinx_coroutines_stream_package(string klass)
		{
			if (__TypeRegistrations.package_kotlinx_coroutines_stream_mappings == null)
			{
				__TypeRegistrations.package_kotlinx_coroutines_stream_mappings = new string[]
				{
					"kotlinx/coroutines/stream/StreamKt:Xamarin.KotlinX.Coroutines.Stream.StreamKt"
				};
			}
			return __TypeRegistrations.Lookup(__TypeRegistrations.package_kotlinx_coroutines_stream_mappings, klass);
		}

		// Token: 0x06000AB0 RID: 2736 RVA: 0x00026755 File Offset: 0x00024955
		[return: Nullable(2)]
		private static Type lookup_kotlinx_coroutines_sync_package(string klass)
		{
			if (__TypeRegistrations.package_kotlinx_coroutines_sync_mappings == null)
			{
				__TypeRegistrations.package_kotlinx_coroutines_sync_mappings = new string[]
				{
					"kotlinx/coroutines/sync/Mutex$DefaultImpls:Xamarin.KotlinX.Coroutines.Sync.MutexDefaultImpls",
					"kotlinx/coroutines/sync/MutexKt:Xamarin.KotlinX.Coroutines.Sync.MutexKt",
					"kotlinx/coroutines/sync/SemaphoreKt:Xamarin.KotlinX.Coroutines.Sync.SemaphoreKt"
				};
			}
			return __TypeRegistrations.Lookup(__TypeRegistrations.package_kotlinx_coroutines_sync_mappings, klass);
		}

		// Token: 0x06000AB1 RID: 2737 RVA: 0x0002678C File Offset: 0x0002498C
		[return: Nullable(2)]
		private static Type lookup_kotlinx_coroutines_time_package(string klass)
		{
			if (__TypeRegistrations.package_kotlinx_coroutines_time_mappings == null)
			{
				__TypeRegistrations.package_kotlinx_coroutines_time_mappings = new string[]
				{
					"kotlinx/coroutines/time/TimeKt:Xamarin.KotlinX.Coroutines.Time.TimeKt"
				};
			}
			return __TypeRegistrations.Lookup(__TypeRegistrations.package_kotlinx_coroutines_time_mappings, klass);
		}

		// Token: 0x0400037F RID: 895
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private static string[] package_kotlinx_coroutines_mappings;

		// Token: 0x04000380 RID: 896
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private static string[] package_kotlinx_coroutines_channels_mappings;

		// Token: 0x04000381 RID: 897
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private static string[] package_kotlinx_coroutines_flow_mappings;

		// Token: 0x04000382 RID: 898
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private static string[] package_kotlinx_coroutines_future_mappings;

		// Token: 0x04000383 RID: 899
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private static string[] package_kotlinx_coroutines_intrinsics_mappings;

		// Token: 0x04000384 RID: 900
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private static string[] package_kotlinx_coroutines_scheduling_mappings;

		// Token: 0x04000385 RID: 901
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private static string[] package_kotlinx_coroutines_selects_mappings;

		// Token: 0x04000386 RID: 902
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private static string[] package_kotlinx_coroutines_stream_mappings;

		// Token: 0x04000387 RID: 903
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private static string[] package_kotlinx_coroutines_sync_mappings;

		// Token: 0x04000388 RID: 904
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private static string[] package_kotlinx_coroutines_time_mappings;

		// Token: 0x020000E9 RID: 233
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0400038C RID: 908
			[Nullable(new byte[]
			{
				0,
				1,
				2
			})]
			public static Converter<string, Type> <0>__lookup_kotlinx_coroutines_package;

			// Token: 0x0400038D RID: 909
			[Nullable(new byte[]
			{
				0,
				1,
				2
			})]
			public static Converter<string, Type> <1>__lookup_kotlinx_coroutines_channels_package;

			// Token: 0x0400038E RID: 910
			[Nullable(new byte[]
			{
				0,
				1,
				2
			})]
			public static Converter<string, Type> <2>__lookup_kotlinx_coroutines_flow_package;

			// Token: 0x0400038F RID: 911
			[Nullable(new byte[]
			{
				0,
				1,
				2
			})]
			public static Converter<string, Type> <3>__lookup_kotlinx_coroutines_future_package;

			// Token: 0x04000390 RID: 912
			[Nullable(new byte[]
			{
				0,
				1,
				2
			})]
			public static Converter<string, Type> <4>__lookup_kotlinx_coroutines_intrinsics_package;

			// Token: 0x04000391 RID: 913
			[Nullable(new byte[]
			{
				0,
				1,
				2
			})]
			public static Converter<string, Type> <5>__lookup_kotlinx_coroutines_scheduling_package;

			// Token: 0x04000392 RID: 914
			[Nullable(new byte[]
			{
				0,
				1,
				2
			})]
			public static Converter<string, Type> <6>__lookup_kotlinx_coroutines_selects_package;

			// Token: 0x04000393 RID: 915
			[Nullable(new byte[]
			{
				0,
				1,
				2
			})]
			public static Converter<string, Type> <7>__lookup_kotlinx_coroutines_stream_package;

			// Token: 0x04000394 RID: 916
			[Nullable(new byte[]
			{
				0,
				1,
				2
			})]
			public static Converter<string, Type> <8>__lookup_kotlinx_coroutines_sync_package;

			// Token: 0x04000395 RID: 917
			[Nullable(new byte[]
			{
				0,
				1,
				2
			})]
			public static Converter<string, Type> <9>__lookup_kotlinx_coroutines_time_package;
		}
	}
}
