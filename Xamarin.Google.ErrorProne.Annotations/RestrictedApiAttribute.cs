using System;
using Android.Runtime;
using Java.Lang;

namespace Xamarin.Google.ErrorProne.Annotations
{
	// Token: 0x02000045 RID: 69
	[Annotation("com.google.errorprone.annotations.RestrictedApi")]
	public class RestrictedApiAttribute : Attribute
	{
		// Token: 0x17000071 RID: 113
		// (get) Token: 0x0600024E RID: 590 RVA: 0x00007403 File Offset: 0x00005603
		// (set) Token: 0x0600024F RID: 591 RVA: 0x0000740B File Offset: 0x0000560B
		[Register("allowedOnPath")]
		public string AllowedOnPath { get; set; }

		// Token: 0x17000072 RID: 114
		// (get) Token: 0x06000250 RID: 592 RVA: 0x00007414 File Offset: 0x00005614
		// (set) Token: 0x06000251 RID: 593 RVA: 0x0000741C File Offset: 0x0000561C
		[Register("allowlistAnnotations")]
		public Class[] AllowlistAnnotations { get; set; }

		// Token: 0x17000073 RID: 115
		// (get) Token: 0x06000252 RID: 594 RVA: 0x00007425 File Offset: 0x00005625
		// (set) Token: 0x06000253 RID: 595 RVA: 0x0000742D File Offset: 0x0000562D
		[Register("allowlistWithWarningAnnotations")]
		public Class[] AllowlistWithWarningAnnotations { get; set; }

		// Token: 0x17000074 RID: 116
		// (get) Token: 0x06000254 RID: 596 RVA: 0x00007436 File Offset: 0x00005636
		// (set) Token: 0x06000255 RID: 597 RVA: 0x0000743E File Offset: 0x0000563E
		[Register("explanation")]
		public string Explanation { get; set; }

		// Token: 0x17000075 RID: 117
		// (get) Token: 0x06000256 RID: 598 RVA: 0x00007447 File Offset: 0x00005647
		// (set) Token: 0x06000257 RID: 599 RVA: 0x0000744F File Offset: 0x0000564F
		[Register("link")]
		public string Link { get; set; }
	}
}
