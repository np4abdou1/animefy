using System;
using System.Runtime.CompilerServices;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Xamarin.KotlinX.Coroutines.Channels
{
	// Token: 0x020000D2 RID: 210
	[NullableContext(1)]
	[Nullable(0)]
	[Register("kotlinx/coroutines/channels/Channel", DoNotGenerateAcw = true)]
	public abstract class Channel : Java.Lang.Object
	{
		// Token: 0x06000993 RID: 2451 RVA: 0x0002304D File Offset: 0x0002124D
		internal Channel()
		{
		}

		// Token: 0x170002DE RID: 734
		// (get) Token: 0x06000994 RID: 2452 RVA: 0x00023058 File Offset: 0x00021258
		[Register("Factory")]
		public static ChannelFactory Factory
		{
			get
			{
				return Java.Lang.Object.GetObject<ChannelFactory>(Channel._members.StaticFields.GetObjectValue("Factory.Lkotlinx/coroutines/channels/Channel$Factory;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x04000304 RID: 772
		[Register("BUFFERED")]
		public const int Buffered = -2;

		// Token: 0x04000305 RID: 773
		[Register("CONFLATED")]
		public const int Conflated = -1;

		// Token: 0x04000306 RID: 774
		[Register("DEFAULT_BUFFER_PROPERTY_NAME")]
		public const string DefaultBufferPropertyName = "kotlinx.coroutines.channels.defaultBuffer";

		// Token: 0x04000307 RID: 775
		[Register("OPTIONAL_CHANNEL")]
		public const int OptionalChannel = -3;

		// Token: 0x04000308 RID: 776
		[Register("RENDEZVOUS")]
		public const int Rendezvous = 0;

		// Token: 0x04000309 RID: 777
		[Register("UNLIMITED")]
		public const int Unlimited = 2147483647;

		// Token: 0x0400030A RID: 778
		private static readonly JniPeerMembers _members = new XAPeerMembers("kotlinx/coroutines/channels/Channel", typeof(Channel));
	}
}
