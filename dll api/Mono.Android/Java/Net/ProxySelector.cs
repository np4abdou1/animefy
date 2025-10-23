using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Java.Net
{
	// Token: 0x020003AF RID: 943
	[Register("java/net/ProxySelector", DoNotGenerateAcw = true)]
	public abstract class ProxySelector : Java.Lang.Object
	{
		// Token: 0x1700080E RID: 2062
		// (get) Token: 0x06002993 RID: 10643 RVA: 0x00075294 File Offset: 0x00073494
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return ProxySelector._members;
			}
		}

		// Token: 0x1700080F RID: 2063
		// (get) Token: 0x06002994 RID: 10644 RVA: 0x0007529C File Offset: 0x0007349C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return ProxySelector._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000810 RID: 2064
		// (get) Token: 0x06002995 RID: 10645 RVA: 0x000752C0 File Offset: 0x000734C0
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return ProxySelector._members.ManagedPeerType;
			}
		}

		// Token: 0x06002996 RID: 10646 RVA: 0x000021E0 File Offset: 0x000003E0
		protected ProxySelector(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x17000811 RID: 2065
		// (get) Token: 0x06002997 RID: 10647 RVA: 0x000752CC File Offset: 0x000734CC
		public static ProxySelector Default
		{
			get
			{
				return Java.Lang.Object.GetObject<ProxySelector>(ProxySelector._members.StaticMethods.InvokeObjectMethod("getDefault.()Ljava/net/ProxySelector;", null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x06002998 RID: 10648 RVA: 0x000752FD File Offset: 0x000734FD
		private static Delegate GetSelect_Ljava_net_URI_Handler()
		{
			if (ProxySelector.cb_select_Ljava_net_URI_ == null)
			{
				ProxySelector.cb_select_Ljava_net_URI_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(ProxySelector.n_Select_Ljava_net_URI_));
			}
			return ProxySelector.cb_select_Ljava_net_URI_;
		}

		// Token: 0x06002999 RID: 10649 RVA: 0x00075324 File Offset: 0x00073524
		private static IntPtr n_Select_Ljava_net_URI_(IntPtr jnienv, IntPtr native__this, IntPtr native_uri)
		{
			ProxySelector @object = Java.Lang.Object.GetObject<ProxySelector>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			URI object2 = Java.Lang.Object.GetObject<URI>(native_uri, JniHandleOwnership.DoNotTransfer);
			return JavaList<Proxy>.ToLocalJniHandle(@object.Select(object2));
		}

		// Token: 0x0600299A RID: 10650
		public abstract IList<Proxy> Select(URI uri);

		// Token: 0x04001105 RID: 4357
		private static readonly JniPeerMembers _members = new XAPeerMembers("java/net/ProxySelector", typeof(ProxySelector));

		// Token: 0x04001106 RID: 4358
		private static Delegate cb_select_Ljava_net_URI_;
	}
}
