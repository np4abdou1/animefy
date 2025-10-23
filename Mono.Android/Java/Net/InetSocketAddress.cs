using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Java.Net
{
	// Token: 0x020003AD RID: 941
	[Register("java/net/InetSocketAddress", DoNotGenerateAcw = true)]
	public class InetSocketAddress : SocketAddress
	{
		// Token: 0x17000805 RID: 2053
		// (get) Token: 0x0600297F RID: 10623 RVA: 0x00074FF6 File Offset: 0x000731F6
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return InetSocketAddress._members;
			}
		}

		// Token: 0x17000806 RID: 2054
		// (get) Token: 0x06002980 RID: 10624 RVA: 0x00075000 File Offset: 0x00073200
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return InetSocketAddress._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000807 RID: 2055
		// (get) Token: 0x06002981 RID: 10625 RVA: 0x00075024 File Offset: 0x00073224
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return InetSocketAddress._members.ManagedPeerType;
			}
		}

		// Token: 0x06002982 RID: 10626 RVA: 0x00075030 File Offset: 0x00073230
		protected InetSocketAddress(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x17000808 RID: 2056
		// (get) Token: 0x06002983 RID: 10627 RVA: 0x0007503C File Offset: 0x0007323C
		public string HostString
		{
			get
			{
				return JNIEnv.GetString(InetSocketAddress._members.InstanceMethods.InvokeNonvirtualObjectMethod("getHostString.()Ljava/lang/String;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x17000809 RID: 2057
		// (get) Token: 0x06002984 RID: 10628 RVA: 0x0007506E File Offset: 0x0007326E
		public int Port
		{
			get
			{
				return InetSocketAddress._members.InstanceMethods.InvokeNonvirtualInt32Method("getPort.()I", this, null);
			}
		}

		// Token: 0x06002985 RID: 10629 RVA: 0x00075088 File Offset: 0x00073288
		public unsafe sealed override bool Equals(Java.Lang.Object obj)
		{
			bool result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((obj == null) ? IntPtr.Zero : obj.Handle);
				result = InetSocketAddress._members.InstanceMethods.InvokeNonvirtualBooleanMethod("equals.(Ljava/lang/Object;)Z", this, ptr);
			}
			finally
			{
				GC.KeepAlive(obj);
			}
			return result;
		}

		// Token: 0x06002986 RID: 10630 RVA: 0x000750F0 File Offset: 0x000732F0
		public sealed override int GetHashCode()
		{
			return InetSocketAddress._members.InstanceMethods.InvokeNonvirtualInt32Method("hashCode.()I", this, null);
		}

		// Token: 0x04001102 RID: 4354
		private static readonly JniPeerMembers _members = new XAPeerMembers("java/net/InetSocketAddress", typeof(InetSocketAddress));
	}
}
