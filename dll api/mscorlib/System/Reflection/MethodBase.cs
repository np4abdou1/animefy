using System;
using System.Diagnostics;
using System.Globalization;
using System.Reflection.Emit;
using System.Runtime.InteropServices;
using System.Text;

namespace System.Reflection
{
	/// <summary>Provides information about methods and constructors. </summary>
	// Token: 0x020004A9 RID: 1193
	[Serializable]
	public abstract class MethodBase : MemberInfo
	{
		/// <summary>When overridden in a derived class, gets the parameters of the specified method or constructor.</summary>
		/// <returns>An array of type <see langword="ParameterInfo" /> containing information that matches the signature of the method (or constructor) reflected by this <see langword="MethodBase" /> instance.</returns>
		// Token: 0x0600213B RID: 8507
		public abstract ParameterInfo[] GetParameters();

		/// <summary>Gets the attributes associated with this method.</summary>
		/// <returns>One of the <see cref="T:System.Reflection.MethodAttributes" /> values.</returns>
		// Token: 0x1700042D RID: 1069
		// (get) Token: 0x0600213C RID: 8508
		public abstract MethodAttributes Attributes { get; }

		/// <summary>When overridden in a derived class, returns the <see cref="T:System.Reflection.MethodImplAttributes" /> flags.</summary>
		/// <returns>The <see langword="MethodImplAttributes" /> flags.</returns>
		// Token: 0x0600213D RID: 8509
		public abstract MethodImplAttributes GetMethodImplementationFlags();

		/// <summary>Gets a value indicating the calling conventions for this method.</summary>
		/// <returns>The <see cref="T:System.Reflection.CallingConventions" /> for this method.</returns>
		// Token: 0x1700042E RID: 1070
		// (get) Token: 0x0600213E RID: 8510 RVA: 0x0000B18D File Offset: 0x0000938D
		public virtual CallingConventions CallingConvention
		{
			get
			{
				return CallingConventions.Standard;
			}
		}

		/// <summary>Gets a value indicating whether the method is abstract.</summary>
		/// <returns>
		///     <see langword="true" /> if the method is abstract; otherwise, <see langword="false" />.</returns>
		// Token: 0x1700042F RID: 1071
		// (get) Token: 0x0600213F RID: 8511 RVA: 0x0008A15C File Offset: 0x0008835C
		public bool IsAbstract
		{
			get
			{
				return (this.Attributes & MethodAttributes.Abstract) > MethodAttributes.PrivateScope;
			}
		}

		/// <summary>Gets a value indicating whether the method is a constructor.</summary>
		/// <returns>
		///     <see langword="true" /> if this method is a constructor represented by a <see cref="T:System.Reflection.ConstructorInfo" /> object (see note in Remarks about <see cref="T:System.Reflection.Emit.ConstructorBuilder" /> objects); otherwise, <see langword="false" />.</returns>
		// Token: 0x17000430 RID: 1072
		// (get) Token: 0x06002140 RID: 8512 RVA: 0x0008A16D File Offset: 0x0008836D
		public bool IsConstructor
		{
			get
			{
				return this is ConstructorInfo && !this.IsStatic && (this.Attributes & MethodAttributes.RTSpecialName) == MethodAttributes.RTSpecialName;
			}
		}

		/// <summary>Gets a value indicating whether this method has a special name.</summary>
		/// <returns>
		///     <see langword="true" /> if this method has a special name; otherwise, <see langword="false" />.</returns>
		// Token: 0x17000431 RID: 1073
		// (get) Token: 0x06002141 RID: 8513 RVA: 0x0008A194 File Offset: 0x00088394
		public bool IsSpecialName
		{
			get
			{
				return (this.Attributes & MethodAttributes.SpecialName) > MethodAttributes.PrivateScope;
			}
		}

