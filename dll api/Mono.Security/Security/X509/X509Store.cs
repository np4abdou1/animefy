using System;
using System.Collections;
using System.IO;

namespace Mono.Security.X509
{
	// Token: 0x02000018 RID: 24
	public class X509Store
	{
		// Token: 0x060000D5 RID: 213 RVA: 0x00007D60 File Offset: 0x00005F60
		internal X509Store(string path, bool crl, bool newFormat)
		{
			this._storePath = path;
			this._crl = crl;
			this._newFormat = newFormat;
		}

		// Token: 0x17000042 RID: 66
		// (get) Token: 0x060000D6 RID: 214 RVA: 0x00007D7D File Offset: 0x00005F7D
		public X509CertificateCollection Certificates
		{
			get
			{
				if (this._certificates == null)
				{
					this._certificates = this.BuildCertificatesCollection(this._storePath);
				}
				return this._certificates;
			}
		}

		// Token: 0x17000043 RID: 67
		// (get) Token: 0x060000D7 RID: 215 RVA: 0x00007D9F File Offset: 0x00005F9F
		public ArrayList Crls
		{
			get
			{
				if (!this._crl)
				{
					this._crls = new ArrayList();
				}
				if (this._crls == null)
				{
					this._crls = this.BuildCrlsCollection(this._storePath);
				}
				return this._crls;
			}
		}

		// Token: 0x060000D8 RID: 216 RVA: 0x00007DD4 File Offset: 0x00005FD4
		private byte[] Load(string filename)
		{
			byte[] array = null;
			using (FileStream fileStream = File.OpenRead(filename))
			{
				array = new byte[fileStream.Length];
				fileStream.Read(array, 0, array.Length);
				fileStream.Close();
			}
			return array;
		}

		// Token: 0x060000D9 RID: 217 RVA: 0x00007E28 File Offset: 0x00006028
		private X509Certificate LoadCertificate(string filename)
		{
			return new X509Certificate(this.Load(filename));
		}

		// Token: 0x060000DA RID: 218 RVA: 0x00007E36 File Offset: 0x00006036
		private X509Crl LoadCrl(string filename)
		{
			return new X509Crl(this.Load(filename));
		}

		// Token: 0x060000DB RID: 219 RVA: 0x00007E44 File Offset: 0x00006044
		private bool CheckStore(string path, bool throwException)
		{
			bool result;
			try
			{
				if (Directory.Exists(path))
				{
					result = true;
				}
				else
				{
					Directory.CreateDirectory(path);
					result = Directory.Exists(path);
				}
			}
			catch
			{
				if (throwException)
				{
					throw;
				}
				result = false;
			}
			return result;
		}

		// Token: 0x060000DC RID: 220 RVA: 0x00007E88 File Offset: 0x00006088
		private X509CertificateCollection BuildCertificatesCollection(string storeName)
		{
			X509CertificateCollection x509CertificateCollection = new X509CertificateCollection();
			string path = Path.Combine(this._storePath, storeName);
			if (!this.CheckStore(path, false))
			{
				return x509CertificateCollection;
			}
			string[] files = Directory.GetFiles(path, this._newFormat ? "*.0" : "*.cer");
			if (files != null && files.Length != 0)
			{
				foreach (string filename in files)
				{
					try
					{
						X509Certificate value = this.LoadCertificate(filename);
						x509CertificateCollection.Add(value);
					}
					catch
					{
					}
				}
			}
			return x509CertificateCollection;
		}

		// Token: 0x060000DD RID: 221 RVA: 0x00007F1C File Offset: 0x0000611C
		private ArrayList BuildCrlsCollection(string storeName)
		{
			ArrayList arrayList = new ArrayList();
			string path = Path.Combine(this._storePath, storeName);
			if (!this.CheckStore(path, false))
			{
				return arrayList;
			}
			string[] files = Directory.GetFiles(path, "*.crl");
			if (files != null && files.Length != 0)
			{
				foreach (string filename in files)
				{
					try
					{
						X509Crl value = this.LoadCrl(filename);
						arrayList.Add(value);
					}
					catch
					{
					}
				}
			}
			return arrayList;
		}

		// Token: 0x04000073 RID: 115
		private string _storePath;

		// Token: 0x04000074 RID: 116
		private X509CertificateCollection _certificates;

		// Token: 0x04000075 RID: 117
		private ArrayList _crls;

		// Token: 0x04000076 RID: 118
		private bool _crl;

		// Token: 0x04000077 RID: 119
		private bool _newFormat;
	}
}
