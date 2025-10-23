using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Content;
using Android.Runtime;
using Java.Interop;
using Java.Lang;
using JavaX.Inject;
using Xamarin.Google.Android.DataTransport.Runtime.Dagger.Internal;

namespace Xamarin.Google.Android.DataTransport.Runtime.Backends
{
	// Token: 0x02000095 RID: 149
	[Register("com/google/android/datatransport/runtime/backends/MetadataBackendRegistry_Factory", DoNotGenerateAcw = true)]
	public sealed class MetadataBackendRegistry_Factory : Java.Lang.Object, IFactory, IProvider, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x170001D7 RID: 471
		// (get) Token: 0x06000571 RID: 1393 RVA: 0x000105E4 File Offset: 0x0000E7E4
		internal static IntPtr class_ref
		{
			get
			{
				return MetadataBackendRegistry_Factory._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170001D8 RID: 472
		// (get) Token: 0x06000572 RID: 1394 RVA: 0x00010608 File Offset: 0x0000E808
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return MetadataBackendRegistry_Factory._members;
			}
		}

		// Token: 0x170001D9 RID: 473
		// (get) Token: 0x06000573 RID: 1395 RVA: 0x00010610 File Offset: 0x0000E810
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return MetadataBackendRegistry_Factory._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170001DA RID: 474
		// (get) Token: 0x06000574 RID: 1396 RVA: 0x00010634 File Offset: 0x0000E834
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return MetadataBackendRegistry_Factory._members.ManagedPeerType;
			}
		}

		// Token: 0x06000575 RID: 1397 RVA: 0x000026C4 File Offset: 0x000008C4
		internal MetadataBackendRegistry_Factory(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06000576 RID: 1398 RVA: 0x00010640 File Offset: 0x0000E840
		[Register(".ctor", "(Ljavax/inject/Provider;Ljavax/inject/Provider;)V", "")]
		public unsafe MetadataBackendRegistry_Factory(IProvider applicationContextProvider, IProvider creationContextFactoryProvider) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((applicationContextProvider == null) ? IntPtr.Zero : ((Java.Lang.Object)applicationContextProvider).Handle);
				ptr[1] = new JniArgumentValue((creationContextFactoryProvider == null) ? IntPtr.Zero : ((Java.Lang.Object)creationContextFactoryProvider).Handle);
				base.SetHandle(MetadataBackendRegistry_Factory._members.InstanceMethods.StartCreateInstance("(Ljavax/inject/Provider;Ljavax/inject/Provider;)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				MetadataBackendRegistry_Factory._members.InstanceMethods.FinishCreateInstance("(Ljavax/inject/Provider;Ljavax/inject/Provider;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(applicationContextProvider);
				GC.KeepAlive(creationContextFactoryProvider);
			}
		}

		// Token: 0x06000577 RID: 1399 RVA: 0x00010720 File Offset: 0x0000E920
		[Register("create", "(Ljavax/inject/Provider;Ljavax/inject/Provider;)Lcom/google/android/datatransport/runtime/backends/MetadataBackendRegistry_Factory;", "")]
		public unsafe static MetadataBackendRegistry_Factory Create(IProvider applicationContextProvider, IProvider creationContextFactoryProvider)
		{
			MetadataBackendRegistry_Factory @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((applicationContextProvider == null) ? IntPtr.Zero : ((Java.Lang.Object)applicationContextProvider).Handle);
				ptr[1] = new JniArgumentValue((creationContextFactoryProvider == null) ? IntPtr.Zero : ((Java.Lang.Object)creationContextFactoryProvider).Handle);
				@object = Java.Lang.Object.GetObject<MetadataBackendRegistry_Factory>(MetadataBackendRegistry_Factory._members.StaticMethods.InvokeObjectMethod("create.(Ljavax/inject/Provider;Ljavax/inject/Provider;)Lcom/google/android/datatransport/runtime/backends/MetadataBackendRegistry_Factory;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(applicationContextProvider);
				GC.KeepAlive(creationContextFactoryProvider);
			}
			return @object;
		}

		// Token: 0x06000578 RID: 1400 RVA: 0x000107C4 File Offset: 0x0000E9C4
		[Register("get", "()Ljava/lang/Object;", "")]
		public Java.Lang.Object Get()
		{
			return Java.Lang.Object.GetObject<Java.Lang.Object>(MetadataBackendRegistry_Factory._members.InstanceMethods.InvokeAbstractObjectMethod("get.()Ljava/lang/Object;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x06000579 RID: 1401 RVA: 0x000107F8 File Offset: 0x0000E9F8
		[Register("newInstance", "(Landroid/content/Context;Ljava/lang/Object;)Ljava/lang/Object;", "")]
		public unsafe static Java.Lang.Object NewInstance(Context applicationContext, Java.Lang.Object creationContextFactory)
		{
			Java.Lang.Object @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((applicationContext == null) ? IntPtr.Zero : applicationContext.Handle);
				ptr[1] = new JniArgumentValue((creationContextFactory == null) ? IntPtr.Zero : creationContextFactory.Handle);
				@object = Java.Lang.Object.GetObject<Java.Lang.Object>(MetadataBackendRegistry_Factory._members.StaticMethods.InvokeObjectMethod("newInstance.(Landroid/content/Context;Ljava/lang/Object;)Ljava/lang/Object;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(applicationContext);
				GC.KeepAlive(creationContextFactory);
			}
			return @object;
		}

		// Token: 0x0400012C RID: 300
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/google/android/datatransport/runtime/backends/MetadataBackendRegistry_Factory", typeof(MetadataBackendRegistry_Factory));
	}
}
