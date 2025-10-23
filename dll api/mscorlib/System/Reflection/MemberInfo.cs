using System;
using System.Collections.Generic;

namespace System.Reflection
{
	/// <summary>Obtains information about the attributes of a member and provides access to member metadata.</summary>
	// Token: 0x020004A6 RID: 1190
	[Serializable]
	public abstract class MemberInfo : ICustomAttributeProvider
	{
		/// <summary>When overridden in a derived class, gets a <see cref="T:System.Reflection.MemberTypes" /> value indicating the type of the member — method, constructor, event, and so on.</summary>
		/// <returns>A <see cref="T:System.Reflection.MemberTypes" /> value indicating the type of member.</returns>
		// Token: 0x17000426 RID: 1062
		// (get) Token: 0x0600212B RID: 8491
		public abstract MemberTypes MemberType { get; }

		/// <summary>Gets the name of the current member.</summary>
		/// <returns>A <see cref="T:System.String" /> containing the name of this member.</returns>
		// Token: 0x17000427 RID: 1063
		// (get) Token: 0x0600212C RID: 8492
		public abstract string Name { get; }

		/// <summary>Gets the class that declares this member.</summary>
		/// <returns>The <see langword="Type" /> object for the class that declares this member.</returns>
		// Token: 0x17000428 RID: 1064
		// (get) Token: 0x0600212D RID: 8493
		public abstract Type DeclaringType { get; }

		/// <summary>Gets the class object that was used to obtain this instance of <see langword="MemberInfo" />.</summary>
		/// <returns>The <see langword="Type" /> object through which this <see langword="MemberInfo" /> object was obtained.</returns>
		// Token: 0x17000429 RID: 1065
		// (get) Token: 0x0600212E RID: 8494
		public abstract Type ReflectedType { get; }

		/// <summary>Gets the module in which the type that declares the member represented by the current <see cref="T:System.Reflection.MemberInfo" /> is defined.</summary>
		/// <returns>The <see cref="T:System.Reflection.Module" /> in which the type that declares the member represented by the current <see cref="T:System.Reflection.MemberInfo" /> is defined.</returns>
		/// <exception cref="T:System.NotImplementedException">This method is not implemented.</exception>
		// Token: 0x1700042A RID: 1066
		// (get) Token: 0x0600212F RID: 8495 RVA: 0x0008A01C File Offset: 0x0008821C
		public virtual Module Module
		{
			get
			{
				Type type = this as Type;
				if (type != null)
				{
					return type.Module;
				}
				throw NotImplemented.ByDesign;
			}
		}

		/// <summary>When overridden in a derived class, indicates whether one or more attributes of the specified type or of its derived types is applied to this member.</summary>
		/// <param name="attributeType">The type of custom attribute to search for. The search includes derived types.</param>
		/// <param name="inherit">
		///       <see langword="true" /> to search this member's inheritance chain to find the attributes; otherwise, <see langword="false" />. This parameter is ignored for properties and events; see Remarks.</param>
		/// <returns>
		///     <see langword="true" /> if one or more instances of <paramref name="attributeType" /> or any of its derived types is applied to this member; otherwise, <see langword="false" />.</returns>
		// Token: 0x06002130 RID: 8496
		public abstract bool IsDefined(Type attributeType, bool inherit);

		/// <summary>When overridden in a derived class, returns an array of all custom attributes applied to this member. </summary>
		/// <param name="inherit">
		///       <see langword="true" /> to search this member's inheritance chain to find the attributes; otherwise, <see langword="false" />. This parameter is ignored for properties and events; see Remarks.</param>
		/// <returns>An array that contains all the custom attributes applied to this member, or an array with zero elements if no attributes are defined.</returns>
		/// <exception cref="T:System.InvalidOperationException">This member belongs to a type that is loaded into the reflection-only context. See How to: Load Assemblies into the Reflection-Only Context.</exception>
		/// <exception cref="T:System.TypeLoadException">A custom attribute type could not be loaded. </exception>
		// Token: 0x06002131 RID: 8497
		public abstract object[] GetCustomAttributes(bool inherit);

		/// <summary>When overridden in a derived class, returns an array of custom attributes applied to this member and identified by <see cref="T:System.Type" />.</summary>
		/// <param name="attributeType">The type of attribute to search for. Only attributes that are assignable to this type are returned. </param>
		/// <param name="inherit">
		///       <see langword="true" /> to search this member's inheritance chain to find the attributes; otherwise, <see langword="false" />. This parameter is ignored for properties and events; see Remarks. </param>
		/// <returns>An array of custom attributes applied to this member, or an array with zero elements if no attributes assignable to <paramref name="attributeType" /> have been applied.</returns>
		/// <exception cref="T:System.TypeLoadException">A custom attribute type cannot be loaded. </exception>
		/// <exception cref="T:System.ArgumentNullException">If <paramref name="attributeType" /> is <see langword="null" />.</exception>
		/// <exception cref="T:System.InvalidOperationException">This member belongs to a type that is loaded into the reflection-only context. See How to: Load Assemblies into the Reflection-Only Context.</exception>
		// Token: 0x06002132 RID: 8498
		public abstract object[] GetCustomAttributes(Type attributeType, bool inherit);

		/// <summary>Gets a collection that contains this member's custom attributes.</summary>
		/// <returns>A collection that contains this member's custom attributes.</returns>
		// Token: 0x1700042B RID: 1067
		// (get) Token: 0x06002133 RID: 8499 RVA: 0x0008A045 File Offset: 0x00088245
		public virtual IEnumerable<CustomAttributeData> CustomAttributes
		{
			get
			{
				return this.GetCustomAttributesData();
			}
		}

