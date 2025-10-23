using System;
using System.Globalization;
using System.Runtime.InteropServices;

namespace System.Reflection.Emit
{
	/// <summary>Defines the properties for a type.</summary>
	// Token: 0x02000515 RID: 1301
	[StructLayout(0)]
	public sealed class PropertyBuilder : PropertyInfo
	{
		/// <summary>Gets a value indicating whether the property can be read.</summary>
		/// <returns>
		///     <see langword="true" /> if this property can be read; otherwise, <see langword="false" />.</returns>
		// Token: 0x17000576 RID: 1398
		// (get) Token: 0x060025F9 RID: 9721 RVA: 0x0009556F File Offset: 0x0009376F
		public override bool CanRead
		{
			get
			{
				return this.get_method != null;
			}
		}

		/// <summary>Gets a value indicating whether the property can be written to.</summary>
		/// <returns>
		///     <see langword="true" /> if this property can be written to; otherwise, <see langword="false" />.</returns>
		// Token: 0x17000577 RID: 1399
		// (get) Token: 0x060025FA RID: 9722 RVA: 0x0009557D File Offset: 0x0009377D
		public override bool CanWrite
		{
			get
			{
				return this.set_method != null;
			}
		}

		/// <summary>Gets the class that declares this member.</summary>
		/// <returns>The <see langword="Type" /> object for the class that declares this member.</returns>
		// Token: 0x17000578 RID: 1400
		// (get) Token: 0x060025FB RID: 9723 RVA: 0x0009558B File Offset: 0x0009378B
		public override Type DeclaringType
		{
			get
			{
				return this.typeb;
			}
		}

		/// <summary>Gets the name of this member.</summary>
		/// <returns>A <see cref="T:System.String" /> containing the name of this member.</returns>
		// Token: 0x17000579 RID: 1401
		// (get) Token: 0x060025FC RID: 9724 RVA: 0x00095593 File Offset: 0x00093793
		public override string Name
		{
			get
			{
				return this.name;
			}
		}

		/// <summary>Gets the type of the field of this property.</summary>
		/// <returns>The type of this property.</returns>
		// Token: 0x1700057A RID: 1402
		// (get) Token: 0x060025FD RID: 9725 RVA: 0x0009559B File Offset: 0x0009379B
		public override Type PropertyType
		{
			get
			{
				return this.type;
			}
		}

		/// <summary>Gets the class object that was used to obtain this instance of <see langword="MemberInfo" />.</summary>
		/// <returns>The <see langword="Type" /> object through which this <see langword="MemberInfo" /> object was obtained.</returns>
		// Token: 0x1700057B RID: 1403
		// (get) Token: 0x060025FE RID: 9726 RVA: 0x0009558B File Offset: 0x0009378B
		public override Type ReflectedType
		{
			get
			{
				return this.typeb;
			}
		}

		/// <summary>Returns an array of all the custom attributes for this property.</summary>
		/// <param name="inherit">If <see langword="true" />, walks up this property's inheritance chain to find the custom attributes </param>
		/// <returns>An array of all the custom attributes.</returns>
		/// <exception cref="T:System.NotSupportedException">This method is not supported. </exception>
		// Token: 0x060025FF RID: 9727 RVA: 0x000955A3 File Offset: 0x000937A3
		public override object[] GetCustomAttributes(bool inherit)
		{
			throw this.not_supported();
		}

		/// <summary>Returns an array of custom attributes identified by <see cref="T:System.Type" />.</summary>
		/// <param name="attributeType">An array of custom attributes identified by type. </param>
		/// <param name="inherit">If <see langword="true" />, walks up this property's inheritance chain to find the custom attributes. </param>
		/// <returns>An array of custom attributes defined on this reflected member, or <see langword="null" /> if no attributes are defined on this member.</returns>
		/// <exception cref="T:System.NotSupportedException">This method is not supported. </exception>
		// Token: 0x06002600 RID: 9728 RVA: 0x000955A3 File Offset: 0x000937A3
		public override object[] GetCustomAttributes(Type attributeType, bool inherit)
		{
			throw this.not_supported();
		}

