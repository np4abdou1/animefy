using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Kotlin.Text
{
	// Token: 0x020000ED RID: 237
	[NullableContext(1)]
	[Nullable(0)]
	[Register("kotlin/text/TypeAliasesKt", DoNotGenerateAcw = true)]
	public sealed class TypeAliasesKt : Java.Lang.Object
	{
		// Token: 0x1700027D RID: 637
		// (get) Token: 0x060009BA RID: 2490 RVA: 0x00020D2C File Offset: 0x0001EF2C
		internal static IntPtr class_ref
		{
			get
			{
				return TypeAliasesKt._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700027E RID: 638
		// (get) Token: 0x060009BB RID: 2491 RVA: 0x00020D50 File Offset: 0x0001EF50
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return TypeAliasesKt._members;
			}
		}

		// Token: 0x1700027F RID: 639
		// (get) Token: 0x060009BC RID: 2492 RVA: 0x00020D58 File Offset: 0x0001EF58
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return TypeAliasesKt._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000280 RID: 640
		// (get) Token: 0x060009BD RID: 2493 RVA: 0x00020D7C File Offset: 0x0001EF7C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return TypeAliasesKt._members.ManagedPeerType;
			}
		}

		// Token: 0x060009BE RID: 2494 RVA: 0x00020D88 File Offset: 0x0001EF88
		internal TypeAliasesKt(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x0400022C RID: 556
		private static readonly JniPeerMembers _members = new XAPeerMembers("kotlin/text/TypeAliasesKt", typeof(TypeAliasesKt));
	}
}
