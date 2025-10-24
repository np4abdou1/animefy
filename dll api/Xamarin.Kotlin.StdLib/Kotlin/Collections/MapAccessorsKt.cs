using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Kotlin.Collections
{
	// Token: 0x020002D0 RID: 720
	[NullableContext(1)]
	[Nullable(0)]
	[Register("kotlin/collections/MapAccessorsKt", DoNotGenerateAcw = true)]
	public sealed class MapAccessorsKt : Java.Lang.Object
	{
		// Token: 0x170009CA RID: 2506
		// (get) Token: 0x060027C1 RID: 10177 RVA: 0x000ACB0C File Offset: 0x000AAD0C
		internal static IntPtr class_ref
		{
			get
			{
				return MapAccessorsKt._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170009CB RID: 2507
		// (get) Token: 0x060027C2 RID: 10178 RVA: 0x000ACB30 File Offset: 0x000AAD30
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return MapAccessorsKt._members;
			}
		}

		// Token: 0x170009CC RID: 2508
		// (get) Token: 0x060027C3 RID: 10179 RVA: 0x000ACB38 File Offset: 0x000AAD38
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return MapAccessorsKt._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170009CD RID: 2509
		// (get) Token: 0x060027C4 RID: 10180 RVA: 0x000ACB5C File Offset: 0x000AAD5C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return MapAccessorsKt._members.ManagedPeerType;
			}
		}

		// Token: 0x060027C5 RID: 10181 RVA: 0x000ACB68 File Offset: 0x000AAD68
		internal MapAccessorsKt(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x040009BB RID: 2491
		private static readonly JniPeerMembers _members = new XAPeerMembers("kotlin/collections/MapAccessorsKt", typeof(MapAccessorsKt));
	}
}
