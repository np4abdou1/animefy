using System;
using Android.App;
using Android.Content;
using Android.Content.PM;
using Android.OS;
using Android.Views;
using AndroidX.AppCompat.App;
using AndroidX.Fragment.App;
using AQ.Fragments;
using AQ.Helpers;

namespace AQ.Activities
{
	// Token: 0x020000C6 RID: 198
	[Activity(Label = "@string/app_name", Theme = "@style/AppTheme", ConfigurationChanges = (ConfigChanges.Orientation | ConfigChanges.ScreenSize))]
	public class FeedbackActivity : AppCompatActivity
	{
		// Token: 0x06000989 RID: 2441 RVA: 0x00030368 File Offset: 0x0002E568
		protected override void OnCreate(Bundle savedInstanceState)
		{
			string a = SharedPreferencesSaves.StringSharedPreferencesGet("UserAppTheme");
			if (!(a == "BLUE"))
			{
				if (!(a == "PINK"))
				{
					if (!(a == "LIGHT_GRAY"))
					{
						this.SetTheme(2132017171);
					}
					else
					{
						this.SetTheme(2132017174);
					}
				}
				else
				{
					this.SetTheme(2132017177);
				}
			}
			else
			{
				this.SetTheme(2132017168);
			}
			base.OnCreate(savedInstanceState);
			this.SupportActionBar.Elevation = 0f;
			this.SupportActionBar.SetTitle(2131952508);
			this.SupportActionBar.SetDisplayHomeAsUpEnabled(true);
			this.SetContentView(2131558526);
			this.charSuggest = this.Intent.GetBooleanExtra("CharSuggest", false);
			Bundle bundle = new Bundle();
			bundle.PutBoolean("CharSuggest", this.charSuggest);
			FragmentTransaction fragmentTransaction = this.SupportFragmentManager.BeginTransaction();
			FeedbackFragment feedbackFragment = new FeedbackFragment();
			fragmentTransaction.Replace(2131362435, feedbackFragment, "FeedbackFragment");
			feedbackFragment.Arguments = bundle;
			fragmentTransaction.Commit();
		}

		// Token: 0x0600098A RID: 2442 RVA: 0x00030479 File Offset: 0x0002E679
		public override bool OnCreateOptionsMenu(IMenu menu)
		{
			this.MenuInflater.Inflate(2131689492, menu);
			return base.OnCreateOptionsMenu(menu);
		}

		// Token: 0x0600098B RID: 2443 RVA: 0x00030494 File Offset: 0x0002E694
		public override bool OnOptionsItemSelected(IMenuItem item)
		{
			int itemId = item.ItemId;
			if (itemId == 16908332)
			{
				this.Finish();
				return true;
			}
			return base.OnOptionsItemSelected(item);
		}

		// Token: 0x0600098C RID: 2444 RVA: 0x0002545B File Offset: 0x0002365B
		protected override void AttachBaseContext(Context @base)
		{
			base.AttachBaseContext(LocalizationChanger.UpdateResources(@base, "ar"));
		}

		// Token: 0x0400070B RID: 1803
		private bool charSuggest;
	}
}
