using System;

namespace System
{
	/// <summary>Supports a value type that can be assigned <see langword="null" />. This class cannot be inherited.</summary>
	// Token: 0x020000DF RID: 223
	public static class Nullable
	{
		/// <summary>Returns the underlying type argument of the specified nullable type.</summary>
		/// <param name="nullableType">A <see cref="T:System.Type" /> object that describes a closed generic nullable type. </param>
		/// <returns>The type argument of the <paramref name="nullableType" /> parameter, if the <paramref name="nullableType" /> parameter is a closed generic nullable type; otherwise, <see langword="null" />. </returns>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="nullableType" /> is <see langword="null" />.</exception>
		// Token: 0x06000746 RID: 1862 RVA: 0x0001E21E File Offset: 0x0001C41E
		public static Type GetUnderlyingType(Type nullableType)
		{
			if (nullableType == null)
			{
				throw new ArgumentNullException("nullableType");
			}
			if (nullableType.IsGenericType && !nullableType.IsGenericTypeDefinition && nullableType.GetGenericTypeDefinition() == typeof(Nullable<>))
			{
				return nullableType.GetGenericArguments()[0];
			}
			return null;
		}
	}
}
