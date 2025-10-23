using System;
using Android.Runtime;

namespace Xamarin.Google.Android.DataTransport.Runtime.Dagger.MultiBindings
{
	// Token: 0x020000D3 RID: 211
	[Annotation("com.google.android.datatransport.runtime.dagger.multibindings.LongKey")]
	public class LongKeyAttribute : Attribute
	{
		// Token: 0x17000243 RID: 579
		// (get) Token: 0x0600079E RID: 1950 RVA: 0x0001577C File Offset: 0x0001397C
		// (set) Token: 0x0600079F RID: 1951 RVA: 0x00015784 File Offset: 0x00013984
		[Register("value")]
		public long Value { get; set; }
	}
}
