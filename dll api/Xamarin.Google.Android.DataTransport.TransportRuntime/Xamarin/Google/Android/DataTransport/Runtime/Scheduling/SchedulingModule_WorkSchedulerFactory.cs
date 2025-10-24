using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Content;
using Android.Runtime;
using Java.Interop;
using Java.Lang;
using JavaX.Inject;
using Xamarin.Google.Android.DataTransport.Runtime.Dagger.Internal;
using Xamarin.Google.Android.DataTransport.Runtime.Persistence;
using Xamarin.Google.Android.DataTransport.Runtime.Scheduling.JobScheduling;
using Xamarin.Google.Android.DataTransport.Runtime.Time;

namespace Xamarin.Google.Android.DataTransport.Runtime.Scheduling
{
	// Token: 0x0200004E RID: 78
	[Register("com/google/android/datatransport/runtime/scheduling/SchedulingModule_WorkSchedulerFactory", DoNotGenerateAcw = true)]
	public sealed class SchedulingModule_WorkSchedulerFactory : Java.Lang.Object, IFactory, IProvider, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x170000B9 RID: 185
		// (get) Token: 0x06000264 RID: 612 RVA: 0x000075EC File Offset: 0x000057EC
		internal static IntPtr class_ref
		{
			get
			{
				return SchedulingModule_WorkSchedulerFactory._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170000BA RID: 186
		// (get) Token: 0x06000265 RID: 613 RVA: 0x00007610 File Offset: 0x00005810
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return SchedulingModule_WorkSchedulerFactory._members;
			}
		}

