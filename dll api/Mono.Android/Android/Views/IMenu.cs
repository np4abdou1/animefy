using System;
using Android.Content;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Android.Views
{
	// Token: 0x0200011A RID: 282
	[Register("android/view/Menu", "", "Android.Views.IMenuInvoker")]
	public interface IMenu : IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x17000175 RID: 373
		// (get) Token: 0x06000763 RID: 1891
		bool HasVisibleItems { get; }

		// Token: 0x06000764 RID: 1892
		IMenuItem Add(int titleRes);

		// Token: 0x06000765 RID: 1893
		IMenuItem Add(int groupId, int itemId, int order, int titleRes);

		// Token: 0x06000766 RID: 1894
		IMenuItem Add(int groupId, int itemId, int order, ICharSequence title);

		// Token: 0x06000767 RID: 1895
		IMenuItem Add(ICharSequence title);

		// Token: 0x06000768 RID: 1896
		int AddIntentOptions(int groupId, int itemId, int order, ComponentName caller, Intent[] specifics, Intent intent, [GeneratedEnum] MenuAppendFlags flags, IMenuItem[] outSpecificItems);

		// Token: 0x06000769 RID: 1897
		ISubMenu AddSubMenu(int titleRes);

		// Token: 0x0600076A RID: 1898
		ISubMenu AddSubMenu(int groupId, int itemId, int order, int titleRes);

		// Token: 0x0600076B RID: 1899
		ISubMenu AddSubMenu(int groupId, int itemId, int order, ICharSequence title);

		// Token: 0x0600076C RID: 1900
		ISubMenu AddSubMenu(ICharSequence title);

		// Token: 0x0600076D RID: 1901
		void Clear();

		// Token: 0x0600076E RID: 1902
		void Close();

		// Token: 0x0600076F RID: 1903
		IMenuItem FindItem(int id);

		// Token: 0x06000770 RID: 1904
		IMenuItem GetItem(int index);

		// Token: 0x06000771 RID: 1905
		bool IsShortcutKey([GeneratedEnum] Keycode keyCode, KeyEvent e);

		// Token: 0x06000772 RID: 1906
		bool PerformIdentifierAction(int id, [GeneratedEnum] MenuPerformFlags flags);

		// Token: 0x06000773 RID: 1907
		bool PerformShortcut([GeneratedEnum] Keycode keyCode, KeyEvent e, [GeneratedEnum] MenuPerformFlags flags);

		// Token: 0x06000774 RID: 1908
		void RemoveGroup(int groupId);

		// Token: 0x06000775 RID: 1909
		void RemoveItem(int id);

		// Token: 0x06000776 RID: 1910
		void SetGroupCheckable(int group, bool checkable, bool exclusive);

		// Token: 0x06000777 RID: 1911
		void SetGroupEnabled(int group, bool enabled);

		// Token: 0x06000778 RID: 1912
		void SetGroupVisible(int group, bool visible);

		// Token: 0x06000779 RID: 1913
		void SetQwertyMode(bool isQwerty);

		// Token: 0x0600077A RID: 1914
		int Size();

		// Token: 0x0600077B RID: 1915 RVA: 0x0001159B File Offset: 0x0000F79B
		private static Delegate GetSetGroupDividerEnabled_ZHandler()
		{
			if (IMenu.cb_setGroupDividerEnabled_Z == null)
			{
				IMenu.cb_setGroupDividerEnabled_Z = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPZ_V(IMenu.n_SetGroupDividerEnabled_Z));
			}
			return IMenu.cb_setGroupDividerEnabled_Z;
		}

		// Token: 0x0600077C RID: 1916 RVA: 0x000115BF File Offset: 0x0000F7BF
		private static void n_SetGroupDividerEnabled_Z(IntPtr jnienv, IntPtr native__this, bool groupDividerEnabled)
		{
			Java.Lang.Object.GetObject<IMenu>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).SetGroupDividerEnabled(groupDividerEnabled);
		}

		// Token: 0x0600077D RID: 1917 RVA: 0x000115D0 File Offset: 0x0000F7D0
		unsafe void SetGroupDividerEnabled(bool groupDividerEnabled)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(groupDividerEnabled);
			IMenu._members.InstanceMethods.InvokeVirtualVoidMethod("setGroupDividerEnabled.(Z)V", this, ptr);
		}

		// Token: 0x04000202 RID: 514
		private static readonly JniPeerMembers _members = new XAPeerMembers("android/view/Menu", typeof(IMenu), true);

		// Token: 0x04000203 RID: 515
		private static Delegate cb_setGroupDividerEnabled_Z;
	}
}
