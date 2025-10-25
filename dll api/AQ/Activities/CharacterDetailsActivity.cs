using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Net;
using System.Runtime.CompilerServices;
using System.Threading;
using Android.App;
using Android.Content;
using Android.Content.PM;
using Android.Content.Res;
using Android.OS;
using Android.Views;
using Android.Views.Animations;
using Android.Widget;
using AndroidX.AppCompat.App;
using AndroidX.Core.App;
using AndroidX.Fragment.App;
using AndroidX.RecyclerView.Widget;
using AQ.Dialogs;
using AQ.Helpers;
using AQ.Models;
using AQ.ViewAdapters;
using AQ.ViewModels;
using Bumptech.Glide;
using Java.Lang;

namespace AQ.Activities
{
	// Token: 0x020000C1 RID: 193
	[Activity(Label = "@string/app_name", Theme = "@style/AppTheme", ConfigurationChanges = (ConfigChanges.KeyboardHidden | ConfigChanges.Orientation | ConfigChanges.ScreenSize))]
	public class CharacterDetailsActivity : AppCompatActivity
	{
		// Token: 0x060008F3 RID: 2291 RVA: 0x0002AB28 File Offset: 0x00028D28
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
			this.SetContentView(2131558434);
			this.user = UsersViewModel.GetUserProfile();
			this.userId = ((this.user == null) ? 0 : this.user.UserID);
			this.charId = this.Intent.GetStringExtra("CharId");
			this.charEnName = this.Intent.GetStringExtra("CharEnName");
			this.charAka = this.Intent.GetStringExtra("CharAka");
			this.charArName = this.Intent.GetStringExtra("CharArName");
			this.charJpName = this.Intent.GetStringExtra("CharJpName");
			this.relationId = this.Intent.GetStringExtra("RelationId");
			this.charPhoto = this.Intent.GetStringExtra("CharPhoto");
			this.gender = this.Intent.GetIntExtra("Gender", 0);
			this.extraPhotosCount = this.Intent.GetIntExtra("ExtraPhotosCount", 0);
			this.age = this.Intent.GetStringExtra("Age");
			this.height = this.Intent.GetStringExtra("Height");
			this.weight = this.Intent.GetStringExtra("Weight");
			this.bloodType = this.Intent.GetStringExtra("BloodType");
			this.isLoved = this.Intent.GetStringExtra("IsLoved");
			this.loversCount = this.Intent.GetIntExtra("LikersCount", 0);
			this.disloversCount = this.Intent.GetIntExtra("DislikersCount", 0);
			this.itemPosition = this.Intent.GetIntExtra("ItemPosition", 0);
			this.finishOnRelatedCharClick = this.Intent.GetBooleanExtra("FinishOnRelatedCharClick", false);
			this.SupportActionBar.Title = this.charEnName + " - " + this.charArName;
			this.mAboutTitle = base.FindViewById<TextView>(2131361807);
			this.mAboutTitle.Text = base.Resources.GetString(2131951645) + " " + this.charArName;
			this.mCharPhoto = base.FindViewById<ImageView>(2131362090);
			if (this.charPhoto != "")
			{
				Glide.With(this).Load(this.charPhoto).CenterCrop().Placeholder(2131231224).Into(this.mCharPhoto);
			}
			this.mLoveBtn = base.FindViewById<ImageView>(2131362109);
			this.mNotLoveBtn = base.FindViewById<ImageView>(2131362114);
			if (this.isLoved == "True")
			{
				this.mLoveBtn.SetImageResource(2131231083);
			}
			else if (this.isLoved == "False")
			{
				this.mNotLoveBtn.SetImageResource(2131230974);
			}
			this.mCharDetailsLoader = base.FindViewById<ProgressBar>(2131362835);
			this.mCharDetailsReload = base.FindViewById<ImageView>(2131362089);
			this.extraPhotosRecycler = base.FindViewById<RecyclerView>(2131362133);
			this.voicActorsRecycler = base.FindViewById<RecyclerView>(2131362151);
			this.topQuotesRecycler = base.FindViewById<RecyclerView>(2131362150);
			this.animographyRecycler = base.FindViewById<RecyclerView>(2131362132);
			this.relatedCharsRecycler = base.FindViewById<RecyclerView>(2131362140);
			this.mQuotesArea = base.FindViewById<LinearLayout>(2131362135);
			this.mVoiceActorsArea = base.FindViewById<LinearLayout>(2131362153);
			this.mAnimographyArea = base.FindViewById<LinearLayout>(2131362131);
			this.mRelatedCharsArea = base.FindViewById<LinearLayout>(2131362139);
			this.mExtraInfoContentA = base.FindViewById<LinearLayout>(2131362098);
			this.mExtraInfoContentB = base.FindViewById<LinearLayout>(2131362101);
			this.mExtraInfoContentC = base.FindViewById<LinearLayout>(2131362104);
			this.mExtraInfoContentD = base.FindViewById<LinearLayout>(2131362107);
			this.mExtraInfoTitleA = base.FindViewById<TextView>(2131362099);
			this.mExtraInfoTitleB = base.FindViewById<TextView>(2131362102);
			this.mExtraInfoTitleC = base.FindViewById<TextView>(2131362105);
			this.mExtraInfoTitleD = base.FindViewById<TextView>(2131362108);
			this.mExtraInfoBodyA = base.FindViewById<TextView>(2131362097);
			this.mExtraInfoBodyB = base.FindViewById<TextView>(2131362100);
			this.mExtraInfoBodyC = base.FindViewById<TextView>(2131362103);
			this.mExtraInfoBodyD = base.FindViewById<TextView>(2131362106);
			this.mAgeContent = base.FindViewById<LinearLayout>(2131362056);
			this.mBirthdayContent = base.FindViewById<LinearLayout>(2131362060);
			this.mHeightContent = base.FindViewById<LinearLayout>(2131362076);
			this.mWeightContent = base.FindViewById<LinearLayout>(2131362096);
			this.mBloodTypeContent = base.FindViewById<LinearLayout>(2131362062);
			this.mHairColorContent = base.FindViewById<LinearLayout>(2131362074);
			this.mEyeColorContent = base.FindViewById<LinearLayout>(2131362068);
			this.mPositionContent = base.FindViewById<LinearLayout>(2131362093);
			this.mOccupationContent = base.FindViewById<LinearLayout>(2131362088);
			this.mLikesContent = base.FindViewById<LinearLayout>(2131362079);
			this.mDislikesContent = base.FindViewById<LinearLayout>(2131362064);
			this.mFavouriteFoodContent = base.FindViewById<LinearLayout>(2131362070);
			this.mPosition = base.FindViewById<TextView>(2131362092);
			this.mOccupation = base.FindViewById<TextView>(2131362087);
			this.mLikes = base.FindViewById<TextView>(2131362078);
			this.mDislikes = base.FindViewById<TextView>(2131362063);
			this.mLikesTitle = base.FindViewById<TextView>(2131362080);
			this.mDislikesTitle = base.FindViewById<TextView>(2131362065);
			this.mFavouriteFood = base.FindViewById<TextView>(2131362069);
			this.mMoreAboutAContent = base.FindViewById<LinearLayout>(2131362111);
			this.mMoreAboutBContent = base.FindViewById<LinearLayout>(2131362112);
			this.mMoreAboutCContent = base.FindViewById<LinearLayout>(2131362113);
			this.mMoreAboutATitle = base.FindViewById<TextView>(2131362082);
			this.mMoreAboutBTitle = base.FindViewById<TextView>(2131362084);
			this.mMoreAboutCTitle = base.FindViewById<TextView>(2131362086);
			this.mMoreAboutABody = base.FindViewById<TextView>(2131362081);
			this.mMoreAboutBBody = base.FindViewById<TextView>(2131362083);
			this.mMoreAboutCBody = base.FindViewById<TextView>(2131362085);
			if (this.gender == 1)
			{
				this.mLikesTitle.Text = this.Resources.GetString(2131952034);
				this.mDislikesTitle.Text = this.Resources.GetString(2131951873);
			}
			this.mAge = base.FindViewById<TextView>(2131362055);
			this.mBirthday = base.FindViewById<TextView>(2131362059);
			this.mHeight = base.FindViewById<TextView>(2131362075);
			this.mWeight = base.FindViewById<TextView>(2131362095);
			if (this.age == "")
			{
				this.mAgeContent.Visibility = ViewStates.Gone;
			}
			else
			{
				this.mAge.Text = this.age.Replace(',', '\n');
			}
			if (this.height == "")
			{
				this.mHeightContent.Visibility = ViewStates.Gone;
			}
			else
			{
				this.mHeight.Text = this.height.Replace(',', '\n');
			}
			if (this.weight == "")
			{
				this.mWeightContent.Visibility = ViewStates.Gone;
			}
			else
			{
				this.mWeight.Text = this.weight.Replace(',', '\n');
			}
			this.mGender = base.FindViewById<TextView>(2131362071);
			if (this.gender == 0)
			{
				this.mGender.Text = this.Resources.GetString(2131951959);
			}
			else
			{
				this.mGender.Text = this.Resources.GetString(2131951958);
			}
			this.mBloodType = base.FindViewById<TextView>(2131362061);
			if (this.bloodType == "")
			{
				this.mBloodTypeContent.Visibility = ViewStates.Gone;
			}
			else
			{
				this.mBloodType.Text = this.bloodType;
			}
			this.mLoversCount = base.FindViewById<TextView>(2131362851);
			this.mDisLoversCount = base.FindViewById<TextView>(2131362709);
			this.mLoversCount.Text = string.Format("{0:N0}", this.loversCount);
			this.mDisLoversCount.Text = string.Format("{0:N0}", this.disloversCount);
			this.mCharEnName = base.FindViewById<TextView>(2131362066);
			this.mCharEnName.Text = this.charEnName;
			this.mCharAka = base.FindViewById<TextView>(2131362057);
			if (this.charAka == "")
			{
				this.mCharAka.Visibility = ViewStates.Gone;
			}
			else
			{
				this.mCharAka.Text = this.charAka;
			}
			this.mCharArName = base.FindViewById<TextView>(2131362058);
			if (this.charArName == "")
			{
				this.mCharArName.Visibility = ViewStates.Gone;
			}
			else
			{
				this.mCharArName.Text = this.charArName;
			}
			this.mCharJpName = base.FindViewById<TextView>(2131362077);
			if (this.charJpName == "")
			{
				this.mCharJpName.Visibility = ViewStates.Gone;
			}
			else
			{
				this.mCharJpName.Text = "(" + this.charJpName + ")";
			}
			this.mCharBio = base.FindViewById<TextView>(2131362053);
			this.mHairColor = base.FindViewById<TextView>(2131362073);
			this.mEyeColor = base.FindViewById<TextView>(2131362067);
			this.mCurrentOrientation = base.Resources.Configuration.Orientation;
			ThreadPool.QueueUserWorkItem(delegate(object o)
			{
				this.LoadData();
			});
			this.mLoveBtn.Click += this.MLoveBtn_Click;
			this.mNotLoveBtn.Click += this.MNotLoveBtn_Click;
			this.mCharPhoto.Click += this.MCharPhoto_Click;
			this.mCharDetailsReload.Click += this.MCharDetailsReload_Click;
		}

