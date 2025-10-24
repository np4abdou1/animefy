using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Content;
using Android.Runtime;
using Java.Interop;
using Java.Lang;
using Java.Util.Concurrent;
using JavaX.Inject;
using Xamarin.Google.Android.DataTransport.Runtime.Backends;
using Xamarin.Google.Android.DataTransport.Runtime.Dagger.Internal;
using Xamarin.Google.Android.DataTransport.Runtime.Persistence;
using Xamarin.Google.Android.DataTransport.Runtime.Synchronization;
using Xamarin.Google.Android.DataTransport.Runtime.Time;

namespace Xamarin.Google.Android.DataTransport.Runtime.Scheduling.JobScheduling
{
	// Token: 0x0200005E RID: 94
	[Register("com/google/android/datatransport/runtime/scheduling/jobscheduling/Uploader_Factory", DoNotGenerateAcw = true)]
	public sealed class Uploader_Factory : Java.Lang.Object, IFactory, IProvider, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x170000F2 RID: 242
		// (get) Token: 0x06000318 RID: 792 RVA: 0x00009A68 File Offset: 0x00007C68
		internal static IntPtr class_ref
		{
			get
			{
				return Uploader_Factory._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170000F3 RID: 243
		// (get) Token: 0x06000319 RID: 793 RVA: 0x00009A8C File Offset: 0x00007C8C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return Uploader_Factory._members;
			}
		}

