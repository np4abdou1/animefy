using System;

namespace System.Security.Cryptography.X509Certificates
{
	/// <summary>Represents a chain-building engine for <see cref="T:System.Security.Cryptography.X509Certificates.X509Certificate2" /> certificates.</summary>
	// Token: 0x020000F9 RID: 249
	public class X509Chain : IDisposable
	{
		// Token: 0x17000124 RID: 292
		// (get) Token: 0x060006FE RID: 1790 RVA: 0x00028A2C File Offset: 0x00026C2C
		internal X509ChainImpl Impl
		{
			get
			{
				X509Helper2.ThrowIfContextInvalid(this.impl);
				return this.impl;
			}
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Security.Cryptography.X509Certificates.X509Chain" /> class.</summary>
		// Token: 0x060006FF RID: 1791 RVA: 0x00028A3F File Offset: 0x00026C3F
		public X509Chain() : this(false)
		{
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Security.Cryptography.X509Certificates.X509Chain" /> class specifying a value that indicates whether the machine context should be used.</summary>
		/// <param name="useMachineContext">
		///       <see langword="true" /> to use the machine context; <see langword="false" /> to use the current user context. </param>
		// Token: 0x06000700 RID: 1792 RVA: 0x00028A48 File Offset: 0x00026C48
		public X509Chain(bool useMachineContext)
		{
			this.impl = X509Helper2.CreateChainImpl(useMachineContext);
		}

		// Token: 0x06000701 RID: 1793 RVA: 0x00028A5C File Offset: 0x00026C5C
		internal X509Chain(X509ChainImpl impl)
		{
			X509Helper2.ThrowIfContextInvalid(impl);
			this.impl = impl;
		}

		/// <summary>Gets a collection of <see cref="T:System.Security.Cryptography.X509Certificates.X509ChainElement" /> objects.</summary>
		/// <returns>An <see cref="T:System.Security.Cryptography.X509Certificates.X509ChainElementCollection" /> object.</returns>
		// Token: 0x17000125 RID: 293
		// (get) Token: 0x06000702 RID: 1794 RVA: 0x00028A71 File Offset: 0x00026C71
		public X509ChainElementCollection ChainElements
		{
			get
			{
				return this.Impl.ChainElements;
			}
		}

		/// <summary>Gets or sets the <see cref="T:System.Security.Cryptography.X509Certificates.X509ChainPolicy" /> to use when building an X.509 certificate chain.</summary>
		/// <returns>The <see cref="T:System.Security.Cryptography.X509Certificates.X509ChainPolicy" /> object associated with this X.509 chain.</returns>
		/// <exception cref="T:System.ArgumentNullException">The value being set for this property is <see langword="null" />.</exception>
		// Token: 0x17000126 RID: 294
		// (get) Token: 0x06000703 RID: 1795 RVA: 0x00028A7E File Offset: 0x00026C7E
		public X509ChainPolicy ChainPolicy
		{
			get
			{
				return this.Impl.ChainPolicy;
			}
		}

		/// <summary>Builds an X.509 chain using the policy specified in <see cref="T:System.Security.Cryptography.X509Certificates.X509ChainPolicy" />.</summary>
		/// <param name="certificate">An <see cref="T:System.Security.Cryptography.X509Certificates.X509Certificate2" /> object.</param>
		/// <returns>
		///     <see langword="true" /> if the X.509 certificate is valid; otherwise, <see langword="false" />.</returns>
		/// <exception cref="T:System.ArgumentException">The <paramref name="certificate" /> is not a valid certificate or is <see langword="null" />. </exception>
		/// <exception cref="T:System.Security.Cryptography.CryptographicException">The <paramref name="certificate" /> is unreadable. </exception>
		// Token: 0x06000704 RID: 1796 RVA: 0x00028A8B File Offset: 0x00026C8B
		public bool Build(X509Certificate2 certificate)
		{
			return this.Impl.Build(certificate);
		}

		/// <summary>Clears the current <see cref="T:System.Security.Cryptography.X509Certificates.X509Chain" /> object.</summary>
		// Token: 0x06000705 RID: 1797 RVA: 0x00028A99 File Offset: 0x00026C99
		public void Reset()
		{
			this.Impl.Reset();
		}

		/// <summary>Creates an <see cref="T:System.Security.Cryptography.X509Certificates.X509Chain" /> object after querying for the mapping defined in the CryptoConfig file, and maps the chain to that mapping.</summary>
		/// <returns>An <see cref="T:System.Security.Cryptography.X509Certificates.X509Chain" /> object.</returns>
		// Token: 0x06000706 RID: 1798 RVA: 0x00028AA6 File Offset: 0x00026CA6
		public static X509Chain Create()
		{
			return (X509Chain)CryptoConfig.CreateFromName("X509Chain");
		}

		/// <summary>Releases all of the resources used by this <see cref="T:System.Security.Cryptography.X509Certificates.X509Chain" />.</summary>
		// Token: 0x06000707 RID: 1799 RVA: 0x00028AB7 File Offset: 0x00026CB7
		public void Dispose()
		{
			this.Dispose(true);
			GC.SuppressFinalize(this);
		}

		/// <summary>Releases the unmanaged resources used by this <see cref="T:System.Security.Cryptography.X509Certificates.X509Chain" />, and optionally releases the managed resources.</summary>
		/// <param name="disposing">
		///       <see langword="true" /> to release both managed and unmanaged resources; <see langword="false" /> to release only unmanaged resources.</param>
		// Token: 0x06000708 RID: 1800 RVA: 0x00028AC6 File Offset: 0x00026CC6
		protected virtual void Dispose(bool disposing)
		{
			if (this.impl != null)
			{
				this.impl.Dispose();
				this.impl = null;
			}
		}

		// Token: 0x06000709 RID: 1801 RVA: 0x00028AE4 File Offset: 0x00026CE4
		~X509Chain()
		{
			this.Dispose(false);
		}

		// Token: 0x040004E0 RID: 1248
		private X509ChainImpl impl;
	}
}
