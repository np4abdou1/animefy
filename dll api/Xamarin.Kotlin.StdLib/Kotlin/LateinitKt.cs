using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Kotlin
{
	// Token: 0x02000089 RID: 137
	[NullableContext(1)]
	[Nullable(0)]
	[Register("kotlin/LateinitKt", DoNotGenerateAcw = true)]
	public sealed class LateinitKt : Java.Lang.Object
	{
		// Token: 0x170000AF RID: 175
		// (get) Token: 0x060003CE RID: 974 RVA: 0x000091E4 File Offset: 0x000073E4
		internal static IntPtr class_ref
		{
			get
			{
				return LateinitKt._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170000B0 RID: 176
		// (get) Token: 0x060003CF RID: 975 RVA: 0x00009208 File Offset: 0x00007408
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return LateinitKt._members;
			}
		}

		// Token: 0x170000B1 RID: 177
		// (get) Token: 0x060003D0 RID: 976 RVA: 0x00009210 File Offset: 0x00007410
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return LateinitKt._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170000B2 RID: 178
		// (get) Token: 0x060003D1 RID: 977 RVA: 0x00009234 File Offset: 0x00007434
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return LateinitKt._members.ManagedPeerType;
			}
		}

		// Token: 0x060003D2 RID: 978 RVA: 0x00009240 File Offset: 0x00007440
		internal LateinitKt(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x04000139 RID: 313
		private static readonly JniPeerMembers _members = new XAPeerMembers("kotlin/LateinitKt", typeof(LateinitKt));
	}
}
