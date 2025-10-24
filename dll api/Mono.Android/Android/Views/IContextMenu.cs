using System;
using Android.Graphics.Drawables;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Android.Views
{
	// Token: 0x02000118 RID: 280
	[Register("android/view/ContextMenu", "", "Android.Views.IContextMenuInvoker")]
	public interface IContextMenu : IMenu, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x0600072B RID: 1835
		void ClearHeader();

		// Token: 0x0600072C RID: 1836
		IContextMenu SetHeaderIcon(Drawable icon);

		// Token: 0x0600072D RID: 1837
		IContextMenu SetHeaderIcon(int iconRes);

		// Token: 0x0600072E RID: 1838
		IContextMenu SetHeaderTitle(int titleRes);

		// Token: 0x0600072F RID: 1839
		IContextMenu SetHeaderTitle(ICharSequence title);

		// Token: 0x06000730 RID: 1840
		IContextMenu SetHeaderView(View view);
	}
}
