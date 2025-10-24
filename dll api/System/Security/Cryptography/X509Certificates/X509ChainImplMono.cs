﻿using System;
using System.Collections;
using System.Text;
using Mono.Security.X509;
using Mono.Security.X509.Extensions;

namespace System.Security.Cryptography.X509Certificates
{
	// Token: 0x020000FE RID: 254
	internal class X509ChainImplMono : X509ChainImpl
	{
		// Token: 0x0600072D RID: 1837 RVA: 0x00028F64 File Offset: 0x00027164
		public X509ChainImplMono(bool useMachineContext)
		{
			this.location = (useMachineContext ? StoreLocation.LocalMachine : StoreLocation.CurrentUser);
			this.elements = new X509ChainElementCollection();
			this.policy = new X509ChainPolicy();
		}

		// Token: 0x17000133 RID: 307
		// (get) Token: 0x0600072E RID: 1838 RVA: 0x00009518 File Offset: 0x00007718
		public override bool IsValid
		{
			get
			{
				return true;
			}
		}

		// Token: 0x17000134 RID: 308
		// (get) Token: 0x0600072F RID: 1839 RVA: 0x00028F8F File Offset: 0x0002718F
		public override X509ChainElementCollection ChainElements
		{
			get
			{
				return this.elements;
			}
		}

		// Token: 0x17000135 RID: 309
		// (get) Token: 0x06000730 RID: 1840 RVA: 0x00028F97 File Offset: 0x00027197
		public override X509ChainPolicy ChainPolicy
		{
			get
			{
				return this.policy;
			}
		}

		// Token: 0x06000731 RID: 1841 RVA: 0x00004D67 File Offset: 0x00002F67
		public override void AddStatus(X509ChainStatusFlags error)
		{
		}

