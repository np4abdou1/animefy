using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;
using JavaX.Inject;
using Xamarin.Google.Android.DataTransport.Runtime.Dagger.Internal;
using Xamarin.Google.Android.DataTransport.Runtime.Scheduling;
using Xamarin.Google.Android.DataTransport.Runtime.Scheduling.JobScheduling;
using Xamarin.Google.Android.DataTransport.Runtime.Time;

namespace Xamarin.Google.Android.DataTransport.Runtime
{
	// Token: 0x0200002F RID: 47
	[Register("com/google/android/datatransport/runtime/TransportRuntime_Factory", DoNotGenerateAcw = true)]
	public sealed class TransportRuntime_Factory : Java.Lang.Object, IFactory, IProvider, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x1700005E RID: 94
		// (get) Token: 0x06000173 RID: 371 RVA: 0x00004C60 File Offset: 0x00002E60
		internal static IntPtr class_ref
		{
			get
			{
				return TransportRuntime_Factory._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700005F RID: 95
		// (get) Token: 0x06000174 RID: 372 RVA: 0x00004C84 File Offset: 0x00002E84
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return TransportRuntime_Factory._members;
			}
		}

		// Token: 0x17000060 RID: 96
		// (get) Token: 0x06000175 RID: 373 RVA: 0x00004C8C File Offset: 0x00002E8C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return TransportRuntime_Factory._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000061 RID: 97
		// (get) Token: 0x06000176 RID: 374 RVA: 0x00004CB0 File Offset: 0x00002EB0
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return TransportRuntime_Factory._members.ManagedPeerType;
			}
		}

		// Token: 0x06000177 RID: 375 RVA: 0x000026C4 File Offset: 0x000008C4
		internal TransportRuntime_Factory(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06000178 RID: 376 RVA: 0x00004CBC File Offset: 0x00002EBC
		[Register(".ctor", "(Ljavax/inject/Provider;Ljavax/inject/Provider;Ljavax/inject/Provider;Ljavax/inject/Provider;Ljavax/inject/Provider;)V", "")]
		public unsafe TransportRuntime_Factory(IProvider eventClockProvider, IProvider uptimeClockProvider, IProvider schedulerProvider, IProvider uploaderProvider, IProvider initializerProvider) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((eventClockProvider == null) ? IntPtr.Zero : ((Java.Lang.Object)eventClockProvider).Handle);
				ptr[1] = new JniArgumentValue((uptimeClockProvider == null) ? IntPtr.Zero : ((Java.Lang.Object)uptimeClockProvider).Handle);
				ptr[2] = new JniArgumentValue((schedulerProvider == null) ? IntPtr.Zero : ((Java.Lang.Object)schedulerProvider).Handle);
				ptr[3] = new JniArgumentValue((uploaderProvider == null) ? IntPtr.Zero : ((Java.Lang.Object)uploaderProvider).Handle);
				ptr[4] = new JniArgumentValue((initializerProvider == null) ? IntPtr.Zero : ((Java.Lang.Object)initializerProvider).Handle);
				base.SetHandle(TransportRuntime_Factory._members.InstanceMethods.StartCreateInstance("(Ljavax/inject/Provider;Ljavax/inject/Provider;Ljavax/inject/Provider;Ljavax/inject/Provider;Ljavax/inject/Provider;)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				TransportRuntime_Factory._members.InstanceMethods.FinishCreateInstance("(Ljavax/inject/Provider;Ljavax/inject/Provider;Ljavax/inject/Provider;Ljavax/inject/Provider;Ljavax/inject/Provider;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(eventClockProvider);
				GC.KeepAlive(uptimeClockProvider);
				GC.KeepAlive(schedulerProvider);
				GC.KeepAlive(uploaderProvider);
				GC.KeepAlive(initializerProvider);
			}
		}

		// Token: 0x06000179 RID: 377 RVA: 0x00004E40 File Offset: 0x00003040
		[Register("create", "(Ljavax/inject/Provider;Ljavax/inject/Provider;Ljavax/inject/Provider;Ljavax/inject/Provider;Ljavax/inject/Provider;)Lcom/google/android/datatransport/runtime/TransportRuntime_Factory;", "")]
		public unsafe static TransportRuntime_Factory Create(IProvider eventClockProvider, IProvider uptimeClockProvider, IProvider schedulerProvider, IProvider uploaderProvider, IProvider initializerProvider)
		{
			TransportRuntime_Factory @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((eventClockProvider == null) ? IntPtr.Zero : ((Java.Lang.Object)eventClockProvider).Handle);
				ptr[1] = new JniArgumentValue((uptimeClockProvider == null) ? IntPtr.Zero : ((Java.Lang.Object)uptimeClockProvider).Handle);
				ptr[2] = new JniArgumentValue((schedulerProvider == null) ? IntPtr.Zero : ((Java.Lang.Object)schedulerProvider).Handle);
				ptr[3] = new JniArgumentValue((uploaderProvider == null) ? IntPtr.Zero : ((Java.Lang.Object)uploaderProvider).Handle);
				ptr[4] = new JniArgumentValue((initializerProvider == null) ? IntPtr.Zero : ((Java.Lang.Object)initializerProvider).Handle);
				@object = Java.Lang.Object.GetObject<TransportRuntime_Factory>(TransportRuntime_Factory._members.StaticMethods.InvokeObjectMethod("create.(Ljavax/inject/Provider;Ljavax/inject/Provider;Ljavax/inject/Provider;Ljavax/inject/Provider;Ljavax/inject/Provider;)Lcom/google/android/datatransport/runtime/TransportRuntime_Factory;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(eventClockProvider);
				GC.KeepAlive(uptimeClockProvider);
				GC.KeepAlive(schedulerProvider);
				GC.KeepAlive(uploaderProvider);
				GC.KeepAlive(initializerProvider);
			}
			return @object;
		}

		// Token: 0x0600017A RID: 378 RVA: 0x00004F78 File Offset: 0x00003178
		[Register("get", "()Lcom/google/android/datatransport/runtime/TransportRuntime;", "")]
		public Java.Lang.Object Get()
		{
			return Java.Lang.Object.GetObject<Java.Lang.Object>(TransportRuntime_Factory._members.InstanceMethods.InvokeAbstractObjectMethod("get.()Lcom/google/android/datatransport/runtime/TransportRuntime;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x0600017B RID: 379 RVA: 0x00004FAC File Offset: 0x000031AC
		[Register("newInstance", "(Lcom/google/android/datatransport/runtime/time/Clock;Lcom/google/android/datatransport/runtime/time/Clock;Lcom/google/android/datatransport/runtime/scheduling/Scheduler;Lcom/google/android/datatransport/runtime/scheduling/jobscheduling/Uploader;Lcom/google/android/datatransport/runtime/scheduling/jobscheduling/WorkInitializer;)Lcom/google/android/datatransport/runtime/TransportRuntime;", "")]
		public unsafe static TransportRuntime NewInstance(IClock eventClock, IClock uptimeClock, IScheduler scheduler, Uploader uploader, WorkInitializer initializer)
		{
			TransportRuntime @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((eventClock == null) ? IntPtr.Zero : ((Java.Lang.Object)eventClock).Handle);
				ptr[1] = new JniArgumentValue((uptimeClock == null) ? IntPtr.Zero : ((Java.Lang.Object)uptimeClock).Handle);
				ptr[2] = new JniArgumentValue((scheduler == null) ? IntPtr.Zero : ((Java.Lang.Object)scheduler).Handle);
				ptr[3] = new JniArgumentValue((uploader == null) ? IntPtr.Zero : uploader.Handle);
				ptr[4] = new JniArgumentValue((initializer == null) ? IntPtr.Zero : initializer.Handle);
				@object = Java.Lang.Object.GetObject<TransportRuntime>(TransportRuntime_Factory._members.StaticMethods.InvokeObjectMethod("newInstance.(Lcom/google/android/datatransport/runtime/time/Clock;Lcom/google/android/datatransport/runtime/time/Clock;Lcom/google/android/datatransport/runtime/scheduling/Scheduler;Lcom/google/android/datatransport/runtime/scheduling/jobscheduling/Uploader;Lcom/google/android/datatransport/runtime/scheduling/jobscheduling/WorkInitializer;)Lcom/google/android/datatransport/runtime/TransportRuntime;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(eventClock);
				GC.KeepAlive(uptimeClock);
				GC.KeepAlive(scheduler);
				GC.KeepAlive(uploader);
				GC.KeepAlive(initializer);
			}
			return @object;
		}

		// Token: 0x0400004E RID: 78
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/google/android/datatransport/runtime/TransportRuntime_Factory", typeof(TransportRuntime_Factory));
	}
}
