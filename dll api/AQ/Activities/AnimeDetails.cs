using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using Android.App;
using Android.Content;
using Android.Content.PM;
using Android.Content.Res;
using Android.Graphics;
using Android.Net;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using AndroidX.AppCompat.App;
using AndroidX.Core.App;
using AndroidX.Core.Util;
using AndroidX.Fragment.App;
using AndroidX.RecyclerView.Widget;
using AQ.Dialogs;
using AQ.Fragments;
using AQ.Helpers;
using AQ.Models;
using AQ.ViewAdapters;
using AQ.ViewModels;
using Bumptech.Glide;
using Com.Wang.Avi;
using Firebase.Messaging;
using Google.Android.Material.Tabs;
using Java.Lang;
using Newtonsoft.Json;
using Warkiz.Widgets;

namespace AQ.Activities
{
	// Token: 0x020000BF RID: 191
	[Activity(Label = "@string/app_name", Theme = "@style/AppTheme", ConfigurationChanges = (ConfigChanges.KeyboardHidden | ConfigChanges.Orientation | ConfigChanges.ScreenSize))]
	public class AnimeDetails : AppCompatActivity
	{
		// Token: 0x060008A4 RID: 2212 RVA: 0x00026DB4 File Offset: 0x00024FB4
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
			this.SupportActionBar.SetTitle(2131952500);
			this.SetContentView(2131558431);
			this.animeId = this.Intent.GetStringExtra("AnimeId");
			this.enTitle = this.Intent.GetStringExtra("ENTitle");
			this.jpTitle = this.Intent.GetStringExtra("JPTitle");
			this.arTitle = this.Intent.GetStringExtra("ARTitle");
			this.synonyms = this.Intent.GetStringExtra("Synonyms");
			this.tags = this.Intent.GetStringExtra("Tags");
			this.genres = this.Intent.GetStringExtra("Genres");
			this.season = this.Intent.GetIntExtra("Season", 0);
			this.duration = this.Intent.GetIntExtra("Duration", 0);
			this.premiered = this.Intent.GetStringExtra("Premiered");
			this.aired = this.Intent.GetStringExtra("Aired");
			this.broadcast = this.Intent.GetStringExtra("Broadcast");
			this.thumbnail = this.Intent.GetStringExtra("Thumbnail");
			this.trailer = this.Intent.GetStringExtra("Trailer");
			this.ytTrailer = this.Intent.GetStringExtra("YTTrailer");
			this.creators = this.Intent.GetStringExtra("Creators");
			this.status = this.Intent.GetStringExtra("Status");
			this.episodes = this.Intent.GetIntExtra("Episodes", 0);
			this.score = this.Intent.GetFloatExtra("Score", 0f);
			this.rank = this.Intent.GetStringExtra("Rank");
			this.popularity = this.Intent.GetStringExtra("Popularity");
			this.rating = this.Intent.GetStringExtra("Rating");
			this.relationId = this.Intent.GetStringExtra("RelationId");
			this.malId = this.Intent.GetStringExtra("MalId");
			this.type = this.Intent.GetStringExtra("Type");
			this.rating = this.Intent.GetStringExtra("Rating");
			this.itemPosition = this.Intent.GetIntExtra("ItemPosition", 0);
			this.transition = this.Intent.GetBooleanExtra("Transition", false);
			this.isCommingFromRelatedAnime = this.Intent.GetBooleanExtra("CommingFromRelatedAnime", false);
			this.isCommingFromFindMore = this.Intent.GetBooleanExtra("CommingFromFindMore", false);
			this.user = UsersViewModel.GetUserProfile();
			this.userId = ((this.user == null) ? 0 : this.user.UserID);
			Glide.With(this).Load(this.thumbnail).CenterCrop().Placeholder(2131231224).Into(base.FindViewById<ImageView>(2131361895));
			this.currentOrientation = this.Resources.Configuration.Orientation;
			this.mMalSectionContent = base.FindViewById<FrameLayout>(2131361912);
			this.mEpisodesCountContent = base.FindViewById<LinearLayout>(2131361902);
			this.mSeasonContent = base.FindViewById<LinearLayout>(2131361927);
			this.mThumbnail = base.FindViewById<ImageView>(2131361937);
			this.mTitle = base.FindViewById<TextView>(2131361938);
			this.mSynonyms = base.FindViewById<TextView>(2131361935);
			this.mPlot = base.FindViewById<TextView>(2131361915);
			this.mType = base.FindViewById<TextView>(2131361942);
			this.mDuration = base.FindViewById<TextView>(2131361897);
			this.mHeaderPremiered = base.FindViewById<TextView>(2131361905);
			this.mStatus = base.FindViewById<TextView>(2131361930);
			this.mEpisodes = base.FindViewById<TextView>(2131361901);
			this.mBroadcast = base.FindViewById<TextView>(2131361893);
			this.mSeasonTitle = base.FindViewById<TextView>(2131361928);
			this.mPremiered = base.FindViewById<TextView>(2131361916);
			this.mAgeRating = base.FindViewById<TextView>(2131361891);
			this.mViewAllComments = base.FindViewById<TextView>(2131361929);
			this.mNoRelatedAnime = base.FindViewById<TextView>(2131361913);
			this.mStatusAringMarker = base.FindViewById<AVLoadingIndicatorView>(2131361931);
			this.mMalScore = base.FindViewById<TextView>(2131361911);
			this.mMalRanked = base.FindViewById<TextView>(2131361908);
			this.mMalPopularity = base.FindViewById<TextView>(2131361907);
			this.mEpisodesWatchText = base.FindViewById<TextView>(2131361899);
			this.mFavouritesCount = base.FindViewById<TextView>(2131361903);
			this.mRate = base.FindViewById<TextView>(2131361917);
			this.mMalRate = base.FindViewById<TextView>(2131361909);
			this.mRatersCount = base.FindViewById<TextView>(2131361922);
			this.mMalRatersCount = base.FindViewById<TextView>(2131361910);
			this.mRatingSeeker = base.FindViewById<IndicatorSeekBar>(2131361921);
			this.mGenresRecyclerView = base.FindViewById<RecyclerView>(2131361904);
			this.mStudiosRecyclerView = base.FindViewById<RecyclerView>(2131361934);
			this.mRelatedsRecyclerView = base.FindViewById<RecyclerView>(2131361923);
			this.mTrailerThumbnail = base.FindViewById<ImageView>(2131361941);
			this.mEpisodesWatchIcon = base.FindViewById<ImageView>(2131361898);
			this.mTrailerPaly = base.FindViewById<RelativeLayout>(2131361939);
			this.mEpisodesWatch = base.FindViewById<RelativeLayout>(2131361900);
			this.mFavouriteIcon = base.FindViewById<ImageView>(2131361943);
			this.mLibraryIcon = base.FindViewById<ImageView>(2131361944);
			this.mReload = base.FindViewById<ImageView>(2131361925);
			this.mComments = base.FindViewById<ImageView>(2131361894);
			this.mNoStudios = base.FindViewById<TextView>(2131361914);
			this.mRateDeleteIcon = base.FindViewById<ImageView>(2131361919);
			this.mLoader = base.FindViewById<ProgressBar>(2131361906);
			this.mRateDeleteProgressBar = base.FindViewById<ProgressBar>(2131361920);
			this.mTabLayout = base.FindViewById<TabLayout>(2131361936);
			this.HandleUiAssignments();
			ThreadPool.QueueUserWorkItem(delegate(object o)
			{
				this.LoadAnimeDetails();
			});
			this.mTitle.LongClick += this.MTitle_LongClick;
			this.mPlot.Click += this.MPlot_Click;
			this.mThumbnail.Click += this.MThumbnail_Click;
			this.mTrailerPaly.Click += this.MTrailerPaly_Click;
			this.mEpisodesWatch.Click += this.MEpisodesWatch_Click;
			this.mViewAllComments.Click += this.MViewAllComments_Click;
			this.mComments.Click += this.MComments_Click;
			this.mRateDeleteIcon.Click += this.MRateDeleteIcon_Click;
			this.mReload.Click += this.MReload_Click;
			this.mTabLayout.TabSelected += this.MTabLayout_TabSelected;
			this.mRatingSeeker.OnSeekChangeListener = new AnimeDetails.SeekChangeListener(this);
		}

