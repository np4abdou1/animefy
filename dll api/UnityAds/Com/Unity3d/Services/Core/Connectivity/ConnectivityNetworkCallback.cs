using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Net;
using Android.Runtime;
using Java.Interop;

namespace Com.Unity3d.Services.Core.Connectivity
{
	// Token: 0x0200014A RID: 330
	[Register("com/unity3d/services/core/connectivity/ConnectivityNetworkCallback", DoNotGenerateAcw = true)]
	public class ConnectivityNetworkCallback : ConnectivityManager.NetworkCallback
	{
		// Token: 0x170004C4 RID: 1220
		// (get) Token: 0x06000D3C RID: 3388 RVA: 0x00025270 File Offset: 0x00023470
		internal static IntPtr class_ref
		{
			get
			{
				return ConnectivityNetworkCallback._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170004C5 RID: 1221
		// (get) Token: 0x06000D3D RID: 3389 RVA: 0x00025294 File Offset: 0x00023494
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return ConnectivityNetworkCallback._members;
			}
		}

		// Token: 0x170004C6 RID: 1222
		// (get) Token: 0x06000D3E RID: 3390 RVA: 0x0002529C File Offset: 0x0002349C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return ConnectivityNetworkCallback._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170004C7 RID: 1223
		// (get) Token: 0x06000D3F RID: 3391 RVA: 0x000252C0 File Offset: 0x000234C0
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return ConnectivityNetworkCallback._members.ManagedPeerType;
			}
		}

		// Token: 0x06000D40 RID: 3392 RVA: 0x000252CC File Offset: 0x000234CC
		protected ConnectivityNetworkCallback(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06000D41 RID: 3393 RVA: 0x000252D8 File Offset: 0x000234D8
		[Register(".ctor", "()V", "")]
		public ConnectivityNetworkCallback() : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			base.SetHandle(ConnectivityNetworkCallback._members.InstanceMethods.StartCreateInstance("()V", base.GetType(), null).Handle, JniHandleOwnership.TransferLocalRef);
			ConnectivityNetworkCallback._members.InstanceMethods.FinishCreateInstance("()V", this, null);
		}

		// Token: 0x06000D42 RID: 3394 RVA: 0x00025346 File Offset: 0x00023546
		[Register("register", "()V", "")]
		public static void Register()
		{
			ConnectivityNetworkCallback._members.StaticMethods.InvokeVoidMethod("register.()V", null);
		}

		// Token: 0x06000D43 RID: 3395 RVA: 0x0002535E File Offset: 0x0002355E
		[Register("unregister", "()V", "")]
		public static void Unregister()
		{
			ConnectivityNetworkCallback._members.StaticMethods.InvokeVoidMethod("unregister.()V", null);
		}

		// Token: 0x04000309 RID: 777
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/unity3d/services/core/connectivity/ConnectivityNetworkCallback", typeof(ConnectivityNetworkCallback));
	}
}
