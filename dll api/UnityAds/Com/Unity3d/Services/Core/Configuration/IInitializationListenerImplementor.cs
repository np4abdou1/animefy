using System;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Com.Unity3d.Services.Core.Configuration
{
	// Token: 0x02000169 RID: 361
	[Register("mono/com/unity3d/services/core/configuration/IInitializationListenerImplementor")]
	internal sealed class IInitializationListenerImplementor : Java.Lang.Object, IInitializationListener, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x06000FAF RID: 4015 RVA: 0x0002A668 File Offset: 0x00028868
		public IInitializationListenerImplementor(object sender) : base(JNIEnv.StartCreateInstance("mono/com/unity3d/services/core/configuration/IInitializationListenerImplementor", "()V", Array.Empty<JValue>()), JniHandleOwnership.TransferLocalRef)
		{
			JNIEnv.FinishCreateInstance(base.Handle, "()V", Array.Empty<JValue>());
			this.sender = sender;
		}

		// Token: 0x06000FB0 RID: 4016 RVA: 0x0002A6A4 File Offset: 0x000288A4
		public void OnSdkInitializationFailed(string p0, ErrorState p1, int p2)
		{
			EventHandler<SdkInitializationFailedEventArgs> onSdkInitializationFailedHandler = this.OnSdkInitializationFailedHandler;
			if (onSdkInitializationFailedHandler != null)
			{
				onSdkInitializationFailedHandler(this.sender, new SdkInitializationFailedEventArgs(p0, p1, p2));
			}
		}

		// Token: 0x06000FB1 RID: 4017 RVA: 0x0002A6D0 File Offset: 0x000288D0
		public void OnSdkInitialized()
		{
			EventHandler onSdkInitializedHandler = this.OnSdkInitializedHandler;
			if (onSdkInitializedHandler != null)
			{
				onSdkInitializedHandler(this.sender, new EventArgs());
			}
		}

		// Token: 0x06000FB2 RID: 4018 RVA: 0x0002A6F8 File Offset: 0x000288F8
		internal static bool __IsEmpty(IInitializationListenerImplementor value)
		{
			return value.OnSdkInitializationFailedHandler == null && value.OnSdkInitializedHandler == null;
		}

		// Token: 0x040003C7 RID: 967
		private object sender;

		// Token: 0x040003C8 RID: 968
		public EventHandler<SdkInitializationFailedEventArgs> OnSdkInitializationFailedHandler;

		// Token: 0x040003C9 RID: 969
		public EventHandler OnSdkInitializedHandler;
	}
}
