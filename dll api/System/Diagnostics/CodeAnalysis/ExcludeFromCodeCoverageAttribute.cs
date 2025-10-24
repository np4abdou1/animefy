using System;

namespace System.Diagnostics.CodeAnalysis
{
	/// <summary>Specifies that the attributed code should be excluded from code coverage information. </summary>
	// Token: 0x020000D5 RID: 213
	[AttributeUsage(AttributeTargets.Assembly | AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Constructor | AttributeTargets.Method | AttributeTargets.Property | AttributeTargets.Event, Inherited = false, AllowMultiple = false)]
	public sealed class ExcludeFromCodeCoverageAttribute : Attribute
	{
	}
}