		/// <summary>Gets a value indicating whether the method is <see langword="static" />.</summary>
		/// <returns>
		///     <see langword="true" /> if this method is <see langword="static" />; otherwise, <see langword="false" />.</returns>
		// Token: 0x17000432 RID: 1074
		// (get) Token: 0x06002142 RID: 8514 RVA: 0x0008A1A5 File Offset: 0x000883A5
		public bool IsStatic
		{
			get
			{
				return (this.Attributes & MethodAttributes.Static) > MethodAttributes.PrivateScope;
			}
		}

		/// <summary>Gets a value indicating whether the method is <see langword="virtual" />.</summary>
		/// <returns>
		///     <see langword="true" /> if this method is <see langword="virtual" />; otherwise, <see langword="false" />.</returns>
		// Token: 0x17000433 RID: 1075
		// (get) Token: 0x06002143 RID: 8515 RVA: 0x0008A1B3 File Offset: 0x000883B3
		public bool IsVirtual
		{
			get
			{
				return (this.Attributes & MethodAttributes.Virtual) > MethodAttributes.PrivateScope;
			}
		}

		/// <summary>Gets a value indicating whether this is a public method.</summary>
		/// <returns>
		///     <see langword="true" /> if this method is public; otherwise, <see langword="false" />.</returns>
		// Token: 0x17000434 RID: 1076
		// (get) Token: 0x06002144 RID: 8516 RVA: 0x0008A1C1 File Offset: 0x000883C1
		public bool IsPublic
		{
			get
			{
				return (this.Attributes & MethodAttributes.MemberAccessMask) == MethodAttributes.Public;
			}
		}

		/// <summary>Gets a value indicating whether the method is generic.</summary>
		/// <returns>
		///     <see langword="true" /> if the current <see cref="T:System.Reflection.MethodBase" /> represents a generic method; otherwise, <see langword="false" />.</returns>
		// Token: 0x17000435 RID: 1077
		// (get) Token: 0x06002145 RID: 8517 RVA: 0x0002ACA4 File Offset: 0x00028EA4
		public virtual bool IsGenericMethod
		{
			get
			{
				return false;
			}
		}

		/// <summary>Gets a value indicating whether the method is a generic method definition.</summary>
		/// <returns>
		///     <see langword="true" /> if the current <see cref="T:System.Reflection.MethodBase" /> object represents the definition of a generic method; otherwise, <see langword="false" />.</returns>
		// Token: 0x17000436 RID: 1078
		// (get) Token: 0x06002146 RID: 8518 RVA: 0x0002ACA4 File Offset: 0x00028EA4
		public virtual bool IsGenericMethodDefinition
		{
			get
			{
				return false;
			}
		}

		/// <summary>Returns an array of <see cref="T:System.Type" /> objects that represent the type arguments of a generic method or the type parameters of a generic method definition.</summary>
		/// <returns>An array of <see cref="T:System.Type" /> objects that represent the type arguments of a generic method or the type parameters of a generic method definition. Returns an empty array if the current method is not a generic method.</returns>
		/// <exception cref="T:System.NotSupportedException">The current object is a <see cref="T:System.Reflection.ConstructorInfo" />. Generic constructors are not supported in the .NET Framework version 2.0. This exception is the default behavior if this method is not overridden in a derived class.</exception>
		// Token: 0x06002147 RID: 8519 RVA: 0x0002ACDC File Offset: 0x00028EDC
		public virtual Type[] GetGenericArguments()
		{
			throw new NotSupportedException("Derived classes must provide an implementation.");
		}

		/// <summary>Gets a value indicating whether the generic method contains unassigned generic type parameters.</summary>
		/// <returns>
		///     <see langword="true" /> if the current <see cref="T:System.Reflection.MethodBase" /> object represents a generic method that contains unassigned generic type parameters; otherwise, <see langword="false" />.</returns>
		// Token: 0x17000437 RID: 1079
		// (get) Token: 0x06002148 RID: 8520 RVA: 0x0002ACA4 File Offset: 0x00028EA4
		public virtual bool ContainsGenericParameters
		{
			get
			{
				return false;
			}
		}

