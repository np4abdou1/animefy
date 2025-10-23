using System;

namespace System.Security
{
	/// <summary>Specifies that code or an assembly performs security-critical operations.</summary>
	// Token: 0x0200027D RID: 637
	[AttributeUsage(AttributeTargets.Assembly | AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Enum | AttributeTargets.Constructor | AttributeTargets.Method | AttributeTargets.Field | AttributeTargets.Interface | AttributeTargets.Delegate, AllowMultiple = false, Inherited = false)]
	public sealed class SecurityCriticalAttribute : Attribute
	{
	}
}
