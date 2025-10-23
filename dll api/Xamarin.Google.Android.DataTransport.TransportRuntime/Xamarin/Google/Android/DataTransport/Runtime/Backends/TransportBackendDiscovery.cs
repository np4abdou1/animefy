using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Xamarin.Google.Android.DataTransport.Runtime.Backends
{
	// Token: 0x02000096 RID: 150
	[Register("com/google/android/datatransport/runtime/backends/TransportBackendDiscovery", DoNotGenerateAcw = true)]
	public class TransportBackendDiscovery : Service
	{
		// Token: 0x170001DB RID: 475
		// (get) Token: 0x0600057B RID: 1403 RVA: 0x000108B0 File Offset: 0x0000EAB0
		internal static IntPtr class_ref
		{
			get
			{
				return TransportBackendDiscovery._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170001DC RID: 476
		// (get) Token: 0x0600057C RID: 1404 RVA: 0x000108D4 File Offset: 0x0000EAD4
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return TransportBackendDiscovery._members;
			}
		}

		// Token: 0x170001DD RID: 477
		// (get) Token: 0x0600057D RID: 1405 RVA: 0x000108DC File Offset: 0x0000EADC
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return TransportBackendDiscovery._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170001DE RID: 478
		// (get) Token: 0x0600057E RID: 1406 RVA: 0x00010900 File Offset: 0x0000EB00
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return TransportBackendDiscovery._members.ManagedPeerType;
			}
		}

		// Token: 0x0600057F RID: 1407 RVA: 0x0001090C File Offset: 0x0000EB0C
		protected TransportBackendDiscovery(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06000580 RID: 1408 RVA: 0x00010918 File Offset: 0x0000EB18
		[Register(".ctor", "()V", "")]
		public TransportBackendDiscovery() : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			base.SetHandle(TransportBackendDiscovery._members.InstanceMethods.StartCreateInstance("()V", base.GetType(), null).Handle, JniHandleOwnership.TransferLocalRef);
			TransportBackendDiscovery._members.InstanceMethods.FinishCreateInstance("()V", this, null);
		}

		// Token: 0x06000581 RID: 1409 RVA: 0x00010986 File Offset: 0x0000EB86
		private static Delegate GetOnBind_Landroid_content_Intent_Handler()
		{
			if (TransportBackendDiscovery.cb_onBind_Landroid_content_Intent_ == null)
			{
				TransportBackendDiscovery.cb_onBind_Landroid_content_Intent_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(TransportBackendDiscovery.n_OnBind_Landroid_content_Intent_));
			}
			return TransportBackendDiscovery.cb_onBind_Landroid_content_Intent_;
		}

		// Token: 0x06000582 RID: 1410 RVA: 0x000109AC File Offset: 0x0000EBAC
		private static IntPtr n_OnBind_Landroid_content_Intent_(IntPtr jnienv, IntPtr native__this, IntPtr native_intent)
		{
			Service @object = Java.Lang.Object.GetObject<TransportBackendDiscovery>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Intent object2 = Java.Lang.Object.GetObject<Intent>(native_intent, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.OnBind(object2));
		}

		// Token: 0x06000583 RID: 1411 RVA: 0x000109D4 File Offset: 0x0000EBD4
		[Register("onBind", "(Landroid/content/Intent;)Landroid/os/IBinder;", "GetOnBind_Landroid_content_Intent_Handler")]
		public unsafe override IBinder OnBind(Intent intent)
		{
			IBinder @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((intent == null) ? IntPtr.Zero : intent.Handle);
				@object = Java.Lang.Object.GetObject<IBinder>(TransportBackendDiscovery._members.InstanceMethods.InvokeVirtualObjectMethod("onBind.(Landroid/content/Intent;)Landroid/os/IBinder;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(intent);
			}
			return @object;
		}

		// Token: 0x0400012D RID: 301
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/google/android/datatransport/runtime/backends/TransportBackendDiscovery", typeof(TransportBackendDiscovery));

		// Token: 0x0400012E RID: 302
		private static Delegate cb_onBind_Landroid_content_Intent_;
	}
}
