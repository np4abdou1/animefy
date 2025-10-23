using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Android.Net
{
	// Token: 0x020001F9 RID: 505
	[Register("android/net/ConnectivityManager", DoNotGenerateAcw = true)]
	public class ConnectivityManager : Java.Lang.Object
	{
		// Token: 0x170003B9 RID: 953
		// (get) Token: 0x06001247 RID: 4679 RVA: 0x00030388 File Offset: 0x0002E588
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return ConnectivityManager._members;
			}
		}

		// Token: 0x170003BA RID: 954
		// (get) Token: 0x06001248 RID: 4680 RVA: 0x00030390 File Offset: 0x0002E590
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return ConnectivityManager._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170003BB RID: 955
		// (get) Token: 0x06001249 RID: 4681 RVA: 0x000303B4 File Offset: 0x0002E5B4
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return ConnectivityManager._members.ManagedPeerType;
			}
		}

		// Token: 0x0600124A RID: 4682 RVA: 0x000021E0 File Offset: 0x000003E0
		protected ConnectivityManager(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x0400083D RID: 2109
		private static readonly JniPeerMembers _members = new XAPeerMembers("android/net/ConnectivityManager", typeof(ConnectivityManager));

		// Token: 0x020001FA RID: 506
		[Register("android/net/ConnectivityManager$NetworkCallback", DoNotGenerateAcw = true)]
		public class NetworkCallback : Java.Lang.Object
		{
			// Token: 0x170003BC RID: 956
			// (get) Token: 0x0600124C RID: 4684 RVA: 0x000303DB File Offset: 0x0002E5DB
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			public override JniPeerMembers JniPeerMembers
			{
				get
				{
					return ConnectivityManager.NetworkCallback._members;
				}
			}

			// Token: 0x170003BD RID: 957
			// (get) Token: 0x0600124D RID: 4685 RVA: 0x000303E4 File Offset: 0x0002E5E4
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override IntPtr ThresholdClass
			{
				get
				{
					return ConnectivityManager.NetworkCallback._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x170003BE RID: 958
			// (get) Token: 0x0600124E RID: 4686 RVA: 0x00030408 File Offset: 0x0002E608
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override Type ThresholdType
			{
				get
				{
					return ConnectivityManager.NetworkCallback._members.ManagedPeerType;
				}
			}

			// Token: 0x0600124F RID: 4687 RVA: 0x000021E0 File Offset: 0x000003E0
			protected NetworkCallback(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
			{
			}

			// Token: 0x0400083E RID: 2110
			private static readonly JniPeerMembers _members = new XAPeerMembers("android/net/ConnectivityManager$NetworkCallback", typeof(ConnectivityManager.NetworkCallback));
		}
	}
}
