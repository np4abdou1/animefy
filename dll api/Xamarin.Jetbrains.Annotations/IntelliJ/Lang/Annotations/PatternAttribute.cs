using System;
using System.Runtime.CompilerServices;
using Android.Runtime;

namespace IntelliJ.Lang.Annotations
{
	// Token: 0x0200005E RID: 94
	[NullableContext(2)]
	[Nullable(0)]
	[Annotation("org.intellij.lang.annotations.Pattern")]
	public class PatternAttribute : Attribute
	{
		// Token: 0x17000096 RID: 150
		// (get) Token: 0x06000315 RID: 789 RVA: 0x00008A21 File Offset: 0x00006C21
		// (set) Token: 0x06000316 RID: 790 RVA: 0x00008A29 File Offset: 0x00006C29
		[Register("value")]
		public string Value { get; set; }
	}
}
