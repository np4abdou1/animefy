using System;
using System.Runtime.InteropServices;

namespace System.Security.Cryptography
{
	/// <summary>Represents the abstract class from which all implementations of keyed hash algorithms must derive. </summary>
	// Token: 0x020002BF RID: 703
	[ComVisible(true)]
	public abstract class KeyedHashAlgorithm : HashAlgorithm
	{
		/// <summary>Releases the unmanaged resources used by the <see cref="T:System.Security.Cryptography.KeyedHashAlgorithm" /> and optionally releases the managed resources.</summary>
		/// <param name="disposing">
		///       <see langword="true" /> to release both managed and unmanaged resources; <see langword="false" /> to release only unmanaged resources. </param>
		// Token: 0x06001780 RID: 6016 RVA: 0x0006094E File Offset: 0x0005EB4E
		protected override void Dispose(bool disposing)
		{
			if (disposing)
			{
				if (this.KeyValue != null)
				{
					Array.Clear(this.KeyValue, 0, this.KeyValue.Length);
				}
				this.KeyValue = null;
			}
			base.Dispose(disposing);
		}

		/// <summary>Gets or sets the key to use in the hash algorithm.</summary>
		/// <returns>The key to use in the hash algorithm.</returns>
		/// <exception cref="T:System.Security.Cryptography.CryptographicException">An attempt was made to change the <see cref="P:System.Security.Cryptography.KeyedHashAlgorithm.Key" /> property after hashing has begun. </exception>
		// Token: 0x17000273 RID: 627
		// (get) Token: 0x06001781 RID: 6017 RVA: 0x000602CD File Offset: 0x0005E4CD
		// (set) Token: 0x06001782 RID: 6018 RVA: 0x0006097D File Offset: 0x0005EB7D
		public virtual byte[] Key
		{
			get
			{
				return (byte[])this.KeyValue.Clone();
			}
			set
			{
				if (this.State != 0)
				{
					throw new CryptographicException(Environment.GetResourceString("Hash key cannot be changed after the first write to the stream."));
				}
				this.KeyValue = (byte[])value.Clone();
			}
		}

		/// <summary>The key to use in the hash algorithm.</summary>
		// Token: 0x040009AA RID: 2474
		protected byte[] KeyValue;
	}
}
