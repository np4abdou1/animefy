using System;
using System.Runtime.CompilerServices;
using Android.Runtime;
using Java.Lang;

namespace JetBrains.Annotations
{
	// Token: 0x0200003D RID: 61
	[NullableContext(2)]
	[Nullable(0)]
	[Annotation("org.jetbrains.annotations.NotNull")]
	public class NotNullAttribute : Attribute
	{
		// Token: 0x1700005F RID: 95
		// (get) Token: 0x060001ED RID: 493 RVA: 0x0000645C File Offset: 0x0000465C
		// (set) Token: 0x060001EE RID: 494 RVA: 0x00006464 File Offset: 0x00004664
		[Register("exception")]
		public Class Exception { get; set; }

		// Token: 0x17000060 RID: 96
		// (get) Token: 0x060001EF RID: 495 RVA: 0x0000646D File Offset: 0x0000466D
		// (set) Token: 0x060001F0 RID: 496 RVA: 0x00006475 File Offset: 0x00004675
		[Register("value")]
		public string Value { get; set; }
	}
}
