using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Net;
using System.Text;
using System.Threading;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Views;
using Android.Widget;
using AndroidX.Core.App;
using AndroidX.Fragment.App;
using AndroidX.RecyclerView.Widget;
using AQ.Activities;
using AQ.Models;
using AQ.ViewAdapters;
using AQ.ViewModels;
using Google.Android.Material.BottomSheet;
using Java.Lang;
using Newtonsoft.Json;

namespace AQ.Dialogs
{
	// Token: 0x020000B8 RID: 184
	public class RelatedAnimeSheet : RoundedBottomSheet
	{
		// Token: 0x06000850 RID: 2128 RVA: 0x00024804 File Offset: 0x00022A04
		public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
		{
			this.view = inflater.Inflate(2131558639, container, false);
			this.user = UsersViewModel.GetUserProfile();
			this.userId = ((this.user == null) ? 0 : this.user.UserID);
			this.recyclerView = this.view.FindViewById<RecyclerView>(2131362901);
			this.mReloader = this.view.FindViewById<ImageView>(2131362903);
			this.mLoader = this.view.FindViewById<ProgressBar>(2131362835);
			ThreadPool.QueueUserWorkItem(delegate(object o)
			{
				this.LoadRelatedAnime();
			});
			this.mReloader.Click += this.MReloader_Click;
			return this.view;
		}

		// Token: 0x06000851 RID: 2129 RVA: 0x000248BC File Offset: 0x00022ABC
		private void MReloader_Click(object sender, EventArgs e)
		{
			this.mReloader.Visibility = ViewStates.Gone;
			this.recyclerView.Visibility = ViewStates.Gone;
			this.mLoader.Visibility = ViewStates.Visible;
			ThreadPool.QueueUserWorkItem(delegate(object o)
			{
				this.LoadRelatedAnime();
			});
		}

		// Token: 0x06000852 RID: 2130 RVA: 0x000248F4 File Offset: 0x00022AF4
		private void LoadRelatedAnime()
		{
			WebClient webClient = new WebClient();
			Uri address = new Uri(Constants.ApiPhp("anime/load_related_anime.php"));
			webClient.UploadValuesAsync(address, new NameValueCollection
			{
				{
					"UserId",
					this.userId.ToString()
				},
				{
					"RelationId",
					base.Arguments.GetString("RelatedId", "n/a")
				},
				{
					"Language",
					base.Resources.GetString(2131951706)
				},
				{
					"Token",
					"8cnY80AZSbUCmR26Vku1VUUY4"
				}
			});
			webClient.UploadValuesCompleted += delegate(object sender, UploadValuesCompletedEventArgs e)
			{
				if (this.isDismissed)
				{
					return;
				}
				try
				{
					string @string = Encoding.UTF8.GetString(e.Result);
					this.relatedAnimeList = JsonConvert.DeserializeObject<List<AnimeModel>>(@string);
					base.Activity.RunOnUiThread(delegate()
					{
						if (this.relatedAnimeList.Count > 0)
						{
							this.adapter = new AnimeCatalogGridAdapter(this.view.Context, this.relatedAnimeList, base.Resources.GetDimensionPixelSize(2131165282));
							this.adapter.ItemClick += this.Adapter_ItemClick;
							this.adapter.ItemLongClick += this.Adapter_ItemLongClick;
							LinearLayoutManager layoutManager = new LinearLayoutManager(this.view.Context, 0, false);
							this.recyclerView.SetLayoutManager(layoutManager);
							this.recyclerView.SetAdapter(this.adapter);
						}
						this.mLoader.Visibility = ViewStates.Gone;
						this.recyclerView.Visibility = ViewStates.Visible;
					});
				}
				catch
				{
					base.Activity.RunOnUiThread(delegate()
					{
						this.mReloader.Visibility = ViewStates.Visible;
						this.recyclerView.Visibility = ViewStates.Gone;
						this.mLoader.Visibility = ViewStates.Gone;
					});
				}
			};
		}

		// Token: 0x06000853 RID: 2131 RVA: 0x00024998 File Offset: 0x00022B98
		private void Adapter_ItemLongClick(object sender, int e)
		{
			long num = JavaSystem.CurrentTimeMillis();
			if (num - this.mLastClickTime < RelatedAnimeSheet.CLICK_TIME_INTERVAL)
			{
				return;
			}
			this.mLastClickTime = num;
			AnimeModel animeModel = this.relatedAnimeList[e];
			Bundle bundle = new Bundle();
			bundle.PutString("Title", animeModel.EN_Title);
			bundle.PutString("AnimeId", animeModel.AnimeId);
			bundle.PutString("AnimeType", animeModel.Type);
			bundle.PutString("Genres", animeModel.Genres);
			AnimeDetailsGlance animeDetailsGlance = new AnimeDetailsGlance();
			FragmentTransaction transaction = base.ParentFragmentManager.BeginTransaction();
			animeDetailsGlance.Arguments = bundle;
			animeDetailsGlance.Show(transaction, "DialogDescription");
		}

