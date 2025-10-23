using System;
using Android.Content;
using Android.Util;
using Android.Views;
using Android.Widget;

namespace AQ.Sdks.Ok
{
	// Token: 0x02000050 RID: 80
	public class CustomFrameLayout : FrameLayout
	{
		// Token: 0x06000305 RID: 773 RVA: 0x0000DAFB File Offset: 0x0000BCFB
		public CustomFrameLayout(Context context, IAttributeSet attrs, int defStyle) : base(context, attrs, defStyle)
		{
		}

		// Token: 0x06000306 RID: 774 RVA: 0x0000DB06 File Offset: 0x0000BD06
		public CustomFrameLayout(Context context, IAttributeSet attrs) : base(context, attrs)
		{
		}

		// Token: 0x06000307 RID: 775 RVA: 0x0000E33D File Offset: 0x0000C53D
		public CustomFrameLayout(Context context, OkWebVideoView videoView) : base(context)
		{
			this.VideoView = videoView;
		}

		// Token: 0x06000308 RID: 776 RVA: 0x0000E34D File Offset: 0x0000C54D
		public override bool DispatchKeyEvent(KeyEvent e)
		{
			if (e.KeyCode == Keycode.Back && e.Action == KeyEventActions.Up)
			{
				this.VideoView.hideVideoView();
				return true;
			}
			return base.DispatchKeyEvent(e);
		}

		// Token: 0x040001B4 RID: 436
		private OkWebVideoView VideoView;
	}
}