		// Token: 0x06000732 RID: 1842 RVA: 0x00028FA0 File Offset: 0x000271A0
		public override bool Build(X509Certificate2 certificate)
		{
			if (certificate == null)
			{
				throw new ArgumentException("certificate");
			}
			this.Reset();
			X509ChainStatusFlags x509ChainStatusFlags;
			try
			{
				x509ChainStatusFlags = this.BuildChainFrom(certificate);
				this.ValidateChain(x509ChainStatusFlags);
			}
			catch (CryptographicException innerException)
			{
				throw new ArgumentException("certificate", innerException);
			}
			X509ChainStatusFlags x509ChainStatusFlags2 = X509ChainStatusFlags.NoError;
			ArrayList arrayList = new ArrayList();
			foreach (X509ChainElement x509ChainElement in this.elements)
			{
				foreach (X509ChainStatus x509ChainStatus in x509ChainElement.ChainElementStatus)
				{
					if ((x509ChainStatusFlags2 & x509ChainStatus.Status) != x509ChainStatus.Status)
					{
						arrayList.Add(x509ChainStatus);
						x509ChainStatusFlags2 |= x509ChainStatus.Status;
					}
				}
			}
			if (x509ChainStatusFlags != X509ChainStatusFlags.NoError)
			{
				arrayList.Insert(0, new X509ChainStatus(x509ChainStatusFlags));
			}
			this.status = (X509ChainStatus[])arrayList.ToArray(typeof(X509ChainStatus));
			if (this.status.Length == 0 || this.ChainPolicy.VerificationFlags == X509VerificationFlags.AllFlags)
			{
				return true;
			}
			bool flag = true;
			X509ChainStatus[] chainElementStatus = this.status;
			int i = 0;
			while (i < chainElementStatus.Length)
			{
				X509ChainStatus x509ChainStatus2 = chainElementStatus[i];
				X509ChainStatusFlags x509ChainStatusFlags3 = x509ChainStatus2.Status;
				if (x509ChainStatusFlags3 <= X509ChainStatusFlags.InvalidNameConstraints)
				{
					if (x509ChainStatusFlags3 <= X509ChainStatusFlags.UntrustedRoot)
					{
						if (x509ChainStatusFlags3 != X509ChainStatusFlags.NotTimeValid)
						{
							if (x509ChainStatusFlags3 != X509ChainStatusFlags.NotTimeNested)
							{
								if (x509ChainStatusFlags3 != X509ChainStatusFlags.UntrustedRoot)
								{
									goto IL_2E4;
								}
								goto IL_216;
							}
							else
							{
								flag &= ((this.ChainPolicy.VerificationFlags & X509VerificationFlags.IgnoreNotTimeNested) > X509VerificationFlags.NoFlag);
							}
						}
						else
						{
							flag &= ((this.ChainPolicy.VerificationFlags & X509VerificationFlags.IgnoreNotTimeValid) > X509VerificationFlags.NoFlag);
						}
					}
					else if (x509ChainStatusFlags3 <= X509ChainStatusFlags.InvalidPolicyConstraints)
					{
						if (x509ChainStatusFlags3 != X509ChainStatusFlags.InvalidExtension)
						{
							if (x509ChainStatusFlags3 != X509ChainStatusFlags.InvalidPolicyConstraints)
							{
								goto IL_2E4;
							}
							goto IL_274;
						}
						else
						{
							flag &= ((this.ChainPolicy.VerificationFlags & X509VerificationFlags.IgnoreWrongUsage) > X509VerificationFlags.NoFlag);
						}
					}
					else if (x509ChainStatusFlags3 != X509ChainStatusFlags.InvalidBasicConstraints)
					{
						if (x509ChainStatusFlags3 != X509ChainStatusFlags.InvalidNameConstraints)
						{
							goto IL_2E4;
						}
						goto IL_28D;
					}
					else
					{
						flag &= ((this.ChainPolicy.VerificationFlags & X509VerificationFlags.IgnoreInvalidBasicConstraints) > X509VerificationFlags.NoFlag);
					}
				}
				else if (x509ChainStatusFlags3 <= X509ChainStatusFlags.PartialChain)
				{
					if (x509ChainStatusFlags3 <= X509ChainStatusFlags.HasNotPermittedNameConstraint)
					{
						if (x509ChainStatusFlags3 != X509ChainStatusFlags.HasNotSupportedNameConstraint && x509ChainStatusFlags3 != X509ChainStatusFlags.HasNotPermittedNameConstraint)
						{
							goto IL_2E4;
						}
						goto IL_28D;
					}
					else
					{
						if (x509ChainStatusFlags3 == X509ChainStatusFlags.HasExcludedNameConstraint)
						{
							goto IL_28D;
						}
						if (x509ChainStatusFlags3 != X509ChainStatusFlags.PartialChain)
						{
							goto IL_2E4;
						}
						goto IL_216;
					}
				}
				else if (x509ChainStatusFlags3 <= X509ChainStatusFlags.CtlNotSignatureValid)
				{
					if (x509ChainStatusFlags3 != X509ChainStatusFlags.CtlNotTimeValid)
					{
						if (x509ChainStatusFlags3 != X509ChainStatusFlags.CtlNotSignatureValid)
						{
							goto IL_2E4;
						}
					}
					else
					{
						flag &= ((this.ChainPolicy.VerificationFlags & X509VerificationFlags.IgnoreCtlNotTimeValid) > X509VerificationFlags.NoFlag);
					}
				}
				else if (x509ChainStatusFlags3 != X509ChainStatusFlags.CtlNotValidForUsage)
				{
					if (x509ChainStatusFlags3 != X509ChainStatusFlags.NoIssuanceChainPolicy)
					{
						goto IL_2E4;
					}
					goto IL_274;
				}
				else
				{
					flag &= ((this.ChainPolicy.VerificationFlags & X509VerificationFlags.IgnoreWrongUsage) > X509VerificationFlags.NoFlag);
				}
				IL_2E6:
				if (!flag)
				{
					return false;
				}
				i++;
				continue;
				IL_216:
				flag &= ((this.ChainPolicy.VerificationFlags & X509VerificationFlags.AllowUnknownCertificateAuthority) > X509VerificationFlags.NoFlag);
				goto IL_2E6;
				IL_274:
				flag &= ((this.ChainPolicy.VerificationFlags & X509VerificationFlags.IgnoreInvalidPolicy) > X509VerificationFlags.NoFlag);
				goto IL_2E6;
				IL_28D:
				flag &= ((this.ChainPolicy.VerificationFlags & X509VerificationFlags.IgnoreInvalidName) > X509VerificationFlags.NoFlag);
				goto IL_2E6;
				IL_2E4:
				flag = false;
				goto IL_2E6;
			}
			return true;
		}

