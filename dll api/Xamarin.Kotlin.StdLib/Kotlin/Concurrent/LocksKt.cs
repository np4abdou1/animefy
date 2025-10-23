using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Kotlin.Concurrent
{
	// Token: 0x02000280 RID: 640
	[NullableContext(1)]
	[Nullable(0)]
	[Register("kotlin/concurrent/LocksKt", DoNotGenerateAcw = true)]
	public sealed class LocksKt : Java.Lang.Object
	{
		// Token: 0x1700085C RID: 2140
		// (get) Token: 0x06001CC8 RID: 7368 RVA: 0x0005F660 File Offset: 0x0005D860
		internal static IntPtr class_ref
		{
			get
			{
				return LocksKt._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700085D RID: 2141
		// (get) Token: 0x06001CC9 RID: 7369 RVA: 0x0005F684 File Offset: 0x0005D884
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return LocksKt._members;
			}
		}

		// Token: 0x1700085E RID: 2142
		// (get) Token: 0x06001CCA RID: 7370 RVA: 0x0005F68C File Offset: 0x0005D88C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return LocksKt._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700085F RID: 2143
		// (get) Token: 0x06001CCB RID: 7371 RVA: 0x0005F6B0 File Offset: 0x0005D8B0
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return LocksKt._members.ManagedPeerType;
			}
		}

		// Token: 0x06001CCC RID: 7372 RVA: 0x0005F6BC File Offset: 0x0005D8BC
		internal LocksKt(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x040008DC RID: 2268
		private static readonly JniPeerMembers _members = new XAPeerMembers("kotlin/concurrent/LocksKt", typeof(LocksKt));
	}
}
