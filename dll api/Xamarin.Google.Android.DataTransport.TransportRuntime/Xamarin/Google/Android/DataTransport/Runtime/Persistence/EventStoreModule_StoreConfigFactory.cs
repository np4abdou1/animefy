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
	// Token: 0x0200006B RID: 107
	[Register("com/google/android/datatransport/runtime/scheduling/persistence/EventStoreModule_StoreConfigFactory", DoNotGenerateAcw = true)]
	public sealed class EventStoreModule_StoreConfigFactory : Java.Lang.Object, IFactory, IProvider, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x1700011C RID: 284
		// (get) Token: 0x0600037F RID: 895 RVA: 0x0000B19C File Offset: 0x0000939C
		internal static IntPtr class_ref
		{
			get
			{
				return EventStoreModule_StoreConfigFactory._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700011D RID: 285
		// (get) Token: 0x06000380 RID: 896 RVA: 0x0000B1C0 File Offset: 0x000093C0
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return EventStoreModule_StoreConfigFactory._members;
			}
		}

		// Token: 0x1700011E RID: 286
		// (get) Token: 0x06000381 RID: 897 RVA: 0x0000B1C8 File Offset: 0x000093C8
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return EventStoreModule_StoreConfigFactory._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700011F RID: 287
		// (get) Token: 0x06000382 RID: 898 RVA: 0x0000B1EC File Offset: 0x000093EC
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return EventStoreModule_StoreConfigFactory._members.ManagedPeerType;
			}
		}

		// Token: 0x06000383 RID: 899 RVA: 0x000026C4 File Offset: 0x000008C4
		internal EventStoreModule_StoreConfigFactory(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06000384 RID: 900 RVA: 0x0000B1F8 File Offset: 0x000093F8
		[Register(".ctor", "()V", "")]
		public EventStoreModule_StoreConfigFactory() : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			base.SetHandle(EventStoreModule_StoreConfigFactory._members.InstanceMethods.StartCreateInstance("()V", base.GetType(), null).Handle, JniHandleOwnership.TransferLocalRef);
			EventStoreModule_StoreConfigFactory._members.InstanceMethods.FinishCreateInstance("()V", this, null);
		}

		// Token: 0x06000385 RID: 901 RVA: 0x0000B268 File Offset: 0x00009468
		[Register("create", "()Lcom/google/android/datatransport/runtime/scheduling/persistence/EventStoreModule_StoreConfigFactory;", "")]
		public static EventStoreModule_StoreConfigFactory Create()
		{
			return Java.Lang.Object.GetObject<EventStoreModule_StoreConfigFactory>(EventStoreModule_StoreConfigFactory._members.StaticMethods.InvokeObjectMethod("create.()Lcom/google/android/datatransport/runtime/scheduling/persistence/EventStoreModule_StoreConfigFactory;", null).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x06000386 RID: 902 RVA: 0x0000B29C File Offset: 0x0000949C
		[Register("get", "()Ljava/lang/Object;", "")]
		public Java.Lang.Object Get()
		{
			return Java.Lang.Object.GetObject<Java.Lang.Object>(EventStoreModule_StoreConfigFactory._members.InstanceMethods.InvokeAbstractObjectMethod("get.()Ljava/lang/Object;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x06000387 RID: 903 RVA: 0x0000B2D0 File Offset: 0x000094D0
		[Register("storeConfig", "()Ljava/lang/Object;", "")]
		public static Java.Lang.Object StoreConfig()
		{
			return Java.Lang.Object.GetObject<Java.Lang.Object>(EventStoreModule_StoreConfigFactory._members.StaticMethods.InvokeObjectMethod("storeConfig.()Ljava/lang/Object;", null).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x040000C3 RID: 195
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/google/android/datatransport/runtime/scheduling/persistence/EventStoreModule_StoreConfigFactory", typeof(EventStoreModule_StoreConfigFactory));
	}
}
