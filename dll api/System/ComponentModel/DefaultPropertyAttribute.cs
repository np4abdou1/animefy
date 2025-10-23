﻿using System;

namespace System.ComponentModel
{
	/// <summary>Specifies the default property for a component.</summary>
	// Token: 0x0200025B RID: 603
	[AttributeUsage(AttributeTargets.Class)]
	public sealed class DefaultPropertyAttribute : Attribute
	{
		/// <summary>Initializes a new instance of the <see cref="T:System.ComponentModel.DefaultPropertyAttribute" /> class.</summary>
		/// <param name="name">The name of the default property for the component this attribute is bound to. </param>
		// Token: 0x06001022 RID: 4130 RVA: 0x0004F897 File Offset: 0x0004DA97
		public DefaultPropertyAttribute(string name)
		{
			this.Name = name;
		}

		/// <summary>Gets the name of the default property for the component this attribute is bound to.</summary>
		/// <returns>The name of the default property for the component this attribute is bound to. The default value is <see langword="null" />.</returns>
		// Token: 0x1700033A RID: 826
		// (get) Token: 0x06001023 RID: 4131 RVA: 0x0004F8A6 File Offset: 0x0004DAA6
		public string Name { get; }

		/// <summary>Returns whether the value of the given object is equal to the current <see cref="T:System.ComponentModel.DefaultPropertyAttribute" />.</summary>
		/// <param name="obj">The object to test the value equality of. </param>
		/// <returns>
		///     <see langword="true" /> if the value of the given object is equal to that of the current; otherwise, <see langword="false" />.</returns>
		// Token: 0x06001024 RID: 4132 RVA: 0x0004F8B0 File Offset: 0x0004DAB0
		public override bool Equals(object obj)
		{
			DefaultPropertyAttribute defaultPropertyAttribute = obj as DefaultPropertyAttribute;
			return defaultPropertyAttribute != null && defaultPropertyAttribute.Name == this.Name;
		}

		/// <summary>Returns the hash code for this instance.</summary>
		/// <returns>A 32-bit signed integer hash code.</returns>
		// Token: 0x06001025 RID: 4133 RVA: 0x0004CFC2 File Offset: 0x0004B1C2
		public override int GetHashCode()
		{
			return base.GetHashCode();
		}

		/// <summary>Specifies the default value for the <see cref="T:System.ComponentModel.DefaultPropertyAttribute" />, which is <see langword="null" />. This <see langword="static" /> field is read-only.</summary>
		// Token: 0x04000C41 RID: 3137
		public static readonly DefaultPropertyAttribute Default = new DefaultPropertyAttribute(null);
	}
}
