using System;
using System.Runtime.CompilerServices;
using Android.Runtime;

namespace JetBrains.Annotations
{
	// Token: 0x02000042 RID: 66
	[NullableContext(2)]
	[Nullable(0)]
	[Annotation("org.jetbrains.annotations.UnknownNullability")]
	public class UnknownNullabilityAttribute : Attribute
	{
		// Token: 0x17000065 RID: 101
		// (get) Token: 0x060001FE RID: 510 RVA: 0x000064EA File Offset: 0x000046EA
		// (set) Token: 0x060001FF RID: 511 RVA: 0x000064F2 File Offset: 0x000046F2
		[Register("value")]
		public string Value { get; set; }
	}
}
