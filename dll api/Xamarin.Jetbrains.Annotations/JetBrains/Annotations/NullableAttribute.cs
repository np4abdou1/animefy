using System;
using System.Runtime.CompilerServices;
using Android.Runtime;

namespace JetBrains.Annotations
{
	// Token: 0x0200003E RID: 62
	[NullableContext(2)]
	[Nullable(0)]
	[Annotation("org.jetbrains.annotations.Nullable")]
	public class NullableAttribute : Attribute
	{
		// Token: 0x17000061 RID: 97
		// (get) Token: 0x060001F2 RID: 498 RVA: 0x00006486 File Offset: 0x00004686
		// (set) Token: 0x060001F3 RID: 499 RVA: 0x0000648E File Offset: 0x0000468E
		[Register("value")]
		public string Value { get; set; }
	}
}
