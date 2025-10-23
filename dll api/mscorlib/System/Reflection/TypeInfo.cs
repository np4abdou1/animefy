using System;
using System.Collections.Generic;

namespace System.Reflection
{
	/// <summary>Represents type declarations for class types, interface types, array types, value types, enumeration types, type parameters, generic type definitions, and open or closed constructed generic types. </summary>
	// Token: 0x020004C5 RID: 1221
	public abstract class TypeInfo : Type, IReflectableType
	{
		/// <summary>Returns a representation of the current type as a <see cref="T:System.Reflection.TypeInfo" /> object.</summary>
		/// <returns>A reference to the current type.</returns>
		// Token: 0x06002288 RID: 8840 RVA: 0x0000245A File Offset: 0x0000065A
		TypeInfo IReflectableType.GetTypeInfo()
		{
			return this;
		}

		/// <summary>Returns the current type as a <see cref="T:System.Type" /> object.</summary>
		/// <returns>The current type.</returns>
		// Token: 0x06002289 RID: 8841 RVA: 0x0000245A File Offset: 0x0000065A
		public virtual Type AsType()
		{
			return this;
		}

		/// <summary>Returns an object that represents the specified public field declared by the current type.</summary>
		/// <param name="name">The name of the field.</param>
		/// <returns>An object that represents the specified field, if found; otherwise, <see langword="null" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="name" /> is <see langword="null" />. </exception>
		// Token: 0x0600228A RID: 8842 RVA: 0x0008B319 File Offset: 0x00089519
		public virtual FieldInfo GetDeclaredField(string name)
		{
			return this.GetField(name, BindingFlags.DeclaredOnly | BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic);
		}

		/// <summary>Returns an object that represents the specified public property declared by the current type.</summary>
		/// <param name="name">The name of the property.</param>
		/// <returns>An object that represents the specified property, if found; otherwise, <see langword="null" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="name" /> is <see langword="null" />. </exception>
		// Token: 0x0600228B RID: 8843 RVA: 0x0008B324 File Offset: 0x00089524
		public virtual PropertyInfo GetDeclaredProperty(string name)
		{
			return base.GetProperty(name, BindingFlags.DeclaredOnly | BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic);
		}

		/// <summary>Gets a collection of the properties defined by the current type. </summary>
		/// <returns>A collection of the properties defined by the current type.</returns>
		// Token: 0x170004A3 RID: 1187
		// (get) Token: 0x0600228C RID: 8844 RVA: 0x0008B32F File Offset: 0x0008952F
		public virtual IEnumerable<PropertyInfo> DeclaredProperties
		{
			get
			{
				return this.GetProperties(BindingFlags.DeclaredOnly | BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic);
			}
		}

		/// <summary>Gets a collection of the interfaces implemented by the current type.</summary>
		/// <returns>A collection of the interfaces implemented by the current type.</returns>
		// Token: 0x170004A4 RID: 1188
		// (get) Token: 0x0600228D RID: 8845 RVA: 0x0008B339 File Offset: 0x00089539
		public virtual IEnumerable<Type> ImplementedInterfaces
		{
			get
			{
				return this.GetInterfaces();
			}
		}

		/// <summary>Returns a value that indicates whether the specified type can be assigned to the current type.</summary>
		/// <param name="typeInfo">The type to check.</param>
		/// <returns>
		///     <see langword="true" /> if the specified type can be assigned to this type; otherwise, <see langword="false" />.</returns>
		// Token: 0x0600228E RID: 8846 RVA: 0x0008B344 File Offset: 0x00089544
		public virtual bool IsAssignableFrom(TypeInfo typeInfo)
		{
			if (typeInfo == null)
			{
				return false;
			}
			if (this == typeInfo)
			{
				return true;
			}
			if (typeInfo.IsSubclassOf(this))
			{
				return true;
			}
			if (base.IsInterface)
			{
				return typeInfo.ImplementInterface(this);
			}
			if (this.IsGenericParameter)
			{
				Type[] genericParameterConstraints = this.GetGenericParameterConstraints();
				for (int i = 0; i < genericParameterConstraints.Length; i++)
				{
					if (!genericParameterConstraints[i].IsAssignableFrom(typeInfo))
					{
						return false;
					}
				}
				return true;
			}
			return false;
		}
	}
}
