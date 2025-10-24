using System;
using System.Runtime.CompilerServices;
using Android.Runtime;

namespace IntelliJ.Lang.Annotations
{
	// Token: 0x02000047 RID: 71
	[NullableContext(2)]
	[Nullable(0)]
	[Annotation("org.intellij.lang.annotations.Flow")]
	public class FlowAttribute : Attribute
	{
		// Token: 0x17000066 RID: 102
		// (get) Token: 0x06000209 RID: 521 RVA: 0x00006616 File Offset: 0x00004816
		// (set) Token: 0x0600020A RID: 522 RVA: 0x0000661E File Offset: 0x0000481E
		[Register("source")]
		public string Source { get; set; }

		// Token: 0x17000067 RID: 103
		// (get) Token: 0x0600020B RID: 523 RVA: 0x00006627 File Offset: 0x00004827
		// (set) Token: 0x0600020C RID: 524 RVA: 0x0000662F File Offset: 0x0000482F
		[Register("sourceIsContainer")]
		public bool SourceIsContainer { get; set; }

		// Token: 0x17000068 RID: 104
		// (get) Token: 0x0600020D RID: 525 RVA: 0x00006638 File Offset: 0x00004838
		// (set) Token: 0x0600020E RID: 526 RVA: 0x00006640 File Offset: 0x00004840
		[Register("target")]
		public string Target { get; set; }

		// Token: 0x17000069 RID: 105
		// (get) Token: 0x0600020F RID: 527 RVA: 0x00006649 File Offset: 0x00004849
		// (set) Token: 0x06000210 RID: 528 RVA: 0x00006651 File Offset: 0x00004851
		[Register("targetIsContainer")]
		public bool TargetIsContainer { get; set; }
	}
}
