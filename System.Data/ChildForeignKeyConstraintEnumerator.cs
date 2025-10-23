using System;

namespace System.Data
{
	// Token: 0x0200000D RID: 13
	internal sealed class ChildForeignKeyConstraintEnumerator : ForeignKeyConstraintEnumerator
	{
		// Token: 0x06000068 RID: 104 RVA: 0x000038EF File Offset: 0x00001AEF
		public ChildForeignKeyConstraintEnumerator(DataSet dataSet, DataTable inTable) : base(dataSet)
		{
			this._table = inTable;
		}

		// Token: 0x06000069 RID: 105 RVA: 0x000038FF File Offset: 0x00001AFF
		protected override bool IsValidCandidate(Constraint constraint)
		{
			return constraint is ForeignKeyConstraint && ((ForeignKeyConstraint)constraint).Table == this._table;
		}

		// Token: 0x04000021 RID: 33
		private readonly DataTable _table;
	}
}
