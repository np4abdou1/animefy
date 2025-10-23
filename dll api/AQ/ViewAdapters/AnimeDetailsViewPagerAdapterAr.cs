using System;
using AndroidX.Fragment.App;
using AQ.Fragments;
using Java.Lang;

namespace AQ.ViewAdapters
{
	// Token: 0x02000043 RID: 67
	public class AnimeDetailsViewPagerAdapterAr : FragmentStatePagerAdapter
	{
		// Token: 0x060002B2 RID: 690 RVA: 0x0000D4FB File Offset: 0x0000B6FB
		public AnimeDetailsViewPagerAdapterAr(FragmentManager fm, string[] titles) : base(fm, 1)
		{
			this.Titles = titles;
		}

		// Token: 0x060002B3 RID: 691 RVA: 0x0000D50C File Offset: 0x0000B70C
		public override ICharSequence GetPageTitleFormatted(int position)
		{
			return new Java.Lang.String(this.Titles[position]);
		}

		// Token: 0x1700009C RID: 156
		// (get) Token: 0x060002B4 RID: 692 RVA: 0x0000D51B File Offset: 0x0000B71B
		public override int Count
		{
			get
			{
				return this.Titles.Length;
			}
		}

		// Token: 0x060002B5 RID: 693 RVA: 0x0000D4C4 File Offset: 0x0000B6C4
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

		// Token: 0x0400018F RID: 399
		private string[] Titles;
	}
}
