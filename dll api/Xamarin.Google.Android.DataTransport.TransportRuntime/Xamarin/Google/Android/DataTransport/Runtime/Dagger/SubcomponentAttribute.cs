using System;
using Android.Runtime;
using Java.Lang;

namespace Xamarin.Google.Android.DataTransport.Runtime.Dagger
{
	// Token: 0x020000BD RID: 189
	[Annotation("com.google.android.datatransport.runtime.dagger.Subcomponent")]
	public class SubcomponentAttribute : Attribute
	{
		// Token: 0x17000220 RID: 544
		// (get) Token: 0x060006DA RID: 1754 RVA: 0x00013B63 File Offset: 0x00011D63
		// (set) Token: 0x060006DB RID: 1755 RVA: 0x00013B6B File Offset: 0x00011D6B
		[Register("modules")]
		public Class[] Modules { get; set; }
	}
}
