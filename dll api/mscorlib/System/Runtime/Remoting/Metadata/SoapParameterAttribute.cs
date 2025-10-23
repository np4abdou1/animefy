using System;
using System.Runtime.InteropServices;

namespace System.Runtime.Remoting.Metadata
{
	/// <summary>Customizes SOAP generation and processing for a parameter. This class cannot be inherited.</summary>
	// Token: 0x02000359 RID: 857
	[AttributeUsage(AttributeTargets.Parameter)]
	[ComVisible(true)]
	public sealed class SoapParameterAttribute : SoapAttribute
	{
	}
}
