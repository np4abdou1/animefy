using System;
using System.Xml.XPath;

namespace MS.Internal.Xml.XPath
{
	// Token: 0x02000352 RID: 850
	internal class Operand : AstNode
	{
		// Token: 0x06001D6B RID: 7531 RVA: 0x000ABA07 File Offset: 0x000A9C07
		public Operand(string val)
		{
			this._type = XPathResultType.String;
			this._val = val;
		}

		// Token: 0x06001D6C RID: 7532 RVA: 0x000ABA1D File Offset: 0x000A9C1D
		public Operand(double val)
		{
			this._type = XPathResultType.Number;
			this._val = val;
		}

		// Token: 0x170006A6 RID: 1702
		// (get) Token: 0x06001D6D RID: 7533 RVA: 0x0004E85B File Offset: 0x0004CA5B
		public override AstNode.AstType Type
		{
			get
			{
				return AstNode.AstType.ConstantOperand;
			}
		}

		// Token: 0x170006A7 RID: 1703
		// (get) Token: 0x06001D6E RID: 7534 RVA: 0x000ABA38 File Offset: 0x000A9C38
		public override XPathResultType ReturnType
		{
			get
			{
				return this._type;
			}
		}

		// Token: 0x0400134E RID: 4942
		private XPathResultType _type;

		// Token: 0x0400134F RID: 4943
		private object _val;
	}
}