		// Token: 0x060008A5 RID: 2213 RVA: 0x00027580 File Offset: 0x00025780
		private void MTitle_LongClick(object sender, View.LongClickEventArgs e)
		{
			ClipboardManager clipboardManager = (ClipboardManager)this.GetSystemService("clipboard");
			clipboardManager.PrimaryClip = ClipData.NewPlainText(this.jpTitle, this.mTitle.Text);
			CustomizedToast.ShowToast(this, this.Resources.GetString(2131952498), 0);
		}

		// Token: 0x060008A6 RID: 2214 RVA: 0x000275D1 File Offset: 0x000257D1
		private void MRateDeleteIcon_Click(object sender, EventArgs e)
		{
			this.mRateDeleteIcon.Visibility = ViewStates.Gone;
			this.mRateDeleteProgressBar.Visibility = ViewStates.Visible;
			this.DeleteRate();
		}

		// Token: 0x060008A7 RID: 2215 RVA: 0x000275F4 File Offset: 0x000257F4
		private void MReload_Click(object sender, EventArgs e)
		{
			this.mLoader.Visibility = ViewStates.Visible;
			this.mNoRelatedAnime.Visibility = ViewStates.Gone;
			this.mReload.Visibility = ViewStates.Gone;
			this.mRelatedsRecyclerView.Visibility = ViewStates.Gone;
			ThreadPool.QueueUserWorkItem(delegate(object o)
			{
				this.LoadAnimeDetails();
			});
		}

		// Token: 0x060008A8 RID: 2216 RVA: 0x00027644 File Offset: 0x00025844
		private void MPlot_Click(object sender, EventArgs e)
		{
			if (this.isPlotExpanded)
			{
				if (this.Resources.GetString(2131951706) == "AR")
				{
					this.mPlot.Post(new Suffixer(this, this.mPlot, 7, this.Resources.GetString(2131951949)));
				}
				else
				{
					this.mPlot.Post(new Suffixer(this, this.mPlot, 10, this.Resources.GetString(2131951949)));
				}
				this.isPlotExpanded = false;
				return;
			}
			this.mPlot.SetMaxLines(this.plotMaxLines);
			this.isPlotExpanded = true;
		}

		// Token: 0x060008A9 RID: 2217 RVA: 0x000276EC File Offset: 0x000258EC
		private void MTabLayout_TabSelected(object sender, TabLayout.TabSelectedEventArgs e)
		{
			if (this.isLoading)
			{
				this.mTabLayout.GetTabAt(this.tapSelcted).Select();
				return;
			}
			if (e.Tab.Position != 0)
			{
				if (e.Tab.Position == 1)
				{
					this.tapSelcted = 1;
					if (this.relationId != "")
					{
						if (!this.isRelatedCharctersLoaded)
						{
							this.isLoading = true;
							ThreadPool.QueueUserWorkItem(delegate(object o)
							{
								this.LoadRelatedCharacters();
							});
							return;
						}
						if (this.relatedCharactersList.Count<CharacterModel>() == 0)
						{
							this.mNoRelatedAnime.Visibility = ViewStates.Visible;
							this.mRelatedsRecyclerView.Visibility = ViewStates.Gone;
							this.mNoRelatedAnime.Text = this.Resources.GetString(2131952240);
							return;
						}
						this.mRelatedsRecyclerView.SetLayoutManager(this.relatedCharactersLayoutManager);
						this.mRelatedsRecyclerView.SetAdapter(this.mAdapterRelatedCharacters);
						this.mNoRelatedAnime.Visibility = ViewStates.Gone;
						this.mRelatedsRecyclerView.Visibility = ViewStates.Visible;
						return;
					}
					else
					{
						this.mNoRelatedAnime.Visibility = ViewStates.Visible;
						this.mRelatedsRecyclerView.Visibility = ViewStates.Gone;
						this.mNoRelatedAnime.Text = this.Resources.GetString(2131952240);
					}
				}
				return;
			}
			this.tapSelcted = 0;
			if (!this.isRelatedAnimeLoaded)
			{
				this.mNoRelatedAnime.Visibility = ViewStates.Visible;
				this.mRelatedsRecyclerView.Visibility = ViewStates.Gone;
				this.mNoRelatedAnime.Text = this.Resources.GetString(2131951826);
				return;
			}
			if (this.animeDetails.RelatedAnime.Count<AnimeModel>() == 0)
			{
				this.mNoRelatedAnime.Visibility = ViewStates.Visible;
				this.mRelatedsRecyclerView.Visibility = ViewStates.Gone;
				this.mNoRelatedAnime.Text = this.Resources.GetString(2131952239);
				return;
			}
			this.mRelatedsRecyclerView.SetLayoutManager(new LinearLayoutManager(this, 0, false));
			this.mRelatedsRecyclerView.SetAdapter(this.mAdapterRelatedAnime);
			this.mNoRelatedAnime.Visibility = ViewStates.Gone;
			this.mRelatedsRecyclerView.Visibility = ViewStates.Visible;
		}

		// Token: 0x060008AA RID: 2218 RVA: 0x000278F0 File Offset: 0x00025AF0
		private void MFavouriteIcon_Click(object sender, EventArgs e)
		{
			if (this.userId == 0)
			{
				this.SignInPormpt(this.Resources.GetString(2131951866));
				return;
			}
			if (this.animeDetails.Library.Favourite == 1)
			{
				this.mFavouriteIcon.SetImageResource(2131231080);
				this.animeDetails.Library.Favourite = 0;
				this.deleteFavouriteOnReturn = true;
			}
			else
			{
				this.mFavouriteIcon.SetImageResource(2131231083);
				this.animeDetails.Library.Favourite = 1;
				this.deleteFavouriteOnReturn = false;
			}
			FavouritesViewModel.FavouritesCrud(this.userId, this.animeId, this.type);
		}

		// Token: 0x060008AB RID: 2219 RVA: 0x00027998 File Offset: 0x00025B98
		private void MAddToLibrary_Click(object sender, EventArgs e)
		{
			if (this.userId == 0)
			{
				this.SignInPormpt(this.Resources.GetString(2131951866));
				return;
			}
			new LibrarySheet().Show(this.SupportFragmentManager.BeginTransaction(), "LibrarySheet");
		}

		// Token: 0x060008AC RID: 2220 RVA: 0x000279D4 File Offset: 0x00025BD4
		private void MComments_Click(object sender, EventArgs e)
		{
			long num = JavaSystem.CurrentTimeMillis();
			if (num - this.mLastClickTime < AnimeDetails.CLICK_TIME_INTERVAL)
			{
				return;
			}
			this.mLastClickTime = num;
			Bundle bundle = new Bundle();
			bundle.PutString("AnimeID", this.animeId);
			bundle.PutString("CommType", this.type);
			Comments comments = new Comments();
			FragmentTransaction transaction = this.SupportFragmentManager.BeginTransaction();
			comments.Arguments = bundle;
			comments.Show(transaction, "Comments");
		}

		// Token: 0x060008AD RID: 2221 RVA: 0x00027A4C File Offset: 0x00025C4C
		private void MViewAllComments_Click(object sender, EventArgs e)
		{
			long num = JavaSystem.CurrentTimeMillis();
			if (num - this.mLastClickTime < AnimeDetails.CLICK_TIME_INTERVAL)
			{
				return;
			}
			this.mLastClickTime = num;
			Bundle bundle = new Bundle();
			bundle.PutString("AnimeID", this.animeId);
			bundle.PutString("CommType", this.type);
			Comments comments = new Comments();
			FragmentTransaction transaction = this.SupportFragmentManager.BeginTransaction();
			comments.Arguments = bundle;
			comments.Show(transaction, "Comments");
		}