		/// <summary>Invokes the method or constructor represented by the current instance, using the specified parameters.</summary>
		/// <param name="obj">The object on which to invoke the method or constructor. If a method is static, this argument is ignored. If a constructor is static, this argument must be <see langword="null" /> or an instance of the class that defines the constructor.</param>
		/// <param name="parameters">An argument list for the invoked method or constructor. This is an array of objects with the same number, order, and type as the parameters of the method or constructor to be invoked. If there are no parameters, <paramref name="parameters" /> should be <see langword="null" />.If the method or constructor represented by this instance takes a <see langword="ref" /> parameter (<see langword="ByRef" /> in Visual Basic), no special attribute is required for that parameter in order to invoke the method or constructor using this function. Any object in this array that is not explicitly initialized with a value will contain the default value for that object type. For reference-type elements, this value is <see langword="null" />. For value-type elements, this value is 0, 0.0, or <see langword="false" />, depending on the specific element type. </param>
		/// <returns>An object containing the return value of the invoked method, or <see langword="null" /> in the case of a constructor.Elements of the <paramref name="parameters" /> array that represent parameters declared with the <see langword="ref" /> or <see langword="out" /> keyword may also be modified.</returns>
		/// <exception cref="T:System.Reflection.TargetException">
		///           In the .NET for Windows Store apps or the Portable Class Library, catch <see cref="T:System.Exception" /> instead.The <paramref name="obj" /> parameter is <see langword="null" /> and the method is not static.-or- The method is not declared or inherited by the class of <paramref name="obj" />. -or-A static constructor is invoked, and <paramref name="obj" /> is neither <see langword="null" /> nor an instance of the class that declared the constructor.</exception>
		/// <exception cref="T:System.ArgumentException">The elements of the <paramref name="parameters" />array do not match the signature of the method or constructor reflected by this instance. </exception>
		/// <exception cref="T:System.Reflection.TargetInvocationException">The invoked method or constructor throws an exception. -or-
		///         The current instance is a <see cref="T:System.Reflection.Emit.DynamicMethod" /> that contains unverifiable code. See the "Verification" section in Remarks for <see cref="T:System.Reflection.Emit.DynamicMethod" />.</exception>
		/// <exception cref="T:System.Reflection.TargetParameterCountException">The <paramref name="parameters" /> array does not have the correct number of arguments. </exception>
		/// <exception cref="T:System.MethodAccessException">
		///           In the .NET for Windows Store apps or the Portable Class Library, catch the base class exception, <see cref="T:System.MemberAccessException" />, instead.The caller does not have permission to execute the method or constructor that is represented by the current instance. </exception>
		/// <exception cref="T:System.InvalidOperationException">The type that declares the method is an open generic type. That is, the <see cref="P:System.Type.ContainsGenericParameters" /> property returns <see langword="true" /> for the declaring type.</exception>
		/// <exception cref="T:System.NotSupportedException">The current instance is a <see cref="T:System.Reflection.Emit.MethodBuilder" />.</exception>
		// Token: 0x06002149 RID: 8521 RVA: 0x0008A1CE File Offset: 0x000883CE
		[DebuggerHidden]
		[DebuggerStepThrough]
		public object Invoke(object obj, object[] parameters)
		{
			return this.Invoke(obj, BindingFlags.Default, null, parameters, null);
		}

