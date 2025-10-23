using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Bumptech.Glide.Load.Model
{
	// Token: 0x02000134 RID: 308
	[Register("com/bumptech/glide/load/model/Headers", "", "Bumptech.Glide.Load.Model.IHeadersInvoker")]
	public interface IHeaders : IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x17000411 RID: 1041
		// (get) Token: 0x06000FB4 RID: 4020 RVA: 0x00032B40 File Offset: 0x00030D40
		[Register("DEFAULT")]
		IHeaders Default
		{
			get
			{
				return Java.Lang.Object.GetObject<IHeaders>(IHeaders._members.StaticFields.GetObjectValue("DEFAULT.Lcom/bumptech/glide/load/model/Headers;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x17000412 RID: 1042
		// (get) Token: 0x06000FB5 RID: 4021 RVA: 0x00032B70 File Offset: 0x00030D70
		[Register("NONE")]
		[Obsolete("deprecated")]
		IHeaders None
		{
			get
			{
				return Java.Lang.Object.GetObject<IHeaders>(IHeaders._members.StaticFields.GetObjectValue("NONE.Lcom/bumptech/glide/load/model/Headers;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x17000413 RID: 1043
		// (get) Token: 0x06000FB6 RID: 4022
		IDictionary<string, string> Headers { [Register("getHeaders", "()Ljava/util/Map;", "GetGetHeadersHandler:Bumptech.Glide.Load.Model.IHeadersInvoker, Xamarin.Android.Glide")] get; }

		// Token: 0x0400039D RID: 925
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/bumptech/glide/load/model/Headers", typeof(IHeaders), true);
	}
}
