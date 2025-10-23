using System;
using Android.Runtime;
using Java.Lang;

namespace Xamarin.Google.Android.DataTransport.Runtime.Dagger.MultiBindings
{
	// Token: 0x020000BE RID: 190
	[Annotation("com.google.android.datatransport.runtime.dagger.multibindings.ClassKey")]
	public class ClassKeyAttribute : Attribute
	{
		// Token: 0x17000221 RID: 545
		// (get) Token: 0x060006DD RID: 1757 RVA: 0x00013B74 File Offset: 0x00011D74
		// (set) Token: 0x060006DE RID: 1758 RVA: 0x00013B7C File Offset: 0x00011D7C
		[Register("value")]
		public Class Value { get; set; }
	}
}
