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
using Android.Graphics;
using Android.OS;
using Android.Views;
using Android.Views.Animations;
using Android.Widget;
using AndroidX.AppCompat.App;
using AndroidX.CardView.Widget;
using AndroidX.Core.App;
using AndroidX.Core.Util;
using AndroidX.Fragment.App;
using AndroidX.RecyclerView.Widget;
using AndroidX.SwipeRefreshLayout.Widget;
using AQ.Dialogs;
using AQ.Helpers;
using AQ.Models;
using AQ.ViewAdapters;
using AQ.ViewModels;
using Bumptech.Glide;
using Google.Android.Material.Tabs;
using Java.Lang;
using Newtonsoft.Json;
using Refractored.Controls;

namespace AQ.Activities
{
	// Token: 0x020000D0 RID: 208
	[Activity(Label = "@string/app_name", Theme = "@style/AppTheme", ConfigurationChanges = (ConfigChanges.KeyboardHidden | ConfigChanges.Orientation | ConfigChanges.ScreenSize))]
	public class UserProfileActivity : AppCompatActivity
	{
		// Token: 0x06000A61 RID: 2657 RVA: 0x000373FC File Offset: 0x000355FC
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
			this.userId = this.Intent.GetStringExtra("UserId");
			this.displayName = this.Intent.GetStringExtra("DisplayName");
			this.bio = this.Intent.GetStringExtra("Bio");
			this.gender = this.Intent.GetStringExtra("Gender");
			this.membership = this.Intent.GetStringExtra("Membership");
			this.userProfilePhoto = this.Intent.GetStringExtra("ProfilePhoto");
			this.userGglProfilePhoto = this.Intent.GetStringExtra("GglProfilePhoto");
			this.userProfileCover = this.Intent.GetStringExtra("ProfileCover");
			this.allowLibraryView = this.Intent.GetIntExtra("LibraryViewAllowed", 0);
			this.SupportActionBar.Elevation = 0f;
			this.SupportActionBar.SetDisplayHomeAsUpEnabled(true);
			this.SupportActionBar.Title = this.displayName + " - " + this.Resources.GetString(2131952561);
			this.SetContentView(2131558462);
			this.user = UsersViewModel.GetUserProfile();
			this.visitorId = ((this.user == null) ? 0 : this.user.UserID);
			this.libraryList = new List<AnimeModel>();
			this.favouriteList = new List<AnimeModel>();
			this.charactersList = new List<CharacterModel>();
			base.FindViewById<RelativeLayout>(2131363206).ClipToOutline = true;
			this.mFavouritesBtn = base.FindViewById<Button>(2131363249);
			this.mLibraryBtn = base.FindViewById<Button>(2131363258);
			this.mFavouritesLoader = base.FindViewById<CardView>(2131363245);
			this.mLibraryLoader = base.FindViewById<CardView>(2131363254);
			this.mPremiumMark = base.FindViewById<ImageView>(2131363259);
			this.mFavouritesRecycler = base.FindViewById<RecyclerView>(2131363246);
			this.mLibraryRecycler = base.FindViewById<RecyclerView>(2131363255);
			this.mCommentsCount = base.FindViewById<TextView>(2131363204);
			this.mRepliesCount = base.FindViewById<TextView>(2131363262);
			this.mRatingsCount = base.FindViewById<TextView>(2131363261);
			this.mVisitorCount = base.FindViewById<TextView>(2131363265);
			this.mProfileCover = base.FindViewById<ImageView>(2131363205);
			this.mRefreshLoader = base.FindViewById<SwipeRefreshLayout>(2131363264);
			this.hideLoader = AnimationUtils.LoadAnimation(this, 2130771997);
			this.showLoader = AnimationUtils.LoadAnimation(this, 2130771998);
			this.mDisplayName = base.FindViewById<TextView>(2131363251);
			this.mBio = base.FindViewById<TextView>(2131363250);
			this.mProfilePhoto = base.FindViewById<CircleImageView>(2131363260);
			this.mFavouritesTabLayout = base.FindViewById<TabLayout>(2131363247);
			this.mLibraryTabLayout = base.FindViewById<TabLayout>(2131363256);
			this.mFavouritesEmptyView = base.FindViewById<TextView>(2131363244);
			this.mLibraryEmptyView = base.FindViewById<TextView>(2131363253);
			this.mMembership = base.FindViewById<TextView>(2131363252);
			this.mDisplayName.Text = this.displayName;
			if (this.bio != "")
			{
				this.mBio.Text = "\"" + this.bio + "\"";
				this.bioLinesCount = this.mBio.MaxLines;
				this.mBio.Post(new Suffixer(this, this.mBio, 6, this.Resources.GetString(2131951949)));
			}
			else
			{
				this.mBio.Text = "\"" + this.Resources.GetString(2131952232) + "\"";
			}
			if (this.userProfilePhoto != "" && this.userProfilePhoto != "N/A")
			{
				Glide.With(this).Load(Constants.ProfilePhoto(this.userProfilePhoto, this.userId)).Into(this.mProfilePhoto);
			}
			else if (this.userGglProfilePhoto != "" && this.userGglProfilePhoto != "N/A")
			{
				Glide.With(this).Load(this.userGglProfilePhoto).Into(this.mProfilePhoto);
			}
			if (this.userProfileCover != "")
			{
				Glide.With(this).Load(Constants.ProfileCover(this.userProfileCover, this.userId)).Into(this.mProfileCover);
			}
			if (this.membership == "ADMIN")
			{
				this.mMembership.Text = this.Resources.GetString(2131951669);
				this.mMembership.SetBackgroundResource(2131231248);
				this.mMembership.Visibility = ViewStates.Visible;
				this.mProfilePhoto.BorderColor = Color.Red;
			}
			else if (this.membership == "PREMIUM")
			{
				this.mMembership.Text = this.Resources.GetString(2131952304);
				this.mMembership.SetBackgroundResource(2131231245);
				this.mMembership.Visibility = ViewStates.Visible;
				this.mProfilePhoto.BorderColor = Color.Gold;
				this.mPremiumMark.Visibility = ViewStates.Visible;
			}
			if (this.allowLibraryView == 1)
			{
				this.mFavouritesBtn.Enabled = false;
				this.mFavouritesBtn.Text = this.Resources.GetString(2131952032);
				this.mFavouritesBtn.SetBackgroundResource(2131230904);
				this.mFavouritesBtn.SetTextColor(Color.ParseColor("#99FFFFFF"));
				this.mLibraryBtn.Enabled = false;
				this.mLibraryBtn.Text = this.Resources.GetString(2131952032);
				this.mLibraryBtn.SetBackgroundResource(2131230904);
				this.mLibraryBtn.SetTextColor(Color.ParseColor("#99FFFFFF"));
			}
			this.layoutManagerFavourites = new LinearLayoutManager(this, 0, false);
			this.layoutManagerLibrary = new LinearLayoutManager(this, 0, false);
			if (this.Resources.GetString(2131951706) == "EN")
			{
				this.recyclerDirection = 1;
			}
			else
			{
				this.recyclerDirection = -1;
			}
			ThreadPool.QueueUserWorkItem(delegate(object o)
			{
				this.UserStatistics();
			});
			this.mBio.Click += this.MBio_Click;
			this.mRefreshLoader.Refresh += this.MRefreshLoader_Refresh;
			this.mFavouritesBtn.Click += this.MFavouritesBtn_Click;
			this.mLibraryBtn.Click += this.MLibraryBtn_Click;
			this.mFavouritesRecycler.ScrollChange += this.MFavouritesRecycler_ScrollChange;
			this.mLibraryRecycler.ScrollChange += this.MLibraryRecycler_ScrollChange;
			this.mFavouritesTabLayout.TabSelected += this.MFavouritesTabLayout_TabSelected;
			this.mLibraryTabLayout.TabSelected += this.MLibraryTabLayout_TabSelected;
		}

