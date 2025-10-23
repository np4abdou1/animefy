using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Kotlin.Collections.Builders
{
	// Token: 0x020002DB RID: 731
	[NullableContext(1)]
	[Nullable(0)]
	[Register("kotlin/collections/builders/ListBuilderKt", DoNotGenerateAcw = true)]
	public sealed class ListBuilderKt : Java.Lang.Object
	{
		// Token: 0x170009F6 RID: 2550
		// (get) Token: 0x06002939 RID: 10553 RVA: 0x000B76A0 File Offset: 0x000B58A0
		internal static IntPtr class_ref
		{
			get
			{
				return ListBuilderKt._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170009F7 RID: 2551
		// (get) Token: 0x0600293A RID: 10554 RVA: 0x000B76C4 File Offset: 0x000B58C4
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return ListBuilderKt._members;
			}
		}

		// Token: 0x170009F8 RID: 2552
		// (get) Token: 0x0600293B RID: 10555 RVA: 0x000B76CC File Offset: 0x000B58CC
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return ListBuilderKt._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170009F9 RID: 2553
		// (get) Token: 0x0600293C RID: 10556 RVA: 0x000B76F0 File Offset: 0x000B58F0
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return ListBuilderKt._members.ManagedPeerType;
			}
		}

		// Token: 0x0600293D RID: 10557 RVA: 0x000B76FC File Offset: 0x000B58FC
		internal ListBuilderKt(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x040009C9 RID: 2505
		private static readonly JniPeerMembers _members = new XAPeerMembers("kotlin/collections/builders/ListBuilderKt", typeof(ListBuilderKt));
	}
}
