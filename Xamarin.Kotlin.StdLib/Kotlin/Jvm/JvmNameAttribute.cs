using System;
using System.Runtime.CompilerServices;
using Android.Runtime;

namespace Kotlin.Jvm
{
	// Token: 0x0200017D RID: 381
	[NullableContext(2)]
	[Nullable(0)]
	[Annotation("kotlin.jvm.JvmName")]
	public class JvmNameAttribute : Attribute
	{
		// Token: 0x1700054B RID: 1355
		// (get) Token: 0x06001346 RID: 4934 RVA: 0x0003EBEB File Offset: 0x0003CDEB
		// (set) Token: 0x06001347 RID: 4935 RVA: 0x0003EBF3 File Offset: 0x0003CDF3
		[Register("name")]
		public string Name { get; set; }
	}
}
