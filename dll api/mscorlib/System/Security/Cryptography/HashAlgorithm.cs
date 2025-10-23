using System;

namespace System.Security.Cryptography
{
	/// <summary>Represents the base class from which all implementations of cryptographic hash algorithms must derive.</summary>
	// Token: 0x020002A2 RID: 674
	public abstract class HashAlgorithm : IDisposable, ICryptoTransform
	{
		/// <summary>Creates an instance of the specified implementation of a hash algorithm.</summary>
		/// <param name="hashName">The hash algorithm implementation to use. The following table shows the valid values for the <paramref name="hashName" /> parameter and the algorithms they map to. Parameter value Implements SHA 
		///               <see cref="T:System.Security.Cryptography.SHA1CryptoServiceProvider" />
		///             SHA1 
		///               <see cref="T:System.Security.Cryptography.SHA1CryptoServiceProvider" />
		///             System.Security.Cryptography.SHA1 
		///               <see cref="T:System.Security.Cryptography.SHA1CryptoServiceProvider" />
		///             System.Security.Cryptography.HashAlgorithm 
		///               <see cref="T:System.Security.Cryptography.SHA1CryptoServiceProvider" />
		///             MD5 
		///               <see cref="T:System.Security.Cryptography.MD5CryptoServiceProvider" />
		///             System.Security.Cryptography.MD5 
		///               <see cref="T:System.Security.Cryptography.MD5CryptoServiceProvider" />
		///             SHA256 
		///               <see cref="T:System.Security.Cryptography.SHA256Managed" />
		///             SHA-256 
		///               <see cref="T:System.Security.Cryptography.SHA256Managed" />
		///             System.Security.Cryptography.SHA256 
		///               <see cref="T:System.Security.Cryptography.SHA256Managed" />
		///             SHA384 
		///               <see cref="T:System.Security.Cryptography.SHA384Managed" />
		///             SHA-384 
		///               <see cref="T:System.Security.Cryptography.SHA384Managed" />
		///             System.Security.Cryptography.SHA384 
		///               <see cref="T:System.Security.Cryptography.SHA384Managed" />
		///             SHA512 
		///               <see cref="T:System.Security.Cryptography.SHA512Managed" />
		///             SHA-512 
		///               <see cref="T:System.Security.Cryptography.SHA512Managed" />
		///             System.Security.Cryptography.SHA512 
		///               <see cref="T:System.Security.Cryptography.SHA512Managed" />
		///             </param>
		/// <returns>A new instance of the specified hash algorithm, or <see langword="null" /> if <paramref name="hashName" /> is not a valid hash algorithm.</returns>
		// Token: 0x060016F8 RID: 5880 RVA: 0x0005F3A0 File Offset: 0x0005D5A0
		public static HashAlgorithm Create(string hashName)
		{
			return (HashAlgorithm)CryptoConfigForwarder.CreateFromName(hashName);
		}

		/// <summary>Gets the size, in bits, of the computed hash code.</summary>
		/// <returns>The size, in bits, of the computed hash code.</returns>
		// Token: 0x17000261 RID: 609
		// (get) Token: 0x060016F9 RID: 5881 RVA: 0x0005F3AD File Offset: 0x0005D5AD
		public virtual int HashSize
		{
			get
			{
				return this.HashSizeValue;
			}
		}

		/// <summary>Gets the value of the computed hash code.</summary>
		/// <returns>The current value of the computed hash code.</returns>
		/// <exception cref="T:System.Security.Cryptography.CryptographicUnexpectedOperationException">
		///         <see cref="F:System.Security.Cryptography.HashAlgorithm.HashValue" /> is <see langword="null" />. </exception>
		/// <exception cref="T:System.ObjectDisposedException">The object has already been disposed.</exception>
		// Token: 0x17000262 RID: 610
		// (get) Token: 0x060016FA RID: 5882 RVA: 0x0005F3B5 File Offset: 0x0005D5B5
		public virtual byte[] Hash
		{
			get
			{
				if (this._disposed)
				{
					throw new ObjectDisposedException(null);
				}
				if (this.State != 0)
				{
					throw new CryptographicUnexpectedOperationException("Hash must be finalized before the hash value is retrieved.");
				}
				byte[] hashValue = this.HashValue;
				return (byte[])((hashValue != null) ? hashValue.Clone() : null);
			}
		}

		/// <summary>Computes the hash value for the specified byte array.</summary>
		/// <param name="buffer">The input to compute the hash code for. </param>
		/// <returns>The computed hash code.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="buffer" /> is <see langword="null" />.</exception>
		/// <exception cref="T:System.ObjectDisposedException">The object has already been disposed.</exception>
		// Token: 0x060016FB RID: 5883 RVA: 0x0005F3F0 File Offset: 0x0005D5F0
		public byte[] ComputeHash(byte[] buffer)
		{
			if (this._disposed)
			{
				throw new ObjectDisposedException(null);
			}
			if (buffer == null)
			{
				throw new ArgumentNullException("buffer");
			}
			this.HashCore(buffer, 0, buffer.Length);
			return this.CaptureHashCodeAndReinitialize();
		}

