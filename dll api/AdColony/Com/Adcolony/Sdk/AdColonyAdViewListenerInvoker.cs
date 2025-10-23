using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;

namespace Com.Adcolony.Sdk
{
	// Token: 0x02000040 RID: 64
	[Register("com/adcolony/sdk/AdColonyAdViewListener", DoNotGenerateAcw = true)]
	internal class AdColonyAdViewListenerInvoker : AdColonyAdViewListener
	{
		// Token: 0x06000282 RID: 642 RVA: 0x000082C3 File Offset: 0x000064C3
		public AdColonyAdViewListenerInvoker(IntPtr handle, JniHandleOwnership transfer) : base(handle, transfer)
		{
		}

		// Token: 0x170000C7 RID: 199
		// (get) Token: 0x06000283 RID: 643 RVA: 0x000082CD File Offset: 0x000064CD
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return AdColonyAdViewListenerInvoker._members;
			}
		}

		// Token: 0x170000C8 RID: 200
		// (get) Token: 0x06000284 RID: 644 RVA: 0x000082D4 File Offset: 0x000064D4
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return AdColonyAdViewListenerInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x06000285 RID: 645 RVA: 0x000082E0 File Offset: 0x000064E0
		[Register("onRequestFilled", "(Lcom/adcolony/sdk/AdColonyAdView;)V", "GetOnRequestFilled_Lcom_adcolony_sdk_AdColonyAdView_Handler")]
		public unsafe override void OnRequestFilled(AdColonyAdView p0)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((p0 == null) ? IntPtr.Zero : p0.Handle);
				AdColonyAdViewListenerInvoker._members.InstanceMethods.InvokeAbstractVoidMethod("onRequestFilled.(Lcom/adcolony/sdk/AdColonyAdView;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(p0);
			}
		}

		// Token: 0x04000073 RID: 115
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/adcolony/sdk/AdColonyAdViewListener", typeof(AdColonyAdViewListenerInvoker));
	}
}
