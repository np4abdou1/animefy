using System;
using System.Collections.Specialized;
using System.IO;
using System.Net;
using AQ.Models;
using SQLite;

namespace AQ.ViewModels
{
	// Token: 0x0200000F RID: 15
	public class WatchHistoryViewModel
	{
		// Token: 0x0600005E RID: 94 RVA: 0x000051E8 File Offset: 0x000033E8
		public static void DeleteHistory(int userId, string animeId, float episode)
		{
			WatchHistoryViewModel.client = new WebClient();
			WatchHistoryViewModel.uri = new Uri(Constants.ApiPhp("library/history/history_delete.php"));
			WatchHistoryViewModel.parameters = new NameValueCollection();
			WatchHistoryViewModel.parameters.Add("UserId", userId.ToString());
			WatchHistoryViewModel.parameters.Add("AnimeId", animeId);
			WatchHistoryViewModel.parameters.Add("Episode", episode.ToString());
			WatchHistoryViewModel.parameters.Add("Token", "8cnY80AZSbUCmR26Vku1VUUY4");
			WatchHistoryViewModel.client.UploadValuesAsync(WatchHistoryViewModel.uri, WatchHistoryViewModel.parameters);
		}

		// Token: 0x0600005F RID: 95 RVA: 0x00005284 File Offset: 0x00003484
		public static void ClearAllHistory(int userId)
		{
			WatchHistoryViewModel.client = new WebClient();
			WatchHistoryViewModel.uri = new Uri(Constants.ApiPhp("library/history/history_clear_all.php"));
			WatchHistoryViewModel.parameters = new NameValueCollection();
			WatchHistoryViewModel.parameters.Add("UserId", userId.ToString());
			WatchHistoryViewModel.parameters.Add("Token", "8cnY80AZSbUCmR26Vku1VUUY4");
			WatchHistoryViewModel.client.UploadValuesAsync(WatchHistoryViewModel.uri, WatchHistoryViewModel.parameters);
		}

		// Token: 0x06000060 RID: 96 RVA: 0x000052F7 File Offset: 0x000034F7
		public static void localeHistoryPrepareTable()
		{
			WatchHistoryViewModel.localeHistoryDb.CreateTable<LocaleHistoryModel>(CreateFlags.None);
		}

		// Token: 0x06000061 RID: 97 RVA: 0x00005308 File Offset: 0x00003508
		public static void AddLocaleHistory(string animeID, float episode)
		{
			if (!WatchHistoryViewModel.IsLocaleHistoryExists(animeID, episode))
			{
				WatchHistoryViewModel.localeHistoryDb.CreateTable<LocaleHistoryModel>(CreateFlags.None);
				LocaleHistoryModel localeHistoryModel = new LocaleHistoryModel();
				localeHistoryModel.AnimeId = animeID;
				localeHistoryModel.Episode = episode;
				WatchHistoryViewModel.localeHistoryDb.Insert(localeHistoryModel);
				return;
			}
			WatchHistoryViewModel.DelLocaleHistory(animeID, episode);
		}

		// Token: 0x06000062 RID: 98 RVA: 0x00005354 File Offset: 0x00003554
		public static void DelLocaleHistory(string animeId, float episode)
		{
			LocaleHistoryModel localeHistoryModel = WatchHistoryViewModel.localeHistoryDb.FindWithQuery<LocaleHistoryModel>("SELECT * FROM EyeEpisodesTable WHERE AnimeId = ? AND Episode = ?", new object[]
			{
				animeId,
				episode
			});
			if (localeHistoryModel != null)
			{
				WatchHistoryViewModel.localeHistoryDb.Delete(localeHistoryModel);
			}
		}

		// Token: 0x06000063 RID: 99 RVA: 0x00005394 File Offset: 0x00003594
		public static bool IsLocaleHistoryExists(string animeId, float episode)
		{
			return WatchHistoryViewModel.localeHistoryDb.FindWithQuery<LocaleHistoryModel>("SELECT * FROM EyeEpisodesTable WHERE AnimeId = ? AND Episode = ?", new object[]
			{
				animeId,
				episode
			}) != null;
		}

		// Token: 0x04000080 RID: 128
		public static WebClient client;

		// Token: 0x04000081 RID: 129
		public static Uri uri;

		// Token: 0x04000082 RID: 130
		public static NameValueCollection parameters;

		// Token: 0x04000083 RID: 131
		public static string dbPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "AnimeifySchema.db3");

		// Token: 0x04000084 RID: 132
		public static SQLiteConnection localeHistoryDb = new SQLiteConnection(WatchHistoryViewModel.dbPath, true);
	}
}
