using System;

namespace System.Reflection
{
	/// <summary>Discovers the attributes of a method and provides access to method metadata.</summary>
	// Token: 0x020004AB RID: 1195
	[Serializable]
	public abstract class MethodInfo : MethodBase
	{
		/// <summary>Gets a <see cref="T:System.Reflection.MemberTypes" /> value indicating that this member is a method.</summary>
		/// <returns>A <see cref="T:System.Reflection.MemberTypes" /> value indicating that this member is a method.</returns>
		// Token: 0x1700043A RID: 1082
		// (get) Token: 0x0600215B RID: 8539 RVA: 0x0002B5F5 File Offset: 0x000297F5
		public override MemberTypes MemberType
		{
			get
			{
				return MemberTypes.Method;
			}
		}

		/// <summary>Gets a <see cref="T:System.Reflection.ParameterInfo" /> object that contains information about the return type of the method, such as whether the return type has custom modifiers. </summary>
		/// <returns>A <see cref="T:System.Reflection.ParameterInfo" /> object that contains information about the return type.</returns>
		/// <exception cref="T:System.NotImplementedException">This method is not implemented.</exception>
		// Token: 0x1700043B RID: 1083
		// (get) Token: 0x0600215C RID: 8540 RVA: 0x0002AC9D File Offset: 0x00028E9D
		public virtual ParameterInfo ReturnParameter
		{
			get
			{
				throw NotImplemented.ByDesign;
			}
		}

		/// <summary>Gets the return type of this method.</summary>
		/// <returns>The return type of this method.</returns>
		// Token: 0x1700043C RID: 1084
		// (get) Token: 0x0600215D RID: 8541 RVA: 0x0002AC9D File Offset: 0x00028E9D
		public virtual Type ReturnType
		{
			get
			{
				throw NotImplemented.ByDesign;
			}
		}

		/// <summary>Returns an array of <see cref="T:System.Type" /> objects that represent the type arguments of a generic method or the type parameters of a generic method definition.</summary>
		/// <returns>An array of <see cref="T:System.Type" /> objects that represent the type arguments of a generic method or the type parameters of a generic method definition. Returns an empty array if the current method is not a generic method.</returns>
		/// <exception cref="T:System.NotSupportedException">This method is not supported.</exception>
		// Token: 0x0600215E RID: 8542 RVA: 0x0002ACDC File Offset: 0x00028EDC
		public override Type[] GetGenericArguments()
		{
			throw new NotSupportedException("Derived classes must provide an implementation.");
		}

		/// <summary>Returns a <see cref="T:System.Reflection.MethodInfo" /> object that represents a generic method definition from which the current method can be constructed.</summary>
		/// <returns>A <see cref="T:System.Reflection.MethodInfo" /> object representing a generic method definition from which the current method can be constructed.</returns>
		/// <exception cref="T:System.InvalidOperationException">The current method is not a generic method. That is, <see cref="P:System.Reflection.MethodInfo.IsGenericMethod" /> returns <see langword="false" />. </exception>
		/// <exception cref="T:System.NotSupportedException">This method is not supported.</exception>
		// Token: 0x0600215F RID: 8543 RVA: 0x0002ACDC File Offset: 0x00028EDC
		public virtual MethodInfo GetGenericMethodDefinition()
		{
			throw new NotSupportedException("Derived classes must provide an implementation.");
		}

		/// <summary>Substitutes the elements of an array of types for the type parameters of the current generic method definition, and returns a <see cref="T:System.Reflection.MethodInfo" /> object representing the resulting constructed method.</summary>
		/// <param name="typeArguments">An array of types to be substituted for the type parameters of the current generic method definition.</param>
		/// <returns>A <see cref="T:System.Reflection.MethodInfo" /> object that represents the constructed method formed by substituting the elements of <paramref name="typeArguments" /> for the type parameters of the current generic method definition.</returns>
		/// <exception cref="T:System.InvalidOperationException">The current <see cref="T:System.Reflection.MethodInfo" /> does not represent a generic method definition. That is, <see cref="P:System.Reflection.MethodInfo.IsGenericMethodDefinition" /> returns <see langword="false" />.</exception>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="typeArguments" /> is <see langword="null" />.-or- Any element of <paramref name="typeArguments" /> is <see langword="null" />. </exception>
		/// <exception cref="T:System.ArgumentException">The number of elements in <paramref name="typeArguments" /> is not the same as the number of type parameters of the current generic method definition.-or- An element of <paramref name="typeArguments" /> does not satisfy the constraints specified for the corresponding type parameter of the current generic method definition. </exception>
		/// <exception cref="T:System.NotSupportedException">This method is not supported.</exception>
		// Token: 0x06002160 RID: 8544 RVA: 0x0002ACDC File Offset: 0x00028EDC
		public virtual MethodInfo MakeGenericMethod(params Type[] typeArguments)
		{
			throw new NotSupportedException("Derived classes must provide an implementation.");
		}

