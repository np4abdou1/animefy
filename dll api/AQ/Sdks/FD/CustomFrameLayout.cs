using System;
using Android.Content;
using Android.Util;
using Android.Views;
using Android.Widget;

namespace AQ.Sdks.FD
{
	// Token: 0x0200005C RID: 92
	public class CustomFrameLayout : FrameLayout
	{
		// Token: 0x06000355 RID: 853 RVA: 0x0000DAFB File Offset: 0x0000BCFB
		public CustomFrameLayout(Context context, IAttributeSet attrs, int defStyle) : base(context, attrs, defStyle)
		{
		}

		// Token: 0x06000356 RID: 854 RVA: 0x0000DB06 File Offset: 0x0000BD06
		public CustomFrameLayout(Context context, IAttributeSet attrs) : base(context, attrs)
		{
		}

		// Token: 0x06000357 RID: 855 RVA: 0x0000EEB1 File Offset: 0x0000D0B1
		public CustomFrameLayout(Context context, FDWebVideoView videoView) : base(context)
		{
			this.VideoView = videoView;
		}

		// Token: 0x06000358 RID: 856 RVA: 0x0000EEC1 File Offset: 0x0000D0C1
		public override bool DispatchKeyEvent(KeyEvent e)
		{
			if (e.KeyCode == Keycode.Back && e.Action == KeyEventActions.Up)
			{
				this.VideoView.hideVideoView();
				return true;
			}
			return base.DispatchKeyEvent(e);
		}

		// Token: 0x040001DB RID: 475
		private FDWebVideoView VideoView;
	}
}
