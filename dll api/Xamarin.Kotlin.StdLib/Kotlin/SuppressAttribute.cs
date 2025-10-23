using System;
using System.Runtime.CompilerServices;
using Android.Runtime;

namespace Kotlin
{
	// Token: 0x0200009F RID: 159
	[Annotation("kotlin.Suppress")]
	public class SuppressAttribute : Attribute
	{
		// Token: 0x170000F4 RID: 244
		// (get) Token: 0x06000458 RID: 1112 RVA: 0x0000A412 File Offset: 0x00008612
		// (set) Token: 0x06000459 RID: 1113 RVA: 0x0000A41A File Offset: 0x0000861A
		[Nullable(new byte[]
		{
			2,
			1
		})]
		[Register("names")]
		public string[] Names { [return: Nullable(new byte[]
		{
			2,
			1
		})] get; [param: Nullable(new byte[]
		{
			2,
			1
		})] set; }
	}
}
