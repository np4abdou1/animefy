using System;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Com.Unity3d.Services.Core.Request
{
	// Token: 0x020000A2 RID: 162
	[Register("mono/com/unity3d/services/core/request/IResolveHostListenerImplementor")]
	internal sealed class IResolveHostListenerImplementor : Java.Lang.Object, IResolveHostListener, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x060005DE RID: 1502 RVA: 0x000108C9 File Offset: 0x0000EAC9
		public IResolveHostListenerImplementor(object sender) : base(JNIEnv.StartCreateInstance("mono/com/unity3d/services/core/request/IResolveHostListenerImplementor", "()V", Array.Empty<JValue>()), JniHandleOwnership.TransferLocalRef)
		{
			JNIEnv.FinishCreateInstance(base.Handle, "()V", Array.Empty<JValue>());
			this.sender = sender;
		}

		// Token: 0x060005DF RID: 1503 RVA: 0x00010904 File Offset: 0x0000EB04
		public void OnFailed(string p0, ResolveHostError p1, string p2)
		{
			EventHandler<FailedEventArgs> onFailedHandler = this.OnFailedHandler;
			if (onFailedHandler != null)
			{
				onFailedHandler(this.sender, new FailedEventArgs(p0, p1, p2));
			}
		}

		// Token: 0x060005E0 RID: 1504 RVA: 0x00010930 File Offset: 0x0000EB30
		public void OnResolve(string p0, string p1)
		{
			EventHandler<ResolveEventArgs> onResolveHandler = this.OnResolveHandler;
			if (onResolveHandler != null)
			{
				onResolveHandler(this.sender, new ResolveEventArgs(p0, p1));
			}
		}

		// Token: 0x060005E1 RID: 1505 RVA: 0x0001095A File Offset: 0x0000EB5A
		internal static bool __IsEmpty(IResolveHostListenerImplementor value)
		{
			return value.OnFailedHandler == null && value.OnResolveHandler == null;
		}

		// Token: 0x0400015C RID: 348
		private object sender;

		// Token: 0x0400015D RID: 349
		public EventHandler<FailedEventArgs> OnFailedHandler;

		// Token: 0x0400015E RID: 350
		public EventHandler<ResolveEventArgs> OnResolveHandler;
	}
}
