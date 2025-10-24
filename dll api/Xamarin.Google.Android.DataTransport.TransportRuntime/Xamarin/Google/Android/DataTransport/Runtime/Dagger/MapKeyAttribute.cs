using System;
using Android.Runtime;

namespace Xamarin.Google.Android.DataTransport.Runtime.Dagger
{
	// Token: 0x020000B9 RID: 185
	[Annotation("com.google.android.datatransport.runtime.dagger.MapKey")]
	public class MapKeyAttribute : Attribute
	{
		// Token: 0x1700021D RID: 541
		// (get) Token: 0x060006D0 RID: 1744 RVA: 0x00013B30 File Offset: 0x00011D30
		// (set) Token: 0x060006D1 RID: 1745 RVA: 0x00013B38 File Offset: 0x00011D38
		[Register("unwrapValue")]
		public bool UnwrapValue { get; set; }
	}
}
