using System;

namespace Mono.Security.X509
{
	// Token: 0x0200000B RID: 11
	internal class SafeBag
	{
		// Token: 0x06000041 RID: 65 RVA: 0x000032EE File Offset: 0x000014EE
		public SafeBag(string bagOID, ASN1 asn1)
		{
			this._bagOID = bagOID;
			this._asn1 = asn1;
		}

		// Token: 0x17000016 RID: 22
		// (get) Token: 0x06000042 RID: 66 RVA: 0x00003304 File Offset: 0x00001504
		public string BagOID
		{
			get
			{
				return this._bagOID;
			}
		}

		// Token: 0x17000017 RID: 23
		// (get) Token: 0x06000043 RID: 67 RVA: 0x0000330C File Offset: 0x0000150C
		public ASN1 ASN1
		{
			get
			{
				return this._asn1;
			}
		}

		// Token: 0x04000019 RID: 25
		private string _bagOID;

		// Token: 0x0400001A RID: 26
		private ASN1 _asn1;
	}
}
