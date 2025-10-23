using System;
using System.Collections;
using System.Reflection;

namespace System.ComponentModel
{
	/// <summary>Represents a collection of attributes.</summary>
	// Token: 0x0200024A RID: 586
	public class AttributeCollection : ICollection, IEnumerable
	{
		/// <summary>Initializes a new instance of the <see cref="T:System.ComponentModel.AttributeCollection" /> class.</summary>
		/// <param name="attributes">An array of type <see cref="T:System.Attribute" /> that provides the attributes for this collection. </param>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="attributes" /> is <see langword="null" />.</exception>
		// Token: 0x06000FC7 RID: 4039 RVA: 0x0004D898 File Offset: 0x0004BA98
		public AttributeCollection(params Attribute[] attributes)
		{
			this._attributes = (attributes ?? Array.Empty<Attribute>());
			for (int i = 0; i < this._attributes.Length; i++)
			{
				if (this._attributes[i] == null)
				{
					throw new ArgumentNullException("attributes");
				}
			}
		}

		/// <summary>Gets the attribute collection.</summary>
		/// <returns>The attribute collection.</returns>
		// Token: 0x17000329 RID: 809
		// (get) Token: 0x06000FC8 RID: 4040 RVA: 0x0004D8E3 File Offset: 0x0004BAE3
		protected virtual Attribute[] Attributes
		{
			get
			{
				return this._attributes;
			}
		}

		/// <summary>Gets the number of attributes.</summary>
		/// <returns>The number of attributes.</returns>
		// Token: 0x1700032A RID: 810
		// (get) Token: 0x06000FC9 RID: 4041 RVA: 0x0004D8EB File Offset: 0x0004BAEB
		public int Count
		{
			get
			{
				return this.Attributes.Length;
			}
		}

		/// <summary>Gets the attribute with the specified type.</summary>
		/// <param name="attributeType">The <see cref="T:System.Type" /> of the <see cref="T:System.Attribute" /> to get from the collection. </param>
		/// <returns>The <see cref="T:System.Attribute" /> with the specified type or, if the attribute does not exist, the default value for the attribute type.</returns>
		// Token: 0x1700032B RID: 811
		public virtual Attribute this[Type attributeType]
		{
			get
			{
				object obj = AttributeCollection.s_internalSyncObject;
				Attribute defaultAttribute;
				lock (obj)
				{
					if (this._foundAttributeTypes == null)
					{
						this._foundAttributeTypes = new AttributeCollection.AttributeEntry[5];
					}
					int i = 0;
					while (i < 5)
					{
						if (this._foundAttributeTypes[i].type == attributeType)
						{
							int index = this._foundAttributeTypes[i].index;
							if (index != -1)
							{
								return this.Attributes[index];
							}
							return this.GetDefaultAttribute(attributeType);
						}
						else
						{
							if (this._foundAttributeTypes[i].type == null)
							{
								break;
							}
							i++;
						}
					}
					int index2 = this._index;
					this._index = index2 + 1;
					i = index2;
					if (this._index >= 5)
					{
						this._index = 0;
					}
					this._foundAttributeTypes[i].type = attributeType;
					int num = this.Attributes.Length;
					for (int j = 0; j < num; j++)
					{
						Attribute attribute = this.Attributes[j];
						if (attribute.GetType() == attributeType)
						{
							this._foundAttributeTypes[i].index = j;
							return attribute;
						}
					}
					for (int k = 0; k < num; k++)
					{
						Attribute attribute2 = this.Attributes[k];
						if (attributeType.IsInstanceOfType(attribute2))
						{
							this._foundAttributeTypes[i].index = k;
							return attribute2;
						}
					}
					this._foundAttributeTypes[i].index = -1;
					defaultAttribute = this.GetDefaultAttribute(attributeType);
				}
				return defaultAttribute;
			}
		}

		/// <summary>Determines whether this collection of attributes has the specified attribute.</summary>
		/// <param name="attribute">An <see cref="T:System.Attribute" /> to find in the collection. </param>
		/// <returns>
		///     <see langword="true" /> if the collection contains the attribute or is the default attribute for the type of attribute; otherwise, <see langword="false" />.</returns>
		// Token: 0x06000FCB RID: 4043 RVA: 0x0004DAA4 File Offset: 0x0004BCA4
		public bool Contains(Attribute attribute)
		{
			Attribute attribute2 = this[attribute.GetType()];
			return attribute2 != null && attribute2.Equals(attribute);
		}

