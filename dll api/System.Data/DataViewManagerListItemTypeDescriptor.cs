using System;
using System.ComponentModel;

namespace System.Data
{
	// Token: 0x0200004B RID: 75
	internal sealed class DataViewManagerListItemTypeDescriptor : ICustomTypeDescriptor
	{
		// Token: 0x06000656 RID: 1622 RVA: 0x0001D51E File Offset: 0x0001B71E
		internal DataViewManagerListItemTypeDescriptor(DataViewManager dataViewManager)
		{
			this._dataViewManager = dataViewManager;
		}

		// Token: 0x06000657 RID: 1623 RVA: 0x0001D52D File Offset: 0x0001B72D
		internal DataView GetDataView(DataTable table)
		{
			DataView dataView = new DataView(table);
			dataView.SetDataViewManager(this._dataViewManager);
			return dataView;
		}

		// Token: 0x06000658 RID: 1624 RVA: 0x0000C00B File Offset: 0x0000A20B
		AttributeCollection ICustomTypeDescriptor.GetAttributes()
		{
			return new AttributeCollection(null);
		}

		// Token: 0x06000659 RID: 1625 RVA: 0x000020F7 File Offset: 0x000002F7
		string ICustomTypeDescriptor.GetClassName()
		{
			return null;
		}

		// Token: 0x0600065A RID: 1626 RVA: 0x000020F7 File Offset: 0x000002F7
		string ICustomTypeDescriptor.GetComponentName()
		{
			return null;
		}

		// Token: 0x0600065B RID: 1627 RVA: 0x000020F7 File Offset: 0x000002F7
		TypeConverter ICustomTypeDescriptor.GetConverter()
		{
			return null;
		}

		// Token: 0x0600065C RID: 1628 RVA: 0x000020F7 File Offset: 0x000002F7
		EventDescriptor ICustomTypeDescriptor.GetDefaultEvent()
		{
			return null;
		}

		// Token: 0x0600065D RID: 1629 RVA: 0x000020F7 File Offset: 0x000002F7
		PropertyDescriptor ICustomTypeDescriptor.GetDefaultProperty()
		{
			return null;
		}

		// Token: 0x0600065E RID: 1630 RVA: 0x000020F7 File Offset: 0x000002F7
		object ICustomTypeDescriptor.GetEditor(Type editorBaseType)
		{
			return null;
		}

		// Token: 0x0600065F RID: 1631 RVA: 0x0000C013 File Offset: 0x0000A213
		EventDescriptorCollection ICustomTypeDescriptor.GetEvents()
		{
			return new EventDescriptorCollection(null);
		}

		// Token: 0x06000660 RID: 1632 RVA: 0x0000C013 File Offset: 0x0000A213
		EventDescriptorCollection ICustomTypeDescriptor.GetEvents(Attribute[] attributes)
		{
			return new EventDescriptorCollection(null);
		}

		// Token: 0x06000661 RID: 1633 RVA: 0x0000C01B File Offset: 0x0000A21B
		PropertyDescriptorCollection ICustomTypeDescriptor.GetProperties()
		{
			return ((ICustomTypeDescriptor)this).GetProperties(null);
		}

		// Token: 0x06000662 RID: 1634 RVA: 0x0001D544 File Offset: 0x0001B744
		PropertyDescriptorCollection ICustomTypeDescriptor.GetProperties(Attribute[] attributes)
		{
			if (this._propsCollection == null)
			{
				PropertyDescriptor[] array = null;
				DataSet dataSet = this._dataViewManager.DataSet;
				if (dataSet != null)
				{
					int count = dataSet.Tables.Count;
					array = new PropertyDescriptor[count];
					for (int i = 0; i < count; i++)
					{
						array[i] = new DataTablePropertyDescriptor(dataSet.Tables[i]);
					}
				}
				this._propsCollection = new PropertyDescriptorCollection(array);
			}
			return this._propsCollection;
		}

		// Token: 0x06000663 RID: 1635 RVA: 0x00002050 File Offset: 0x00000250
		object ICustomTypeDescriptor.GetPropertyOwner(PropertyDescriptor pd)
		{
			return this;
		}

		// Token: 0x04000179 RID: 377
		private DataViewManager _dataViewManager;

		// Token: 0x0400017A RID: 378
		private PropertyDescriptorCollection _propsCollection;
	}
}
