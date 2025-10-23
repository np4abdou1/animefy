using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Bumptech.Glide.Manager
{
	// Token: 0x0200007E RID: 126
	[Register("com/bumptech/glide/manager/RequestManagerTreeNode", "", "Bumptech.Glide.Manager.IRequestManagerTreeNodeInvoker")]
	public interface IRequestManagerTreeNode : IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x1700010E RID: 270
		// (get) Token: 0x0600054F RID: 1359
		ICollection<RequestManager> Descendants { [Register("getDescendants", "()Ljava/util/Set;", "GetGetDescendantsHandler:Bumptech.Glide.Manager.IRequestManagerTreeNodeInvoker, Xamarin.Android.Glide")] get; }
	}
}
