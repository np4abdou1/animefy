using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Android.Content
{
	// Token: 0x020002A0 RID: 672
	[Register("android/content/SharedPreferences", "", "Android.Content.ISharedPreferencesInvoker")]
	public interface ISharedPreferences : IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x1700058A RID: 1418
		// (get) Token: 0x060019D3 RID: 6611
		IDictionary<string, object> All { get; }

		// Token: 0x060019D4 RID: 6612
		bool Contains(string key);

		// Token: 0x060019D5 RID: 6613
		ISharedPreferencesEditor Edit();

		// Token: 0x060019D6 RID: 6614
		bool GetBoolean(string key, bool defValue);

		// Token: 0x060019D7 RID: 6615
		float GetFloat(string key, float defValue);

		// Token: 0x060019D8 RID: 6616
		int GetInt(string key, int defValue);

		// Token: 0x060019D9 RID: 6617
		long GetLong(string key, long defValue);

		// Token: 0x060019DA RID: 6618
		string GetString(string key, string defValue);

		// Token: 0x060019DB RID: 6619
		ICollection<string> GetStringSet(string key, ICollection<string> defValues);

		// Token: 0x060019DC RID: 6620
		void RegisterOnSharedPreferenceChangeListener(ISharedPreferencesOnSharedPreferenceChangeListener listener);

		// Token: 0x060019DD RID: 6621
		void UnregisterOnSharedPreferenceChangeListener(ISharedPreferencesOnSharedPreferenceChangeListener listener);
	}
}
