using System;
using System.Xml.XPath;

namespace MS.Internal.Xml.XPath
{
	// Token: 0x02000351 RID: 849
	internal class Group : AstNode
	{
		// Token: 0x06001D68 RID: 7528 RVA: 0x000AB9F8 File Offset: 0x000A9BF8
		public Group(AstNode groupNode)
		{
			this._groupNode = groupNode;
		}

		// Token: 0x170006A4 RID: 1700
		// (get) Token: 0x06001D69 RID: 7529 RVA: 0x0004950A File Offset: 0x0004770A
		public override AstNode.AstType Type
		{
			get
			{
				return AstNode.AstType.Group;
			}
		}

		// Token: 0x170006A5 RID: 1701
		// (get) Token: 0x06001D6A RID: 7530 RVA: 0x0004E85B File Offset: 0x0004CA5B
		public override XPathResultType ReturnType
		{
			get
			{
				return XPathResultType.NodeSet;
			}
		}

		// Token: 0x0400134D RID: 4941
		private AstNode _groupNode;
	}
}
