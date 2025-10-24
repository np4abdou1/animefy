using System;
using System.Runtime.CompilerServices;
using Android.Runtime;

namespace IntelliJ.Lang.Annotations
{
	// Token: 0x02000061 RID: 97
	[NullableContext(2)]
	[Nullable(0)]
	[Annotation("org.intellij.lang.annotations.Subst")]
	public class SubstAttribute : Attribute
	{
		// Token: 0x17000099 RID: 153
		// (get) Token: 0x0600031E RID: 798 RVA: 0x00008A6C File Offset: 0x00006C6C
		// (set) Token: 0x0600031F RID: 799 RVA: 0x00008A74 File Offset: 0x00006C74
		[Register("value")]
		public string Value { get; set; }
	}
}
