using System;

namespace System.Data
{
	// Token: 0x0200000E RID: 14
	internal sealed class ParentForeignKeyConstraintEnumerator : ForeignKeyConstraintEnumerator
	{
		// Token: 0x0600006A RID: 106 RVA: 0x0000391E File Offset: 0x00001B1E
		public ParentForeignKeyConstraintEnumerator(DataSet dataSet, DataTable inTable) : base(dataSet)
		{
			this._table = inTable;
		}

		// Token: 0x0600006B RID: 107 RVA: 0x0000392E File Offset: 0x00001B2E
		protected override bool IsValidCandidate(Constraint constraint)
		{
			return constraint is ForeignKeyConstraint && ((ForeignKeyConstraint)constraint).RelatedTable == this._table;
		}

		// Token: 0x04000022 RID: 34
		private readonly DataTable _table;
	}
}
