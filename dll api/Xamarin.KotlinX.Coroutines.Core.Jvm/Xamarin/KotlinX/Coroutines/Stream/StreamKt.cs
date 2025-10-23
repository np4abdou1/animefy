using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Xamarin.KotlinX.Coroutines.Stream
{
	// Token: 0x0200008F RID: 143
	[NullableContext(1)]
	[Nullable(0)]
	[Register("kotlinx/coroutines/stream/StreamKt", DoNotGenerateAcw = true)]
	public sealed class StreamKt : Java.Lang.Object
	{
		// Token: 0x170001DB RID: 475
		// (get) Token: 0x06000655 RID: 1621 RVA: 0x00014E30 File Offset: 0x00013030
		internal static IntPtr class_ref
		{
			get
			{
				return StreamKt._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170001DC RID: 476
		// (get) Token: 0x06000656 RID: 1622 RVA: 0x00014E54 File Offset: 0x00013054
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return StreamKt._members;
			}
		}

		// Token: 0x170001DD RID: 477
		// (get) Token: 0x06000657 RID: 1623 RVA: 0x00014E5C File Offset: 0x0001305C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return StreamKt._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170001DE RID: 478
		// (get) Token: 0x06000658 RID: 1624 RVA: 0x00014E80 File Offset: 0x00013080
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return StreamKt._members.ManagedPeerType;
			}
		}

		// Token: 0x06000659 RID: 1625 RVA: 0x00014E8C File Offset: 0x0001308C
		internal StreamKt(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x0400022C RID: 556
		private static readonly JniPeerMembers _members = new XAPeerMembers("kotlinx/coroutines/stream/StreamKt", typeof(StreamKt));
	}
}
