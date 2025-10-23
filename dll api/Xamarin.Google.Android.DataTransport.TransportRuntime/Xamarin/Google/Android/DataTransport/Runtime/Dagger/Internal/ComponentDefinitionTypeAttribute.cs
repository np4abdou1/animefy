using System;
using Android.Runtime;
using Java.Lang;

namespace Xamarin.Google.Android.DataTransport.Runtime.Dagger.Internal
{
	// Token: 0x020000DA RID: 218
	[Annotation("com.google.android.datatransport.runtime.dagger.internal.ComponentDefinitionType")]
	public class ComponentDefinitionTypeAttribute : Attribute
	{
		// Token: 0x17000251 RID: 593
		// (get) Token: 0x060007C0 RID: 1984 RVA: 0x00015B9D File Offset: 0x00013D9D
		// (set) Token: 0x060007C1 RID: 1985 RVA: 0x00015BA5 File Offset: 0x00013DA5
		[Register("value")]
		public Class Value { get; set; }
	}
}
