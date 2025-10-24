using System;
using Android.Runtime;

namespace Xamarin.Google.ErrorProne.Annotations
{
	// Token: 0x0200002B RID: 43
	[Annotation("com.google.errorprone.annotations.Immutable")]
	public class ImmutableAttribute : Attribute
	{
		// Token: 0x1700003C RID: 60
		// (get) Token: 0x06000167 RID: 359 RVA: 0x000052F0 File Offset: 0x000034F0
		// (set) Token: 0x06000168 RID: 360 RVA: 0x000052F8 File Offset: 0x000034F8
		[Register("containerOf")]
		public string[] ContainerOf { get; set; }
	}
}
