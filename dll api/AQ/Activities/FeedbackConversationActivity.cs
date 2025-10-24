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
using Android.OS;
using Android.Text;
using Android.Views;
using Android.Views.Animations;
using Android.Widget;
using AndroidX.AppCompat.App;
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
using Newtonsoft.Json;
using Refractored.Controls;

namespace AQ.Activities
{
	// Token: 0x020000C7 RID: 199
	[Activity(Label = "@string/app_name", Theme = "@style/AppTheme", ConfigurationChanges = (ConfigChanges.Orientation | ConfigChanges.ScreenSize))]
	public class FeedbackConversationActivity : AppCompatActivity
	{
		// Token: 0x0600098E RID: 2446 RVA: 0x000304C0 File Offset: 0x0002E6C0
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
			this.OverridePendingTransition(2130772003, 2130772004);
			this.SupportActionBar.Elevation = 0f;
			this.SupportActionBar.SetDisplayHomeAsUpEnabled(true);
			this.SetContentView(2131558445);
			this.user = UsersViewModel.GetUserProfile();
			this.userId = ((this.user == null) ? 0 : this.user.UserID);
			this.feedId = this.Intent.GetStringExtra("FeedId");
			this.subject = this.Intent.GetStringExtra("Subject");
			this.body = this.Intent.GetStringExtra("Body");
			this.SupportActionBar.Title = this.subject;
			this.mFeedBody = base.FindViewById<TextView>(2131362396);
			this.mNoReplies = base.FindViewById<TextView>(2131362402);
			this.recyclerView = base.FindViewById<RecyclerView>(2131362415);
			this.mFeedbackRepliesLoader = base.FindViewById<AVLoadingIndicatorView>(2131362406);
			this.mFeedbackSendLoader = base.FindViewById<ProgressBar>(2131362409);
			this.mSendButton = base.FindViewById<ImageView>(2131362407);
			this.mSendConetnet = base.FindViewById<FrameLayout>(2131362408);
			this.mTypingField = base.FindViewById<EditText>(2131362411);
			this.sendReady = AnimationUtils.LoadAnimation(this, 2130771998);
			this.sendNotReady = AnimationUtils.LoadAnimation(this, 2130771997);
			this.mFeedBody.Text = this.body;
			if (this.userId != 0)
			{
				this.user = UsersViewModel.GetUserProfile();
				if (this.user != null)
				{
					this.mAvatar = base.FindViewById<CircleImageView>(2131362394);
					if (this.user.ProfileImage != "")
					{
						Glide.With(this).Load(Constants.ProfilePhoto(this.user.ProfileImage, this.user.UserID.ToString())).CenterCrop().Into(this.mAvatar);
					}
					else if (this.user.GoogleProfilePhotoUrl != "")
					{
						Glide.With(this).Load(this.user.GoogleProfilePhotoUrl).CenterCrop().Into(this.mAvatar);
					}
				}
			}
			this.recyclerView.Visibility = ViewStates.Visible;
			this.mTypingField.TextChanged += this.MTypingField_TextChanged;
			this.mSendButton.Click += this.MSendButton_Click;
			ThreadPool.QueueUserWorkItem(delegate(object o)
			{
				this.LoadFeedbackReplies();
			});
		}

		// Token: 0x0600098F RID: 2447 RVA: 0x000307BC File Offset: 0x0002E9BC
		private void MSendButton_Click(object sender, EventArgs e)
		{
			if (this.userId == 0)
			{
				return;
			}
			if (this.mTypingField.Text.StartsWith("/") && this.user.Membership != "ADMIN")
			{
				CustomizedToast.ShowToast(this, this.Resources.GetString(2131952599), 0);
				return;
			}
			if (this.user.CommunicationStatus == "BLOCK")
			{
				CommunicationBlock communicationBlock = new CommunicationBlock();
				FragmentTransaction transaction = this.SupportFragmentManager.BeginTransaction();
				communicationBlock.Show(transaction, "BlockedDialog");
				return;
			}
			this.mSendButton.StartAnimation(this.sendNotReady);
			this.mSendButton.Clickable = false;
			this.IsSendAnimated = false;
			this.mFeedbackSendLoader.Visibility = ViewStates.Visible;
			this.AddFeedbakcReply();
		}

