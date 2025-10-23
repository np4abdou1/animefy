using System;
using Mono.Security.X509;

namespace System.Security.Cryptography.X509Certificates
{
	/// <summary>Represents an X.509 store, which is a physical store where certificates are persisted and managed. This class cannot be inherited.</summary>
	// Token: 0x02000107 RID: 263
	public sealed class X509Store : IDisposable
	{
		/// <summary>Initializes a new instance of the <see cref="T:System.Security.Cryptography.X509Certificates.X509Store" /> class using the specified <see cref="T:System.Security.Cryptography.X509Certificates.StoreName" /> and <see cref="T:System.Security.Cryptography.X509Certificates.StoreLocation" /> values.</summary>
		/// <param name="storeName">One of the enumeration values that specifies the name of the X.509 certificate store. </param>
		/// <param name="storeLocation">One of the enumeration values that specifies the location of the X.509 certificate store. </param>
		/// <exception cref="T:System.ArgumentException">
		///         <paramref name="storeLocation" /> is not a valid location or <paramref name="storeName" /> is not a valid name. </exception>
		// Token: 0x06000787 RID: 1927 RVA: 0x0002AD98 File Offset: 0x00028F98
		public X509Store(StoreName storeName, StoreLocation storeLocation)
		{
			if (storeName < StoreName.AddressBook || storeName > StoreName.TrustedPublisher)
			{
				throw new ArgumentException("storeName");
			}
			if (storeLocation < StoreLocation.CurrentUser || storeLocation > StoreLocation.LocalMachine)
			{
				throw new ArgumentException("storeLocation");
			}
			if (storeName == StoreName.CertificateAuthority)
			{
				this._name = "CA";
			}
			else
			{
				this._name = storeName.ToString();
			}
			this._location = storeLocation;
		}

		/// <summary>Returns a collection of certificates located in an X.509 certificate store.</summary>
		/// <returns>A collection of certificates.</returns>
		// Token: 0x1700014C RID: 332
		// (get) Token: 0x06000788 RID: 1928 RVA: 0x0002ADFC File Offset: 0x00028FFC
		public X509Certificate2Collection Certificates
		{
			get
			{
				if (this.list == null)
				{
					this.list = new X509Certificate2Collection();
				}
				else if (this.store == null)
				{
					this.list.Clear();
				}
				return this.list;
			}
		}

		// Token: 0x1700014D RID: 333
		// (get) Token: 0x06000789 RID: 1929 RVA: 0x0002AE2C File Offset: 0x0002902C
		private X509Stores Factory
		{
			get
			{
				if (this._location == StoreLocation.CurrentUser)
				{
					return X509StoreManager.CurrentUser;
				}
				return X509StoreManager.LocalMachine;
			}
		}

		// Token: 0x1700014E RID: 334
		// (get) Token: 0x0600078A RID: 1930 RVA: 0x0002AE42 File Offset: 0x00029042
		internal X509Store Store
		{
			get
			{
				return this.store;
			}
		}

		/// <summary>Closes an X.509 certificate store.</summary>
		// Token: 0x0600078B RID: 1931 RVA: 0x0002AE4A File Offset: 0x0002904A
		public void Close()
		{
			this.store = null;
			if (this.list != null)
			{
				this.list.Clear();
			}
		}

		/// <summary>Releases the resources used by this <see cref="T:System.Security.Cryptography.X509Certificates.X509Store" />.</summary>
		// Token: 0x0600078C RID: 1932 RVA: 0x0002AE66 File Offset: 0x00029066
		public void Dispose()
		{
			this.Close();
		}

		/// <summary>Opens an X.509 certificate store or creates a new store, depending on <see cref="T:System.Security.Cryptography.X509Certificates.OpenFlags" /> flag settings.</summary>
		/// <param name="flags">A bitwise combination of enumeration values that specifies the way to open the X.509 certificate store. </param>
		/// <exception cref="T:System.Security.Cryptography.CryptographicException">The store is unreadable. </exception>
		/// <exception cref="T:System.Security.SecurityException">The caller does not have the required permission. </exception>
		/// <exception cref="T:System.ArgumentException">The store contains invalid values.</exception>
		// Token: 0x0600078D RID: 1933 RVA: 0x0002AE70 File Offset: 0x00029070
		public void Open(OpenFlags flags)
		{
			if (string.IsNullOrEmpty(this._name))
			{
				throw new CryptographicException(Locale.GetText("Invalid store name (null or empty)."));
			}
			string storeName;
			if (this._name == "Root")
			{
				storeName = "Trust";
			}
			else
			{
				storeName = this._name;
			}
			bool create = (flags & OpenFlags.OpenExistingOnly) != OpenFlags.OpenExistingOnly;
			this.store = this.Factory.Open(storeName, create);
			if (this.store == null)
			{
				throw new CryptographicException(Locale.GetText("Store {0} doesn't exists.", new object[]
				{
					this._name
				}));
			}
			this._flags = flags;
			foreach (X509Certificate x509Certificate in this.store.Certificates)
			{
				X509Certificate2 x509Certificate2 = new X509Certificate2(x509Certificate.RawData);
				x509Certificate2.Impl.PrivateKey = x509Certificate.RSA;
				this.Certificates.Add(x509Certificate2);
			}
		}

		// Token: 0x0400050A RID: 1290
		private string _name;

		// Token: 0x0400050B RID: 1291
		private StoreLocation _location;

		// Token: 0x0400050C RID: 1292
		private X509Certificate2Collection list;

		// Token: 0x0400050D RID: 1293
		private OpenFlags _flags;

		// Token: 0x0400050E RID: 1294
		private X509Store store;
	}
}
