using System;
using System.Collections.Generic;
using Android.Content;

namespace AQ.Helpers
{
	// Token: 0x02000090 RID: 144
	public class LanguageConvertor
	{
		// Token: 0x06000684 RID: 1668 RVA: 0x0001242C File Offset: 0x0001062C
		public static List<string> GenresToList(Context context, string enGenres)
		{
			Dictionary<string, string> dictionary = new Dictionary<string, string>();
			dictionary.Add("Action", context.Resources.GetString(2131951652));
			dictionary.Add("Adventure", context.Resources.GetString(2131951672));
			dictionary.Add("School", context.Resources.GetString(2131952359));
			dictionary.Add("Comedy", context.Resources.GetString(2131951790));
			dictionary.Add("Drama", context.Resources.GetString(2131951884));
			dictionary.Add("Sports", context.Resources.GetString(2131952426));
			dictionary.Add("Slice of Life", context.Resources.GetString(2131952412));
			dictionary.Add("Fantasy", context.Resources.GetString(2131951923));
			dictionary.Add("Magic", context.Resources.GetString(2131952067));
			dictionary.Add("Supernatural", context.Resources.GetString(2131952452));
			dictionary.Add("Horror", context.Resources.GetString(2131952001));
			dictionary.Add("Vampire", context.Resources.GetString(2131952563));
			dictionary.Add("Mystery", context.Resources.GetString(2131952217));
			dictionary.Add("Thriller", context.Resources.GetString(2131952467));
			dictionary.Add("Psychological", context.Resources.GetString(2131952316));
			dictionary.Add("Romance", context.Resources.GetString(2131952346));
			dictionary.Add("Sci-Fi", context.Resources.GetString(2131952360));
			dictionary.Add("Ecchi", context.Resources.GetString(2131951885));
			dictionary.Add("Shounen", context.Resources.GetString(2131952400));
			dictionary.Add("Shoujo", context.Resources.GetString(2131952399));
			dictionary.Add("Seinen", context.Resources.GetString(2131952373));
			dictionary.Add("Music", context.Resources.GetString(2131952212));
			dictionary.Add("Game", context.Resources.GetString(2131951955));
			dictionary.Add("Historical", context.Resources.GetString(2131951998));
			dictionary.Add("Samurai", context.Resources.GetString(2131952356));
			dictionary.Add("Martial Arts", context.Resources.GetString(2131952072));
			dictionary.Add("Super Power", context.Resources.GetString(2131952451));
			dictionary.Add("Military", context.Resources.GetString(2131952137));
			dictionary.Add("Police", context.Resources.GetString(2131952300));
			dictionary.Add("Demons", context.Resources.GetString(2131951853));
			dictionary.Add("Space", context.Resources.GetString(2131952422));
			dictionary.Add("Cars", context.Resources.GetString(2131951754));
			dictionary.Add("Mecha", context.Resources.GetString(2131952096));
			dictionary.Add("Harem", context.Resources.GetString(2131951974));
			string[] array = enGenres.Split(", ", StringSplitOptions.None);
			List<string> list = new List<string>();
			foreach (string key in array)
			{
				if (dictionary.ContainsKey(key))
				{
					list.Add(dictionary[key]);
				}
				else
				{
					list.Add("");
				}
			}
			return list;
		}

