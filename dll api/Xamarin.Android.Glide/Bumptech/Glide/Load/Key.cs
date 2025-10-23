using System;
using Android.Runtime;
using Java.Interop;
using Java.Lang;
using Java.Nio.Charset;

namespace Bumptech.Glide.Load
{
	// Token: 0x020000D2 RID: 210
	[Register("com/bumptech/glide/load/Key", DoNotGenerateAcw = true)]
	public abstract class Key : Java.Lang.Object
	{
		// Token: 0x06000AC1 RID: 2753 RVA: 0x0002157C File Offset: 0x0001F77C
		internal Key()
		{
		}

		// Token: 0x1700027C RID: 636
		// (get) Token: 0x06000AC2 RID: 2754 RVA: 0x00021584 File Offset: 0x0001F784
		[Register("CHARSET")]
		public static Charset Charset
		{
			get
			{
				return Java.Lang.Object.GetObject<Charset>(Key._members.StaticFields.GetObjectValue("CHARSET.Ljava/nio/charset/Charset;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x040002A3 RID: 675
		[Register("STRING_CHARSET_NAME")]
		public const string StringCharsetName = "UTF-8";

		// Token: 0x040002A4 RID: 676
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/bumptech/glide/load/Key", typeof(Key));
	}
}
