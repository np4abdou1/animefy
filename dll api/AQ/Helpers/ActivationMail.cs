using System;
using System.Collections.Specialized;
using System.Net;
using Android.Content;

namespace AQ.Helpers
{
	// Token: 0x02000096 RID: 150
	public class ActivationMail
	{
		// Token: 0x0600069A RID: 1690 RVA: 0x00013BC4 File Offset: 0x00011DC4
		public static void SendActivationMailApis(Context context, string lang, string emailOrUserName)
		{
			WebClient webClient = new WebClient();
			Uri address = new Uri(Constants.ApiPhp("users/mail_send_activation.php"));
			webClient.UploadValuesAsync(address, new NameValueCollection
			{
				{
					"EmailOrUsername",
					emailOrUserName
				},
				{
					"Lang",
					lang
				}
			});
		}
	}
}