		// Token: 0x06000733 RID: 1843 RVA: 0x000292BC File Offset: 0x000274BC
		public override void Reset()
		{
			if (this.status != null && this.status.Length != 0)
			{
				this.status = null;
			}
			if (this.elements.Count > 0)
			{
				this.elements.Clear();
			}
			if (this.user_root_store != null)
			{
				this.user_root_store.Close();
				this.user_root_store = null;
			}
			if (this.root_store != null)
			{
				this.root_store.Close();
				this.root_store = null;
			}
			if (this.user_ca_store != null)
			{
				this.user_ca_store.Close();
				this.user_ca_store = null;
			}
			if (this.ca_store != null)
			{
				this.ca_store.Close();
				this.ca_store = null;
			}
			this.roots = null;
			this.cas = null;
			this.collection = null;
			this.bce_restriction = null;
			this.working_public_key = null;
		}

		// Token: 0x17000136 RID: 310
		// (get) Token: 0x06000734 RID: 1844 RVA: 0x00029388 File Offset: 0x00027588
		private X509Certificate2Collection Roots
		{
			get
			{
				if (this.roots == null)
				{
					X509Certificate2Collection x509Certificate2Collection = new X509Certificate2Collection();
					X509Store lmrootStore = this.LMRootStore;
					if (this.location == StoreLocation.CurrentUser)
					{
						x509Certificate2Collection.AddRange(this.UserRootStore.Certificates);
					}
					x509Certificate2Collection.AddRange(lmrootStore.Certificates);
					this.roots = x509Certificate2Collection;
				}
				return this.roots;
			}
		}

		// Token: 0x17000137 RID: 311
		// (get) Token: 0x06000735 RID: 1845 RVA: 0x000293E0 File Offset: 0x000275E0
		private X509Certificate2Collection CertificateAuthorities
		{
			get
			{
				if (this.cas == null)
				{
					X509Certificate2Collection x509Certificate2Collection = new X509Certificate2Collection();
					X509Store lmcastore = this.LMCAStore;
					if (this.location == StoreLocation.CurrentUser)
					{
						x509Certificate2Collection.AddRange(this.UserCAStore.Certificates);
					}
					x509Certificate2Collection.AddRange(lmcastore.Certificates);
					this.cas = x509Certificate2Collection;
				}
				return this.cas;
			}
		}

		// Token: 0x17000138 RID: 312
		// (get) Token: 0x06000736 RID: 1846 RVA: 0x00029438 File Offset: 0x00027638
		private X509Store LMRootStore
		{
			get
			{
				if (this.root_store == null)
				{
					this.root_store = new X509Store(StoreName.Root, StoreLocation.LocalMachine);
					try
					{
						this.root_store.Open(OpenFlags.OpenExistingOnly);
					}
					catch
					{
					}
				}
				return this.root_store;
			}
		}

		// Token: 0x17000139 RID: 313
		// (get) Token: 0x06000737 RID: 1847 RVA: 0x00029484 File Offset: 0x00027684
		private X509Store UserRootStore
		{
			get
			{
				if (this.user_root_store == null)
				{
					this.user_root_store = new X509Store(StoreName.Root, StoreLocation.CurrentUser);
					try
					{
						this.user_root_store.Open(OpenFlags.OpenExistingOnly);
					}
					catch
					{
					}
				}
				return this.user_root_store;
			}
		}

		// Token: 0x1700013A RID: 314
		// (get) Token: 0x06000738 RID: 1848 RVA: 0x000294D0 File Offset: 0x000276D0
		private X509Store LMCAStore
		{
			get
			{
				if (this.ca_store == null)
				{
					this.ca_store = new X509Store(StoreName.CertificateAuthority, StoreLocation.LocalMachine);
					try
					{
						this.ca_store.Open(OpenFlags.OpenExistingOnly);
					}
					catch
					{
					}
				}
				return this.ca_store;
			}
		}

		// Token: 0x1700013B RID: 315
		// (get) Token: 0x06000739 RID: 1849 RVA: 0x0002951C File Offset: 0x0002771C
		private X509Store UserCAStore
		{
			get
			{
				if (this.user_ca_store == null)
				{
					this.user_ca_store = new X509Store(StoreName.CertificateAuthority, StoreLocation.CurrentUser);
					try
					{
						this.user_ca_store.Open(OpenFlags.OpenExistingOnly);
					}
					catch
					{
					}
				}
				return this.user_ca_store;
			}
		}

		// Token: 0x1700013C RID: 316
		// (get) Token: 0x0600073A RID: 1850 RVA: 0x00029568 File Offset: 0x00027768
		private X509Certificate2Collection CertificateCollection
		{
			get
			{
				if (this.collection == null)
				{
					this.collection = new X509Certificate2Collection(this.ChainPolicy.ExtraStore);
					this.collection.AddRange(this.Roots);
					this.collection.AddRange(this.CertificateAuthorities);
				}
				return this.collection;
			}
		}

