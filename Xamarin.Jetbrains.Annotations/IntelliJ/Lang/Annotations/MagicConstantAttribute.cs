using System;
using System.Runtime.CompilerServices;
using Android.Runtime;
using Java.Lang;

namespace IntelliJ.Lang.Annotations
{
	// Token: 0x0200005D RID: 93
	[NullableContext(2)]
	[Nullable(0)]
	[Annotation("org.intellij.lang.annotations.MagicConstant")]
	public class MagicConstantAttribute : Attribute
	{
		// Token: 0x17000091 RID: 145
		// (get) Token: 0x0600030A RID: 778 RVA: 0x000089C4 File Offset: 0x00006BC4
		// (set) Token: 0x0600030B RID: 779 RVA: 0x000089CC File Offset: 0x00006BCC
		[Register("flags")]
		public long[] Flags { get; set; }

		// Token: 0x17000092 RID: 146
		// (get) Token: 0x0600030C RID: 780 RVA: 0x000089D5 File Offset: 0x00006BD5
		// (set) Token: 0x0600030D RID: 781 RVA: 0x000089DD File Offset: 0x00006BDD
		[Register("flagsFromClass")]
		public Class FlagsFromClass { get; set; }

		// Token: 0x17000093 RID: 147
		// (get) Token: 0x0600030E RID: 782 RVA: 0x000089E6 File Offset: 0x00006BE6
		// (set) Token: 0x0600030F RID: 783 RVA: 0x000089EE File Offset: 0x00006BEE
		[Register("intValues")]
		public long[] IntValues { get; set; }

		// Token: 0x17000094 RID: 148
		// (get) Token: 0x06000310 RID: 784 RVA: 0x000089F7 File Offset: 0x00006BF7
		// (set) Token: 0x06000311 RID: 785 RVA: 0x000089FF File Offset: 0x00006BFF
		[Nullable(new byte[]
		{
			2,
			1
		})]
		[Register("stringValues")]
		public string[] StringValues { [return: Nullable(new byte[]
		{
			2,
			1
		})] get; [param: Nullable(new byte[]
		{
			2,
			1
		})] set; }

		// Token: 0x17000095 RID: 149
		// (get) Token: 0x06000312 RID: 786 RVA: 0x00008A08 File Offset: 0x00006C08
		// (set) Token: 0x06000313 RID: 787 RVA: 0x00008A10 File Offset: 0x00006C10
		[Register("valuesFromClass")]
		public Class ValuesFromClass { get; set; }
	}
}
