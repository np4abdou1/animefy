using System;
using System.Runtime.InteropServices;

namespace System.Security.Cryptography
{
	/// <summary>Contains information about the properties of a digital signature.</summary>
	// Token: 0x020002D7 RID: 727
	[ComVisible(true)]
	public class SignatureDescription
	{
		/// <summary>Gets or sets the key algorithm for the signature description.</summary>
		/// <returns>The key algorithm for the signature description.</returns>
		// Token: 0x17000283 RID: 643
		// (set) Token: 0x06001837 RID: 6199 RVA: 0x00067762 File Offset: 0x00065962
		public string KeyAlgorithm
		{
			set
			{
				this._strKey = value;
			}
		}

		/// <summary>Gets or sets the digest algorithm for the signature description.</summary>
		/// <returns>The digest algorithm for the signature description.</returns>
		// Token: 0x17000284 RID: 644
		// (set) Token: 0x06001838 RID: 6200 RVA: 0x0006776B File Offset: 0x0006596B
		public string DigestAlgorithm
		{
			set
			{
				this._strDigest = value;
			}
		}

		/// <summary>Gets or sets the formatter algorithm for the signature description.</summary>
		/// <returns>The formatter algorithm for the signature description.</returns>
		// Token: 0x17000285 RID: 645
		// (set) Token: 0x06001839 RID: 6201 RVA: 0x00067774 File Offset: 0x00065974
		public string FormatterAlgorithm
		{
			set
			{
				this._strFormatter = value;
			}
		}

		/// <summary>Gets or sets the deformatter algorithm for the signature description.</summary>
		/// <returns>The deformatter algorithm for the signature description.</returns>
		// Token: 0x17000286 RID: 646
		// (set) Token: 0x0600183A RID: 6202 RVA: 0x0006777D File Offset: 0x0006597D
		public string DeformatterAlgorithm
		{
			set
			{
				this._strDeformatter = value;
			}
		}

		// Token: 0x040009FC RID: 2556
		private string _strKey;

		// Token: 0x040009FD RID: 2557
		private string _strDigest;

		// Token: 0x040009FE RID: 2558
		private string _strFormatter;

		// Token: 0x040009FF RID: 2559
		private string _strDeformatter;
	}
}
