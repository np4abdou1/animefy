using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Kotlin
{
	// Token: 0x020000B5 RID: 181
	[NullableContext(1)]
	[Nullable(0)]
	[Register("kotlin/UnsignedKt", DoNotGenerateAcw = true)]
	public sealed class UnsignedKt : Java.Lang.Object
	{
		// Token: 0x1700014F RID: 335
		// (get) Token: 0x0600051F RID: 1311 RVA: 0x0000C9D8 File Offset: 0x0000ABD8
		internal static IntPtr class_ref
		{
			get
			{
				return UnsignedKt._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000150 RID: 336
		// (get) Token: 0x06000520 RID: 1312 RVA: 0x0000C9FC File Offset: 0x0000ABFC
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return UnsignedKt._members;
			}
		}

		// Token: 0x17000151 RID: 337
		// (get) Token: 0x06000521 RID: 1313 RVA: 0x0000CA04 File Offset: 0x0000AC04
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return UnsignedKt._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000152 RID: 338
		// (get) Token: 0x06000522 RID: 1314 RVA: 0x0000CA28 File Offset: 0x0000AC28
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return UnsignedKt._members.ManagedPeerType;
			}
		}

		// Token: 0x06000523 RID: 1315 RVA: 0x0000CA34 File Offset: 0x0000AC34
		internal UnsignedKt(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x04000175 RID: 373
		private static readonly JniPeerMembers _members = new XAPeerMembers("kotlin/UnsignedKt", typeof(UnsignedKt));
	}
}
