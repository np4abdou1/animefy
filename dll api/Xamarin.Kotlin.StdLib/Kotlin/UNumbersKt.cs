using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Kotlin
{
	// Token: 0x020000B6 RID: 182
	[NullableContext(1)]
	[Nullable(0)]
	[Register("kotlin/UNumbersKt", DoNotGenerateAcw = true)]
	public sealed class UNumbersKt : Java.Lang.Object
	{
		// Token: 0x17000153 RID: 339
		// (get) Token: 0x06000525 RID: 1317 RVA: 0x0000CA5C File Offset: 0x0000AC5C
		internal static IntPtr class_ref
		{
			get
			{
				return UNumbersKt._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000154 RID: 340
		// (get) Token: 0x06000526 RID: 1318 RVA: 0x0000CA80 File Offset: 0x0000AC80
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return UNumbersKt._members;
			}
		}

		// Token: 0x17000155 RID: 341
		// (get) Token: 0x06000527 RID: 1319 RVA: 0x0000CA88 File Offset: 0x0000AC88
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return UNumbersKt._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000156 RID: 342
		// (get) Token: 0x06000528 RID: 1320 RVA: 0x0000CAAC File Offset: 0x0000ACAC
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return UNumbersKt._members.ManagedPeerType;
			}
		}

		// Token: 0x06000529 RID: 1321 RVA: 0x0000CAB8 File Offset: 0x0000ACB8
		internal UNumbersKt(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x04000176 RID: 374
		private static readonly JniPeerMembers _members = new XAPeerMembers("kotlin/UNumbersKt", typeof(UNumbersKt));
	}
}
