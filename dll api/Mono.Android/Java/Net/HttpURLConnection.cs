using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;

namespace Java.Net
{
	// Token: 0x020003AB RID: 939
	[Register("java/net/HttpURLConnection", DoNotGenerateAcw = true)]
	public abstract class HttpURLConnection : URLConnection
	{
		// Token: 0x17000800 RID: 2048
		// (get) Token: 0x06002975 RID: 10613 RVA: 0x00074F47 File Offset: 0x00073147
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return HttpURLConnection._members;
			}
		}

		// Token: 0x17000801 RID: 2049
		// (get) Token: 0x06002976 RID: 10614 RVA: 0x00074F50 File Offset: 0x00073150
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return HttpURLConnection._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000802 RID: 2050
		// (get) Token: 0x06002977 RID: 10615 RVA: 0x00074F74 File Offset: 0x00073174
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return HttpURLConnection._members.ManagedPeerType;
			}
		}

		// Token: 0x06002978 RID: 10616 RVA: 0x00074F80 File Offset: 0x00073180
		protected HttpURLConnection(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x04001100 RID: 4352
		private static readonly JniPeerMembers _members = new XAPeerMembers("java/net/HttpURLConnection", typeof(HttpURLConnection));
	}
}
