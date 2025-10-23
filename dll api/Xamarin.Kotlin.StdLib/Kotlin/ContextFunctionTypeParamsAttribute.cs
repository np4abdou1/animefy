using System;
using Android.Runtime;

namespace Kotlin
{
	// Token: 0x02000045 RID: 69
	[Annotation("kotlin.ContextFunctionTypeParams")]
	public class ContextFunctionTypeParamsAttribute : Attribute
	{
		// Token: 0x17000011 RID: 17
		// (get) Token: 0x0600010D RID: 269 RVA: 0x00002755 File Offset: 0x00000955
		// (set) Token: 0x0600010E RID: 270 RVA: 0x0000275D File Offset: 0x0000095D
		[Register("count")]
		public int Count { get; set; }
	}
}
