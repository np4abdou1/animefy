using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Kotlin
{
	// Token: 0x020000A8 RID: 168
	[NullableContext(1)]
	[Nullable(0)]
	[Register("kotlin/UByteArrayKt", DoNotGenerateAcw = true)]
	public sealed class UByteArrayKt : Java.Lang.Object
	{
		// Token: 0x1700011A RID: 282
		// (get) Token: 0x060004AB RID: 1195 RVA: 0x0000B430 File Offset: 0x00009630
		internal static IntPtr class_ref
		{
			get
			{
				return UByteArrayKt._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700011B RID: 283
		// (get) Token: 0x060004AC RID: 1196 RVA: 0x0000B454 File Offset: 0x00009654
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return UByteArrayKt._members;
			}
		}

		// Token: 0x1700011C RID: 284
		// (get) Token: 0x060004AD RID: 1197 RVA: 0x0000B45C File Offset: 0x0000965C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return UByteArrayKt._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700011D RID: 285
		// (get) Token: 0x060004AE RID: 1198 RVA: 0x0000B480 File Offset: 0x00009680
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return UByteArrayKt._members.ManagedPeerType;
			}
		}

		// Token: 0x060004AF RID: 1199 RVA: 0x0000B48C File Offset: 0x0000968C
		internal UByteArrayKt(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x04000161 RID: 353
		private static readonly JniPeerMembers _members = new XAPeerMembers("kotlin/UByteArrayKt", typeof(UByteArrayKt));
	}
}
