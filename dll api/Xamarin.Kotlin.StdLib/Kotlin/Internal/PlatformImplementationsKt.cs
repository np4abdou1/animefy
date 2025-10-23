using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Kotlin.Internal
{
	// Token: 0x0200023C RID: 572
	[NullableContext(1)]
	[Nullable(0)]
	[Register("kotlin/internal/PlatformImplementationsKt", DoNotGenerateAcw = true)]
	public sealed class PlatformImplementationsKt : Java.Lang.Object
	{
		// Token: 0x170007A4 RID: 1956
		// (get) Token: 0x06001A6D RID: 6765 RVA: 0x0005906C File Offset: 0x0005726C
		internal static IntPtr class_ref
		{
			get
			{
				return PlatformImplementationsKt._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170007A5 RID: 1957
		// (get) Token: 0x06001A6E RID: 6766 RVA: 0x00059090 File Offset: 0x00057290
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return PlatformImplementationsKt._members;
			}
		}

		// Token: 0x170007A6 RID: 1958
		// (get) Token: 0x06001A6F RID: 6767 RVA: 0x00059098 File Offset: 0x00057298
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return PlatformImplementationsKt._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170007A7 RID: 1959
		// (get) Token: 0x06001A70 RID: 6768 RVA: 0x000590BC File Offset: 0x000572BC
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return PlatformImplementationsKt._members.ManagedPeerType;
			}
		}

		// Token: 0x06001A71 RID: 6769 RVA: 0x000590C8 File Offset: 0x000572C8
		internal PlatformImplementationsKt(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x04000809 RID: 2057
		private static readonly JniPeerMembers _members = new XAPeerMembers("kotlin/internal/PlatformImplementationsKt", typeof(PlatformImplementationsKt));
	}
}