		/// <summary>Returns the public and non-public get accessor for this property.</summary>
		/// <param name="nonPublic">Indicates whether non-public get accessors should be returned. <see langword="true" /> if non-public methods are to be included; otherwise, <see langword="false" />. </param>
		/// <returns>A <see langword="MethodInfo" /> object representing the get accessor for this property, if <paramref name="nonPublic" /> is <see langword="true" />. Returns <see langword="null" /> if <paramref name="nonPublic" /> is <see langword="false" /> and the get accessor is non-public, or if <paramref name="nonPublic" /> is <see langword="true" /> but no get accessors exist.</returns>
		// Token: 0x06002601 RID: 9729 RVA: 0x000955AB File Offset: 0x000937AB
		public override MethodInfo GetGetMethod(bool nonPublic)
		{
			return this.get_method;
		}

		/// <summary>Returns an array of all the index parameters for the property.</summary>
		/// <returns>An array of type <see langword="ParameterInfo" /> containing the parameters for the indexes.</returns>
		/// <exception cref="T:System.NotSupportedException">This method is not supported. </exception>
		// Token: 0x06002602 RID: 9730 RVA: 0x000955A3 File Offset: 0x000937A3
		public override ParameterInfo[] GetIndexParameters()
		{
			throw this.not_supported();
		}

		/// <summary>Returns the set accessor for this property.</summary>
		/// <param name="nonPublic">Indicates whether the accessor should be returned if it is non-public. <see langword="true" /> if non-public methods are to be included; otherwise, <see langword="false" />. </param>
		/// <returns>The property's <see langword="Set" /> method, or <see langword="null" />, as shown in the following table. Value Condition A <see cref="T:System.Reflection.MethodInfo" /> object representing the Set method for this property. The set accessor is public.
		///             <paramref name="nonPublic" /> is true and non-public methods can be returned. null 
		///             <paramref name="nonPublic" /> is true, but the property is read-only.
		///             <paramref name="nonPublic" /> is false and the set accessor is non-public. </returns>
		// Token: 0x06002603 RID: 9731 RVA: 0x000955B3 File Offset: 0x000937B3
		public override MethodInfo GetSetMethod(bool nonPublic)
		{
			return this.set_method;
		}

		/// <summary>Gets the value of a property having the specified binding, index, and <see langword="CultureInfo" />.</summary>
		/// <param name="obj">The object whose property value will be returned. </param>
		/// <param name="invokeAttr">The invocation attribute. This must be a bit flag from <see langword="BindingFlags" /> : <see langword="InvokeMethod" />, <see langword="CreateInstance" />, <see langword="Static" />, <see langword="GetField" />, <see langword="SetField" />, <see langword="GetProperty" />, or <see langword="SetProperty" />. A suitable invocation attribute must be specified. If a static member is to be invoked, the <see langword="Static" /> flag of <see langword="BindingFlags" /> must be set. </param>
		/// <param name="binder">An object that enables the binding, coercion of argument types, invocation of members, and retrieval of <see langword="MemberInfo" /> objects using reflection. If <paramref name="binder" /> is <see langword="null" />, the default binder is used. </param>
		/// <param name="index">Optional index values for indexed properties. This value should be <see langword="null" /> for non-indexed properties. </param>
		/// <param name="culture">The <see langword="CultureInfo" /> object that represents the culture for which the resource is to be localized. Note that if the resource is not localized for this culture, the <see langword="CultureInfo.Parent" /> method will be called successively in search of a match. If this value is <see langword="null" />, the <see langword="CultureInfo" /> is obtained from the <see langword="CultureInfo.CurrentUICulture" /> property. </param>
		/// <returns>The property value for <paramref name="obj" />.</returns>
		/// <exception cref="T:System.NotSupportedException">This method is not supported. </exception>
		// Token: 0x06002604 RID: 9732 RVA: 0x000955A3 File Offset: 0x000937A3
		public override object GetValue(object obj, BindingFlags invokeAttr, Binder binder, object[] index, CultureInfo culture)
		{
			throw this.not_supported();
		}

