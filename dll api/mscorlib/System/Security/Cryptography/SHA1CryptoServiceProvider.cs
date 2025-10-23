using System;
using System.Runtime.InteropServices;

namespace System.Security.Cryptography
{
	/// <summary>Computes the <see cref="T:System.Security.Cryptography.SHA1" /> hash value for the input data using the implementation provided by the cryptographic service provider (CSP). This class cannot be inherited. </summary>
	// Token: 0x020002EB RID: 747
	[ComVisible(true)]
	public sealed class SHA1CryptoServiceProvider : SHA1
	{
		/// <summary>Initializes a new instance of the <see cref="T:System.Security.Cryptography.SHA1CryptoServiceProvider" /> class.</summary>
		// Token: 0x060018BD RID: 6333 RVA: 0x0006CC38 File Offset: 0x0006AE38
		public SHA1CryptoServiceProvider()
		{
			this.sha = new SHA1Internal();
		}

		// Token: 0x060018BE RID: 6334 RVA: 0x0006CC4C File Offset: 0x0006AE4C
		~SHA1CryptoServiceProvider()
		{
			this.Dispose(false);
		}

		// Token: 0x060018BF RID: 6335 RVA: 0x0006CC7C File Offset: 0x0006AE7C
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x060018C0 RID: 6336 RVA: 0x0006CC85 File Offset: 0x0006AE85
		protected override void HashCore(byte[] rgb, int ibStart, int cbSize)
		{
			this.State = 1;
			this.sha.HashCore(rgb, ibStart, cbSize);
		}

		// Token: 0x060018C1 RID: 6337 RVA: 0x0006CC9C File Offset: 0x0006AE9C
		protected override byte[] HashFinal()
		{
			this.State = 0;
			return this.sha.HashFinal();
		}

		/// <summary>Initializes an instance of <see cref="T:System.Security.Cryptography.SHA1CryptoServiceProvider" />.</summary>
		// Token: 0x060018C2 RID: 6338 RVA: 0x0006CCB0 File Offset: 0x0006AEB0
		public override void Initialize()
		{
			this.sha.Initialize();
		}

		// Token: 0x04000A39 RID: 2617
		private SHA1Internal sha;
	}
}
