using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace _COROUTINE
{
	// Token: 0x02000018 RID: 24
	[NullableContext(1)]
	[Nullable(0)]
	[Register("_COROUTINE/CoroutineDebuggingKt", DoNotGenerateAcw = true)]
	public sealed class CoroutineDebuggingKt : Java.Lang.Object
	{
		// Token: 0x17000001 RID: 1
		// (get) Token: 0x0600004B RID: 75 RVA: 0x000020A8 File Offset: 0x000002A8
		internal static IntPtr class_ref
		{
			get
			{
				return CoroutineDebuggingKt._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000002 RID: 2
		// (get) Token: 0x0600004C RID: 76 RVA: 0x000020CC File Offset: 0x000002CC
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return CoroutineDebuggingKt._members;
			}
		}

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x0600004D RID: 77 RVA: 0x000020D4 File Offset: 0x000002D4
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return CoroutineDebuggingKt._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x0600004E RID: 78 RVA: 0x000020F8 File Offset: 0x000002F8
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return CoroutineDebuggingKt._members.ManagedPeerType;
			}
		}

		// Token: 0x0600004F RID: 79 RVA: 0x00002104 File Offset: 0x00000304
		internal CoroutineDebuggingKt(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x04000004 RID: 4
		private static readonly JniPeerMembers _members = new XAPeerMembers("_COROUTINE/CoroutineDebuggingKt", typeof(CoroutineDebuggingKt));
	}
}
