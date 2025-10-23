using System;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Bumptech.Glide.Load.Model
{
	// Token: 0x02000132 RID: 306
	[Register("com/bumptech/glide/load/model/Headers", DoNotGenerateAcw = true)]
	public abstract class Headers : Java.Lang.Object
	{
		// Token: 0x06000FAF RID: 4015 RVA: 0x00032AB3 File Offset: 0x00030CB3
		internal Headers()
		{
		}

		// Token: 0x1700040F RID: 1039
		// (get) Token: 0x06000FB0 RID: 4016 RVA: 0x00032ABC File Offset: 0x00030CBC
		[Register("DEFAULT")]
		public static IHeaders Default
		{
			get
			{
				return Java.Lang.Object.GetObject<IHeaders>(Headers._members.StaticFields.GetObjectValue("DEFAULT.Lcom/bumptech/glide/load/model/Headers;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x17000410 RID: 1040
		// (get) Token: 0x06000FB1 RID: 4017 RVA: 0x00032AEC File Offset: 0x00030CEC
		[Register("NONE")]
		[Obsolete("deprecated")]
		public static IHeaders None
		{
			get
			{
				return Java.Lang.Object.GetObject<IHeaders>(Headers._members.StaticFields.GetObjectValue("NONE.Lcom/bumptech/glide/load/model/Headers;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x0400039C RID: 924
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/bumptech/glide/load/model/Headers", typeof(Headers));
	}
}
