using System;
using System.ComponentModel;
using System.Reflection;
using System.Runtime.CompilerServices;

namespace System.Data
{
	/// <summary>Represents a customized view of a <see cref="T:System.Data.DataRow" />.</summary>
	// Token: 0x02000036 RID: 54
	[DefaultMember("Item")]
	public class DataRowView : ICustomTypeDescriptor, INotifyPropertyChanged
	{
		// Token: 0x0600035C RID: 860 RVA: 0x0000BE40 File Offset: 0x0000A040
		internal DataRowView(DataView dataView, DataRow row)
		{
			this._dataView = dataView;
			this._row = row;
		}

		/// <summary>Gets a value indicating whether the current <see cref="T:System.Data.DataRowView" /> is identical to the specified object.</summary>
		/// <param name="other">An <see cref="T:System.Object" /> to be compared. </param>
		/// <returns>
		///     <see langword="true" /> if <paramref name="object" /> is a <see cref="T:System.Data.DataRowView" /> and it returns the same row as the current <see cref="T:System.Data.DataRowView" />; otherwise <see langword="false" />.</returns>
		// Token: 0x0600035D RID: 861 RVA: 0x0000BE56 File Offset: 0x0000A056
		public override bool Equals(object other)
		{
			return this == other;
		}

		/// <summary>Returns the hash code of the <see cref="T:System.Data.DataRow" /> object.</summary>
		/// <returns>A 32-bit signed integer hash code 1, which represents Boolean <see langword="true" /> if the value of this instance is nonzero; otherwise the integer zero, which represents Boolean <see langword="false" />.</returns>
		// Token: 0x0600035E RID: 862 RVA: 0x0000BE5C File Offset: 0x0000A05C
		public override int GetHashCode()
		{
			return this.Row.GetHashCode();
		}

		/// <summary>Gets the <see cref="T:System.Data.DataView" /> to which this row belongs.</summary>
		/// <returns>The <see langword="DataView" /> to which this row belongs.</returns>
		// Token: 0x17000087 RID: 135
		// (get) Token: 0x0600035F RID: 863 RVA: 0x0000BE69 File Offset: 0x0000A069
		public DataView DataView
		{
			get
			{
				return this._dataView;
			}
		}

		// Token: 0x17000088 RID: 136
		// (get) Token: 0x06000360 RID: 864 RVA: 0x0000BE71 File Offset: 0x0000A071
		private DataRowVersion RowVersionDefault
		{
			get
			{
				return this.Row.GetDefaultRowVersion(this._dataView.RowStateFilter);
			}
		}

		// Token: 0x06000361 RID: 865 RVA: 0x0000BE89 File Offset: 0x0000A089
		internal int GetRecord()
		{
			return this.Row.GetRecordFromVersion(this.RowVersionDefault);
		}

		// Token: 0x06000362 RID: 866 RVA: 0x0000BE9C File Offset: 0x0000A09C
		internal bool HasRecord()
		{
			return this.Row.HasVersion(this.RowVersionDefault);
		}

		// Token: 0x06000363 RID: 867 RVA: 0x0000BEAF File Offset: 0x0000A0AF
		internal object GetColumnValue(DataColumn column)
		{
			return this.Row[column, this.RowVersionDefault];
		}

		// Token: 0x06000364 RID: 868 RVA: 0x0000BEC4 File Offset: 0x0000A0C4
		internal void SetColumnValue(DataColumn column, object value)
		{
			if (this._delayBeginEdit)
			{
				this._delayBeginEdit = false;
				this.Row.BeginEdit();
			}
			if (DataRowVersion.Original == this.RowVersionDefault)
			{
				throw ExceptionBuilder.SetFailed(column.ColumnName);
			}
			this.Row[column] = value;
		}

		/// <summary>Returns a <see cref="T:System.Data.DataView" /> for the child <see cref="T:System.Data.DataTable" /> with the specified <see cref="T:System.Data.DataRelation" /> and parent..</summary>
		/// <param name="relation">The <see cref="T:System.Data.DataRelation" /> object.</param>
		/// <param name="followParent">The parent object.</param>
		/// <returns>A <see cref="T:System.Data.DataView" /> for the child <see cref="T:System.Data.DataTable" />.</returns>
		// Token: 0x06000365 RID: 869 RVA: 0x0000BF14 File Offset: 0x0000A114
		public DataView CreateChildView(DataRelation relation, bool followParent)
		{
			if (relation == null || relation.ParentKey.Table != this.DataView.Table)
			{
				throw ExceptionBuilder.CreateChildView();
			}
			RelatedView relatedView;
			if (!followParent)
			{
				int record = this.GetRecord();
				object[] keyValues = relation.ParentKey.GetKeyValues(record);
				relatedView = new RelatedView(relation.ChildColumnsReference, keyValues);
			}
			else
			{
				relatedView = new RelatedView(this, relation.ParentKey, relation.ChildColumnsReference);
			}
			relatedView.SetIndex("", DataViewRowState.CurrentRows, null);
			relatedView.SetDataViewManager(this.DataView.DataViewManager);
			return relatedView;
		}

