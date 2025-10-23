using System;
using System.Collections;

namespace System.Data
{
	// Token: 0x0200000B RID: 11
	internal class ConstraintEnumerator
	{
		// Token: 0x06000060 RID: 96 RVA: 0x00003809 File Offset: 0x00001A09
		public ConstraintEnumerator(DataSet dataSet)
		{
			this._tables = ((dataSet != null) ? dataSet.Tables.GetEnumerator() : null);
			this._currentObject = null;
		}

		// Token: 0x06000061 RID: 97 RVA: 0x00003830 File Offset: 0x00001A30
		public bool GetNext()
		{
			this._currentObject = null;
			while (this._tables != null)
			{
				if (this._constraints == null)
				{
					if (!this._tables.MoveNext())
					{
						this._tables = null;
						return false;
					}
					this._constraints = ((DataTable)this._tables.Current).Constraints.GetEnumerator();
				}
				if (!this._constraints.MoveNext())
				{
					this._constraints = null;
				}
				else
				{
					Constraint constraint = (Constraint)this._constraints.Current;
					if (this.IsValidCandidate(constraint))
					{
						this._currentObject = constraint;
						return true;
					}
				}
			}
			return false;
		}

		// Token: 0x06000062 RID: 98 RVA: 0x000038C6 File Offset: 0x00001AC6
		public Constraint GetConstraint()
		{
			return this._currentObject;
		}

		// Token: 0x06000063 RID: 99 RVA: 0x00002317 File Offset: 0x00000517
		protected virtual bool IsValidCandidate(Constraint constraint)
		{
			return true;
		}

		// Token: 0x1700000F RID: 15
		// (get) Token: 0x06000064 RID: 100 RVA: 0x000038C6 File Offset: 0x00001AC6
		protected Constraint CurrentObject
		{
			get
			{
				return this._currentObject;
			}
		}

		// Token: 0x0400001E RID: 30
		private IEnumerator _tables;

		// Token: 0x0400001F RID: 31
		private IEnumerator _constraints;

		// Token: 0x04000020 RID: 32
		private Constraint _currentObject;
	}
}
