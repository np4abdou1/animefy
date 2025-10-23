using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Kotlin.Time.Jdk8
{
	// Token: 0x020000D7 RID: 215
	[NullableContext(1)]
	[Nullable(0)]
	[Register("kotlin/time/jdk8/DurationConversionsJDK8Kt", DoNotGenerateAcw = true)]
	public sealed class DurationConversionsJDK8Kt : Java.Lang.Object
	{
		// Token: 0x170001D1 RID: 465
		// (get) Token: 0x0600067F RID: 1663 RVA: 0x00010560 File Offset: 0x0000E760
		internal static IntPtr class_ref
		{
			get
			{
				return DurationConversionsJDK8Kt._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170001D2 RID: 466
		// (get) Token: 0x06000680 RID: 1664 RVA: 0x00010584 File Offset: 0x0000E784
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return DurationConversionsJDK8Kt._members;
			}
		}

		// Token: 0x170001D3 RID: 467
		// (get) Token: 0x06000681 RID: 1665 RVA: 0x0001058C File Offset: 0x0000E78C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return DurationConversionsJDK8Kt._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170001D4 RID: 468
		// (get) Token: 0x06000682 RID: 1666 RVA: 0x000105B0 File Offset: 0x0000E7B0
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return DurationConversionsJDK8Kt._members.ManagedPeerType;
			}
		}

		// Token: 0x06000683 RID: 1667 RVA: 0x000105BC File Offset: 0x0000E7BC
		internal DurationConversionsJDK8Kt(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x040001C8 RID: 456
		private static readonly JniPeerMembers _members = new XAPeerMembers("kotlin/time/jdk8/DurationConversionsJDK8Kt", typeof(DurationConversionsJDK8Kt));
	}
}
