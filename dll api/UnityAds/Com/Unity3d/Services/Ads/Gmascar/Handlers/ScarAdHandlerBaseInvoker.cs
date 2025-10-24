using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;

namespace Com.Unity3d.Services.Ads.Gmascar.Handlers
{
	// Token: 0x02000207 RID: 519
	[Register("com/unity3d/services/ads/gmascar/handlers/ScarAdHandlerBase", DoNotGenerateAcw = true)]
	internal class ScarAdHandlerBaseInvoker : ScarAdHandlerBase
	{
		// Token: 0x06001833 RID: 6195 RVA: 0x00045F23 File Offset: 0x00044123
		public ScarAdHandlerBaseInvoker(IntPtr handle, JniHandleOwnership transfer) : base(handle, transfer)
		{
		}

		// Token: 0x17000849 RID: 2121
		// (get) Token: 0x06001834 RID: 6196 RVA: 0x00045F2D File Offset: 0x0004412D
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return ScarAdHandlerBaseInvoker._members;
			}
		}

		// Token: 0x1700084A RID: 2122
		// (get) Token: 0x06001835 RID: 6197 RVA: 0x00045F34 File Offset: 0x00044134
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return ScarAdHandlerBaseInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x040005E5 RID: 1509
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/unity3d/services/ads/gmascar/handlers/ScarAdHandlerBase", typeof(ScarAdHandlerBaseInvoker));
	}
}
