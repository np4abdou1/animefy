using System;
using System.Runtime.CompilerServices;
using Android.Runtime;

namespace Kotlin
{
	// Token: 0x0200004B RID: 75
	[NullableContext(2)]
	[Nullable(0)]
	[Annotation("kotlin.DeprecatedSinceKotlin")]
	public class DeprecatedSinceKotlinAttribute : Attribute
	{
		// Token: 0x17000021 RID: 33
		// (get) Token: 0x06000135 RID: 309 RVA: 0x00002E08 File Offset: 0x00001008
		// (set) Token: 0x06000136 RID: 310 RVA: 0x00002E10 File Offset: 0x00001010
		[Register("errorSince")]
		public string ErrorSince { get; set; }

		// Token: 0x17000022 RID: 34
		// (get) Token: 0x06000137 RID: 311 RVA: 0x00002E19 File Offset: 0x00001019
		// (set) Token: 0x06000138 RID: 312 RVA: 0x00002E21 File Offset: 0x00001021
		[Register("hiddenSince")]
		public string HiddenSince { get; set; }

		// Token: 0x17000023 RID: 35
		// (get) Token: 0x06000139 RID: 313 RVA: 0x00002E2A File Offset: 0x0000102A
		// (set) Token: 0x0600013A RID: 314 RVA: 0x00002E32 File Offset: 0x00001032
		[Register("warningSince")]
		public string WarningSince { get; set; }
	}
}
