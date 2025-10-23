using System;
using Android.Runtime;
using Java.Interop;

namespace Android.Widget
{
	// Token: 0x020000CB RID: 203
	[Register("android/widget/Checkable", "", "Android.Widget.ICheckableInvoker")]
	public interface ICheckable : IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x1700008C RID: 140
		// (get) Token: 0x06000426 RID: 1062
		// (set) Token: 0x06000427 RID: 1063
		bool Checked { get; set; }

		// Token: 0x06000428 RID: 1064
		void Toggle();
	}
}
