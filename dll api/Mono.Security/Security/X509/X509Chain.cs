using System;
using System.Net;
using Mono.Security.X509.Extensions;

namespace Mono.Security.X509
{
	// Token: 0x02000014 RID: 20
	public class X509Chain
	{
		// Token: 0x060000BB RID: 187 RVA: 0x00007551 File Offset: 0x00005751
		public X509Chain()
		{
			this.certs = new X509CertificateCollection();
		}

		// Token: 0x1700003D RID: 61
		// (get) Token: 0x060000BC RID: 188 RVA: 0x00007564 File Offset: 0x00005764
		public X509CertificateCollection TrustAnchors
		{
			get
			{
				if (this.roots == null)
				{
					this.roots = new X509CertificateCollection();
					this.roots.AddRange(X509StoreManager.TrustedRootCertificates);
					return this.roots;
				}
				return this.roots;
			}
		}

		// Token: 0x060000BD RID: 189 RVA: 0x00007596 File Offset: 0x00005796
		public void LoadCertificates(X509CertificateCollection collection)
		{
			this.certs.AddRange(collection);
		}

		// Token: 0x060000BE RID: 190 RVA: 0x000075A4 File Offset: 0x000057A4
		public bool Build(X509Certificate leaf)
		{
			this._status = X509ChainStatusFlags.NoError;
			if (this._chain == null)
			{
				this._chain = new X509CertificateCollection();
				X509Certificate x509Certificate = leaf;
				X509Certificate potentialRoot = x509Certificate;
				while (x509Certificate != null && !x509Certificate.IsSelfSigned)
				{
					potentialRoot = x509Certificate;
					this._chain.Add(x509Certificate);
					x509Certificate = this.FindCertificateParent(x509Certificate);
				}
				this._root = this.FindCertificateRoot(potentialRoot);
			}
			else
			{
				int count = this._chain.Count;
				if (count > 0)
				{
					if (this.IsParent(leaf, this._chain[0]))
					{
						int num = 1;
						while (num < count && this.IsParent(this._chain[num - 1], this._chain[num]))
						{
							num++;
						}
						if (num == count)
						{
							this._root = this.FindCertificateRoot(this._chain[count - 1]);
						}
					}
				}
				else
				{
					this._root = this.FindCertificateRoot(leaf);
				}
			}
			if (this._chain != null && this._status == X509ChainStatusFlags.NoError)
			{
				foreach (X509Certificate cert in this._chain)
				{
					if (!this.IsValid(cert))
					{
						return false;
					}
				}
				if (!this.IsValid(leaf))
				{
					if (this._status == X509ChainStatusFlags.NotTimeNested)
					{
						this._status = X509ChainStatusFlags.NotTimeValid;
					}
					return false;
				}
				if (this._root != null && !this.IsValid(this._root))
				{
					return false;
				}
			}
			return this._status == X509ChainStatusFlags.NoError;
		}

		// Token: 0x060000BF RID: 191 RVA: 0x00007730 File Offset: 0x00005930
		public void Reset()
		{
			this._status = X509ChainStatusFlags.NoError;
			this.roots = null;
			this.certs.Clear();
			if (this._chain != null)
			{
				this._chain.Clear();
			}
		}

		// Token: 0x060000C0 RID: 192 RVA: 0x0000775E File Offset: 0x0000595E
		private bool IsValid(X509Certificate cert)
		{
			if (!cert.IsCurrent)
			{
				this._status = X509ChainStatusFlags.NotTimeNested;
				return false;
			}
			bool checkCertificateRevocationList = ServicePointManager.CheckCertificateRevocationList;
			return true;
		}

		// Token: 0x060000C1 RID: 193 RVA: 0x00007778 File Offset: 0x00005978
		private X509Certificate FindCertificateParent(X509Certificate child)
		{
			foreach (X509Certificate x509Certificate in this.certs)
			{
				if (this.IsParent(child, x509Certificate))
				{
					return x509Certificate;
				}
			}
			return null;
		}

		// Token: 0x060000C2 RID: 194 RVA: 0x000077D8 File Offset: 0x000059D8
		private X509Certificate FindCertificateRoot(X509Certificate potentialRoot)
		{
			if (potentialRoot == null)
			{
				this._status = X509ChainStatusFlags.PartialChain;
				return null;
			}
			if (this.IsTrusted(potentialRoot))
			{
				return potentialRoot;
			}
			foreach (X509Certificate x509Certificate in this.TrustAnchors)
			{
				if (this.IsParent(potentialRoot, x509Certificate))
				{
					return x509Certificate;
				}
			}
			if (potentialRoot.IsSelfSigned)
			{
				this._status = X509ChainStatusFlags.UntrustedRoot;
				return potentialRoot;
			}
			this._status = X509ChainStatusFlags.PartialChain;
			return null;
		}

		// Token: 0x060000C3 RID: 195 RVA: 0x00007870 File Offset: 0x00005A70
		private bool IsTrusted(X509Certificate potentialTrusted)
		{
			return this.TrustAnchors.Contains(potentialTrusted);
		}

		// Token: 0x060000C4 RID: 196 RVA: 0x00007880 File Offset: 0x00005A80
		private bool IsParent(X509Certificate child, X509Certificate parent)
		{
			if (child.IssuerName != parent.SubjectName)
			{
				return false;
			}
			if (parent.Version > 2 && !this.IsTrusted(parent))
			{
				X509Extension x509Extension = parent.Extensions["2.5.29.19"];
				if (x509Extension != null)
				{
					if (!new BasicConstraintsExtension(x509Extension).CertificateAuthority)
					{
						this._status = X509ChainStatusFlags.InvalidBasicConstraints;
					}
				}
				else
				{
					this._status = X509ChainStatusFlags.InvalidBasicConstraints;
				}
			}
			if (!child.VerifySignature(parent.RSA))
			{
				this._status = X509ChainStatusFlags.NotSignatureValid;
				return false;
			}
			return true;
		}

		// Token: 0x04000062 RID: 98
		private X509CertificateCollection roots;

		// Token: 0x04000063 RID: 99
		private X509CertificateCollection certs;

		// Token: 0x04000064 RID: 100
		private X509Certificate _root;

		// Token: 0x04000065 RID: 101
		private X509CertificateCollection _chain;

		// Token: 0x04000066 RID: 102
		private X509ChainStatusFlags _status;
	}
}
