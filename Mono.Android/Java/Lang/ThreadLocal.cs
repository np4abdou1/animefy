using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;

namespace Java.Lang
{
	// Token: 0x020003F7 RID: 1015
	[Register("java/lang/ThreadLocal", DoNotGenerateAcw = true)]
	[JavaTypeParameters(new string[]
	{
		"T"
	})]
	public class ThreadLocal : Object
	{
		// Token: 0x170008D2 RID: 2258
		// (get) Token: 0x06002C8F RID: 11407 RVA: 0x0007AE24 File Offset: 0x00079024
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return ThreadLocal._members;
			}
		}

		// Token: 0x170008D3 RID: 2259
		// (get) Token: 0x06002C90 RID: 11408 RVA: 0x0007AE2C File Offset: 0x0007902C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return ThreadLocal._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170008D4 RID: 2260
		// (get) Token: 0x06002C91 RID: 11409 RVA: 0x0007AE50 File Offset: 0x00079050
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return ThreadLocal._members.ManagedPeerType;
			}
		}

		// Token: 0x06002C92 RID: 11410 RVA: 0x000021E0 File Offset: 0x000003E0
		protected ThreadLocal(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x040011A2 RID: 4514
		private static readonly JniPeerMembers _members = new XAPeerMembers("java/lang/ThreadLocal", typeof(ThreadLocal));
	}
}
