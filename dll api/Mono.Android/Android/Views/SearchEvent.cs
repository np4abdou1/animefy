using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Android.Views
{
	// Token: 0x0200013C RID: 316
	[Register("android/view/SearchEvent", DoNotGenerateAcw = true, ApiSince = 23)]
	public class SearchEvent : Java.Lang.Object
	{
		// Token: 0x1700020C RID: 524
		// (get) Token: 0x06000A8F RID: 2703 RVA: 0x0001A6EF File Offset: 0x000188EF
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return SearchEvent._members;
			}
		}

		// Token: 0x1700020D RID: 525
		// (get) Token: 0x06000A90 RID: 2704 RVA: 0x0001A6F8 File Offset: 0x000188F8
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return SearchEvent._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700020E RID: 526
		// (get) Token: 0x06000A91 RID: 2705 RVA: 0x0001A71C File Offset: 0x0001891C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return SearchEvent._members.ManagedPeerType;
			}
		}

		// Token: 0x06000A92 RID: 2706 RVA: 0x000021E0 File Offset: 0x000003E0
		protected SearchEvent(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x0400036D RID: 877
		private static readonly JniPeerMembers _members = new XAPeerMembers("android/view/SearchEvent", typeof(SearchEvent));
	}
}
