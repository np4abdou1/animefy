using System;
using Android.OS;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Com.Applovin.Sdk
{
	// Token: 0x0200009D RID: 157
	[Register("mono/com/applovin/sdk/AppLovinVariableService_OnVariablesUpdateListenerImplementor")]
	internal sealed class IAppLovinVariableServiceOnVariablesUpdateListenerImplementor : Java.Lang.Object, IAppLovinVariableServiceOnVariablesUpdateListener, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x0600053B RID: 1339 RVA: 0x0000DB29 File Offset: 0x0000BD29
		public IAppLovinVariableServiceOnVariablesUpdateListenerImplementor(object sender) : base(JNIEnv.StartCreateInstance("mono/com/applovin/sdk/AppLovinVariableService_OnVariablesUpdateListenerImplementor", "()V", Array.Empty<JValue>()), JniHandleOwnership.TransferLocalRef)
		{
			JNIEnv.FinishCreateInstance(base.Handle, "()V", Array.Empty<JValue>());
			this.sender = sender;
		}

		// Token: 0x0600053C RID: 1340 RVA: 0x0000DB64 File Offset: 0x0000BD64
		public void OnVariablesUpdate(Bundle p0)
		{
			EventHandler<AppLovinVariableServiceOnVariablesUpdateEventArgs> handler = this.Handler;
			if (handler != null)
			{
				handler(this.sender, new AppLovinVariableServiceOnVariablesUpdateEventArgs(p0));
			}
		}

		// Token: 0x0600053D RID: 1341 RVA: 0x0000DB8D File Offset: 0x0000BD8D
		internal static bool __IsEmpty(IAppLovinVariableServiceOnVariablesUpdateListenerImplementor value)
		{
			return value.Handler == null;
		}

		// Token: 0x04000192 RID: 402
		private object sender;

		// Token: 0x04000193 RID: 403
		public EventHandler<AppLovinVariableServiceOnVariablesUpdateEventArgs> Handler;
	}
}