		// Token: 0x170000BB RID: 187
		// (get) Token: 0x06000266 RID: 614 RVA: 0x00007618 File Offset: 0x00005818
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return SchedulingModule_WorkSchedulerFactory._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170000BC RID: 188
		// (get) Token: 0x06000267 RID: 615 RVA: 0x0000763C File Offset: 0x0000583C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return SchedulingModule_WorkSchedulerFactory._members.ManagedPeerType;
			}
		}

		// Token: 0x06000268 RID: 616 RVA: 0x000026C4 File Offset: 0x000008C4
		internal SchedulingModule_WorkSchedulerFactory(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06000269 RID: 617 RVA: 0x00007648 File Offset: 0x00005848
		[Register(".ctor", "(Ljavax/inject/Provider;Ljavax/inject/Provider;Ljavax/inject/Provider;Ljavax/inject/Provider;)V", "")]
		public unsafe SchedulingModule_WorkSchedulerFactory(IProvider contextProvider, IProvider eventStoreProvider, IProvider configProvider, IProvider clockProvider) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((contextProvider == null) ? IntPtr.Zero : ((Java.Lang.Object)contextProvider).Handle);
				ptr[1] = new JniArgumentValue((eventStoreProvider == null) ? IntPtr.Zero : ((Java.Lang.Object)eventStoreProvider).Handle);
				ptr[2] = new JniArgumentValue((configProvider == null) ? IntPtr.Zero : ((Java.Lang.Object)configProvider).Handle);
				ptr[3] = new JniArgumentValue((clockProvider == null) ? IntPtr.Zero : ((Java.Lang.Object)clockProvider).Handle);
				base.SetHandle(SchedulingModule_WorkSchedulerFactory._members.InstanceMethods.StartCreateInstance("(Ljavax/inject/Provider;Ljavax/inject/Provider;Ljavax/inject/Provider;Ljavax/inject/Provider;)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				SchedulingModule_WorkSchedulerFactory._members.InstanceMethods.FinishCreateInstance("(Ljavax/inject/Provider;Ljavax/inject/Provider;Ljavax/inject/Provider;Ljavax/inject/Provider;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(contextProvider);
				GC.KeepAlive(eventStoreProvider);
				GC.KeepAlive(configProvider);
				GC.KeepAlive(clockProvider);
			}
		}

		// Token: 0x0600026A RID: 618 RVA: 0x0000778C File Offset: 0x0000598C
		[Register("create", "(Ljavax/inject/Provider;Ljavax/inject/Provider;Ljavax/inject/Provider;Ljavax/inject/Provider;)Lcom/google/android/datatransport/runtime/scheduling/SchedulingModule_WorkSchedulerFactory;", "")]
		public unsafe static SchedulingModule_WorkSchedulerFactory Create(IProvider contextProvider, IProvider eventStoreProvider, IProvider configProvider, IProvider clockProvider)
		{
			SchedulingModule_WorkSchedulerFactory @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((contextProvider == null) ? IntPtr.Zero : ((Java.Lang.Object)contextProvider).Handle);
				ptr[1] = new JniArgumentValue((eventStoreProvider == null) ? IntPtr.Zero : ((Java.Lang.Object)eventStoreProvider).Handle);
				ptr[2] = new JniArgumentValue((configProvider == null) ? IntPtr.Zero : ((Java.Lang.Object)configProvider).Handle);
				ptr[3] = new JniArgumentValue((clockProvider == null) ? IntPtr.Zero : ((Java.Lang.Object)clockProvider).Handle);
				@object = Java.Lang.Object.GetObject<SchedulingModule_WorkSchedulerFactory>(SchedulingModule_WorkSchedulerFactory._members.StaticMethods.InvokeObjectMethod("create.(Ljavax/inject/Provider;Ljavax/inject/Provider;Ljavax/inject/Provider;Ljavax/inject/Provider;)Lcom/google/android/datatransport/runtime/scheduling/SchedulingModule_WorkSchedulerFactory;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(contextProvider);
				GC.KeepAlive(eventStoreProvider);
				GC.KeepAlive(configProvider);
				GC.KeepAlive(clockProvider);
			}
			return @object;
		}

		// Token: 0x0600026B RID: 619 RVA: 0x00007890 File Offset: 0x00005A90
		[Register("get", "()Lcom/google/android/datatransport/runtime/scheduling/jobscheduling/WorkScheduler;", "")]
		public Java.Lang.Object Get()
		{
			return Java.Lang.Object.GetObject<Java.Lang.Object>(SchedulingModule_WorkSchedulerFactory._members.InstanceMethods.InvokeAbstractObjectMethod("get.()Lcom/google/android/datatransport/runtime/scheduling/jobscheduling/WorkScheduler;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x0600026C RID: 620 RVA: 0x000078C4 File Offset: 0x00005AC4
		[Register("workScheduler", "(Landroid/content/Context;Lcom/google/android/datatransport/runtime/scheduling/persistence/EventStore;Lcom/google/android/datatransport/runtime/scheduling/jobscheduling/SchedulerConfig;Lcom/google/android/datatransport/runtime/time/Clock;)Lcom/google/android/datatransport/runtime/scheduling/jobscheduling/WorkScheduler;", "")]
		public unsafe static IWorkScheduler WorkScheduler(Context context, IEventStore eventStore, SchedulerConfig config, IClock clock)
		{
			IWorkScheduler @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((context == null) ? IntPtr.Zero : context.Handle);
				ptr[1] = new JniArgumentValue((eventStore == null) ? IntPtr.Zero : ((Java.Lang.Object)eventStore).Handle);
				ptr[2] = new JniArgumentValue((config == null) ? IntPtr.Zero : config.Handle);
				ptr[3] = new JniArgumentValue((clock == null) ? IntPtr.Zero : ((Java.Lang.Object)clock).Handle);
				@object = Java.Lang.Object.GetObject<IWorkScheduler>(SchedulingModule_WorkSchedulerFactory._members.StaticMethods.InvokeObjectMethod("workScheduler.(Landroid/content/Context;Lcom/google/android/datatransport/runtime/scheduling/persistence/EventStore;Lcom/google/android/datatransport/runtime/scheduling/jobscheduling/SchedulerConfig;Lcom/google/android/datatransport/runtime/time/Clock;)Lcom/google/android/datatransport/runtime/scheduling/jobscheduling/WorkScheduler;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(context);
				GC.KeepAlive(eventStore);
				GC.KeepAlive(config);
				GC.KeepAlive(clock);
			}
			return @object;
		}

		// Token: 0x04000089 RID: 137
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/google/android/datatransport/runtime/scheduling/SchedulingModule_WorkSchedulerFactory", typeof(SchedulingModule_WorkSchedulerFactory));
	}
}
