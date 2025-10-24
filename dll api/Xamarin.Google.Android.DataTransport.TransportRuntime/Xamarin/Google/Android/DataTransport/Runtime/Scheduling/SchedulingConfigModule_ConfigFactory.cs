using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;
using JavaX.Inject;
using Xamarin.Google.Android.DataTransport.Runtime.Dagger.Internal;
using Xamarin.Google.Android.DataTransport.Runtime.Scheduling.JobScheduling;
using Xamarin.Google.Android.DataTransport.Runtime.Time;

namespace Xamarin.Google.Android.DataTransport.Runtime.Scheduling
{
	// Token: 0x0200004B RID: 75
	[Register("com/google/android/datatransport/runtime/scheduling/SchedulingConfigModule_ConfigFactory", DoNotGenerateAcw = true)]
	public sealed class SchedulingConfigModule_ConfigFactory : Java.Lang.Object, IFactory, IProvider, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x170000AF RID: 175
		// (get) Token: 0x0600024F RID: 591 RVA: 0x0000727C File Offset: 0x0000547C
		internal static IntPtr class_ref
		{
			get
			{
				return SchedulingConfigModule_ConfigFactory._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170000B0 RID: 176
		// (get) Token: 0x06000250 RID: 592 RVA: 0x000072A0 File Offset: 0x000054A0
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return SchedulingConfigModule_ConfigFactory._members;
			}
		}

		// Token: 0x170000B1 RID: 177
		// (get) Token: 0x06000251 RID: 593 RVA: 0x000072A8 File Offset: 0x000054A8
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return SchedulingConfigModule_ConfigFactory._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170000B2 RID: 178
		// (get) Token: 0x06000252 RID: 594 RVA: 0x000072CC File Offset: 0x000054CC
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return SchedulingConfigModule_ConfigFactory._members.ManagedPeerType;
			}
		}

		// Token: 0x06000253 RID: 595 RVA: 0x000026C4 File Offset: 0x000008C4
		internal SchedulingConfigModule_ConfigFactory(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06000254 RID: 596 RVA: 0x000072D8 File Offset: 0x000054D8
		[Register(".ctor", "(Ljavax/inject/Provider;)V", "")]
		public unsafe SchedulingConfigModule_ConfigFactory(IProvider clockProvider) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((clockProvider == null) ? IntPtr.Zero : ((Java.Lang.Object)clockProvider).Handle);
				base.SetHandle(SchedulingConfigModule_ConfigFactory._members.InstanceMethods.StartCreateInstance("(Ljavax/inject/Provider;)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				SchedulingConfigModule_ConfigFactory._members.InstanceMethods.FinishCreateInstance("(Ljavax/inject/Provider;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(clockProvider);
			}
		}

		// Token: 0x06000255 RID: 597 RVA: 0x0000738C File Offset: 0x0000558C
		[Register("config", "(Lcom/google/android/datatransport/runtime/time/Clock;)Lcom/google/android/datatransport/runtime/scheduling/jobscheduling/SchedulerConfig;", "")]
		public unsafe static SchedulerConfig Config(IClock clock)
		{
			SchedulerConfig @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((clock == null) ? IntPtr.Zero : ((Java.Lang.Object)clock).Handle);
				@object = Java.Lang.Object.GetObject<SchedulerConfig>(SchedulingConfigModule_ConfigFactory._members.StaticMethods.InvokeObjectMethod("config.(Lcom/google/android/datatransport/runtime/time/Clock;)Lcom/google/android/datatransport/runtime/scheduling/jobscheduling/SchedulerConfig;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(clock);
			}
			return @object;
		}

		// Token: 0x06000256 RID: 598 RVA: 0x00007404 File Offset: 0x00005604
		[Register("create", "(Ljavax/inject/Provider;)Lcom/google/android/datatransport/runtime/scheduling/SchedulingConfigModule_ConfigFactory;", "")]
		public unsafe static SchedulingConfigModule_ConfigFactory Create(IProvider clockProvider)
		{
			SchedulingConfigModule_ConfigFactory @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((clockProvider == null) ? IntPtr.Zero : ((Java.Lang.Object)clockProvider).Handle);
				@object = Java.Lang.Object.GetObject<SchedulingConfigModule_ConfigFactory>(SchedulingConfigModule_ConfigFactory._members.StaticMethods.InvokeObjectMethod("create.(Ljavax/inject/Provider;)Lcom/google/android/datatransport/runtime/scheduling/SchedulingConfigModule_ConfigFactory;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(clockProvider);
			}
			return @object;
		}

		// Token: 0x06000257 RID: 599 RVA: 0x0000747C File Offset: 0x0000567C
		[Register("get", "()Lcom/google/android/datatransport/runtime/scheduling/jobscheduling/SchedulerConfig;", "")]
		public Java.Lang.Object Get()
		{
			return Java.Lang.Object.GetObject<Java.Lang.Object>(SchedulingConfigModule_ConfigFactory._members.InstanceMethods.InvokeAbstractObjectMethod("get.()Lcom/google/android/datatransport/runtime/scheduling/jobscheduling/SchedulerConfig;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x04000086 RID: 134
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/google/android/datatransport/runtime/scheduling/SchedulingConfigModule_ConfigFactory", typeof(SchedulingConfigModule_ConfigFactory));
	}
}
