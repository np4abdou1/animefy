using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Xamarin.KotlinX.Coroutines.Channels
{
	// Token: 0x020000D6 RID: 214
	[NullableContext(1)]
	[Nullable(0)]
	[Register("kotlinx/coroutines/channels/ChannelIterator$DefaultImpls", DoNotGenerateAcw = true)]
	public sealed class ChannelIteratorDefaultImpls : Java.Lang.Object
	{
		// Token: 0x170002EB RID: 747
		// (get) Token: 0x060009DB RID: 2523 RVA: 0x00023E30 File Offset: 0x00022030
		internal static IntPtr class_ref
		{
			get
			{
				return ChannelIteratorDefaultImpls._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170002EC RID: 748
		// (get) Token: 0x060009DC RID: 2524 RVA: 0x00023E54 File Offset: 0x00022054
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return ChannelIteratorDefaultImpls._members;
			}
		}

		// Token: 0x170002ED RID: 749
		// (get) Token: 0x060009DD RID: 2525 RVA: 0x00023E5C File Offset: 0x0002205C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return ChannelIteratorDefaultImpls._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170002EE RID: 750
		// (get) Token: 0x060009DE RID: 2526 RVA: 0x00023E80 File Offset: 0x00022080
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return ChannelIteratorDefaultImpls._members.ManagedPeerType;
			}
		}

		// Token: 0x060009DF RID: 2527 RVA: 0x00023E8C File Offset: 0x0002208C
		internal ChannelIteratorDefaultImpls(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x04000334 RID: 820
		private static readonly JniPeerMembers _members = new XAPeerMembers("kotlinx/coroutines/channels/ChannelIterator$DefaultImpls", typeof(ChannelIteratorDefaultImpls));
	}
}
