using System;
using Android.Content;
using Android.Util;
using Android.Views;
using Android.Widget;

namespace AQ.Sdks.LB
{
	// Token: 0x02000058 RID: 88
	public class CustomFrameLayout : FrameLayout
	{
		// Token: 0x0600033A RID: 826 RVA: 0x0000DAFB File Offset: 0x0000BCFB
		public CustomFrameLayout(Context context, IAttributeSet attrs, int defStyle) : base(context, attrs, defStyle)
		{
		}

		// Token: 0x0600033B RID: 827 RVA: 0x0000DB06 File Offset: 0x0000BD06
		public CustomFrameLayout(Context context, IAttributeSet attrs) : base(context, attrs)
		{
		}

		// Token: 0x0600033C RID: 828 RVA: 0x0000EAA9 File Offset: 0x0000CCA9
		public CustomFrameLayout(Context context, LBWebVideoView videoView) : base(context)
		{
			this.VideoView = videoView;
		}

		// Token: 0x0600033D RID: 829 RVA: 0x0000EAB9 File Offset: 0x0000CCB9
		public override bool DispatchKeyEvent(KeyEvent e)
		{
			if (e.KeyCode == Keycode.Back && e.Action == KeyEventActions.Up)
			{
				this.VideoView.hideVideoView();
				return true;
			}
			return base.DispatchKeyEvent(e);
		}

		// Token: 0x040001CE RID: 462
		private LBWebVideoView VideoView;
	}
}
