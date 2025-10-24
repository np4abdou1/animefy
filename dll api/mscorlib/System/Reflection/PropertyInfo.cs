using System;
using System.Diagnostics;
using System.Globalization;

namespace System.Reflection
{
	/// <summary>Discovers the attributes of a property and provides access to property metadata.</summary>
	// Token: 0x020004B5 RID: 1205
	[Serializable]
	public abstract class PropertyInfo : MemberInfo
	{
		/// <summary>Gets a <see cref="T:System.Reflection.MemberTypes" /> value indicating that this member is a property.</summary>
		/// <returns>A <see cref="T:System.Reflection.MemberTypes" /> value indicating that this member is a property.</returns>
		// Token: 0x1700044B RID: 1099
		// (get) Token: 0x06002194 RID: 8596 RVA: 0x00012A7D File Offset: 0x00010C7D
		public override MemberTypes MemberType
		{
			get
			{
				return MemberTypes.Property;
			}
		}

		/// <summary>Gets the type of this property.</summary>
		/// <returns>The type of this property.</returns>
		// Token: 0x1700044C RID: 1100
		// (get) Token: 0x06002195 RID: 8597
		public abstract Type PropertyType { get; }

		/// <summary>When overridden in a derived class, returns an array of all the index parameters for the property.</summary>
		/// <returns>An array of type <see langword="ParameterInfo" /> containing the parameters for the indexes. If the property is not indexed, the array has 0 (zero) elements.</returns>
		// Token: 0x06002196 RID: 8598
		public abstract ParameterInfo[] GetIndexParameters();

		/// <summary>Gets a value indicating whether the property can be read.</summary>
		/// <returns>
		///     <see langword="true" /> if this property can be read; otherwise, <see langword="false" />.</returns>
		// Token: 0x1700044D RID: 1101
		// (get) Token: 0x06002197 RID: 8599
		public abstract bool CanRead { get; }

		/// <summary>Gets a value indicating whether the property can be written to.</summary>
		/// <returns>
		///     <see langword="true" /> if this property can be written to; otherwise, <see langword="false" />.</returns>
		// Token: 0x1700044E RID: 1102
		// (get) Token: 0x06002198 RID: 8600
		public abstract bool CanWrite { get; }

		/// <summary>Gets the <see langword="get" /> accessor for this property.</summary>
		/// <returns>The <see langword="get" /> accessor for this property.</returns>
		// Token: 0x1700044F RID: 1103
		// (get) Token: 0x06002199 RID: 8601 RVA: 0x0008A800 File Offset: 0x00088A00
		public virtual MethodInfo GetMethod
		{
			get
			{
				return this.GetGetMethod(true);
			}
		}

		/// <summary>Returns the public <see langword="get" /> accessor for this property.</summary>
		/// <returns>A <see langword="MethodInfo" /> object representing the public <see langword="get" /> accessor for this property, or <see langword="null" /> if the <see langword="get" /> accessor is non-public or does not exist.</returns>
		// Token: 0x0600219A RID: 8602 RVA: 0x0008A809 File Offset: 0x00088A09
		public MethodInfo GetGetMethod()
		{
			return this.GetGetMethod(false);
		}

		/// <summary>When overridden in a derived class, returns the public or non-public <see langword="get" /> accessor for this property.</summary>
		/// <param name="nonPublic">Indicates whether a non-public <see langword="get" /> accessor should be returned. <see langword="true" /> if a non-public accessor is to be returned; otherwise, <see langword="false" />. </param>
		/// <returns>A <see langword="MethodInfo" /> object representing the <see langword="get" /> accessor for this property, if <paramref name="nonPublic" /> is <see langword="true" />. Returns <see langword="null" /> if <paramref name="nonPublic" /> is <see langword="false" /> and the <see langword="get" /> accessor is non-public, or if <paramref name="nonPublic" /> is <see langword="true" /> but no <see langword="get" /> accessors exist.</returns>
		/// <exception cref="T:System.Security.SecurityException">The requested method is non-public and the caller does not have <see cref="T:System.Security.Permissions.ReflectionPermission" /> to reflect on this non-public method. </exception>
		// Token: 0x0600219B RID: 8603
		public abstract MethodInfo GetGetMethod(bool nonPublic);

