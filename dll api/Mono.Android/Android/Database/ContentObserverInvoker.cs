using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;

namespace Android.Database
{
	// Token: 0x02000241 RID: 577
	[Register("android/database/ContentObserver", DoNotGenerateAcw = true)]
	internal class ContentObserverInvoker : ContentObserver
	{
		// Token: 0x06001478 RID: 5240 RVA: 0x00034B5F File Offset: 0x00032D5F
		public ContentObserverInvoker(IntPtr handle, JniHandleOwnership transfer) : base(handle, transfer)
		{
		}

		// Token: 0x17000482 RID: 1154
		// (get) Token: 0x06001479 RID: 5241 RVA: 0x00034B69 File Offset: 0x00032D69
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return ContentObserverInvoker._members;
			}
		}

		// Token: 0x17000483 RID: 1155
		// (get) Token: 0x0600147A RID: 5242 RVA: 0x00034B70 File Offset: 0x00032D70
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return ContentObserverInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x040008EB RID: 2283
		private static readonly JniPeerMembers _members = new XAPeerMembers("android/database/ContentObserver", typeof(ContentObserverInvoker));
	}
}
