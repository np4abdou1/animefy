using System;
using System.Globalization;
using System.Runtime.InteropServices;

namespace System.Reflection.Emit
{
	/// <summary>Defines and represents a method (or constructor) on a dynamic class.</summary>
	// Token: 0x0200050B RID: 1291
	[StructLayout(0)]
	public sealed class MethodBuilder : MethodInfo
	{
		// Token: 0x06002572 RID: 9586 RVA: 0x00092648 File Offset: 0x00090848
		internal MethodBuilder(TypeBuilder tb, string name, MethodAttributes attributes, CallingConventions callingConvention, Type returnType, Type[] returnModReq, Type[] returnModOpt, Type[] parameterTypes, Type[][] paramModReq, Type[][] paramModOpt)
		{
			this.name = name;
			this.attrs = attributes;
			this.call_conv = callingConvention;
			this.rtype = returnType;
			this.returnModReq = returnModReq;
			this.returnModOpt = returnModOpt;
			this.paramModReq = paramModReq;
			this.paramModOpt = paramModOpt;
			if ((attributes & MethodAttributes.Static) == MethodAttributes.PrivateScope)
			{
				this.call_conv |= CallingConventions.HasThis;
			}
			if (parameterTypes != null)
			{
				for (int i = 0; i < parameterTypes.Length; i++)
				{
					if (parameterTypes[i] == null)
					{
						throw new ArgumentException("Elements of the parameterTypes array cannot be null", "parameterTypes");
					}
				}
				this.parameters = new Type[parameterTypes.Length];
				Array.Copy(parameterTypes, this.parameters, parameterTypes.Length);
			}
			this.type = tb;
			this.table_idx = this.get_next_table_index(this, 6, 1);
			((ModuleBuilder)tb.Module).RegisterToken(this, this.GetToken().Token);
		}

		/// <summary>Not supported for this type.</summary>
		/// <returns>Not supported.</returns>
		/// <exception cref="T:System.NotSupportedException">The invoked method is not supported in the base class.</exception>
		// Token: 0x1700054D RID: 1357
		// (get) Token: 0x06002573 RID: 9587 RVA: 0x0002AD12 File Offset: 0x00028F12
		public override bool ContainsGenericParameters
		{
			get
			{
				throw new NotSupportedException();
			}
		}

		// Token: 0x1700054E RID: 1358
		// (get) Token: 0x06002574 RID: 9588 RVA: 0x00092739 File Offset: 0x00090939
		internal TypeBuilder TypeBuilder
		{
			get
			{
				return this.type;
			}
		}

		/// <summary>Retrieves the internal handle for the method. Use this handle to access the underlying metadata handle.</summary>
		/// <returns>Read-only. The internal handle for the method. Use this handle to access the underlying metadata handle.</returns>
		/// <exception cref="T:System.NotSupportedException">This method is not currently supported. Retrieve the method using <see cref="M:System.Type.GetMethod(System.String,System.Reflection.BindingFlags,System.Reflection.Binder,System.Reflection.CallingConventions,System.Type[],System.Reflection.ParameterModifier[])" /> and call <see cref="P:System.Reflection.MethodBase.MethodHandle" /> on the returned <see cref="T:System.Reflection.MethodInfo" />. </exception>
		// Token: 0x1700054F RID: 1359
		// (get) Token: 0x06002575 RID: 9589 RVA: 0x00092741 File Offset: 0x00090941
		public override RuntimeMethodHandle MethodHandle
		{
			get
			{
				throw this.NotSupported();
			}
		}

		/// <summary>Gets the return type of the method represented by this <see cref="T:System.Reflection.Emit.MethodBuilder" />.</summary>
		/// <returns>The return type of the method.</returns>
		// Token: 0x17000550 RID: 1360
		// (get) Token: 0x06002576 RID: 9590 RVA: 0x00092749 File Offset: 0x00090949
		public override Type ReturnType
		{
			get
			{
				return this.rtype;
			}
		}

