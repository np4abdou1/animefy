using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Kotlin.Collections
{
	// Token: 0x020002D6 RID: 726
	[NullableContext(1)]
	[Nullable(0)]
	[Register("kotlin/collections/TypeAliasesKt", DoNotGenerateAcw = true)]
	public sealed class TypeAliasesKt : Java.Lang.Object
	{
		// Token: 0x170009E2 RID: 2530
		// (get) Token: 0x0600284F RID: 10319 RVA: 0x000B043C File Offset: 0x000AE63C
		internal static IntPtr class_ref
		{
			get
			{
				return TypeAliasesKt._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170009E3 RID: 2531
		// (get) Token: 0x06002850 RID: 10320 RVA: 0x000B0460 File Offset: 0x000AE660
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return TypeAliasesKt._members;
			}
		}

		// Token: 0x170009E4 RID: 2532
		// (get) Token: 0x06002851 RID: 10321 RVA: 0x000B0468 File Offset: 0x000AE668
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return TypeAliasesKt._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170009E5 RID: 2533
		// (get) Token: 0x06002852 RID: 10322 RVA: 0x000B048C File Offset: 0x000AE68C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return TypeAliasesKt._members.ManagedPeerType;
			}
		}

		// Token: 0x06002853 RID: 10323 RVA: 0x000B0498 File Offset: 0x000AE698
		internal TypeAliasesKt(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x040009C4 RID: 2500
		private static readonly JniPeerMembers _members = new XAPeerMembers("kotlin/collections/TypeAliasesKt", typeof(TypeAliasesKt));
	}
}
