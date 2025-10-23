﻿using System;

namespace System.ComponentModel
{
	/// <summary>Provides a simple default implementation of the <see cref="T:System.ComponentModel.ICustomTypeDescriptor" /> interface.</summary>
	// Token: 0x02000257 RID: 599
	public abstract class CustomTypeDescriptor : ICustomTypeDescriptor
	{
		/// <summary>Returns a collection of custom attributes for the type represented by this type descriptor.</summary>
		/// <returns>An <see cref="T:System.ComponentModel.AttributeCollection" /> containing the attributes for the type. The default is <see cref="F:System.ComponentModel.AttributeCollection.Empty" />.</returns>
		// Token: 0x06001004 RID: 4100 RVA: 0x0004F48F File Offset: 0x0004D68F
		public virtual AttributeCollection GetAttributes()
		{
			if (this._parent != null)
			{
				return this._parent.GetAttributes();
			}
			return AttributeCollection.Empty;
		}

		/// <summary>Returns the fully qualified name of the class represented by this type descriptor.</summary>
		/// <returns>A <see cref="T:System.String" /> containing the fully qualified class name of the type this type descriptor is describing. The default is <see langword="null" />.</returns>
		// Token: 0x06001005 RID: 4101 RVA: 0x0004F4AA File Offset: 0x0004D6AA
		public virtual string GetClassName()
		{
			ICustomTypeDescriptor parent = this._parent;
			if (parent == null)
			{
				return null;
			}
			return parent.GetClassName();
		}

		/// <summary>Returns the name of the class represented by this type descriptor.</summary>
		/// <returns>A <see cref="T:System.String" /> containing the name of the component instance this type descriptor is describing. The default is <see langword="null" />.</returns>
		// Token: 0x06001006 RID: 4102 RVA: 0x0004F4BD File Offset: 0x0004D6BD
		public virtual string GetComponentName()
		{
			ICustomTypeDescriptor parent = this._parent;
			if (parent == null)
			{
				return null;
			}
			return parent.GetComponentName();
		}

		/// <summary>Returns a type converter for the type represented by this type descriptor.</summary>
		/// <returns>A <see cref="T:System.ComponentModel.TypeConverter" /> for the type represented by this type descriptor. The default is a newly created <see cref="T:System.ComponentModel.TypeConverter" />.</returns>
		// Token: 0x06001007 RID: 4103 RVA: 0x0004F4D0 File Offset: 0x0004D6D0
		public virtual TypeConverter GetConverter()
		{
			if (this._parent != null)
			{
				return this._parent.GetConverter();
			}
			return new TypeConverter();
		}

		/// <summary>Returns the event descriptor for the default event of the object represented by this type descriptor.</summary>
		/// <returns>The <see cref="T:System.ComponentModel.EventDescriptor" /> for the default event on the object represented by this type descriptor. The default is <see langword="null" />.</returns>
		// Token: 0x06001008 RID: 4104 RVA: 0x0004F4EB File Offset: 0x0004D6EB
		public virtual EventDescriptor GetDefaultEvent()
		{
			ICustomTypeDescriptor parent = this._parent;
			if (parent == null)
			{
				return null;
			}
			return parent.GetDefaultEvent();
		}

		/// <summary>Returns the property descriptor for the default property of the object represented by this type descriptor.</summary>
		/// <returns>A <see cref="T:System.ComponentModel.PropertyDescriptor" /> for the default property on the object represented by this type descriptor. The default is <see langword="null" />.</returns>
		// Token: 0x06001009 RID: 4105 RVA: 0x0004F4FE File Offset: 0x0004D6FE
		public virtual PropertyDescriptor GetDefaultProperty()
		{
			ICustomTypeDescriptor parent = this._parent;
			if (parent == null)
			{
				return null;
			}
			return parent.GetDefaultProperty();
		}

