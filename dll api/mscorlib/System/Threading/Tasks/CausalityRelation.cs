using System;

namespace System.Threading.Tasks
{
	// Token: 0x0200023B RID: 571
	internal enum CausalityRelation
	{
		// Token: 0x040007F1 RID: 2033
		AssignDelegate,
		// Token: 0x040007F2 RID: 2034
		Join,
		// Token: 0x040007F3 RID: 2035
		Choice,
		// Token: 0x040007F4 RID: 2036
		Cancel,
		// Token: 0x040007F5 RID: 2037
		Error
	}
}
