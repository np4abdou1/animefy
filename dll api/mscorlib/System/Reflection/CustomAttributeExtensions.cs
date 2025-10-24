using System;
using System.Collections.Generic;

namespace System.Reflection
{
	/// <summary>Contains static methods for retrieving custom attributes.</summary>
	// Token: 0x020004CA RID: 1226
	public static class CustomAttributeExtensions
	{
		/// <summary>Retrieves a custom attribute of a specified type that is applied to a specified member.</summary>
		/// <param name="element">The member to inspect.</param>
		/// <param name="attributeType">The type of attribute to search for.</param>
		/// <returns>A custom attribute that matches <paramref name="attributeType" />, or <see langword="null" /> if no such attribute is found.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="element" /> or <paramref name="attributeType" /> is <see langword="null" />. </exception>
		/// <exception cref="T:System.ArgumentException">
		///         <paramref name="attributeType" /> is not derived from <see cref="T:System.Attribute" />. </exception>
		/// <exception cref="T:System.NotSupportedException">
		///         <paramref name="element" /> is not a constructor, method, property, event, type, or field. </exception>
		/// <exception cref="T:System.Reflection.AmbiguousMatchException">More than one of the requested attributes was found. </exception>
		/// <exception cref="T:System.TypeLoadException">A custom attribute type cannot be loaded. </exception>
		// Token: 0x060022A0 RID: 8864 RVA: 0x0008B910 File Offset: 0x00089B10
		public static Attribute GetCustomAttribute(this MemberInfo element, Type attributeType)
		{
			return Attribute.GetCustomAttribute(element, attributeType);
		}

		/// <summary>Retrieves a custom attribute of a specified type that is applied to a specified member.</summary>
		/// <param name="element">The member to inspect.</param>
		/// <typeparam name="T">The type of attribute to search for.</typeparam>
		/// <returns>A custom attribute that matches <paramref name="T" />, or <see langword="null" /> if no such attribute is found.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="element" /> is <see langword="null" />. </exception>
		/// <exception cref="T:System.NotSupportedException">
		///         <paramref name="element" /> is not a constructor, method, property, event, type, or field. </exception>
		/// <exception cref="T:System.Reflection.AmbiguousMatchException">More than one of the requested attributes was found. </exception>
		/// <exception cref="T:System.TypeLoadException">A custom attribute type cannot be loaded. </exception>
		// Token: 0x060022A1 RID: 8865 RVA: 0x0008B919 File Offset: 0x00089B19
		public static T GetCustomAttribute<T>(this MemberInfo element) where T : Attribute
		{
			return (T)((object)element.GetCustomAttribute(typeof(T)));
		}

		/// <summary>Retrieves a custom attribute of a specified type that is applied to a specified member, and optionally inspects the ancestors of that member.</summary>
		/// <param name="element">The member to inspect.</param>
		/// <param name="attributeType">The type of attribute to search for.</param>
		/// <param name="inherit">
		///       <see langword="true" /> to inspect the ancestors of <paramref name="element" />; otherwise, <see langword="false" />. </param>
		/// <returns>A custom attribute that matches <paramref name="attributeType" />, or <see langword="null" /> if no such attribute is found.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="element" /> or <paramref name="attributeType" /> is <see langword="null" />. </exception>
		/// <exception cref="T:System.ArgumentException">
		///         <paramref name="attributeType" /> is not derived from <see cref="T:System.Attribute" />. </exception>
		/// <exception cref="T:System.NotSupportedException">
		///         <paramref name="element" /> is not a constructor, method, property, event, type, or field. </exception>
		/// <exception cref="T:System.Reflection.AmbiguousMatchException">More than one of the requested attributes was found. </exception>
		/// <exception cref="T:System.TypeLoadException">A custom attribute type cannot be loaded. </exception>
		// Token: 0x060022A2 RID: 8866 RVA: 0x0008B930 File Offset: 0x00089B30
		public static Attribute GetCustomAttribute(this MemberInfo element, Type attributeType, bool inherit)
		{
			return Attribute.GetCustomAttribute(element, attributeType, inherit);
		}

