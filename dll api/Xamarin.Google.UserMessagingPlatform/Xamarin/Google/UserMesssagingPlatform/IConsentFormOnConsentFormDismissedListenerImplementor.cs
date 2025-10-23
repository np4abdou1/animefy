using System;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Xamarin.Google.UserMesssagingPlatform
{
	// Token: 0x0200001E RID: 30
	[Register("mono/com/google/android/ump/ConsentForm_OnConsentFormDismissedListenerImplementor")]
	internal sealed class IConsentFormOnConsentFormDismissedListenerImplementor : Java.Lang.Object, IConsentFormOnConsentFormDismissedListener, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x060000AF RID: 175 RVA: 0x000032AD File Offset: 0x000014AD
		public IConsentFormOnConsentFormDismissedListenerImplementor(object sender) : base(JNIEnv.StartCreateInstance("mono/com/google/android/ump/ConsentForm_OnConsentFormDismissedListenerImplementor", "()V", Array.Empty<JValue>()), JniHandleOwnership.TransferLocalRef)
		{
			JNIEnv.FinishCreateInstance(base.Handle, "()V", Array.Empty<JValue>());
			this.sender = sender;
		}

		// Token: 0x060000B0 RID: 176 RVA: 0x000032E8 File Offset: 0x000014E8
		public void OnConsentFormDismissed(FormError p0)
		{
			EventHandler<ConsentFormOnConsentFormDismissedEventArgs> handler = this.Handler;
			if (handler != null)
			{
				handler(this.sender, new ConsentFormOnConsentFormDismissedEventArgs(p0));
			}
		}

		// Token: 0x060000B1 RID: 177 RVA: 0x00003311 File Offset: 0x00001511
		internal static bool __IsEmpty(IConsentFormOnConsentFormDismissedListenerImplementor value)
		{
			return value.Handler == null;
		}

		// Token: 0x04000030 RID: 48
		private object sender;

		// Token: 0x04000031 RID: 49
		public EventHandler<ConsentFormOnConsentFormDismissedEventArgs> Handler;
	}
}
