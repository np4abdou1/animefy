using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Kotlin
{
	// Token: 0x02000095 RID: 149
	[NullableContext(1)]
	[Nullable(0)]
	[Register("kotlin/PreconditionsKt", DoNotGenerateAcw = true)]
	public sealed class PreconditionsKt : Java.Lang.Object
	{
		// Token: 0x170000DB RID: 219
		// (get) Token: 0x0600042B RID: 1067 RVA: 0x0000A108 File Offset: 0x00008308
		internal static IntPtr class_ref
		{
			get
			{
				return PreconditionsKt._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170000DC RID: 220
		// (get) Token: 0x0600042C RID: 1068 RVA: 0x0000A12C File Offset: 0x0000832C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return PreconditionsKt._members;
			}
		}

		// Token: 0x170000DD RID: 221
		// (get) Token: 0x0600042D RID: 1069 RVA: 0x0000A134 File Offset: 0x00008334
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return PreconditionsKt._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170000DE RID: 222
		// (get) Token: 0x0600042E RID: 1070 RVA: 0x0000A158 File Offset: 0x00008358
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return PreconditionsKt._members.ManagedPeerType;
			}
		}

		// Token: 0x0600042F RID: 1071 RVA: 0x0000A164 File Offset: 0x00008364
		internal PreconditionsKt(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x0400014A RID: 330
		private static readonly JniPeerMembers _members = new XAPeerMembers("kotlin/PreconditionsKt", typeof(PreconditionsKt));
	}
}
