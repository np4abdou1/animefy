using System;
using System.Collections.Generic;

namespace System.Linq.Expressions.Compiler
{
	// Token: 0x020000E6 RID: 230
	internal sealed class LabelScopeInfo
	{
		// Token: 0x0600074C RID: 1868 RVA: 0x00017E5D File Offset: 0x0001605D
		internal LabelScopeInfo(LabelScopeInfo parent, LabelScopeKind kind)
		{
			this.Parent = parent;
			this.Kind = kind;
		}

		// Token: 0x1700016E RID: 366
		// (get) Token: 0x0600074D RID: 1869 RVA: 0x00017E74 File Offset: 0x00016074
		internal bool CanJumpInto
		{
			get
			{
				LabelScopeKind kind = this.Kind;
				return kind <= LabelScopeKind.Lambda;
			}
		}

		// Token: 0x0600074E RID: 1870 RVA: 0x00017E8F File Offset: 0x0001608F
		internal bool ContainsTarget(LabelTarget target)
		{
			return this._labels != null && this._labels.ContainsKey(target);
		}

		// Token: 0x0600074F RID: 1871 RVA: 0x00017EA7 File Offset: 0x000160A7
		internal bool TryGetLabelInfo(LabelTarget target, out LabelInfo info)
		{
			if (this._labels == null)
			{
				info = null;
				return false;
			}
			return this._labels.TryGetValue(target, out info);
		}

		// Token: 0x06000750 RID: 1872 RVA: 0x00017EC3 File Offset: 0x000160C3
		internal void AddLabelInfo(LabelTarget target, LabelInfo info)
		{
			if (this._labels == null)
			{
				this._labels = new Dictionary<LabelTarget, LabelInfo>();
			}
			this._labels.Add(target, info);
		}

		// Token: 0x0400022E RID: 558
		private Dictionary<LabelTarget, LabelInfo> _labels;

		// Token: 0x0400022F RID: 559
		internal readonly LabelScopeKind Kind;

		// Token: 0x04000230 RID: 560
		internal readonly LabelScopeInfo Parent;
	}
}