		// Token: 0x060008AE RID: 2222 RVA: 0x00027AC4 File Offset: 0x00025CC4
		private void MEpisodesWatch_Click(object sender, EventArgs e)
		{
			long num = JavaSystem.CurrentTimeMillis();
			if (num - this.mLastClickTime < AnimeDetails.CLICK_TIME_INTERVAL)
			{
				return;
			}
			this.mLastClickTime = num;
			if (!(this.type == "MOVIE"))
			{
				Intent intent = new Intent(this, typeof(EpisodesActivity));
				intent.PutExtra("AnimeId", this.animeId);
				intent.PutExtra("Title", this.enTitle);
				intent.PutExtra("Type", this.type);
				this.StartActivity(intent);
				return;
			}
			if (this.episodes > 1)
			{
				Intent intent2 = new Intent(this, typeof(EpisodesActivity));
				intent2.PutExtra("AnimeId", this.animeId);
				intent2.PutExtra("Title", this.enTitle);
				intent2.PutExtra("Type", this.type);
				this.StartActivity(intent2);
				return;
			}
			Intent intent3 = new Intent(this, typeof(ServersListActivity));
			intent3.PutExtra("AnimeId", this.animeId);
			intent3.PutExtra("AnimeTitle", this.enTitle);
			intent3.PutExtra("AnimeType", this.type);
			this.StartActivity(intent3);
		}

		// Token: 0x060008AF RID: 2223 RVA: 0x00027BF8 File Offset: 0x00025DF8
		private void HandleUiAssignments()
		{
			this.mTitle.Text = this.enTitle;
			if (this.synonyms != "")
			{
				this.mSynonyms.Text = this.synonyms;
			}
			else
			{
				this.mSynonyms.Visibility = ViewStates.Gone;
			}
			this.plotMaxLines = this.mPlot.MaxLines;
			this.mHeaderPremiered.Text = this.aired;
			if (this.Resources.GetString(2131951706) == "AR")
			{
				this.mPlot.Post(new Suffixer(this, this.mPlot, 7, this.Resources.GetString(2131951949)));
			}
			else
			{
				this.mPlot.Post(new Suffixer(this, this.mPlot, 10, this.Resources.GetString(2131951949)));
			}
			if (this.rating == "ALLAGES")
			{
				this.mAgeRating.Text = this.Resources.GetString(2131951679);
			}
			if (this.rating == "CHILDREN")
			{
				this.mAgeRating.Text = this.Resources.GetString(2131951782);
			}
			else
			{
				this.mAgeRating.Text = this.rating;
			}
			if (this.type == "MOVIE")
			{
				this.mEpisodesCountContent.Visibility = ViewStates.Gone;
				this.mEpisodesWatchText.Text = this.Resources.GetString(2131952570);
				this.mEpisodesWatchIcon.SetImageResource(2131231238);
				if (this.status == "AIRED")
				{
					this.mStatus.Text = this.Resources.GetString(2131952436);
				}
				if (this.premiered != "")
				{
					this.mSeasonTitle.Text = this.Resources.GetString(2131951676);
					this.mPremiered.Text = LanguageConvertor.PremieredMonth(this, this.premiered);
				}
				else
				{
					this.mSeasonContent.Visibility = ViewStates.Gone;
				}
			}
			else
			{
				if (this.status == "AIRING")
				{
					this.mStatusAringMarker.Visibility = ViewStates.Visible;
					this.mStatus.SetTextColor(Color.ParseColor("#1DB954"));
					this.mStatus.Text = this.Resources.GetString(2131952434);
					this.mEpisodes.Text = this.episodes.ToString() + " (" + this.Resources.GetString(2131952413) + ")";
					this.mBroadcast.Text = string.Concat(new string[]
					{
						" (",
						this.Resources.GetString(2131951741),
						" ",
						LanguageConvertor.DayOfWeek(this, this.broadcast),
						") "
					});
					this.mBroadcast.Visibility = ViewStates.Visible;
				}
				else if (this.status == "AIRED")
				{
					this.mStatus.Text = this.Resources.GetString(2131952433);
					this.mEpisodes.Text = this.episodes.ToString();
				}
				if (this.season > 0)
				{
					TextView textView = this.mSeasonTitle;
					textView.Text = textView.Text + " " + this.season.ToString();
				}
				else if (this.premiered != "")
				{
					this.mPremiered.Text = LanguageConvertor.Premiered(this, this.premiered);
				}
				else
				{
					this.mSeasonContent.Visibility = ViewStates.Gone;
				}
			}
			if (this.status == "PAUSED")
			{
				this.mStatus.Text = this.Resources.GetString(2131952438);
				this.mEpisodes.Text = this.episodes.ToString();
			}
			else if (this.status == "UPCOMING")
			{
				this.mStatus.SetTextColor(Color.ParseColor("#1DB954"));
				this.mStatus.Text = this.Resources.GetString(2131952439);
				this.mEpisodesWatchText.Text = this.Resources.GetString(2131952439);
				this.mEpisodesCountContent.Visibility = ViewStates.Gone;
			}
			else if (this.status == "UNAVAILABLE")
			{
				this.mStatus.Text = this.Resources.GetString(2131952578);
				this.mEpisodesWatch.Enabled = false;
				this.mEpisodesWatchText.SetTextColor(Color.ParseColor("#80FFFFFF"));
				this.mEpisodesWatchText.Text = this.Resources.GetString(2131952578);
				this.mEpisodesWatchIcon.SetImageResource(2131231237);
				this.mEpisodesCountContent.Visibility = ViewStates.Gone;
			}
			if (this.episodes == -1)
			{
				this.mEpisodes.Text = this.Resources.GetString(2131952249);
			}
			this.TypeUiPrepare();
			this.GernesUiPrepare();
			if (this.creators != "")
			{
				this.StudiosUiPrepare();
			}
			else
			{
				this.mNoStudios.Visibility = ViewStates.Visible;
				this.mStudiosRecyclerView.Visibility = ViewStates.Gone;
			}
			this.mDuration.Text = Calculators.ConvertMinutesToDuration(this, this.duration);
			Glide.With(this).Load(this.thumbnail).CenterCrop().Placeholder(2131231224).Into(this.mThumbnail);
			if (this.ytTrailer != "")
			{
				Glide.With(this).Load(string.Format("https://img.youtube.com/vi/{0}/0.jpg", this.ytTrailer)).CenterCrop().Placeholder(2131231224).Into(this.mTrailerThumbnail);
			}
			else
			{
				Glide.With(this).Load(this.thumbnail).CenterCrop().Placeholder(2131231224).Into(this.mTrailerThumbnail);
			}
			ThreadPool.QueueUserWorkItem(delegate(object o)
			{
				this.MalUiPrepare();
			});
		}

		// Token: 0x060008B0 RID: 2224 RVA: 0x00028214 File Offset: 0x00026414
		private void GernesUiPrepare()
		{
			this.mAdapterGenres = new ClickableTextsAdapter2(this, LanguageConvertor.GenresToList(this, this.genres));
			this.mAdapterGenres.ItemClick += this.MAdapterGenres_ItemClick;
			this.mGenresRecyclerView.SetLayoutManager(new LinearLayoutManager(this, 0, false));
			this.mGenresRecyclerView.SetAdapter(this.mAdapterGenres);
		}

		// Token: 0x060008B1 RID: 2225 RVA: 0x00028274 File Offset: 0x00026474
		private void StudiosUiPrepare()
		{
			string[] items = this.creators.Split(", ", StringSplitOptions.None);
			this.mAdapterStudios = new ClickableTextsAdapter3(this, items);
			this.mAdapterStudios.ItemClick += this.MAdapterStudios_ItemClick;
			this.mStudiosRecyclerView.SetLayoutManager(new LinearLayoutManager(this, 0, false));
			this.mStudiosRecyclerView.SetAdapter(this.mAdapterStudios);
		}

