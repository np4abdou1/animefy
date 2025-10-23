using System;
using System.ComponentModel;

namespace System.Data.Common
{
	/// <summary>Implements <see cref="T:System.Data.IDataRecord" /> and <see cref="T:System.ComponentModel.ICustomTypeDescriptor" />, and provides data binding support for <see cref="T:System.Data.Common.DbEnumerator" />.</summary>
	// Token: 0x020000E6 RID: 230
	public abstract class DbDataRecord : ICustomTypeDescriptor, IDataRecord
	{
		/// <summary>Indicates the number of fields within the current record. This property is read-only.</summary>
		/// <returns>The number of fields within the current record.</returns>
		/// <exception cref="T:System.NotSupportedException">Not connected to a data source to read from. </exception>
		// Token: 0x17000218 RID: 536
		// (get) Token: 0x06000FBE RID: 4030
		public abstract int FieldCount { get; }

		/// <summary>Indicates the value at the specified column in its native format given the column ordinal. This property is read-only.</summary>
		/// <param name="i">The column ordinal. </param>
		/// <returns>The value at the specified column in its native format.</returns>
		// Token: 0x17000219 RID: 537
		public abstract object this[int i]
		{
			get;
		}

		/// <summary>Returns the name of the back-end data type.</summary>
		/// <param name="i">The column ordinal. </param>
		/// <returns>The name of the back-end data type.</returns>
		// Token: 0x06000FC0 RID: 4032
		public abstract string GetDataTypeName(int i);

		/// <summary>Returns the <see cref="T:System.Type" /> that is the data type of the object.</summary>
		/// <param name="i">The column ordinal. </param>
		/// <returns>The <see cref="T:System.Type" /> that is the data type of the object.</returns>
		// Token: 0x06000FC1 RID: 4033
		public abstract Type GetFieldType(int i);

		/// <summary>Returns the name of the specified column.</summary>
		/// <param name="i">The column ordinal. </param>
		/// <returns>The name of the specified column.</returns>
		// Token: 0x06000FC2 RID: 4034
		public abstract string GetName(int i);

		/// <summary>Returns the value at the specified column in its native format.</summary>
		/// <param name="i">The column ordinal. </param>
		/// <returns>The value to return.</returns>
		// Token: 0x06000FC3 RID: 4035
		public abstract object GetValue(int i);

		/// <summary>Populates an array of objects with the column values of the current record.</summary>
		/// <param name="values">An array of <see cref="T:System.Object" /> to copy the attribute fields into. </param>
		/// <returns>The number of instances of <see cref="T:System.Object" /> in the array.</returns>
		// Token: 0x06000FC4 RID: 4036
		public abstract int GetValues(object[] values);

		/// <summary>Returns a collection of custom attributes for this instance of a component.</summary>
		/// <returns>An <see cref="T:System.ComponentModel.AttributeCollection" /> that contains the attributes for this object. </returns>
		// Token: 0x06000FC5 RID: 4037 RVA: 0x0000C00B File Offset: 0x0000A20B
		AttributeCollection ICustomTypeDescriptor.GetAttributes()
		{
			return new AttributeCollection(null);
		}

		/// <summary>Returns the class name of this instance of a component.</summary>
		/// <returns>The class name of the object, or <see langword="null" /> if the class does not have a name.</returns>
		// Token: 0x06000FC6 RID: 4038 RVA: 0x000020F7 File Offset: 0x000002F7
		string ICustomTypeDescriptor.GetClassName()
		{
			return null;
		}

		/// <summary>Returns the name of this instance of a component.</summary>
		/// <returns>The name of the object, or <see langword="null" /> if the object does not have a name.</returns>
		// Token: 0x06000FC7 RID: 4039 RVA: 0x000020F7 File Offset: 0x000002F7
		string ICustomTypeDescriptor.GetComponentName()
		{
			return null;
		}

		/// <summary>Returns a type converter for this instance of a component.</summary>
		/// <returns>A <see cref="T:System.ComponentModel.TypeConverter" /> that is the converter for this object, or <see langword="null" /> if there is no <see cref="T:System.ComponentModel.TypeConverter" /> for this object.</returns>
		// Token: 0x06000FC8 RID: 4040 RVA: 0x000020F7 File Offset: 0x000002F7
		TypeConverter ICustomTypeDescriptor.GetConverter()
		{
			return null;
		}