		// Token: 0x060008F4 RID: 2292 RVA: 0x0002B5CD File Offset: 0x000297CD
		private void MCharDetailsReload_Click(object sender, EventArgs e)
		{
			this.mCharDetailsReload.Visibility = ViewStates.Gone;
			this.mCharDetailsLoader.Visibility = ViewStates.Visible;
			ThreadPool.QueueUserWorkItem(delegate(object o)
			{
				this.LoadData();
			});
		}

		// Token: 0x060008F5 RID: 2293 RVA: 0x0002B5FC File Offset: 0x000297FC
		private void MCharPhoto_Click(object sender, EventArgs e)
		{
			Bundle bundle = new Bundle();
			bundle.PutString("ThumbnailLink", this.charPhoto);
			ThumbnailsDialog thumbnailsDialog = new ThumbnailsDialog();
			FragmentTransaction transaction = this.SupportFragmentManager.BeginTransaction();
			thumbnailsDialog.Arguments = bundle;
			thumbnailsDialog.Show(transaction, "ThumbNailDialog");
		}

		// Token: 0x060008F6 RID: 2294 RVA: 0x0002B648 File Offset: 0x00029848
		private void MNotLoveBtn_Click(object sender, EventArgs e)
		{
			if (this.userId == 0)
			{
				CustomizedToast.ShowToast(this, this.Resources.GetString(2131951866), 0);
				return;
			}
			if (this.isLoved == "False")
			{
				this.isLoved = "na";
				this.disloversCount--;
				this.mNotLoveBtn.StartAnimation(AnimationUtils.LoadAnimation(this, 2130771992));
				this.mNotLoveBtn.SetImageResource(2131230973);
				ThreadPool.QueueUserWorkItem(delegate(object o)
				{
					this.SetLove(this.charId, "DELETE", 0);
				});
			}
			else
			{
				if (this.isLoved == "True")
				{
					this.loversCount--;
				}
				this.isLoved = "False";
				this.disloversCount++;
				this.mNotLoveBtn.StartAnimation(AnimationUtils.LoadAnimation(this, 2130771992));
				this.mNotLoveBtn.SetImageResource(2131230974);
				this.mLoveBtn.SetImageResource(2131231080);
				ThreadPool.QueueUserWorkItem(delegate(object o)
				{
					this.SetLove(this.charId, "ADD_UPDATE", 0);
				});
			}
			this.mLoversCount.Text = string.Format("{0:N0}", this.loversCount);
			this.mDisLoversCount.Text = string.Format("{0:N0}", this.disloversCount);
		}

