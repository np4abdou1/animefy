using System;

namespace Warkiz.Widgets
{
	// Token: 0x02000015 RID: 21
	public class StartTrackingTouchEventArgs : EventArgs
	{
		// Token: 0x0600016E RID: 366 RVA: 0x0000613D File Offset: 0x0000433D
		public StartTrackingTouchEventArgs(IndicatorSeekBar seekBar)
		{
			this.seekBar = seekBar;
		}

		// Token: 0x1700002B RID: 43
		// (get) Token: 0x0600016F RID: 367 RVA: 0x0000614C File Offset: 0x0000434C
		public IndicatorSeekBar SeekBar
		{
			get
			{
				return this.seekBar;
			}
		}

		// Token: 0x0400007B RID: 123
		private IndicatorSeekBar seekBar;
	}
}
