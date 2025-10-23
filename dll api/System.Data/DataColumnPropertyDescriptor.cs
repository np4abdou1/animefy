using System;
using System.Collections;
using System.ComponentModel;
using System.Data.Common;

namespace System.Data
{
	// Token: 0x02000016 RID: 22
	internal sealed class DataColumnPropertyDescriptor : PropertyDescriptor
	{
		// Token: 0x06000132 RID: 306 RVA: 0x00006BEA File Offset: 0x00004DEA
		internal DataColumnPropertyDescriptor(DataColumn dataColumn) : base(dataColumn.ColumnName, null)
		{
			this.Column = dataColumn;
		}

		// Token: 0x1700004D RID: 77
		// (get) Token: 0x06000133 RID: 307 RVA: 0x00006C00 File Offset: 0x00004E00
		public override AttributeCollection Attributes
		{
			get
			{
				if (typeof(IList).IsAssignableFrom(this.PropertyType))
				{
					Attribute[] array = new Attribute[base.Attributes.Count + 1];
					base.Attributes.CopyTo(array, 0);
					array[array.Length - 1] = new ListBindableAttribute(false);
					return new AttributeCollection(array);
				}
				return base.Attributes;
			}
		}

		// Token: 0x1700004E RID: 78
		// (get) Token: 0x06000134 RID: 308 RVA: 0x00006C5E File Offset: 0x00004E5E
		internal DataColumn Column { get; }

		// Token: 0x1700004F RID: 79
		// (get) Token: 0x06000135 RID: 309 RVA: 0x00006C66 File Offset: 0x00004E66
		public override Type ComponentType
		{
			get
			{
				return typeof(DataRowView);
			}
		}

		// Token: 0x17000050 RID: 80
		// (get) Token: 0x06000136 RID: 310 RVA: 0x00006C72 File Offset: 0x00004E72
		public override bool IsReadOnly
		{
			get
			{
				return this.Column.ReadOnly;
			}
		}

		// Token: 0x17000051 RID: 81
		// (get) Token: 0x06000137 RID: 311 RVA: 0x00006C7F File Offset: 0x00004E7F
		public override Type PropertyType
		{
			get
			{
				return this.Column.DataType;
			}
		}

		// Token: 0x06000138 RID: 312 RVA: 0x00006C8C File Offset: 0x00004E8C
		public override bool Equals(object other)
		{
			return other is DataColumnPropertyDescriptor && ((DataColumnPropertyDescriptor)other).Column == this.Column;
		}

		// Token: 0x06000139 RID: 313 RVA: 0x00006CAB File Offset: 0x00004EAB
		public override int GetHashCode()
		{
			return this.Column.GetHashCode();
		}

		// Token: 0x0600013A RID: 314 RVA: 0x00006CB8 File Offset: 0x00004EB8
		public override bool CanResetValue(object component)
		{
			DataRowView dataRowView = (DataRowView)component;
			if (!this.Column.IsSqlType)
			{
				return dataRowView.GetColumnValue(this.Column) != DBNull.Value;
			}
			return !DataStorage.IsObjectNull(dataRowView.GetColumnValue(this.Column));
		}

		// Token: 0x0600013B RID: 315 RVA: 0x00006D04 File Offset: 0x00004F04
		public override object GetValue(object component)
		{
			return ((DataRowView)component).GetColumnValue(this.Column);
		}

		// Token: 0x0600013C RID: 316 RVA: 0x00006D17 File Offset: 0x00004F17
		public override void ResetValue(object component)
		{
			((DataRowView)component).SetColumnValue(this.Column, DBNull.Value);
		}

		// Token: 0x0600013D RID: 317 RVA: 0x00006D2F File Offset: 0x00004F2F
		public override void SetValue(object component, object value)
		{
			((DataRowView)component).SetColumnValue(this.Column, value);
			this.OnValueChanged(component, EventArgs.Empty);
		}

		// Token: 0x0600013E RID: 318 RVA: 0x000020BC File Offset: 0x000002BC
		public override bool ShouldSerializeValue(object component)
		{
			return false;
		}
	}
}
