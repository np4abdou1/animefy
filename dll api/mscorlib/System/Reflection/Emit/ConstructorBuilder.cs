using System;
using System.Globalization;
using System.Runtime.InteropServices;

namespace System.Reflection.Emit
{
	/// <summary>Defines and represents a constructor of a dynamic class.</summary>
	// Token: 0x020004F1 RID: 1265
	[StructLayout(0)]
	public sealed class ConstructorBuilder : ConstructorInfo
	{
		// Token: 0x06002461 RID: 9313 RVA: 0x0008F870 File Offset: 0x0008DA70
		internal ConstructorBuilder(TypeBuilder tb, MethodAttributes attributes, CallingConventions callingConvention, Type[] parameterTypes, Type[][] paramModReq, Type[][] paramModOpt)
		{
			this.attrs = (attributes | MethodAttributes.SpecialName | MethodAttributes.RTSpecialName);
			this.call_conv = callingConvention;
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
			this.paramModReq = paramModReq;
			this.paramModOpt = paramModOpt;
			this.table_idx = this.get_next_table_index(this, 6, 1);
			((ModuleBuilder)tb.Module).RegisterToken(this, this.GetToken().Token);
		}

		/// <summary>Gets a <see cref="T:System.Reflection.CallingConventions" /> value that depends on whether the declaring type is generic.</summary>
		/// <returns>
		///     <see cref="F:System.Reflection.CallingConventions.HasThis" /> if the declaring type is generic; otherwise, <see cref="F:System.Reflection.CallingConventions.Standard" />. </returns>
		// Token: 0x1700050B RID: 1291
		// (get) Token: 0x06002462 RID: 9314 RVA: 0x0008F938 File Offset: 0x0008DB38
		public override CallingConventions CallingConvention
		{
			get
			{
				return this.call_conv;
			}
		}

		// Token: 0x1700050C RID: 1292
		// (get) Token: 0x06002463 RID: 9315 RVA: 0x0008F940 File Offset: 0x0008DB40
		internal TypeBuilder TypeBuilder
		{
			get
			{
				return this.type;
			}
		}

		/// <summary>Returns the method implementation flags for this constructor.</summary>
		/// <returns>The method implementation flags for this constructor.</returns>
		// Token: 0x06002464 RID: 9316 RVA: 0x0008F948 File Offset: 0x0008DB48
		public override MethodImplAttributes GetMethodImplementationFlags()
		{
			return this.iattrs;
		}

		/// <summary>Returns the parameters of this constructor.</summary>
		/// <returns>Returns an array of <see cref="T:System.Reflection.ParameterInfo" /> objects that represent the parameters of this constructor.</returns>
		/// <exception cref="T:System.InvalidOperationException">
		///         <see cref="M:System.Reflection.Emit.TypeBuilder.CreateType" /> has not been called on this constructor's type, in the .NET Framework versions 1.0 and 1.1. </exception>
		/// <exception cref="T:System.NotSupportedException">
		///         <see cref="M:System.Reflection.Emit.TypeBuilder.CreateType" /> has not been called on this constructor's type, in the .NET Framework version 2.0. </exception>
		// Token: 0x06002465 RID: 9317 RVA: 0x0008F950 File Offset: 0x0008DB50
		public override ParameterInfo[] GetParameters()
		{
			if (!this.type.is_created)
			{
				throw this.not_created();
			}
			return this.GetParametersInternal();
		}

