using System;

namespace System.ComponentModel
{
	/// <summary>Provides functionality for containers. Containers are objects that logically contain zero or more components.</summary>
	// Token: 0x0200023F RID: 575
	public interface IContainer : IDisposable
	{
		/// <summary>Gets all the components in the <see cref="T:System.ComponentModel.IContainer" />.</summary>
		/// <returns>A collection of <see cref="T:System.ComponentModel.IComponent" /> objects that represents all the components in the <see cref="T:System.ComponentModel.IContainer" />.</returns>
		// Token: 0x17000320 RID: 800
		// (get) Token: 0x06000FA8 RID: 4008
		ComponentCollection Components { get; }

		/// <summary>Removes a component from the <see cref="T:System.ComponentModel.IContainer" />.</summary>
		/// <param name="component">The <see cref="T:System.ComponentModel.IComponent" /> to remove. </param>
		// Token: 0x06000FA9 RID: 4009
		void Remove(IComponent component);
	}
}