		/// <summary>Computes the hash value for the specified region of the specified byte array.</summary>
		/// <param name="buffer">The input to compute the hash code for. </param>
		/// <param name="offset">The offset into the byte array from which to begin using data. </param>
		/// <param name="count">The number of bytes in the array to use as data. </param>
		/// <returns>The computed hash code.</returns>
		/// <exception cref="T:System.ArgumentException">
		///         <paramref name="count" /> is an invalid value.-or-
		///         <paramref name="buffer" /> length is invalid.</exception>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="buffer" /> is <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///         <paramref name="offset" /> is out of range. This parameter requires a non-negative number.</exception>
		/// <exception cref="T:System.ObjectDisposedException">The object has already been disposed.</exception>
		// Token: 0x060016FC RID: 5884 RVA: 0x0005F420 File Offset: 0x0005D620
		public byte[] ComputeHash(byte[] buffer, int offset, int count)
		{
			if (buffer == null)
			{
				throw new ArgumentNullException("buffer");
			}
			if (offset < 0)
			{
				throw new ArgumentOutOfRangeException("offset", "Non-negative number required.");
			}
			if (count < 0 || count > buffer.Length)
			{
				throw new ArgumentException("Argument {0} should be larger than {1}.");
			}
			if (buffer.Length - count < offset)
			{
				throw new ArgumentException("Offset and length were out of bounds for the array or count is greater than the number of elements from index to the end of the source collection.");
			}
			if (this._disposed)
			{
				throw new ObjectDisposedException(null);
			}
			this.HashCore(buffer, offset, count);
			return this.CaptureHashCodeAndReinitialize();
		}

		// Token: 0x060016FD RID: 5885 RVA: 0x0005F495 File Offset: 0x0005D695
		private byte[] CaptureHashCodeAndReinitialize()
		{
			this.HashValue = this.HashFinal();
			byte[] result = (byte[])this.HashValue.Clone();
			this.Initialize();
			return result;
		}

		/// <summary>Releases all resources used by the current instance of the <see cref="T:System.Security.Cryptography.HashAlgorithm" /> class.</summary>
		// Token: 0x060016FE RID: 5886 RVA: 0x0005F4B9 File Offset: 0x0005D6B9
		public void Dispose()
		{
			this.Dispose(true);
			GC.SuppressFinalize(this);
		}

		/// <summary>Releases all resources used by the <see cref="T:System.Security.Cryptography.HashAlgorithm" /> class.</summary>
		// Token: 0x060016FF RID: 5887 RVA: 0x0005F4C8 File Offset: 0x0005D6C8
		public void Clear()
		{
			((IDisposable)this).Dispose();
		}

		/// <summary>Releases the unmanaged resources used by the <see cref="T:System.Security.Cryptography.HashAlgorithm" /> and optionally releases the managed resources.</summary>
		/// <param name="disposing">
		///       <see langword="true" /> to release both managed and unmanaged resources; <see langword="false" /> to release only unmanaged resources. </param>
		// Token: 0x06001700 RID: 5888 RVA: 0x0005F4D0 File Offset: 0x0005D6D0
		protected virtual void Dispose(bool disposing)
		{
			if (disposing)
			{
				this._disposed = true;
			}
		}

		/// <summary>When overridden in a derived class, gets the input block size.</summary>
		/// <returns>The input block size.</returns>
		// Token: 0x17000263 RID: 611
		// (get) Token: 0x06001701 RID: 5889 RVA: 0x0000B18D File Offset: 0x0000938D
		public virtual int InputBlockSize
		{
			get
			{
				return 1;
			}
		}

		/// <summary>When overridden in a derived class, gets the output block size.</summary>
		/// <returns>The output block size.</returns>
		// Token: 0x17000264 RID: 612
		// (get) Token: 0x06001702 RID: 5890 RVA: 0x0000B18D File Offset: 0x0000938D
		public virtual int OutputBlockSize
		{
			get
			{
				return 1;
			}
		}

		/// <summary>When overridden in a derived class, gets a value indicating whether multiple blocks can be transformed.</summary>
		/// <returns>
		///     <see langword="true" /> if multiple blocks can be transformed; otherwise, <see langword="false" />.</returns>
		// Token: 0x17000265 RID: 613
		// (get) Token: 0x06001703 RID: 5891 RVA: 0x0000B18D File Offset: 0x0000938D
		public virtual bool CanTransformMultipleBlocks
		{
			get
			{
				return true;
			}
		}

