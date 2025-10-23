using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Kotlin
{
	// Token: 0x020000AC RID: 172
	[NullableContext(1)]
	[Nullable(0)]
	[Register("kotlin/UIntArrayKt", DoNotGenerateAcw = true)]
	public sealed class UIntArrayKt : Java.Lang.Object
	{
		// Token: 0x1700012C RID: 300
		// (get) Token: 0x060004D6 RID: 1238 RVA: 0x0000BC98 File Offset: 0x00009E98
		internal static IntPtr class_ref
		{
			get
			{
				return UIntArrayKt._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700012D RID: 301
		// (get) Token: 0x060004D7 RID: 1239 RVA: 0x0000BCBC File Offset: 0x00009EBC
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return UIntArrayKt._members;
			}
		}

		// Token: 0x1700012E RID: 302
		// (get) Token: 0x060004D8 RID: 1240 RVA: 0x0000BCC4 File Offset: 0x00009EC4
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return UIntArrayKt._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700012F RID: 303
		// (get) Token: 0x060004D9 RID: 1241 RVA: 0x0000BCE8 File Offset: 0x00009EE8
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return UIntArrayKt._members.ManagedPeerType;
			}
		}

		// Token: 0x060004DA RID: 1242 RVA: 0x0000BCF4 File Offset: 0x00009EF4
		internal UIntArrayKt(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x04000169 RID: 361
		private static readonly JniPeerMembers _members = new XAPeerMembers("kotlin/UIntArrayKt", typeof(UIntArrayKt));
	}
}
