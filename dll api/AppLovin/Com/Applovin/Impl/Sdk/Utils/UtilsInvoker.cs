using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;

namespace Com.Applovin.Impl.Sdk.Utils
{
	// Token: 0x0200013D RID: 317
	[Register("com/applovin/impl/sdk/utils/Utils", DoNotGenerateAcw = true)]
	internal class UtilsInvoker : Utils
	{
		// Token: 0x06000F21 RID: 3873 RVA: 0x0002CB53 File Offset: 0x0002AD53
		public UtilsInvoker(IntPtr handle, JniHandleOwnership transfer) : base(handle, transfer)
		{
		}

		// Token: 0x170003D4 RID: 980
		// (get) Token: 0x06000F22 RID: 3874 RVA: 0x0002CB5D File Offset: 0x0002AD5D
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return UtilsInvoker._members;
			}
		}

		// Token: 0x170003D5 RID: 981
		// (get) Token: 0x06000F23 RID: 3875 RVA: 0x0002CB64 File Offset: 0x0002AD64
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return UtilsInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x040004FC RID: 1276
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/applovin/impl/sdk/utils/Utils", typeof(UtilsInvoker));
	}
}
