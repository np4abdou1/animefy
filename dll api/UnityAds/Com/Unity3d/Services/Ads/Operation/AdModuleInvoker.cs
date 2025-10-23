using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Com.Unity3d.Services.Core.Webview.Bridge;
using Java.Interop;

namespace Com.Unity3d.Services.Ads.Operation
{
	// Token: 0x020001E5 RID: 485
	[Register("com/unity3d/services/ads/operation/AdModule", DoNotGenerateAcw = true)]
	internal class AdModuleInvoker : AdModule, IAdModule, IWebViewBridgeSharedObjectStore, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x0600161E RID: 5662 RVA: 0x0003F779 File Offset: 0x0003D979
		public AdModuleInvoker(IntPtr handle, JniHandleOwnership transfer) : base(handle, transfer)
		{
		}

		// Token: 0x170007C4 RID: 1988
		// (get) Token: 0x0600161F RID: 5663 RVA: 0x0003F783 File Offset: 0x0003D983
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return AdModuleInvoker._members;
			}
		}

		// Token: 0x170007C5 RID: 1989
		// (get) Token: 0x06001620 RID: 5664 RVA: 0x0003F78A File Offset: 0x0003D98A
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return AdModuleInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x0400053A RID: 1338
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/unity3d/services/ads/operation/AdModule", typeof(AdModuleInvoker));
	}
}
