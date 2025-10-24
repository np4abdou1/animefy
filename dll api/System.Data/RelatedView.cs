using System;

namespace System.Data
{
	// Token: 0x02000086 RID: 134
	internal sealed class RelatedView : DataView, IFilter
	{
		// Token: 0x0600083A RID: 2106 RVA: 0x00028F9C File Offset: 0x0002719C
		public RelatedView(DataColumn[] columns, object[] values) : base(columns[0].Table, false)
		{
			if (values == null)
			{
				throw ExceptionBuilder.ArgumentNull("values");
			}
			this._parentRowView = null;
			this._parentKey = null;
			this._childKey = new DataKey(columns, true);
			this._filterValues = values;
			base.ResetRowViewCache();
		}

		// Token: 0x0600083B RID: 2107 RVA: 0x00028FF3 File Offset: 0x000271F3
		public RelatedView(DataRowView parentRowView, DataKey parentKey, DataColumn[] childKeyColumns) : base(childKeyColumns[0].Table, false)
		{
			this._filterValues = null;
			this._parentRowView = parentRowView;
			this._parentKey = new DataKey?(parentKey);
			this._childKey = new DataKey(childKeyColumns, true);
			base.ResetRowViewCache();
		}

		// Token: 0x0600083C RID: 2108 RVA: 0x00029034 File Offset: 0x00027234
		private object[] GetParentValues()
		{
			if (this._filterValues != null)
			{
				return this._filterValues;
			}
			if (!this._parentRowView.HasRecord())
			{
				return null;
			}
			return this._parentKey.Value.GetKeyValues(this._parentRowView.GetRecord());
		}

		// Token: 0x0600083D RID: 2109 RVA: 0x00029080 File Offset: 0x00027280
		public bool Invoke(DataRow row, DataRowVersion version)
		{
			object[] parentValues = this.GetParentValues();
			if (parentValues == null)
			{
				return false;
			}
			object[] keyValues = row.GetKeyValues(this._childKey, version);
			bool flag = true;
			if (keyValues.Length != parentValues.Length)
			{
				flag = false;
			}
			else
			{
				for (int i = 0; i < keyValues.Length; i++)
				{
					if (!keyValues[i].Equals(parentValues[i]))
					{
						flag = false;
						break;
					}
				}
			}
			IFilter filter = base.GetFilter();
			if (filter != null)
			{
				flag &= filter.Invoke(row, version);
			}
			return flag;
		}

		// Token: 0x0600083E RID: 2110 RVA: 0x00002050 File Offset: 0x00000250
		internal override IFilter GetFilter()
		{
			return this;
		}

		// Token: 0x0600083F RID: 2111 RVA: 0x000290F0 File Offset: 0x000272F0
		public override DataRowView AddNew()
		{
			DataRowView dataRowView = base.AddNew();
			dataRowView.Row.SetKeyValues(this._childKey, this.GetParentValues());
			return dataRowView;
		}

		// Token: 0x06000840 RID: 2112 RVA: 0x0002910F File Offset: 0x0002730F
		internal override void SetIndex(string newSort, DataViewRowState newRowStates, IFilter newRowFilter)
		{
			base.SetIndex2(newSort, newRowStates, newRowFilter, false);
			base.Reset();
		}

		// Token: 0x040002BB RID: 699
		private readonly DataKey? _parentKey;

		// Token: 0x040002BC RID: 700
		private readonly DataKey _childKey;

		// Token: 0x040002BD RID: 701
		private readonly DataRowView _parentRowView;

		// Token: 0x040002BE RID: 702
		private readonly object[] _filterValues;
	}
}