		// Token: 0x06000990 RID: 2448 RVA: 0x00030888 File Offset: 0x0002EA88
		private void MTypingField_TextChanged(object sender, TextChangedEventArgs e)
		{
			if (this.mTypingField.Text.Trim() == "")
			{
				if (this.IsSendAnimated)
				{
					this.mSendButton.StartAnimation(this.sendNotReady);
					this.mSendConetnet.Visibility = ViewStates.Gone;
					this.mSendButton.Clickable = false;
					this.IsSendAnimated = false;
					return;
				}
			}
			else if (!this.IsSendAnimated)
			{
				this.mSendButton.StartAnimation(this.sendReady);
				this.mSendConetnet.Visibility = ViewStates.Visible;
				this.mSendButton.Clickable = true;
				this.IsSendAnimated = true;
			}
		}

		// Token: 0x06000991 RID: 2449 RVA: 0x00030924 File Offset: 0x0002EB24
		public void AddFeedbakcReply()
		{
			this.client = new WebClient();
			this.uri = new Uri(Constants.ApiPhp("feedback/feedback_reply_add.php"));
			this.parameters = new NameValueCollection();
			this.parameters.Add("UserID", this.userId.ToString());
			this.parameters.Add("FeedbackId", this.feedId);
			this.parameters.Add("ReplyBody", this.mTypingField.Text.Trim());
			this.parameters.Add("Token", "8cnY80AZSbUCmR26Vku1VUUY4");
			this.client.UploadValuesAsync(this.uri, this.parameters);
			this.client.UploadValuesCompleted += delegate(object s, UploadValuesCompletedEventArgs e)
			{
				try
				{
					string @string = Encoding.UTF8.GetString(e.Result);
					this.mLastFeedBack = JsonConvert.DeserializeObject<FeedBackRepliesModel>(@string);
					if (this.mLastFeedBack != null)
					{
						int num = this.mFeedbackRepliesList.Count<FeedBackRepliesModel>();
						this.mFeedbackRepliesList.Insert(num, this.mLastFeedBack);
						this.mTypingField.Text = "";
						this.adapter.NotifyItemInserted(num);
						this.mNoReplies.Visibility = ViewStates.Gone;
						this.mSendButton.Clickable = false;
						this.recyclerView.ScrollToPosition(0);
					}
					else
					{
						this.mSendButton.StartAnimation(this.sendReady);
						this.mSendButton.Clickable = true;
						this.IsSendAnimated = true;
						CustomizedToast.ShowToast(this, this.Resources.GetString(2131951828), 0);
					}
					this.mFeedbackSendLoader.Visibility = ViewStates.Gone;
					this.mSendConetnet.Visibility = ViewStates.Gone;
				}
				catch
				{
					this.mSendButton.Clickable = true;
					this.IsSendAnimated = true;
					this.mFeedbackSendLoader.Visibility = ViewStates.Gone;
					this.mSendButton.StartAnimation(this.sendReady);
					CustomizedToast.ShowToast(this, this.Resources.GetString(2131951828), 0);
				}
			};
		}

		// Token: 0x06000992 RID: 2450 RVA: 0x000309F0 File Offset: 0x0002EBF0
		private void LoadFeedbackReplies()
		{
			this.client = new WebClient();
			this.uri = new Uri(Constants.ApiPhp("feedback/feedback_replies.php"));
			this.parameters = new NameValueCollection();
			this.parameters.Add("FeedbackId", this.feedId);
			this.parameters.Add("Token", "8cnY80AZSbUCmR26Vku1VUUY4");
			this.client.UploadValuesAsync(this.uri, this.parameters);
			this.client.UploadValuesCompleted += delegate(object s, UploadValuesCompletedEventArgs e)
			{
				base.RunOnUiThread(delegate()
				{
					try
					{
						string @string = Encoding.UTF8.GetString(e.Result);
						this.mFeedbackRepliesList = JsonConvert.DeserializeObject<List<FeedBackRepliesModel>>(@string);
						if (this.mFeedbackRepliesList != null)
						{
							this.adapter = new FeedbacksRepliesListAdapter(this, this.mFeedbackRepliesList);
							this.adapter.ItemAvatarClick += this.Adapter_ItemAvatarClick;
							this.layoutManager = new GridLayoutManager(this, 1);
							this.recyclerView.SetLayoutManager(this.layoutManager);
							this.recyclerView.SetAdapter(this.adapter);
							if (this.mFeedbackRepliesList.Count == 0)
							{
								this.mNoReplies.Visibility = ViewStates.Visible;
							}
							else
							{
								this.recyclerView.Visibility = ViewStates.Visible;
							}
							this.mFeedbackRepliesLoader.Visibility = ViewStates.Gone;
						}
						else
						{
							this.mFeedbackRepliesLoader.Visibility = ViewStates.Gone;
							CustomizedToast.ShowToast(this, this.Resources.GetString(2131951941), 0);
						}
					}
					catch
					{
						this.mFeedbackRepliesLoader.Visibility = ViewStates.Gone;
						CustomizedToast.ShowToast(this, this.Resources.GetString(2131951941), 0);
					}
				});
			};
		}

