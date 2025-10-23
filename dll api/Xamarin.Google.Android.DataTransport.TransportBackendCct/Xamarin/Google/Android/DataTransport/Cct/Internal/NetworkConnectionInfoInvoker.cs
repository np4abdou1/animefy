using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Xamarin.Google.Android.DataTransport.Cct.Internal
{
	// Token: 0x02000025 RID: 37
	[Register("com/google/android/datatransport/cct/internal/NetworkConnectionInfo", DoNotGenerateAcw = true)]
	internal class NetworkConnectionInfoInvoker : NetworkConnectionInfo
	{
		// Token: 0x06000206 RID: 518 RVA: 0x00006443 File Offset: 0x00004643
		public NetworkConnectionInfoInvoker(IntPtr handle, JniHandleOwnership transfer) : base(handle, transfer)
		{
		}

		// Token: 0x170000C9 RID: 201
		// (get) Token: 0x06000207 RID: 519 RVA: 0x0000644D File Offset: 0x0000464D
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return NetworkConnectionInfoInvoker._members;
			}
		}

		// Token: 0x170000CA RID: 202
		// (get) Token: 0x06000208 RID: 520 RVA: 0x00006454 File Offset: 0x00004654
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return NetworkConnectionInfoInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x06000209 RID: 521 RVA: 0x00006460 File Offset: 0x00004660
		[Register("getMobileSubtype", "()Lcom/google/android/datatransport/cct/internal/NetworkConnectionInfo$MobileSubtype;", "GetGetMobileSubtypeHandler")]
		public override NetworkConnectionInfo.MobileSubtype GetMobileSubtype()
		{
			return Java.Lang.Object.GetObject<NetworkConnectionInfo.MobileSubtype>(NetworkConnectionInfoInvoker._members.InstanceMethods.InvokeAbstractObjectMethod("getMobileSubtype.()Lcom/google/android/datatransport/cct/internal/NetworkConnectionInfo$MobileSubtype;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x0600020A RID: 522 RVA: 0x00006494 File Offset: 0x00004694
		[Register("getNetworkType", "()Lcom/google/android/datatransport/cct/internal/NetworkConnectionInfo$NetworkType;", "GetGetNetworkTypeHandler")]
		public override NetworkConnectionInfo.NetworkType GetNetworkType()
		{
			return Java.Lang.Object.GetObject<NetworkConnectionInfo.NetworkType>(NetworkConnectionInfoInvoker._members.InstanceMethods.InvokeAbstractObjectMethod("getNetworkType.()Lcom/google/android/datatransport/cct/internal/NetworkConnectionInfo$NetworkType;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x04000060 RID: 96
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/google/android/datatransport/cct/internal/NetworkConnectionInfo", typeof(NetworkConnectionInfoInvoker));
	}
}