		// Token: 0x060008B2 RID: 2226 RVA: 0x000282DC File Offset: 0x000264DC
		private void TypeUiPrepare()
		{
			if (this.type == "OVA")
			{
				this.mType.Text = " " + this.Resources.GetString(2131952541) + " ";
				return;
			}
			if (this.type == "SPECIAL")
			{
				this.mType.Text = " " + this.Resources.GetString(2131952542) + " ";
				return;
			}
			if (this.type == "ONA")
			{
				this.mType.Text = " " + this.Resources.GetString(2131952540) + " ";
				return;
			}
			if (this.type == "CARTOON")
			{
				this.mType.Text = " " + this.Resources.GetString(2131952537);
				return;
			}
			if (this.type == "MOVIE")
			{
				this.mType.Text = " " + this.Resources.GetString(2131952539);
				return;
			}
			this.mType.Text = " " + this.Resources.GetString(2131952536);
		}

		// Token: 0x060008B3 RID: 2227 RVA: 0x00028438 File Offset: 0x00026638
		private void MalUiPrepare()
		{
			try
			{
				using (WebClient webClient = new WebClient())
				{
					string value = webClient.DownloadString("https://api.jikan.moe/v4/anime/" + this.malId);
					JikanModel exam = new JikanModel();
					exam = JsonConvert.DeserializeObject<JikanModel>(value);
					base.RunOnUiThread(delegate()
					{
						if (exam != null)
						{
							this.mMalRate.Text = exam.data.score.ToString();
							this.mMalScore.Text = string.Format("{0:N0}", exam.data.favorites);
							this.mMalRanked.Text = " #" + exam.data.rank.ToString() + " ";
							this.mMalPopularity.Text = " #" + exam.data.popularity.ToString() + " ";
							this.mMalRatersCount.Text = string.Concat(new string[]
							{
								"(",
								string.Format("{0:N0}", exam.data.scored_by),
								" ",
								this.Resources.GetString(2131952293),
								")"
							});
						}
					});
				}
			}
			catch
			{
				base.RunOnUiThread(delegate()
				{
					this.mMalSectionContent.Visibility = ViewStates.Gone;
				});
			}
		}

		// Token: 0x060008B4 RID: 2228 RVA: 0x000284D8 File Offset: 0x000266D8
		private void MAdapterGenres_ItemClick(object sender, int e)
		{
			long num = JavaSystem.CurrentTimeMillis();
			if (num - this.mLastClickTime < AnimeDetails.CLICK_TIME_INTERVAL)
			{
				return;
			}
			this.mLastClickTime = num;
			View itemView = this.mGenresRecyclerView.FindViewHolderForAdapterPosition(e).ItemView;
			TextView textView = itemView.FindViewById<TextView>(2131363147);
			if (this.isCommingFromFindMore)
			{
				if (this.transition || this.isOrientationChanged)
				{
					this.Finish();
				}
				else
				{
					this.SupportFinishAfterTransition();
				}
				Intent intent = new Intent();
				intent.PutExtra("FindMoreType", "GENRE");
				intent.PutExtra("FindMoreData", this.genres.Split(", ", StringSplitOptions.None)[e]);
				intent.PutExtra("DataTitle", textView.Text);
				intent.PutExtra("ItemPosistion", this.itemPosition);
				base.SetResult(Result.Ok, intent);
				return;
			}
			Intent intent2 = new Intent(Application.Context, typeof(FindMoreActivity));
			intent2.PutExtra("FindMoreDataType", "GENRE");
			intent2.PutExtra("FindMoreData", this.genres.Split(", ", StringSplitOptions.None)[e]);
			intent2.PutExtra("DataTitle", textView.Text);
			if (Build.VERSION.SdkInt >= BuildVersionCodes.Lollipop)
			{
				ActivityOptionsCompat activityOptionsCompat = ActivityOptionsCompat.MakeSceneTransitionAnimation(this, textView, "textviewdatabutton");
				this.StartActivity(intent2, activityOptionsCompat.ToBundle());
				return;
			}
			this.StartActivity(intent2);
		}

		// Token: 0x060008B5 RID: 2229 RVA: 0x00028638 File Offset: 0x00026838
		private void MAdapterStudios_ItemClick(object sender, int e)
		{
			long num = JavaSystem.CurrentTimeMillis();
			if (num - this.mLastClickTime < AnimeDetails.CLICK_TIME_INTERVAL)
			{
				return;
			}
			this.mLastClickTime = num;
			View itemView = this.mStudiosRecyclerView.FindViewHolderForAdapterPosition(e).ItemView;
			TextView textView = itemView.FindViewById<TextView>(2131363147);
			if (this.isCommingFromFindMore)
			{
				if (this.transition || this.isOrientationChanged)
				{
					this.Finish();
				}
				else
				{
					this.SupportFinishAfterTransition();
				}
				Intent intent = new Intent();
				intent.PutExtra("FindMoreType", "STUDIOS");
				intent.PutExtra("FindMoreData", textView.Text);
				intent.PutExtra("DataTitle", textView.Text);
				intent.PutExtra("ItemPosistion", this.itemPosition);
				base.SetResult(Result.Ok, intent);
				return;
			}
			Intent intent2 = new Intent(Application.Context, typeof(FindMoreActivity));
			intent2.PutExtra("FindMoreType", "STUDIOS");
			intent2.PutExtra("FindMoreData", textView.Text);
			intent2.PutExtra("DataTitle", textView.Text);
			if (Build.VERSION.SdkInt >= BuildVersionCodes.Lollipop)
			{
				ActivityOptionsCompat activityOptionsCompat = ActivityOptionsCompat.MakeSceneTransitionAnimation(this, textView, "textviewdatabutton");
				this.StartActivity(intent2, activityOptionsCompat.ToBundle());
				return;
			}
			this.StartActivity(intent2);
		}

		// Token: 0x060008B6 RID: 2230 RVA: 0x0002877C File Offset: 0x0002697C
		private void MThumbnail_Click(object sender, EventArgs e)
		{
			Bundle bundle = new Bundle();
			bundle.PutString("ThumbnailLink", this.thumbnail);
			ThumbnailsDialog thumbnailsDialog = new ThumbnailsDialog();
			FragmentTransaction transaction = this.SupportFragmentManager.BeginTransaction();
			thumbnailsDialog.Arguments = bundle;
			thumbnailsDialog.Show(transaction, "ThumbNailDialog");
		}

		// Token: 0x060008B7 RID: 2231 RVA: 0x000287C8 File Offset: 0x000269C8
		private void MTrailerPaly_Click(object sender, EventArgs e)
		{
			if (this.ytTrailer != "")
			{
				string text = "com.google.android.youtube";
				Intent launchIntentForPackage = this.PackageManager.GetLaunchIntentForPackage(text);
				Intent intent = new Intent("android.intent.action.VIEW");
				if (launchIntentForPackage != null)
				{
					intent.SetPackage(text);
					intent.SetData(Android.Net.Uri.Parse(string.Format("https://www.youtube.com/watch?v={0}", this.ytTrailer)));
				}
				else
				{
					intent.SetData(Android.Net.Uri.Parse(string.Format("https://www.youtube.com/watch?v={0}", this.ytTrailer)));
				}
				this.StartActivity(intent);
				return;
			}
			Bundle bundle = new Bundle();
			bundle.PutString("AnimeType", this.type);
			bundle.PutString("TrailerLink", this.trailer);
			TrailersDialog trailersDialog = new TrailersDialog();
			FragmentTransaction transaction = this.SupportFragmentManager.BeginTransaction();
			trailersDialog.Arguments = bundle;
			trailersDialog.Show(transaction, "TrailerDialog");
		}

