using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Kotlin.Collections
{
	// Token: 0x020002D7 RID: 727
	[NullableContext(1)]
	[Nullable(0)]
	[Register("kotlin/collections/UArraySortingKt", DoNotGenerateAcw = true)]
	public sealed class UArraySortingKt : Java.Lang.Object
	{
		// Token: 0x170009E6 RID: 2534
		// (get) Token: 0x06002855 RID: 10325 RVA: 0x000B04C0 File Offset: 0x000AE6C0
		internal static IntPtr class_ref
		{
			get
			{
				return UArraySortingKt._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170009E7 RID: 2535
		// (get) Token: 0x06002856 RID: 10326 RVA: 0x000B04E4 File Offset: 0x000AE6E4
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return UArraySortingKt._members;
			}
		}

		// Token: 0x170009E8 RID: 2536
		// (get) Token: 0x06002857 RID: 10327 RVA: 0x000B04EC File Offset: 0x000AE6EC
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return UArraySortingKt._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170009E9 RID: 2537
		// (get) Token: 0x06002858 RID: 10328 RVA: 0x000B0510 File Offset: 0x000AE710
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return UArraySortingKt._members.ManagedPeerType;
			}
		}

		// Token: 0x06002859 RID: 10329 RVA: 0x000B051C File Offset: 0x000AE71C
		internal UArraySortingKt(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x040009C5 RID: 2501
		private static readonly JniPeerMembers _members = new XAPeerMembers("kotlin/collections/UArraySortingKt", typeof(UArraySortingKt));
	}
}
