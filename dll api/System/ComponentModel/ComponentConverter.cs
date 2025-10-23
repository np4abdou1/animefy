using System;

namespace System.ComponentModel
{
	/// <summary>Provides a type converter to convert components to and from various other representations.</summary>
	// Token: 0x0200029A RID: 666
	public class ComponentConverter : ReferenceConverter
	{
		/// <summary>Initializes a new instance of the <see cref="T:System.ComponentModel.ComponentConverter" /> class.</summary>
		/// <param name="type">A <see cref="T:System.Type" /> that represents the type to associate with this component converter. </param>
		// Token: 0x06001193 RID: 4499 RVA: 0x00052287 File Offset: 0x00050487
		public ComponentConverter(Type type) : base(type)
		{
		}
	}
}
