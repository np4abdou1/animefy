using System;
using System.Xml.XPath;

namespace MS.Internal.Xml.XPath
{
	// Token: 0x0200034E RID: 846
	internal class Filter : AstNode
	{
		// Token: 0x06001D5F RID: 7519 RVA: 0x000AB950 File Offset: 0x000A9B50
		public Filter(AstNode input, AstNode condition)
		{
			this._input = input;
			this._condition = condition;
		}

		// Token: 0x170006A0 RID: 1696
		// (get) Token: 0x06001D60 RID: 7520 RVA: 0x000466F0 File Offset: 0x000448F0
		public override AstNode.AstType Type
		{
			get
			{
				return AstNode.AstType.Filter;
			}
		}

		// Token: 0x170006A1 RID: 1697
		// (get) Token: 0x06001D61 RID: 7521 RVA: 0x0004E85B File Offset: 0x0004CA5B
		public override XPathResultType ReturnType
		{
			get
			{
				return XPathResultType.NodeSet;
			}
		}

		// Token: 0x04001329 RID: 4905
		private AstNode _input;

		// Token: 0x0400132A RID: 4906
		private AstNode _condition;
	}
}
