using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Xamarin.KotlinX.Coroutines
{
	// Token: 0x02000032 RID: 50
	[NullableContext(1)]
	[Nullable(0)]
	[Register("kotlinx/coroutines/EventLoopKt", DoNotGenerateAcw = true)]
	public sealed class EventLoopKt : Java.Lang.Object
	{
		// Token: 0x1700006E RID: 110
		// (get) Token: 0x0600012F RID: 303 RVA: 0x00004E00 File Offset: 0x00003000
		internal static IntPtr class_ref
		{
			get
			{
				return EventLoopKt._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700006F RID: 111
		// (get) Token: 0x06000130 RID: 304 RVA: 0x00004E24 File Offset: 0x00003024
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return EventLoopKt._members;
			}
		}

		// Token: 0x17000070 RID: 112
		// (get) Token: 0x06000131 RID: 305 RVA: 0x00004E2C File Offset: 0x0000302C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return EventLoopKt._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000071 RID: 113
		// (get) Token: 0x06000132 RID: 306 RVA: 0x00004E50 File Offset: 0x00003050
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return EventLoopKt._members.ManagedPeerType;
			}
		}

		// Token: 0x06000133 RID: 307 RVA: 0x00004E5C File Offset: 0x0000305C
		internal EventLoopKt(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06000134 RID: 308 RVA: 0x00004E66 File Offset: 0x00003066
		[Register("processNextEventInCurrentThread", "()J", "")]
		public static long ProcessNextEventInCurrentThread()
		{
			return EventLoopKt._members.StaticMethods.InvokeInt64Method("processNextEventInCurrentThread.()J", null);
		}

		// Token: 0x04000028 RID: 40
		private static readonly JniPeerMembers _members = new XAPeerMembers("kotlinx/coroutines/EventLoopKt", typeof(EventLoopKt));
	}
}
