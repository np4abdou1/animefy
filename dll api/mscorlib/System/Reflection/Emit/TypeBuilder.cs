using System;
using System.Collections;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace System.Reflection.Emit
{
	/// <summary>Defines and creates new instances of classes during run time.</summary>
	// Token: 0x02000518 RID: 1304
	[StructLayout(0)]
	public sealed class TypeBuilder : TypeInfo
	{
		// Token: 0x06002608 RID: 9736 RVA: 0x000955BB File Offset: 0x000937BB
		protected override TypeAttributes GetAttributeFlagsImpl()
		{
			return this.attrs;
		}

		// Token: 0x06002609 RID: 9737 RVA: 0x000955C4 File Offset: 0x000937C4
		internal TypeBuilder(ModuleBuilder mb, TypeAttributes attr, int table_idx)
		{
			this.parent = null;
			this.attrs = attr;
			this.class_size = 0;
			this.table_idx = table_idx;
			this.tname = ((table_idx == 1) ? "<Module>" : ("type_" + table_idx.ToString()));
			this.nspace = string.Empty;
			this.fullname = TypeIdentifiers.WithoutEscape(this.tname);
			this.pmodule = mb;
		}

		/// <summary>Retrieves the dynamic assembly that contains this type definition.</summary>
		/// <returns>Read-only. Retrieves the dynamic assembly that contains this type definition.</returns>
		// Token: 0x1700057C RID: 1404
		// (get) Token: 0x0600260A RID: 9738 RVA: 0x00095638 File Offset: 0x00093838
		public override Assembly Assembly
		{
			get
			{
				return this.pmodule.Assembly;
			}
		}

		/// <summary>Returns the full name of this type qualified by the display name of the assembly.</summary>
		/// <returns>Read-only. The full name of this type qualified by the display name of the assembly.</returns>
		// Token: 0x1700057D RID: 1405
		// (get) Token: 0x0600260B RID: 9739 RVA: 0x00095645 File Offset: 0x00093845
		public override string AssemblyQualifiedName
		{
			get
			{
				return this.fullname.DisplayName + ", " + this.Assembly.FullName;
			}
		}

		/// <summary>Retrieves the base type of this type.</summary>
		/// <returns>Read-only. Retrieves the base type of this type.</returns>
		// Token: 0x1700057E RID: 1406
		// (get) Token: 0x0600260C RID: 9740 RVA: 0x00095667 File Offset: 0x00093867
		public override Type BaseType
		{
			get
			{
				return this.parent;
			}
		}

		/// <summary>Returns the type that declared this type.</summary>
		/// <returns>Read-only. The type that declared this type.</returns>
		// Token: 0x1700057F RID: 1407
		// (get) Token: 0x0600260D RID: 9741 RVA: 0x0009566F File Offset: 0x0009386F
		public override Type DeclaringType
		{
			get
			{
				return this.nesting_type;
			}
		}

		/// <summary>Determines whether this type is derived from a specified type.</summary>
		/// <param name="c">A <see cref="T:System.Type" /> that is to be checked. </param>
		/// <returns>Read-only. Returns <see langword="true" /> if this type is the same as the type <paramref name="c" />, or is a subtype of type <paramref name="c" />; otherwise, <see langword="false" />.</returns>
		// Token: 0x0600260E RID: 9742 RVA: 0x00095678 File Offset: 0x00093878
		[ComVisible(true)]
		public override bool IsSubclassOf(Type c)
		{
			if (c == null)
			{
				return false;
			}
			if (c == this)
			{
				return false;
			}
			Type baseType = this.parent;
			while (baseType != null)
			{
				if (c == baseType)
				{
					return true;
				}
				baseType = baseType.BaseType;
			}
			return false;
		}

		/// <summary>Returns the underlying system type for this <see langword="TypeBuilder" />.</summary>
		/// <returns>Read-only. Returns the underlying system type.</returns>
		/// <exception cref="T:System.InvalidOperationException">This type is an enumeration, but there is no underlying system type. </exception>
		// Token: 0x17000580 RID: 1408
		// (get) Token: 0x0600260F RID: 9743 RVA: 0x000956C0 File Offset: 0x000938C0
		public override Type UnderlyingSystemType
		{
			get
			{
				if (this.is_created)
				{
					return this.created.UnderlyingSystemType;
				}
				if (!this.IsEnum)
				{
					return this;
				}
				if (this.underlying_type != null)
				{
					return this.underlying_type;
				}
				throw new InvalidOperationException("Enumeration type is not defined.");
			}
		}

		/// <summary>Retrieves the full path of this type.</summary>
		/// <returns>Read-only. Retrieves the full path of this type.</returns>
		// Token: 0x17000581 RID: 1409
		// (get) Token: 0x06002610 RID: 9744 RVA: 0x000956FF File Offset: 0x000938FF
		public override string FullName
		{
			get
			{
				return this.fullname.DisplayName;
			}
		}

		/// <summary>Retrieves the GUID of this type.</summary>
		/// <returns>Read-only. Retrieves the GUID of this type </returns>
		/// <exception cref="T:System.NotSupportedException">This method is not currently supported for incomplete types. </exception>
		// Token: 0x17000582 RID: 1410
		// (get) Token: 0x06002611 RID: 9745 RVA: 0x0009570C File Offset: 0x0009390C
		public override Guid GUID
		{
			get
			{
				this.check_created();
				return this.created.GUID;
			}
		}

		/// <summary>Retrieves the dynamic module that contains this type definition.</summary>
		/// <returns>Read-only. Retrieves the dynamic module that contains this type definition.</returns>
		// Token: 0x17000583 RID: 1411
		// (get) Token: 0x06002612 RID: 9746 RVA: 0x0009571F File Offset: 0x0009391F
		public override Module Module
		{
			get
			{
				return this.pmodule;
			}
		}

		/// <summary>Retrieves the name of this type.</summary>
		/// <returns>Read-only. Retrieves the <see cref="T:System.String" /> name of this type.</returns>
		// Token: 0x17000584 RID: 1412
		// (get) Token: 0x06002613 RID: 9747 RVA: 0x00095727 File Offset: 0x00093927
		public override string Name
		{
			get
			{
				return this.tname;
			}
		}

		/// <summary>Retrieves the namespace where this <see langword="TypeBuilder" /> is defined.</summary>
		/// <returns>Read-only. Retrieves the namespace where this <see langword="TypeBuilder" /> is defined.</returns>
		// Token: 0x17000585 RID: 1413
		// (get) Token: 0x06002614 RID: 9748 RVA: 0x0009572F File Offset: 0x0009392F
		public override string Namespace
		{
			get
			{
				return this.nspace;
			}
		}

		/// <summary>Returns the type that was used to obtain this type.</summary>
		/// <returns>Read-only. The type that was used to obtain this type.</returns>
		// Token: 0x17000586 RID: 1414
		// (get) Token: 0x06002615 RID: 9749 RVA: 0x0009566F File Offset: 0x0009386F
		public override Type ReflectedType
		{
			get
			{
				return this.nesting_type;
			}
		}

		// Token: 0x06002616 RID: 9750 RVA: 0x00095738 File Offset: 0x00093938
		protected override ConstructorInfo GetConstructorImpl(BindingFlags bindingAttr, Binder binder, CallingConventions callConvention, Type[] types, ParameterModifier[] modifiers)
		{
			this.check_created();
			if (!(this.created == typeof(object)))
			{
				return this.created.GetConstructor(bindingAttr, binder, callConvention, types, modifiers);
			}
			if (this.ctors == null)
			{
				return null;
			}
			ConstructorBuilder constructorBuilder = null;
			int num = 0;
			foreach (ConstructorBuilder constructorBuilder2 in this.ctors)
			{
				if (callConvention == CallingConventions.Any || constructorBuilder2.CallingConvention == callConvention)
				{
					constructorBuilder = constructorBuilder2;
					num++;
				}
			}
			if (num == 0)
			{
				return null;
			}
			if (types != null)
			{
				MethodBase[] array2 = new MethodBase[num];
				if (num == 1)
				{
					array2[0] = constructorBuilder;
				}
				else
				{
					num = 0;
					foreach (ConstructorBuilder constructorInfo in this.ctors)
					{
						if (callConvention == CallingConventions.Any || constructorInfo.CallingConvention == callConvention)
						{
							array2[num++] = constructorInfo;
						}
					}
				}
				if (binder == null)
				{
					binder = Type.DefaultBinder;
				}
				return (ConstructorInfo)binder.SelectMethod(bindingAttr, array2, types, modifiers);
			}
			if (num > 1)
			{
				throw new AmbiguousMatchException();
			}
			return constructorBuilder;
		}

		/// <summary>Determines whether a custom attribute is applied to the current type.</summary>
		/// <param name="attributeType">The type of attribute to search for. Only attributes that are assignable to this type are returned. </param>
		/// <param name="inherit">Specifies whether to search this member's inheritance chain to find the attributes. </param>
		/// <returns>
		///     <see langword="true" /> if one or more instances of <paramref name="attributeType" />, or an attribute derived from <paramref name="attributeType" />, is defined on this type; otherwise, <see langword="false" />.</returns>
		/// <exception cref="T:System.NotSupportedException">This method is not currently supported for incomplete types. Retrieve the type using <see cref="M:System.Type.GetType" /> and call <see cref="M:System.Reflection.MemberInfo.IsDefined(System.Type,System.Boolean)" /> on the returned <see cref="T:System.Type" />. </exception>
		/// <exception cref="T:System.ArgumentException">
		///         <paramref name="attributeType" /> is not defined.</exception>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="attributeType" /> is <see langword="null" />.</exception>
		// Token: 0x06002617 RID: 9751 RVA: 0x00095833 File Offset: 0x00093A33
		public override bool IsDefined(Type attributeType, bool inherit)
		{
			if (!this.is_created)
			{
				throw new NotSupportedException();
			}
			return MonoCustomAttrs.IsDefined(this, attributeType, inherit);
		}

		/// <summary>Returns all the custom attributes defined for this type.</summary>
		/// <param name="inherit">Specifies whether to search this member's inheritance chain to find the attributes. </param>
		/// <returns>Returns an array of objects representing all the custom attributes of this type.</returns>
		/// <exception cref="T:System.NotSupportedException">This method is not currently supported for incomplete types. Retrieve the type using <see cref="M:System.Type.GetType" /> and call <see cref="M:System.Reflection.MemberInfo.GetCustomAttributes(System.Boolean)" /> on the returned <see cref="T:System.Type" />. </exception>
		// Token: 0x06002618 RID: 9752 RVA: 0x0009584B File Offset: 0x00093A4B
		public override object[] GetCustomAttributes(bool inherit)
		{
			this.check_created();
			return this.created.GetCustomAttributes(inherit);
		}

		/// <summary>Returns all the custom attributes of the current type that are assignable to a specified type.</summary>
		/// <param name="attributeType">The type of attribute to search for. Only attributes that are assignable to this type are returned.</param>
		/// <param name="inherit">Specifies whether to search this member's inheritance chain to find the attributes. </param>
		/// <returns>An array of custom attributes defined on the current type.</returns>
		/// <exception cref="T:System.NotSupportedException">This method is not currently supported for incomplete types. Retrieve the type using <see cref="M:System.Type.GetType" /> and call <see cref="M:System.Reflection.MemberInfo.GetCustomAttributes(System.Boolean)" /> on the returned <see cref="T:System.Type" />. </exception>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="attributeType" /> is <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">The type must be a type provided by the underlying runtime system.</exception>
		// Token: 0x06002619 RID: 9753 RVA: 0x0009585F File Offset: 0x00093A5F
		public override object[] GetCustomAttributes(Type attributeType, bool inherit)
		{
			this.check_created();
			return this.created.GetCustomAttributes(attributeType, inherit);
		}

		/// <summary>Adds a new constructor to the type, with the given attributes and signature.</summary>
		/// <param name="attributes">The attributes of the constructor. </param>
		/// <param name="callingConvention">The calling convention of the constructor. </param>
		/// <param name="parameterTypes">The parameter types of the constructor. </param>
		/// <returns>The defined constructor.</returns>
		/// <exception cref="T:System.InvalidOperationException">The type was previously created using <see cref="M:System.Reflection.Emit.TypeBuilder.CreateType" />. </exception>
		// Token: 0x0600261A RID: 9754 RVA: 0x00095874 File Offset: 0x00093A74
		[ComVisible(true)]
		public ConstructorBuilder DefineConstructor(MethodAttributes attributes, CallingConventions callingConvention, Type[] parameterTypes)
		{
			return this.DefineConstructor(attributes, callingConvention, parameterTypes, null, null);
		}

		/// <summary>Adds a new constructor to the type, with the given attributes, signature, and custom modifiers.</summary>
		/// <param name="attributes">The attributes of the constructor. </param>
		/// <param name="callingConvention">The calling convention of the constructor. </param>
		/// <param name="parameterTypes">The parameter types of the constructor. </param>
		/// <param name="requiredCustomModifiers">An array of arrays of types. Each array of types represents the required custom modifiers for the corresponding parameter, such as <see cref="T:System.Runtime.CompilerServices.IsConst" />. If a particular parameter has no required custom modifiers, specify <see langword="null" /> instead of an array of types. If none of the parameters have required custom modifiers, specify <see langword="null" /> instead of an array of arrays.</param>
		/// <param name="optionalCustomModifiers">An array of arrays of types. Each array of types represents the optional custom modifiers for the corresponding parameter, such as <see cref="T:System.Runtime.CompilerServices.IsConst" />. If a particular parameter has no optional custom modifiers, specify <see langword="null" /> instead of an array of types. If none of the parameters have optional custom modifiers, specify <see langword="null" /> instead of an array of arrays.</param>
		/// <returns>The defined constructor.</returns>
		/// <exception cref="T:System.ArgumentException">The size of <paramref name="requiredCustomModifiers" /> or <paramref name="optionalCustomModifiers" /> does not equal the size of <paramref name="parameterTypes" />.</exception>
		/// <exception cref="T:System.InvalidOperationException">The type was previously created using <see cref="M:System.Reflection.Emit.TypeBuilder.CreateType" />.-or-For the current dynamic type, the <see cref="P:System.Reflection.Emit.TypeBuilder.IsGenericType" /> property is <see langword="true" />, but the <see cref="P:System.Reflection.Emit.TypeBuilder.IsGenericTypeDefinition" /> property is <see langword="false" />.</exception>
		// Token: 0x0600261B RID: 9755 RVA: 0x00095884 File Offset: 0x00093A84
		[ComVisible(true)]
		public ConstructorBuilder DefineConstructor(MethodAttributes attributes, CallingConventions callingConvention, Type[] parameterTypes, Type[][] requiredCustomModifiers, Type[][] optionalCustomModifiers)
		{
			this.check_not_created();
			ConstructorBuilder constructorBuilder = new ConstructorBuilder(this, attributes, callingConvention, parameterTypes, requiredCustomModifiers, optionalCustomModifiers);
			if (this.ctors != null)
			{
				ConstructorBuilder[] array = new ConstructorBuilder[this.ctors.Length + 1];
				Array.Copy(this.ctors, array, this.ctors.Length);
				array[this.ctors.Length] = constructorBuilder;
				this.ctors = array;
			}
			else
			{
				this.ctors = new ConstructorBuilder[1];
				this.ctors[0] = constructorBuilder;
			}
			return constructorBuilder;
		}

		/// <summary>Defines the default constructor. The constructor defined here will simply call the default constructor of the parent.</summary>
		/// <param name="attributes">A <see langword="MethodAttributes" /> object representing the attributes to be applied to the constructor. </param>
		/// <returns>Returns the constructor.</returns>
		/// <exception cref="T:System.NotSupportedException">The parent type (base type) does not have a default constructor. </exception>
		/// <exception cref="T:System.InvalidOperationException">The type was previously created using <see cref="M:System.Reflection.Emit.TypeBuilder.CreateType" />.-or-For the current dynamic type, the <see cref="P:System.Reflection.Emit.TypeBuilder.IsGenericType" /> property is <see langword="true" />, but the <see cref="P:System.Reflection.Emit.TypeBuilder.IsGenericTypeDefinition" /> property is <see langword="false" />.</exception>
		// Token: 0x0600261C RID: 9756 RVA: 0x000958FC File Offset: 0x00093AFC
		[ComVisible(true)]
		public ConstructorBuilder DefineDefaultConstructor(MethodAttributes attributes)
		{
			Type type;
			if (this.parent != null)
			{
				type = this.parent;
			}
			else
			{
				type = this.pmodule.assemblyb.corlib_object_type;
			}
			Type type2 = type;
			type = type.InternalResolve();
			if (type == typeof(object) || type == typeof(ValueType))
			{
				type = type2;
			}
			ConstructorInfo constructor = type.GetConstructor(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic, null, Type.EmptyTypes, null);
			if (constructor == null)
			{
				throw new NotSupportedException("Parent does not have a default constructor. The default constructor must be explicitly defined.");
			}
			ConstructorBuilder constructorBuilder = this.DefineConstructor(attributes, CallingConventions.Standard, Type.EmptyTypes);
			ILGenerator ilgenerator = constructorBuilder.GetILGenerator();
			ilgenerator.Emit(OpCodes.Ldarg_0);
			ilgenerator.Emit(OpCodes.Call, constructor);
			ilgenerator.Emit(OpCodes.Ret);
			return constructorBuilder;
		}

		// Token: 0x0600261D RID: 9757 RVA: 0x000959B8 File Offset: 0x00093BB8
		private void append_method(MethodBuilder mb)
		{
			if (this.methods != null)
			{
				if (this.methods.Length == this.num_methods)
				{
					MethodBuilder[] destinationArray = new MethodBuilder[this.methods.Length * 2];
					Array.Copy(this.methods, destinationArray, this.num_methods);
					this.methods = destinationArray;
				}
			}
			else
			{
				this.methods = new MethodBuilder[1];
			}
			this.methods[this.num_methods] = mb;
			this.num_methods++;
		}

		/// <summary>Adds a new method to the type, with the specified name, method attributes, calling convention, and method signature.</summary>
		/// <param name="name">The name of the method. <paramref name="name" /> cannot contain embedded nulls. </param>
		/// <param name="attributes">The attributes of the method. </param>
		/// <param name="callingConvention">The calling convention of the method. </param>
		/// <param name="returnType">The return type of the method. </param>
		/// <param name="parameterTypes">The types of the parameters of the method. </param>
		/// <returns>A <see cref="T:System.Reflection.Emit.MethodBuilder" /> representing the newly defined method.</returns>
		/// <exception cref="T:System.ArgumentException">The length of <paramref name="name" /> is zero.-or- The type of the parent of this method is an interface, and this method is not virtual (<see langword="Overridable" /> in Visual Basic). </exception>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="name" /> is <see langword="null" />. </exception>
		/// <exception cref="T:System.InvalidOperationException">The type was previously created using <see cref="M:System.Reflection.Emit.TypeBuilder.CreateType" />.-or-For the current dynamic type, the <see cref="P:System.Reflection.Emit.TypeBuilder.IsGenericType" /> property is <see langword="true" />, but the <see cref="P:System.Reflection.Emit.TypeBuilder.IsGenericTypeDefinition" /> property is <see langword="false" />. </exception>
		// Token: 0x0600261E RID: 9758 RVA: 0x00095A30 File Offset: 0x00093C30
		public MethodBuilder DefineMethod(string name, MethodAttributes attributes, CallingConventions callingConvention, Type returnType, Type[] parameterTypes)
		{
			return this.DefineMethod(name, attributes, callingConvention, returnType, null, null, parameterTypes, null, null);
		}

		/// <summary>Adds a new method to the type, with the specified name, method attributes, calling convention, method signature, and custom modifiers.</summary>
		/// <param name="name">The name of the method. <paramref name="name" /> cannot contain embedded nulls. </param>
		/// <param name="attributes">The attributes of the method. </param>
		/// <param name="callingConvention">The calling convention of the method. </param>
		/// <param name="returnType">The return type of the method. </param>
		/// <param name="returnTypeRequiredCustomModifiers">An array of types representing the required custom modifiers, such as <see cref="T:System.Runtime.CompilerServices.IsConst" />, for the return type of the method. If the return type has no required custom modifiers, specify <see langword="null" />.</param>
		/// <param name="returnTypeOptionalCustomModifiers">An array of types representing the optional custom modifiers, such as <see cref="T:System.Runtime.CompilerServices.IsConst" />, for the return type of the method. If the return type has no optional custom modifiers, specify <see langword="null" />.</param>
		/// <param name="parameterTypes">The types of the parameters of the method.</param>
		/// <param name="parameterTypeRequiredCustomModifiers">An array of arrays of types. Each array of types represents the required custom modifiers for the corresponding parameter, such as <see cref="T:System.Runtime.CompilerServices.IsConst" />. If a particular parameter has no required custom modifiers, specify <see langword="null" /> instead of an array of types. If none of the parameters have required custom modifiers, specify <see langword="null" /> instead of an array of arrays.</param>
		/// <param name="parameterTypeOptionalCustomModifiers">An array of arrays of types. Each array of types represents the optional custom modifiers for the corresponding parameter, such as <see cref="T:System.Runtime.CompilerServices.IsConst" />. If a particular parameter has no optional custom modifiers, specify <see langword="null" /> instead of an array of types. If none of the parameters have optional custom modifiers, specify <see langword="null" /> instead of an array of arrays.</param>
		/// <returns>A <see cref="T:System.Reflection.Emit.MethodBuilder" /> object representing the newly added method.</returns>
		/// <exception cref="T:System.ArgumentException">The length of <paramref name="name" /> is zero.-or- The type of the parent of this method is an interface, and this method is not virtual (<see langword="Overridable" /> in Visual Basic). -or-The size of <paramref name="parameterTypeRequiredCustomModifiers" /> or <paramref name="parameterTypeOptionalCustomModifiers" /> does not equal the size of <paramref name="parameterTypes" />.</exception>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="name" /> is <see langword="null" />. </exception>
		/// <exception cref="T:System.InvalidOperationException">The type was previously created using <see cref="M:System.Reflection.Emit.TypeBuilder.CreateType" />.-or-For the current dynamic type, the <see cref="P:System.Reflection.Emit.TypeBuilder.IsGenericType" /> property is <see langword="true" />, but the <see cref="P:System.Reflection.Emit.TypeBuilder.IsGenericTypeDefinition" /> property is <see langword="false" />.</exception>
		// Token: 0x0600261F RID: 9759 RVA: 0x00095A50 File Offset: 0x00093C50
		public MethodBuilder DefineMethod(string name, MethodAttributes attributes, CallingConventions callingConvention, Type returnType, Type[] returnTypeRequiredCustomModifiers, Type[] returnTypeOptionalCustomModifiers, Type[] parameterTypes, Type[][] parameterTypeRequiredCustomModifiers, Type[][] parameterTypeOptionalCustomModifiers)
		{
			this.check_name("name", name);
			this.check_not_created();
			if (base.IsInterface && ((attributes & MethodAttributes.Abstract) == MethodAttributes.PrivateScope || (attributes & MethodAttributes.Virtual) == MethodAttributes.PrivateScope) && (attributes & MethodAttributes.Static) == MethodAttributes.PrivateScope)
			{
				throw new ArgumentException("Interface method must be abstract and virtual.");
			}
			if (returnType == null)
			{
				returnType = this.pmodule.assemblyb.corlib_void_type;
			}
			MethodBuilder methodBuilder = new MethodBuilder(this, name, attributes, callingConvention, returnType, returnTypeRequiredCustomModifiers, returnTypeOptionalCustomModifiers, parameterTypes, parameterTypeRequiredCustomModifiers, parameterTypeOptionalCustomModifiers);
			this.append_method(methodBuilder);
			return methodBuilder;
		}

		/// <summary>Adds a new method to the type, with the specified name and method attributes.</summary>
		/// <param name="name">The name of the method. <paramref name="name" /> cannot contain embedded nulls. </param>
		/// <param name="attributes">The attributes of the method. </param>
		/// <returns>A <see cref="T:System.Reflection.Emit.MethodBuilder" /> representing the newly defined method.</returns>
		/// <exception cref="T:System.ArgumentException">The length of <paramref name="name" /> is zero.-or- The type of the parent of this method is an interface, and this method is not virtual (<see langword="Overridable" /> in Visual Basic). </exception>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="name" /> is <see langword="null" />. </exception>
		/// <exception cref="T:System.InvalidOperationException">The type was previously created using <see cref="M:System.Reflection.Emit.TypeBuilder.CreateType" />.-or-For the current dynamic type, the <see cref="P:System.Reflection.Emit.TypeBuilder.IsGenericType" /> property is <see langword="true" />, but the <see cref="P:System.Reflection.Emit.TypeBuilder.IsGenericTypeDefinition" /> property is <see langword="false" />. </exception>
		// Token: 0x06002620 RID: 9760 RVA: 0x00095AD1 File Offset: 0x00093CD1
		public MethodBuilder DefineMethod(string name, MethodAttributes attributes)
		{
			return this.DefineMethod(name, attributes, CallingConventions.Standard);
		}

		/// <summary>Adds a new method to the type, with the specified name, method attributes, and calling convention.</summary>
		/// <param name="name">The name of the method. <paramref name="name" /> cannot contain embedded nulls. </param>
		/// <param name="attributes">The attributes of the method. </param>
		/// <param name="callingConvention">The calling convention of the method. </param>
		/// <returns>A <see cref="T:System.Reflection.Emit.MethodBuilder" /> representing the newly defined method.</returns>
		/// <exception cref="T:System.ArgumentException">The length of <paramref name="name" /> is zero.-or- The type of the parent of this method is an interface and this method is not virtual (<see langword="Overridable" /> in Visual Basic). </exception>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="name" /> is <see langword="null" />. </exception>
		/// <exception cref="T:System.InvalidOperationException">The type was previously created using <see cref="M:System.Reflection.Emit.TypeBuilder.CreateType" />.-or-For the current dynamic type, the <see cref="P:System.Reflection.Emit.TypeBuilder.IsGenericType" /> property is <see langword="true" />, but the <see cref="P:System.Reflection.Emit.TypeBuilder.IsGenericTypeDefinition" /> property is <see langword="false" />. </exception>
		// Token: 0x06002621 RID: 9761 RVA: 0x00095ADC File Offset: 0x00093CDC
		public MethodBuilder DefineMethod(string name, MethodAttributes attributes, CallingConventions callingConvention)
		{
			return this.DefineMethod(name, attributes, callingConvention, null, null);
		}

		/// <summary>Adds a new field to the type, with the given name, attributes, and field type.</summary>
		/// <param name="fieldName">The name of the field. <paramref name="fieldName" /> cannot contain embedded nulls. </param>
		/// <param name="type">The type of the field </param>
		/// <param name="attributes">The attributes of the field. </param>
		/// <returns>The defined field.</returns>
		/// <exception cref="T:System.ArgumentException">The length of <paramref name="fieldName" /> is zero.-or- 
		///         <paramref name="type" /> is System.Void.-or- A total size was specified for the parent class of this field. </exception>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="fieldName" /> is <see langword="null" />. </exception>
		/// <exception cref="T:System.InvalidOperationException">The type was previously created using <see cref="M:System.Reflection.Emit.TypeBuilder.CreateType" />.</exception>
		// Token: 0x06002622 RID: 9762 RVA: 0x00095AE9 File Offset: 0x00093CE9
		public FieldBuilder DefineField(string fieldName, Type type, FieldAttributes attributes)
		{
			return this.DefineField(fieldName, type, null, null, attributes);
		}

		/// <summary>Adds a new field to the type, with the given name, attributes, field type, and custom modifiers.</summary>
		/// <param name="fieldName">The name of the field. <paramref name="fieldName" /> cannot contain embedded nulls. </param>
		/// <param name="type">The type of the field </param>
		/// <param name="requiredCustomModifiers">An array of types representing the required custom modifiers for the field, such as <see cref="T:Microsoft.VisualC.IsConstModifier" />.</param>
		/// <param name="optionalCustomModifiers">An array of types representing the optional custom modifiers for the field, such as <see cref="T:Microsoft.VisualC.IsConstModifier" />.</param>
		/// <param name="attributes">The attributes of the field. </param>
		/// <returns>The defined field.</returns>
		/// <exception cref="T:System.ArgumentException">The length of <paramref name="fieldName" /> is zero.-or- 
		///         <paramref name="type" /> is System.Void.-or- A total size was specified for the parent class of this field. </exception>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="fieldName" /> is <see langword="null" />. </exception>
		/// <exception cref="T:System.InvalidOperationException">The type was previously created using <see cref="M:System.Reflection.Emit.TypeBuilder.CreateType" />. </exception>
		// Token: 0x06002623 RID: 9763 RVA: 0x00095AF8 File Offset: 0x00093CF8
		public FieldBuilder DefineField(string fieldName, Type type, Type[] requiredCustomModifiers, Type[] optionalCustomModifiers, FieldAttributes attributes)
		{
			this.check_name("fieldName", fieldName);
			if (type == typeof(void))
			{
				throw new ArgumentException("Bad field type in defining field.");
			}
			this.check_not_created();
			FieldBuilder fieldBuilder = new FieldBuilder(this, fieldName, type, attributes, requiredCustomModifiers, optionalCustomModifiers);
			if (this.fields != null)
			{
				if (this.fields.Length == this.num_fields)
				{
					FieldBuilder[] destinationArray = new FieldBuilder[this.fields.Length * 2];
					Array.Copy(this.fields, destinationArray, this.num_fields);
					this.fields = destinationArray;
				}
				this.fields[this.num_fields] = fieldBuilder;
				this.num_fields++;
			}
			else
			{
				this.fields = new FieldBuilder[1];
				this.fields[0] = fieldBuilder;
				this.num_fields++;
			}
			if (this.IsEnum && this.underlying_type == null && (attributes & FieldAttributes.Static) == FieldAttributes.PrivateScope)
			{
				this.underlying_type = type;
			}
			return fieldBuilder;
		}

		// Token: 0x06002624 RID: 9764
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern TypeInfo create_runtime_class();

		// Token: 0x06002625 RID: 9765 RVA: 0x00095BE9 File Offset: 0x00093DE9
		private bool is_nested_in(Type t)
		{
			while (t != null)
			{
				if (t == this)
				{
					return true;
				}
				t = t.DeclaringType;
			}
			return false;
		}

		// Token: 0x06002626 RID: 9766 RVA: 0x00095C0C File Offset: 0x00093E0C
		private bool has_ctor_method()
		{
			MethodAttributes methodAttributes = MethodAttributes.SpecialName | MethodAttributes.RTSpecialName;
			for (int i = 0; i < this.num_methods; i++)
			{
				MethodBuilder methodBuilder = this.methods[i];
				if (methodBuilder.Name == ConstructorInfo.ConstructorName && (methodBuilder.Attributes & methodAttributes) == methodAttributes)
				{
					return true;
				}
			}
			return false;
		}

		/// <summary>Creates a <see cref="T:System.Type" /> object for the class. After defining fields and methods on the class, <see langword="CreateType" /> is called in order to load its <see langword="Type" /> object.</summary>
		/// <returns>Returns the new <see cref="T:System.Type" /> object for this class.</returns>
		/// <exception cref="T:System.InvalidOperationException">The enclosing type has not been created.-or- This type is non-abstract and contains an abstract method.-or- 
		///         This type is not an abstract class or an interface and has a method without a method body. </exception>
		/// <exception cref="T:System.NotSupportedException">The type contains invalid Microsoft intermediate language (MSIL) code.-or- The branch target is specified using a 1-byte offset, but the target is at a distance greater than 127 bytes from the branch. </exception>
		/// <exception cref="T:System.TypeLoadException">The type cannot be loaded. For example, it contains a <see langword="static" /> method that has the calling convention <see cref="F:System.Reflection.CallingConventions.HasThis" />.</exception>
		// Token: 0x06002627 RID: 9767 RVA: 0x00095C59 File Offset: 0x00093E59
		public Type CreateType()
		{
			return this.CreateTypeInfo();
		}

		/// <summary>Gets a <see cref="T:System.Reflection.TypeInfo" /> object that represents this type.</summary>
		/// <returns>An object that represents this type.</returns>
		// Token: 0x06002628 RID: 9768 RVA: 0x00095C64 File Offset: 0x00093E64
		public TypeInfo CreateTypeInfo()
		{
			if (this.createTypeCalled)
			{
				return this.created;
			}
			if (!base.IsInterface && this.parent == null && this != this.pmodule.assemblyb.corlib_object_type && this.FullName != "<Module>")
			{
				this.SetParent(this.pmodule.assemblyb.corlib_object_type);
			}
			if (this.fields != null)
			{
				foreach (FieldBuilder fieldBuilder in this.fields)
				{
					if (!(fieldBuilder == null))
					{
						Type fieldType = fieldBuilder.FieldType;
						if (!fieldBuilder.IsStatic && fieldType is TypeBuilder && fieldType.IsValueType && fieldType != this && this.is_nested_in(fieldType))
						{
							TypeBuilder typeBuilder = (TypeBuilder)fieldType;
							if (!typeBuilder.is_created)
							{
								AppDomain.CurrentDomain.DoTypeBuilderResolve(typeBuilder);
								bool is_created = typeBuilder.is_created;
							}
						}
					}
				}
			}
			if (!base.IsInterface && !base.IsValueType && this.ctors == null && this.tname != "<Module>" && ((this.GetAttributeFlagsImpl() & TypeAttributes.Abstract) | TypeAttributes.Sealed) != (TypeAttributes.Abstract | TypeAttributes.Sealed) && !this.has_ctor_method())
			{
				this.DefineDefaultConstructor(MethodAttributes.Public);
			}
			this.createTypeCalled = true;
			if (this.parent != null && this.parent.IsSealed)
			{
				string[] array2 = new string[5];
				array2[0] = "Could not load type '";
				array2[1] = this.FullName;
				array2[2] = "' from assembly '";
				int num = 3;
				Assembly assembly = this.Assembly;
				array2[num] = ((assembly != null) ? assembly.ToString() : null);
				array2[4] = "' because the parent type is sealed.";
				throw new TypeLoadException(string.Concat(array2));
			}
			if (this.parent == this.pmodule.assemblyb.corlib_enum_type && this.methods != null)
			{
				string[] array3 = new string[5];
				array3[0] = "Could not load type '";
				array3[1] = this.FullName;
				array3[2] = "' from assembly '";
				int num2 = 3;
				Assembly assembly2 = this.Assembly;
				array3[num2] = ((assembly2 != null) ? assembly2.ToString() : null);
				array3[4] = "' because it is an enum with methods.";
				throw new TypeLoadException(string.Concat(array3));
			}
			if (this.interfaces != null)
			{
				foreach (Type type in this.interfaces)
				{
					if (type.IsNestedPrivate && type.Assembly != this.Assembly)
					{
						string[] array5 = new string[7];
						array5[0] = "Could not load type '";
						array5[1] = this.FullName;
						array5[2] = "' from assembly '";
						int num3 = 3;
						Assembly assembly3 = this.Assembly;
						array5[num3] = ((assembly3 != null) ? assembly3.ToString() : null);
						array5[4] = "' because it is implements the inaccessible interface '";
						array5[5] = type.FullName;
						array5[6] = "'.";
						throw new TypeLoadException(string.Concat(array5));
					}
				}
			}
			if (this.methods != null)
			{
				bool flag = !base.IsAbstract;
				for (int j = 0; j < this.num_methods; j++)
				{
					MethodBuilder methodBuilder = this.methods[j];
					if (flag && methodBuilder.IsAbstract)
					{
						string str = "Type is concrete but has abstract method ";
						MethodBuilder methodBuilder2 = methodBuilder;
						throw new InvalidOperationException(str + ((methodBuilder2 != null) ? methodBuilder2.ToString() : null));
					}
					methodBuilder.check_override();
					methodBuilder.fixup();
				}
			}
			if (this.ctors != null)
			{
				ConstructorBuilder[] array6 = this.ctors;
				for (int i = 0; i < array6.Length; i++)
				{
					array6[i].fixup();
				}
			}
			this.ResolveUserTypes();
			this.created = this.create_runtime_class();
			if (this.created != null)
			{
				return this.created;
			}
			return this;
		}

		// Token: 0x06002629 RID: 9769 RVA: 0x00095FE0 File Offset: 0x000941E0
		private void ResolveUserTypes()
		{
			this.parent = TypeBuilder.ResolveUserType(this.parent);
			TypeBuilder.ResolveUserTypes(this.interfaces);
			if (this.fields != null)
			{
				foreach (FieldBuilder fieldBuilder in this.fields)
				{
					if (fieldBuilder != null)
					{
						fieldBuilder.ResolveUserTypes();
					}
				}
			}
			if (this.methods != null)
			{
				foreach (MethodBuilder methodBuilder in this.methods)
				{
					if (methodBuilder != null)
					{
						methodBuilder.ResolveUserTypes();
					}
				}
			}
			if (this.ctors != null)
			{
				foreach (ConstructorBuilder constructorBuilder in this.ctors)
				{
					if (constructorBuilder != null)
					{
						constructorBuilder.ResolveUserTypes();
					}
				}
			}
		}

		// Token: 0x0600262A RID: 9770 RVA: 0x000960A4 File Offset: 0x000942A4
		internal static void ResolveUserTypes(Type[] types)
		{
			if (types != null)
			{
				for (int i = 0; i < types.Length; i++)
				{
					types[i] = TypeBuilder.ResolveUserType(types[i]);
				}
			}
		}

		// Token: 0x0600262B RID: 9771 RVA: 0x000960D0 File Offset: 0x000942D0
		internal static Type ResolveUserType(Type t)
		{
			if (!(t != null) || (!(t.GetType().Assembly != typeof(int).Assembly) && !(t is TypeDelegator)))
			{
				return t;
			}
			t = t.UnderlyingSystemType;
			if (t != null && (t.GetType().Assembly != typeof(int).Assembly || t is TypeDelegator))
			{
				throw new NotSupportedException("User defined subclasses of System.Type are not yet supported.");
			}
			return t;
		}

		/// <summary>Returns an array of <see cref="T:System.Reflection.ConstructorInfo" /> objects representing the public and non-public constructors defined for this class, as specified.</summary>
		/// <param name="bindingAttr">This must be a bit flag from <see cref="T:System.Reflection.BindingFlags" /> as in <see langword="InvokeMethod" />, <see langword="NonPublic" />, and so on. </param>
		/// <returns>Returns an array of <see cref="T:System.Reflection.ConstructorInfo" /> objects representing the specified constructors defined for this class. If no constructors are defined, an empty array is returned.</returns>
		/// <exception cref="T:System.NotSupportedException">This method is not implemented for incomplete types. </exception>
		// Token: 0x0600262C RID: 9772 RVA: 0x00096157 File Offset: 0x00094357
		[ComVisible(true)]
		public override ConstructorInfo[] GetConstructors(BindingFlags bindingAttr)
		{
			if (this.is_created)
			{
				return this.created.GetConstructors(bindingAttr);
			}
			throw new NotSupportedException();
		}

		/// <summary>Calling this method always throws <see cref="T:System.NotSupportedException" />.</summary>
		/// <returns>This method is not supported. No value is returned.</returns>
		/// <exception cref="T:System.NotSupportedException">This method is not supported. </exception>
		// Token: 0x0600262D RID: 9773 RVA: 0x0002AD12 File Offset: 0x00028F12
		public override Type GetElementType()
		{
			throw new NotSupportedException();
		}

		/// <summary>Returns the event with the specified name.</summary>
		/// <param name="name">The name of the event to search for. </param>
		/// <param name="bindingAttr">A bitwise combination of <see cref="T:System.Reflection.BindingFlags" /> values that limits the search. </param>
		/// <returns>An <see cref="T:System.Reflection.EventInfo" /> object representing the event declared or inherited by this type with the specified name, or <see langword="null" /> if there are no matches.</returns>
		/// <exception cref="T:System.NotSupportedException">This method is not implemented for incomplete types. </exception>
		// Token: 0x0600262E RID: 9774 RVA: 0x00096173 File Offset: 0x00094373
		public override EventInfo GetEvent(string name, BindingFlags bindingAttr)
		{
			this.check_created();
			return this.created.GetEvent(name, bindingAttr);
		}

		/// <summary>Returns the public and non-public events that are declared by this type.</summary>
		/// <param name="bindingAttr">A bitwise combination of <see cref="T:System.Reflection.BindingFlags" /> values that limits the search.</param>
		/// <returns>Returns an array of <see cref="T:System.Reflection.EventInfo" /> objects representing the events declared or inherited by this type that match the specified binding flags. An empty array is returned if there are no matching events.</returns>
		/// <exception cref="T:System.NotSupportedException">This method is not implemented for incomplete types. </exception>
		// Token: 0x0600262F RID: 9775 RVA: 0x00096188 File Offset: 0x00094388
		public override EventInfo[] GetEvents(BindingFlags bindingAttr)
		{
			if (this.is_created)
			{
				return this.created.GetEvents(bindingAttr);
			}
			throw new NotSupportedException();
		}

		/// <summary>Returns the field specified by the given name.</summary>
		/// <param name="name">The name of the field to get. </param>
		/// <param name="bindingAttr">This must be a bit flag from <see cref="T:System.Reflection.BindingFlags" /> as in <see langword="InvokeMethod" />, <see langword="NonPublic" />, and so on. </param>
		/// <returns>Returns the <see cref="T:System.Reflection.FieldInfo" /> object representing the field declared or inherited by this type with the specified name and public or non-public modifier. If there are no matches then <see langword="null" /> is returned.</returns>
		/// <exception cref="T:System.NotSupportedException">This method is not implemented for incomplete types. </exception>
		// Token: 0x06002630 RID: 9776 RVA: 0x000961A4 File Offset: 0x000943A4
		public override FieldInfo GetField(string name, BindingFlags bindingAttr)
		{
			if (this.created != null)
			{
				return this.created.GetField(name, bindingAttr);
			}
			if (this.fields == null)
			{
				return null;
			}
			foreach (FieldBuilder fieldInfo in this.fields)
			{
				if (!(fieldInfo == null) && !(fieldInfo.Name != name))
				{
					bool flag = false;
					FieldAttributes attributes = fieldInfo.Attributes;
					if ((attributes & FieldAttributes.FieldAccessMask) == FieldAttributes.Public)
					{
						if ((bindingAttr & BindingFlags.Public) != BindingFlags.Default)
						{
							flag = true;
						}
					}
					else if ((bindingAttr & BindingFlags.NonPublic) != BindingFlags.Default)
					{
						flag = true;
					}
					if (flag)
					{
						flag = false;
						if ((attributes & FieldAttributes.Static) != FieldAttributes.PrivateScope)
						{
							if ((bindingAttr & BindingFlags.Static) != BindingFlags.Default)
							{
								flag = true;
							}
						}
						else if ((bindingAttr & BindingFlags.Instance) != BindingFlags.Default)
						{
							flag = true;
						}
						if (flag)
						{
							return fieldInfo;
						}
					}
				}
			}
			return null;
		}

		/// <summary>Returns the public and non-public fields that are declared by this type.</summary>
		/// <param name="bindingAttr">This must be a bit flag from <see cref="T:System.Reflection.BindingFlags" /> : <see langword="InvokeMethod" />, <see langword="NonPublic" />, and so on. </param>
		/// <returns>Returns an array of <see cref="T:System.Reflection.FieldInfo" /> objects representing the public and non-public fields declared or inherited by this type. An empty array is returned if there are no fields, as specified.</returns>
		/// <exception cref="T:System.NotSupportedException">This method is not implemented for incomplete types. </exception>
		// Token: 0x06002631 RID: 9777 RVA: 0x00096250 File Offset: 0x00094450
		public override FieldInfo[] GetFields(BindingFlags bindingAttr)
		{
			if (this.created != null)
			{
				return this.created.GetFields(bindingAttr);
			}
			if (this.fields == null)
			{
				return new FieldInfo[0];
			}
			ArrayList arrayList = new ArrayList();
			foreach (FieldBuilder fieldInfo in this.fields)
			{
				if (!(fieldInfo == null))
				{
					bool flag = false;
					FieldAttributes attributes = fieldInfo.Attributes;
					if ((attributes & FieldAttributes.FieldAccessMask) == FieldAttributes.Public)
					{
						if ((bindingAttr & BindingFlags.Public) != BindingFlags.Default)
						{
							flag = true;
						}
					}
					else if ((bindingAttr & BindingFlags.NonPublic) != BindingFlags.Default)
					{
						flag = true;
					}
					if (flag)
					{
						flag = false;
						if ((attributes & FieldAttributes.Static) != FieldAttributes.PrivateScope)
						{
							if ((bindingAttr & BindingFlags.Static) != BindingFlags.Default)
							{
								flag = true;
							}
						}
						else if ((bindingAttr & BindingFlags.Instance) != BindingFlags.Default)
						{
							flag = true;
						}
						if (flag)
						{
							arrayList.Add(fieldInfo);
						}
					}
				}
			}
			FieldInfo[] array2 = new FieldInfo[arrayList.Count];
			arrayList.CopyTo(array2);
			return array2;
		}

		/// <summary>Returns an array of all the interfaces implemented on this type and its base types.</summary>
		/// <returns>Returns an array of <see cref="T:System.Type" /> objects representing the implemented interfaces. If none are defined, an empty array is returned.</returns>
		// Token: 0x06002632 RID: 9778 RVA: 0x00096318 File Offset: 0x00094518
		public override Type[] GetInterfaces()
		{
			if (this.is_created)
			{
				return this.created.GetInterfaces();
			}
			if (this.interfaces != null)
			{
				Type[] array = new Type[this.interfaces.Length];
				this.interfaces.CopyTo(array, 0);
				return array;
			}
			return Type.EmptyTypes;
		}

		/// <summary>Returns all the public and non-public members declared or inherited by this type, as specified.</summary>
		/// <param name="name">The name of the member. </param>
		/// <param name="type">The type of the member to return. </param>
		/// <param name="bindingAttr">This must be a bit flag from <see cref="T:System.Reflection.BindingFlags" />, as in <see langword="InvokeMethod" />, <see langword="NonPublic" />, and so on. </param>
		/// <returns>Returns an array of <see cref="T:System.Reflection.MemberInfo" /> objects representing the public and non-public members defined on this type if <paramref name="nonPublic" /> is used; otherwise, only the public members are returned.</returns>
		/// <exception cref="T:System.NotSupportedException">This method is not implemented for incomplete types. </exception>
		// Token: 0x06002633 RID: 9779 RVA: 0x00096363 File Offset: 0x00094563
		public override MemberInfo[] GetMember(string name, MemberTypes type, BindingFlags bindingAttr)
		{
			this.check_created();
			return this.created.GetMember(name, type, bindingAttr);
		}

		// Token: 0x06002634 RID: 9780 RVA: 0x0009637C File Offset: 0x0009457C
		private MethodInfo[] GetMethodsByName(string name, BindingFlags bindingAttr, bool ignoreCase, Type reflected_type)
		{
			MethodInfo[] array2;
			if ((bindingAttr & BindingFlags.DeclaredOnly) == BindingFlags.Default && this.parent != null)
			{
				MethodInfo[] array = this.parent.GetMethods(bindingAttr);
				ArrayList arrayList = new ArrayList(array.Length);
				bool flag = (bindingAttr & BindingFlags.FlattenHierarchy) > BindingFlags.Default;
				foreach (MethodInfo methodInfo in array)
				{
					MethodAttributes attributes = methodInfo.Attributes;
					if (!methodInfo.IsStatic || flag)
					{
						MethodAttributes methodAttributes = attributes & MethodAttributes.MemberAccessMask;
						bool flag2;
						if (methodAttributes != MethodAttributes.Private)
						{
							if (methodAttributes != MethodAttributes.Assembly)
							{
								if (methodAttributes == MethodAttributes.Public)
								{
									flag2 = ((bindingAttr & BindingFlags.Public) > BindingFlags.Default);
								}
								else
								{
									flag2 = ((bindingAttr & BindingFlags.NonPublic) > BindingFlags.Default);
								}
							}
							else
							{
								flag2 = ((bindingAttr & BindingFlags.NonPublic) > BindingFlags.Default);
							}
						}
						else
						{
							flag2 = false;
						}
						if (flag2)
						{
							arrayList.Add(methodInfo);
						}
					}
				}
				if (this.methods == null)
				{
					array2 = new MethodInfo[arrayList.Count];
					arrayList.CopyTo(array2);
				}
				else
				{
					array2 = new MethodInfo[this.methods.Length + arrayList.Count];
					arrayList.CopyTo(array2, 0);
					this.methods.CopyTo(array2, arrayList.Count);
				}
			}
			else
			{
				MethodInfo[] array3 = this.methods;
				array2 = array3;
			}
			if (array2 == null)
			{
				return new MethodInfo[0];
			}
			ArrayList arrayList2 = new ArrayList();
			foreach (MethodInfo methodInfo2 in array2)
			{
				if (!(methodInfo2 == null) && (name == null || string.Compare(methodInfo2.Name, name, ignoreCase) == 0))
				{
					bool flag2 = false;
					MethodAttributes attributes = methodInfo2.Attributes;
					if ((attributes & MethodAttributes.MemberAccessMask) == MethodAttributes.Public)
					{
						if ((bindingAttr & BindingFlags.Public) != BindingFlags.Default)
						{
							flag2 = true;
						}
					}
					else if ((bindingAttr & BindingFlags.NonPublic) != BindingFlags.Default)
					{
						flag2 = true;
					}
					if (flag2)
					{
						flag2 = false;
						if ((attributes & MethodAttributes.Static) != MethodAttributes.PrivateScope)
						{
							if ((bindingAttr & BindingFlags.Static) != BindingFlags.Default)
							{
								flag2 = true;
							}
						}
						else if ((bindingAttr & BindingFlags.Instance) != BindingFlags.Default)
						{
							flag2 = true;
						}
						if (flag2)
						{
							arrayList2.Add(methodInfo2);
						}
					}
				}
			}
			MethodInfo[] array4 = new MethodInfo[arrayList2.Count];
			arrayList2.CopyTo(array4);
			return array4;
		}

		/// <summary>Returns all the public and non-public methods declared or inherited by this type, as specified.</summary>
		/// <param name="bindingAttr">This must be a bit flag from <see cref="T:System.Reflection.BindingFlags" /> as in <see langword="InvokeMethod" />, <see langword="NonPublic" />, and so on. </param>
		/// <returns>Returns an array of <see cref="T:System.Reflection.MethodInfo" /> objects representing the public and non-public methods defined on this type if <paramref name="nonPublic" /> is used; otherwise, only the public methods are returned.</returns>
		/// <exception cref="T:System.NotSupportedException">This method is not implemented for incomplete types. </exception>
		// Token: 0x06002635 RID: 9781 RVA: 0x0009653C File Offset: 0x0009473C
		public override MethodInfo[] GetMethods(BindingFlags bindingAttr)
		{
			return this.GetMethodsByName(null, bindingAttr, false, this);
		}

		// Token: 0x06002636 RID: 9782 RVA: 0x00096548 File Offset: 0x00094748
		protected override MethodInfo GetMethodImpl(string name, BindingFlags bindingAttr, Binder binder, CallingConventions callConvention, Type[] types, ParameterModifier[] modifiers)
		{
			this.check_created();
			if (types == null)
			{
				return this.created.GetMethod(name, bindingAttr);
			}
			return this.created.GetMethod(name, bindingAttr, binder, callConvention, types, modifiers);
		}

		/// <summary>Returns the public and non-public nested types that are declared by this type.</summary>
		/// <param name="name">The <see cref="T:System.String" /> containing the name of the nested type to get. </param>
		/// <param name="bindingAttr">A bitmask comprised of one or more <see cref="T:System.Reflection.BindingFlags" /> that specify how the search is conducted.-or- Zero, to conduct a case-sensitive search for public methods. </param>
		/// <returns>A <see cref="T:System.Type" /> object representing the nested type that matches the specified requirements, if found; otherwise, <see langword="null" />.</returns>
		/// <exception cref="T:System.NotSupportedException">This method is not implemented for incomplete types. </exception>
		// Token: 0x06002637 RID: 9783 RVA: 0x00096578 File Offset: 0x00094778
		public override Type GetNestedType(string name, BindingFlags bindingAttr)
		{
			this.check_created();
			if (this.subtypes == null)
			{
				return null;
			}
			foreach (TypeBuilder typeBuilder in this.subtypes)
			{
				if (typeBuilder.is_created)
				{
					if ((typeBuilder.attrs & TypeAttributes.VisibilityMask) == TypeAttributes.NestedPublic)
					{
						if ((bindingAttr & BindingFlags.Public) == BindingFlags.Default)
						{
							goto IL_55;
						}
					}
					else if ((bindingAttr & BindingFlags.NonPublic) == BindingFlags.Default)
					{
						goto IL_55;
					}
					if (typeBuilder.Name == name)
					{
						return typeBuilder.created;
					}
				}
				IL_55:;
			}
			return null;
		}

		/// <summary>Returns all the public and non-public properties declared or inherited by this type, as specified.</summary>
		/// <param name="bindingAttr">This invocation attribute. This must be a bit flag from <see cref="T:System.Reflection.BindingFlags" /> : <see langword="InvokeMethod" />, <see langword="NonPublic" />, and so on. </param>
		/// <returns>Returns an array of <see langword="PropertyInfo" /> objects representing the public and non-public properties defined on this type if <paramref name="nonPublic" /> is used; otherwise, only the public properties are returned.</returns>
		/// <exception cref="T:System.NotSupportedException">This method is not implemented for incomplete types. </exception>
		// Token: 0x06002638 RID: 9784 RVA: 0x000965E8 File Offset: 0x000947E8
		public override PropertyInfo[] GetProperties(BindingFlags bindingAttr)
		{
			if (this.is_created)
			{
				return this.created.GetProperties(bindingAttr);
			}
			if (this.properties == null)
			{
				return new PropertyInfo[0];
			}
			ArrayList arrayList = new ArrayList();
			foreach (PropertyBuilder propertyInfo in this.properties)
			{
				bool flag = false;
				MethodInfo methodInfo = propertyInfo.GetGetMethod(true);
				if (methodInfo == null)
				{
					methodInfo = propertyInfo.GetSetMethod(true);
				}
				if (!(methodInfo == null))
				{
					MethodAttributes attributes = methodInfo.Attributes;
					if ((attributes & MethodAttributes.MemberAccessMask) == MethodAttributes.Public)
					{
						if ((bindingAttr & BindingFlags.Public) != BindingFlags.Default)
						{
							flag = true;
						}
					}
					else if ((bindingAttr & BindingFlags.NonPublic) != BindingFlags.Default)
					{
						flag = true;
					}
					if (flag)
					{
						flag = false;
						if ((attributes & MethodAttributes.Static) != MethodAttributes.PrivateScope)
						{
							if ((bindingAttr & BindingFlags.Static) != BindingFlags.Default)
							{
								flag = true;
							}
						}
						else if ((bindingAttr & BindingFlags.Instance) != BindingFlags.Default)
						{
							flag = true;
						}
						if (flag)
						{
							arrayList.Add(propertyInfo);
						}
					}
				}
			}
			PropertyInfo[] array2 = new PropertyInfo[arrayList.Count];
			arrayList.CopyTo(array2);
			return array2;
		}

		// Token: 0x06002639 RID: 9785 RVA: 0x000966C7 File Offset: 0x000948C7
		protected override PropertyInfo GetPropertyImpl(string name, BindingFlags bindingAttr, Binder binder, Type returnType, Type[] types, ParameterModifier[] modifiers)
		{
			throw this.not_supported();
		}

		// Token: 0x0600263A RID: 9786 RVA: 0x000966CF File Offset: 0x000948CF
		protected override bool HasElementTypeImpl()
		{
			return this.is_created && this.created.HasElementType;
		}

		/// <summary>Invokes the specified member. The method that is to be invoked must be accessible and provide the most specific match with the specified argument list, under the constraints of the specified binder and invocation attributes.</summary>
		/// <param name="name">The name of the member to invoke. This can be a constructor, method, property, or field. A suitable invocation attribute must be specified. Note that it is possible to invoke the default member of a class by passing an empty string as the name of the member. </param>
		/// <param name="invokeAttr">The invocation attribute. This must be a bit flag from <see langword="BindingFlags" />. </param>
		/// <param name="binder">An object that enables the binding, coercion of argument types, invocation of members, and retrieval of <see langword="MemberInfo" /> objects using reflection. If binder is <see langword="null" />, the default binder is used. See <see cref="T:System.Reflection.Binder" />. </param>
		/// <param name="target">The object on which to invoke the specified member. If the member is static, this parameter is ignored. </param>
		/// <param name="args">An argument list. This is an array of Objects that contains the number, order, and type of the parameters of the member to be invoked. If there are no parameters this should be null. </param>
		/// <param name="modifiers">An array of the same length as <paramref name="args" /> with elements that represent the attributes associated with the arguments of the member to be invoked. A parameter has attributes associated with it in the metadata. They are used by various interoperability services. See the metadata specs for more details. </param>
		/// <param name="culture">An instance of <see langword="CultureInfo" /> used to govern the coercion of types. If this is null, the <see langword="CultureInfo" /> for the current thread is used. (Note that this is necessary to, for example, convert a String that represents 1000 to a Double value, since 1000 is represented differently by different cultures.) </param>
		/// <param name="namedParameters">Each parameter in the <paramref name="namedParameters" /> array gets the value in the corresponding element in the <paramref name="args" /> array. If the length of <paramref name="args" /> is greater than the length of <paramref name="namedParameters" />, the remaining argument values are passed in order. </param>
		/// <returns>Returns the return value of the invoked member.</returns>
		/// <exception cref="T:System.NotSupportedException">This method is not currently supported for incomplete types. </exception>
		// Token: 0x0600263B RID: 9787 RVA: 0x000966E8 File Offset: 0x000948E8
		public override object InvokeMember(string name, BindingFlags invokeAttr, Binder binder, object target, object[] args, ParameterModifier[] modifiers, CultureInfo culture, string[] namedParameters)
		{
			this.check_created();
			return this.created.InvokeMember(name, invokeAttr, binder, target, args, modifiers, culture, namedParameters);
		}

		// Token: 0x0600263C RID: 9788 RVA: 0x0002ACA4 File Offset: 0x00028EA4
		protected override bool IsArrayImpl()
		{
			return false;
		}

		// Token: 0x0600263D RID: 9789 RVA: 0x0002ACA4 File Offset: 0x00028EA4
		protected override bool IsByRefImpl()
		{
			return false;
		}

		// Token: 0x0600263E RID: 9790 RVA: 0x0002AD4C File Offset: 0x00028F4C
		protected override bool IsCOMObjectImpl()
		{
			return (this.GetAttributeFlagsImpl() & TypeAttributes.Import) > TypeAttributes.NotPublic;
		}

		// Token: 0x0600263F RID: 9791 RVA: 0x0002ACA4 File Offset: 0x00028EA4
		protected override bool IsPointerImpl()
		{
			return false;
		}

		// Token: 0x06002640 RID: 9792 RVA: 0x0002ACA4 File Offset: 0x00028EA4
		protected override bool IsPrimitiveImpl()
		{
			return false;
		}

		// Token: 0x06002641 RID: 9793 RVA: 0x00096714 File Offset: 0x00094914
		protected override bool IsValueTypeImpl()
		{
			if (this == this.pmodule.assemblyb.corlib_value_type || this == this.pmodule.assemblyb.corlib_enum_type)
			{
				return false;
			}
			Type baseType = this.parent;
			while (baseType != null)
			{
				if (baseType == this.pmodule.assemblyb.corlib_value_type)
				{
					return true;
				}
				baseType = baseType.BaseType;
			}
			return false;
		}

		/// <summary>Returns a <see cref="T:System.Type" /> object that represents a one-dimensional array of the current type, with a lower bound of zero.</summary>
		/// <returns>A <see cref="T:System.Type" /> object representing a one-dimensional array type whose element type is the current type, with a lower bound of zero.</returns>
		// Token: 0x06002642 RID: 9794 RVA: 0x0008EF9D File Offset: 0x0008D19D
		public override Type MakeArrayType()
		{
			return new ArrayType(this, 0);
		}

		/// <summary>Returns a <see cref="T:System.Type" /> object that represents an array of the current type, with the specified number of dimensions.</summary>
		/// <param name="rank">The number of dimensions for the array. </param>
		/// <returns>A <see cref="T:System.Type" /> object that represents a one-dimensional array of the current type.</returns>
		/// <exception cref="T:System.IndexOutOfRangeException">
		///         <paramref name="rank" /> is not a valid array dimension.</exception>
		// Token: 0x06002643 RID: 9795 RVA: 0x0008EFA6 File Offset: 0x0008D1A6
		public override Type MakeArrayType(int rank)
		{
			if (rank < 1)
			{
				throw new IndexOutOfRangeException();
			}
			return new ArrayType(this, rank);
		}

		/// <summary>Returns a <see cref="T:System.Type" /> object that represents the current type when passed as a <see langword="ref" /> parameter (<see langword="ByRef" /> in Visual Basic).</summary>
		/// <returns>A <see cref="T:System.Type" /> object that represents the current type when passed as a <see langword="ref" /> parameter (<see langword="ByRef" /> in Visual Basic).</returns>
		// Token: 0x06002644 RID: 9796 RVA: 0x0008EFB9 File Offset: 0x0008D1B9
		public override Type MakeByRefType()
		{
			return new ByRefType(this);
		}

		/// <summary>Substitutes the elements of an array of types for the type parameters of the current generic type definition, and returns the resulting constructed type.</summary>
		/// <param name="typeArguments">An array of types to be substituted for the type parameters of the current generic type definition.</param>
		/// <returns>A <see cref="T:System.Type" /> representing the constructed type formed by substituting the elements of <paramref name="typeArguments" /> for the type parameters of the current generic type. </returns>
		/// <exception cref="T:System.InvalidOperationException">The current type does not represent the definition of a generic type. That is, <see cref="P:System.Reflection.Emit.TypeBuilder.IsGenericTypeDefinition" /> returns <see langword="false" />. </exception>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="typeArguments" /> is <see langword="null" />.-or- Any element of <paramref name="typeArguments" /> is <see langword="null" />. </exception>
		/// <exception cref="T:System.ArgumentException">
		///         The <see cref="P:System.Type.Module" /> property of any element of <paramref name="typeArguments" /> is <see langword="null" />. -or- The <see cref="P:System.Reflection.Module.Assembly" /> property of the module of any element of <paramref name="typeArguments" /> is <see langword="null" />. </exception>
		// Token: 0x06002645 RID: 9797 RVA: 0x00096788 File Offset: 0x00094988
		public override Type MakeGenericType(params Type[] typeArguments)
		{
			if (!this.IsGenericTypeDefinition)
			{
				throw new InvalidOperationException("not a generic type definition");
			}
			if (typeArguments == null)
			{
				throw new ArgumentNullException("typeArguments");
			}
			if (this.generic_params.Length != typeArguments.Length)
			{
				throw new ArgumentException(string.Format("The type or method has {0} generic parameter(s) but {1} generic argument(s) where provided. A generic argument must be provided for each generic parameter.", this.generic_params.Length, typeArguments.Length), "typeArguments");
			}
			for (int i = 0; i < typeArguments.Length; i++)
			{
				if (typeArguments[i] == null)
				{
					throw new ArgumentNullException("typeArguments");
				}
			}
			Type[] array = new Type[typeArguments.Length];
			typeArguments.CopyTo(array, 0);
			return this.pmodule.assemblyb.MakeGenericType(this, array);
		}

		/// <summary>Returns a <see cref="T:System.Type" /> object that represents the type of an unmanaged pointer to the current type.</summary>
		/// <returns>A <see cref="T:System.Type" /> object that represents the type of an unmanaged pointer to the current type.</returns>
		// Token: 0x06002646 RID: 9798 RVA: 0x0008EFC1 File Offset: 0x0008D1C1
		public override Type MakePointerType()
		{
			return new PointerType(this);
		}

		/// <summary>Not supported in dynamic modules.</summary>
		/// <returns>Read-only.</returns>
		/// <exception cref="T:System.NotSupportedException">Not supported in dynamic modules. </exception>
		// Token: 0x17000587 RID: 1415
		// (get) Token: 0x06002647 RID: 9799 RVA: 0x00096836 File Offset: 0x00094A36
		public override RuntimeTypeHandle TypeHandle
		{
			get
			{
				this.check_created();
				return this.created.TypeHandle;
			}
		}

		/// <summary>Sets the base type of the type currently under construction.</summary>
		/// <param name="parent">The new base type. </param>
		/// <exception cref="T:System.InvalidOperationException">The type was previously created using <see cref="M:System.Reflection.Emit.TypeBuilder.CreateType" />.-or-
		///         <paramref name="parent" /> is <see langword="null" />, and the current instance represents an interface whose attributes do not include <see cref="F:System.Reflection.TypeAttributes.Abstract" />.-or-For the current dynamic type, the <see cref="P:System.Reflection.Emit.TypeBuilder.IsGenericType" /> property is <see langword="true" />, but the <see cref="P:System.Reflection.Emit.TypeBuilder.IsGenericTypeDefinition" /> property is <see langword="false" />. </exception>
		/// <exception cref="T:System.ArgumentException">
		///         <paramref name="parent" /> is an interface. This exception condition is new in the .NET Framework version 2.0. </exception>
		// Token: 0x06002648 RID: 9800 RVA: 0x0009684C File Offset: 0x00094A4C
		public void SetParent(Type parent)
		{
			this.check_not_created();
			if (parent == null)
			{
				if ((this.attrs & TypeAttributes.ClassSemanticsMask) != TypeAttributes.NotPublic)
				{
					if ((this.attrs & TypeAttributes.Abstract) == TypeAttributes.NotPublic)
					{
						throw new InvalidOperationException("Interface must be declared abstract.");
					}
					this.parent = null;
				}
				else
				{
					this.parent = typeof(object);
				}
			}
			else
			{
				this.parent = parent;
			}
			this.parent = TypeBuilder.ResolveUserType(this.parent);
		}

		// Token: 0x06002649 RID: 9801 RVA: 0x000968BF File Offset: 0x00094ABF
		internal int get_next_table_index(object obj, int table, int count)
		{
			return this.pmodule.get_next_table_index(obj, table, count);
		}

		// Token: 0x0600264A RID: 9802 RVA: 0x000968CF File Offset: 0x00094ACF
		internal override Type InternalResolve()
		{
			this.check_created();
			return this.created;
		}

		// Token: 0x0600264B RID: 9803 RVA: 0x000968CF File Offset: 0x00094ACF
		internal override Type RuntimeResolve()
		{
			this.check_created();
			return this.created;
		}

		// Token: 0x17000588 RID: 1416
		// (get) Token: 0x0600264C RID: 9804 RVA: 0x000968DD File Offset: 0x00094ADD
		internal bool is_created
		{
			get
			{
				return this.createTypeCalled;
			}
		}

		// Token: 0x0600264D RID: 9805 RVA: 0x0008F51E File Offset: 0x0008D71E
		private Exception not_supported()
		{
			return new NotSupportedException("The invoked member is not supported in a dynamic module.");
		}

		// Token: 0x0600264E RID: 9806 RVA: 0x000968E5 File Offset: 0x00094AE5
		private void check_not_created()
		{
			if (this.is_created)
			{
				throw new InvalidOperationException("Unable to change after type has been created.");
			}
		}

		// Token: 0x0600264F RID: 9807 RVA: 0x000968FA File Offset: 0x00094AFA
		private void check_created()
		{
			if (!this.is_created)
			{
				throw this.not_supported();
			}
		}

		// Token: 0x06002650 RID: 9808 RVA: 0x0009690B File Offset: 0x00094B0B
		private void check_name(string argName, string name)
		{
			if (name == null)
			{
				throw new ArgumentNullException(argName);
			}
			if (name.Length == 0)
			{
				throw new ArgumentException("Empty name is not legal", argName);
			}
			if (name[0] == '\0')
			{
				throw new ArgumentException("Illegal name", argName);
			}
		}

		/// <summary>Returns the name of the type excluding the namespace.</summary>
		/// <returns>Read-only. The name of the type excluding the namespace.</returns>
		// Token: 0x06002651 RID: 9809 RVA: 0x00096940 File Offset: 0x00094B40
		public override string ToString()
		{
			return this.FullName;
		}

		/// <summary>Gets a value that indicates whether a specified <see cref="T:System.Type" /> can be assigned to this object.</summary>
		/// <param name="c">The object to test. </param>
		/// <returns>
		///     <see langword="true" /> if the <paramref name="c" /> parameter and the current type represent the same type, or if the current type is in the inheritance hierarchy of <paramref name="c" />, or if the current type is an interface that <paramref name="c" /> supports. <see langword="false" /> if none of these conditions are valid, or if <paramref name="c" /> is <see langword="null" />.</returns>
		// Token: 0x06002652 RID: 9810 RVA: 0x00096948 File Offset: 0x00094B48
		public override bool IsAssignableFrom(Type c)
		{
			return base.IsAssignableFrom(c);
		}

		// Token: 0x06002653 RID: 9811 RVA: 0x00096954 File Offset: 0x00094B54
		internal bool IsAssignableTo(Type c)
		{
			if (c == this)
			{
				return true;
			}
			if (c.IsInterface)
			{
				if (this.parent != null && this.is_created && c.IsAssignableFrom(this.parent))
				{
					return true;
				}
				if (this.interfaces == null)
				{
					return false;
				}
				foreach (Type c2 in this.interfaces)
				{
					if (c.IsAssignableFrom(c2))
					{
						return true;
					}
				}
				if (!this.is_created)
				{
					return false;
				}
			}
			if (this.parent == null)
			{
				return c == typeof(object);
			}
			return c.IsAssignableFrom(this.parent);
		}

		/// <summary>Returns a value that indicates whether the current dynamic type has been created.</summary>
		/// <returns>
		///     <see langword="true" /> if the <see cref="M:System.Reflection.Emit.TypeBuilder.CreateType" /> method has been called; otherwise, <see langword="false" />. </returns>
		// Token: 0x06002654 RID: 9812 RVA: 0x000969FD File Offset: 0x00094BFD
		public bool IsCreated()
		{
			return this.is_created;
		}

		/// <summary>Returns an array of <see cref="T:System.Type" /> objects representing the type arguments of a generic type or the type parameters of a generic type definition.</summary>
		/// <returns>An array of <see cref="T:System.Type" /> objects. The elements of the array represent the type arguments of a generic type or the type parameters of a generic type definition.</returns>
		// Token: 0x06002655 RID: 9813 RVA: 0x00096A08 File Offset: 0x00094C08
		public override Type[] GetGenericArguments()
		{
			if (this.generic_params == null)
			{
				return null;
			}
			Type[] array = new Type[this.generic_params.Length];
			this.generic_params.CopyTo(array, 0);
			return array;
		}

		/// <summary>Returns a <see cref="T:System.Type" /> object that represents a generic type definition from which the current type can be obtained.</summary>
		/// <returns>A <see cref="T:System.Type" /> object representing a generic type definition from which the current type can be obtained.</returns>
		/// <exception cref="T:System.InvalidOperationException">The current type is not generic. That is, <see cref="P:System.Reflection.Emit.TypeBuilder.IsGenericType" /> returns <see langword="false" />.</exception>
		// Token: 0x06002656 RID: 9814 RVA: 0x00096A3B File Offset: 0x00094C3B
		public override Type GetGenericTypeDefinition()
		{
			if (this.generic_params == null)
			{
				throw new InvalidOperationException("Type is not generic");
			}
			return this;
		}

		// Token: 0x17000589 RID: 1417
		// (get) Token: 0x06002657 RID: 9815 RVA: 0x00096A51 File Offset: 0x00094C51
		public override bool ContainsGenericParameters
		{
			get
			{
				return this.generic_params != null;
			}
		}

		/// <summary>Gets a value indicating whether the current type is a generic type parameter.</summary>
		/// <returns>
		///     <see langword="true" /> if the current <see cref="T:System.Reflection.Emit.TypeBuilder" /> object represents a generic type parameter; otherwise, <see langword="false" />.</returns>
		// Token: 0x1700058A RID: 1418
		// (get) Token: 0x06002658 RID: 9816 RVA: 0x0002ACA4 File Offset: 0x00028EA4
		public override bool IsGenericParameter
		{
			get
			{
				return false;
			}
		}

		/// <summary>Gets a value that indicates the covariance and special constraints of the current generic type parameter. </summary>
		/// <returns>A bitwise combination of <see cref="T:System.Reflection.GenericParameterAttributes" /> values that describes the covariance and special constraints of the current generic type parameter.</returns>
		// Token: 0x1700058B RID: 1419
		// (get) Token: 0x06002659 RID: 9817 RVA: 0x0002ACA4 File Offset: 0x00028EA4
		public override GenericParameterAttributes GenericParameterAttributes
		{
			get
			{
				return GenericParameterAttributes.None;
			}
		}

		/// <summary>Gets a value indicating whether the current <see cref="T:System.Reflection.Emit.TypeBuilder" /> represents a generic type definition from which other generic types can be constructed.</summary>
		/// <returns>
		///     <see langword="true" /> if this <see cref="T:System.Reflection.Emit.TypeBuilder" /> object represents a generic type definition; otherwise, <see langword="false" />.</returns>
		// Token: 0x1700058C RID: 1420
		// (get) Token: 0x0600265A RID: 9818 RVA: 0x00096A51 File Offset: 0x00094C51
		public override bool IsGenericTypeDefinition
		{
			get
			{
				return this.generic_params != null;
			}
		}

		/// <summary>Gets a value indicating whether the current type is a generic type. </summary>
		/// <returns>
		///     <see langword="true" /> if the type represented by the current <see cref="T:System.Reflection.Emit.TypeBuilder" /> object is generic; otherwise, <see langword="false" />.</returns>
		// Token: 0x1700058D RID: 1421
		// (get) Token: 0x0600265B RID: 9819 RVA: 0x00096A5C File Offset: 0x00094C5C
		public override bool IsGenericType
		{
			get
			{
				return this.IsGenericTypeDefinition;
			}
		}

		/// <summary>Gets the position of a type parameter in the type parameter list of the generic type that declared the parameter.</summary>
		/// <returns>If the current <see cref="T:System.Reflection.Emit.TypeBuilder" /> object represents a generic type parameter, the position of the type parameter in the type parameter list of the generic type that declared the parameter; otherwise, undefined.</returns>
		// Token: 0x1700058E RID: 1422
		// (get) Token: 0x0600265C RID: 9820 RVA: 0x0002ACA4 File Offset: 0x00028EA4
		public override int GenericParameterPosition
		{
			get
			{
				return 0;
			}
		}

		/// <summary>Gets the method that declared the current generic type parameter.</summary>
		/// <returns>A <see cref="T:System.Reflection.MethodBase" /> that represents the method that declared the current type, if the current type is a generic type parameter; otherwise, <see langword="null" />.</returns>
		// Token: 0x1700058F RID: 1423
		// (get) Token: 0x0600265D RID: 9821 RVA: 0x0002AC82 File Offset: 0x00028E82
		public override MethodBase DeclaringMethod
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000590 RID: 1424
		// (get) Token: 0x0600265E RID: 9822 RVA: 0x0002ACA4 File Offset: 0x00028EA4
		internal override bool IsUserType
		{
			get
			{
				return false;
			}
		}

		/// <summary>Gets a value that indicates whether this object represents a constructed generic type.</summary>
		/// <returns>
		///     <see langword="true" /> if this object represents a constructed generic type; otherwise, <see langword="false" />.</returns>
		// Token: 0x17000591 RID: 1425
		// (get) Token: 0x0600265F RID: 9823 RVA: 0x0002ACA4 File Offset: 0x00028EA4
		public override bool IsConstructedGenericType
		{
			get
			{
				return false;
			}
		}

		/// <summary>Gets a value that indicates whether a specified <see cref="T:System.Reflection.TypeInfo" /> object can be assigned to this object.</summary>
		/// <param name="typeInfo">The object to test.</param>
		/// <returns>
		///     <see langword="true" /> if <paramref name="typeInfo" /> can be assigned to this object; otherwise, <see langword="false" />.</returns>
		// Token: 0x06002660 RID: 9824 RVA: 0x00096A64 File Offset: 0x00094C64
		public override bool IsAssignableFrom(TypeInfo typeInfo)
		{
			return base.IsAssignableFrom(typeInfo);
		}

		// Token: 0x040013B6 RID: 5046
		private string tname;

		// Token: 0x040013B7 RID: 5047
		private string nspace;

		// Token: 0x040013B8 RID: 5048
		private Type parent;

		// Token: 0x040013B9 RID: 5049
		private Type nesting_type;

		// Token: 0x040013BA RID: 5050
		internal Type[] interfaces;

		// Token: 0x040013BB RID: 5051
		internal int num_methods;

		// Token: 0x040013BC RID: 5052
		internal MethodBuilder[] methods;

		// Token: 0x040013BD RID: 5053
		internal ConstructorBuilder[] ctors;

		// Token: 0x040013BE RID: 5054
		internal PropertyBuilder[] properties;

		// Token: 0x040013BF RID: 5055
		internal int num_fields;

		// Token: 0x040013C0 RID: 5056
		internal FieldBuilder[] fields;

		// Token: 0x040013C1 RID: 5057
		internal EventBuilder[] events;

		// Token: 0x040013C2 RID: 5058
		private CustomAttributeBuilder[] cattrs;

		// Token: 0x040013C3 RID: 5059
		internal TypeBuilder[] subtypes;

		// Token: 0x040013C4 RID: 5060
		internal TypeAttributes attrs;

		// Token: 0x040013C5 RID: 5061
		private int table_idx;

		// Token: 0x040013C6 RID: 5062
		private ModuleBuilder pmodule;

		// Token: 0x040013C7 RID: 5063
		private int class_size;

		// Token: 0x040013C8 RID: 5064
		private PackingSize packing_size;

		// Token: 0x040013C9 RID: 5065
		private IntPtr generic_container;

		// Token: 0x040013CA RID: 5066
		private GenericTypeParameterBuilder[] generic_params;

		// Token: 0x040013CB RID: 5067
		private RefEmitPermissionSet[] permissions;

		// Token: 0x040013CC RID: 5068
		private TypeInfo created;

		// Token: 0x040013CD RID: 5069
		private int state;

		// Token: 0x040013CE RID: 5070
		private TypeName fullname;

		// Token: 0x040013CF RID: 5071
		private bool createTypeCalled;

		// Token: 0x040013D0 RID: 5072
		private Type underlying_type;

		/// <summary>Represents that total size for the type is not specified.</summary>
		// Token: 0x040013D1 RID: 5073
		public const int UnspecifiedTypeSize = 0;
	}
}
