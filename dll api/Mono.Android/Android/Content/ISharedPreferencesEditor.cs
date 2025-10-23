using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Android.Content
{
	// Token: 0x0200029C RID: 668
	[Register("android/content/SharedPreferences$Editor", "", "Android.Content.ISharedPreferencesEditorInvoker")]
	public interface ISharedPreferencesEditor : IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x06001997 RID: 6551
		void Apply();

		// Token: 0x06001998 RID: 6552
		ISharedPreferencesEditor Clear();

		// Token: 0x06001999 RID: 6553
		bool Commit();

		// Token: 0x0600199A RID: 6554
		ISharedPreferencesEditor PutBoolean(string key, bool value);

		// Token: 0x0600199B RID: 6555
		ISharedPreferencesEditor PutFloat(string key, float value);

		// Token: 0x0600199C RID: 6556
		ISharedPreferencesEditor PutInt(string key, int value);

		// Token: 0x0600199D RID: 6557
		ISharedPreferencesEditor PutLong(string key, long value);

		// Token: 0x0600199E RID: 6558
		ISharedPreferencesEditor PutString(string key, string value);

		// Token: 0x0600199F RID: 6559
		ISharedPreferencesEditor PutStringSet(string key, ICollection<string> values);

		// Token: 0x060019A0 RID: 6560
		ISharedPreferencesEditor Remove(string key);
	}
}
