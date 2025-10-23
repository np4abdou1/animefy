using System;
using Android.Runtime;
using Java.Lang;

namespace Xamarin.Google.Android.DataTransport.Runtime.Dagger
{
	// Token: 0x0200009A RID: 154
	[Annotation("com.google.android.datatransport.runtime.dagger.Component")]
	public class ComponentAttribute : Attribute
	{
		// Token: 0x170001DF RID: 479
		// (get) Token: 0x06000588 RID: 1416 RVA: 0x00010A63 File Offset: 0x0000EC63
		// (set) Token: 0x06000589 RID: 1417 RVA: 0x00010A6B File Offset: 0x0000EC6B
		[Register("dependencies")]
		public Class[] Dependencies { get; set; }

		// Token: 0x170001E0 RID: 480
		// (get) Token: 0x0600058A RID: 1418 RVA: 0x00010A74 File Offset: 0x0000EC74
		// (set) Token: 0x0600058B RID: 1419 RVA: 0x00010A7C File Offset: 0x0000EC7C
		[Register("modules")]
		public Class[] Modules { get; set; }
	}
}
