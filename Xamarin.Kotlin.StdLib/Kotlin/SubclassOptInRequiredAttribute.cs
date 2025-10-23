using System;
using System.Runtime.CompilerServices;
using Android.Runtime;
using Java.Lang;

namespace Kotlin
{
	// Token: 0x0200009E RID: 158
	[NullableContext(2)]
	[Nullable(0)]
	[Annotation("kotlin.SubclassOptInRequired")]
	public class SubclassOptInRequiredAttribute : Attribute
	{
		// Token: 0x170000F3 RID: 243
		// (get) Token: 0x06000455 RID: 1109 RVA: 0x0000A3F9 File Offset: 0x000085F9
		// (set) Token: 0x06000456 RID: 1110 RVA: 0x0000A401 File Offset: 0x00008601
		[Register("markerClass")]
		public Class MarkerClass { get; set; }
	}
}
