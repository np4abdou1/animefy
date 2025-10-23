﻿using System;

namespace System.Reflection
{
	/// <summary>Provides custom attributes for reflection objects that support them.</summary>
	// Token: 0x020004A0 RID: 1184
	public interface ICustomAttributeProvider
	{
		/// <summary>Returns an array of all of the custom attributes defined on this member, excluding named attributes, or an empty array if there are no custom attributes.</summary>
		/// <param name="inherit">When <see langword="true" />, look up the hierarchy chain for the inherited custom attribute. </param>
		/// <returns>An array of Objects representing custom attributes, or an empty array.</returns>
		/// <exception cref="T:System.TypeLoadException">The custom attribute type cannot be loaded. </exception>
		/// <exception cref="T:System.Reflection.AmbiguousMatchException">There is more than one attribute of type <paramref name="attributeType" /> defined on this member. </exception>
		// Token: 0x0600211D RID: 8477
		object[] GetCustomAttributes(bool inherit);

		/// <summary>Returns an array of custom attributes defined on this member, identified by type, or an empty array if there are no custom attributes of that type.</summary>
		/// <param name="attributeType">The type of the custom attributes. </param>
		/// <param name="inherit">When <see langword="true" />, look up the hierarchy chain for the inherited custom attribute. </param>
		/// <returns>An array of Objects representing custom attributes, or an empty array.</returns>
		/// <exception cref="T:System.TypeLoadException">The custom attribute type cannot be loaded. </exception>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="attributeType" /> is <see langword="null" />.</exception>
		// Token: 0x0600211E RID: 8478
		object[] GetCustomAttributes(Type attributeType, bool inherit);

		/// <summary>Indicates whether one or more instance of <paramref name="attributeType" /> is defined on this member.</summary>
		/// <param name="attributeType">The type of the custom attributes. </param>
		/// <param name="inherit">When <see langword="true" />, look up the hierarchy chain for the inherited custom attribute. </param>
		/// <returns>
		///     <see langword="true" /> if the <paramref name="attributeType" /> is defined on this member; <see langword="false" /> otherwise.</returns>
		// Token: 0x0600211F RID: 8479
		bool IsDefined(Type attributeType, bool inherit);
	}
}
