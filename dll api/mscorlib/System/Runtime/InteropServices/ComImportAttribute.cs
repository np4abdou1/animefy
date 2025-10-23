using System;

namespace System.Runtime.InteropServices
{
	/// <summary>Indicates that the attributed type was previously defined in COM.</summary>
	// Token: 0x0200040D RID: 1037
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Interface, Inherited = false)]
	[ComVisible(true)]
	public sealed class ComImportAttribute : Attribute
	{
	}
}
