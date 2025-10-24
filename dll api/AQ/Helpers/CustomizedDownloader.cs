using System;
using System.IO;
using System.Net;
using Android.App;
using Android.Content.PM;
using Android.Net;
using Android.OS;
using AndroidX.Core.App;

namespace AQ.Helpers
{
	// Token: 0x0200008C RID: 140
	public class CustomizedDownloader
	{
		// Token: 0x0600066E RID: 1646 RVA: 0x00011788 File Offset: 0x0000F988
		public static void Download(Activity activity, string link, string fileName, string title, string folderName, string description)
		{
			if (Build.VERSION.SdkInt >= BuildVersionCodes.M)
			{
				if (activity.CheckSelfPermission("android.permission.WRITE_EXTERNAL_STORAGE") == Permission.Granted)
				{
					CustomizedToast.ShowToast(activity, activity.Resources.GetString(2131951882), 0);
				}
				else
				{
					ActivityCompat.RequestPermissions(activity, new string[]
					{
						"android.permission.WRITE_EXTERNAL_STORAGE"
					}, 1);
				}
			}
			try
			{
				Android.OS.Environment.GetExternalStoragePublicDirectory(Android.OS.Environment.DirectoryDownloads).Mkdirs();
				Android.Net.Uri uri = Android.Net.Uri.Parse(link);
				DownloadManager downloadManager = (DownloadManager)activity.GetSystemService("download");
				DownloadManager.Request request = new DownloadManager.Request(uri);
				request.SetAllowedNetworkTypes((DownloadNetwork)3);
				request.SetTitle(title);
				request.SetDescription(description);
				if (Build.VERSION.SdkInt >= BuildVersionCodes.Honeycomb)
				{
					request.AllowScanningByMediaScanner();
					request.SetNotificationVisibility(DownloadVisibility.VisibleNotifyCompleted);
				}
				request.SetVisibleInDownloadsUi(true);
				request.SetDestinationInExternalPublicDir(Android.OS.Environment.DirectoryDownloads + "/Animeify/" + folderName, fileName);
				downloadManager.Enqueue(request);
			}
			catch
			{
			}
		}

		// Token: 0x0600066F RID: 1647 RVA: 0x00011878 File Offset: 0x0000FA78
		public static string FrDownload(string link)
		{
			HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(link);
			httpWebRequest.UserAgent = "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/83.0.4103.97 Safari/537.36 Edg/83.0.478.45";
			HttpWebResponse httpWebResponse = (HttpWebResponse)httpWebRequest.GetResponse();
			string text = new StreamReader(httpWebResponse.GetResponseStream()).ReadToEnd();
			int num = text.IndexOf("https://download");
			int nextIndexOf = CustomizedDownloader.GetNextIndexOf('"', text, num);
			return text.Substring(num, nextIndexOf - num);
		}

		// Token: 0x06000670 RID: 1648 RVA: 0x000118E8 File Offset: 0x0000FAE8
		public static string LuDownload(string link)
		{
			HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(link);
			HttpWebResponse httpWebResponse = (HttpWebResponse)httpWebRequest.GetResponse();
			string text = new StreamReader(httpWebResponse.GetResponseStream()).ReadToEnd();
			int num = text.IndexOf("file:");
			int num2 = CustomizedDownloader.LuGetNextIndexOf('"', text, num);
			string text2 = text.Substring(num, num2 - num);
			return text2.Replace("file: \"", "");
		}

		// Token: 0x06000671 RID: 1649 RVA: 0x0001195C File Offset: 0x0000FB5C
		public static string Lu2Download(string link)
		{
			HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(link);
			HttpWebResponse httpWebResponse = (HttpWebResponse)httpWebRequest.GetResponse();
			string text = new StreamReader(httpWebResponse.GetResponseStream()).ReadToEnd();
			int num = text.IndexOf("href='https://");
			int num2 = CustomizedDownloader.LuGetNextIndexOf('\'', text, num);
			string text2 = text.Substring(num, num2 - num);
			return text2.Replace("href='", "");
		}

		// Token: 0x06000672 RID: 1650 RVA: 0x000119D0 File Offset: 0x0000FBD0
		public static string SFDownload(string link)
		{
			HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(link);
			HttpWebResponse httpWebResponse = (HttpWebResponse)httpWebRequest.GetResponse();
			string text = new StreamReader(httpWebResponse.GetResponseStream()).ReadToEnd();
			int num = text.IndexOf("streamUrl\":\"http://");
			int nextIndexOfSF = CustomizedDownloader.GetNextIndexOfSF('"', text, num);
			string text2 = text.Substring(num, nextIndexOfSF - num);
			string text3 = text2.Replace("streamUrl\":\"", "");
			return text3.Substring(0, text3.Length - 4);
		}

		// Token: 0x06000673 RID: 1651 RVA: 0x00011A54 File Offset: 0x0000FC54
		public static string GuDownload(string link)
		{
			HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(link);
			HttpWebResponse httpWebResponse = (HttpWebResponse)httpWebRequest.GetResponse();
			string text = new StreamReader(httpWebResponse.GetResponseStream()).ReadToEnd();
			int num = text.IndexOf("type|");
			int num2 = CustomizedDownloader.GuGetNextIndexOf('\'', text, num);
			string text2 = text.Substring(num, num2 - num);
			string[] array = text2.Replace("type|", "").Split("|", StringSplitOptions.None);
			return string.Format("https://" + array[1] + ".gounlimited.to/" + array[0], Array.Empty<object>());
		}

		// Token: 0x06000674 RID: 1652 RVA: 0x00011AF4 File Offset: 0x0000FCF4
		private static int GuGetNextIndexOf(char c, string source, int start)
		{
			if (start < 0 || start > source.Length - 1)
			{
				throw new ArgumentOutOfRangeException();
			}
			for (int i = start; i < source.Length; i++)
			{
				if (source[i] == c)
				{
					return i;
				}
			}
			return -1;
		}

		// Token: 0x06000675 RID: 1653 RVA: 0x00011B34 File Offset: 0x0000FD34
		private static int GetNextIndexOf(char c, string source, int start)
		{
			if (start < 0 || start > source.Length - 1)
			{
				throw new ArgumentOutOfRangeException();
			}
			for (int i = start; i < source.Length; i++)
			{
				if (source[i] == c)
				{
					return i;
				}
			}
			return -1;
		}

		// Token: 0x06000676 RID: 1654 RVA: 0x00011B74 File Offset: 0x0000FD74
		private static int LuGetNextIndexOf(char c, string source, int start)
		{
			bool flag = false;
			if (start < 0 || start > source.Length - 1)
			{
				throw new ArgumentOutOfRangeException();
			}
			for (int i = start; i < source.Length; i++)
			{
				if (source[i] == c)
				{
					if (flag)
					{
						return i;
					}
					flag = true;
				}
			}
			return -1;
		}

		// Token: 0x06000677 RID: 1655 RVA: 0x00011BBC File Offset: 0x0000FDBC
		private static int GetNextIndexOfSF(char c, string source, int start)
		{
			int num = 2;
			if (start < 0 || start > source.Length - 1)
			{
				throw new ArgumentOutOfRangeException();
			}
			for (int i = start; i < source.Length; i++)
			{
				if (source[i] == c)
				{
					if (num == 0)
					{
						return i;
					}
					num--;
				}
			}
			return -1;
		}
	}
}
