using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Threading;

namespace System
{
	/// <summary>Represents type declarations: class types, interface types, array types, value types, enumeration types, type parameters, generic type definitions, and open or closed constructed generic types.To browse the .NET Framework source code for this type, see the Reference Source.</summary>
	// Token: 0x0200010E RID: 270
	[Serializable]
	public abstract class Type : MemberInfo
	{
		/// <summary>Returns a value that indicates whether the specified value exists in the current enumeration type.</summary>
		/// <param name="value">The value to be tested.</param>
		/// <returns>
		///     <see langword="true" /> if the specified value is a member of the current enumeration type; otherwise, <see langword="false" />.</returns>
		/// <exception cref="T:System.ArgumentException">The current type is not an enumeration.</exception>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="value" /> is <see langword="null" />.</exception>
		/// <exception cref="T:System.InvalidOperationException">
		///         <paramref name="value" /> is of a type that cannot be the underlying type of an enumeration.</exception>
		// Token: 0x060009B6 RID: 2486 RVA: 0x0002A3A8 File Offset: 0x000285A8
		public virtual bool IsEnumDefined(object value)
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (!this.IsEnum)
			{
				throw new ArgumentException("Type provided must be an Enum.", "enumType");
			}
			Type type = value.GetType();
			if (type.IsEnum)
			{
				if (!type.IsEquivalentTo(this))
				{
					throw new ArgumentException(SR.Format("Object must be the same type as the enum. The type passed in was '{0}'; the enum type was '{1}'.", type.ToString(), this.ToString()));
				}
				type = type.GetEnumUnderlyingType();
			}
			if (type == typeof(string))
			{
				object[] enumNames = this.GetEnumNames();
				return Array.IndexOf<object>(enumNames, value) >= 0;
			}
			if (!Type.IsIntegerType(type))
			{
				throw new InvalidOperationException("Unknown enum type.");
			}
			Type enumUnderlyingType = this.GetEnumUnderlyingType();
			if (enumUnderlyingType.GetTypeCodeImpl() != type.GetTypeCodeImpl())
			{
				throw new ArgumentException(SR.Format("Enum underlying type and the object must be same type or object must be a String. Type passed in was '{0}'; the enum underlying type was '{1}'.", type.ToString(), enumUnderlyingType.ToString()));
			}
			return Type.BinarySearch(this.GetEnumRawConstantValues(), value) >= 0;
		}

