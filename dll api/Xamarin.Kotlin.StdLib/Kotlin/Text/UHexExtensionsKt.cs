using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Kotlin.Text
{
	// Token: 0x020000EF RID: 239
	[NullableContext(1)]
	[Nullable(0)]
	[Register("kotlin/text/UHexExtensionsKt", DoNotGenerateAcw = true)]
	public sealed class UHexExtensionsKt : Java.Lang.Object
	{
		// Token: 0x17000286 RID: 646
		// (get) Token: 0x060009C7 RID: 2503 RVA: 0x00020E64 File Offset: 0x0001F064
		internal static IntPtr class_ref
		{
			get
			{
				return UHexExtensionsKt._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000287 RID: 647
		// (get) Token: 0x060009C8 RID: 2504 RVA: 0x00020E88 File Offset: 0x0001F088
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return UHexExtensionsKt._members;
			}
		}

		// Token: 0x17000288 RID: 648
		// (get) Token: 0x060009C9 RID: 2505 RVA: 0x00020E90 File Offset: 0x0001F090
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return UHexExtensionsKt._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000289 RID: 649
		// (get) Token: 0x060009CA RID: 2506 RVA: 0x00020EB4 File Offset: 0x0001F0B4
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return UHexExtensionsKt._members.ManagedPeerType;
			}
		}

		// Token: 0x060009CB RID: 2507 RVA: 0x00020EC0 File Offset: 0x0001F0C0
		internal UHexExtensionsKt(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x04000257 RID: 599
		private static readonly JniPeerMembers _members = new XAPeerMembers("kotlin/text/UHexExtensionsKt", typeof(UHexExtensionsKt));
	}
}
