using System;
using System.Globalization;
using System.Runtime.InteropServices;

namespace System.Reflection.Emit
{
	/// <summary>Describes and represents an enumeration type.</summary>
	// Token: 0x020004FB RID: 1275
	public sealed class EnumBuilder : TypeInfo
	{
		// Token: 0x060024CE RID: 9422 RVA: 0x00090628 File Offset: 0x0008E828
		internal TypeBuilder GetTypeBuilder()
		{
			return this._tb;
		}

		/// <summary>Retrieves the dynamic assembly that contains this enum definition.</summary>
		/// <returns>Read-only. The dynamic assembly that contains this enum definition.</returns>
		// Token: 0x17000529 RID: 1321
		// (get) Token: 0x060024CF RID: 9423 RVA: 0x00090630 File Offset: 0x0008E830
		public override Assembly Assembly
		{
			get
			{
				return this._tb.Assembly;
			}
		}

		/// <summary>Returns the full path of this enum qualified by the display name of the parent assembly.</summary>
		/// <returns>Read-only. The full path of this enum qualified by the display name of the parent assembly.</returns>
		// Token: 0x1700052A RID: 1322
		// (get) Token: 0x060024D0 RID: 9424 RVA: 0x0009063D File Offset: 0x0008E83D
		public override string AssemblyQualifiedName
		{
			get
			{
				return this._tb.AssemblyQualifiedName;
			}
		}

		/// <summary>Returns the parent <see cref="T:System.Type" /> of this type which is always <see cref="T:System.Enum" />.</summary>
		/// <returns>Read-only. The parent <see cref="T:System.Type" /> of this type.</returns>
		// Token: 0x1700052B RID: 1323
		// (get) Token: 0x060024D1 RID: 9425 RVA: 0x0009064A File Offset: 0x0008E84A
		public override Type BaseType
		{
			get
			{
				return this._tb.BaseType;
			}
		}

		/// <summary>Returns the full path of this enum.</summary>
		/// <returns>Read-only. The full path of this enum.</returns>
		// Token: 0x1700052C RID: 1324
		// (get) Token: 0x060024D2 RID: 9426 RVA: 0x00090657 File Offset: 0x0008E857
		public override string FullName
		{
			get
			{
				return this._tb.FullName;
			}
		}

		/// <summary>Returns the GUID of this enum.</summary>
		/// <returns>Read-only. The GUID of this enum.</returns>
		/// <exception cref="T:System.NotSupportedException">This method is not currently supported in types that are not complete. </exception>
		// Token: 0x1700052D RID: 1325
		// (get) Token: 0x060024D3 RID: 9427 RVA: 0x00090664 File Offset: 0x0008E864
		public override Guid GUID
		{
			get
			{
				return this._tb.GUID;
			}
		}

		/// <summary>Retrieves the dynamic module that contains this <see cref="T:System.Reflection.Emit.EnumBuilder" /> definition.</summary>
		/// <returns>Read-only. The dynamic module that contains this <see cref="T:System.Reflection.Emit.EnumBuilder" /> definition.</returns>
		// Token: 0x1700052E RID: 1326
		// (get) Token: 0x060024D4 RID: 9428 RVA: 0x00090671 File Offset: 0x0008E871
		public override Module Module
		{
			get
			{
				return this._tb.Module;
			}
		}

		/// <summary>Returns the name of this enum.</summary>
		/// <returns>Read-only. The name of this enum.</returns>
		// Token: 0x1700052F RID: 1327
		// (get) Token: 0x060024D5 RID: 9429 RVA: 0x0009067E File Offset: 0x0008E87E
		public override string Name
		{
			get
			{
				return this._tb.Name;
			}
		}

		/// <summary>Returns the namespace of this enum.</summary>
		/// <returns>Read-only. The namespace of this enum.</returns>
		// Token: 0x17000530 RID: 1328
		// (get) Token: 0x060024D6 RID: 9430 RVA: 0x0009068B File Offset: 0x0008E88B
		public override string Namespace
		{
			get
			{
				return this._tb.Namespace;
			}
		}

