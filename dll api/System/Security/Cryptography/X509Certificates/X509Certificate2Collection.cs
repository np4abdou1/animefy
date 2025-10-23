using System;
using System.Collections;
using System.Globalization;

namespace System.Security.Cryptography.X509Certificates
{
	/// <summary>Represents a collection of <see cref="T:System.Security.Cryptography.X509Certificates.X509Certificate2" /> objects. This class cannot be inherited.</summary>
	// Token: 0x020000F1 RID: 241
	public class X509Certificate2Collection : X509CertificateCollection
	{
		/// <summary>Initializes a new instance of the <see cref="T:System.Security.Cryptography.X509Certificates.X509Certificate2Collection" /> class without any <see cref="T:System.Security.Cryptography.X509Certificates.X509Certificate2" /> information.</summary>
		// Token: 0x060006A5 RID: 1701 RVA: 0x00027973 File Offset: 0x00025B73
		public X509Certificate2Collection()
		{
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Security.Cryptography.X509Certificates.X509Certificate2Collection" /> class using the specified certificate collection.</summary>
		/// <param name="certificates">An <see cref="T:System.Security.Cryptography.X509Certificates.X509Certificate2Collection" /> object. </param>
		// Token: 0x060006A6 RID: 1702 RVA: 0x0002797B File Offset: 0x00025B7B
		public X509Certificate2Collection(X509Certificate2Collection certificates)
		{
			this.AddRange(certificates);
		}

		/// <summary>Gets or sets the element at the specified index.</summary>
		/// <param name="index">The zero-based index of the element to get or set. </param>
		/// <returns>The element at the specified index.</returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///         <paramref name="index" /> is less than zero.-or- 
		///         <paramref name="index" /> is equal to or greater than the <see cref="P:System.Collections.CollectionBase.Count" /> property. </exception>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="index" /> is <see langword="null" />. </exception>
		// Token: 0x17000100 RID: 256
		public X509Certificate2 this[int index]
		{
			get
			{
				if (index < 0)
				{
					throw new ArgumentOutOfRangeException("negative index");
				}
				if (index >= base.InnerList.Count)
				{
					throw new ArgumentOutOfRangeException("index >= Count");
				}
				return (X509Certificate2)base.InnerList[index];
			}
		}

		/// <summary>Adds an object to the end of the <see cref="T:System.Security.Cryptography.X509Certificates.X509Certificate2Collection" />.</summary>
		/// <param name="certificate">An X.509 certificate represented as an <see cref="T:System.Security.Cryptography.X509Certificates.X509Certificate2" /> object. </param>
		/// <returns>The <see cref="T:System.Security.Cryptography.X509Certificates.X509Certificate2Collection" /> index at which the <paramref name="certificate" /> has been added.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="certificate" /> is <see langword="null" />. </exception>
		// Token: 0x060006A8 RID: 1704 RVA: 0x000279C5 File Offset: 0x00025BC5
		public int Add(X509Certificate2 certificate)
		{
			if (certificate == null)
			{
				throw new ArgumentNullException("certificate");
			}
			return base.InnerList.Add(certificate);
		}

		/// <summary>Adds multiple <see cref="T:System.Security.Cryptography.X509Certificates.X509Certificate2" /> objects in an <see cref="T:System.Security.Cryptography.X509Certificates.X509Certificate2Collection" /> object to another <see cref="T:System.Security.Cryptography.X509Certificates.X509Certificate2Collection" /> object.</summary>
		/// <param name="certificates">An <see cref="T:System.Security.Cryptography.X509Certificates.X509Certificate2Collection" /> object. </param>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="certificates" /> is <see langword="null" />. </exception>
		// Token: 0x060006A9 RID: 1705 RVA: 0x000279E1 File Offset: 0x00025BE1
		public void AddRange(X509Certificate2Collection certificates)
		{
			if (certificates == null)
			{
				throw new ArgumentNullException("certificates");
			}
			base.InnerList.AddRange(certificates);
		}

		/// <summary>Determines whether the <see cref="T:System.Security.Cryptography.X509Certificates.X509Certificate2Collection" /> object contains a specific certificate.</summary>
		/// <param name="certificate">The <see cref="T:System.Security.Cryptography.X509Certificates.X509Certificate2" /> object to locate in the collection. </param>
		/// <returns>
		///     <see langword="true" /> if the <see cref="T:System.Security.Cryptography.X509Certificates.X509Certificate2Collection" /> contains the specified <paramref name="certificate" />; otherwise, <see langword="false" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="certificate" /> is <see langword="null" />. </exception>
		// Token: 0x060006AA RID: 1706 RVA: 0x00027A00 File Offset: 0x00025C00
		public bool Contains(X509Certificate2 certificate)
		{
			if (certificate == null)
			{
				throw new ArgumentNullException("certificate");
			}
			using (IEnumerator enumerator = base.InnerList.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					if (((X509Certificate2)enumerator.Current).Equals(certificate))
					{
						return true;
					}
				}
			}
			return false;
		}

