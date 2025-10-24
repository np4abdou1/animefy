using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Kotlin
{
	// Token: 0x020000B0 RID: 176
	[NullableContext(1)]
	[Nullable(0)]
	[Register("kotlin/ULongArrayKt", DoNotGenerateAcw = true)]
	public sealed class ULongArrayKt : Java.Lang.Object
	{
		// Token: 0x1700013E RID: 318
		// (get) Token: 0x06000501 RID: 1281 RVA: 0x0000C500 File Offset: 0x0000A700
		internal static IntPtr class_ref
		{
			get
			{
				return ULongArrayKt._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700013F RID: 319
		// (get) Token: 0x06000502 RID: 1282 RVA: 0x0000C524 File Offset: 0x0000A724
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return ULongArrayKt._members;
			}
		}

		// Token: 0x17000140 RID: 320
		// (get) Token: 0x06000503 RID: 1283 RVA: 0x0000C52C File Offset: 0x0000A72C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return ULongArrayKt._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000141 RID: 321
		// (get) Token: 0x06000504 RID: 1284 RVA: 0x0000C550 File Offset: 0x0000A750
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return ULongArrayKt._members.ManagedPeerType;
			}
		}

		// Token: 0x06000505 RID: 1285 RVA: 0x0000C55C File Offset: 0x0000A75C
		internal ULongArrayKt(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x04000171 RID: 369
		private static readonly JniPeerMembers _members = new XAPeerMembers("kotlin/ULongArrayKt", typeof(ULongArrayKt));
	}
}
