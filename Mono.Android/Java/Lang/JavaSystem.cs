using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;

namespace Java.Lang
{
	// Token: 0x020003E2 RID: 994
	[Register("java/lang/System", DoNotGenerateAcw = true)]
	public sealed class JavaSystem : Object
	{
		// Token: 0x17000894 RID: 2196
		// (get) Token: 0x06002BA4 RID: 11172 RVA: 0x0007918E File Offset: 0x0007738E
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return JavaSystem._members;
			}
		}

		// Token: 0x17000895 RID: 2197
		// (get) Token: 0x06002BA5 RID: 11173 RVA: 0x00079198 File Offset: 0x00077398
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return JavaSystem._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000896 RID: 2198
		// (get) Token: 0x06002BA6 RID: 11174 RVA: 0x000791BC File Offset: 0x000773BC
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return JavaSystem._members.ManagedPeerType;
			}
		}

		// Token: 0x06002BA7 RID: 11175 RVA: 0x000021E0 File Offset: 0x000003E0
		internal JavaSystem(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06002BA8 RID: 11176 RVA: 0x000791C8 File Offset: 0x000773C8
		public static long CurrentTimeMillis()
		{
			return JavaSystem._members.StaticMethods.InvokeInt64Method("currentTimeMillis.()J", null);
		}

		// Token: 0x04001172 RID: 4466
		private static readonly JniPeerMembers _members = new XAPeerMembers("java/lang/System", typeof(JavaSystem));
	}
}
