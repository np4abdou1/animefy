using System;
using System.Collections.Specialized;
using System.Net;

namespace AQ.ViewModels
{
	// Token: 0x0200000A RID: 10
	public class FavouritesViewModel
	{
		// Token: 0x06000040 RID: 64 RVA: 0x000047F8 File Offset: 0x000029F8
		public static void FavouritesCrud(int userId, string animeId, string type)
		{
			FavouritesViewModel.client = new WebClient();
			FavouritesViewModel.uri = new Uri(Constants.ApiPhp("library/favourites/favourites_a_crud.php"));
			FavouritesViewModel.parameters = new NameValueCollection();
			FavouritesViewModel.parameters.Add("UserId", userId.ToString());
			FavouritesViewModel.parameters.Add("AnimeId", animeId);
			FavouritesViewModel.parameters.Add("Type", type);
			FavouritesViewModel.parameters.Add("Token", "8cnY80AZSbUCmR26Vku1VUUY4");
			FavouritesViewModel.client.UploadValuesAsync(FavouritesViewModel.uri, FavouritesViewModel.parameters);
		}

		// Token: 0x06000041 RID: 65 RVA: 0x0000488C File Offset: 0x00002A8C
		public static void FavouritesClearAll(int userId)
		{
			FavouritesViewModel.client = new WebClient();
			FavouritesViewModel.uri = new Uri(Constants.ApiPhp("library/favourites/favourites_a_clear_all.php"));
			FavouritesViewModel.parameters = new NameValueCollection();
			FavouritesViewModel.parameters.Add("UserId", userId.ToString());
			FavouritesViewModel.parameters.Add("Token", "8cnY80AZSbUCmR26Vku1VUUY4");
			FavouritesViewModel.client.UploadValuesAsync(FavouritesViewModel.uri, FavouritesViewModel.parameters);
		}

		// Token: 0x04000070 RID: 112
		public static WebClient client;

		// Token: 0x04000071 RID: 113
		public static Uri uri;

		// Token: 0x04000072 RID: 114
		public static NameValueCollection parameters;
	}
}
