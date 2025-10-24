using System;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Com.Unity3d.Scar.Adapter.Common.Signals
{
	// Token: 0x020002AE RID: 686
	[Register("mono/com/unity3d/scar/adapter/common/signals/ISignalCallbackListenerImplementor")]
	internal sealed class ISignalCallbackListenerImplementor : Java.Lang.Object, ISignalCallbackListener, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x0600271F RID: 10015 RVA: 0x00064D6F File Offset: 0x00062F6F
		public ISignalCallbackListenerImplementor(object sender) : base(JNIEnv.StartCreateInstance("mono/com/unity3d/scar/adapter/common/signals/ISignalCallbackListenerImplementor", "()V", Array.Empty<JValue>()), JniHandleOwnership.TransferLocalRef)
		{
			JNIEnv.FinishCreateInstance(base.Handle, "()V", Array.Empty<JValue>());
			this.sender = sender;
		}

		// Token: 0x06002720 RID: 10016 RVA: 0x00064DA8 File Offset: 0x00062FA8
		public void OnFailure(string p0)
		{
			EventHandler<FailureEventArgs> onFailureHandler = this.OnFailureHandler;
			if (onFailureHandler != null)
			{
				onFailureHandler(this.sender, new FailureEventArgs(p0));
			}
		}

		// Token: 0x06002721 RID: 10017 RVA: 0x00064DD4 File Offset: 0x00062FD4
		public void OnSuccess(string p0, string p1, Java.Lang.Object p2)
		{
			EventHandler<SuccessEventArgs> onSuccessHandler = this.OnSuccessHandler;
			if (onSuccessHandler != null)
			{
				onSuccessHandler(this.sender, new SuccessEventArgs(p0, p1, p2));
			}
		}

		// Token: 0x06002722 RID: 10018 RVA: 0x00064DFF File Offset: 0x00062FFF
		internal static bool __IsEmpty(ISignalCallbackListenerImplementor value)
		{
			return value.OnFailureHandler == null && value.OnSuccessHandler == null;
		}

		// Token: 0x040007C6 RID: 1990
		private object sender;

		// Token: 0x040007C7 RID: 1991
		public EventHandler<FailureEventArgs> OnFailureHandler;

		// Token: 0x040007C8 RID: 1992
		public EventHandler<SuccessEventArgs> OnSuccessHandler;
	}
}
