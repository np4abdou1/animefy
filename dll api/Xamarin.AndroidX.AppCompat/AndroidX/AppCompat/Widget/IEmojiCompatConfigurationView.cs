using System;
using Android.Runtime;
using Java.Interop;

namespace AndroidX.AppCompat.Widget
{
	// Token: 0x02000068 RID: 104
	[Register("androidx/appcompat/widget/EmojiCompatConfigurationView", "", "AndroidX.AppCompat.Widget.IEmojiCompatConfigurationViewInvoker")]
	public interface IEmojiCompatConfigurationView : IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x1700010A RID: 266
		// (get) Token: 0x06000780 RID: 1920
		// (set) Token: 0x06000781 RID: 1921
		bool EmojiCompatEnabled { [Register("isEmojiCompatEnabled", "()Z", "GetIsEmojiCompatEnabledHandler:AndroidX.AppCompat.Widget.IEmojiCompatConfigurationViewInvoker, Xamarin.AndroidX.AppCompat")] get; [Register("setEmojiCompatEnabled", "(Z)V", "GetSetEmojiCompatEnabled_ZHandler:AndroidX.AppCompat.Widget.IEmojiCompatConfigurationViewInvoker, Xamarin.AndroidX.AppCompat")] set; }
	}
}