		/// <summary>Gets the <see langword="set" /> accessor for this property.</summary>
		/// <returns>The <see langword="set" /> accessor for this property, or <see langword="null" /> if the property is read-only.</returns>
		// Token: 0x17000450 RID: 1104
		// (get) Token: 0x0600219C RID: 8604 RVA: 0x0008A812 File Offset: 0x00088A12
		public virtual MethodInfo SetMethod
		{
			get
			{
				return this.GetSetMethod(true);
			}
		}

		/// <summary>Returns the public <see langword="set" /> accessor for this property.</summary>
		/// <returns>The <see langword="MethodInfo" /> object representing the <see langword="Set" /> method for this property if the <see langword="set" /> accessor is public, or <see langword="null" /> if the <see langword="set" /> accessor is not public.</returns>
		// Token: 0x0600219D RID: 8605 RVA: 0x0008A81B File Offset: 0x00088A1B
		public MethodInfo GetSetMethod()
		{
			return this.GetSetMethod(false);
		}

		/// <summary>When overridden in a derived class, returns the <see langword="set" /> accessor for this property.</summary>
		/// <param name="nonPublic">Indicates whether the accessor should be returned if it is non-public. <see langword="true" /> if a non-public accessor is to be returned; otherwise, <see langword="false" />. </param>
		/// <returns>This property's <see langword="Set" /> method, or <see langword="null" />, as shown in the following table.Value Condition The <see langword="Set" /> method for this property. The <see langword="set" /> accessor is public.-or- 
		///             <paramref name="nonPublic" /> is <see langword="true" /> and the <see langword="set" /> accessor is non-public. 
		///             <see langword="null" />
		///
		///             <paramref name="nonPublic" /> is <see langword="true" />, but the property is read-only.-or- 
		///             <paramref name="nonPublic" /> is <see langword="false" /> and the <see langword="set" /> accessor is non-public.-or- There is no <see langword="set" /> accessor. </returns>
		/// <exception cref="T:System.Security.SecurityException">The requested method is non-public and the caller does not have <see cref="T:System.Security.Permissions.ReflectionPermission" /> to reflect on this non-public method. </exception>
		// Token: 0x0600219E RID: 8606
		public abstract MethodInfo GetSetMethod(bool nonPublic);

		/// <summary>Returns the property value of a specified object.</summary>
		/// <param name="obj">The object whose property value will be returned.</param>
		/// <returns>The property value of the specified object.</returns>
		// Token: 0x0600219F RID: 8607 RVA: 0x0008A824 File Offset: 0x00088A24
		[DebuggerHidden]
		[DebuggerStepThrough]
		public object GetValue(object obj)
		{
			return this.GetValue(obj, null);
		}

