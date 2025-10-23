using System;
using Android.Content.Res;
using Android.Runtime;
using Java.Interop;

namespace Android.Widget
{
	// Token: 0x020000D8 RID: 216
	[Register("android/widget/ThemedSpinnerAdapter", "", "Android.Widget.IThemedSpinnerAdapterInvoker", ApiSince = 23)]
	public interface IThemedSpinnerAdapter : ISpinnerAdapter, IAdapter, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x170000B5 RID: 181
		// (get) Token: 0x0600049B RID: 1179
		// (set) Token: 0x0600049C RID: 1180
		Resources.Theme DropDownViewTheme { get; set; }
	}
}
