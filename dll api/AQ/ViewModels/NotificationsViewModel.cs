using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.IO;
using System.Net;
using System.Text;
using Android.App;
using Android.Content;
using Android.OS;
using AndroidX.Core.App;
using AQ.Activities;
using AQ.Helpers;
using AQ.Models;
using Java.Lang;
using Newtonsoft.Json;
using SQLite;

namespace AQ.ViewModels
{
	// Token: 0x0200000D RID: 13
	public class NotificationsViewModel
	{
		// Token: 0x06000049 RID: 73 RVA: 0x00004B03 File Offset: 0x00002D03
		public static void NotifPrepareTable()
		{
			NotificationsViewModel.db.CreateTable<NotificationsModel>(CreateFlags.None);
		}

		// Token: 0x0600004A RID: 74 RVA: 0x00004B14 File Offset: 0x00002D14
		public static void InitializeNewNotif(string animeID, string animeTitle, int epCount)
		{
			if (!NotificationsViewModel.IsNotifExist(animeID))
			{
				NotificationsModel notificationsModel = new NotificationsModel();
				notificationsModel.AnimeID = animeID;
				notificationsModel.AnimeTitle = animeTitle;
				notificationsModel.EpisodesCount = epCount;
				NotificationsViewModel.db.Insert(notificationsModel);
			}
		}

		// Token: 0x0600004B RID: 75 RVA: 0x00004B50 File Offset: 0x00002D50
		public static List<NotificationsModel> GetAllNotifications()
		{
			return NotificationsViewModel.db.Query<NotificationsModel>("SELECT * FROM NotificationsTable", Array.Empty<object>());
		}

		// Token: 0x0600004C RID: 76 RVA: 0x00004B74 File Offset: 0x00002D74
		public static bool IsNotifExist(string animeID)
		{
			return NotificationsViewModel.db.FindWithQuery<NotificationsModel>("SELECT * FROM NotificationsTable WHERE AnimeID = ?", new object[]
			{
				animeID
			}) != null;
		}

		// Token: 0x0600004D RID: 77 RVA: 0x00004BA4 File Offset: 0x00002DA4
		public static void UpdateNotif(string animeID, int newEpisodeCount)
		{
			List<NotificationsModel> list = NotificationsViewModel.db.Query<NotificationsModel>("SELECT * FROM NotificationsTable WHERE AnimeID = ?", new object[]
			{
				animeID
			});
			foreach (NotificationsModel notificationsModel in list)
			{
				notificationsModel.EpisodesCount = newEpisodeCount;
				NotificationsViewModel.db.Update(notificationsModel);
			}
		}

		// Token: 0x0600004E RID: 78 RVA: 0x00004C18 File Offset: 0x00002E18
		public static void DelNotif(string animeID)
		{
			List<NotificationsModel> list = NotificationsViewModel.db.Query<NotificationsModel>("SELECT * FROM NotificationsTable WHERE AnimeID = ?", new object[]
			{
				animeID
			});
			foreach (NotificationsModel objectToDelete in list)
			{
				NotificationsViewModel.db.Delete(objectToDelete);
			}
		}

		// Token: 0x0600004F RID: 79 RVA: 0x00004C88 File Offset: 0x00002E88
		public static void ClearAll()
		{
			List<NotificationsModel> list = NotificationsViewModel.db.Query<NotificationsModel>("SELECT * FROM NotificationsTable", Array.Empty<object>());
			foreach (NotificationsModel objectToDelete in list)
			{
				NotificationsViewModel.db.Delete(objectToDelete);
			}
		}

		// Token: 0x06000050 RID: 80 RVA: 0x00004CF0 File Offset: 0x00002EF0
		public static void CheckForNewEpisodes(Context context)
		{
			if (SharedPreferencesSaves.StringSharedPreferencesGet("Notification") == "OFF")
			{
				return;
			}
			NotificationsViewModel.PushNotificationAsync pushNotificationAsync = new NotificationsViewModel.PushNotificationAsync();
			pushNotificationAsync.Execute(new Context[]
			{
				context
			});
		}

		// Token: 0x06000051 RID: 81 RVA: 0x00004D2C File Offset: 0x00002F2C
		public static void PushNotification(Context context, string animeId, string animeTitle, int episode)
		{
			Bundle bundle = new Bundle();
			bundle.PutString("AnimeId", animeId);
			bundle.PutString("Title", animeTitle);
			bundle.PutBoolean("IsNotification", true);
			Intent intent = new Intent(context, typeof(EpisodesActivity));
			intent.PutExtras(bundle);
			TaskStackBuilder taskStackBuilder = TaskStackBuilder.Create(context);
			taskStackBuilder.AddParentStack(Class.FromType(typeof(EpisodesActivity)));
			taskStackBuilder.AddNextIntent(intent);
			PendingIntent pendingIntent = taskStackBuilder.GetPendingIntent(NotificationsViewModel.count++, 134217728);
			NotificationCompat.BigPictureStyle bigPictureStyle = new NotificationCompat.BigPictureStyle();
			bigPictureStyle.BigPicture(BitmapStreamer.GetBitmapB("NOTIFCATION_COVER_URL"));
			bigPictureStyle.SetSummaryText("الحلقة " + episode.ToString() + " إضغط للمشاهدة");
			NotificationCompat.Builder builder = new NotificationCompat.Builder(context, NotificationsModel.EPISODE_CHANNEL_ID).SetAutoCancel(true).SetContentIntent(pendingIntent).SetContentTitle(animeTitle).SetSmallIcon(2131231135).SetStyle(bigPictureStyle).SetContentText("الحلقة " + episode.ToString() + " إضغط للمشاهدة");
			NotificationManagerCompat notificationManagerCompat = NotificationManagerCompat.From(context);
			notificationManagerCompat.Notify(NotificationsViewModel.count++, builder.Build());
		}