		/// <summary>Retrieves a custom attribute of a specified type that is applied to a specified member, and optionally inspects the ancestors of that member.</summary>
		/// <param name="element">The member to inspect.</param>
		/// <param name="inherit">
		///       <see langword="true" /> to inspect the ancestors of <paramref name="element" />; otherwise, <see langword="false" />. </param>
		/// <typeparam name="T">The type of attribute to search for.</typeparam>
		/// <returns>A custom attribute that matches <paramref name="T" />, or <see langword="null" /> if no such attribute is found.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="element" /> is <see langword="null" />. </exception>
		/// <exception cref="T:System.NotSupportedException">
		///         <paramref name="element" /> is not a constructor, method, property, event, type, or field. </exception>
		/// <exception cref="T:System.Reflection.AmbiguousMatchException">More than one of the requested attributes was found. </exception>
		/// <exception cref="T:System.TypeLoadException">A custom attribute type cannot be loaded. </exception>
		// Token: 0x060022A3 RID: 8867 RVA: 0x0008B93A File Offset: 0x00089B3A
		public static T GetCustomAttribute<T>(this MemberInfo element, bool inherit) where T : Attribute
		{
			return (T)((object)element.GetCustomAttribute(typeof(T), inherit));
		}

		/// <summary>Retrieves a collection of custom attributes of a specified type that are applied to a specified member.</summary>
		/// <param name="element">The member to inspect.</param>
		/// <param name="attributeType">The type of attribute to search for.</param>
		/// <returns>A collection of the custom attributes that are applied to <paramref name="element" /> and that match <paramref name="attributeType" />, or an empty collection if no such attributes exist. </returns>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="element" /> or <paramref name="attributeType" /> is <see langword="null" />. </exception>
		/// <exception cref="T:System.ArgumentException">
		///         <paramref name="attributeType" /> is not derived from <see cref="T:System.Attribute" />. </exception>
		/// <exception cref="T:System.NotSupportedException">
		///         <paramref name="element" /> is not a constructor, method, property, event, type, or field. </exception>
		/// <exception cref="T:System.TypeLoadException">A custom attribute type cannot be loaded. </exception>
		// Token: 0x060022A4 RID: 8868 RVA: 0x0008B952 File Offset: 0x00089B52
		public static IEnumerable<Attribute> GetCustomAttributes(this MemberInfo element, Type attributeType)
		{
			return Attribute.GetCustomAttributes(element, attributeType);
		}

		/// <summary>Retrieves a collection of custom attributes of a specified type that are applied to a specified member.</summary>
		/// <param name="element">The member to inspect.</param>
		/// <typeparam name="T">The type of attribute to search for.</typeparam>
		/// <returns>A collection of the custom attributes that are applied to <paramref name="element" /> and that match <paramref name="T" />, or an empty collection if no such attributes exist. </returns>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="element" /> is <see langword="null" />. </exception>
		/// <exception cref="T:System.NotSupportedException">
		///         <paramref name="element" /> is not a constructor, method, property, event, type, or field. </exception>
		/// <exception cref="T:System.TypeLoadException">A custom attribute type cannot be loaded. </exception>
		// Token: 0x060022A5 RID: 8869 RVA: 0x0008B95B File Offset: 0x00089B5B
		public static IEnumerable<T> GetCustomAttributes<T>(this MemberInfo element) where T : Attribute
		{
			return (IEnumerable<T>)element.GetCustomAttributes(typeof(T));
		}

		/// <summary>Indicates whether custom attributes of a specified type are applied to a specified member.</summary>
		/// <param name="element">The member to inspect.</param>
		/// <param name="attributeType">The type of attribute to search for.</param>
		/// <returns>
		///     <see langword="true" /> if an attribute of the specified type is applied to <paramref name="element" />; otherwise, <see langword="false" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="element" /> or <paramref name="attributeType" /> is <see langword="null" />. </exception>
		/// <exception cref="T:System.ArgumentException">
		///         <paramref name="attributeType" /> is not derived from <see cref="T:System.Attribute" />. </exception>
		/// <exception cref="T:System.NotSupportedException">
		///         <paramref name="element" /> is not a constructor, method, property, event, type, or field. </exception>
		// Token: 0x060022A6 RID: 8870 RVA: 0x0008B972 File Offset: 0x00089B72
		public static bool IsDefined(this MemberInfo element, Type attributeType)
		{
			return Attribute.IsDefined(element, attributeType);
		}
	}
}
