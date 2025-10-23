using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Kotlin.Coroutines.Jvm.Internal
{
	// Token: 0x02000265 RID: 613
	[NullableContext(1)]
	[Nullable(0)]
	[Register("kotlin/coroutines/jvm/internal/DebugMetadataKt", DoNotGenerateAcw = true)]
	public sealed class DebugMetadataKt : Java.Lang.Object
	{
		// Token: 0x1700080E RID: 2062
		// (get) Token: 0x06001C0A RID: 7178 RVA: 0x0005DB30 File Offset: 0x0005BD30
		internal static IntPtr class_ref
		{
			get
			{
				return DebugMetadataKt._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700080F RID: 2063
		// (get) Token: 0x06001C0B RID: 7179 RVA: 0x0005DB54 File Offset: 0x0005BD54
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return DebugMetadataKt._members;
			}
		}

		// Token: 0x17000810 RID: 2064
		// (get) Token: 0x06001C0C RID: 7180 RVA: 0x0005DB5C File Offset: 0x0005BD5C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return DebugMetadataKt._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000811 RID: 2065
		// (get) Token: 0x06001C0D RID: 7181 RVA: 0x0005DB80 File Offset: 0x0005BD80
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return DebugMetadataKt._members.ManagedPeerType;
			}
		}

		// Token: 0x06001C0E RID: 7182 RVA: 0x0005DB8C File Offset: 0x0005BD8C
		internal DebugMetadataKt(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x040008A8 RID: 2216
		private static readonly JniPeerMembers _members = new XAPeerMembers("kotlin/coroutines/jvm/internal/DebugMetadataKt", typeof(DebugMetadataKt));
	}
}
