using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;
using Java.Util.Concurrent;
using JavaX.Inject;
using Xamarin.Google.Android.DataTransport.Runtime.Dagger.Internal;
using Xamarin.Google.Android.DataTransport.Runtime.Persistence;
using Xamarin.Google.Android.DataTransport.Runtime.Synchronization;

namespace Xamarin.Google.Android.DataTransport.Runtime.Scheduling.JobScheduling
{
	// Token: 0x02000060 RID: 96
	[Register("com/google/android/datatransport/runtime/scheduling/jobscheduling/WorkInitializer_Factory", DoNotGenerateAcw = true)]
	public sealed class WorkInitializer_Factory : Java.Lang.Object, IFactory, IProvider, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x170000FA RID: 250
		// (get) Token: 0x0600032B RID: 811 RVA: 0x0000A244 File Offset: 0x00008444
		internal static IntPtr class_ref
		{
			get
			{
				return WorkInitializer_Factory._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170000FB RID: 251
		// (get) Token: 0x0600032C RID: 812 RVA: 0x0000A268 File Offset: 0x00008468
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return WorkInitializer_Factory._members;
			}
		}

		// Token: 0x170000FC RID: 252
		// (get) Token: 0x0600032D RID: 813 RVA: 0x0000A270 File Offset: 0x00008470
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return WorkInitializer_Factory._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170000FD RID: 253
		// (get) Token: 0x0600032E RID: 814 RVA: 0x0000A294 File Offset: 0x00008494
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return WorkInitializer_Factory._members.ManagedPeerType;
			}
		}

		// Token: 0x0600032F RID: 815 RVA: 0x000026C4 File Offset: 0x000008C4
		internal WorkInitializer_Factory(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06000330 RID: 816 RVA: 0x0000A2A0 File Offset: 0x000084A0
		[Register(".ctor", "(Ljavax/inject/Provider;Ljavax/inject/Provider;Ljavax/inject/Provider;Ljavax/inject/Provider;)V", "")]
		public unsafe WorkInitializer_Factory(IProvider executorProvider, IProvider storeProvider, IProvider schedulerProvider, IProvider guardProvider) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((executorProvider == null) ? IntPtr.Zero : ((Java.Lang.Object)executorProvider).Handle);
				ptr[1] = new JniArgumentValue((storeProvider == null) ? IntPtr.Zero : ((Java.Lang.Object)storeProvider).Handle);
				ptr[2] = new JniArgumentValue((schedulerProvider == null) ? IntPtr.Zero : ((Java.Lang.Object)schedulerProvider).Handle);
				ptr[3] = new JniArgumentValue((guardProvider == null) ? IntPtr.Zero : ((Java.Lang.Object)guardProvider).Handle);
				base.SetHandle(WorkInitializer_Factory._members.InstanceMethods.StartCreateInstance("(Ljavax/inject/Provider;Ljavax/inject/Provider;Ljavax/inject/Provider;Ljavax/inject/Provider;)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				WorkInitializer_Factory._members.InstanceMethods.FinishCreateInstance("(Ljavax/inject/Provider;Ljavax/inject/Provider;Ljavax/inject/Provider;Ljavax/inject/Provider;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(executorProvider);
				GC.KeepAlive(storeProvider);
				GC.KeepAlive(schedulerProvider);
				GC.KeepAlive(guardProvider);
			}
		}

		// Token: 0x06000331 RID: 817 RVA: 0x0000A3E4 File Offset: 0x000085E4
		[Register("create", "(Ljavax/inject/Provider;Ljavax/inject/Provider;Ljavax/inject/Provider;Ljavax/inject/Provider;)Lcom/google/android/datatransport/runtime/scheduling/jobscheduling/WorkInitializer_Factory;", "")]
		public unsafe static WorkInitializer_Factory Create(IProvider executorProvider, IProvider storeProvider, IProvider schedulerProvider, IProvider guardProvider)
		{
			WorkInitializer_Factory @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((executorProvider == null) ? IntPtr.Zero : ((Java.Lang.Object)executorProvider).Handle);
				ptr[1] = new JniArgumentValue((storeProvider == null) ? IntPtr.Zero : ((Java.Lang.Object)storeProvider).Handle);
				ptr[2] = new JniArgumentValue((schedulerProvider == null) ? IntPtr.Zero : ((Java.Lang.Object)schedulerProvider).Handle);
				ptr[3] = new JniArgumentValue((guardProvider == null) ? IntPtr.Zero : ((Java.Lang.Object)guardProvider).Handle);
				@object = Java.Lang.Object.GetObject<WorkInitializer_Factory>(WorkInitializer_Factory._members.StaticMethods.InvokeObjectMethod("create.(Ljavax/inject/Provider;Ljavax/inject/Provider;Ljavax/inject/Provider;Ljavax/inject/Provider;)Lcom/google/android/datatransport/runtime/scheduling/jobscheduling/WorkInitializer_Factory;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(executorProvider);
				GC.KeepAlive(storeProvider);
				GC.KeepAlive(schedulerProvider);
				GC.KeepAlive(guardProvider);
			}
			return @object;
		}

		// Token: 0x06000332 RID: 818 RVA: 0x0000A4E8 File Offset: 0x000086E8
		[Register("get", "()Lcom/google/android/datatransport/runtime/scheduling/jobscheduling/WorkInitializer;", "")]
		public Java.Lang.Object Get()
		{
			return Java.Lang.Object.GetObject<Java.Lang.Object>(WorkInitializer_Factory._members.InstanceMethods.InvokeAbstractObjectMethod("get.()Lcom/google/android/datatransport/runtime/scheduling/jobscheduling/WorkInitializer;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x06000333 RID: 819 RVA: 0x0000A51C File Offset: 0x0000871C
		[Register("newInstance", "(Ljava/util/concurrent/Executor;Lcom/google/android/datatransport/runtime/scheduling/persistence/EventStore;Lcom/google/android/datatransport/runtime/scheduling/jobscheduling/WorkScheduler;Lcom/google/android/datatransport/runtime/synchronization/SynchronizationGuard;)Lcom/google/android/datatransport/runtime/scheduling/jobscheduling/WorkInitializer;", "")]
		public unsafe static WorkInitializer NewInstance(IExecutor executor, IEventStore store, IWorkScheduler scheduler, ISynchronizationGuard guard)
		{
			WorkInitializer @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((executor == null) ? IntPtr.Zero : ((Java.Lang.Object)executor).Handle);
				ptr[1] = new JniArgumentValue((store == null) ? IntPtr.Zero : ((Java.Lang.Object)store).Handle);
				ptr[2] = new JniArgumentValue((scheduler == null) ? IntPtr.Zero : ((Java.Lang.Object)scheduler).Handle);
				ptr[3] = new JniArgumentValue((guard == null) ? IntPtr.Zero : ((Java.Lang.Object)guard).Handle);
				@object = Java.Lang.Object.GetObject<WorkInitializer>(WorkInitializer_Factory._members.StaticMethods.InvokeObjectMethod("newInstance.(Ljava/util/concurrent/Executor;Lcom/google/android/datatransport/runtime/scheduling/persistence/EventStore;Lcom/google/android/datatransport/runtime/scheduling/jobscheduling/WorkScheduler;Lcom/google/android/datatransport/runtime/synchronization/SynchronizationGuard;)Lcom/google/android/datatransport/runtime/scheduling/jobscheduling/WorkInitializer;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(executor);
				GC.KeepAlive(store);
				GC.KeepAlive(scheduler);
				GC.KeepAlive(guard);
			}
			return @object;
		}

		// Token: 0x040000B4 RID: 180
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/google/android/datatransport/runtime/scheduling/jobscheduling/WorkInitializer_Factory", typeof(WorkInitializer_Factory));
	}
}
