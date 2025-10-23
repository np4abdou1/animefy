using System;
using System.Runtime.CompilerServices;
using Android.Runtime;

namespace Kotlin
{
	// Token: 0x0200004A RID: 74
	[NullableContext(2)]
	[Nullable(0)]
	[Annotation("kotlin.Deprecated")]
	public class DeprecatedAttribute : Attribute
	{
		// Token: 0x17000020 RID: 32
		// (get) Token: 0x06000132 RID: 306 RVA: 0x00002DEF File Offset: 0x00000FEF
		// (set) Token: 0x06000133 RID: 307 RVA: 0x00002DF7 File Offset: 0x00000FF7
		[Register("message")]
		public string Message { get; set; }
	}
}
