using System;

namespace System.Reflection
{
	/// <summary>Represents a type that you can reflect over.</summary>
	// Token: 0x020004A1 RID: 1185
	public interface IReflectableType
	{
		/// <summary>Retrieves an object that represents this type.</summary>
		/// <returns>An object that represents this type.</returns>
		// Token: 0x06002120 RID: 8480
		TypeInfo GetTypeInfo();
	}
}
