using System;
using Android.Runtime;
using Android.Views;
using Java.Interop;
using Java.Lang;

namespace Com.Unity3d.Services.Banners
{
	// Token: 0x020001AB RID: 427
	[Register("mono/com/unity3d/services/banners/IUnityBannerListenerImplementor")]
	internal sealed class IUnityBannerListenerImplementor : Java.Lang.Object, IUnityBannerListener, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x06001353 RID: 4947 RVA: 0x00036CB9 File Offset: 0x00034EB9
		public IUnityBannerListenerImplementor(object sender) : base(JNIEnv.StartCreateInstance("mono/com/unity3d/services/banners/IUnityBannerListenerImplementor", "()V", Array.Empty<JValue>()), JniHandleOwnership.TransferLocalRef)
		{
			JNIEnv.FinishCreateInstance(base.Handle, "()V", Array.Empty<JValue>());
			this.sender = sender;
		}

		// Token: 0x06001354 RID: 4948 RVA: 0x00036CF4 File Offset: 0x00034EF4
		public void OnUnityBannerClick(string p0)
		{
			EventHandler<UnityBannerClickEventArgs> onUnityBannerClickHandler = this.OnUnityBannerClickHandler;
			if (onUnityBannerClickHandler != null)
			{
				onUnityBannerClickHandler(this.sender, new UnityBannerClickEventArgs(p0));
			}
		}

		// Token: 0x06001355 RID: 4949 RVA: 0x00036D20 File Offset: 0x00034F20
		public void OnUnityBannerError(string p0)
		{
			EventHandler<UnityBannerErrorEventArgs> onUnityBannerErrorHandler = this.OnUnityBannerErrorHandler;
			if (onUnityBannerErrorHandler != null)
			{
				onUnityBannerErrorHandler(this.sender, new UnityBannerErrorEventArgs(p0));
			}
		}

		// Token: 0x06001356 RID: 4950 RVA: 0x00036D4C File Offset: 0x00034F4C
		public void OnUnityBannerHide(string p0)
		{
			EventHandler<UnityBannerHideEventArgs> onUnityBannerHideHandler = this.OnUnityBannerHideHandler;
			if (onUnityBannerHideHandler != null)
			{
				onUnityBannerHideHandler(this.sender, new UnityBannerHideEventArgs(p0));
			}
		}

		// Token: 0x06001357 RID: 4951 RVA: 0x00036D78 File Offset: 0x00034F78
		public void OnUnityBannerLoaded(string p0, View p1)
		{
			EventHandler<UnityBannerLoadedEventArgs> onUnityBannerLoadedHandler = this.OnUnityBannerLoadedHandler;
			if (onUnityBannerLoadedHandler != null)
			{
				onUnityBannerLoadedHandler(this.sender, new UnityBannerLoadedEventArgs(p0, p1));
			}
		}

		// Token: 0x06001358 RID: 4952 RVA: 0x00036DA4 File Offset: 0x00034FA4
		public void OnUnityBannerShow(string p0)
		{
			EventHandler<UnityBannerShowEventArgs> onUnityBannerShowHandler = this.OnUnityBannerShowHandler;
			if (onUnityBannerShowHandler != null)
			{
				onUnityBannerShowHandler(this.sender, new UnityBannerShowEventArgs(p0));
			}
		}

		// Token: 0x06001359 RID: 4953 RVA: 0x00036DD0 File Offset: 0x00034FD0
		public void OnUnityBannerUnloaded(string p0)
		{
			EventHandler<UnityBannerUnloadedEventArgs> onUnityBannerUnloadedHandler = this.OnUnityBannerUnloadedHandler;
			if (onUnityBannerUnloadedHandler != null)
			{
				onUnityBannerUnloadedHandler(this.sender, new UnityBannerUnloadedEventArgs(p0));
			}
		}

		// Token: 0x0600135A RID: 4954 RVA: 0x00036DF9 File Offset: 0x00034FF9
		internal static bool __IsEmpty(IUnityBannerListenerImplementor value)
		{
			return value.OnUnityBannerClickHandler == null && value.OnUnityBannerErrorHandler == null && value.OnUnityBannerHideHandler == null && value.OnUnityBannerLoadedHandler == null && value.OnUnityBannerShowHandler == null && value.OnUnityBannerUnloadedHandler == null;
		}

		// Token: 0x0400049A RID: 1178
		private object sender;

		// Token: 0x0400049B RID: 1179
		public EventHandler<UnityBannerClickEventArgs> OnUnityBannerClickHandler;

		// Token: 0x0400049C RID: 1180
		public EventHandler<UnityBannerErrorEventArgs> OnUnityBannerErrorHandler;

		// Token: 0x0400049D RID: 1181
		public EventHandler<UnityBannerHideEventArgs> OnUnityBannerHideHandler;

		// Token: 0x0400049E RID: 1182
		public EventHandler<UnityBannerLoadedEventArgs> OnUnityBannerLoadedHandler;

		// Token: 0x0400049F RID: 1183
		public EventHandler<UnityBannerShowEventArgs> OnUnityBannerShowHandler;

		// Token: 0x040004A0 RID: 1184
		public EventHandler<UnityBannerUnloadedEventArgs> OnUnityBannerUnloadedHandler;
	}
}