		// Token: 0x0600073B RID: 1851 RVA: 0x000295BC File Offset: 0x000277BC
		private X509ChainStatusFlags BuildChainFrom(X509Certificate2 certificate)
		{
			this.elements.Add(certificate);
			while (!this.IsChainComplete(certificate))
			{
				certificate = this.FindParent(certificate);
				if (certificate == null)
				{
					return X509ChainStatusFlags.PartialChain;
				}
				if (this.elements.Contains(certificate))
				{
					return X509ChainStatusFlags.Cyclic;
				}
				this.elements.Add(certificate);
			}
			if (!this.Roots.Contains(certificate))
			{
				this.elements[this.elements.Count - 1].StatusFlags |= X509ChainStatusFlags.UntrustedRoot;
			}
			return X509ChainStatusFlags.NoError;
		}

		// Token: 0x0600073C RID: 1852 RVA: 0x00029648 File Offset: 0x00027848
		private X509Certificate2 SelectBestFromCollection(X509Certificate2 child, X509Certificate2Collection c)
		{
			int count = c.Count;
			if (count == 0)
			{
				return null;
			}
			if (count == 1)
			{
				return c[0];
			}
			X509Certificate2Collection x509Certificate2Collection = c.Find(X509FindType.FindByTimeValid, this.ChainPolicy.VerificationTime, false);
			int count2 = x509Certificate2Collection.Count;
			if (count2 != 0)
			{
				if (count2 == 1)
				{
					return x509Certificate2Collection[0];
				}
			}
			else
			{
				x509Certificate2Collection = c;
			}
			string authorityKeyIdentifier = X509ChainImplMono.GetAuthorityKeyIdentifier(child);
			if (string.IsNullOrEmpty(authorityKeyIdentifier))
			{
				return x509Certificate2Collection[0];
			}
			foreach (X509Certificate2 x509Certificate in x509Certificate2Collection)
			{
				string subjectKeyIdentifier = this.GetSubjectKeyIdentifier(x509Certificate);
				if (authorityKeyIdentifier == subjectKeyIdentifier)
				{
					return x509Certificate;
				}
			}
			return x509Certificate2Collection[0];
		}

		// Token: 0x0600073D RID: 1853 RVA: 0x000296F8 File Offset: 0x000278F8
		private X509Certificate2 FindParent(X509Certificate2 certificate)
		{
			X509Certificate2Collection x509Certificate2Collection = this.CertificateCollection.Find(X509FindType.FindBySubjectDistinguishedName, certificate.Issuer, false);
			string authorityKeyIdentifier = X509ChainImplMono.GetAuthorityKeyIdentifier(certificate);
			if (authorityKeyIdentifier != null && authorityKeyIdentifier.Length > 0)
			{
				x509Certificate2Collection.AddRange(this.CertificateCollection.Find(X509FindType.FindBySubjectKeyIdentifier, authorityKeyIdentifier, false));
			}
			X509Certificate2 x509Certificate = this.SelectBestFromCollection(certificate, x509Certificate2Collection);
			if (!certificate.Equals(x509Certificate))
			{
				return x509Certificate;
			}
			return null;
		}

		// Token: 0x0600073E RID: 1854 RVA: 0x00029758 File Offset: 0x00027958
		private bool IsChainComplete(X509Certificate2 certificate)
		{
			if (!this.IsSelfIssued(certificate))
			{
				return false;
			}
			if (certificate.Version < 3)
			{
				return true;
			}
			string subjectKeyIdentifier = this.GetSubjectKeyIdentifier(certificate);
			if (string.IsNullOrEmpty(subjectKeyIdentifier))
			{
				return true;
			}
			string authorityKeyIdentifier = X509ChainImplMono.GetAuthorityKeyIdentifier(certificate);
			return string.IsNullOrEmpty(authorityKeyIdentifier) || authorityKeyIdentifier == subjectKeyIdentifier;
		}

		// Token: 0x0600073F RID: 1855 RVA: 0x000297A5 File Offset: 0x000279A5
		private bool IsSelfIssued(X509Certificate2 certificate)
		{
			return certificate.Issuer == certificate.Subject;
		}

