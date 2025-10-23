using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Graphics;
using Android.Runtime;
using Java.Interop;

namespace Android.Text
{
	// Token: 0x020001BA RID: 442
	[Register("android/text/TextPaint", DoNotGenerateAcw = true)]
	public class TextPaint : Paint
	{
		// Token: 0x1700031C RID: 796
		// (get) Token: 0x06001016 RID: 4118 RVA: 0x0002A227 File Offset: 0x00028427
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return TextPaint._members;
			}
		}

		// Token: 0x1700031D RID: 797
		// (get) Token: 0x06001017 RID: 4119 RVA: 0x0002A230 File Offset: 0x00028430
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return TextPaint._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700031E RID: 798
		// (get) Token: 0x06001018 RID: 4120 RVA: 0x0002A254 File Offset: 0x00028454
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return TextPaint._members.ManagedPeerType;
			}
		}

		// Token: 0x06001019 RID: 4121 RVA: 0x0002A260 File Offset: 0x00028460
		protected TextPaint(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x04000759 RID: 1881
		private static readonly JniPeerMembers _members = new XAPeerMembers("android/text/TextPaint", typeof(TextPaint));
	}
}
