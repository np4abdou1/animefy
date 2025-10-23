using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Kotlin.Math
{
	// Token: 0x0200014D RID: 333
	[NullableContext(1)]
	[Nullable(0)]
	[Register("kotlin/math/UMathKt", DoNotGenerateAcw = true)]
	public sealed class UMathKt : Java.Lang.Object
	{
		// Token: 0x170004F3 RID: 1267
		// (get) Token: 0x06001179 RID: 4473 RVA: 0x0003A4AC File Offset: 0x000386AC
		internal static IntPtr class_ref
		{
			get
			{
				return UMathKt._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170004F4 RID: 1268
		// (get) Token: 0x0600117A RID: 4474 RVA: 0x0003A4D0 File Offset: 0x000386D0
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return UMathKt._members;
			}
		}

		// Token: 0x170004F5 RID: 1269
		// (get) Token: 0x0600117B RID: 4475 RVA: 0x0003A4D8 File Offset: 0x000386D8
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return UMathKt._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170004F6 RID: 1270
		// (get) Token: 0x0600117C RID: 4476 RVA: 0x0003A4FC File Offset: 0x000386FC
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return UMathKt._members.ManagedPeerType;
			}
		}

		// Token: 0x0600117D RID: 4477 RVA: 0x0003A508 File Offset: 0x00038708
		internal UMathKt(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x0400059E RID: 1438
		private static readonly JniPeerMembers _members = new XAPeerMembers("kotlin/math/UMathKt", typeof(UMathKt));
	}
}
