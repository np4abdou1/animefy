using System;
using System.Xml.XPath;

namespace MS.Internal.Xml.XPath
{
	// Token: 0x0200034A RID: 842
	internal abstract class AstNode
	{
		// Token: 0x17000695 RID: 1685
		// (get) Token: 0x06001D4F RID: 7503
		public abstract AstNode.AstType Type { get; }

		// Token: 0x17000696 RID: 1686
		// (get) Token: 0x06001D50 RID: 7504
		public abstract XPathResultType ReturnType { get; }

		// Token: 0x0200034B RID: 843
		public enum AstType
		{
			// Token: 0x0400130A RID: 4874
			Axis,
			// Token: 0x0400130B RID: 4875
			Operator,
			// Token: 0x0400130C RID: 4876
			Filter,
			// Token: 0x0400130D RID: 4877
			ConstantOperand,
			// Token: 0x0400130E RID: 4878
			Function,
			// Token: 0x0400130F RID: 4879
			Group,
			// Token: 0x04001310 RID: 4880
			Root,
			// Token: 0x04001311 RID: 4881
			Variable,
			// Token: 0x04001312 RID: 4882
			Error
		}
	}
}
