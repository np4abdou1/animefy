using System;
using System.ComponentModel;
using System.Data.ProviderBase;

namespace System.Data.Common
{
	// Token: 0x020000DC RID: 220
	internal sealed class DataRecordInternal : DbDataRecord, ICustomTypeDescriptor
	{
		// Token: 0x06000F15 RID: 3861 RVA: 0x0004B170 File Offset: 0x00049370
		internal DataRecordInternal(SchemaInfo[] schemaInfo, object[] values, PropertyDescriptorCollection descriptors, FieldNameLookup fieldNameLookup)
		{
			this._schemaInfo = schemaInfo;
			this._values = values;
			this._propertyDescriptors = descriptors;
			this._fieldNameLookup = fieldNameLookup;
		}

		// Token: 0x17000204 RID: 516
		// (get) Token: 0x06000F16 RID: 3862 RVA: 0x0004B195 File Offset: 0x00049395
		public override int FieldCount
		{
			get
			{
				return this._schemaInfo.Length;
			}
		}

		// Token: 0x06000F17 RID: 3863 RVA: 0x0004B1A0 File Offset: 0x000493A0
		public override int GetValues(object[] values)
		{
			if (values == null)
			{
				throw ADP.ArgumentNull("values");
			}
			int num = (values.Length < this._schemaInfo.Length) ? values.Length : this._schemaInfo.Length;
			for (int i = 0; i < num; i++)
			{
				values[i] = this._values[i];
			}
			return num;
		}

		// Token: 0x06000F18 RID: 3864 RVA: 0x0004B1EE File Offset: 0x000493EE
		public override string GetName(int i)
		{
			return this._schemaInfo[i].name;
		}

		// Token: 0x06000F19 RID: 3865 RVA: 0x0004B201 File Offset: 0x00049401
		public override object GetValue(int i)
		{
			return this._values[i];
		}

		// Token: 0x06000F1A RID: 3866 RVA: 0x0004B20B File Offset: 0x0004940B
		public override string GetDataTypeName(int i)
		{
			return this._schemaInfo[i].typeName;
		}

		// Token: 0x06000F1B RID: 3867 RVA: 0x0004B21E File Offset: 0x0004941E
		public override Type GetFieldType(int i)
		{
			return this._schemaInfo[i].type;
		}

		// Token: 0x17000205 RID: 517
		public override object this[int i]
		{
			get
			{
				return this.GetValue(i);
			}
		}

		// Token: 0x06000F1D RID: 3869 RVA: 0x0000C00B File Offset: 0x0000A20B
		AttributeCollection ICustomTypeDescriptor.GetAttributes()
		{
			return new AttributeCollection(null);
		}

		// Token: 0x06000F1E RID: 3870 RVA: 0x000020F7 File Offset: 0x000002F7
		string ICustomTypeDescriptor.GetClassName()
		{
			return null;
		}

		// Token: 0x06000F1F RID: 3871 RVA: 0x000020F7 File Offset: 0x000002F7
		string ICustomTypeDescriptor.GetComponentName()
		{
			return null;
		}

		// Token: 0x06000F20 RID: 3872 RVA: 0x000020F7 File Offset: 0x000002F7
		TypeConverter ICustomTypeDescriptor.GetConverter()
		{
			return null;
		}

		// Token: 0x06000F21 RID: 3873 RVA: 0x000020F7 File Offset: 0x000002F7
		EventDescriptor ICustomTypeDescriptor.GetDefaultEvent()
		{
			return null;
		}

		// Token: 0x06000F22 RID: 3874 RVA: 0x000020F7 File Offset: 0x000002F7
		PropertyDescriptor ICustomTypeDescriptor.GetDefaultProperty()
		{
			return null;
		}

		// Token: 0x06000F23 RID: 3875 RVA: 0x000020F7 File Offset: 0x000002F7
		object ICustomTypeDescriptor.GetEditor(Type editorBaseType)
		{
			return null;
		}

		// Token: 0x06000F24 RID: 3876 RVA: 0x0000C013 File Offset: 0x0000A213
		EventDescriptorCollection ICustomTypeDescriptor.GetEvents()
		{
			return new EventDescriptorCollection(null);
		}

		// Token: 0x06000F25 RID: 3877 RVA: 0x0000C013 File Offset: 0x0000A213
		EventDescriptorCollection ICustomTypeDescriptor.GetEvents(Attribute[] attributes)
		{
			return new EventDescriptorCollection(null);
		}

		// Token: 0x06000F26 RID: 3878 RVA: 0x0000C01B File Offset: 0x0000A21B
		PropertyDescriptorCollection ICustomTypeDescriptor.GetProperties()
		{
			return ((ICustomTypeDescriptor)this).GetProperties(null);
		}

		// Token: 0x06000F27 RID: 3879 RVA: 0x0004B23A File Offset: 0x0004943A
		PropertyDescriptorCollection ICustomTypeDescriptor.GetProperties(Attribute[] attributes)
		{
			if (this._propertyDescriptors == null)
			{
				this._propertyDescriptors = new PropertyDescriptorCollection(null);
			}
			return this._propertyDescriptors;
		}

		// Token: 0x06000F28 RID: 3880 RVA: 0x00002050 File Offset: 0x00000250
		object ICustomTypeDescriptor.GetPropertyOwner(PropertyDescriptor pd)
		{
			return this;
		}

		// Token: 0x040004B9 RID: 1209
		private SchemaInfo[] _schemaInfo;

		// Token: 0x040004BA RID: 1210
		private object[] _values;

		// Token: 0x040004BB RID: 1211
		private PropertyDescriptorCollection _propertyDescriptors;

		// Token: 0x040004BC RID: 1212
		private FieldNameLookup _fieldNameLookup;
	}
}