		// Token: 0x06000A62 RID: 2658 RVA: 0x00037B64 File Offset: 0x00035D64
		private void MBio_Click(object sender, EventArgs e)
		{
			if (!(this.bio != ""))
			{
				this.mBio.Text = "\"" + this.Resources.GetString(2131952232) + "\"";
				return;
			}
			if (this.isBiographyExpanded)
			{
				this.mBio.Post(new Suffixer(this, this.mBio, 6, this.Resources.GetString(2131951949)));
				this.isBiographyExpanded = false;
				return;
			}
			this.mBio.SetMaxLines(this.bioLinesCount);
			this.mBio.Text = "\"" + this.bio + "\"";
			this.isBiographyExpanded = true;
		}

		// Token: 0x06000A63 RID: 2659 RVA: 0x00037C20 File Offset: 0x00035E20
		private void MFavouritesRecycler_ScrollChange(object sender, View.ScrollChangeEventArgs e)
		{
			if (!this.mFavouritesRecycler.CanScrollHorizontally(this.recyclerDirection))
			{
				if (!this.isFavouritesLoading)
				{
					this.isFavouritesLoading = true;
					AnimeModel.IsAnimationAllowed = false;
					this.mFavouritesLoader.StartAnimation(this.showLoader);
					this.mFavouritesLoader.Visibility = ViewStates.Visible;
					ThreadPool.QueueUserWorkItem(delegate(object o)
					{
						this.LoadFavourites(this.favouriteList.Count<AnimeModel>(), true);
					});
					return;
				}
			}
			else if (!AnimeModel.IsAnimationAllowed && !this.isFavouritesLoading)
			{
				AnimeModel.IsAnimationAllowed = true;
			}
		}

