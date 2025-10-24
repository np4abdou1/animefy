using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Com.Unity3d.Services.Core.Request
{
	// Token: 0x020000A6 RID: 166
	[Register("mono/com/unity3d/services/core/request/IWebRequestListenerImplementor")]
	internal sealed class IWebRequestListenerImplementor : Java.Lang.Object, IWebRequestListener, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x060005F8 RID: 1528 RVA: 0x00010CB5 File Offset: 0x0000EEB5
		public IWebRequestListenerImplementor(object sender) : base(JNIEnv.StartCreateInstance("mono/com/unity3d/services/core/request/IWebRequestListenerImplementor", "()V", Array.Empty<JValue>()), JniHandleOwnership.TransferLocalRef)
		{
			JNIEnv.FinishCreateInstance(base.Handle, "()V", Array.Empty<JValue>());
			this.sender = sender;
		}

		// Token: 0x060005F9 RID: 1529 RVA: 0x00010CF0 File Offset: 0x0000EEF0
		public void OnComplete(string p0, string p1, int p2, IDictionary<string, IList<string>> p3)
		{
			EventHandler<CompleteEventArgs> onCompleteHandler = this.OnCompleteHandler;
			if (onCompleteHandler != null)
			{
				onCompleteHandler(this.sender, new CompleteEventArgs(p0, p1, p2, p3));
			}
		}

		// Token: 0x060005FA RID: 1530 RVA: 0x00010D20 File Offset: 0x0000EF20
		public void OnFailed(string p0, string p1)
		{
			EventHandler<FailedEventArgs> onFailedHandler = this.OnFailedHandler;
			if (onFailedHandler != null)
			{
				onFailedHandler(this.sender, new FailedEventArgs(p0, p1));
			}
		}

		// Token: 0x060005FB RID: 1531 RVA: 0x00010D4A File Offset: 0x0000EF4A
		internal static bool __IsEmpty(IWebRequestListenerImplementor value)
		{
			return value.OnCompleteHandler == null && value.OnFailedHandler == null;
		}

		// Token: 0x04000169 RID: 361
		private object sender;

		// Token: 0x0400016A RID: 362
		public EventHandler<CompleteEventArgs> OnCompleteHandler;

		// Token: 0x0400016B RID: 363
		public EventHandler<FailedEventArgs> OnFailedHandler;
	}
}