		/// <summary>When overridden in a derived class, returns the <see cref="T:System.Reflection.MethodInfo" /> object for the method on the direct or indirect base class in which the method represented by this instance was first declared.</summary>
		/// <returns>A <see cref="T:System.Reflection.MethodInfo" /> object for the first implementation of this method.</returns>
		// Token: 0x06002161 RID: 8545
		public abstract MethodInfo GetBaseDefinition();

		/// <summary>Creates a delegate of the specified type from this method.</summary>
		/// <param name="delegateType">The type of the delegate to create.</param>
		/// <returns>The delegate for this method.</returns>
		// Token: 0x06002162 RID: 8546 RVA: 0x0002ACDC File Offset: 0x00028EDC
		public virtual Delegate CreateDelegate(Type delegateType)
		{
			throw new NotSupportedException("Derived classes must provide an implementation.");
		}

		/// <summary>Creates a delegate of the specified type with the specified target from this method.</summary>
		/// <param name="delegateType">The type of the delegate to create.</param>
		/// <param name="target">The object targeted by the delegate.</param>
		/// <returns>The delegate for this method.</returns>
		// Token: 0x06002163 RID: 8547 RVA: 0x0002ACDC File Offset: 0x00028EDC
		public virtual Delegate CreateDelegate(Type delegateType, object target)
		{
			throw new NotSupportedException("Derived classes must provide an implementation.");
		}

		/// <summary>Returns a value that indicates whether this instance is equal to a specified object.</summary>
		/// <param name="obj">An object to compare with this instance, or <see langword="null" />.</param>
		/// <returns>
		///     <see langword="true" /> if <paramref name="obj" /> equals the type and value of this instance; otherwise, <see langword="false" />.</returns>
		// Token: 0x06002164 RID: 8548 RVA: 0x00089B1C File Offset: 0x00087D1C
		public override bool Equals(object obj)
		{
			return base.Equals(obj);
		}

		/// <summary>Returns the hash code for this instance.</summary>
		/// <returns>A 32-bit signed integer hash code.</returns>
		// Token: 0x06002165 RID: 8549 RVA: 0x00089B25 File Offset: 0x00087D25
		public override int GetHashCode()
		{
			return base.GetHashCode();
		}

		/// <summary>Indicates whether two <see cref="T:System.Reflection.MethodInfo" /> objects are equal.</summary>
		/// <param name="left">The first object to compare.</param>
		/// <param name="right">The second object to compare.</param>
		/// <returns>
		///     <see langword="true" /> if <paramref name="left" /> is equal to <paramref name="right" />; otherwise, <see langword="false" />.</returns>
		// Token: 0x06002166 RID: 8550 RVA: 0x0003F3D8 File Offset: 0x0003D5D8
		public static bool operator ==(MethodInfo left, MethodInfo right)
		{
			return left == right || (left != null && right != null && left.Equals(right));
		}

		/// <summary>Indicates whether two <see cref="T:System.Reflection.MethodInfo" /> objects are not equal.</summary>
		/// <param name="left">The first object to compare.</param>
		/// <param name="right">The second object to compare.</param>
		/// <returns>
		///     <see langword="true" /> if <paramref name="left" /> is not equal to <paramref name="right" />; otherwise, <see langword="false" />.</returns>
		// Token: 0x06002167 RID: 8551 RVA: 0x0008A498 File Offset: 0x00088698
		public static bool operator !=(MethodInfo left, MethodInfo right)
		{
			return !(left == right);
		}

		// Token: 0x1700043D RID: 1085
		// (get) Token: 0x06002168 RID: 8552 RVA: 0x0008A4A4 File Offset: 0x000886A4
		internal virtual int GenericParameterCount
		{
			get
			{
				return this.GetGenericArguments().Length;
			}
		}
	}
}