		/// <summary>Retrieves the class that was used in reflection to obtain this object.</summary>
		/// <returns>Read-only. The type used to obtain this method.</returns>
		// Token: 0x17000551 RID: 1361
		// (get) Token: 0x06002577 RID: 9591 RVA: 0x00092739 File Offset: 0x00090939
		public override Type ReflectedType
		{
			get
			{
				return this.type;
			}
		}

		/// <summary>Returns the type that declares this method.</summary>
		/// <returns>Read-only. The type that declares this method.</returns>
		// Token: 0x17000552 RID: 1362
		// (get) Token: 0x06002578 RID: 9592 RVA: 0x00092739 File Offset: 0x00090939
		public override Type DeclaringType
		{
			get
			{
				return this.type;
			}
		}

		/// <summary>Retrieves the name of this method.</summary>
		/// <returns>Read-only. Retrieves a string containing the simple name of this method.</returns>
		// Token: 0x17000553 RID: 1363
		// (get) Token: 0x06002579 RID: 9593 RVA: 0x00092751 File Offset: 0x00090951
		public override string Name
		{
			get
			{
				return this.name;
			}
		}

		/// <summary>Retrieves the attributes for this method.</summary>
		/// <returns>Read-only. Retrieves the <see langword="MethodAttributes" /> for this method.</returns>
		// Token: 0x17000554 RID: 1364
		// (get) Token: 0x0600257A RID: 9594 RVA: 0x00092759 File Offset: 0x00090959
		public override MethodAttributes Attributes
		{
			get
			{
				return this.attrs;
			}
		}

		/// <summary>Returns the calling convention of the method.</summary>
		/// <returns>Read-only. The calling convention of the method.</returns>
		// Token: 0x17000555 RID: 1365
		// (get) Token: 0x0600257B RID: 9595 RVA: 0x00092761 File Offset: 0x00090961
		public override CallingConventions CallingConvention
		{
			get
			{
				return this.call_conv;
			}
		}

		/// <summary>Returns the <see langword="MethodToken" /> that represents the token for this method.</summary>
		/// <returns>Returns the <see langword="MethodToken" /> of this method.</returns>
		// Token: 0x0600257C RID: 9596 RVA: 0x00092769 File Offset: 0x00090969
		public MethodToken GetToken()
		{
			return new MethodToken(100663296 | this.table_idx);
		}

		/// <summary>Return the base implementation for a method.</summary>
		/// <returns>The base implementation of this method.</returns>
		// Token: 0x0600257D RID: 9597 RVA: 0x0000245A File Offset: 0x0000065A
		public override MethodInfo GetBaseDefinition()
		{
			return this;
		}

		/// <summary>Returns the implementation flags for the method.</summary>
		/// <returns>Returns the implementation flags for the method.</returns>
		// Token: 0x0600257E RID: 9598 RVA: 0x0009277C File Offset: 0x0009097C
		public override MethodImplAttributes GetMethodImplementationFlags()
		{
			return this.iattrs;
		}

		/// <summary>Returns the parameters of this method.</summary>
		/// <returns>An array of <see langword="ParameterInfo" /> objects that represent the parameters of the method.</returns>
		/// <exception cref="T:System.NotSupportedException">This method is not currently supported. Retrieve the method using <see cref="M:System.Type.GetMethod(System.String,System.Reflection.BindingFlags,System.Reflection.Binder,System.Reflection.CallingConventions,System.Type[],System.Reflection.ParameterModifier[])" /> and call <see langword="GetParameters" /> on the returned <see cref="T:System.Reflection.MethodInfo" />. </exception>
		// Token: 0x0600257F RID: 9599 RVA: 0x00092784 File Offset: 0x00090984
		public override ParameterInfo[] GetParameters()
		{
			if (!this.type.is_created)
			{
				throw this.NotSupported();
			}
			return this.GetParametersInternal();
		}

		// Token: 0x06002580 RID: 9600 RVA: 0x000927A0 File Offset: 0x000909A0
		internal override ParameterInfo[] GetParametersInternal()
		{
			if (this.parameters == null)
			{
				return null;
			}
			ParameterInfo[] array = new ParameterInfo[this.parameters.Length];
			for (int i = 0; i < this.parameters.Length; i++)
			{
				ParameterInfo[] array2 = array;
				int num = i;
				ParameterBuilder[] array3 = this.pinfo;
				array2[num] = RuntimeParameterInfo.New((array3 != null) ? array3[i + 1] : null, this.parameters[i], this, i + 1);
			}
			return array;
		}

