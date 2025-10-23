using System;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Xamarin.Google.UserMesssagingPlatform
{
	// Token: 0x02000028 RID: 40
	[Register("mono/com/google/android/ump/ConsentInformation_OnConsentInfoUpdateFailureListenerImplementor")]
	internal sealed class IConsentInformationOnConsentInfoUpdateFailureListenerImplementor : Java.Lang.Object, IConsentInformationOnConsentInfoUpdateFailureListener, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x060000E5 RID: 229 RVA: 0x00003A0D File Offset: 0x00001C0D
		public IConsentInformationOnConsentInfoUpdateFailureListenerImplementor(object sender) : base(JNIEnv.StartCreateInstance("mono/com/google/android/ump/ConsentInformation_OnConsentInfoUpdateFailureListenerImplementor", "()V", Array.Empty<JValue>()), JniHandleOwnership.TransferLocalRef)
		{
			JNIEnv.FinishCreateInstance(base.Handle, "()V", Array.Empty<JValue>());
			this.sender = sender;
		}

		// Token: 0x060000E6 RID: 230 RVA: 0x00003A48 File Offset: 0x00001C48
		public void OnConsentInfoUpdateFailure(FormError p0)
		{
			EventHandler<ConsentInformationOnConsentInfoUpdateFailureEventArgs> handler = this.Handler;
			if (handler != null)
			{
				handler(this.sender, new ConsentInformationOnConsentInfoUpdateFailureEventArgs(p0));
			}
		}

		// Token: 0x060000E7 RID: 231 RVA: 0x00003A71 File Offset: 0x00001C71
		internal static bool __IsEmpty(IConsentInformationOnConsentInfoUpdateFailureListenerImplementor value)
		{
			return value.Handler == null;
		}

		// Token: 0x04000049 RID: 73
		private object sender;

		// Token: 0x0400004A RID: 74
		public EventHandler<ConsentInformationOnConsentInfoUpdateFailureEventArgs> Handler;
	}
}
