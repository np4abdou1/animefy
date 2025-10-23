using System;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Android.Gms.Ads.Rewarded
{
	// Token: 0x02000026 RID: 38
	[Register("mono/com/google/android/gms/ads/rewarded/OnAdMetadataChangedListenerImplementor")]
	internal sealed class IOnAdMetadataChangedListenerImplementor : Java.Lang.Object, IOnAdMetadataChangedListener, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x06000177 RID: 375 RVA: 0x0000574A File Offset: 0x0000394A
		public IOnAdMetadataChangedListenerImplementor(object sender) : base(JNIEnv.StartCreateInstance("mono/com/google/android/gms/ads/rewarded/OnAdMetadataChangedListenerImplementor", "()V", Array.Empty<JValue>()), JniHandleOwnership.TransferLocalRef)
		{
			JNIEnv.FinishCreateInstance(base.Handle, "()V", Array.Empty<JValue>());
			this.sender = sender;
		}

		// Token: 0x06000178 RID: 376 RVA: 0x00005784 File Offset: 0x00003984
		public void OnAdMetadataChanged()
		{
			EventHandler handler = this.Handler;
			if (handler != null)
			{
				handler(this.sender, new EventArgs());
			}
		}

		// Token: 0x06000179 RID: 377 RVA: 0x000057AC File Offset: 0x000039AC
		internal static bool __IsEmpty(IOnAdMetadataChangedListenerImplementor value)
		{
			return value.Handler == null;
		}

		// Token: 0x0400004F RID: 79
		private object sender;

		// Token: 0x04000050 RID: 80
		public EventHandler Handler;
	}
}