		// Token: 0x06000685 RID: 1669 RVA: 0x00012828 File Offset: 0x00010A28
		public static string GenresToStringList(Context context, string enGenres)
		{
			Dictionary<string, string> dictionary = new Dictionary<string, string>();
			dictionary.Add("Action", context.Resources.GetString(2131951652));
			dictionary.Add("Adventure", context.Resources.GetString(2131951672));
			dictionary.Add("School", context.Resources.GetString(2131952359));
			dictionary.Add("Comedy", context.Resources.GetString(2131951790));
			dictionary.Add("Drama", context.Resources.GetString(2131951884));
			dictionary.Add("Sports", context.Resources.GetString(2131952426));
			dictionary.Add("Slice of Life", context.Resources.GetString(2131952412));
			dictionary.Add("Fantasy", context.Resources.GetString(2131951923));
			dictionary.Add("Magic", context.Resources.GetString(2131952067));
			dictionary.Add("Supernatural", context.Resources.GetString(2131952452));
			dictionary.Add("Horror", context.Resources.GetString(2131952001));
			dictionary.Add("Vampire", context.Resources.GetString(2131952563));
			dictionary.Add("Mystery", context.Resources.GetString(2131952217));
			dictionary.Add("Thriller", context.Resources.GetString(2131952467));
			dictionary.Add("Psychological", context.Resources.GetString(2131952316));
			dictionary.Add("Romance", context.Resources.GetString(2131952346));
			dictionary.Add("Sci-Fi", context.Resources.GetString(2131952360));
			dictionary.Add("Ecchi", context.Resources.GetString(2131951885));
			dictionary.Add("Shounen", context.Resources.GetString(2131952400));
			dictionary.Add("Shoujo", context.Resources.GetString(2131952399));
			dictionary.Add("Seinen", context.Resources.GetString(2131952373));
			dictionary.Add("Music", context.Resources.GetString(2131952212));
			dictionary.Add("Game", context.Resources.GetString(2131951955));
			dictionary.Add("Historical", context.Resources.GetString(2131951998));
			dictionary.Add("Samurai", context.Resources.GetString(2131952356));
			dictionary.Add("Martial Arts", context.Resources.GetString(2131952072));
			dictionary.Add("Super Power", context.Resources.GetString(2131952451));
			dictionary.Add("Military", context.Resources.GetString(2131952137));
			dictionary.Add("Police", context.Resources.GetString(2131952300));
			dictionary.Add("Demons", context.Resources.GetString(2131951853));
			dictionary.Add("Space", context.Resources.GetString(2131952422));
			dictionary.Add("Cars", context.Resources.GetString(2131951754));
			dictionary.Add("Mecha", context.Resources.GetString(2131952096));
			dictionary.Add("Harem", context.Resources.GetString(2131951974));
			string[] array = enGenres.Split(", ", StringSplitOptions.None);
			string text = "";
			for (int i = 0; i < array.Length; i++)
			{
				if (i == array.Length - 1)
				{
					text += (dictionary.ContainsKey(array[i]) ? dictionary[array[i]] : "");
				}
				else
				{
					text += (dictionary.ContainsKey(array[i]) ? (dictionary[array[i]] + "، ") : "");
				}
			}
			return text;
		}

		// Token: 0x06000686 RID: 1670 RVA: 0x00012C4C File Offset: 0x00010E4C
		public static string GenresToSingle(Context context, string key)
		{
			Dictionary<string, string> dictionary = new Dictionary<string, string>();
			dictionary.Add("Action", context.Resources.GetString(2131951652));
			dictionary.Add("Adventure", context.Resources.GetString(2131951672));
			dictionary.Add("School", context.Resources.GetString(2131952359));
			dictionary.Add("Comedy", context.Resources.GetString(2131951790));
			dictionary.Add("Drama", context.Resources.GetString(2131951884));
			dictionary.Add("Sports", context.Resources.GetString(2131952426));
			dictionary.Add("Slice of Life", context.Resources.GetString(2131952412));
			dictionary.Add("Fantasy", context.Resources.GetString(2131951923));
			dictionary.Add("Magic", context.Resources.GetString(2131952067));
			dictionary.Add("Supernatural", context.Resources.GetString(2131952452));
			dictionary.Add("Horror", context.Resources.GetString(2131952001));
			dictionary.Add("Vampire", context.Resources.GetString(2131952563));
			dictionary.Add("Mystery", context.Resources.GetString(2131952217));
			dictionary.Add("Thriller", context.Resources.GetString(2131952467));
			dictionary.Add("Psychological", context.Resources.GetString(2131952316));
			dictionary.Add("Romance", context.Resources.GetString(2131952346));
			dictionary.Add("Sci-Fi", context.Resources.GetString(2131952360));
			dictionary.Add("Ecchi", context.Resources.GetString(2131951885));
			dictionary.Add("Shounen", context.Resources.GetString(2131952400));
			dictionary.Add("Shoujo", context.Resources.GetString(2131952399));
			dictionary.Add("Seinen", context.Resources.GetString(2131952373));
			dictionary.Add("Music", context.Resources.GetString(2131952212));
			dictionary.Add("Game", context.Resources.GetString(2131951955));
			dictionary.Add("Historical", context.Resources.GetString(2131951998));
			dictionary.Add("Samurai", context.Resources.GetString(2131952356));
			dictionary.Add("Martial Arts", context.Resources.GetString(2131952072));
			dictionary.Add("Super Power", context.Resources.GetString(2131952451));
			dictionary.Add("Military", context.Resources.GetString(2131952137));
			dictionary.Add("Police", context.Resources.GetString(2131952300));
			dictionary.Add("Demons", context.Resources.GetString(2131951853));
			dictionary.Add("Space", context.Resources.GetString(2131952422));
			dictionary.Add("Cars", context.Resources.GetString(2131951754));
			dictionary.Add("Mecha", context.Resources.GetString(2131952096));
			dictionary.Add("Harem", context.Resources.GetString(2131951974));
			if (!dictionary.ContainsKey(key))
			{
				return "";
			}
			return dictionary[key];
		}