		// Token: 0x06000854 RID: 2132 RVA: 0x00024A44 File Offset: 0x00022C44
		private void Adapter_ItemClick(object sender, int e)
		{
			long num = JavaSystem.CurrentTimeMillis();
			if (num - this.mLastClickTime < RelatedAnimeSheet.CLICK_TIME_INTERVAL)
			{
				return;
			}
			this.mLastClickTime = num;
			AnimeModel animeModel = this.relatedAnimeList[e];
			View itemView = this.recyclerView.FindViewHolderForAdapterPosition(e).ItemView;
			ImageView sharedElement = itemView.FindViewById<ImageView>(2131361956);
			Intent intent = new Intent(Application.Context, typeof(AnimeDetails));
			intent.PutExtra("AnimeId", animeModel.AnimeId);
			intent.PutExtra("ENTitle", animeModel.EN_Title);
			intent.PutExtra("JPTitle", animeModel.JP_Title);
			intent.PutExtra("ARTitle", animeModel.AR_Title);
			intent.PutExtra("Synonyms", animeModel.Synonyms);
			intent.PutExtra("Tags", animeModel.Tags);
			intent.PutExtra("Genres", animeModel.Genres);
			intent.PutExtra("Season", animeModel.Season);
			intent.PutExtra("Duration", animeModel.Duration);
			intent.PutExtra("Premiered", animeModel.Premiered);
			intent.PutExtra("Aired", animeModel.Aired);
			intent.PutExtra("Broadcast", animeModel.Broadcast);
			intent.PutExtra("Thumbnail", Constants.Thumbnails(animeModel.Thumbnail));
			intent.PutExtra("Trailer", animeModel.Trailer);
			intent.PutExtra("YTTrailer", animeModel.YTTrailer);
			intent.PutExtra("Creators", animeModel.Creators);
			intent.PutExtra("Status", animeModel.Status);
			intent.PutExtra("Episodes", animeModel.Episodes);
			intent.PutExtra("Score", animeModel.Score);
			intent.PutExtra("Rank", animeModel.Rank);
			intent.PutExtra("Popularity", animeModel.Popularity);
			intent.PutExtra("Rating", animeModel.Rating);
			intent.PutExtra("RelationId", animeModel.RelationId);
			intent.PutExtra("MalId", animeModel.MalId);
			intent.PutExtra("Type", animeModel.Type);
			intent.PutExtra("ItemPosition", e);
			intent.PutExtra("Transition", this.isDismissed);
			if (Build.VERSION.SdkInt >= BuildVersionCodes.Lollipop)
			{
				ActivityOptionsCompat activityOptionsCompat = ActivityOptionsCompat.MakeSceneTransitionAnimation(base.Activity, sharedElement, "catalogthumbnail");
				this.StartActivityForResult(intent, 1, activityOptionsCompat.ToBundle());
				return;
			}
			this.StartActivityForResult(intent, 1);
		}

		// Token: 0x06000855 RID: 2133 RVA: 0x00024CE6 File Offset: 0x00022EE6
		public override void OnStart()
		{
			base.OnStart();
			BottomSheetBehavior.From((View)this.view.Parent).State = 3;
		}

		// Token: 0x06000856 RID: 2134 RVA: 0x00024D09 File Offset: 0x00022F09
		public override void OnDismiss(IDialogInterface dialog)
		{
			base.OnDismiss(dialog);
			this.isDismissed = true;
		}

		// Token: 0x04000574 RID: 1396
		private View view;

		// Token: 0x04000575 RID: 1397
		private UsersModel user;

		// Token: 0x04000576 RID: 1398
		private int userId;

		// Token: 0x04000577 RID: 1399
		private RecyclerView recyclerView;

		// Token: 0x04000578 RID: 1400
		private AnimeCatalogGridAdapter adapter;

		// Token: 0x04000579 RID: 1401
		private List<AnimeModel> relatedAnimeList;

		// Token: 0x0400057A RID: 1402
		private ImageView mReloader;

		// Token: 0x0400057B RID: 1403
		private ProgressBar mLoader;

		// Token: 0x0400057C RID: 1404
		private long mLastClickTime = JavaSystem.CurrentTimeMillis();

		// Token: 0x0400057D RID: 1405
		private static readonly long CLICK_TIME_INTERVAL = 1000L;

		// Token: 0x0400057E RID: 1406
		private bool isDismissed;
	}
}