		// Token: 0x06002581 RID: 9601 RVA: 0x000927FE File Offset: 0x000909FE
		internal override int GetParametersCount()
		{
			if (this.parameters == null)
			{
				return 0;
			}
			return this.parameters.Length;
		}

		// Token: 0x06002582 RID: 9602 RVA: 0x00092812 File Offset: 0x00090A12
		internal MethodBase RuntimeResolve()
		{
			return this.type.RuntimeResolve().GetMethod(this);
		}

		/// <summary>Returns a reference to the module that contains this method.</summary>
		/// <returns>Returns a reference to the module that contains this method.</returns>
		// Token: 0x06002583 RID: 9603 RVA: 0x00092825 File Offset: 0x00090A25
		public Module GetModule()
		{
			return this.type.Module;
		}

		/// <summary>Dynamically invokes the method reflected by this instance on the given object, passing along the specified parameters, and under the constraints of the given binder.</summary>
		/// <param name="obj">The object on which to invoke the specified method. If the method is static, this parameter is ignored. </param>
		/// <param name="invokeAttr">This must be a bit flag from <see cref="T:System.Reflection.BindingFlags" /> : <see langword="InvokeMethod" />, <see langword="NonPublic" />, and so on. </param>
		/// <param name="binder">An object that enables the binding, coercion of argument types, invocation of members, and retrieval of MemberInfo objects via reflection. If binder is <see langword="null" />, the default binder is used. For more details, see <see cref="T:System.Reflection.Binder" />. </param>
		/// <param name="parameters">An argument list. This is an array of arguments with the same number, order, and type as the parameters of the method to be invoked. If there are no parameters this should be <see langword="null" />. </param>
		/// <param name="culture">An instance of <see cref="T:System.Globalization.CultureInfo" /> used to govern the coercion of types. If this is null, the <see cref="T:System.Globalization.CultureInfo" /> for the current thread is used. (Note that this is necessary to, for example, convert a <see cref="T:System.String" /> that represents 1000 to a <see cref="T:System.Double" /> value, since 1000 is represented differently by different cultures.) </param>
		/// <returns>Returns an object containing the return value of the invoked method.</returns>
		/// <exception cref="T:System.NotSupportedException">This method is not currently supported. Retrieve the method using <see cref="M:System.Type.GetMethod(System.String,System.Reflection.BindingFlags,System.Reflection.Binder,System.Reflection.CallingConventions,System.Type[],System.Reflection.ParameterModifier[])" /> and call <see cref="M:System.Type.InvokeMember(System.String,System.Reflection.BindingFlags,System.Reflection.Binder,System.Object,System.Object[],System.Reflection.ParameterModifier[],System.Globalization.CultureInfo,System.String[])" /> on the returned <see cref="T:System.Reflection.MethodInfo" />. </exception>
		// Token: 0x06002584 RID: 9604 RVA: 0x00092741 File Offset: 0x00090941
		public override object Invoke(object obj, BindingFlags invokeAttr, Binder binder, object[] parameters, CultureInfo culture)
		{
			throw this.NotSupported();
		}

		/// <summary>Checks if the specified custom attribute type is defined.</summary>
		/// <param name="attributeType">The custom attribute type. </param>
		/// <param name="inherit">Specifies whether to search this member's inheritance chain to find the custom attributes. </param>
		/// <returns>
		///     <see langword="true" /> if the specified custom attribute type is defined; otherwise, <see langword="false" />.</returns>
		/// <exception cref="T:System.NotSupportedException">This method is not currently supported. Retrieve the method using <see cref="M:System.Type.GetMethod(System.String,System.Reflection.BindingFlags,System.Reflection.Binder,System.Reflection.CallingConventions,System.Type[],System.Reflection.ParameterModifier[])" /> and call <see cref="M:System.Reflection.MemberInfo.IsDefined(System.Type,System.Boolean)" /> on the returned <see cref="T:System.Reflection.MethodInfo" />. </exception>
		// Token: 0x06002585 RID: 9605 RVA: 0x00092741 File Offset: 0x00090941
		public override bool IsDefined(Type attributeType, bool inherit)
		{
			throw this.NotSupported();
		}

