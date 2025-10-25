using System;

namespace AQ
{
	// Token: 0x02000005 RID: 5
	internal static class Constants
	{
		// Token: 0x06000005 RID: 5 RVA: 0x0000208E File Offset: 0x0000028E
		public static string ApiPhp(string file)
		{
			return "https://animeify.net/animeify/apis_v4/" + file;
		}

		// Token: 0x06000006 RID: 6 RVA: 0x0000209B File Offset: 0x0000029B
		public static string Thumbnails(string url)
		{
			return "https://animeify.net/animeify/files/thumbnails/" + url;
		}

		// Token: 0x06000007 RID: 7 RVA: 0x000020A8 File Offset: 0x000002A8
		public static string Trailers(string url)
		{
			return "https://animeify.net/animeify/files/trailers/" + url;
		}

		// Token: 0x06000008 RID: 8 RVA: 0x000020B5 File Offset: 0x000002B5
		public static string CharPhoto(string url)
		{
			return "https://animeify.net/animeify/files/characters/photos/chars/" + url;
		}

		// Token: 0x06000009 RID: 9 RVA: 0x000020C2 File Offset: 0x000002C2
		public static string TrendingPhotos(string photo)
		{
			return "https://animeify.net/animeify/files/trending/photos/" + photo;
		}

		// Token: 0x0600000A RID: 10 RVA: 0x000020CF File Offset: 0x000002CF
		public static string PeoplePhoto(string url)
		{
			return "https://animeify.net/animeify/files/characters/photos/voiceactors/" + url;
		}

		// Token: 0x0600000B RID: 11 RVA: 0x000020DC File Offset: 0x000002DC
		public static string ProfilePhoto(string photo, string userId)
		{
			return "https://animeify.net/animeify/users/profile_photos/" + photo;
		}

		// Token: 0x0600000C RID: 12 RVA: 0x000020E9 File Offset: 0x000002E9
		public static string ProfileCover(string photo, string userId)
		{
			return "https://animeify.net/animeify/users/profile_covers/" + photo;
		}

		// Token: 0x0600000D RID: 13 RVA: 0x000020F6 File Offset: 0x000002F6
		public static string NewsCover(string photo)
		{
			return "https://animeify.net/animeify/files/news/cover_thumbnails/" + photo;
		}

		// Token: 0x04000003 RID: 3
		public const string Token = "8cnY80AZSbUCmR26Vku1VUUY4";

		// Token: 0x04000004 RID: 4
		private const string ServiceUrl = "https://animeify.net/animeify/";

		// Token: 0x04000005 RID: 5
		private const string ApisUrl = "https://animeify.net/animeify/apis_v4/";

		// Token: 0x04000006 RID: 6
		private const string AnimeThumbnailsUrl = "https://animeify.net/animeify/files/thumbnails/";

		// Token: 0x04000007 RID: 7
		private const string AnimeTrailersUrl = "https://animeify.net/animeify/files/trailers/";

		// Token: 0x04000008 RID: 8
		private const string CharctersPhotosUrl = "https://animeify.net/animeify/files/characters/photos/chars/";

		// Token: 0x04000009 RID: 9
		private const string PeoplePhotosUrl = "https://animeify.net/animeify/files/characters/photos/voiceactors/";

		// Token: 0x0400000A RID: 10
		public const string NewsUrl = "https://animeify.net/animeify/files/news/";

		// Token: 0x0400000B RID: 11
		private const string UsersPath = "https://animeify.net/animeify/users/";

		// Token: 0x0400000C RID: 12
		private const string TrendingUrl = "https://animeify.net/animeify/files/trending/";

		// Token: 0x0400000D RID: 13
		public const string AppName = "ANIMEIFY";

		// Token: 0x0400000E RID: 14
		public const int CurrentAppVersion = 309;

		// Token: 0x0400000F RID: 15
		public const string Series = "SERIES";

		// Token: 0x04000010 RID: 16
		public const string Movie = "MOVIE";

		// Token: 0x04000011 RID: 17
		public const string Ova = "OVA";

		// Token: 0x04000012 RID: 18
		public const string Ona = "ONA";

		// Token: 0x04000013 RID: 19
		public const string Special = "SPECIAL";

		// Token: 0x04000014 RID: 20
		public const string Cartoon = "CARTOON";

		// Token: 0x04000015 RID: 21
		public const string Episode = "EPISODE";

		// Token: 0x04000016 RID: 22
		public const string Anime = "ANIME";

		// Token: 0x04000017 RID: 23
		public const string News = "NEWS";

		// Token: 0x04000018 RID: 24
		public const string Character = "CHARACTER";

		// Token: 0x04000019 RID: 25
		public const string Others = "OTHERS";

		// Token: 0x0400001A RID: 26
		public const string COMMENT = "COMMENT";

		// Token: 0x0400001B RID: 27
		public const string REPLY = "REPLY";

		// Token: 0x0400001C RID: 28
		public const string LIKE = "LIKE";

