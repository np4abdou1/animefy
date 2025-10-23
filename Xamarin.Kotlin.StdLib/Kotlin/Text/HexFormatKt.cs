using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Kotlin.Text
{
	// Token: 0x020000DF RID: 223
	[NullableContext(1)]
	[Nullable(0)]
	[Register("kotlin/text/HexFormatKt", DoNotGenerateAcw = true)]
	public sealed class HexFormatKt : Java.Lang.Object
	{
		// Token: 0x17000235 RID: 565
		// (get) Token: 0x06000717 RID: 1815 RVA: 0x00012418 File Offset: 0x00010618
		internal static IntPtr class_ref
		{
			get
			{
				return HexFormatKt._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000236 RID: 566
		// (get) Token: 0x06000718 RID: 1816 RVA: 0x0001243C File Offset: 0x0001063C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return HexFormatKt._members;
			}
		}

		// Token: 0x17000237 RID: 567
		// (get) Token: 0x06000719 RID: 1817 RVA: 0x00012444 File Offset: 0x00010644
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return HexFormatKt._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000238 RID: 568
		// (get) Token: 0x0600071A RID: 1818 RVA: 0x00012468 File Offset: 0x00010668
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return HexFormatKt._members.ManagedPeerType;
			}
		}

		// Token: 0x0600071B RID: 1819 RVA: 0x00012474 File Offset: 0x00010674
		internal HexFormatKt(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x040001D0 RID: 464
		private static readonly JniPeerMembers _members = new XAPeerMembers("kotlin/text/HexFormatKt", typeof(HexFormatKt));
	}
}
