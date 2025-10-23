using System;

namespace System
{
	/// <summary>Indicates that a class can be serialized. This class cannot be inherited.</summary>
	// Token: 0x020000F2 RID: 242
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Enum | AttributeTargets.Delegate, Inherited = false)]
	public sealed class SerializableAttribute : Attribute
	{
	}
}
