using System;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Bumptech.Glide.Load.Engine.Cache
{
	// Token: 0x0200016B RID: 363
	[Register("mono/com/bumptech/glide/load/engine/cache/MemoryCache_ResourceRemovedListenerImplementor")]
	internal sealed class IMemoryCacheResourceRemovedListenerImplementor : Java.Lang.Object, IMemoryCacheResourceRemovedListener, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x060011F8 RID: 4600 RVA: 0x0003A096 File Offset: 0x00038296
		public IMemoryCacheResourceRemovedListenerImplementor(object sender) : base(JNIEnv.StartCreateInstance("mono/com/bumptech/glide/load/engine/cache/MemoryCache_ResourceRemovedListenerImplementor", "()V", Array.Empty<JValue>()), JniHandleOwnership.TransferLocalRef)
		{
			JNIEnv.FinishCreateInstance(base.Handle, "()V", Array.Empty<JValue>());
			this.sender = sender;
		}

		// Token: 0x060011F9 RID: 4601 RVA: 0x0003A0D0 File Offset: 0x000382D0
		public void OnResourceRemoved(IResource p0)
		{
			EventHandler<MemoryCacheResourceRemovedEventArgs> handler = this.Handler;
			if (handler != null)
			{
				handler(this.sender, new MemoryCacheResourceRemovedEventArgs(p0));
			}
		}

		// Token: 0x060011FA RID: 4602 RVA: 0x0003A0F9 File Offset: 0x000382F9
		internal static bool __IsEmpty(IMemoryCacheResourceRemovedListenerImplementor value)
		{
			return value.Handler == null;
		}

		// Token: 0x04000429 RID: 1065
		private object sender;

		// Token: 0x0400042A RID: 1066
		public EventHandler<MemoryCacheResourceRemovedEventArgs> Handler;
	}
}
