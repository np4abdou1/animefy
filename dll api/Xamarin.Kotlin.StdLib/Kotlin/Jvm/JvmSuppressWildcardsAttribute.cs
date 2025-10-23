using System;
using Android.Runtime;

namespace Kotlin.Jvm
{
	// Token: 0x02000182 RID: 386
	[Annotation("kotlin.jvm.JvmSuppressWildcards")]
	public class JvmSuppressWildcardsAttribute : Attribute
	{
		// Token: 0x1700054C RID: 1356
		// (get) Token: 0x0600134D RID: 4941 RVA: 0x0003EC24 File Offset: 0x0003CE24
		// (set) Token: 0x0600134E RID: 4942 RVA: 0x0003EC2C File Offset: 0x0003CE2C
		[Register("suppress")]
		public bool Suppress { get; set; }
	}
}
