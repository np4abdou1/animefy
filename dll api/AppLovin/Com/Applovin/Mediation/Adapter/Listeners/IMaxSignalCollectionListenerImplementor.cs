using System;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Com.Applovin.Mediation.Adapter.Listeners
{
	// Token: 0x02000128 RID: 296
	[Register("mono/com/applovin/mediation/adapter/listeners/MaxSignalCollectionListenerImplementor")]
	internal sealed class IMaxSignalCollectionListenerImplementor : Java.Lang.Object, IMaxSignalCollectionListener, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x06000D20 RID: 3360 RVA: 0x00023212 File Offset: 0x00021412
		public IMaxSignalCollectionListenerImplementor(object sender) : base(JNIEnv.StartCreateInstance("mono/com/applovin/mediation/adapter/listeners/MaxSignalCollectionListenerImplementor", "()V", Array.Empty<JValue>()), JniHandleOwnership.TransferLocalRef)
		{
			JNIEnv.FinishCreateInstance(base.Handle, "()V", Array.Empty<JValue>());
			this.sender = sender;
		}

		// Token: 0x06000D21 RID: 3361 RVA: 0x0002324C File Offset: 0x0002144C
		public void OnSignalCollected(string p0)
		{
			EventHandler<SignalCollectedEventArgs> onSignalCollectedHandler = this.OnSignalCollectedHandler;
			if (onSignalCollectedHandler != null)
			{
				onSignalCollectedHandler(this.sender, new SignalCollectedEventArgs(p0));
			}
		}

		// Token: 0x06000D22 RID: 3362 RVA: 0x00023278 File Offset: 0x00021478
		public void OnSignalCollectionFailed(string p0)
		{
			EventHandler<SignalCollectionFailedEventArgs> onSignalCollectionFailedHandler = this.OnSignalCollectionFailedHandler;
			if (onSignalCollectionFailedHandler != null)
			{
				onSignalCollectionFailedHandler(this.sender, new SignalCollectionFailedEventArgs(p0));
			}
		}

		// Token: 0x06000D23 RID: 3363 RVA: 0x000232A1 File Offset: 0x000214A1
		internal static bool __IsEmpty(IMaxSignalCollectionListenerImplementor value)
		{
			return value.OnSignalCollectedHandler == null && value.OnSignalCollectionFailedHandler == null;
		}

		// Token: 0x04000495 RID: 1173
		private object sender;

		// Token: 0x04000496 RID: 1174
		public EventHandler<SignalCollectedEventArgs> OnSignalCollectedHandler;

		// Token: 0x04000497 RID: 1175
		public EventHandler<SignalCollectionFailedEventArgs> OnSignalCollectionFailedHandler;
	}
}
