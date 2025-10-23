using System;
using System.Collections.Specialized;
using System.Net;

namespace AQ.ViewModels
{
	// Token: 0x0200000C RID: 12
	public class LibraryViewModel
	{
		// Token: 0x06000046 RID: 70 RVA: 0x000049DC File Offset: 0x00002BDC
		public static void ClearAll(int userId, string library)
		{
			LibraryViewModel.client = new WebClient();
			LibraryViewModel.uri = new Uri(Constants.ApiPhp("library/library/library_clear_all.php"));
			LibraryViewModel.parameters = new NameValueCollection();
			LibraryViewModel.parameters.Add("UserId", userId.ToString());
			LibraryViewModel.parameters.Add("Library", library);
			LibraryViewModel.parameters.Add("Token", "8cnY80AZSbUCmR26Vku1VUUY4");
			LibraryViewModel.client.UploadValuesAsync(LibraryViewModel.uri, LibraryViewModel.parameters);
		}

		// Token: 0x06000047 RID: 71 RVA: 0x00004A60 File Offset: 0x00002C60
		public static void CrudItem(int userId, string animeId, string library, string type)
		{
			LibraryViewModel.client = new WebClient();
			LibraryViewModel.uri = new Uri(Constants.ApiPhp("library/library/library_crud.php"));
			LibraryViewModel.parameters = new NameValueCollection();
			LibraryViewModel.parameters.Add("UserId", userId.ToString());
			LibraryViewModel.parameters.Add("AnimeId", animeId);
			LibraryViewModel.parameters.Add("Library", library);
			LibraryViewModel.parameters.Add("Type", type);
			LibraryViewModel.parameters.Add("Token", "8cnY80AZSbUCmR26Vku1VUUY4");
			LibraryViewModel.client.UploadValuesAsync(LibraryViewModel.uri, LibraryViewModel.parameters);
		}

		// Token: 0x04000073 RID: 115
		public static WebClient client;

		// Token: 0x04000074 RID: 116
		public static Uri uri;

		// Token: 0x04000075 RID: 117
		public static NameValueCollection parameters;
	}
}
