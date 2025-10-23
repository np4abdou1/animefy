using System;
using Android.Runtime;

namespace Xamarin.Google.ErrorProne.Annotations
{
	// Token: 0x02000008 RID: 8
	[Annotation("com.google.errorprone.annotations.CompatibleWith")]
	public class CompatibleWithAttribute : Attribute
	{
		// Token: 0x17000001 RID: 1
		// (get) Token: 0x06000010 RID: 16 RVA: 0x00002058 File Offset: 0x00000258
		// (set) Token: 0x06000011 RID: 17 RVA: 0x00002060 File Offset: 0x00000260
		[Register("value")]
		public string Value { get; set; }
	}
}
