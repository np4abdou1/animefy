using System;
using Android.Database;
using Android.Net;
using Android.Runtime;
using Java.Interop;

namespace Bumptech.Glide.Load.Data.Mediastore
{
	// Token: 0x0200019D RID: 413
	[Register("com/bumptech/glide/load/data/mediastore/ThumbnailQuery", "", "Bumptech.Glide.Load.Data.Mediastore.IThumbnailQueryInvoker")]
	public interface IThumbnailQuery : IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x060014D7 RID: 5335
		[Register("query", "(Landroid/net/Uri;)Landroid/database/Cursor;", "GetQuery_Landroid_net_Uri_Handler:Bumptech.Glide.Load.Data.Mediastore.IThumbnailQueryInvoker, Xamarin.Android.Glide")]
		ICursor Query(Android.Net.Uri p0);
	}
}