		/// <summary>Returns the default event for this instance of a component.</summary>
		/// <returns>An <see cref="T:System.ComponentModel.EventDescriptor" /> that represents the default event for this object, or <see langword="null" /> if this object does not have events.</returns>
		// Token: 0x06000FC9 RID: 4041 RVA: 0x000020F7 File Offset: 0x000002F7
		EventDescriptor ICustomTypeDescriptor.GetDefaultEvent()
		{
			return null;
		}

		/// <summary>Returns the default property for this instance of a component.</summary>
		/// <returns>A <see cref="T:System.ComponentModel.PropertyDescriptor" /> that represents the default property for this object, or <see langword="null" /> if this object does not have properties.</returns>
		// Token: 0x06000FCA RID: 4042 RVA: 0x000020F7 File Offset: 0x000002F7
		PropertyDescriptor ICustomTypeDescriptor.GetDefaultProperty()
		{
			return null;
		}

		/// <summary>Returns an editor of the specified type for this instance of a component.</summary>
		/// <param name="editorBaseType">A <see cref="T:System.Type" /> that represents the editor for this object.</param>
		/// <returns>An <see cref="T:System.Object" /> of the specified type that is the editor for this object, or <see langword="null" /> if the editor cannot be found.</returns>
		// Token: 0x06000FCB RID: 4043 RVA: 0x000020F7 File Offset: 0x000002F7
		object ICustomTypeDescriptor.GetEditor(Type editorBaseType)
		{
			return null;
		}

		/// <summary>Returns the events for this instance of a component.</summary>
		/// <returns>An <see cref="T:System.ComponentModel.EventDescriptorCollection" /> that represents the events for this component instance.</returns>
		// Token: 0x06000FCC RID: 4044 RVA: 0x0000C013 File Offset: 0x0000A213
		EventDescriptorCollection ICustomTypeDescriptor.GetEvents()
		{
			return new EventDescriptorCollection(null);
		}

		/// <summary>Returns the events for this instance of a component using the specified attribute array as a filter.</summary>
		/// <param name="attributes">An array of type <see cref="T:System.Attribute" /> that is used as a filter.</param>
		/// <returns>An <see cref="T:System.ComponentModel.EventDescriptorCollection" /> that represents the filtered events for this component instance.</returns>
		// Token: 0x06000FCD RID: 4045 RVA: 0x0000C013 File Offset: 0x0000A213
		EventDescriptorCollection ICustomTypeDescriptor.GetEvents(Attribute[] attributes)
		{
			return new EventDescriptorCollection(null);
		}

		/// <summary>Returns the properties for this instance of a component.</summary>
		/// <returns>A <see cref="T:System.ComponentModel.PropertyDescriptorCollection" /> that represents the properties for this component instance.</returns>
		// Token: 0x06000FCE RID: 4046 RVA: 0x0000C01B File Offset: 0x0000A21B
		PropertyDescriptorCollection ICustomTypeDescriptor.GetProperties()
		{
			return ((ICustomTypeDescriptor)this).GetProperties(null);
		}

		/// <summary>Returns the properties for this instance of a component using the attribute array as a filter.</summary>
		/// <param name="attributes">An array of type <see cref="T:System.Attribute" /> that is used as a filter.</param>
		/// <returns>A <see cref="T:System.ComponentModel.PropertyDescriptorCollection" /> that represents the filtered properties for this component instance.</returns>
		// Token: 0x06000FCF RID: 4047 RVA: 0x0004CCE4 File Offset: 0x0004AEE4
		PropertyDescriptorCollection ICustomTypeDescriptor.GetProperties(Attribute[] attributes)
		{
			return new PropertyDescriptorCollection(null);
		}

		/// <summary>Returns an object that contains the property described by the specified property descriptor.</summary>
		/// <param name="pd">A <see cref="T:System.ComponentModel.PropertyDescriptor" /> that represents the property whose owner is to be found.</param>
		/// <returns>An <see cref="T:System.Object" /> that represents the owner of the specified property.</returns>
		// Token: 0x06000FD0 RID: 4048 RVA: 0x00002050 File Offset: 0x00000250
		object ICustomTypeDescriptor.GetPropertyOwner(PropertyDescriptor pd)
		{
			return this;
		}
	}
}
