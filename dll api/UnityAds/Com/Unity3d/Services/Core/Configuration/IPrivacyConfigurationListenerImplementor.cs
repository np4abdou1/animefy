using System;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Com.Unity3d.Services.Core.Configuration
{
	// Token: 0x02000176 RID: 374
	[Register("mono/com/unity3d/services/core/configuration/IPrivacyConfigurationListenerImplementor")]
	internal sealed class IPrivacyConfigurationListenerImplementor : Java.Lang.Object, IPrivacyConfigurationListener, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x060010BD RID: 4285 RVA: 0x0002CE5A File Offset: 0x0002B05A
		public IPrivacyConfigurationListenerImplementor(object sender) : base(JNIEnv.StartCreateInstance("mono/com/unity3d/services/core/configuration/IPrivacyConfigurationListenerImplementor", "()V", Array.Empty<JValue>()), JniHandleOwnership.TransferLocalRef)
		{
			JNIEnv.FinishCreateInstance(base.Handle, "()V", Array.Empty<JValue>());
			this.sender = sender;
		}

		// Token: 0x060010BE RID: 4286 RVA: 0x0002CE94 File Offset: 0x0002B094
		public void OnError(string p0)
		{
			EventHandler<ErrorEventArgs> onErrorHandler = this.OnErrorHandler;
			if (onErrorHandler != null)
			{
				onErrorHandler(this.sender, new ErrorEventArgs(p0));
			}
		}

		// Token: 0x060010BF RID: 4287 RVA: 0x0002CEC0 File Offset: 0x0002B0C0
		public void OnSuccess(PrivacyConfig p0)
		{
			EventHandler<SuccessEventArgs> onSuccessHandler = this.OnSuccessHandler;
			if (onSuccessHandler != null)
			{
				onSuccessHandler(this.sender, new SuccessEventArgs(p0));
			}
		}

		// Token: 0x060010C0 RID: 4288 RVA: 0x0002CEE9 File Offset: 0x0002B0E9
		internal static bool __IsEmpty(IPrivacyConfigurationListenerImplementor value)
		{
			return value.OnErrorHandler == null && value.OnSuccessHandler == null;
		}

		// Token: 0x0400042A RID: 1066
		private object sender;

		// Token: 0x0400042B RID: 1067
		public EventHandler<ErrorEventArgs> OnErrorHandler;

		// Token: 0x0400042C RID: 1068
		public EventHandler<SuccessEventArgs> OnSuccessHandler;
	}
}
