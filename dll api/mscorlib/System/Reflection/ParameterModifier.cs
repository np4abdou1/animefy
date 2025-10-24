using System;

namespace System.Reflection
{
	/// <summary>Attaches a modifier to parameters so that binding can work with parameter signatures in which the types have been modified.</summary>
	// Token: 0x020004B0 RID: 1200
	[DefaultMember("Item")]
	public readonly struct ParameterModifier
	{
		// Token: 0x04001042 RID: 4162
		private readonly bool[] _byRef;
	}
}