		/// <summary>Returns the property value of a specified object with optional index values for indexed properties.</summary>
		/// <param name="obj">The object whose property value will be returned. </param>
		/// <param name="index">Optional index values for indexed properties. The indexes of indexed properties are zero-based. This value should be <see langword="null" /> for non-indexed properties. </param>
		/// <returns>The property value of the specified object.</returns>
		/// <exception cref="T:System.ArgumentException">The <paramref name="index" /> array does not contain the type of arguments needed.-or- The property's <see langword="get" /> accessor is not found. </exception>
		/// <exception cref="T:System.Reflection.TargetException">
		///           In the .NET for Windows Store apps or the Portable Class Library, catch <see cref="T:System.Exception" /> instead.The object does not match the target type, or a property is an instance property but <paramref name="obj" /> is <see langword="null" />. </exception>
		/// <exception cref="T:System.Reflection.TargetParameterCountException">The number of parameters in <paramref name="index" /> does not match the number of parameters the indexed property takes. </exception>
		/// <exception cref="T:System.MethodAccessException">
		///           In the .NET for Windows Store apps or the Portable Class Library, catch the base class exception, <see cref="T:System.MemberAccessException" />, instead.There was an illegal attempt to access a private or protected method inside a class. </exception>
		/// <exception cref="T:System.Reflection.TargetInvocationException">An error occurred while retrieving the property value. For example, an index value specified for an indexed property is out of range. The <see cref="P:System.Exception.InnerException" /> property indicates the reason for the error.</exception>
		// Token: 0x060021A0 RID: 8608 RVA: 0x0008A82E File Offset: 0x00088A2E
		[DebuggerHidden]
		[DebuggerStepThrough]
		public virtual object GetValue(object obj, object[] index)
		{
			return this.GetValue(obj, BindingFlags.Default, null, index, null);
		}

		/// <summary>When overridden in a derived class, returns the property value of a specified object that has the specified binding, index, and culture-specific information.</summary>
		/// <param name="obj">The object whose property value will be returned. </param>
		/// <param name="invokeAttr">A bitwise combination of the following enumeration members that specify the invocation attribute: <see langword="InvokeMethod" />, <see langword="CreateInstance" />, <see langword="Static" />, <see langword="GetField" />, <see langword="SetField" />, <see langword="GetProperty" />, and <see langword="SetProperty" />. You must specify a suitable invocation attribute. For example, to invoke a static member, set the <see langword="Static" /> flag. </param>
		/// <param name="binder">An object that enables the binding, coercion of argument types, invocation of members, and retrieval of <see cref="T:System.Reflection.MemberInfo" /> objects through reflection. If <paramref name="binder" /> is <see langword="null" />, the default binder is used. </param>
		/// <param name="index">Optional index values for indexed properties. This value should be <see langword="null" /> for non-indexed properties. </param>
		/// <param name="culture">The culture for which the resource is to be localized. If the resource is not localized for this culture, the <see cref="P:System.Globalization.CultureInfo.Parent" /> property will be called successively in search of a match. If this value is <see langword="null" />, the culture-specific information is obtained from the <see cref="P:System.Globalization.CultureInfo.CurrentUICulture" /> property. </param>
		/// <returns>The property value of the specified object.</returns>
		/// <exception cref="T:System.ArgumentException">The <paramref name="index" /> array does not contain the type of arguments needed.-or- The property's <see langword="get" /> accessor is not found. </exception>
		/// <exception cref="T:System.Reflection.TargetException">The object does not match the target type, or a property is an instance property but <paramref name="obj" /> is <see langword="null" />. </exception>
		/// <exception cref="T:System.Reflection.TargetParameterCountException">The number of parameters in <paramref name="index" /> does not match the number of parameters the indexed property takes. </exception>
		/// <exception cref="T:System.MethodAccessException">There was an illegal attempt to access a private or protected method inside a class. </exception>
		/// <exception cref="T:System.Reflection.TargetInvocationException">An error occurred while retrieving the property value. For example, an index value specified for an indexed property is out of range. The <see cref="P:System.Exception.InnerException" /> property indicates the reason for the error.</exception>
		// Token: 0x060021A1 RID: 8609
		public abstract object GetValue(object obj, BindingFlags invokeAttr, Binder binder, object[] index, CultureInfo culture);

