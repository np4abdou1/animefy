using System;

namespace Warkiz.Widgets
{
	// Token: 0x02000016 RID: 22
	public class StopTrackingTouchEventArgs : EventArgs
	{
		// Token: 0x06000170 RID: 368 RVA: 0x00006154 File Offset: 0x00004354
		public StopTrackingTouchEventArgs(IndicatorSeekBar seekBar)
		{
			this.seekBar = seekBar;
		}

		// Token: 0x1700002C RID: 44
		// (get) Token: 0x06000171 RID: 369 RVA: 0x00006163 File Offset: 0x00004363
		public IndicatorSeekBar SeekBar
		{
			get
			{
				return this.seekBar;
			}
		}

		// Token: 0x0400007C RID: 124
		private IndicatorSeekBar seekBar;
	}
}
