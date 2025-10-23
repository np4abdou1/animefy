using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Kotlin
{
	// Token: 0x020000A9 RID: 169
	[NullableContext(1)]
	[Nullable(0)]
	[Register("kotlin/UByteKt", DoNotGenerateAcw = true)]
	public sealed class UByteKt : Java.Lang.Object
	{
		// Token: 0x1700011E RID: 286
		// (get) Token: 0x060004B1 RID: 1201 RVA: 0x0000B4B4 File Offset: 0x000096B4
		internal static IntPtr class_ref
		{
			get
			{
				return UByteKt._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700011F RID: 287
		// (get) Token: 0x060004B2 RID: 1202 RVA: 0x0000B4D8 File Offset: 0x000096D8
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return UByteKt._members;
			}
		}

		// Token: 0x17000120 RID: 288
		// (get) Token: 0x060004B3 RID: 1203 RVA: 0x0000B4E0 File Offset: 0x000096E0
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return UByteKt._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000121 RID: 289
		// (get) Token: 0x060004B4 RID: 1204 RVA: 0x0000B504 File Offset: 0x00009704
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return UByteKt._members.ManagedPeerType;
			}
		}

		// Token: 0x060004B5 RID: 1205 RVA: 0x0000B510 File Offset: 0x00009710
		internal UByteKt(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x04000162 RID: 354
		private static readonly JniPeerMembers _members = new XAPeerMembers("kotlin/UByteKt", typeof(UByteKt));
	}
}