		// Token: 0x06000A64 RID: 2660 RVA: 0x00037C9C File Offset: 0x00035E9C
		private void MLibraryRecycler_ScrollChange(object sender, View.ScrollChangeEventArgs e)
		{
			if (!this.mLibraryRecycler.CanScrollHorizontally(this.recyclerDirection))
			{
				if (!this.isLibraryLoading)
				{
					this.isLibraryLoading = true;
					AnimeModel.IsAnimationAllowed = false;
					this.mLibraryLoader.StartAnimation(this.showLoader);
					this.mLibraryLoader.Visibility = ViewStates.Visible;
					ThreadPool.QueueUserWorkItem(delegate(object o)
					{
						this.LoadLibrary(this.libraryList.Count<AnimeModel>(), true);
					});
					return;
				}
			}
			else if (!AnimeModel.IsAnimationAllowed && !this.isLibraryLoading)
			{
				AnimeModel.IsAnimationAllowed = true;
			}
		}

		// Token: 0x06000A65 RID: 2661 RVA: 0x00037D18 File Offset: 0x00035F18
		private void MLibraryTabLayout_TabSelected(object sender, TabLayout.TabSelectedEventArgs e)
		{
			if (this.isLibraryOpened)
			{
				this.mLibraryLoader.StartAnimation(this.showLoader);
				this.mLibraryLoader.Visibility = ViewStates.Visible;
				if (e.Tab.Position == 0)
				{
					this.currentLibraryType = "WATCH_CURRENTLY";
					ThreadPool.QueueUserWorkItem(delegate(object o)
					{
						this.LoadLibrary(0, false);
					});
					return;
				}
				if (e.Tab.Position == 1)
				{
					this.currentLibraryType = "WATCH_LATER";
					ThreadPool.QueueUserWorkItem(delegate(object o)
					{
						this.LoadLibrary(0, false);
					});
					return;
				}
				if (e.Tab.Position == 2)
				{
					this.currentLibraryType = "WATCH_DONE";
					ThreadPool.QueueUserWorkItem(delegate(object o)
					{
						this.LoadLibrary(0, false);
					});
				}
			}
		}

		// Token: 0x06000A66 RID: 2662 RVA: 0x00037DD0 File Offset: 0x00035FD0
		private void MFavouritesTabLayout_TabSelected(object sender, TabLayout.TabSelectedEventArgs e)
		{
			if (this.isFavouritesOpened)
			{
				this.mFavouritesLoader.StartAnimation(this.showLoader);
				this.mFavouritesLoader.Visibility = ViewStates.Visible;
				if (e.Tab.Position == 0)
				{
					this.currentFavouriteType = "SERIES";
					ThreadPool.QueueUserWorkItem(delegate(object o)
					{
						this.LoadFavourites(0, false);
					});
					return;
				}
				if (e.Tab.Position == 1)
				{
					this.currentFavouriteType = "MOVIE";
					ThreadPool.QueueUserWorkItem(delegate(object o)
					{
						this.LoadFavourites(0, false);
					});
					return;
				}
				if (e.Tab.Position == 2)
				{
					ThreadPool.QueueUserWorkItem(delegate(object o)
					{
						this.LoadFavouriteCharacters(0, false);
					});
				}
			}
		}

