using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Kotlin.Concurrent
{
	// Token: 0x02000282 RID: 642
	[NullableContext(1)]
	[Nullable(0)]
	[Register("kotlin/concurrent/TimersKt", DoNotGenerateAcw = true)]
	public sealed class TimersKt : Java.Lang.Object
	{
		// Token: 0x17000864 RID: 2148
		// (get) Token: 0x06001CD5 RID: 7381 RVA: 0x0005F870 File Offset: 0x0005DA70
		internal static IntPtr class_ref
		{
			get
			{
				return TimersKt._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000865 RID: 2149
		// (get) Token: 0x06001CD6 RID: 7382 RVA: 0x0005F894 File Offset: 0x0005DA94
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return TimersKt._members;
			}
		}

		// Token: 0x17000866 RID: 2150
		// (get) Token: 0x06001CD7 RID: 7383 RVA: 0x0005F89C File Offset: 0x0005DA9C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return TimersKt._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000867 RID: 2151
		// (get) Token: 0x06001CD8 RID: 7384 RVA: 0x0005F8C0 File Offset: 0x0005DAC0
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return TimersKt._members.ManagedPeerType;
			}
		}

		// Token: 0x06001CD9 RID: 7385 RVA: 0x0005F8CC File Offset: 0x0005DACC
		internal TimersKt(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x040008DE RID: 2270
		private static readonly JniPeerMembers _members = new XAPeerMembers("kotlin/concurrent/TimersKt", typeof(TimersKt));
	}
}