		// Token: 0x06002466 RID: 9318 RVA: 0x0008F96C File Offset: 0x0008DB6C
		internal override ParameterInfo[] GetParametersInternal()
		{
			if (this.parameters == null)
			{
				return EmptyArray<ParameterInfo>.Value;
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

		// Token: 0x06002467 RID: 9319 RVA: 0x0008F9CE File Offset: 0x0008DBCE
		internal override int GetParametersCount()
		{
			if (this.parameters == null)
			{
				return 0;
			}
			return this.parameters.Length;
		}

		// Token: 0x06002468 RID: 9320 RVA: 0x0008F9E2 File Offset: 0x0008DBE2
		internal MethodBase RuntimeResolve()
		{
			return this.type.RuntimeResolve().GetConstructor(this);
		}

		/// <summary>Dynamically invokes the constructor reflected by this instance with the specified arguments, under the constraints of the specified <see langword="Binder" />.</summary>
		/// <param name="obj">The object that needs to be reinitialized. </param>
		/// <param name="invokeAttr">One of the <see langword="BindingFlags" /> values that specifies the type of binding that is desired. </param>
		/// <param name="binder">A <see langword="Binder" /> that defines a set of properties and enables the binding, coercion of argument types, and invocation of members using reflection. If <paramref name="binder" /> is <see langword="null" />, then Binder.DefaultBinding is used. </param>
		/// <param name="parameters">An argument list. This is an array of arguments with the same number, order, and type as the parameters of the constructor to be invoked. If there are no parameters, this should be a null reference (<see langword="Nothing" /> in Visual Basic). </param>
		/// <param name="culture">A <see cref="T:System.Globalization.CultureInfo" /> used to govern the coercion of types. If this is null, the <see cref="T:System.Globalization.CultureInfo" /> for the current thread is used. </param>
		/// <returns>An instance of the class associated with the constructor.</returns>
		/// <exception cref="T:System.NotSupportedException">This method is not currently supported. You can retrieve the constructor using <see cref="M:System.Type.GetConstructor(System.Reflection.BindingFlags,System.Reflection.Binder,System.Reflection.CallingConventions,System.Type[],System.Reflection.ParameterModifier[])" /> and call <see cref="M:System.Reflection.ConstructorInfo.Invoke(System.Reflection.BindingFlags,System.Reflection.Binder,System.Object[],System.Globalization.CultureInfo)" /> on the returned <see cref="T:System.Reflection.ConstructorInfo" />. </exception>
		// Token: 0x06002469 RID: 9321 RVA: 0x0008F9F5 File Offset: 0x0008DBF5
		public override object Invoke(object obj, BindingFlags invokeAttr, Binder binder, object[] parameters, CultureInfo culture)
		{
			throw this.not_supported();
		}

		/// <summary>Invokes the constructor dynamically reflected by this instance on the given object, passing along the specified parameters, and under the constraints of the given binder.</summary>
		/// <param name="invokeAttr">This must be a bit flag from <see cref="T:System.Reflection.BindingFlags" />, such as InvokeMethod, NonPublic, and so on. </param>
		/// <param name="binder">An object that enables the binding, coercion of argument types, invocation of members, and retrieval of <see langword="MemberInfo" /> objects using reflection. If binder is <see langword="null" />, the default binder is used. See <see cref="T:System.Reflection.Binder" />. </param>
		/// <param name="parameters">An argument list. This is an array of arguments with the same number, order, and type as the parameters of the constructor to be invoked. If there are no parameters this should be <see langword="null" />. </param>
		/// <param name="culture">An instance of <see cref="T:System.Globalization.CultureInfo" /> used to govern the coercion of types. If this is null, the <see cref="T:System.Globalization.CultureInfo" /> for the current thread is used. (For example, this is necessary to convert a <see cref="T:System.String" /> that represents 1000 to a <see cref="T:System.Double" /> value, since 1000 is represented differently by different cultures.) </param>
		/// <returns>Returns an <see cref="T:System.Object" /> that is the return value of the invoked constructor.</returns>
		/// <exception cref="T:System.NotSupportedException">This method is not currently supported. You can retrieve the constructor using <see cref="M:System.Type.GetConstructor(System.Reflection.BindingFlags,System.Reflection.Binder,System.Reflection.CallingConventions,System.Type[],System.Reflection.ParameterModifier[])" /> and call <see cref="M:System.Reflection.ConstructorInfo.Invoke(System.Reflection.BindingFlags,System.Reflection.Binder,System.Object[],System.Globalization.CultureInfo)" /> on the returned <see cref="T:System.Reflection.ConstructorInfo" />. </exception>
		// Token: 0x0600246A RID: 9322 RVA: 0x0008F9F5 File Offset: 0x0008DBF5
		public override object Invoke(BindingFlags invokeAttr, Binder binder, object[] parameters, CultureInfo culture)
		{
			throw this.not_supported();
		}

		/// <summary>Retrieves the internal handle for the method. Use this handle to access the underlying metadata handle.</summary>
		/// <returns>Returns the internal handle for the method. Use this handle to access the underlying metadata handle.</returns>
		/// <exception cref="T:System.NotSupportedException">This property is not supported on this class. </exception>
		// Token: 0x1700050D RID: 1293
		// (get) Token: 0x0600246B RID: 9323 RVA: 0x0008F9F5 File Offset: 0x0008DBF5
		public override RuntimeMethodHandle MethodHandle
		{
			get
			{
				throw this.not_supported();
			}
		}

		/// <summary>Retrieves the attributes for this constructor.</summary>
		/// <returns>Returns the attributes for this constructor.</returns>
		// Token: 0x1700050E RID: 1294
		// (get) Token: 0x0600246C RID: 9324 RVA: 0x0008F9FD File Offset: 0x0008DBFD
		public override MethodAttributes Attributes
		{
			get
			{
				return this.attrs;
			}
		}

		/// <summary>Holds a reference to the <see cref="T:System.Type" /> object from which this object was obtained.</summary>
		/// <returns>Returns the <see langword="Type" /> object from which this object was obtained.</returns>
		// Token: 0x1700050F RID: 1295
		// (get) Token: 0x0600246D RID: 9325 RVA: 0x0008F940 File Offset: 0x0008DB40
		public override Type ReflectedType
		{
			get
			{
				return this.type;
			}
		}

		/// <summary>Retrieves a reference to the <see cref="T:System.Type" /> object for the type that declares this member.</summary>
		/// <returns>Returns the <see cref="T:System.Type" /> object for the type that declares this member.</returns>
		// Token: 0x17000510 RID: 1296
		// (get) Token: 0x0600246E RID: 9326 RVA: 0x0008F940 File Offset: 0x0008DB40
		public override Type DeclaringType
		{
			get
			{
				return this.type;
			}
		}

		/// <summary>Retrieves the name of this constructor.</summary>
		/// <returns>Returns the name of this constructor.</returns>
		// Token: 0x17000511 RID: 1297
		// (get) Token: 0x0600246F RID: 9327 RVA: 0x0008FA05 File Offset: 0x0008DC05
		public override string Name
		{
			get
			{
				if ((this.attrs & MethodAttributes.Static) == MethodAttributes.PrivateScope)
				{
					return ConstructorInfo.ConstructorName;
				}
				return ConstructorInfo.TypeConstructorName;
			}
		}

		/// <summary>Checks if the specified custom attribute type is defined.</summary>
		/// <param name="attributeType">A custom attribute type. </param>
		/// <param name="inherit">Controls inheritance of custom attributes from base classes. This parameter is ignored. </param>
		/// <returns>
		///     <see langword="true" /> if the specified custom attribute type is defined; otherwise, <see langword="false" />.</returns>
		/// <exception cref="T:System.NotSupportedException">This method is not currently supported. You can retrieve the constructor using <see cref="M:System.Type.GetConstructor(System.Reflection.BindingFlags,System.Reflection.Binder,System.Reflection.CallingConventions,System.Type[],System.Reflection.ParameterModifier[])" /> and call <see cref="M:System.Reflection.MemberInfo.IsDefined(System.Type,System.Boolean)" /> on the returned <see cref="T:System.Reflection.ConstructorInfo" />. </exception>
		// Token: 0x06002470 RID: 9328 RVA: 0x0008F9F5 File Offset: 0x0008DBF5
		public override bool IsDefined(Type attributeType, bool inherit)
		{
			throw this.not_supported();
		}

		/// <summary>Returns all the custom attributes defined for this constructor.</summary>
		/// <param name="inherit">Controls inheritance of custom attributes from base classes. This parameter is ignored. </param>
		/// <returns>Returns an array of objects representing all the custom attributes of the constructor represented by this <see cref="T:System.Reflection.Emit.ConstructorBuilder" /> instance.</returns>
		/// <exception cref="T:System.NotSupportedException">This method is not currently supported. </exception>
		// Token: 0x06002471 RID: 9329 RVA: 0x0008F9F5 File Offset: 0x0008DBF5
		public override object[] GetCustomAttributes(bool inherit)
		{
			throw this.not_supported();
		}

		/// <summary>Returns the custom attributes identified by the given type.</summary>
		/// <param name="attributeType">The custom attribute type. </param>
		/// <param name="inherit">Controls inheritance of custom attributes from base classes. This parameter is ignored. </param>
		/// <returns>Returns an array of type <see cref="T:System.Object" /> representing the attributes of this constructor.</returns>
		/// <exception cref="T:System.NotSupportedException">This method is not currently supported. </exception>
		// Token: 0x06002472 RID: 9330 RVA: 0x0008F9F5 File Offset: 0x0008DBF5
		public override object[] GetCustomAttributes(Type attributeType, bool inherit)
		{
			throw this.not_supported();
		}

		/// <summary>Gets an <see cref="T:System.Reflection.Emit.ILGenerator" /> for this constructor.</summary>
		/// <returns>Returns an <see cref="T:System.Reflection.Emit.ILGenerator" /> object for this constructor.</returns>
		/// <exception cref="T:System.InvalidOperationException">The constructor is a default constructor.-or-The constructor has <see cref="T:System.Reflection.MethodAttributes" /> or <see cref="T:System.Reflection.MethodImplAttributes" /> flags indicating that it should not have a method body.</exception>
		// Token: 0x06002473 RID: 9331 RVA: 0x0008FA1D File Offset: 0x0008DC1D
		public ILGenerator GetILGenerator()
		{
			return this.GetILGenerator(64);
		}

		/// <summary>Gets an <see cref="T:System.Reflection.Emit.ILGenerator" /> object, with the specified MSIL stream size, that can be used to build a method body for this constructor.</summary>
		/// <param name="streamSize">The size of the MSIL stream, in bytes.</param>
		/// <returns>An <see cref="T:System.Reflection.Emit.ILGenerator" /> for this constructor.</returns>
		/// <exception cref="T:System.InvalidOperationException">The constructor is a default constructor.-or-The constructor has <see cref="T:System.Reflection.MethodAttributes" /> or <see cref="T:System.Reflection.MethodImplAttributes" /> flags indicating that it should not have a method body. </exception>
		// Token: 0x06002474 RID: 9332 RVA: 0x0008FA28 File Offset: 0x0008DC28
		public ILGenerator GetILGenerator(int streamSize)
		{
			if (this.ilgen != null)
			{
				return this.ilgen;
			}
			this.ilgen = new ILGenerator(this.type.Module, ((ModuleBuilder)this.type.Module).GetTokenGenerator(), streamSize);
			return this.ilgen;
		}

		/// <summary>Returns a reference to the module that contains this constructor.</summary>
		/// <returns>The module that contains this constructor.</returns>
		// Token: 0x06002475 RID: 9333 RVA: 0x0008FA76 File Offset: 0x0008DC76
		public Module GetModule()
		{
			return this.type.Module;
		}

		/// <summary>Returns the <see cref="T:System.Reflection.Emit.MethodToken" /> that represents the token for this constructor.</summary>
		/// <returns>Returns the <see cref="T:System.Reflection.Emit.MethodToken" /> of this constructor.</returns>
		// Token: 0x06002476 RID: 9334 RVA: 0x0008FA83 File Offset: 0x0008DC83
		public MethodToken GetToken()
		{
			return new MethodToken(100663296 | this.table_idx);
		}

		/// <summary>Gets the dynamic module in which this constructor is defined.</summary>
		/// <returns>A <see cref="T:System.Reflection.Module" /> object that represents the dynamic module in which this constructor is defined.</returns>
		// Token: 0x17000512 RID: 1298
		// (get) Token: 0x06002477 RID: 9335 RVA: 0x0008FA96 File Offset: 0x0008DC96
		public override Module Module
		{
			get
			{
				return this.GetModule();
			}
		}

		/// <summary>Returns this <see cref="T:System.Reflection.Emit.ConstructorBuilder" /> instance as a <see cref="T:System.String" />.</summary>
		/// <returns>Returns a <see cref="T:System.String" /> containing the name, attributes, and exceptions of this constructor, followed by the current Microsoft intermediate language (MSIL) stream.</returns>
		// Token: 0x06002478 RID: 9336 RVA: 0x0008FA9E File Offset: 0x0008DC9E
		public override string ToString()
		{
			return "ConstructorBuilder ['" + this.type.Name + "']";
		}

		// Token: 0x06002479 RID: 9337 RVA: 0x0008FABC File Offset: 0x0008DCBC
		internal void fixup()
		{
			if ((this.attrs & (MethodAttributes.Abstract | MethodAttributes.PinvokeImpl)) == MethodAttributes.PrivateScope && (this.iattrs & (MethodImplAttributes)4099) == MethodImplAttributes.IL && (this.ilgen == null || this.ilgen.ILOffset == 0))
			{
				throw new InvalidOperationException("Method '" + this.Name + "' does not have a method body.");
			}
			if (this.ilgen != null)
			{
				this.ilgen.label_fixup(this);
			}
		}

		// Token: 0x0600247A RID: 9338 RVA: 0x0008FB2C File Offset: 0x0008DD2C
		internal void ResolveUserTypes()
		{
			TypeBuilder.ResolveUserTypes(this.parameters);
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

		// Token: 0x0600247B RID: 9339 RVA: 0x0008FB8E File Offset: 0x0008DD8E
		internal override int get_next_table_index(object obj, int table, int count)
		{
			return this.type.get_next_table_index(obj, table, count);
		}

		// Token: 0x0600247C RID: 9340 RVA: 0x0008F51E File Offset: 0x0008D71E
		private Exception not_supported()
		{
			return new NotSupportedException("The invoked member is not supported in a dynamic module.");
		}

		// Token: 0x0600247D RID: 9341 RVA: 0x0008FB9E File Offset: 0x0008DD9E
		private Exception not_created()
		{
			return new NotSupportedException("The type is not yet created.");
		}

		// Token: 0x040011DE RID: 4574
		private RuntimeMethodHandle mhandle;

		// Token: 0x040011DF RID: 4575
		private ILGenerator ilgen;

		// Token: 0x040011E0 RID: 4576
		internal Type[] parameters;

		// Token: 0x040011E1 RID: 4577
		private MethodAttributes attrs;

		// Token: 0x040011E2 RID: 4578
		private MethodImplAttributes iattrs;

		// Token: 0x040011E3 RID: 4579
		private int table_idx;

		// Token: 0x040011E4 RID: 4580
		private CallingConventions call_conv;

		// Token: 0x040011E5 RID: 4581
		private TypeBuilder type;

		// Token: 0x040011E6 RID: 4582
		internal ParameterBuilder[] pinfo;

		// Token: 0x040011E7 RID: 4583
		private CustomAttributeBuilder[] cattrs;

		// Token: 0x040011E8 RID: 4584
		private bool init_locals = true;

		// Token: 0x040011E9 RID: 4585
		private Type[][] paramModReq;

		// Token: 0x040011EA RID: 4586
		private Type[][] paramModOpt;

		// Token: 0x040011EB RID: 4587
		private RefEmitPermissionSet[] permissions;
	}
}
