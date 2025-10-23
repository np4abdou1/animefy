using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Com.Unity3d.Scar.Adapter.Common.Requests;
using Java.Interop;
using Java.Lang;

namespace Com.Unity3d.Scar.Adapter.V2100.Requests
{
	// Token: 0x0200024D RID: 589
	[Register("com/unity3d/scar/adapter/v2100/requests/AdRequestFactory", DoNotGenerateAcw = true)]
	public class AdRequestFactory : Java.Lang.Object
	{
		// Token: 0x17000AD1 RID: 2769
		// (get) Token: 0x06001E8E RID: 7822 RVA: 0x00055548 File Offset: 0x00053748
		internal static IntPtr class_ref
		{
			get
			{
				return AdRequestFactory._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000AD2 RID: 2770
		// (get) Token: 0x06001E8F RID: 7823 RVA: 0x0005556C File Offset: 0x0005376C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return AdRequestFactory._members;
			}
		}

		// Token: 0x17000AD3 RID: 2771
		// (get) Token: 0x06001E90 RID: 7824 RVA: 0x00055574 File Offset: 0x00053774
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return AdRequestFactory._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000AD4 RID: 2772
		// (get) Token: 0x06001E91 RID: 7825 RVA: 0x00055598 File Offset: 0x00053798
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return AdRequestFactory._members.ManagedPeerType;
			}
		}

		// Token: 0x06001E92 RID: 7826 RVA: 0x000021E8 File Offset: 0x000003E8
		protected AdRequestFactory(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06001E93 RID: 7827 RVA: 0x000555A4 File Offset: 0x000537A4
		[Register(".ctor", "(Lcom/unity3d/scar/adapter/common/requests/RequestExtras;)V", "")]
		public unsafe AdRequestFactory(RequestExtras requestExtras) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((requestExtras == null) ? IntPtr.Zero : requestExtras.Handle);
				base.SetHandle(AdRequestFactory._members.InstanceMethods.StartCreateInstance("(Lcom/unity3d/scar/adapter/common/requests/RequestExtras;)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				AdRequestFactory._members.InstanceMethods.FinishCreateInstance("(Lcom/unity3d/scar/adapter/common/requests/RequestExtras;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(requestExtras);
			}
		}

		// Token: 0x040006E2 RID: 1762
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/unity3d/scar/adapter/v2100/requests/AdRequestFactory", typeof(AdRequestFactory));
	}
}