		/// <summary>Returns the underlying system type for this enum.</summary>
		/// <returns>Read-only. Returns the underlying system type.</returns>
		// Token: 0x17000531 RID: 1329
		// (get) Token: 0x060024D7 RID: 9431 RVA: 0x00090698 File Offset: 0x0008E898
		public override Type UnderlyingSystemType
		{
			get
			{
				return this._underlyingType;
			}
		}

		// Token: 0x060024D8 RID: 9432 RVA: 0x000906A0 File Offset: 0x0008E8A0
		protected override TypeAttributes GetAttributeFlagsImpl()
		{
			return this._tb.attrs;
		}

		// Token: 0x060024D9 RID: 9433 RVA: 0x000906AD File Offset: 0x0008E8AD
		protected override ConstructorInfo GetConstructorImpl(BindingFlags bindingAttr, Binder binder, CallingConventions callConvention, Type[] types, ParameterModifier[] modifiers)
		{
			return this._tb.GetConstructor(bindingAttr, binder, callConvention, types, modifiers);
		}

		/// <summary>Returns an array of <see cref="T:System.Reflection.ConstructorInfo" /> objects representing the public and non-public constructors defined for this class, as specified.</summary>
		/// <param name="bindingAttr">This must be a bit flag from <see cref="T:System.Reflection.BindingFlags" /> : <see langword="InvokeMethod" />, <see langword="NonPublic" />, and so on. </param>
		/// <returns>Returns an array of <see cref="T:System.Reflection.ConstructorInfo" /> objects representing the specified constructors defined for this class. If no constructors are defined, an empty array is returned.</returns>
		/// <exception cref="T:System.NotSupportedException">This method is not currently supported in types that are not complete. </exception>
		// Token: 0x060024DA RID: 9434 RVA: 0x000906C1 File Offset: 0x0008E8C1
		[ComVisible(true)]
		public override ConstructorInfo[] GetConstructors(BindingFlags bindingAttr)
		{
			return this._tb.GetConstructors(bindingAttr);
		}

		/// <summary>Returns all the custom attributes defined for this constructor.</summary>
		/// <param name="inherit">Specifies whether to search this member's inheritance chain to find the attributes. </param>
		/// <returns>Returns an array of objects representing all the custom attributes of the constructor represented by this <see cref="T:System.Reflection.Emit.ConstructorBuilder" /> instance.</returns>
		/// <exception cref="T:System.NotSupportedException">This method is not currently supported in types that are not complete. </exception>
		// Token: 0x060024DB RID: 9435 RVA: 0x000906CF File Offset: 0x0008E8CF
		public override object[] GetCustomAttributes(bool inherit)
		{
			return this._tb.GetCustomAttributes(inherit);
		}

		/// <summary>Returns the custom attributes identified by the given type.</summary>
		/// <param name="attributeType">The <see langword="Type" /> object to which the custom attributes are applied. </param>
		/// <param name="inherit">Specifies whether to search this member's inheritance chain to find the attributes. </param>
		/// <returns>Returns an array of objects representing the attributes of this constructor that are of <see cref="T:System.Type" /><paramref name="attributeType" />.</returns>
		/// <exception cref="T:System.NotSupportedException">This method is not currently supported in types that are not complete. </exception>
		// Token: 0x060024DC RID: 9436 RVA: 0x000906DD File Offset: 0x0008E8DD
		public override object[] GetCustomAttributes(Type attributeType, bool inherit)
		{
			return this._tb.GetCustomAttributes(attributeType, inherit);
		}

		/// <summary>Calling this method always throws <see cref="T:System.NotSupportedException" />.</summary>
		/// <returns>This method is not supported. No value is returned.</returns>
		/// <exception cref="T:System.NotSupportedException">This method is not currently supported. </exception>
		// Token: 0x060024DD RID: 9437 RVA: 0x000906EC File Offset: 0x0008E8EC
		public override Type GetElementType()
		{
			return this._tb.GetElementType();
		}