		/// <summary>Sets the property value of a specified object.</summary>
		/// <param name="obj">The object whose property value will be set.</param>
		/// <param name="value">The new property value.</param>
		/// <exception cref="T:System.ArgumentException">The property's <see langword="set" /> accessor is not found. -or-
		///         <paramref name="value" /> cannot be converted to the type of <see cref="P:System.Reflection.PropertyInfo.PropertyType" />. </exception>
		/// <exception cref="T:System.Reflection.TargetException">
		///           In the .NET for Windows Store apps or the Portable Class Library, catch <see cref="T:System.Exception" /> instead.The type of <paramref name="obj" /> does not match the target type, or a property is an instance property but <paramref name="obj" /> is <see langword="null" />. </exception>
		/// <exception cref="T:System.MethodAccessException">
		///           In the .NET for Windows Store apps or the Portable Class Library, catch the base class exception, <see cref="T:System.MemberAccessException" />, instead.There was an illegal attempt to access a private or protected method inside a class. </exception>
		/// <exception cref="T:System.Reflection.TargetInvocationException">An error occurred while setting the property value. The <see cref="P:System.Exception.InnerException" /> property indicates the reason for the error.</exception>
		// Token: 0x060021A2 RID: 8610 RVA: 0x0008A83B File Offset: 0x00088A3B
		[DebuggerHidden]
		[DebuggerStepThrough]
		public void SetValue(object obj, object value)
		{
			this.SetValue(obj, value, null);
		}

		/// <summary>Sets the property value of a specified object with optional index values for index properties.</summary>
		/// <param name="obj">The object whose property value will be set. </param>
		/// <param name="value">The new property value. </param>
		/// <param name="index">Optional index values for indexed properties. This value should be <see langword="null" /> for non-indexed properties. </param>
		/// <exception cref="T:System.ArgumentException">The <paramref name="index" /> array does not contain the type of arguments needed.-or- The property's <see langword="set" /> accessor is not found. -or-
		///         <paramref name="value" /> cannot be converted to the type of <see cref="P:System.Reflection.PropertyInfo.PropertyType" />.</exception>
		/// <exception cref="T:System.Reflection.TargetException">
		///           In the .NET for Windows Store apps or the Portable Class Library, catch <see cref="T:System.Exception" /> instead.The object does not match the target type, or a property is an instance property but <paramref name="obj" /> is <see langword="null" />. </exception>
		/// <exception cref="T:System.Reflection.TargetParameterCountException">The number of parameters in <paramref name="index" /> does not match the number of parameters the indexed property takes. </exception>
		/// <exception cref="T:System.MethodAccessException">
		///           In the .NET for Windows Store apps or the Portable Class Library, catch the base class exception, <see cref="T:System.MemberAccessException" />, instead.There was an illegal attempt to access a private or protected method inside a class. </exception>
		/// <exception cref="T:System.Reflection.TargetInvocationException">An error occurred while setting the property value. For example, an index value specified for an indexed property is out of range. The <see cref="P:System.Exception.InnerException" /> property indicates the reason for the error.</exception>
		// Token: 0x060021A3 RID: 8611 RVA: 0x0008A846 File Offset: 0x00088A46
		[DebuggerHidden]
		[DebuggerStepThrough]
		public virtual void SetValue(object obj, object value, object[] index)
		{
			this.SetValue(obj, value, BindingFlags.Default, null, index, null);
		}

