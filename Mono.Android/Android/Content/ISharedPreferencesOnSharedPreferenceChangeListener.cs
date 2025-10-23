using System;
using Android.Runtime;
using Java.Interop;

namespace Android.Content
{
	// Token: 0x0200029E RID: 670
	[Register("android/content/SharedPreferences$OnSharedPreferenceChangeListener", "", "Android.Content.ISharedPreferencesOnSharedPreferenceChangeListenerInvoker")]
	public interface ISharedPreferencesOnSharedPreferenceChangeListener : IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x060019C7 RID: 6599
		void OnSharedPreferenceChanged(ISharedPreferences sharedPreferences, string key);
	}
}
