using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Xamarin.KotlinX.Coroutines.Channels
{
	// Token: 0x020000C0 RID: 192
	[NullableContext(1)]
	[Nullable(0)]
	[Register("kotlinx/coroutines/channels/BroadcastChannelKt", DoNotGenerateAcw = true)]
	public sealed class BroadcastChannelKt : Java.Lang.Object
	{
		// Token: 0x1700028D RID: 653
		// (get) Token: 0x060008AD RID: 2221 RVA: 0x0001F9B8 File Offset: 0x0001DBB8
		internal static IntPtr class_ref
		{
			get
			{
				return BroadcastChannelKt._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700028E RID: 654
		// (get) Token: 0x060008AE RID: 2222 RVA: 0x0001F9DC File Offset: 0x0001DBDC
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return BroadcastChannelKt._members;
			}
		}

		// Token: 0x1700028F RID: 655
		// (get) Token: 0x060008AF RID: 2223 RVA: 0x0001F9E4 File Offset: 0x0001DBE4
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return BroadcastChannelKt._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000290 RID: 656
		// (get) Token: 0x060008B0 RID: 2224 RVA: 0x0001FA08 File Offset: 0x0001DC08
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return BroadcastChannelKt._members.ManagedPeerType;
			}
		}

		// Token: 0x060008B1 RID: 2225 RVA: 0x0001FA14 File Offset: 0x0001DC14
		internal BroadcastChannelKt(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x060008B2 RID: 2226 RVA: 0x0001FA20 File Offset: 0x0001DC20
		[Obsolete("deprecated")]
		[Register("BroadcastChannel", "(I)Lkotlinx/coroutines/channels/BroadcastChannel;", "")]
		[JavaTypeParameters(new string[]
		{
			"E"
		})]
		public unsafe static IBroadcastChannel BroadcastChannel(int capacity)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(capacity);
			return Java.Lang.Object.GetObject<IBroadcastChannel>(BroadcastChannelKt._members.StaticMethods.InvokeObjectMethod("BroadcastChannel.(I)Lkotlinx/coroutines/channels/BroadcastChannel;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x040002BE RID: 702
		private static readonly JniPeerMembers _members = new XAPeerMembers("kotlinx/coroutines/channels/BroadcastChannelKt", typeof(BroadcastChannelKt));
	}
}
