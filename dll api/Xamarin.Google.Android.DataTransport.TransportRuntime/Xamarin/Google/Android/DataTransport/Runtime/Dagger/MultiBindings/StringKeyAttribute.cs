using System;
using Android.Runtime;

namespace Xamarin.Google.Android.DataTransport.Runtime.Dagger.MultiBindings
{
	// Token: 0x020000D5 RID: 213
	[Annotation("com.google.android.datatransport.runtime.dagger.multibindings.StringKey")]
	public class StringKeyAttribute : Attribute
	{
		// Token: 0x17000244 RID: 580
		// (get) Token: 0x060007A2 RID: 1954 RVA: 0x0001578D File Offset: 0x0001398D
		// (set) Token: 0x060007A3 RID: 1955 RVA: 0x00015795 File Offset: 0x00013995
		[Register("value")]
		public string Value { get; set; }
	}
}
