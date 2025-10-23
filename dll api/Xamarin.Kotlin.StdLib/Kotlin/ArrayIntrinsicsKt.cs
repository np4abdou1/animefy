using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Kotlin
{
	// Token: 0x02000040 RID: 64
	[NullableContext(1)]
	[Nullable(0)]
	[Register("kotlin/ArrayIntrinsicsKt", DoNotGenerateAcw = true)]
	public sealed class ArrayIntrinsicsKt : Java.Lang.Object
	{
		// Token: 0x17000001 RID: 1
		// (get) Token: 0x060000F4 RID: 244 RVA: 0x00002540 File Offset: 0x00000740
		internal static IntPtr class_ref
		{
			get
			{
				return ArrayIntrinsicsKt._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000002 RID: 2
		// (get) Token: 0x060000F5 RID: 245 RVA: 0x00002564 File Offset: 0x00000764
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return ArrayIntrinsicsKt._members;
			}
		}

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x060000F6 RID: 246 RVA: 0x0000256C File Offset: 0x0000076C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return ArrayIntrinsicsKt._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x060000F7 RID: 247 RVA: 0x00002590 File Offset: 0x00000790
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return ArrayIntrinsicsKt._members.ManagedPeerType;
			}
		}

		// Token: 0x060000F8 RID: 248 RVA: 0x0000259C File Offset: 0x0000079C
		internal ArrayIntrinsicsKt(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x0400000E RID: 14
		private static readonly JniPeerMembers _members = new XAPeerMembers("kotlin/ArrayIntrinsicsKt", typeof(ArrayIntrinsicsKt));
	}
}
