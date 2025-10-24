using System;
using System.Diagnostics;
using System.Globalization;

namespace System.Reflection
{
	/// <summary>Discovers the attributes of a class constructor and provides access to constructor metadata. </summary>
	// Token: 0x02000494 RID: 1172
	[Serializable]
	public abstract class ConstructorInfo : MethodBase
	{
		/// <summary>Gets a <see cref="T:System.Reflection.MemberTypes" /> value indicating that this member is a constructor.</summary>
		/// <returns>A <see cref="T:System.Reflection.MemberTypes" /> value indicating that this member is a constructor.</returns>
		// Token: 0x17000418 RID: 1048
		// (get) Token: 0x060020D8 RID: 8408 RVA: 0x0000B18D File Offset: 0x0000938D
		public override MemberTypes MemberType
		{
			get
			{
				return MemberTypes.Constructor;
			}
		}

		/// <summary>Invokes the constructor reflected by the instance that has the specified parameters, providing default values for the parameters not commonly used.</summary>
		/// <param name="parameters">An array of values that matches the number, order and type (under the constraints of the default binder) of the parameters for this constructor. If this constructor takes no parameters, then use either an array with zero elements or <see langword="null" />, as in Object[] parameters = new Object[0]. Any object in this array that is not explicitly initialized with a value will contain the default value for that object type. For reference-type elements, this value is <see langword="null" />. For value-type elements, this value is 0, 0.0, or <see langword="false" />, depending on the specific element type. </param>
		/// <returns>An instance of the class associated with the constructor.</returns>
		/// <exception cref="T:System.MemberAccessException">The class is abstract.-or- The constructor is a class initializer. </exception>
		/// <exception cref="T:System.MethodAccessException">
		///           In the .NET for Windows Store apps or the Portable Class Library, catch the base class exception, <see cref="T:System.MemberAccessException" />, instead.The constructor is private or protected, and the caller lacks <see cref="F:System.Security.Permissions.ReflectionPermissionFlag.MemberAccess" />. </exception>
		/// <exception cref="T:System.ArgumentException">The <paramref name="parameters" /> array does not contain values that match the types accepted by this constructor. </exception>
		/// <exception cref="T:System.Reflection.TargetInvocationException">The invoked constructor throws an exception. </exception>
		/// <exception cref="T:System.Reflection.TargetParameterCountException">An incorrect number of parameters was passed. </exception>
		/// <exception cref="T:System.NotSupportedException">Creation of <see cref="T:System.TypedReference" />, <see cref="T:System.ArgIterator" />, and <see cref="T:System.RuntimeArgumentHandle" /> types is not supported.</exception>
		/// <exception cref="T:System.Security.SecurityException">The caller does not have the necessary code access permission.</exception>
		// Token: 0x060020D9 RID: 8409 RVA: 0x00089B0C File Offset: 0x00087D0C
		[DebuggerHidden]
		[DebuggerStepThrough]
		public object Invoke(object[] parameters)
		{
			return this.Invoke(BindingFlags.CreateInstance, null, parameters, null);
		}

