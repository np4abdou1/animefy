using System;
using System.Collections.Specialized;
using System.Net;
using System.Threading;
using Android.App;
using Android.Content;
using Android.Content.PM;
using Android.Gms.Ads.Interstitial;
using Android.Net;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Views.Animations;
using Android.Webkit;
using Android.Widget;
using AndroidX.AppCompat.App;
using AndroidX.Fragment.App;
using AQ.Dialogs;
using AQ.Helpers;
using AQ.Models;
using AQ.ViewModels;
using Com.Unity3d.Ads;
using Google.Android.Material.FloatingActionButton;
using Java.Interop;
using Java.Lang;

namespace AQ.Activities
{
	// Token: 0x020000CC RID: 204
	[Activity(Label = "@string/app_name", Theme = "@style/AppTheme", ConfigurationChanges = (ConfigChanges.KeyboardHidden | ConfigChanges.Orientation | ConfigChanges.ScreenSize))]
	public class NewContentActivity : AppCompatActivity
	{
		// Token: 0x060009F8 RID: 2552 RVA: 0x00033E44 File Offset: 0x00032044
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
			this.SupportActionBar.SetDisplayHomeAsUpEnabled(true);
			this.SetContentView(2131558454);
			this.newId = this.Intent.GetIntExtra("NewId", 0);
			this.title = this.Intent.GetStringExtra("NewTitle");
			this.relatedAnimeId = this.Intent.GetStringExtra("RelatedAnimeId");
			this.SupportActionBar.Title = this.title;
			this.user = UsersViewModel.GetUserProfile();
			this.userId = ((this.user == null) ? 0 : this.user.UserID);
			this.membership = ((this.user == null) ? "" : this.user.Membership);
			this.mShareFab = base.FindViewById<FloatingActionButton>(2131362779);
			this.mCommentsFab = base.FindViewById<FloatingActionButton>(2131362769);
			this.mRelatedAnimeFab = base.FindViewById<FloatingActionButton>(2131362777);
			this.mLoader = base.FindViewById<ProgressBar>(2131362835);
			this.mOfflineView = base.FindViewById<RelativeLayout>(2131362816);
			this.mOfflineRetry = base.FindViewById<Button>(2131362815);
			this.fab_open = AnimationUtils.LoadAnimation(this, 2130771998);
			this.mShareFab.StartAnimation(this.fab_open);
			this.mCommentsFab.StartAnimation(this.fab_open);
			this.mRelatedAnimeFab.StartAnimation(this.fab_open);
			this.LoadAd();
			this.LoadNewContent();
			this.mShareFab.Click += this.MShareFab_Click;
			this.mCommentsFab.Click += this.MCommentsFab_Click;
			this.mRelatedAnimeFab.Click += this.MRelatedAnimeFab_Click;
			this.mOfflineRetry.Click += this.MOfflineRetry_Click;
		}

		// Token: 0x060009F9 RID: 2553 RVA: 0x00034094 File Offset: 0x00032294
		private void LoadAd()
		{
			if (this.membership == "PREMIUM" || this.membership == "ADMIN")
			{
				if (SharedPreferencesSaves.StringSharedPreferencesGet("IsAdsRemoved") == "False")
				{
					this.ShowAd();
					return;
				}
			}
			else
			{
				this.ShowAd();
			}
		}

		// Token: 0x060009FA RID: 2554 RVA: 0x000340E8 File Offset: 0x000322E8
		private void ShowAd()
		{
			if (new Random().Next(0, SharedPreferencesSaves.IntSharedPreferencesGet("NewsAd")) == 0)
			{
				UnityAds.Load("Intersitial_N_Android", new NewContentActivity.UnityAdsLoadListener(this));
			}
		}