		// Token: 0x06000A67 RID: 2663 RVA: 0x00037E7C File Offset: 0x0003607C
		private void MLibraryBtn_Click(object sender, EventArgs e)
		{
			this.isLibraryOpened = true;
			this.mLibraryBtn.Visibility = ViewStates.Gone;
			this.mLibraryLoader.StartAnimation(this.showLoader);
			this.mLibraryLoader.Visibility = ViewStates.Visible;
			ThreadPool.QueueUserWorkItem(delegate(object o)
			{
				this.LoadLibrary(0, false);
			});
		}

		// Token: 0x06000A68 RID: 2664 RVA: 0x00037ECC File Offset: 0x000360CC
		private void MFavouritesBtn_Click(object sender, EventArgs e)
		{
			this.isFavouritesOpened = true;
			this.mFavouritesBtn.Visibility = ViewStates.Gone;
			this.mFavouritesLoader.StartAnimation(this.showLoader);
			this.mFavouritesLoader.Visibility = ViewStates.Visible;
			ThreadPool.QueueUserWorkItem(delegate(object o)
			{
				this.LoadFavourites(0, false);
			});
		}

		// Token: 0x06000A69 RID: 2665 RVA: 0x00037F1B File Offset: 0x0003611B
		private void MRefreshLoader_Refresh(object sender, EventArgs e)
		{
			this.mRefreshLoader.Refreshing = false;
			ThreadPool.QueueUserWorkItem(delegate(object o)
			{
				this.UserStatistics();
			});
		}

		// Token: 0x06000A6A RID: 2666 RVA: 0x00037F3C File Offset: 0x0003613C
		private void UserStatistics()
		{
			this.client = new WebClient();
			this.uri = new Uri(Constants.ApiPhp("users/user_statistics.php"));
			NameValueCollection nameValueCollection = new NameValueCollection();
			nameValueCollection.Add("UserId", this.userId);
			nameValueCollection.Add("Token", "8cnY80AZSbUCmR26Vku1VUUY4");
			this.client.UploadValuesAsync(this.uri, nameValueCollection);
			this.client.UploadValuesCompleted += delegate(object senderc, UploadValuesCompletedEventArgs ec)
			{
				try
				{
					string @string = Encoding.UTF8.GetString(ec.Result);
					UserStatistics counterData = JsonConvert.DeserializeObject<UserStatistics>(@string);
					if (counterData != null)
					{
						base.RunOnUiThread(delegate()
						{
							this.mCommentsCount.Text = counterData.comments.ToString();
							this.mRepliesCount.Text = counterData.comments_replies.ToString();
							this.mRatingsCount.Text = counterData.ratings.ToString();
							this.mVisitorCount.Text = this.Resources.GetString(2131952567) + ": " + counterData.profile_views.ToString();
						});
					}
				}
				catch (System.Exception ex)
				{
					System.Exception ex3;
					System.Exception ex2 = ex3;
					System.Exception ex = ex2;
					base.RunOnUiThread(delegate()
					{
						CustomizedToast.ShowToast(this, ex.ToString(), 0);
					});
				}
			};
		}

