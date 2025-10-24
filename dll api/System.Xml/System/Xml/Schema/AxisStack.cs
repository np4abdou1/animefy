using System;
using System.Collections;

namespace System.Xml.Schema
{
	// Token: 0x02000221 RID: 545
	internal class AxisStack
	{
		// Token: 0x170003AD RID: 941
		// (get) Token: 0x060011F9 RID: 4601 RVA: 0x0006F765 File Offset: 0x0006D965
		internal ForwardAxis Subtree
		{
			get
			{
				return this._subtree;
			}
		}

		// Token: 0x170003AE RID: 942
		// (get) Token: 0x060011FA RID: 4602 RVA: 0x0006F76D File Offset: 0x0006D96D
		internal int Length
		{
			get
			{
				return this._stack.Count;
			}
		}

		// Token: 0x060011FB RID: 4603 RVA: 0x0006F77A File Offset: 0x0006D97A
		public AxisStack(ForwardAxis faxis, ActiveAxis parent)
		{
			this._subtree = faxis;
			this._stack = new ArrayList();
			this._parent = parent;
			if (!faxis.IsDss)
			{
				this.Push(1);
			}
		}

		// Token: 0x060011FC RID: 4604 RVA: 0x0006F7AC File Offset: 0x0006D9AC
		internal void Push(int depth)
		{
			AxisElement value = new AxisElement(this._subtree.RootNode, depth);
			this._stack.Add(value);
		}

		// Token: 0x060011FD RID: 4605 RVA: 0x0006F7D8 File Offset: 0x0006D9D8
		internal void Pop()
		{
			this._stack.RemoveAt(this.Length - 1);
		}

		// Token: 0x060011FE RID: 4606 RVA: 0x0006F7ED File Offset: 0x0006D9ED
		internal static bool Equal(string thisname, string thisURN, string name, string URN)
		{
			if (thisURN == null)
			{
				if (URN != null && URN.Length != 0)
				{
					return false;
				}
			}
			else if (thisURN.Length != 0 && thisURN != URN)
			{
				return false;
			}
			return thisname.Length == 0 || !(thisname != name);
		}

		// Token: 0x060011FF RID: 4607 RVA: 0x0006F828 File Offset: 0x0006DA28
		internal void MoveToParent(string name, string URN, int depth)
		{
			if (this._subtree.IsSelfAxis)
			{
				return;
			}
			for (int i = 0; i < this._stack.Count; i++)
			{
				((AxisElement)this._stack[i]).MoveToParent(depth, this._subtree);
			}
			if (this._subtree.IsDss && AxisStack.Equal(this._subtree.RootNode.Name, this._subtree.RootNode.Urn, name, URN))
			{
				this.Pop();
			}
		}

		// Token: 0x06001200 RID: 4608 RVA: 0x0006F8B4 File Offset: 0x0006DAB4
		internal bool MoveToChild(string name, string URN, int depth)
		{
			bool result = false;
			if (this._subtree.IsDss && AxisStack.Equal(this._subtree.RootNode.Name, this._subtree.RootNode.Urn, name, URN))
			{
				this.Push(-1);
			}
			for (int i = 0; i < this._stack.Count; i++)
			{
				if (((AxisElement)this._stack[i]).MoveToChild(name, URN, depth, this._subtree))
				{
					result = true;
				}
			}
			return result;
		}

		// Token: 0x06001201 RID: 4609 RVA: 0x0006F93C File Offset: 0x0006DB3C
		internal bool MoveToAttribute(string name, string URN, int depth)
		{
			if (!this._subtree.IsAttribute)
			{
				return false;
			}
			if (!AxisStack.Equal(this._subtree.TopNode.Name, this._subtree.TopNode.Urn, name, URN))
			{
				return false;
			}
			bool result = false;
			if (this._subtree.TopNode.Input == null)
			{
				return this._subtree.IsDss || depth == 1;
			}
			for (int i = 0; i < this._stack.Count; i++)
			{
				AxisElement axisElement = (AxisElement)this._stack[i];
				if (axisElement.isMatch && axisElement.CurNode == this._subtree.TopNode.Input)
				{
					result = true;
				}
			}
			return result;
		}

		// Token: 0x04000C3D RID: 3133
		private ArrayList _stack;

		// Token: 0x04000C3E RID: 3134
		private ForwardAxis _subtree;

		// Token: 0x04000C3F RID: 3135
		private ActiveAxis _parent;
	}
}
