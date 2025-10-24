using System;
using Android.Content;
using Android.Util;

namespace AQ.Helpers
{
	// Token: 0x02000088 RID: 136
	public class Calculators
	{
		// Token: 0x06000661 RID: 1633 RVA: 0x00010B9C File Offset: 0x0000ED9C
		public static string ConvertMinutesToDuration(Context context, int minutes)
		{
			TimeSpan timeSpan = TimeSpan.FromMinutes((double)minutes);
			string result;
			if (timeSpan.Minutes == 0)
			{
				result = timeSpan.Hours.ToString() + " " + context.Resources.GetString(2131952002);
			}
			else if (timeSpan.Hours == 0)
			{
				result = timeSpan.Minutes.ToString() + " " + context.Resources.GetString(2131952139);
			}
			else
			{
				result = string.Concat(new string[]
				{
					timeSpan.Hours.ToString(),
					" ",
					context.Resources.GetString(2131952002),
					" ",
					timeSpan.Minutes.ToString(),
					" ",
					context.Resources.GetString(2131952139)
				});
			}
			return result;
		}

		// Token: 0x06000662 RID: 1634 RVA: 0x00010C94 File Offset: 0x0000EE94
		public static string TimeCalculatorAR(Context context, string date)
		{
			TimeSpan timeSpan = new TimeSpan(DateTime.Now.Ticks - DateTime.Parse(date).Ticks);
			double num = Math.Abs(timeSpan.TotalSeconds);
			if (num < 60.0)
			{
				if (timeSpan.Seconds == 1)
				{
					return context.Resources.GetString(2131952481);
				}
				if (timeSpan.Seconds < 3)
				{
					return context.Resources.GetString(2131952490);
				}
				if (timeSpan.Seconds < 11)
				{
					return string.Concat(new string[]
					{
						context.Resources.GetString(2131951675),
						" ",
						timeSpan.Seconds.ToString(),
						" ",
						context.Resources.GetString(2131952485)
					});
				}
				return string.Concat(new string[]
				{
					context.Resources.GetString(2131951675),
					" ",
					timeSpan.Seconds.ToString(),
					" ",
					context.Resources.GetString(2131952484)
				});
			}
			else if (num < 2700.0)
			{
				if (num < 120.0)
				{
					return context.Resources.GetString(2131952479);
				}
				if (num < 180.0)
				{
					return context.Resources.GetString(2131952488);
				}
				if (num < 660.0)
				{
					return string.Concat(new string[]
					{
						context.Resources.GetString(2131951675),
						" ",
						timeSpan.Minutes.ToString(),
						" ",
						context.Resources.GetString(2131952474)
					});
				}
				return string.Concat(new string[]
				{
					context.Resources.GetString(2131951675),
					" ",
					timeSpan.Minutes.ToString(),
					" ",
					context.Resources.GetString(2131952473)
				});
			}
			else
			{
				if (num < 5400.0)
				{
					return context.Resources.GetString(2131952478);
				}
				if (num < 86400.0)
				{
					if (num < 10800.0)
					{
						return context.Resources.GetString(2131952487);
					}
					if (num < 39600.0)
					{
						return string.Concat(new string[]
						{
							context.Resources.GetString(2131951675),
							" ",
							timeSpan.Hours.ToString(),
							" ",
							context.Resources.GetString(2131952472)
						});
					}
					return string.Concat(new string[]
					{
						context.Resources.GetString(2131951675),
						" ",
						timeSpan.Hours.ToString(),
						" ",
						context.Resources.GetString(2131952471)
					});
				}
				else
				{
					if (num < 172800.0)
					{
						return context.Resources.GetString(2131952477);
					}
					if (num < 604800.0)
					{
						if (num < 259200.0)
						{
							return context.Resources.GetString(2131952486);
						}
						return string.Concat(new string[]
						{
							context.Resources.GetString(2131951675),
							" ",
							timeSpan.Days.ToString(),
							" ",
							context.Resources.GetString(2131952470)
						});
					}
					else if (num < 2419200.0)
					{
						int num2 = Convert.ToInt32(Math.Floor((double)timeSpan.Days / 7.0));
						if (num2 <= 1)
						{
							return context.Resources.GetString(2131952482);
						}
						if (num < 1814400.0)
						{
							return context.Resources.GetString(2131952491);
						}
						return string.Concat(new string[]
						{
							context.Resources.GetString(2131951675),
							" ",
							num2.ToString(),
							" ",
							context.Resources.GetString(2131952494)
						});
					}
					else if (num < 31104000.0)
					{
						int num3 = Convert.ToInt32(Math.Floor((double)timeSpan.Days / 30.0));
						if (num3 <= 1)
						{
							return context.Resources.GetString(2131952480);
						}
						if (num3 < 3)
						{
							return context.Resources.GetString(2131952489);
						}
						if (num3 < 11)
						{
							return string.Concat(new string[]
							{
								context.Resources.GetString(2131951675),
								" ",
								num3.ToString(),
								" ",
								context.Resources.GetString(2131952476)
							});
						}
						return string.Concat(new string[]
						{
							context.Resources.GetString(2131951675),
							" ",
							num3.ToString(),
							" ",
							context.Resources.GetString(2131952475)
						});
					}
					else
					{
						int num4 = Convert.ToInt32(Math.Floor((double)timeSpan.Days / 365.0));
						if (num4 <= 1)
						{
							return context.Resources.GetString(2131952483);
						}
						if (num4 < 3)
						{
							return context.Resources.GetString(2131952492);
						}
						if (num4 < 11)
						{
							return string.Concat(new string[]
							{
								context.Resources.GetString(2131951675),
								" ",
								num4.ToString(),
								" ",
								context.Resources.GetString(2131952496)
							});
						}
						return string.Concat(new string[]
						{
							context.Resources.GetString(2131951675),
							" ",
							num4.ToString(),
							" ",
							context.Resources.GetString(2131952495)
						});
					}
				}
			}
		}