		// Token: 0x06000A6B RID: 2667 RVA: 0x00037FBC File Offset: 0x000361BC
		private void LoadLibrary(int from = 0, bool loadMore = false)
		{
			this.client = new WebClient();
			this.uri = new Uri(Constants.ApiPhp("users/profile_library.php"));
			NameValueCollection nameValueCollection = new NameValueCollection();
			nameValueCollection.Add("UserId", this.userId);
			nameValueCollection.Add("VisistorId", this.visitorId.ToString());
			nameValueCollection.Add("Language", this.Resources.GetString(2131951706));
			nameValueCollection.Add("Library", this.currentLibraryType);
			nameValueCollection.Add("From", from.ToString());
			nameValueCollection.Add("Token", "8cnY80AZSbUCmR26Vku1VUUY4");
			this.client.UploadValuesAsync(this.uri, nameValueCollection);
			Action <>9__1;
			this.client.UploadValuesCompleted += delegate(object sender, UploadValuesCompletedEventArgs e)
			{
				try
				{
					string @string = Encoding.UTF8.GetString(e.Result);
					List<AnimeModel> animeTmpList = JsonConvert.DeserializeObject<List<AnimeModel>>(@string);
					this.RunOnUiThread(delegate()
					{
						if (animeTmpList != null)
						{
							if (loadMore)
							{
								this.libraryList.AddRange(animeTmpList);
								this.adapterLibrary.NotifyDataSetChanged();
							}
							else
							{
								this.libraryList.Clear();
								this.libraryList.AddRange(animeTmpList);
								this.adapterLibrary = new AnimeCatalogGridAdapter(this, this.libraryList, this.Resources.GetDimensionPixelSize(2131165282));
								this.adapterLibrary.ItemClick += this.AdapterLibrary_ItemClick;
								this.adapterLibrary.ItemLongClick += this.AdapterLibrary_ItemLongClick;
								this.layoutManagerLibrary = new LinearLayoutManager(this, 0, false);
								this.mLibraryRecycler.SetLayoutManager(this.layoutManagerLibrary);
								this.mLibraryRecycler.SetAdapter(this.adapterLibrary);
								if (this.libraryList.Count == 0)
								{
									this.mLibraryEmptyView.Visibility = ViewStates.Visible;
									this.mLibraryRecycler.Visibility = ViewStates.Gone;
								}
								else
								{
									this.mLibraryEmptyView.Visibility = ViewStates.Gone;
									this.mLibraryRecycler.Visibility = ViewStates.Visible;
								}
							}
						}
						this.isLibraryLoading = false;
						this.mLibraryLoader.StartAnimation(this.hideLoader);
						this.mLibraryLoader.Visibility = ViewStates.Gone;
					});
				}
				catch
				{
					Activity <>4__this = this;
					Action action;
					if ((action = <>9__1) == null)
					{
						action = (<>9__1 = delegate()
						{
							this.isLibraryLoading = false;
							this.mLibraryLoader.StartAnimation(this.hideLoader);
							this.mLibraryLoader.Visibility = ViewStates.Gone;
						});
					}
					<>4__this.RunOnUiThread(action);
				}
			};
		}

		// Token: 0x06000A6C RID: 2668 RVA: 0x000380A1 File Offset: 0x000362A1
		private void AdapterLibrary_ItemLongClick(object sender, int e)
		{
			this.AnimeDetailsGlance(this.libraryList, e);
		}

		// Token: 0x06000A6D RID: 2669 RVA: 0x000380B0 File Offset: 0x000362B0
		private void AdapterLibrary_ItemClick(object sender, int e)
		{
			this.OpenDetails(this.mLibraryRecycler, this.libraryList, e, 2, this.isLibraryLoading);
		}

		// Token: 0x06000A6E RID: 2670 RVA: 0x000380CC File Offset: 0x000362CC
		private void LoadFavourites(int from = 0, bool loadMore = false)
		{
			this.client = new WebClient();
			this.uri = new Uri(Constants.ApiPhp("users/profile_favourites.php"));
			NameValueCollection nameValueCollection = new NameValueCollection();
			nameValueCollection.Add("UserId", this.userId);
			nameValueCollection.Add("VisistorId", this.visitorId.ToString());
			nameValueCollection.Add("Language", this.Resources.GetString(2131951706));
			nameValueCollection.Add("Type", this.currentFavouriteType);
			nameValueCollection.Add("From", from.ToString());
			nameValueCollection.Add("Token", "8cnY80AZSbUCmR26Vku1VUUY4");
			this.client.UploadValuesAsync(this.uri, nameValueCollection);
			Action <>9__1;
			this.client.UploadValuesCompleted += delegate(object sender, UploadValuesCompletedEventArgs e)
			{
				try
				{
					string @string = Encoding.UTF8.GetString(e.Result);
					List<AnimeModel> animeTmpList = JsonConvert.DeserializeObject<List<AnimeModel>>(@string);
					this.RunOnUiThread(delegate()
					{
						if (animeTmpList != null)
						{
							if (loadMore)
							{
								this.favouriteList.AddRange(animeTmpList);
								this.adapterFavourites.NotifyDataSetChanged();
							}
							else
							{
								this.favouriteList.Clear();
								this.favouriteList.AddRange(animeTmpList);
								this.adapterFavourites = new AnimeCatalogGridAdapter(this, this.favouriteList, this.Resources.GetDimensionPixelSize(2131165282));
								this.adapterFavourites.ItemClick += this.AdapterFavourites_ItemClick;
								this.adapterFavourites.ItemLongClick += this.AdapterFavourites_ItemLongClick;
								this.layoutManagerFavourites = new LinearLayoutManager(this, 0, false);
								this.mFavouritesRecycler.SetLayoutManager(this.layoutManagerFavourites);
								this.mFavouritesRecycler.SetAdapter(this.adapterFavourites);
								if (this.favouriteList.Count == 0)
								{
									this.mFavouritesEmptyView.Visibility = ViewStates.Visible;
									this.mFavouritesRecycler.Visibility = ViewStates.Gone;
								}
								else
								{
									this.mFavouritesEmptyView.Visibility = ViewStates.Gone;
									this.mFavouritesRecycler.Visibility = ViewStates.Visible;
								}
							}
						}
						this.isFavouritesLoading = false;
						this.mFavouritesLoader.StartAnimation(this.hideLoader);
						this.mFavouritesLoader.Visibility = ViewStates.Gone;
					});
				}
				catch
				{
					Activity <>4__this = this;
					Action action;
					if ((action = <>9__1) == null)
					{
						action = (<>9__1 = delegate()
						{
							this.isFavouritesLoading = false;
							this.mFavouritesLoader.StartAnimation(this.hideLoader);
							this.mFavouritesLoader.Visibility = ViewStates.Gone;
						});
					}
					<>4__this.RunOnUiThread(action);
				}
			};
		}

