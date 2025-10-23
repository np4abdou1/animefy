using System;
using System.Collections;

namespace System.Xml.Schema
{
	// Token: 0x02000222 RID: 546
	internal class ActiveAxis
	{
		// Token: 0x170003AF RID: 943
		// (get) Token: 0x06001202 RID: 4610 RVA: 0x0006F9F6 File Offset: 0x0006DBF6
		public int CurrentDepth
		{
			get
			{
				return this._currentDepth;
			}
		}

		// Token: 0x06001203 RID: 4611 RVA: 0x0006F9FE File Offset: 0x0006DBFE
		internal void Reactivate()
		{
			this._isActive = true;
			this._currentDepth = -1;
		}

		// Token: 0x06001204 RID: 4612 RVA: 0x0006FA10 File Offset: 0x0006DC10
		internal ActiveAxis(Asttree axisTree)
		{
			this._axisTree = axisTree;
			this._currentDepth = -1;
			this._axisStack = new ArrayList(axisTree.SubtreeArray.Count);
			for (int i = 0; i < axisTree.SubtreeArray.Count; i++)
			{
				AxisStack value = new AxisStack((ForwardAxis)axisTree.SubtreeArray[i], this);
				this._axisStack.Add(value);
			}
			this._isActive = true;
		}

		// Token: 0x06001205 RID: 4613 RVA: 0x0006FA8C File Offset: 0x0006DC8C
		public bool MoveToStartElement(string localname, string URN)
		{
			if (!this._isActive)
			{
				return false;
			}
			this._currentDepth++;
			bool result = false;
			for (int i = 0; i < this._axisStack.Count; i++)
			{
				AxisStack axisStack = (AxisStack)this._axisStack[i];
				if (axisStack.Subtree.IsSelfAxis)
				{
					if (axisStack.Subtree.IsDss || this.CurrentDepth == 0)
					{
						result = true;
					}
				}
				else if (this.CurrentDepth != 0 && axisStack.MoveToChild(localname, URN, this._currentDepth))
				{
					result = true;
				}
			}
			return result;
		}

		// Token: 0x06001206 RID: 4614 RVA: 0x0006FB1C File Offset: 0x0006DD1C
		public virtual bool EndElement(string localname, string URN)
		{
			if (this._currentDepth == 0)
			{
				this._isActive = false;
				this._currentDepth--;
			}
			if (!this._isActive)
			{
				return false;
			}
			for (int i = 0; i < this._axisStack.Count; i++)
			{
				((AxisStack)this._axisStack[i]).MoveToParent(localname, URN, this._currentDepth);
			}
			this._currentDepth--;
			return false;
		}

		// Token: 0x06001207 RID: 4615 RVA: 0x0006FB94 File Offset: 0x0006DD94
		public bool MoveToAttribute(string localname, string URN)
		{
			if (!this._isActive)
			{
				return false;
			}
			bool result = false;
			for (int i = 0; i < this._axisStack.Count; i++)
			{
				if (((AxisStack)this._axisStack[i]).MoveToAttribute(localname, URN, this._currentDepth + 1))
				{
					result = true;
				}
			}
			return result;
		}

		// Token: 0x04000C40 RID: 3136
		private int _currentDepth;

		// Token: 0x04000C41 RID: 3137
		private bool _isActive;

		// Token: 0x04000C42 RID: 3138
		private Asttree _axisTree;

		// Token: 0x04000C43 RID: 3139
		private ArrayList _axisStack;
	}
}