		/// <summary>Returns the event with the specified name.</summary>
		/// <param name="name">The name of the event to get. </param>
		/// <param name="bindingAttr">This invocation attribute. This must be a bit flag from <see cref="T:System.Reflection.BindingFlags" /> : <see langword="InvokeMethod" />, <see langword="NonPublic" />, and so on. </param>
		/// <returns>Returns an <see cref="T:System.Reflection.EventInfo" /> object representing the event declared or inherited by this type with the specified name. If there are no matches, <see langword="null" /> is returned.</returns>
		/// <exception cref="T:System.NotSupportedException">This method is not currently supported in types that are not complete. </exception>
		// Token: 0x060024DE RID: 9438 RVA: 0x000906F9 File Offset: 0x0008E8F9
		public override EventInfo GetEvent(string name, BindingFlags bindingAttr)
		{
			return this._tb.GetEvent(name, bindingAttr);
		}

		/// <summary>Returns the public and non-public events that are declared by this type.</summary>
		/// <param name="bindingAttr">This must be a bit flag from <see cref="T:System.Reflection.BindingFlags" />, such as <see langword="InvokeMethod" />, <see langword="NonPublic" />, and so on. </param>
		/// <returns>Returns an array of <see cref="T:System.Reflection.EventInfo" /> objects representing the public and non-public events declared or inherited by this type. An empty array is returned if there are no events, as specified.</returns>
		/// <exception cref="T:System.NotSupportedException">This method is not currently supported in types that are not complete. </exception>
		// Token: 0x060024DF RID: 9439 RVA: 0x00090708 File Offset: 0x0008E908
		public override EventInfo[] GetEvents(BindingFlags bindingAttr)
		{
			return this._tb.GetEvents(bindingAttr);
		}

		/// <summary>Returns the field specified by the given name.</summary>
		/// <param name="name">The name of the field to get. </param>
		/// <param name="bindingAttr">This must be a bit flag from <see cref="T:System.Reflection.BindingFlags" /> : <see langword="InvokeMethod" />, <see langword="NonPublic" />, and so on. </param>
		/// <returns>Returns the <see cref="T:System.Reflection.FieldInfo" /> object representing the field declared or inherited by this type with the specified name and public or non-public modifier. If there are no matches, then null is returned.</returns>
		/// <exception cref="T:System.NotSupportedException">This method is not currently supported in types that are not complete. </exception>
		// Token: 0x060024E0 RID: 9440 RVA: 0x00090716 File Offset: 0x0008E916
		public override FieldInfo GetField(string name, BindingFlags bindingAttr)
		{
			return this._tb.GetField(name, bindingAttr);
		}

		/// <summary>Returns the public and non-public fields that are declared by this type.</summary>
		/// <param name="bindingAttr">This must be a bit flag from <see cref="T:System.Reflection.BindingFlags" />, such as InvokeMethod, NonPublic, and so on. </param>
		/// <returns>Returns an array of <see cref="T:System.Reflection.FieldInfo" /> objects representing the public and non-public fields declared or inherited by this type. An empty array is returned if there are no fields, as specified.</returns>
		/// <exception cref="T:System.NotSupportedException">This method is not currently supported in types that are not complete. </exception>
		// Token: 0x060024E1 RID: 9441 RVA: 0x00090725 File Offset: 0x0008E925
		public override FieldInfo[] GetFields(BindingFlags bindingAttr)
		{
			return this._tb.GetFields(bindingAttr);
		}

		/// <summary>Returns an array of all the interfaces implemented on this a class and its base classes.</summary>
		/// <returns>Returns an array of <see cref="T:System.Type" /> objects representing the implemented interfaces. If none are defined, an empty array is returned.</returns>
		// Token: 0x060024E2 RID: 9442 RVA: 0x00090733 File Offset: 0x0008E933
		public override Type[] GetInterfaces()
		{
			return this._tb.GetInterfaces();
		}

		// Token: 0x060024E3 RID: 9443 RVA: 0x00090740 File Offset: 0x0008E940
		protected override MethodInfo GetMethodImpl(string name, BindingFlags bindingAttr, Binder binder, CallingConventions callConvention, Type[] types, ParameterModifier[] modifiers)
		{
			if (types == null)
			{
				return this._tb.GetMethod(name, bindingAttr);
			}
			return this._tb.GetMethod(name, bindingAttr, binder, callConvention, types, modifiers);
		}