		// Token: 0x06000A6F RID: 2671 RVA: 0x000381B1 File Offset: 0x000363B1
		private void AdapterFavourites_ItemLongClick(object sender, int e)
		{
			this.AnimeDetailsGlance(this.favouriteList, e);
		}

		// Token: 0x06000A70 RID: 2672 RVA: 0x000381C0 File Offset: 0x000363C0
		private void AdapterFavourites_ItemClick(object sender, int e)
		{
			this.OpenDetails(this.mFavouritesRecycler, this.favouriteList, e, 1, this.isFavouritesLoading);
		}

		// Token: 0x06000A71 RID: 2673 RVA: 0x000381DC File Offset: 0x000363DC
		private void LoadFavouriteCharacters(int from = 0, bool loadMore = false)
		{
			this.client = new WebClient();
			this.uri = new Uri(Constants.ApiPhp("users/profile_loved_chars.php"));
			NameValueCollection nameValueCollection = new NameValueCollection();
			nameValueCollection.Add("UserId", this.userId);
			nameValueCollection.Add("VisistorId", this.visitorId.ToString());
			nameValueCollection.Add("From", from.ToString());
			nameValueCollection.Add("Token", "8cnY80AZSbUCmR26Vku1VUUY4");
			this.client.UploadValuesAsync(this.uri, nameValueCollection);
			Action <>9__1;
			this.client.UploadValuesCompleted += delegate(object sender, UploadValuesCompletedEventArgs e)
			{
				try
				{
					string @string = Encoding.UTF8.GetString(e.Result);
					List<CharacterModel> charTmpList = JsonConvert.DeserializeObject<List<CharacterModel>>(@string);
					this.RunOnUiThread(delegate()
					{
						if (charTmpList != null)
						{
							if (loadMore)
							{
								this.charactersList.AddRange(charTmpList);
								this.adapterLovedCharacters.NotifyDataSetChanged();
							}
							else
							{
								this.charactersList.Clear();
								this.charactersList.AddRange(charTmpList);
								this.adapterLovedCharacters = new CharacterRelatedCharsAdapter(this, this.charactersList);
								this.adapterLovedCharacters.ItemClick += this.AdapterLovedCharacters_ItemClick;
								this.layoutManagerCharacters = new LinearLayoutManager(this, 0, false);
								this.mFavouritesRecycler.SetLayoutManager(this.layoutManagerCharacters);
								this.mFavouritesRecycler.SetAdapter(this.adapterLovedCharacters);
								if (this.charactersList.Count == 0)
								{
									this.mFavouritesEmptyView.Visibility = ViewStates.Visible;
									this.mFavouritesRecycler.Visibility = ViewStates.Gone;
								}
								else
								{
									this.mFavouritesEmptyView.Visibility = ViewStates.Gone;
									this.mFavouritesRecycler.Visibility = ViewStates.Visible;
								}
							}
						}
						this.isFavouritesLoading = false;
						this.mFavouritesLoader.StartAnimation(this.hideLoader);
						this.mFavouritesLoader.Visibility = ViewStates.Gone;
					});
				}
				catch
				{
					Activity <>4__this = this;
					Action action;
					if ((action = <>9__1) == null)
					{
						action = (<>9__1 = delegate()
						{
							this.isFavouritesLoading = false;
							this.mFavouritesLoader.StartAnimation(this.hideLoader);
							this.mFavouritesLoader.Visibility = ViewStates.Gone;
						});
					}
					<>4__this.RunOnUiThread(action);
				}
			};
		}