		// Token: 0x060008B8 RID: 2232 RVA: 0x000288A8 File Offset: 0x00026AA8
		private void LoadAnimeDetails()
		{
			WebClient webClient = new WebClient();
			System.Uri address = new System.Uri(Constants.ApiPhp("anime/load_anime_details.php"));
			webClient.UploadValuesAsync(address, new NameValueCollection
			{
				{
					"UserId",
					this.userId.ToString()
				},
				{
					"Language",
					this.Resources.GetString(2131951706)
				},
				{
					"AnimeId",
					this.animeId
				},
				{
					"AnimeRelationId",
					this.relationId
				},
				{
					"Token",
					"8cnY80AZSbUCmR26Vku1VUUY4"
				}
			});
			webClient.UploadValuesCompleted += delegate(object sender, UploadValuesCompletedEventArgs e)
			{
				try
				{
					string @string = Encoding.UTF8.GetString(e.Result);
					this.animeDetails = JsonConvert.DeserializeObject<AnimeDetailsModel>(@string);
					base.RunOnUiThread(delegate()
					{
						if (this.animeDetails != null)
						{
							this.mPlot.Text = this.animeDetails.Plot;
							this.PrepareUserLibrary();
							if (this.animeDetails.AnimeStatistics != null)
							{
								this.mFavouritesCount.Text = string.Format("{0:N0}", this.animeDetails.AnimeStatistics.library_favourites);
								this.CalculateAnimeRating(this.animeDetails.AnimeStatistics);
							}
							this.mAdapterRelatedAnime = new AnimeCatalogGridAdapter(this, this.animeDetails.RelatedAnime, this.Resources.GetDimensionPixelSize(2131165282));
							this.mAdapterRelatedAnime.ItemClick += this.MAdapterRelatedAnime_ItemClick;
							this.mAdapterRelatedAnime.ItemLongClick += this.MAdapterRelatedAnime_ItemLongClick;
							this.mRelatedsRecyclerView.SetLayoutManager(new LinearLayoutManager(this, 0, false));
							this.mRelatedsRecyclerView.SetAdapter(this.mAdapterRelatedAnime);
							if (this.animeDetails.RelatedAnime.Count<AnimeModel>() == 0)
							{
								this.mNoRelatedAnime.Visibility = ViewStates.Visible;
								this.mRelatedsRecyclerView.Visibility = ViewStates.Gone;
								this.mNoRelatedAnime.Text = this.Resources.GetString(2131952239);
							}
							else
							{
								this.mNoRelatedAnime.Visibility = ViewStates.Gone;
								this.mRelatedsRecyclerView.Visibility = ViewStates.Visible;
							}
							this.isRelatedAnimeLoaded = true;
						}
						else
						{
							this.mNoRelatedAnime.Visibility = ViewStates.Visible;
							this.mReload.Visibility = ViewStates.Visible;
							this.mRelatedsRecyclerView.Visibility = ViewStates.Gone;
							this.mNoRelatedAnime.Text = this.Resources.GetString(2131951826);
						}
						this.mLoader.Visibility = ViewStates.Gone;
					});
				}
				catch
				{
					base.RunOnUiThread(delegate()
					{
						this.mLoader.Visibility = ViewStates.Gone;
						this.mNoRelatedAnime.Visibility = ViewStates.Visible;
						this.mReload.Visibility = ViewStates.Visible;
						this.mRelatedsRecyclerView.Visibility = ViewStates.Gone;
						this.mNoRelatedAnime.Text = this.Resources.GetString(2131951826);
					});
				}
				this.isLoading = false;
			};
		}

		// Token: 0x060008B9 RID: 2233 RVA: 0x00028950 File Offset: 0x00026B50
		private void PrepareUserLibrary()
		{
			if (this.animeDetails.Library.Favourite == 1)
			{
				this.mFavouriteIcon.SetImageResource(2131231083);
			}
			else
			{
				this.mFavouriteIcon.SetImageResource(2131231080);
			}
			string library = this.animeDetails.Library.Library;
			if (!(library == "WATCH_CURRENTLY"))
			{
				if (!(library == "WATCH_LATER"))
				{
					if (!(library == "WATCH_DONE"))
					{
						this.mLibraryIcon.SetImageResource(2131231158);
					}
					else
					{
						this.mLibraryIcon.SetImageResource(2131231013);
					}
				}
				else
				{
					this.mLibraryIcon.SetImageResource(2131231186);
				}
			}
			else
			{
				this.mLibraryIcon.SetImageResource(2131231004);
			}
			this.mFavouriteIcon.Click += this.MFavouriteIcon_Click;
			this.mLibraryIcon.Click += this.MAddToLibrary_Click;
		}

		// Token: 0x060008BA RID: 2234 RVA: 0x00028A40 File Offset: 0x00026C40
		private void MAdapterRelatedAnime_ItemLongClick(object sender, int e)
		{
			long num = JavaSystem.CurrentTimeMillis();
			if (num - this.mLastClickTime < AnimeDetails.CLICK_TIME_INTERVAL)
			{
				return;
			}
			this.mLastClickTime = num;
			AnimeModel animeModel = this.animeDetails.RelatedAnime[this.itemPosition];
			Bundle bundle = new Bundle();
			bundle.PutString("Title", animeModel.EN_Title);
			bundle.PutString("AnimeId", animeModel.AnimeId);
			bundle.PutString("AnimeType", animeModel.Type);
			bundle.PutString("Genres", animeModel.Genres);
			AnimeDetailsGlance animeDetailsGlance = new AnimeDetailsGlance();
			FragmentTransaction transaction = this.SupportFragmentManager.BeginTransaction();
			animeDetailsGlance.Arguments = bundle;
			animeDetailsGlance.Show(transaction, "AnimeDetailsGlance");
		}

		// Token: 0x060008BB RID: 2235 RVA: 0x00028AF4 File Offset: 0x00026CF4
		private void MAdapterRelatedAnime_ItemClick(object sender, int e)
		{
			long num = JavaSystem.CurrentTimeMillis();
			if (num - this.mLastClickTime < AnimeDetails.CLICK_TIME_INTERVAL)
			{
				return;
			}
			this.mLastClickTime = num;
			AnimeModel animeModel = this.animeDetails.RelatedAnime[e];
			View itemView = this.mRelatedsRecyclerView.FindViewHolderForAdapterPosition(e).ItemView;
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
			intent.PutExtra("Transition", false);
			intent.PutExtra("CommingFromRelatedAnime", true);
			if (Build.VERSION.SdkInt >= BuildVersionCodes.Lollipop)
			{
				ActivityOptionsCompat activityOptionsCompat = ActivityOptionsCompat.MakeSceneTransitionAnimation(this, sharedElement, "catalogthumbnail");
				this.StartActivityForResult(intent, 1, activityOptionsCompat.ToBundle());
			}
			else
			{
				this.StartActivityForResult(intent, 1);
			}
			if (this.isCommingFromRelatedAnime)
			{
				this.Finish();
			}
		}

		// Token: 0x060008BC RID: 2236 RVA: 0x00028DB0 File Offset: 0x00026FB0
		private void SetRate(int rate)
		{
			WebClient webClient = new WebClient();
			System.Uri address = new System.Uri(Constants.ApiPhp("anime/rating/rate_set.php"));
			webClient.UploadValuesAsync(address, new NameValueCollection
			{
				{
					"AnimeId",
					this.animeId
				},
				{
					"Episode",
					0.ToString()
				},
				{
					"UserId",
					this.userId.ToString()
				},
				{
					"Rate",
					rate.ToString()
				},
				{
					"Token",
					"8cnY80AZSbUCmR26Vku1VUUY4"
				}
			});
			webClient.UploadValuesCompleted += delegate(object sender, UploadValuesCompletedEventArgs e)
			{
				try
				{
					string @string = Encoding.UTF8.GetString(e.Result);
					AnimeStatistics statistics = JsonConvert.DeserializeObject<AnimeStatistics>(@string);
					base.RunOnUiThread(delegate()
					{
						this.CalculateAnimeRating(statistics);
						this.mRateDeleteProgressBar.Visibility = ViewStates.Gone;
					});
				}
				catch
				{
					base.RunOnUiThread(delegate()
					{
						this.mRatingSeeker.SetProgress(1f);
						this.mRateDeleteProgressBar.Visibility = ViewStates.Gone;
					});
				}
			};
		}

