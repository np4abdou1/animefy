using System;

namespace System.Security
{
	/// <summary>Defines the methods that convert permission object state to and from XML element representation.</summary>
	// Token: 0x02000278 RID: 632
	public interface ISecurityEncodable
	{
		/// <summary>Creates an XML encoding of the security object and its current state.</summary>
		/// <returns>An XML encoding of the security object, including any state information.</returns>
		// Token: 0x06001639 RID: 5689
		SecurityElement ToXml();
	}
}
