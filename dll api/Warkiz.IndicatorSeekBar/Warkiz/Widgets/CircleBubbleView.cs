using System;
using Android.Runtime;
using Android.Views;
using Java.Interop;

namespace Warkiz.Widgets
{
	// Token: 0x02000004 RID: 4
	[Register("com/warkiz/widget/CircleBubbleView", DoNotGenerateAcw = true)]
	public class CircleBubbleView : View
	{
		// Token: 0x17000009 RID: 9
		// (get) Token: 0x0600009A RID: 154 RVA: 0x00003D48 File Offset: 0x00001F48
		internal static IntPtr class_ref
		{
			get
			{
				return CircleBubbleView._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700000A RID: 10
		// (get) Token: 0x0600009B RID: 155 RVA: 0x00003D6C File Offset: 0x00001F6C
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return CircleBubbleView._members;
			}
		}

		// Token: 0x1700000B RID: 11
		// (get) Token: 0x0600009C RID: 156 RVA: 0x00003D74 File Offset: 0x00001F74
		protected override IntPtr ThresholdClass
		{
			get
			{
				return CircleBubbleView._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700000C RID: 12
		// (get) Token: 0x0600009D RID: 157 RVA: 0x00003D98 File Offset: 0x00001F98
		protected override Type ThresholdType
		{
			get
			{
				return CircleBubbleView._members.ManagedPeerType;
			}
		}

		// Token: 0x0600009E RID: 158 RVA: 0x000020AC File Offset: 0x000002AC
		protected CircleBubbleView(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x04000031 RID: 49
		internal static readonly JniPeerMembers _members = new XAPeerMembers("com/warkiz/widget/CircleBubbleView", typeof(CircleBubbleView));
	}
}
