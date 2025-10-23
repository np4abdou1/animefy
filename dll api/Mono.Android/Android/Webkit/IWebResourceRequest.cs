using System;
using System.Collections.Generic;
using Android.Net;
using Android.Runtime;
using Java.Interop;

namespace Android.Webkit
{
	// Token: 0x02000102 RID: 258
	[Register("android/webkit/WebResourceRequest", "", "Android.Webkit.IWebResourceRequestInvoker")]
	public interface IWebResourceRequest : IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x17000123 RID: 291
		// (get) Token: 0x0600063F RID: 1599
		bool HasGesture { get; }

		// Token: 0x17000124 RID: 292
		// (get) Token: 0x06000640 RID: 1600
		bool IsForMainFrame { get; }

		// Token: 0x17000125 RID: 293
		// (get) Token: 0x06000641 RID: 1601
		bool IsRedirect { get; }

		// Token: 0x17000126 RID: 294
		// (get) Token: 0x06000642 RID: 1602
		string Method { get; }

		// Token: 0x17000127 RID: 295
		// (get) Token: 0x06000643 RID: 1603
		IDictionary<string, string> RequestHeaders { get; }

		// Token: 0x17000128 RID: 296
		// (get) Token: 0x06000644 RID: 1604
		Android.Net.Uri Url { get; }
	}
}