		/// <summary>When overridden in a derived class, invokes the reflected method or constructor with the given parameters.</summary>
		/// <param name="obj">The object on which to invoke the method or constructor. If a method is static, this argument is ignored. If a constructor is static, this argument must be <see langword="null" /> or an instance of the class that defines the constructor.</param>
		/// <param name="invokeAttr">A bitmask that is a combination of 0 or more bit flags from <see cref="T:System.Reflection.BindingFlags" />. If <paramref name="binder" /> is <see langword="null" />, this parameter is assigned the value <see cref="F:System.Reflection.BindingFlags.Default" />; thus, whatever you pass in is ignored. </param>
		/// <param name="binder">An object that enables the binding, coercion of argument types, invocation of members, and retrieval of <see langword="MemberInfo" /> objects via reflection. If <paramref name="binder" /> is <see langword="null" />, the default binder is used. </param>
		/// <param name="parameters">An argument list for the invoked method or constructor. This is an array of objects with the same number, order, and type as the parameters of the method or constructor to be invoked. If there are no parameters, this should be <see langword="null" />.If the method or constructor represented by this instance takes a ByRef parameter, there is no special attribute required for that parameter in order to invoke the method or constructor using this function. Any object in this array that is not explicitly initialized with a value will contain the default value for that object type. For reference-type elements, this value is <see langword="null" />. For value-type elements, this value is 0, 0.0, or <see langword="false" />, depending on the specific element type. </param>
		/// <param name="culture">An instance of <see langword="CultureInfo" /> used to govern the coercion of types. If this is <see langword="null" />, the <see langword="CultureInfo" /> for the current thread is used. (This is necessary to convert a <see langword="String" /> that represents 1000 to a <see langword="Double" /> value, for example, since 1000 is represented differently by different cultures.) </param>
		/// <returns>An <see langword="Object" /> containing the return value of the invoked method, or <see langword="null" /> in the case of a constructor, or <see langword="null" /> if the method's return type is <see langword="void" />. Before calling the method or constructor, <see langword="Invoke" /> checks to see if the user has access permission and verifies that the parameters are valid.Elements of the <paramref name="parameters" /> array that represent parameters declared with the <see langword="ref" /> or <see langword="out" /> keyword may also be modified.</returns>
		/// <exception cref="T:System.Reflection.TargetException">The <paramref name="obj" /> parameter is <see langword="null" /> and the method is not static.-or- The method is not declared or inherited by the class of <paramref name="obj" />. -or-A static constructor is invoked, and <paramref name="obj" /> is neither <see langword="null" /> nor an instance of the class that declared the constructor.</exception>
		/// <exception cref="T:System.ArgumentException">The type of the <paramref name="parameters" /> parameter does not match the signature of the method or constructor reflected by this instance. </exception>
		/// <exception cref="T:System.Reflection.TargetParameterCountException">The <paramref name="parameters" /> array does not have the correct number of arguments. </exception>
		/// <exception cref="T:System.Reflection.TargetInvocationException">The invoked method or constructor throws an exception. </exception>
		/// <exception cref="T:System.MethodAccessException">The caller does not have permission to execute the method or constructor that is represented by the current instance. </exception>
		/// <exception cref="T:System.InvalidOperationException">The type that declares the method is an open generic type. That is, the <see cref="P:System.Type.ContainsGenericParameters" /> property returns <see langword="true" /> for the declaring type.</exception>
		// Token: 0x0600214A RID: 8522
		public abstract object Invoke(object obj, BindingFlags invokeAttr, Binder binder, object[] parameters, CultureInfo culture);

		/// <summary>Gets a handle to the internal metadata representation of a method.</summary>
		/// <returns>A <see cref="T:System.RuntimeMethodHandle" /> object.</returns>
		// Token: 0x17000438 RID: 1080
		// (get) Token: 0x0600214B RID: 8523
		public abstract RuntimeMethodHandle MethodHandle { get; }

		/// <summary>Gets a value that indicates whether the current method or constructor is security-critical or security-safe-critical at the current trust level, and therefore can perform critical operations. </summary>
		/// <returns>
		///     <see langword="true" /> if the current method or constructor is security-critical or security-safe-critical at the current trust level; <see langword="false" /> if it is transparent. </returns>
		// Token: 0x17000439 RID: 1081
		// (get) Token: 0x0600214C RID: 8524 RVA: 0x0002AC9D File Offset: 0x00028E9D
		public virtual bool IsSecurityCritical
		{
			get
			{
				throw NotImplemented.ByDesign;
			}
		}

		/// <summary>Returns a value that indicates whether this instance is equal to a specified object.</summary>
		/// <param name="obj">An object to compare with this instance, or <see langword="null" />.</param>
		/// <returns>
		///     <see langword="true" /> if <paramref name="obj" /> equals the type and value of this instance; otherwise, <see langword="false" />.</returns>
		// Token: 0x0600214D RID: 8525 RVA: 0x00089BF8 File Offset: 0x00087DF8
		public override bool Equals(object obj)
		{
			return base.Equals(obj);
		}

