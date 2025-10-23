using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Kotlin.Collections
{
	// Token: 0x020002D5 RID: 725
	[NullableContext(1)]
	[Nullable(0)]
	[Register("kotlin/collections/SlidingWindowKt", DoNotGenerateAcw = true)]
	public sealed class SlidingWindowKt : Java.Lang.Object
	{
		// Token: 0x170009DE RID: 2526
		// (get) Token: 0x06002849 RID: 10313 RVA: 0x000B03B8 File Offset: 0x000AE5B8
		internal static IntPtr class_ref
		{
			get
			{
				return SlidingWindowKt._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170009DF RID: 2527
		// (get) Token: 0x0600284A RID: 10314 RVA: 0x000B03DC File Offset: 0x000AE5DC
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return SlidingWindowKt._members;
			}
		}

		// Token: 0x170009E0 RID: 2528
		// (get) Token: 0x0600284B RID: 10315 RVA: 0x000B03E4 File Offset: 0x000AE5E4
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return SlidingWindowKt._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170009E1 RID: 2529
		// (get) Token: 0x0600284C RID: 10316 RVA: 0x000B0408 File Offset: 0x000AE608
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return SlidingWindowKt._members.ManagedPeerType;
			}
		}

		// Token: 0x0600284D RID: 10317 RVA: 0x000B0414 File Offset: 0x000AE614
		internal SlidingWindowKt(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x040009C3 RID: 2499
		private static readonly JniPeerMembers _members = new XAPeerMembers("kotlin/collections/SlidingWindowKt", typeof(SlidingWindowKt));
	}
}
