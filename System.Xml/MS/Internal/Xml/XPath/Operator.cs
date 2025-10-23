using System;
using System.Xml.XPath;

namespace MS.Internal.Xml.XPath
{
	// Token: 0x02000353 RID: 851
	internal class Operator : AstNode
	{
		// Token: 0x06001D6F RID: 7535 RVA: 0x000ABA40 File Offset: 0x000A9C40
		public Operator(Operator.Op op, AstNode opnd1, AstNode opnd2)
		{
			this._opType = op;
			this._opnd1 = opnd1;
			this._opnd2 = opnd2;
		}

		// Token: 0x170006A8 RID: 1704
		// (get) Token: 0x06001D70 RID: 7536 RVA: 0x0000C89B File Offset: 0x0000AA9B
		public override AstNode.AstType Type
		{
			get
			{
				return AstNode.AstType.Operator;
			}
		}

		// Token: 0x170006A9 RID: 1705
		// (get) Token: 0x06001D71 RID: 7537 RVA: 0x000ABA5D File Offset: 0x000A9C5D
		public override XPathResultType ReturnType
		{
			get
			{
				if (this._opType <= Operator.Op.GE)
				{
					return XPathResultType.Boolean;
				}
				if (this._opType <= Operator.Op.MOD)
				{
					return XPathResultType.Number;
				}
				return XPathResultType.NodeSet;
			}
		}

		// Token: 0x04001350 RID: 4944
		private static Operator.Op[] s_invertOp = new Operator.Op[]
		{
			Operator.Op.INVALID,
			Operator.Op.INVALID,
			Operator.Op.INVALID,
			Operator.Op.EQ,
			Operator.Op.NE,
			Operator.Op.GT,
			Operator.Op.GE,
			Operator.Op.LT,
			Operator.Op.LE
		};

		// Token: 0x04001351 RID: 4945
		private Operator.Op _opType;

		// Token: 0x04001352 RID: 4946
		private AstNode _opnd1;

		// Token: 0x04001353 RID: 4947
		private AstNode _opnd2;

		// Token: 0x02000354 RID: 852
		public enum Op
		{
			// Token: 0x04001355 RID: 4949
			INVALID,
			// Token: 0x04001356 RID: 4950
			OR,
			// Token: 0x04001357 RID: 4951
			AND,
			// Token: 0x04001358 RID: 4952
			EQ,
			// Token: 0x04001359 RID: 4953
			NE,
			// Token: 0x0400135A RID: 4954
			LT,
			// Token: 0x0400135B RID: 4955
			LE,
			// Token: 0x0400135C RID: 4956
			GT,
			// Token: 0x0400135D RID: 4957
			GE,
			// Token: 0x0400135E RID: 4958
			PLUS,
			// Token: 0x0400135F RID: 4959
			MINUS,
			// Token: 0x04001360 RID: 4960
			MUL,
			// Token: 0x04001361 RID: 4961
			DIV,
			// Token: 0x04001362 RID: 4962
			MOD,
			// Token: 0x04001363 RID: 4963
			UNION
		}
	}
}
