using System;
using System.Runtime.CompilerServices;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Xamarin.KotlinX.Coroutines.Channels
{
	// Token: 0x020000D4 RID: 212
	[Register("kotlinx/coroutines/channels/Channel", "", "Xamarin.KotlinX.Coroutines.Channels.IChannelInvoker")]
	[JavaTypeParameters(new string[]
	{
		"E"
	})]
	public interface IChannel : IReceiveChannel, IJavaObject, IDisposable, IJavaPeerable, ISendChannel
	{
		// Token: 0x170002DF RID: 735
		// (get) Token: 0x06000997 RID: 2455 RVA: 0x000230AC File Offset: 0x000212AC
		[Nullable(1)]
		[Register("Factory")]
		ChannelFactory Factory
		{
			[NullableContext(1)]
			get
			{
				return Java.Lang.Object.GetObject<ChannelFactory>(IChannel._members.StaticFields.GetObjectValue("Factory.Lkotlinx/coroutines/channels/Channel$Factory;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x0400030B RID: 779
		[Nullable(1)]
		private static readonly JniPeerMembers _members = new XAPeerMembers("kotlinx/coroutines/channels/Channel", typeof(IChannel), true);
	}
}