		// Token: 0x06000740 RID: 1856 RVA: 0x000297B8 File Offset: 0x000279B8
		private void ValidateChain(X509ChainStatusFlags flag)
		{
			int num = this.elements.Count - 1;
			X509Certificate2 certificate = this.elements[num].Certificate;
			if ((flag & X509ChainStatusFlags.PartialChain) == X509ChainStatusFlags.NoError)
			{
				this.Process(num);
				if (num == 0)
				{
					this.elements[0].UncompressFlags();
					return;
				}
				num--;
			}
			this.working_public_key = certificate.PublicKey.Key;
			this.working_issuer_name = certificate.IssuerName;
			this.max_path_length = num;
			for (int i = num; i > 0; i--)
			{
				this.Process(i);
				this.PrepareForNextCertificate(i);
			}
			this.Process(0);
			this.CheckRevocationOnChain(flag);
			this.WrapUp();
		}

		// Token: 0x06000741 RID: 1857 RVA: 0x00029860 File Offset: 0x00027A60
		private void Process(int n)
		{
			X509ChainElement x509ChainElement = this.elements[n];
			X509Certificate2 certificate = x509ChainElement.Certificate;
			X509Certificate monoCertificate = X509Helper2.GetMonoCertificate(certificate);
			if (n != this.elements.Count - 1 && monoCertificate.KeyAlgorithm == "1.2.840.10040.4.1" && monoCertificate.KeyAlgorithmParameters == null)
			{
				X509Certificate monoCertificate2 = X509Helper2.GetMonoCertificate(this.elements[n + 1].Certificate);
				monoCertificate.KeyAlgorithmParameters = monoCertificate2.KeyAlgorithmParameters;
			}
			bool flag = this.working_public_key == null;
			if (!this.IsSignedWith(certificate, flag ? certificate.PublicKey.Key : this.working_public_key) && (flag || n != this.elements.Count - 1 || this.IsSelfIssued(certificate)))
			{
				x509ChainElement.StatusFlags |= X509ChainStatusFlags.NotSignatureValid;
			}
			if (this.ChainPolicy.VerificationTime < certificate.NotBefore || this.ChainPolicy.VerificationTime > certificate.NotAfter)
			{
				x509ChainElement.StatusFlags |= X509ChainStatusFlags.NotTimeValid;
			}
			if (flag)
			{
				return;
			}
			if (!X500DistinguishedName.AreEqual(certificate.IssuerName, this.working_issuer_name))
			{
				x509ChainElement.StatusFlags |= X509ChainStatusFlags.InvalidNameConstraints;
			}
			if (!this.IsSelfIssued(certificate))
			{
			}
		}

		// Token: 0x06000742 RID: 1858 RVA: 0x000299A0 File Offset: 0x00027BA0
		private void PrepareForNextCertificate(int n)
		{
			X509ChainElement x509ChainElement = this.elements[n];
			X509Certificate2 certificate = x509ChainElement.Certificate;
			this.working_issuer_name = certificate.SubjectName;
			this.working_public_key = certificate.PublicKey.Key;
			X509BasicConstraintsExtension x509BasicConstraintsExtension = certificate.Extensions["2.5.29.19"] as X509BasicConstraintsExtension;
			if (x509BasicConstraintsExtension != null)
			{
				if (!x509BasicConstraintsExtension.CertificateAuthority)
				{
					x509ChainElement.StatusFlags |= X509ChainStatusFlags.InvalidBasicConstraints;
				}
			}
			else if (certificate.Version >= 3)
			{
				x509ChainElement.StatusFlags |= X509ChainStatusFlags.InvalidBasicConstraints;
			}
			if (!this.IsSelfIssued(certificate))
			{
				if (this.max_path_length > 0)
				{
					this.max_path_length--;
				}
				else if (this.bce_restriction != null)
				{
					this.bce_restriction.StatusFlags |= X509ChainStatusFlags.InvalidBasicConstraints;
				}
			}
			if (x509BasicConstraintsExtension != null && x509BasicConstraintsExtension.HasPathLengthConstraint && x509BasicConstraintsExtension.PathLengthConstraint < this.max_path_length)
			{
				this.max_path_length = x509BasicConstraintsExtension.PathLengthConstraint;
				this.bce_restriction = x509ChainElement;
			}
			X509KeyUsageExtension x509KeyUsageExtension = certificate.Extensions["2.5.29.15"] as X509KeyUsageExtension;
			if (x509KeyUsageExtension != null)
			{
				X509KeyUsageFlags x509KeyUsageFlags = X509KeyUsageFlags.KeyCertSign;
				if ((x509KeyUsageExtension.KeyUsages & x509KeyUsageFlags) != x509KeyUsageFlags)
				{
					x509ChainElement.StatusFlags |= X509ChainStatusFlags.NotValidForUsage;
				}
			}
			this.ProcessCertificateExtensions(x509ChainElement);
		}

