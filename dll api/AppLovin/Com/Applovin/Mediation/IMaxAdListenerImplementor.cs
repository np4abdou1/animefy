using System;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Com.Applovin.Mediation
{
	// Token: 0x020000AA RID: 170
	[Register("mono/com/applovin/mediation/MaxAdListenerImplementor")]
	internal sealed class IMaxAdListenerImplementor : Java.Lang.Object, IMaxAdListener, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x060005D7 RID: 1495 RVA: 0x0000F1AF File Offset: 0x0000D3AF
		public IMaxAdListenerImplementor(object sender) : base(JNIEnv.StartCreateInstance("mono/com/applovin/mediation/MaxAdListenerImplementor", "()V", Array.Empty<JValue>()), JniHandleOwnership.TransferLocalRef)
		{
			JNIEnv.FinishCreateInstance(base.Handle, "()V", Array.Empty<JValue>());
			this.sender = sender;
		}

		// Token: 0x060005D8 RID: 1496 RVA: 0x0000F1E8 File Offset: 0x0000D3E8
		public void OnAdClicked(IMaxAd p0)
		{
			EventHandler<AdClickedEventArgs> onAdClickedHandler = this.OnAdClickedHandler;
			if (onAdClickedHandler != null)
			{
				onAdClickedHandler(this.sender, new AdClickedEventArgs(p0));
			}
		}

		// Token: 0x060005D9 RID: 1497 RVA: 0x0000F214 File Offset: 0x0000D414
		public void OnAdDisplayFailed(IMaxAd p0, IMaxError p1)
		{
			EventHandler<AdDisplayFailedEventArgs> onAdDisplayFailedHandler = this.OnAdDisplayFailedHandler;
			if (onAdDisplayFailedHandler != null)
			{
				onAdDisplayFailedHandler(this.sender, new AdDisplayFailedEventArgs(p0, p1));
			}
		}

		// Token: 0x060005DA RID: 1498 RVA: 0x0000F240 File Offset: 0x0000D440
		public void OnAdDisplayed(IMaxAd p0)
		{
			EventHandler<AdDisplayedEventArgs> onAdDisplayedHandler = this.OnAdDisplayedHandler;
			if (onAdDisplayedHandler != null)
			{
				onAdDisplayedHandler(this.sender, new AdDisplayedEventArgs(p0));
			}
		}

		// Token: 0x060005DB RID: 1499 RVA: 0x0000F26C File Offset: 0x0000D46C
		public void OnAdHidden(IMaxAd p0)
		{
			EventHandler<AdHiddenEventArgs> onAdHiddenHandler = this.OnAdHiddenHandler;
			if (onAdHiddenHandler != null)
			{
				onAdHiddenHandler(this.sender, new AdHiddenEventArgs(p0));
			}
		}

		// Token: 0x060005DC RID: 1500 RVA: 0x0000F298 File Offset: 0x0000D498
		public void OnAdLoadFailed(string p0, IMaxError p1)
		{
			EventHandler<AdLoadFailedEventArgs> onAdLoadFailedHandler = this.OnAdLoadFailedHandler;
			if (onAdLoadFailedHandler != null)
			{
				onAdLoadFailedHandler(this.sender, new AdLoadFailedEventArgs(p0, p1));
			}
		}

		// Token: 0x060005DD RID: 1501 RVA: 0x0000F2C4 File Offset: 0x0000D4C4
		public void OnAdLoaded(IMaxAd p0)
		{
			EventHandler<AdLoadedEventArgs> onAdLoadedHandler = this.OnAdLoadedHandler;
			if (onAdLoadedHandler != null)
			{
				onAdLoadedHandler(this.sender, new AdLoadedEventArgs(p0));
			}
		}

		// Token: 0x060005DE RID: 1502 RVA: 0x0000F2ED File Offset: 0x0000D4ED
		internal static bool __IsEmpty(IMaxAdListenerImplementor value)
		{
			return value.OnAdClickedHandler == null && value.OnAdDisplayFailedHandler == null && value.OnAdDisplayedHandler == null && value.OnAdHiddenHandler == null && value.OnAdLoadFailedHandler == null && value.OnAdLoadedHandler == null;
		}

		// Token: 0x040001DA RID: 474
		private object sender;

		// Token: 0x040001DB RID: 475
		public EventHandler<AdClickedEventArgs> OnAdClickedHandler;

		// Token: 0x040001DC RID: 476
		public EventHandler<AdDisplayFailedEventArgs> OnAdDisplayFailedHandler;

		// Token: 0x040001DD RID: 477
		public EventHandler<AdDisplayedEventArgs> OnAdDisplayedHandler;

		// Token: 0x040001DE RID: 478
		public EventHandler<AdHiddenEventArgs> OnAdHiddenHandler;

		// Token: 0x040001DF RID: 479
		public EventHandler<AdLoadFailedEventArgs> OnAdLoadFailedHandler;

		// Token: 0x040001E0 RID: 480
		public EventHandler<AdLoadedEventArgs> OnAdLoadedHandler;
	}
}