		// Token: 0x060006AB RID: 1707 RVA: 0x00027A70 File Offset: 0x00025C70
		private string GetKeyIdentifier(X509Certificate2 x)
		{
			X509SubjectKeyIdentifierExtension x509SubjectKeyIdentifierExtension = x.Extensions["2.5.29.14"] as X509SubjectKeyIdentifierExtension;
			if (x509SubjectKeyIdentifierExtension == null)
			{
				x509SubjectKeyIdentifierExtension = new X509SubjectKeyIdentifierExtension(x.PublicKey, X509SubjectKeyIdentifierHashAlgorithm.CapiSha1, false);
			}
			return x509SubjectKeyIdentifierExtension.SubjectKeyIdentifier;
		}

		/// <summary>Searches an <see cref="T:System.Security.Cryptography.X509Certificates.X509Certificate2Collection" /> object using the search criteria specified by the <see cref="T:System.Security.Cryptography.X509Certificates.X509FindType" /> enumeration and the <paramref name="findValue" /> object.</summary>
		/// <param name="findType">One of the <see cref="T:System.Security.Cryptography.X509Certificates.X509FindType" />  values. </param>
		/// <param name="findValue">The search criteria as an object. </param>
		/// <param name="validOnly">
		///       <see langword="true" /> to allow only valid certificates to be returned from the search; otherwise, <see langword="false" />. </param>
		/// <returns>An <see cref="T:System.Security.Cryptography.X509Certificates.X509Certificate2Collection" /> object.</returns>
		/// <exception cref="T:System.Security.Cryptography.CryptographicException">
		///         <paramref name="findType" /> is invalid. </exception>
		// Token: 0x060006AC RID: 1708 RVA: 0x00027AAC File Offset: 0x00025CAC
		public X509Certificate2Collection Find(X509FindType findType, object findValue, bool validOnly)
		{
			if (findValue == null)
			{
				throw new ArgumentNullException("findValue");
			}
			string text = string.Empty;
			string text2 = string.Empty;
			X509KeyUsageFlags x509KeyUsageFlags = X509KeyUsageFlags.None;
			DateTime t = DateTime.MinValue;
			switch (findType)
			{
			case X509FindType.FindByThumbprint:
			case X509FindType.FindBySubjectName:
			case X509FindType.FindBySubjectDistinguishedName:
			case X509FindType.FindByIssuerName:
			case X509FindType.FindByIssuerDistinguishedName:
			case X509FindType.FindBySerialNumber:
			case X509FindType.FindByTemplateName:
			case X509FindType.FindBySubjectKeyIdentifier:
				try
				{
					text = (string)findValue;
					goto IL_190;
				}
				catch (Exception inner)
				{
					throw new CryptographicException(Locale.GetText("Invalid find value type '{0}', expected '{1}'.", new object[]
					{
						findValue.GetType(),
						"string"
					}), inner);
				}
				break;
			case X509FindType.FindByTimeValid:
			case X509FindType.FindByTimeNotYetValid:
			case X509FindType.FindByTimeExpired:
				goto IL_13C;
			case X509FindType.FindByApplicationPolicy:
			case X509FindType.FindByCertificatePolicy:
			case X509FindType.FindByExtension:
				break;
			case X509FindType.FindByKeyUsage:
				goto IL_107;
			default:
				goto IL_171;
			}
			try
			{
				text2 = (string)findValue;
			}
			catch (Exception inner2)
			{
				throw new CryptographicException(Locale.GetText("Invalid find value type '{0}', expected '{1}'.", new object[]
				{
					findValue.GetType(),
					"X509KeyUsageFlags"
				}), inner2);
			}
			try
			{
				CryptoConfig.EncodeOID(text2);
				goto IL_190;
			}
			catch (CryptographicUnexpectedOperationException)
			{
				string text3 = Locale.GetText("Invalid OID value '{0}'.", new object[]
				{
					text2
				});
				throw new ArgumentException("findValue", text3);
			}
			IL_107:
			try
			{
				x509KeyUsageFlags = (X509KeyUsageFlags)findValue;
				goto IL_190;
			}
			catch (Exception inner3)
			{
				throw new CryptographicException(Locale.GetText("Invalid find value type '{0}', expected '{1}'.", new object[]
				{
					findValue.GetType(),
					"X509KeyUsageFlags"
				}), inner3);
			}
			IL_13C:
			try
			{
				t = (DateTime)findValue;
				goto IL_190;
			}
			catch (Exception inner4)
			{
				throw new CryptographicException(Locale.GetText("Invalid find value type '{0}', expected '{1}'.", new object[]
				{
					findValue.GetType(),
					"X509DateTime"
				}), inner4);
			}
			IL_171:
			throw new CryptographicException(Locale.GetText("Invalid find type '{0}'.", new object[]
			{
				findType
			}));
			IL_190:
			CultureInfo invariantCulture = CultureInfo.InvariantCulture;
			X509Certificate2Collection x509Certificate2Collection = new X509Certificate2Collection();
			foreach (object obj in base.InnerList)
			{
				X509Certificate2 x509Certificate = (X509Certificate2)obj;
				bool flag = false;
				switch (findType)
				{
				case X509FindType.FindByThumbprint:
					flag = (string.Compare(text, x509Certificate.Thumbprint, true, invariantCulture) == 0 || string.Compare(text, x509Certificate.GetCertHashString(), true, invariantCulture) == 0);
					break;
				case X509FindType.FindBySubjectName:
					foreach (string text4 in x509Certificate.SubjectName.Format(true).Split(X509Certificate2Collection.newline_split, StringSplitOptions.RemoveEmptyEntries))
					{
						int startIndex = text4.IndexOf('=');
						flag = (text4.IndexOf(text, startIndex, StringComparison.InvariantCultureIgnoreCase) >= 0);
						if (flag)
						{
							break;
						}
					}
					break;
				case X509FindType.FindBySubjectDistinguishedName:
					flag = (string.Compare(text, x509Certificate.Subject, true, invariantCulture) == 0);
					break;
				case X509FindType.FindByIssuerName:
					flag = (x509Certificate.GetNameInfo(X509NameType.SimpleName, true).IndexOf(text, StringComparison.InvariantCultureIgnoreCase) >= 0);
					break;
				case X509FindType.FindByIssuerDistinguishedName:
					flag = (string.Compare(text, x509Certificate.Issuer, true, invariantCulture) == 0);
					break;
				case X509FindType.FindBySerialNumber:
					flag = (string.Compare(text, x509Certificate.SerialNumber, true, invariantCulture) == 0);
					break;
				case X509FindType.FindByTimeValid:
					flag = (t >= x509Certificate.NotBefore && t <= x509Certificate.NotAfter);
					break;
				case X509FindType.FindByTimeNotYetValid:
					flag = (t < x509Certificate.NotBefore);
					break;
				case X509FindType.FindByTimeExpired:
					flag = (t > x509Certificate.NotAfter);
					break;
				case X509FindType.FindByApplicationPolicy:
					flag = (x509Certificate.Extensions.Count == 0);
					break;
				case X509FindType.FindByExtension:
					flag = (x509Certificate.Extensions[text2] != null);
					break;
				case X509FindType.FindByKeyUsage:
				{
					X509KeyUsageExtension x509KeyUsageExtension = x509Certificate.Extensions["2.5.29.15"] as X509KeyUsageExtension;
					flag = (x509KeyUsageExtension == null || (x509KeyUsageExtension.KeyUsages & x509KeyUsageFlags) == x509KeyUsageFlags);
					break;
				}
				case X509FindType.FindBySubjectKeyIdentifier:
					flag = (string.Compare(text, this.GetKeyIdentifier(x509Certificate), true, invariantCulture) == 0);
					break;
				}
				if (flag)
				{
					if (validOnly)
					{
						try
						{
							if (x509Certificate.Verify())
							{
								x509Certificate2Collection.Add(x509Certificate);
							}
							continue;
						}
						catch
						{
							continue;
						}
					}
					x509Certificate2Collection.Add(x509Certificate);
				}
			}
			return x509Certificate2Collection;
		}

		/// <summary>Returns an enumerator that can iterate through a <see cref="T:System.Security.Cryptography.X509Certificates.X509Certificate2Collection" /> object.</summary>
		/// <returns>An <see cref="T:System.Security.Cryptography.X509Certificates.X509Certificate2Enumerator" /> object that can iterate through the <see cref="T:System.Security.Cryptography.X509Certificates.X509Certificate2Collection" /> object.</returns>
		// Token: 0x060006AD RID: 1709 RVA: 0x00027F68 File Offset: 0x00026168
		public new X509Certificate2Enumerator GetEnumerator()
		{
			return new X509Certificate2Enumerator(this);
		}

		// Token: 0x040004D6 RID: 1238
		private static string[] newline_split = new string[]
		{
			Environment.NewLine
		};
	}
}
