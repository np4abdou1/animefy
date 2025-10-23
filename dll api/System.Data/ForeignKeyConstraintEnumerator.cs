using System;

namespace System.Data
{
	// Token: 0x0200000C RID: 12
	internal class ForeignKeyConstraintEnumerator : ConstraintEnumerator
	{
		// Token: 0x06000065 RID: 101 RVA: 0x000038CE File Offset: 0x00001ACE
		public ForeignKeyConstraintEnumerator(DataSet dataSet) : base(dataSet)
		{
		}

		// Token: 0x06000066 RID: 102 RVA: 0x000038D7 File Offset: 0x00001AD7
		protected override bool IsValidCandidate(Constraint constraint)
		{
			return constraint is ForeignKeyConstraint;
		}

		// Token: 0x06000067 RID: 103 RVA: 0x000038E2 File Offset: 0x00001AE2
		public ForeignKeyConstraint GetForeignKeyConstraint()
		{
			return (ForeignKeyConstraint)base.CurrentObject;
		}
	}
}
