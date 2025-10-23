using System;
using System.Runtime.CompilerServices;
using Android.Runtime;

namespace JetBrains.Annotations
{
	// Token: 0x02000011 RID: 17
	[NullableContext(2)]
	[Nullable(0)]
	[Annotation("org.jetbrains.annotations.Contract")]
	public class ContractAttribute : Attribute
	{
		// Token: 0x17000009 RID: 9
		// (get) Token: 0x0600002A RID: 42 RVA: 0x000021C5 File Offset: 0x000003C5
		// (set) Token: 0x0600002B RID: 43 RVA: 0x000021CD File Offset: 0x000003CD
		[Register("mutates")]
		public string Mutates { get; set; }

		// Token: 0x1700000A RID: 10
		// (get) Token: 0x0600002C RID: 44 RVA: 0x000021D6 File Offset: 0x000003D6
		// (set) Token: 0x0600002D RID: 45 RVA: 0x000021DE File Offset: 0x000003DE
		[Register("pure")]
		public bool Pure { get; set; }

		// Token: 0x1700000B RID: 11
		// (get) Token: 0x0600002E RID: 46 RVA: 0x000021E7 File Offset: 0x000003E7
		// (set) Token: 0x0600002F RID: 47 RVA: 0x000021EF File Offset: 0x000003EF
		[Register("value")]
		public string Value { get; set; }
	}
}
