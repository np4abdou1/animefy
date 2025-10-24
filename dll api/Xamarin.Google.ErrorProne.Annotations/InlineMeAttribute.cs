using System;
using Android.Runtime;

namespace Xamarin.Google.ErrorProne.Annotations
{
	// Token: 0x0200002F RID: 47
	[Annotation("com.google.errorprone.annotations.InlineMe")]
	public class InlineMeAttribute : Attribute
	{
		// Token: 0x17000041 RID: 65
		// (get) Token: 0x06000180 RID: 384 RVA: 0x00005640 File Offset: 0x00003840
		// (set) Token: 0x06000181 RID: 385 RVA: 0x00005648 File Offset: 0x00003848
		[Register("imports")]
		public string[] Imports { get; set; }

		// Token: 0x17000042 RID: 66
		// (get) Token: 0x06000182 RID: 386 RVA: 0x00005651 File Offset: 0x00003851
		// (set) Token: 0x06000183 RID: 387 RVA: 0x00005659 File Offset: 0x00003859
		[Register("replacement")]
		public string Replacement { get; set; }

		// Token: 0x17000043 RID: 67
		// (get) Token: 0x06000184 RID: 388 RVA: 0x00005662 File Offset: 0x00003862
		// (set) Token: 0x06000185 RID: 389 RVA: 0x0000566A File Offset: 0x0000386A
		[Register("staticImports")]
		public string[] StaticImports { get; set; }
	}
}
