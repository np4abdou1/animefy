using System;
using System.IO;
using System.Net;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Android.App;
using Android.Graphics;
using Android.Graphics.Drawables;
using Java.Net;

namespace AQ.Helpers
{
	// Token: 0x02000087 RID: 135
	public class BitmapStreamer
	{
		// Token: 0x0600065D RID: 1629 RVA: 0x00010A60 File Offset: 0x0000EC60
		public static Task<Drawable> GetDrawableAsync(string url, Activity activity)
		{
			BitmapStreamer.<GetDrawableAsync>d__0 <GetDrawableAsync>d__;
			<GetDrawableAsync>d__.<>t__builder = AsyncTaskMethodBuilder<Drawable>.Create();
			<GetDrawableAsync>d__.url = url;
			<GetDrawableAsync>d__.activity = activity;
			<GetDrawableAsync>d__.<>1__state = -1;
			<GetDrawableAsync>d__.<>t__builder.Start<BitmapStreamer.<GetDrawableAsync>d__0>(ref <GetDrawableAsync>d__);
			return <GetDrawableAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0600065E RID: 1630 RVA: 0x00010AAC File Offset: 0x0000ECAC
		public static Bitmap GetBitmap(string url)
		{
			Bitmap result;
			try
			{
				HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(url);
				using (HttpWebResponse httpWebResponse = (HttpWebResponse)httpWebRequest.GetResponse())
				{
					using (Stream responseStream = httpWebResponse.GetResponseStream())
					{
						MemoryStream memoryStream = new MemoryStream();
						responseStream.CopyTo(memoryStream);
						Bitmap bitmap = BitmapFactory.DecodeByteArray(memoryStream.GetBuffer(), 0, (int)memoryStream.Length);
						result = bitmap;
					}
				}
			}
			catch
			{
				result = null;
			}
			return result;
		}

		// Token: 0x0600065F RID: 1631 RVA: 0x00010B44 File Offset: 0x0000ED44
		public static Bitmap GetBitmapB(string src)
		{
			Bitmap result;
			try
			{
				URL url = new URL(src);
				HttpURLConnection httpURLConnection = (HttpURLConnection)url.OpenConnection();
				httpURLConnection.DoInput = true;
				httpURLConnection.Connect();
				Stream inputStream = httpURLConnection.InputStream;
				Bitmap bitmap = BitmapFactory.DecodeStream(inputStream);
				result = bitmap;
			}
			catch
			{
				result = null;
			}
			return result;
		}
	}
}
