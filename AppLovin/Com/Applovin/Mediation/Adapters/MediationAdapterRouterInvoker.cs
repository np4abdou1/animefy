using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;

namespace Com.Applovin.Mediation.Adapters
{
	// Token: 0x020000F6 RID: 246
	[Register("com/applovin/mediation/adapters/MediationAdapterRouter", DoNotGenerateAcw = true)]
	internal class MediationAdapterRouterInvoker : MediationAdapterRouter
	{
		// Token: 0x06000A93 RID: 2707 RVA: 0x0001CE4B File Offset: 0x0001B04B
		public MediationAdapterRouterInvoker(IntPtr handle, JniHandleOwnership transfer) : base(handle, transfer)
		{
		}

		// Token: 0x170002CF RID: 719
		// (get) Token: 0x06000A94 RID: 2708 RVA: 0x0001CE55 File Offset: 0x0001B055
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return MediationAdapterRouterInvoker._members;
			}
		}

		// Token: 0x170002D0 RID: 720
		// (get) Token: 0x06000A95 RID: 2709 RVA: 0x0001CE5C File Offset: 0x0001B05C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return MediationAdapterRouterInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x0400037A RID: 890
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/applovin/mediation/adapters/MediationAdapterRouter", typeof(MediationAdapterRouterInvoker));
	}
}
