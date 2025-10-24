using System;
using System.ComponentModel;

namespace System.Data
{
	// Token: 0x0200002A RID: 42
	internal sealed class DataRelationPropertyDescriptor : PropertyDescriptor
	{
		// Token: 0x060002E9 RID: 745 RVA: 0x0000A6DA File Offset: 0x000088DA
		internal DataRelationPropertyDescriptor(DataRelation dataRelation) : base(dataRelation.RelationName, null)
		{
			this.Relation = dataRelation;
		}

		// Token: 0x17000072 RID: 114
		// (get) Token: 0x060002EA RID: 746 RVA: 0x0000A6F0 File Offset: 0x000088F0
		internal DataRelation Relation { get; }

		// Token: 0x17000073 RID: 115
		// (get) Token: 0x060002EB RID: 747 RVA: 0x00006C66 File Offset: 0x00004E66
		public override Type ComponentType
		{
			get
			{
				return typeof(DataRowView);
			}
		}

		// Token: 0x17000074 RID: 116
		// (get) Token: 0x060002EC RID: 748 RVA: 0x000020BC File Offset: 0x000002BC
		public override bool IsReadOnly
		{
			get
			{
				return false;
			}
		}

		// Token: 0x17000075 RID: 117
		// (get) Token: 0x060002ED RID: 749 RVA: 0x0000A6F8 File Offset: 0x000088F8
		public override Type PropertyType
		{
			get
			{
				return typeof(IBindingList);
			}
		}

		// Token: 0x060002EE RID: 750 RVA: 0x0000A704 File Offset: 0x00008904
		public override bool Equals(object other)
		{
			return other is DataRelationPropertyDescriptor && ((DataRelationPropertyDescriptor)other).Relation == this.Relation;
		}

		// Token: 0x060002EF RID: 751 RVA: 0x0000A723 File Offset: 0x00008923
		public override int GetHashCode()
		{
			return this.Relation.GetHashCode();
		}

		// Token: 0x060002F0 RID: 752 RVA: 0x000020BC File Offset: 0x000002BC
		public override bool CanResetValue(object component)
		{
			return false;
		}

		// Token: 0x060002F1 RID: 753 RVA: 0x0000A730 File Offset: 0x00008930
		public override object GetValue(object component)
		{
			return ((DataRowView)component).CreateChildView(this.Relation);
		}

		// Token: 0x060002F2 RID: 754 RVA: 0x000057B2 File Offset: 0x000039B2
		public override void ResetValue(object component)
		{
		}

		// Token: 0x060002F3 RID: 755 RVA: 0x000057B2 File Offset: 0x000039B2
		public override void SetValue(object component, object value)
		{
		}

		// Token: 0x060002F4 RID: 756 RVA: 0x000020BC File Offset: 0x000002BC
		public override bool ShouldSerializeValue(object component)
		{
			return false;
		}
	}
}
