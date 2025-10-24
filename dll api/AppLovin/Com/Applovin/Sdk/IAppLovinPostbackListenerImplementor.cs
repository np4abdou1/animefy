using System;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Com.Applovin.Sdk
{
	// Token: 0x0200008B RID: 139
	[Register("mono/com/applovin/sdk/AppLovinPostbackListenerImplementor")]
	internal sealed class IAppLovinPostbackListenerImplementor : Java.Lang.Object, IAppLovinPostbackListener, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x06000488 RID: 1160 RVA: 0x0000C249 File Offset: 0x0000A449
		public IAppLovinPostbackListenerImplementor(object sender) : base(JNIEnv.StartCreateInstance("mono/com/applovin/sdk/AppLovinPostbackListenerImplementor", "()V", Array.Empty<JValue>()), JniHandleOwnership.TransferLocalRef)
		{
			JNIEnv.FinishCreateInstance(base.Handle, "()V", Array.Empty<JValue>());
			this.sender = sender;
		}

		// Token: 0x06000489 RID: 1161 RVA: 0x0000C284 File Offset: 0x0000A484
		public void OnPostbackFailure(string p0, int p1)
		{
			EventHandler<PostbackFailureEventArgs> onPostbackFailureHandler = this.OnPostbackFailureHandler;
			if (onPostbackFailureHandler != null)
			{
				onPostbackFailureHandler(this.sender, new PostbackFailureEventArgs(p0, p1));
			}
		}

		// Token: 0x0600048A RID: 1162 RVA: 0x0000C2B0 File Offset: 0x0000A4B0
		public void OnPostbackSuccess(string p0)
		{
			EventHandler<PostbackSuccessEventArgs> onPostbackSuccessHandler = this.OnPostbackSuccessHandler;
			if (onPostbackSuccessHandler != null)
			{
				onPostbackSuccessHandler(this.sender, new PostbackSuccessEventArgs(p0));
			}
		}

		// Token: 0x0600048B RID: 1163 RVA: 0x0000C2D9 File Offset: 0x0000A4D9
		internal static bool __IsEmpty(IAppLovinPostbackListenerImplementor value)
		{
			return value.OnPostbackFailureHandler == null && value.OnPostbackSuccessHandler == null;
		}

		// Token: 0x0400014D RID: 333
		private object sender;

		// Token: 0x0400014E RID: 334
		public EventHandler<PostbackFailureEventArgs> OnPostbackFailureHandler;

		// Token: 0x0400014F RID: 335
		public EventHandler<PostbackSuccessEventArgs> OnPostbackSuccessHandler;
	}
}
