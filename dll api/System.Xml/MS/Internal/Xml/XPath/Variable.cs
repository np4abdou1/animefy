using System;
using System.Xml.XPath;

namespace MS.Internal.Xml.XPath
{
	// Token: 0x02000356 RID: 854
	internal class Variable : AstNode
	{
		// Token: 0x06001D76 RID: 7542 RVA: 0x000ABA98 File Offset: 0x000A9C98
		public Variable(string name, string prefix)
		{
			this._localname = name;
			this._prefix = prefix;
		}

		// Token: 0x170006AC RID: 1708
		// (get) Token: 0x06001D77 RID: 7543 RVA: 0x0004E739 File Offset: 0x0004C939
		public override AstNode.AstType Type
		{
			get
			{
				return AstNode.AstType.Variable;
			}
		}

		// Token: 0x170006AD RID: 1709
		// (get) Token: 0x06001D78 RID: 7544 RVA: 0x0004950A File Offset: 0x0004770A
		public override XPathResultType ReturnType
		{
			get
			{
				return XPathResultType.Any;
			}
		}

		// Token: 0x04001364 RID: 4964
		private string _localname;

		// Token: 0x04001365 RID: 4965
		private string _prefix;
	}
}