		// Token: 0x06000743 RID: 1859 RVA: 0x00029ADC File Offset: 0x00027CDC
		private void WrapUp()
		{
			X509ChainElement x509ChainElement = this.elements[0];
			X509Certificate2 certificate = x509ChainElement.Certificate;
			this.IsSelfIssued(certificate);
			this.ProcessCertificateExtensions(x509ChainElement);
			for (int i = this.elements.Count - 1; i >= 0; i--)
			{
				this.elements[i].UncompressFlags();
			}
		}

		// Token: 0x06000744 RID: 1860 RVA: 0x00029B38 File Offset: 0x00027D38
		private void ProcessCertificateExtensions(X509ChainElement element)
		{
			foreach (X509Extension x509Extension in element.Certificate.Extensions)
			{
				if (x509Extension.Critical)
				{
					string value = x509Extension.Oid.Value;
					if (!(value == "2.5.29.15") && !(value == "2.5.29.19"))
					{
						element.StatusFlags |= X509ChainStatusFlags.InvalidExtension;
					}
				}
			}
		}

		// Token: 0x06000745 RID: 1861 RVA: 0x00029BA7 File Offset: 0x00027DA7
		private bool IsSignedWith(X509Certificate2 signed, AsymmetricAlgorithm pubkey)
		{
			return pubkey != null && X509Helper2.GetMonoCertificate(signed).VerifySignature(pubkey);
		}

		// Token: 0x06000746 RID: 1862 RVA: 0x00029BBC File Offset: 0x00027DBC
		private string GetSubjectKeyIdentifier(X509Certificate2 certificate)
		{
			X509SubjectKeyIdentifierExtension x509SubjectKeyIdentifierExtension = certificate.Extensions["2.5.29.14"] as X509SubjectKeyIdentifierExtension;
			if (x509SubjectKeyIdentifierExtension != null)
			{
				return x509SubjectKeyIdentifierExtension.SubjectKeyIdentifier;
			}
			return string.Empty;
		}

		// Token: 0x06000747 RID: 1863 RVA: 0x00029BEE File Offset: 0x00027DEE
		private static string GetAuthorityKeyIdentifier(X509Certificate2 certificate)
		{
			return X509ChainImplMono.GetAuthorityKeyIdentifier(X509Helper2.GetMonoCertificate(certificate).Extensions["2.5.29.35"]);
		}

		// Token: 0x06000748 RID: 1864 RVA: 0x00029C0A File Offset: 0x00027E0A
		private static string GetAuthorityKeyIdentifier(X509Crl crl)
		{
			return X509ChainImplMono.GetAuthorityKeyIdentifier(crl.Extensions["2.5.29.35"]);
		}

		// Token: 0x06000749 RID: 1865 RVA: 0x00029C24 File Offset: 0x00027E24
		private static string GetAuthorityKeyIdentifier(X509Extension ext)
		{
			if (ext == null)
			{
				return string.Empty;
			}
			byte[] identifier = new AuthorityKeyIdentifierExtension(ext).Identifier;
			if (identifier == null)
			{
				return string.Empty;
			}
			StringBuilder stringBuilder = new StringBuilder();
			foreach (byte b in identifier)
			{
				stringBuilder.Append(b.ToString("X02"));
			}
			return stringBuilder.ToString();
		}

