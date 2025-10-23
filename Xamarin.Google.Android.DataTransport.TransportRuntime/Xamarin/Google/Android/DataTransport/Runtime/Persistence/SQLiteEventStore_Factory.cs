using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;
using JavaX.Inject;
using Xamarin.Google.Android.DataTransport.Runtime.Dagger.Internal;
using Xamarin.Google.Android.DataTransport.Runtime.Time;

namespace Xamarin.Google.Android.DataTransport.Runtime.Persistence
{
	// Token: 0x02000074 RID: 116
	[Register("com/google/android/datatransport/runtime/scheduling/persistence/SQLiteEventStore_Factory", DoNotGenerateAcw = true)]
	public sealed class SQLiteEventStore_Factory : Java.Lang.Object, IFactory, IProvider, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x1700013C RID: 316
		// (get) Token: 0x06000423 RID: 1059 RVA: 0x0000CD94 File Offset: 0x0000AF94
		internal static IntPtr class_ref
		{
			get
			{
				return SQLiteEventStore_Factory._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700013D RID: 317
		// (get) Token: 0x06000424 RID: 1060 RVA: 0x0000CDB8 File Offset: 0x0000AFB8
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return SQLiteEventStore_Factory._members;
			}
		}

		// Token: 0x1700013E RID: 318
		// (get) Token: 0x06000425 RID: 1061 RVA: 0x0000CDC0 File Offset: 0x0000AFC0
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return SQLiteEventStore_Factory._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700013F RID: 319
		// (get) Token: 0x06000426 RID: 1062 RVA: 0x0000CDE4 File Offset: 0x0000AFE4
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return SQLiteEventStore_Factory._members.ManagedPeerType;
			}
		}

		// Token: 0x06000427 RID: 1063 RVA: 0x000026C4 File Offset: 0x000008C4
		internal SQLiteEventStore_Factory(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06000428 RID: 1064 RVA: 0x0000CDF0 File Offset: 0x0000AFF0
		[Register(".ctor", "(Ljavax/inject/Provider;Ljavax/inject/Provider;Ljavax/inject/Provider;Ljavax/inject/Provider;Ljavax/inject/Provider;)V", "")]
		public unsafe SQLiteEventStore_Factory(IProvider wallClockProvider, IProvider clockProvider, IProvider configProvider, IProvider schemaManagerProvider, IProvider packageNameProvider) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((wallClockProvider == null) ? IntPtr.Zero : ((Java.Lang.Object)wallClockProvider).Handle);
				ptr[1] = new JniArgumentValue((clockProvider == null) ? IntPtr.Zero : ((Java.Lang.Object)clockProvider).Handle);
				ptr[2] = new JniArgumentValue((configProvider == null) ? IntPtr.Zero : ((Java.Lang.Object)configProvider).Handle);
				ptr[3] = new JniArgumentValue((schemaManagerProvider == null) ? IntPtr.Zero : ((Java.Lang.Object)schemaManagerProvider).Handle);
				ptr[4] = new JniArgumentValue((packageNameProvider == null) ? IntPtr.Zero : ((Java.Lang.Object)packageNameProvider).Handle);
				base.SetHandle(SQLiteEventStore_Factory._members.InstanceMethods.StartCreateInstance("(Ljavax/inject/Provider;Ljavax/inject/Provider;Ljavax/inject/Provider;Ljavax/inject/Provider;Ljavax/inject/Provider;)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				SQLiteEventStore_Factory._members.InstanceMethods.FinishCreateInstance("(Ljavax/inject/Provider;Ljavax/inject/Provider;Ljavax/inject/Provider;Ljavax/inject/Provider;Ljavax/inject/Provider;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(wallClockProvider);
				GC.KeepAlive(clockProvider);
				GC.KeepAlive(configProvider);
				GC.KeepAlive(schemaManagerProvider);
				GC.KeepAlive(packageNameProvider);
			}
		}

		// Token: 0x06000429 RID: 1065 RVA: 0x0000CF74 File Offset: 0x0000B174
		[Register("create", "(Ljavax/inject/Provider;Ljavax/inject/Provider;Ljavax/inject/Provider;Ljavax/inject/Provider;Ljavax/inject/Provider;)Lcom/google/android/datatransport/runtime/scheduling/persistence/SQLiteEventStore_Factory;", "")]
		public unsafe static SQLiteEventStore_Factory Create(IProvider wallClockProvider, IProvider clockProvider, IProvider configProvider, IProvider schemaManagerProvider, IProvider packageNameProvider)
		{
			SQLiteEventStore_Factory @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((wallClockProvider == null) ? IntPtr.Zero : ((Java.Lang.Object)wallClockProvider).Handle);
				ptr[1] = new JniArgumentValue((clockProvider == null) ? IntPtr.Zero : ((Java.Lang.Object)clockProvider).Handle);
				ptr[2] = new JniArgumentValue((configProvider == null) ? IntPtr.Zero : ((Java.Lang.Object)configProvider).Handle);
				ptr[3] = new JniArgumentValue((schemaManagerProvider == null) ? IntPtr.Zero : ((Java.Lang.Object)schemaManagerProvider).Handle);
				ptr[4] = new JniArgumentValue((packageNameProvider == null) ? IntPtr.Zero : ((Java.Lang.Object)packageNameProvider).Handle);
				@object = Java.Lang.Object.GetObject<SQLiteEventStore_Factory>(SQLiteEventStore_Factory._members.StaticMethods.InvokeObjectMethod("create.(Ljavax/inject/Provider;Ljavax/inject/Provider;Ljavax/inject/Provider;Ljavax/inject/Provider;Ljavax/inject/Provider;)Lcom/google/android/datatransport/runtime/scheduling/persistence/SQLiteEventStore_Factory;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(wallClockProvider);
				GC.KeepAlive(clockProvider);
				GC.KeepAlive(configProvider);
				GC.KeepAlive(schemaManagerProvider);
				GC.KeepAlive(packageNameProvider);
			}
			return @object;
		}

		// Token: 0x0600042A RID: 1066 RVA: 0x0000D0AC File Offset: 0x0000B2AC
		[Register("get", "()Lcom/google/android/datatransport/runtime/scheduling/persistence/SQLiteEventStore;", "")]
		public Java.Lang.Object Get()
		{
			return Java.Lang.Object.GetObject<Java.Lang.Object>(SQLiteEventStore_Factory._members.InstanceMethods.InvokeAbstractObjectMethod("get.()Lcom/google/android/datatransport/runtime/scheduling/persistence/SQLiteEventStore;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x0600042B RID: 1067 RVA: 0x0000D0E0 File Offset: 0x0000B2E0
		[Register("newInstance", "(Lcom/google/android/datatransport/runtime/time/Clock;Lcom/google/android/datatransport/runtime/time/Clock;Ljava/lang/Object;Ljava/lang/Object;Ljavax/inject/Provider;)Lcom/google/android/datatransport/runtime/scheduling/persistence/SQLiteEventStore;", "")]
		public unsafe static SQLiteEventStore NewInstance(IClock wallClock, IClock clock, Java.Lang.Object config, Java.Lang.Object schemaManager, IProvider packageName)
		{
			SQLiteEventStore @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((wallClock == null) ? IntPtr.Zero : ((Java.Lang.Object)wallClock).Handle);
				ptr[1] = new JniArgumentValue((clock == null) ? IntPtr.Zero : ((Java.Lang.Object)clock).Handle);
				ptr[2] = new JniArgumentValue((config == null) ? IntPtr.Zero : config.Handle);
				ptr[3] = new JniArgumentValue((schemaManager == null) ? IntPtr.Zero : schemaManager.Handle);
				ptr[4] = new JniArgumentValue((packageName == null) ? IntPtr.Zero : ((Java.Lang.Object)packageName).Handle);
				@object = Java.Lang.Object.GetObject<SQLiteEventStore>(SQLiteEventStore_Factory._members.StaticMethods.InvokeObjectMethod("newInstance.(Lcom/google/android/datatransport/runtime/time/Clock;Lcom/google/android/datatransport/runtime/time/Clock;Ljava/lang/Object;Ljava/lang/Object;Ljavax/inject/Provider;)Lcom/google/android/datatransport/runtime/scheduling/persistence/SQLiteEventStore;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(wallClock);
				GC.KeepAlive(clock);
				GC.KeepAlive(config);
				GC.KeepAlive(schemaManager);
				GC.KeepAlive(packageName);
			}
			return @object;
		}

		// Token: 0x040000F8 RID: 248
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/google/android/datatransport/runtime/scheduling/persistence/SQLiteEventStore_Factory", typeof(SQLiteEventStore_Factory));
	}
}