		// Token: 0x060008BD RID: 2237 RVA: 0x00028E50 File Offset: 0x00027050
		private void DeleteRate()
		{
			WebClient webClient = new WebClient();
			System.Uri address = new System.Uri(Constants.ApiPhp("anime/rating/rate_delete.php"));
			webClient.UploadValuesAsync(address, new NameValueCollection
			{
				{
					"UserId",
					this.userId.ToString()
				},
				{
					"AnimeId",
					this.animeId
				},
				{
					"Episode",
					0.ToString()
				},
				{
					"Type",
					this.type
				},
				{
					"Token",
					"8cnY80AZSbUCmR26Vku1VUUY4"
				}
			});
			webClient.UploadValuesCompleted += delegate(object sender, UploadValuesCompletedEventArgs e)
			{
				try
				{
					string @string = Encoding.UTF8.GetString(e.Result);
					AnimeStatistics animeStatistics = JsonConvert.DeserializeObject<AnimeStatistics>(@string);
					if (animeStatistics != null)
					{
						this.mRateDeleteIcon.Visibility = ViewStates.Gone;
						this.mRateDeleteProgressBar.Visibility = ViewStates.Gone;
						this.mRatingSeeker.SetProgress(1f);
						this.CalculateAnimeRating(animeStatistics);
					}
					else
					{
						this.mRateDeleteIcon.Visibility = ViewStates.Visible;
						this.mRateDeleteProgressBar.Visibility = ViewStates.Gone;
					}
				}
				catch
				{
					this.mRateDeleteIcon.Visibility = ViewStates.Visible;
					this.mRateDeleteProgressBar.Visibility = ViewStates.Gone;
				}
			};
		}

		// Token: 0x060008BE RID: 2238 RVA: 0x00028EF0 File Offset: 0x000270F0
		private float CalculateRateing(int[] rating)
		{
			return (float)(rating[0] + 2 * rating[1] + 3 * rating[2] + 4 * rating[3] + 5 * rating[4] + 6 * rating[5] + 7 * rating[6] + 8 * rating[7] + 9 * rating[8] + 10 * rating[9]) / (float)(rating[0] + rating[1] + rating[2] + rating[3] + rating[4] + rating[5] + rating[6] + rating[7] + rating[8] + rating[9]);
		}

		// Token: 0x060008BF RID: 2239 RVA: 0x00028F64 File Offset: 0x00027164
		private void CalculateAnimeRating(AnimeStatistics statistics)
		{
			if (statistics.UserRate > 0)
			{
				this.mRateDeleteIcon.Visibility = ViewStates.Visible;
			}
			else
			{
				this.mRateDeleteIcon.Visibility = ViewStates.Gone;
			}
			int[] array = new int[]
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
			float num = this.CalculateRateing(array);
			if (!float.IsNaN(num))
			{
				if ((double)num > 9.9)
				{
					this.mRate.Text = string.Format("{0:0}", num);
				}
				else
				{
					this.mRate.Text = string.Format("{0:0.0}", num);
				}
			}
			else
			{
				this.mRate.Text = "0";
			}
			this.mRatingSeeker.SetProgress((float)statistics.UserRate);
			int num2 = statistics.rates_1 + statistics.rates_2 + statistics.rates_3 + statistics.rates_4 + statistics.rates_5 + statistics.rates_6 + statistics.rates_7 + statistics.rates_8 + statistics.rates_9 + statistics.rates_10;
			this.mRatersCount.Text = string.Concat(new string[]
			{
				"(",
				string.Format("{0:N0}", num2),
				" ",
				this.Resources.GetString(2131952293),
				")"
			});
		}

		// Token: 0x060008C0 RID: 2240 RVA: 0x0002910C File Offset: 0x0002730C
		private void LoadRelatedCharacters()
		{
			WebClient webClient = new WebClient();
			System.Uri address = new System.Uri(Constants.ApiPhp("characters/related_characters.php"));
			webClient.UploadValuesAsync(address, new NameValueCollection
			{
				{
					"UserId",
					this.userId.ToString()
				},
				{
					"RelationId",
					this.relationId
				},
				{
					"Token",
					"8cnY80AZSbUCmR26Vku1VUUY4"
				}
			});
			webClient.UploadValuesCompleted += delegate(object sender, UploadValuesCompletedEventArgs e)
			{
				try
				{
					string @string = Encoding.UTF8.GetString(e.Result);
					this.relatedCharactersList = JsonConvert.DeserializeObject<List<CharacterModel>>(@string);
					base.RunOnUiThread(delegate()
					{
						if (this.relatedCharactersList != null)
						{
							this.mAdapterRelatedCharacters = new CharactersListAdapter(this, this.relatedCharactersList);
							this.mAdapterRelatedCharacters.ItemClick += this.MAdapterRelatedCharacters_ItemClick;
							this.relatedCharactersLayoutManager = new GridLayoutManager(this, Calculators.CalculateNumberOfColumns(this, 124f));
							this.mRelatedsRecyclerView.SetLayoutManager(this.relatedCharactersLayoutManager);
							this.mRelatedsRecyclerView.SetAdapter(this.mAdapterRelatedCharacters);
							if (this.relatedCharactersList.Count<CharacterModel>() == 0)
							{
								this.mNoRelatedAnime.Visibility = ViewStates.Visible;
								this.mRelatedsRecyclerView.Visibility = ViewStates.Gone;
								this.mNoRelatedAnime.Text = this.Resources.GetString(2131952240);
							}
							else
							{
								this.mNoRelatedAnime.Visibility = ViewStates.Gone;
								this.mRelatedsRecyclerView.Visibility = ViewStates.Visible;
							}
							this.isRelatedCharctersLoaded = true;
						}
					});
				}
				catch
				{
					base.RunOnUiThread(delegate()
					{
						this.mNoRelatedAnime.Visibility = ViewStates.Visible;
						this.mRelatedsRecyclerView.Visibility = ViewStates.Gone;
						this.mNoRelatedAnime.Text = this.Resources.GetString(2131951826);
					});
				}
				this.isLoading = false;
			};
		}

		// Token: 0x060008C1 RID: 2241 RVA: 0x00029188 File Offset: 0x00027388
		private void MAdapterRelatedCharacters_ItemClick(object sender, int e)
		{
			long num = JavaSystem.CurrentTimeMillis();
			if (num - this.mLastClickTime < AnimeDetails.CLICK_TIME_INTERVAL)
			{
				return;
			}
			this.mLastClickTime = num;
			CharacterModel characterModel = this.relatedCharactersList[e];
			if (characterModel.Enabled == 0)
			{
				CustomizedToast.ShowToast(this, this.Resources.GetString(2131952247), 0);
				return;
			}
			View itemView = this.mRelatedsRecyclerView.FindViewHolderForAdapterPosition(e).ItemView;
			ImageView a = itemView.FindViewById<ImageView>(2131362127);
			TextView a2 = itemView.FindViewById<TextView>(2131362125);
			Intent intent = new Intent(Application.Context, typeof(CharacterDetailsActivity));
			intent.PutExtra("CharId", characterModel.CharId);
			intent.PutExtra("CharEnName", characterModel.NameEN);
			intent.PutExtra("CharArName", characterModel.NameAR);
			intent.PutExtra("CharJpName", characterModel.NameJP);
			intent.PutExtra("CharAka", characterModel.Aka);
			intent.PutExtra("RelationId", characterModel.RelationId);
			intent.PutExtra("Gender", characterModel.Gender);
			intent.PutExtra("ExtraPhotosCount", characterModel.ExtraPhotosCount);
			intent.PutExtra("Age", characterModel.Age);
			intent.PutExtra("Height", characterModel.Height);
			intent.PutExtra("Weight", characterModel.Weight);
			intent.PutExtra("BloodType", characterModel.BloodType);
			intent.PutExtra("IsLoved", characterModel.Love);
			intent.PutExtra("CharPhoto", Constants.CharPhoto(characterModel.Photo));
			intent.PutExtra("LikersCount", characterModel.LikersCount);
			intent.PutExtra("DislikersCount", characterModel.DislikersCount);
			intent.PutExtra("ItemPosition", e);
			if (Build.VERSION.SdkInt >= BuildVersionCodes.Lollipop)
			{
				Pair pair = Pair.Create(a, "charthumbnail");
				Pair pair2 = Pair.Create(a2, "name");
				ActivityOptionsCompat activityOptionsCompat = ActivityOptionsCompat.MakeSceneTransitionAnimation(this, new Pair[]
				{
					pair,
					pair2
				});
				this.StartActivityForResult(intent, 2, activityOptionsCompat.ToBundle());
				return;
			}
			this.StartActivityForResult(intent, 2);
		}

