using System;
using Android.Runtime;

namespace Xamarin.Google.ErrorProne.Annotations.Concurrent
{
	// Token: 0x02000054 RID: 84
	[Annotation("com.google.errorprone.annotations.concurrent.UnlockMethod")]
	public class UnlockMethodAttribute : Attribute
	{
		// Token: 0x17000088 RID: 136
		// (get) Token: 0x060002C3 RID: 707 RVA: 0x00008329 File Offset: 0x00006529
		// (set) Token: 0x060002C4 RID: 708 RVA: 0x00008331 File Offset: 0x00006531
		[Register("value")]
		public string[] Value { get; set; }
	}
}
