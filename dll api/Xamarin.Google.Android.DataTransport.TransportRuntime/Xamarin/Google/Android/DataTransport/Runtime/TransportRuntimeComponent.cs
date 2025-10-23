using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.IO;
using Java.Lang;

namespace Xamarin.Google.Android.DataTransport.Runtime
{
	// Token: 0x0200002D RID: 45
	[Register("com/google/android/datatransport/runtime/TransportRuntimeComponent", DoNotGenerateAcw = true)]
	public abstract class TransportRuntimeComponent : Java.Lang.Object, ICloseable, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x17000058 RID: 88
		// (get) Token: 0x06000166 RID: 358 RVA: 0x00004B64 File Offset: 0x00002D64
		internal static IntPtr class_ref
		{
			get
			{
				return TransportRuntimeComponent._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000059 RID: 89
		// (get) Token: 0x06000167 RID: 359 RVA: 0x00004B88 File Offset: 0x00002D88
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return TransportRuntimeComponent._members;
			}
		}

		// Token: 0x1700005A RID: 90
		// (get) Token: 0x06000168 RID: 360 RVA: 0x00004B90 File Offset: 0x00002D90
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return TransportRuntimeComponent._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700005B RID: 91
		// (get) Token: 0x06000169 RID: 361 RVA: 0x00004BB4 File Offset: 0x00002DB4
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return TransportRuntimeComponent._members.ManagedPeerType;
			}
		}

		// Token: 0x0600016A RID: 362 RVA: 0x000026C4 File Offset: 0x000008C4
		protected TransportRuntimeComponent(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x0600016B RID: 363 RVA: 0x00004BC0 File Offset: 0x00002DC0
		private static Delegate GetCloseHandler()
		{
			if (TransportRuntimeComponent.cb_close == null)
			{
				TransportRuntimeComponent.cb_close = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_V(TransportRuntimeComponent.n_Close));
			}
			return TransportRuntimeComponent.cb_close;
		}

		// Token: 0x0600016C RID: 364 RVA: 0x00004BE4 File Offset: 0x00002DE4
		private static void n_Close(IntPtr jnienv, IntPtr native__this)
		{
			Java.Lang.Object.GetObject<TransportRuntimeComponent>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Close();
		}

		// Token: 0x0600016D RID: 365 RVA: 0x00004BF3 File Offset: 0x00002DF3
		[Register("close", "()V", "GetCloseHandler")]
		public virtual void Close()
		{
			TransportRuntimeComponent._members.InstanceMethods.InvokeVirtualVoidMethod("close.()V", this, null);
		}

		// Token: 0x0400004B RID: 75
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/google/android/datatransport/runtime/TransportRuntimeComponent", typeof(TransportRuntimeComponent));

		// Token: 0x0400004C RID: 76
		private static Delegate cb_close;
	}
}
