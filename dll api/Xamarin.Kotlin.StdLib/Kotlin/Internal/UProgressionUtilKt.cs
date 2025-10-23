using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Kotlin.Internal
{
	// Token: 0x0200023E RID: 574
	[NullableContext(1)]
	[Nullable(0)]
	[Register("kotlin/internal/UProgressionUtilKt", DoNotGenerateAcw = true)]
	public sealed class UProgressionUtilKt : Java.Lang.Object
	{
		// Token: 0x170007AC RID: 1964
		// (get) Token: 0x06001A79 RID: 6777 RVA: 0x00059174 File Offset: 0x00057374
		internal static IntPtr class_ref
		{
			get
			{
				return UProgressionUtilKt._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170007AD RID: 1965
		// (get) Token: 0x06001A7A RID: 6778 RVA: 0x00059198 File Offset: 0x00057398
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return UProgressionUtilKt._members;
			}
		}

		// Token: 0x170007AE RID: 1966
		// (get) Token: 0x06001A7B RID: 6779 RVA: 0x000591A0 File Offset: 0x000573A0
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return UProgressionUtilKt._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170007AF RID: 1967
		// (get) Token: 0x06001A7C RID: 6780 RVA: 0x000591C4 File Offset: 0x000573C4
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return UProgressionUtilKt._members.ManagedPeerType;
			}
		}

		// Token: 0x06001A7D RID: 6781 RVA: 0x000591D0 File Offset: 0x000573D0
		internal UProgressionUtilKt(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x0400080B RID: 2059
		private static readonly JniPeerMembers _members = new XAPeerMembers("kotlin/internal/UProgressionUtilKt", typeof(UProgressionUtilKt));
	}
}
