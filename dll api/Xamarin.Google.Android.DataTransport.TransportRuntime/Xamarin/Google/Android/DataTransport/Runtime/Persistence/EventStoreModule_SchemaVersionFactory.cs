using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;
using JavaX.Inject;
using Xamarin.Google.Android.DataTransport.Runtime.Dagger.Internal;

namespace Xamarin.Google.Android.DataTransport.Runtime.Persistence
{
	// Token: 0x0200006A RID: 106
	[Register("com/google/android/datatransport/runtime/scheduling/persistence/EventStoreModule_SchemaVersionFactory", DoNotGenerateAcw = true)]
	public sealed class EventStoreModule_SchemaVersionFactory : Java.Lang.Object, IFactory, IProvider, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x17000118 RID: 280
		// (get) Token: 0x06000375 RID: 885 RVA: 0x0000B034 File Offset: 0x00009234
		internal static IntPtr class_ref
		{
			get
			{
				return EventStoreModule_SchemaVersionFactory._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000119 RID: 281
		// (get) Token: 0x06000376 RID: 886 RVA: 0x0000B058 File Offset: 0x00009258
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return EventStoreModule_SchemaVersionFactory._members;
			}
		}

		// Token: 0x1700011A RID: 282
		// (get) Token: 0x06000377 RID: 887 RVA: 0x0000B060 File Offset: 0x00009260
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return EventStoreModule_SchemaVersionFactory._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700011B RID: 283
		// (get) Token: 0x06000378 RID: 888 RVA: 0x0000B084 File Offset: 0x00009284
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return EventStoreModule_SchemaVersionFactory._members.ManagedPeerType;
			}
		}

		// Token: 0x06000379 RID: 889 RVA: 0x000026C4 File Offset: 0x000008C4
		internal EventStoreModule_SchemaVersionFactory(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x0600037A RID: 890 RVA: 0x0000B090 File Offset: 0x00009290
		[Register(".ctor", "()V", "")]
		public EventStoreModule_SchemaVersionFactory() : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			base.SetHandle(EventStoreModule_SchemaVersionFactory._members.InstanceMethods.StartCreateInstance("()V", base.GetType(), null).Handle, JniHandleOwnership.TransferLocalRef);
			EventStoreModule_SchemaVersionFactory._members.InstanceMethods.FinishCreateInstance("()V", this, null);
		}

		// Token: 0x0600037B RID: 891 RVA: 0x0000B100 File Offset: 0x00009300
		[Register("create", "()Lcom/google/android/datatransport/runtime/scheduling/persistence/EventStoreModule_SchemaVersionFactory;", "")]
		public static EventStoreModule_SchemaVersionFactory Create()
		{
			return Java.Lang.Object.GetObject<EventStoreModule_SchemaVersionFactory>(EventStoreModule_SchemaVersionFactory._members.StaticMethods.InvokeObjectMethod("create.()Lcom/google/android/datatransport/runtime/scheduling/persistence/EventStoreModule_SchemaVersionFactory;", null).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x0600037C RID: 892 RVA: 0x0000B134 File Offset: 0x00009334
		[Register("get", "()Ljava/lang/Integer;", "")]
		public Java.Lang.Object Get()
		{
			return Java.Lang.Object.GetObject<Java.Lang.Object>(EventStoreModule_SchemaVersionFactory._members.InstanceMethods.InvokeAbstractObjectMethod("get.()Ljava/lang/Integer;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x0600037D RID: 893 RVA: 0x0000B166 File Offset: 0x00009366
		[Register("schemaVersion", "()I", "")]
		public static int SchemaVersion()
		{
			return EventStoreModule_SchemaVersionFactory._members.StaticMethods.InvokeInt32Method("schemaVersion.()I", null);
		}

		// Token: 0x040000C2 RID: 194
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/google/android/datatransport/runtime/scheduling/persistence/EventStoreModule_SchemaVersionFactory", typeof(EventStoreModule_SchemaVersionFactory));
	}
}
