using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Net;
using System.Text;
using System.Threading;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Text;
using Android.Views;
using Android.Views.InputMethods;
using Android.Widget;
using AndroidX.Fragment.App;
using AndroidX.RecyclerView.Widget;
using AQ.Activities;
using AQ.Helpers;
using AQ.Models;
using AQ.ViewAdapters;
using AQ.ViewModels;
using Com.Wang.Avi;
using Newtonsoft.Json;

namespace AQ.Fragments
{
	// Token: 0x020000A3 RID: 163
	public class FeedbackFragment : AndroidX.Fragment.App.Fragment
	{
		// Token: 0x06000702 RID: 1794 RVA: 0x00016AC0 File Offset: 0x00014CC0
		public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
		{
			this.view = inflater.Inflate(2131558446, container, false);
			this.charSuggest = base.Arguments.GetBoolean("CharSuggest", false);
			this.user = UsersViewModel.GetUserProfile();
			this.userId = ((this.user == null) ? 0 : this.user.UserID);
			this.mNoteField = this.view.FindViewById<EditText>(2131362797);
			this.mSendButton = this.view.FindViewById<FrameLayout>(2131362972);
			this.mSendingProgress = this.view.FindViewById<FrameLayout>(2131362973);
			this.mCharCounter = this.view.FindViewById<TextView>(2131362398);
			this.mNoActiveFeedbacks = this.view.FindViewById<TextView>(2131362789);
			this.mSortbySpinner = this.view.FindViewById<Spinner>(2131363108);
			this.mFeedbacksLoader = this.view.FindViewById<AVLoadingIndicatorView>(2131362414);
			this.recyclerView = this.view.FindViewById<RecyclerView>(2131362413);
			this.mSendTxt = this.view.FindViewById<TextView>(2131362974);
			this.mSortbySpinner.ItemSelected += this.spinner_ItemSelected;
			ArrayAdapter arrayAdapter = ArrayAdapter.CreateFromResource(this.view.Context, 2130903041, 17367048);
			arrayAdapter.SetDropDownViewResource(17367049);
			this.mSortbySpinner.Adapter = arrayAdapter;
			if (this.charSuggest)
			{
				this.mSortbySpinner.SetSelection(2);
				this.mNoteField.Text = base.Resources.GetString(2131951764) + " ";
				this.mNoteField.RequestFocus();
				this.mNoteField.SetSelection(this.mNoteField.Text.Length);
				this.mCharCounter.Text = base.Resources.GetString(2131951936) + " " + (1000 - this.mNoteField.Length()).ToString();
			}
			else
			{
				this.mCharCounter.Text = base.Resources.GetString(2131951936) + " 1000";
			}
			if (this.userId == 0)
			{
				this.mNoActiveFeedbacks.Text = base.Resources.GetString(2131952049);
				this.mFeedbacksLoader.Visibility = ViewStates.Gone;
				this.mNoActiveFeedbacks.Visibility = ViewStates.Visible;
			}
			else
			{
				ThreadPool.QueueUserWorkItem(delegate(object o)
				{
					this.LoadActiveFeedbacks();
				});
			}
			this.mNoteField.TextChanged += this.MNoteField_TextChanged;
			this.mSendButton.Click += this.MSendButton_Click;
			return this.view;
		}

		// Token: 0x06000703 RID: 1795 RVA: 0x00016D78 File Offset: 0x00014F78
		private void spinner_ItemSelected(object sender, AdapterView.ItemSelectedEventArgs e)
		{
			switch (this.mSortbySpinner.SelectedItemPosition)
			{
			case 0:
				this.type = 0;
				this.subject = base.Resources.GetString(2131952244);
				return;
			case 1:
				this.type = 1;
				this.subject = base.Resources.GetString(2131951697);
				return;
			case 2:
				this.type = 2;
				if (this.charSuggest)
				{
					this.subject = base.Resources.GetString(2131952448);
					return;
				}
				this.subject = base.Resources.GetString(2131952448);
				return;
			case 3:
				this.type = 3;
				this.subject = base.Resources.GetString(2131951823);
				return;
			case 4:
				this.type = 4;
				this.subject = base.Resources.GetString(2131952336);
				return;
			default:
				this.type = 0;
				this.subject = base.Resources.GetString(2131952244);
				return;
			}
		}

