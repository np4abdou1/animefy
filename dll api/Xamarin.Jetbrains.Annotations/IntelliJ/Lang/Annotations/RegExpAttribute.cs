using System;
using System.Runtime.CompilerServices;
using Android.Runtime;

namespace IntelliJ.Lang.Annotations
{
	// Token: 0x02000060 RID: 96
	[NullableContext(2)]
	[Nullable(0)]
	[Annotation("org.intellij.lang.annotations.RegExp")]
	public class RegExpAttribute : Attribute
	{
		// Token: 0x17000097 RID: 151
		// (get) Token: 0x06000319 RID: 793 RVA: 0x00008A42 File Offset: 0x00006C42
		// (set) Token: 0x0600031A RID: 794 RVA: 0x00008A4A File Offset: 0x00006C4A
		[Register("prefix")]
		public string Prefix { get; set; }

		// Token: 0x17000098 RID: 152
		// (get) Token: 0x0600031B RID: 795 RVA: 0x00008A53 File Offset: 0x00006C53
		// (set) Token: 0x0600031C RID: 796 RVA: 0x00008A5B File Offset: 0x00006C5B
		[Register("suffix")]
		public string Suffix { get; set; }
	}
}
