using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Kotlin
{
	// Token: 0x020000BA RID: 186
	[NullableContext(1)]
	[Nullable(0)]
	[Register("kotlin/UShortKt", DoNotGenerateAcw = true)]
	public sealed class UShortKt : Java.Lang.Object
	{
		// Token: 0x17000165 RID: 357
		// (get) Token: 0x06000550 RID: 1360 RVA: 0x0000D2C4 File Offset: 0x0000B4C4
		internal static IntPtr class_ref
		{
			get
			{
				return UShortKt._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000166 RID: 358
		// (get) Token: 0x06000551 RID: 1361 RVA: 0x0000D2E8 File Offset: 0x0000B4E8
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return UShortKt._members;
			}
		}

		// Token: 0x17000167 RID: 359
		// (get) Token: 0x06000552 RID: 1362 RVA: 0x0000D2F0 File Offset: 0x0000B4F0
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return UShortKt._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000168 RID: 360
		// (get) Token: 0x06000553 RID: 1363 RVA: 0x0000D314 File Offset: 0x0000B514
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return UShortKt._members.ManagedPeerType;
			}
		}

		// Token: 0x06000554 RID: 1364 RVA: 0x0000D320 File Offset: 0x0000B520
		internal UShortKt(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x0400017E RID: 382
		private static readonly JniPeerMembers _members = new XAPeerMembers("kotlin/UShortKt", typeof(UShortKt));
	}
}
