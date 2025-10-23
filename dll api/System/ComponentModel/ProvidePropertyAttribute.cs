using System;

namespace System.ComponentModel
{
	/// <summary>Specifies the name of the property that an implementer of <see cref="T:System.ComponentModel.IExtenderProvider" /> offers to other components. This class cannot be inherited</summary>
	// Token: 0x0200027D RID: 637
	[AttributeUsage(AttributeTargets.Class, AllowMultiple = true)]
	public sealed class ProvidePropertyAttribute : Attribute
	{
		/// <summary>Gets the name of a property that this class provides.</summary>
		/// <returns>The name of a property that this class provides.</returns>
		// Token: 0x17000380 RID: 896
		// (get) Token: 0x06001125 RID: 4389 RVA: 0x000514A4 File Offset: 0x0004F6A4
		public string PropertyName { get; }

		/// <summary>Gets the name of the data type this property can extend.</summary>
		/// <returns>The name of the data type this property can extend.</returns>
		// Token: 0x17000381 RID: 897
		// (get) Token: 0x06001126 RID: 4390 RVA: 0x000514AC File Offset: 0x0004F6AC
		public string ReceiverTypeName { get; }
	}
}
