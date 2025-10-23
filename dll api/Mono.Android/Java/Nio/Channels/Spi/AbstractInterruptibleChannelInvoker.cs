using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;

namespace Java.Nio.Channels.Spi
{
	// Token: 0x020003AA RID: 938
	[Register("java/nio/channels/spi/AbstractInterruptibleChannel", DoNotGenerateAcw = true)]
	internal class AbstractInterruptibleChannelInvoker : AbstractInterruptibleChannel
	{
		// Token: 0x06002971 RID: 10609 RVA: 0x00073170 File Offset: 0x00071370
		public AbstractInterruptibleChannelInvoker(IntPtr handle, JniHandleOwnership transfer) : base(handle, transfer)
		{
		}

		// Token: 0x170007FE RID: 2046
		// (get) Token: 0x06002972 RID: 10610 RVA: 0x00074F19 File Offset: 0x00073119
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return AbstractInterruptibleChannelInvoker._members;
			}
		}

		// Token: 0x170007FF RID: 2047
		// (get) Token: 0x06002973 RID: 10611 RVA: 0x00074F20 File Offset: 0x00073120
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return AbstractInterruptibleChannelInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x040010FF RID: 4351
		private static readonly JniPeerMembers _members = new XAPeerMembers("java/nio/channels/spi/AbstractInterruptibleChannel", typeof(AbstractInterruptibleChannelInvoker));
	}
}
