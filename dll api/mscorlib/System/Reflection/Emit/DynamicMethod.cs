using System;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace System.Reflection.Emit
{
	/// <summary>Defines and represents a dynamic method that can be compiled, executed, and discarded. Discarded methods are available for garbage collection.</summary>
	// Token: 0x020004F8 RID: 1272
	[ComVisible(true)]
	[StructLayout(0)]
	public sealed class DynamicMethod : MethodInfo
	{
		/// <summary>Creates a dynamic method, specifying the method name, return type, parameter types, the type with which the dynamic method is logically associated, and whether just-in-time (JIT) visibility checks should be skipped for types and members accessed by the Microsoft intermediate language (MSIL) of the dynamic method.</summary>
		/// <param name="name">The name of the dynamic method. This can be a zero-length string, but it cannot be <see langword="null" />. </param>
		/// <param name="returnType">A <see cref="T:System.Type" /> object that specifies the return type of the dynamic method, or <see langword="null" /> if the method has no return type. </param>
		/// <param name="parameterTypes">An array of <see cref="T:System.Type" /> objects specifying the types of the parameters of the dynamic method, or <see langword="null" /> if the method has no parameters. </param>
		/// <param name="owner">A <see cref="T:System.Type" /> with which the dynamic method is logically associated. The dynamic method has access to all members of the type.</param>
		/// <param name="skipVisibility">
		///       <see langword="true" /> to skip JIT visibility checks on types and members accessed by the MSIL of the dynamic method; otherwise, <see langword="false" />. </param>
		/// <exception cref="T:System.ArgumentException">An element of <paramref name="parameterTypes" /> is <see langword="null" /> or <see cref="T:System.Void" />.-or- 
		///         <paramref name="owner" /> is an interface, an array, an open generic type, or a type parameter of a generic type or method.</exception>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="name" /> is <see langword="null" />. -or-
		///         <paramref name="owner" /> is <see langword="null" />.</exception>
		/// <exception cref="T:System.NotSupportedException">
		///         <paramref name="returnType" /> is <see langword="null" />, or is a type for which <see cref="P:System.Type.IsByRef" /> returns <see langword="true" />. </exception>
		// Token: 0x060024AA RID: 9386 RVA: 0x0008FFBE File Offset: 0x0008E1BE
		public DynamicMethod(string name, Type returnType, Type[] parameterTypes, Type owner, bool skipVisibility) : this(name, MethodAttributes.FamANDAssem | MethodAttributes.Family | MethodAttributes.Static, CallingConventions.Standard, returnType, parameterTypes, owner, skipVisibility)
		{
		}

		/// <summary>Creates a dynamic method, specifying the method name, attributes, calling convention, return type, parameter types, the type with which the dynamic method is logically associated, and whether just-in-time (JIT) visibility checks should be skipped for types and members accessed by the Microsoft intermediate language (MSIL) of the dynamic method.</summary>
		/// <param name="name">The name of the dynamic method. This can be a zero-length string, but it cannot be <see langword="null" />.</param>
		/// <param name="attributes">A bitwise combination of <see cref="T:System.Reflection.MethodAttributes" /> values that specifies the attributes of the dynamic method. The only combination allowed is <see cref="F:System.Reflection.MethodAttributes.Public" /> and <see cref="F:System.Reflection.MethodAttributes.Static" />.</param>
		/// <param name="callingConvention">The calling convention for the dynamic method. Must be <see cref="F:System.Reflection.CallingConventions.Standard" />.</param>
		/// <param name="returnType">A <see cref="T:System.Type" /> object that specifies the return type of the dynamic method, or <see langword="null" /> if the method has no return type. </param>
		/// <param name="parameterTypes">An array of <see cref="T:System.Type" /> objects specifying the types of the parameters of the dynamic method, or <see langword="null" /> if the method has no parameters. </param>
		/// <param name="owner">A <see cref="T:System.Type" /> with which the dynamic method is logically associated. The dynamic method has access to all members of the type.</param>
		/// <param name="skipVisibility">
		///       <see langword="true" /> to skip JIT visibility checks on types and members accessed by the MSIL of the dynamic method; otherwise, <see langword="false" />.</param>
		/// <exception cref="T:System.ArgumentException">An element of <paramref name="parameterTypes" /> is <see langword="null" /> or <see cref="T:System.Void" />. -or-
		///         <paramref name="owner" /> is an interface, an array, an open generic type, or a type parameter of a generic type or method.</exception>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="name" /> is <see langword="null" />. -or-
		///         <paramref name="owner" /> is <see langword="null" />.</exception>
		/// <exception cref="T:System.NotSupportedException">
		///         <paramref name="attributes" /> is a combination of flags other than <see cref="F:System.Reflection.MethodAttributes.Public" /> and <see cref="F:System.Reflection.MethodAttributes.Static" />.-or-
		///         <paramref name="callingConvention" /> is not <see cref="F:System.Reflection.CallingConventions.Standard" />.-or-
		///         <paramref name="returnType" /> is a type for which <see cref="P:System.Type.IsByRef" /> returns <see langword="true" />. </exception>
		// Token: 0x060024AB RID: 9387 RVA: 0x0008FFD0 File Offset: 0x0008E1D0
		public DynamicMethod(string name, MethodAttributes attributes, CallingConventions callingConvention, Type returnType, Type[] parameterTypes, Type owner, bool skipVisibility) : this(name, attributes, callingConvention, returnType, parameterTypes, owner, owner.Module, skipVisibility, false)
		{
		}

		/// <summary>Initializes an anonymously hosted dynamic method, specifying the method name, return type, parameter types, and whether just-in-time (JIT) visibility checks should be skipped for types and members accessed by the Microsoft intermediate language (MSIL) of the dynamic method. </summary>
		/// <param name="name">The name of the dynamic method. This can be a zero-length string, but it cannot be <see langword="null" />. </param>
		/// <param name="returnType">A <see cref="T:System.Type" /> object that specifies the return type of the dynamic method, or <see langword="null" /> if the method has no return type. </param>
		/// <param name="parameterTypes">An array of <see cref="T:System.Type" /> objects specifying the types of the parameters of the dynamic method, or <see langword="null" /> if the method has no parameters. </param>
		/// <param name="restrictedSkipVisibility">
		///       <see langword="true" /> to skip JIT visibility checks on types and members accessed by the MSIL of the dynamic method, with this restriction: the trust level of the assemblies that contain those types and members must be equal to or less than the trust level of the call stack that emits the dynamic method; otherwise, <see langword="false" />. </param>
		/// <exception cref="T:System.ArgumentException">An element of <paramref name="parameterTypes" /> is <see langword="null" /> or <see cref="T:System.Void" />.</exception>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="name" /> is <see langword="null" />. </exception>
		/// <exception cref="T:System.NotSupportedException">
		///         <paramref name="returnType" /> is a type for which <see cref="P:System.Type.IsByRef" /> returns <see langword="true" />. </exception>
		// Token: 0x060024AC RID: 9388 RVA: 0x0008FFF8 File Offset: 0x0008E1F8
		public DynamicMethod(string name, Type returnType, Type[] parameterTypes, bool restrictedSkipVisibility) : this(name, MethodAttributes.FamANDAssem | MethodAttributes.Family | MethodAttributes.Static, CallingConventions.Standard, returnType, parameterTypes, null, null, restrictedSkipVisibility, true)
		{
		}

		// Token: 0x060024AD RID: 9389 RVA: 0x00090018 File Offset: 0x0008E218
		private DynamicMethod(string name, MethodAttributes attributes, CallingConventions callingConvention, Type returnType, Type[] parameterTypes, Type owner, Module m, bool skipVisibility, bool anonHosted)
		{
			if (name == null)
			{
				throw new ArgumentNullException("name");
			}
			if (returnType == null)
			{
				returnType = typeof(void);
			}
			if (m == null && !anonHosted)
			{
				throw new ArgumentNullException("m");
			}
			if (returnType.IsByRef)
			{
				throw new ArgumentException("Return type can't be a byref type", "returnType");
			}
			if (parameterTypes != null)
			{
				for (int i = 0; i < parameterTypes.Length; i++)
				{
					if (parameterTypes[i] == null)
					{
						throw new ArgumentException("Parameter " + i.ToString() + " is null", "parameterTypes");
					}
				}
			}
			if (owner != null && (owner.IsArray || owner.IsInterface))
			{
				throw new ArgumentException("Owner can't be an array or an interface.");
			}
			if (m == null)
			{
				m = DynamicMethod.AnonHostModuleHolder.AnonHostModule;
			}
			this.name = name;
			this.attributes = (attributes | MethodAttributes.Static);
			this.callingConvention = callingConvention;
			this.returnType = returnType;
			this.parameters = parameterTypes;
			this.owner = owner;
			this.module = m;
			this.skipVisibility = skipVisibility;
		}

		// Token: 0x060024AE RID: 9390
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void create_dynamic_method(DynamicMethod m);

		// Token: 0x060024AF RID: 9391 RVA: 0x00090140 File Offset: 0x0008E340
		private void CreateDynMethod()
		{
			lock (this)
			{
				if (this.mhandle.Value == IntPtr.Zero)
				{
					if (this.ilgen == null || this.ilgen.ILOffset == 0)
					{
						throw new InvalidOperationException("Method '" + this.name + "' does not have a method body.");
					}
					this.ilgen.label_fixup(this);
					try
					{
						this.creating = true;
						if (this.refs != null)
						{
							for (int i = 0; i < this.refs.Length; i++)
							{
								if (this.refs[i] is DynamicMethod)
								{
									DynamicMethod dynamicMethod = (DynamicMethod)this.refs[i];
									if (!dynamicMethod.creating)
									{
										dynamicMethod.CreateDynMethod();
									}
								}
							}
						}
					}
					finally
					{
						this.creating = false;
					}
					DynamicMethod.create_dynamic_method(this);
					this.ilgen = null;
				}
			}
		}

		/// <summary>Completes the dynamic method and creates a delegate that can be used to execute it.</summary>
		/// <param name="delegateType">A delegate type whose signature matches that of the dynamic method. </param>
		/// <returns>A delegate of the specified type, which can be used to execute the dynamic method.</returns>
		/// <exception cref="T:System.InvalidOperationException">The dynamic method has no method body.</exception>
		/// <exception cref="T:System.ArgumentException">
		///         <paramref name="delegateType" /> has the wrong number of parameters or the wrong parameter types.</exception>
		// Token: 0x060024B0 RID: 9392 RVA: 0x0009023C File Offset: 0x0008E43C
		[ComVisible(true)]
		public sealed override Delegate CreateDelegate(Type delegateType)
		{
			if (delegateType == null)
			{
				throw new ArgumentNullException("delegateType");
			}
			if (this.deleg != null)
			{
				return this.deleg;
			}
			this.CreateDynMethod();
			this.deleg = Delegate.CreateDelegate(delegateType, null, this);
			return this.deleg;
		}

		/// <summary>Completes the dynamic method and creates a delegate that can be used to execute it, specifying the delegate type and an object the delegate is bound to.</summary>
		/// <param name="delegateType">A delegate type whose signature matches that of the dynamic method, minus the first parameter.</param>
		/// <param name="target">An object the delegate is bound to. Must be of the same type as the first parameter of the dynamic method. </param>
		/// <returns>A delegate of the specified type, which can be used to execute the dynamic method with the specified target object.</returns>
		/// <exception cref="T:System.InvalidOperationException">The dynamic method has no method body.</exception>
		/// <exception cref="T:System.ArgumentException">
		///         <paramref name="target" /> is not the same type as the first parameter of the dynamic method, and is not assignable to that type.-or-
		///         <paramref name="delegateType" /> has the wrong number of parameters or the wrong parameter types.</exception>
		// Token: 0x060024B1 RID: 9393 RVA: 0x0009027B File Offset: 0x0008E47B
		[ComVisible(true)]
		public sealed override Delegate CreateDelegate(Type delegateType, object target)
		{
			if (delegateType == null)
			{
				throw new ArgumentNullException("delegateType");
			}
			this.CreateDynMethod();
			return Delegate.CreateDelegate(delegateType, target, this);
		}

		/// <summary>Returns the base implementation for the method.</summary>
		/// <returns>The base implementation of the method.</returns>
		// Token: 0x060024B2 RID: 9394 RVA: 0x0000245A File Offset: 0x0000065A
		public override MethodInfo GetBaseDefinition()
		{
			return this;
		}

		/// <summary>Returns all the custom attributes defined for the method.</summary>
		/// <param name="inherit">
		///       <see langword="true" /> to search the method's inheritance chain to find the custom attributes; <see langword="false" /> to check only the current method. </param>
		/// <returns>An array of objects representing all the custom attributes of the method.</returns>
		// Token: 0x060024B3 RID: 9395 RVA: 0x0009029F File Offset: 0x0008E49F
		public override object[] GetCustomAttributes(bool inherit)
		{
			return new object[]
			{
				new MethodImplAttribute(this.GetMethodImplementationFlags())
			};
		}

		/// <summary>Returns the custom attributes of the specified type that have been applied to the method.</summary>
		/// <param name="attributeType">A <see cref="T:System.Type" /> representing the type of custom attribute to return. </param>
		/// <param name="inherit">
		///       <see langword="true" /> to search the method's inheritance chain to find the custom attributes; <see langword="false" /> to check only the current method. </param>
		/// <returns>An array of objects representing the attributes of the method that are of type <paramref name="attributeType" /> or derive from type <paramref name="attributeType" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="attributeType" /> is <see langword="null" />.</exception>
		// Token: 0x060024B4 RID: 9396 RVA: 0x000902B8 File Offset: 0x0008E4B8
		public override object[] GetCustomAttributes(Type attributeType, bool inherit)
		{
			if (attributeType == null)
			{
				throw new ArgumentNullException("attributeType");
			}
			if (attributeType.IsAssignableFrom(typeof(MethodImplAttribute)))
			{
				return new object[]
				{
					new MethodImplAttribute(this.GetMethodImplementationFlags())
				};
			}
			return EmptyArray<object>.Value;
		}

		/// <summary>Returns a Microsoft intermediate language (MSIL) generator for the method with a default MSIL stream size of 64 bytes.</summary>
		/// <returns>An <see cref="T:System.Reflection.Emit.ILGenerator" /> object for the method.</returns>
		// Token: 0x060024B5 RID: 9397 RVA: 0x00090305 File Offset: 0x0008E505
		public ILGenerator GetILGenerator()
		{
			return this.GetILGenerator(64);
		}

		/// <summary>Returns a Microsoft intermediate language (MSIL) generator for the method with the specified MSIL stream size.</summary>
		/// <param name="streamSize">The size of the MSIL stream, in bytes. </param>
		/// <returns>An <see cref="T:System.Reflection.Emit.ILGenerator" /> object for the method, with the specified MSIL stream size.</returns>
		// Token: 0x060024B6 RID: 9398 RVA: 0x00090310 File Offset: 0x0008E510
		public ILGenerator GetILGenerator(int streamSize)
		{
			if ((this.GetMethodImplementationFlags() & MethodImplAttributes.CodeTypeMask) != MethodImplAttributes.IL || (this.GetMethodImplementationFlags() & MethodImplAttributes.ManagedMask) != MethodImplAttributes.IL)
			{
				throw new InvalidOperationException("Method body should not exist.");
			}
			if (this.ilgen != null)
			{
				return this.ilgen;
			}
			this.ilgen = new ILGenerator(this.Module, new DynamicMethodTokenGenerator(this), streamSize);
			return this.ilgen;
		}

		/// <summary>Returns the implementation flags for the method.</summary>
		/// <returns>A bitwise combination of <see cref="T:System.Reflection.MethodImplAttributes" /> values representing the implementation flags for the method.</returns>
		// Token: 0x060024B7 RID: 9399 RVA: 0x0002B5F5 File Offset: 0x000297F5
		public override MethodImplAttributes GetMethodImplementationFlags()
		{
			return MethodImplAttributes.NoInlining;
		}

		/// <summary>Returns the parameters of the dynamic method.</summary>
		/// <returns>An array of <see cref="T:System.Reflection.ParameterInfo" /> objects that represent the parameters of the dynamic method.</returns>
		// Token: 0x060024B8 RID: 9400 RVA: 0x00090369 File Offset: 0x0008E569
		public override ParameterInfo[] GetParameters()
		{
			return this.GetParametersInternal();
		}

		// Token: 0x060024B9 RID: 9401 RVA: 0x00090374 File Offset: 0x0008E574
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

		// Token: 0x060024BA RID: 9402 RVA: 0x000903D6 File Offset: 0x0008E5D6
		internal override int GetParametersCount()
		{
			if (this.parameters != null)
			{
				return this.parameters.Length;
			}
			return 0;
		}

		/// <summary>Invokes the dynamic method using the specified parameters, under the constraints of the specified binder, with the specified culture information.</summary>
		/// <param name="obj">This parameter is ignored for dynamic methods, because they are static. Specify <see langword="null" />. </param>
		/// <param name="invokeAttr">A bitwise combination of <see cref="T:System.Reflection.BindingFlags" /> values.</param>
		/// <param name="binder">A <see cref="T:System.Reflection.Binder" /> object that enables the binding, coercion of argument types, invocation of members, and retrieval of <see cref="T:System.Reflection.MemberInfo" /> objects through reflection. If <paramref name="binder" /> is <see langword="null" />, the default binder is used. For more details, see <see cref="T:System.Reflection.Binder" />. </param>
		/// <param name="parameters">An argument list. This is an array of arguments with the same number, order, and type as the parameters of the method to be invoked. If there are no parameters this parameter should be <see langword="null" />. </param>
		/// <param name="culture">An instance of <see cref="T:System.Globalization.CultureInfo" /> used to govern the coercion of types. If this is <see langword="null" />, the <see cref="T:System.Globalization.CultureInfo" /> for the current thread is used. For example, this information is needed to correctly convert a <see cref="T:System.String" /> that represents 1000 to a <see cref="T:System.Double" /> value, because 1000 is represented differently by different cultures. </param>
		/// <returns>A <see cref="T:System.Object" /> containing the return value of the invoked method.</returns>
		/// <exception cref="T:System.NotSupportedException">The <see cref="F:System.Reflection.CallingConventions.VarArgs" /> calling convention is not supported.</exception>
		/// <exception cref="T:System.Reflection.TargetParameterCountException">The number of elements in <paramref name="parameters" /> does not match the number of parameters in the dynamic method.</exception>
		/// <exception cref="T:System.ArgumentException">The type of one or more elements of <paramref name="parameters" /> does not match the type of the corresponding parameter of the dynamic method.</exception>
		/// <exception cref="T:System.Reflection.TargetInvocationException">The dynamic method is associated with a module, is not anonymously hosted, and was constructed with <paramref name="skipVisibility" /> set to <see langword="false" />, but the dynamic method accesses members that are not <see langword="public" /> or <see langword="internal" /> (<see langword="Friend" /> in Visual Basic).-or-The dynamic method is anonymously hosted and was constructed with <paramref name="skipVisibility" /> set to <see langword="false" />, but it accesses members that are not <see langword="public" />.-or-
		///         The dynamic method contains unverifiable code. See the "Verification" section in Remarks for <see cref="T:System.Reflection.Emit.DynamicMethod" />.</exception>
		// Token: 0x060024BB RID: 9403 RVA: 0x000903EC File Offset: 0x0008E5EC
		public override object Invoke(object obj, BindingFlags invokeAttr, Binder binder, object[] parameters, CultureInfo culture)
		{
			object result;
			try
			{
				this.CreateDynMethod();
				if (this.method == null)
				{
					this.method = new RuntimeMethodInfo(this.mhandle);
				}
				result = this.method.Invoke(obj, invokeAttr, binder, parameters, culture);
			}
			catch (MethodAccessException inner)
			{
				throw new TargetInvocationException("Method cannot be invoked.", inner);
			}
			return result;
		}

		/// <summary>Indicates whether the specified custom attribute type is defined.</summary>
		/// <param name="attributeType">A <see cref="T:System.Type" /> representing the type of custom attribute to search for. </param>
		/// <param name="inherit">
		///       <see langword="true" /> to search the method's inheritance chain to find the custom attributes; <see langword="false" /> to check only the current method. </param>
		/// <returns>
		///     <see langword="true" /> if the specified custom attribute type is defined; otherwise, <see langword="false" />.</returns>
		// Token: 0x060024BC RID: 9404 RVA: 0x00090454 File Offset: 0x0008E654
		public override bool IsDefined(Type attributeType, bool inherit)
		{
			if (attributeType == null)
			{
				throw new ArgumentNullException("attributeType");
			}
			return attributeType.IsAssignableFrom(typeof(MethodImplAttribute));
		}

		/// <summary>Returns the signature of the method, represented as a string.</summary>
		/// <returns>A string representing the method signature.</returns>
		// Token: 0x060024BD RID: 9405 RVA: 0x00090480 File Offset: 0x0008E680
		public override string ToString()
		{
			string text = string.Empty;
			ParameterInfo[] parametersInternal = this.GetParametersInternal();
			for (int i = 0; i < parametersInternal.Length; i++)
			{
				if (i > 0)
				{
					text += ", ";
				}
				text += parametersInternal[i].ParameterType.Name;
			}
			return string.Concat(new string[]
			{
				this.ReturnType.Name,
				" ",
				this.Name,
				"(",
				text,
				")"
			});
		}

		/// <summary>Gets the attributes specified when the dynamic method was created.</summary>
		/// <returns>A bitwise combination of the <see cref="T:System.Reflection.MethodAttributes" /> values representing the attributes for the method.</returns>
		// Token: 0x1700051F RID: 1311
		// (get) Token: 0x060024BE RID: 9406 RVA: 0x0009050A File Offset: 0x0008E70A
		public override MethodAttributes Attributes
		{
			get
			{
				return this.attributes;
			}
		}

		/// <summary>Gets the calling convention specified when the dynamic method was created.</summary>
		/// <returns>One of the <see cref="T:System.Reflection.CallingConventions" /> values that indicates the calling convention of the method.</returns>
		// Token: 0x17000520 RID: 1312
		// (get) Token: 0x060024BF RID: 9407 RVA: 0x00090512 File Offset: 0x0008E712
		public override CallingConventions CallingConvention
		{
			get
			{
				return this.callingConvention;
			}
		}

		/// <summary>Gets the type that declares the method, which is always <see langword="null" /> for dynamic methods.</summary>
		/// <returns>Always <see langword="null" />.</returns>
		// Token: 0x17000521 RID: 1313
		// (get) Token: 0x060024C0 RID: 9408 RVA: 0x0002AC82 File Offset: 0x00028E82
		public override Type DeclaringType
		{
			get
			{
				return null;
			}
		}

		/// <summary>Not supported for dynamic methods.</summary>
		/// <returns>Not supported for dynamic methods.</returns>
		/// <exception cref="T:System.InvalidOperationException">Not allowed for dynamic methods.</exception>
		// Token: 0x17000522 RID: 1314
		// (get) Token: 0x060024C1 RID: 9409 RVA: 0x0009051A File Offset: 0x0008E71A
		public override RuntimeMethodHandle MethodHandle
		{
			get
			{
				return this.mhandle;
			}
		}

		/// <summary>Gets the module with which the dynamic method is logically associated.</summary>
		/// <returns>The <see cref="T:System.Reflection.Module" /> with which the current dynamic method is associated.</returns>
		// Token: 0x17000523 RID: 1315
		// (get) Token: 0x060024C2 RID: 9410 RVA: 0x00090522 File Offset: 0x0008E722
		public override Module Module
		{
			get
			{
				return this.module;
			}
		}

		/// <summary>Gets the name of the dynamic method.</summary>
		/// <returns>The simple name of the method.</returns>
		// Token: 0x17000524 RID: 1316
		// (get) Token: 0x060024C3 RID: 9411 RVA: 0x0009052A File Offset: 0x0008E72A
		public override string Name
		{
			get
			{
				return this.name;
			}
		}

		/// <summary>Gets the class that was used in reflection to obtain the method.</summary>
		/// <returns>Always <see langword="null" />.</returns>
		// Token: 0x17000525 RID: 1317
		// (get) Token: 0x060024C4 RID: 9412 RVA: 0x0002AC82 File Offset: 0x00028E82
		public override Type ReflectedType
		{
			get
			{
				return null;
			}
		}

		/// <summary>Gets the return parameter of the dynamic method.</summary>
		/// <returns>Always <see langword="null" />. </returns>
		// Token: 0x17000526 RID: 1318
		// (get) Token: 0x060024C5 RID: 9413 RVA: 0x0002B1E0 File Offset: 0x000293E0
		public override ParameterInfo ReturnParameter
		{
			get
			{
				throw new NotImplementedException();
			}
		}

		/// <summary>Gets the type of return value for the dynamic method.</summary>
		/// <returns>A <see cref="T:System.Type" /> representing the type of the return value of the current method; <see cref="T:System.Void" /> if the method has no return type.</returns>
		// Token: 0x17000527 RID: 1319
		// (get) Token: 0x060024C6 RID: 9414 RVA: 0x00090532 File Offset: 0x0008E732
		public override Type ReturnType
		{
			get
			{
				return this.returnType;
			}
		}

		// Token: 0x060024C7 RID: 9415 RVA: 0x0009053C File Offset: 0x0008E73C
		internal int AddRef(object reference)
		{
			if (this.refs == null)
			{
				this.refs = new object[4];
			}
			if (this.nrefs >= this.refs.Length - 1)
			{
				object[] destinationArray = new object[this.refs.Length * 2];
				Array.Copy(this.refs, destinationArray, this.refs.Length);
				this.refs = destinationArray;
			}
			this.refs[this.nrefs] = reference;
			this.refs[this.nrefs + 1] = null;
			this.nrefs += 2;
			return this.nrefs - 1;
		}

		// Token: 0x040011F6 RID: 4598
		private RuntimeMethodHandle mhandle;

		// Token: 0x040011F7 RID: 4599
		private string name;

		// Token: 0x040011F8 RID: 4600
		private Type returnType;

		// Token: 0x040011F9 RID: 4601
		private Type[] parameters;

		// Token: 0x040011FA RID: 4602
		private MethodAttributes attributes;

		// Token: 0x040011FB RID: 4603
		private CallingConventions callingConvention;

		// Token: 0x040011FC RID: 4604
		private Module module;

		// Token: 0x040011FD RID: 4605
		private bool skipVisibility;

		// Token: 0x040011FE RID: 4606
		private bool init_locals = true;

		// Token: 0x040011FF RID: 4607
		private ILGenerator ilgen;

		// Token: 0x04001200 RID: 4608
		private int nrefs;

		// Token: 0x04001201 RID: 4609
		private object[] refs;

		// Token: 0x04001202 RID: 4610
		private IntPtr referenced_by;

		// Token: 0x04001203 RID: 4611
		private Type owner;

		// Token: 0x04001204 RID: 4612
		private Delegate deleg;

		// Token: 0x04001205 RID: 4613
		private RuntimeMethodInfo method;

		// Token: 0x04001206 RID: 4614
		private ParameterBuilder[] pinfo;

		// Token: 0x04001207 RID: 4615
		internal bool creating;

		// Token: 0x04001208 RID: 4616
		private DynamicILInfo il_info;

		// Token: 0x020004F9 RID: 1273
		private static class AnonHostModuleHolder
		{
			// Token: 0x060024C8 RID: 9416 RVA: 0x000905D0 File Offset: 0x0008E7D0
			static AnonHostModuleHolder()
			{
				AssemblyName assemblyName = new AssemblyName();
				assemblyName.Name = "Anonymously Hosted DynamicMethods Assembly";
				DynamicMethod.AnonHostModuleHolder.anon_host_module = AppDomain.CurrentDomain.DefineDynamicAssembly(assemblyName, AssemblyBuilderAccess.Run).GetManifestModule();
			}

			// Token: 0x17000528 RID: 1320
			// (get) Token: 0x060024C9 RID: 9417 RVA: 0x00090604 File Offset: 0x0008E804
			public static Module AnonHostModule
			{
				get
				{
					return DynamicMethod.AnonHostModuleHolder.anon_host_module;
				}
			}

			// Token: 0x04001209 RID: 4617
			public static readonly Module anon_host_module;
		}
	}
}
