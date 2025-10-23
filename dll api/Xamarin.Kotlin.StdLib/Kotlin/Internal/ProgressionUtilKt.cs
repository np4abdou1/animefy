using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Kotlin.Internal
{
	// Token: 0x0200023D RID: 573
	[NullableContext(1)]
	[Nullable(0)]
	[Register("kotlin/internal/ProgressionUtilKt", DoNotGenerateAcw = true)]
	public sealed class ProgressionUtilKt : Java.Lang.Object
	{
		// Token: 0x170007A8 RID: 1960
		// (get) Token: 0x06001A73 RID: 6771 RVA: 0x000590F0 File Offset: 0x000572F0
		internal static IntPtr class_ref
		{
			get
			{
				return ProgressionUtilKt._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170007A9 RID: 1961
		// (get) Token: 0x06001A74 RID: 6772 RVA: 0x00059114 File Offset: 0x00057314
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return ProgressionUtilKt._members;
			}
		}

		// Token: 0x170007AA RID: 1962
		// (get) Token: 0x06001A75 RID: 6773 RVA: 0x0005911C File Offset: 0x0005731C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return ProgressionUtilKt._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170007AB RID: 1963
		// (get) Token: 0x06001A76 RID: 6774 RVA: 0x00059140 File Offset: 0x00057340
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return ProgressionUtilKt._members.ManagedPeerType;
			}
		}

		// Token: 0x06001A77 RID: 6775 RVA: 0x0005914C File Offset: 0x0005734C
		internal ProgressionUtilKt(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x0400080A RID: 2058
		private static readonly JniPeerMembers _members = new XAPeerMembers("kotlin/internal/ProgressionUtilKt", typeof(ProgressionUtilKt));
	}
}
