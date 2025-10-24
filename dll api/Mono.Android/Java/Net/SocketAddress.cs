using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.IO;
using Java.Lang;

namespace Java.Net
{
	// Token: 0x020003B1 RID: 945
	[Register("java/net/SocketAddress", DoNotGenerateAcw = true)]
	public abstract class SocketAddress : Java.Lang.Object, ISerializable, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x17000814 RID: 2068
		// (get) Token: 0x060029A1 RID: 10657 RVA: 0x00075413 File Offset: 0x00073613
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return SocketAddress._members;
			}
		}

		// Token: 0x17000815 RID: 2069
		// (get) Token: 0x060029A2 RID: 10658 RVA: 0x0007541C File Offset: 0x0007361C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return SocketAddress._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000816 RID: 2070
		// (get) Token: 0x060029A3 RID: 10659 RVA: 0x00075440 File Offset: 0x00073640
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return SocketAddress._members.ManagedPeerType;
			}
		}

		// Token: 0x060029A4 RID: 10660 RVA: 0x000021E0 File Offset: 0x000003E0
		protected SocketAddress(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x04001108 RID: 4360
		private static readonly JniPeerMembers _members = new XAPeerMembers("java/net/SocketAddress", typeof(SocketAddress));
	}
}