		// Token: 0x06000663 RID: 1635 RVA: 0x000112E8 File Offset: 0x0000F4E8
		public static string TimeCalculatorEN(Context context, string date)
		{
			TimeSpan timeSpan = new TimeSpan(DateTime.Now.Ticks - DateTime.Parse(date).Ticks);
			double num = Math.Abs(timeSpan.TotalSeconds);
			if (num < 60.0)
			{
				if (timeSpan.Seconds != 1)
				{
					return timeSpan.Seconds.ToString() + " " + context.Resources.GetString(2131952485);
				}
				return context.Resources.GetString(2131952481);
			}
			else
			{
				if (num < 120.0)
				{
					return context.Resources.GetString(2131952479);
				}
				if (num < 2700.0)
				{
					return timeSpan.Minutes.ToString() + "  minutes ago";
				}
				if (num < 5400.0)
				{
					return context.Resources.GetString(2131952478);
				}
				if (num < 86400.0)
				{
					return timeSpan.Hours.ToString() + " " + context.Resources.GetString(2131952472);
				}
				if (num < 172800.0)
				{
					return context.Resources.GetString(2131952477);
				}
				if (num < 604800.0)
				{
					return timeSpan.Days.ToString() + " " + context.Resources.GetString(2131952470);
				}
				if (num < 2419200.0)
				{
					int num2 = Convert.ToInt32(Math.Floor((double)timeSpan.Days / 7.0));
					if (num2 > 1)
					{
						return num2.ToString() + " " + context.Resources.GetString(2131952494);
					}
					return context.Resources.GetString(2131952482);
				}
				else if (num < 31104000.0)
				{
					int num3 = Convert.ToInt32(Math.Floor((double)timeSpan.Days / 30.0));
					if (num3 > 1)
					{
						return num3.ToString() + " " + context.Resources.GetString(2131952476);
					}
					return context.Resources.GetString(2131952480);
				}
				else
				{
					int num4 = Convert.ToInt32(Math.Floor((double)timeSpan.Days / 365.0));
					if (num4 > 1)
					{
						return num4.ToString() + " " + context.Resources.GetString(2131952496);
					}
					return context.Resources.GetString(2131952483);
				}
			}
		}

		// Token: 0x06000664 RID: 1636 RVA: 0x00011578 File Offset: 0x0000F778
		public static int ConvertPixelsToDp(float pixelValue, Context context)
		{
			return (int)(pixelValue / context.Resources.DisplayMetrics.Density);
		}

		// Token: 0x06000665 RID: 1637 RVA: 0x0001159C File Offset: 0x0000F79C
		public static int CalculateNumberOfColumns(Context context, float columnWidthDp)
		{
			DisplayMetrics displayMetrics = context.Resources.DisplayMetrics;
			float num = (float)displayMetrics.WidthPixels / displayMetrics.Density;
			return (int)((double)(num / columnWidthDp) + 0.5);
		}

		// Token: 0x06000666 RID: 1638 RVA: 0x000115D8 File Offset: 0x0000F7D8
		public static string GetSizeOfNum(int numb)
		{
			string result;
			try
			{
				string[] array = new string[]
				{
					"B",
					"KB",
					"MB",
					"GB",
					"TB",
					"PB",
					"EB"
				};
				if (numb == 0)
				{
					result = "0" + array[0];
				}
				else
				{
					long num = (long)Math.Abs(numb);
					int num2 = Convert.ToInt32(Math.Floor(Math.Log((double)num, 1024.0)));
					double num3 = Math.Round((double)num / Math.Pow(1024.0, (double)num2), 1);
					result = ((double)Math.Sign(numb) * num3).ToString() + array[num2];
				}
			}
			catch
			{
				result = "N/A";
			}
			return result;
		}
	}
}
