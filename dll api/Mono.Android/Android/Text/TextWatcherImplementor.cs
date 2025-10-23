using System;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Android.Text
{
	// Token: 0x020001C0 RID: 448
	[Register("mono/android/text/TextWatcherImplementor")]
	internal sealed class TextWatcherImplementor : Java.Lang.Object, ITextWatcher, INoCopySpan, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x06001027 RID: 4135 RVA: 0x0002A360 File Offset: 0x00028560
		public TextWatcherImplementor(object inst, EventHandler<TextChangedEventArgs> changed_handler, EventHandler<TextChangedEventArgs> before_handler, EventHandler<AfterTextChangedEventArgs> after_handler) : base(JNIEnv.StartCreateInstance("mono/android/text/TextWatcherImplementor", "()V", Array.Empty<JValue>()), JniHandleOwnership.TransferLocalRef)
		{
			JNIEnv.FinishCreateInstance(base.Handle, "()V", Array.Empty<JValue>());
			this.inst = inst;
			this.AfterTextChanged = after_handler;
			this.BeforeTextChanged = before_handler;
			this.TextChanged = changed_handler;
		}

		// Token: 0x06001028 RID: 4136 RVA: 0x0002A3BC File Offset: 0x000285BC
		void ITextWatcher.AfterTextChanged(IEditable s)
		{
			EventHandler<AfterTextChangedEventArgs> afterTextChanged = this.AfterTextChanged;
			if (afterTextChanged != null)
			{
				afterTextChanged(this.inst, new AfterTextChangedEventArgs(s));
			}
		}

		// Token: 0x06001029 RID: 4137 RVA: 0x0002A3E8 File Offset: 0x000285E8
		void ITextWatcher.BeforeTextChanged(ICharSequence s, int start, int before, int after)
		{
			EventHandler<TextChangedEventArgs> beforeTextChanged = this.BeforeTextChanged;
			if (beforeTextChanged != null)
			{
				beforeTextChanged(this.inst, new TextChangedEventArgs(s, start, before, after));
			}
		}

		// Token: 0x0600102A RID: 4138 RVA: 0x0002A418 File Offset: 0x00028618
		void ITextWatcher.OnTextChanged(ICharSequence s, int start, int before, int count)
		{
			EventHandler<TextChangedEventArgs> textChanged = this.TextChanged;
			if (textChanged != null)
			{
				textChanged(this.inst, new TextChangedEventArgs(s, start, before, count));
			}
		}

		// Token: 0x04000772 RID: 1906
		private object inst;

		// Token: 0x04000773 RID: 1907
		public EventHandler<AfterTextChangedEventArgs> AfterTextChanged;

		// Token: 0x04000774 RID: 1908
		public EventHandler<TextChangedEventArgs> BeforeTextChanged;

		// Token: 0x04000775 RID: 1909
		public EventHandler<TextChangedEventArgs> TextChanged;
	}
}