		/// <summary>Returns all the public and non-public methods declared or inherited by this type, as specified.</summary>
		/// <param name="bindingAttr">This must be a bit flag from <see cref="T:System.Reflection.BindingFlags" />, such as <see langword="InvokeMethod" />, <see langword="NonPublic" />, and so on. </param>
		/// <returns>Returns an array of <see cref="T:System.Reflection.MethodInfo" /> objects representing the public and non-public methods defined on this type if <paramref name="nonPublic" /> is used; otherwise, only the public methods are returned.</returns>
		/// <exception cref="T:System.NotSupportedException">This method is not currently supported in types that are not complete. </exception>
		// Token: 0x060024E4 RID: 9444 RVA: 0x00090768 File Offset: 0x0008E968
		public override MethodInfo[] GetMethods(BindingFlags bindingAttr)
		{
			return this._tb.GetMethods(bindingAttr);
		}

		/// <summary>Returns the specified nested type that is declared by this type.</summary>
		/// <param name="name">The <see cref="T:System.String" /> containing the name of the nested type to get. </param>
		/// <param name="bindingAttr">A bitmask comprised of one or more <see cref="T:System.Reflection.BindingFlags" /> that specify how the search is conducted.-or- Zero, to conduct a case-sensitive search for public methods. </param>
		/// <returns>A <see cref="T:System.Type" /> object representing the nested type that matches the specified requirements, if found; otherwise, <see langword="null" />.</returns>
		/// <exception cref="T:System.NotSupportedException">This method is not currently supported in types that are not complete. </exception>
		// Token: 0x060024E5 RID: 9445 RVA: 0x00090776 File Offset: 0x0008E976
		public override Type GetNestedType(string name, BindingFlags bindingAttr)
		{
			return this._tb.GetNestedType(name, bindingAttr);
		}

		/// <summary>Returns all the public and non-public properties declared or inherited by this type, as specified.</summary>
		/// <param name="bindingAttr">This invocation attribute. This must be a bit flag from <see cref="T:System.Reflection.BindingFlags" /> : <see langword="InvokeMethod" />, <see langword="NonPublic" />, and so on. </param>
		/// <returns>Returns an array of <see cref="T:System.Reflection.PropertyInfo" /> objects representing the public and non-public properties defined on this type if <paramref name="nonPublic" /> is used; otherwise, only the public properties are returned.</returns>
		/// <exception cref="T:System.NotSupportedException">This method is not currently supported in types that are not complete. </exception>
		// Token: 0x060024E6 RID: 9446 RVA: 0x00090785 File Offset: 0x0008E985
		public override PropertyInfo[] GetProperties(BindingFlags bindingAttr)
		{
			return this._tb.GetProperties(bindingAttr);
		}

		// Token: 0x060024E7 RID: 9447 RVA: 0x00090793 File Offset: 0x0008E993
		protected override PropertyInfo GetPropertyImpl(string name, BindingFlags bindingAttr, Binder binder, Type returnType, Type[] types, ParameterModifier[] modifiers)
		{
			throw this.CreateNotSupportedException();
		}

		// Token: 0x060024E8 RID: 9448 RVA: 0x0009079B File Offset: 0x0008E99B
		protected override bool HasElementTypeImpl()
		{
			return this._tb.HasElementType;
		}

