using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;

namespace Java.Net
{
	// Token: 0x020003B6 RID: 950
	[Register("java/net/URLConnection", DoNotGenerateAcw = true)]
	internal class URLConnectionInvoker : URLConnection
	{
		// Token: 0x060029C7 RID: 10695 RVA: 0x00074F80 File Offset: 0x00073180
		public URLConnectionInvoker(IntPtr handle, JniHandleOwnership transfer) : base(handle, transfer)
		{
		}

		// Token: 0x17000824 RID: 2084
		// (get) Token: 0x060029C8 RID: 10696 RVA: 0x00075960 File Offset: 0x00073B60
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return URLConnectionInvoker._members;
			}
		}

		// Token: 0x17000825 RID: 2085
		// (get) Token: 0x060029C9 RID: 10697 RVA: 0x00075967 File Offset: 0x00073B67
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return URLConnectionInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x060029CA RID: 10698 RVA: 0x00075973 File Offset: 0x00073B73
		public override void Connect()
		{
			URLConnectionInvoker._members.InstanceMethods.InvokeAbstractVoidMethod("connect.()V", this, null);
		}

		// Token: 0x04001110 RID: 4368
		private static readonly JniPeerMembers _members = new XAPeerMembers("java/net/URLConnection", typeof(URLConnectionInvoker));
	}
}