		// Token: 0x060009FB RID: 2555 RVA: 0x00034114 File Offset: 0x00032314
		private void MRelatedAnimeFab_Click(object sender, EventArgs e)
		{
			long num = JavaSystem.CurrentTimeMillis();
			if (num - this.mLastClickTime < NewContentActivity.CLICK_TIME_INTERVAL)
			{
				return;
			}
			this.mLastClickTime = num;
			if (this.relatedAnimeId == "")
			{
				CustomizedToast.ShowToast(this, this.Resources.GetString(2131952224), 0);
				return;
			}
			Bundle bundle = new Bundle();
			bundle.PutString("RelatedId", this.relatedAnimeId);
			RelatedAnimeSheet relatedAnimeSheet = new RelatedAnimeSheet();
			FragmentTransaction transaction = this.SupportFragmentManager.BeginTransaction();
			relatedAnimeSheet.Arguments = bundle;
			relatedAnimeSheet.Show(transaction, "RelatedAnimeSheet");
		}

		// Token: 0x060009FC RID: 2556 RVA: 0x000341A8 File Offset: 0x000323A8
		private void MCommentsFab_Click(object sender, EventArgs e)
		{
			long num = JavaSystem.CurrentTimeMillis();
			if (num - this.mLastClickTime < NewContentActivity.CLICK_TIME_INTERVAL)
			{
				return;
			}
			this.mLastClickTime = num;
			Bundle bundle = new Bundle();
			bundle.PutString("AnimeID", this.newId.ToString());
			bundle.PutString("CommType", NewsModel.News);
			Comments comments = new Comments();
			FragmentTransaction transaction = this.SupportFragmentManager.BeginTransaction();
			comments.Arguments = bundle;
			comments.Show(transaction, "Comments");
		}

		// Token: 0x060009FD RID: 2557 RVA: 0x00034224 File Offset: 0x00032424
		private void MOfflineRetry_Click(object sender, EventArgs e)
		{
			this.mOfflineView.Visibility = ViewStates.Gone;
			this.mLoader.Visibility = ViewStates.Visible;
			this.LoadNewContent();
		}

		// Token: 0x060009FE RID: 2558 RVA: 0x00034244 File Offset: 0x00032444
		private void MShareFab_Click(object sender, EventArgs e)
		{
			Intent intent = new Intent("android.intent.action.SEND");
			intent.PutExtra("android.intent.extra.TITLE", this.Resources.GetString(2131952114));
			intent.PutExtra("android.intent.extra.SUBJECT", this.Resources.GetString(2131952114) + " " + this.Resources.GetString(2131951707));
			intent.PutExtra("android.intent.extra.TEXT", string.Concat(new string[]
			{
				this.Resources.GetString(2131952114),
				": ",
				this.title,
				" ",
				SharedPreferencesSaves.StringSharedPreferencesGet("WebsiteUrl")
			}));
			intent.SetType("text/plain");
			this.StartActivity(Intent.CreateChooser(intent, this.Resources.GetString(2131952394)));
		}

		// Token: 0x060009FF RID: 2559 RVA: 0x00034328 File Offset: 0x00032528
		private void LoadNewContent()
		{
			this.mNewsWebView = base.FindViewById<WebView>(2131362784);
			this.mNewsWebView.Settings.JavaScriptEnabled = true;
			this.mNewsWebView.Settings.SetAppCacheEnabled(false);
			this.mNewsWebView.Settings.CacheMode = CacheModes.NoCache;
			this.mNewsWebView.SetWebViewClient(new NewContentActivity.NewsWebViewClient(this, this.mLoader, this.mOfflineView));
			if (SharedPreferencesSaves.StringSharedPreferencesGet("UserAppTheme") == "DARK_GRAY" || SharedPreferencesSaves.StringSharedPreferencesGet("UserAppTheme") == "LIGHT_GRAY")
			{
				this.mNewsWebView.LoadUrl("https://animeify.net/animeify/files/news/content_dark/" + this.newId.ToString() + ".html");
			}
			else
			{
				this.mNewsWebView.LoadUrl("https://animeify.net/animeify/files/news/content_light/" + this.newId.ToString() + ".html");
			}
			ThreadPool.QueueUserWorkItem(delegate(object o)
			{
				this.AddNewView();
			});
		}

