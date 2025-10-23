using System;
using System.Globalization;

namespace System.Reflection
{
	/// <summary>Represents a named argument of a custom attribute in the reflection-only context.</summary>
	// Token: 0x020004C7 RID: 1223
	public struct CustomAttributeNamedArgument
	{
		/// <summary>Initializes a new instance of the <see cref="T:System.Reflection.CustomAttributeNamedArgument" /> class, which represents the specified field or property of the custom attribute, and specifies the value of the field or property.</summary>
		/// <param name="memberInfo">A field or property of the custom attribute. The new <see cref="T:System.Reflection.CustomAttributeNamedArgument" /> object represents this member and its value.</param>
		/// <param name="value">The value of the field or property of the custom attribute.</param>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="memberInfo" /> is <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">
		///         <paramref name="memberInfo" /> is not a field or property of the custom attribute.</exception>
		// Token: 0x06002291 RID: 8849 RVA: 0x0008B3EC File Offset: 0x000895EC
		public CustomAttributeNamedArgument(MemberInfo memberInfo, object value)
		{
			if (memberInfo == null)
			{
				throw new ArgumentNullException("memberInfo");
			}
			FieldInfo fieldInfo = memberInfo as FieldInfo;
			PropertyInfo propertyInfo = memberInfo as PropertyInfo;
			Type argumentType;
			if (fieldInfo != null)
			{
				argumentType = fieldInfo.FieldType;
			}
			else
			{
				if (!(propertyInfo != null))
				{
					throw new ArgumentException("The member must be either a field or a property.");
				}
				argumentType = propertyInfo.PropertyType;
			}
			this._lazyMemberInfo = memberInfo;
			this._attributeType = memberInfo.DeclaringType;
			if (value is CustomAttributeTypedArgument)
			{
				CustomAttributeTypedArgument customAttributeTypedArgument = (CustomAttributeTypedArgument)value;
				this.TypedValue = customAttributeTypedArgument;
			}
			else
			{
				this.TypedValue = new CustomAttributeTypedArgument(argumentType, value);
			}
			this.IsField = (fieldInfo != null);
			this.MemberName = memberInfo.Name;
		}

		/// <summary>Gets a <see cref="T:System.Reflection.CustomAttributeTypedArgument" /> structure that can be used to obtain the type and value of the current named argument.</summary>
		/// <returns>A structure that can be used to obtain the type and value of the current named argument.</returns>
		// Token: 0x170004A5 RID: 1189
		// (get) Token: 0x06002292 RID: 8850 RVA: 0x0008B49F File Offset: 0x0008969F
		public readonly CustomAttributeTypedArgument TypedValue { get; }

		/// <summary>Gets a value that indicates whether the named argument is a field.</summary>
		/// <returns>
		///     <see langword="true" /> if the named argument is a field; otherwise, <see langword="false" />.</returns>
		// Token: 0x170004A6 RID: 1190
		// (get) Token: 0x06002293 RID: 8851 RVA: 0x0008B4A7 File Offset: 0x000896A7
		public readonly bool IsField { get; }

		/// <summary>Gets the name of the attribute member that would be used to set the named argument.</summary>
		/// <returns>The name of the attribute member that would be used to set the named argument.</returns>
		// Token: 0x170004A7 RID: 1191
		// (get) Token: 0x06002294 RID: 8852 RVA: 0x0008B4AF File Offset: 0x000896AF
		public readonly string MemberName { get; }

		/// <summary>Returns a value that indicates whether this instance is equal to a specified object.</summary>
		/// <param name="obj">An object to compare with this instance, or <see langword="null" />.</param>
		/// <returns>
		///     <see langword="true" /> if <paramref name="obj" /> equals the type and value of this instance; otherwise, <see langword="false" />.</returns>
		// Token: 0x06002295 RID: 8853 RVA: 0x0008B4B7 File Offset: 0x000896B7
		public override bool Equals(object obj)
		{
			return obj == this;
		}

		/// <summary>Returns the hash code for this instance.</summary>
		/// <returns>A 32-bit signed integer hash code.</returns>
		// Token: 0x06002296 RID: 8854 RVA: 0x0008B4C7 File Offset: 0x000896C7
		public override int GetHashCode()
		{
			return base.GetHashCode();
		}

		/// <summary>Returns a string that consists of the argument name, the equal sign, and a string representation of the argument value.</summary>
		/// <returns>A string that consists of the argument name, the equal sign, and a string representation of the argument value.</returns>
		// Token: 0x06002297 RID: 8855 RVA: 0x0008B4DC File Offset: 0x000896DC
		public override string ToString()
		{
			if (this._attributeType == null)
			{
				return base.ToString();
			}
			string result;
			try
			{
				bool typed = this._lazyMemberInfo == null || (this.IsField ? ((FieldInfo)this._lazyMemberInfo).FieldType : ((PropertyInfo)this._lazyMemberInfo).PropertyType) != typeof(object);
				result = string.Format(CultureInfo.CurrentCulture, "{0} = {1}", this.MemberName, this.TypedValue.ToString(typed));
			}
			catch (MissingMetadataException)
			{
				result = base.ToString();
			}
			return result;
		}

		// Token: 0x0400108B RID: 4235
		private readonly Type _attributeType;

		// Token: 0x0400108C RID: 4236
		private volatile MemberInfo _lazyMemberInfo;
	}
}