		/// <summary>When overridden in a derived class, sets the property value for a specified object that has the specified binding, index, and culture-specific information.</summary>
		/// <param name="obj">The object whose property value will be set. </param>
		/// <param name="value">The new property value. </param>
		/// <param name="invokeAttr">A bitwise combination of the following enumeration members that specify the invocation attribute: <see langword="InvokeMethod" />, <see langword="CreateInstance" />, <see langword="Static" />, <see langword="GetField" />, <see langword="SetField" />, <see langword="GetProperty" />, or <see langword="SetProperty" />. You must specify a suitable invocation attribute. For example, to invoke a static member, set the <see langword="Static" /> flag. </param>
		/// <param name="binder">An object that enables the binding, coercion of argument types, invocation of members, and retrieval of <see cref="T:System.Reflection.MemberInfo" /> objects through reflection. If <paramref name="binder" /> is <see langword="null" />, the default binder is used. </param>
		/// <param name="index">Optional index values for indexed properties. This value should be <see langword="null" /> for non-indexed properties. </param>
		/// <param name="culture">The culture for which the resource is to be localized. If the resource is not localized for this culture, the <see cref="P:System.Globalization.CultureInfo.Parent" /> property will be called successively in search of a match. If this value is <see langword="null" />, the culture-specific information is obtained from the <see cref="P:System.Globalization.CultureInfo.CurrentUICulture" /> property. </param>
		/// <exception cref="T:System.ArgumentException">The <paramref name="index" /> array does not contain the type of arguments needed.-or- The property's <see langword="set" /> accessor is not found. -or-
		///         <paramref name="value" /> cannot be converted to the type of <see cref="P:System.Reflection.PropertyInfo.PropertyType" />.</exception>
		/// <exception cref="T:System.Reflection.TargetException">The object does not match the target type, or a property is an instance property but <paramref name="obj" /> is <see langword="null" />. </exception>
		/// <exception cref="T:System.Reflection.TargetParameterCountException">The number of parameters in <paramref name="index" /> does not match the number of parameters the indexed property takes. </exception>
		/// <exception cref="T:System.MethodAccessException">There was an illegal attempt to access a private or protected method inside a class. </exception>
		/// <exception cref="T:System.Reflection.TargetInvocationException">An error occurred while setting the property value. For example, an index value specified for an indexed property is out of range. The <see cref="P:System.Exception.InnerException" /> property indicates the reason for the error.</exception>
		// Token: 0x060021A4 RID: 8612
		public abstract void SetValue(object obj, object value, BindingFlags invokeAttr, Binder binder, object[] index, CultureInfo culture);

		/// <summary>Returns a value that indicates whether this instance is equal to a specified object.</summary>
		/// <param name="obj">An object to compare with this instance, or <see langword="null" />.</param>
		/// <returns>
		///     <see langword="true" /> if <paramref name="obj" /> equals the type and value of this instance; otherwise, <see langword="false" />.</returns>
		// Token: 0x060021A5 RID: 8613 RVA: 0x00089BF8 File Offset: 0x00087DF8
		public override bool Equals(object obj)
		{
			return base.Equals(obj);
		}

		/// <summary>Returns the hash code for this instance.</summary>
		/// <returns>A 32-bit signed integer hash code.</returns>
		// Token: 0x060021A6 RID: 8614 RVA: 0x00089C01 File Offset: 0x00087E01
		public override int GetHashCode()
		{
			return base.GetHashCode();
		}

		/// <summary>Indicates whether two <see cref="T:System.Reflection.PropertyInfo" /> objects are equal.</summary>
		/// <param name="left">The first object to compare.</param>
		/// <param name="right">The second object to compare.</param>
		/// <returns>
		///     <see langword="true" /> if <paramref name="left" /> is equal to <paramref name="right" />; otherwise, <see langword="false" />.</returns>
		// Token: 0x060021A7 RID: 8615 RVA: 0x0003F3D8 File Offset: 0x0003D5D8
		public static bool operator ==(PropertyInfo left, PropertyInfo right)
		{
			return left == right || (left != null && right != null && left.Equals(right));
		}

		/// <summary>Indicates whether two <see cref="T:System.Reflection.PropertyInfo" /> objects are not equal.</summary>
		/// <param name="left">The first object to compare.</param>
		/// <param name="right">The second object to compare.</param>
		/// <returns>
		///     <see langword="true" /> if <paramref name="left" /> is not equal to <paramref name="right" />; otherwise, <see langword="false" />.</returns>
		// Token: 0x060021A8 RID: 8616 RVA: 0x0008A854 File Offset: 0x00088A54
		public static bool operator !=(PropertyInfo left, PropertyInfo right)
		{
			return !(left == right);
		}
	}
}