		// Token: 0x06000704 RID: 1796 RVA: 0x00016E84 File Offset: 0x00015084
		private void MNoteField_TextChanged(object sender, TextChangedEventArgs e)
		{
			this.mCharCounter.Text = base.Resources.GetString(2131951936) + " " + (1000 - this.mNoteField.Length()).ToString();
		}

		// Token: 0x06000705 RID: 1797 RVA: 0x00016ED0 File Offset: 0x000150D0
		private void MSendButton_Click(object sender, EventArgs e)
		{
			if (this.mNoteField.Text.Trim() == "")
			{
				CustomizedToast.ShowToast(this.view.Context, base.Resources.GetString(2131952602), 0);
				return;
			}
			this.mSendingProgress.Visibility = ViewStates.Visible;
			this.mSendTxt.Visibility = ViewStates.Gone;
			this.mSendButton.Enabled = false;
			InputMethodManager inputMethodManager = (InputMethodManager)this.view.Context.GetSystemService("input_method");
			View currentFocus = base.Activity.CurrentFocus;
			if (currentFocus != null)
			{
				inputMethodManager.HideSoftInputFromWindow(currentFocus.WindowToken, HideSoftInputFlags.None);
			}
			this.SendFeedback();
		}

		// Token: 0x06000706 RID: 1798 RVA: 0x00016F80 File Offset: 0x00015180
		private void SendFeedback()
		{
			this.client = new WebClient();
			this.uri = new Uri(Constants.ApiPhp("feedback/feedback_add.php"));
			this.parameters = new NameValueCollection();
			this.parameters.Add("UserID", this.userId.ToString());
			this.parameters.Add("Type", this.type.ToString());
			this.parameters.Add("Subject", this.subject);
			this.parameters.Add("Note", this.mNoteField.Text.Trim());
			this.parameters.Add("Version", base.Resources.GetString(2131951714).Substring(1, base.Resources.GetString(2131951714).Length - 1));
			this.parameters.Add("SendDate", DateTime.Now.ToShortDateString());
			this.parameters.Add("Status", "1");
			this.parameters.Add("Token", "8cnY80AZSbUCmR26Vku1VUUY4");
			this.client.UploadValuesAsync(this.uri, this.parameters);
			this.client.UploadValuesCompleted += delegate(object s, UploadValuesCompletedEventArgs e)
			{
				try
				{
					string @string = Encoding.UTF8.GetString(e.Result);
					FeedBackModel feedBackModel = JsonConvert.DeserializeObject<FeedBackModel>(@string);
					if (feedBackModel != null)
					{
						this.mSendingProgress.Visibility = ViewStates.Gone;
						this.mSendTxt.Visibility = ViewStates.Visible;
						this.mSendButton.Enabled = true;
						CustomizedToast.ShowToast(this.view.Context, base.Resources.GetString(2131952339), 0);
						if (this.adapter != null)
						{
							this.mNoteField.Text = "";
							this.mNoActiveFeedbacks.Visibility = ViewStates.Gone;
							this.mFeedbacksList.Insert(0, feedBackModel);
							this.adapter.NotifyItemInserted(0);
						}
					}
				}
				catch
				{
					this.mSendTxt.Visibility = ViewStates.Visible;
					this.mSendingProgress.Visibility = ViewStates.Gone;
					this.mSendButton.Enabled = true;
					CustomizedToast.ShowToast(this.view.Context, base.Resources.GetString(2131951831), 0);
				}
			};
		}

