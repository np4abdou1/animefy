using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Com.Unity3d.Services.Core.Request
{
	// Token: 0x020000AB RID: 171
	[Register("mono/com/unity3d/services/core/request/IWebRequestProgressListenerImplementor")]
	internal sealed class IWebRequestProgressListenerImplementor : Java.Lang.Object, IWebRequestProgressListener, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x06000616 RID: 1558 RVA: 0x000110CB File Offset: 0x0000F2CB
		public IWebRequestProgressListenerImplementor(object sender) : base(JNIEnv.StartCreateInstance("mono/com/unity3d/services/core/request/IWebRequestProgressListenerImplementor", "()V", Array.Empty<JValue>()), JniHandleOwnership.TransferLocalRef)
		{
			JNIEnv.FinishCreateInstance(base.Handle, "()V", Array.Empty<JValue>());
			this.sender = sender;
		}

		// Token: 0x06000617 RID: 1559 RVA: 0x00011104 File Offset: 0x0000F304
		public void OnRequestProgress(string p0, long p1, long p2)
		{
			EventHandler<RequestProgressEventArgs> onRequestProgressHandler = this.OnRequestProgressHandler;
			if (onRequestProgressHandler != null)
			{
				onRequestProgressHandler(this.sender, new RequestProgressEventArgs(p0, p1, p2));
			}
		}

		// Token: 0x06000618 RID: 1560 RVA: 0x00011130 File Offset: 0x0000F330
		public void OnRequestStart(string p0, long p1, int p2, IDictionary<string, IList<string>> p3)
		{
			EventHandler<RequestStartEventArgs> onRequestStartHandler = this.OnRequestStartHandler;
			if (onRequestStartHandler != null)
			{
				onRequestStartHandler(this.sender, new RequestStartEventArgs(p0, p1, p2, p3));
			}
		}

		// Token: 0x06000619 RID: 1561 RVA: 0x0001115D File Offset: 0x0000F35D
		internal static bool __IsEmpty(IWebRequestProgressListenerImplementor value)
		{
			return value.OnRequestProgressHandler == null && value.OnRequestStartHandler == null;
		}

		// Token: 0x04000179 RID: 377
		private object sender;

		// Token: 0x0400017A RID: 378
		public EventHandler<RequestProgressEventArgs> OnRequestProgressHandler;

		// Token: 0x0400017B RID: 379
		public EventHandler<RequestStartEventArgs> OnRequestStartHandler;
	}
}
