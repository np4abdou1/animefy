using System;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Com.Unity3d.Services.Core.Lifecycle
{
	// Token: 0x020000F2 RID: 242
	[Register("mono/com/unity3d/services/core/lifecycle/IAppEventListenerImplementor")]
	internal sealed class IAppEventListenerImplementor : Java.Lang.Object, IAppEventListener, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x06000984 RID: 2436 RVA: 0x0001BB6D File Offset: 0x00019D6D
		public IAppEventListenerImplementor(object sender) : base(JNIEnv.StartCreateInstance("mono/com/unity3d/services/core/lifecycle/IAppEventListenerImplementor", "()V", Array.Empty<JValue>()), JniHandleOwnership.TransferLocalRef)
		{
			JNIEnv.FinishCreateInstance(base.Handle, "()V", Array.Empty<JValue>());
			this.sender = sender;
		}

		// Token: 0x06000985 RID: 2437 RVA: 0x0001BBA8 File Offset: 0x00019DA8
		public void OnLifecycleEvent(LifecycleEvent p0)
		{
			EventHandler<AppEventEventArgs> handler = this.Handler;
			if (handler != null)
			{
				handler(this.sender, new AppEventEventArgs(p0));
			}
		}

		// Token: 0x06000986 RID: 2438 RVA: 0x0001BBD1 File Offset: 0x00019DD1
		internal static bool __IsEmpty(IAppEventListenerImplementor value)
		{
			return value.Handler == null;
		}

		// Token: 0x0400023D RID: 573
		private object sender;

		// Token: 0x0400023E RID: 574
		public EventHandler<AppEventEventArgs> Handler;
	}
}
