using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Kotlin.Streams.Jdk8
{
	// Token: 0x020000F5 RID: 245
	[NullableContext(1)]
	[Nullable(0)]
	[Register("kotlin/streams/jdk8/StreamsKt", DoNotGenerateAcw = true)]
	public sealed class StreamsKt : Java.Lang.Object
	{
		// Token: 0x1700029E RID: 670
		// (get) Token: 0x06000A02 RID: 2562 RVA: 0x00021B44 File Offset: 0x0001FD44
		internal static IntPtr class_ref
		{
			get
			{
				return StreamsKt._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700029F RID: 671
		// (get) Token: 0x06000A03 RID: 2563 RVA: 0x00021B68 File Offset: 0x0001FD68
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return StreamsKt._members;
			}
		}

		// Token: 0x170002A0 RID: 672
		// (get) Token: 0x06000A04 RID: 2564 RVA: 0x00021B70 File Offset: 0x0001FD70
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return StreamsKt._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170002A1 RID: 673
		// (get) Token: 0x06000A05 RID: 2565 RVA: 0x00021B94 File Offset: 0x0001FD94
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return StreamsKt._members.ManagedPeerType;
			}
		}

		// Token: 0x06000A06 RID: 2566 RVA: 0x00021BA0 File Offset: 0x0001FDA0
		internal StreamsKt(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x0400025D RID: 605
		private static readonly JniPeerMembers _members = new XAPeerMembers("kotlin/streams/jdk8/StreamsKt", typeof(StreamsKt));
	}
}
