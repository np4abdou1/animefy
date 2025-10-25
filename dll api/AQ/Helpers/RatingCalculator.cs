using System;
using AQ.Models;

namespace AQ.Helpers
{
	// Token: 0x02000095 RID: 149
	public class RatingCalculator
	{
		// Token: 0x06000697 RID: 1687 RVA: 0x00013A90 File Offset: 0x00011C90
		private static float Calculate(int[] rating)
		{
			return (float)(rating[0] + 2 * rating[1] + 3 * rating[2] + 4 * rating[3] + 5 * rating[4] + 6 * rating[5] + 7 * rating[6] + 8 * rating[7] + 9 * rating[8] + 10 * rating[9]) / (float)(rating[0] + rating[1] + rating[2] + rating[3] + rating[4] + rating[5] + rating[6] + rating[7] + rating[8] + rating[9]);
		}

		// Token: 0x06000698 RID: 1688 RVA: 0x00013B04 File Offset: 0x00011D04
		public static string CalculateRating(AnimeModel statistics)
		{
			int[] rating = new int[]
			{
				statistics.rates_1,
				statistics.rates_2,
				statistics.rates_3,
				statistics.rates_4,
				statistics.rates_5,
				statistics.rates_6,
				statistics.rates_7,
				statistics.rates_8,
				statistics.rates_9,
				statistics.rates_10
			};
			float num = RatingCalculator.Calculate(rating);
			string result;
			if (!float.IsNaN(num))
			{
				if ((double)num > 9.9)
				{
					result = string.Format("{0:0}", num);
				}
				else
				{
					result = string.Format("{0:0.0}", num);
				}
			}
			else
			{
				result = "0";
			}
			return result;
		}
	}
}
