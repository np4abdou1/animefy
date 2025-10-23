using System;
using Android.Runtime;

namespace Xamarin.Google.ErrorProne.Annotations
{
	// Token: 0x0200000A RID: 10
	[Annotation("com.google.errorprone.annotations.DoNotCall")]
	public class DoNotCallAttribute : Attribute
	{
		// Token: 0x17000002 RID: 2
		// (get) Token: 0x06000014 RID: 20 RVA: 0x00002069 File Offset: 0x00000269
		// (set) Token: 0x06000015 RID: 21 RVA: 0x00002071 File Offset: 0x00000271
		[Register("value")]
		public string Value { get; set; }
	}
}
