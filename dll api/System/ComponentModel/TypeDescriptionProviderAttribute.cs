using System;

namespace System.ComponentModel
{
	/// <summary>Specifies the custom type description provider for a class. This class cannot be inherited.</summary>
	// Token: 0x0200028A RID: 650
	[AttributeUsage(AttributeTargets.Class, Inherited = true)]
	public sealed class TypeDescriptionProviderAttribute : Attribute
	{
		/// <summary>Initializes a new instance of the <see cref="T:System.ComponentModel.TypeDescriptionProviderAttribute" /> class using the specified type name.</summary>
		/// <param name="typeName">The qualified name of the type.</param>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="typeName" /> is <see langword="null" />.</exception>
		// Token: 0x0600115F RID: 4447 RVA: 0x00051F1F File Offset: 0x0005011F
		public TypeDescriptionProviderAttribute(string typeName)
		{
			if (typeName == null)
			{
				throw new ArgumentNullException("typeName");
			}
			this.TypeName = typeName;
		}

		/// <summary>Gets the type name for the type description provider.</summary>
		/// <returns>A <see cref="T:System.String" /> containing the qualified type name for the <see cref="T:System.ComponentModel.TypeDescriptionProvider" />.</returns>
		// Token: 0x17000386 RID: 902
		// (get) Token: 0x06001160 RID: 4448 RVA: 0x00051F3C File Offset: 0x0005013C
		public string TypeName { get; }
	}
}