		/// <summary>When implemented in a derived class, invokes the constructor reflected by this <see langword="ConstructorInfo" /> with the specified arguments, under the constraints of the specified <see langword="Binder" />.</summary>
		/// <param name="invokeAttr">One of the <see langword="BindingFlags" /> values that specifies the type of binding. </param>
		/// <param name="binder">A <see langword="Binder" /> that defines a set of properties and enables the binding, coercion of argument types, and invocation of members using reflection. If <paramref name="binder" /> is <see langword="null" />, then <see langword="Binder.DefaultBinding" /> is used. </param>
		/// <param name="parameters">An array of type <see langword="Object" /> used to match the number, order and type of the parameters for this constructor, under the constraints of <paramref name="binder" />. If this constructor does not require parameters, pass an array with zero elements, as in Object[] parameters = new Object[0]. Any object in this array that is not explicitly initialized with a value will contain the default value for that object type. For reference-type elements, this value is <see langword="null" />. For value-type elements, this value is 0, 0.0, or <see langword="false" />, depending on the specific element type. </param>
		/// <param name="culture">A <see cref="T:System.Globalization.CultureInfo" /> used to govern the coercion of types. If this is <see langword="null" />, the <see cref="T:System.Globalization.CultureInfo" /> for the current thread is used. </param>
		/// <returns>An instance of the class associated with the constructor.</returns>
		/// <exception cref="T:System.ArgumentException">The <paramref name="parameters" /> array does not contain values that match the types accepted by this constructor, under the constraints of the <paramref name="binder" />. </exception>
		/// <exception cref="T:System.Reflection.TargetInvocationException">The invoked constructor throws an exception. </exception>
		/// <exception cref="T:System.Reflection.TargetParameterCountException">An incorrect number of parameters was passed. </exception>
		/// <exception cref="T:System.NotSupportedException">Creation of <see cref="T:System.TypedReference" />, <see cref="T:System.ArgIterator" />, and <see cref="T:System.RuntimeArgumentHandle" /> types is not supported.</exception>
		/// <exception cref="T:System.Security.SecurityException">The caller does not have the necessary code access permissions.</exception>
		/// <exception cref="T:System.MemberAccessException">The class is abstract.-or- The constructor is a class initializer. </exception>
		/// <exception cref="T:System.MethodAccessException">The constructor is private or protected, and the caller lacks <see cref="F:System.Security.Permissions.ReflectionPermissionFlag.MemberAccess" />. </exception>
		// Token: 0x060020DA RID: 8410
		public abstract object Invoke(BindingFlags invokeAttr, Binder binder, object[] parameters, CultureInfo culture);

		/// <summary>Returns a value that indicates whether this instance is equal to a specified object.</summary>
		/// <param name="obj">An object to compare with this instance, or <see langword="null" />.</param>
		/// <returns>
		///     <see langword="true" /> if <paramref name="obj" /> equals the type and value of this instance; otherwise, <see langword="false" />.</returns>
		// Token: 0x060020DB RID: 8411 RVA: 0x00089B1C File Offset: 0x00087D1C
		public override bool Equals(object obj)
		{
			return base.Equals(obj);
		}

		/// <summary>Returns the hash code for this instance.</summary>
		/// <returns>A 32-bit signed integer hash code.</returns>
		// Token: 0x060020DC RID: 8412 RVA: 0x00089B25 File Offset: 0x00087D25
		public override int GetHashCode()
		{
			return base.GetHashCode();
		}

		/// <summary>Indicates whether two <see cref="T:System.Reflection.ConstructorInfo" /> objects are equal.</summary>
		/// <param name="left">The first <see cref="T:System.Reflection.ConstructorInfo" /> to compare.</param>
		/// <param name="right">The second <see cref="T:System.Reflection.ConstructorInfo" /> to compare.</param>
		/// <returns>
		///     <see langword="true" /> if <paramref name="left" /> is equal to <paramref name="right" />; otherwise <see langword="false" />.</returns>
		// Token: 0x060020DD RID: 8413 RVA: 0x0003F3D8 File Offset: 0x0003D5D8
		public static bool operator ==(ConstructorInfo left, ConstructorInfo right)
		{
			return left == right || (left != null && right != null && left.Equals(right));
		}

		/// <summary>Indicates whether two <see cref="T:System.Reflection.ConstructorInfo" /> objects are not equal.</summary>
		/// <param name="left">The first <see cref="T:System.Reflection.ConstructorInfo" /> to compare.</param>
		/// <param name="right">The second <see cref="T:System.Reflection.ConstructorInfo" /> to compare.</param>
		/// <returns>
		///     <see langword="true" /> if <paramref name="left" /> is not equal to <paramref name="right" />; otherwise <see langword="false" />.</returns>
		// Token: 0x060020DE RID: 8414 RVA: 0x00089B2D File Offset: 0x00087D2D
		public static bool operator !=(ConstructorInfo left, ConstructorInfo right)
		{
			return !(left == right);
		}

		/// <summary>Represents the name of the class constructor method as it is stored in metadata. This name is always ".ctor". This field is read-only.</summary>
		// Token: 0x04000FC7 RID: 4039
		public static readonly string ConstructorName = ".ctor";

		/// <summary>Represents the name of the type constructor method as it is stored in metadata. This name is always ".cctor". This property is read-only.</summary>
		// Token: 0x04000FC8 RID: 4040
		public static readonly string TypeConstructorName = ".cctor";
	}
}
