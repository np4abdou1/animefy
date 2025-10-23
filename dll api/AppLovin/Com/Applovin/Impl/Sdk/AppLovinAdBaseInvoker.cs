using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;

namespace Com.Applovin.Impl.Sdk
{
	// Token: 0x0200012A RID: 298
	[Register("com/applovin/impl/sdk/AppLovinAdBase", DoNotGenerateAcw = true)]
	internal class AppLovinAdBaseInvoker : AppLovinAdBase
	{
		// Token: 0x06000D7A RID: 3450 RVA: 0x00024427 File Offset: 0x00022627
		public AppLovinAdBaseInvoker(IntPtr handle, JniHandleOwnership transfer) : base(handle, transfer)
		{
		}

		// Token: 0x17000386 RID: 902
		// (get) Token: 0x06000D7B RID: 3451 RVA: 0x00024431 File Offset: 0x00022631
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return AppLovinAdBaseInvoker._members;
			}
		}

		// Token: 0x17000387 RID: 903
		// (get) Token: 0x06000D7C RID: 3452 RVA: 0x00024438 File Offset: 0x00022638
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return AppLovinAdBaseInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x17000388 RID: 904
		// (get) Token: 0x06000D7D RID: 3453 RVA: 0x00024444 File Offset: 0x00022644
		public override long AdIdNumber
		{
			[Register("getAdIdNumber", "()J", "GetGetAdIdNumberHandler")]
			get
			{
				return AppLovinAdBaseInvoker._members.InstanceMethods.InvokeAbstractInt64Method("getAdIdNumber.()J", this, null);
			}
		}

		// Token: 0x040004B1 RID: 1201
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/applovin/impl/sdk/AppLovinAdBase", typeof(AppLovinAdBaseInvoker));
	}
}