		// Token: 0x06000A00 RID: 2560 RVA: 0x00034420 File Offset: 0x00032620
		public void AddNewView()
		{
			WebClient webClient = new WebClient();
			System.Uri address = new System.Uri(Constants.ApiPhp("news/add_news_view.php"));
			webClient.UploadValuesAsync(address, new NameValueCollection
			{
				{
					"NewId",
					this.newId.ToString()
				},
				{
					"Token",
					"8cnY80AZSbUCmR26Vku1VUUY4"
				}
			});
		}

		// Token: 0x06000A01 RID: 2561 RVA: 0x00034478 File Offset: 0x00032678
		public override bool OnOptionsItemSelected(IMenuItem item)
		{
			int itemId = item.ItemId;
			if (itemId == 16908332)
			{
				this.SupportFinishAfterTransition();
				return true;
			}
			return base.OnOptionsItemSelected(item);
		}

		// Token: 0x06000A02 RID: 2562 RVA: 0x0002689A File Offset: 0x00024A9A
		protected override void OnResume()
		{
			base.OnResume();
			PublicFunctions.ValidateConnection();
		}

		// Token: 0x06000A03 RID: 2563 RVA: 0x0002545B File Offset: 0x0002365B
		protected override void AttachBaseContext(Context @base)
		{
			base.AttachBaseContext(LocalizationChanger.UpdateResources(@base, "ar"));
		}

		// Token: 0x04000787 RID: 1927
		private WebView mNewsWebView;

		// Token: 0x04000788 RID: 1928
		private UsersModel user;

		// Token: 0x04000789 RID: 1929
		private int userId;

		// Token: 0x0400078A RID: 1930
		private string membership = "";

		// Token: 0x0400078B RID: 1931
		private FloatingActionButton mShareFab;

		// Token: 0x0400078C RID: 1932
		private FloatingActionButton mCommentsFab;

		// Token: 0x0400078D RID: 1933
		private FloatingActionButton mRelatedAnimeFab;

		// Token: 0x0400078E RID: 1934
		private ProgressBar mLoader;

		// Token: 0x0400078F RID: 1935
		private Button mOfflineRetry;

		// Token: 0x04000790 RID: 1936
		private RelativeLayout mOfflineView;

		// Token: 0x04000791 RID: 1937
		private Animation fab_open;

		// Token: 0x04000792 RID: 1938
		private InterstitialAd mInterstitialAd;

		// Token: 0x04000793 RID: 1939
		public int newId;

		// Token: 0x04000794 RID: 1940
		public string title;

		// Token: 0x04000795 RID: 1941
		public string relatedAnimeId;

		// Token: 0x04000796 RID: 1942
		private long mLastClickTime = JavaSystem.CurrentTimeMillis();

		// Token: 0x04000797 RID: 1943
		private static readonly long CLICK_TIME_INTERVAL = 1000L;

		// Token: 0x0200017B RID: 379
		public class NewsWebViewClient : WebViewClient
		{
			// Token: 0x06000C5C RID: 3164 RVA: 0x00044602 File Offset: 0x00042802
			public NewsWebViewClient(NewContentActivity context, ProgressBar loader, RelativeLayout offlineView)
			{
				this.mLoader = loader;
				this.mOfflineView = offlineView;
				this.context = context;
			}

			// Token: 0x06000C5D RID: 3165 RVA: 0x00044620 File Offset: 0x00042820
			[Obsolete("Deprecated Method got a Replacement")]
			public override bool ShouldOverrideUrlLoading(WebView view, string url)
			{
				if (url.Contains("youtube"))
				{
					string package = "com.google.android.youtube";
					try
					{
						Intent intent = new Intent("android.intent.action.VIEW", Android.Net.Uri.Parse(url));
						intent.SetPackage(package);
						this.context.StartActivity(intent);
					}
					catch
					{
						Intent intent2 = new Intent("android.intent.action.VIEW");
						intent2.SetData(Android.Net.Uri.Parse(url));
						this.context.StartActivity(intent2);
					}
					return true;
				}
				return false;
			}

