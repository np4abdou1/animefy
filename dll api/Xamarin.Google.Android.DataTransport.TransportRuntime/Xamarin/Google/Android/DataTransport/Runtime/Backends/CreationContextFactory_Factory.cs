using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Content;
using Android.Runtime;
using Java.Interop;
using Java.Lang;
using JavaX.Inject;
using Xamarin.Google.Android.DataTransport.Runtime.Dagger.Internal;
using Xamarin.Google.Android.DataTransport.Runtime.Time;

namespace Xamarin.Google.Android.DataTransport.Runtime.Backends
{
	// Token: 0x0200008E RID: 142
	[Register("com/google/android/datatransport/runtime/backends/CreationContextFactory_Factory", DoNotGenerateAcw = true)]
	public sealed class CreationContextFactory_Factory : Java.Lang.Object, IFactory, IProvider, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x170001C7 RID: 455
		// (get) Token: 0x0600053C RID: 1340 RVA: 0x0000FC88 File Offset: 0x0000DE88
		internal static IntPtr class_ref
		{
			get
			{
				return CreationContextFactory_Factory._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170001C8 RID: 456
		// (get) Token: 0x0600053D RID: 1341 RVA: 0x0000FCAC File Offset: 0x0000DEAC
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return CreationContextFactory_Factory._members;
			}
		}

		// Token: 0x170001C9 RID: 457
		// (get) Token: 0x0600053E RID: 1342 RVA: 0x0000FCB4 File Offset: 0x0000DEB4
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return CreationContextFactory_Factory._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170001CA RID: 458
		// (get) Token: 0x0600053F RID: 1343 RVA: 0x0000FCD8 File Offset: 0x0000DED8
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return CreationContextFactory_Factory._members.ManagedPeerType;
			}
		}

		// Token: 0x06000540 RID: 1344 RVA: 0x000026C4 File Offset: 0x000008C4
		internal CreationContextFactory_Factory(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06000541 RID: 1345 RVA: 0x0000FCE4 File Offset: 0x0000DEE4
		[Register(".ctor", "(Ljavax/inject/Provider;Ljavax/inject/Provider;Ljavax/inject/Provider;)V", "")]
		public unsafe CreationContextFactory_Factory(IProvider applicationContextProvider, IProvider wallClockProvider, IProvider monotonicClockProvider) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((applicationContextProvider == null) ? IntPtr.Zero : ((Java.Lang.Object)applicationContextProvider).Handle);
				ptr[1] = new JniArgumentValue((wallClockProvider == null) ? IntPtr.Zero : ((Java.Lang.Object)wallClockProvider).Handle);
				ptr[2] = new JniArgumentValue((monotonicClockProvider == null) ? IntPtr.Zero : ((Java.Lang.Object)monotonicClockProvider).Handle);
				base.SetHandle(CreationContextFactory_Factory._members.InstanceMethods.StartCreateInstance("(Ljavax/inject/Provider;Ljavax/inject/Provider;Ljavax/inject/Provider;)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				CreationContextFactory_Factory._members.InstanceMethods.FinishCreateInstance("(Ljavax/inject/Provider;Ljavax/inject/Provider;Ljavax/inject/Provider;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(applicationContextProvider);
				GC.KeepAlive(wallClockProvider);
				GC.KeepAlive(monotonicClockProvider);
			}
		}

		// Token: 0x06000542 RID: 1346 RVA: 0x0000FDF4 File Offset: 0x0000DFF4
		[Register("create", "(Ljavax/inject/Provider;Ljavax/inject/Provider;Ljavax/inject/Provider;)Lcom/google/android/datatransport/runtime/backends/CreationContextFactory_Factory;", "")]
		public unsafe static CreationContextFactory_Factory Create(IProvider applicationContextProvider, IProvider wallClockProvider, IProvider monotonicClockProvider)
		{
			CreationContextFactory_Factory @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((applicationContextProvider == null) ? IntPtr.Zero : ((Java.Lang.Object)applicationContextProvider).Handle);
				ptr[1] = new JniArgumentValue((wallClockProvider == null) ? IntPtr.Zero : ((Java.Lang.Object)wallClockProvider).Handle);
				ptr[2] = new JniArgumentValue((monotonicClockProvider == null) ? IntPtr.Zero : ((Java.Lang.Object)monotonicClockProvider).Handle);
				@object = Java.Lang.Object.GetObject<CreationContextFactory_Factory>(CreationContextFactory_Factory._members.StaticMethods.InvokeObjectMethod("create.(Ljavax/inject/Provider;Ljavax/inject/Provider;Ljavax/inject/Provider;)Lcom/google/android/datatransport/runtime/backends/CreationContextFactory_Factory;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(applicationContextProvider);
				GC.KeepAlive(wallClockProvider);
				GC.KeepAlive(monotonicClockProvider);
			}
			return @object;
		}

		// Token: 0x06000543 RID: 1347 RVA: 0x0000FEC8 File Offset: 0x0000E0C8
		[Register("get", "()Ljava/lang/Object;", "")]
		public Java.Lang.Object Get()
		{
			return Java.Lang.Object.GetObject<Java.Lang.Object>(CreationContextFactory_Factory._members.InstanceMethods.InvokeAbstractObjectMethod("get.()Ljava/lang/Object;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x06000544 RID: 1348 RVA: 0x0000FEFC File Offset: 0x0000E0FC
		[Register("newInstance", "(Landroid/content/Context;Lcom/google/android/datatransport/runtime/time/Clock;Lcom/google/android/datatransport/runtime/time/Clock;)Ljava/lang/Object;", "")]
		public unsafe static Java.Lang.Object NewInstance(Context applicationContext, IClock wallClock, IClock monotonicClock)
		{
			Java.Lang.Object @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((applicationContext == null) ? IntPtr.Zero : applicationContext.Handle);
				ptr[1] = new JniArgumentValue((wallClock == null) ? IntPtr.Zero : ((Java.Lang.Object)wallClock).Handle);
				ptr[2] = new JniArgumentValue((monotonicClock == null) ? IntPtr.Zero : ((Java.Lang.Object)monotonicClock).Handle);
				@object = Java.Lang.Object.GetObject<Java.Lang.Object>(CreationContextFactory_Factory._members.StaticMethods.InvokeObjectMethod("newInstance.(Landroid/content/Context;Lcom/google/android/datatransport/runtime/time/Clock;Lcom/google/android/datatransport/runtime/time/Clock;)Ljava/lang/Object;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(applicationContext);
				GC.KeepAlive(wallClock);
				GC.KeepAlive(monotonicClock);
			}
			return @object;
		}

		// Token: 0x0400011D RID: 285
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/google/android/datatransport/runtime/backends/CreationContextFactory_Factory", typeof(CreationContextFactory_Factory));
	}
}
