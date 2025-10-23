using System;
using Android.OS;
using Android.Views;
using Android.Widget;
using AndroidX.Fragment.App;
using Bumptech.Glide;

namespace AQ.Dialogs
{
	// Token: 0x020000BA RID: 186
	public class ThumbnailsDialog : DialogFragment
	{
		// Token: 0x06000861 RID: 2145 RVA: 0x00024EBC File Offset: 0x000230BC
		public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
		{
			this.Dialog.Window.SetBackgroundDrawableResource(2131230936);
			this.view = inflater.Inflate(2131558516, container, false);
			this.thumbnailLink = base.Arguments.GetString("ThumbnailLink", "N/A");
			this.mThumbNail = this.view.FindViewById<ImageView>(2131362522);
			Glide.With(this).Load(this.thumbnailLink).CenterCrop().Placeholder(2131231224).Into(this.mThumbNail);
			return this.view;
		}

		// Token: 0x0400057F RID: 1407
		private View view;

		// Token: 0x04000580 RID: 1408
		private ImageView mThumbNail;

		// Token: 0x04000581 RID: 1409
		private string thumbnailLink;
	}
}
