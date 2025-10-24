using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;

namespace Bumptech.Glide.Request
{
	// Token: 0x02000087 RID: 135
	[Register("com/bumptech/glide/request/BaseRequestOptions", DoNotGenerateAcw = true)]
	internal class BaseRequestOptionsInvoker : BaseRequestOptions
	{
		// Token: 0x060006C2 RID: 1730 RVA: 0x000155AC File Offset: 0x000137AC
		public BaseRequestOptionsInvoker(IntPtr handle, JniHandleOwnership transfer) : base(handle, transfer)
		{
		}

		// Token: 0x17000153 RID: 339
		// (get) Token: 0x060006C3 RID: 1731 RVA: 0x000155B6 File Offset: 0x000137B6
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return BaseRequestOptionsInvoker._members;
			}
		}

		// Token: 0x17000154 RID: 340
		// (get) Token: 0x060006C4 RID: 1732 RVA: 0x000155BD File Offset: 0x000137BD
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return BaseRequestOptionsInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x0400017F RID: 383
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/bumptech/glide/request/BaseRequestOptions", typeof(BaseRequestOptionsInvoker));
	}
}
