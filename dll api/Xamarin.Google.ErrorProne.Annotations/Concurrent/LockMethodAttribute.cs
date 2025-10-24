using System;
using Android.Runtime;

namespace Xamarin.Google.ErrorProne.Annotations.Concurrent
{
	// Token: 0x02000053 RID: 83
	[Annotation("com.google.errorprone.annotations.concurrent.LockMethod")]
	public class LockMethodAttribute : Attribute
	{
		// Token: 0x17000087 RID: 135
		// (get) Token: 0x060002C0 RID: 704 RVA: 0x00008318 File Offset: 0x00006518
		// (set) Token: 0x060002C1 RID: 705 RVA: 0x00008320 File Offset: 0x00006520
		[Register("value")]
		public string[] Value { get; set; }
	}
}