		// Token: 0x060008F7 RID: 2295 RVA: 0x0002B7A0 File Offset: 0x000299A0
		private void MLoveBtn_Click(object sender, EventArgs e)
		{
			if (this.userId == 0)
			{
				CustomizedToast.ShowToast(this, this.Resources.GetString(2131951866), 0);
				return;
			}
			if (this.isLoved == "True")
			{
				this.isLoved = "na";
				this.loversCount--;
				this.mLoveBtn.StartAnimation(AnimationUtils.LoadAnimation(this, 2130771992));
				this.mLoveBtn.SetImageResource(2131231080);
				ThreadPool.QueueUserWorkItem(delegate(object o)
				{
					this.SetLove(this.charId, "DELETE", 1);
				});
			}
			else
			{
				if (this.isLoved == "False")
				{
					this.disloversCount--;
				}
				this.isLoved = "True";
				this.loversCount++;
				this.mLoveBtn.StartAnimation(AnimationUtils.LoadAnimation(this, 2130771992));
				this.mLoveBtn.SetImageResource(2131231083);
				this.mNotLoveBtn.SetImageResource(2131230973);
				ThreadPool.QueueUserWorkItem(delegate(object o)
				{
					this.SetLove(this.charId, "ADD_UPDATE", 1);
				});
			}
			this.mLoversCount.Text = string.Format("{0:N0}", this.loversCount);
			this.mDisLoversCount.Text = string.Format("{0:N0}", this.disloversCount);
		}

