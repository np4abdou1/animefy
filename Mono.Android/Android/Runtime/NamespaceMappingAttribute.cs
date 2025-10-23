using System;

namespace Android.Runtime
{
	// Token: 0x020002EE RID: 750
	[AttributeUsage(AttributeTargets.Assembly | AttributeTargets.Module, AllowMultiple = true)]
	public class NamespaceMappingAttribute : Attribute
	{
		// Token: 0x17000609 RID: 1545
		// (get) Token: 0x06001DC3 RID: 7619 RVA: 0x00051ADC File Offset: 0x0004FCDC
		// (set) Token: 0x06001DC4 RID: 7620 RVA: 0x00051AE4 File Offset: 0x0004FCE4
		public string Java { get; set; }

		// Token: 0x1700060A RID: 1546
		// (get) Token: 0x06001DC5 RID: 7621 RVA: 0x00051AED File Offset: 0x0004FCED
		// (set) Token: 0x06001DC6 RID: 7622 RVA: 0x00051AF5 File Offset: 0x0004FCF5
		public string Managed { get; set; }
	}
}
