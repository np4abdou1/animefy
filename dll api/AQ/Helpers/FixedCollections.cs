using System;
using System.Collections.Generic;
using Android.Content;
using AQ.Models;

namespace AQ.Helpers
{
	// Token: 0x0200008F RID: 143
	public class FixedCollections
	{
		// Token: 0x0600067D RID: 1661 RVA: 0x00011CC0 File Offset: 0x0000FEC0
		public static string[] Genres(Context context)
		{
			return new string[]
			{
				context.Resources.GetString(2131951678),
				context.Resources.GetString(2131951652),
				context.Resources.GetString(2131951672),
				context.Resources.GetString(2131951790),
				context.Resources.GetString(2131951884),
				context.Resources.GetString(2131952426),
				context.Resources.GetString(2131952412),
				context.Resources.GetString(2131951923),
				context.Resources.GetString(2131952067),
				context.Resources.GetString(2131952452),
				context.Resources.GetString(2131952001),
				context.Resources.GetString(2131952563),
				context.Resources.GetString(2131952217),
				context.Resources.GetString(2131952467),
				context.Resources.GetString(2131952316),
				context.Resources.GetString(2131952212),
				context.Resources.GetString(2131951955),
				context.Resources.GetString(2131951998),
				context.Resources.GetString(2131952346),
				context.Resources.GetString(2131952360),
				context.Resources.GetString(2131952359),
				context.Resources.GetString(2131952400),
				context.Resources.GetString(2131951974),
				context.Resources.GetString(2131952373),
				context.Resources.GetString(2131952399),
				context.Resources.GetString(2131951885),
				context.Resources.GetString(2131952356),
				context.Resources.GetString(2131952072),
				context.Resources.GetString(2131952451),
				context.Resources.GetString(2131952137),
				context.Resources.GetString(2131952300),
				context.Resources.GetString(2131951853),
				context.Resources.GetString(2131952422),
				context.Resources.GetString(2131951754),
				context.Resources.GetString(2131952096)
			};
		}

		// Token: 0x0600067E RID: 1662 RVA: 0x00011F8C File Offset: 0x0001018C
		public static string[] Genres2(Context context)
		{
			return new string[]
			{
				context.Resources.GetString(2131951652),
				context.Resources.GetString(2131951672),
				context.Resources.GetString(2131951790),
				context.Resources.GetString(2131951884),
				context.Resources.GetString(2131952426),
				context.Resources.GetString(2131952412),
				context.Resources.GetString(2131951923),
				context.Resources.GetString(2131952067),
				context.Resources.GetString(2131952452),
				context.Resources.GetString(2131952001),
				context.Resources.GetString(2131952563),
				context.Resources.GetString(2131952217),
				context.Resources.GetString(2131952467),
				context.Resources.GetString(2131952316),
				context.Resources.GetString(2131952212),
				context.Resources.GetString(2131951955),
				context.Resources.GetString(2131951998),
				context.Resources.GetString(2131952346),
				context.Resources.GetString(2131952360),
				context.Resources.GetString(2131952359),
				context.Resources.GetString(2131952400),
				context.Resources.GetString(2131951974),
				context.Resources.GetString(2131952373),
				context.Resources.GetString(2131952399),
				context.Resources.GetString(2131951885),
				context.Resources.GetString(2131952356),
				context.Resources.GetString(2131952072),
				context.Resources.GetString(2131952451),
				context.Resources.GetString(2131952137),
				context.Resources.GetString(2131952300),
				context.Resources.GetString(2131951853),
				context.Resources.GetString(2131952422),
				context.Resources.GetString(2131951754),
				context.Resources.GetString(2131952096)
			};
		}

		// Token: 0x0600067F RID: 1663 RVA: 0x00012241 File Offset: 0x00010441
		public static string[] Years()
		{
			return SharedPreferencesSaves.StringSharedPreferencesGet("YearsList").Split(", ", StringSplitOptions.None);
		}

		// Token: 0x06000680 RID: 1664 RVA: 0x00012258 File Offset: 0x00010458
		public static List<SelectableListModel> YearsList()
		{
			List<SelectableListModel> list = new List<SelectableListModel>();
			foreach (string title in FixedCollections.Years())
			{
				list.Add(new SelectableListModel
				{
					Title = title
				});
			}
			return list;
		}

		// Token: 0x06000681 RID: 1665 RVA: 0x00012298 File Offset: 0x00010498
		public static List<SelectableListModel> Seasons(Context context)
		{
			return new List<SelectableListModel>
			{
				new SelectableListModel
				{
					Title = context.Resources.GetString(2131952449)
				},
				new SelectableListModel
				{
					Title = context.Resources.GetString(2131952584)
				},
				new SelectableListModel
				{
					Title = context.Resources.GetString(2131952427)
				},
				new SelectableListModel
				{
					Title = context.Resources.GetString(2131951919)
				}
			};
		}

		// Token: 0x06000682 RID: 1666 RVA: 0x00012330 File Offset: 0x00010530
		public static List<SelectableListModel> WeekDays(Context context)
		{
			return new List<SelectableListModel>
			{
				new SelectableListModel
				{
					Title = context.Resources.GetString(2131952357)
				},
				new SelectableListModel
				{
					Title = context.Resources.GetString(2131952450)
				},
				new SelectableListModel
				{
					Title = context.Resources.GetString(2131952143)
				},
				new SelectableListModel
				{
					Title = context.Resources.GetString(2131952534)
				},
				new SelectableListModel
				{
					Title = context.Resources.GetString(2131952581)
				},
				new SelectableListModel
				{
					Title = context.Resources.GetString(2131952468)
				},
				new SelectableListModel
				{
					Title = context.Resources.GetString(2131951952)
				}
			};
		}
	}
}
