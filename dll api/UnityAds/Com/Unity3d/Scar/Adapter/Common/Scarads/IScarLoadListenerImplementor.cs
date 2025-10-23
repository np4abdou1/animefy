using System;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Com.Unity3d.Scar.Adapter.Common.Scarads
{
	// Token: 0x020002BF RID: 703
	[Register("mono/com/unity3d/scar/adapter/common/scarads/IScarLoadListenerImplementor")]
	internal sealed class IScarLoadListenerImplementor : Java.Lang.Object, IScarLoadListener, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x060027AB RID: 10155 RVA: 0x000666BA File Offset: 0x000648BA
		public IScarLoadListenerImplementor(object sender) : base(JNIEnv.StartCreateInstance("mono/com/unity3d/scar/adapter/common/scarads/IScarLoadListenerImplementor", "()V", Array.Empty<JValue>()), JniHandleOwnership.TransferLocalRef)
		{
			JNIEnv.FinishCreateInstance(base.Handle, "()V", Array.Empty<JValue>());
			this.sender = sender;
		}

		// Token: 0x060027AC RID: 10156 RVA: 0x000666F4 File Offset: 0x000648F4
		public void OnAdLoaded()
		{
			EventHandler handler = this.Handler;
			if (handler != null)
			{
				handler(this.sender, new EventArgs());
			}
		}

		// Token: 0x060027AD RID: 10157 RVA: 0x0006671C File Offset: 0x0006491C
		internal static bool __IsEmpty(IScarLoadListenerImplementor value)
		{
			return value.Handler == null;
		}

		// Token: 0x040007F3 RID: 2035
		private object sender;

		// Token: 0x040007F4 RID: 2036
		public EventHandler Handler;
	}
}