		// Token: 0x06000A72 RID: 2674 RVA: 0x00038298 File Offset: 0x00036498
		private void AdapterLovedCharacters_ItemClick(object sender, int e)
		{
			long num = JavaSystem.CurrentTimeMillis();
			if (num - this.mLastClickTime < UserProfileActivity.CLICK_TIME_INTERVAL)
			{
				return;
			}
			this.mLastClickTime = num;
			CharacterModel characterModel = this.charactersList[e];
			if (characterModel.Enabled == 0)
			{
				CustomizedToast.ShowToast(this, this.Resources.GetString(2131952247), 0);
				return;
			}
			View itemView = this.mFavouritesRecycler.FindViewHolderForAdapterPosition(e).ItemView;
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
				this.StartActivityForResult(intent, 3, activityOptionsCompat.ToBundle());
				return;
			}
			this.StartActivityForResult(intent, 3);
		}

		// Token: 0x06000A73 RID: 2675 RVA: 0x000384C0 File Offset: 0x000366C0
		private void OpenDetails(RecyclerView recyclerView, List<AnimeModel> list, int itemPosition, int resaultCode, bool isLoading)
		{
			long num = JavaSystem.CurrentTimeMillis();
			if (num - this.mLastClickTime < UserProfileActivity.CLICK_TIME_INTERVAL)
			{
				return;
			}
			this.mLastClickTime = num;
			AnimeModel animeModel = list[itemPosition];
			View itemView = recyclerView.FindViewHolderForAdapterPosition(itemPosition).ItemView;
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
			intent.PutExtra("ItemPosition", itemPosition);
			intent.PutExtra("Transition", isLoading);
			if (Build.VERSION.SdkInt >= BuildVersionCodes.Lollipop)
			{
				ActivityOptionsCompat activityOptionsCompat = ActivityOptionsCompat.MakeSceneTransitionAnimation(this, sharedElement, "catalogthumbnail");
				this.StartActivityForResult(intent, resaultCode, activityOptionsCompat.ToBundle());
				return;
			}
			this.StartActivityForResult(intent, resaultCode);
		}

		// Token: 0x06000A74 RID: 2676 RVA: 0x00038754 File Offset: 0x00036954
		private void AnimeDetailsGlance(List<AnimeModel> list, int itemPosition)
		{
			long num = JavaSystem.CurrentTimeMillis();
			if (num - this.mLastClickTime < UserProfileActivity.CLICK_TIME_INTERVAL)
			{
				return;
			}
			this.mLastClickTime = num;
			AnimeModel animeModel = list[itemPosition];
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

		// Token: 0x06000A75 RID: 2677 RVA: 0x000387F8 File Offset: 0x000369F8
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

		// Token: 0x06000A76 RID: 2678 RVA: 0x0002689A File Offset: 0x00024A9A
		protected override void OnResume()
		{
			base.OnResume();
			PublicFunctions.ValidateConnection();
		}

		// Token: 0x06000A77 RID: 2679 RVA: 0x0002545B File Offset: 0x0002365B
		protected override void AttachBaseContext(Context @base)
		{
			base.AttachBaseContext(LocalizationChanger.UpdateResources(@base, "ar"));
		}

		// Token: 0x040007FD RID: 2045
		private UsersModel user;

		// Token: 0x040007FE RID: 2046
		private int visitorId;

		// Token: 0x040007FF RID: 2047
		private SwipeRefreshLayout mRefreshLoader;

		// Token: 0x04000800 RID: 2048
		private WebClient client;

		// Token: 0x04000801 RID: 2049
		private Uri uri;

		// Token: 0x04000802 RID: 2050
		private Button mFavouritesBtn;

		// Token: 0x04000803 RID: 2051
		private Button mLibraryBtn;

		// Token: 0x04000804 RID: 2052
		private CardView mFavouritesLoader;

		// Token: 0x04000805 RID: 2053
		private CardView mLibraryLoader;

		// Token: 0x04000806 RID: 2054
		private RecyclerView mFavouritesRecycler;

		// Token: 0x04000807 RID: 2055
		private RecyclerView mLibraryRecycler;

		// Token: 0x04000808 RID: 2056
		private List<AnimeModel> favouriteList;

		// Token: 0x04000809 RID: 2057
		private List<AnimeModel> libraryList;

		// Token: 0x0400080A RID: 2058
		private List<CharacterModel> charactersList;

		// Token: 0x0400080B RID: 2059
		private LinearLayoutManager layoutManagerFavourites;

		// Token: 0x0400080C RID: 2060
		private LinearLayoutManager layoutManagerLibrary;

		// Token: 0x0400080D RID: 2061
		private LinearLayoutManager layoutManagerCharacters;

		// Token: 0x0400080E RID: 2062
		private AnimeCatalogGridAdapter adapterFavourites;

		// Token: 0x0400080F RID: 2063
		private AnimeCatalogGridAdapter adapterLibrary;

		// Token: 0x04000810 RID: 2064
		private CharacterRelatedCharsAdapter adapterLovedCharacters;

		// Token: 0x04000811 RID: 2065
		private ImageView mProfileCover;

		// Token: 0x04000812 RID: 2066
		private ImageView mPremiumMark;

		// Token: 0x04000813 RID: 2067
		private CircleImageView mProfilePhoto;

		// Token: 0x04000814 RID: 2068
		private TextView mDisplayName;

		// Token: 0x04000815 RID: 2069
		private TextView mMembership;

		// Token: 0x04000816 RID: 2070
		private TextView mBio;

		// Token: 0x04000817 RID: 2071
		private TextView mCommentsCount;

		// Token: 0x04000818 RID: 2072
		private TextView mRepliesCount;

		// Token: 0x04000819 RID: 2073
		private TextView mRatingsCount;

		// Token: 0x0400081A RID: 2074
		private TextView mVisitorCount;

		// Token: 0x0400081B RID: 2075
		private TextView mFavouritesEmptyView;

		// Token: 0x0400081C RID: 2076
		private TextView mLibraryEmptyView;

		// Token: 0x0400081D RID: 2077
		private TabLayout mFavouritesTabLayout;

		// Token: 0x0400081E RID: 2078
		private TabLayout mLibraryTabLayout;

		// Token: 0x0400081F RID: 2079
		private string userId;

		// Token: 0x04000820 RID: 2080
		private string displayName;

		// Token: 0x04000821 RID: 2081
		private string bio;

		// Token: 0x04000822 RID: 2082
		private string gender;

		// Token: 0x04000823 RID: 2083
		private string membership;

		// Token: 0x04000824 RID: 2084
		private string userProfilePhoto;

		// Token: 0x04000825 RID: 2085
		private string userGglProfilePhoto;

		// Token: 0x04000826 RID: 2086
		private string userProfileCover;

		// Token: 0x04000827 RID: 2087
		private int allowLibraryView;

		// Token: 0x04000828 RID: 2088
		private int recyclerDirection;

		// Token: 0x04000829 RID: 2089
		private int bioLinesCount = 1;

		// Token: 0x0400082A RID: 2090
		private string currentLibraryType = "WATCH_CURRENTLY";

		// Token: 0x0400082B RID: 2091
		private string currentFavouriteType = "SERIES";

		// Token: 0x0400082C RID: 2092
		private bool isFavouritesOpened;

		// Token: 0x0400082D RID: 2093
		private bool isLibraryOpened;

		// Token: 0x0400082E RID: 2094
		private bool isFavouritesLoading;

		// Token: 0x0400082F RID: 2095
		private bool isLibraryLoading;

		// Token: 0x04000830 RID: 2096
		private bool isBiographyExpanded;

		// Token: 0x04000831 RID: 2097
		private Animation hideLoader;

		// Token: 0x04000832 RID: 2098
		private Animation showLoader;

		// Token: 0x04000833 RID: 2099
		private long mLastClickTime = JavaSystem.CurrentTimeMillis();

		// Token: 0x04000834 RID: 2100
		private static readonly long CLICK_TIME_INTERVAL = 1000L;
	}
}
