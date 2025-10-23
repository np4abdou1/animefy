using System;
using Android.Runtime;

namespace Xamarin.Google.ErrorProne.Annotations.Concurrent
{
	// Token: 0x02000049 RID: 73
	[Annotation("com.google.errorprone.annotations.concurrent.GuardedBy")]
	public class GuardedByAttribute : Attribute
	{
		// Token: 0x17000076 RID: 118
		// (get) Token: 0x0600025C RID: 604 RVA: 0x00007458 File Offset: 0x00005658
		// (set) Token: 0x0600025D RID: 605 RVA: 0x00007460 File Offset: 0x00005660
		[Register("value")]
		public string Value { get; set; }
	}
}
