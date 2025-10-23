using System;
using System.ComponentModel;
using System.ComponentModel.Design.Serialization;
using System.Globalization;
using System.Reflection;

namespace System.Data
{
	// Token: 0x0200000A RID: 10
	internal sealed class ConstraintConverter : ExpandableObjectConverter
	{
		// Token: 0x0600005E RID: 94 RVA: 0x00002118 File Offset: 0x00000318
		public override bool CanConvertTo(ITypeDescriptorContext context, Type destinationType)
		{
			return destinationType == typeof(InstanceDescriptor) || base.CanConvertTo(context, destinationType);
		}

		// Token: 0x0600005F RID: 95 RVA: 0x0000364C File Offset: 0x0000184C
		public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType)
		{
			if (destinationType == null)
			{
				throw new ArgumentNullException("destinationType");
			}
			if (destinationType == typeof(InstanceDescriptor) && value is Constraint)
			{
				if (value is UniqueConstraint)
				{
					UniqueConstraint uniqueConstraint = (UniqueConstraint)value;
					ConstructorInfo constructor = typeof(UniqueConstraint).GetConstructor(new Type[]
					{
						typeof(string),
						typeof(string[]),
						typeof(bool)
					});
					if (constructor != null)
					{
						return new InstanceDescriptor(constructor, new object[]
						{
							uniqueConstraint.ConstraintName,
							uniqueConstraint.ColumnNames,
							uniqueConstraint.IsPrimaryKey
						});
					}
				}
				else
				{
					ForeignKeyConstraint foreignKeyConstraint = (ForeignKeyConstraint)value;
					ConstructorInfo constructor2 = typeof(ForeignKeyConstraint).GetConstructor(new Type[]
					{
						typeof(string),
						typeof(string),
						typeof(string[]),
						typeof(string[]),
						typeof(AcceptRejectRule),
						typeof(Rule),
						typeof(Rule)
					});
					if (constructor2 != null)
					{
						return new InstanceDescriptor(constructor2, new object[]
						{
							foreignKeyConstraint.ConstraintName,
							foreignKeyConstraint.ParentKey.Table.TableName,
							foreignKeyConstraint.ParentColumnNames,
							foreignKeyConstraint.ChildColumnNames,
							foreignKeyConstraint.AcceptRejectRule,
							foreignKeyConstraint.DeleteRule,
							foreignKeyConstraint.UpdateRule
						});
					}
				}
			}
			return base.ConvertTo(context, culture, value, destinationType);
		}
	}
}
