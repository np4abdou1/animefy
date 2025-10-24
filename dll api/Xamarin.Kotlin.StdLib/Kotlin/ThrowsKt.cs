using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Kotlin
{
	// Token: 0x020000A1 RID: 161
	[NullableContext(1)]
	[Nullable(0)]
	[Register("kotlin/ThrowsKt", DoNotGenerateAcw = true)]
	public sealed class ThrowsKt : Java.Lang.Object
	{
		// Token: 0x170000F9 RID: 249
		// (get) Token: 0x06000461 RID: 1121 RVA: 0x0000A4B0 File Offset: 0x000086B0
		internal static IntPtr class_ref
		{
			get
			{
				return ThrowsKt._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170000FA RID: 250
		// (get) Token: 0x06000462 RID: 1122 RVA: 0x0000A4D4 File Offset: 0x000086D4
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return ThrowsKt._members;
			}
		}

		// Token: 0x170000FB RID: 251
		// (get) Token: 0x06000463 RID: 1123 RVA: 0x0000A4DC File Offset: 0x000086DC
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return ThrowsKt._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170000FC RID: 252
		// (get) Token: 0x06000464 RID: 1124 RVA: 0x0000A500 File Offset: 0x00008700
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return ThrowsKt._members.ManagedPeerType;
			}
		}

		// Token: 0x06000465 RID: 1125 RVA: 0x0000A50C File Offset: 0x0000870C
		internal ThrowsKt(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x04000156 RID: 342
		private static readonly JniPeerMembers _members = new XAPeerMembers("kotlin/ThrowsKt", typeof(ThrowsKt));
	}
}
