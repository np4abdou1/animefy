using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;

namespace Java.Net
{
	// Token: 0x020003AC RID: 940
	[Register("java/net/HttpURLConnection", DoNotGenerateAcw = true)]
	internal class HttpURLConnectionInvoker : HttpURLConnection
	{
		// Token: 0x0600297A RID: 10618 RVA: 0x00074FA5 File Offset: 0x000731A5
		public HttpURLConnectionInvoker(IntPtr handle, JniHandleOwnership transfer) : base(handle, transfer)
		{
		}

		// Token: 0x17000803 RID: 2051
		// (get) Token: 0x0600297B RID: 10619 RVA: 0x00074FAF File Offset: 0x000731AF
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return HttpURLConnectionInvoker._members;
			}
		}

		// Token: 0x17000804 RID: 2052
		// (get) Token: 0x0600297C RID: 10620 RVA: 0x00074FB6 File Offset: 0x000731B6
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return HttpURLConnectionInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x0600297D RID: 10621 RVA: 0x00074FC2 File Offset: 0x000731C2
		public override void Connect()
		{
			HttpURLConnectionInvoker._members.InstanceMethods.InvokeAbstractVoidMethod("connect.()V", this, null);
		}

		// Token: 0x04001101 RID: 4353
		private static readonly JniPeerMembers _members = new XAPeerMembers("java/net/HttpURLConnection", typeof(HttpURLConnectionInvoker));
	}
}
