using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Com.Applovin.Sdk
{
	// Token: 0x0200007D RID: 125
	[Register("mono/com/applovin/sdk/AppLovinAdRewardListenerImplementor")]
	internal sealed class IAppLovinAdRewardListenerImplementor : Java.Lang.Object, IAppLovinAdRewardListener, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x06000413 RID: 1043 RVA: 0x0000AFF2 File Offset: 0x000091F2
		public IAppLovinAdRewardListenerImplementor(object sender) : base(JNIEnv.StartCreateInstance("mono/com/applovin/sdk/AppLovinAdRewardListenerImplementor", "()V", Array.Empty<JValue>()), JniHandleOwnership.TransferLocalRef)
		{
			JNIEnv.FinishCreateInstance(base.Handle, "()V", Array.Empty<JValue>());
			this.sender = sender;
		}

		// Token: 0x06000414 RID: 1044 RVA: 0x0000B02C File Offset: 0x0000922C
		public void UserOverQuota(IAppLovinAd p0, IDictionary<string, string> p1)
		{
			EventHandler<UserOverQuotaEventArgs> userOverQuotaHandler = this.UserOverQuotaHandler;
			if (userOverQuotaHandler != null)
			{
				userOverQuotaHandler(this.sender, new UserOverQuotaEventArgs(p0, p1));
			}
		}

		// Token: 0x06000415 RID: 1045 RVA: 0x0000B058 File Offset: 0x00009258
		public void UserRewardRejected(IAppLovinAd p0, IDictionary<string, string> p1)
		{
			EventHandler<UserRewardRejectedEventArgs> userRewardRejectedHandler = this.UserRewardRejectedHandler;
			if (userRewardRejectedHandler != null)
			{
				userRewardRejectedHandler(this.sender, new UserRewardRejectedEventArgs(p0, p1));
			}
		}

		// Token: 0x06000416 RID: 1046 RVA: 0x0000B084 File Offset: 0x00009284
		public void UserRewardVerified(IAppLovinAd p0, IDictionary<string, string> p1)
		{
			EventHandler<UserRewardVerifiedEventArgs> userRewardVerifiedHandler = this.UserRewardVerifiedHandler;
			if (userRewardVerifiedHandler != null)
			{
				userRewardVerifiedHandler(this.sender, new UserRewardVerifiedEventArgs(p0, p1));
			}
		}

		// Token: 0x06000417 RID: 1047 RVA: 0x0000B0B0 File Offset: 0x000092B0
		public void ValidationRequestFailed(IAppLovinAd p0, int p1)
		{
			EventHandler<ValidationRequestFailedEventArgs> validationRequestFailedHandler = this.ValidationRequestFailedHandler;
			if (validationRequestFailedHandler != null)
			{
				validationRequestFailedHandler(this.sender, new ValidationRequestFailedEventArgs(p0, p1));
			}
		}

		// Token: 0x06000418 RID: 1048 RVA: 0x0000B0DA File Offset: 0x000092DA
		internal static bool __IsEmpty(IAppLovinAdRewardListenerImplementor value)
		{
			return value.UserOverQuotaHandler == null && value.UserRewardRejectedHandler == null && value.UserRewardVerifiedHandler == null && value.ValidationRequestFailedHandler == null;
		}

		// Token: 0x04000118 RID: 280
		private object sender;

		// Token: 0x04000119 RID: 281
		public EventHandler<UserOverQuotaEventArgs> UserOverQuotaHandler;

		// Token: 0x0400011A RID: 282
		public EventHandler<UserRewardRejectedEventArgs> UserRewardRejectedHandler;

		// Token: 0x0400011B RID: 283
		public EventHandler<UserRewardVerifiedEventArgs> UserRewardVerifiedHandler;

		// Token: 0x0400011C RID: 284
		public EventHandler<ValidationRequestFailedEventArgs> ValidationRequestFailedHandler;
	}
}
