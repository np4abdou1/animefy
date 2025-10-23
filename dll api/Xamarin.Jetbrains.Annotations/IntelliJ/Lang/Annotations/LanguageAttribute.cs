using System;
using System.Runtime.CompilerServices;
using Android.Runtime;

namespace IntelliJ.Lang.Annotations
{
	// Token: 0x0200005C RID: 92
	[NullableContext(2)]
	[Nullable(0)]
	[Annotation("org.intellij.lang.annotations.Language")]
	public class LanguageAttribute : Attribute
	{
		// Token: 0x1700008E RID: 142
		// (get) Token: 0x06000303 RID: 771 RVA: 0x00008989 File Offset: 0x00006B89
		// (set) Token: 0x06000304 RID: 772 RVA: 0x00008991 File Offset: 0x00006B91
		[Register("prefix")]
		public string Prefix { get; set; }

		// Token: 0x1700008F RID: 143
		// (get) Token: 0x06000305 RID: 773 RVA: 0x0000899A File Offset: 0x00006B9A
		// (set) Token: 0x06000306 RID: 774 RVA: 0x000089A2 File Offset: 0x00006BA2
		[Register("suffix")]
		public string Suffix { get; set; }

		// Token: 0x17000090 RID: 144
		// (get) Token: 0x06000307 RID: 775 RVA: 0x000089AB File Offset: 0x00006BAB
		// (set) Token: 0x06000308 RID: 776 RVA: 0x000089B3 File Offset: 0x00006BB3
		[Register("value")]
		public string Value { get; set; }
	}
}
