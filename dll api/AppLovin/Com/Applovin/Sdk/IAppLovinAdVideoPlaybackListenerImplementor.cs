using System;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Com.Applovin.Sdk
{
	// Token: 0x02000084 RID: 132
	[Register("mono/com/applovin/sdk/AppLovinAdVideoPlaybackListenerImplementor")]
	internal sealed class IAppLovinAdVideoPlaybackListenerImplementor : Java.Lang.Object, IAppLovinAdVideoPlaybackListener, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x0600044D RID: 1101 RVA: 0x0000B918 File Offset: 0x00009B18
		public IAppLovinAdVideoPlaybackListenerImplementor(object sender) : base(JNIEnv.StartCreateInstance("mono/com/applovin/sdk/AppLovinAdVideoPlaybackListenerImplementor", "()V", Array.Empty<JValue>()), JniHandleOwnership.TransferLocalRef)
		{
			JNIEnv.FinishCreateInstance(base.Handle, "()V", Array.Empty<JValue>());
			this.sender = sender;
		}

		// Token: 0x0600044E RID: 1102 RVA: 0x0000B954 File Offset: 0x00009B54
		public void VideoPlaybackBegan(IAppLovinAd p0)
		{
			EventHandler<VideoPlaybackBeganEventArgs> videoPlaybackBeganHandler = this.VideoPlaybackBeganHandler;
			if (videoPlaybackBeganHandler != null)
			{
				videoPlaybackBeganHandler(this.sender, new VideoPlaybackBeganEventArgs(p0));
			}
		}

		// Token: 0x0600044F RID: 1103 RVA: 0x0000B980 File Offset: 0x00009B80
		public void VideoPlaybackEnded(IAppLovinAd p0, double p1, bool p2)
		{
			EventHandler<VideoPlaybackEndedEventArgs> videoPlaybackEndedHandler = this.VideoPlaybackEndedHandler;
			if (videoPlaybackEndedHandler != null)
			{
				videoPlaybackEndedHandler(this.sender, new VideoPlaybackEndedEventArgs(p0, p1, p2));
			}
		}

		// Token: 0x06000450 RID: 1104 RVA: 0x0000B9AB File Offset: 0x00009BAB
		internal static bool __IsEmpty(IAppLovinAdVideoPlaybackListenerImplementor value)
		{
			return value.VideoPlaybackBeganHandler == null && value.VideoPlaybackEndedHandler == null;
		}

		// Token: 0x04000133 RID: 307
		private object sender;

		// Token: 0x04000134 RID: 308
		public EventHandler<VideoPlaybackBeganEventArgs> VideoPlaybackBeganHandler;

		// Token: 0x04000135 RID: 309
		public EventHandler<VideoPlaybackEndedEventArgs> VideoPlaybackEndedHandler;
	}
}
