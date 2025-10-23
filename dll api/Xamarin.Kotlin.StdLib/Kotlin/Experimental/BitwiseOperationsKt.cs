using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Kotlin.Experimental
{
	// Token: 0x0200023F RID: 575
	[NullableContext(1)]
	[Nullable(0)]
	[Register("kotlin/experimental/BitwiseOperationsKt", DoNotGenerateAcw = true)]
	public sealed class BitwiseOperationsKt : Java.Lang.Object
	{
		// Token: 0x170007B0 RID: 1968
		// (get) Token: 0x06001A7F RID: 6783 RVA: 0x000591F8 File Offset: 0x000573F8
		internal static IntPtr class_ref
		{
			get
			{
				return BitwiseOperationsKt._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170007B1 RID: 1969
		// (get) Token: 0x06001A80 RID: 6784 RVA: 0x0005921C File Offset: 0x0005741C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return BitwiseOperationsKt._members;
			}
		}

		// Token: 0x170007B2 RID: 1970
		// (get) Token: 0x06001A81 RID: 6785 RVA: 0x00059224 File Offset: 0x00057424
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return BitwiseOperationsKt._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170007B3 RID: 1971
		// (get) Token: 0x06001A82 RID: 6786 RVA: 0x00059248 File Offset: 0x00057448
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return BitwiseOperationsKt._members.ManagedPeerType;
			}
		}

		// Token: 0x06001A83 RID: 6787 RVA: 0x00059254 File Offset: 0x00057454
		internal BitwiseOperationsKt(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x0400080C RID: 2060
		private static readonly JniPeerMembers _members = new XAPeerMembers("kotlin/experimental/BitwiseOperationsKt", typeof(BitwiseOperationsKt));
	}
}
