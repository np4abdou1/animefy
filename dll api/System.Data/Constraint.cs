using System;
using System.ComponentModel;
using System.Data.Common;
using System.Globalization;

namespace System.Data
{
	/// <summary>Represents a constraint that can be enforced on one or more <see cref="T:System.Data.DataColumn" /> objects.</summary>
	// Token: 0x02000008 RID: 8
	[DefaultProperty("ConstraintName")]
	[TypeConverter(typeof(ConstraintConverter))]
	public abstract class Constraint
	{
		/// <summary>The name of a constraint in the <see cref="T:System.Data.ConstraintCollection" />.</summary>
		/// <returns>The name of the <see cref="T:System.Data.Constraint" />.</returns>
		/// <exception cref="T:System.ArgumentException">The <see cref="T:System.Data.Constraint" /> name is a null value or empty string. </exception>
		/// <exception cref="T:System.Data.DuplicateNameException">The <see cref="T:System.Data.ConstraintCollection" /> already contains a <see cref="T:System.Data.Constraint" /> with the same name (The comparison is not case-sensitive.). </exception>
		// Token: 0x17000005 RID: 5
		// (get) Token: 0x06000026 RID: 38 RVA: 0x000027E1 File Offset: 0x000009E1
		// (set) Token: 0x06000027 RID: 39 RVA: 0x000027EC File Offset: 0x000009EC
		[DefaultValue("")]
		public virtual string ConstraintName
		{
			get
			{
				return this._name;
			}
			set
			{
				if (value == null)
				{
					value = string.Empty;
				}
				if (string.IsNullOrEmpty(value) && this.Table != null && this.InCollection)
				{
					throw ExceptionBuilder.NoConstraintName();
				}
				CultureInfo culture = (this.Table != null) ? this.Table.Locale : CultureInfo.CurrentCulture;
				if (string.Compare(this._name, value, true, culture) != 0)
				{
					if (this.Table != null && this.InCollection)
					{
						this.Table.Constraints.RegisterName(value);
						if (this._name.Length != 0)
						{
							this.Table.Constraints.UnregisterName(this._name);
						}
					}
					this._name = value;
					return;
				}
				if (string.Compare(this._name, value, false, culture) != 0)
				{
					this._name = value;
				}
			}
		}

		// Token: 0x17000006 RID: 6
		// (get) Token: 0x06000028 RID: 40 RVA: 0x000028AF File Offset: 0x00000AAF
		// (set) Token: 0x06000029 RID: 41 RVA: 0x000028CB File Offset: 0x00000ACB
		internal string SchemaName
		{
			get
			{
				if (!string.IsNullOrEmpty(this._schemaName))
				{
					return this._schemaName;
				}
				return this.ConstraintName;
			}
			set
			{
				if (!string.IsNullOrEmpty(value))
				{
					this._schemaName = value;
				}
			}
		}

		// Token: 0x17000007 RID: 7
		// (get) Token: 0x0600002A RID: 42 RVA: 0x000028DC File Offset: 0x00000ADC
		// (set) Token: 0x0600002B RID: 43 RVA: 0x000028E4 File Offset: 0x00000AE4
		internal virtual bool InCollection
		{
			get
			{
				return this._inCollection;
			}
			set
			{
				this._inCollection = value;
				this._dataSet = (value ? this.Table.DataSet : null);
			}
		}

		/// <summary>Gets the <see cref="T:System.Data.DataTable" /> to which the constraint applies.</summary>
		/// <returns>A <see cref="T:System.Data.DataTable" /> to which the constraint applies.</returns>
		// Token: 0x17000008 RID: 8
		// (get) Token: 0x0600002C RID: 44
		public abstract DataTable Table { get; }

		/// <summary>Gets the collection of user-defined constraint properties.</summary>
		/// <returns>A <see cref="T:System.Data.PropertyCollection" /> of custom information.</returns>
		// Token: 0x17000009 RID: 9
		// (get) Token: 0x0600002D RID: 45 RVA: 0x00002904 File Offset: 0x00000B04
		[Browsable(false)]
		public PropertyCollection ExtendedProperties
		{
			get
			{
				PropertyCollection result;
				if ((result = this._extendedProperties) == null)
				{
					result = (this._extendedProperties = new PropertyCollection());
				}
				return result;
			}
		}

		// Token: 0x0600002E RID: 46
		internal abstract bool ContainsColumn(DataColumn column);

		// Token: 0x0600002F RID: 47
		internal abstract bool CanEnableConstraint();

		// Token: 0x06000030 RID: 48
		internal abstract Constraint Clone(DataSet destination);

		// Token: 0x06000031 RID: 49
		internal abstract Constraint Clone(DataSet destination, bool ignoreNSforTableLookup);

		// Token: 0x06000032 RID: 50 RVA: 0x00002929 File Offset: 0x00000B29
		internal void CheckConstraint()
		{
			if (!this.CanEnableConstraint())
			{
				throw ExceptionBuilder.ConstraintViolation(this.ConstraintName);
			}
		}

		// Token: 0x06000033 RID: 51
		internal abstract void CheckCanAddToCollection(ConstraintCollection constraint);

		// Token: 0x06000034 RID: 52
		internal abstract bool CanBeRemovedFromCollection(ConstraintCollection constraint, bool fThrowException);

		// Token: 0x06000035 RID: 53
		internal abstract void CheckConstraint(DataRow row, DataRowAction action);

		// Token: 0x06000036 RID: 54
		internal abstract void CheckState();

		/// <summary>Gets the <see cref="T:System.Data.DataSet" /> to which this constraint belongs.</summary>
		// Token: 0x06000037 RID: 55 RVA: 0x00002940 File Offset: 0x00000B40
		protected void CheckStateForProperty()
		{
			try
			{
				this.CheckState();
			}
			catch (Exception ex) when (ADP.IsCatchableExceptionType(ex))
			{
				throw ExceptionBuilder.BadObjectPropertyAccess(ex.Message);
			}
		}

		/// <summary>Gets the <see cref="T:System.Data.DataSet" /> to which this constraint belongs.</summary>
		/// <returns>The <see cref="T:System.Data.DataSet" /> to which the constraint belongs.</returns>
		// Token: 0x1700000A RID: 10
		// (get) Token: 0x06000038 RID: 56 RVA: 0x0000298C File Offset: 0x00000B8C
		[CLSCompliant(false)]
		protected virtual DataSet _DataSet
		{
			get
			{
				return this._dataSet;
			}
		}

		// Token: 0x06000039 RID: 57
		internal abstract bool IsConstraintViolated();

		/// <summary>Gets the <see cref="P:System.Data.Constraint.ConstraintName" />, if there is one, as a string.</summary>
		/// <returns>The string value of the <see cref="P:System.Data.Constraint.ConstraintName" />.</returns>
		// Token: 0x0600003A RID: 58 RVA: 0x00002994 File Offset: 0x00000B94
		public override string ToString()
		{
			return this.ConstraintName;
		}

		// Token: 0x04000013 RID: 19
		private string _schemaName = string.Empty;

		// Token: 0x04000014 RID: 20
		private bool _inCollection;

		// Token: 0x04000015 RID: 21
		private DataSet _dataSet;

		// Token: 0x04000016 RID: 22
		internal string _name = string.Empty;

		// Token: 0x04000017 RID: 23
		internal PropertyCollection _extendedProperties;
	}
}