		// Token: 0x0600074A RID: 1866 RVA: 0x00029C84 File Offset: 0x00027E84
		private void CheckRevocationOnChain(X509ChainStatusFlags flag)
		{
			bool flag2 = (flag & X509ChainStatusFlags.PartialChain) > X509ChainStatusFlags.NoError;
			bool online;
			switch (this.ChainPolicy.RevocationMode)
			{
			case X509RevocationMode.NoCheck:
				return;
			case X509RevocationMode.Online:
				online = true;
				break;
			case X509RevocationMode.Offline:
				online = false;
				break;
			default:
				throw new InvalidOperationException(Locale.GetText("Invalid revocation mode."));
			}
			bool flag3 = flag2;
			for (int i = this.elements.Count - 1; i >= 0; i--)
			{
				bool flag4 = true;
				switch (this.ChainPolicy.RevocationFlag)
				{
				case X509RevocationFlag.EndCertificateOnly:
					flag4 = (i == 0);
					break;
				case X509RevocationFlag.EntireChain:
					flag4 = true;
					break;
				case X509RevocationFlag.ExcludeRoot:
					flag4 = (i != this.elements.Count - 1);
					break;
				}
				X509ChainElement x509ChainElement = this.elements[i];
				if (!flag3)
				{
					flag3 |= ((x509ChainElement.StatusFlags & X509ChainStatusFlags.NotSignatureValid) > X509ChainStatusFlags.NoError);
				}
				if (flag3)
				{
					x509ChainElement.StatusFlags |= X509ChainStatusFlags.RevocationStatusUnknown;
					x509ChainElement.StatusFlags |= X509ChainStatusFlags.OfflineRevocation;
				}
				else if (flag4 && !flag2 && !this.IsSelfIssued(x509ChainElement.Certificate))
				{
					x509ChainElement.StatusFlags |= this.CheckRevocation(x509ChainElement.Certificate, i + 1, online);
					flag3 |= ((x509ChainElement.StatusFlags & X509ChainStatusFlags.Revoked) > X509ChainStatusFlags.NoError);
				}
			}
		}

		// Token: 0x0600074B RID: 1867 RVA: 0x00029DD0 File Offset: 0x00027FD0
		private X509ChainStatusFlags CheckRevocation(X509Certificate2 certificate, int ca, bool online)
		{
			X509ChainStatusFlags x509ChainStatusFlags = X509ChainStatusFlags.RevocationStatusUnknown;
			X509Certificate2 certificate2 = this.elements[ca].Certificate;
			while (this.IsSelfIssued(certificate2) && ca < this.elements.Count - 1)
			{
				x509ChainStatusFlags = this.CheckRevocation(certificate, certificate2, online);
				if (x509ChainStatusFlags != X509ChainStatusFlags.RevocationStatusUnknown)
				{
					break;
				}
				ca++;
				certificate2 = this.elements[ca].Certificate;
			}
			if (x509ChainStatusFlags == X509ChainStatusFlags.RevocationStatusUnknown)
			{
				x509ChainStatusFlags = this.CheckRevocation(certificate, certificate2, online);
			}
			return x509ChainStatusFlags;
		}

		// Token: 0x0600074C RID: 1868 RVA: 0x00029E44 File Offset: 0x00028044
		private X509ChainStatusFlags CheckRevocation(X509Certificate2 certificate, X509Certificate2 ca_cert, bool online)
		{
			X509KeyUsageExtension x509KeyUsageExtension = ca_cert.Extensions["2.5.29.15"] as X509KeyUsageExtension;
			if (x509KeyUsageExtension != null)
			{
				X509KeyUsageFlags x509KeyUsageFlags = X509KeyUsageFlags.CrlSign;
				if ((x509KeyUsageExtension.KeyUsages & x509KeyUsageFlags) != x509KeyUsageFlags)
				{
					return X509ChainStatusFlags.RevocationStatusUnknown;
				}
			}
			X509Crl x509Crl = this.FindCrl(ca_cert);
			bool flag = x509Crl == null && online;
			if (x509Crl == null)
			{
				return X509ChainStatusFlags.RevocationStatusUnknown;
			}
			if (!x509Crl.VerifySignature(ca_cert.PublicKey.Key))
			{
				return X509ChainStatusFlags.RevocationStatusUnknown;
			}
			X509Certificate monoCertificate = X509Helper2.GetMonoCertificate(certificate);
			X509Crl.X509CrlEntry crlEntry = x509Crl.GetCrlEntry(monoCertificate);
			if (crlEntry != null)
			{
				if (!this.ProcessCrlEntryExtensions(crlEntry))
				{
					return X509ChainStatusFlags.Revoked;
				}
				if (crlEntry.RevocationDate <= this.ChainPolicy.VerificationTime)
				{
					return X509ChainStatusFlags.Revoked;
				}
			}
			if (x509Crl.NextUpdate < this.ChainPolicy.VerificationTime)
			{
				return X509ChainStatusFlags.RevocationStatusUnknown | X509ChainStatusFlags.OfflineRevocation;
			}
			if (!this.ProcessCrlExtensions(x509Crl))
			{
				return X509ChainStatusFlags.RevocationStatusUnknown;
			}
			return X509ChainStatusFlags.NoError;
		}

