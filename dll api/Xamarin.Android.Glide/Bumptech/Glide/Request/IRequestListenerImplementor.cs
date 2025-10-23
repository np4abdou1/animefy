using System;
using Android.Runtime;
using Bumptech.Glide.Load;
using Bumptech.Glide.Load.Engine;
using Bumptech.Glide.Request.Target;
using Java.Interop;
using Java.Lang;

namespace Bumptech.Glide.Request
{
	// Token: 0x02000094 RID: 148
	[Register("mono/com/bumptech/glide/request/RequestListenerImplementor")]
	internal sealed class IRequestListenerImplementor : Java.Lang.Object, IRequestListener, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x06000790 RID: 1936 RVA: 0x00017776 File Offset: 0x00015976
		public IRequestListenerImplementor(object sender) : base(JNIEnv.StartCreateInstance("mono/com/bumptech/glide/request/RequestListenerImplementor", "()V", Array.Empty<JValue>()), JniHandleOwnership.TransferLocalRef)
		{
			JNIEnv.FinishCreateInstance(base.Handle, "()V", Array.Empty<JValue>());
			this.sender = sender;
		}

		// Token: 0x06000791 RID: 1937 RVA: 0x000177B0 File Offset: 0x000159B0
		public bool OnLoadFailed(GlideException p0, Java.Lang.Object p1, ITarget p2, bool p3)
		{
			EventHandler<LoadFailedEventArgs> onLoadFailedHandler = this.OnLoadFailedHandler;
			if (onLoadFailedHandler == null)
			{
				return false;
			}
			LoadFailedEventArgs loadFailedEventArgs = new LoadFailedEventArgs(true, p0, p1, p2, p3);
			onLoadFailedHandler(this.sender, loadFailedEventArgs);
			return loadFailedEventArgs.Handled;
		}

		// Token: 0x06000792 RID: 1938 RVA: 0x000177E8 File Offset: 0x000159E8
		public bool OnResourceReady(Java.Lang.Object p0, Java.Lang.Object p1, ITarget p2, DataSource p3, bool p4)
		{
			EventHandler<ResourceReadyEventArgs> onResourceReadyHandler = this.OnResourceReadyHandler;
			if (onResourceReadyHandler == null)
			{
				return false;
			}
			ResourceReadyEventArgs resourceReadyEventArgs = new ResourceReadyEventArgs(true, p0, p1, p2, p3, p4);
			onResourceReadyHandler(this.sender, resourceReadyEventArgs);
			return resourceReadyEventArgs.Handled;
		}

		// Token: 0x06000793 RID: 1939 RVA: 0x00017822 File Offset: 0x00015A22
		internal static bool __IsEmpty(IRequestListenerImplementor value)
		{
			return value.OnLoadFailedHandler == null && value.OnResourceReadyHandler == null;
		}

		// Token: 0x040001D7 RID: 471
		private object sender;

		// Token: 0x040001D8 RID: 472
		public EventHandler<LoadFailedEventArgs> OnLoadFailedHandler;

		// Token: 0x040001D9 RID: 473
		public EventHandler<ResourceReadyEventArgs> OnResourceReadyHandler;
	}
}