		// Token: 0x060008F8 RID: 2296 RVA: 0x0002B8F8 File Offset: 0x00029AF8
		private void LoadData()
		{
			this.mClient = new WebClient();
			this.mUri = new Uri(Constants.ApiPhp("characters/characters_details.php"));
			this.parameters = new NameValueCollection();
			this.parameters.Add("UserId", this.userId.ToString());
			this.parameters.Add("CharId", this.charId);
			this.parameters.Add("Language", this.Resources.GetString(2131951706));
			this.parameters.Add("RelationId", this.relationId);
			this.parameters.Add("Token", "8cnY80AZSbUCmR26Vku1VUUY4");
			this.mClient.UploadValuesAsync(this.mUri, this.parameters);
			this.mClient.UploadValuesCompleted += delegate(object sender, UploadValuesCompletedEventArgs e)
			{
				CharacterDetailsActivity.<<LoadData>b__114_0>d <<LoadData>b__114_0>d;
				<<LoadData>b__114_0>d.<>t__builder = AsyncVoidMethodBuilder.Create();
				<<LoadData>b__114_0>d.<>4__this = this;
				<<LoadData>b__114_0>d.e = e;
				<<LoadData>b__114_0>d.<>1__state = -1;
				<<LoadData>b__114_0>d.<>t__builder.Start<CharacterDetailsActivity.<<LoadData>b__114_0>d>(ref <<LoadData>b__114_0>d);
			};
		}

		// Token: 0x060008F9 RID: 2297 RVA: 0x0002B9DC File Offset: 0x00029BDC
		private void ExtraPhotosAdapter_ItemPhotoClick(object sender, int e)
		{
			string str = this.charPhotos[e];
			Bundle bundle = new Bundle();
			bundle.PutString("ThumbnailLink", Constants.CharPhoto("extras/" + str + ".jpg"));
			ThumbnailsDialog thumbnailsDialog = new ThumbnailsDialog();
			FragmentTransaction transaction = this.SupportFragmentManager.BeginTransaction();
			thumbnailsDialog.Arguments = bundle;
			thumbnailsDialog.Show(transaction, "ThumbNailDialog");
		}

		// Token: 0x060008FA RID: 2298 RVA: 0x0002BA44 File Offset: 0x00029C44
		private void VoicActorsAdapter_ItemPhotoClick(object sender, int e)
		{
			CharacterVoiceActors characterVoiceActors = this.mCharObject.VoiceActors[e];
			Bundle bundle = new Bundle();
			bundle.PutString("ThumbnailLink", Constants.PeoplePhoto(characterVoiceActors.Photo));
			ThumbnailsDialog thumbnailsDialog = new ThumbnailsDialog();
			FragmentTransaction transaction = this.SupportFragmentManager.BeginTransaction();
			thumbnailsDialog.Arguments = bundle;
			thumbnailsDialog.Show(transaction, "ThumbNailDialog");
		}

		// Token: 0x060008FB RID: 2299 RVA: 0x0002BAA8 File Offset: 0x00029CA8
		private void TopQuotesAdapter_ItemCopyClick(object sender, int e)
		{
			CharacterQuotes characterQuotes = this.mCharObject.Quotes[e];
			ClipboardManager clipboardManager = (ClipboardManager)this.GetSystemService("clipboard");
			ClipData primaryClip;
			if (this.Resources.GetString(2131951706) == "AR")
			{
				primaryClip = ClipData.NewPlainText(this.charEnName, " \"" + characterQuotes.Quote + "\" - " + this.charArName);
			}
			else
			{
				primaryClip = ClipData.NewPlainText(this.charEnName, " \"" + characterQuotes.Quote + "\" - " + this.charEnName);
			}
			clipboardManager.PrimaryClip = primaryClip;
			CustomizedToast.ShowToast(this, this.Resources.GetString(2131952318), 0);
		}

