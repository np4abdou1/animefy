using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Kotlin.Enums
{
	// Token: 0x02000249 RID: 585
	[NullableContext(1)]
	[Nullable(0)]
	[Register("kotlin/enums/EnumEntriesKt", DoNotGenerateAcw = true)]
	public sealed class EnumEntriesKt : Java.Lang.Object
	{
		// Token: 0x170007C0 RID: 1984
		// (get) Token: 0x06001AC7 RID: 6855 RVA: 0x00059C48 File Offset: 0x00057E48
		internal static IntPtr class_ref
		{
			get
			{
				return EnumEntriesKt._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170007C1 RID: 1985
		// (get) Token: 0x06001AC8 RID: 6856 RVA: 0x00059C6C File Offset: 0x00057E6C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return EnumEntriesKt._members;
			}
		}

		// Token: 0x170007C2 RID: 1986
		// (get) Token: 0x06001AC9 RID: 6857 RVA: 0x00059C74 File Offset: 0x00057E74
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return EnumEntriesKt._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170007C3 RID: 1987
		// (get) Token: 0x06001ACA RID: 6858 RVA: 0x00059C98 File Offset: 0x00057E98
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return EnumEntriesKt._members.ManagedPeerType;
			}
		}

		// Token: 0x06001ACB RID: 6859 RVA: 0x00059CA4 File Offset: 0x00057EA4
		internal EnumEntriesKt(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x0400082B RID: 2091
		private static readonly JniPeerMembers _members = new XAPeerMembers("kotlin/enums/EnumEntriesKt", typeof(EnumEntriesKt));
	}
}
