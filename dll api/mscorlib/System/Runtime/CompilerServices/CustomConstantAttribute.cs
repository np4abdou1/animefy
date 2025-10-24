using System;

namespace System.Runtime.CompilerServices
{
	/// <summary>Defines a constant value that a compiler can persist for a field or method parameter.</summary>
	// Token: 0x02000440 RID: 1088
	[AttributeUsage(AttributeTargets.Field | AttributeTargets.Parameter, Inherited = false)]
	[Serializable]
	public abstract class CustomConstantAttribute : Attribute
	{
		/// <summary>Gets the constant value stored by this attribute.</summary>
		/// <returns>The constant value stored by this attribute.</returns>
		// Token: 0x170003FF RID: 1023
		// (get) Token: 0x06001FFF RID: 8191
		public abstract object Value { get; }
	}
}
