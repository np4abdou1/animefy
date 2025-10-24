using System;
using Android.Runtime;

namespace Xamarin.Google.ErrorProne.Annotations
{
	// Token: 0x0200000B RID: 11
	[Annotation("com.google.errorprone.annotations.DoNotMock")]
	public class DoNotMockAttribute : Attribute
	{
		// Token: 0x17000003 RID: 3
		// (get) Token: 0x06000017 RID: 23 RVA: 0x0000207A File Offset: 0x0000027A
		// (set) Token: 0x06000018 RID: 24 RVA: 0x00002082 File Offset: 0x00000282
		[Register("value")]
		public string Value { get; set; }
	}
}
