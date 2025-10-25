using System;
using Android.Content;
using Android.Util;
using Android.Views;
using Android.Widget;

namespace AQ.Sdks.MA
{
	// Token: 0x02000054 RID: 84
	public class CustomFrameLayout : FrameLayout
	{
		// Token: 0x0600031F RID: 799 RVA: 0x0000DAFB File Offset: 0x0000BCFB
		public CustomFrameLayout(Context context, IAttributeSet attrs, int defStyle) : base(context, attrs, defStyle)
		{
		}

		// Token: 0x06000320 RID: 800 RVA: 0x0000DB06 File Offset: 0x0000BD06
		public CustomFrameLayout(Context context, IAttributeSet attrs) : base(context, attrs)
		{
		}

		// Token: 0x06000321 RID: 801 RVA: 0x0000E6A1 File Offset: 0x0000C8A1
		public CustomFrameLayout(Context context, MaWebVideoView videoView) : base(context)
		{
			this.VideoView = videoView;
		}

		// Token: 0x06000322 RID: 802 RVA: 0x0000E6B1 File Offset: 0x0000C8B1
		public override bool DispatchKeyEvent(KeyEvent e)
		{
			if (e.KeyCode == Keycode.Back && e.Action == KeyEventActions.Up)
			{
				this.VideoView.hideVideoView();
				return true;
			}
			return base.DispatchKeyEvent(e);
		}

		// Token: 0x040001C1 RID: 449
		private MaWebVideoView VideoView;
	}
}
