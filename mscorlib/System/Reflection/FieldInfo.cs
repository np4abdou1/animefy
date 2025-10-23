using System;
using System.Diagnostics;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace System.Reflection
{
	/// <summary>Discovers the attributes of a field and provides access to field metadata. </summary>
	// Token: 0x0200049E RID: 1182
	[Serializable]
	public abstract class FieldInfo : MemberInfo
	{
		/// <summary>Gets a <see cref="T:System.Reflection.MemberTypes" /> value indicating that this member is a field.</summary>
		/// <returns>A <see cref="T:System.Reflection.MemberTypes" /> value indicating that this member is a field.</returns>
		// Token: 0x1700041C RID: 1052
		// (get) Token: 0x06002103 RID: 8451 RVA: 0x0000F994 File Offset: 0x0000DB94
		public override MemberTypes MemberType
		{
			get
			{
				return MemberTypes.Field;
			}
		}

		/// <summary>Gets the attributes associated with this field.</summary>
		/// <returns>The <see langword="FieldAttributes" /> for this field.</returns>
		// Token: 0x1700041D RID: 1053
		// (get) Token: 0x06002104 RID: 8452
		public abstract FieldAttributes Attributes { get; }

		/// <summary>Gets the type of this field object.</summary>
		/// <returns>The type of this field object.</returns>
		// Token: 0x1700041E RID: 1054
		// (get) Token: 0x06002105 RID: 8453
		public abstract Type FieldType { get; }

		/// <summary>Gets a value indicating whether the field can only be set in the body of the constructor.</summary>
		/// <returns>
		///     <see langword="true" /> if the field has the <see langword="InitOnly" /> attribute set; otherwise, <see langword="false" />.</returns>
		// Token: 0x1700041F RID: 1055
		// (get) Token: 0x06002106 RID: 8454 RVA: 0x00089CE2 File Offset: 0x00087EE2
		public bool IsInitOnly
		{
			get
			{
				return (this.Attributes & FieldAttributes.InitOnly) > FieldAttributes.PrivateScope;
			}
		}

		/// <summary>Gets a value indicating whether the value is written at compile time and cannot be changed.</summary>
		/// <returns>
		///     <see langword="true" /> if the field has the <see langword="Literal" /> attribute set; otherwise, <see langword="false" />.</returns>
		// Token: 0x17000420 RID: 1056
		// (get) Token: 0x06002107 RID: 8455 RVA: 0x00089CF0 File Offset: 0x00087EF0
		public bool IsLiteral
		{
			get
			{
				return (this.Attributes & FieldAttributes.Literal) > FieldAttributes.PrivateScope;
			}
		}

		/// <summary>Gets a value indicating whether this field has the <see langword="NotSerialized" /> attribute.</summary>
		/// <returns>
		///     <see langword="true" /> if the field has the <see langword="NotSerialized" /> attribute set; otherwise, <see langword="false" />.</returns>
		// Token: 0x17000421 RID: 1057
		// (get) Token: 0x06002108 RID: 8456 RVA: 0x00089CFE File Offset: 0x00087EFE
		public bool IsNotSerialized
		{
			get
			{
				return (this.Attributes & FieldAttributes.NotSerialized) > FieldAttributes.PrivateScope;
			}
		}

		/// <summary>Gets a value indicating whether the field is static.</summary>
		/// <returns>
		///     <see langword="true" /> if this field is static; otherwise, <see langword="false" />.</returns>
		// Token: 0x17000422 RID: 1058
		// (get) Token: 0x06002109 RID: 8457 RVA: 0x00089D0F File Offset: 0x00087F0F
		public bool IsStatic
		{
			get
			{
				return (this.Attributes & FieldAttributes.Static) > FieldAttributes.PrivateScope;
			}
		}

		/// <summary>Gets a value indicating whether the field is private.</summary>
		/// <returns>
		///     <see langword="true" /> if the field is private; otherwise; <see langword="false" />.</returns>
		// Token: 0x17000423 RID: 1059
		// (get) Token: 0x0600210A RID: 8458 RVA: 0x00089D1D File Offset: 0x00087F1D
		public bool IsPrivate
		{
			get
			{
				return (this.Attributes & FieldAttributes.FieldAccessMask) == FieldAttributes.Private;
			}
		}

		/// <summary>Gets a value indicating whether the field is public.</summary>
		/// <returns>
		///     <see langword="true" /> if this field is public; otherwise, <see langword="false" />.</returns>
		// Token: 0x17000424 RID: 1060
		// (get) Token: 0x0600210B RID: 8459 RVA: 0x00089D2A File Offset: 0x00087F2A
		public bool IsPublic
		{
			get
			{
				return (this.Attributes & FieldAttributes.FieldAccessMask) == FieldAttributes.Public;
			}
		}

		/// <summary>Gets a <see langword="RuntimeFieldHandle" />, which is a handle to the internal metadata representation of a field.</summary>
		/// <returns>A handle to the internal metadata representation of a field.</returns>
		// Token: 0x17000425 RID: 1061
		// (get) Token: 0x0600210C RID: 8460
		public abstract RuntimeFieldHandle FieldHandle { get; }

		/// <summary>Returns a value that indicates whether this instance is equal to a specified object.</summary>
		/// <param name="obj">An object to compare with this instance, or <see langword="null" />.</param>
		/// <returns>
		///     <see langword="true" /> if <paramref name="obj" /> equals the type and value of this instance; otherwise, <see langword="false" />.</returns>
		// Token: 0x0600210D RID: 8461 RVA: 0x00089BF8 File Offset: 0x00087DF8
		public override bool Equals(object obj)
		{
			return base.Equals(obj);
		}

		/// <summary>Returns the hash code for this instance.</summary>
		/// <returns>A 32-bit signed integer hash code.</returns>
		// Token: 0x0600210E RID: 8462 RVA: 0x00089C01 File Offset: 0x00087E01
		public override int GetHashCode()
		{
			return base.GetHashCode();
		}

		/// <summary>Indicates whether two <see cref="T:System.Reflection.FieldInfo" /> objects are equal.</summary>
		/// <param name="left">The first object to compare.</param>
		/// <param name="right">The second object to compare.</param>
		/// <returns>
		///     <see langword="true" /> if <paramref name="left" /> is equal to <paramref name="right" />; otherwise, <see langword="false" />.</returns>
		// Token: 0x0600210F RID: 8463 RVA: 0x0003F3D8 File Offset: 0x0003D5D8
		public static bool operator ==(FieldInfo left, FieldInfo right)
		{
			return left == right || (left != null && right != null && left.Equals(right));
		}

		/// <summary>Indicates whether two <see cref="T:System.Reflection.FieldInfo" /> objects are not equal.</summary>
		/// <param name="left">The first object to compare.</param>
		/// <param name="right">The second object to compare.</param>
		/// <returns>
		///     <see langword="true" /> if <paramref name="left" /> is not equal to <paramref name="right" />; otherwise, <see langword="false" />.</returns>
		// Token: 0x06002110 RID: 8464 RVA: 0x00089D37 File Offset: 0x00087F37
		public static bool operator !=(FieldInfo left, FieldInfo right)
		{
			return !(left == right);
		}

		/// <summary>When overridden in a derived class, returns the value of a field supported by a given object.</summary>
		/// <param name="obj">The object whose field value will be returned. </param>
		/// <returns>An object containing the value of the field reflected by this instance.</returns>
		/// <exception cref="T:System.Reflection.TargetException">In the .NET for Windows Store apps or the Portable Class Library, catch <see cref="T:System.Exception" /> instead.The field is non-static and <paramref name="obj" /> is <see langword="null" />. </exception>
		/// <exception cref="T:System.NotSupportedException">A field is marked literal, but the field does not have one of the accepted literal types. </exception>
		/// <exception cref="T:System.FieldAccessException">In the .NET for Windows Store apps or the Portable Class Library, catch the base class exception, <see cref="T:System.MemberAccessException" />, instead.The caller does not have permission to access this field. </exception>
		/// <exception cref="T:System.ArgumentException">The method is neither declared nor inherited by the class of <paramref name="obj" />. </exception>
		// Token: 0x06002111 RID: 8465
		public abstract object GetValue(object obj);

		/// <summary>Sets the value of the field supported by the given object.</summary>
		/// <param name="obj">The object whose field value will be set. </param>
		/// <param name="value">The value to assign to the field. </param>
		/// <exception cref="T:System.FieldAccessException">
		///           In the .NET for Windows Store apps or the Portable Class Library, catch the base class exception, <see cref="T:System.MemberAccessException" />, instead.The caller does not have permission to access this field. </exception>
		/// <exception cref="T:System.Reflection.TargetException">
		///           In the .NET for Windows Store apps or the Portable Class Library, catch <see cref="T:System.Exception" /> instead.The <paramref name="obj" /> parameter is <see langword="null" /> and the field is an instance field. </exception>
		/// <exception cref="T:System.ArgumentException">The field does not exist on the object.-or- The <paramref name="value" /> parameter cannot be converted and stored in the field. </exception>
		// Token: 0x06002112 RID: 8466 RVA: 0x00089D43 File Offset: 0x00087F43
		[DebuggerHidden]
		[DebuggerStepThrough]
		public void SetValue(object obj, object value)
		{
			this.SetValue(obj, value, BindingFlags.Default, Type.DefaultBinder, null);
		}

		/// <summary>When overridden in a derived class, sets the value of the field supported by the given object.</summary>
		/// <param name="obj">The object whose field value will be set. </param>
		/// <param name="value">The value to assign to the field. </param>
		/// <param name="invokeAttr">A field of <see langword="Binder" /> that specifies the type of binding that is desired (for example, <see langword="Binder.CreateInstance" /> or <see langword="Binder.ExactBinding" />). </param>
		/// <param name="binder">A set of properties that enables the binding, coercion of argument types, and invocation of members through reflection. If <paramref name="binder" /> is <see langword="null" />, then <see langword="Binder.DefaultBinding" /> is used. </param>
		/// <param name="culture">The software preferences of a particular culture. </param>
		/// <exception cref="T:System.FieldAccessException">The caller does not have permission to access this field. </exception>
		/// <exception cref="T:System.Reflection.TargetException">The <paramref name="obj" /> parameter is <see langword="null" /> and the field is an instance field. </exception>
		/// <exception cref="T:System.ArgumentException">The field does not exist on the object.-or- The <paramref name="value" /> parameter cannot be converted and stored in the field. </exception>
		// Token: 0x06002113 RID: 8467
		public abstract void SetValue(object obj, object value, BindingFlags invokeAttr, Binder binder, CultureInfo culture);

		/// <summary>Sets the value of the field supported by the given object.</summary>
		/// <param name="obj">A <see cref="T:System.TypedReference" /> structure that encapsulates a managed pointer to a location and a runtime representation of the type that can be stored at that location. </param>
		/// <param name="value">The value to assign to the field. </param>
		/// <exception cref="T:System.NotSupportedException">The caller requires the Common Language Specification (CLS) alternative, but called this method instead. </exception>
		// Token: 0x06002114 RID: 8468 RVA: 0x00089D54 File Offset: 0x00087F54
		[CLSCompliant(false)]
		public virtual void SetValueDirect(TypedReference obj, object value)
		{
			throw new NotSupportedException("This non-CLS method is not implemented.");
		}

		/// <summary>Returns a literal value associated with the field by a compiler. </summary>
		/// <returns>An <see cref="T:System.Object" /> that contains the literal value associated with the field. If the literal value is a class type with an element value of zero, the return value is <see langword="null" />.</returns>
		/// <exception cref="T:System.InvalidOperationException">The Constant table in unmanaged metadata does not contain a constant value for the current field.</exception>
		/// <exception cref="T:System.FormatException">The type of the value is not one of the types permitted by the Common Language Specification (CLS). See the ECMA Partition II specification Metadata Logical Format: Other Structures, Element Types used in Signatures. </exception>
		/// <exception cref="T:System.NotSupportedException">The constant value for the field is not set. </exception>
		// Token: 0x06002115 RID: 8469 RVA: 0x00089D54 File Offset: 0x00087F54
		public virtual object GetRawConstantValue()
		{
			throw new NotSupportedException("This non-CLS method is not implemented.");
		}

		// Token: 0x06002116 RID: 8470
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FieldInfo internal_from_handle_type(IntPtr field_handle, IntPtr type_handle);

		/// <summary>Gets a <see cref="T:System.Reflection.FieldInfo" /> for the field represented by the specified handle.</summary>
		/// <param name="handle">A <see cref="T:System.RuntimeFieldHandle" /> structure that contains the handle to the internal metadata representation of a field. </param>
		/// <returns>A <see cref="T:System.Reflection.FieldInfo" /> object representing the field specified by <paramref name="handle" />.</returns>
		/// <exception cref="T:System.ArgumentException">
		///         <paramref name="handle" /> is invalid.</exception>
		// Token: 0x06002117 RID: 8471 RVA: 0x00089D60 File Offset: 0x00087F60
		public static FieldInfo GetFieldFromHandle(RuntimeFieldHandle handle)
		{
			if (handle.Value == IntPtr.Zero)
			{
				throw new ArgumentException("The handle is invalid.");
			}
			return FieldInfo.internal_from_handle_type(handle.Value, IntPtr.Zero);
		}

		/// <summary>Gets a <see cref="T:System.Reflection.FieldInfo" /> for the field represented by the specified handle, for the specified generic type.</summary>
		/// <param name="handle">A <see cref="T:System.RuntimeFieldHandle" /> structure that contains the handle to the internal metadata representation of a field.</param>
		/// <param name="declaringType">A <see cref="T:System.RuntimeTypeHandle" /> structure that contains the handle to the generic type that defines the field.</param>
		/// <returns>A <see cref="T:System.Reflection.FieldInfo" /> object representing the field specified by <paramref name="handle" />, in the generic type specified by <paramref name="declaringType" />.</returns>
		/// <exception cref="T:System.ArgumentException">
		///         <paramref name="handle" /> is invalid.-or-
		///         <paramref name="declaringType" /> is not compatible with <paramref name="handle" />. For example, <paramref name="declaringType" /> is the runtime type handle of the generic type definition, and <paramref name="handle" /> comes from a constructed type. See Remarks.</exception>
		// Token: 0x06002118 RID: 8472 RVA: 0x00089D94 File Offset: 0x00087F94
		[ComVisible(false)]
		public static FieldInfo GetFieldFromHandle(RuntimeFieldHandle handle, RuntimeTypeHandle declaringType)
		{
			if (handle.Value == IntPtr.Zero)
			{
				throw new ArgumentException("The handle is invalid.");
			}
			FieldInfo fieldInfo = FieldInfo.internal_from_handle_type(handle.Value, declaringType.Value);
			if (fieldInfo == null)
			{
				throw new ArgumentException("The field handle and the type handle are incompatible.");
			}
			return fieldInfo;
		}

		// Token: 0x06002119 RID: 8473 RVA: 0x00089DE6 File Offset: 0x00087FE6
		internal virtual int GetFieldOffset()
		{
			throw new SystemException("This method should not be called");
		}

		// Token: 0x0600211A RID: 8474
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern MarshalAsAttribute get_marshal_info();

		// Token: 0x0600211B RID: 8475 RVA: 0x00089DF4 File Offset: 0x00087FF4
		internal object[] GetPseudoCustomAttributes()
		{
			int num = 0;
			if (this.IsNotSerialized)
			{
				num++;
			}
			if (this.DeclaringType.IsExplicitLayout)
			{
				num++;
			}
			MarshalAsAttribute marshal_info = this.get_marshal_info();
			if (marshal_info != null)
			{
				num++;
			}
			if (num == 0)
			{
				return null;
			}
			object[] array = new object[num];
			num = 0;
			if (this.IsNotSerialized)
			{
				array[num++] = new NonSerializedAttribute();
			}
			if (this.DeclaringType.IsExplicitLayout)
			{
				array[num++] = new FieldOffsetAttribute(this.GetFieldOffset());
			}
			if (marshal_info != null)
			{
				array[num++] = marshal_info;
			}
			return array;
		}

		// Token: 0x0600211C RID: 8476 RVA: 0x00089E7C File Offset: 0x0008807C
		internal CustomAttributeData[] GetPseudoCustomAttributesData()
		{
			int num = 0;
			if (this.IsNotSerialized)
			{
				num++;
			}
			if (this.DeclaringType.IsExplicitLayout)
			{
				num++;
			}
			MarshalAsAttribute marshal_info = this.get_marshal_info();
			if (marshal_info != null)
			{
				num++;
			}
			if (num == 0)
			{
				return null;
			}
			CustomAttributeData[] array = new CustomAttributeData[num];
			num = 0;
			if (this.IsNotSerialized)
			{
				array[num++] = new CustomAttributeData(typeof(NonSerializedAttribute).GetConstructor(Type.EmptyTypes));
			}
			if (this.DeclaringType.IsExplicitLayout)
			{
				CustomAttributeTypedArgument[] ctorArgs = new CustomAttributeTypedArgument[]
				{
					new CustomAttributeTypedArgument(typeof(int), this.GetFieldOffset())
				};
				array[num++] = new CustomAttributeData(typeof(FieldOffsetAttribute).GetConstructor(new Type[]
				{
					typeof(int)
				}), ctorArgs, EmptyArray<CustomAttributeNamedArgument>.Value);
			}
			if (marshal_info != null)
			{
				CustomAttributeTypedArgument[] ctorArgs2 = new CustomAttributeTypedArgument[]
				{
					new CustomAttributeTypedArgument(typeof(UnmanagedType), marshal_info.Value)
				};
				array[num++] = new CustomAttributeData(typeof(MarshalAsAttribute).GetConstructor(new Type[]
				{
					typeof(UnmanagedType)
				}), ctorArgs2, EmptyArray<CustomAttributeNamedArgument>.Value);
			}
			return array;
		}
	}
}