		// Token: 0x06000687 RID: 1671 RVA: 0x0001300C File Offset: 0x0001120C
		public static string GenresToENSingle(Context context, string key)
		{
			Dictionary<string, string> dictionary = new Dictionary<string, string>();
			dictionary.Add(context.Resources.GetString(2131951652), "Action");
			dictionary.Add(context.Resources.GetString(2131951672), "Adventure");
			dictionary.Add(context.Resources.GetString(2131952359), "School");
			dictionary.Add(context.Resources.GetString(2131951790), "Comedy");
			dictionary.Add(context.Resources.GetString(2131951884), "Drama");
			dictionary.Add(context.Resources.GetString(2131952426), "Sports");
			dictionary.Add(context.Resources.GetString(2131952412), "Slice of Life");
			dictionary.Add(context.Resources.GetString(2131951923), "Fantasy");
			dictionary.Add(context.Resources.GetString(2131952067), "Magic");
			dictionary.Add(context.Resources.GetString(2131952452), "Supernatural");
			dictionary.Add(context.Resources.GetString(2131952001), "Horror");
			dictionary.Add(context.Resources.GetString(2131952563), "Vampire");
			dictionary.Add(context.Resources.GetString(2131952217), "Mystery");
			dictionary.Add(context.Resources.GetString(2131952467), "Thriller");
			dictionary.Add(context.Resources.GetString(2131952316), "Psychological");
			dictionary.Add(context.Resources.GetString(2131952346), "Romance");
			dictionary.Add(context.Resources.GetString(2131952360), "Sci-Fi");
			dictionary.Add(context.Resources.GetString(2131951885), "Ecchi");
			dictionary.Add(context.Resources.GetString(2131952400), "Shounen");
			dictionary.Add(context.Resources.GetString(2131952399), "Shoujo");
			dictionary.Add(context.Resources.GetString(2131952373), "Seinen");
			dictionary.Add(context.Resources.GetString(2131952212), "Music");
			dictionary.Add(context.Resources.GetString(2131951955), "Game");
			dictionary.Add(context.Resources.GetString(2131951998), "Historical");
			dictionary.Add(context.Resources.GetString(2131952356), "Samurai");
			dictionary.Add(context.Resources.GetString(2131952072), "Martial Arts");
			dictionary.Add(context.Resources.GetString(2131952451), "Super Power");
			dictionary.Add(context.Resources.GetString(2131952137), "Military");
			dictionary.Add(context.Resources.GetString(2131952300), "Police");
			dictionary.Add(context.Resources.GetString(2131951853), "Demons");
			dictionary.Add(context.Resources.GetString(2131952422), "Space");
			dictionary.Add(context.Resources.GetString(2131951754), "Cars");
			dictionary.Add(context.Resources.GetString(2131952096), "Mecha");
			dictionary.Add(context.Resources.GetString(2131951974), "Harem");
			if (!dictionary.ContainsKey(key))
			{
				return "";
			}
			return dictionary[key];
		}

