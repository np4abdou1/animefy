using System;
using System.Collections;

namespace System.ComponentModel
{
	/// <summary>Provides a read-only container for a collection of <see cref="T:System.ComponentModel.IComponent" /> objects.</summary>
	// Token: 0x02000236 RID: 566
	public class ComponentCollection : ReadOnlyCollectionBase
	{
		/// <summary>Gets any component in the collection matching the specified name.</summary>
		/// <param name="name">The name of the <see cref="T:System.ComponentModel.IComponent" /> to get. </param>
		/// <returns>A component with a name matching the name specified by the <paramref name="name" /> parameter, or <see langword="null" /> if the named component cannot be found in the collection.</returns>
		// Token: 0x17000316 RID: 790
		public virtual IComponent this[string name]
		{
			get
			{
				if (name != null)
				{
					foreach (object obj in ((IEnumerable)base.InnerList))
					{
						IComponent component = (IComponent)obj;
						if (component != null && component.Site != null && component.Site.Name != null && string.Equals(component.Site.Name, name, StringComparison.OrdinalIgnoreCase))
						{
							return component;
						}
					}
				}
				return null;
			}
		}
	}
}