			// Token: 0x06000C5E RID: 3166 RVA: 0x000446A4 File Offset: 0x000428A4
			public override bool ShouldOverrideUrlLoading(WebView view, IWebResourceRequest request)
			{
				if (request.Url.ToString().Contains("youtube"))
				{
					string package = "com.google.android.youtube";
					try
					{
						Intent intent = new Intent("android.intent.action.VIEW", Android.Net.Uri.Parse(request.Url.ToString()));
						intent.SetPackage(package);
						this.context.StartActivity(intent);
					}
					catch
					{
						Intent intent2 = new Intent("android.intent.action.VIEW");
						intent2.SetData(Android.Net.Uri.Parse(request.Url.ToString()));
						this.context.StartActivity(intent2);
					}
					return true;
				}
				return false;
			}

			// Token: 0x06000C5F RID: 3167 RVA: 0x00044744 File Offset: 0x00042944
			public override void OnPageCommitVisible(WebView view, string url)
			{
				base.OnPageCommitVisible(view, url);
				view.Visibility = ViewStates.Visible;
			}

			// Token: 0x06000C60 RID: 3168 RVA: 0x00044755 File Offset: 0x00042955
			public override void OnPageFinished(WebView view, string url)
			{
				base.OnPageFinished(view, url);
				this.mLoader.Visibility = ViewStates.Gone;
				view.Visibility = ViewStates.Visible;
				if (this.context.mInterstitialAd != null)
				{
					this.context.mInterstitialAd.Show(this.context);
				}
			}

			// Token: 0x04003161 RID: 12641
			private NewContentActivity context;

			// Token: 0x04003162 RID: 12642
			private ProgressBar mLoader;

			// Token: 0x04003163 RID: 12643
			private RelativeLayout mOfflineView;
		}

		// Token: 0x0200017C RID: 380
		private class UnityAdsLoadListener : Java.Lang.Object, IUnityAdsLoadListener, IJavaObject, IDisposable, IJavaPeerable
		{
			// Token: 0x06000C61 RID: 3169 RVA: 0x00044795 File Offset: 0x00042995
			public UnityAdsLoadListener(NewContentActivity context)
			{
				this.context = context;
			}

			// Token: 0x06000C62 RID: 3170 RVA: 0x000447A4 File Offset: 0x000429A4
			public void OnUnityAdsAdLoaded(string p0)
			{
				UnityAds.Show(this.context, "Intersitial_N_Android", new UnityAdsShowOptions(), new NewContentActivity.UnityAdsShowListener(this.context));
			}

			// Token: 0x06000C63 RID: 3171 RVA: 0x00004097 File Offset: 0x00002297
			public void OnUnityAdsFailedToLoad(string p0, UnityAds.UnityAdsLoadError p1, string p2)
			{
			}

			// Token: 0x04003164 RID: 12644
			private NewContentActivity context;
		}

		// Token: 0x0200017D RID: 381
		private class UnityAdsShowListener : Java.Lang.Object, IUnityAdsShowListener, IJavaObject, IDisposable, IJavaPeerable
		{
			// Token: 0x06000C64 RID: 3172 RVA: 0x000447C6 File Offset: 0x000429C6
			public UnityAdsShowListener(NewContentActivity context)
			{
				this.context = context;
			}

			// Token: 0x06000C65 RID: 3173 RVA: 0x00004097 File Offset: 0x00002297
			public void OnUnityAdsShowClick(string p0)
			{
			}

			// Token: 0x06000C66 RID: 3174 RVA: 0x00004097 File Offset: 0x00002297
			public void OnUnityAdsShowComplete(string p0, UnityAds.UnityAdsShowCompletionState p1)
			{
			}

			// Token: 0x06000C67 RID: 3175 RVA: 0x00004097 File Offset: 0x00002297
			public void OnUnityAdsShowFailure(string p0, UnityAds.UnityAdsShowError p1, string p2)
			{
			}

			// Token: 0x06000C68 RID: 3176 RVA: 0x00004097 File Offset: 0x00002297
			public void OnUnityAdsShowStart(string p0)
			{
			}

			// Token: 0x04003165 RID: 12645
			private NewContentActivity context;
		}
	}
}
