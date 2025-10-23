using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Java.Net
{
	// Token: 0x020003AE RID: 942
	[Register("java/net/Proxy", DoNotGenerateAcw = true)]
	public class Proxy : Java.Lang.Object
	{
		// Token: 0x1700080A RID: 2058
		// (get) Token: 0x06002988 RID: 10632 RVA: 0x00075124 File Offset: 0x00073324
		[Register("NO_PROXY")]
		public static Proxy NoProxy
		{
			get
			{
				return Java.Lang.Object.GetObject<Proxy>(Proxy._members.StaticFields.GetObjectValue("NO_PROXY.Ljava/net/Proxy;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x1700080B RID: 2059
		// (get) Token: 0x06002989 RID: 10633 RVA: 0x00075153 File Offset: 0x00073353
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return Proxy._members;
			}
		}

		// Token: 0x1700080C RID: 2060
		// (get) Token: 0x0600298A RID: 10634 RVA: 0x0007515C File Offset: 0x0007335C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return Proxy._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700080D RID: 2061
		// (get) Token: 0x0600298B RID: 10635 RVA: 0x00075180 File Offset: 0x00073380
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return Proxy._members.ManagedPeerType;
			}
		}

		// Token: 0x0600298C RID: 10636 RVA: 0x000021E0 File Offset: 0x000003E0
		protected Proxy(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x0600298D RID: 10637 RVA: 0x0007518C File Offset: 0x0007338C
		private static Delegate GetAddressHandler()
		{
			if (Proxy.cb_address == null)
			{
				Proxy.cb_address = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(Proxy.n_Address));
			}
			return Proxy.cb_address;
		}

		// Token: 0x0600298E RID: 10638 RVA: 0x000751B0 File Offset: 0x000733B0
		private static IntPtr n_Address(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<Proxy>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Address());
		}

		// Token: 0x0600298F RID: 10639 RVA: 0x000751C4 File Offset: 0x000733C4
		public virtual SocketAddress Address()
		{
			return Java.Lang.Object.GetObject<SocketAddress>(Proxy._members.InstanceMethods.InvokeVirtualObjectMethod("address.()Ljava/net/SocketAddress;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x06002990 RID: 10640 RVA: 0x000751F8 File Offset: 0x000733F8
		public unsafe sealed override bool Equals(Java.Lang.Object obj)
		{
			bool result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((obj == null) ? IntPtr.Zero : obj.Handle);
				result = Proxy._members.InstanceMethods.InvokeNonvirtualBooleanMethod("equals.(Ljava/lang/Object;)Z", this, ptr);
			}
			finally
			{
				GC.KeepAlive(obj);
			}
			return result;
		}

		// Token: 0x06002991 RID: 10641 RVA: 0x00075260 File Offset: 0x00073460
		public sealed override int GetHashCode()
		{
			return Proxy._members.InstanceMethods.InvokeNonvirtualInt32Method("hashCode.()I", this, null);
		}

		// Token: 0x04001103 RID: 4355
		private static readonly JniPeerMembers _members = new XAPeerMembers("java/net/Proxy", typeof(Proxy));

		// Token: 0x04001104 RID: 4356
		private static Delegate cb_address;
	}
}
