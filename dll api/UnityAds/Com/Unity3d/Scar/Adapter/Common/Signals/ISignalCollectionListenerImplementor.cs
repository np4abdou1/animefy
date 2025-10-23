using System;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Com.Unity3d.Scar.Adapter.Common.Signals
{
	// Token: 0x020002B3 RID: 691
	[Register("mono/com/unity3d/scar/adapter/common/signals/ISignalCollectionListenerImplementor")]
	internal sealed class ISignalCollectionListenerImplementor : Java.Lang.Object, ISignalCollectionListener, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x06002738 RID: 10040 RVA: 0x000650AE File Offset: 0x000632AE
		public ISignalCollectionListenerImplementor(object sender) : base(JNIEnv.StartCreateInstance("mono/com/unity3d/scar/adapter/common/signals/ISignalCollectionListenerImplementor", "()V", Array.Empty<JValue>()), JniHandleOwnership.TransferLocalRef)
		{
			JNIEnv.FinishCreateInstance(base.Handle, "()V", Array.Empty<JValue>());
			this.sender = sender;
		}

		// Token: 0x06002739 RID: 10041 RVA: 0x000650E8 File Offset: 0x000632E8
		public void OnSignalsCollected(string p0)
		{
			EventHandler<SignalsCollectedEventArgs> onSignalsCollectedHandler = this.OnSignalsCollectedHandler;
			if (onSignalsCollectedHandler != null)
			{
				onSignalsCollectedHandler(this.sender, new SignalsCollectedEventArgs(p0));
			}
		}

		// Token: 0x0600273A RID: 10042 RVA: 0x00065114 File Offset: 0x00063314
		public void OnSignalsCollectionFailed(string p0)
		{
			EventHandler<SignalsCollectionFailedEventArgs> onSignalsCollectionFailedHandler = this.OnSignalsCollectionFailedHandler;
			if (onSignalsCollectionFailedHandler != null)
			{
				onSignalsCollectionFailedHandler(this.sender, new SignalsCollectionFailedEventArgs(p0));
			}
		}

		// Token: 0x0600273B RID: 10043 RVA: 0x0006513D File Offset: 0x0006333D
		internal static bool __IsEmpty(ISignalCollectionListenerImplementor value)
		{
			return value.OnSignalsCollectedHandler == null && value.OnSignalsCollectionFailedHandler == null;
		}

		// Token: 0x040007D1 RID: 2001
		private object sender;

		// Token: 0x040007D2 RID: 2002
		public EventHandler<SignalsCollectedEventArgs> OnSignalsCollectedHandler;

		// Token: 0x040007D3 RID: 2003
		public EventHandler<SignalsCollectionFailedEventArgs> OnSignalsCollectionFailedHandler;
	}
}
