using System;
using System.ComponentModel;

namespace System.Data
{
	// Token: 0x02000043 RID: 67
	internal sealed class DataTablePropertyDescriptor : PropertyDescriptor
	{
		// Token: 0x170000D2 RID: 210
		// (get) Token: 0x0600058F RID: 1423 RVA: 0x0001A6CE File Offset: 0x000188CE
		public DataTable Table { get; }

		// Token: 0x06000590 RID: 1424 RVA: 0x0001A6D6 File Offset: 0x000188D6
		internal DataTablePropertyDescriptor(DataTable dataTable) : base(dataTable.TableName, null)
		{
			this.Table = dataTable;
		}

		// Token: 0x170000D3 RID: 211
		// (get) Token: 0x06000591 RID: 1425 RVA: 0x00006C66 File Offset: 0x00004E66
		public override Type ComponentType
		{
			get
			{
				return typeof(DataRowView);
			}
		}

		// Token: 0x170000D4 RID: 212
		// (get) Token: 0x06000592 RID: 1426 RVA: 0x000020BC File Offset: 0x000002BC
		public override bool IsReadOnly
		{
			get
			{
				return false;
			}
		}

		// Token: 0x170000D5 RID: 213
		// (get) Token: 0x06000593 RID: 1427 RVA: 0x0000A6F8 File Offset: 0x000088F8
		public override Type PropertyType
		{
			get
			{
				return typeof(IBindingList);
			}
		}

		// Token: 0x06000594 RID: 1428 RVA: 0x0001A6EC File Offset: 0x000188EC
		public override bool Equals(object other)
		{
			return other is DataTablePropertyDescriptor && ((DataTablePropertyDescriptor)other).Table == this.Table;
		}

		// Token: 0x06000595 RID: 1429 RVA: 0x0001A70B File Offset: 0x0001890B
		public override int GetHashCode()
		{
			return this.Table.GetHashCode();
		}

		// Token: 0x06000596 RID: 1430 RVA: 0x000020BC File Offset: 0x000002BC
		public override bool CanResetValue(object component)
		{
			return false;
		}

		// Token: 0x06000597 RID: 1431 RVA: 0x0001A718 File Offset: 0x00018918
		public override object GetValue(object component)
		{
			return ((DataViewManagerListItemTypeDescriptor)component).GetDataView(this.Table);
		}

		// Token: 0x06000598 RID: 1432 RVA: 0x000057B2 File Offset: 0x000039B2
		public override void ResetValue(object component)
		{
		}

		// Token: 0x06000599 RID: 1433 RVA: 0x000057B2 File Offset: 0x000039B2
		public override void SetValue(object component, object value)
		{
		}

		// Token: 0x0600059A RID: 1434 RVA: 0x000020BC File Offset: 0x000002BC
		public override bool ShouldSerializeValue(object component)
		{
			return false;
		}
	}
}