		/// <summary>Returns the name of the constant that has the specified value, for the current enumeration type.</summary>
		/// <param name="value">The value whose name is to be retrieved.</param>
		/// <returns>The name of the member of the current enumeration type that has the specified value, or <see langword="null" /> if no such constant is found.</returns>
		/// <exception cref="T:System.ArgumentException">The current type is not an enumeration.-or-
		///         <paramref name="value" /> is neither of the current type nor does it have the same underlying type as the current type.</exception>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="value" /> is <see langword="null" />.</exception>
		// Token: 0x060009B7 RID: 2487 RVA: 0x0002A494 File Offset: 0x00028694
		public virtual string GetEnumName(object value)
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (!this.IsEnum)
			{
				throw new ArgumentException("Type provided must be an Enum.", "enumType");
			}
			Type type = value.GetType();
			if (!type.IsEnum && !Type.IsIntegerType(type))
			{
				throw new ArgumentException("The value passed in must be an enum base or an underlying type for an enum, such as an Int32.", "value");
			}
			int num = Type.BinarySearch(this.GetEnumRawConstantValues(), value);
			if (num >= 0)
			{
				return this.GetEnumNames()[num];
			}
			return null;
		}

		/// <summary>Returns the names of the members of the current enumeration type.</summary>
		/// <returns>An array that contains the names of the members of the enumeration.</returns>
		/// <exception cref="T:System.ArgumentException">The current type is not an enumeration.</exception>
		// Token: 0x060009B8 RID: 2488 RVA: 0x0002A50C File Offset: 0x0002870C
		public virtual string[] GetEnumNames()
		{
			if (!this.IsEnum)
			{
				throw new ArgumentException("Type provided must be an Enum.", "enumType");
			}
			string[] result;
			Array array;
			this.GetEnumData(out result, out array);
			return result;
		}

		// Token: 0x060009B9 RID: 2489 RVA: 0x0002A53C File Offset: 0x0002873C
		private Array GetEnumRawConstantValues()
		{
			string[] array;
			Array result;
			this.GetEnumData(out array, out result);
			return result;
		}

		// Token: 0x060009BA RID: 2490 RVA: 0x0002A554 File Offset: 0x00028754
		private void GetEnumData(out string[] enumNames, out Array enumValues)
		{
			FieldInfo[] fields = this.GetFields(BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic);
			object[] array = new object[fields.Length];
			string[] array2 = new string[fields.Length];
			for (int i = 0; i < fields.Length; i++)
			{
				array2[i] = fields[i].Name;
				array[i] = fields[i].GetRawConstantValue();
			}
			IComparer @default = Comparer<object>.Default;
			for (int j = 1; j < array.Length; j++)
			{
				int num = j;
				string text = array2[j];
				object obj = array[j];
				bool flag = false;
				while (@default.Compare(array[num - 1], obj) > 0)
				{
					array2[num] = array2[num - 1];
					array[num] = array[num - 1];
					num--;
					flag = true;
					if (num == 0)
					{
						break;
					}
				}
				if (flag)
				{
					array2[num] = text;
					array[num] = obj;
				}
			}
			enumNames = array2;
			enumValues = array;
		}

		// Token: 0x060009BB RID: 2491 RVA: 0x0002A620 File Offset: 0x00028820
		private static int BinarySearch(Array array, object value)
		{
			ulong[] array2 = new ulong[array.Length];
			for (int i = 0; i < array.Length; i++)
			{
				array2[i] = Enum.ToUInt64(array.GetValue(i));
			}
			ulong value2 = Enum.ToUInt64(value);
			return Array.BinarySearch<ulong>(array2, value2);
		}

		// Token: 0x060009BC RID: 2492 RVA: 0x0002A668 File Offset: 0x00028868
		internal static bool IsIntegerType(Type t)
		{
			return t == typeof(int) || t == typeof(short) || t == typeof(ushort) || t == typeof(byte) || t == typeof(sbyte) || t == typeof(uint) || t == typeof(long) || t == typeof(ulong) || t == typeof(char) || t == typeof(bool);
		}

		/// <summary>Gets a value indicating whether the <see cref="T:System.Type" /> is serializable.</summary>
		/// <returns>
		///     <see langword="true" /> if the <see cref="T:System.Type" /> is serializable; otherwise, <see langword="false" />.</returns>
		// Token: 0x170000A8 RID: 168
		// (get) Token: 0x060009BD RID: 2493 RVA: 0x0002A730 File Offset: 0x00028930
		public virtual bool IsSerializable
		{
			get
			{
				if ((this.GetAttributeFlagsImpl() & TypeAttributes.Serializable) != TypeAttributes.NotPublic)
				{
					return true;
				}
				Type type = this.UnderlyingSystemType;
				if (type.IsRuntimeImplemented())
				{
					while (!(type == typeof(Delegate)) && !(type == typeof(Enum)))
					{
						type = type.BaseType;
						if (!(type != null))
						{
							return false;
						}
					}
					return true;
				}
				return false;
			}
		}

		/// <summary>Gets a value indicating whether the current <see cref="T:System.Type" /> object has type parameters that have not been replaced by specific types.</summary>
		/// <returns>
		///     <see langword="true" /> if the <see cref="T:System.Type" /> object is itself a generic type parameter or has type parameters for which specific types have not been supplied; otherwise, <see langword="false" />.</returns>
		// Token: 0x170000A9 RID: 169
		// (get) Token: 0x060009BE RID: 2494 RVA: 0x0002A794 File Offset: 0x00028994
		public virtual bool ContainsGenericParameters
		{
			get
			{
				if (this.HasElementType)
				{
					return this.GetRootElementType().ContainsGenericParameters;
				}
				if (this.IsGenericParameter)
				{
					return true;
				}
				if (!this.IsGenericType)
				{
					return false;
				}
				Type[] genericArguments = this.GetGenericArguments();
				for (int i = 0; i < genericArguments.Length; i++)
				{
					if (genericArguments[i].ContainsGenericParameters)
					{
						return true;
					}
				}
				return false;
			}
		}

		// Token: 0x060009BF RID: 2495 RVA: 0x0002A7EC File Offset: 0x000289EC
		internal Type GetRootElementType()
		{
			Type type = this;
			while (type.HasElementType)
			{
				type = type.GetElementType();
			}
			return type;
		}

		/// <summary>Gets a value indicating whether the <see cref="T:System.Type" /> can be accessed by code outside the assembly.</summary>
		/// <returns>
		///     <see langword="true" /> if the current <see cref="T:System.Type" /> is a public type or a public nested type such that all the enclosing types are public; otherwise, <see langword="false" />.</returns>
		// Token: 0x170000AA RID: 170
		// (get) Token: 0x060009C0 RID: 2496 RVA: 0x0002A810 File Offset: 0x00028A10
		public bool IsVisible
		{
			get
			{
				if (this.IsGenericParameter)
				{
					return true;
				}
				if (this.HasElementType)
				{
					return this.GetElementType().IsVisible;
				}
				Type type = this;
				while (type.IsNested)
				{
					if (!type.IsNestedPublic)
					{
						return false;
					}
					type = type.DeclaringType;
				}
				if (!type.IsPublic)
				{
					return false;
				}
				if (this.IsGenericType && !this.IsGenericTypeDefinition)
				{
					Type[] genericArguments = this.GetGenericArguments();
					for (int i = 0; i < genericArguments.Length; i++)
					{
						if (!genericArguments[i].IsVisible)
						{
							return false;
						}
					}
				}
				return true;
			}
		}

		/// <summary>Determines whether the current <see cref="T:System.Type" /> derives from the specified <see cref="T:System.Type" />.</summary>
		/// <param name="c">The type to compare with the current type. </param>
		/// <returns>
		///     <see langword="true" /> if the current <see langword="Type" /> derives from <paramref name="c" />; otherwise, <see langword="false" />. This method also returns <see langword="false" /> if <paramref name="c" /> and the current <see langword="Type" /> are equal.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="c" /> is <see langword="null" />. </exception>
		// Token: 0x060009C1 RID: 2497 RVA: 0x0002A894 File Offset: 0x00028A94
		public virtual bool IsSubclassOf(Type c)
		{
			Type type = this;
			if (type == c)
			{
				return false;
			}
			while (type != null)
			{
				if (type == c)
				{
					return true;
				}
				type = type.BaseType;
			}
			return false;
		}

		/// <summary>Determines whether an instance of a specified type can be assigned to an instance of the current type.</summary>
		/// <param name="c">The type to compare with the current type. </param>
		/// <returns>
		///     <see langword="true" /> if any of the following conditions is true:
		///         <paramref name="c" /> and the current instance represent the same type. 
		///         <paramref name="c" /> is derived either directly or indirectly from the current instance. <paramref name="c" /> is derived directly from the current instance if it inherits from the current instance; <paramref name="c" /> is derived indirectly from the current instance if it inherits from a succession of one or more classes that inherit from the current instance.  The current instance is an interface that <paramref name="c" /> implements. 
		///         <paramref name="c" /> is a generic type parameter, and the current instance represents one of the constraints of <paramref name="c" />. In the following example, the current instance is a <see cref="T:System.Type" /> object that represents the <see cref="T:System.IO.Stream" /> class. GenericWithConstraint is a generic type whose generic type parameter must be of type    <see cref="T:System.IO.Stream" />. Passing its generic type parameter to the <see cref="M:System.Type.IsAssignableFrom(System.Type)" /> indicates that  an instance of the generic type parameter can be assigned to an <see cref="T:System.IO.Stream" /> object. System.Type.IsAssignableFrom#2
		///
		///         <paramref name="c" /> represents a value type, and the current instance represents Nullable&lt;c&gt; (Nullable(Of c) in Visual Basic).
		///     <see langword="false" /> if none of these conditions are true, or if <paramref name="c" /> is <see langword="null" />. </returns>
		// Token: 0x060009C2 RID: 2498 RVA: 0x0002A8CC File Offset: 0x00028ACC
		public virtual bool IsAssignableFrom(Type c)
		{
			if (c == null)
			{
				return false;
			}
			if (this == c)
			{
				return true;
			}
			Type underlyingSystemType = this.UnderlyingSystemType;
			if (underlyingSystemType.IsRuntimeImplemented())
			{
				return underlyingSystemType.IsAssignableFrom(c);
			}
			if (c.IsSubclassOf(this))
			{
				return true;
			}
			if (this.IsInterface)
			{
				return c.ImplementInterface(this);
			}
			if (this.IsGenericParameter)
			{
				Type[] genericParameterConstraints = this.GetGenericParameterConstraints();
				for (int i = 0; i < genericParameterConstraints.Length; i++)
				{
					if (!genericParameterConstraints[i].IsAssignableFrom(c))
					{
						return false;
					}
				}
				return true;
			}
			return false;
		}

		// Token: 0x060009C3 RID: 2499 RVA: 0x0002A950 File Offset: 0x00028B50
		internal bool ImplementInterface(Type ifaceType)
		{
			Type type = this;
			while (type != null)
			{
				Type[] interfaces = type.GetInterfaces();
				if (interfaces != null)
				{
					for (int i = 0; i < interfaces.Length; i++)
					{
						if (interfaces[i] == ifaceType || (interfaces[i] != null && interfaces[i].ImplementInterface(ifaceType)))
						{
							return true;
						}
					}
				}
				type = type.BaseType;
			}
			return false;
		}

		// Token: 0x060009C4 RID: 2500 RVA: 0x0002A9B0 File Offset: 0x00028BB0
		private static bool FilterAttributeImpl(MemberInfo m, object filterCriteria)
		{
			if (filterCriteria == null)
			{
				throw new InvalidFilterCriteriaException("An Int32 must be provided for the filter criteria.");
			}
			MemberTypes memberType = m.MemberType;
			if (memberType != MemberTypes.Constructor)
			{
				if (memberType == MemberTypes.Field)
				{
					FieldAttributes fieldAttributes = FieldAttributes.PrivateScope;
					try
					{
						fieldAttributes = (FieldAttributes)((int)filterCriteria);
					}
					catch
					{
						throw new InvalidFilterCriteriaException("An Int32 must be provided for the filter criteria.");
					}
					FieldAttributes attributes = ((FieldInfo)m).Attributes;
					return ((fieldAttributes & FieldAttributes.FieldAccessMask) == FieldAttributes.PrivateScope || (attributes & FieldAttributes.FieldAccessMask) == (fieldAttributes & FieldAttributes.FieldAccessMask)) && ((fieldAttributes & FieldAttributes.Static) == FieldAttributes.PrivateScope || (attributes & FieldAttributes.Static) != FieldAttributes.PrivateScope) && ((fieldAttributes & FieldAttributes.InitOnly) == FieldAttributes.PrivateScope || (attributes & FieldAttributes.InitOnly) != FieldAttributes.PrivateScope) && ((fieldAttributes & FieldAttributes.Literal) == FieldAttributes.PrivateScope || (attributes & FieldAttributes.Literal) != FieldAttributes.PrivateScope) && ((fieldAttributes & FieldAttributes.NotSerialized) == FieldAttributes.PrivateScope || (attributes & FieldAttributes.NotSerialized) != FieldAttributes.PrivateScope) && ((fieldAttributes & FieldAttributes.PinvokeImpl) == FieldAttributes.PrivateScope || (attributes & FieldAttributes.PinvokeImpl) != FieldAttributes.PrivateScope);
				}
				if (memberType != MemberTypes.Method)
				{
					return false;
				}
			}
			MethodAttributes methodAttributes = MethodAttributes.PrivateScope;
			try
			{
				methodAttributes = (MethodAttributes)((int)filterCriteria);
			}
			catch
			{
				throw new InvalidFilterCriteriaException("An Int32 must be provided for the filter criteria.");
			}
			MethodAttributes attributes2;
			if (m.MemberType == MemberTypes.Method)
			{
				attributes2 = ((MethodInfo)m).Attributes;
			}
			else
			{
				attributes2 = ((ConstructorInfo)m).Attributes;
			}
			return ((methodAttributes & MethodAttributes.MemberAccessMask) == MethodAttributes.PrivateScope || (attributes2 & MethodAttributes.MemberAccessMask) == (methodAttributes & MethodAttributes.MemberAccessMask)) && ((methodAttributes & MethodAttributes.Static) == MethodAttributes.PrivateScope || (attributes2 & MethodAttributes.Static) != MethodAttributes.PrivateScope) && ((methodAttributes & MethodAttributes.Final) == MethodAttributes.PrivateScope || (attributes2 & MethodAttributes.Final) != MethodAttributes.PrivateScope) && ((methodAttributes & MethodAttributes.Virtual) == MethodAttributes.PrivateScope || (attributes2 & MethodAttributes.Virtual) != MethodAttributes.PrivateScope) && ((methodAttributes & MethodAttributes.Abstract) == MethodAttributes.PrivateScope || (attributes2 & MethodAttributes.Abstract) != MethodAttributes.PrivateScope) && ((methodAttributes & MethodAttributes.SpecialName) == MethodAttributes.PrivateScope || (attributes2 & MethodAttributes.SpecialName) != MethodAttributes.PrivateScope);
		}

		// Token: 0x060009C5 RID: 2501 RVA: 0x0002AB2C File Offset: 0x00028D2C
		private static bool FilterNameImpl(MemberInfo m, object filterCriteria)
		{
			if (filterCriteria == null || !(filterCriteria is string))
			{
				throw new InvalidFilterCriteriaException("A String must be provided for the filter criteria.");
			}
			string text = (string)filterCriteria;
			text = text.Trim();
			string text2 = m.Name;
			if (m.MemberType == MemberTypes.NestedType)
			{
				text2 = text2.Substring(text2.LastIndexOf('+') + 1);
			}
			if (text.Length > 0 && text[text.Length - 1] == '*')
			{
				text = text.Substring(0, text.Length - 1);
				return text2.StartsWith(text, StringComparison.Ordinal);
			}
			return text2.Equals(text);
		}

		// Token: 0x060009C6 RID: 2502 RVA: 0x0002ABC0 File Offset: 0x00028DC0
		private static bool FilterNameIgnoreCaseImpl(MemberInfo m, object filterCriteria)
		{
			if (filterCriteria == null || !(filterCriteria is string))
			{
				throw new InvalidFilterCriteriaException("A String must be provided for the filter criteria.");
			}
			string text = (string)filterCriteria;
			text = text.Trim();
			string text2 = m.Name;
			if (m.MemberType == MemberTypes.NestedType)
			{
				text2 = text2.Substring(text2.LastIndexOf('+') + 1);
			}
			if (text.Length > 0 && text[text.Length - 1] == '*')
			{
				text = text.Substring(0, text.Length - 1);
				return string.Compare(text2, 0, text, 0, text.Length, StringComparison.OrdinalIgnoreCase) == 0;
			}
			return string.Compare(text, text2, StringComparison.OrdinalIgnoreCase) == 0;
		}

		/// <summary>Gets a <see cref="T:System.Reflection.MemberTypes" /> value indicating that this member is a type or a nested type.</summary>
		/// <returns>A <see cref="T:System.Reflection.MemberTypes" /> value indicating that this member is a type or a nested type.</returns>
		// Token: 0x170000AB RID: 171
		// (get) Token: 0x060009C8 RID: 2504 RVA: 0x0002AC68 File Offset: 0x00028E68
		public override MemberTypes MemberType
		{
			get
			{
				return MemberTypes.TypeInfo;
			}
		}

		/// <summary>Gets the current <see cref="T:System.Type" />.</summary>
		/// <returns>The current <see cref="T:System.Type" />.</returns>
		/// <exception cref="T:System.Reflection.TargetInvocationException">A class initializer is invoked and throws an exception. </exception>
		// Token: 0x060009C9 RID: 2505 RVA: 0x0002AC6C File Offset: 0x00028E6C
		public new Type GetType()
		{
			return base.GetType();
		}

		/// <summary>Gets the namespace of the <see cref="T:System.Type" />.</summary>
		/// <returns>The namespace of the <see cref="T:System.Type" />; <see langword="null" /> if the current instance has no namespace or represents a generic parameter.</returns>
		// Token: 0x170000AC RID: 172
		// (get) Token: 0x060009CA RID: 2506
		public abstract string Namespace { get; }

		/// <summary>Gets the assembly-qualified name of the type, which includes the name of the assembly from which this <see cref="T:System.Type" /> object was loaded.</summary>
		/// <returns>The assembly-qualified name of the <see cref="T:System.Type" />, which includes the name of the assembly from which the <see cref="T:System.Type" /> was loaded, or <see langword="null" /> if the current instance represents a generic type parameter.</returns>
		// Token: 0x170000AD RID: 173
		// (get) Token: 0x060009CB RID: 2507
		public abstract string AssemblyQualifiedName { get; }

		/// <summary>Gets the fully qualified name of the type, including its namespace but not its assembly. </summary>
		/// <returns>The fully qualified name of the type, including its namespace but not its assembly; or <see langword="null" /> if the current instance represents a generic type parameter, an array type, pointer type, or <see langword="byref" /> type based on a type parameter, or a generic type that is not a generic type definition but contains unresolved type parameters.</returns>
		// Token: 0x170000AE RID: 174
		// (get) Token: 0x060009CC RID: 2508
		public abstract string FullName { get; }

		/// <summary>Gets the <see cref="T:System.Reflection.Assembly" /> in which the type is declared. For generic types, gets the <see cref="T:System.Reflection.Assembly" /> in which the generic type is defined.</summary>
		/// <returns>An <see cref="T:System.Reflection.Assembly" /> instance that describes the assembly containing the current type. For generic types, the instance describes the assembly that contains the generic type definition, not the assembly that creates and uses a particular constructed type.</returns>
		// Token: 0x170000AF RID: 175
		// (get) Token: 0x060009CD RID: 2509
		public abstract Assembly Assembly { get; }

		/// <summary>Gets the module (the DLL) in which the current <see cref="T:System.Type" /> is defined.</summary>
		/// <returns>The module in which the current <see cref="T:System.Type" /> is defined.</returns>
		// Token: 0x170000B0 RID: 176
		// (get) Token: 0x060009CE RID: 2510
		public new abstract Module Module { get; }

		/// <summary>Gets a value indicating whether the current <see cref="T:System.Type" /> object represents a type whose definition is nested inside the definition of another type.</summary>
		/// <returns>
		///     <see langword="true" /> if the <see cref="T:System.Type" /> is nested inside another type; otherwise, <see langword="false" />.</returns>
		// Token: 0x170000B1 RID: 177
		// (get) Token: 0x060009CF RID: 2511 RVA: 0x0002AC74 File Offset: 0x00028E74
		public bool IsNested
		{
			get
			{
				return this.DeclaringType != null;
			}
		}

		/// <summary>Gets the type that declares the current nested type or generic type parameter.</summary>
		/// <returns>A <see cref="T:System.Type" /> object representing the enclosing type, if the current type is a nested type; or the generic type definition, if the current type is a type parameter of a generic type; or the type that declares the generic method, if the current type is a type parameter of a generic method; otherwise, <see langword="null" />.</returns>
		// Token: 0x170000B2 RID: 178
		// (get) Token: 0x060009D0 RID: 2512 RVA: 0x0002AC82 File Offset: 0x00028E82
		public override Type DeclaringType
		{
			get
			{
				return null;
			}
		}

		/// <summary>
		///
		///     Gets a <see cref="T:System.Reflection.MethodBase" /> that represents the declaring method, if the current <see cref="T:System.Type" /> represents a type parameter of a generic method.</summary>
		/// <returns>If the current <see cref="T:System.Type" /> represents a type parameter of a generic method, a <see cref="T:System.Reflection.MethodBase" /> that represents declaring method; otherwise, <see langword="null" />.</returns>
		// Token: 0x170000B3 RID: 179
		// (get) Token: 0x060009D1 RID: 2513 RVA: 0x0002AC82 File Offset: 0x00028E82
		public virtual MethodBase DeclaringMethod
		{
			get
			{
				return null;
			}
		}

		/// <summary>Gets the class object that was used to obtain this member. </summary>
		/// <returns>The <see langword="Type" /> object through which this <see cref="T:System.Type" /> object was obtained. </returns>
		// Token: 0x170000B4 RID: 180
		// (get) Token: 0x060009D2 RID: 2514 RVA: 0x0002AC82 File Offset: 0x00028E82
		public override Type ReflectedType
		{
			get
			{
				return null;
			}
		}

		/// <summary>Indicates the type provided by the common language runtime that represents this type.</summary>
		/// <returns>The underlying system type for the <see cref="T:System.Type" />.</returns>
		// Token: 0x170000B5 RID: 181
		// (get) Token: 0x060009D3 RID: 2515
		public abstract Type UnderlyingSystemType { get; }

		/// <summary>Gets a value that indicates whether the type is an array.</summary>
		/// <returns>
		///     <see langword="true" /> if the current type is an array; otherwise, <see langword="false" />.</returns>
		// Token: 0x170000B6 RID: 182
		// (get) Token: 0x060009D4 RID: 2516 RVA: 0x0002AC85 File Offset: 0x00028E85
		public bool IsArray
		{
			get
			{
				return this.IsArrayImpl();
			}
		}

		/// <summary>When overridden in a derived class, implements the <see cref="P:System.Type.IsArray" /> property and determines whether the <see cref="T:System.Type" /> is an array.</summary>
		/// <returns>
		///     <see langword="true" /> if the <see cref="T:System.Type" /> is an array; otherwise, <see langword="false" />.</returns>
		// Token: 0x060009D5 RID: 2517
		protected abstract bool IsArrayImpl();

		/// <summary>Gets a value indicating whether the <see cref="T:System.Type" /> is passed by reference.</summary>
		/// <returns>
		///     <see langword="true" /> if the <see cref="T:System.Type" /> is passed by reference; otherwise, <see langword="false" />.</returns>
		// Token: 0x170000B7 RID: 183
		// (get) Token: 0x060009D6 RID: 2518 RVA: 0x0002AC8D File Offset: 0x00028E8D
		public bool IsByRef
		{
			get
			{
				return this.IsByRefImpl();
			}
		}

		/// <summary>When overridden in a derived class, implements the <see cref="P:System.Type.IsByRef" /> property and determines whether the <see cref="T:System.Type" /> is passed by reference.</summary>
		/// <returns>
		///     <see langword="true" /> if the <see cref="T:System.Type" /> is passed by reference; otherwise, <see langword="false" />.</returns>
		// Token: 0x060009D7 RID: 2519
		protected abstract bool IsByRefImpl();

		/// <summary>Gets a value indicating whether the <see cref="T:System.Type" /> is a pointer.</summary>
		/// <returns>
		///     <see langword="true" /> if the <see cref="T:System.Type" /> is a pointer; otherwise, <see langword="false" />.</returns>
		// Token: 0x170000B8 RID: 184
		// (get) Token: 0x060009D8 RID: 2520 RVA: 0x0002AC95 File Offset: 0x00028E95
		public bool IsPointer
		{
			get
			{
				return this.IsPointerImpl();
			}
		}

		/// <summary>When overridden in a derived class, implements the <see cref="P:System.Type.IsPointer" /> property and determines whether the <see cref="T:System.Type" /> is a pointer.</summary>
		/// <returns>
		///     <see langword="true" /> if the <see cref="T:System.Type" /> is a pointer; otherwise, <see langword="false" />.</returns>
		// Token: 0x060009D9 RID: 2521
		protected abstract bool IsPointerImpl();

		/// <summary>Gets a value that indicates whether this object represents a constructed generic type. You can create instances of a constructed generic type. </summary>
		/// <returns>
		///     <see langword="true" /> if this object represents a constructed generic type; otherwise, <see langword="false" />.</returns>
		// Token: 0x170000B9 RID: 185
		// (get) Token: 0x060009DA RID: 2522 RVA: 0x0002AC9D File Offset: 0x00028E9D
		public virtual bool IsConstructedGenericType
		{
			get
			{
				throw NotImplemented.ByDesign;
			}
		}

		/// <summary>Gets a value indicating whether the current <see cref="T:System.Type" /> represents a type parameter in the definition of a generic type or method.</summary>
		/// <returns>
		///     <see langword="true" /> if the <see cref="T:System.Type" /> object represents a type parameter of a generic type definition or generic method definition; otherwise, <see langword="false" />.</returns>
		// Token: 0x170000BA RID: 186
		// (get) Token: 0x060009DB RID: 2523 RVA: 0x0002ACA4 File Offset: 0x00028EA4
		public virtual bool IsGenericParameter
		{
			get
			{
				return false;
			}
		}

		// Token: 0x170000BB RID: 187
		// (get) Token: 0x060009DC RID: 2524 RVA: 0x0002ACA7 File Offset: 0x00028EA7
		public virtual bool IsGenericMethodParameter
		{
			get
			{
				return this.IsGenericParameter && this.DeclaringMethod != null;
			}
		}

		/// <summary>Gets a value indicating whether the current type is a generic type.</summary>
		/// <returns>
		///     <see langword="true" /> if the current type is a generic type; otherwise,<see langword=" false" />.</returns>
		// Token: 0x170000BC RID: 188
		// (get) Token: 0x060009DD RID: 2525 RVA: 0x0002ACA4 File Offset: 0x00028EA4
		public virtual bool IsGenericType
		{
			get
			{
				return false;
			}
		}

		/// <summary>Gets a value indicating whether the current <see cref="T:System.Type" /> represents a generic type definition, from which other generic types can be constructed.</summary>
		/// <returns>
		///     <see langword="true" /> if the <see cref="T:System.Type" /> object represents a generic type definition; otherwise, <see langword="false" />.</returns>
		// Token: 0x170000BD RID: 189
		// (get) Token: 0x060009DE RID: 2526 RVA: 0x0002ACA4 File Offset: 0x00028EA4
		public virtual bool IsGenericTypeDefinition
		{
			get
			{
				return false;
			}
		}

		// Token: 0x170000BE RID: 190
		// (get) Token: 0x060009DF RID: 2527 RVA: 0x0002AC9D File Offset: 0x00028E9D
		public virtual bool IsSZArray
		{
			get
			{
				throw NotImplemented.ByDesign;
			}
		}

		// Token: 0x170000BF RID: 191
		// (get) Token: 0x060009E0 RID: 2528 RVA: 0x0002ACBF File Offset: 0x00028EBF
		public virtual bool IsVariableBoundArray
		{
			get
			{
				return this.IsArray && !this.IsSZArray;
			}
		}

		/// <summary>Gets a value indicating whether the current <see cref="T:System.Type" /> encompasses or refers to another type; that is, whether the current <see cref="T:System.Type" /> is an array, a pointer, or is passed by reference.</summary>
		/// <returns>
		///     <see langword="true" /> if the <see cref="T:System.Type" /> is an array, a pointer, or is passed by reference; otherwise, <see langword="false" />.</returns>
		// Token: 0x170000C0 RID: 192
		// (get) Token: 0x060009E1 RID: 2529 RVA: 0x0002ACD4 File Offset: 0x00028ED4
		public bool HasElementType
		{
			get
			{
				return this.HasElementTypeImpl();
			}
		}

		/// <summary>When overridden in a derived class, implements the <see cref="P:System.Type.HasElementType" /> property and determines whether the current <see cref="T:System.Type" /> encompasses or refers to another type; that is, whether the current <see cref="T:System.Type" /> is an array, a pointer, or is passed by reference.</summary>
		/// <returns>
		///     <see langword="true" /> if the <see cref="T:System.Type" /> is an array, a pointer, or is passed by reference; otherwise, <see langword="false" />.</returns>
		// Token: 0x060009E2 RID: 2530
		protected abstract bool HasElementTypeImpl();

		/// <summary>When overridden in a derived class, returns the <see cref="T:System.Type" /> of the object encompassed or referred to by the current array, pointer or reference type.</summary>
		/// <returns>The <see cref="T:System.Type" /> of the object encompassed or referred to by the current array, pointer, or reference type, or <see langword="null" /> if the current <see cref="T:System.Type" /> is not an array or a pointer, or is not passed by reference, or represents a generic type or a type parameter in the definition of a generic type or generic method.</returns>
		// Token: 0x060009E3 RID: 2531
		public abstract Type GetElementType();

		/// <summary>Gets the number of dimensions in an array. </summary>
		/// <returns>An integer that contains the number of dimensions in the current type. </returns>
		/// <exception cref="T:System.NotSupportedException">The functionality of this method is unsupported in the base class and must be implemented in a derived class instead. </exception>
		/// <exception cref="T:System.ArgumentException">The current type is not an array. </exception>
		// Token: 0x060009E4 RID: 2532 RVA: 0x0002ACDC File Offset: 0x00028EDC
		public virtual int GetArrayRank()
		{
			throw new NotSupportedException("Derived classes must provide an implementation.");
		}

		/// <summary>Returns a <see cref="T:System.Type" /> object that represents a generic type definition from which the current generic type can be constructed.</summary>
		/// <returns>A <see cref="T:System.Type" /> object representing a generic type from which the current type can be constructed.</returns>
		/// <exception cref="T:System.InvalidOperationException">The current type is not a generic type.  That is, <see cref="P:System.Type.IsGenericType" /> returns <see langword="false" />. </exception>
		/// <exception cref="T:System.NotSupportedException">The invoked method is not supported in the base class. Derived classes must provide an implementation.</exception>
		// Token: 0x060009E5 RID: 2533 RVA: 0x0002ACDC File Offset: 0x00028EDC
		public virtual Type GetGenericTypeDefinition()
		{
			throw new NotSupportedException("Derived classes must provide an implementation.");
		}

		/// <summary>Gets an array of the generic type arguments for this type.</summary>
		/// <returns>An array of the generic type arguments for this type.</returns>
		// Token: 0x170000C1 RID: 193
		// (get) Token: 0x060009E6 RID: 2534 RVA: 0x0002ACE8 File Offset: 0x00028EE8
		public virtual Type[] GenericTypeArguments
		{
			get
			{
				if (!this.IsGenericType || this.IsGenericTypeDefinition)
				{
					return Array.Empty<Type>();
				}
				return this.GetGenericArguments();
			}
		}

		/// <summary>Returns an array of <see cref="T:System.Type" /> objects that represent the type arguments of a closed generic type or the type parameters of a generic type definition.</summary>
		/// <returns>An array of <see cref="T:System.Type" /> objects that represent the type arguments of a generic type. Returns an empty array if the current type is not a generic type.</returns>
		/// <exception cref="T:System.NotSupportedException">The invoked method is not supported in the base class. Derived classes must provide an implementation.</exception>
		// Token: 0x060009E7 RID: 2535 RVA: 0x0002ACDC File Offset: 0x00028EDC
		public virtual Type[] GetGenericArguments()
		{
			throw new NotSupportedException("Derived classes must provide an implementation.");
		}

		/// <summary>Gets the position of the type parameter in the type parameter list of the generic type or method that declared the parameter, when the <see cref="T:System.Type" /> object represents a type parameter of a generic type or a generic method.</summary>
		/// <returns>The position of a type parameter in the type parameter list of the generic type or method that defines the parameter. Position numbers begin at 0.</returns>
		/// <exception cref="T:System.InvalidOperationException">The current type does not represent a type parameter. That is, <see cref="P:System.Type.IsGenericParameter" /> returns <see langword="false" />. </exception>
		// Token: 0x170000C2 RID: 194
		// (get) Token: 0x060009E8 RID: 2536 RVA: 0x0002AD06 File Offset: 0x00028F06
		public virtual int GenericParameterPosition
		{
			get
			{
				throw new InvalidOperationException("Method may only be called on a Type for which Type.IsGenericParameter is true.");
			}
		}

		/// <summary>Gets a combination of <see cref="T:System.Reflection.GenericParameterAttributes" /> flags that describe the covariance and special constraints of the current generic type parameter. </summary>
		/// <returns>A bitwise combination of <see cref="T:System.Reflection.GenericParameterAttributes" /> values that describes the covariance and special constraints of the current generic type parameter.</returns>
		/// <exception cref="T:System.InvalidOperationException">The current <see cref="T:System.Type" /> object is not a generic type parameter. That is, the <see cref="P:System.Type.IsGenericParameter" /> property returns <see langword="false" />.</exception>
		/// <exception cref="T:System.NotSupportedException">The invoked method is not supported in the base class.</exception>
		// Token: 0x170000C3 RID: 195
		// (get) Token: 0x060009E9 RID: 2537 RVA: 0x0002AD12 File Offset: 0x00028F12
		public virtual GenericParameterAttributes GenericParameterAttributes
		{
			get
			{
				throw new NotSupportedException();
			}
		}

		/// <summary>Returns an array of <see cref="T:System.Type" /> objects that represent the constraints on the current generic type parameter. </summary>
		/// <returns>An array of <see cref="T:System.Type" /> objects that represent the constraints on the current generic type parameter.</returns>
		/// <exception cref="T:System.InvalidOperationException">The current <see cref="T:System.Type" /> object is not a generic type parameter. That is, the <see cref="P:System.Type.IsGenericParameter" /> property returns <see langword="false" />.</exception>
		// Token: 0x060009EA RID: 2538 RVA: 0x0002AD19 File Offset: 0x00028F19
		public virtual Type[] GetGenericParameterConstraints()
		{
			if (!this.IsGenericParameter)
			{
				throw new InvalidOperationException("Method may only be called on a Type for which Type.IsGenericParameter is true.");
			}
			throw new InvalidOperationException();
		}

		/// <summary>Gets the attributes associated with the <see cref="T:System.Type" />.</summary>
		/// <returns>A <see cref="T:System.Reflection.TypeAttributes" /> object representing the attribute set of the <see cref="T:System.Type" />, unless the <see cref="T:System.Type" /> represents a generic type parameter, in which case the value is unspecified. </returns>
		// Token: 0x170000C4 RID: 196
		// (get) Token: 0x060009EB RID: 2539 RVA: 0x0002AD33 File Offset: 0x00028F33
		public TypeAttributes Attributes
		{
			get
			{
				return this.GetAttributeFlagsImpl();
			}
		}

		/// <summary>When overridden in a derived class, implements the <see cref="P:System.Type.Attributes" /> property and gets a bitmask indicating the attributes associated with the <see cref="T:System.Type" />.</summary>
		/// <returns>A <see cref="T:System.Reflection.TypeAttributes" /> object representing the attribute set of the <see cref="T:System.Type" />.</returns>
		// Token: 0x060009EC RID: 2540
		protected abstract TypeAttributes GetAttributeFlagsImpl();

		/// <summary>Gets a value indicating whether the <see cref="T:System.Type" /> is abstract and must be overridden.</summary>
		/// <returns>
		///     <see langword="true" /> if the <see cref="T:System.Type" /> is abstract; otherwise, <see langword="false" />.</returns>
		// Token: 0x170000C5 RID: 197
		// (get) Token: 0x060009ED RID: 2541 RVA: 0x0002AD3B File Offset: 0x00028F3B
		public bool IsAbstract
		{
			get
			{
				return (this.GetAttributeFlagsImpl() & TypeAttributes.Abstract) > TypeAttributes.NotPublic;
			}
		}

		/// <summary>Gets a value indicating whether the <see cref="T:System.Type" /> has a <see cref="T:System.Runtime.InteropServices.ComImportAttribute" /> attribute applied, indicating that it was imported from a COM type library.</summary>
		/// <returns>
		///     <see langword="true" /> if the <see cref="T:System.Type" /> has a <see cref="T:System.Runtime.InteropServices.ComImportAttribute" />; otherwise, <see langword="false" />.</returns>
		// Token: 0x170000C6 RID: 198
		// (get) Token: 0x060009EE RID: 2542 RVA: 0x0002AD4C File Offset: 0x00028F4C
		public bool IsImport
		{
			get
			{
				return (this.GetAttributeFlagsImpl() & TypeAttributes.Import) > TypeAttributes.NotPublic;
			}
		}

		/// <summary>Gets a value indicating whether the <see cref="T:System.Type" /> is declared sealed.</summary>
		/// <returns>
		///     <see langword="true" /> if the <see cref="T:System.Type" /> is declared sealed; otherwise, <see langword="false" />.</returns>
		// Token: 0x170000C7 RID: 199
		// (get) Token: 0x060009EF RID: 2543 RVA: 0x0002AD5D File Offset: 0x00028F5D
		public bool IsSealed
		{
			get
			{
				return (this.GetAttributeFlagsImpl() & TypeAttributes.Sealed) > TypeAttributes.NotPublic;
			}
		}

		/// <summary>Gets a value indicating whether the <see cref="T:System.Type" /> is a class or a delegate; that is, not a value type or interface.</summary>
		/// <returns>
		///     <see langword="true" /> if the <see cref="T:System.Type" /> is a class; otherwise, <see langword="false" />.</returns>
		// Token: 0x170000C8 RID: 200
		// (get) Token: 0x060009F0 RID: 2544 RVA: 0x0002AD6E File Offset: 0x00028F6E
		public bool IsClass
		{
			get
			{
				return (this.GetAttributeFlagsImpl() & TypeAttributes.ClassSemanticsMask) == TypeAttributes.NotPublic && !this.IsValueType;
			}
		}

		/// <summary>Gets a value indicating whether the <see cref="T:System.Type" /> is nested and visible only within its own assembly.</summary>
		/// <returns>
		///     <see langword="true" /> if the <see cref="T:System.Type" /> is nested and visible only within its own assembly; otherwise, <see langword="false" />.</returns>
		// Token: 0x170000C9 RID: 201
		// (get) Token: 0x060009F1 RID: 2545 RVA: 0x0002AD86 File Offset: 0x00028F86
		public bool IsNestedAssembly
		{
			get
			{
				return (this.GetAttributeFlagsImpl() & TypeAttributes.VisibilityMask) == TypeAttributes.NestedAssembly;
			}
		}

		/// <summary>Gets a value indicating whether the <see cref="T:System.Type" /> is nested and declared private.</summary>
		/// <returns>
		///     <see langword="true" /> if the <see cref="T:System.Type" /> is nested and declared private; otherwise, <see langword="false" />.</returns>
		// Token: 0x170000CA RID: 202
		// (get) Token: 0x060009F2 RID: 2546 RVA: 0x0002AD93 File Offset: 0x00028F93
		public bool IsNestedPrivate
		{
			get
			{
				return (this.GetAttributeFlagsImpl() & TypeAttributes.VisibilityMask) == TypeAttributes.NestedPrivate;
			}
		}

		/// <summary>Gets a value indicating whether a class is nested and declared public.</summary>
		/// <returns>
		///     <see langword="true" /> if the class is nested and declared public; otherwise, <see langword="false" />.</returns>
		// Token: 0x170000CB RID: 203
		// (get) Token: 0x060009F3 RID: 2547 RVA: 0x0002ADA0 File Offset: 0x00028FA0
		public bool IsNestedPublic
		{
			get
			{
				return (this.GetAttributeFlagsImpl() & TypeAttributes.VisibilityMask) == TypeAttributes.NestedPublic;
			}
		}

		/// <summary>Gets a value indicating whether the <see cref="T:System.Type" /> is not declared public.</summary>
		/// <returns>
		///     <see langword="true" /> if the <see cref="T:System.Type" /> is not declared public and is not a nested type; otherwise, <see langword="false" />.</returns>
		// Token: 0x170000CC RID: 204
		// (get) Token: 0x060009F4 RID: 2548 RVA: 0x0002ADAD File Offset: 0x00028FAD
		public bool IsNotPublic
		{
			get
			{
				return (this.GetAttributeFlagsImpl() & TypeAttributes.VisibilityMask) == TypeAttributes.NotPublic;
			}
		}

		/// <summary>Gets a value indicating whether the <see cref="T:System.Type" /> is declared public.</summary>
		/// <returns>
		///     <see langword="true" /> if the <see cref="T:System.Type" /> is declared public and is not a nested type; otherwise, <see langword="false" />.</returns>
		// Token: 0x170000CD RID: 205
		// (get) Token: 0x060009F5 RID: 2549 RVA: 0x0002ADBA File Offset: 0x00028FBA
		public bool IsPublic
		{
			get
			{
				return (this.GetAttributeFlagsImpl() & TypeAttributes.VisibilityMask) == TypeAttributes.Public;
			}
		}

		/// <summary>Gets a value indicating whether the fields of the current type are laid out at explicitly specified offsets.</summary>
		/// <returns>
		///     <see langword="true" /> if the <see cref="P:System.Type.Attributes" /> property of the current type includes <see cref="F:System.Reflection.TypeAttributes.ExplicitLayout" />; otherwise, <see langword="false" />.</returns>
		// Token: 0x170000CE RID: 206
		// (get) Token: 0x060009F6 RID: 2550 RVA: 0x0002ADC7 File Offset: 0x00028FC7
		public bool IsExplicitLayout
		{
			get
			{
				return (this.GetAttributeFlagsImpl() & TypeAttributes.LayoutMask) == TypeAttributes.ExplicitLayout;
			}
		}

		/// <summary>Gets a value indicating whether the <see cref="T:System.Type" /> is a COM object.</summary>
		/// <returns>
		///     <see langword="true" /> if the <see cref="T:System.Type" /> is a COM object; otherwise, <see langword="false" />.</returns>
		// Token: 0x170000CF RID: 207
		// (get) Token: 0x060009F7 RID: 2551 RVA: 0x0002ADD6 File Offset: 0x00028FD6
		public bool IsCOMObject
		{
			get
			{
				return this.IsCOMObjectImpl();
			}
		}

		/// <summary>When overridden in a derived class, implements the <see cref="P:System.Type.IsCOMObject" /> property and determines whether the <see cref="T:System.Type" /> is a COM object.</summary>
		/// <returns>
		///     <see langword="true" /> if the <see cref="T:System.Type" /> is a COM object; otherwise, <see langword="false" />.</returns>
		// Token: 0x060009F8 RID: 2552
		protected abstract bool IsCOMObjectImpl();

		/// <summary>Gets a value indicating whether the <see cref="T:System.Type" /> can be hosted in a context.</summary>
		/// <returns>
		///     <see langword="true" /> if the <see cref="T:System.Type" /> can be hosted in a context; otherwise, <see langword="false" />.</returns>
		// Token: 0x170000D0 RID: 208
		// (get) Token: 0x060009F9 RID: 2553 RVA: 0x0002ADDE File Offset: 0x00028FDE
		public bool IsContextful
		{
			get
			{
				return this.IsContextfulImpl();
			}
		}

		/// <summary>Implements the <see cref="P:System.Type.IsContextful" /> property and determines whether the <see cref="T:System.Type" /> can be hosted in a context.</summary>
		/// <returns>
		///     <see langword="true" /> if the <see cref="T:System.Type" /> can be hosted in a context; otherwise, <see langword="false" />.</returns>
		// Token: 0x060009FA RID: 2554 RVA: 0x0002ADE6 File Offset: 0x00028FE6
		protected virtual bool IsContextfulImpl()
		{
			return typeof(ContextBoundObject).IsAssignableFrom(this);
		}

		// Token: 0x170000D1 RID: 209
		// (get) Token: 0x060009FB RID: 2555 RVA: 0x0000B18D File Offset: 0x0000938D
		public virtual bool IsCollectible
		{
			get
			{
				return true;
			}
		}

		/// <summary>Gets a value indicating whether the current <see cref="T:System.Type" /> represents an enumeration.</summary>
		/// <returns>
		///     <see langword="true" /> if the current <see cref="T:System.Type" /> represents an enumeration; otherwise, <see langword="false" />.</returns>
		// Token: 0x170000D2 RID: 210
		// (get) Token: 0x060009FC RID: 2556 RVA: 0x0002ADF8 File Offset: 0x00028FF8
		public virtual bool IsEnum
		{
			get
			{
				return this.IsSubclassOf(typeof(Enum));
			}
		}

		/// <summary>Gets a value indicating whether the <see cref="T:System.Type" /> is marshaled by reference.</summary>
		/// <returns>
		///     <see langword="true" /> if the <see cref="T:System.Type" /> is marshaled by reference; otherwise, <see langword="false" />.</returns>
		// Token: 0x170000D3 RID: 211
		// (get) Token: 0x060009FD RID: 2557 RVA: 0x0002AE0A File Offset: 0x0002900A
		public bool IsMarshalByRef
		{
			get
			{
				return this.IsMarshalByRefImpl();
			}
		}

		/// <summary>Implements the <see cref="P:System.Type.IsMarshalByRef" /> property and determines whether the <see cref="T:System.Type" /> is marshaled by reference.</summary>
		/// <returns>
		///     <see langword="true" /> if the <see cref="T:System.Type" /> is marshaled by reference; otherwise, <see langword="false" />.</returns>
		// Token: 0x060009FE RID: 2558 RVA: 0x0002AE12 File Offset: 0x00029012
		protected virtual bool IsMarshalByRefImpl()
		{
			return typeof(MarshalByRefObject).IsAssignableFrom(this);
		}

		/// <summary>Gets a value indicating whether the <see cref="T:System.Type" /> is one of the primitive types.</summary>
		/// <returns>
		///     <see langword="true" /> if the <see cref="T:System.Type" /> is one of the primitive types; otherwise, <see langword="false" />.</returns>
		// Token: 0x170000D4 RID: 212
		// (get) Token: 0x060009FF RID: 2559 RVA: 0x0002AE24 File Offset: 0x00029024
		public bool IsPrimitive
		{
			get
			{
				return this.IsPrimitiveImpl();
			}
		}

		/// <summary>When overridden in a derived class, implements the <see cref="P:System.Type.IsPrimitive" /> property and determines whether the <see cref="T:System.Type" /> is one of the primitive types.</summary>
		/// <returns>
		///     <see langword="true" /> if the <see cref="T:System.Type" /> is one of the primitive types; otherwise, <see langword="false" />.</returns>
		// Token: 0x06000A00 RID: 2560
		protected abstract bool IsPrimitiveImpl();

		/// <summary>Gets a value indicating whether the <see cref="T:System.Type" /> is a value type.</summary>
		/// <returns>
		///     <see langword="true" /> if the <see cref="T:System.Type" /> is a value type; otherwise, <see langword="false" />.</returns>
		// Token: 0x170000D5 RID: 213
		// (get) Token: 0x06000A01 RID: 2561 RVA: 0x0002AE2C File Offset: 0x0002902C
		public bool IsValueType
		{
			get
			{
				return this.IsValueTypeImpl();
			}
		}

		/// <summary>Implements the <see cref="P:System.Type.IsValueType" /> property and determines whether the <see cref="T:System.Type" /> is a value type; that is, not a class or an interface.</summary>
		/// <returns>
		///     <see langword="true" /> if the <see cref="T:System.Type" /> is a value type; otherwise, <see langword="false" />.</returns>
		// Token: 0x06000A02 RID: 2562 RVA: 0x0002AE34 File Offset: 0x00029034
		protected virtual bool IsValueTypeImpl()
		{
			return this.IsSubclassOf(typeof(ValueType));
		}

		// Token: 0x170000D6 RID: 214
		// (get) Token: 0x06000A03 RID: 2563 RVA: 0x0002ACA4 File Offset: 0x00028EA4
		public virtual bool IsSignatureType
		{
			get
			{
				return false;
			}
		}

		/// <summary>Searches for a public instance constructor whose parameters match the types in the specified array.</summary>
		/// <param name="types">An array of <see cref="T:System.Type" /> objects representing the number, order, and type of the parameters for the desired constructor.-or- An empty array of <see cref="T:System.Type" /> objects, to get a constructor that takes no parameters. Such an empty array is provided by the <see langword="static" /> field <see cref="F:System.Type.EmptyTypes" />.</param>
		/// <returns>An object representing the public instance constructor whose parameters match the types in the parameter type array, if found; otherwise, <see langword="null" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="types" /> is <see langword="null" />.-or- One of the elements in <paramref name="types" /> is <see langword="null" />. </exception>
		/// <exception cref="T:System.ArgumentException">
		///         <paramref name="types" /> is multidimensional. </exception>
		// Token: 0x06000A04 RID: 2564 RVA: 0x0002AE46 File Offset: 0x00029046
		public ConstructorInfo GetConstructor(Type[] types)
		{
			return this.GetConstructor(BindingFlags.Instance | BindingFlags.Public, null, types, null);
		}

		/// <summary>Searches for a constructor whose parameters match the specified argument types and modifiers, using the specified binding constraints.</summary>
		/// <param name="bindingAttr">A bitmask comprised of one or more <see cref="T:System.Reflection.BindingFlags" /> that specify how the search is conducted.-or- Zero, to return <see langword="null" />. </param>
		/// <param name="binder">An object that defines a set of properties and enables binding, which can involve selection of an overloaded method, coercion of argument types, and invocation of a member through reflection.-or- A null reference (<see langword="Nothing" /> in Visual Basic), to use the <see cref="P:System.Type.DefaultBinder" />. </param>
		/// <param name="types">An array of <see cref="T:System.Type" /> objects representing the number, order, and type of the parameters for the constructor to get.-or- An empty array of the type <see cref="T:System.Type" /> (that is, Type[] types = new Type[0]) to get a constructor that takes no parameters.-or- 
		///       <see cref="F:System.Type.EmptyTypes" />. </param>
		/// <param name="modifiers">An array of <see cref="T:System.Reflection.ParameterModifier" /> objects representing the attributes associated with the corresponding element in the parameter type array. The default binder does not process this parameter. </param>
		/// <returns>A <see cref="T:System.Reflection.ConstructorInfo" /> object representing the constructor that matches the specified requirements, if found; otherwise, <see langword="null" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="types" /> is <see langword="null" />.-or- One of the elements in <paramref name="types" /> is <see langword="null" />. </exception>
		/// <exception cref="T:System.ArgumentException">
		///         <paramref name="types" /> is multidimensional.-or- 
		///         <paramref name="modifiers" /> is multidimensional.-or- 
		///         <paramref name="types" /> and <paramref name="modifiers" /> do not have the same length. </exception>
		// Token: 0x06000A05 RID: 2565 RVA: 0x0002AE53 File Offset: 0x00029053
		public ConstructorInfo GetConstructor(BindingFlags bindingAttr, Binder binder, Type[] types, ParameterModifier[] modifiers)
		{
			return this.GetConstructor(bindingAttr, binder, CallingConventions.Any, types, modifiers);
		}

		/// <summary>Searches for a constructor whose parameters match the specified argument types and modifiers, using the specified binding constraints and the specified calling convention.</summary>
		/// <param name="bindingAttr">A bitmask comprised of one or more <see cref="T:System.Reflection.BindingFlags" /> that specify how the search is conducted.-or- Zero, to return <see langword="null" />. </param>
		/// <param name="binder">An object that defines a set of properties and enables binding, which can involve selection of an overloaded method, coercion of argument types, and invocation of a member through reflection.-or- A null reference (<see langword="Nothing" /> in Visual Basic), to use the <see cref="P:System.Type.DefaultBinder" />. </param>
		/// <param name="callConvention">The object that specifies the set of rules to use regarding the order and layout of arguments, how the return value is passed, what registers are used for arguments, and the stack is cleaned up. </param>
		/// <param name="types">An array of <see cref="T:System.Type" /> objects representing the number, order, and type of the parameters for the constructor to get.-or- An empty array of the type <see cref="T:System.Type" /> (that is, Type[] types = new Type[0]) to get a constructor that takes no parameters. </param>
		/// <param name="modifiers">An array of <see cref="T:System.Reflection.ParameterModifier" /> objects representing the attributes associated with the corresponding element in the <paramref name="types" /> array. The default binder does not process this parameter. </param>
		/// <returns>An object representing the constructor that matches the specified requirements, if found; otherwise, <see langword="null" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="types" /> is <see langword="null" />.-or- One of the elements in <paramref name="types" /> is <see langword="null" />. </exception>
		/// <exception cref="T:System.ArgumentException">
		///         <paramref name="types" /> is multidimensional.-or- 
		///         <paramref name="modifiers" /> is multidimensional.-or- 
		///         <paramref name="types" /> and <paramref name="modifiers" /> do not have the same length. </exception>
		// Token: 0x06000A06 RID: 2566 RVA: 0x0002AE64 File Offset: 0x00029064
		public ConstructorInfo GetConstructor(BindingFlags bindingAttr, Binder binder, CallingConventions callConvention, Type[] types, ParameterModifier[] modifiers)
		{
			if (types == null)
			{
				throw new ArgumentNullException("types");
			}
			for (int i = 0; i < types.Length; i++)
			{
				if (types[i] == null)
				{
					throw new ArgumentNullException("types");
				}
			}
			return this.GetConstructorImpl(bindingAttr, binder, callConvention, types, modifiers);
		}

		/// <summary>When overridden in a derived class, searches for a constructor whose parameters match the specified argument types and modifiers, using the specified binding constraints and the specified calling convention.</summary>
		/// <param name="bindingAttr">A bitmask comprised of one or more <see cref="T:System.Reflection.BindingFlags" /> that specify how the search is conducted.-or- Zero, to return <see langword="null" />. </param>
		/// <param name="binder">An object that defines a set of properties and enables binding, which can involve selection of an overloaded method, coercion of argument types, and invocation of a member through reflection.-or- A null reference (<see langword="Nothing" /> in Visual Basic), to use the <see cref="P:System.Type.DefaultBinder" />. </param>
		/// <param name="callConvention">The object that specifies the set of rules to use regarding the order and layout of arguments, how the return value is passed, what registers are used for arguments, and the stack is cleaned up. </param>
		/// <param name="types">An array of <see cref="T:System.Type" /> objects representing the number, order, and type of the parameters for the constructor to get.-or- An empty array of the type <see cref="T:System.Type" /> (that is, Type[] types = new Type[0]) to get a constructor that takes no parameters. </param>
		/// <param name="modifiers">An array of <see cref="T:System.Reflection.ParameterModifier" /> objects representing the attributes associated with the corresponding element in the <paramref name="types" /> array. The default binder does not process this parameter. </param>
		/// <returns>A <see cref="T:System.Reflection.ConstructorInfo" /> object representing the constructor that matches the specified requirements, if found; otherwise, <see langword="null" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="types" /> is <see langword="null" />.-or- One of the elements in <paramref name="types" /> is <see langword="null" />. </exception>
		/// <exception cref="T:System.ArgumentException">
		///         <paramref name="types" /> is multidimensional.-or- 
		///         <paramref name="modifiers" /> is multidimensional.-or- 
		///         <paramref name="types" /> and <paramref name="modifiers" /> do not have the same length. </exception>
		/// <exception cref="T:System.NotSupportedException">The current type is a <see cref="T:System.Reflection.Emit.TypeBuilder" /> or <see cref="T:System.Reflection.Emit.GenericTypeParameterBuilder" />.</exception>
		// Token: 0x06000A07 RID: 2567
		protected abstract ConstructorInfo GetConstructorImpl(BindingFlags bindingAttr, Binder binder, CallingConventions callConvention, Type[] types, ParameterModifier[] modifiers);

		/// <summary>Returns all the public constructors defined for the current <see cref="T:System.Type" />.</summary>
		/// <returns>An array of <see cref="T:System.Reflection.ConstructorInfo" /> objects representing all the public instance constructors defined for the current <see cref="T:System.Type" />, but not including the type initializer (static constructor). If no public instance constructors are defined for the current <see cref="T:System.Type" />, or if the current <see cref="T:System.Type" /> represents a type parameter in the definition of a generic type or generic method, an empty array of type <see cref="T:System.Reflection.ConstructorInfo" /> is returned.</returns>
		// Token: 0x06000A08 RID: 2568 RVA: 0x0002AEB3 File Offset: 0x000290B3
		public ConstructorInfo[] GetConstructors()
		{
			return this.GetConstructors(BindingFlags.Instance | BindingFlags.Public);
		}

		/// <summary>When overridden in a derived class, searches for the constructors defined for the current <see cref="T:System.Type" />, using the specified <see langword="BindingFlags" />.</summary>
		/// <param name="bindingAttr">A bitmask comprised of one or more <see cref="T:System.Reflection.BindingFlags" /> that specify how the search is conducted.-or- Zero, to return <see langword="null" />. </param>
		/// <returns>
		///
		///
		///     An array of <see cref="T:System.Reflection.ConstructorInfo" /> objects representing all constructors defined for the current <see cref="T:System.Type" /> that match the specified binding constraints, including the type initializer if it is defined. Returns an empty array of type <see cref="T:System.Reflection.ConstructorInfo" /> if no constructors are defined for the current <see cref="T:System.Type" />, if none of the defined constructors match the binding constraints, or if the current <see cref="T:System.Type" /> represents a type parameter in the definition of a generic type or generic method.</returns>
		// Token: 0x06000A09 RID: 2569
		public abstract ConstructorInfo[] GetConstructors(BindingFlags bindingAttr);

		/// <summary>Returns the <see cref="T:System.Reflection.EventInfo" /> object representing the specified public event.</summary>
		/// <param name="name">The string containing the name of an event that is declared or inherited by the current <see cref="T:System.Type" />. </param>
		/// <returns>The object representing the specified public event that is declared or inherited by the current <see cref="T:System.Type" />, if found; otherwise, <see langword="null" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="name" /> is <see langword="null" />. </exception>
		// Token: 0x06000A0A RID: 2570 RVA: 0x0002AEBD File Offset: 0x000290BD
		public EventInfo GetEvent(string name)
		{
			return this.GetEvent(name, BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public);
		}

		/// <summary>When overridden in a derived class, returns the <see cref="T:System.Reflection.EventInfo" /> object representing the specified event, using the specified binding constraints.</summary>
		/// <param name="name">The string containing the name of an event which is declared or inherited by the current <see cref="T:System.Type" />. </param>
		/// <param name="bindingAttr">A bitmask comprised of one or more <see cref="T:System.Reflection.BindingFlags" /> that specify how the search is conducted.-or- Zero, to return <see langword="null" />. </param>
		/// <returns>The object representing the specified event that is declared or inherited by the current <see cref="T:System.Type" />, if found; otherwise, <see langword="null" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="name" /> is <see langword="null" />. </exception>
		// Token: 0x06000A0B RID: 2571
		public abstract EventInfo GetEvent(string name, BindingFlags bindingAttr);

		/// <summary>When overridden in a derived class, searches for events that are declared or inherited by the current <see cref="T:System.Type" />, using the specified binding constraints.</summary>
		/// <param name="bindingAttr">A bitmask comprised of one or more <see cref="T:System.Reflection.BindingFlags" /> that specify how the search is conducted.-or- Zero, to return <see langword="null" />. </param>
		/// <returns>An array of <see cref="T:System.Reflection.EventInfo" /> objects representing all events that are declared or inherited by the current <see cref="T:System.Type" /> that match the specified binding constraints.-or- An empty array of type <see cref="T:System.Reflection.EventInfo" />, if the current <see cref="T:System.Type" /> does not have events, or if none of the events match the binding constraints.</returns>
		// Token: 0x06000A0C RID: 2572
		public abstract EventInfo[] GetEvents(BindingFlags bindingAttr);

		/// <summary>Searches for the public field with the specified name.</summary>
		/// <param name="name">The string containing the name of the data field to get. </param>
		/// <returns>An object representing the public field with the specified name, if found; otherwise, <see langword="null" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="name" /> is <see langword="null" />. </exception>
		/// <exception cref="T:System.NotSupportedException">This <see cref="T:System.Type" /> object is a <see cref="T:System.Reflection.Emit.TypeBuilder" /> whose <see cref="M:System.Reflection.Emit.TypeBuilder.CreateType" /> method has not yet been called. </exception>
		// Token: 0x06000A0D RID: 2573 RVA: 0x0002AEC8 File Offset: 0x000290C8
		public FieldInfo GetField(string name)
		{
			return this.GetField(name, BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public);
		}

		/// <summary>Searches for the specified field, using the specified binding constraints.</summary>
		/// <param name="name">The string containing the name of the data field to get. </param>
		/// <param name="bindingAttr">A bitmask comprised of one or more <see cref="T:System.Reflection.BindingFlags" /> that specify how the search is conducted.-or- Zero, to return <see langword="null" />. </param>
		/// <returns>An object representing the field that matches the specified requirements, if found; otherwise, <see langword="null" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="name" /> is <see langword="null" />. </exception>
		// Token: 0x06000A0E RID: 2574
		public abstract FieldInfo GetField(string name, BindingFlags bindingAttr);

		/// <summary>Returns all the public fields of the current <see cref="T:System.Type" />.</summary>
		/// <returns>An array of <see cref="T:System.Reflection.FieldInfo" /> objects representing all the public fields defined for the current <see cref="T:System.Type" />.-or- An empty array of type <see cref="T:System.Reflection.FieldInfo" />, if no public fields are defined for the current <see cref="T:System.Type" />.</returns>
		// Token: 0x06000A0F RID: 2575 RVA: 0x0002AED3 File Offset: 0x000290D3
		public FieldInfo[] GetFields()
		{
			return this.GetFields(BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public);
		}

		/// <summary>When overridden in a derived class, searches for the fields defined for the current <see cref="T:System.Type" />, using the specified binding constraints.</summary>
		/// <param name="bindingAttr">A bitmask comprised of one or more <see cref="T:System.Reflection.BindingFlags" /> that specify how the search is conducted.-or- Zero, to return <see langword="null" />. </param>
		/// <returns>An array of <see cref="T:System.Reflection.FieldInfo" /> objects representing all fields defined for the current <see cref="T:System.Type" /> that match the specified binding constraints.-or- An empty array of type <see cref="T:System.Reflection.FieldInfo" />, if no fields are defined for the current <see cref="T:System.Type" />, or if none of the defined fields match the binding constraints.</returns>
		// Token: 0x06000A10 RID: 2576
		public abstract FieldInfo[] GetFields(BindingFlags bindingAttr);

		/// <summary>Searches for the public members with the specified name.</summary>
		/// <param name="name">The string containing the name of the public members to get. </param>
		/// <returns>An array of <see cref="T:System.Reflection.MemberInfo" /> objects representing the public members with the specified name, if found; otherwise, an empty array.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="name" /> is <see langword="null" />. </exception>
		// Token: 0x06000A11 RID: 2577 RVA: 0x0002AEDD File Offset: 0x000290DD
		public MemberInfo[] GetMember(string name)
		{
			return this.GetMember(name, BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public);
		}

		/// <summary>Searches for the specified members, using the specified binding constraints.</summary>
		/// <param name="name">The string containing the name of the members to get. </param>
		/// <param name="bindingAttr">A bitmask comprised of one or more <see cref="T:System.Reflection.BindingFlags" /> that specify how the search is conducted.-or- Zero, to return an empty array. </param>
		/// <returns>An array of <see cref="T:System.Reflection.MemberInfo" /> objects representing the public members with the specified name, if found; otherwise, an empty array.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="name" /> is <see langword="null" />. </exception>
		// Token: 0x06000A12 RID: 2578 RVA: 0x0002AEE8 File Offset: 0x000290E8
		public virtual MemberInfo[] GetMember(string name, BindingFlags bindingAttr)
		{
			return this.GetMember(name, MemberTypes.All, bindingAttr);
		}

		/// <summary>Searches for the specified members of the specified member type, using the specified binding constraints.</summary>
		/// <param name="name">The string containing the name of the members to get. </param>
		/// <param name="type">The value to search for. </param>
		/// <param name="bindingAttr">A bitmask comprised of one or more <see cref="T:System.Reflection.BindingFlags" /> that specify how the search is conducted.-or- Zero, to return an empty array. </param>
		/// <returns>An array of <see cref="T:System.Reflection.MemberInfo" /> objects representing the public members with the specified name, if found; otherwise, an empty array.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="name" /> is <see langword="null" />. </exception>
		/// <exception cref="T:System.NotSupportedException">A derived class must provide an implementation. </exception>
		// Token: 0x06000A13 RID: 2579 RVA: 0x0002ACDC File Offset: 0x00028EDC
		public virtual MemberInfo[] GetMember(string name, MemberTypes type, BindingFlags bindingAttr)
		{
			throw new NotSupportedException("Derived classes must provide an implementation.");
		}

		/// <summary>Searches for the public method with the specified name.</summary>
		/// <param name="name">The string containing the name of the public method to get. </param>
		/// <returns>An object that represents the public method with the specified name, if found; otherwise, <see langword="null" />.</returns>
		/// <exception cref="T:System.Reflection.AmbiguousMatchException">More than one method is found with the specified name. </exception>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="name" /> is <see langword="null" />. </exception>
		// Token: 0x06000A14 RID: 2580 RVA: 0x0002AEF7 File Offset: 0x000290F7
		public MethodInfo GetMethod(string name)
		{
			return this.GetMethod(name, BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public);
		}

		/// <summary>Searches for the specified method, using the specified binding constraints.</summary>
		/// <param name="name">The string containing the name of the method to get. </param>
		/// <param name="bindingAttr">A bitmask comprised of one or more <see cref="T:System.Reflection.BindingFlags" /> that specify how the search is conducted.-or- Zero, to return <see langword="null" />. </param>
		/// <returns>An object representing the method that matches the specified requirements, if found; otherwise, <see langword="null" />.</returns>
		/// <exception cref="T:System.Reflection.AmbiguousMatchException">More than one method is found with the specified name and matching the specified binding constraints. </exception>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="name" /> is <see langword="null" />. </exception>
		// Token: 0x06000A15 RID: 2581 RVA: 0x0002AF02 File Offset: 0x00029102
		public MethodInfo GetMethod(string name, BindingFlags bindingAttr)
		{
			if (name == null)
			{
				throw new ArgumentNullException("name");
			}
			return this.GetMethodImpl(name, bindingAttr, null, CallingConventions.Any, null, null);
		}

		/// <summary>Searches for the specified public method whose parameters match the specified argument types.</summary>
		/// <param name="name">The string containing the name of the public method to get. </param>
		/// <param name="types">An array of <see cref="T:System.Type" /> objects representing the number, order, and type of the parameters for the method to get.-or- An empty array of <see cref="T:System.Type" /> objects (as provided by the <see cref="F:System.Type.EmptyTypes" /> field) to get a method that takes no parameters. </param>
		/// <returns>An object representing the public method whose parameters match the specified argument types, if found; otherwise, <see langword="null" />.</returns>
		/// <exception cref="T:System.Reflection.AmbiguousMatchException">More than one method is found with the specified name and specified parameters. </exception>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="name" /> is <see langword="null" />.-or- 
		///         <paramref name="types" /> is <see langword="null" />.-or- One of the elements in <paramref name="types" /> is <see langword="null" />. </exception>
		/// <exception cref="T:System.ArgumentException">
		///         <paramref name="types" /> is multidimensional. </exception>
		// Token: 0x06000A16 RID: 2582 RVA: 0x0002AF1E File Offset: 0x0002911E
		public MethodInfo GetMethod(string name, Type[] types)
		{
			return this.GetMethod(name, types, null);
		}

		/// <summary>Searches for the specified public method whose parameters match the specified argument types and modifiers.</summary>
		/// <param name="name">The string containing the name of the public method to get. </param>
		/// <param name="types">An array of <see cref="T:System.Type" /> objects representing the number, order, and type of the parameters for the method to get.-or- An empty array of <see cref="T:System.Type" /> objects (as provided by the <see cref="F:System.Type.EmptyTypes" /> field) to get a method that takes no parameters. </param>
		/// <param name="modifiers">An array of <see cref="T:System.Reflection.ParameterModifier" /> objects representing the attributes associated with the corresponding element in the <paramref name="types" /> array. To be only used when calling through COM interop, and only parameters that are passed by reference are handled. The default binder does not process this parameter.</param>
		/// <returns>An object representing the public method that matches the specified requirements, if found; otherwise, <see langword="null" />.</returns>
		/// <exception cref="T:System.Reflection.AmbiguousMatchException">More than one method is found with the specified name and specified parameters. </exception>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="name" /> is <see langword="null" />.-or- 
		///         <paramref name="types" /> is <see langword="null" />.-or- One of the elements in <paramref name="types" /> is <see langword="null" />. </exception>
		/// <exception cref="T:System.ArgumentException">
		///         <paramref name="types" /> is multidimensional.-or- 
		///         <paramref name="modifiers" /> is multidimensional.</exception>
		// Token: 0x06000A17 RID: 2583 RVA: 0x0002AF29 File Offset: 0x00029129
		public MethodInfo GetMethod(string name, Type[] types, ParameterModifier[] modifiers)
		{
			return this.GetMethod(name, BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public, null, types, modifiers);
		}

		/// <summary>Searches for the specified method whose parameters match the specified argument types and modifiers, using the specified binding constraints.</summary>
		/// <param name="name">The string containing the name of the method to get. </param>
		/// <param name="bindingAttr">A bitmask comprised of one or more <see cref="T:System.Reflection.BindingFlags" /> that specify how the search is conducted.-or- Zero, to return <see langword="null" />. </param>
		/// <param name="binder">An object that defines a set of properties and enables binding, which can involve selection of an overloaded method, coercion of argument types, and invocation of a member through reflection.-or- A null reference (<see langword="Nothing" /> in Visual Basic), to use the <see cref="P:System.Type.DefaultBinder" />. </param>
		/// <param name="types">An array of <see cref="T:System.Type" /> objects representing the number, order, and type of the parameters for the method to get.-or- An empty array of <see cref="T:System.Type" /> objects (as provided by the <see cref="F:System.Type.EmptyTypes" /> field) to get a method that takes no parameters. </param>
		/// <param name="modifiers">An array of <see cref="T:System.Reflection.ParameterModifier" /> objects representing the attributes associated with the corresponding element in the <paramref name="types" /> array. To be only used when calling through COM interop, and only parameters that are passed by reference are handled. The default binder does not process this parameter.</param>
		/// <returns>An object representing the method that matches the specified requirements, if found; otherwise, <see langword="null" />.</returns>
		/// <exception cref="T:System.Reflection.AmbiguousMatchException">More than one method is found with the specified name and matching the specified binding constraints. </exception>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="name" /> is <see langword="null" />.-or- 
		///         <paramref name="types" /> is <see langword="null" />.-or- One of the elements in <paramref name="types" /> is <see langword="null" />. </exception>
		/// <exception cref="T:System.ArgumentException">
		///         <paramref name="types" /> is multidimensional.-or- 
		///         <paramref name="modifiers" /> is multidimensional.</exception>
		// Token: 0x06000A18 RID: 2584 RVA: 0x0002AF37 File Offset: 0x00029137
		public MethodInfo GetMethod(string name, BindingFlags bindingAttr, Binder binder, Type[] types, ParameterModifier[] modifiers)
		{
			return this.GetMethod(name, bindingAttr, binder, CallingConventions.Any, types, modifiers);
		}

		/// <summary>Searches for the specified method whose parameters match the specified argument types and modifiers, using the specified binding constraints and the specified calling convention.</summary>
		/// <param name="name">The string containing the name of the method to get. </param>
		/// <param name="bindingAttr">A bitmask comprised of one or more <see cref="T:System.Reflection.BindingFlags" /> that specify how the search is conducted.-or- Zero, to return <see langword="null" />. </param>
		/// <param name="binder">An object that defines a set of properties and enables binding, which can involve selection of an overloaded method, coercion of argument types, and invocation of a member through reflection.-or- A null reference (<see langword="Nothing" /> in Visual Basic), to use the <see cref="P:System.Type.DefaultBinder" />. </param>
		/// <param name="callConvention">The object that specifies the set of rules to use regarding the order and layout of arguments, how the return value is passed, what registers are used for arguments, and how the stack is cleaned up. </param>
		/// <param name="types">An array of <see cref="T:System.Type" /> objects representing the number, order, and type of the parameters for the method to get.-or- An empty array of <see cref="T:System.Type" /> objects (as provided by the <see cref="F:System.Type.EmptyTypes" /> field) to get a method that takes no parameters. </param>
		/// <param name="modifiers">An array of <see cref="T:System.Reflection.ParameterModifier" /> objects representing the attributes associated with the corresponding element in the <paramref name="types" /> array. To be only used when calling through COM interop, and only parameters that are passed by reference are handled. The default binder does not process this parameter.</param>
		/// <returns>An object representing the method that matches the specified requirements, if found; otherwise, <see langword="null" />.</returns>
		/// <exception cref="T:System.Reflection.AmbiguousMatchException">More than one method is found with the specified name and matching the specified binding constraints. </exception>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="name" /> is <see langword="null" />.-or- 
		///         <paramref name="types" /> is <see langword="null" />.-or- One of the elements in <paramref name="types" /> is <see langword="null" />. </exception>
		/// <exception cref="T:System.ArgumentException">
		///         <paramref name="types" /> is multidimensional.-or- 
		///         <paramref name="modifiers" /> is multidimensional.</exception>
		// Token: 0x06000A19 RID: 2585 RVA: 0x0002AF48 File Offset: 0x00029148
		public MethodInfo GetMethod(string name, BindingFlags bindingAttr, Binder binder, CallingConventions callConvention, Type[] types, ParameterModifier[] modifiers)
		{
			if (name == null)
			{
				throw new ArgumentNullException("name");
			}
			if (types == null)
			{
				throw new ArgumentNullException("types");
			}
			for (int i = 0; i < types.Length; i++)
			{
				if (types[i] == null)
				{
					throw new ArgumentNullException("types");
				}
			}
			return this.GetMethodImpl(name, bindingAttr, binder, callConvention, types, modifiers);
		}

		/// <summary>When overridden in a derived class, searches for the specified method whose parameters match the specified argument types and modifiers, using the specified binding constraints and the specified calling convention.</summary>
		/// <param name="name">The string containing the name of the method to get. </param>
		/// <param name="bindingAttr">A bitmask comprised of one or more <see cref="T:System.Reflection.BindingFlags" /> that specify how the search is conducted.-or- Zero, to return <see langword="null" />. </param>
		/// <param name="binder">An object that defines a set of properties and enables binding, which can involve selection of an overloaded method, coercion of argument types, and invocation of a member through reflection.-or- A null reference (<see langword="Nothing" /> in Visual Basic), to use the <see cref="P:System.Type.DefaultBinder" />. </param>
		/// <param name="callConvention">The object that specifies the set of rules to use regarding the order and layout of arguments, how the return value is passed, what registers are used for arguments, and what process cleans up the stack. </param>
		/// <param name="types">An array of <see cref="T:System.Type" /> objects representing the number, order, and type of the parameters for the method to get.-or- An empty array of the type <see cref="T:System.Type" /> (that is, Type[] types = new Type[0]) to get a method that takes no parameters.-or- 
		///       <see langword="null" />. If <paramref name="types" /> is <see langword="null" />, arguments are not matched. </param>
		/// <param name="modifiers">An array of <see cref="T:System.Reflection.ParameterModifier" /> objects representing the attributes associated with the corresponding element in the <paramref name="types" /> array. The default binder does not process this parameter. </param>
		/// <returns>An object representing the method that matches the specified requirements, if found; otherwise, <see langword="null" />.</returns>
		/// <exception cref="T:System.Reflection.AmbiguousMatchException">More than one method is found with the specified name and matching the specified binding constraints. </exception>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="name" /> is <see langword="null" />. </exception>
		/// <exception cref="T:System.ArgumentException">
		///         <paramref name="types" /> is multidimensional.-or- 
		///         <paramref name="modifiers" /> is multidimensional.-or- 
		///         <paramref name="types" /> and <paramref name="modifiers" /> do not have the same length. </exception>
		/// <exception cref="T:System.NotSupportedException">The current type is a <see cref="T:System.Reflection.Emit.TypeBuilder" /> or <see cref="T:System.Reflection.Emit.GenericTypeParameterBuilder" />.</exception>
		// Token: 0x06000A1A RID: 2586
		protected abstract MethodInfo GetMethodImpl(string name, BindingFlags bindingAttr, Binder binder, CallingConventions callConvention, Type[] types, ParameterModifier[] modifiers);

		/// <summary>Returns all the public methods of the current <see cref="T:System.Type" />.</summary>
		/// <returns>An array of <see cref="T:System.Reflection.MethodInfo" /> objects representing all the public methods defined for the current <see cref="T:System.Type" />.-or- An empty array of type <see cref="T:System.Reflection.MethodInfo" />, if no public methods are defined for the current <see cref="T:System.Type" />.</returns>
		// Token: 0x06000A1B RID: 2587 RVA: 0x0002AFA7 File Offset: 0x000291A7
		public MethodInfo[] GetMethods()
		{
			return this.GetMethods(BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public);
		}

		/// <summary>When overridden in a derived class, searches for the methods defined for the current <see cref="T:System.Type" />, using the specified binding constraints.</summary>
		/// <param name="bindingAttr">A bitmask comprised of one or more <see cref="T:System.Reflection.BindingFlags" /> that specify how the search is conducted.-or- Zero, to return <see langword="null" />. </param>
		/// <returns>An array of <see cref="T:System.Reflection.MethodInfo" /> objects representing all methods defined for the current <see cref="T:System.Type" /> that match the specified binding constraints.-or- An empty array of type <see cref="T:System.Reflection.MethodInfo" />, if no methods are defined for the current <see cref="T:System.Type" />, or if none of the defined methods match the binding constraints.</returns>
		// Token: 0x06000A1C RID: 2588
		public abstract MethodInfo[] GetMethods(BindingFlags bindingAttr);

		/// <summary>When overridden in a derived class, searches for the specified nested type, using the specified binding constraints.</summary>
		/// <param name="name">The string containing the name of the nested type to get. </param>
		/// <param name="bindingAttr">A bitmask comprised of one or more <see cref="T:System.Reflection.BindingFlags" /> that specify how the search is conducted.-or- Zero, to return <see langword="null" />. </param>
		/// <returns>An object representing the nested type that matches the specified requirements, if found; otherwise, <see langword="null" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="name" /> is <see langword="null" />. </exception>
		// Token: 0x06000A1D RID: 2589
		public abstract Type GetNestedType(string name, BindingFlags bindingAttr);

		/// <summary>Searches for the public property with the specified name.</summary>
		/// <param name="name">The string containing the name of the public property to get. </param>
		/// <returns>An object representing the public property with the specified name, if found; otherwise, <see langword="null" />.</returns>
		/// <exception cref="T:System.Reflection.AmbiguousMatchException">More than one property is found with the specified name. See Remarks.</exception>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="name" /> is <see langword="null" />. </exception>
		// Token: 0x06000A1E RID: 2590 RVA: 0x0002AFB1 File Offset: 0x000291B1
		public PropertyInfo GetProperty(string name)
		{
			return this.GetProperty(name, BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public);
		}

		/// <summary>Searches for the specified property, using the specified binding constraints.</summary>
		/// <param name="name">The string containing the name of the property to get. </param>
		/// <param name="bindingAttr">A bitmask comprised of one or more <see cref="T:System.Reflection.BindingFlags" /> that specify how the search is conducted.-or- Zero, to return <see langword="null" />. </param>
		/// <returns>An object representing the property that matches the specified requirements, if found; otherwise, <see langword="null" />.</returns>
		/// <exception cref="T:System.Reflection.AmbiguousMatchException">More than one property is found with the specified name and matching the specified binding constraints. See Remarks.</exception>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="name" /> is <see langword="null" />. </exception>
		// Token: 0x06000A1F RID: 2591 RVA: 0x0002AFBC File Offset: 0x000291BC
		public PropertyInfo GetProperty(string name, BindingFlags bindingAttr)
		{
			if (name == null)
			{
				throw new ArgumentNullException("name");
			}
			return this.GetPropertyImpl(name, bindingAttr, null, null, null, null);
		}

		/// <summary>Searches for the public property with the specified name and return type.</summary>
		/// <param name="name">The string containing the name of the public property to get. </param>
		/// <param name="returnType">The return type of the property. </param>
		/// <returns>An object representing the public property with the specified name, if found; otherwise, <see langword="null" />.</returns>
		/// <exception cref="T:System.Reflection.AmbiguousMatchException">More than one property is found with the specified name. </exception>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="name" /> is <see langword="null" />, or <paramref name="returnType" /> is <see langword="null" />. </exception>
		// Token: 0x06000A20 RID: 2592 RVA: 0x0002AFD8 File Offset: 0x000291D8
		public PropertyInfo GetProperty(string name, Type returnType)
		{
			if (name == null)
			{
				throw new ArgumentNullException("name");
			}
			if (returnType == null)
			{
				throw new ArgumentNullException("returnType");
			}
			return this.GetPropertyImpl(name, BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public, null, returnType, null, null);
		}

		/// <summary>Searches for the specified public property whose parameters match the specified argument types.</summary>
		/// <param name="name">The string containing the name of the public property to get. </param>
		/// <param name="returnType">The return type of the property. </param>
		/// <param name="types">An array of <see cref="T:System.Type" /> objects representing the number, order, and type of the parameters for the indexed property to get.-or- An empty array of the type <see cref="T:System.Type" /> (that is, Type[] types = new Type[0]) to get a property that is not indexed. </param>
		/// <returns>An object representing the public property whose parameters match the specified argument types, if found; otherwise, <see langword="null" />.</returns>
		/// <exception cref="T:System.Reflection.AmbiguousMatchException">More than one property is found with the specified name and matching the specified argument types. </exception>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="name" /> is <see langword="null" />.-or- 
		///         <paramref name="types" /> is <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">
		///         <paramref name="types" /> is multidimensional. </exception>
		/// <exception cref="T:System.NullReferenceException">An element of <paramref name="types" /> is <see langword="null" />.</exception>
		// Token: 0x06000A21 RID: 2593 RVA: 0x0002B009 File Offset: 0x00029209
		public PropertyInfo GetProperty(string name, Type returnType, Type[] types)
		{
			return this.GetProperty(name, returnType, types, null);
		}

		/// <summary>Searches for the specified public property whose parameters match the specified argument types and modifiers.</summary>
		/// <param name="name">The string containing the name of the public property to get. </param>
		/// <param name="returnType">The return type of the property. </param>
		/// <param name="types">An array of <see cref="T:System.Type" /> objects representing the number, order, and type of the parameters for the indexed property to get.-or- An empty array of the type <see cref="T:System.Type" /> (that is, Type[] types = new Type[0]) to get a property that is not indexed. </param>
		/// <param name="modifiers">An array of <see cref="T:System.Reflection.ParameterModifier" /> objects representing the attributes associated with the corresponding element in the <paramref name="types" /> array. The default binder does not process this parameter. </param>
		/// <returns>An object representing the public property that matches the specified requirements, if found; otherwise, <see langword="null" />.</returns>
		/// <exception cref="T:System.Reflection.AmbiguousMatchException">More than one property is found with the specified name and matching the specified argument types and modifiers. </exception>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="name" /> is <see langword="null" />.-or- 
		///         <paramref name="types" /> is <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">
		///         <paramref name="types" /> is multidimensional.-or- 
		///         <paramref name="modifiers" /> is multidimensional.-or- 
		///         <paramref name="types" /> and <paramref name="modifiers" /> do not have the same length. </exception>
		/// <exception cref="T:System.NullReferenceException">An element of <paramref name="types" /> is <see langword="null" />.</exception>
		// Token: 0x06000A22 RID: 2594 RVA: 0x0002B015 File Offset: 0x00029215
		public PropertyInfo GetProperty(string name, Type returnType, Type[] types, ParameterModifier[] modifiers)
		{
			return this.GetProperty(name, BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public, null, returnType, types, modifiers);
		}

		/// <summary>Searches for the specified property whose parameters match the specified argument types and modifiers, using the specified binding constraints.</summary>
		/// <param name="name">The string containing the name of the property to get. </param>
		/// <param name="bindingAttr">A bitmask comprised of one or more <see cref="T:System.Reflection.BindingFlags" /> that specify how the search is conducted.-or- Zero, to return <see langword="null" />. </param>
		/// <param name="binder">An object that defines a set of properties and enables binding, which can involve selection of an overloaded method, coercion of argument types, and invocation of a member through reflection.-or- A null reference (<see langword="Nothing" /> in Visual Basic), to use the <see cref="P:System.Type.DefaultBinder" />. </param>
		/// <param name="returnType">The return type of the property. </param>
		/// <param name="types">An array of <see cref="T:System.Type" /> objects representing the number, order, and type of the parameters for the indexed property to get.-or- An empty array of the type <see cref="T:System.Type" /> (that is, Type[] types = new Type[0]) to get a property that is not indexed. </param>
		/// <param name="modifiers">An array of <see cref="T:System.Reflection.ParameterModifier" /> objects representing the attributes associated with the corresponding element in the <paramref name="types" /> array. The default binder does not process this parameter. </param>
		/// <returns>An object representing the property that matches the specified requirements, if found; otherwise, <see langword="null" />.</returns>
		/// <exception cref="T:System.Reflection.AmbiguousMatchException">More than one property is found with the specified name and matching the specified binding constraints. </exception>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="name" /> is <see langword="null" />.-or- 
		///         <paramref name="types" /> is <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">
		///         <paramref name="types" /> is multidimensional.-or- 
		///         <paramref name="modifiers" /> is multidimensional.-or- 
		///         <paramref name="types" /> and <paramref name="modifiers" /> do not have the same length. </exception>
		/// <exception cref="T:System.NullReferenceException">An element of <paramref name="types" /> is <see langword="null" />.</exception>
		// Token: 0x06000A23 RID: 2595 RVA: 0x0002B025 File Offset: 0x00029225
		public PropertyInfo GetProperty(string name, BindingFlags bindingAttr, Binder binder, Type returnType, Type[] types, ParameterModifier[] modifiers)
		{
			if (name == null)
			{
				throw new ArgumentNullException("name");
			}
			if (types == null)
			{
				throw new ArgumentNullException("types");
			}
			return this.GetPropertyImpl(name, bindingAttr, binder, returnType, types, modifiers);
		}

		/// <summary>When overridden in a derived class, searches for the specified property whose parameters match the specified argument types and modifiers, using the specified binding constraints.</summary>
		/// <param name="name">The string containing the name of the property to get. </param>
		/// <param name="bindingAttr">A bitmask comprised of one or more <see cref="T:System.Reflection.BindingFlags" /> that specify how the search is conducted.-or- Zero, to return <see langword="null" />. </param>
		/// <param name="binder">An object that defines a set of properties and enables binding, which can involve selection of an overloaded member, coercion of argument types, and invocation of a member through reflection.-or- A null reference (<see langword="Nothing" /> in Visual Basic), to use the <see cref="P:System.Type.DefaultBinder" />. </param>
		/// <param name="returnType">The return type of the property. </param>
		/// <param name="types">An array of <see cref="T:System.Type" /> objects representing the number, order, and type of the parameters for the indexed property to get.-or- An empty array of the type <see cref="T:System.Type" /> (that is, Type[] types = new Type[0]) to get a property that is not indexed. </param>
		/// <param name="modifiers">An array of <see cref="T:System.Reflection.ParameterModifier" /> objects representing the attributes associated with the corresponding element in the <paramref name="types" /> array. The default binder does not process this parameter. </param>
		/// <returns>An object representing the property that matches the specified requirements, if found; otherwise, <see langword="null" />.</returns>
		/// <exception cref="T:System.Reflection.AmbiguousMatchException">More than one property is found with the specified name and matching the specified binding constraints. </exception>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="name" /> is <see langword="null" />.-or- 
		///         <paramref name="types" /> is <see langword="null" />.-or- One of the elements in <paramref name="types" /> is <see langword="null" />. </exception>
		/// <exception cref="T:System.ArgumentException">
		///         <paramref name="types" /> is multidimensional.-or- 
		///         <paramref name="modifiers" /> is multidimensional.-or- 
		///         <paramref name="types" /> and <paramref name="modifiers" /> do not have the same length. </exception>
		/// <exception cref="T:System.NotSupportedException">The current type is a <see cref="T:System.Reflection.Emit.TypeBuilder" />, <see cref="T:System.Reflection.Emit.EnumBuilder" />, or <see cref="T:System.Reflection.Emit.GenericTypeParameterBuilder" />.</exception>
		// Token: 0x06000A24 RID: 2596
		protected abstract PropertyInfo GetPropertyImpl(string name, BindingFlags bindingAttr, Binder binder, Type returnType, Type[] types, ParameterModifier[] modifiers);

		/// <summary>When overridden in a derived class, searches for the properties of the current <see cref="T:System.Type" />, using the specified binding constraints.</summary>
		/// <param name="bindingAttr">A bitmask comprised of one or more <see cref="T:System.Reflection.BindingFlags" /> that specify how the search is conducted.-or- Zero, to return <see langword="null" />. </param>
		/// <returns>An array of <see cref="T:System.Reflection.PropertyInfo" /> objects representing all properties of the current <see cref="T:System.Type" /> that match the specified binding constraints.-or- An empty array of type <see cref="T:System.Reflection.PropertyInfo" />, if the current <see cref="T:System.Type" /> does not have properties, or if none of the properties match the binding constraints.</returns>
		// Token: 0x06000A25 RID: 2597
		public abstract PropertyInfo[] GetProperties(BindingFlags bindingAttr);

		/// <summary>Gets the handle for the current <see cref="T:System.Type" />.</summary>
		/// <returns>The handle for the current <see cref="T:System.Type" />.</returns>
		/// <exception cref="T:System.NotSupportedException">The .NET Compact Framework does not currently support this property.</exception>
		// Token: 0x170000D7 RID: 215
		// (get) Token: 0x06000A26 RID: 2598 RVA: 0x0002AD12 File Offset: 0x00028F12
		public virtual RuntimeTypeHandle TypeHandle
		{
			get
			{
				throw new NotSupportedException();
			}
		}

		/// <summary>Gets the handle for the <see cref="T:System.Type" /> of a specified object.</summary>
		/// <param name="o">The object for which to get the type handle. </param>
		/// <returns>The handle for the <see cref="T:System.Type" /> of the specified <see cref="T:System.Object" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="o" /> is <see langword="null" />.</exception>
		// Token: 0x06000A27 RID: 2599 RVA: 0x0002B053 File Offset: 0x00029253
		public static RuntimeTypeHandle GetTypeHandle(object o)
		{
			if (o == null)
			{
				throw new ArgumentNullException(null, "Invalid handle.");
			}
			return o.GetType().TypeHandle;
		}

		/// <summary>Gets the underlying type code of the specified <see cref="T:System.Type" />.</summary>
		/// <param name="type">The type whose underlying type code to get. </param>
		/// <returns>The code of the underlying type, or <see cref="F:System.TypeCode.Empty" /> if <paramref name="type" /> is <see langword="null" />.</returns>
		// Token: 0x06000A28 RID: 2600 RVA: 0x0002B06F File Offset: 0x0002926F
		public static TypeCode GetTypeCode(Type type)
		{
			if (type == null)
			{
				return TypeCode.Empty;
			}
			return type.GetTypeCodeImpl();
		}

		/// <summary>Returns the underlying type code of this <see cref="T:System.Type" /> instance.</summary>
		/// <returns>The type code of the underlying type.</returns>
		// Token: 0x06000A29 RID: 2601 RVA: 0x0002B082 File Offset: 0x00029282
		protected virtual TypeCode GetTypeCodeImpl()
		{
			if (this != this.UnderlyingSystemType && this.UnderlyingSystemType != null)
			{
				return Type.GetTypeCode(this.UnderlyingSystemType);
			}
			return TypeCode.Object;
		}

		/// <summary>Gets the GUID associated with the <see cref="T:System.Type" />.</summary>
		/// <returns>The GUID associated with the <see cref="T:System.Type" />.</returns>
		// Token: 0x170000D8 RID: 216
		// (get) Token: 0x06000A2A RID: 2602
		public abstract Guid GUID { get; }

		/// <summary>Gets the type from which the current <see cref="T:System.Type" /> directly inherits.</summary>
		/// <returns>The <see cref="T:System.Type" /> from which the current <see cref="T:System.Type" /> directly inherits, or <see langword="null" /> if the current <see langword="Type" /> represents the <see cref="T:System.Object" /> class or an interface.</returns>
		// Token: 0x170000D9 RID: 217
		// (get) Token: 0x06000A2B RID: 2603
		public abstract Type BaseType { get; }

		/// <summary>When overridden in a derived class, invokes the specified member, using the specified binding constraints and matching the specified argument list, modifiers and culture.</summary>
		/// <param name="name">The string containing the name of the constructor, method, property, or field member to invoke.-or- An empty string ("") to invoke the default member. -or-For <see langword="IDispatch" /> members, a string representing the DispID, for example "[DispID=3]".</param>
		/// <param name="invokeAttr">A bitmask comprised of one or more <see cref="T:System.Reflection.BindingFlags" /> that specify how the search is conducted. The access can be one of the <see langword="BindingFlags" /> such as <see langword="Public" />, <see langword="NonPublic" />, <see langword="Private" />, <see langword="InvokeMethod" />, <see langword="GetField" />, and so on. The type of lookup need not be specified. If the type of lookup is omitted, <see langword="BindingFlags.Public" /> | <see langword="BindingFlags.Instance" /> | <see langword="BindingFlags.Static" /> are used. </param>
		/// <param name="binder">An object that defines a set of properties and enables binding, which can involve selection of an overloaded method, coercion of argument types, and invocation of a member through reflection.-or- A null reference (Nothing in Visual Basic), to use the <see cref="P:System.Type.DefaultBinder" />. Note that explicitly defining a <see cref="T:System.Reflection.Binder" /> object may be required for successfully invoking method overloads with variable arguments.</param>
		/// <param name="target">The object on which to invoke the specified member. </param>
		/// <param name="args">An array containing the arguments to pass to the member to invoke. </param>
		/// <param name="modifiers">An array of <see cref="T:System.Reflection.ParameterModifier" /> objects representing the attributes associated with the corresponding element in the <paramref name="args" /> array. A parameter's associated attributes are stored in the member's signature. The default binder processes this parameter only when calling a COM component. </param>
		/// <param name="culture">The <see cref="T:System.Globalization.CultureInfo" /> object representing the globalization locale to use, which may be necessary for locale-specific conversions, such as converting a numeric String to a Double.-or- A null reference (<see langword="Nothing" /> in Visual Basic) to use the current thread's <see cref="T:System.Globalization.CultureInfo" />. </param>
		/// <param name="namedParameters">An array containing the names of the parameters to which the values in the <paramref name="args" /> array are passed. </param>
		/// <returns>An object representing the return value of the invoked member.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="invokeAttr" />
		///          does not contain <see langword="CreateInstance" /> and <paramref name="name" /> is <see langword="null" />. </exception>
		/// <exception cref="T:System.ArgumentException">
		///         <paramref name="args" /> and <paramref name="modifiers" /> do not have the same length.-or- 
		///         <paramref name="invokeAttr" /> is not a valid <see cref="T:System.Reflection.BindingFlags" /> attribute.-or- 
		///         <paramref name="invokeAttr" /> does not contain one of the following binding flags: <see langword="InvokeMethod" />, <see langword="CreateInstance" />, <see langword="GetField" />, <see langword="SetField" />, <see langword="GetProperty" />, or <see langword="SetProperty" />.-or- 
		///         <paramref name="invokeAttr" /> contains <see langword="CreateInstance" /> combined with <see langword="InvokeMethod" />, <see langword="GetField" />, <see langword="SetField" />, <see langword="GetProperty" />, or <see langword="SetProperty" />.-or- 
		///         <paramref name="invokeAttr" /> contains both <see langword="GetField" /> and <see langword="SetField" />.-or- 
		///         <paramref name="invokeAttr" /> contains both <see langword="GetProperty" /> and <see langword="SetProperty" />.-or- 
		///         <paramref name="invokeAttr" /> contains <see langword="InvokeMethod" /> combined with <see langword="SetField" /> or <see langword="SetProperty" />.-or- 
		///         <paramref name="invokeAttr" /> contains <see langword="SetField" /> and <paramref name="args" /> has more than one element.-or- The named parameter array is larger than the argument array.-or- This method is called on a COM object and one of the following binding flags was not passed in: <see langword="BindingFlags.InvokeMethod" />, <see langword="BindingFlags.GetProperty" />, <see langword="BindingFlags.SetProperty" />, <see langword="BindingFlags.PutDispProperty" />, or <see langword="BindingFlags.PutRefDispProperty" />.-or- One of the named parameter arrays contains a string that is <see langword="null" />. </exception>
		/// <exception cref="T:System.MethodAccessException">The specified member is a class initializer. </exception>
		/// <exception cref="T:System.MissingFieldException">The field or property cannot be found. </exception>
		/// <exception cref="T:System.MissingMethodException">No method can be found that matches the arguments in <paramref name="args" />.-or- No member can be found that has the argument names supplied in <paramref name="namedParameters" />.-or- The current <see cref="T:System.Type" /> object represents a type that contains open type parameters, that is, <see cref="P:System.Type.ContainsGenericParameters" /> returns <see langword="true" />. </exception>
		/// <exception cref="T:System.Reflection.TargetException">The specified member cannot be invoked on <paramref name="target" />. </exception>
		/// <exception cref="T:System.Reflection.AmbiguousMatchException">More than one method matches the binding criteria. </exception>
		/// <exception cref="T:System.InvalidOperationException">The method represented by <paramref name="name" /> has one or more unspecified generic type parameters. That is, the method's <see cref="P:System.Reflection.MethodInfo.ContainsGenericParameters" /> property returns <see langword="true" />.</exception>
		// Token: 0x06000A2C RID: 2604
		public abstract object InvokeMember(string name, BindingFlags invokeAttr, Binder binder, object target, object[] args, ParameterModifier[] modifiers, CultureInfo culture, string[] namedParameters);

		/// <summary>When overridden in a derived class, gets all the interfaces implemented or inherited by the current <see cref="T:System.Type" />.</summary>
		/// <returns>An array of <see cref="T:System.Type" /> objects representing all the interfaces implemented or inherited by the current <see cref="T:System.Type" />.-or- An empty array of type <see cref="T:System.Type" />, if no interfaces are implemented or inherited by the current <see cref="T:System.Type" />.</returns>
		/// <exception cref="T:System.Reflection.TargetInvocationException">A static initializer is invoked and throws an exception. </exception>
		// Token: 0x06000A2D RID: 2605
		public abstract Type[] GetInterfaces();

		/// <summary>Determines whether the specified object is an instance of the current <see cref="T:System.Type" />.</summary>
		/// <param name="o">The object to compare with the current type. </param>
		/// <returns>
		///     <see langword="true" /> if the current <see langword="Type" /> is in the inheritance hierarchy of the object represented by <paramref name="o" />, or if the current <see langword="Type" /> is an interface that <paramref name="o" /> implements. <see langword="false" /> if neither of these conditions is the case, if <paramref name="o" /> is <see langword="null" />, or if the current <see langword="Type" /> is an open generic type (that is, <see cref="P:System.Type.ContainsGenericParameters" /> returns <see langword="true" />).</returns>
		// Token: 0x06000A2E RID: 2606 RVA: 0x0002B0AD File Offset: 0x000292AD
		public virtual bool IsInstanceOfType(object o)
		{
			return o != null && this.IsAssignableFrom(o.GetType());
		}

		/// <summary>Determines whether two COM types have the same identity and are eligible for type equivalence.</summary>
		/// <param name="other">The COM type that is tested for equivalence with the current type.</param>
		/// <returns>
		///     <see langword="true" /> if the COM types are equivalent; otherwise, <see langword="false" />. This method also returns <see langword="false" /> if one type is in an assembly that is loaded for execution, and the other is in an assembly that is loaded into the reflection-only context.</returns>
		// Token: 0x06000A2F RID: 2607 RVA: 0x0002B0C0 File Offset: 0x000292C0
		public virtual bool IsEquivalentTo(Type other)
		{
			return this == other;
		}

		/// <summary>Returns the underlying type of the current enumeration type.</summary>
		/// <returns>The underlying type of the current enumeration.</returns>
		/// <exception cref="T:System.ArgumentException">The current type is not an enumeration.-or-The enumeration type is not valid, because it contains more than one instance field.</exception>
		// Token: 0x06000A30 RID: 2608 RVA: 0x0002B0CC File Offset: 0x000292CC
		public virtual Type GetEnumUnderlyingType()
		{
			if (!this.IsEnum)
			{
				throw new ArgumentException("Type provided must be an Enum.", "enumType");
			}
			FieldInfo[] fields = this.GetFields(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic);
			if (fields == null || fields.Length != 1)
			{
				throw new ArgumentException("The Enum type should contain one and only one instance field.", "enumType");
			}
			return fields[0].FieldType;
		}

		/// <summary>Returns an array of the values of the constants in the current enumeration type.</summary>
		/// <returns>An array that contains the values. The elements of the array are sorted by the binary values (that is, the unsigned values) of the enumeration constants.</returns>
		/// <exception cref="T:System.ArgumentException">The current type is not an enumeration.</exception>
		// Token: 0x06000A31 RID: 2609 RVA: 0x0002B11B File Offset: 0x0002931B
		public virtual Array GetEnumValues()
		{
			if (!this.IsEnum)
			{
				throw new ArgumentException("Type provided must be an Enum.", "enumType");
			}
			throw NotImplemented.ByDesign;
		}

		/// <summary>Returns a <see cref="T:System.Type" /> object representing a one-dimensional array of the current type, with a lower bound of zero.</summary>
		/// <returns>A <see cref="T:System.Type" /> object representing a one-dimensional array of the current type, with a lower bound of zero.</returns>
		/// <exception cref="T:System.NotSupportedException">The invoked method is not supported in the base class. Derived classes must provide an implementation.</exception>
		/// <exception cref="T:System.TypeLoadException">The current type is <see cref="T:System.TypedReference" />.-or-The current type is a <see langword="ByRef" /> type. That is, <see cref="P:System.Type.IsByRef" /> returns <see langword="true" />. </exception>
		// Token: 0x06000A32 RID: 2610 RVA: 0x0002AD12 File Offset: 0x00028F12
		public virtual Type MakeArrayType()
		{
			throw new NotSupportedException();
		}

		/// <summary>Returns a <see cref="T:System.Type" /> object representing an array of the current type, with the specified number of dimensions.</summary>
		/// <param name="rank">The number of dimensions for the array. This number must be less than or equal to 32.</param>
		/// <returns>An object representing an array of the current type, with the specified number of dimensions.</returns>
		/// <exception cref="T:System.IndexOutOfRangeException">
		///         <paramref name="rank" /> is invalid. For example, 0 or negative.</exception>
		/// <exception cref="T:System.NotSupportedException">The invoked method is not supported in the base class.</exception>
		/// <exception cref="T:System.TypeLoadException">The current type is <see cref="T:System.TypedReference" />.-or-The current type is a <see langword="ByRef" /> type. That is, <see cref="P:System.Type.IsByRef" /> returns <see langword="true" />. -or-
		///         <paramref name="rank" /> is greater than 32.</exception>
		// Token: 0x06000A33 RID: 2611 RVA: 0x0002AD12 File Offset: 0x00028F12
		public virtual Type MakeArrayType(int rank)
		{
			throw new NotSupportedException();
		}

		/// <summary>Returns a <see cref="T:System.Type" /> object that represents the current type when passed as a <see langword="ref" /> parameter (<see langword="ByRef" /> parameter in Visual Basic).</summary>
		/// <returns>A <see cref="T:System.Type" /> object that represents the current type when passed as a <see langword="ref" /> parameter (<see langword="ByRef" /> parameter in Visual Basic).</returns>
		/// <exception cref="T:System.NotSupportedException">The invoked method is not supported in the base class.</exception>
		/// <exception cref="T:System.TypeLoadException">The current type is <see cref="T:System.TypedReference" />.-or-The current type is a <see langword="ByRef" /> type. That is, <see cref="P:System.Type.IsByRef" /> returns <see langword="true" />. </exception>
		// Token: 0x06000A34 RID: 2612 RVA: 0x0002AD12 File Offset: 0x00028F12
		public virtual Type MakeByRefType()
		{
			throw new NotSupportedException();
		}

		/// <summary>Substitutes the elements of an array of types for the type parameters of the current generic type definition and returns a <see cref="T:System.Type" /> object representing the resulting constructed type.</summary>
		/// <param name="typeArguments">An array of types to be substituted for the type parameters of the current generic type.</param>
		/// <returns>A <see cref="T:System.Type" /> representing the constructed type formed by substituting the elements of <paramref name="typeArguments" /> for the type parameters of the current generic type.</returns>
		/// <exception cref="T:System.InvalidOperationException">The current type does not represent a generic type definition. That is, <see cref="P:System.Type.IsGenericTypeDefinition" /> returns <see langword="false" />. </exception>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="typeArguments" /> is <see langword="null" />.-or- Any element of <paramref name="typeArguments" /> is <see langword="null" />. </exception>
		/// <exception cref="T:System.ArgumentException">The number of elements in <paramref name="typeArguments" /> is not the same as the number of type parameters in the current generic type definition.-or- Any element of <paramref name="typeArguments" /> does not satisfy the constraints specified for the corresponding type parameter of the current generic type. -or- 
		///         <paramref name="typeArguments" /> contains an element that is a pointer type (<see cref="P:System.Type.IsPointer" /> returns <see langword="true" />), a by-ref type (<see cref="P:System.Type.IsByRef" /> returns <see langword="true" />), or <see cref="T:System.Void" />.</exception>
		/// <exception cref="T:System.NotSupportedException">The invoked method is not supported in the base class. Derived classes must provide an implementation.</exception>
		// Token: 0x06000A35 RID: 2613 RVA: 0x0002ACDC File Offset: 0x00028EDC
		public virtual Type MakeGenericType(params Type[] typeArguments)
		{
			throw new NotSupportedException("Derived classes must provide an implementation.");
		}

		/// <summary>Returns a <see cref="T:System.Type" /> object that represents a pointer to the current type.</summary>
		/// <returns>A <see cref="T:System.Type" /> object that represents a pointer to the current type.</returns>
		/// <exception cref="T:System.NotSupportedException">The invoked method is not supported in the base class.</exception>
		/// <exception cref="T:System.TypeLoadException">The current type is <see cref="T:System.TypedReference" />.-or-The current type is a <see langword="ByRef" /> type. That is, <see cref="P:System.Type.IsByRef" /> returns <see langword="true" />. </exception>
		// Token: 0x06000A36 RID: 2614 RVA: 0x0002AD12 File Offset: 0x00028F12
		public virtual Type MakePointerType()
		{
			throw new NotSupportedException();
		}

		// Token: 0x06000A37 RID: 2615 RVA: 0x0002B13A File Offset: 0x0002933A
		public static Type MakeGenericSignatureType(Type genericTypeDefinition, params Type[] typeArguments)
		{
			return new SignatureConstructedGenericType(genericTypeDefinition, typeArguments);
		}

		/// <summary>Returns a <see langword="String" /> representing the name of the current <see langword="Type" />.</summary>
		/// <returns>A <see cref="T:System.String" /> representing the name of the current <see cref="T:System.Type" />.</returns>
		// Token: 0x06000A38 RID: 2616 RVA: 0x0002B143 File Offset: 0x00029343
		public override string ToString()
		{
			return "Type: " + this.Name;
		}

		/// <summary>Determines if the underlying system type of the current <see cref="T:System.Type" /> object is the same as the underlying system type of the specified <see cref="T:System.Object" />.</summary>
		/// <param name="o">The object whose underlying system type is to be compared with the underlying system type of the current <see cref="T:System.Type" />. For the comparison to succeed, <paramref name="o" /> must be able to be cast or converted to an object of type   <see cref="T:System.Type" />.</param>
		/// <returns>
		///     <see langword="true" /> if the underlying system type of <paramref name="o" /> is the same as the underlying system type of the current <see cref="T:System.Type" />; otherwise, <see langword="false" />. This method also returns <see langword="false" /> if: .
		///         <paramref name="o" /> is <see langword="null" />.
		///         <paramref name="o" /> cannot be cast or converted to a <see cref="T:System.Type" /> object.</returns>
		// Token: 0x06000A39 RID: 2617 RVA: 0x0002B155 File Offset: 0x00029355
		public override bool Equals(object o)
		{
			return o != null && this.Equals(o as Type);
		}

		/// <summary>Returns the hash code for this instance.</summary>
		/// <returns>The hash code for this instance.</returns>
		// Token: 0x06000A3A RID: 2618 RVA: 0x0002B168 File Offset: 0x00029368
		public override int GetHashCode()
		{
			Type underlyingSystemType = this.UnderlyingSystemType;
			if (underlyingSystemType != this)
			{
				return underlyingSystemType.GetHashCode();
			}
			return base.GetHashCode();
		}

		/// <summary>Determines if the underlying system type of the current <see cref="T:System.Type" /> is the same as the underlying system type of the specified <see cref="T:System.Type" />.</summary>
		/// <param name="o">The object whose underlying system type is to be compared with the underlying system type of the current <see cref="T:System.Type" />. </param>
		/// <returns>
		///     <see langword="true" /> if the underlying system type of <paramref name="o" /> is the same as the underlying system type of the current <see cref="T:System.Type" />; otherwise, <see langword="false" />.</returns>
		// Token: 0x06000A3B RID: 2619 RVA: 0x0002B18D File Offset: 0x0002938D
		public virtual bool Equals(Type o)
		{
			return !(o == null) && this.UnderlyingSystemType == o.UnderlyingSystemType;
		}

		/// <summary>Gets a reference to the default binder, which implements internal rules for selecting the appropriate members to be called by <see cref="M:System.Type.InvokeMember(System.String,System.Reflection.BindingFlags,System.Reflection.Binder,System.Object,System.Object[],System.Reflection.ParameterModifier[],System.Globalization.CultureInfo,System.String[])" />.</summary>
		/// <returns>A reference to the default binder used by the system.</returns>
		// Token: 0x170000DA RID: 218
		// (get) Token: 0x06000A3C RID: 2620 RVA: 0x0002B1A8 File Offset: 0x000293A8
		public static Binder DefaultBinder
		{
			get
			{
				if (Type.s_defaultBinder == null)
				{
					DefaultBinder value = new DefaultBinder();
					Interlocked.CompareExchange<Binder>(ref Type.s_defaultBinder, value, null);
				}
				return Type.s_defaultBinder;
			}
		}

		// Token: 0x06000A3D RID: 2621 RVA: 0x0002B1D8 File Offset: 0x000293D8
		internal virtual Type InternalResolve()
		{
			return this.UnderlyingSystemType;
		}

		// Token: 0x06000A3E RID: 2622 RVA: 0x0002B1E0 File Offset: 0x000293E0
		internal virtual Type RuntimeResolve()
		{
			throw new NotImplementedException();
		}

		// Token: 0x170000DB RID: 219
		// (get) Token: 0x06000A3F RID: 2623 RVA: 0x0000B18D File Offset: 0x0000938D
		internal virtual bool IsUserType
		{
			get
			{
				return true;
			}
		}

		// Token: 0x06000A40 RID: 2624 RVA: 0x0002B1E7 File Offset: 0x000293E7
		internal virtual MethodInfo GetMethod(MethodInfo fromNoninstanciated)
		{
			throw new InvalidOperationException("can only be called in generic type");
		}

		// Token: 0x06000A41 RID: 2625 RVA: 0x0002B1E7 File Offset: 0x000293E7
		internal virtual ConstructorInfo GetConstructor(ConstructorInfo fromNoninstanciated)
		{
			throw new InvalidOperationException("can only be called in generic type");
		}

		// Token: 0x06000A42 RID: 2626 RVA: 0x0002B1E7 File Offset: 0x000293E7
		internal virtual FieldInfo GetField(FieldInfo fromNoninstanciated)
		{
			throw new InvalidOperationException("can only be called in generic type");
		}

		/// <summary>Gets the type referenced by the specified type handle.</summary>
		/// <param name="handle">The object that refers to the type. </param>
		/// <returns>The type referenced by the specified <see cref="T:System.RuntimeTypeHandle" />, or <see langword="null" /> if the <see cref="P:System.RuntimeTypeHandle.Value" /> property of <paramref name="handle" /> is <see langword="null" />.</returns>
		/// <exception cref="T:System.Reflection.TargetInvocationException">A class initializer is invoked and throws an exception. </exception>
		// Token: 0x06000A43 RID: 2627 RVA: 0x0002B1F3 File Offset: 0x000293F3
		public static Type GetTypeFromHandle(RuntimeTypeHandle handle)
		{
			if (handle.Value == IntPtr.Zero)
			{
				return null;
			}
			return Type.internal_from_handle(handle.Value);
		}

		// Token: 0x06000A44 RID: 2628
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern Type internal_from_handle(IntPtr handle);

		// Token: 0x170000DC RID: 220
		// (get) Token: 0x06000A45 RID: 2629 RVA: 0x0002ACA4 File Offset: 0x00028EA4
		internal virtual bool IsSzArray
		{
			get
			{
				return false;
			}
		}

		// Token: 0x06000A46 RID: 2630 RVA: 0x0002B216 File Offset: 0x00029416
		internal string FormatTypeName()
		{
			return this.FormatTypeName(false);
		}

		// Token: 0x06000A47 RID: 2631 RVA: 0x0002B1E0 File Offset: 0x000293E0
		internal virtual string FormatTypeName(bool serialization)
		{
			throw new NotImplementedException();
		}

		/// <summary>Gets a value indicating whether the <see cref="T:System.Type" /> is an interface; that is, not a class or a value type.</summary>
		/// <returns>
		///     <see langword="true" /> if the <see cref="T:System.Type" /> is an interface; otherwise, <see langword="false" />.</returns>
		// Token: 0x170000DD RID: 221
		// (get) Token: 0x06000A48 RID: 2632 RVA: 0x0002B220 File Offset: 0x00029420
		public bool IsInterface
		{
			get
			{
				RuntimeType runtimeType = this as RuntimeType;
				if (runtimeType != null)
				{
					return RuntimeTypeHandle.IsInterface(runtimeType);
				}
				return (this.GetAttributeFlagsImpl() & TypeAttributes.ClassSemanticsMask) == TypeAttributes.ClassSemanticsMask;
			}
		}

		/// <summary>Gets the <see cref="T:System.Type" /> with the specified name, specifying whether to throw an exception if the type is not found and whether to perform a case-sensitive search. </summary>
		/// <param name="typeName">The assembly-qualified name of the type to get. See <see cref="P:System.Type.AssemblyQualifiedName" />. If the type is in the currently executing assembly or in Mscorlib.dll, it is sufficient to supply the type name qualified by its namespace.</param>
		/// <param name="throwOnError">
		///       <see langword="true" /> to throw an exception if the type cannot be found; <see langword="false" /> to return <see langword="null" />.Specifying <see langword="false" /> also suppresses some other exception conditions, but not all of them. See the Exceptions section.</param>
		/// <param name="ignoreCase">
		///       <see langword="true" /> to perform a case-insensitive search for <paramref name="typeName" />, <see langword="false" /> to perform a case-sensitive search for <paramref name="typeName" />. </param>
		/// <returns>The type with the specified name. If the type is not found, the <paramref name="throwOnError" /> parameter specifies whether <see langword="null" /> is returned or an exception is thrown. In some cases, an exception is thrown regardless of the value of <paramref name="throwOnError" />. See the Exceptions section. </returns>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="typeName" /> is <see langword="null" />. </exception>
		/// <exception cref="T:System.Reflection.TargetInvocationException">A class initializer is invoked and throws an exception. </exception>
		/// <exception cref="T:System.TypeLoadException">
		///         <paramref name="throwOnError" /> is <see langword="true" /> and the type is not found. -or-
		///
		///         <paramref name="throwOnError" /> is <see langword="true" /> and <paramref name="typeName" /> contains invalid characters, such as an embedded tab.-or-
		///
		///         <paramref name="throwOnError" /> is <see langword="true" /> and <paramref name="typeName" /> is an empty string.-or-
		///
		///         <paramref name="throwOnError" /> is <see langword="true" /> and <paramref name="typeName" /> represents an array type with an invalid size. -or-
		///         <paramref name="typeName" /> represents an array of <see cref="T:System.TypedReference" />. </exception>
		/// <exception cref="T:System.ArgumentException">
		///         <paramref name="throwOnError" /> is <see langword="true" /> and <paramref name="typeName" /> contains invalid syntax. For example, "MyType[,*,]".-or- 
		///
		///         <paramref name="typeName" />
		///          represents a generic type that has a pointer type, a <see langword="ByRef" /> type, or <see cref="T:System.Void" /> as one of its type arguments.-or-
		///         <paramref name="typeName" /> represents a generic type that has an incorrect number of type arguments.-or-
		///         <paramref name="typeName" /> represents a generic type, and one of its type arguments does not satisfy the constraints for the corresponding type parameter.</exception>
		/// <exception cref="T:System.IO.FileNotFoundException">
		///         <paramref name="throwOnError" /> is <see langword="true" /> and the assembly or one of its dependencies was not found. </exception>
		/// <exception cref="T:System.IO.FileLoadException">The assembly or one of its dependencies was found, but could not be loaded. </exception>
		/// <exception cref="T:System.BadImageFormatException">The assembly or one of its dependencies is not valid. -or-Version 2.0 or later of the common language runtime is currently loaded, and the assembly was compiled with a later version.</exception>
		// Token: 0x06000A49 RID: 2633 RVA: 0x0002B254 File Offset: 0x00029454
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static Type GetType(string typeName, bool throwOnError, bool ignoreCase)
		{
			StackCrawlMark stackCrawlMark = StackCrawlMark.LookForMyCaller;
			return RuntimeType.GetType(typeName, throwOnError, ignoreCase, false, ref stackCrawlMark);
		}

		/// <summary>Gets the <see cref="T:System.Type" /> with the specified name, performing a case-sensitive search and specifying whether to throw an exception if the type is not found.</summary>
		/// <param name="typeName">The assembly-qualified name of the type to get. See <see cref="P:System.Type.AssemblyQualifiedName" />. If the type is in the currently executing assembly or in Mscorlib.dll, it is sufficient to supply the type name qualified by its namespace.</param>
		/// <param name="throwOnError">
		///       <see langword="true" /> to throw an exception if the type cannot be found; <see langword="false" /> to return <see langword="null" />. Specifying <see langword="false" /> also suppresses some other exception conditions, but not all of them. See the Exceptions section.</param>
		/// <returns>The type with the specified name. If the type is not found, the <paramref name="throwOnError" /> parameter specifies whether <see langword="null" /> is returned or an exception is thrown. In some cases, an exception is thrown regardless of the value of <paramref name="throwOnError" />. See the Exceptions section. </returns>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="typeName" /> is <see langword="null" />. </exception>
		/// <exception cref="T:System.Reflection.TargetInvocationException">A class initializer is invoked and throws an exception. </exception>
		/// <exception cref="T:System.TypeLoadException">
		///         <paramref name="throwOnError" /> is <see langword="true" /> and the type is not found. -or-
		///
		///         <paramref name="throwOnError" /> is <see langword="true" /> and <paramref name="typeName" /> contains invalid characters, such as an embedded tab.-or-
		///
		///         <paramref name="throwOnError" /> is <see langword="true" /> and <paramref name="typeName" /> is an empty string.-or-
		///
		///         <paramref name="throwOnError" /> is <see langword="true" /> and <paramref name="typeName" /> represents an array type with an invalid size. -or-
		///         <paramref name="typeName" /> represents an array of <see cref="T:System.TypedReference" />. </exception>
		/// <exception cref="T:System.ArgumentException">
		///         <paramref name="throwOnError" /> is <see langword="true" /> and <paramref name="typeName" /> contains invalid syntax. For example, "MyType[,*,]".-or- 
		///
		///         <paramref name="typeName" />
		///          represents a generic type that has a pointer type, a <see langword="ByRef" /> type, or <see cref="T:System.Void" /> as one of its type arguments.-or-
		///         <paramref name="typeName" /> represents a generic type that has an incorrect number of type arguments.-or-
		///         <paramref name="typeName" /> represents a generic type, and one of its type arguments does not satisfy the constraints for the corresponding type parameter.</exception>
		/// <exception cref="T:System.IO.FileNotFoundException">
		///         <paramref name="throwOnError" /> is <see langword="true" /> and the assembly or one of its dependencies was not found. </exception>
		/// <exception cref="T:System.IO.FileLoadException">
		///           In the .NET for Windows Store apps or the Portable Class Library, catch the base class exception, <see cref="T:System.IO.IOException" />, instead.The assembly or one of its dependencies was found, but could not be loaded. </exception>
		/// <exception cref="T:System.BadImageFormatException">The assembly or one of its dependencies is not valid. -or-Version 2.0 or later of the common language runtime is currently loaded, and the assembly was compiled with a later version.</exception>
		// Token: 0x06000A4A RID: 2634 RVA: 0x0002B270 File Offset: 0x00029470
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static Type GetType(string typeName, bool throwOnError)
		{
			StackCrawlMark stackCrawlMark = StackCrawlMark.LookForMyCaller;
			return RuntimeType.GetType(typeName, throwOnError, false, false, ref stackCrawlMark);
		}

		/// <summary>Gets the <see cref="T:System.Type" /> with the specified name, performing a case-sensitive search.</summary>
		/// <param name="typeName">The assembly-qualified name of the type to get. See <see cref="P:System.Type.AssemblyQualifiedName" />. If the type is in the currently executing assembly or in Mscorlib.dll, it is sufficient to supply the type name qualified by its namespace.</param>
		/// <returns>The type with the specified name, if found; otherwise, <see langword="null" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="typeName" /> is <see langword="null" />. </exception>
		/// <exception cref="T:System.Reflection.TargetInvocationException">A class initializer is invoked and throws an exception. </exception>
		/// <exception cref="T:System.ArgumentException">
		///         <paramref name="typeName" /> represents a generic type that has a pointer type, a <see langword="ByRef" /> type, or <see cref="T:System.Void" /> as one of its type arguments.-or-
		///         <paramref name="typeName" /> represents a generic type that has an incorrect number of type arguments.-or-
		///         <paramref name="typeName" /> represents a generic type, and one of its type arguments does not satisfy the constraints for the corresponding type parameter.</exception>
		/// <exception cref="T:System.TypeLoadException">
		///         <paramref name="typeName" /> represents an array of <see cref="T:System.TypedReference" />. </exception>
		/// <exception cref="T:System.IO.FileLoadException">
		///           In the .NET for Windows Store apps or the Portable Class Library, catch the base class exception, <see cref="T:System.IO.IOException" />, instead.The assembly or one of its dependencies was found, but could not be loaded. </exception>
		/// <exception cref="T:System.BadImageFormatException">The assembly or one of its dependencies is not valid. -or-Version 2.0 or later of the common language runtime is currently loaded, and the assembly was compiled with a later version.</exception>
		// Token: 0x06000A4B RID: 2635 RVA: 0x0002B28C File Offset: 0x0002948C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static Type GetType(string typeName)
		{
			StackCrawlMark stackCrawlMark = StackCrawlMark.LookForMyCaller;
			return RuntimeType.GetType(typeName, false, false, false, ref stackCrawlMark);
		}

		/// <summary>Gets the type with the specified name, optionally providing custom methods to resolve the assembly and the type.</summary>
		/// <param name="typeName">The name of the type to get. If the <paramref name="typeResolver" /> parameter is provided, the type name can be any string that <paramref name="typeResolver" /> is capable of resolving. If the <paramref name="assemblyResolver" /> parameter is provided or if standard type resolution is used, <paramref name="typeName" /> must be an assembly-qualified name (see <see cref="P:System.Type.AssemblyQualifiedName" />), unless the type is in the currently executing assembly or in Mscorlib.dll, in which case it is sufficient to supply the type name qualified by its namespace.</param>
		/// <param name="assemblyResolver">A method that locates and returns the assembly that is specified in <paramref name="typeName" />. The assembly name is passed to <paramref name="assemblyResolver" /> as an <see cref="T:System.Reflection.AssemblyName" /> object. If <paramref name="typeName" /> does not contain the name of an assembly, <paramref name="assemblyResolver" /> is not called. If <paramref name="assemblyResolver" /> is not supplied, standard assembly resolution is performed. Caution   Do not pass methods from unknown or untrusted callers. Doing so could result in elevation of privilege for malicious code. Use only methods that you provide or that you are familiar with. </param>
		/// <param name="typeResolver">A method that locates and returns the type that is specified by <paramref name="typeName" /> from the assembly that is returned by <paramref name="assemblyResolver" /> or by standard assembly resolution. If no assembly is provided, the <paramref name="typeResolver" /> method can provide one. The method also takes a parameter that specifies whether to perform a case-insensitive search; <see langword="false" /> is passed to that parameter. Caution   Do not pass methods from unknown or untrusted callers. </param>
		/// <returns>The type with the specified name, or <see langword="null" /> if the type is not found. </returns>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="typeName" /> is <see langword="null" />. </exception>
		/// <exception cref="T:System.Reflection.TargetInvocationException">A class initializer is invoked and throws an exception. </exception>
		/// <exception cref="T:System.ArgumentException">An error occurs when <paramref name="typeName" /> is parsed into a type name and an assembly name (for example, when the simple type name includes an unescaped special character).-or-
		///         <paramref name="typeName" /> represents a generic type that has a pointer type, a <see langword="ByRef" /> type, or <see cref="T:System.Void" /> as one of its type arguments.-or-
		///         <paramref name="typeName" /> represents a generic type that has an incorrect number of type arguments.-or-
		///         <paramref name="typeName" /> represents a generic type, and one of its type arguments does not satisfy the constraints for the corresponding type parameter.</exception>
		/// <exception cref="T:System.TypeLoadException">
		///         <paramref name="typeName" /> represents an array of <see cref="T:System.TypedReference" />. </exception>
		/// <exception cref="T:System.IO.FileLoadException">The assembly or one of its dependencies was found, but could not be loaded. -or-
		///         <paramref name="typeName" /> contains an invalid assembly name.-or-
		///         <paramref name="typeName" /> is a valid assembly name without a type name.</exception>
		/// <exception cref="T:System.BadImageFormatException">The assembly or one of its dependencies is not valid. -or-The assembly was compiled with a later version of the common language runtime than the version that is currently loaded.</exception>
		// Token: 0x06000A4C RID: 2636 RVA: 0x0002B2A8 File Offset: 0x000294A8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static Type GetType(string typeName, Func<AssemblyName, Assembly> assemblyResolver, Func<Assembly, string, bool, Type> typeResolver)
		{
			StackCrawlMark stackCrawlMark = StackCrawlMark.LookForMyCaller;
			return TypeNameParser.GetType(typeName, assemblyResolver, typeResolver, false, false, ref stackCrawlMark);
		}

		/// <summary>Gets the type with the specified name, specifying whether to throw an exception if the type is not found, and optionally providing custom methods to resolve the assembly and the type.</summary>
		/// <param name="typeName">The name of the type to get. If the <paramref name="typeResolver" /> parameter is provided, the type name can be any string that <paramref name="typeResolver" /> is capable of resolving. If the <paramref name="assemblyResolver" /> parameter is provided or if standard type resolution is used, <paramref name="typeName" /> must be an assembly-qualified name (see <see cref="P:System.Type.AssemblyQualifiedName" />), unless the type is in the currently executing assembly or in Mscorlib.dll, in which case it is sufficient to supply the type name qualified by its namespace.</param>
		/// <param name="assemblyResolver">A method that locates and returns the assembly that is specified in <paramref name="typeName" />. The assembly name is passed to <paramref name="assemblyResolver" /> as an <see cref="T:System.Reflection.AssemblyName" /> object. If <paramref name="typeName" /> does not contain the name of an assembly, <paramref name="assemblyResolver" /> is not called. If <paramref name="assemblyResolver" /> is not supplied, standard assembly resolution is performed. Caution   Do not pass methods from unknown or untrusted callers. Doing so could result in elevation of privilege for malicious code. Use only methods that you provide or that you are familiar with. </param>
		/// <param name="typeResolver">A method that locates and returns the type that is specified by <paramref name="typeName" /> from the assembly that is returned by <paramref name="assemblyResolver" /> or by standard assembly resolution. If no assembly is provided, the method can provide one. The method also takes a parameter that specifies whether to perform a case-insensitive search; <see langword="false" /> is passed to that parameter. Caution   Do not pass methods from unknown or untrusted callers. </param>
		/// <param name="throwOnError">
		///       <see langword="true" /> to throw an exception if the type cannot be found; <see langword="false" /> to return <see langword="null" />. Specifying <see langword="false" /> also suppresses some other exception conditions, but not all of them. See the Exceptions section.</param>
		/// <returns>The type with the specified name. If the type is not found, the <paramref name="throwOnError" /> parameter specifies whether <see langword="null" /> is returned or an exception is thrown. In some cases, an exception is thrown regardless of the value of <paramref name="throwOnError" />. See the Exceptions section. </returns>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="typeName" /> is <see langword="null" />. </exception>
		/// <exception cref="T:System.Reflection.TargetInvocationException">A class initializer is invoked and throws an exception. </exception>
		/// <exception cref="T:System.TypeLoadException">
		///         <paramref name="throwOnError" /> is <see langword="true" /> and the type is not found. -or-
		///         <paramref name="throwOnError" /> is <see langword="true" /> and <paramref name="typeName" /> contains invalid characters, such as an embedded tab.-or-
		///         <paramref name="throwOnError" /> is <see langword="true" /> and <paramref name="typeName" /> is an empty string.-or-
		///         <paramref name="throwOnError" /> is <see langword="true" /> and <paramref name="typeName" /> represents an array type with an invalid size. -or-
		///         <paramref name="typeName" /> represents an array of <see cref="T:System.TypedReference" />. </exception>
		/// <exception cref="T:System.ArgumentException">An error occurs when <paramref name="typeName" /> is parsed into a type name and an assembly name (for example, when the simple type name includes an unescaped special character).-or-
		///         <paramref name="throwOnError" /> is <see langword="true" /> and <paramref name="typeName" /> contains invalid syntax (for example, "MyType[,*,]").-or- 
		///         <paramref name="typeName" /> represents a generic type that has a pointer type, a <see langword="ByRef" /> type, or <see cref="T:System.Void" /> as one of its type arguments.-or-
		///         <paramref name="typeName" /> represents a generic type that has an incorrect number of type arguments.-or-
		///         <paramref name="typeName" /> represents a generic type, and one of its type arguments does not satisfy the constraints for the corresponding type parameter.</exception>
		/// <exception cref="T:System.IO.FileNotFoundException">
		///         <paramref name="throwOnError" /> is <see langword="true" /> and the assembly or one of its dependencies was not found. -or-
		///         <paramref name="typeName" /> contains an invalid assembly name.-or-
		///         <paramref name="typeName" /> is a valid assembly name without a type name.</exception>
		/// <exception cref="T:System.IO.FileLoadException">The assembly or one of its dependencies was found, but could not be loaded. </exception>
		/// <exception cref="T:System.BadImageFormatException">The assembly or one of its dependencies is not valid. -or-The assembly was compiled with a later version of the common language runtime than the version that is currently loaded.</exception>
		// Token: 0x06000A4D RID: 2637 RVA: 0x0002B2C4 File Offset: 0x000294C4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static Type GetType(string typeName, Func<AssemblyName, Assembly> assemblyResolver, Func<Assembly, string, bool, Type> typeResolver, bool throwOnError)
		{
			StackCrawlMark stackCrawlMark = StackCrawlMark.LookForMyCaller;
			return TypeNameParser.GetType(typeName, assemblyResolver, typeResolver, throwOnError, false, ref stackCrawlMark);
		}

		/// <summary>Gets the type with the specified name, specifying whether to perform a case-sensitive search and whether to throw an exception if the type is not found, and optionally providing custom methods to resolve the assembly and the type.</summary>
		/// <param name="typeName">The name of the type to get. If the <paramref name="typeResolver" /> parameter is provided, the type name can be any string that <paramref name="typeResolver" /> is capable of resolving. If the <paramref name="assemblyResolver" /> parameter is provided or if standard type resolution is used, <paramref name="typeName" /> must be an assembly-qualified name (see <see cref="P:System.Type.AssemblyQualifiedName" />), unless the type is in the currently executing assembly or in Mscorlib.dll, in which case it is sufficient to supply the type name qualified by its namespace.</param>
		/// <param name="assemblyResolver">A method that locates and returns the assembly that is specified in <paramref name="typeName" />. The assembly name is passed to <paramref name="assemblyResolver" /> as an <see cref="T:System.Reflection.AssemblyName" /> object. If <paramref name="typeName" /> does not contain the name of an assembly, <paramref name="assemblyResolver" /> is not called. If <paramref name="assemblyResolver" /> is not supplied, standard assembly resolution is performed. Caution   Do not pass methods from unknown or untrusted callers. Doing so could result in elevation of privilege for malicious code. Use only methods that you provide or that you are familiar with.</param>
		/// <param name="typeResolver">A method that locates and returns the type that is specified by <paramref name="typeName" /> from the assembly that is returned by <paramref name="assemblyResolver" /> or by standard assembly resolution. If no assembly is provided, the method can provide one. The method also takes a parameter that specifies whether to perform a case-insensitive search; the value of <paramref name="ignoreCase" /> is passed to that parameter. Caution   Do not pass methods from unknown or untrusted callers. </param>
		/// <param name="throwOnError">
		///       <see langword="true" /> to throw an exception if the type cannot be found; <see langword="false" /> to return <see langword="null" />. Specifying <see langword="false" /> also suppresses some other exception conditions, but not all of them. See the Exceptions section.</param>
		/// <param name="ignoreCase">
		///       <see langword="true" /> to perform a case-insensitive search for <paramref name="typeName" />, <see langword="false" /> to perform a case-sensitive search for <paramref name="typeName" />. </param>
		/// <returns>The type with the specified name. If the type is not found, the <paramref name="throwOnError" /> parameter specifies whether <see langword="null" /> is returned or an exception is thrown. In some cases, an exception is thrown regardless of the value of <paramref name="throwOnError" />. See the Exceptions section. </returns>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="typeName" /> is <see langword="null" />. </exception>
		/// <exception cref="T:System.Reflection.TargetInvocationException">A class initializer is invoked and throws an exception. </exception>
		/// <exception cref="T:System.TypeLoadException">
		///         <paramref name="throwOnError" /> is <see langword="true" /> and the type is not found. -or-
		///         <paramref name="throwOnError" /> is <see langword="true" /> and <paramref name="typeName" /> contains invalid characters, such as an embedded tab.-or-
		///         <paramref name="throwOnError" /> is <see langword="true" /> and <paramref name="typeName" /> is an empty string.-or-
		///         <paramref name="throwOnError" /> is <see langword="true" /> and <paramref name="typeName" /> represents an array type with an invalid size. -or-
		///         <paramref name="typeName" /> represents an array of <see cref="T:System.TypedReference" />. </exception>
		/// <exception cref="T:System.ArgumentException">An error occurs when <paramref name="typeName" /> is parsed into a type name and an assembly name (for example, when the simple type name includes an unescaped special character).-or-
		///         <paramref name="throwOnError" /> is <see langword="true" /> and <paramref name="typeName" /> contains invalid syntax (for example, "MyType[,*,]").-or- 
		///         <paramref name="typeName" /> represents a generic type that has a pointer type, a <see langword="ByRef" /> type, or <see cref="T:System.Void" /> as one of its type arguments.-or-
		///         <paramref name="typeName" /> represents a generic type that has an incorrect number of type arguments.-or-
		///         <paramref name="typeName" /> represents a generic type, and one of its type arguments does not satisfy the constraints for the corresponding type parameter.</exception>
		/// <exception cref="T:System.IO.FileNotFoundException">
		///         <paramref name="throwOnError" /> is <see langword="true" /> and the assembly or one of its dependencies was not found. </exception>
		/// <exception cref="T:System.IO.FileLoadException">The assembly or one of its dependencies was found, but could not be loaded. -or-
		///         <paramref name="typeName" /> contains an invalid assembly name.-or-
		///         <paramref name="typeName" /> is a valid assembly name without a type name.</exception>
		/// <exception cref="T:System.BadImageFormatException">The assembly or one of its dependencies is not valid. -or-The assembly was compiled with a later version of the common language runtime than the version that is currently loaded.</exception>
		// Token: 0x06000A4E RID: 2638 RVA: 0x0002B2E0 File Offset: 0x000294E0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static Type GetType(string typeName, Func<AssemblyName, Assembly> assemblyResolver, Func<Assembly, string, bool, Type> typeResolver, bool throwOnError, bool ignoreCase)
		{
			StackCrawlMark stackCrawlMark = StackCrawlMark.LookForMyCaller;
			return TypeNameParser.GetType(typeName, assemblyResolver, typeResolver, throwOnError, ignoreCase, ref stackCrawlMark);
		}

		/// <summary>Indicates whether two <see cref="T:System.Type" /> objects are equal.</summary>
		/// <param name="left">The first object to compare.</param>
		/// <param name="right">The second object to compare.</param>
		/// <returns>
		///     <see langword="true" /> if <paramref name="left" /> is equal to <paramref name="right" />; otherwise, <see langword="false" />.</returns>
		// Token: 0x06000A4F RID: 2639 RVA: 0x0002B2FC File Offset: 0x000294FC
		public static bool operator ==(Type left, Type right)
		{
			return left == right;
		}

		/// <summary>Indicates whether two <see cref="T:System.Type" /> objects are not equal.</summary>
		/// <param name="left">The first object to compare.</param>
		/// <param name="right">The second object to compare.</param>
		/// <returns>
		///     <see langword="true" /> if <paramref name="left" /> is not equal to <paramref name="right" />; otherwise, <see langword="false" />.</returns>
		// Token: 0x06000A50 RID: 2640 RVA: 0x0002B302 File Offset: 0x00029502
		public static bool operator !=(Type left, Type right)
		{
			return left != right;
		}

		// Token: 0x170000DE RID: 222
		// (get) Token: 0x06000A51 RID: 2641 RVA: 0x0002B30C File Offset: 0x0002950C
		internal string FullNameOrDefault
		{
			get
			{
				if (this.InternalNameIfAvailable == null)
				{
					return "UnknownType";
				}
				string result;
				try
				{
					result = this.FullName;
				}
				catch (MissingMetadataException)
				{
					result = "UnknownType";
				}
				return result;
			}
		}

		// Token: 0x06000A52 RID: 2642 RVA: 0x0002B34C File Offset: 0x0002954C
		internal bool IsRuntimeImplemented()
		{
			return this.UnderlyingSystemType is RuntimeType;
		}

		// Token: 0x06000A53 RID: 2643 RVA: 0x0002B35C File Offset: 0x0002955C
		internal virtual string InternalGetNameIfAvailable(ref Type rootCauseForFailure)
		{
			return this.Name;
		}

		// Token: 0x170000DF RID: 223
		// (get) Token: 0x06000A54 RID: 2644 RVA: 0x0002B364 File Offset: 0x00029564
		internal string InternalNameIfAvailable
		{
			get
			{
				Type type = null;
				return this.InternalGetNameIfAvailable(ref type);
			}
		}

		// Token: 0x170000E0 RID: 224
		// (get) Token: 0x06000A55 RID: 2645 RVA: 0x0002B37B File Offset: 0x0002957B
		internal string NameOrDefault
		{
			get
			{
				return this.InternalNameIfAvailable ?? "UnknownType";
			}
		}

		// Token: 0x0400038A RID: 906
		private static volatile Binder s_defaultBinder;

		/// <summary>Separates names in the namespace of the <see cref="T:System.Type" />. This field is read-only.</summary>
		// Token: 0x0400038B RID: 907
		public static readonly char Delimiter = '.';

		/// <summary>Represents an empty array of type <see cref="T:System.Type" />. This field is read-only.</summary>
		// Token: 0x0400038C RID: 908
		public static readonly Type[] EmptyTypes = Array.Empty<Type>();

		/// <summary>Represents a missing value in the <see cref="T:System.Type" /> information. This field is read-only.</summary>
		// Token: 0x0400038D RID: 909
		public static readonly object Missing = System.Reflection.Missing.Value;

		/// <summary>Represents the member filter used on attributes. This field is read-only.</summary>
		// Token: 0x0400038E RID: 910
		public static readonly MemberFilter FilterAttribute = new MemberFilter(Type.FilterAttributeImpl);

		/// <summary>Represents the case-sensitive member filter used on names. This field is read-only.</summary>
		// Token: 0x0400038F RID: 911
		public static readonly MemberFilter FilterName = new MemberFilter(Type.FilterNameImpl);

		/// <summary>Represents the case-insensitive member filter used on names. This field is read-only.</summary>
		// Token: 0x04000390 RID: 912
		public static readonly MemberFilter FilterNameIgnoreCase = new MemberFilter(Type.FilterNameIgnoreCaseImpl);

		// Token: 0x04000391 RID: 913
		internal RuntimeTypeHandle _impl;
	}
}
