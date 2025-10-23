using System;
using Android.Runtime;

namespace JetBrains.Annotations
{
	// Token: 0x02000040 RID: 64
	[Annotation("org.jetbrains.annotations.Range")]
	public class RangeAttribute : Attribute
	{
		// Token: 0x17000063 RID: 99
		// (get) Token: 0x060001F8 RID: 504 RVA: 0x000064B8 File Offset: 0x000046B8
		// (set) Token: 0x060001F9 RID: 505 RVA: 0x000064C0 File Offset: 0x000046C0
		[Register("from")]
		public long From { get; set; }

		// Token: 0x17000064 RID: 100
		// (get) Token: 0x060001FA RID: 506 RVA: 0x000064C9 File Offset: 0x000046C9
		// (set) Token: 0x060001FB RID: 507 RVA: 0x000064D1 File Offset: 0x000046D1
		[Register("to")]
		public long To { get; set; }
	}
}
