using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;

namespace Com.Adcolony.Sdk
{
	// Token: 0x02000046 RID: 70
	[Register("com/adcolony/sdk/AdColonyInterstitialListener", DoNotGenerateAcw = true)]
	internal class AdColonyInterstitialListenerInvoker : AdColonyInterstitialListener
	{
		// Token: 0x06000375 RID: 885 RVA: 0x0000B1AF File Offset: 0x000093AF
		public AdColonyInterstitialListenerInvoker(IntPtr handle, JniHandleOwnership transfer) : base(handle, transfer)
		{
		}

		// Token: 0x170000F1 RID: 241
		// (get) Token: 0x06000376 RID: 886 RVA: 0x0000B1B9 File Offset: 0x000093B9
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return AdColonyInterstitialListenerInvoker._members;
			}
		}

		// Token: 0x170000F2 RID: 242
		// (get) Token: 0x06000377 RID: 887 RVA: 0x0000B1C0 File Offset: 0x000093C0
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return AdColonyInterstitialListenerInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x06000378 RID: 888 RVA: 0x0000B1CC File Offset: 0x000093CC
		[Register("onRequestFilled", "(Lcom/adcolony/sdk/AdColonyInterstitial;)V", "GetOnRequestFilled_Lcom_adcolony_sdk_AdColonyInterstitial_Handler")]
		public unsafe override void OnRequestFilled(AdColonyInterstitial p0)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((p0 == null) ? IntPtr.Zero : p0.Handle);
				AdColonyInterstitialListenerInvoker._members.InstanceMethods.InvokeAbstractVoidMethod("onRequestFilled.(Lcom/adcolony/sdk/AdColonyInterstitial;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(p0);
			}
		}

		// Token: 0x040000EA RID: 234
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/adcolony/sdk/AdColonyInterstitialListener", typeof(AdColonyInterstitialListenerInvoker));
	}
}
