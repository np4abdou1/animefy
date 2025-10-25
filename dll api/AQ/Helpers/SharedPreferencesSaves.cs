using System;
using Android.App;
using Android.Content;

namespace AQ.Helpers
{
	// Token: 0x02000097 RID: 151
	public class SharedPreferencesSaves
	{
		// Token: 0x0600069C RID: 1692 RVA: 0x00013C10 File Offset: 0x00011E10
		public static void IntSharedPreferencesSave(string dateKey, int dataValue)
		{
			ISharedPreferencesEditor sharedPreferencesEditor = SharedPreferencesSaves.AppSharedPreferences.Edit();
			sharedPreferencesEditor.PutInt(dateKey, dataValue);
			sharedPreferencesEditor.Commit();
		}

		// Token: 0x0600069D RID: 1693 RVA: 0x00013C38 File Offset: 0x00011E38
		public static int IntSharedPreferencesGet(string dateKey)
		{
			return SharedPreferencesSaves.AppSharedPreferences.GetInt(dateKey, 0);
		}

		// Token: 0x0600069E RID: 1694 RVA: 0x00013C48 File Offset: 0x00011E48
		public static void StringSharedPreferencesSave(string dateKey, string dataValue)
		{
			ISharedPreferencesEditor sharedPreferencesEditor = SharedPreferencesSaves.AppSharedPreferences.Edit();
			sharedPreferencesEditor.PutString(dateKey, dataValue);
			sharedPreferencesEditor.Commit();
		}

		// Token: 0x0600069F RID: 1695 RVA: 0x00013C70 File Offset: 0x00011E70
		public static string StringSharedPreferencesGet(string dateKey)
		{
			return SharedPreferencesSaves.AppSharedPreferences.GetString(dateKey, null);
		}

		// Token: 0x04000353 RID: 851
		public static ISharedPreferences AppSharedPreferences = Application.Context.GetSharedPreferences("AppSharedPreferences", FileCreationMode.Private);
	}
}