		// Token: 0x060008C2 RID: 2242 RVA: 0x000293C4 File Offset: 0x000275C4
		private void SignInPormpt(string msg)
		{
			Bundle bundle = new Bundle();
			bundle.PutString("Message", msg);
			DialogSigninPrompt dialogSigninPrompt = new DialogSigninPrompt();
			FragmentTransaction transaction = this.SupportFragmentManager.BeginTransaction();
			dialogSigninPrompt.Arguments = bundle;
			dialogSigninPrompt.Show(transaction, "DialogSigninPrompt");
		}

		// Token: 0x060008C3 RID: 2243 RVA: 0x0002940C File Offset: 0x0002760C
		public override bool OnCreateOptionsMenu(IMenu menu)
		{
			this.MenuInflater.Inflate(2131689479, menu);
			if (this.status == "AIRING")
			{
				menu.FindItem(2131362642).SetEnabled(true);
				if (NotificationsViewModel.IsNotifExist(this.animeId))
				{
					menu.FindItem(2131362642).SetIcon(2131231143);
				}
				else
				{
					menu.FindItem(2131362642).SetIcon(2131231141);
				}
			}
			return base.OnCreateOptionsMenu(menu);
		}

		// Token: 0x060008C4 RID: 2244 RVA: 0x00029490 File Offset: 0x00027690
		public override bool OnOptionsItemSelected(IMenuItem item)
		{
			int itemId = item.ItemId;
			if (itemId == 16908332)
			{
				Intent intent = new Intent();
				intent.PutExtra("DeleteOnReturn", this.deleteFavouriteOnReturn);
				intent.PutExtra("ItemPosistion", this.itemPosition);
				if (this.transition || this.isOrientationChanged)
				{
					this.Finish();
				}
				else
				{
					this.SupportFinishAfterTransition();
				}
				base.SetResult(Result.Ok, intent);
			}
			else if (itemId == 2131362642)
			{
				if (this.status == "AIRING")
				{
					if (NotificationsViewModel.IsNotifExist(this.animeId))
					{
						item.SetIcon(2131231141);
						FirebaseMessaging.Instance.UnsubscribeFromTopic(this.animeId);
						NotificationsViewModel.DelNotif(this.animeId);
						CustomizedToast.ShowToast(this, this.Resources.GetString(2131951927) + " " + this.enTitle, 2131231141);
					}
					else
					{
						item.SetIcon(2131231143);
						FirebaseMessaging.Instance.SubscribeToTopic(this.animeId);
						NotificationsViewModel.InitializeNewNotif(this.animeId, this.enTitle, this.episodes);
						CustomizedToast.ShowToast(this, this.Resources.GetString(2131951928) + " " + this.enTitle, 2131231141);
					}
				}
				else
				{
					CustomizedToast.ShowToast(this, this.Resources.GetString(2131951693) + " " + this.enTitle, 2131230956);
				}
			}
			else if (itemId == 2131362657)
			{
				Intent intent2 = new Intent("android.intent.action.SEND");
				intent2.SetType("text/plain");
				intent2.PutExtra("android.intent.extra.SUBJECT", this.enTitle + " " + this.Resources.GetString(2131951718));
				intent2.PutExtra("android.intent.extra.TEXT", string.Concat(new string[]
				{
					this.enTitle,
					"-",
					this.Resources.GetString(2131952395),
					" https://play.google.com/store/apps/details?id=",
					this.Resources.GetString(2131951708)
				}));
				this.StartActivity(Intent.CreateChooser(intent2, this.Resources.GetString(2131952394)));
			}
			return base.OnOptionsItemSelected(item);
		}

		// Token: 0x060008C5 RID: 2245 RVA: 0x000296E4 File Offset: 0x000278E4
		protected override void OnActivityResult(int requestCode, [GeneratedEnum] Result resultCode, Intent data)
		{
			base.OnActivityResult(requestCode, resultCode, data);
			if (resultCode == Result.Ok && requestCode == 2)
			{
				int intExtra = data.GetIntExtra("ItemPosistion", 0);
				this.relatedCharactersList[intExtra].Love = data.GetIntExtra("LoveFeedback", 0);
				this.relatedCharactersList[intExtra].LikersCount = data.GetIntExtra("LoversCount", 0);
				this.relatedCharactersList[intExtra].DislikersCount = data.GetIntExtra("DisloversCount", 0);
			}
		}

		// Token: 0x060008C6 RID: 2246 RVA: 0x00029768 File Offset: 0x00027968
		public override void OnBackPressed()
		{
			base.OnBackPressed();
			Intent intent = new Intent();
			intent.PutExtra("DeleteOnReturn", this.deleteFavouriteOnReturn);
			intent.PutExtra("ItemPosistion", this.itemPosition);
			if (!this.transition || !this.isOrientationChanged)
			{
				this.SupportFinishAfterTransition();
			}
			base.SetResult(Result.Ok, intent);
		}

		// Token: 0x060008C7 RID: 2247 RVA: 0x000297C3 File Offset: 0x000279C3
		public override void OnConfigurationChanged(Configuration newConfig)
		{
			base.OnConfigurationChanged(newConfig);
			if (newConfig.Orientation != this.currentOrientation)
			{
				this.isOrientationChanged = true;
				return;
			}
			this.isOrientationChanged = false;
		}

		// Token: 0x060008C8 RID: 2248 RVA: 0x000297EC File Offset: 0x000279EC
		protected override void OnResume()
		{
			base.OnResume();
			PublicFunctions.ValidateConnection();
			if (UsersModel.OnResumeLogin)
			{
				this.user = UsersViewModel.GetUserProfile();
				this.userId = ((this.user == null) ? 0 : this.user.UserID);
			}
			if (this.firstOpen > 0)
			{
				if (this.mLoader.Visibility == ViewStates.Visible)
				{
					this.mLoader.Visibility = ViewStates.Gone;
					return;
				}
			}
			else
			{
				this.firstOpen++;
			}
		}

		// Token: 0x060008C9 RID: 2249 RVA: 0x0002545B File Offset: 0x0002365B
		protected override void AttachBaseContext(Context @base)
		{
			base.AttachBaseContext(LocalizationChanger.UpdateResources(@base, "ar"));
		}

		// Token: 0x040005B4 RID: 1460
		private UsersModel user;

		// Token: 0x040005B5 RID: 1461
		private int userId;

		// Token: 0x040005B6 RID: 1462
		private Orientation currentOrientation;

		// Token: 0x040005B7 RID: 1463
		public string animeId;

		// Token: 0x040005B8 RID: 1464
		public string enTitle;

		// Token: 0x040005B9 RID: 1465
		public string jpTitle;

		// Token: 0x040005BA RID: 1466
		public string arTitle;

		// Token: 0x040005BB RID: 1467
		public string synonyms;

		// Token: 0x040005BC RID: 1468
		public string tags;

		// Token: 0x040005BD RID: 1469
		public string genres;

		// Token: 0x040005BE RID: 1470
		public string premiered;

		// Token: 0x040005BF RID: 1471
		public string aired;

		// Token: 0x040005C0 RID: 1472
		public string broadcast;

		// Token: 0x040005C1 RID: 1473
		public string thumbnail;

		// Token: 0x040005C2 RID: 1474
		public string trailer;

		// Token: 0x040005C3 RID: 1475
		public string ytTrailer;

		// Token: 0x040005C4 RID: 1476
		public string creators;

		// Token: 0x040005C5 RID: 1477
		public string status;

		// Token: 0x040005C6 RID: 1478
		public string rank;

		// Token: 0x040005C7 RID: 1479
		public string popularity;

		// Token: 0x040005C8 RID: 1480
		public string rating;

		// Token: 0x040005C9 RID: 1481
		public string relationId;

		// Token: 0x040005CA RID: 1482
		public string malId;

		// Token: 0x040005CB RID: 1483
		public string type = "";

		// Token: 0x040005CC RID: 1484
		public int season;

		// Token: 0x040005CD RID: 1485
		public int duration;

		// Token: 0x040005CE RID: 1486
		public int episodes;

