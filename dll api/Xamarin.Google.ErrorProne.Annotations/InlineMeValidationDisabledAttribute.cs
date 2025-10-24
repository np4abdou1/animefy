using System;
using Android.Runtime;

namespace Xamarin.Google.ErrorProne.Annotations
{
	// Token: 0x02000030 RID: 48
	[Annotation("com.google.errorprone.annotations.InlineMeValidationDisabled")]
	public class InlineMeValidationDisabledAttribute : Attribute
	{
		// Token: 0x17000044 RID: 68
		// (get) Token: 0x06000187 RID: 391 RVA: 0x00005673 File Offset: 0x00003873
		// (set) Token: 0x06000188 RID: 392 RVA: 0x0000567B File Offset: 0x0000387B
		[Register("value")]
		public string Value { get; set; }
	}
}
