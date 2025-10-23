using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;

namespace Bumptech.Glide.Load.Engine.BitmapRecycle
{
	// Token: 0x02000174 RID: 372
	[Register("com/bumptech/glide/load/engine/bitmap_recycle/BaseKeyPool", DoNotGenerateAcw = true)]
	internal class BaseKeyPoolInvoker : BaseKeyPool
	{
		// Token: 0x06001287 RID: 4743 RVA: 0x0003B99B File Offset: 0x00039B9B
		public BaseKeyPoolInvoker(IntPtr handle, JniHandleOwnership transfer) : base(handle, transfer)
		{
		}

		// Token: 0x170004EE RID: 1262
		// (get) Token: 0x06001288 RID: 4744 RVA: 0x0003B9A5 File Offset: 0x00039BA5
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return BaseKeyPoolInvoker._members;
			}
		}

		// Token: 0x170004EF RID: 1263
		// (get) Token: 0x06001289 RID: 4745 RVA: 0x0003B9AC File Offset: 0x00039BAC
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return BaseKeyPoolInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x04000455 RID: 1109
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/bumptech/glide/load/engine/bitmap_recycle/BaseKeyPool", typeof(BaseKeyPoolInvoker));
	}
}
