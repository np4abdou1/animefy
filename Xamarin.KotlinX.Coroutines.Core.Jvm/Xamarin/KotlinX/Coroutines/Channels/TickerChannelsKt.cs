using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Android.Runtime;
using Java.Interop;
using Java.Lang;
using Kotlin.Coroutines;

namespace Xamarin.KotlinX.Coroutines.Channels
{
	// Token: 0x020000E3 RID: 227
	[NullableContext(1)]
	[Nullable(0)]
	[Register("kotlinx/coroutines/channels/TickerChannelsKt", DoNotGenerateAcw = true)]
	public sealed class TickerChannelsKt : Java.Lang.Object
	{
		// Token: 0x17000322 RID: 802
		// (get) Token: 0x06000A95 RID: 2709 RVA: 0x00025E0C File Offset: 0x0002400C
		internal static IntPtr class_ref
		{
			get
			{
				return TickerChannelsKt._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000323 RID: 803
		// (get) Token: 0x06000A96 RID: 2710 RVA: 0x00025E30 File Offset: 0x00024030
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return TickerChannelsKt._members;
			}
		}

		// Token: 0x17000324 RID: 804
		// (get) Token: 0x06000A97 RID: 2711 RVA: 0x00025E38 File Offset: 0x00024038
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return TickerChannelsKt._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000325 RID: 805
		// (get) Token: 0x06000A98 RID: 2712 RVA: 0x00025E5C File Offset: 0x0002405C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return TickerChannelsKt._members.ManagedPeerType;
			}
		}

		// Token: 0x06000A99 RID: 2713 RVA: 0x00025E68 File Offset: 0x00024068
		internal TickerChannelsKt(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06000A9A RID: 2714 RVA: 0x00025E74 File Offset: 0x00024074
		[Register("ticker", "(JJLkotlin/coroutines/CoroutineContext;Lkotlinx/coroutines/channels/TickerMode;)Lkotlinx/coroutines/channels/ReceiveChannel;", "")]
		public unsafe static IReceiveChannel Ticker(long delayMillis, long initialDelayMillis, ICoroutineContext context, TickerMode mode)
		{
			IReceiveChannel @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(delayMillis);
				ptr[1] = new JniArgumentValue(initialDelayMillis);
				ptr[2] = new JniArgumentValue((context == null) ? IntPtr.Zero : ((Java.Lang.Object)context).Handle);
				ptr[3] = new JniArgumentValue((mode == null) ? IntPtr.Zero : mode.Handle);
				@object = Java.Lang.Object.GetObject<IReceiveChannel>(TickerChannelsKt._members.StaticMethods.InvokeObjectMethod("ticker.(JJLkotlin/coroutines/CoroutineContext;Lkotlinx/coroutines/channels/TickerMode;)Lkotlinx/coroutines/channels/ReceiveChannel;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(context);
				GC.KeepAlive(mode);
			}
			return @object;
		}

		// Token: 0x0400037D RID: 893
		private static readonly JniPeerMembers _members = new XAPeerMembers("kotlinx/coroutines/channels/TickerChannelsKt", typeof(TickerChannelsKt));
	}
}
