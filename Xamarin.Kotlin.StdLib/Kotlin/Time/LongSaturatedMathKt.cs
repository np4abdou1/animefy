using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Kotlin.Time
{
	// Token: 0x020000D2 RID: 210
	[NullableContext(1)]
	[Nullable(0)]
	[Register("kotlin/time/LongSaturatedMathKt", DoNotGenerateAcw = true)]
	public sealed class LongSaturatedMathKt : Java.Lang.Object
	{
		// Token: 0x170001BB RID: 443
		// (get) Token: 0x06000652 RID: 1618 RVA: 0x0000FCA8 File Offset: 0x0000DEA8
		internal static IntPtr class_ref
		{
			get
			{
				return LongSaturatedMathKt._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170001BC RID: 444
		// (get) Token: 0x06000653 RID: 1619 RVA: 0x0000FCCC File Offset: 0x0000DECC
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return LongSaturatedMathKt._members;
			}
		}

		// Token: 0x170001BD RID: 445
		// (get) Token: 0x06000654 RID: 1620 RVA: 0x0000FCD4 File Offset: 0x0000DED4
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return LongSaturatedMathKt._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170001BE RID: 446
		// (get) Token: 0x06000655 RID: 1621 RVA: 0x0000FCF8 File Offset: 0x0000DEF8
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return LongSaturatedMathKt._members.ManagedPeerType;
			}
		}

		// Token: 0x06000656 RID: 1622 RVA: 0x0000FD04 File Offset: 0x0000DF04
		internal LongSaturatedMathKt(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x040001C3 RID: 451
		private static readonly JniPeerMembers _members = new XAPeerMembers("kotlin/time/LongSaturatedMathKt", typeof(LongSaturatedMathKt));
	}
}
