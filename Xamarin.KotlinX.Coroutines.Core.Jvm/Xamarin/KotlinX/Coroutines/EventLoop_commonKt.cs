using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Xamarin.KotlinX.Coroutines
{
	// Token: 0x02000033 RID: 51
	[NullableContext(1)]
	[Nullable(0)]
	[Register("kotlinx/coroutines/EventLoop_commonKt", DoNotGenerateAcw = true)]
	public sealed class EventLoop_commonKt : Java.Lang.Object
	{
		// Token: 0x17000072 RID: 114
		// (get) Token: 0x06000136 RID: 310 RVA: 0x00004E9C File Offset: 0x0000309C
		internal static IntPtr class_ref
		{
			get
			{
				return EventLoop_commonKt._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000073 RID: 115
		// (get) Token: 0x06000137 RID: 311 RVA: 0x00004EC0 File Offset: 0x000030C0
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return EventLoop_commonKt._members;
			}
		}

		// Token: 0x17000074 RID: 116
		// (get) Token: 0x06000138 RID: 312 RVA: 0x00004EC8 File Offset: 0x000030C8
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return EventLoop_commonKt._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000075 RID: 117
		// (get) Token: 0x06000139 RID: 313 RVA: 0x00004EEC File Offset: 0x000030EC
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return EventLoop_commonKt._members.ManagedPeerType;
			}
		}

		// Token: 0x0600013A RID: 314 RVA: 0x00004EF8 File Offset: 0x000030F8
		internal EventLoop_commonKt(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x04000029 RID: 41
		private static readonly JniPeerMembers _members = new XAPeerMembers("kotlinx/coroutines/EventLoop_commonKt", typeof(EventLoop_commonKt));
	}
}
