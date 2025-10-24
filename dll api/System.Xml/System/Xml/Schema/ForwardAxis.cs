using System;

namespace System.Xml.Schema
{
	// Token: 0x02000224 RID: 548
	internal class ForwardAxis
	{
		// Token: 0x170003B1 RID: 945
		// (get) Token: 0x0600120C RID: 4620 RVA: 0x0006FC6E File Offset: 0x0006DE6E
		internal DoubleLinkAxis RootNode
		{
			get
			{
				return this._rootNode;
			}
		}

		// Token: 0x170003B2 RID: 946
		// (get) Token: 0x0600120D RID: 4621 RVA: 0x0006FC76 File Offset: 0x0006DE76
		internal DoubleLinkAxis TopNode
		{
			get
			{
				return this._topNode;
			}
		}

		// Token: 0x170003B3 RID: 947
		// (get) Token: 0x0600120E RID: 4622 RVA: 0x0006FC7E File Offset: 0x0006DE7E
		internal bool IsAttribute
		{
			get
			{
				return this._isAttribute;
			}
		}

		// Token: 0x170003B4 RID: 948
		// (get) Token: 0x0600120F RID: 4623 RVA: 0x0006FC86 File Offset: 0x0006DE86
		internal bool IsDss
		{
			get
			{
				return this._isDss;
			}
		}

		// Token: 0x170003B5 RID: 949
		// (get) Token: 0x06001210 RID: 4624 RVA: 0x0006FC8E File Offset: 0x0006DE8E
		internal bool IsSelfAxis
		{
			get
			{
				return this._isSelfAxis;
			}
		}

		// Token: 0x06001211 RID: 4625 RVA: 0x0006FC98 File Offset: 0x0006DE98
		public ForwardAxis(DoubleLinkAxis axis, bool isdesorself)
		{
			this._isDss = isdesorself;
			this._isAttribute = Asttree.IsAttribute(axis);
			this._topNode = axis;
			this._rootNode = axis;
			while (this._rootNode.Input != null)
			{
				this._rootNode = (DoubleLinkAxis)this._rootNode.Input;
			}
			this._isSelfAxis = Asttree.IsSelf(this._topNode);
		}

		// Token: 0x04000C45 RID: 3141
		private DoubleLinkAxis _topNode;

		// Token: 0x04000C46 RID: 3142
		private DoubleLinkAxis _rootNode;

		// Token: 0x04000C47 RID: 3143
		private bool _isAttribute;

		// Token: 0x04000C48 RID: 3144
		private bool _isDss;

		// Token: 0x04000C49 RID: 3145
		private bool _isSelfAxis;
	}
}