		/// <summary>Invokes the specified member. The method that is to be invoked must be accessible and provide the most specific match with the specified argument list, under the contraints of the specified binder and invocation attributes.</summary>
		/// <param name="name">The name of the member to invoke. This can be a constructor, method, property, or field. A suitable invocation attribute must be specified. Note that it is possible to invoke the default member of a class by passing an empty string as the name of the member. </param>
		/// <param name="invokeAttr">The invocation attribute. This must be a bit flag from <see langword="BindingFlags" />. </param>
		/// <param name="binder">An object that enables the binding, coercion of argument types, invocation of members, and retrieval of <see langword="MemberInfo" /> objects using reflection. If binder is <see langword="null" />, the default binder is used. See <see cref="T:System.Reflection.Binder" />. </param>
		/// <param name="target">The object on which to invoke the specified member. If the member is static, this parameter is ignored. </param>
		/// <param name="args">An argument list. This is an array of objects that contains the number, order, and type of the parameters of the member to be invoked. If there are no parameters this should be null. </param>
		/// <param name="modifiers">An array of the same length as <paramref name="args" /> with elements that represent the attributes associated with the arguments of the member to be invoked. A parameter has attributes associated with it in the metadata. They are used by various interoperability services. See the metadata specs for details such as this. </param>
		/// <param name="culture">An instance of <see langword="CultureInfo" /> used to govern the coercion of types. If this is null, the <see langword="CultureInfo" /> for the current thread is used. (Note that this is necessary to, for example, convert a string that represents 1000 to a double value, since 1000 is represented differently by different cultures.) </param>
		/// <param name="namedParameters">Each parameter in the <paramref name="namedParameters" /> array gets the value in the corresponding element in the <paramref name="args" /> array. If the length of <paramref name="args" /> is greater than the length of <paramref name="namedParameters" />, the remaining argument values are passed in order. </param>
		/// <returns>Returns the return value of the invoked member.</returns>
		/// <exception cref="T:System.NotSupportedException">This method is not currently supported in types that are not complete. </exception>
		// Token: 0x060024E9 RID: 9449 RVA: 0x000907A8 File Offset: 0x0008E9A8
		public override object InvokeMember(string name, BindingFlags invokeAttr, Binder binder, object target, object[] args, ParameterModifier[] modifiers, CultureInfo culture, string[] namedParameters)
		{
			return this._tb.InvokeMember(name, invokeAttr, binder, target, args, modifiers, culture, namedParameters);
		}

		// Token: 0x060024EA RID: 9450 RVA: 0x0002ACA4 File Offset: 0x00028EA4
		protected override bool IsArrayImpl()
		{
			return false;
		}

		// Token: 0x060024EB RID: 9451 RVA: 0x0002ACA4 File Offset: 0x00028EA4
		protected override bool IsByRefImpl()
		{
			return false;
		}

		// Token: 0x060024EC RID: 9452 RVA: 0x0002ACA4 File Offset: 0x00028EA4
		protected override bool IsCOMObjectImpl()
		{
			return false;
		}

		// Token: 0x060024ED RID: 9453 RVA: 0x0002ACA4 File Offset: 0x00028EA4
		protected override bool IsPointerImpl()
		{
			return false;
		}

		// Token: 0x060024EE RID: 9454 RVA: 0x0002ACA4 File Offset: 0x00028EA4
		protected override bool IsPrimitiveImpl()
		{
			return false;
		}

		/// <summary>Checks if the specified custom attribute type is defined.</summary>
		/// <param name="attributeType">The <see langword="Type" /> object to which the custom attributes are applied. </param>
		/// <param name="inherit">Specifies whether to search this member's inheritance chain to find the attributes. </param>
		/// <returns>
		///     <see langword="true" /> if one or more instance of <paramref name="attributeType" /> is defined on this member; otherwise, <see langword="false" />.</returns>
		/// <exception cref="T:System.NotSupportedException">This method is not currently supported in types that are not complete. </exception>
		// Token: 0x060024EF RID: 9455 RVA: 0x000907CD File Offset: 0x0008E9CD
		public override bool IsDefined(Type attributeType, bool inherit)
		{
			return this._tb.IsDefined(attributeType, inherit);
		}

		// Token: 0x060024F0 RID: 9456 RVA: 0x0008F51E File Offset: 0x0008D71E
		private Exception CreateNotSupportedException()
		{
			return new NotSupportedException("The invoked member is not supported in a dynamic module.");
		}

		// Token: 0x0400120B RID: 4619
		private TypeBuilder _tb;

		// Token: 0x0400120C RID: 4620
		private FieldBuilder _underlyingField;

		// Token: 0x0400120D RID: 4621
		private Type _underlyingType;
	}
}