		// Token: 0x06000993 RID: 2451 RVA: 0x00030A84 File Offset: 0x0002EC84
		private void Adapter_ItemAvatarClick(object sender, int e)
		{
			FeedBackRepliesModel feedBackRepliesModel = this.mFeedbackRepliesList[e];
			Bundle bundle = new Bundle();
			bundle.PutString("UserId", feedBackRepliesModel.UserData.UserID.ToString());
			bundle.PutString("DisplayName", feedBackRepliesModel.UserData.FullName);
			bundle.PutString("Bio", feedBackRepliesModel.UserData.Bio);
			bundle.PutString("Gender", feedBackRepliesModel.UserData.Gender);
			bundle.PutString("Membership", feedBackRepliesModel.UserData.Membership);
			bundle.PutString("ProfilePhoto", feedBackRepliesModel.UserData.ProfileImage);
			bundle.PutString("GglPforilePhoto", feedBackRepliesModel.UserData.GoogleProfilePhotoUrl);
			bundle.PutString("ProfileCover", feedBackRepliesModel.UserData.ProfileCover);
			bundle.PutInt("LibraryViewAllowed", feedBackRepliesModel.UserData.AllowLibraryView);
			DialogUserProfile dialogUserProfile = new DialogUserProfile();
			FragmentTransaction transaction = this.SupportFragmentManager.BeginTransaction();
			dialogUserProfile.Arguments = bundle;
			dialogUserProfile.Show(transaction, "DialogUserProfile");
		}

		// Token: 0x06000994 RID: 2452 RVA: 0x00030B9C File Offset: 0x0002ED9C
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

		// Token: 0x06000995 RID: 2453 RVA: 0x0002689A File Offset: 0x00024A9A
		protected override void OnResume()
		{
			base.OnResume();
			PublicFunctions.ValidateConnection();
		}

		// Token: 0x06000996 RID: 2454 RVA: 0x0002545B File Offset: 0x0002365B
		protected override void AttachBaseContext(Context @base)
		{
			base.AttachBaseContext(LocalizationChanger.UpdateResources(@base, "ar"));
		}

		// Token: 0x0400070C RID: 1804
		private UsersModel user;

		// Token: 0x0400070D RID: 1805
		private int userId;

		// Token: 0x0400070E RID: 1806
		private TextView mFeedBody;

		// Token: 0x0400070F RID: 1807
		private TextView mNoReplies;

		// Token: 0x04000710 RID: 1808
		private RecyclerView recyclerView;

		// Token: 0x04000711 RID: 1809
		private RecyclerView.LayoutManager layoutManager;

		// Token: 0x04000712 RID: 1810
		private FeedbacksRepliesListAdapter adapter;

		// Token: 0x04000713 RID: 1811
		private List<FeedBackRepliesModel> mFeedbackRepliesList;

		// Token: 0x04000714 RID: 1812
		private AVLoadingIndicatorView mFeedbackRepliesLoader;

		// Token: 0x04000715 RID: 1813
		private ImageView mSendButton;

		// Token: 0x04000716 RID: 1814
		private FeedBackRepliesModel mLastFeedBack;

		// Token: 0x04000717 RID: 1815
		private FrameLayout mSendConetnet;

		// Token: 0x04000718 RID: 1816
		private CircleImageView mAvatar;

		// Token: 0x04000719 RID: 1817
		private WebClient client;

		// Token: 0x0400071A RID: 1818
		private Uri uri;

		// Token: 0x0400071B RID: 1819
		private NameValueCollection parameters;

		// Token: 0x0400071C RID: 1820
		private ProgressBar mFeedbackSendLoader;

		// Token: 0x0400071D RID: 1821
		private EditText mTypingField;

		// Token: 0x0400071E RID: 1822
		private string subject;

		// Token: 0x0400071F RID: 1823
		private string body;

		// Token: 0x04000720 RID: 1824
		private string feedId;

		// Token: 0x04000721 RID: 1825
		private bool IsSendAnimated;

		// Token: 0x04000722 RID: 1826
		private Animation sendReady;

		// Token: 0x04000723 RID: 1827
		private Animation sendNotReady;
	}
}