		/// <summary>Returns all the custom attributes defined for this method.</summary>
		/// <param name="inherit">Specifies whether to search this member's inheritance chain to find the custom attributes. </param>
		/// <returns>Returns an array of objects representing all the custom attributes of this method.</returns>
		/// <exception cref="T:System.NotSupportedException">This method is not currently supported. Retrieve the method using <see cref="M:System.Type.GetMethod(System.String,System.Reflection.BindingFlags,System.Reflection.Binder,System.Reflection.CallingConventions,System.Type[],System.Reflection.ParameterModifier[])" /> and call <see cref="M:System.Reflection.MemberInfo.GetCustomAttributes(System.Boolean)" /> on the returned <see cref="T:System.Reflection.MethodInfo" />. </exception>
		// Token: 0x06002586 RID: 9606 RVA: 0x00092832 File Offset: 0x00090A32
		public override object[] GetCustomAttributes(bool inherit)
		{
			if (this.type.is_created)
			{
				return MonoCustomAttrs.GetCustomAttributes(this, inherit);
			}
			throw this.NotSupported();
		}

		/// <summary>Returns the custom attributes identified by the given type.</summary>
		/// <param name="attributeType">The custom attribute type. </param>
		/// <param name="inherit">Specifies whether to search this member's inheritance chain to find the custom attributes. </param>
		/// <returns>Returns an array of objects representing the attributes of this method that are of type <paramref name="attributeType" />.</returns>
		/// <exception cref="T:System.NotSupportedException">This method is not currently supported. Retrieve the method using <see cref="M:System.Type.GetMethod(System.String,System.Reflection.BindingFlags,System.Reflection.Binder,System.Reflection.CallingConventions,System.Type[],System.Reflection.ParameterModifier[])" /> and call <see cref="M:System.Reflection.MemberInfo.GetCustomAttributes(System.Boolean)" /> on the returned <see cref="T:System.Reflection.MethodInfo" />. </exception>
		// Token: 0x06002587 RID: 9607 RVA: 0x0009284F File Offset: 0x00090A4F
		public override object[] GetCustomAttributes(Type attributeType, bool inherit)
		{
			if (this.type.is_created)
			{
				return MonoCustomAttrs.GetCustomAttributes(this, attributeType, inherit);
			}
			throw this.NotSupported();
		}

		/// <summary>Returns an <see langword="ILGenerator" /> for this method with a default Microsoft intermediate language (MSIL) stream size of 64 bytes.</summary>
		/// <returns>Returns an <see langword="ILGenerator" /> object for this method.</returns>
		/// <exception cref="T:System.InvalidOperationException">The method should not have a body because of its <see cref="T:System.Reflection.MethodAttributes" /> or <see cref="T:System.Reflection.MethodImplAttributes" /> flags, for example because it has the <see cref="F:System.Reflection.MethodAttributes.PinvokeImpl" /> flag. -or-The method is a generic method, but not a generic method definition. That is, the <see cref="P:System.Reflection.Emit.MethodBuilder.IsGenericMethod" /> property is <see langword="true" />, but the <see cref="P:System.Reflection.Emit.MethodBuilder.IsGenericMethodDefinition" /> property is <see langword="false" />. </exception>
		// Token: 0x06002588 RID: 9608 RVA: 0x0009286D File Offset: 0x00090A6D
		public ILGenerator GetILGenerator()
		{
			return this.GetILGenerator(64);
		}

