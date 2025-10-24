using System;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Xamarin.Google.UserMesssagingPlatform
{
	// Token: 0x0200002B RID: 43
	[Register("mono/com/google/android/ump/ConsentInformation_OnConsentInfoUpdateSuccessListenerImplementor")]
	internal sealed class IConsentInformationOnConsentInfoUpdateSuccessListenerImplementor : Java.Lang.Object, IConsentInformationOnConsentInfoUpdateSuccessListener, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x060000F5 RID: 245 RVA: 0x00003BE6 File Offset: 0x00001DE6
		public IConsentInformationOnConsentInfoUpdateSuccessListenerImplementor(object sender) : base(JNIEnv.StartCreateInstance("mono/com/google/android/ump/ConsentInformation_OnConsentInfoUpdateSuccessListenerImplementor", "()V", Array.Empty<JValue>()), JniHandleOwnership.TransferLocalRef)
		{
			JNIEnv.FinishCreateInstance(base.Handle, "()V", Array.Empty<JValue>());
			this.sender = sender;
		}

		// Token: 0x060000F6 RID: 246 RVA: 0x00003C20 File Offset: 0x00001E20
		public void OnConsentInfoUpdateSuccess()
		{
			EventHandler handler = this.Handler;
			if (handler != null)
			{
				handler(this.sender, new EventArgs());
			}
		}

		// Token: 0x060000F7 RID: 247 RVA: 0x00003C48 File Offset: 0x00001E48
		internal static bool __IsEmpty(IConsentInformationOnConsentInfoUpdateSuccessListenerImplementor value)
		{
			return value.Handler == null;
		}

		// Token: 0x0400004F RID: 79
		private object sender;

		// Token: 0x04000050 RID: 80
		public EventHandler Handler;
	}
}
