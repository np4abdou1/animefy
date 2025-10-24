using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;

namespace Android.Graphics.Drawables
{
	// Token: 0x0200023E RID: 574
	[Register("android/graphics/drawable/StateListDrawable", DoNotGenerateAcw = true)]
	public class StateListDrawable : DrawableContainer
	{
		// Token: 0x17000479 RID: 1145
		// (get) Token: 0x06001469 RID: 5225 RVA: 0x00034A5B File Offset: 0x00032C5B
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return StateListDrawable._members;
			}
		}

		// Token: 0x1700047A RID: 1146
		// (get) Token: 0x0600146A RID: 5226 RVA: 0x00034A64 File Offset: 0x00032C64
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return StateListDrawable._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700047B RID: 1147
		// (get) Token: 0x0600146B RID: 5227 RVA: 0x00034A88 File Offset: 0x00032C88
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return StateListDrawable._members.ManagedPeerType;
			}
		}

		// Token: 0x0600146C RID: 5228 RVA: 0x00034A94 File Offset: 0x00032C94
		protected StateListDrawable(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x040008E8 RID: 2280
		private static readonly JniPeerMembers _members = new XAPeerMembers("android/graphics/drawable/StateListDrawable", typeof(StateListDrawable));
	}
}