		/// <summary>Returns an <see langword="ILGenerator" /> for this method with the specified Microsoft intermediate language (MSIL) stream size.</summary>
		/// <param name="size">The size of the MSIL stream, in bytes. </param>
		/// <returns>Returns an <see langword="ILGenerator" /> object for this method.</returns>
		/// <exception cref="T:System.InvalidOperationException">The method should not have a body because of its <see cref="T:System.Reflection.MethodAttributes" /> or <see cref="T:System.Reflection.MethodImplAttributes" /> flags, for example because it has the <see cref="F:System.Reflection.MethodAttributes.PinvokeImpl" /> flag. -or-The method is a generic method, but not a generic method definition. That is, the <see cref="P:System.Reflection.Emit.MethodBuilder.IsGenericMethod" /> property is <see langword="true" />, but the <see cref="P:System.Reflection.Emit.MethodBuilder.IsGenericMethodDefinition" /> property is <see langword="false" />.   </exception>
		// Token: 0x06002589 RID: 9609 RVA: 0x00092878 File Offset: 0x00090A78
		public ILGenerator GetILGenerator(int size)
		{
			if ((this.iattrs & MethodImplAttributes.CodeTypeMask) != MethodImplAttributes.IL || (this.iattrs & MethodImplAttributes.ManagedMask) != MethodImplAttributes.IL)
			{
				throw new InvalidOperationException("Method body should not exist.");
			}
			if (this.ilgen != null)
			{
				return this.ilgen;
			}
			this.ilgen = new ILGenerator(this.type.Module, ((ModuleBuilder)this.type.Module).GetTokenGenerator(), size);
			return this.ilgen;
		}

		/// <summary>Sets the parameter attributes and the name of a parameter of this method, or of the return value of this method. Returns a ParameterBuilder that can be used to apply custom attributes.</summary>
		/// <param name="position">The position of the parameter in the parameter list. Parameters are indexed beginning with the number 1 for the first parameter; the number 0 represents the return value of the method. </param>
		/// <param name="attributes">The parameter attributes of the parameter. </param>
		/// <param name="strParamName">The name of the parameter. The name can be the null string. </param>
		/// <returns>Returns a <see langword="ParameterBuilder" /> object that represents a parameter of this method or the return value of this method.</returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException">The method has no parameters.-or- 
		///         <paramref name="position" /> is less than zero.-or- 
		///         <paramref name="position" /> is greater than the number of the method's parameters. </exception>
		/// <exception cref="T:System.InvalidOperationException">The containing type was previously created using <see cref="M:System.Reflection.Emit.TypeBuilder.CreateType" />.-or-For the current method, the <see cref="P:System.Reflection.Emit.MethodBuilder.IsGenericMethod" /> property is <see langword="true" />, but the <see cref="P:System.Reflection.Emit.MethodBuilder.IsGenericMethodDefinition" /> property is <see langword="false" />. </exception>
		// Token: 0x0600258A RID: 9610 RVA: 0x000928E8 File Offset: 0x00090AE8
		public ParameterBuilder DefineParameter(int position, ParameterAttributes attributes, string strParamName)
		{
			this.RejectIfCreated();
			if (position < 0 || this.parameters == null || position > this.parameters.Length)
			{
				throw new ArgumentOutOfRangeException("position");
			}
			ParameterBuilder parameterBuilder = new ParameterBuilder(this, position, attributes, strParamName);
			if (this.pinfo == null)
			{
				this.pinfo = new ParameterBuilder[this.parameters.Length + 1];
			}
			this.pinfo[position] = parameterBuilder;
			return parameterBuilder;
		}

		// Token: 0x0600258B RID: 9611 RVA: 0x00092950 File Offset: 0x00090B50
		internal void check_override()
		{
			if (this.override_methods != null)
			{
				foreach (MethodInfo methodInfo in this.override_methods)
				{
					if (methodInfo.IsVirtual && !base.IsVirtual)
					{
						throw new TypeLoadException(string.Format("Method '{0}' override '{1}' but it is not virtual", this.name, methodInfo));
					}
				}
			}
		}

		// Token: 0x0600258C RID: 9612 RVA: 0x000929A8 File Offset: 0x00090BA8
		internal void fixup()
		{
			if ((this.attrs & (MethodAttributes.Abstract | MethodAttributes.PinvokeImpl)) == MethodAttributes.PrivateScope && (this.iattrs & (MethodImplAttributes)4099) == MethodImplAttributes.IL && (this.ilgen == null || this.ilgen.ILOffset == 0) && (this.code == null || this.code.Length == 0))
			{
				throw new InvalidOperationException(string.Format("Method '{0}.{1}' does not have a method body.", this.DeclaringType.FullName, this.Name));
			}
			if (this.ilgen != null)
			{
				this.ilgen.label_fixup(this);
			}
		}

