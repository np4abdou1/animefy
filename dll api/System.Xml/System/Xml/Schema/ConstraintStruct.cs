using System;
using System.Collections;

namespace System.Xml.Schema
{
	// Token: 0x0200022D RID: 557
	internal sealed class ConstraintStruct
	{
		// Token: 0x170003CE RID: 974
		// (get) Token: 0x0600126E RID: 4718 RVA: 0x00071250 File Offset: 0x0006F450
		internal int TableDim
		{
			get
			{
				return this.tableDim;
			}
		}

		// Token: 0x0600126F RID: 4719 RVA: 0x00071258 File Offset: 0x0006F458
		internal ConstraintStruct(CompiledIdentityConstraint constraint)
		{
			this.constraint = constraint;
			this.tableDim = constraint.Fields.Length;
			this.axisFields = new ArrayList();
			this.axisSelector = new SelectorActiveAxis(constraint.Selector, this);
			if (this.constraint.Role != CompiledIdentityConstraint.ConstraintRole.Keyref)
			{
				this.qualifiedTable = new Hashtable();
			}
		}

		// Token: 0x04000C73 RID: 3187
		internal CompiledIdentityConstraint constraint;

		// Token: 0x04000C74 RID: 3188
		internal SelectorActiveAxis axisSelector;

		// Token: 0x04000C75 RID: 3189
		internal ArrayList axisFields;

		// Token: 0x04000C76 RID: 3190
		internal Hashtable qualifiedTable;

		// Token: 0x04000C77 RID: 3191
		internal Hashtable keyrefTable;

		// Token: 0x04000C78 RID: 3192
		private int tableDim;
	}
}
