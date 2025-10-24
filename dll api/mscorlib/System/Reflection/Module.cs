using System;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace System.Reflection
{
	/// <summary>Performs reflection on a module.</summary>
	// Token: 0x020004AD RID: 1197
	[Serializable]
	[StructLayout(0)]
	public abstract class Module : ICustomAttributeProvider, ISerializable
	{
		/// <summary>Gets the appropriate <see cref="T:System.Reflection.Assembly" /> for this instance of <see cref="T:System.Reflection.Module" />.</summary>
		/// <returns>An <see langword="Assembly" /> object.</returns>
		// Token: 0x1700043E RID: 1086
		// (get) Token: 0x0600216D RID: 8557 RVA: 0x0002AC9D File Offset: 0x00028E9D
		public virtual Assembly Assembly
		{
			get
			{
				throw NotImplemented.ByDesign;
			}
		}

		/// <summary>Gets a <see langword="String" /> representing the name of the module with the path removed.</summary>
		/// <returns>The module name with no path.</returns>
		// Token: 0x1700043F RID: 1087
		// (get) Token: 0x0600216E RID: 8558 RVA: 0x0002AC9D File Offset: 0x00028E9D
		public virtual string Name
		{
			get
			{
				throw NotImplemented.ByDesign;
			}
		}

		/// <summary>Gets a universally unique identifier (UUID) that can be used to distinguish between two versions of a module.</summary>
		/// <returns>A <see cref="T:System.Guid" /> that can be used to distinguish between two versions of a module.</returns>
		// Token: 0x17000440 RID: 1088
		// (get) Token: 0x0600216F RID: 8559 RVA: 0x0002AC9D File Offset: 0x00028E9D
		public virtual Guid ModuleVersionId
		{
			get
			{
				throw NotImplemented.ByDesign;
			}
		}

		/// <summary>Gets a string representing the name of the module.</summary>
		/// <returns>The module name.</returns>
		// Token: 0x17000441 RID: 1089
		// (get) Token: 0x06002170 RID: 8560 RVA: 0x0002AC9D File Offset: 0x00028E9D
		public virtual string ScopeName
		{
			get
			{
				throw NotImplemented.ByDesign;
			}
		}

		/// <summary>Gets a value indicating whether the object is a resource.</summary>
		/// <returns>
		///     <see langword="true" /> if the object is a resource; otherwise, <see langword="false" />.</returns>
		// Token: 0x06002171 RID: 8561 RVA: 0x0002AC9D File Offset: 0x00028E9D
		public virtual bool IsResource()
		{
			throw NotImplemented.ByDesign;
		}

		/// <summary>Returns a value that indicates whether the specified attribute type has been applied to this module.</summary>
		/// <param name="attributeType">The type of custom attribute to test for. </param>
		/// <param name="inherit">This argument is ignored for objects of this type. </param>
		/// <returns>
		///     <see langword="true" /> if one or more instances of <paramref name="attributeType" /> have been applied to this module; otherwise, <see langword="false" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="attributeType" /> is <see langword="null" />. </exception>
		/// <exception cref="T:System.ArgumentException">
		///         <paramref name="attributeType" /> is not a <see cref="T:System.Type" /> object supplied by the runtime. For example, <paramref name="attributeType" /> is a <see cref="T:System.Reflection.Emit.TypeBuilder" /> object.</exception>
		// Token: 0x06002172 RID: 8562 RVA: 0x0002AC9D File Offset: 0x00028E9D
		public virtual bool IsDefined(Type attributeType, bool inherit)
		{
			throw NotImplemented.ByDesign;
		}

		/// <summary>Returns all custom attributes.</summary>
		/// <param name="inherit">This argument is ignored for objects of this type. </param>
		/// <returns>An array of type <see langword="Object" /> containing all custom attributes.</returns>
		// Token: 0x06002173 RID: 8563 RVA: 0x0002AC9D File Offset: 0x00028E9D
		public virtual object[] GetCustomAttributes(bool inherit)
		{
			throw NotImplemented.ByDesign;
		}

		/// <summary>Gets custom attributes of the specified type.</summary>
		/// <param name="attributeType">The type of attribute to get. </param>
		/// <param name="inherit">This argument is ignored for objects of this type. </param>
		/// <returns>An array of type <see langword="Object" /> containing all custom attributes of the specified type.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="attributeType" /> is <see langword="null" />. </exception>
		/// <exception cref="T:System.ArgumentException">
		///         <paramref name="attributeType" /> is not a <see cref="T:System.Type" /> object supplied by the runtime. For example, <paramref name="attributeType" /> is a <see cref="T:System.Reflection.Emit.TypeBuilder" /> object.</exception>
		// Token: 0x06002174 RID: 8564 RVA: 0x0002AC9D File Offset: 0x00028E9D
		public virtual object[] GetCustomAttributes(Type attributeType, bool inherit)
		{
			throw NotImplemented.ByDesign;
		}

		/// <summary>Returns all the types defined within this module.</summary>
		/// <returns>An array of type <see langword="Type" /> containing types defined within the module that is reflected by this instance.</returns>
		/// <exception cref="T:System.Reflection.ReflectionTypeLoadException">One or more classes in a module could not be loaded. </exception>
		/// <exception cref="T:System.Security.SecurityException">The caller does not have the required permission. </exception>
		// Token: 0x06002175 RID: 8565 RVA: 0x0002AC9D File Offset: 0x00028E9D
		public virtual Type[] GetTypes()
		{
			throw NotImplemented.ByDesign;
		}

		/// <summary>Returns the method or constructor identified by the specified metadata token.</summary>
		/// <param name="metadataToken">A metadata token that identifies a method or constructor in the module.</param>
		/// <returns>A <see cref="T:System.Reflection.MethodBase" /> object representing the method or constructor that is identified by the specified metadata token.</returns>
		/// <exception cref="T:System.ArgumentException">
		///         <paramref name="metadataToken" /> is not a token for a method or constructor in the scope of the current module.-or-
		///         <paramref name="metadataToken" /> is a <see langword="MethodSpec" /> whose signature contains element type <see langword="var" /> (a type parameter of a generic type) or <see langword="mvar" /> (a type parameter of a generic method).</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///         <paramref name="metadataToken" /> is not a valid token in the scope of the current module.</exception>
		// Token: 0x06002176 RID: 8566 RVA: 0x0008A4BA File Offset: 0x000886BA
		public MethodBase ResolveMethod(int metadataToken)
		{
			return this.ResolveMethod(metadataToken, null, null);
		}

		/// <summary>Returns the method or constructor identified by the specified metadata token, in the context defined by the specified generic type parameters.</summary>
		/// <param name="metadataToken">A metadata token that identifies a method or constructor in the module.</param>
		/// <param name="genericTypeArguments">An array of <see cref="T:System.Type" /> objects representing the generic type arguments of the type where the token is in scope, or <see langword="null" /> if that type is not generic. </param>
		/// <param name="genericMethodArguments">An array of <see cref="T:System.Type" /> objects representing the generic type arguments of the method where the token is in scope, or <see langword="null" /> if that method is not generic.</param>
		/// <returns>A <see cref="T:System.Reflection.MethodBase" /> object representing the method that is identified by the specified metadata token.</returns>
		/// <exception cref="T:System.ArgumentException">
		///         <paramref name="metadataToken" /> is not a token for a method or constructor in the scope of the current module.-or-
		///         <paramref name="metadataToken" /> is a <see langword="MethodSpec" /> whose signature contains element type <see langword="var" /> (a type parameter of a generic type) or <see langword="mvar" /> (a type parameter of a generic method), and the necessary generic type arguments were not supplied for either or both of <paramref name="genericTypeArguments" /> and <paramref name="genericMethodArguments" />.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///         <paramref name="metadataToken" /> is not a valid token in the scope of the current module.</exception>
		// Token: 0x06002177 RID: 8567 RVA: 0x0002AC9D File Offset: 0x00028E9D
		public virtual MethodBase ResolveMethod(int metadataToken, Type[] genericTypeArguments, Type[] genericMethodArguments)
		{
			throw NotImplemented.ByDesign;
		}

		/// <summary>Provides an <see cref="T:System.Runtime.Serialization.ISerializable" /> implementation for serialized objects.</summary>
		/// <param name="info">The information and data needed to serialize or deserialize an object. </param>
		/// <param name="context">The context for the serialization. </param>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="info" /> is <see langword="null" />. </exception>
		// Token: 0x06002178 RID: 8568 RVA: 0x0002AC9D File Offset: 0x00028E9D
		public virtual void GetObjectData(SerializationInfo info, StreamingContext context)
		{
			throw NotImplemented.ByDesign;
		}

		/// <summary>Determines whether this module and the specified object are equal.</summary>
		/// <param name="o">The object to compare with this instance. </param>
		/// <returns>
		///     <see langword="true" /> if <paramref name="o" /> is equal to this instance; otherwise, <see langword="false" />.</returns>
		// Token: 0x06002179 RID: 8569 RVA: 0x0008A054 File Offset: 0x00088254
		public override bool Equals(object o)
		{
			return base.Equals(o);
		}

		/// <summary>Returns the hash code for this instance.</summary>
		/// <returns>A 32-bit signed integer hash code.</returns>
		// Token: 0x0600217A RID: 8570 RVA: 0x0005B518 File Offset: 0x00059718
		public override int GetHashCode()
		{
			return base.GetHashCode();
		}

		/// <summary>Indicates whether two <see cref="T:System.Reflection.Module" /> objects are equal.</summary>
		/// <param name="left">The first object to compare.</param>
		/// <param name="right">The second object to compare.</param>
		/// <returns>
		///     <see langword="true" /> if <paramref name="left" /> is equal to <paramref name="right" />; otherwise, <see langword="false" />.</returns>
		// Token: 0x0600217B RID: 8571 RVA: 0x0003F3D8 File Offset: 0x0003D5D8
		public static bool operator ==(Module left, Module right)
		{
			return left == right || (left != null && right != null && left.Equals(right));
		}

		/// <summary>Returns the name of the module.</summary>
		/// <returns>A <see langword="String" /> representing the name of this module.</returns>
		// Token: 0x0600217C RID: 8572 RVA: 0x0008A4C5 File Offset: 0x000886C5
		public override string ToString()
		{
			return this.ScopeName;
		}

		// Token: 0x0600217D RID: 8573 RVA: 0x0008A4D0 File Offset: 0x000886D0
		private static bool FilterTypeNameImpl(Type cls, object filterCriteria)
		{
			if (filterCriteria == null || !(filterCriteria is string))
			{
				throw new InvalidFilterCriteriaException("A String must be provided for the filter criteria.");
			}
			string text = (string)filterCriteria;
			if (text.Length > 0 && text[text.Length - 1] == '*')
			{
				text = text.Substring(0, text.Length - 1);
				return cls.Name.StartsWith(text, StringComparison.Ordinal);
			}
			return cls.Name.Equals(text);
		}

		// Token: 0x0600217E RID: 8574 RVA: 0x0008A540 File Offset: 0x00088740
		private static bool FilterTypeNameIgnoreCaseImpl(Type cls, object filterCriteria)
		{
			if (filterCriteria == null || !(filterCriteria is string))
			{
				throw new InvalidFilterCriteriaException("A String must be provided for the filter criteria.");
			}
			string text = (string)filterCriteria;
			if (text.Length > 0 && text[text.Length - 1] == '*')
			{
				text = text.Substring(0, text.Length - 1);
				string name = cls.Name;
				return name.Length >= text.Length && string.Compare(name, 0, text, 0, text.Length, StringComparison.OrdinalIgnoreCase) == 0;
			}
			return string.Compare(text, cls.Name, StringComparison.OrdinalIgnoreCase) == 0;
		}

		// Token: 0x0600217F RID: 8575 RVA: 0x0002B1E0 File Offset: 0x000293E0
		internal virtual Guid GetModuleVersionId()
		{
			throw new NotImplementedException();
		}

		/// <summary>A <see langword="TypeFilter" /> object that filters the list of types defined in this module based upon the name. This field is case-sensitive and read-only.</summary>
		// Token: 0x0400102C RID: 4140
		public static readonly TypeFilter FilterTypeName = new TypeFilter(Module.FilterTypeNameImpl);

		/// <summary>A <see langword="TypeFilter" /> object that filters the list of types defined in this module based upon the name. This field is case-insensitive and read-only.</summary>
		// Token: 0x0400102D RID: 4141
		public static readonly TypeFilter FilterTypeNameIgnoreCase = new TypeFilter(Module.FilterTypeNameIgnoreCaseImpl);

		// Token: 0x0400102E RID: 4142
		private const BindingFlags DefaultLookup = BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public;
	}
}