		// Token: 0x0600258D RID: 9613 RVA: 0x00092A2C File Offset: 0x00090C2C
		internal void ResolveUserTypes()
		{
			this.rtype = TypeBuilder.ResolveUserType(this.rtype);
			TypeBuilder.ResolveUserTypes(this.parameters);
			TypeBuilder.ResolveUserTypes(this.returnModReq);
			TypeBuilder.ResolveUserTypes(this.returnModOpt);
			if (this.paramModReq != null)
			{
				Type[][] array = this.paramModReq;
				for (int i = 0; i < array.Length; i++)
				{
					TypeBuilder.ResolveUserTypes(array[i]);
				}
			}
			if (this.paramModOpt != null)
			{
				Type[][] array = this.paramModOpt;
				for (int i = 0; i < array.Length; i++)
				{
					TypeBuilder.ResolveUserTypes(array[i]);
				}
			}
		}

		/// <summary>Returns this <see langword="MethodBuilder" /> instance as a string.</summary>
		/// <returns>Returns a string containing the name, attributes, method signature, exceptions, and local signature of this method followed by the current Microsoft intermediate language (MSIL) stream.</returns>
		// Token: 0x0600258E RID: 9614 RVA: 0x00092AB5 File Offset: 0x00090CB5
		public override string ToString()
		{
			return string.Concat(new string[]
			{
				"MethodBuilder [",
				this.type.Name,
				"::",
				this.name,
				"]"
			});
		}

		/// <summary>Determines whether the given object is equal to this instance.</summary>
		/// <param name="obj">The object to compare with this <see langword="MethodBuilder" /> instance. </param>
		/// <returns>
		///     <see langword="true" /> if <paramref name="obj" /> is an instance of <see langword="MethodBuilder" /> and is equal to this object; otherwise, <see langword="false" />.</returns>
		// Token: 0x0600258F RID: 9615 RVA: 0x00092AF1 File Offset: 0x00090CF1
		public override bool Equals(object obj)
		{
			return base.Equals(obj);
		}

		/// <summary>Gets the hash code for this method.</summary>
		/// <returns>The hash code for this method.</returns>
		// Token: 0x06002590 RID: 9616 RVA: 0x00092AFA File Offset: 0x00090CFA
		public override int GetHashCode()
		{
			return this.name.GetHashCode();
		}

		// Token: 0x06002591 RID: 9617 RVA: 0x00092B07 File Offset: 0x00090D07
		internal override int get_next_table_index(object obj, int table, int count)
		{
			return this.type.get_next_table_index(obj, table, count);
		}

		// Token: 0x06002592 RID: 9618 RVA: 0x00092B17 File Offset: 0x00090D17
		private void RejectIfCreated()
		{
			if (this.type.is_created)
			{
				throw new InvalidOperationException("Type definition of the method is complete.");
			}
		}

		// Token: 0x06002593 RID: 9619 RVA: 0x0008F51E File Offset: 0x0008D71E
		private Exception NotSupported()
		{
			return new NotSupportedException("The invoked member is not supported in a dynamic module.");
		}

		/// <summary>Returns a generic method constructed from the current generic method definition using the specified generic type arguments.</summary>
		/// <param name="typeArguments">An array of <see cref="T:System.Type" /> objects that represent the type arguments for the generic method.</param>
		/// <returns>A <see cref="T:System.Reflection.MethodInfo" /> representing the generic method constructed from the current generic method definition using the specified generic type arguments.</returns>
		// Token: 0x06002594 RID: 9620 RVA: 0x00092B34 File Offset: 0x00090D34
		public override MethodInfo MakeGenericMethod(params Type[] typeArguments)
		{
			if (!this.IsGenericMethodDefinition)
			{
				throw new InvalidOperationException("Method is not a generic method definition");
			}
			if (typeArguments == null)
			{
				throw new ArgumentNullException("typeArguments");
			}
			if (this.generic_params.Length != typeArguments.Length)
			{
				throw new ArgumentException("Incorrect length", "typeArguments");
			}
			for (int i = 0; i < typeArguments.Length; i++)
			{
				if (typeArguments[i] == null)
				{
					throw new ArgumentNullException("typeArguments");
				}
			}
			return new MethodOnTypeBuilderInst(this, typeArguments);
		}