		/// <summary>Returns a list of <see cref="T:System.Reflection.CustomAttributeData" /> objects representing data about the attributes that have been applied to the target member.</summary>
		/// <returns>A generic list of <see cref="T:System.Reflection.CustomAttributeData" /> objects representing data about the attributes that have been applied to the target member.</returns>
		// Token: 0x06002134 RID: 8500 RVA: 0x0002AC9D File Offset: 0x00028E9D
		public virtual IList<CustomAttributeData> GetCustomAttributesData()
		{
			throw NotImplemented.ByDesign;
		}

		/// <summary>Gets a value that identifies a metadata element.</summary>
		/// <returns>A value which, in combination with <see cref="P:System.Reflection.MemberInfo.Module" />, uniquely identifies a metadata element.</returns>
		/// <exception cref="T:System.InvalidOperationException">The current <see cref="T:System.Reflection.MemberInfo" /> represents an array method, such as <see langword="Address" />, on an array type whose element type is a dynamic type that has not been completed. To get a metadata token in this case, pass the <see cref="T:System.Reflection.MemberInfo" /> object to the <see cref="M:System.Reflection.Emit.ModuleBuilder.GetMethodToken(System.Reflection.MethodInfo)" /> method; or use the <see cref="M:System.Reflection.Emit.ModuleBuilder.GetArrayMethodToken(System.Type,System.String,System.Reflection.CallingConventions,System.Type,System.Type[])" />  method to get the token directly, instead of using the <see cref="M:System.Reflection.Emit.ModuleBuilder.GetArrayMethod(System.Type,System.String,System.Reflection.CallingConventions,System.Type,System.Type[])" /> method to get a <see cref="T:System.Reflection.MethodInfo" /> first.</exception>
		// Token: 0x1700042C RID: 1068
		// (get) Token: 0x06002135 RID: 8501 RVA: 0x0008A04D File Offset: 0x0008824D
		public virtual int MetadataToken
		{
			get
			{
				throw new InvalidOperationException();
			}
		}

		/// <summary>Returns a value that indicates whether this instance is equal to a specified object.</summary>
		/// <param name="obj">An object to compare with this instance, or <see langword="null" />.</param>
		/// <returns>
		///     <see langword="true" /> if <paramref name="obj" /> equals the type and value of this instance; otherwise, <see langword="false" />.</returns>
		// Token: 0x06002136 RID: 8502 RVA: 0x0008A054 File Offset: 0x00088254
		public override bool Equals(object obj)
		{
			return base.Equals(obj);
		}

		/// <summary>Returns the hash code for this instance.</summary>
		/// <returns>A 32-bit signed integer hash code.</returns>
		// Token: 0x06002137 RID: 8503 RVA: 0x0005B518 File Offset: 0x00059718
		public override int GetHashCode()
		{
			return base.GetHashCode();
		}

		/// <summary>Indicates whether two <see cref="T:System.Reflection.MemberInfo" /> objects are equal.</summary>
		/// <param name="left">The <see cref="T:System.Reflection.MemberInfo" /> to compare to <paramref name="right" />.</param>
		/// <param name="right">The <see cref="T:System.Reflection.MemberInfo" /> to compare to <paramref name="left" />.</param>
		/// <returns>
		///     <see langword="true" /> if <paramref name="left" /> is equal to <paramref name="right" />; otherwise <see langword="false" />.</returns>
		// Token: 0x06002138 RID: 8504 RVA: 0x0008A060 File Offset: 0x00088260
		public static bool operator ==(MemberInfo left, MemberInfo right)
		{
			if (left == right)
			{
				return true;
			}
			if (left == null || right == null)
			{
				return false;
			}
			Type left2;
			Type right2;
			if ((left2 = (left as Type)) != null && (right2 = (right as Type)) != null)
			{
				return left2 == right2;
			}
			MethodBase left3;
			MethodBase right3;
			if ((left3 = (left as MethodBase)) != null && (right3 = (right as MethodBase)) != null)
			{
				return left3 == right3;
			}
			FieldInfo left4;
			FieldInfo right4;
			if ((left4 = (left as FieldInfo)) != null && (right4 = (right as FieldInfo)) != null)
			{
				return left4 == right4;
			}
			EventInfo left5;
			EventInfo right5;
			if ((left5 = (left as EventInfo)) != null && (right5 = (right as EventInfo)) != null)
			{
				return left5 == right5;
			}
			PropertyInfo left6;
			PropertyInfo right6;
			return (left6 = (left as PropertyInfo)) != null && (right6 = (right as PropertyInfo)) != null && left6 == right6;
		}

		/// <summary>Indicates whether two <see cref="T:System.Reflection.MemberInfo" /> objects are not equal.</summary>
		/// <param name="left">The <see cref="T:System.Reflection.MemberInfo" /> to compare to <paramref name="right" />.</param>
		/// <param name="right">The <see cref="T:System.Reflection.MemberInfo" /> to compare to <paramref name="left" />.</param>
		/// <returns>
		///     <see langword="true" /> if <paramref name="left" /> is not equal to <paramref name="right" />; otherwise <see langword="false" />.</returns>
		// Token: 0x06002139 RID: 8505 RVA: 0x0008A150 File Offset: 0x00088350
		public static bool operator !=(MemberInfo left, MemberInfo right)
		{
			return !(left == right);
		}
	}
}