		// Token: 0x06000052 RID: 82 RVA: 0x00004E60 File Offset: 0x00003060
		public static void CreateNotificationChannel(Context context, string channelName, string channelDescription)
		{
			if (Build.VERSION.SdkInt < BuildVersionCodes.O)
			{
				return;
			}
			NotificationChannel channel = new NotificationChannel(NotificationsModel.EPISODE_CHANNEL_ID, channelName, NotificationImportance.Default)
			{
				Description = channelDescription
			};
			NotificationManager notificationManager = (NotificationManager)context.GetSystemService("notification");
			notificationManager.CreateNotificationChannel(channel);
		}

		// Token: 0x06000053 RID: 83 RVA: 0x00004EA4 File Offset: 0x000030A4
		public static void CreateNotificationChannel(Context context)
		{
			if (Build.VERSION.SdkInt < BuildVersionCodes.O)
			{
				return;
			}
			NotificationChannel channel = new NotificationChannel(NotificationsViewModel.CHANNEL_ID, "Animeify", NotificationImportance.Default)
			{
				Description = "Animeify Notifications"
			};
			NotificationManager notificationManager = (NotificationManager)context.GetSystemService("notification");
			notificationManager.CreateNotificationChannel(channel);
		}

		// Token: 0x04000076 RID: 118
		public static WebClient client;

		// Token: 0x04000077 RID: 119
		public static Uri uri;

		// Token: 0x04000078 RID: 120
		public static NameValueCollection parameters;

		// Token: 0x04000079 RID: 121
		internal static readonly string CHANNEL_ID = "EpisodesNotificationChannal";

		// Token: 0x0400007A RID: 122
		internal static readonly int NOTIFICATION_ID = 100;

		// Token: 0x0400007B RID: 123
		public static int count;

		// Token: 0x0400007C RID: 124
		public static string dbPath = Path.Combine(System.Environment.GetFolderPath(System.Environment.SpecialFolder.MyDocuments), "AnimeifySchema.db3");

		// Token: 0x0400007D RID: 125
		public static SQLiteConnection db = new SQLiteConnection(NotificationsViewModel.dbPath, true);

		// Token: 0x020000FB RID: 251
		public class PushNotificationAsync : AsyncTask<Context, string, string>
		{
			// Token: 0x06000B0B RID: 2827 RVA: 0x0003C004 File Offset: 0x0003A204
			protected override string RunInBackground(params Context[] @params)
			{
				NotificationsViewModel.count = 1;
				List<NotificationsModel> allNotifications = NotificationsViewModel.GetAllNotifications();
				using (List<NotificationsModel>.Enumerator enumerator = allNotifications.GetEnumerator())
				{
					while (enumerator.MoveNext())
					{
						NotificationsModel notif = enumerator.Current;
						NotificationsViewModel.client = new WebClient();
						NotificationsViewModel.uri = new Uri(Constants.ApiPhp("notifications.php"));
						NotificationsViewModel.parameters = new NameValueCollection();
						NotificationsViewModel.parameters.Add("AnimeID", notif.AnimeID);
						NotificationsViewModel.client.UploadValuesAsync(NotificationsViewModel.uri, NotificationsViewModel.parameters);
						NotificationsViewModel.client.UploadValuesCompleted += delegate(object sender, UploadValuesCompletedEventArgs e)
						{
							try
							{
								string @string = Encoding.UTF8.GetString(e.Result);
								NotificationsModel notificationsModel = JsonConvert.DeserializeObject<NotificationsModel>(@string);
								if (notificationsModel.Status == 0)
								{
									NotificationsViewModel.DelNotif(notif.AnimeID);
								}
								if (notificationsModel.EpisodesCount > notif.EpisodesCount)
								{
									NotificationsViewModel.UpdateNotif(notif.AnimeID, notificationsModel.EpisodesCount);
									NotificationsViewModel.PushNotification(@params[0], notif.AnimeID, notif.AnimeTitle, notificationsModel.EpisodesCount);
								}
							}
							catch
							{
							}
						};
					}
				}
				return "";
			}
		}
	}
}
