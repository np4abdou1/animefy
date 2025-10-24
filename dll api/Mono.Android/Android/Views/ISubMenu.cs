using System;
using Android.Graphics.Drawables;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Android.Views
{
	// Token: 0x02000125 RID: 293
	[Register("android/view/SubMenu", "", "Android.Views.ISubMenuInvoker")]
	public interface ISubMenu : IMenu, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x170001BB RID: 443
		// (get) Token: 0x060008DA RID: 2266
		IMenuItem Item { get; }

		// Token: 0x060008DB RID: 2267
		void ClearHeader();

		// Token: 0x060008DC RID: 2268
		ISubMenu SetHeaderIcon(Drawable icon);

		// Token: 0x060008DD RID: 2269
		ISubMenu SetHeaderIcon(int iconRes);

		// Token: 0x060008DE RID: 2270
		ISubMenu SetHeaderTitle(int titleRes);

		// Token: 0x060008DF RID: 2271
		ISubMenu SetHeaderTitle(ICharSequence title);

		// Token: 0x060008E0 RID: 2272
		ISubMenu SetHeaderView(View view);

		// Token: 0x060008E1 RID: 2273
		ISubMenu SetIcon(Drawable icon);

		// Token: 0x060008E2 RID: 2274
		ISubMenu SetIcon(int iconRes);
	}
}
