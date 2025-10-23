using System;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Com.Unity3d.Services.Ads.Token
{
	// Token: 0x020001DE RID: 478
	[Register("mono/com/unity3d/services/ads/token/INativeTokenGeneratorListenerImplementor")]
	internal sealed class INativeTokenGeneratorListenerImplementor : Java.Lang.Object, INativeTokenGeneratorListener, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x060015D5 RID: 5589 RVA: 0x0003E9AB File Offset: 0x0003CBAB
		public INativeTokenGeneratorListenerImplementor(object sender) : base(JNIEnv.StartCreateInstance("mono/com/unity3d/services/ads/token/INativeTokenGeneratorListenerImplementor", "()V", Array.Empty<JValue>()), JniHandleOwnership.TransferLocalRef)
		{
			JNIEnv.FinishCreateInstance(base.Handle, "()V", Array.Empty<JValue>());
			this.sender = sender;
		}

		// Token: 0x060015D6 RID: 5590 RVA: 0x0003E9E4 File Offset: 0x0003CBE4
		public void OnReady(string p0)
		{
			EventHandler<NativeTokenGeneratorEventArgs> handler = this.Handler;
			if (handler != null)
			{
				handler(this.sender, new NativeTokenGeneratorEventArgs(p0));
			}
		}

		// Token: 0x060015D7 RID: 5591 RVA: 0x0003EA0D File Offset: 0x0003CC0D
		internal static bool __IsEmpty(INativeTokenGeneratorListenerImplementor value)
		{
			return value.Handler == null;
		}

		// Token: 0x0400052F RID: 1327
		private object sender;

		// Token: 0x04000530 RID: 1328
		public EventHandler<NativeTokenGeneratorEventArgs> Handler;
	}
}
