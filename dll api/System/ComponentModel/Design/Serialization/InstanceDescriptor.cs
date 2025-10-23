﻿using System;
using System.Collections;
using System.Reflection;

namespace System.ComponentModel.Design.Serialization
{
	/// <summary>Provides the information necessary to create an instance of an object. This class cannot be inherited.</summary>
	// Token: 0x020002BD RID: 701
	public sealed class InstanceDescriptor
	{
		/// <summary>Initializes a new instance of the <see cref="T:System.ComponentModel.Design.Serialization.InstanceDescriptor" /> class using the specified member information and arguments.</summary>
		/// <param name="member">The member information for the descriptor. This can be a <see cref="T:System.Reflection.MethodInfo" />, <see cref="T:System.Reflection.ConstructorInfo" />, <see cref="T:System.Reflection.FieldInfo" />, or <see cref="T:System.Reflection.PropertyInfo" />. If this is a <see cref="T:System.Reflection.MethodInfo" />, <see cref="T:System.Reflection.FieldInfo" />, or <see cref="T:System.Reflection.PropertyInfo" />, it must represent a <see langword="static" /> member. </param>
		/// <param name="arguments">The collection of arguments to pass to the member. This parameter can be <see langword="null" /> or an empty collection if there are no arguments. The collection can also consist of other instances of <see cref="T:System.ComponentModel.Design.Serialization.InstanceDescriptor" />. </param>
		/// <exception cref="T:System.ArgumentException">
		///         <paramref name="member" /> is of type <see cref="T:System.Reflection.MethodInfo" />, <see cref="T:System.Reflection.FieldInfo" />, or <see cref="T:System.Reflection.PropertyInfo" />, and it does not represent a <see langword="static" /> member.
		///         <paramref name="member" /> is of type <see cref="T:System.Reflection.PropertyInfo" /> and is not readable.
		///         <paramref name="member" /> is of type <see cref="T:System.Reflection.MethodInfo" /> or <see cref="T:System.Reflection.ConstructorInfo" />, and the number of arguments in <paramref name="arguments" /> does not match the signature of <paramref name="member." />
		///         <paramref name="member" /> is of type <see cref="T:System.Reflection.ConstructorInfo" /> and represents a <see langword="static" /> member.
		///         <paramref name="member" /> is of type <see cref="T:System.Reflection.FieldInfo" />, and the number of arguments in <paramref name="arguments" /> is not zero. </exception>
		// Token: 0x060012A5 RID: 4773 RVA: 0x0005939E File Offset: 0x0005759E
		public InstanceDescriptor(MemberInfo member, ICollection arguments) : this(member, arguments, true)
		{
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.ComponentModel.Design.Serialization.InstanceDescriptor" /> class using the specified member information, arguments, and value indicating whether the specified information completely describes the instance.</summary>
		/// <param name="member">The member information for the descriptor. This can be a <see cref="T:System.Reflection.MethodInfo" />, <see cref="T:System.Reflection.ConstructorInfo" />, <see cref="T:System.Reflection.FieldInfo" />, or <see cref="T:System.Reflection.PropertyInfo" />. If this is a <see cref="T:System.Reflection.MethodInfo" />, <see cref="T:System.Reflection.FieldInfo" />, or <see cref="T:System.Reflection.PropertyInfo" />, it must represent a <see langword="static" /> member. </param>
		/// <param name="arguments">The collection of arguments to pass to the member. This parameter can be <see langword="null" /> or an empty collection if there are no arguments. The collection can also consist of other instances of <see cref="T:System.ComponentModel.Design.Serialization.InstanceDescriptor" />. </param>
		/// <param name="isComplete">
		///       <see langword="true" /> if the specified information completely describes the instance; otherwise, <see langword="false" />. </param>
		/// <exception cref="T:System.ArgumentException">
		///         <paramref name="member" /> is of type <see cref="T:System.Reflection.MethodInfo" />, <see cref="T:System.Reflection.FieldInfo" />, or <see cref="T:System.Reflection.PropertyInfo" />, and it does not represent a <see langword="static" /> member
		///         <paramref name="member" /> is of type <see cref="T:System.Reflection.PropertyInfo" /> and is not readable.
		///         <paramref name="member" /> is of type <see cref="T:System.Reflection.MethodInfo" /> or <see cref="T:System.Reflection.ConstructorInfo" /> and the number of arguments in <paramref name="arguments" /> does not match the signature of <paramref name="member" />.
		///         <paramref name="member" /> is of type <see cref="T:System.Reflection.ConstructorInfo" /> and represents a <see langword="static" /> member
		///         <paramref name="member" /> is of type <see cref="T:System.Reflection.FieldInfo" />, and the number of arguments in <paramref name="arguments" /> is not zero.</exception>
		// Token: 0x060012A6 RID: 4774 RVA: 0x000593AC File Offset: 0x000575AC
		public InstanceDescriptor(MemberInfo member, ICollection arguments, bool isComplete)
		{
			this.MemberInfo = member;
			this.<IsComplete>k__BackingField = isComplete;
			if (arguments == null)
			{
				this.Arguments = Array.Empty<object>();
			}
			else
			{
				object[] array = new object[arguments.Count];
				arguments.CopyTo(array, 0);
				this.Arguments = array;
			}
			if (member is FieldInfo)
			{
				if (!((FieldInfo)member).IsStatic)
				{
					throw new ArgumentException("Parameter must be static.");
				}
				if (this.Arguments.Count != 0)
				{
					throw new ArgumentException("Length mismatch.");
				}
			}
			else if (member is ConstructorInfo)
			{
				ConstructorInfo constructorInfo = (ConstructorInfo)member;
				if (constructorInfo.IsStatic)
				{
					throw new ArgumentException("Parameter cannot be static.");
				}
				if (this.Arguments.Count != constructorInfo.GetParameters().Length)
				{
					throw new ArgumentException("Length mismatch.");
				}
			}
			else if (member is MethodInfo)
			{
				MethodInfo methodInfo = (MethodInfo)member;
				if (!methodInfo.IsStatic)
				{
					throw new ArgumentException("Parameter must be static.");
				}
				if (this.Arguments.Count != methodInfo.GetParameters().Length)
				{
					throw new ArgumentException("Length mismatch.");
				}
			}
			else if (member is PropertyInfo)
			{
				PropertyInfo propertyInfo = (PropertyInfo)member;
				if (!propertyInfo.CanRead)
				{
					throw new ArgumentException("Parameter must be readable.");
				}
				MethodInfo getMethod = propertyInfo.GetGetMethod();
				if (getMethod != null && !getMethod.IsStatic)
				{
					throw new ArgumentException("Parameter must be static.");
				}
			}
		}

		/// <summary>Gets the collection of arguments that can be used to reconstruct an instance of the object that this instance descriptor represents.</summary>
		/// <returns>An <see cref="T:System.Collections.ICollection" /> of arguments that can be used to create the object.</returns>
		// Token: 0x170003AF RID: 943
		// (get) Token: 0x060012A7 RID: 4775 RVA: 0x000594FD File Offset: 0x000576FD
		public ICollection Arguments { get; }

		/// <summary>Gets the member information that describes the instance this descriptor is associated with.</summary>
		/// <returns>A <see cref="T:System.Reflection.MemberInfo" /> that describes the instance that this object is associated with.</returns>
		// Token: 0x170003B0 RID: 944
		// (get) Token: 0x060012A8 RID: 4776 RVA: 0x00059505 File Offset: 0x00057705
		public MemberInfo MemberInfo { get; }

		/// <summary>Invokes this instance descriptor and returns the object the descriptor describes.</summary>
		/// <returns>The object this instance descriptor describes.</returns>
		// Token: 0x060012A9 RID: 4777 RVA: 0x00059510 File Offset: 0x00057710
		public object Invoke()
		{
			object[] array = new object[this.Arguments.Count];
			this.Arguments.CopyTo(array, 0);
			for (int i = 0; i < array.Length; i++)
			{
				if (array[i] is InstanceDescriptor)
				{
					array[i] = ((InstanceDescriptor)array[i]).Invoke();
				}
			}
			if (this.MemberInfo is ConstructorInfo)
			{
				return ((ConstructorInfo)this.MemberInfo).Invoke(array);
			}
			if (this.MemberInfo is MethodInfo)
			{
				return ((MethodInfo)this.MemberInfo).Invoke(null, array);
			}
			if (this.MemberInfo is PropertyInfo)
			{
				return ((PropertyInfo)this.MemberInfo).GetValue(null, array);
			}
			if (this.MemberInfo is FieldInfo)
			{
				return ((FieldInfo)this.MemberInfo).GetValue(null);
			}
			return null;
		}
	}
}