		/// <summary>Computes the hash value for the specified region of the input byte array and copies the specified region of the input byte array to the specified region of the output byte array.</summary>
		/// <param name="inputBuffer">The input to compute the hash code for. </param>
		/// <param name="inputOffset">The offset into the input byte array from which to begin using data. </param>
		/// <param name="inputCount">The number of bytes in the input byte array to use as data. </param>
		/// <param name="outputBuffer">A copy of the part of the input array used to compute the hash code. </param>
		/// <param name="outputOffset">The offset into the output byte array from which to begin writing data. </param>
		/// <returns>The number of bytes written.</returns>
		/// <exception cref="T:System.ArgumentException">
		///         <paramref name="inputCount" /> uses an invalid value.-or-
		///         <paramref name="inputBuffer" /> has an invalid length.</exception>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="inputBuffer" /> is <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///         <paramref name="inputOffset" /> is out of range. This parameter requires a non-negative number.</exception>
		/// <exception cref="T:System.ObjectDisposedException">The object has already been disposed.</exception>
		// Token: 0x06001704 RID: 5892 RVA: 0x0005F4DC File Offset: 0x0005D6DC
		public int TransformBlock(byte[] inputBuffer, int inputOffset, int inputCount, byte[] outputBuffer, int outputOffset)
		{
			this.ValidateTransformBlock(inputBuffer, inputOffset, inputCount);
			this.State = 1;
			this.HashCore(inputBuffer, inputOffset, inputCount);
			if (outputBuffer != null && (inputBuffer != outputBuffer || inputOffset != outputOffset))
			{
				Buffer.BlockCopy(inputBuffer, inputOffset, outputBuffer, outputOffset, inputCount);
			}
			return inputCount;
		}

		/// <summary>Computes the hash value for the specified region of the specified byte array.</summary>
		/// <param name="inputBuffer">The input to compute the hash code for. </param>
		/// <param name="inputOffset">The offset into the byte array from which to begin using data. </param>
		/// <param name="inputCount">The number of bytes in the byte array to use as data. </param>
		/// <returns>An array that is a copy of the part of the input that is hashed.</returns>
		/// <exception cref="T:System.ArgumentException">
		///         <paramref name="inputCount" /> uses an invalid value.-or-
		///         <paramref name="inputBuffer" /> has an invalid offset length.</exception>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="inputBuffer" /> is <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///         <paramref name="inputOffset" /> is out of range. This parameter requires a non-negative number.</exception>
		/// <exception cref="T:System.ObjectDisposedException">The object has already been disposed.</exception>
		// Token: 0x06001705 RID: 5893 RVA: 0x0005F514 File Offset: 0x0005D714
		public byte[] TransformFinalBlock(byte[] inputBuffer, int inputOffset, int inputCount)
		{
			this.ValidateTransformBlock(inputBuffer, inputOffset, inputCount);
			this.HashCore(inputBuffer, inputOffset, inputCount);
			this.HashValue = this.CaptureHashCodeAndReinitialize();
			byte[] array;
			if (inputCount != 0)
			{
				array = new byte[inputCount];
				Buffer.BlockCopy(inputBuffer, inputOffset, array, 0, inputCount);
			}
			else
			{
				array = Array.Empty<byte>();
			}
			this.State = 0;
			return array;
		}

		// Token: 0x06001706 RID: 5894 RVA: 0x0005F564 File Offset: 0x0005D764
		private void ValidateTransformBlock(byte[] inputBuffer, int inputOffset, int inputCount)
		{
			if (inputBuffer == null)
			{
				throw new ArgumentNullException("inputBuffer");
			}
			if (inputOffset < 0)
			{
				throw new ArgumentOutOfRangeException("inputOffset", "Non-negative number required.");
			}
			if (inputCount < 0 || inputCount > inputBuffer.Length)
			{
				throw new ArgumentException("Argument {0} should be larger than {1}.");
			}
			if (inputBuffer.Length - inputCount < inputOffset)
			{
				throw new ArgumentException("Offset and length were out of bounds for the array or count is greater than the number of elements from index to the end of the source collection.");
			}
			if (this._disposed)
			{
				throw new ObjectDisposedException(null);
			}
		}

		/// <summary>When overridden in a derived class, routes data written to the object into the hash algorithm for computing the hash.</summary>
		/// <param name="array">The input to compute the hash code for. </param>
		/// <param name="ibStart">The offset into the byte array from which to begin using data. </param>
		/// <param name="cbSize">The number of bytes in the byte array to use as data. </param>
		// Token: 0x06001707 RID: 5895
		protected abstract void HashCore(byte[] array, int ibStart, int cbSize);

		/// <summary>When overridden in a derived class, finalizes the hash computation after the last data is processed by the cryptographic stream object.</summary>
		/// <returns>The computed hash code.</returns>
		// Token: 0x06001708 RID: 5896
		protected abstract byte[] HashFinal();

		/// <summary>Initializes an implementation of the <see cref="T:System.Security.Cryptography.HashAlgorithm" /> class.</summary>
		// Token: 0x06001709 RID: 5897
		public abstract void Initialize();

		// Token: 0x0400095F RID: 2399
		private bool _disposed;

		/// <summary>Represents the size, in bits, of the computed hash code.</summary>
		// Token: 0x04000960 RID: 2400
		protected int HashSizeValue;

		/// <summary>Represents the value of the computed hash code.</summary>
		// Token: 0x04000961 RID: 2401
		protected internal byte[] HashValue;

		/// <summary>Represents the state of the hash computation.</summary>
		// Token: 0x04000962 RID: 2402
		protected int State;
	}
}
