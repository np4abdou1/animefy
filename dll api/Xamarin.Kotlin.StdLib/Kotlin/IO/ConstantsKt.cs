using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Kotlin.IO
{
	// Token: 0x0200021E RID: 542
	[NullableContext(1)]
	[Nullable(0)]
	[Register("kotlin/io/ConstantsKt", DoNotGenerateAcw = true)]
	public sealed class ConstantsKt : Java.Lang.Object
	{
		// Token: 0x1700072F RID: 1839
		// (get) Token: 0x06001928 RID: 6440 RVA: 0x00053AD0 File Offset: 0x00051CD0
		internal static IntPtr class_ref
		{
			get
			{
				return ConstantsKt._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000730 RID: 1840
		// (get) Token: 0x06001929 RID: 6441 RVA: 0x00053AF4 File Offset: 0x00051CF4
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return ConstantsKt._members;
			}
		}

		// Token: 0x17000731 RID: 1841
		// (get) Token: 0x0600192A RID: 6442 RVA: 0x00053AFC File Offset: 0x00051CFC
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return ConstantsKt._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000732 RID: 1842
		// (get) Token: 0x0600192B RID: 6443 RVA: 0x00053B20 File Offset: 0x00051D20
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return ConstantsKt._members.ManagedPeerType;
			}
		}

		// Token: 0x0600192C RID: 6444 RVA: 0x00053B2C File Offset: 0x00051D2C
		internal ConstantsKt(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x040007CE RID: 1998
		[Register("DEFAULT_BUFFER_SIZE")]
		public const int DefaultBufferSize = 8192;

		// Token: 0x040007CF RID: 1999
		private static readonly JniPeerMembers _members = new XAPeerMembers("kotlin/io/ConstantsKt", typeof(ConstantsKt));
	}
}