		// Token: 0x0600074D RID: 1869 RVA: 0x00029F0C File Offset: 0x0002810C
		private static X509Crl CheckCrls(string subject, string ski, X509Store store)
		{
			if (store == null)
			{
				return null;
			}
			foreach (object obj in store.Crls)
			{
				X509Crl x509Crl = (X509Crl)obj;
				if (x509Crl.IssuerName == subject && (ski.Length == 0 || ski == X509ChainImplMono.GetAuthorityKeyIdentifier(x509Crl)))
				{
					return x509Crl;
				}
			}
			return null;
		}

		// Token: 0x0600074E RID: 1870 RVA: 0x00029F90 File Offset: 0x00028190
		private X509Crl FindCrl(X509Certificate2 caCertificate)
		{
			string subject = caCertificate.SubjectName.Decode(X500DistinguishedNameFlags.None);
			string subjectKeyIdentifier = this.GetSubjectKeyIdentifier(caCertificate);
			X509Crl x509Crl = X509ChainImplMono.CheckCrls(subject, subjectKeyIdentifier, this.LMCAStore.Store);
			if (x509Crl != null)
			{
				return x509Crl;
			}
			if (this.location == StoreLocation.CurrentUser)
			{
				x509Crl = X509ChainImplMono.CheckCrls(subject, subjectKeyIdentifier, this.UserCAStore.Store);
				if (x509Crl != null)
				{
					return x509Crl;
				}
			}
			x509Crl = X509ChainImplMono.CheckCrls(subject, subjectKeyIdentifier, this.LMRootStore.Store);
			if (x509Crl != null)
			{
				return x509Crl;
			}
			if (this.location == StoreLocation.CurrentUser)
			{
				x509Crl = X509ChainImplMono.CheckCrls(subject, subjectKeyIdentifier, this.UserRootStore.Store);
				if (x509Crl != null)
				{
					return x509Crl;
				}
			}
			return null;
		}

		// Token: 0x0600074F RID: 1871 RVA: 0x0002A028 File Offset: 0x00028228
		private bool ProcessCrlExtensions(X509Crl crl)
		{
			foreach (object obj in crl.Extensions)
			{
				X509Extension x509Extension = (X509Extension)obj;
				if (x509Extension.Critical)
				{
					string oid = x509Extension.Oid;
					if (!(oid == "2.5.29.20") && !(oid == "2.5.29.35"))
					{
						return false;
					}
				}
			}
			return true;
		}

		// Token: 0x06000750 RID: 1872 RVA: 0x0002A0B0 File Offset: 0x000282B0
		private bool ProcessCrlEntryExtensions(X509Crl.X509CrlEntry entry)
		{
			foreach (object obj in entry.Extensions)
			{
				X509Extension x509Extension = (X509Extension)obj;
				if (x509Extension.Critical && !(x509Extension.Oid == "2.5.29.21"))
				{
					return false;
				}
			}
			return true;
		}

		// Token: 0x040004E7 RID: 1255
		private StoreLocation location;

		// Token: 0x040004E8 RID: 1256
		private X509ChainElementCollection elements;

		// Token: 0x040004E9 RID: 1257
		private X509ChainPolicy policy;

		// Token: 0x040004EA RID: 1258
		private X509ChainStatus[] status;

		// Token: 0x040004EB RID: 1259
		private static X509ChainStatus[] Empty = new X509ChainStatus[0];

		// Token: 0x040004EC RID: 1260
		private int max_path_length;

		// Token: 0x040004ED RID: 1261
		private X500DistinguishedName working_issuer_name;

		// Token: 0x040004EE RID: 1262
		private AsymmetricAlgorithm working_public_key;

		// Token: 0x040004EF RID: 1263
		private X509ChainElement bce_restriction;

		// Token: 0x040004F0 RID: 1264
		private X509Certificate2Collection roots;

		// Token: 0x040004F1 RID: 1265
		private X509Certificate2Collection cas;

		// Token: 0x040004F2 RID: 1266
		private X509Store root_store;

		// Token: 0x040004F3 RID: 1267
		private X509Store ca_store;

		// Token: 0x040004F4 RID: 1268
		private X509Store user_root_store;

		// Token: 0x040004F5 RID: 1269
		private X509Store user_ca_store;

		// Token: 0x040004F6 RID: 1270
		private X509Certificate2Collection collection;
	}
}
