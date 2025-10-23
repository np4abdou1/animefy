using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;
using Java.Util.Concurrent;
using JavaX.Inject;
using Xamarin.Google.Android.DataTransport.Runtime.Backends;
using Xamarin.Google.Android.DataTransport.Runtime.Dagger.Internal;
using Xamarin.Google.Android.DataTransport.Runtime.Persistence;
using Xamarin.Google.Android.DataTransport.Runtime.Scheduling.JobScheduling;
using Xamarin.Google.Android.DataTransport.Runtime.Synchronization;

namespace Xamarin.Google.Android.DataTransport.Runtime.Scheduling
{
	// Token: 0x02000046 RID: 70
	[Register("com/google/android/datatransport/runtime/scheduling/DefaultScheduler_Factory", DoNotGenerateAcw = true)]
	public sealed class DefaultScheduler_Factory : Java.Lang.Object, IFactory, IProvider, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x170000A1 RID: 161
		// (get) Token: 0x0600022D RID: 557 RVA: 0x00006AA8 File Offset: 0x00004CA8
		internal static IntPtr class_ref
		{
			get
			{
				return DefaultScheduler_Factory._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170000A2 RID: 162
		// (get) Token: 0x0600022E RID: 558 RVA: 0x00006ACC File Offset: 0x00004CCC
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return DefaultScheduler_Factory._members;
			}
		}