		// Token: 0x060008FC RID: 2300 RVA: 0x0002BB64 File Offset: 0x00029D64
		private void RelatedCharsAdapter_ItemClick(object sender, int e)
		{
			long num = JavaSystem.CurrentTimeMillis();
			if (num - this.mLastClickTime < CharacterDetailsActivity.CLICK_TIME_INTERVAL)
			{
				return;
			}
			this.mLastClickTime = num;
			CharacterModel characterModel = this.mCharObject.RelatedCharacters[e];
			if (characterModel.Enabled == 0)
			{
				CustomizedToast.ShowToast(this, this.Resources.GetString(2131952247), 0);
				return;
			}
			View itemView = this.relatedCharsRecycler.FindViewHolderForAdapterPosition(e).ItemView;
			ImageView imageView = itemView.FindViewById<ImageView>(2131362127);
			TextView textView = itemView.FindViewById<TextView>(2131362125);
			Intent intent = new Intent(Application.Context, typeof(CharacterDetailsActivity));
			intent.PutExtra("CharId", characterModel.CharId);
			intent.PutExtra("CharEnName", characterModel.NameEN);
			intent.PutExtra("CharArName", characterModel.NameAR);
			intent.PutExtra("CharJpName", characterModel.NameJP);
			intent.PutExtra("CharAka", characterModel.Aka);
			intent.PutExtra("RelationId", characterModel.RelationId);
			intent.PutExtra("Gender", characterModel.Gender);
			intent.PutExtra("Age", characterModel.Age);
			intent.PutExtra("Height", characterModel.Height);
			intent.PutExtra("Weight", characterModel.Weight);
			intent.PutExtra("BloodType", characterModel.BloodType);
			intent.PutExtra("IsLoved", characterModel.Love);
			intent.PutExtra("CharPhoto", Constants.CharPhoto(characterModel.Photo));
			intent.PutExtra("LikersCount", characterModel.LikersCount);
			intent.PutExtra("DislikersCount", characterModel.DislikersCount);
			intent.PutExtra("ItemPosition", e);
			intent.PutExtra("FinishOnRelatedCharClick", true);
			this.StartActivityForResult(intent, 2);
			if (this.finishOnRelatedCharClick)
			{
				this.Finish();
			}
		}

		// Token: 0x060008FD RID: 2301 RVA: 0x0002BD58 File Offset: 0x00029F58
		private void AnimographyAdapter_ItemLongClick(object sender, int e)
		{
			long num = JavaSystem.CurrentTimeMillis();
			if (num - this.mLastClickTime < CharacterDetailsActivity.CLICK_TIME_INTERVAL)
			{
				return;
			}
			this.mLastClickTime = num;
			AnimeModel animeModel = this.mCharObject.Animeography[e];
			Bundle bundle = new Bundle();
			bundle.PutString("Title", animeModel.EN_Title);
			bundle.PutString("AnimeId", animeModel.AnimeId);
			bundle.PutString("AnimeType", animeModel.Type);
			bundle.PutString("Genres", animeModel.Genres);
			AnimeDetailsGlance animeDetailsGlance = new AnimeDetailsGlance();
			FragmentTransaction transaction = this.SupportFragmentManager.BeginTransaction();
			animeDetailsGlance.Arguments = bundle;
			animeDetailsGlance.Show(transaction, "DialogDescription");
		}

		// Token: 0x060008FE RID: 2302 RVA: 0x0002BE08 File Offset: 0x0002A008
		private void AnimographyAdapter_ItemClick(object sender, int e)
		{
			long num = JavaSystem.CurrentTimeMillis();
			if (num - this.mLastClickTime < CharacterDetailsActivity.CLICK_TIME_INTERVAL)
			{
				return;
			}
			this.mLastClickTime = num;
			AnimeModel animeModel = this.mCharObject.Animeography[e];
			View itemView = this.animographyRecycler.FindViewHolderForAdapterPosition(e).ItemView;
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
			if (Build.VERSION.SdkInt >= BuildVersionCodes.Lollipop)
			{
				ActivityOptionsCompat activityOptionsCompat = ActivityOptionsCompat.MakeSceneTransitionAnimation(this, sharedElement, "catalogthumbnail");
				this.StartActivityForResult(intent, 1, activityOptionsCompat.ToBundle());
				return;
			}
			this.StartActivityForResult(intent, 1);
		}

		// Token: 0x060008FF RID: 2303 RVA: 0x0002C0A8 File Offset: 0x0002A2A8
		private void SetLove(string charId, string command, int love)
		{
			WebClient webClient = new WebClient();
			Uri address = new Uri(Constants.ApiPhp("characters/characters_set_love.php"));
			webClient.UploadValuesAsync(address, new NameValueCollection
			{
				{
					"CharId",
					charId
				},
				{
					"UserId",
					this.userId.ToString()
				},
				{
					"Command",
					command
				},
				{
					"Love",
					love.ToString()
				},
				{
					"Token",
					"8cnY80AZSbUCmR26Vku1VUUY4"
				}
			});
		}

