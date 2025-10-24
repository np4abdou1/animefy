using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Org.Json
{
	// Token: 0x0200008C RID: 140
	[Register("org/json/JSONArray", DoNotGenerateAcw = true)]
	public class JSONArray : Java.Lang.Object
	{
		// Token: 0x17000003 RID: 3
		// (get) Token: 0x06000223 RID: 547 RVA: 0x000021A8 File Offset: 0x000003A8
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return JSONArray._members;
			}
		}

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x06000224 RID: 548 RVA: 0x000021B0 File Offset: 0x000003B0
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return JSONArray._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000005 RID: 5
		// (get) Token: 0x06000225 RID: 549 RVA: 0x000021D4 File Offset: 0x000003D4
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return JSONArray._members.ManagedPeerType;
			}
		}

		// Token: 0x06000226 RID: 550 RVA: 0x000021E0 File Offset: 0x000003E0
		protected JSONArray(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x04000005 RID: 5
		private static readonly JniPeerMembers _members = new XAPeerMembers("org/json/JSONArray", typeof(JSONArray));
	}
}
