using System;
using Android.Runtime;

namespace Xamarin.Google.Android.DataTransport.Runtime.Dagger.MultiBindings
{
	// Token: 0x020000CE RID: 206
	[Annotation("com.google.android.datatransport.runtime.dagger.multibindings.IntKey")]
	public class IntKeyAttribute : Attribute
	{
		// Token: 0x1700023E RID: 574
		// (get) Token: 0x06000780 RID: 1920 RVA: 0x000153A0 File Offset: 0x000135A0
		// (set) Token: 0x06000781 RID: 1921 RVA: 0x000153A8 File Offset: 0x000135A8
		[Register("value")]
		public int Value { get; set; }
	}
}
