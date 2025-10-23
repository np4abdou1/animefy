using System;

namespace System.Security.Cryptography.X509Certificates
{
	/// <summary>Represents the chain policy to be applied when building an X509 certificate chain. This class cannot be inherited.</summary>
	// Token: 0x020000FF RID: 255
	public sealed class X509ChainPolicy
	{
		/// <summary>Initializes a new instance of the <see cref="T:System.Security.Cryptography.X509Certificates.X509ChainPolicy" /> class. </summary>
		// Token: 0x06000752 RID: 1874 RVA: 0x0002A131 File Offset: 0x00028331
		public X509ChainPolicy()
		{
			this.Reset();
		}

		/// <summary>Represents an additional collection of certificates that can be searched by the chaining engine when validating a certificate chain.</summary>
		/// <returns>An <see cref="T:System.Security.Cryptography.X509Certificates.X509Certificate2Collection" /> object.</returns>
		// Token: 0x1700013D RID: 317
		// (get) Token: 0x06000753 RID: 1875 RVA: 0x0002A140 File Offset: 0x00028340
		// (set) Token: 0x06000754 RID: 1876 RVA: 0x0002A1C8 File Offset: 0x000283C8
		public X509Certificate2Collection ExtraStore
		{
			get
			{
				if (this.store2 != null)
				{
					return this.store2;
				}
				this.store2 = new X509Certificate2Collection();
				if (this.store != null)
				{
					foreach (X509Certificate certificate in this.store)
					{
						this.store2.Add(new X509Certificate2(certificate));
					}
				}
				return this.store2;
			}
			internal set
			{
				this.store2 = value;
			}
		}

		/// <summary>Gets or sets values for X509 revocation flags.</summary>
		/// <returns>An <see cref="T:System.Security.Cryptography.X509Certificates.X509RevocationFlag" /> object.</returns>
		/// <exception cref="T:System.ArgumentException">The <see cref="T:System.Security.Cryptography.X509Certificates.X509RevocationFlag" /> value supplied is not a valid flag. </exception>
		// Token: 0x1700013E RID: 318
		// (get) Token: 0x06000755 RID: 1877 RVA: 0x0002A1D1 File Offset: 0x000283D1
		public X509RevocationFlag RevocationFlag
		{
			get
			{
				return this.rflag;
			}
		}

		/// <summary>Gets or sets values for X509 certificate revocation mode.</summary>
		/// <returns>An <see cref="T:System.Security.Cryptography.X509Certificates.X509RevocationMode" /> object.</returns>
		/// <exception cref="T:System.ArgumentException">The <see cref="T:System.Security.Cryptography.X509Certificates.X509RevocationMode" /> value supplied is not a valid flag. </exception>
		// Token: 0x1700013F RID: 319
		// (get) Token: 0x06000756 RID: 1878 RVA: 0x0002A1D9 File Offset: 0x000283D9
		// (set) Token: 0x06000757 RID: 1879 RVA: 0x0002A1E1 File Offset: 0x000283E1
		public X509RevocationMode RevocationMode
		{
			get
			{
				return this.mode;
			}
			set
			{
				if (value < X509RevocationMode.NoCheck || value > X509RevocationMode.Offline)
				{
					throw new ArgumentException("RevocationMode");
				}
				this.mode = value;
			}
		}

		/// <summary>Gets verification flags for the certificate.</summary>
		/// <returns>A value from the <see cref="T:System.Security.Cryptography.X509Certificates.X509VerificationFlags" /> enumeration.</returns>
		/// <exception cref="T:System.ArgumentException">The <see cref="T:System.Security.Cryptography.X509Certificates.X509VerificationFlags" /> value supplied is not a valid flag. <see cref="F:System.Security.Cryptography.X509Certificates.X509VerificationFlags.NoFlag" /> is the default value. </exception>
		// Token: 0x17000140 RID: 320
		// (get) Token: 0x06000758 RID: 1880 RVA: 0x0002A1FD File Offset: 0x000283FD
		// (set) Token: 0x06000759 RID: 1881 RVA: 0x0002A205 File Offset: 0x00028405
		public X509VerificationFlags VerificationFlags
		{
			get
			{
				return this.vflags;
			}
			set
			{
				if ((value | X509VerificationFlags.AllFlags) != X509VerificationFlags.AllFlags)
				{
					throw new ArgumentException("VerificationFlags");
				}
				this.vflags = value;
			}
		}

		/// <summary>The time that the certificate was verified expressed in local time.</summary>
		/// <returns>A <see cref="T:System.DateTime" /> object.</returns>
		// Token: 0x17000141 RID: 321
		// (get) Token: 0x0600075A RID: 1882 RVA: 0x0002A227 File Offset: 0x00028427
		public DateTime VerificationTime
		{
			get
			{
				return this.vtime;
			}
		}

		/// <summary>Resets the <see cref="T:System.Security.Cryptography.X509Certificates.X509ChainPolicy" /> members to their default values.</summary>
		// Token: 0x0600075B RID: 1883 RVA: 0x0002A230 File Offset: 0x00028430
		public void Reset()
		{
			this.apps = new OidCollection();
			this.cert = new OidCollection();
			this.store2 = null;
			this.rflag = X509RevocationFlag.ExcludeRoot;
			this.mode = X509RevocationMode.Online;
			this.timeout = TimeSpan.Zero;
			this.vflags = X509VerificationFlags.NoFlag;
			this.vtime = DateTime.Now;
		}

		// Token: 0x040004F7 RID: 1271
		private OidCollection apps;

		// Token: 0x040004F8 RID: 1272
		private OidCollection cert;

		// Token: 0x040004F9 RID: 1273
		private X509CertificateCollection store;

		// Token: 0x040004FA RID: 1274
		private X509Certificate2Collection store2;

		// Token: 0x040004FB RID: 1275
		private X509RevocationFlag rflag;

		// Token: 0x040004FC RID: 1276
		private X509RevocationMode mode;

		// Token: 0x040004FD RID: 1277
		private TimeSpan timeout;

		// Token: 0x040004FE RID: 1278
		private X509VerificationFlags vflags;

		// Token: 0x040004FF RID: 1279
		private DateTime vtime;
	}
}
