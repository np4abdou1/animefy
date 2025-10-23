using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Android.Database
{
	// Token: 0x0200023F RID: 575
	[Register("android/database/CharArrayBuffer", DoNotGenerateAcw = true)]
	public sealed class CharArrayBuffer : Java.Lang.Object
	{
		// Token: 0x1700047C RID: 1148
		// (get) Token: 0x0600146E RID: 5230 RVA: 0x00034AB9 File Offset: 0x00032CB9
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return CharArrayBuffer._members;
			}
		}

		// Token: 0x1700047D RID: 1149
		// (get) Token: 0x0600146F RID: 5231 RVA: 0x00034AC0 File Offset: 0x00032CC0
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return CharArrayBuffer._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700047E RID: 1150
		// (get) Token: 0x06001470 RID: 5232 RVA: 0x00034AE4 File Offset: 0x00032CE4
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return CharArrayBuffer._members.ManagedPeerType;
			}
		}

		// Token: 0x06001471 RID: 5233 RVA: 0x000021E0 File Offset: 0x000003E0
		internal CharArrayBuffer(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x040008E9 RID: 2281
		private static readonly JniPeerMembers _members = new XAPeerMembers("android/database/CharArrayBuffer", typeof(CharArrayBuffer));
	}
}
