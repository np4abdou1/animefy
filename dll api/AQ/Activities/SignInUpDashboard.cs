using System;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Views;
using AndroidX.AppCompat.App;
using AndroidX.Fragment.App;
using AQ.Fragments;
using AQ.Helpers;

namespace AQ.Activities
{
	// Token: 0x020000CE RID: 206
	[Activity(Label = "@string/app_name", Theme = "@style/AppTheme")]
	public class SignInUpDashboard : AppCompatActivity
	{
		// Token: 0x06000A47 RID: 2631 RVA: 0x00036A9C File Offset: 0x00034C9C
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
			this.OverridePendingTransition(2130772025, 2130772026);
			this.SupportActionBar.Elevation = 0f;
			this.SupportActionBar.SetDisplayHomeAsUpEnabled(true);
			this.SupportActionBar.SetDisplayShowTitleEnabled(false);
			this.SupportActionBar.SetDisplayShowCustomEnabled(true);
			this.SupportActionBar.SetCustomView(2131558645);
			this.SetContentView(2131558525);
			FragmentTransaction fragmentTransaction = this.SupportFragmentManager.BeginTransaction();
			fragmentTransaction.Replace(2131362434, new LoginFragment(), "LoginFragment");
			fragmentTransaction.Commit();
		}

		// Token: 0x06000A48 RID: 2632 RVA: 0x00036BA0 File Offset: 0x00034DA0
		public override bool OnOptionsItemSelected(IMenuItem item)
		{
			int itemId = item.ItemId;
			if (itemId == 16908332)
			{
				this.Finish();
				this.OverridePendingTransition(2130772024, 2130772027);
				return true;
			}
			return base.OnOptionsItemSelected(item);
		}

		// Token: 0x06000A49 RID: 2633 RVA: 0x00036BDB File Offset: 0x00034DDB
		public override void OnBackPressed()
		{
			base.OnBackPressed();
			this.OverridePendingTransition(2130772024, 2130772027);
		}

		// Token: 0x06000A4A RID: 2634 RVA: 0x0002689A File Offset: 0x00024A9A
		protected override void OnResume()
		{
			base.OnResume();
			PublicFunctions.ValidateConnection();
		}

		// Token: 0x06000A4B RID: 2635 RVA: 0x0002545B File Offset: 0x0002365B
		protected override void AttachBaseContext(Context @base)
		{
			base.AttachBaseContext(LocalizationChanger.UpdateResources(@base, "ar"));
		}
	}
}