		/// <summary>Indicates whether one or more instance of <paramref name="attributeType" /> is defined on this property.</summary>
		/// <param name="attributeType">The <see langword="Type" /> object to which the custom attributes are applied. </param>
		/// <param name="inherit">Specifies whether to walk up this property's inheritance chain to find the custom attributes. </param>
		/// <returns>
		///     <see langword="true" /> if one or more instance of <paramref name="attributeType" /> is defined on this property; otherwise <see langword="false" />.</returns>
		/// <exception cref="T:System.NotSupportedException">This method is not supported. </exception>
		// Token: 0x06002605 RID: 9733 RVA: 0x000955A3 File Offset: 0x000937A3
		public override bool IsDefined(Type attributeType, bool inherit)
		{
			throw this.not_supported();
		}

		/// <summary>Sets the property value for the given object to the given value.</summary>
		/// <param name="obj">The object whose property value will be returned. </param>
		/// <param name="value">The new value for this property. </param>
		/// <param name="invokeAttr">The invocation attribute. This must be a bit flag from <see langword="BindingFlags" /> : <see langword="InvokeMethod" />, <see langword="CreateInstance" />, <see langword="Static" />, <see langword="GetField" />, <see langword="SetField" />, <see langword="GetProperty" />, or <see langword="SetProperty" />. A suitable invocation attribute must be specified. If a static member is to be invoked, the <see langword="Static" /> flag of <see langword="BindingFlags" /> must be set. </param>
		/// <param name="binder">An object that enables the binding, coercion of argument types, invocation of members, and retrieval of <see langword="MemberInfo" /> objects using reflection. If <paramref name="binder" /> is <see langword="null" />, the default binder is used. </param>
		/// <param name="index">Optional index values for indexed properties. This value should be <see langword="null" /> for non-indexed properties. </param>
		/// <param name="culture">The <see langword="CultureInfo" /> object that represents the culture for which the resource is to be localized. Note that if the resource is not localized for this culture, the <see langword="CultureInfo.Parent" /> method will be called successively in search of a match. If this value is <see langword="null" />, the <see langword="CultureInfo" /> is obtained from the <see langword="CultureInfo.CurrentUICulture" /> property. </param>
		/// <exception cref="T:System.NotSupportedException">This method is not supported. </exception>
		// Token: 0x06002606 RID: 9734 RVA: 0x00002A7D File Offset: 0x00000C7D
		public override void SetValue(object obj, object value, BindingFlags invokeAttr, Binder binder, object[] index, CultureInfo culture)
		{
		}

		// Token: 0x06002607 RID: 9735 RVA: 0x0008F51E File Offset: 0x0008D71E
		private Exception not_supported()
		{
			return new NotSupportedException("The invoked member is not supported in a dynamic module.");
		}

		// Token: 0x0400139A RID: 5018
		private PropertyAttributes attrs;

		// Token: 0x0400139B RID: 5019
		private string name;

		// Token: 0x0400139C RID: 5020
		private Type type;

		// Token: 0x0400139D RID: 5021
		private Type[] parameters;

		// Token: 0x0400139E RID: 5022
		private CustomAttributeBuilder[] cattrs;

		// Token: 0x0400139F RID: 5023
		private object def_value;

		// Token: 0x040013A0 RID: 5024
		private MethodBuilder set_method;

		// Token: 0x040013A1 RID: 5025
		private MethodBuilder get_method;

		// Token: 0x040013A2 RID: 5026
		private int table_idx;

		// Token: 0x040013A3 RID: 5027
		internal TypeBuilder typeb;

		// Token: 0x040013A4 RID: 5028
		private Type[] returnModReq;

		// Token: 0x040013A5 RID: 5029
		private Type[] returnModOpt;

		// Token: 0x040013A6 RID: 5030
		private Type[][] paramModReq;

		// Token: 0x040013A7 RID: 5031
		private Type[][] paramModOpt;

		// Token: 0x040013A8 RID: 5032
		private CallingConventions callingConvention;
	}
}
