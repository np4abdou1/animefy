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
	// Token: 0x02000068 RID: 104
	[Register("com/google/android/datatransport/runtime/scheduling/persistence/EventStoreModule_DbNameFactory", DoNotGenerateAcw = true)]
	public sealed class EventStoreModule_DbNameFactory : Java.Lang.Object, IFactory, IProvider, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x17000110 RID: 272
		// (get) Token: 0x06000361 RID: 865 RVA: 0x0000AC5C File Offset: 0x00008E5C
		internal static IntPtr class_ref
		{
			get
			{
				return EventStoreModule_DbNameFactory._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000111 RID: 273
		// (get) Token: 0x06000362 RID: 866 RVA: 0x0000AC80 File Offset: 0x00008E80
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return EventStoreModule_DbNameFactory._members;
			}
		}

		// Token: 0x17000112 RID: 274
		// (get) Token: 0x06000363 RID: 867 RVA: 0x0000AC88 File Offset: 0x00008E88
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return EventStoreModule_DbNameFactory._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000113 RID: 275
		// (get) Token: 0x06000364 RID: 868 RVA: 0x0000ACAC File Offset: 0x00008EAC
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return EventStoreModule_DbNameFactory._members.ManagedPeerType;
			}
		}

		// Token: 0x06000365 RID: 869 RVA: 0x000026C4 File Offset: 0x000008C4
		internal EventStoreModule_DbNameFactory(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06000366 RID: 870 RVA: 0x0000ACB8 File Offset: 0x00008EB8
		[Register(".ctor", "()V", "")]
		public EventStoreModule_DbNameFactory() : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			base.SetHandle(EventStoreModule_DbNameFactory._members.InstanceMethods.StartCreateInstance("()V", base.GetType(), null).Handle, JniHandleOwnership.TransferLocalRef);
			EventStoreModule_DbNameFactory._members.InstanceMethods.FinishCreateInstance("()V", this, null);
		}

		// Token: 0x06000367 RID: 871 RVA: 0x0000AD28 File Offset: 0x00008F28
		[Register("create", "()Lcom/google/android/datatransport/runtime/scheduling/persistence/EventStoreModule_DbNameFactory;", "")]
		public static EventStoreModule_DbNameFactory Create()
		{
			return Java.Lang.Object.GetObject<EventStoreModule_DbNameFactory>(EventStoreModule_DbNameFactory._members.StaticMethods.InvokeObjectMethod("create.()Lcom/google/android/datatransport/runtime/scheduling/persistence/EventStoreModule_DbNameFactory;", null).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x06000368 RID: 872 RVA: 0x0000AD5C File Offset: 0x00008F5C
		[Register("dbName", "()Ljava/lang/String;", "")]
		public static string DbName()
		{
			return JNIEnv.GetString(EventStoreModule_DbNameFactory._members.StaticMethods.InvokeObjectMethod("dbName.()Ljava/lang/String;", null).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x06000369 RID: 873 RVA: 0x0000AD90 File Offset: 0x00008F90
		[Register("get", "()Ljava/lang/String;", "")]
		public Java.Lang.Object Get()
		{
			return JNIEnv.GetString(EventStoreModule_DbNameFactory._members.InstanceMethods.InvokeAbstractObjectMethod("get.()Ljava/lang/String;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x040000C0 RID: 192
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/google/android/datatransport/runtime/scheduling/persistence/EventStoreModule_DbNameFactory", typeof(EventStoreModule_DbNameFactory));
	}
}