		// Token: 0x170000A3 RID: 163
		// (get) Token: 0x0600022F RID: 559 RVA: 0x00006AD4 File Offset: 0x00004CD4
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return DefaultScheduler_Factory._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170000A4 RID: 164
		// (get) Token: 0x06000230 RID: 560 RVA: 0x00006AF8 File Offset: 0x00004CF8
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return DefaultScheduler_Factory._members.ManagedPeerType;
			}
		}

		// Token: 0x06000231 RID: 561 RVA: 0x000026C4 File Offset: 0x000008C4
		internal DefaultScheduler_Factory(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06000232 RID: 562 RVA: 0x00006B04 File Offset: 0x00004D04
		[Register(".ctor", "(Ljavax/inject/Provider;Ljavax/inject/Provider;Ljavax/inject/Provider;Ljavax/inject/Provider;Ljavax/inject/Provider;)V", "")]
		public unsafe DefaultScheduler_Factory(IProvider executorProvider, IProvider backendRegistryProvider, IProvider workSchedulerProvider, IProvider eventStoreProvider, IProvider guardProvider) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((executorProvider == null) ? IntPtr.Zero : ((Java.Lang.Object)executorProvider).Handle);
				ptr[1] = new JniArgumentValue((backendRegistryProvider == null) ? IntPtr.Zero : ((Java.Lang.Object)backendRegistryProvider).Handle);
				ptr[2] = new JniArgumentValue((workSchedulerProvider == null) ? IntPtr.Zero : ((Java.Lang.Object)workSchedulerProvider).Handle);
				ptr[3] = new JniArgumentValue((eventStoreProvider == null) ? IntPtr.Zero : ((Java.Lang.Object)eventStoreProvider).Handle);
				ptr[4] = new JniArgumentValue((guardProvider == null) ? IntPtr.Zero : ((Java.Lang.Object)guardProvider).Handle);
				base.SetHandle(DefaultScheduler_Factory._members.InstanceMethods.StartCreateInstance("(Ljavax/inject/Provider;Ljavax/inject/Provider;Ljavax/inject/Provider;Ljavax/inject/Provider;Ljavax/inject/Provider;)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				DefaultScheduler_Factory._members.InstanceMethods.FinishCreateInstance("(Ljavax/inject/Provider;Ljavax/inject/Provider;Ljavax/inject/Provider;Ljavax/inject/Provider;Ljavax/inject/Provider;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(executorProvider);
				GC.KeepAlive(backendRegistryProvider);
				GC.KeepAlive(workSchedulerProvider);
				GC.KeepAlive(eventStoreProvider);
				GC.KeepAlive(guardProvider);
			}
		}

		// Token: 0x06000233 RID: 563 RVA: 0x00006C88 File Offset: 0x00004E88
		[Register("create", "(Ljavax/inject/Provider;Ljavax/inject/Provider;Ljavax/inject/Provider;Ljavax/inject/Provider;Ljavax/inject/Provider;)Lcom/google/android/datatransport/runtime/scheduling/DefaultScheduler_Factory;", "")]
		public unsafe static DefaultScheduler_Factory Create(IProvider executorProvider, IProvider backendRegistryProvider, IProvider workSchedulerProvider, IProvider eventStoreProvider, IProvider guardProvider)
		{
			DefaultScheduler_Factory @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((executorProvider == null) ? IntPtr.Zero : ((Java.Lang.Object)executorProvider).Handle);
				ptr[1] = new JniArgumentValue((backendRegistryProvider == null) ? IntPtr.Zero : ((Java.Lang.Object)backendRegistryProvider).Handle);
				ptr[2] = new JniArgumentValue((workSchedulerProvider == null) ? IntPtr.Zero : ((Java.Lang.Object)workSchedulerProvider).Handle);
				ptr[3] = new JniArgumentValue((eventStoreProvider == null) ? IntPtr.Zero : ((Java.Lang.Object)eventStoreProvider).Handle);
				ptr[4] = new JniArgumentValue((guardProvider == null) ? IntPtr.Zero : ((Java.Lang.Object)guardProvider).Handle);
				@object = Java.Lang.Object.GetObject<DefaultScheduler_Factory>(DefaultScheduler_Factory._members.StaticMethods.InvokeObjectMethod("create.(Ljavax/inject/Provider;Ljavax/inject/Provider;Ljavax/inject/Provider;Ljavax/inject/Provider;Ljavax/inject/Provider;)Lcom/google/android/datatransport/runtime/scheduling/DefaultScheduler_Factory;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(executorProvider);
				GC.KeepAlive(backendRegistryProvider);
				GC.KeepAlive(workSchedulerProvider);
				GC.KeepAlive(eventStoreProvider);
				GC.KeepAlive(guardProvider);
			}
			return @object;
		}

		// Token: 0x06000234 RID: 564 RVA: 0x00006DC0 File Offset: 0x00004FC0
		[Register("get", "()Lcom/google/android/datatransport/runtime/scheduling/DefaultScheduler;", "")]
		public Java.Lang.Object Get()
		{
			return Java.Lang.Object.GetObject<Java.Lang.Object>(DefaultScheduler_Factory._members.InstanceMethods.InvokeAbstractObjectMethod("get.()Lcom/google/android/datatransport/runtime/scheduling/DefaultScheduler;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x06000235 RID: 565 RVA: 0x00006DF4 File Offset: 0x00004FF4
		[Register("newInstance", "(Ljava/util/concurrent/Executor;Lcom/google/android/datatransport/runtime/backends/BackendRegistry;Lcom/google/android/datatransport/runtime/scheduling/jobscheduling/WorkScheduler;Lcom/google/android/datatransport/runtime/scheduling/persistence/EventStore;Lcom/google/android/datatransport/runtime/synchronization/SynchronizationGuard;)Lcom/google/android/datatransport/runtime/scheduling/DefaultScheduler;", "")]
		public unsafe static DefaultScheduler NewInstance(IExecutor executor, IBackendRegistry backendRegistry, IWorkScheduler workScheduler, IEventStore eventStore, ISynchronizationGuard guard)
		{
			DefaultScheduler @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((executor == null) ? IntPtr.Zero : ((Java.Lang.Object)executor).Handle);
				ptr[1] = new JniArgumentValue((backendRegistry == null) ? IntPtr.Zero : ((Java.Lang.Object)backendRegistry).Handle);
				ptr[2] = new JniArgumentValue((workScheduler == null) ? IntPtr.Zero : ((Java.Lang.Object)workScheduler).Handle);
				ptr[3] = new JniArgumentValue((eventStore == null) ? IntPtr.Zero : ((Java.Lang.Object)eventStore).Handle);
				ptr[4] = new JniArgumentValue((guard == null) ? IntPtr.Zero : ((Java.Lang.Object)guard).Handle);
				@object = Java.Lang.Object.GetObject<DefaultScheduler>(DefaultScheduler_Factory._members.StaticMethods.InvokeObjectMethod("newInstance.(Ljava/util/concurrent/Executor;Lcom/google/android/datatransport/runtime/backends/BackendRegistry;Lcom/google/android/datatransport/runtime/scheduling/jobscheduling/WorkScheduler;Lcom/google/android/datatransport/runtime/scheduling/persistence/EventStore;Lcom/google/android/datatransport/runtime/synchronization/SynchronizationGuard;)Lcom/google/android/datatransport/runtime/scheduling/DefaultScheduler;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(executor);
				GC.KeepAlive(backendRegistry);
				GC.KeepAlive(workScheduler);
				GC.KeepAlive(eventStore);
				GC.KeepAlive(guard);
			}
			return @object;
		}

		// Token: 0x0400007F RID: 127
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/google/android/datatransport/runtime/scheduling/DefaultScheduler_Factory", typeof(DefaultScheduler_Factory));
	}
}
