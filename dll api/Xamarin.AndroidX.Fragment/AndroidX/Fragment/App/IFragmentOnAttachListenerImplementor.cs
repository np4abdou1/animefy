using System;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace AndroidX.Fragment.App
{
	// Token: 0x0200004B RID: 75
	[Register("mono/androidx/fragment/app/FragmentOnAttachListenerImplementor")]
	internal sealed class IFragmentOnAttachListenerImplementor : Java.Lang.Object, IFragmentOnAttachListener, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x0600042C RID: 1068 RVA: 0x0000D95E File Offset: 0x0000BB5E
		public IFragmentOnAttachListenerImplementor(object sender) : base(JNIEnv.StartCreateInstance("mono/androidx/fragment/app/FragmentOnAttachListenerImplementor", "()V", Array.Empty<JValue>()), JniHandleOwnership.TransferLocalRef)
		{
			JNIEnv.FinishCreateInstance(base.Handle, "()V", Array.Empty<JValue>());
			this.sender = sender;
		}

		// Token: 0x0600042D RID: 1069 RVA: 0x0000D998 File Offset: 0x0000BB98
		public void OnAttachFragment(FragmentManager p0, Fragment p1)
		{
			EventHandler<FragmentOnAttachEventArgs> handler = this.Handler;
			if (handler != null)
			{
				handler(this.sender, new FragmentOnAttachEventArgs(p0, p1));
			}
		}

		// Token: 0x0600042E RID: 1070 RVA: 0x0000D9C2 File Offset: 0x0000BBC2
		internal static bool __IsEmpty(IFragmentOnAttachListenerImplementor value)
		{
			return value.Handler == null;
		}

		// Token: 0x0400011D RID: 285
		private object sender;

		// Token: 0x0400011E RID: 286
		public EventHandler<FragmentOnAttachEventArgs> Handler;
	}
}
