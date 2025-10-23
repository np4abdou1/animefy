using System;
using System.Runtime.InteropServices;

namespace System.Security.Cryptography
{
	/// <summary>Represents the abstract class from which all implementations of Hash-based Message Authentication Code (HMAC) must derive.</summary>
	// Token: 0x020002B4 RID: 692
	[ComVisible(true)]
	public abstract class HMAC : KeyedHashAlgorithm
	{
		/// <summary>Gets or sets the block size to use in the hash value.</summary>
		/// <returns>The block size to use in the hash value.</returns>
		// Token: 0x1700026C RID: 620
		// (get) Token: 0x0600174B RID: 5963 RVA: 0x000601BE File Offset: 0x0005E3BE
		// (set) Token: 0x0600174C RID: 5964 RVA: 0x000601C6 File Offset: 0x0005E3C6
		protected int BlockSizeValue
		{
			get
			{
				return this.blockSizeValue;
			}
			set
			{
				this.blockSizeValue = value;
			}
		}

		// Token: 0x0600174D RID: 5965 RVA: 0x000601D0 File Offset: 0x0005E3D0
		private void UpdateIOPadBuffers()
		{
			if (this.m_inner == null)
			{
				this.m_inner = new byte[this.BlockSizeValue];
			}
			if (this.m_outer == null)
			{
				this.m_outer = new byte[this.BlockSizeValue];
			}
			for (int i = 0; i < this.BlockSizeValue; i++)
			{
				this.m_inner[i] = 54;
				this.m_outer[i] = 92;
			}
			for (int i = 0; i < this.KeyValue.Length; i++)
			{
				byte[] inner = this.m_inner;
				int num = i;
				inner[num] ^= this.KeyValue[i];
				byte[] outer = this.m_outer;
				int num2 = i;
				outer[num2] ^= this.KeyValue[i];
			}
		}

		// Token: 0x0600174E RID: 5966 RVA: 0x0006027C File Offset: 0x0005E47C
		internal void InitializeKey(byte[] key)
		{
			this.m_inner = null;
			this.m_outer = null;
			if (key.Length > this.BlockSizeValue)
			{
				this.KeyValue = this.m_hash1.ComputeHash(key);
			}
			else
			{
				this.KeyValue = (byte[])key.Clone();
			}
			this.UpdateIOPadBuffers();
		}

		/// <summary>Gets or sets the key to use in the hash algorithm.</summary>
		/// <returns>The key to use in the hash algorithm.</returns>
		/// <exception cref="T:System.Security.Cryptography.CryptographicException">An attempt is made to change the <see cref="P:System.Security.Cryptography.HMAC.Key" /> property after hashing has begun. </exception>
		// Token: 0x1700026D RID: 621
		// (get) Token: 0x0600174F RID: 5967 RVA: 0x000602CD File Offset: 0x0005E4CD
		// (set) Token: 0x06001750 RID: 5968 RVA: 0x000602DF File Offset: 0x0005E4DF
		public override byte[] Key
		{
			get
			{
				return (byte[])this.KeyValue.Clone();
			}
			set
			{
				if (this.m_hashing)
				{
					throw new CryptographicException(Environment.GetResourceString("Hash key cannot be changed after the first write to the stream."));
				}
				this.InitializeKey(value);
			}
		}

		/// <summary>Creates an instance of the default implementation of a Hash-based Message Authentication Code (HMAC).</summary>
		/// <returns>A new SHA-1 instance, unless the default settings have been changed by using the &lt;cryptoClass&gt; element.</returns>
		// Token: 0x06001751 RID: 5969 RVA: 0x00060300 File Offset: 0x0005E500
		public static HMAC Create()
		{
			return HMAC.Create("System.Security.Cryptography.HMAC");
		}

		/// <summary>Creates an instance of the specified implementation of a Hash-based Message Authentication Code (HMAC).</summary>
		/// <param name="algorithmName">The HMAC implementation to use. The following table shows the valid values for the <paramref name="algorithmName" /> parameter and the algorithms they map to.Parameter valueImplements System.Security.Cryptography.HMAC
		///               <see cref="T:System.Security.Cryptography.HMACSHA1" />
		///             System.Security.Cryptography.KeyedHashAlgorithm
		///               <see cref="T:System.Security.Cryptography.HMACSHA1" />
		///             HMACMD5
		///               <see cref="T:System.Security.Cryptography.HMACMD5" />
		///             System.Security.Cryptography.HMACMD5
		///               <see cref="T:System.Security.Cryptography.HMACMD5" />
		///             HMACRIPEMD160
		///               <see cref="T:System.Security.Cryptography.HMACRIPEMD160" />
		///             System.Security.Cryptography.HMACRIPEMD160
		///               <see cref="T:System.Security.Cryptography.HMACRIPEMD160" />
		///             HMACSHA1
		///               <see cref="T:System.Security.Cryptography.HMACSHA1" />
		///             System.Security.Cryptography.HMACSHA1
		///               <see cref="T:System.Security.Cryptography.HMACSHA1" />
		///             HMACSHA256
		///               <see cref="T:System.Security.Cryptography.HMACSHA256" />
		///             System.Security.Cryptography.HMACSHA256
		///               <see cref="T:System.Security.Cryptography.HMACSHA256" />
		///             HMACSHA384
		///               <see cref="T:System.Security.Cryptography.HMACSHA384" />
		///             System.Security.Cryptography.HMACSHA384
		///               <see cref="T:System.Security.Cryptography.HMACSHA384" />
		///             HMACSHA512
		///               <see cref="T:System.Security.Cryptography.HMACSHA512" />
		///             System.Security.Cryptography.HMACSHA512
		///               <see cref="T:System.Security.Cryptography.HMACSHA512" />
		///             MACTripleDES
		///               <see cref="T:System.Security.Cryptography.MACTripleDES" />
		///             System.Security.Cryptography.MACTripleDES
		///               <see cref="T:System.Security.Cryptography.MACTripleDES" />
		///             </param>
		/// <returns>A new instance of the specified HMAC implementation.</returns>
		// Token: 0x06001752 RID: 5970 RVA: 0x0006030C File Offset: 0x0005E50C
		public new static HMAC Create(string algorithmName)
		{
			return (HMAC)CryptoConfig.CreateFromName(algorithmName);
		}

