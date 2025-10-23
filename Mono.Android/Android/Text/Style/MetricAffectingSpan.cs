using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;

namespace Android.Text.Style
{
	// Token: 0x020001CA RID: 458
	[Register("android/text/style/MetricAffectingSpan", DoNotGenerateAcw = true)]
	public abstract class MetricAffectingSpan : CharacterStyle, IUpdateLayout, IUpdateAppearance, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x1700033B RID: 827
		// (get) Token: 0x0600106B RID: 4203 RVA: 0x0002AC97 File Offset: 0x00028E97
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return MetricAffectingSpan._members;
			}
		}

		// Token: 0x1700033C RID: 828
		// (get) Token: 0x0600106C RID: 4204 RVA: 0x0002ACA0 File Offset: 0x00028EA0
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return MetricAffectingSpan._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700033D RID: 829
		// (get) Token: 0x0600106D RID: 4205 RVA: 0x0002ACC4 File Offset: 0x00028EC4
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return MetricAffectingSpan._members.ManagedPeerType;
			}
		}

		// Token: 0x0600106E RID: 4206 RVA: 0x0002A4DE File Offset: 0x000286DE
		protected MetricAffectingSpan(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x04000786 RID: 1926
		private static readonly JniPeerMembers _members = new XAPeerMembers("android/text/style/MetricAffectingSpan", typeof(MetricAffectingSpan));
	}
}
