using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Android.Graphics
{
	// Token: 0x0200021B RID: 539
	[Register("android/graphics/Canvas", DoNotGenerateAcw = true)]
	public class Canvas : Java.Lang.Object
	{
		// Token: 0x17000413 RID: 1043
		// (get) Token: 0x0600133C RID: 4924 RVA: 0x00032473 File Offset: 0x00030673
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return Canvas._members;
			}
		}

		// Token: 0x17000414 RID: 1044
		// (get) Token: 0x0600133D RID: 4925 RVA: 0x0003247C File Offset: 0x0003067C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return Canvas._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000415 RID: 1045
		// (get) Token: 0x0600133E RID: 4926 RVA: 0x000324A0 File Offset: 0x000306A0
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return Canvas._members.ManagedPeerType;
			}
		}

		// Token: 0x0600133F RID: 4927 RVA: 0x000021E0 File Offset: 0x000003E0
		protected Canvas(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x04000893 RID: 2195
		private static readonly JniPeerMembers _members = new XAPeerMembers("android/graphics/Canvas", typeof(Canvas));
	}
}
