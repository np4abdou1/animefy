using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Kotlin.Text
{
	// Token: 0x020000DB RID: 219
	[NullableContext(1)]
	[Nullable(0)]
	[Register("kotlin/text/CharsetsKt", DoNotGenerateAcw = true)]
	public sealed class CharsetsKt : Java.Lang.Object
	{
		// Token: 0x17000221 RID: 545
		// (get) Token: 0x060006DF RID: 1759 RVA: 0x0001157C File Offset: 0x0000F77C
		internal static IntPtr class_ref
		{
			get
			{
				return CharsetsKt._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000222 RID: 546
		// (get) Token: 0x060006E0 RID: 1760 RVA: 0x000115A0 File Offset: 0x0000F7A0
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return CharsetsKt._members;
			}
		}

		// Token: 0x17000223 RID: 547
		// (get) Token: 0x060006E1 RID: 1761 RVA: 0x000115A8 File Offset: 0x0000F7A8
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return CharsetsKt._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000224 RID: 548
		// (get) Token: 0x060006E2 RID: 1762 RVA: 0x000115CC File Offset: 0x0000F7CC
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return CharsetsKt._members.ManagedPeerType;
			}
		}

		// Token: 0x060006E3 RID: 1763 RVA: 0x000115D8 File Offset: 0x0000F7D8
		internal CharsetsKt(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x040001CC RID: 460
		private static readonly JniPeerMembers _members = new XAPeerMembers("kotlin/text/CharsetsKt", typeof(CharsetsKt));
	}
}