		/// <summary>Returns the hash code for this instance.</summary>
		/// <returns>A 32-bit signed integer hash code.</returns>
		// Token: 0x0600214E RID: 8526 RVA: 0x00089C01 File Offset: 0x00087E01
		public override int GetHashCode()
		{
			return base.GetHashCode();
		}

		/// <summary>Indicates whether two <see cref="T:System.Reflection.MethodBase" /> objects are equal.</summary>
		/// <param name="left">The first object to compare.</param>
		/// <param name="right">The second object to compare.</param>
		/// <returns>
		///     <see langword="true" /> if <paramref name="left" /> is equal to <paramref name="right" />; otherwise, <see langword="false" />.</returns>
		// Token: 0x0600214F RID: 8527 RVA: 0x0008A1DC File Offset: 0x000883DC
		public static bool operator ==(MethodBase left, MethodBase right)
		{
			if (left == right)
			{
				return true;
			}
			if (left == null || right == null)
			{
				return false;
			}
			MethodInfo left2;
			MethodInfo right2;
			if ((left2 = (left as MethodInfo)) != null && (right2 = (right as MethodInfo)) != null)
			{
				return left2 == right2;
			}
			ConstructorInfo left3;
			ConstructorInfo right3;
			return (left3 = (left as ConstructorInfo)) != null && (right3 = (right as ConstructorInfo)) != null && left3 == right3;
		}

		/// <summary>Indicates whether two <see cref="T:System.Reflection.MethodBase" /> objects are not equal.</summary>
		/// <param name="left">The first object to compare.</param>
		/// <param name="right">The second object to compare.</param>
		/// <returns>
		///     <see langword="true" /> if <paramref name="left" /> is not equal to <paramref name="right" />; otherwise, <see langword="false" />.</returns>
		// Token: 0x06002150 RID: 8528 RVA: 0x0008A248 File Offset: 0x00088448
		public static bool operator !=(MethodBase left, MethodBase right)
		{
			return !(left == right);
		}

		// Token: 0x06002151 RID: 8529 RVA: 0x0008A254 File Offset: 0x00088454
		internal virtual ParameterInfo[] GetParametersInternal()
		{
			return this.GetParameters();
		}

		// Token: 0x06002152 RID: 8530 RVA: 0x0008A25C File Offset: 0x0008845C
		internal virtual int GetParametersCount()
		{
			return this.GetParametersInternal().Length;
		}

		// Token: 0x06002153 RID: 8531 RVA: 0x0008A266 File Offset: 0x00088466
		internal virtual int get_next_table_index(object obj, int table, int count)
		{
			if (this is MethodBuilder)
			{
				return ((MethodBuilder)this).get_next_table_index(obj, table, count);
			}
			if (this is ConstructorBuilder)
			{
				return ((ConstructorBuilder)this).get_next_table_index(obj, table, count);
			}
			throw new Exception("Method is not a builder method");
		}

		// Token: 0x06002154 RID: 8532 RVA: 0x0008A2A0 File Offset: 0x000884A0
		internal virtual string FormatNameAndSig(bool serialization)
		{
			StringBuilder stringBuilder = new StringBuilder(this.Name);
			stringBuilder.Append("(");
			stringBuilder.Append(MethodBase.ConstructParameters(this.GetParameterTypes(), this.CallingConvention, serialization));
			stringBuilder.Append(")");
			return stringBuilder.ToString();
		}

		// Token: 0x06002155 RID: 8533 RVA: 0x0008A2F0 File Offset: 0x000884F0
		internal virtual Type[] GetParameterTypes()
		{
			ParameterInfo[] parametersNoCopy = this.GetParametersNoCopy();
			Type[] array = new Type[parametersNoCopy.Length];
			for (int i = 0; i < parametersNoCopy.Length; i++)
			{
				array[i] = parametersNoCopy[i].ParameterType;
			}
			return array;
		}

