using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Xamarin.Google.Android.DataTransport.Cct.Internal
{
	// Token: 0x02000015 RID: 21
	[Register("com/google/android/datatransport/cct/internal/ClientInfo", DoNotGenerateAcw = true)]
	internal class ClientInfoInvoker : ClientInfo
	{
		// Token: 0x060000F2 RID: 242 RVA: 0x00003F47 File Offset: 0x00002147
		public ClientInfoInvoker(IntPtr handle, JniHandleOwnership transfer) : base(handle, transfer)
		{
		}

		// Token: 0x17000050 RID: 80
		// (get) Token: 0x060000F3 RID: 243 RVA: 0x00003F51 File Offset: 0x00002151
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return ClientInfoInvoker._members;
			}
		}

		// Token: 0x17000051 RID: 81
		// (get) Token: 0x060000F4 RID: 244 RVA: 0x00003F58 File Offset: 0x00002158
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return ClientInfoInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x17000052 RID: 82
		// (get) Token: 0x060000F5 RID: 245 RVA: 0x00003F64 File Offset: 0x00002164
		public override AndroidClientInfo AndroidClientInfo
		{
			[Register("getAndroidClientInfo", "()Lcom/google/android/datatransport/cct/internal/AndroidClientInfo;", "GetGetAndroidClientInfoHandler")]
			get
			{
				return Java.Lang.Object.GetObject<AndroidClientInfo>(ClientInfoInvoker._members.InstanceMethods.InvokeAbstractObjectMethod("getAndroidClientInfo.()Lcom/google/android/datatransport/cct/internal/AndroidClientInfo;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x060000F6 RID: 246 RVA: 0x00003F98 File Offset: 0x00002198
		[Register("getClientType", "()Lcom/google/android/datatransport/cct/internal/ClientInfo$ClientType;", "GetGetClientTypeHandler")]
		public override ClientInfo.ClientType GetClientType()
		{
			return Java.Lang.Object.GetObject<ClientInfo.ClientType>(ClientInfoInvoker._members.InstanceMethods.InvokeAbstractObjectMethod("getClientType.()Lcom/google/android/datatransport/cct/internal/ClientInfo$ClientType;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x0400002E RID: 46
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/google/android/datatransport/cct/internal/ClientInfo", typeof(ClientInfoInvoker));
	}
}
