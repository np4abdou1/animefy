using System;
using System.Collections.Specialized;
using System.Net;

namespace AQ.ViewModels
{
	// Token: 0x0200000B RID: 11
	public class FeedBackViewModel
	{
		// Token: 0x06000043 RID: 67 RVA: 0x00004900 File Offset: 0x00002B00
		public static void SendFeedback(string userID, string note)
		{
			WebClient webClient = new WebClient();
			Uri address = new Uri(Constants.ApiPhp("feedback/feedback.php"));
			webClient.UploadValuesAsync(address, new NameValueCollection
			{
				{
					"UserID",
					userID
				},
				{
					"Note",
					note
				},
				{
					"SendDate",
					DateTime.Now.ToShortDateString()
				},
				{
					"Token",
					"8cnY80AZSbUCmR26Vku1VUUY4"
				}
			});
		}

		// Token: 0x06000044 RID: 68 RVA: 0x00004974 File Offset: 0x00002B74
		public static void SendServerFeedback(string animeId, string type, string episode)
		{
			WebClient webClient = new WebClient();
			Uri address = new Uri(Constants.ApiPhp("feedback/report_servers.php"));
			webClient.UploadValuesAsync(address, new NameValueCollection
			{
				{
					"AnimeId",
					animeId
				},
				{
					"Type",
					type
				},
				{
					"Episode",
					episode
				},
				{
					"Token",
					"8cnY80AZSbUCmR26Vku1VUUY4"
				}
			});
		}
	}
}
