using System;
using Android.Content;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace AndroidX.Activity.ContextAware
{
	// Token: 0x02000020 RID: 32
	[Register("mono/androidx/activity/contextaware/OnContextAvailableListenerImplementor")]
	internal sealed class IOnContextAvailableListenerImplementor : Java.Lang.Object, IOnContextAvailableListener, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x060000EB RID: 235 RVA: 0x000043C9 File Offset: 0x000025C9
		public IOnContextAvailableListenerImplementor(object sender) : base(JNIEnv.StartCreateInstance("mono/androidx/activity/contextaware/OnContextAvailableListenerImplementor", "()V", Array.Empty<JValue>()), JniHandleOwnership.TransferLocalRef)
		{
			JNIEnv.FinishCreateInstance(base.Handle, "()V", Array.Empty<JValue>());
			this.sender = sender;
		}

		// Token: 0x060000EC RID: 236 RVA: 0x00004404 File Offset: 0x00002604
		public void OnContextAvailable(Context context)
		{
			EventHandler<ContextAvailableEventArgs> handler = this.Handler;
			if (handler != null)
			{
				handler(this.sender, new ContextAvailableEventArgs(context));
			}
		}

		// Token: 0x060000ED RID: 237 RVA: 0x0000442D File Offset: 0x0000262D
		internal static bool __IsEmpty(IOnContextAvailableListenerImplementor value)
		{
			return value.Handler == null;
		}

		// Token: 0x04000035 RID: 53
		private object sender;

		// Token: 0x04000036 RID: 54
		public EventHandler<ContextAvailableEventArgs> Handler;
	}
}
