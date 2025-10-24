using System;

namespace System.Reflection
{
	/// <summary>Contains methods for converting <see cref="T:System.Type" /> objects.</summary>
	// Token: 0x020004A3 RID: 1187
	public static class IntrospectionExtensions
	{
		/// <summary>Returns the <see cref="T:System.Reflection.TypeInfo" /> representation of the specified type.</summary>
		/// <param name="type">The type to convert.</param>
		/// <returns>The converted object.</returns>
		// Token: 0x06002121 RID: 8481 RVA: 0x00089FB8 File Offset: 0x000881B8
		public static TypeInfo GetTypeInfo(this Type type)
		{
			if (type == null)
			{
				throw new ArgumentNullException("type");
			}
			IReflectableType reflectableType = type as IReflectableType;
			if (reflectableType != null)
			{
				return reflectableType.GetTypeInfo();
			}
			return new TypeDelegator(type);
		}
	}
}