		/// <summary>Returns the default <see cref="T:System.Attribute" /> of a given <see cref="T:System.Type" />.</summary>
		/// <param name="attributeType">The <see cref="T:System.Type" /> of the attribute to retrieve. </param>
		/// <returns>The default <see cref="T:System.Attribute" /> of a given <paramref name="attributeType" />.</returns>
		// Token: 0x06000FCC RID: 4044 RVA: 0x0004DACC File Offset: 0x0004BCCC
		protected Attribute GetDefaultAttribute(Type attributeType)
		{
			object obj = AttributeCollection.s_internalSyncObject;
			Attribute result;
			lock (obj)
			{
				if (AttributeCollection.s_defaultAttributes == null)
				{
					AttributeCollection.s_defaultAttributes = new Hashtable();
				}
				if (AttributeCollection.s_defaultAttributes.ContainsKey(attributeType))
				{
					result = (Attribute)AttributeCollection.s_defaultAttributes[attributeType];
				}
				else
				{
					Attribute attribute = null;
					Type reflectionType = TypeDescriptor.GetReflectionType(attributeType);
					FieldInfo field = reflectionType.GetField("Default", BindingFlags.Static | BindingFlags.Public | BindingFlags.GetField);
					if (field != null && field.IsStatic)
					{
						attribute = (Attribute)field.GetValue(null);
					}
					else
					{
						ConstructorInfo constructor = reflectionType.UnderlyingSystemType.GetConstructor(Array.Empty<Type>());
						if (constructor != null)
						{
							attribute = (Attribute)constructor.Invoke(Array.Empty<object>());
							if (!attribute.IsDefaultAttribute())
							{
								attribute = null;
							}
						}
					}
					AttributeCollection.s_defaultAttributes[attributeType] = attribute;
					result = attribute;
				}
			}
			return result;
		}

		/// <summary>Gets an enumerator for this collection.</summary>
		/// <returns>An enumerator of type <see cref="T:System.Collections.IEnumerator" />.</returns>
		// Token: 0x06000FCD RID: 4045 RVA: 0x0004DBC4 File Offset: 0x0004BDC4
		public IEnumerator GetEnumerator()
		{
			return this.Attributes.GetEnumerator();
		}

		/// <summary>Gets a value indicating whether access to the collection is synchronized (thread-safe).</summary>
		/// <returns>
		///     <see langword="true" /> if access to the collection is synchronized (thread-safe); otherwise, <see langword="false" />.</returns>
		// Token: 0x1700032C RID: 812
		// (get) Token: 0x06000FCE RID: 4046 RVA: 0x000023F6 File Offset: 0x000005F6
		bool ICollection.IsSynchronized
		{
			get
			{
				return false;
			}
		}

		/// <summary>Gets an object that can be used to synchronize access to the collection.</summary>
		/// <returns>An object that can be used to synchronize access to the collection.</returns>
		// Token: 0x1700032D RID: 813
		// (get) Token: 0x06000FCF RID: 4047 RVA: 0x000022FE File Offset: 0x000004FE
		object ICollection.SyncRoot
		{
			get
			{
				return null;
			}
		}

		/// <summary>Gets the number of elements contained in the collection.</summary>
		/// <returns>The number of elements contained in the collection.</returns>
		// Token: 0x1700032E RID: 814
		// (get) Token: 0x06000FD0 RID: 4048 RVA: 0x0004DBD1 File Offset: 0x0004BDD1
		int ICollection.Count
		{
			get
			{
				return this.Count;
			}
		}

		/// <summary>Returns an <see cref="T:System.Collections.IEnumerator" /> for the <see cref="T:System.Collections.IDictionary" />. </summary>
		/// <returns>An <see cref="T:System.Collections.IEnumerator" /> for the <see cref="T:System.Collections.IDictionary" />.</returns>
		// Token: 0x06000FD1 RID: 4049 RVA: 0x0004DBD9 File Offset: 0x0004BDD9
		IEnumerator IEnumerable.GetEnumerator()
		{
			return this.GetEnumerator();
		}

		/// <summary>Copies the collection to an array, starting at the specified index.</summary>
		/// <param name="array">The <see cref="T:System.Array" /> to copy the collection to. </param>
		/// <param name="index">The index to start from. </param>
		// Token: 0x06000FD2 RID: 4050 RVA: 0x0004DBE1 File Offset: 0x0004BDE1
		public void CopyTo(Array array, int index)
		{
			Array.Copy(this.Attributes, 0, array, index, this.Attributes.Length);
		}

		/// <summary>Specifies an empty collection that you can use, rather than creating a new one. This field is read-only.</summary>
		// Token: 0x04000C29 RID: 3113
		public static readonly AttributeCollection Empty = new AttributeCollection(null);

		// Token: 0x04000C2A RID: 3114
		private static Hashtable s_defaultAttributes;

		// Token: 0x04000C2B RID: 3115
		private readonly Attribute[] _attributes;

		// Token: 0x04000C2C RID: 3116
		private static readonly object s_internalSyncObject = new object();

		// Token: 0x04000C2D RID: 3117
		private AttributeCollection.AttributeEntry[] _foundAttributeTypes;

		// Token: 0x04000C2E RID: 3118
		private int _index;

		// Token: 0x0200024B RID: 587
		private struct AttributeEntry
		{
			// Token: 0x04000C2F RID: 3119
			public Type type;

			// Token: 0x04000C30 RID: 3120
			public int index;
		}
	}
}