		/// <summary>Initializes an instance of the default implementation of <see cref="T:System.Security.Cryptography.HMAC" />.</summary>
		// Token: 0x06001753 RID: 5971 RVA: 0x00060319 File Offset: 0x0005E519
		public override void Initialize()
		{
			this.m_hash1.Initialize();
			this.m_hash2.Initialize();
			this.m_hashing = false;
		}

		/// <summary>When overridden in a derived class, routes data written to the object into the default <see cref="T:System.Security.Cryptography.HMAC" /> hash algorithm for computing the hash value.</summary>
		/// <param name="rgb">The input data. </param>
		/// <param name="ib">The offset into the byte array from which to begin using data. </param>
		/// <param name="cb">The number of bytes in the array to use as data. </param>
		// Token: 0x06001754 RID: 5972 RVA: 0x00060338 File Offset: 0x0005E538
		protected override void HashCore(byte[] rgb, int ib, int cb)
		{
			if (!this.m_hashing)
			{
				this.m_hash1.TransformBlock(this.m_inner, 0, this.m_inner.Length, this.m_inner, 0);
				this.m_hashing = true;
			}
			this.m_hash1.TransformBlock(rgb, ib, cb, rgb, ib);
		}

		/// <summary>When overridden in a derived class, finalizes the hash computation after the last data is processed by the cryptographic stream object.</summary>
		/// <returns>The computed hash code in a byte array.</returns>
		// Token: 0x06001755 RID: 5973 RVA: 0x00060388 File Offset: 0x0005E588
		protected override byte[] HashFinal()
		{
			if (!this.m_hashing)
			{
				this.m_hash1.TransformBlock(this.m_inner, 0, this.m_inner.Length, this.m_inner, 0);
				this.m_hashing = true;
			}
			this.m_hash1.TransformFinalBlock(EmptyArray<byte>.Value, 0, 0);
			byte[] hashValue = this.m_hash1.HashValue;
			this.m_hash2.TransformBlock(this.m_outer, 0, this.m_outer.Length, this.m_outer, 0);
			this.m_hash2.TransformBlock(hashValue, 0, hashValue.Length, hashValue, 0);
			this.m_hashing = false;
			this.m_hash2.TransformFinalBlock(EmptyArray<byte>.Value, 0, 0);
			return this.m_hash2.HashValue;
		}

		/// <summary>Releases the unmanaged resources used by the <see cref="T:System.Security.Cryptography.HMAC" /> class when a key change is legitimate and optionally releases the managed resources.</summary>
		/// <param name="disposing">
		///       <see langword="true" /> to release both managed and unmanaged resources; <see langword="false" /> to release only unmanaged resources. </param>
		// Token: 0x06001756 RID: 5974 RVA: 0x00060440 File Offset: 0x0005E640
		protected override void Dispose(bool disposing)
		{
			if (disposing)
			{
				if (this.m_hash1 != null)
				{
					((IDisposable)this.m_hash1).Dispose();
				}
				if (this.m_hash2 != null)
				{
					((IDisposable)this.m_hash2).Dispose();
				}
				if (this.m_inner != null)
				{
					Array.Clear(this.m_inner, 0, this.m_inner.Length);
				}
				if (this.m_outer != null)
				{
					Array.Clear(this.m_outer, 0, this.m_outer.Length);
				}
			}
			base.Dispose(disposing);
		}

		// Token: 0x06001757 RID: 5975 RVA: 0x000604B8 File Offset: 0x0005E6B8
		internal static HashAlgorithm GetHashAlgorithmWithFipsFallback(Func<HashAlgorithm> createStandardHashAlgorithmCallback, Func<HashAlgorithm> createFipsHashAlgorithmCallback)
		{
			if (CryptoConfig.AllowOnlyFipsAlgorithms)
			{
				try
				{
					return createFipsHashAlgorithmCallback();
				}
				catch (PlatformNotSupportedException ex)
				{
					throw new InvalidOperationException(ex.Message, ex);
				}
			}
			return createStandardHashAlgorithmCallback();
		}

		// Token: 0x04000992 RID: 2450
		private int blockSizeValue = 64;

		// Token: 0x04000993 RID: 2451
		internal string m_hashName;

		// Token: 0x04000994 RID: 2452
		internal HashAlgorithm m_hash1;

		// Token: 0x04000995 RID: 2453
		internal HashAlgorithm m_hash2;

		// Token: 0x04000996 RID: 2454
		private byte[] m_inner;

		// Token: 0x04000997 RID: 2455
		private byte[] m_outer;

		// Token: 0x04000998 RID: 2456
		private bool m_hashing;
	}
}