		/// <summary>Gets a value indicating whether the current <see cref="T:System.Reflection.Emit.MethodBuilder" /> object represents the definition of a generic method.</summary>
		/// <returns>
		///     <see langword="true" /> if the current <see cref="T:System.Reflection.Emit.MethodBuilder" /> object represents the definition of a generic method; otherwise, <see langword="false" />.</returns>
		// Token: 0x17000556 RID: 1366
		// (get) Token: 0x06002595 RID: 9621 RVA: 0x00092BAC File Offset: 0x00090DAC
		public override bool IsGenericMethodDefinition
		{
			get
			{
				return this.generic_params != null;
			}
		}

		/// <summary>Gets a value indicating whether the method is a generic method.</summary>
		/// <returns>
		///     <see langword="true" /> if the method is generic; otherwise, <see langword="false" />.</returns>
		// Token: 0x17000557 RID: 1367
		// (get) Token: 0x06002596 RID: 9622 RVA: 0x00092BAC File Offset: 0x00090DAC
		public override bool IsGenericMethod
		{
			get
			{
				return this.generic_params != null;
			}
		}

		/// <summary>Returns this method.</summary>
		/// <returns>The current instance of <see cref="T:System.Reflection.Emit.MethodBuilder" />. </returns>
		/// <exception cref="T:System.InvalidOperationException">The current method is not generic. That is, the <see cref="P:System.Reflection.Emit.MethodBuilder.IsGenericMethod" /> property returns <see langword="false" />.</exception>
		// Token: 0x06002597 RID: 9623 RVA: 0x00092BB7 File Offset: 0x00090DB7
		public override MethodInfo GetGenericMethodDefinition()
		{
			if (!this.IsGenericMethodDefinition)
			{
				throw new InvalidOperationException();
			}
			return this;
		}

		/// <summary>Returns an array of <see cref="T:System.Reflection.Emit.GenericTypeParameterBuilder" /> objects that represent the type parameters of the method, if it is generic.</summary>
		/// <returns>An array of <see cref="T:System.Reflection.Emit.GenericTypeParameterBuilder" /> objects representing the type parameters, if the method is generic, or <see langword="null" /> if the method is not generic. </returns>
		// Token: 0x06002598 RID: 9624 RVA: 0x00092BC8 File Offset: 0x00090DC8
		public override Type[] GetGenericArguments()
		{
			if (this.generic_params == null)
			{
				return null;
			}
			Type[] array = new Type[this.generic_params.Length];
			for (int i = 0; i < this.generic_params.Length; i++)
			{
				array[i] = this.generic_params[i];
			}
			return array;
		}

		/// <summary>Sets the return type of the method.</summary>
		/// <param name="returnType">A <see cref="T:System.Type" /> object that represents the return type of the method.</param>
		/// <exception cref="T:System.InvalidOperationException">The current method is generic, but is not a generic method definition. That is, the <see cref="P:System.Reflection.Emit.MethodBuilder.IsGenericMethod" /> property is <see langword="true" />, but the <see cref="P:System.Reflection.Emit.MethodBuilder.IsGenericMethodDefinition" /> property is <see langword="false" />.</exception>
		// Token: 0x06002599 RID: 9625 RVA: 0x00092C0C File Offset: 0x00090E0C
		public void SetReturnType(Type returnType)
		{
			this.rtype = returnType;
		}

