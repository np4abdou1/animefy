using System;

namespace System.Linq.Expressions.Compiler
{
	// Token: 0x020000E5 RID: 229
	internal enum LabelScopeKind
	{
		// Token: 0x04000225 RID: 549
		Statement,
		// Token: 0x04000226 RID: 550
		Block,
		// Token: 0x04000227 RID: 551
		Switch,
		// Token: 0x04000228 RID: 552
		Lambda,
		// Token: 0x04000229 RID: 553
		Try,
		// Token: 0x0400022A RID: 554
		Catch,
		// Token: 0x0400022B RID: 555
		Finally,
		// Token: 0x0400022C RID: 556
		Filter,
		// Token: 0x0400022D RID: 557
		Expression
	}
}
