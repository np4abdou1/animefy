using System;

namespace System.Runtime.InteropServices
{
	/// <summary>Indicates that the HRESULT or <see langword="retval" /> signature transformation that takes place during COM interop calls should be suppressed.</summary>
	// Token: 0x0200040F RID: 1039
	[AttributeUsage(AttributeTargets.Method, Inherited = false)]
	[ComVisible(true)]
	public sealed class PreserveSigAttribute : Attribute
	{
	}
}
