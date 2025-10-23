using System;
using Android.Runtime;

namespace Warkiz.Widgets
{
	// Token: 0x02000012 RID: 18
	[Register("com/warkiz/widget/OnSeekChangeListener", "", "Warkiz.Widgets.IOnSeekChangeListenerInvoker")]
	public interface IOnSeekChangeListener : IJavaObject, IDisposable
	{
		// Token: 0x06000157 RID: 343
		[Register("onSeeking", "(Lcom/warkiz/widget/SeekParams;)V", "GetOnSeeking_Lcom_warkiz_widget_SeekParams_Handler:Warkiz.Widgets.IOnSeekChangeListenerInvoker, Warkiz.IndicatorSeekBar")]
		void OnSeeking(SeekParams seekParams);

		// Token: 0x06000158 RID: 344
		[Register("onStartTrackingTouch", "(Lcom/warkiz/widget/IndicatorSeekBar;)V", "GetOnStartTrackingTouch_Lcom_warkiz_widget_IndicatorSeekBar_Handler:Warkiz.Widgets.IOnSeekChangeListenerInvoker, Warkiz.IndicatorSeekBar")]
		void OnStartTrackingTouch(IndicatorSeekBar seekBar);

		// Token: 0x06000159 RID: 345
		[Register("onStopTrackingTouch", "(Lcom/warkiz/widget/IndicatorSeekBar;)V", "GetOnStopTrackingTouch_Lcom_warkiz_widget_IndicatorSeekBar_Handler:Warkiz.Widgets.IOnSeekChangeListenerInvoker, Warkiz.IndicatorSeekBar")]
		void OnStopTrackingTouch(IndicatorSeekBar seekBar);
	}
}
