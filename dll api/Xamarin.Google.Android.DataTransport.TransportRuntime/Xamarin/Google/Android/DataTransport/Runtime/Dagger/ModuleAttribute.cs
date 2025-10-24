using System;
using Android.Runtime;
using Java.Lang;

namespace Xamarin.Google.Android.DataTransport.Runtime.Dagger
{
	// Token: 0x020000BA RID: 186
	[Annotation("com.google.android.datatransport.runtime.dagger.Module")]
	public class ModuleAttribute : Attribute
	{
		// Token: 0x1700021E RID: 542
		// (get) Token: 0x060006D3 RID: 1747 RVA: 0x00013B41 File Offset: 0x00011D41
		// (set) Token: 0x060006D4 RID: 1748 RVA: 0x00013B49 File Offset: 0x00011D49
		[Register("includes")]
		public Class[] Includes { get; set; }

		// Token: 0x1700021F RID: 543
		// (get) Token: 0x060006D5 RID: 1749 RVA: 0x00013B52 File Offset: 0x00011D52
		// (set) Token: 0x060006D6 RID: 1750 RVA: 0x00013B5A File Offset: 0x00011D5A
		[Register("subcomponents")]
		public Class[] Subcomponents { get; set; }
	}
}
