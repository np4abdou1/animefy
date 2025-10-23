using System;
using Android.Runtime;
using Java.Lang;

namespace Bumptech.Glide.Request.Target
{
	// Token: 0x020000BC RID: 188
	[Register("com/bumptech/glide/request/target/Target", DoNotGenerateAcw = true)]
	public abstract class Target : Java.Lang.Object
	{
		// Token: 0x060009DA RID: 2522 RVA: 0x0001EB96 File Offset: 0x0001CD96
		internal Target()
		{
		}

		// Token: 0x04000268 RID: 616
		[Register("SIZE_ORIGINAL")]
		public const int SizeOriginal = -2147483648;
	}
}
