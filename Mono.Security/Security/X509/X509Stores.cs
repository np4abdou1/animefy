using System;
using System.IO;

namespace Mono.Security.X509
{
	// Token: 0x0200001A RID: 26
	public class X509Stores
	{
		// Token: 0x060000E3 RID: 227 RVA: 0x0000807D File Offset: 0x0000627D
		internal X509Stores(string path, bool newFormat)
		{
			this._storePath = path;
			this._newFormat = newFormat;
		}

		// Token: 0x17000049 RID: 73
		// (get) Token: 0x060000E4 RID: 228 RVA: 0x00008094 File Offset: 0x00006294
		public X509Store TrustedRoot
		{
			get
			{
				if (this._trusted == null)
				{
					string path = Path.Combine(this._storePath, "Trust");
					this._trusted = new X509Store(path, true, this._newFormat);
				}
				return this._trusted;
			}
		}

		// Token: 0x060000E5 RID: 229 RVA: 0x000080D4 File Offset: 0x000062D4
		public X509Store Open(string storeName, bool create)
		{
			if (storeName == null)
			{
				throw new ArgumentNullException("storeName");
			}
			string path = Path.Combine(this._storePath, storeName);
			if (!create && !Directory.Exists(path))
			{
				return null;
			}
			return new X509Store(path, true, false);
		}

		// Token: 0x0400007C RID: 124
		private string _storePath;

		// Token: 0x0400007D RID: 125
		private bool _newFormat;

		// Token: 0x0400007E RID: 126
		private X509Store _trusted;
	}
}
