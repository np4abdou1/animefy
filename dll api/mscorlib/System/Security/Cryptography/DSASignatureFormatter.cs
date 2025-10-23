using System;
using System.Runtime.InteropServices;

namespace System.Security.Cryptography
{
	/// <summary>Creates a Digital Signature Algorithm (<see cref="T:System.Security.Cryptography.DSA" />) signature.</summary>
	// Token: 0x020002B3 RID: 691
	[ComVisible(true)]
	public class DSASignatureFormatter : AsymmetricSignatureFormatter
	{
		/// <summary>Initializes a new instance of the <see cref="T:System.Security.Cryptography.DSASignatureFormatter" /> class.</summary>
		// Token: 0x0600174A RID: 5962 RVA: 0x000601A6 File Offset: 0x0005E3A6
		public DSASignatureFormatter()
		{
			this._oid = CryptoConfig.MapNameToOID("SHA1");
		}

		// Token: 0x04000991 RID: 2449
		private string _oid;
	}
}