		/// <summary>Returns a <see cref="T:System.Data.DataView" /> for the child <see cref="T:System.Data.DataTable" /> with the specified child <see cref="T:System.Data.DataRelation" />.</summary>
		/// <param name="relation">The <see cref="T:System.Data.DataRelation" /> object. </param>
		/// <returns>a <see cref="T:System.Data.DataView" /> for the child <see cref="T:System.Data.DataTable" />.</returns>
		// Token: 0x06000366 RID: 870 RVA: 0x0000BFA1 File Offset: 0x0000A1A1
		public DataView CreateChildView(DataRelation relation)
		{
			return this.CreateChildView(relation, false);
		}

		/// <summary>Gets the <see cref="T:System.Data.DataRow" /> being viewed.</summary>
		/// <returns>The <see cref="T:System.Data.DataRow" /> being viewed by the <see cref="T:System.Data.DataRowView" />.</returns>
		// Token: 0x17000089 RID: 137
		// (get) Token: 0x06000367 RID: 871 RVA: 0x0000BFAB File Offset: 0x0000A1AB
		public DataRow Row
		{
			get
			{
				return this._row;
			}
		}

		/// <summary>Commits changes to the underlying <see cref="T:System.Data.DataRow" /> and ends the editing session that was begun with <see cref="M:System.Data.DataRowView.BeginEdit" />.  Use <see cref="M:System.Data.DataRowView.CancelEdit" /> to discard the changes made to the <see cref="T:System.Data.DataRow" />.</summary>
		// Token: 0x06000368 RID: 872 RVA: 0x0000BFB3 File Offset: 0x0000A1B3
		public void EndEdit()
		{
			if (this.IsNew)
			{
				this._dataView.FinishAddNew(true);
			}
			else
			{
				this.Row.EndEdit();
			}
			this._delayBeginEdit = false;
		}

		/// <summary>Indicates whether a <see cref="T:System.Data.DataRowView" /> is new.</summary>
		/// <returns>
		///     <see langword="true" /> if the row is new; otherwise <see langword="false" />.</returns>
		// Token: 0x1700008A RID: 138
		// (get) Token: 0x06000369 RID: 873 RVA: 0x0000BFDD File Offset: 0x0000A1DD
		public bool IsNew
		{
			get
			{
				return this._row == this._dataView._addNewRow;
			}
		}

		// Token: 0x0600036A RID: 874 RVA: 0x0000BFF2 File Offset: 0x0000A1F2
		internal void RaisePropertyChangedEvent(string propName)
		{
			PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
			if (propertyChanged == null)
			{
				return;
			}
			propertyChanged(this, new PropertyChangedEventArgs(propName));
		}

		/// <summary>Returns a collection of custom attributes for this instance of a component.</summary>
		/// <returns>An AttributeCollection containing the attributes for this object.</returns>
		// Token: 0x0600036B RID: 875 RVA: 0x0000C00B File Offset: 0x0000A20B
		AttributeCollection ICustomTypeDescriptor.GetAttributes()
		{
			return new AttributeCollection(null);
		}

		/// <summary>Returns the class name of this instance of a component.</summary>
		/// <returns>The class name of this instance of a component.</returns>
		// Token: 0x0600036C RID: 876 RVA: 0x000020F7 File Offset: 0x000002F7
		string ICustomTypeDescriptor.GetClassName()
		{
			return null;
		}

		/// <summary>Returns the name of this instance of a component.</summary>
		/// <returns>The name of this instance of a component.</returns>
		// Token: 0x0600036D RID: 877 RVA: 0x000020F7 File Offset: 0x000002F7
		string ICustomTypeDescriptor.GetComponentName()
		{
			return null;
		}