		// Token: 0x06000707 RID: 1799 RVA: 0x000170D8 File Offset: 0x000152D8
		private void LoadActiveFeedbacks()
		{
			this.client = new WebClient();
			this.uri = new Uri(Constants.ApiPhp("feedback/load_active_feedbacks.php"));
			this.parameters = new NameValueCollection();
			this.parameters.Add("UserID", this.userId.ToString());
			this.parameters.Add("Token", "8cnY80AZSbUCmR26Vku1VUUY4");
			this.client.UploadValuesAsync(this.uri, this.parameters);
			this.client.UploadValuesCompleted += delegate(object s, UploadValuesCompletedEventArgs e)
			{
				base.Activity.RunOnUiThread(delegate()
				{
					try
					{
						string @string = Encoding.UTF8.GetString(e.Result);
						this.mFeedbacksList = JsonConvert.DeserializeObject<List<FeedBackModel>>(@string);
						if (this.mFeedbacksList != null)
						{
							this.adapter = new FeedbacksListAdapter(this.view.Context, this.mFeedbacksList);
							this.adapter.ItemClick += this.Adapter_ItemClick;
							this.layoutManager = new GridLayoutManager(this.view.Context, 1);
							this.recyclerView.SetLayoutManager(this.layoutManager);
							this.recyclerView.SetAdapter(this.adapter);
							if (this.mFeedbacksList.Count == 0)
							{
								this.mNoActiveFeedbacks.Visibility = ViewStates.Visible;
							}
							else
							{
								this.recyclerView.Visibility = ViewStates.Visible;
							}
							this.mFeedbacksLoader.Visibility = ViewStates.Gone;
						}
						else
						{
							this.mFeedbacksLoader.Visibility = ViewStates.Gone;
							CustomizedToast.ShowToast(this.view.Context, this.Resources.GetString(2131951941), 0);
						}
					}
					catch
					{
						this.mFeedbacksLoader.Visibility = ViewStates.Gone;
						CustomizedToast.ShowToast(this.view.Context, this.Resources.GetString(2131951941), 0);
					}
				});
			};
		}

		// Token: 0x06000708 RID: 1800 RVA: 0x00017170 File Offset: 0x00015370
		private void Adapter_ItemClick(object sender, int e)
		{
			FeedBackModel feedBackModel = this.mFeedbacksList[e];
			Intent intent = new Intent(Application.Context, typeof(FeedbackConversationActivity));
			intent.PutExtra("FeedId", feedBackModel.ID.ToString());
			if (feedBackModel.Subject == "")
			{
				intent.PutExtra("Subject", base.Resources.GetString(2131952244));
			}
			else
			{
				intent.PutExtra("Subject", feedBackModel.Subject);
			}
			intent.PutExtra("Body", feedBackModel.Note);
			this.StartActivity(intent);
		}

		// Token: 0x040003D7 RID: 983
		private View view;

		// Token: 0x040003D8 RID: 984
		private UsersModel user;

		// Token: 0x040003D9 RID: 985
		private int userId;

		// Token: 0x040003DA RID: 986
		private EditText mNoteField;

		// Token: 0x040003DB RID: 987
		private TextView mCharCounter;

		// Token: 0x040003DC RID: 988
		private TextView mNoActiveFeedbacks;

		// Token: 0x040003DD RID: 989
		private Spinner mSortbySpinner;

		// Token: 0x040003DE RID: 990
		private RecyclerView recyclerView;

		// Token: 0x040003DF RID: 991
		private RecyclerView.LayoutManager layoutManager;

		// Token: 0x040003E0 RID: 992
		private FeedbacksListAdapter adapter;

		// Token: 0x040003E1 RID: 993
		private List<FeedBackModel> mFeedbacksList;

		// Token: 0x040003E2 RID: 994
		private AVLoadingIndicatorView mFeedbacksLoader;

		// Token: 0x040003E3 RID: 995
		private TextView mSendTxt;

		// Token: 0x040003E4 RID: 996
		private FrameLayout mSendingProgress;

		// Token: 0x040003E5 RID: 997
		private FrameLayout mSendButton;

		// Token: 0x040003E6 RID: 998
		private WebClient client;

		// Token: 0x040003E7 RID: 999
		private Uri uri;

		// Token: 0x040003E8 RID: 1000
		private NameValueCollection parameters;

		// Token: 0x040003E9 RID: 1001
		private bool charSuggest;

		// Token: 0x040003EA RID: 1002
		private string subject = "";

		// Token: 0x040003EB RID: 1003
		private int type;
	}
}
