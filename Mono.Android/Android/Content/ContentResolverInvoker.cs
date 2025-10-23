using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;

namespace Android.Content
{
	// Token: 0x02000282 RID: 642
	[Register("android/content/ContentResolver", DoNotGenerateAcw = true)]
	internal class ContentResolverInvoker : ContentResolver
	{
		// Token: 0x06001864 RID: 6244 RVA: 0x0003F313 File Offset: 0x0003D513
		public ContentResolverInvoker(IntPtr handle, JniHandleOwnership transfer) : base(handle, transfer)
		{
		}

		// Token: 0x1700053B RID: 1339
		// (get) Token: 0x06001865 RID: 6245 RVA: 0x0003F31D File Offset: 0x0003D51D
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return ContentResolverInvoker._members;
			}
		}

		// Token: 0x1700053C RID: 1340
		// (get) Token: 0x06001866 RID: 6246 RVA: 0x0003F324 File Offset: 0x0003D524
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return ContentResolverInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x04000A55 RID: 2645
		private static readonly JniPeerMembers _members = new XAPeerMembers("android/content/ContentResolver", typeof(ContentResolverInvoker));
	}
}
