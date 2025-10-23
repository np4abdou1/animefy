using System;

namespace System.Security
{
	/// <summary>Represents text that should be kept confidential, such as by deleting it from computer memory when no longer needed. This class cannot be inherited.</summary>
	// Token: 0x02000283 RID: 643
	public sealed class SecureString : IDisposable
	{
		/// <summary>Initializes a new instance of the <see cref="T:System.Security.SecureString" /> class.</summary>
		/// <exception cref="T:System.Security.Cryptography.CryptographicException">An error occurred while protecting or unprotecting the value of this instance.</exception>
		/// <exception cref="T:System.NotSupportedException">This operation is not supported on this platform.</exception>
		// Token: 0x0600166E RID: 5742 RVA: 0x0005BA18 File Offset: 0x00059C18
		public SecureString()
		{
			this.Alloc(8, false);
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Security.SecureString" /> class from a subarray of <see cref="T:System.Char" /> objects. This constructor is not CLS-compliant. The CLS-compliant alternative is <see cref="M:System.Security.SecureString.#ctor" />.</summary>
		/// <param name="value">A pointer to an array of <see cref="T:System.Char" /> objects.</param>
		/// <param name="length">The number of elements of <paramref name="value" /> to include in the new instance.</param>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="value" /> is <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///         <paramref name="length" /> is less than zero or greater than 65,536.</exception>
		/// <exception cref="T:System.Security.Cryptography.CryptographicException">An error occurred while protecting or unprotecting the value of this secure string. </exception>
		/// <exception cref="T:System.NotSupportedException">This operation is not supported on this platform.</exception>
		// Token: 0x0600166F RID: 5743 RVA: 0x0005BA28 File Offset: 0x00059C28
		[CLSCompliant(false)]
		public unsafe SecureString(char* value, int length)
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (length < 0 || length > 65536)
			{
				throw new ArgumentOutOfRangeException("length", "< 0 || > 65536");
			}
			this.length = length;
			this.Alloc(length, false);
			int num = 0;
			for (int i = 0; i < length; i++)
			{
				char c = *(value++);
				this.data[num++] = (byte)(c >> 8);
				this.data[num++] = (byte)c;
			}
			this.Encrypt();
		}

		/// <summary>Gets the number of characters in the current secure string.</summary>
		/// <returns>The number of <see cref="T:System.Char" /> objects in this secure string.</returns>
		/// <exception cref="T:System.ObjectDisposedException">This secure string has already been disposed.</exception>
		// Token: 0x1700024A RID: 586
		// (get) Token: 0x06001670 RID: 5744 RVA: 0x0005BAB0 File Offset: 0x00059CB0
		public int Length
		{
			get
			{
				if (this.disposed)
				{
					throw new ObjectDisposedException("SecureString");
				}
				return this.length;
			}
		}

		/// <summary>Releases all resources used by the current <see cref="T:System.Security.SecureString" /> object.</summary>
		// Token: 0x06001671 RID: 5745 RVA: 0x0005BACB File Offset: 0x00059CCB
		public void Dispose()
		{
			this.disposed = true;
			if (this.data != null)
			{
				Array.Clear(this.data, 0, this.data.Length);
				this.data = null;
			}
			this.length = 0;
		}

		// Token: 0x06001672 RID: 5746 RVA: 0x0005BAFE File Offset: 0x00059CFE
		private void Encrypt()
		{
			if (this.data != null)
			{
				int num = this.data.Length;
			}
		}

		// Token: 0x06001673 RID: 5747 RVA: 0x0005BAFE File Offset: 0x00059CFE
		private void Decrypt()
		{
			if (this.data != null)
			{
				int num = this.data.Length;
			}
		}

		// Token: 0x06001674 RID: 5748 RVA: 0x0005BB10 File Offset: 0x00059D10
		private void Alloc(int length, bool realloc)
		{
			if (length < 0 || length > 65536)
			{
				throw new ArgumentOutOfRangeException("length", "< 0 || > 65536");
			}
			int num = (length >> 3) + (((length & 7) == 0) ? 0 : 1) << 4;
			if (realloc && this.data != null && num == this.data.Length)
			{
				return;
			}
			if (realloc)
			{
				byte[] array = new byte[num];
				Array.Copy(this.data, 0, array, 0, Math.Min(this.data.Length, array.Length));
				Array.Clear(this.data, 0, this.data.Length);
				this.data = array;
				return;
			}
			this.data = new byte[num];
		}

		// Token: 0x06001675 RID: 5749 RVA: 0x0005BBB0 File Offset: 0x00059DB0
		internal byte[] GetBuffer()
		{
			byte[] array = new byte[this.length << 1];
			try
			{
				this.Decrypt();
				Buffer.BlockCopy(this.data, 0, array, 0, array.Length);
			}
			finally
			{
				this.Encrypt();
			}
			return array;
		}

		// Token: 0x040008B6 RID: 2230
		private int length;

		// Token: 0x040008B7 RID: 2231
		private bool disposed;

		// Token: 0x040008B8 RID: 2232
		private byte[] data;
	}
}