		// Token: 0x06000900 RID: 2304 RVA: 0x0002C129 File Offset: 0x0002A329
		public override void OnConfigurationChanged(Configuration newConfig)
		{
			if (newConfig.Orientation != this.mCurrentOrientation)
			{
				this.isOrientationChanged = true;
			}
			else
			{
				this.isOrientationChanged = false;
			}
			base.OnConfigurationChanged(newConfig);
		}

		// Token: 0x06000901 RID: 2305 RVA: 0x0002C150 File Offset: 0x0002A350
		public override void SupportFinishAfterTransition()
		{
			if (this.isOrientationChanged)
			{
				this.Finish();
				return;
			}
			base.SupportFinishAfterTransition();
		}

		// Token: 0x06000902 RID: 2306 RVA: 0x0002C167 File Offset: 0x0002A367
		public override bool OnCreateOptionsMenu(IMenu menu)
		{
			this.MenuInflater.Inflate(2131689482, menu);
			return base.OnCreateOptionsMenu(menu);
		}

		// Token: 0x06000903 RID: 2307 RVA: 0x0002C184 File Offset: 0x0002A384
		public override bool OnOptionsItemSelected(IMenuItem item)
		{
			int itemId = item.ItemId;
			if (itemId == 16908332)
			{
				Intent intent = new Intent();
				intent.PutExtra("LoveFeedback", this.isLoved);
				intent.PutExtra("LoversCount", this.loversCount);
				intent.PutExtra("DisloversCount", this.disloversCount);
				intent.PutExtra("ItemPosistion", this.itemPosition);
				base.SetResult(Result.Ok, intent);
				if (this.isOrientationChanged || this.finishOnRelatedCharClick)
				{
					this.Finish();
				}
				else
				{
					this.SupportFinishAfterTransition();
				}
				return true;
			}
			switch (itemId)
			{
			case 2131362620:
			{
				long num = JavaSystem.CurrentTimeMillis();
				if (num - this.mLastClickTime < CharacterDetailsActivity.CLICK_TIME_INTERVAL)
				{
					return true;
				}
				this.mLastClickTime = num;
				Bundle bundle = new Bundle();
				bundle.PutString("AnimeID", this.charId);
				bundle.PutString("CommType", "CHARACTER");
				Comments comments = new Comments();
				FragmentTransaction transaction = this.SupportFragmentManager.BeginTransaction();
				comments.Arguments = bundle;
				comments.Show(transaction, "Comments");
				return true;
			}
			case 2131362621:
				CustomizedToast.ShowToast(this, this.Resources.GetString(2131952247), 0);
				return true;
			case 2131362622:
			{
				Intent intent2 = new Intent("android.intent.action.SEND");
				intent2.SetType("text/plain");
				string str;
				if (this.Resources.GetString(2131951706) == "AR")
				{
					str = this.charArName;
				}
				else
				{
					str = this.charEnName;
				}
				intent2.PutExtra("android.intent.extra.SUBJECT", this.Resources.GetString(2131952019) + " " + str);
				intent2.PutExtra("android.intent.extra.TEXT", "https://play.google.com/store/apps/details?id=" + this.Resources.GetString(2131951708));
				this.StartActivity(Intent.CreateChooser(intent2, this.Resources.GetString(2131952394)));
				return true;
			}
			default:
				return base.OnOptionsItemSelected(item);
			}
		}

		// Token: 0x06000904 RID: 2308 RVA: 0x0002C37C File Offset: 0x0002A57C
		public override void OnBackPressed()
		{
			Intent intent = new Intent();
			intent.PutExtra("LoveFeedback", this.isLoved);
			intent.PutExtra("LoversCount", this.loversCount);
			intent.PutExtra("DisloversCount", this.disloversCount);
			intent.PutExtra("ItemPosistion", this.itemPosition);
			base.SetResult(Result.Ok, intent);
			if (this.isOrientationChanged || this.finishOnRelatedCharClick)
			{
				this.Finish();
			}
			else
			{
				base.OnBackPressed();
			}
			base.OnBackPressed();
		}

		// Token: 0x06000905 RID: 2309 RVA: 0x0002689A File Offset: 0x00024A9A
		protected override void OnResume()
		{
			base.OnResume();
			PublicFunctions.ValidateConnection();
		}

		// Token: 0x06000906 RID: 2310 RVA: 0x0002545B File Offset: 0x0002365B
		protected override void AttachBaseContext(Context @base)
		{
			base.AttachBaseContext(LocalizationChanger.UpdateResources(@base, "ar"));
		}

