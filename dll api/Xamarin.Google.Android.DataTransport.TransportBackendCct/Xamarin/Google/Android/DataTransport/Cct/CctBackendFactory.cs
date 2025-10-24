using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;
using Xamarin.Google.Android.DataTransport.Runtime.Backends;

namespace Xamarin.Google.Android.DataTransport.Cct
{
	// Token: 0x02000008 RID: 8
	[Register("com/google/android/datatransport/cct/CctBackendFactory", DoNotGenerateAcw = true)]
	public class CctBackendFactory : Java.Lang.Object, IBackendFactory, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x17000001 RID: 1
		// (get) Token: 0x06000016 RID: 22 RVA: 0x00002058 File Offset: 0x00000258
		internal static IntPtr class_ref
		{
			get
			{
				return CctBackendFactory._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000002 RID: 2
		// (get) Token: 0x06000017 RID: 23 RVA: 0x0000207C File Offset: 0x0000027C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return CctBackendFactory._members;
			}
		}

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x06000018 RID: 24 RVA: 0x00002084 File Offset: 0x00000284
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return CctBackendFactory._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x06000019 RID: 25 RVA: 0x000020A8 File Offset: 0x000002A8
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return CctBackendFactory._members.ManagedPeerType;
			}
		}

		// Token: 0x0600001A RID: 26 RVA: 0x000020B4 File Offset: 0x000002B4
		protected CctBackendFactory(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x0600001B RID: 27 RVA: 0x000020C0 File Offset: 0x000002C0
		[Register(".ctor", "()V", "")]
		public CctBackendFactory() : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			base.SetHandle(CctBackendFactory._members.InstanceMethods.StartCreateInstance("()V", base.GetType(), null).Handle, JniHandleOwnership.TransferLocalRef);
			CctBackendFactory._members.InstanceMethods.FinishCreateInstance("()V", this, null);
		}

		// Token: 0x0600001C RID: 28 RVA: 0x0000212E File Offset: 0x0000032E
		private static Delegate GetCreate_Lcom_google_android_datatransport_runtime_backends_CreationContext_Handler()
		{
			if (CctBackendFactory.cb_create_Lcom_google_android_datatransport_runtime_backends_CreationContext_ == null)
			{
				CctBackendFactory.cb_create_Lcom_google_android_datatransport_runtime_backends_CreationContext_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(CctBackendFactory.n_Create_Lcom_google_android_datatransport_runtime_backends_CreationContext_));
			}
			return CctBackendFactory.cb_create_Lcom_google_android_datatransport_runtime_backends_CreationContext_;
		}

		// Token: 0x0600001D RID: 29 RVA: 0x00002154 File Offset: 0x00000354
		private static IntPtr n_Create_Lcom_google_android_datatransport_runtime_backends_CreationContext_(IntPtr jnienv, IntPtr native__this, IntPtr native_creationContext)
		{
			CctBackendFactory @object = Java.Lang.Object.GetObject<CctBackendFactory>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			CreationContext object2 = Java.Lang.Object.GetObject<CreationContext>(native_creationContext, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.Create(object2));
		}

		// Token: 0x0600001E RID: 30 RVA: 0x0000217C File Offset: 0x0000037C
		[Register("create", "(Lcom/google/android/datatransport/runtime/backends/CreationContext;)Lcom/google/android/datatransport/runtime/backends/TransportBackend;", "GetCreate_Lcom_google_android_datatransport_runtime_backends_CreationContext_Handler")]
		public unsafe virtual ITransportBackend Create(CreationContext creationContext)
		{
			ITransportBackend @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((creationContext == null) ? IntPtr.Zero : creationContext.Handle);
				@object = Java.Lang.Object.GetObject<ITransportBackend>(CctBackendFactory._members.InstanceMethods.InvokeVirtualObjectMethod("create.(Lcom/google/android/datatransport/runtime/backends/CreationContext;)Lcom/google/android/datatransport/runtime/backends/TransportBackend;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(creationContext);
			}
			return @object;
		}

		// Token: 0x04000001 RID: 1
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/google/android/datatransport/cct/CctBackendFactory", typeof(CctBackendFactory));

		// Token: 0x04000002 RID: 2
		private static Delegate cb_create_Lcom_google_android_datatransport_runtime_backends_CreationContext_;
	}
}
