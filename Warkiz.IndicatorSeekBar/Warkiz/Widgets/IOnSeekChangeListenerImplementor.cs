using System;
using Android.Runtime;
using Java.Lang;

namespace Warkiz.Widgets
{
	// Token: 0x02000017 RID: 23
	[Register("mono/com/warkiz/widget/OnSeekChangeListenerImplementor")]
	internal sealed class IOnSeekChangeListenerImplementor : Java.Lang.Object, IOnSeekChangeListener, IJavaObject, IDisposable
	{
		// Token: 0x06000172 RID: 370 RVA: 0x0000616B File Offset: 0x0000436B
		public IOnSeekChangeListenerImplementor(object sender) : base(JNIEnv.StartCreateInstance("mono/com/warkiz/widget/OnSeekChangeListenerImplementor", "()V", Array.Empty<JValue>()), JniHandleOwnership.TransferLocalRef)
		{
			JNIEnv.FinishCreateInstance(base.Handle, "()V", Array.Empty<JValue>());
			this.sender = sender;
		}

		// Token: 0x06000173 RID: 371 RVA: 0x000061A4 File Offset: 0x000043A4
		public void OnSeeking(SeekParams seekParams)
		{
			EventHandler<SeekingEventArgs> onSeekingHandler = this.OnSeekingHandler;
			if (onSeekingHandler != null)
			{
				onSeekingHandler(this.sender, new SeekingEventArgs(seekParams));
			}
		}

		// Token: 0x06000174 RID: 372 RVA: 0x000061D0 File Offset: 0x000043D0
		public void OnStartTrackingTouch(IndicatorSeekBar seekBar)
		{
			EventHandler<StartTrackingTouchEventArgs> onStartTrackingTouchHandler = this.OnStartTrackingTouchHandler;
			if (onStartTrackingTouchHandler != null)
			{
				onStartTrackingTouchHandler(this.sender, new StartTrackingTouchEventArgs(seekBar));
			}
		}

		// Token: 0x06000175 RID: 373 RVA: 0x000061FC File Offset: 0x000043FC
		public void OnStopTrackingTouch(IndicatorSeekBar seekBar)
		{
			EventHandler<StopTrackingTouchEventArgs> onStopTrackingTouchHandler = this.OnStopTrackingTouchHandler;
			if (onStopTrackingTouchHandler != null)
			{
				onStopTrackingTouchHandler(this.sender, new StopTrackingTouchEventArgs(seekBar));
			}
		}

		// Token: 0x06000176 RID: 374 RVA: 0x00006225 File Offset: 0x00004425
		internal static bool __IsEmpty(IOnSeekChangeListenerImplementor value)
		{
			return value.OnSeekingHandler == null && value.OnStartTrackingTouchHandler == null && value.OnStopTrackingTouchHandler == null;
		}

		// Token: 0x0400007D RID: 125
		private object sender;

		// Token: 0x0400007E RID: 126
		public EventHandler<SeekingEventArgs> OnSeekingHandler;

		// Token: 0x0400007F RID: 127
		public EventHandler<StartTrackingTouchEventArgs> OnStartTrackingTouchHandler;

		// Token: 0x04000080 RID: 128
		public EventHandler<StopTrackingTouchEventArgs> OnStopTrackingTouchHandler;
	}
}
