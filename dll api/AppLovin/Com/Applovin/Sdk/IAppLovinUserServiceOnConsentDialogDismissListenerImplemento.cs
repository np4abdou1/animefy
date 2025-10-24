using System;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Com.Applovin.Sdk
{
	// Token: 0x02000097 RID: 151
	[Register("mono/com/applovin/sdk/AppLovinUserService_OnConsentDialogDismissListenerImplementor")]
	internal sealed class IAppLovinUserServiceOnConsentDialogDismissListenerImplementor : Java.Lang.Object, IAppLovinUserServiceOnConsentDialogDismissListener, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x06000518 RID: 1304 RVA: 0x0000D69A File Offset: 0x0000B89A
		public IAppLovinUserServiceOnConsentDialogDismissListenerImplementor(object sender) : base(JNIEnv.StartCreateInstance("mono/com/applovin/sdk/AppLovinUserService_OnConsentDialogDismissListenerImplementor", "()V", Array.Empty<JValue>()), JniHandleOwnership.TransferLocalRef)
		{
			JNIEnv.FinishCreateInstance(base.Handle, "()V", Array.Empty<JValue>());
			this.sender = sender;
		}

		// Token: 0x06000519 RID: 1305 RVA: 0x0000D6D4 File Offset: 0x0000B8D4
		public void OnDismiss()
		{
			EventHandler handler = this.Handler;
			if (handler != null)
			{
				handler(this.sender, new EventArgs());
			}
		}

		// Token: 0x0600051A RID: 1306 RVA: 0x0000D6FC File Offset: 0x0000B8FC
		internal static bool __IsEmpty(IAppLovinUserServiceOnConsentDialogDismissListenerImplementor value)
		{
			return value.Handler == null;
		}

		// Token: 0x04000185 RID: 389
		private object sender;

		// Token: 0x04000186 RID: 390
		public EventHandler Handler;
	}
}
