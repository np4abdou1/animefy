using System;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Com.Unity3d.Services.Core.Configuration
{
	// Token: 0x02000163 RID: 355
	[Register("mono/com/unity3d/services/core/configuration/IConfigurationLoaderListenerImplementor")]
	internal sealed class IConfigurationLoaderListenerImplementor : Java.Lang.Object, IConfigurationLoaderListener, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x06000F4D RID: 3917 RVA: 0x00029A9F File Offset: 0x00027C9F
		public IConfigurationLoaderListenerImplementor(object sender) : base(JNIEnv.StartCreateInstance("mono/com/unity3d/services/core/configuration/IConfigurationLoaderListenerImplementor", "()V", Array.Empty<JValue>()), JniHandleOwnership.TransferLocalRef)
		{
			JNIEnv.FinishCreateInstance(base.Handle, "()V", Array.Empty<JValue>());
			this.sender = sender;
		}

		// Token: 0x06000F4E RID: 3918 RVA: 0x00029AD8 File Offset: 0x00027CD8
		public void OnError(string p0)
		{
			EventHandler<ErrorEventArgs> onErrorHandler = this.OnErrorHandler;
			if (onErrorHandler != null)
			{
				onErrorHandler(this.sender, new ErrorEventArgs(p0));
			}
		}

		// Token: 0x06000F4F RID: 3919 RVA: 0x00029B04 File Offset: 0x00027D04
		public void OnSuccess(Configuration p0)
		{
			EventHandler<SuccessEventArgs> onSuccessHandler = this.OnSuccessHandler;
			if (onSuccessHandler != null)
			{
				onSuccessHandler(this.sender, new SuccessEventArgs(p0));
			}
		}

		// Token: 0x06000F50 RID: 3920 RVA: 0x00029B2D File Offset: 0x00027D2D
		internal static bool __IsEmpty(IConfigurationLoaderListenerImplementor value)
		{
			return value.OnErrorHandler == null && value.OnSuccessHandler == null;
		}

		// Token: 0x04000399 RID: 921
		private object sender;

		// Token: 0x0400039A RID: 922
		public EventHandler<ErrorEventArgs> OnErrorHandler;

		// Token: 0x0400039B RID: 923
		public EventHandler<SuccessEventArgs> OnSuccessHandler;
	}
}