		// Token: 0x0400001D RID: 29
		public const string DISLIKE = "DISLIKE";

		// Token: 0x0400001E RID: 30
		public const string Filler = "FILLER";

		// Token: 0x0400001F RID: 31
		public const string Last = "LAST";

		// Token: 0x04000020 RID: 32
		public const string LastFiller = "LAST_FILLER";

		// Token: 0x04000021 RID: 33
		public const string Genre = "GENRE";

		// Token: 0x04000022 RID: 34
		public const string Premiered = "PREMIERED";

		// Token: 0x04000023 RID: 35
		public const string Studios = "STUDIOS";

		// Token: 0x04000024 RID: 36
		public const string Sort = "SORT";

		// Token: 0x04000025 RID: 37
		public const string Search = "SEARCH";

		// Token: 0x04000026 RID: 38
		public const string Name = "NAME";

		// Token: 0x04000027 RID: 39
		public const string PremieredASC = "PREMIERED_ACS";

		// Token: 0x04000028 RID: 40
		public const string PremieredDEC = "PREMIERED_DEC";

		// Token: 0x04000029 RID: 41
		public const string EpisodesASC = "EPISODES_ASC";

		// Token: 0x0400002A RID: 42
		public const string EpisodesDEC = "EPISODES_DEC";

		// Token: 0x0400002B RID: 43
		public const string HighestRate = "HIGHEST_RATE";

		// Token: 0x0400002C RID: 44
		public const string HighestRank = "HIGHEST_RANK";

		// Token: 0x0400002D RID: 45
		public const string Airing = "AIRING";

		// Token: 0x0400002E RID: 46
		public const string Aired = "AIRED";

		// Token: 0x0400002F RID: 47
		public const string Upcoming = "UPCOMING";

		// Token: 0x04000030 RID: 48
		public const string Paused = "PAUSED";

		// Token: 0x04000031 RID: 49
		public const string Unavailable = "UNAVAILABLE";

		// Token: 0x04000032 RID: 50
		public const string AllAges = "ALLAGES";

		// Token: 0x04000033 RID: 51
		public const string Pg13 = "PG-13";

		// Token: 0x04000034 RID: 52
		public const string Pg17 = "PG-17";

		// Token: 0x04000035 RID: 53
		public const string Children = "CHILDREN";

		// Token: 0x04000036 RID: 54
		public const string Light = "LIGHT";

		// Token: 0x04000037 RID: 55
		public const string Blue = "BLUE";

		// Token: 0x04000038 RID: 56
		public const string Pink = "PINK";

		// Token: 0x04000039 RID: 57
		public const string DarkLightGray = "LIGHT_GRAY";

		// Token: 0x0400003A RID: 58
		public const string DarkDarkGray = "DARK_GRAY";

		// Token: 0x0400003B RID: 59
		public const string Saturday = "SATURDAY";

		// Token: 0x0400003C RID: 60
		public const string Sunday = "SUNDAY";

		// Token: 0x0400003D RID: 61
		public const string Monday = "MONDAY";

		// Token: 0x0400003E RID: 62
		public const string Tuesday = "TUESDAY";

		// Token: 0x0400003F RID: 63
		public const string Wednesday = "WEDNESDAY";

		// Token: 0x04000040 RID: 64
		public const string Thursday = "THURSDAY";

		// Token: 0x04000041 RID: 65
		public const string Friday = "FRIDAY";

		// Token: 0x04000042 RID: 66
		public const string Normal = "NORMAL";

		// Token: 0x04000043 RID: 67
		public const string Admin = "ADMIN";

		// Token: 0x04000044 RID: 68
		public const string Premium = "PREMIUM";

		// Token: 0x04000045 RID: 69
		public const string ExpiredPremium = "EXPIRED_PREMIUM";

		// Token: 0x04000046 RID: 70
		public const string IncorrectUserName = "INCORRECT_USERNAME";

		// Token: 0x04000047 RID: 71
		public const string IncorrectPassword = "INCORRECT_PASSWORD";

		// Token: 0x04000048 RID: 72
		public const string UsernameExists = "USERNAME_EXISTS";

		// Token: 0x04000049 RID: 73
		public const string EmailExists = "EMAIL_EXISTS";

		// Token: 0x0400004A RID: 74
		public const string GoogleAccountAlreadyLinked = "GOOGLE_ACCOUNT_ALREADY_LINKED";

		// Token: 0x0400004B RID: 75
		public const string WatchLater = "WATCH_LATER";

		// Token: 0x0400004C RID: 76
		public const string WatchCurrently = "WATCH_CURRENTLY";

		// Token: 0x0400004D RID: 77
		public const string WatchDone = "WATCH_DONE";

		// Token: 0x0400004E RID: 78
		public const string PRIVACY_POLICY_LINK = "https://animeify.net/privacy";

		// Token: 0x0400004F RID: 79
		public const string TERMS_LINK = "https://animeify.net/terms";
	}
}
