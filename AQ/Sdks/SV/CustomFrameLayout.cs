using System;
using Android.Content;
using Android.Util;
using Android.Views;
using Android.Widget;

namespace AQ.Sdks.SV
{
	// Token: 0x0200004C RID: 76
	public class CustomFrameLayout : FrameLayout
	{
		// Token: 0x060002EA RID: 746 RVA: 0x0000DAFB File Offset: 0x0000BCFB
		public CustomFrameLayout(Context context, IAttributeSet attrs, int defStyle) : base(context, attrs, defStyle)
		{
		}

		// Token: 0x060002EB RID: 747 RVA: 0x0000DB06 File Offset: 0x0000BD06
		public CustomFrameLayout(Context context, IAttributeSet attrs) : base(context, attrs)
		{
		}

		// Token: 0x060002EC RID: 748 RVA: 0x0000DF35 File Offset: 0x0000C135
		public CustomFrameLayout(Context context, SVWebVideoView videoView) : base(context)
		{
			this.VideoView = videoView;
		}

		// Token: 0x060002ED RID: 749 RVA: 0x0000DF45 File Offset: 0x0000C145
		public override bool DispatchKeyEvent(KeyEvent e)
		{
			if (e.KeyCode == Keycode.Back && e.Action == KeyEventActions.Up)
			{
				this.VideoView.hideVideoView();
				return true;
			}
			return base.DispatchKeyEvent(e);
		}

		// Token: 0x040001A7 RID: 423
		private SVWebVideoView VideoView;
	}
}
