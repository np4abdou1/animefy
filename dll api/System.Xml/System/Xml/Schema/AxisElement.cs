using System;

namespace System.Xml.Schema
{
	// Token: 0x02000220 RID: 544
	internal class AxisElement
	{
		// Token: 0x170003AC RID: 940
		// (get) Token: 0x060011F4 RID: 4596 RVA: 0x0006F5B3 File Offset: 0x0006D7B3
		internal DoubleLinkAxis CurNode
		{
			get
			{
				return this.curNode;
			}
		}

		// Token: 0x060011F5 RID: 4597 RVA: 0x0006F5BC File Offset: 0x0006D7BC
		internal AxisElement(DoubleLinkAxis node, int depth)
		{
			this.curNode = node;
			this.curDepth = depth;
			this.rootDepth = depth;
			this.isMatch = false;
		}

		// Token: 0x060011F6 RID: 4598 RVA: 0x0006F5F0 File Offset: 0x0006D7F0
		internal void SetDepth(int depth)
		{
			this.curDepth = depth;
			this.rootDepth = depth;
		}

		// Token: 0x060011F7 RID: 4599 RVA: 0x0006F610 File Offset: 0x0006D810
		internal void MoveToParent(int depth, ForwardAxis parent)
		{
			if (depth != this.curDepth - 1)
			{
				if (depth == this.curDepth && this.isMatch)
				{
					this.isMatch = false;
				}
				return;
			}
			if (this.curNode.Input == parent.RootNode && parent.IsDss)
			{
				this.curNode = parent.RootNode;
				this.rootDepth = (this.curDepth = -1);
				return;
			}
			if (this.curNode.Input != null)
			{
				this.curNode = (DoubleLinkAxis)this.curNode.Input;
				this.curDepth--;
				return;
			}
		}

		// Token: 0x060011F8 RID: 4600 RVA: 0x0006F6AC File Offset: 0x0006D8AC
		internal bool MoveToChild(string name, string URN, int depth, ForwardAxis parent)
		{
			if (Asttree.IsAttribute(this.curNode))
			{
				return false;
			}
			if (this.isMatch)
			{
				this.isMatch = false;
			}
			if (!AxisStack.Equal(this.curNode.Name, this.curNode.Urn, name, URN))
			{
				return false;
			}
			if (this.curDepth == -1)
			{
				this.SetDepth(depth);
			}
			else if (depth > this.curDepth)
			{
				return false;
			}
			if (this.curNode == parent.TopNode)
			{
				this.isMatch = true;
				return true;
			}
			DoubleLinkAxis ast = (DoubleLinkAxis)this.curNode.Next;
			if (Asttree.IsAttribute(ast))
			{
				this.isMatch = true;
				return false;
			}
			this.curNode = ast;
			this.curDepth++;
			return false;
		}

		// Token: 0x04000C39 RID: 3129
		internal DoubleLinkAxis curNode;

		// Token: 0x04000C3A RID: 3130
		internal int rootDepth;

		// Token: 0x04000C3B RID: 3131
		internal int curDepth;

		// Token: 0x04000C3C RID: 3132
		internal bool isMatch;
	}
}
