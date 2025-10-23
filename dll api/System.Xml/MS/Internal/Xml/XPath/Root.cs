using System;
using System.Xml.XPath;

namespace MS.Internal.Xml.XPath
{
	// Token: 0x02000355 RID: 853
	internal class Root : AstNode
	{
		// Token: 0x170006AA RID: 1706
		// (get) Token: 0x06001D74 RID: 7540 RVA: 0x00049468 File Offset: 0x00047668
		public override AstNode.AstType Type
		{
			get
			{
				return AstNode.AstType.Root;
			}
		}

		// Token: 0x170006AB RID: 1707
		// (get) Token: 0x06001D75 RID: 7541 RVA: 0x0004E85B File Offset: 0x0004CA5B
		public override XPathResultType ReturnType
		{
			get
			{
				return XPathResultType.NodeSet;
			}
		}
	}
}
