using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Org.Json
{
	// Token: 0x0200008D RID: 141
	[Register("org/json/JSONObject", DoNotGenerateAcw = true)]
	public class JSONObject : Java.Lang.Object
	{
		// Token: 0x17000006 RID: 6
		// (get) Token: 0x06000228 RID: 552 RVA: 0x00002205 File Offset: 0x00000405
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return JSONObject._members;
			}
		}

		// Token: 0x17000007 RID: 7
		// (get) Token: 0x06000229 RID: 553 RVA: 0x0000220C File Offset: 0x0000040C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return JSONObject._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000008 RID: 8
		// (get) Token: 0x0600022A RID: 554 RVA: 0x00002230 File Offset: 0x00000430
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return JSONObject._members.ManagedPeerType;
			}
		}

		// Token: 0x0600022B RID: 555 RVA: 0x000021E0 File Offset: 0x000003E0
		protected JSONObject(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x04000006 RID: 6
		private static readonly JniPeerMembers _members = new XAPeerMembers("org/json/JSONObject", typeof(JSONObject));
	}
}
