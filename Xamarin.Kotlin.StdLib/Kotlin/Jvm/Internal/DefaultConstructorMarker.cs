using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Kotlin.Jvm.Internal
{
	// Token: 0x02000198 RID: 408
	[NullableContext(1)]
	[Nullable(0)]
	[Register("kotlin/jvm/internal/DefaultConstructorMarker", DoNotGenerateAcw = true)]
	public sealed class DefaultConstructorMarker : Java.Lang.Object
	{
		// Token: 0x170005AA RID: 1450
		// (get) Token: 0x06001429 RID: 5161 RVA: 0x00041620 File Offset: 0x0003F820
		internal static IntPtr class_ref
		{
			get
			{
				return DefaultConstructorMarker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170005AB RID: 1451
		// (get) Token: 0x0600142A RID: 5162 RVA: 0x00041644 File Offset: 0x0003F844
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return DefaultConstructorMarker._members;
			}
		}

		// Token: 0x170005AC RID: 1452
		// (get) Token: 0x0600142B RID: 5163 RVA: 0x0004164C File Offset: 0x0003F84C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return DefaultConstructorMarker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170005AD RID: 1453
		// (get) Token: 0x0600142C RID: 5164 RVA: 0x00041670 File Offset: 0x0003F870
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return DefaultConstructorMarker._members.ManagedPeerType;
			}
		}

		// Token: 0x0600142D RID: 5165 RVA: 0x0004167C File Offset: 0x0003F87C
		internal DefaultConstructorMarker(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x04000695 RID: 1685
		private static readonly JniPeerMembers _members = new XAPeerMembers("kotlin/jvm/internal/DefaultConstructorMarker", typeof(DefaultConstructorMarker));
	}
}
