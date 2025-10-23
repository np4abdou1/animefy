using System;
using System.Runtime.CompilerServices;
using Android.Runtime;

namespace Kotlin.Jvm
{
	// Token: 0x02000186 RID: 390
	[NullableContext(2)]
	[Nullable(0)]
	[Annotation("kotlin.jvm.PurelyImplements")]
	public class PurelyImplementsAttribute : Attribute
	{
		// Token: 0x17000551 RID: 1361
		// (get) Token: 0x0600135C RID: 4956 RVA: 0x0003EF63 File Offset: 0x0003D163
		// (set) Token: 0x0600135D RID: 4957 RVA: 0x0003EF6B File Offset: 0x0003D16B
		[Register("value")]
		public string Value { get; set; }
	}
}
