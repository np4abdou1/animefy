using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Xamarin.KotlinX.Coroutines.Channels
{
	// Token: 0x020000D1 RID: 209
	[NullableContext(1)]
	[Nullable(0)]
	[Register("kotlinx/coroutines/channels/Channel$Factory", DoNotGenerateAcw = true)]
	public sealed class ChannelFactory : Java.Lang.Object
	{
		// Token: 0x170002DA RID: 730
		// (get) Token: 0x0600098D RID: 2445 RVA: 0x00022FCC File Offset: 0x000211CC
		internal static IntPtr class_ref
		{
			get
			{
				return ChannelFactory._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170002DB RID: 731
		// (get) Token: 0x0600098E RID: 2446 RVA: 0x00022FF0 File Offset: 0x000211F0
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return ChannelFactory._members;
			}
		}

		// Token: 0x170002DC RID: 732
		// (get) Token: 0x0600098F RID: 2447 RVA: 0x00022FF8 File Offset: 0x000211F8
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return ChannelFactory._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170002DD RID: 733
		// (get) Token: 0x06000990 RID: 2448 RVA: 0x0002301C File Offset: 0x0002121C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return ChannelFactory._members.ManagedPeerType;
			}
		}

		// Token: 0x06000991 RID: 2449 RVA: 0x00023028 File Offset: 0x00021228
		internal ChannelFactory(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x040002FE RID: 766
		[Register("BUFFERED")]
		public const int Buffered = -2;

		// Token: 0x040002FF RID: 767
		[Register("CONFLATED")]
		public const int Conflated = -1;

		// Token: 0x04000300 RID: 768
		[Register("DEFAULT_BUFFER_PROPERTY_NAME")]
		public const string DefaultBufferPropertyName = "kotlinx.coroutines.channels.defaultBuffer";

		// Token: 0x04000301 RID: 769
		[Register("RENDEZVOUS")]
		public const int Rendezvous = 0;

		// Token: 0x04000302 RID: 770
		[Register("UNLIMITED")]
		public const int Unlimited = 2147483647;

		// Token: 0x04000303 RID: 771
		private static readonly JniPeerMembers _members = new XAPeerMembers("kotlinx/coroutines/channels/Channel$Factory", typeof(ChannelFactory));
	}
}
