using System;
using AndroidX.Fragment.App;
using AQ.Fragments;
using Java.Lang;

namespace AQ.ViewAdapters
{
	// Token: 0x02000042 RID: 66
	public class AnimeDetailsViewPagerAdapter : FragmentStatePagerAdapter
	{
		// Token: 0x060002AE RID: 686 RVA: 0x0000D49A File Offset: 0x0000B69A
		public AnimeDetailsViewPagerAdapter(FragmentManager fm, string[] titles) : base(fm, 1)
		{
			this.Titles = titles;
		}

		// Token: 0x060002AF RID: 687 RVA: 0x0000D4AB File Offset: 0x0000B6AB
		public override ICharSequence GetPageTitleFormatted(int position)
		{
			return new Java.Lang.String(this.Titles[position]);
		}

		// Token: 0x1700009B RID: 155
		// (get) Token: 0x060002B0 RID: 688 RVA: 0x0000D4BA File Offset: 0x0000B6BA
		public override int Count
		{
			get
			{
				return this.Titles.Length;
			}
		}

		// Token: 0x060002B1 RID: 689 RVA: 0x0000D4C4 File Offset: 0x0000B6C4
		public override Fragment GetItem(int position)
		{
			switch (position)
			{
			case 0:
				return new LoginFragment();
			case 1:
				return new LoginFragment();
			case 2:
				return new LoginFragment();
			case 3:
				return new LoginFragment();
			default:
				return new LoginFragment();
			}
		}

		// Token: 0x0400018E RID: 398
		private string[] Titles;
	}
}