		// Token: 0x04000629 RID: 1577
		private UsersModel user;

		// Token: 0x0400062A RID: 1578
		private int userId;

		// Token: 0x0400062B RID: 1579
		private RecyclerView extraPhotosRecycler;

		// Token: 0x0400062C RID: 1580
		private RecyclerView voicActorsRecycler;

		// Token: 0x0400062D RID: 1581
		private RecyclerView topQuotesRecycler;

		// Token: 0x0400062E RID: 1582
		private RecyclerView animographyRecycler;

		// Token: 0x0400062F RID: 1583
		private RecyclerView relatedCharsRecycler;

		// Token: 0x04000630 RID: 1584
		private LinearLayoutManager extraPhotosHorizontalLayoutManagaer;

		// Token: 0x04000631 RID: 1585
		private LinearLayoutManager voicActorsHorizontalLayoutManagaer;

		// Token: 0x04000632 RID: 1586
		private LinearLayoutManager animographyHorizontalLayoutManagaer;

		// Token: 0x04000633 RID: 1587
		private LinearLayoutManager relatedCharsHorizontalLayoutManagaer;

		// Token: 0x04000634 RID: 1588
		private RecyclerView.LayoutManager topQuotesLayoutManagaer;

		// Token: 0x04000635 RID: 1589
		private CharactersVoiceActorsListAdapter voicActorsAdapter;

		// Token: 0x04000636 RID: 1590
		private CharacterQuotesListAdapter topQuotesAdapter;

		// Token: 0x04000637 RID: 1591
		private AnimeCatalogGridAdapter animographyAdapter;

		// Token: 0x04000638 RID: 1592
		private CharacterRelatedCharsAdapter relatedCharsAdapter;

		// Token: 0x04000639 RID: 1593
		private CharactersExtraPhotosListAdapter extraPhotosAdapter;

		// Token: 0x0400063A RID: 1594
		private ImageView mLoveBtn;

		// Token: 0x0400063B RID: 1595
		private ImageView mNotLoveBtn;

		// Token: 0x0400063C RID: 1596
		private LinearLayout mQuotesArea;

		// Token: 0x0400063D RID: 1597
		private LinearLayout mVoiceActorsArea;

		// Token: 0x0400063E RID: 1598
		private LinearLayout mAnimographyArea;

		// Token: 0x0400063F RID: 1599
		private LinearLayout mRelatedCharsArea;

		// Token: 0x04000640 RID: 1600
		private LinearLayout mAgeContent;

		// Token: 0x04000641 RID: 1601
		private LinearLayout mBirthdayContent;

		// Token: 0x04000642 RID: 1602
		private LinearLayout mHeightContent;

		// Token: 0x04000643 RID: 1603
		private LinearLayout mWeightContent;

		// Token: 0x04000644 RID: 1604
		private LinearLayout mBloodTypeContent;

		// Token: 0x04000645 RID: 1605
		private LinearLayout mHairColorContent;

		// Token: 0x04000646 RID: 1606
		private LinearLayout mEyeColorContent;

		// Token: 0x04000647 RID: 1607
		private LinearLayout mPositionContent;

		// Token: 0x04000648 RID: 1608
		private LinearLayout mOccupationContent;

		// Token: 0x04000649 RID: 1609
		private LinearLayout mLikesContent;

		// Token: 0x0400064A RID: 1610
		private LinearLayout mDislikesContent;

		// Token: 0x0400064B RID: 1611
		private LinearLayout mFavouriteFoodContent;

		// Token: 0x0400064C RID: 1612
		private LinearLayout mMoreAboutAContent;

		// Token: 0x0400064D RID: 1613
		private LinearLayout mMoreAboutBContent;

		// Token: 0x0400064E RID: 1614
		private LinearLayout mMoreAboutCContent;

		// Token: 0x0400064F RID: 1615
		private LinearLayout mExtraInfoContentA;

		// Token: 0x04000650 RID: 1616
		private LinearLayout mExtraInfoContentB;

		// Token: 0x04000651 RID: 1617
		private LinearLayout mExtraInfoContentC;

		// Token: 0x04000652 RID: 1618
		private LinearLayout mExtraInfoContentD;

		// Token: 0x04000653 RID: 1619
		private TextView mExtraInfoTitleA;

		// Token: 0x04000654 RID: 1620
		private TextView mExtraInfoTitleB;

		// Token: 0x04000655 RID: 1621
		private TextView mExtraInfoTitleC;

		// Token: 0x04000656 RID: 1622
		private TextView mExtraInfoTitleD;

		// Token: 0x04000657 RID: 1623
		private TextView mExtraInfoBodyA;

		// Token: 0x04000658 RID: 1624
		private TextView mExtraInfoBodyB;

		// Token: 0x04000659 RID: 1625
		private TextView mExtraInfoBodyC;