		// Token: 0x040005CF RID: 1487
		public int itemPosition;

		// Token: 0x040005D0 RID: 1488
		public float score;

		// Token: 0x040005D1 RID: 1489
		private FrameLayout mMalSectionContent;

		// Token: 0x040005D2 RID: 1490
		private RelativeLayout mTrailerPaly;

		// Token: 0x040005D3 RID: 1491
		private RelativeLayout mEpisodesWatch;

		// Token: 0x040005D4 RID: 1492
		private LinearLayout mEpisodesCountContent;

		// Token: 0x040005D5 RID: 1493
		private LinearLayout mSeasonContent;

		// Token: 0x040005D6 RID: 1494
		private TextView mTitle;

		// Token: 0x040005D7 RID: 1495
		private TextView mSynonyms;

		// Token: 0x040005D8 RID: 1496
		private TextView mPlot;

		// Token: 0x040005D9 RID: 1497
		private TextView mType;

		// Token: 0x040005DA RID: 1498
		private TextView mDuration;

		// Token: 0x040005DB RID: 1499
		private TextView mHeaderPremiered;

		// Token: 0x040005DC RID: 1500
		private TextView mStatus;

		// Token: 0x040005DD RID: 1501
		private TextView mEpisodes;

		// Token: 0x040005DE RID: 1502
		private TextView mBroadcast;

		// Token: 0x040005DF RID: 1503
		private TextView mSeasonTitle;

		// Token: 0x040005E0 RID: 1504
		private TextView mPremiered;

		// Token: 0x040005E1 RID: 1505
		private TextView mAgeRating;

		// Token: 0x040005E2 RID: 1506
		private TextView mMalScore;

		// Token: 0x040005E3 RID: 1507
		private TextView mMalRanked;

		// Token: 0x040005E4 RID: 1508
		private TextView mMalPopularity;

		// Token: 0x040005E5 RID: 1509
		private TextView mFavouritesCount;

		// Token: 0x040005E6 RID: 1510
		private TextView mRate;

		// Token: 0x040005E7 RID: 1511
		private TextView mMalRate;

		// Token: 0x040005E8 RID: 1512
		private TextView mRatersCount;

		// Token: 0x040005E9 RID: 1513
		private TextView mMalRatersCount;

		// Token: 0x040005EA RID: 1514
		private TextView mNoRelatedAnime;

		// Token: 0x040005EB RID: 1515
		private TextView mViewAllComments;

		// Token: 0x040005EC RID: 1516
		private TextView mEpisodesWatchText;

		// Token: 0x040005ED RID: 1517
		private TextView mNoStudios;

		// Token: 0x040005EE RID: 1518
		private RecyclerView mGenresRecyclerView;

		// Token: 0x040005EF RID: 1519
		private RecyclerView mStudiosRecyclerView;

		// Token: 0x040005F0 RID: 1520
		private RecyclerView mRelatedsRecyclerView;

		// Token: 0x040005F1 RID: 1521
		private ClickableTextsAdapter2 mAdapterGenres;

		// Token: 0x040005F2 RID: 1522
		private ClickableTextsAdapter3 mAdapterStudios;

		// Token: 0x040005F3 RID: 1523
		private AnimeCatalogGridAdapter mAdapterRelatedAnime;

		// Token: 0x040005F4 RID: 1524
		private CharactersListAdapter mAdapterRelatedCharacters;

		// Token: 0x040005F5 RID: 1525
		private RecyclerView.LayoutManager relatedCharactersLayoutManager;

		// Token: 0x040005F6 RID: 1526
		private List<CharacterModel> relatedCharactersList;

		// Token: 0x040005F7 RID: 1527
		private ProgressBar mLoader;

		// Token: 0x040005F8 RID: 1528
		private ProgressBar mRateDeleteProgressBar;

		// Token: 0x040005F9 RID: 1529
		private AVLoadingIndicatorView mStatusAringMarker;

		// Token: 0x040005FA RID: 1530
		private ImageView mThumbnail;

		// Token: 0x040005FB RID: 1531
		private ImageView mTrailerThumbnail;

		// Token: 0x040005FC RID: 1532
		private ImageView mEpisodesWatchIcon;

		// Token: 0x040005FD RID: 1533
		private ImageView mReload;

		// Token: 0x040005FE RID: 1534
		private ImageView mComments;

		// Token: 0x040005FF RID: 1535
		private ImageView mRateDeleteIcon;

		// Token: 0x04000600 RID: 1536
		private ImageView mFavouriteIcon;

		// Token: 0x04000601 RID: 1537
		private ImageView mLibraryIcon;

		// Token: 0x04000602 RID: 1538
		public AnimeDetailsModel animeDetails;

		// Token: 0x04000603 RID: 1539
		private IndicatorSeekBar mRatingSeeker;

		// Token: 0x04000604 RID: 1540
		private TabLayout mTabLayout;

		// Token: 0x04000605 RID: 1541
		private long mLastClickTime = JavaSystem.CurrentTimeMillis();

		// Token: 0x04000606 RID: 1542
		private static readonly long CLICK_TIME_INTERVAL = 1000L;

		// Token: 0x04000607 RID: 1543
		public bool transition;

		// Token: 0x04000608 RID: 1544
		public bool isOrientationChanged;

		// Token: 0x04000609 RID: 1545
		public bool isCommingFromRelatedAnime;

		// Token: 0x0400060A RID: 1546
		public bool isCommingFromFindMore;

		// Token: 0x0400060B RID: 1547
		public bool isRelatedAnimeLoaded;

		// Token: 0x0400060C RID: 1548
		public bool isRelatedCharctersLoaded;

		// Token: 0x0400060D RID: 1549
		public bool isPlotExpanded;

		// Token: 0x0400060E RID: 1550
		public bool deleteFavouriteOnReturn;

		// Token: 0x0400060F RID: 1551
		private bool isLoading = true;

		// Token: 0x04000610 RID: 1552
		private int tapSelcted;

		// Token: 0x04000611 RID: 1553
		private int plotMaxLines;

		// Token: 0x04000612 RID: 1554
		private int firstOpen;

		// Token: 0x02000154 RID: 340
		private class SeekChangeListener : Java.Lang.Object, IOnSeekChangeListener, IJavaObject, IDisposable
		{
			// Token: 0x06000BFA RID: 3066 RVA: 0x0004177A File Offset: 0x0003F97A
			public SeekChangeListener(AnimeDetails context)
			{
				this.context = context;
			}

			// Token: 0x06000BFB RID: 3067 RVA: 0x00041789 File Offset: 0x0003F989
			public void OnSeeking(SeekParams seekParams)
			{
				this.currentRate = seekParams.ThumbPosition + 1;
			}

			// Token: 0x06000BFC RID: 3068 RVA: 0x00004097 File Offset: 0x00002297
			public void OnStartTrackingTouch(IndicatorSeekBar seekBar)
			{
			}

			// Token: 0x06000BFD RID: 3069 RVA: 0x0004179C File Offset: 0x0003F99C
			public void OnStopTrackingTouch(IndicatorSeekBar seekBar)
			{
				if (this.context.userId == 0)
				{
					Bundle bundle = new Bundle();
					bundle.PutString("Message", this.context.Resources.GetString(2131951866));
					DialogSigninPrompt dialogSigninPrompt = new DialogSigninPrompt();
					FragmentTransaction transaction = this.context.SupportFragmentManager.BeginTransaction();
					dialogSigninPrompt.Arguments = bundle;
					dialogSigninPrompt.Show(transaction, "DialogSigninPrompt");
					seekBar.SetProgress(0f);
					return;
				}
				this.context.mRateDeleteIcon.Visibility = ViewStates.Gone;
				this.context.mRateDeleteProgressBar.Visibility = ViewStates.Visible;
				ThreadPool.QueueUserWorkItem(delegate(object o)
				{
					this.context.SetRate(this.currentRate);
				});
			}

			// Token: 0x040030EE RID: 12526
			private AnimeDetails context;

			// Token: 0x040030EF RID: 12527
			private int currentRate;
		}
	}
}
