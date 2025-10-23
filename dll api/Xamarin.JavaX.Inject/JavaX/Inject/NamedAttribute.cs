using System;
using Android.Runtime;

namespace JavaX.Inject
{
	// Token: 0x02000013 RID: 19
	[Annotation("javax.inject.Named")]
	public class NamedAttribute : Attribute
	{
		// Token: 0x17000019 RID: 25
		// (get) Token: 0x06000089 RID: 137 RVA: 0x00003290 File Offset: 0x00001490
		// (set) Token: 0x0600008A RID: 138 RVA: 0x00003298 File Offset: 0x00001498
		[Register("value")]
		public string Value { get; set; }
	}
}