		// Token: 0x06002156 RID: 8534 RVA: 0x0008A254 File Offset: 0x00088454
		internal virtual ParameterInfo[] GetParametersNoCopy()
		{
			return this.GetParameters();
		}

		/// <summary>Gets method information by using the method's internal metadata representation (handle).</summary>
		/// <param name="handle">The method's handle. </param>
		/// <returns>A <see langword="MethodBase" /> containing information about the method.</returns>
		/// <exception cref="T:System.ArgumentException">
		///         <paramref name="handle" /> is invalid.</exception>
		// Token: 0x06002157 RID: 8535 RVA: 0x0008A328 File Offset: 0x00088528
		public static MethodBase GetMethodFromHandle(RuntimeMethodHandle handle)
		{
			if (handle.IsNullHandle())
			{
				throw new ArgumentException(Environment.GetResourceString("The handle is invalid."));
			}
			MethodBase methodFromHandleInternalType = RuntimeMethodInfo.GetMethodFromHandleInternalType(handle.Value, IntPtr.Zero);
			if (methodFromHandleInternalType == null)
			{
				throw new ArgumentException("The handle is invalid.");
			}
			Type declaringType = methodFromHandleInternalType.DeclaringType;
			if (declaringType != null && declaringType.IsGenericType)
			{
				throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, Environment.GetResourceString("Cannot resolve method {0} because the declaring type of the method handle {1} is generic. Explicitly provide the declaring type to GetMethodFromHandle."), methodFromHandleInternalType, declaringType.GetGenericTypeDefinition()));
			}
			return methodFromHandleInternalType;
		}

		/// <summary>Gets a <see cref="T:System.Reflection.MethodBase" /> object for the constructor or method represented by the specified handle, for the specified generic type.</summary>
		/// <param name="handle">A handle to the internal metadata representation of a constructor or method.</param>
		/// <param name="declaringType">A handle to the generic type that defines the constructor or method.</param>
		/// <returns>A <see cref="T:System.Reflection.MethodBase" /> object representing the method or constructor specified by <paramref name="handle" />, in the generic type specified by <paramref name="declaringType" />.</returns>
		/// <exception cref="T:System.ArgumentException">
		///         <paramref name="handle" /> is invalid.</exception>
		// Token: 0x06002158 RID: 8536 RVA: 0x0008A3B0 File Offset: 0x000885B0
		[ComVisible(false)]
		public static MethodBase GetMethodFromHandle(RuntimeMethodHandle handle, RuntimeTypeHandle declaringType)
		{
			if (handle.IsNullHandle())
			{
				throw new ArgumentException(Environment.GetResourceString("The handle is invalid."));
			}
			MethodBase methodFromHandleInternalType = RuntimeMethodInfo.GetMethodFromHandleInternalType(handle.Value, declaringType.Value);
			if (methodFromHandleInternalType == null)
			{
				throw new ArgumentException("The handle is invalid.");
			}
			return methodFromHandleInternalType;
		}

		// Token: 0x06002159 RID: 8537 RVA: 0x0008A400 File Offset: 0x00088600
		internal static string ConstructParameters(Type[] parameterTypes, CallingConventions callingConvention, bool serialization)
		{
			StringBuilder stringBuilder = new StringBuilder();
			string value = "";
			foreach (Type type in parameterTypes)
			{
				stringBuilder.Append(value);
				string text = type.FormatTypeName(serialization);
				if (type.IsByRef && !serialization)
				{
					stringBuilder.Append(text.TrimEnd(new char[]
					{
						'&'
					}));
					stringBuilder.Append(" ByRef");
				}
				else
				{
					stringBuilder.Append(text);
				}
				value = ", ";
			}
			if ((callingConvention & CallingConventions.VarArgs) == CallingConventions.VarArgs)
			{
				stringBuilder.Append(value);
				stringBuilder.Append("...");
			}
			return stringBuilder.ToString();
		}
	}
}
