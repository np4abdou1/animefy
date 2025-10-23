using System;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Com.Unity3d.Services.Ads.Gmascar.Listeners
{
	// Token: 0x02000205 RID: 517
	[Register("mono/com/unity3d/services/ads/gmascar/listeners/IInitializationStatusListenerImplementor")]
	internal sealed class IInitializationStatusListenerImplementor : Java.Lang.Object, IInitializationStatusListener, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x06001811 RID: 6161 RVA: 0x000459BD File Offset: 0x00043BBD
		public IInitializationStatusListenerImplementor(object sender) : base(JNIEnv.StartCreateInstance("mono/com/unity3d/services/ads/gmascar/listeners/IInitializationStatusListenerImplementor", "()V", Array.Empty<JValue>()), JniHandleOwnership.TransferLocalRef)
		{
			JNIEnv.FinishCreateInstance(base.Handle, "()V", Array.Empty<JValue>());
			this.sender = sender;
		}

		// Token: 0x06001812 RID: 6162 RVA: 0x000459F8 File Offset: 0x00043BF8
		public void OnInitializationComplete(Java.Lang.Object p0)
		{
			EventHandler<InitializationStatusEventArgs> handler = this.Handler;
			if (handler != null)
			{
				handler(this.sender, new InitializationStatusEventArgs(p0));
			}
		}

		// Token: 0x06001813 RID: 6163 RVA: 0x00045A21 File Offset: 0x00043C21
		internal static bool __IsEmpty(IInitializationStatusListenerImplementor value)
		{
			return value.Handler == null;
		}

		// Token: 0x040005DC RID: 1500
		private object sender;

		// Token: 0x040005DD RID: 1501
		public EventHandler<InitializationStatusEventArgs> Handler;
	}
}
