using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Kotlin
{
	// Token: 0x02000042 RID: 66
	[NullableContext(1)]
	[Nullable(0)]
	[Register("kotlin/CharCodeJVMKt", DoNotGenerateAcw = true)]
	public sealed class CharCodeJVMKt : Java.Lang.Object
	{
		// Token: 0x17000005 RID: 5
		// (get) Token: 0x060000FB RID: 251 RVA: 0x000025CC File Offset: 0x000007CC
		internal static IntPtr class_ref
		{
			get
			{
				return CharCodeJVMKt._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000006 RID: 6
		// (get) Token: 0x060000FC RID: 252 RVA: 0x000025F0 File Offset: 0x000007F0
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return CharCodeJVMKt._members;
			}
		}

		// Token: 0x17000007 RID: 7
		// (get) Token: 0x060000FD RID: 253 RVA: 0x000025F8 File Offset: 0x000007F8
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return CharCodeJVMKt._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000008 RID: 8
		// (get) Token: 0x060000FE RID: 254 RVA: 0x0000261C File Offset: 0x0000081C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return CharCodeJVMKt._members.ManagedPeerType;
			}
		}

		// Token: 0x060000FF RID: 255 RVA: 0x00002628 File Offset: 0x00000828
		internal CharCodeJVMKt(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x0400000F RID: 15
		private static readonly JniPeerMembers _members = new XAPeerMembers("kotlin/CharCodeJVMKt", typeof(CharCodeJVMKt));
	}
}
