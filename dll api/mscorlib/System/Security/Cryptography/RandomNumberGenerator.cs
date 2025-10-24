using System;
using System.Runtime.InteropServices;

namespace System.Security.Cryptography
{
	/// <summary>Represents the abstract class from which all implementations of cryptographic random number generators derive.</summary>
	// Token: 0x020002C3 RID: 707
	[ComVisible(true)]
	public abstract class RandomNumberGenerator : IDisposable
	{
		/// <summary>When overridden in a derived class, creates an instance of the default implementation of a cryptographic random number generator that can be used to generate random data.</summary>
		/// <returns>A new instance of a cryptographic random number generator.</returns>
		// Token: 0x0600179B RID: 6043 RVA: 0x00060DA8 File Offset: 0x0005EFA8
		public static RandomNumberGenerator Create()
		{
			return RandomNumberGenerator.Create("System.Security.Cryptography.RandomNumberGenerator");
		}

		/// <summary>When overridden in a derived class, creates an instance of the specified implementation of a cryptographic random number generator.</summary>
		/// <param name="rngName">The name of the random number generator implementation to use. </param>
		/// <returns>A new instance of a cryptographic random number generator.</returns>
		// Token: 0x0600179C RID: 6044 RVA: 0x00060DB4 File Offset: 0x0005EFB4
		public static RandomNumberGenerator Create(string rngName)
		{
			return (RandomNumberGenerator)CryptoConfig.CreateFromName(rngName);
		}

		/// <summary>When overridden in a derived class, releases all resources used by the current instance of the <see cref="T:System.Security.Cryptography.RandomNumberGenerator" /> class.</summary>
		// Token: 0x0600179D RID: 6045 RVA: 0x00060DC1 File Offset: 0x0005EFC1
		public void Dispose()
		{
			this.Dispose(true);
			GC.SuppressFinalize(this);
		}

		/// <summary>When overridden in a derived class, releases the unmanaged resources used by the <see cref="T:System.Security.Cryptography.RandomNumberGenerator" /> and optionally releases the managed resources.</summary>
		/// <param name="disposing">
		///       <see langword="true" /> to release both managed and unmanaged resources; <see langword="false" /> to release only unmanaged resources.</param>
		// Token: 0x0600179E RID: 6046 RVA: 0x00002A7D File Offset: 0x00000C7D
		protected virtual void Dispose(bool disposing)
		{
		}

		/// <summary>When overridden in a derived class, fills an array of bytes with a cryptographically strong random sequence of values.</summary>
		/// <param name="data">The array to fill with cryptographically strong random bytes. </param>
		// Token: 0x0600179F RID: 6047
		public abstract void GetBytes(byte[] data);
	}
}
