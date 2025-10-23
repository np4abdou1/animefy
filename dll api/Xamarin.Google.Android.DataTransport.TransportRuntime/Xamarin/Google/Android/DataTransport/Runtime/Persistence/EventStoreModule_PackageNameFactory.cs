using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Content;
using Android.Runtime;
using Java.Interop;
using Java.Lang;
using JavaX.Inject;
using Xamarin.Google.Android.DataTransport.Runtime.Dagger.Internal;

namespace Xamarin.Google.Android.DataTransport.Runtime.Persistence
{
	// Token: 0x02000069 RID: 105
	[Register("com/google/android/datatransport/runtime/scheduling/persistence/EventStoreModule_PackageNameFactory", DoNotGenerateAcw = true)]
	public sealed class EventStoreModule_PackageNameFactory : Java.Lang.Object, IFactory, IProvider, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x17000114 RID: 276
		// (get) Token: 0x0600036B RID: 875 RVA: 0x0000ADE4 File Offset: 0x00008FE4
		internal static IntPtr class_ref
		{
			get
			{
				return EventStoreModule_PackageNameFactory._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000115 RID: 277
		// (get) Token: 0x0600036C RID: 876 RVA: 0x0000AE08 File Offset: 0x00009008
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return EventStoreModule_PackageNameFactory._members;
			}
		}

		// Token: 0x17000116 RID: 278
		// (get) Token: 0x0600036D RID: 877 RVA: 0x0000AE10 File Offset: 0x00009010
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return EventStoreModule_PackageNameFactory._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000117 RID: 279
		// (get) Token: 0x0600036E RID: 878 RVA: 0x0000AE34 File Offset: 0x00009034
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return EventStoreModule_PackageNameFactory._members.ManagedPeerType;
			}
		}

		// Token: 0x0600036F RID: 879 RVA: 0x000026C4 File Offset: 0x000008C4
		internal EventStoreModule_PackageNameFactory(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06000370 RID: 880 RVA: 0x0000AE40 File Offset: 0x00009040
		[Register(".ctor", "(Ljavax/inject/Provider;)V", "")]
		public unsafe EventStoreModule_PackageNameFactory(IProvider contextProvider) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((contextProvider == null) ? IntPtr.Zero : ((Java.Lang.Object)contextProvider).Handle);
				base.SetHandle(EventStoreModule_PackageNameFactory._members.InstanceMethods.StartCreateInstance("(Ljavax/inject/Provider;)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				EventStoreModule_PackageNameFactory._members.InstanceMethods.FinishCreateInstance("(Ljavax/inject/Provider;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(contextProvider);
			}
		}

		// Token: 0x06000371 RID: 881 RVA: 0x0000AEF4 File Offset: 0x000090F4
		[Register("create", "(Ljavax/inject/Provider;)Lcom/google/android/datatransport/runtime/scheduling/persistence/EventStoreModule_PackageNameFactory;", "")]
		public unsafe static EventStoreModule_PackageNameFactory Create(IProvider contextProvider)
		{
			EventStoreModule_PackageNameFactory @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((contextProvider == null) ? IntPtr.Zero : ((Java.Lang.Object)contextProvider).Handle);
				@object = Java.Lang.Object.GetObject<EventStoreModule_PackageNameFactory>(EventStoreModule_PackageNameFactory._members.StaticMethods.InvokeObjectMethod("create.(Ljavax/inject/Provider;)Lcom/google/android/datatransport/runtime/scheduling/persistence/EventStoreModule_PackageNameFactory;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(contextProvider);
			}
			return @object;
		}

		// Token: 0x06000372 RID: 882 RVA: 0x0000AF6C File Offset: 0x0000916C
		[Register("get", "()Ljava/lang/String;", "")]
		public Java.Lang.Object Get()
		{
			return JNIEnv.GetString(EventStoreModule_PackageNameFactory._members.InstanceMethods.InvokeAbstractObjectMethod("get.()Ljava/lang/String;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x06000373 RID: 883 RVA: 0x0000AFA4 File Offset: 0x000091A4
		[Register("packageName", "(Landroid/content/Context;)Ljava/lang/String;", "")]
		public unsafe static string PackageName(Context context)
		{
			string @string;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((context == null) ? IntPtr.Zero : context.Handle);
				@string = JNIEnv.GetString(EventStoreModule_PackageNameFactory._members.StaticMethods.InvokeObjectMethod("packageName.(Landroid/content/Context;)Ljava/lang/String;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(context);
			}
			return @string;
		}

		// Token: 0x040000C1 RID: 193
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/google/android/datatransport/runtime/scheduling/persistence/EventStoreModule_PackageNameFactory", typeof(EventStoreModule_PackageNameFactory));
	}
}
