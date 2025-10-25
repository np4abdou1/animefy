using System;
using Android.Content;
using Android.OS;
using Android.Views;
using Android.Widget;
using AndroidX.AppCompat.Widget;
using AndroidX.Fragment.App;
using AQ.Helpers;

namespace AQ.Fragments
{
	// Token: 0x02000099 RID: 153
	public class DialogCharctersSettings : DialogFragment
	{
		// Token: 0x060006A4 RID: 1700 RVA: 0x00013DDC File Offset: 0x00011FDC
		public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
		{
			this.Dialog.Window.SetBackgroundDrawableResource(2131230936);
			this.view = inflater.Inflate(2131558436, container, false);
			this.mARLang = this.view.FindViewById<RadioButton>(2131362141);
			this.mENLang = this.view.FindViewById<RadioButton>(2131362143);
			this.mJPLang = this.view.FindViewById<RadioButton>(2131362144);
			this.mDone = this.view.FindViewById<TextView>(2131362142);
			this.mEnableSuggestion = this.view.FindViewById<SwitchCompat>(2131362145);
			if (SharedPreferencesSaves.StringSharedPreferencesGet("CharsSuggestionsEnabled") != "NO")
			{
				this.mEnableSuggestion.Checked = true;
			}
			if (SharedPreferencesSaves.StringSharedPreferencesGet("CharsListLanguage") == "ar")
			{
				this.mARLang.Checked = true;
			}
			else if (SharedPreferencesSaves.StringSharedPreferencesGet("CharsListLanguage") == "jp")
			{
				this.mJPLang.Checked = true;
			}
			else
			{
				this.mENLang.Checked = true;
			}
			this.mARLang.CheckedChange += this.MARLang_CheckedChange;
			this.mENLang.CheckedChange += this.MENLang_CheckedChange;
			this.mJPLang.CheckedChange += this.MJPLang_CheckedChange;
			this.mEnableSuggestion.CheckedChange += this.MEnableSuggestion_CheckedChange;
			this.mDone.Click += this.MDone_Click;
			return this.view;
		}

		// Token: 0x060006A5 RID: 1701 RVA: 0x00013F6E File Offset: 0x0001216E
		private void MEnableSuggestion_CheckedChange(object sender, CompoundButton.CheckedChangeEventArgs e)
		{
			if (e.IsChecked)
			{
				SharedPreferencesSaves.StringSharedPreferencesSave("CharsSuggestionsEnabled", "YES");
			}
			else
			{
				SharedPreferencesSaves.StringSharedPreferencesSave("CharsSuggestionsEnabled", "NO");
			}
			this.isChangesMade = true;
		}

		// Token: 0x060006A6 RID: 1702 RVA: 0x00013F9F File Offset: 0x0001219F
		private void MJPLang_CheckedChange(object sender, CompoundButton.CheckedChangeEventArgs e)
		{
			if (e.IsChecked)
			{
				SharedPreferencesSaves.StringSharedPreferencesSave("CharsListLanguage", "jp");
				this.mARLang.Checked = false;
				this.mENLang.Checked = false;
			}
			this.isChangesMade = true;
		}

		// Token: 0x060006A7 RID: 1703 RVA: 0x00013FD7 File Offset: 0x000121D7
		private void MDone_Click(object sender, EventArgs e)
		{
			this.Dismiss();
		}

		// Token: 0x060006A8 RID: 1704 RVA: 0x00013FDF File Offset: 0x000121DF
		private void MENLang_CheckedChange(object sender, CompoundButton.CheckedChangeEventArgs e)
		{
			if (e.IsChecked)
			{
				SharedPreferencesSaves.StringSharedPreferencesSave("CharsListLanguage", "en");
				this.mARLang.Checked = false;
				this.mJPLang.Checked = false;
			}
			this.isChangesMade = true;
		}

		// Token: 0x060006A9 RID: 1705 RVA: 0x00014017 File Offset: 0x00012217
		private void MARLang_CheckedChange(object sender, CompoundButton.CheckedChangeEventArgs e)
		{
			if (e.IsChecked)
			{
				SharedPreferencesSaves.StringSharedPreferencesSave("CharsListLanguage", "ar");
				this.mENLang.Checked = false;
				this.mJPLang.Checked = false;
			}
			this.isChangesMade = true;
		}

		// Token: 0x060006AA RID: 1706 RVA: 0x0001404F File Offset: 0x0001224F
		public override void OnDismiss(IDialogInterface dialog)
		{
			if (this.isChangesMade)
			{
				base.Activity.Recreate();
			}
			base.OnDismiss(dialog);
		}

		// Token: 0x04000358 RID: 856
		private View view;

		// Token: 0x04000359 RID: 857
		private RadioButton mARLang;

		// Token: 0x0400035A RID: 858
		private RadioButton mENLang;

		// Token: 0x0400035B RID: 859
		private RadioButton mJPLang;

		// Token: 0x0400035C RID: 860
		private TextView mDone;

		// Token: 0x0400035D RID: 861
		private SwitchCompat mEnableSuggestion;

		// Token: 0x0400035E RID: 862
		private bool isChangesMade;
	}
}