		// Token: 0x170000F4 RID: 244
		// (get) Token: 0x0600031A RID: 794 RVA: 0x00009A94 File Offset: 0x00007C94
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return Uploader_Factory._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170000F5 RID: 245
		// (get) Token: 0x0600031B RID: 795 RVA: 0x00009AB8 File Offset: 0x00007CB8
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return Uploader_Factory._members.ManagedPeerType;
			}
		}

		// Token: 0x0600031C RID: 796 RVA: 0x000026C4 File Offset: 0x000008C4
		internal Uploader_Factory(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x0600031D RID: 797 RVA: 0x00009AC4 File Offset: 0x00007CC4
		[Register(".ctor", "(Ljavax/inject/Provider;Ljavax/inject/Provider;Ljavax/inject/Provider;Ljavax/inject/Provider;Ljavax/inject/Provider;Ljavax/inject/Provider;Ljavax/inject/Provider;Ljavax/inject/Provider;Ljavax/inject/Provider;)V", "")]
		public unsafe Uploader_Factory(IProvider contextProvider, IProvider backendRegistryProvider, IProvider eventStoreProvider, IProvider workSchedulerProvider, IProvider executorProvider, IProvider guardProvider, IProvider clockProvider, IProvider uptimeClockProvider, IProvider clientHealthMetricsStoreProvider) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)9) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((contextProvider == null) ? IntPtr.Zero : ((Java.Lang.Object)contextProvider).Handle);
				ptr[1] = new JniArgumentValue((backendRegistryProvider == null) ? IntPtr.Zero : ((Java.Lang.Object)backendRegistryProvider).Handle);
				ptr[2] = new JniArgumentValue((eventStoreProvider == null) ? IntPtr.Zero : ((Java.Lang.Object)eventStoreProvider).Handle);
				ptr[3] = new JniArgumentValue((workSchedulerProvider == null) ? IntPtr.Zero : ((Java.Lang.Object)workSchedulerProvider).Handle);
				ptr[4] = new JniArgumentValue((executorProvider == null) ? IntPtr.Zero : ((Java.Lang.Object)executorProvider).Handle);
				ptr[5] = new JniArgumentValue((guardProvider == null) ? IntPtr.Zero : ((Java.Lang.Object)guardProvider).Handle);
				ptr[6] = new JniArgumentValue((clockProvider == null) ? IntPtr.Zero : ((Java.Lang.Object)clockProvider).Handle);
				ptr[7] = new JniArgumentValue((uptimeClockProvider == null) ? IntPtr.Zero : ((Java.Lang.Object)uptimeClockProvider).Handle);
				ptr[8] = new JniArgumentValue((clientHealthMetricsStoreProvider == null) ? IntPtr.Zero : ((Java.Lang.Object)clientHealthMetricsStoreProvider).Handle);
				base.SetHandle(Uploader_Factory._members.InstanceMethods.StartCreateInstance("(Ljavax/inject/Provider;Ljavax/inject/Provider;Ljavax/inject/Provider;Ljavax/inject/Provider;Ljavax/inject/Provider;Ljavax/inject/Provider;Ljavax/inject/Provider;Ljavax/inject/Provider;Ljavax/inject/Provider;)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				Uploader_Factory._members.InstanceMethods.FinishCreateInstance("(Ljavax/inject/Provider;Ljavax/inject/Provider;Ljavax/inject/Provider;Ljavax/inject/Provider;Ljavax/inject/Provider;Ljavax/inject/Provider;Ljavax/inject/Provider;Ljavax/inject/Provider;Ljavax/inject/Provider;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(contextProvider);
				GC.KeepAlive(backendRegistryProvider);
				GC.KeepAlive(eventStoreProvider);
				GC.KeepAlive(workSchedulerProvider);
				GC.KeepAlive(executorProvider);
				GC.KeepAlive(guardProvider);
				GC.KeepAlive(clockProvider);
				GC.KeepAlive(uptimeClockProvider);
				GC.KeepAlive(clientHealthMetricsStoreProvider);
			}
		}

		// Token: 0x0600031E RID: 798 RVA: 0x00009D14 File Offset: 0x00007F14
		[Register("create", "(Ljavax/inject/Provider;Ljavax/inject/Provider;Ljavax/inject/Provider;Ljavax/inject/Provider;Ljavax/inject/Provider;Ljavax/inject/Provider;Ljavax/inject/Provider;Ljavax/inject/Provider;Ljavax/inject/Provider;)Lcom/google/android/datatransport/runtime/scheduling/jobscheduling/Uploader_Factory;", "")]
		public unsafe static Uploader_Factory Create(IProvider contextProvider, IProvider backendRegistryProvider, IProvider eventStoreProvider, IProvider workSchedulerProvider, IProvider executorProvider, IProvider guardProvider, IProvider clockProvider, IProvider uptimeClockProvider, IProvider clientHealthMetricsStoreProvider)
		{
			Uploader_Factory @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)9) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((contextProvider == null) ? IntPtr.Zero : ((Java.Lang.Object)contextProvider).Handle);
				ptr[1] = new JniArgumentValue((backendRegistryProvider == null) ? IntPtr.Zero : ((Java.Lang.Object)backendRegistryProvider).Handle);
				ptr[2] = new JniArgumentValue((eventStoreProvider == null) ? IntPtr.Zero : ((Java.Lang.Object)eventStoreProvider).Handle);
				ptr[3] = new JniArgumentValue((workSchedulerProvider == null) ? IntPtr.Zero : ((Java.Lang.Object)workSchedulerProvider).Handle);
				ptr[4] = new JniArgumentValue((executorProvider == null) ? IntPtr.Zero : ((Java.Lang.Object)executorProvider).Handle);
				ptr[5] = new JniArgumentValue((guardProvider == null) ? IntPtr.Zero : ((Java.Lang.Object)guardProvider).Handle);
				ptr[6] = new JniArgumentValue((clockProvider == null) ? IntPtr.Zero : ((Java.Lang.Object)clockProvider).Handle);
				ptr[7] = new JniArgumentValue((uptimeClockProvider == null) ? IntPtr.Zero : ((Java.Lang.Object)uptimeClockProvider).Handle);
				ptr[8] = new JniArgumentValue((clientHealthMetricsStoreProvider == null) ? IntPtr.Zero : ((Java.Lang.Object)clientHealthMetricsStoreProvider).Handle);
				@object = Java.Lang.Object.GetObject<Uploader_Factory>(Uploader_Factory._members.StaticMethods.InvokeObjectMethod("create.(Ljavax/inject/Provider;Ljavax/inject/Provider;Ljavax/inject/Provider;Ljavax/inject/Provider;Ljavax/inject/Provider;Ljavax/inject/Provider;Ljavax/inject/Provider;Ljavax/inject/Provider;Ljavax/inject/Provider;)Lcom/google/android/datatransport/runtime/scheduling/jobscheduling/Uploader_Factory;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(contextProvider);
				GC.KeepAlive(backendRegistryProvider);
				GC.KeepAlive(eventStoreProvider);
				GC.KeepAlive(workSchedulerProvider);
				GC.KeepAlive(executorProvider);
				GC.KeepAlive(guardProvider);
				GC.KeepAlive(clockProvider);
				GC.KeepAlive(uptimeClockProvider);
				GC.KeepAlive(clientHealthMetricsStoreProvider);
			}
			return @object;
		}

		// Token: 0x0600031F RID: 799 RVA: 0x00009F24 File Offset: 0x00008124
		[Register("get", "()Lcom/google/android/datatransport/runtime/scheduling/jobscheduling/Uploader;", "")]
		public Java.Lang.Object Get()
		{
			return Java.Lang.Object.GetObject<Java.Lang.Object>(Uploader_Factory._members.InstanceMethods.InvokeAbstractObjectMethod("get.()Lcom/google/android/datatransport/runtime/scheduling/jobscheduling/Uploader;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x06000320 RID: 800 RVA: 0x00009F58 File Offset: 0x00008158
		[Register("newInstance", "(Landroid/content/Context;Lcom/google/android/datatransport/runtime/backends/BackendRegistry;Lcom/google/android/datatransport/runtime/scheduling/persistence/EventStore;Lcom/google/android/datatransport/runtime/scheduling/jobscheduling/WorkScheduler;Ljava/util/concurrent/Executor;Lcom/google/android/datatransport/runtime/synchronization/SynchronizationGuard;Lcom/google/android/datatransport/runtime/time/Clock;Lcom/google/android/datatransport/runtime/time/Clock;Lcom/google/android/datatransport/runtime/scheduling/persistence/ClientHealthMetricsStore;)Lcom/google/android/datatransport/runtime/scheduling/jobscheduling/Uploader;", "")]
		public unsafe static Uploader NewInstance(Context context, IBackendRegistry backendRegistry, IEventStore eventStore, IWorkScheduler workScheduler, IExecutor executor, ISynchronizationGuard guard, IClock clock, IClock uptimeClock, IClientHealthMetricsStore clientHealthMetricsStore)
		{
			Uploader @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)9) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((context == null) ? IntPtr.Zero : context.Handle);
				ptr[1] = new JniArgumentValue((backendRegistry == null) ? IntPtr.Zero : ((Java.Lang.Object)backendRegistry).Handle);
				ptr[2] = new JniArgumentValue((eventStore == null) ? IntPtr.Zero : ((Java.Lang.Object)eventStore).Handle);
				ptr[3] = new JniArgumentValue((workScheduler == null) ? IntPtr.Zero : ((Java.Lang.Object)workScheduler).Handle);
				ptr[4] = new JniArgumentValue((executor == null) ? IntPtr.Zero : ((Java.Lang.Object)executor).Handle);
				ptr[5] = new JniArgumentValue((guard == null) ? IntPtr.Zero : ((Java.Lang.Object)guard).Handle);
				ptr[6] = new JniArgumentValue((clock == null) ? IntPtr.Zero : ((Java.Lang.Object)clock).Handle);
				ptr[7] = new JniArgumentValue((uptimeClock == null) ? IntPtr.Zero : ((Java.Lang.Object)uptimeClock).Handle);
				ptr[8] = new JniArgumentValue((clientHealthMetricsStore == null) ? IntPtr.Zero : ((Java.Lang.Object)clientHealthMetricsStore).Handle);
				@object = Java.Lang.Object.GetObject<Uploader>(Uploader_Factory._members.StaticMethods.InvokeObjectMethod("newInstance.(Landroid/content/Context;Lcom/google/android/datatransport/runtime/backends/BackendRegistry;Lcom/google/android/datatransport/runtime/scheduling/persistence/EventStore;Lcom/google/android/datatransport/runtime/scheduling/jobscheduling/WorkScheduler;Ljava/util/concurrent/Executor;Lcom/google/android/datatransport/runtime/synchronization/SynchronizationGuard;Lcom/google/android/datatransport/runtime/time/Clock;Lcom/google/android/datatransport/runtime/time/Clock;Lcom/google/android/datatransport/runtime/scheduling/persistence/ClientHealthMetricsStore;)Lcom/google/android/datatransport/runtime/scheduling/jobscheduling/Uploader;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(context);
				GC.KeepAlive(backendRegistry);
				GC.KeepAlive(eventStore);
				GC.KeepAlive(workScheduler);
				GC.KeepAlive(executor);
				GC.KeepAlive(guard);
				GC.KeepAlive(clock);
				GC.KeepAlive(uptimeClock);
				GC.KeepAlive(clientHealthMetricsStore);
			}
			return @object;
		}

		// Token: 0x040000B1 RID: 177
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/google/android/datatransport/runtime/scheduling/jobscheduling/Uploader_Factory", typeof(Uploader_Factory));
	}
}