		// Token: 0x06000688 RID: 1672 RVA: 0x000133CC File Offset: 0x000115CC
		public static string DayOfWeek(Context context, string day)
		{
			if (day == null)
			{
				return string.Empty;
			}
			string result = "";
			if (day != null)
			{
				switch (day.Length)
				{
				case 6:
				{
					char c = day[0];
					if (c != 'F')
					{
						if (c != 'M')
						{
							if (c == 'S')
							{
								if (day == "SUNDAY")
								{
									result = context.Resources.GetString(2131952450);
								}
							}
						}
						else if (day == "MONDAY")
						{
							result = context.Resources.GetString(2131952143);
						}
					}
					else if (day == "FRIDAY")
					{
						result = context.Resources.GetString(2131951952);
					}
					break;
				}
				case 7:
					if (day == "TUESDAY")
					{
						result = context.Resources.GetString(2131952534);
					}
					break;
				case 8:
				{
					char c = day[0];
					if (c != 'S')
					{
						if (c == 'T')
						{
							if (day == "THURSDAY")
							{
								result = context.Resources.GetString(2131952468);
							}
						}
					}
					else if (day == "SATURDAY")
					{
						result = context.Resources.GetString(2131952357);
					}
					break;
				}
				case 9:
					if (day == "WEDNESDAY")
					{
						result = context.Resources.GetString(2131952581);
					}
					break;
				}
			}
			return result;
		}

		// Token: 0x06000689 RID: 1673 RVA: 0x00013550 File Offset: 0x00011750
		public static string WeekDayToDB(Context context, string day)
		{
			if (day == null)
			{
				return string.Empty;
			}
			string result = "";
			if (day == context.Resources.GetString(2131952357))
			{
				result = "SATURDAY";
			}
			else if (day == context.Resources.GetString(2131952450))
			{
				result = "SUNDAY";
			}
			else if (day == context.Resources.GetString(2131952143))
			{
				result = "MONDAY";
			}
			else if (day == context.Resources.GetString(2131952534))
			{
				result = "TUESDAY";
			}
			else if (day == context.Resources.GetString(2131952581))
			{
				result = "WEDNESDAY";
			}
			else if (day == context.Resources.GetString(2131952468))
			{
				result = "THURSDAY";
			}
			else if (day == context.Resources.GetString(2131951952))
			{
				result = "FRIDAY";
			}
			return result;
		}

		// Token: 0x0600068A RID: 1674 RVA: 0x00013654 File Offset: 0x00011854
		public static string Premiered(Context context, string season)
		{
			if (season == null)
			{
				return string.Empty;
			}
			return season.Replace("Summer", context.Resources.GetString(2131952449)).Replace("Winter", context.Resources.GetString(2131952584)).Replace("Fall", context.Resources.GetString(2131951919)).Replace("Spring", context.Resources.GetString(2131952427));
		}

		// Token: 0x0600068B RID: 1675 RVA: 0x000136D4 File Offset: 0x000118D4
		public static string PremieredToDB(Context context, string season)
		{
			if (season == null)
			{
				return string.Empty;
			}
			return season.Replace(context.Resources.GetString(2131952449), "Summer").Replace(context.Resources.GetString(2131952584), "Winter").Replace(context.Resources.GetString(2131951919), "Fall").Replace(context.Resources.GetString(2131952427), "Spring");
		}

		// Token: 0x0600068C RID: 1676 RVA: 0x00013754 File Offset: 0x00011954
		public static string PremieredYear(string season)
		{
			if (season == null)
			{
				return string.Empty;
			}
			return season.Replace("Summer ", "").Replace("Winter ", "").Replace("Fall ", "").Replace("Spring ", "");
		}

		// Token: 0x0600068D RID: 1677 RVA: 0x000137A8 File Offset: 0x000119A8
		public static string PremieredMonth(Context context, string month)
		{
			if (month == null)
			{
				return string.Empty;
			}
			return month.Replace("January", context.Resources.GetString(2131952015)).Replace("February", context.Resources.GetString(2131951935)).Replace("March", context.Resources.GetString(2131952067)).Replace("April", context.Resources.GetString(2131951717)).Replace("May", context.Resources.GetString(2131952095)).Replace("June", context.Resources.GetString(2131952017)).Replace("July", context.Resources.GetString(2131952016)).Replace("August", context.Resources.GetString(2131951721)).Replace("September", context.Resources.GetString(2131952378)).Replace("October", context.Resources.GetString(2131952256)).Replace("November", context.Resources.GetString(2131952254)).Replace("December", context.Resources.GetString(2131951841));
		}
	}
}