		// Token: 0x0400065A RID: 1626
		private TextView mExtraInfoBodyD;

		// Token: 0x0400065B RID: 1627
		private ProgressBar mCharDetailsLoader;

		// Token: 0x0400065C RID: 1628
		private ImageView mCharDetailsReload;

		// Token: 0x0400065D RID: 1629
		private ImageView mCharPhoto;

		// Token: 0x0400065E RID: 1630
		private TextView mCharEnName;

		// Token: 0x0400065F RID: 1631
		private TextView mCharAka;

		// Token: 0x04000660 RID: 1632
		private TextView mCharArName;

		// Token: 0x04000661 RID: 1633
		private TextView mCharJpName;

		// Token: 0x04000662 RID: 1634
		private TextView mCharBio;

		// Token: 0x04000663 RID: 1635
		private TextView mAboutTitle;

		// Token: 0x04000664 RID: 1636
		private TextView mLoversCount;

		// Token: 0x04000665 RID: 1637
		private TextView mDisLoversCount;

		// Token: 0x04000666 RID: 1638
		private TextView mAge;

		// Token: 0x04000667 RID: 1639
		private TextView mBirthday;

		// Token: 0x04000668 RID: 1640
		private TextView mHeight;

		// Token: 0x04000669 RID: 1641
		private TextView mWeight;

		// Token: 0x0400066A RID: 1642
		private TextView mGender;

		// Token: 0x0400066B RID: 1643
		private TextView mBloodType;

		// Token: 0x0400066C RID: 1644
		private TextView mHairColor;

		// Token: 0x0400066D RID: 1645
		private TextView mEyeColor;

		// Token: 0x0400066E RID: 1646
		private TextView mPosition;

		// Token: 0x0400066F RID: 1647
		private TextView mOccupation;

		// Token: 0x04000670 RID: 1648
		private TextView mLikes;

		// Token: 0x04000671 RID: 1649
		private TextView mDislikes;

		// Token: 0x04000672 RID: 1650
		private TextView mFavouriteFood;

		// Token: 0x04000673 RID: 1651
		private TextView mLikesTitle;

		// Token: 0x04000674 RID: 1652
		private TextView mDislikesTitle;

		// Token: 0x04000675 RID: 1653
		private TextView mMoreAboutATitle;

		// Token: 0x04000676 RID: 1654
		private TextView mMoreAboutBTitle;

		// Token: 0x04000677 RID: 1655
		private TextView mMoreAboutCTitle;

		// Token: 0x04000678 RID: 1656
		private TextView mMoreAboutABody;

		// Token: 0x04000679 RID: 1657
		private TextView mMoreAboutBBody;

		// Token: 0x0400067A RID: 1658
		private TextView mMoreAboutCBody;

		// Token: 0x0400067B RID: 1659
		private CharacterDetails mCharObject;

		// Token: 0x0400067C RID: 1660
		private List<string> charPhotos;

		// Token: 0x0400067D RID: 1661
		private WebClient mClient;

		// Token: 0x0400067E RID: 1662
		private Uri mUri;

		// Token: 0x0400067F RID: 1663
		private NameValueCollection parameters;

		// Token: 0x04000680 RID: 1664
		private string charId;

		// Token: 0x04000681 RID: 1665
		private string charEnName;

		// Token: 0x04000682 RID: 1666
		private string charAka;

		// Token: 0x04000683 RID: 1667
		private string charArName;

		// Token: 0x04000684 RID: 1668
		private string charJpName;

		// Token: 0x04000685 RID: 1669
		private string relationId;

		// Token: 0x04000686 RID: 1670
		private string charPhoto;

		// Token: 0x04000687 RID: 1671
		private string age;

		// Token: 0x04000688 RID: 1672
		private string height;

		// Token: 0x04000689 RID: 1673
		private string weight;

		// Token: 0x0400068A RID: 1674
		private string bloodType;

		// Token: 0x0400068B RID: 1675
		private string isLoved;

		// Token: 0x0400068C RID: 1676
		private int itemPosition;

		// Token: 0x0400068D RID: 1677
		private int loversCount;

		// Token: 0x0400068E RID: 1678
		private int disloversCount;

		// Token: 0x0400068F RID: 1679
		private int gender;

		// Token: 0x04000690 RID: 1680
		private int extraPhotosCount;

		// Token: 0x04000691 RID: 1681
		private bool isOrientationChanged;

		// Token: 0x04000692 RID: 1682
		private bool finishOnRelatedCharClick;

		// Token: 0x04000693 RID: 1683
		private Orientation mCurrentOrientation;

		// Token: 0x04000694 RID: 1684
		private long mLastClickTime = JavaSystem.CurrentTimeMillis();

		// Token: 0x04000695 RID: 1685
		private static readonly long CLICK_TIME_INTERVAL = 1000L;
	}
}
