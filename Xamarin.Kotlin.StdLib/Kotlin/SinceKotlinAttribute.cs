using System;
using System.Runtime.CompilerServices;
using Android.Runtime;

namespace Kotlin
{
	// Token: 0x0200009C RID: 156
	[NullableContext(2)]
	[Nullable(0)]
	[Annotation("kotlin.SinceKotlin")]
	public class SinceKotlinAttribute : Attribute
	{
		// Token: 0x170000EE RID: 238
		// (get) Token: 0x0600044C RID: 1100 RVA: 0x0000A35D File Offset: 0x0000855D
		// (set) Token: 0x0600044D RID: 1101 RVA: 0x0000A365 File Offset: 0x00008565
		[Register("version")]
		public string Version { get; set; }
	}
}
