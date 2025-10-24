using System;
using System.Runtime.CompilerServices;
using Android.Runtime;

namespace Kotlin
{
	// Token: 0x02000099 RID: 153
	[NullableContext(2)]
	[Nullable(0)]
	[Annotation("kotlin.RequiresOptIn")]
	public class RequiresOptInAttribute : Attribute
	{
		// Token: 0x170000E5 RID: 229
		// (get) Token: 0x0600043D RID: 1085 RVA: 0x0000A23F File Offset: 0x0000843F
		// (set) Token: 0x0600043E RID: 1086 RVA: 0x0000A247 File Offset: 0x00008447
		[Register("message")]
		public string Message { get; set; }
	}
}