		/// <summary>Returns an editor of the specified type that is to be associated with the class represented by this type descriptor.</summary>
		/// <param name="editorBaseType">The base type of the editor to retrieve.</param>
		/// <returns>An editor of the given type that is to be associated with the class represented by this type descriptor. The default is <see langword="null" />.</returns>
		// Token: 0x0600100A RID: 4106 RVA: 0x0004F511 File Offset: 0x0004D711
		public virtual object GetEditor(Type editorBaseType)
		{
			ICustomTypeDescriptor parent = this._parent;
			if (parent == null)
			{
				return null;
			}
			return parent.GetEditor(editorBaseType);
		}

		/// <summary>Returns a collection of event descriptors for the object represented by this type descriptor.</summary>
		/// <returns>An <see cref="T:System.ComponentModel.EventDescriptorCollection" /> containing the event descriptors for the object represented by this type descriptor. The default is <see cref="F:System.ComponentModel.EventDescriptorCollection.Empty" />.</returns>
		// Token: 0x0600100B RID: 4107 RVA: 0x0004F525 File Offset: 0x0004D725
		public virtual EventDescriptorCollection GetEvents()
		{
			if (this._parent != null)
			{
				return this._parent.GetEvents();
			}
			return EventDescriptorCollection.Empty;
		}

		/// <summary>Returns a filtered collection of event descriptors for the object represented by this type descriptor.</summary>
		/// <param name="attributes">An array of attributes to use as a filter. This can be <see langword="null" />.</param>
		/// <returns>An <see cref="T:System.ComponentModel.EventDescriptorCollection" /> containing the event descriptions for the object represented by this type descriptor. The default is <see cref="F:System.ComponentModel.EventDescriptorCollection.Empty" />.</returns>
		// Token: 0x0600100C RID: 4108 RVA: 0x0004F540 File Offset: 0x0004D740
		public virtual EventDescriptorCollection GetEvents(Attribute[] attributes)
		{
			if (this._parent != null)
			{
				return this._parent.GetEvents(attributes);
			}
			return EventDescriptorCollection.Empty;
		}

		/// <summary>Returns a collection of property descriptors for the object represented by this type descriptor.</summary>
		/// <returns>A <see cref="T:System.ComponentModel.PropertyDescriptorCollection" /> containing the property descriptions for the object represented by this type descriptor. The default is <see cref="F:System.ComponentModel.PropertyDescriptorCollection.Empty" />.</returns>
		// Token: 0x0600100D RID: 4109 RVA: 0x0004F55C File Offset: 0x0004D75C
		public virtual PropertyDescriptorCollection GetProperties()
		{
			if (this._parent != null)
			{
				return this._parent.GetProperties();
			}
			return PropertyDescriptorCollection.Empty;
		}

		/// <summary>Returns a filtered collection of property descriptors for the object represented by this type descriptor.</summary>
		/// <param name="attributes">An array of attributes to use as a filter. This can be <see langword="null" />.</param>
		/// <returns>A <see cref="T:System.ComponentModel.PropertyDescriptorCollection" /> containing the property descriptions for the object represented by this type descriptor. The default is <see cref="F:System.ComponentModel.PropertyDescriptorCollection.Empty" />.</returns>
		// Token: 0x0600100E RID: 4110 RVA: 0x0004F577 File Offset: 0x0004D777
		public virtual PropertyDescriptorCollection GetProperties(Attribute[] attributes)
		{
			if (this._parent != null)
			{
				return this._parent.GetProperties(attributes);
			}
			return PropertyDescriptorCollection.Empty;
		}

		/// <summary>Returns an object that contains the property described by the specified property descriptor.</summary>
		/// <param name="pd">The property descriptor for which to retrieve the owning object.</param>
		/// <returns>An <see cref="T:System.Object" /> that owns the given property specified by the type descriptor. The default is <see langword="null" />.</returns>
		// Token: 0x0600100F RID: 4111 RVA: 0x0004F593 File Offset: 0x0004D793
		public virtual object GetPropertyOwner(PropertyDescriptor pd)
		{
			ICustomTypeDescriptor parent = this._parent;
			if (parent == null)
			{
				return null;
			}
			return parent.GetPropertyOwner(pd);
		}

		// Token: 0x04000C3D RID: 3133
		private readonly ICustomTypeDescriptor _parent;
	}
}
