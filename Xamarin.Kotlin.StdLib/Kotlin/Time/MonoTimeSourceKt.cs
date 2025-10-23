using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Kotlin.Time
{
	// Token: 0x020000D4 RID: 212
	[NullableContext(1)]
	[Nullable(0)]
	[Register("kotlin/time/MonoTimeSourceKt", DoNotGenerateAcw = true)]
	public sealed class MonoTimeSourceKt : Java.Lang.Object
	{
		// Token: 0x170001C3 RID: 451
		// (get) Token: 0x06000664 RID: 1636 RVA: 0x00010104 File Offset: 0x0000E304
		internal static IntPtr class_ref
		{
			get
			{
				return MonoTimeSourceKt._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170001C4 RID: 452
		// (get) Token: 0x06000665 RID: 1637 RVA: 0x00010128 File Offset: 0x0000E328
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return MonoTimeSourceKt._members;
			}
		}

		// Token: 0x170001C5 RID: 453
		// (get) Token: 0x06000666 RID: 1638 RVA: 0x00010130 File Offset: 0x0000E330
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return MonoTimeSourceKt._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170001C6 RID: 454
		// (get) Token: 0x06000667 RID: 1639 RVA: 0x00010154 File Offset: 0x0000E354
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return MonoTimeSourceKt._members.ManagedPeerType;
			}
		}

		// Token: 0x06000668 RID: 1640 RVA: 0x00010160 File Offset: 0x0000E360
		internal MonoTimeSourceKt(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x040001C5 RID: 453
		private static readonly JniPeerMembers _members = new XAPeerMembers("kotlin/time/MonoTimeSourceKt", typeof(MonoTimeSourceKt));
	}
}
