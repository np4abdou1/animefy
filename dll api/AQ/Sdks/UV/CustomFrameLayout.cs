using System;
using Android.Content;
using Android.Util;
using Android.Views;
using Android.Widget;

namespace AQ.Sdks.UV
{
	// Token: 0x02000048 RID: 72
	public class CustomFrameLayout : FrameLayout
	{
		// Token: 0x060002CF RID: 719 RVA: 0x0000DAFB File Offset: 0x0000BCFB
		public CustomFrameLayout(Context context, IAttributeSet attrs, int defStyle) : base(context, attrs, defStyle)
		{
		}

		// Token: 0x060002D0 RID: 720 RVA: 0x0000DB06 File Offset: 0x0000BD06
		public CustomFrameLayout(Context context, IAttributeSet attrs) : base(context, attrs)
		{
		}

		// Token: 0x060002D1 RID: 721 RVA: 0x0000DB10 File Offset: 0x0000BD10
		public CustomFrameLayout(Context context, UVWebVideoView videoView) : base(context)
		{
			this.VideoView = videoView;
		}

		// Token: 0x060002D2 RID: 722 RVA: 0x0000DB20 File Offset: 0x0000BD20
		public override bool DispatchKeyEvent(KeyEvent e)
		{
			if (e.KeyCode == Keycode.Back && e.Action == KeyEventActions.Up)
			{
				this.VideoView.hideVideoView();
				return true;
			}
			return base.DispatchKeyEvent(e);
		}

		// Token: 0x0400019A RID: 410
		private UVWebVideoView VideoView;
	}
}
