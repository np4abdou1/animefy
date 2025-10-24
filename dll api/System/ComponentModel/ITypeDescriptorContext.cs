using System;

namespace System.ComponentModel
{
	/// <summary>Provides contextual information about a component, such as its container and property descriptor.</summary>
	// Token: 0x0200026E RID: 622
	public interface ITypeDescriptorContext : IServiceProvider
	{
		/// <summary>Gets the container representing this <see cref="T:System.ComponentModel.TypeDescriptor" /> request.</summary>
		/// <returns>An <see cref="T:System.ComponentModel.IContainer" /> with the set of objects for this <see cref="T:System.ComponentModel.TypeDescriptor" />; otherwise, <see langword="null" /> if there is no container or if the <see cref="T:System.ComponentModel.TypeDescriptor" /> does not use outside objects.</returns>
		// Token: 0x1700035E RID: 862
		// (get) Token: 0x060010A7 RID: 4263
		IContainer Container { get; }
	}
}
