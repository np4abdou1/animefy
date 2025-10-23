using System;
using Android.Runtime;
using Java.Interop;
using Java.Lang;
using Java.Nio.Charset;
using Java.Security;

namespace Bumptech.Glide.Load
{
	// Token: 0x020000D4 RID: 212
	[Register("com/bumptech/glide/load/Key", "", "Bumptech.Glide.Load.IKeyInvoker")]
	public interface IKey : IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x1700027D RID: 637
		// (get) Token: 0x06000AC5 RID: 2757 RVA: 0x000215D8 File Offset: 0x0001F7D8
		[Register("CHARSET")]
		Charset Charset
		{
			get
			{
				return Java.Lang.Object.GetObject<Charset>(IKey._members.StaticFields.GetObjectValue("CHARSET.Ljava/nio/charset/Charset;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x06000AC6 RID: 2758
		[Register("equals", "(Ljava/lang/Object;)Z", "GetEquals_Ljava_lang_Object_Handler:Bumptech.Glide.Load.IKeyInvoker, Xamarin.Android.Glide")]
		bool Equals(Java.Lang.Object p0);

		// Token: 0x06000AC7 RID: 2759
		[Register("hashCode", "()I", "GetGetHashCodeHandler:Bumptech.Glide.Load.IKeyInvoker, Xamarin.Android.Glide")]
		int GetHashCode();

		// Token: 0x06000AC8 RID: 2760
		[Register("updateDiskCacheKey", "(Ljava/security/MessageDigest;)V", "GetUpdateDiskCacheKey_Ljava_security_MessageDigest_Handler:Bumptech.Glide.Load.IKeyInvoker, Xamarin.Android.Glide")]
		void UpdateDiskCacheKey(MessageDigest p0);

		// Token: 0x040002A5 RID: 677
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/bumptech/glide/load/Key", typeof(IKey), true);
	}
}
