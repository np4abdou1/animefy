using System;
using System.Linq;
using AndroidX.Fragment.App;
using AndroidX.ViewPager2.Adapter;
using AQ.Fragments;

namespace AQ.ViewAdapters
{
	// Token: 0x02000044 RID: 68
	public class AnimeDetailsViewPager2Adapter : FragmentStateAdapter
	{
		// Token: 0x060002B6 RID: 694 RVA: 0x0000D525 File Offset: 0x0000B725
		public AnimeDetailsViewPager2Adapter(Fragment fm, string[] titles) : base(fm)
		{
			this.Titles = titles;
		}

		// Token: 0x1700009D RID: 157
		// (get) Token: 0x060002B7 RID: 695 RVA: 0x0000D535 File Offset: 0x0000B735
		public override int ItemCount
		{
			get
			{
				return this.Titles.Count<string>();
			}
		}

		// Token: 0x060002B8 RID: 696 RVA: 0x0000D542 File Offset: 0x0000B742
		public override Fragment CreateFragment(int p0)
		{
			if (p0 == 0)
			{
				return new LoginFragment();
			}
			if (p0 != 1)
			{
				return new LoginFragment();
			}
			return new LoginFragment();
		}

		// Token: 0x04000190 RID: 400
		private string[] Titles;
	}
}
