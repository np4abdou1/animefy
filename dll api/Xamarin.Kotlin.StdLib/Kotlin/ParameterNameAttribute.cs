using System;
using System.Runtime.CompilerServices;
using Android.Runtime;

namespace Kotlin
{
	// Token: 0x02000094 RID: 148
	[NullableContext(2)]
	[Nullable(0)]
	[Annotation("kotlin.ParameterName")]
	public class ParameterNameAttribute : Attribute
	{
		// Token: 0x170000DA RID: 218
		// (get) Token: 0x06000428 RID: 1064 RVA: 0x0000A0EF File Offset: 0x000082EF
		// (set) Token: 0x06000429 RID: 1065 RVA: 0x0000A0F7 File Offset: 0x000082F7
		[Register("name")]
		public string Name { get; set; }
	}
}
