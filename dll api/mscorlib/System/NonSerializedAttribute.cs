using System;

namespace System
{
	/// <summary>Indicates that a field of a serializable class should not be serialized. This class cannot be inherited.</summary>
	// Token: 0x020000D9 RID: 217
	[AttributeUsage(AttributeTargets.Field, Inherited = false)]
	public sealed class NonSerializedAttribute : Attribute
	{
	}
}