		/// <summary>Sets the number and types of parameters for a method. </summary>
		/// <param name="parameterTypes">An array of <see cref="T:System.Type" /> objects representing the parameter types.</param>
		/// <exception cref="T:System.InvalidOperationException">The current method is generic, but is not a generic method definition. That is, the <see cref="P:System.Reflection.Emit.MethodBuilder.IsGenericMethod" /> property is <see langword="true" />, but the <see cref="P:System.Reflection.Emit.MethodBuilder.IsGenericMethodDefinition" /> property is <see langword="false" />.</exception>
		// Token: 0x0600259A RID: 9626 RVA: 0x00092C18 File Offset: 0x00090E18
		public void SetParameters(params Type[] parameterTypes)
		{
			if (parameterTypes != null)
			{
				for (int i = 0; i < parameterTypes.Length; i++)
				{
					if (parameterTypes[i] == null)
					{
						throw new ArgumentException("Elements of the parameterTypes array cannot be null", "parameterTypes");
					}
				}
				this.parameters = new Type[parameterTypes.Length];
				Array.Copy(parameterTypes, this.parameters, parameterTypes.Length);
			}
		}

		/// <summary>Gets the module in which the current method is being defined.</summary>
		/// <returns>The <see cref="T:System.Reflection.Module" /> in which the member represented by the current <see cref="T:System.Reflection.MemberInfo" /> is being defined.</returns>
		// Token: 0x17000558 RID: 1368
		// (get) Token: 0x0600259B RID: 9627 RVA: 0x00092C6E File Offset: 0x00090E6E
		public override Module Module
		{
			get
			{
				return this.GetModule();
			}
		}

		/// <summary>Gets a <see cref="T:System.Reflection.ParameterInfo" /> object that contains information about the return type of the method, such as whether the return type has custom modifiers. </summary>
		/// <returns>A <see cref="T:System.Reflection.ParameterInfo" /> object that contains information about the return type.</returns>
		/// <exception cref="T:System.InvalidOperationException">The declaring type has not been created.</exception>
		// Token: 0x17000559 RID: 1369
		// (get) Token: 0x0600259C RID: 9628 RVA: 0x00092C76 File Offset: 0x00090E76
		public override ParameterInfo ReturnParameter
		{
			get
			{
				return base.ReturnParameter;
			}
		}

		// Token: 0x0400125E RID: 4702
		private RuntimeMethodHandle mhandle;

		// Token: 0x0400125F RID: 4703
		private Type rtype;

		// Token: 0x04001260 RID: 4704
		internal Type[] parameters;

		// Token: 0x04001261 RID: 4705
		private MethodAttributes attrs;

		// Token: 0x04001262 RID: 4706
		private MethodImplAttributes iattrs;

		// Token: 0x04001263 RID: 4707
		private string name;

		// Token: 0x04001264 RID: 4708
		private int table_idx;

		// Token: 0x04001265 RID: 4709
		private byte[] code;

		// Token: 0x04001266 RID: 4710
		private ILGenerator ilgen;

		// Token: 0x04001267 RID: 4711
		private TypeBuilder type;

		// Token: 0x04001268 RID: 4712
		internal ParameterBuilder[] pinfo;

		// Token: 0x04001269 RID: 4713
		private CustomAttributeBuilder[] cattrs;

		// Token: 0x0400126A RID: 4714
		private MethodInfo[] override_methods;

		// Token: 0x0400126B RID: 4715
		private string pi_dll;

		// Token: 0x0400126C RID: 4716
		private string pi_entry;

		// Token: 0x0400126D RID: 4717
		private CharSet charset;

		// Token: 0x0400126E RID: 4718
		private uint extra_flags;

		// Token: 0x0400126F RID: 4719
		private CallingConvention native_cc;

		// Token: 0x04001270 RID: 4720
		private CallingConventions call_conv;

		// Token: 0x04001271 RID: 4721
		private bool init_locals = true;

		// Token: 0x04001272 RID: 4722
		private IntPtr generic_container;

		// Token: 0x04001273 RID: 4723
		internal GenericTypeParameterBuilder[] generic_params;

		// Token: 0x04001274 RID: 4724
		private Type[] returnModReq;

		// Token: 0x04001275 RID: 4725
		private Type[] returnModOpt;

		// Token: 0x04001276 RID: 4726
		private Type[][] paramModReq;

		// Token: 0x04001277 RID: 4727
		private Type[][] paramModOpt;

		// Token: 0x04001278 RID: 4728
		private RefEmitPermissionSet[] permissions;
	}
}
