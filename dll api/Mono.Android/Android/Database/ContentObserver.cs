using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Android.Database
{
	// Token: 0x02000240 RID: 576
	[Register("android/database/ContentObserver", DoNotGenerateAcw = true)]
	public abstract class ContentObserver : Java.Lang.Object
	{
		// Token: 0x1700047F RID: 1151
		// (get) Token: 0x06001473 RID: 5235 RVA: 0x00034B0B File Offset: 0x00032D0B
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return ContentObserver._members;
			}
		}

		// Token: 0x17000480 RID: 1152
		// (get) Token: 0x06001474 RID: 5236 RVA: 0x00034B14 File Offset: 0x00032D14
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return ContentObserver._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000481 RID: 1153
		// (get) Token: 0x06001475 RID: 5237 RVA: 0x00034B38 File Offset: 0x00032D38
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return ContentObserver._members.ManagedPeerType;
			}
		}

		// Token: 0x06001476 RID: 5238 RVA: 0x000021E0 File Offset: 0x000003E0
		protected ContentObserver(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x040008EA RID: 2282
		private static readonly JniPeerMembers _members = new XAPeerMembers("android/database/ContentObserver", typeof(ContentObserver));
	}
}
