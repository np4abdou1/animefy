using System;
using System.Collections.Generic;

namespace System.Reflection
{
	/// <summary>Provides methods that retrieve information about types at run time.</summary>
	// Token: 0x020004C6 RID: 1222
	public static class RuntimeReflectionExtensions
	{
		/// <summary>Retrieves a collection that represents all methods defined on a specified type.</summary>
		/// <param name="type">The type that contains the methods.</param>
		/// <returns>A collection of methods for the specified type.</returns>
		// Token: 0x0600228F RID: 8847 RVA: 0x0008B3AF File Offset: 0x000895AF
		public static IEnumerable<MethodInfo> GetRuntimeMethods(this Type type)
		{
			if (type == null)
			{
				throw new ArgumentNullException("type");
			}
			return type.GetMethods(BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic);
		}

		/// <summary>Retrieves an object that represents a specified method.</summary>
		/// <param name="type">The type that contains the method.</param>
		/// <param name="name">The name of the method.</param>
		/// <param name="parameters">An array that contains the method's parameters.</param>
		/// <returns>An object that represents the specified method, or <see langword="null" /> if the method is not found.</returns>
		// Token: 0x06002290 RID: 8848 RVA: 0x0008B3CD File Offset: 0x000895CD
		public static MethodInfo GetRuntimeMethod(this Type type, string name, Type[] parameters)
		{
			if (type == null)
			{
				throw new ArgumentNullException("type");
			}
			return type.GetMethod(name, parameters);
		}
	}
}
