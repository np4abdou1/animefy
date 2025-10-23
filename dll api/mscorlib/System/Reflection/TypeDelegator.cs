﻿using System;
using System.Globalization;

namespace System.Reflection
{
	/// <summary>Wraps a <see cref="T:System.Type" /> object and delegates methods to that <see langword="Type" />.</summary>
	// Token: 0x020004C3 RID: 1219
	public class TypeDelegator : TypeInfo
	{
		/// <summary>Returns a value that indicates whether the specified type can be assigned to this type.</summary>
		/// <param name="typeInfo">The type to check.</param>
		/// <returns>
		///     <see langword="true" /> if the specified type can be assigned to this type; otherwise, <see langword="false" />.</returns>
		// Token: 0x06002258 RID: 8792 RVA: 0x00036AFD File Offset: 0x00034CFD
		public override bool IsAssignableFrom(TypeInfo typeInfo)
		{
			return !(typeInfo == null) && this.IsAssignableFrom(typeInfo.AsType());
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Reflection.TypeDelegator" /> class specifying the encapsulating instance.</summary>
		/// <param name="delegatingType">The instance of the class <see cref="T:System.Type" /> that encapsulates the call to the method of an object. </param>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="delegatingType" /> is <see langword="null" />. </exception>
		// Token: 0x06002259 RID: 8793 RVA: 0x0008B06E File Offset: 0x0008926E
		public TypeDelegator(Type delegatingType)
		{
			if (delegatingType == null)
			{
				throw new ArgumentNullException("delegatingType");
			}
			this.typeImpl = delegatingType;
		}

		/// <summary>Gets the GUID (globally unique identifier) of the implemented type.</summary>
		/// <returns>A GUID.</returns>
		// Token: 0x17000494 RID: 1172
		// (get) Token: 0x0600225A RID: 8794 RVA: 0x0008B091 File Offset: 0x00089291
		public override Guid GUID
		{
			get
			{
				return this.typeImpl.GUID;
			}
		}

		/// <summary>Gets a value that identifies this entity in metadata.</summary>
		/// <returns>A value which, in combination with the module, uniquely identifies this entity in metadata.</returns>
		// Token: 0x17000495 RID: 1173
		// (get) Token: 0x0600225B RID: 8795 RVA: 0x0008B09E File Offset: 0x0008929E
		public override int MetadataToken
		{
			get
			{
				return this.typeImpl.MetadataToken;
			}
		}

		/// <summary>Invokes the specified member. The method that is to be invoked must be accessible and provide the most specific match with the specified argument list, under the constraints of the specified binder and invocation attributes.</summary>
		/// <param name="name">The name of the member to invoke. This may be a constructor, method, property, or field. If an empty string ("") is passed, the default member is invoked. </param>
		/// <param name="invokeAttr">The invocation attribute. This must be one of the following <see cref="T:System.Reflection.BindingFlags" /> : <see langword="InvokeMethod" />, <see langword="CreateInstance" />, <see langword="Static" />, <see langword="GetField" />, <see langword="SetField" />, <see langword="GetProperty" />, or <see langword="SetProperty" />. A suitable invocation attribute must be specified. If a static member is to be invoked, the <see langword="Static" /> flag must be set. </param>
		/// <param name="binder">An object that enables the binding, coercion of argument types, invocation of members, and retrieval of <see langword="MemberInfo" /> objects via reflection. If <paramref name="binder" /> is <see langword="null" />, the default binder is used. See <see cref="T:System.Reflection.Binder" />. </param>
		/// <param name="target">The object on which to invoke the specified member. </param>
		/// <param name="args">An array of type <see langword="Object" /> that contains the number, order, and type of the parameters of the member to be invoked. If <paramref name="args" /> contains an uninitialized <see langword="Object" />, it is treated as empty, which, with the default binder, can be widened to 0, 0.0 or a string. </param>
		/// <param name="modifiers">An array of type <see langword="ParameterModifer" /> that is the same length as <paramref name="args" />, with elements that represent the attributes associated with the arguments of the member to be invoked. A parameter has attributes associated with it in the member's signature. For ByRef, use <see langword="ParameterModifer.ByRef" />, and for none, use <see langword="ParameterModifer.None" />. The default binder does exact matching on these. Attributes such as <see langword="In" /> and <see langword="InOut" /> are not used in binding, and can be viewed using <see langword="ParameterInfo" />. </param>
		/// <param name="culture">An instance of <see langword="CultureInfo" /> used to govern the coercion of types. This is necessary, for example, to convert a string that represents 1000 to a <see langword="Double" /> value, since 1000 is represented differently by different cultures. If <paramref name="culture" /> is <see langword="null" />, the <see langword="CultureInfo" /> for the current thread's <see langword="CultureInfo" /> is used. </param>
		/// <param name="namedParameters">An array of type <see langword="String" /> containing parameter names that match up, starting at element zero, with the <paramref name="args" /> array. There must be no holes in the array. If <paramref name="args" />. <see langword="Length" /> is greater than <paramref name="namedParameters" />. <see langword="Length" />, the remaining parameters are filled in order. </param>
		/// <returns>An <see langword="Object" /> representing the return value of the invoked member.</returns>
		// Token: 0x0600225C RID: 8796 RVA: 0x0008B0AC File Offset: 0x000892AC
		public override object InvokeMember(string name, BindingFlags invokeAttr, Binder binder, object target, object[] args, ParameterModifier[] modifiers, CultureInfo culture, string[] namedParameters)
		{
			return this.typeImpl.InvokeMember(name, invokeAttr, binder, target, args, modifiers, culture, namedParameters);
		}

		/// <summary>Gets the module that contains the implemented type.</summary>
		/// <returns>A <see cref="T:System.Reflection.Module" /> object representing the module of the implemented type.</returns>
		// Token: 0x17000496 RID: 1174
		// (get) Token: 0x0600225D RID: 8797 RVA: 0x0008B0D1 File Offset: 0x000892D1
		public override Module Module
		{
			get
			{
				return this.typeImpl.Module;
			}
		}

		/// <summary>Gets the assembly of the implemented type.</summary>
		/// <returns>An <see cref="T:System.Reflection.Assembly" /> object representing the assembly of the implemented type.</returns>
		// Token: 0x17000497 RID: 1175
		// (get) Token: 0x0600225E RID: 8798 RVA: 0x0008B0DE File Offset: 0x000892DE
		public override Assembly Assembly
		{
			get
			{
				return this.typeImpl.Assembly;
			}
		}

		/// <summary>Gets a handle to the internal metadata representation of an implemented type.</summary>
		/// <returns>A <see langword="RuntimeTypeHandle" /> object.</returns>
		// Token: 0x17000498 RID: 1176
		// (get) Token: 0x0600225F RID: 8799 RVA: 0x0008B0EB File Offset: 0x000892EB
		public override RuntimeTypeHandle TypeHandle
		{
			get
			{
				return this.typeImpl.TypeHandle;
			}
		}

		/// <summary>Gets the name of the implemented type, with the path removed.</summary>
		/// <returns>A <see langword="String" /> containing the type's non-qualified name.</returns>
		// Token: 0x17000499 RID: 1177
		// (get) Token: 0x06002260 RID: 8800 RVA: 0x0008B0F8 File Offset: 0x000892F8
		public override string Name
		{
			get
			{
				return this.typeImpl.Name;
			}
		}

		/// <summary>Gets the fully qualified name of the implemented type.</summary>
		/// <returns>A <see langword="String" /> containing the type's fully qualified name.</returns>
		// Token: 0x1700049A RID: 1178
		// (get) Token: 0x06002261 RID: 8801 RVA: 0x0008B105 File Offset: 0x00089305
		public override string FullName
		{
			get
			{
				return this.typeImpl.FullName;
			}
		}

		/// <summary>Gets the namespace of the implemented type.</summary>
		/// <returns>A <see langword="String" /> containing the type's namespace.</returns>
		// Token: 0x1700049B RID: 1179
		// (get) Token: 0x06002262 RID: 8802 RVA: 0x0008B112 File Offset: 0x00089312
		public override string Namespace
		{
			get
			{
				return this.typeImpl.Namespace;
			}
		}

		/// <summary>Gets the assembly's fully qualified name.</summary>
		/// <returns>A <see langword="String" /> containing the assembly's fully qualified name.</returns>
		// Token: 0x1700049C RID: 1180
		// (get) Token: 0x06002263 RID: 8803 RVA: 0x0008B11F File Offset: 0x0008931F
		public override string AssemblyQualifiedName
		{
			get
			{
				return this.typeImpl.AssemblyQualifiedName;
			}
		}

		/// <summary>Gets the base type for the current type.</summary>
		/// <returns>The base type for a type.</returns>
		// Token: 0x1700049D RID: 1181
		// (get) Token: 0x06002264 RID: 8804 RVA: 0x0008B12C File Offset: 0x0008932C
		public override Type BaseType
		{
			get
			{
				return this.typeImpl.BaseType;
			}
		}

		/// <summary>Gets the constructor that implemented the <see langword="TypeDelegator" />.</summary>
		/// <param name="bindingAttr">A bitmask that affects the way in which the search is conducted. The value is a combination of zero or more bit flags from <see cref="T:System.Reflection.BindingFlags" />. </param>
		/// <param name="binder">An object that enables the binding, coercion of argument types, invocation of members, and retrieval of <see langword="MemberInfo" /> objects using reflection. If <paramref name="binder" /> is <see langword="null" />, the default binder is used. </param>
		/// <param name="callConvention">The calling conventions. </param>
		/// <param name="types">An array of type <see langword="Type" /> containing a list of the parameter number, order, and types. Types cannot be <see langword="null" />; use an appropriate <see langword="GetMethod" /> method or an empty array to search for a method without parameters. </param>
		/// <param name="modifiers">An array of type <see langword="ParameterModifier" /> having the same length as the <paramref name="types" /> array, whose elements represent the attributes associated with the parameters of the method to get. </param>
		/// <returns>A <see langword="ConstructorInfo" /> object for the method that matches the specified criteria, or <see langword="null" /> if a match cannot be found.</returns>
		// Token: 0x06002265 RID: 8805 RVA: 0x0008B139 File Offset: 0x00089339
		protected override ConstructorInfo GetConstructorImpl(BindingFlags bindingAttr, Binder binder, CallingConventions callConvention, Type[] types, ParameterModifier[] modifiers)
		{
			return this.typeImpl.GetConstructor(bindingAttr, binder, callConvention, types, modifiers);
		}

		/// <summary>Returns an array of <see cref="T:System.Reflection.ConstructorInfo" /> objects representing constructors defined for the type wrapped by the current <see cref="T:System.Reflection.TypeDelegator" />.</summary>
		/// <param name="bindingAttr">A bitmask that affects the way in which the search is conducted. The value is a combination of zero or more bit flags from <see cref="T:System.Reflection.BindingFlags" />. </param>
		/// <returns>An array of type <see langword="ConstructorInfo" /> containing the specified constructors defined for this class. If no constructors are defined, an empty array is returned. Depending on the value of a specified parameter, only public constructors or both public and non-public constructors will be returned.</returns>
		// Token: 0x06002266 RID: 8806 RVA: 0x0008B14D File Offset: 0x0008934D
		public override ConstructorInfo[] GetConstructors(BindingFlags bindingAttr)
		{
			return this.typeImpl.GetConstructors(bindingAttr);
		}

		/// <summary>Searches for the specified method whose parameters match the specified argument types and modifiers, using the specified binding constraints and the specified calling convention.</summary>
		/// <param name="name">The method name. </param>
		/// <param name="bindingAttr">A bitmask that affects the way in which the search is conducted. The value is a combination of zero or more bit flags from <see cref="T:System.Reflection.BindingFlags" />. </param>
		/// <param name="binder">An object that enables the binding, coercion of argument types, invocation of members, and retrieval of <see langword="MemberInfo" /> objects using reflection. If <paramref name="binder" /> is <see langword="null" />, the default binder is used. </param>
		/// <param name="callConvention">The calling conventions. </param>
		/// <param name="types">An array of type <see langword="Type" /> containing a list of the parameter number, order, and types. Types cannot be <see langword="null" />; use an appropriate <see langword="GetMethod" /> method or an empty array to search for a method without parameters. </param>
		/// <param name="modifiers">An array of type <see langword="ParameterModifier" /> having the same length as the <paramref name="types" /> array, whose elements represent the attributes associated with the parameters of the method to get. </param>
		/// <returns>A <see langword="MethodInfoInfo" /> object for the implementation method that matches the specified criteria, or <see langword="null" /> if a match cannot be found.</returns>
		// Token: 0x06002267 RID: 8807 RVA: 0x0008B15B File Offset: 0x0008935B
		protected override MethodInfo GetMethodImpl(string name, BindingFlags bindingAttr, Binder binder, CallingConventions callConvention, Type[] types, ParameterModifier[] modifiers)
		{
			if (types == null)
			{
				return this.typeImpl.GetMethod(name, bindingAttr);
			}
			return this.typeImpl.GetMethod(name, bindingAttr, binder, callConvention, types, modifiers);
		}

		/// <summary>Returns an array of <see cref="T:System.Reflection.MethodInfo" /> objects representing specified methods of the type wrapped by the current <see cref="T:System.Reflection.TypeDelegator" />.</summary>
		/// <param name="bindingAttr">A bitmask that affects the way in which the search is conducted. The value is a combination of zero or more bit flags from <see cref="T:System.Reflection.BindingFlags" />. </param>
		/// <returns>An array of <see langword="MethodInfo" /> objects representing the methods defined on this <see langword="TypeDelegator" />.</returns>
		// Token: 0x06002268 RID: 8808 RVA: 0x0008B183 File Offset: 0x00089383
		public override MethodInfo[] GetMethods(BindingFlags bindingAttr)
		{
			return this.typeImpl.GetMethods(bindingAttr);
		}

		/// <summary>Returns a <see cref="T:System.Reflection.FieldInfo" /> object representing the field with the specified name.</summary>
		/// <param name="name">The name of the field to find. </param>
		/// <param name="bindingAttr">A bitmask that affects the way in which the search is conducted. The value is a combination of zero or more bit flags from <see cref="T:System.Reflection.BindingFlags" />. </param>
		/// <returns>A <see langword="FieldInfo" /> object representing the field declared or inherited by this <see langword="TypeDelegator" /> with the specified name. Returns <see langword="null" /> if no such field is found.</returns>
		/// <exception cref="T:System.ArgumentNullException">The <paramref name="name" /> parameter is <see langword="null" />. </exception>
		// Token: 0x06002269 RID: 8809 RVA: 0x0008B191 File Offset: 0x00089391
		public override FieldInfo GetField(string name, BindingFlags bindingAttr)
		{
			return this.typeImpl.GetField(name, bindingAttr);
		}

		/// <summary>Returns an array of <see cref="T:System.Reflection.FieldInfo" /> objects representing the data fields defined for the type wrapped by the current <see cref="T:System.Reflection.TypeDelegator" />.</summary>
		/// <param name="bindingAttr">A bitmask that affects the way in which the search is conducted. The value is a combination of zero or more bit flags from <see cref="T:System.Reflection.BindingFlags" />. </param>
		/// <returns>An array of type <see langword="FieldInfo" /> containing the fields declared or inherited by the current <see langword="TypeDelegator" />. An empty array is returned if there are no matched fields.</returns>
		// Token: 0x0600226A RID: 8810 RVA: 0x0008B1A0 File Offset: 0x000893A0
		public override FieldInfo[] GetFields(BindingFlags bindingAttr)
		{
			return this.typeImpl.GetFields(bindingAttr);
		}

		/// <summary>Returns all the interfaces implemented on the current class and its base classes.</summary>
		/// <returns>An array of type <see langword="Type" /> containing all the interfaces implemented on the current class and its base classes. If none are defined, an empty array is returned.</returns>
		// Token: 0x0600226B RID: 8811 RVA: 0x0008B1AE File Offset: 0x000893AE
		public override Type[] GetInterfaces()
		{
			return this.typeImpl.GetInterfaces();
		}

		/// <summary>Returns the specified event.</summary>
		/// <param name="name">The name of the event to get. </param>
		/// <param name="bindingAttr">A bitmask that affects the way in which the search is conducted. The value is a combination of zero or more bit flags from <see cref="T:System.Reflection.BindingFlags" />. </param>
		/// <returns>An <see cref="T:System.Reflection.EventInfo" /> object representing the event declared or inherited by this type with the specified name. This method returns <see langword="null" /> if no such event is found.</returns>
		/// <exception cref="T:System.ArgumentNullException">The <paramref name="name" /> parameter is <see langword="null" />. </exception>
		// Token: 0x0600226C RID: 8812 RVA: 0x0008B1BB File Offset: 0x000893BB
		public override EventInfo GetEvent(string name, BindingFlags bindingAttr)
		{
			return this.typeImpl.GetEvent(name, bindingAttr);
		}

		/// <summary>When overridden in a derived class, searches for the specified property whose parameters match the specified argument types and modifiers, using the specified binding constraints.</summary>
		/// <param name="name">The property to get. </param>
		/// <param name="bindingAttr">A bitmask that affects the way in which the search is conducted. The value is a combination of zero or more bit flags from <see cref="T:System.Reflection.BindingFlags" />. </param>
		/// <param name="binder">An object that enables the binding, coercion of argument types, invocation of members, and retrieval of <see langword="MemberInfo" /> objects via reflection. If <paramref name="binder" /> is <see langword="null" />, the default binder is used. See <see cref="T:System.Reflection.Binder" />. </param>
		/// <param name="returnType">The return type of the property. </param>
		/// <param name="types">A list of parameter types. The list represents the number, order, and types of the parameters. Types cannot be null; use an appropriate <see langword="GetMethod" /> method or an empty array to search for a method without parameters. </param>
		/// <param name="modifiers">An array of the same length as types with elements that represent the attributes associated with the parameters of the method to get. </param>
		/// <returns>A <see cref="T:System.Reflection.PropertyInfo" /> object for the property that matches the specified criteria, or null if a match cannot be found.</returns>
		// Token: 0x0600226D RID: 8813 RVA: 0x0008B1CA File Offset: 0x000893CA
		protected override PropertyInfo GetPropertyImpl(string name, BindingFlags bindingAttr, Binder binder, Type returnType, Type[] types, ParameterModifier[] modifiers)
		{
			if (returnType == null && types == null)
			{
				return this.typeImpl.GetProperty(name, bindingAttr);
			}
			return this.typeImpl.GetProperty(name, bindingAttr, binder, returnType, types, modifiers);
		}

		/// <summary>Returns an array of <see cref="T:System.Reflection.PropertyInfo" /> objects representing properties of the type wrapped by the current <see cref="T:System.Reflection.TypeDelegator" />.</summary>
		/// <param name="bindingAttr">A bitmask that affects the way in which the search is conducted. The value is a combination of zero or more bit flags from <see cref="T:System.Reflection.BindingFlags" />. </param>
		/// <returns>An array of <see langword="PropertyInfo" /> objects representing properties defined on this <see langword="TypeDelegator" />.</returns>
		// Token: 0x0600226E RID: 8814 RVA: 0x0008B1FC File Offset: 0x000893FC
		public override PropertyInfo[] GetProperties(BindingFlags bindingAttr)
		{
			return this.typeImpl.GetProperties(bindingAttr);
		}

		/// <summary>Returns the events specified in <paramref name="bindingAttr" /> that are declared or inherited by the current <see langword="TypeDelegator" />.</summary>
		/// <param name="bindingAttr">A bitmask that affects the way in which the search is conducted. The value is a combination of zero or more bit flags from <see cref="T:System.Reflection.BindingFlags" />. </param>
		/// <returns>An array of type <see langword="EventInfo" /> containing the events specified in <paramref name="bindingAttr" />. If there are no events, an empty array is returned.</returns>
		// Token: 0x0600226F RID: 8815 RVA: 0x0008B20A File Offset: 0x0008940A
		public override EventInfo[] GetEvents(BindingFlags bindingAttr)
		{
			return this.typeImpl.GetEvents(bindingAttr);
		}

		/// <summary>Returns a nested type specified by <paramref name="name" /> and in <paramref name="bindingAttr" /> that are declared or inherited by the type represented by the current <see cref="T:System.Reflection.TypeDelegator" />.</summary>
		/// <param name="name">The nested type's name. </param>
		/// <param name="bindingAttr">A bitmask that affects the way in which the search is conducted. The value is a combination of zero or more bit flags from <see cref="T:System.Reflection.BindingFlags" />. </param>
		/// <returns>A <see langword="Type" /> object representing the nested type.</returns>
		/// <exception cref="T:System.ArgumentNullException">The <paramref name="name" /> parameter is <see langword="null" />. </exception>
		// Token: 0x06002270 RID: 8816 RVA: 0x0008B218 File Offset: 0x00089418
		public override Type GetNestedType(string name, BindingFlags bindingAttr)
		{
			return this.typeImpl.GetNestedType(name, bindingAttr);
		}

		/// <summary>Returns members (properties, methods, constructors, fields, events, and nested types) specified by the given <paramref name="name" />, <paramref name="type" />, and <paramref name="bindingAttr" />.</summary>
		/// <param name="name">The name of the member to get. </param>
		/// <param name="type">A bitmask that affects the way in which the search is conducted. The value is a combination of zero or more bit flags from <see cref="T:System.Reflection.BindingFlags" />. </param>
		/// <param name="bindingAttr">The type of members to get. </param>
		/// <returns>An array of type <see langword="MemberInfo" /> containing all the members of the current class and its base class meeting the specified criteria.</returns>
		/// <exception cref="T:System.ArgumentNullException">The <paramref name="name" /> parameter is <see langword="null" />. </exception>
		// Token: 0x06002271 RID: 8817 RVA: 0x0008B227 File Offset: 0x00089427
		public override MemberInfo[] GetMember(string name, MemberTypes type, BindingFlags bindingAttr)
		{
			return this.typeImpl.GetMember(name, type, bindingAttr);
		}

		/// <summary>Gets the attributes assigned to the <see langword="TypeDelegator" />.</summary>
		/// <returns>A <see langword="TypeAttributes" /> object representing the implementation attribute flags.</returns>
		// Token: 0x06002272 RID: 8818 RVA: 0x0008B237 File Offset: 0x00089437
		protected override TypeAttributes GetAttributeFlagsImpl()
		{
			return this.typeImpl.Attributes;
		}

		// Token: 0x1700049E RID: 1182
		// (get) Token: 0x06002273 RID: 8819 RVA: 0x0008B244 File Offset: 0x00089444
		public override bool IsSZArray
		{
			get
			{
				return this.typeImpl.IsSZArray;
			}
		}

		/// <summary>Returns a value that indicates whether the <see cref="T:System.Type" /> is an array.</summary>
		/// <returns>
		///     <see langword="true" /> if the <see cref="T:System.Type" /> is an array; otherwise, <see langword="false" />.</returns>
		// Token: 0x06002274 RID: 8820 RVA: 0x0008B251 File Offset: 0x00089451
		protected override bool IsArrayImpl()
		{
			return this.typeImpl.IsArray;
		}

		/// <summary>Returns a value that indicates whether the <see cref="T:System.Type" /> is one of the primitive types.</summary>
		/// <returns>
		///     <see langword="true" /> if the <see cref="T:System.Type" /> is one of the primitive types; otherwise, <see langword="false" />.</returns>
		// Token: 0x06002275 RID: 8821 RVA: 0x0008B25E File Offset: 0x0008945E
		protected override bool IsPrimitiveImpl()
		{
			return this.typeImpl.IsPrimitive;
		}

		/// <summary>Returns a value that indicates whether the <see cref="T:System.Type" /> is passed by reference.</summary>
		/// <returns>
		///     <see langword="true" /> if the <see cref="T:System.Type" /> is passed by reference; otherwise, <see langword="false" />.</returns>
		// Token: 0x06002276 RID: 8822 RVA: 0x0008B26B File Offset: 0x0008946B
		protected override bool IsByRefImpl()
		{
			return this.typeImpl.IsByRef;
		}

		// Token: 0x1700049F RID: 1183
		// (get) Token: 0x06002277 RID: 8823 RVA: 0x0008B278 File Offset: 0x00089478
		public override bool IsGenericMethodParameter
		{
			get
			{
				return this.typeImpl.IsGenericMethodParameter;
			}
		}

		/// <summary>Returns a value that indicates whether the <see cref="T:System.Type" /> is a pointer.</summary>
		/// <returns>
		///     <see langword="true" /> if the <see cref="T:System.Type" /> is a pointer; otherwise, <see langword="false" />.</returns>
		// Token: 0x06002278 RID: 8824 RVA: 0x0008B285 File Offset: 0x00089485
		protected override bool IsPointerImpl()
		{
			return this.typeImpl.IsPointer;
		}

		/// <summary>Returns a value that indicates whether the type is a value type; that is, not a class or an interface.</summary>
		/// <returns>
		///     <see langword="true" /> if the type is a value type; otherwise, <see langword="false" />.</returns>
		// Token: 0x06002279 RID: 8825 RVA: 0x0008B292 File Offset: 0x00089492
		protected override bool IsValueTypeImpl()
		{
			return this.typeImpl.IsValueType;
		}

		/// <summary>Returns a value that indicates whether the <see cref="T:System.Type" /> is a COM object.</summary>
		/// <returns>
		///     <see langword="true" /> if the <see cref="T:System.Type" /> is a COM object; otherwise, <see langword="false" />.</returns>
		// Token: 0x0600227A RID: 8826 RVA: 0x0008B29F File Offset: 0x0008949F
		protected override bool IsCOMObjectImpl()
		{
			return this.typeImpl.IsCOMObject;
		}

		/// <summary>Gets a value that indicates whether this object represents a constructed generic type.</summary>
		/// <returns>
		///     <see langword="true" /> if this object represents a constructed generic type; otherwise, <see langword="false" />.</returns>
		// Token: 0x170004A0 RID: 1184
		// (get) Token: 0x0600227B RID: 8827 RVA: 0x0008B2AC File Offset: 0x000894AC
		public override bool IsConstructedGenericType
		{
			get
			{
				return this.typeImpl.IsConstructedGenericType;
			}
		}

		// Token: 0x170004A1 RID: 1185
		// (get) Token: 0x0600227C RID: 8828 RVA: 0x0008B2B9 File Offset: 0x000894B9
		public override bool IsCollectible
		{
			get
			{
				return this.typeImpl.IsCollectible;
			}
		}

		/// <summary>Returns the <see cref="T:System.Type" /> of the object encompassed or referred to by the current array, pointer or ByRef.</summary>
		/// <returns>The <see cref="T:System.Type" /> of the object encompassed or referred to by the current array, pointer or <see langword="ByRef" />, or <see langword="null" /> if the current <see cref="T:System.Type" /> is not an array, a pointer or a <see langword="ByRef" />.</returns>
		// Token: 0x0600227D RID: 8829 RVA: 0x0008B2C6 File Offset: 0x000894C6
		public override Type GetElementType()
		{
			return this.typeImpl.GetElementType();
		}

		/// <summary>Gets a value indicating whether the current <see cref="T:System.Type" /> encompasses or refers to another type; that is, whether the current <see cref="T:System.Type" /> is an array, a pointer or a ByRef.</summary>
		/// <returns>
		///     <see langword="true" /> if the <see cref="T:System.Type" /> is an array, a pointer or a ByRef; otherwise, <see langword="false" />.</returns>
		// Token: 0x0600227E RID: 8830 RVA: 0x0008B2D3 File Offset: 0x000894D3
		protected override bool HasElementTypeImpl()
		{
			return this.typeImpl.HasElementType;
		}

		/// <summary>Gets the underlying <see cref="T:System.Type" /> that represents the implemented type.</summary>
		/// <returns>The underlying type.</returns>
		// Token: 0x170004A2 RID: 1186
		// (get) Token: 0x0600227F RID: 8831 RVA: 0x0008B2E0 File Offset: 0x000894E0
		public override Type UnderlyingSystemType
		{
			get
			{
				return this.typeImpl.UnderlyingSystemType;
			}
		}

		/// <summary>Returns all the custom attributes defined for this type, specifying whether to search the type's inheritance chain.</summary>
		/// <param name="inherit">Specifies whether to search this type's inheritance chain to find the attributes. </param>
		/// <returns>An array of objects containing all the custom attributes defined for this type.</returns>
		/// <exception cref="T:System.TypeLoadException">A custom attribute type cannot be loaded. </exception>
		// Token: 0x06002280 RID: 8832 RVA: 0x0008B2ED File Offset: 0x000894ED
		public override object[] GetCustomAttributes(bool inherit)
		{
			return this.typeImpl.GetCustomAttributes(inherit);
		}

		/// <summary>Returns an array of custom attributes identified by type.</summary>
		/// <param name="attributeType">An array of custom attributes identified by type.</param>
		/// <param name="inherit">Specifies whether to search this type's inheritance chain to find the attributes. </param>
		/// <returns>An array of objects containing the custom attributes defined in this type that match the <paramref name="attributeType" /> parameter, specifying whether to search the type's inheritance chain, or <see langword="null" /> if no custom attributes are defined on this type.</returns>
		/// <exception cref="T:System.ArgumentException">
		///         <paramref name="attributeType" /> is <see langword="null" />. </exception>
		/// <exception cref="T:System.TypeLoadException">A custom attribute type cannot be loaded. </exception>
		// Token: 0x06002281 RID: 8833 RVA: 0x0008B2FB File Offset: 0x000894FB
		public override object[] GetCustomAttributes(Type attributeType, bool inherit)
		{
			return this.typeImpl.GetCustomAttributes(attributeType, inherit);
		}

		/// <summary>Indicates whether a custom attribute identified by <paramref name="attributeType" /> is defined.</summary>
		/// <param name="attributeType">Specifies whether to search this type's inheritance chain to find the attributes. </param>
		/// <param name="inherit">An array of custom attributes identified by type. </param>
		/// <returns>
		///     <see langword="true" /> if a custom attribute identified by <paramref name="attributeType" /> is defined; otherwise, <see langword="false" />.</returns>
		/// <exception cref="T:System.ArgumentException">
		///         <paramref name="attributeType" /> is <see langword="null" />. </exception>
		/// <exception cref="T:System.Reflection.ReflectionTypeLoadException">The custom attribute type cannot be loaded. </exception>
		// Token: 0x06002282 RID: 8834 RVA: 0x0008B30A File Offset: 0x0008950A
		public override bool IsDefined(Type attributeType, bool inherit)
		{
			return this.typeImpl.IsDefined(attributeType, inherit);
		}

		/// <summary>A value indicating type information.</summary>
		// Token: 0x04001087 RID: 4231
		protected Type typeImpl;
	}
}