		/// <summary>Returns a type converter for this instance of a component.</summary>
		/// <returns>The type converter for this instance of a component.</returns>
		// Token: 0x0600036E RID: 878 RVA: 0x000020F7 File Offset: 0x000002F7
		TypeConverter ICustomTypeDescriptor.GetConverter()
		{
			return null;
		}

		/// <summary>Returns the default event for this instance of a component.</summary>
		/// <returns>The default event for this instance of a component.</returns>
		// Token: 0x0600036F RID: 879 RVA: 0x000020F7 File Offset: 0x000002F7
		EventDescriptor ICustomTypeDescriptor.GetDefaultEvent()
		{
			return null;
		}

		/// <summary>Returns the default property for this instance of a component.</summary>
		/// <returns>The default property for this instance of a component.</returns>
		// Token: 0x06000370 RID: 880 RVA: 0x000020F7 File Offset: 0x000002F7
		PropertyDescriptor ICustomTypeDescriptor.GetDefaultProperty()
		{
			return null;
		}

		/// <summary>Returns an editor of the specified type for this instance of a component.</summary>
		/// <param name="editorBaseType">A <see cref="T:System.Type" /> that represents the editor for this object. </param>
		/// <returns>An <see cref="T:System.Object" /> of the specified type that is the editor for this object, or <see langword="null" /> if the editor cannot be found.</returns>
		// Token: 0x06000371 RID: 881 RVA: 0x000020F7 File Offset: 0x000002F7
		object ICustomTypeDescriptor.GetEditor(Type editorBaseType)
		{
			return null;
		}

		/// <summary>Returns the events for this instance of a component.</summary>
		/// <returns>The events for this instance of a component.</returns>
		// Token: 0x06000372 RID: 882 RVA: 0x0000C013 File Offset: 0x0000A213
		EventDescriptorCollection ICustomTypeDescriptor.GetEvents()
		{
			return new EventDescriptorCollection(null);
		}

		/// <summary>Returns the events for this instance of a component with specified attributes.</summary>
		/// <param name="attributes">The attributes</param>
		/// <returns>The events for this instance of a component.</returns>
		// Token: 0x06000373 RID: 883 RVA: 0x0000C013 File Offset: 0x0000A213
		EventDescriptorCollection ICustomTypeDescriptor.GetEvents(Attribute[] attributes)
		{
			return new EventDescriptorCollection(null);
		}

		/// <summary>Returns the properties for this instance of a component.</summary>
		/// <returns>The properties for this instance of a component.</returns>
		// Token: 0x06000374 RID: 884 RVA: 0x0000C01B File Offset: 0x0000A21B
		PropertyDescriptorCollection ICustomTypeDescriptor.GetProperties()
		{
			return ((ICustomTypeDescriptor)this).GetProperties(null);
		}

		/// <summary>Returns the properties for this instance of a component with specified attributes.</summary>
		/// <param name="attributes">The attributes.</param>
		/// <returns>The properties for this instance of a component.</returns>
		// Token: 0x06000375 RID: 885 RVA: 0x0000C024 File Offset: 0x0000A224
		PropertyDescriptorCollection ICustomTypeDescriptor.GetProperties(Attribute[] attributes)
		{
			if (this._dataView.Table == null)
			{
				return DataRowView.s_zeroPropertyDescriptorCollection;
			}
			return this._dataView.Table.GetPropertyDescriptorCollection(attributes);
		}

		/// <summary>Returns an object that contains the property described by the specified property descriptor.</summary>
		/// <param name="pd">A <see cref="T:System.ComponentModel.PropertyDescriptor" /> that represents the property whose owner is to be found. </param>
		/// <returns>An <see cref="T:System.Object" /> that represents the owner of the specified property.</returns>
		// Token: 0x06000376 RID: 886 RVA: 0x00002050 File Offset: 0x00000250
		object ICustomTypeDescriptor.GetPropertyOwner(PropertyDescriptor pd)
		{
			return this;
		}

		// Token: 0x040000AF RID: 175
		private readonly DataView _dataView;

		// Token: 0x040000B0 RID: 176
		private readonly DataRow _row;

		// Token: 0x040000B1 RID: 177
		private bool _delayBeginEdit;

		// Token: 0x040000B2 RID: 178
		private static readonly PropertyDescriptorCollection s_zeroPropertyDescriptorCollection = new PropertyDescriptorCollection(null);

		// Token: 0x040000B3 RID: 179
		[CompilerGenerated]
		private PropertyChangedEventHandler PropertyChanged;
	}
}
