using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Com.Unity3d.Services.Core.Connectivity
{
	// Token: 0x02000149 RID: 329
	[Register("com/unity3d/services/core/connectivity/ConnectivityMonitor", DoNotGenerateAcw = true)]
	public class ConnectivityMonitor : Java.Lang.Object
	{
		// Token: 0x170004C0 RID: 1216
		// (get) Token: 0x06000D2D RID: 3373 RVA: 0x00025014 File Offset: 0x00023214
		internal static IntPtr class_ref
		{
			get
			{
				return ConnectivityMonitor._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170004C1 RID: 1217
		// (get) Token: 0x06000D2E RID: 3374 RVA: 0x00025038 File Offset: 0x00023238
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return ConnectivityMonitor._members;
			}
		}

		// Token: 0x170004C2 RID: 1218
		// (get) Token: 0x06000D2F RID: 3375 RVA: 0x00025040 File Offset: 0x00023240
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return ConnectivityMonitor._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170004C3 RID: 1219
		// (get) Token: 0x06000D30 RID: 3376 RVA: 0x00025064 File Offset: 0x00023264
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return ConnectivityMonitor._members.ManagedPeerType;
			}
		}

		// Token: 0x06000D31 RID: 3377 RVA: 0x000021E8 File Offset: 0x000003E8
		protected ConnectivityMonitor(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06000D32 RID: 3378 RVA: 0x00025070 File Offset: 0x00023270
		[Register(".ctor", "()V", "")]
		public ConnectivityMonitor() : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			base.SetHandle(ConnectivityMonitor._members.InstanceMethods.StartCreateInstance("()V", base.GetType(), null).Handle, JniHandleOwnership.TransferLocalRef);
			ConnectivityMonitor._members.InstanceMethods.FinishCreateInstance("()V", this, null);
		}

		// Token: 0x06000D33 RID: 3379 RVA: 0x000250E0 File Offset: 0x000232E0
		[Register("addListener", "(Lcom/unity3d/services/core/connectivity/IConnectivityListener;)V", "")]
		public unsafe static void AddListener(IConnectivityListener listener)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((listener == null) ? IntPtr.Zero : ((Java.Lang.Object)listener).Handle);
				ConnectivityMonitor._members.StaticMethods.InvokeVoidMethod("addListener.(Lcom/unity3d/services/core/connectivity/IConnectivityListener;)V", ptr);
			}
			finally
			{
				GC.KeepAlive(listener);
			}
		}

		// Token: 0x06000D34 RID: 3380 RVA: 0x00025148 File Offset: 0x00023348
		[Register("connected", "()V", "")]
		public static void Connected()
		{
			ConnectivityMonitor._members.StaticMethods.InvokeVoidMethod("connected.()V", null);
		}

		// Token: 0x06000D35 RID: 3381 RVA: 0x00025160 File Offset: 0x00023360
		[Register("connectionStatusChanged", "()V", "")]
		public static void ConnectionStatusChanged()
		{
			ConnectivityMonitor._members.StaticMethods.InvokeVoidMethod("connectionStatusChanged.()V", null);
		}

		// Token: 0x06000D36 RID: 3382 RVA: 0x00025178 File Offset: 0x00023378
		[Register("disconnected", "()V", "")]
		public static void Disconnected()
		{
			ConnectivityMonitor._members.StaticMethods.InvokeVoidMethod("disconnected.()V", null);
		}

		// Token: 0x06000D37 RID: 3383 RVA: 0x00025190 File Offset: 0x00023390
		[Register("removeListener", "(Lcom/unity3d/services/core/connectivity/IConnectivityListener;)V", "")]
		public unsafe static void RemoveListener(IConnectivityListener listener)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((listener == null) ? IntPtr.Zero : ((Java.Lang.Object)listener).Handle);
				ConnectivityMonitor._members.StaticMethods.InvokeVoidMethod("removeListener.(Lcom/unity3d/services/core/connectivity/IConnectivityListener;)V", ptr);
			}
			finally
			{
				GC.KeepAlive(listener);
			}
		}

		// Token: 0x06000D38 RID: 3384 RVA: 0x000251F8 File Offset: 0x000233F8
		[Register("setConnectionMonitoring", "(Z)V", "")]
		public unsafe static void SetConnectionMonitoring(bool monitoring)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(monitoring);
			ConnectivityMonitor._members.StaticMethods.InvokeVoidMethod("setConnectionMonitoring.(Z)V", ptr);
		}

		// Token: 0x06000D39 RID: 3385 RVA: 0x00025232 File Offset: 0x00023432
		[Register("stopAll", "()V", "")]
		public static void StopAll()
		{
			ConnectivityMonitor._members.StaticMethods.InvokeVoidMethod("stopAll.()V", null);
		}

		// Token: 0x06000D3A RID: 3386 RVA: 0x0002524A File Offset: 0x0002344A
		private IConnectivityListenerImplementor __CreateIConnectivityListenerImplementor()
		{
			return new IConnectivityListenerImplementor(this);
		}

		// Token: 0x04000308 RID: 776
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/unity3d/services/core/connectivity/ConnectivityMonitor", typeof(ConnectivityMonitor));
	}
}
