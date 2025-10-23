using System;
using System.Collections;

namespace System.ComponentModel
{
	/// <summary>Provides an abstraction of a property on a class.</summary>
	// Token: 0x0200027A RID: 634
	public abstract class PropertyDescriptor : MemberDescriptor
	{
		/// <summary>Initializes a new instance of the <see cref="T:System.ComponentModel.PropertyDescriptor" /> class with the specified name and attributes.</summary>
		/// <param name="name">The name of the property. </param>
		/// <param name="attrs">An array of type <see cref="T:System.Attribute" /> that contains the property attributes. </param>
		// Token: 0x060010DD RID: 4317 RVA: 0x0004FB19 File Offset: 0x0004DD19
		protected PropertyDescriptor(string name, Attribute[] attrs) : base(name, attrs)
		{
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.ComponentModel.PropertyDescriptor" /> class with the name in the specified <see cref="T:System.ComponentModel.MemberDescriptor" /> and the attributes in both the <see cref="T:System.ComponentModel.MemberDescriptor" /> and the <see cref="T:System.Attribute" /> array.</summary>
		/// <param name="descr">A <see cref="T:System.ComponentModel.MemberDescriptor" /> containing the name of the member and its attributes. </param>
		/// <param name="attrs">An <see cref="T:System.Attribute" /> array containing the attributes you want to associate with the property. </param>
		// Token: 0x060010DE RID: 4318 RVA: 0x0005092A File Offset: 0x0004EB2A
		protected PropertyDescriptor(MemberDescriptor descr, Attribute[] attrs) : base(descr, attrs)
		{
		}

		/// <summary>When overridden in a derived class, gets the type of the component this property is bound to.</summary>
		/// <returns>A <see cref="T:System.Type" /> that represents the type of component this property is bound to. When the <see cref="M:System.ComponentModel.PropertyDescriptor.GetValue(System.Object)" /> or <see cref="M:System.ComponentModel.PropertyDescriptor.SetValue(System.Object,System.Object)" /> methods are invoked, the object specified might be an instance of this type.</returns>
		// Token: 0x1700036A RID: 874
		// (get) Token: 0x060010DF RID: 4319
		public abstract Type ComponentType { get; }

		/// <summary>Gets the type converter for this property.</summary>
		/// <returns>A <see cref="T:System.ComponentModel.TypeConverter" /> that is used to convert the <see cref="T:System.Type" /> of this property.</returns>
		// Token: 0x1700036B RID: 875
		// (get) Token: 0x060010E0 RID: 4320 RVA: 0x00050934 File Offset: 0x0004EB34
		public virtual TypeConverter Converter
		{
			get
			{
				AttributeCollection attributes = this.Attributes;
				if (this._converter == null)
				{
					TypeConverterAttribute typeConverterAttribute = (TypeConverterAttribute)attributes[typeof(TypeConverterAttribute)];
					if (typeConverterAttribute.ConverterTypeName != null && typeConverterAttribute.ConverterTypeName.Length > 0)
					{
						Type typeFromName = this.GetTypeFromName(typeConverterAttribute.ConverterTypeName);
						if (typeFromName != null && typeof(TypeConverter).IsAssignableFrom(typeFromName))
						{
							this._converter = (TypeConverter)this.CreateInstance(typeFromName);
						}
					}
					if (this._converter == null)
					{
						this._converter = TypeDescriptor.GetConverter(this.PropertyType);
					}
				}
				return this._converter;
			}
		}

		/// <summary>When overridden in a derived class, gets a value indicating whether this property is read-only.</summary>
		/// <returns>
		///     <see langword="true" /> if the property is read-only; otherwise, <see langword="false" />.</returns>
		// Token: 0x1700036C RID: 876
		// (get) Token: 0x060010E1 RID: 4321
		public abstract bool IsReadOnly { get; }

		/// <summary>When overridden in a derived class, gets the type of the property.</summary>
		/// <returns>A <see cref="T:System.Type" /> that represents the type of the property.</returns>
		// Token: 0x1700036D RID: 877
		// (get) Token: 0x060010E2 RID: 4322
		public abstract Type PropertyType { get; }

		/// <summary>When overridden in a derived class, returns whether resetting an object changes its value.</summary>
		/// <param name="component">The component to test for reset capability. </param>
		/// <returns>
		///     <see langword="true" /> if resetting the component changes its value; otherwise, <see langword="false" />.</returns>
		// Token: 0x060010E3 RID: 4323
		public abstract bool CanResetValue(object component);

		/// <summary>Compares this to another object to see if they are equivalent.</summary>
		/// <param name="obj">The object to compare to this <see cref="T:System.ComponentModel.PropertyDescriptor" />. </param>
		/// <returns>
		///     <see langword="true" /> if the values are equivalent; otherwise, <see langword="false" />.</returns>
		// Token: 0x060010E4 RID: 4324 RVA: 0x000509D8 File Offset: 0x0004EBD8
		public override bool Equals(object obj)
		{
			try
			{
				if (obj == this)
				{
					return true;
				}
				if (obj == null)
				{
					return false;
				}
				PropertyDescriptor propertyDescriptor = obj as PropertyDescriptor;
				if (propertyDescriptor != null && propertyDescriptor.NameHashCode == this.NameHashCode && propertyDescriptor.PropertyType == this.PropertyType && propertyDescriptor.Name.Equals(this.Name))
				{
					return true;
				}
			}
			catch
			{
			}
			return false;
		}

		/// <summary>Creates an instance of the specified type.</summary>
		/// <param name="type">A <see cref="T:System.Type" /> that represents the type to create. </param>
		/// <returns>A new instance of the type.</returns>
		// Token: 0x060010E5 RID: 4325 RVA: 0x00050A50 File Offset: 0x0004EC50
		protected object CreateInstance(Type type)
		{
			Type[] array = new Type[]
			{
				typeof(Type)
			};
			if (type.GetConstructor(array) != null)
			{
				return TypeDescriptor.CreateInstance(null, type, array, new object[]
				{
					this.PropertyType
				});
			}
			return TypeDescriptor.CreateInstance(null, type, null, null);
		}

		/// <summary>Adds the attributes of the <see cref="T:System.ComponentModel.PropertyDescriptor" /> to the specified list of attributes in the parent class.</summary>
		/// <param name="attributeList">An <see cref="T:System.Collections.IList" /> that lists the attributes in the parent class. Initially, this is empty.</param>
		// Token: 0x060010E6 RID: 4326 RVA: 0x00050AA1 File Offset: 0x0004ECA1
		protected override void FillAttributes(IList attributeList)
		{
			this._converter = null;
			this._editors = null;
			this._editorTypes = null;
			this._editorCount = 0;
			base.FillAttributes(attributeList);
		}

		/// <summary>Returns the hash code for this object.</summary>
		/// <returns>The hash code for this object.</returns>
		// Token: 0x060010E7 RID: 4327 RVA: 0x00050AC6 File Offset: 0x0004ECC6
		public override int GetHashCode()
		{
			return this.NameHashCode ^ this.PropertyType.GetHashCode();
		}

		/// <summary>This method returns the object that should be used during invocation of members.</summary>
		/// <param name="type">The <see cref="T:System.Type" /> of the invocation target.</param>
		/// <param name="instance">The potential invocation target.</param>
		/// <returns>The <see cref="T:System.Object" /> that should be used during invocation of members.</returns>
		// Token: 0x060010E8 RID: 4328 RVA: 0x00050ADC File Offset: 0x0004ECDC
		protected override object GetInvocationTarget(Type type, object instance)
		{
			object obj = base.GetInvocationTarget(type, instance);
			ICustomTypeDescriptor customTypeDescriptor = obj as ICustomTypeDescriptor;
			if (customTypeDescriptor != null)
			{
				obj = customTypeDescriptor.GetPropertyOwner(this);
			}
			return obj;
		}

		/// <summary>Returns a type using its name.</summary>
		/// <param name="typeName">The assembly-qualified name of the type to retrieve. </param>
		/// <returns>A <see cref="T:System.Type" /> that matches the given type name, or <see langword="null" /> if a match cannot be found.</returns>
		// Token: 0x060010E9 RID: 4329 RVA: 0x00050B08 File Offset: 0x0004ED08
		protected Type GetTypeFromName(string typeName)
		{
			if (typeName == null || typeName.Length == 0)
			{
				return null;
			}
			Type type = Type.GetType(typeName);
			Type type2 = null;
			if (this.ComponentType != null && (type == null || this.ComponentType.Assembly.FullName.Equals(type.Assembly.FullName)))
			{
				int num = typeName.IndexOf(',');
				if (num != -1)
				{
					typeName = typeName.Substring(0, num);
				}
				type2 = this.ComponentType.Assembly.GetType(typeName);
			}
			return type2 ?? type;
		}

		/// <summary>When overridden in a derived class, gets the current value of the property on a component.</summary>
		/// <param name="component">The component with the property for which to retrieve the value. </param>
		/// <returns>The value of a property for a given component.</returns>
		// Token: 0x060010EA RID: 4330
		public abstract object GetValue(object component);

		/// <summary>Raises the ValueChanged event that you implemented.</summary>
		/// <param name="component">The object that raises the event. </param>
		/// <param name="e">An <see cref="T:System.EventArgs" /> that contains the event data. </param>
		// Token: 0x060010EB RID: 4331 RVA: 0x00050B93 File Offset: 0x0004ED93
		protected virtual void OnValueChanged(object component, EventArgs e)
		{
			if (component != null)
			{
				Hashtable valueChangedHandlers = this._valueChangedHandlers;
				EventHandler eventHandler = (EventHandler)((valueChangedHandlers != null) ? valueChangedHandlers[component] : null);
				if (eventHandler == null)
				{
					return;
				}
				eventHandler(component, e);
			}
		}

		/// <summary>When overridden in a derived class, resets the value for this property of the component to the default value.</summary>
		/// <param name="component">The component with the property value that is to be reset to the default value. </param>
		// Token: 0x060010EC RID: 4332
		public abstract void ResetValue(object component);

		/// <summary>When overridden in a derived class, sets the value of the component to a different value.</summary>
		/// <param name="component">The component with the property value that is to be set. </param>
		/// <param name="value">The new value. </param>
		// Token: 0x060010ED RID: 4333
		public abstract void SetValue(object component, object value);

		/// <summary>When overridden in a derived class, determines a value indicating whether the value of this property needs to be persisted.</summary>
		/// <param name="component">The component with the property to be examined for persistence. </param>
		/// <returns>
		///     <see langword="true" /> if the property should be persisted; otherwise, <see langword="false" />.</returns>
		// Token: 0x060010EE RID: 4334
		public abstract bool ShouldSerializeValue(object component);

		// Token: 0x04000C77 RID: 3191
		private TypeConverter _converter;

		// Token: 0x04000C78 RID: 3192
		private Hashtable _valueChangedHandlers;

		// Token: 0x04000C79 RID: 3193
		private object[] _editors;

		// Token: 0x04000C7A RID: 3194
		private Type[] _editorTypes;

		// Token: 0x04000C7B RID: 3195
		private int _editorCount;
	}
}
