using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Kotlin
{
	// Token: 0x020000B9 RID: 185
	[NullableContext(1)]
	[Nullable(0)]
	[Register("kotlin/UShortArrayKt", DoNotGenerateAcw = true)]
	public sealed class UShortArrayKt : Java.Lang.Object
	{
		// Token: 0x17000161 RID: 353
		// (get) Token: 0x0600054A RID: 1354 RVA: 0x0000D240 File Offset: 0x0000B440
		internal static IntPtr class_ref
		{
			get
			{
				return UShortArrayKt._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000162 RID: 354
		// (get) Token: 0x0600054B RID: 1355 RVA: 0x0000D264 File Offset: 0x0000B464
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return UShortArrayKt._members;
			}
		}

		// Token: 0x17000163 RID: 355
		// (get) Token: 0x0600054C RID: 1356 RVA: 0x0000D26C File Offset: 0x0000B46C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return UShortArrayKt._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000164 RID: 356
		// (get) Token: 0x0600054D RID: 1357 RVA: 0x0000D290 File Offset: 0x0000B490
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return UShortArrayKt._members.ManagedPeerType;
			}
		}

		// Token: 0x0600054E RID: 1358 RVA: 0x0000D29C File Offset: 0x0000B49C
		internal UShortArrayKt(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x0400017D RID: 381
		private static readonly JniPeerMembers _members = new XAPeerMembers("kotlin/UShortArrayKt", typeof(UShortArrayKt));
	}
}
