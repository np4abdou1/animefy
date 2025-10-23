using System;
using System.Globalization;
using System.Text;

namespace Mono.Security.X509.Extensions
{
	// Token: 0x0200002D RID: 45
	public class AuthorityKeyIdentifierExtension : X509Extension
	{
		// Token: 0x060000FC RID: 252 RVA: 0x000083A4 File Offset: 0x000065A4
		public AuthorityKeyIdentifierExtension(X509Extension extension) : base(extension)
		{
		}

		// Token: 0x060000FD RID: 253 RVA: 0x000083B0 File Offset: 0x000065B0
		protected override void Decode()
		{
			ASN1 asn = new ASN1(this.extnValue.Value);
			if (asn.Tag != 48)
			{
				throw new ArgumentException("Invalid AuthorityKeyIdentifier extension");
			}
			for (int i = 0; i < asn.Count; i++)
			{
				ASN1 asn2 = asn[i];
				if (asn2.Tag == 128)
				{
					this.aki = asn2.Value;
				}
			}
		}

		// Token: 0x060000FE RID: 254 RVA: 0x00008418 File Offset: 0x00006618
		protected override void Encode()
		{
			ASN1 asn = new ASN1(48);
			if (this.aki == null)
			{
				throw new InvalidOperationException("Invalid AuthorityKeyIdentifier extension");
			}
			asn.Add(new ASN1(128, this.aki));
			this.extnValue = new ASN1(4);
			this.extnValue.Add(asn);
		}

		// Token: 0x1700004B RID: 75
		// (get) Token: 0x060000FF RID: 255 RVA: 0x00008470 File Offset: 0x00006670
		public byte[] Identifier
		{
			get
			{
				if (this.aki == null)
				{
					return null;
				}
				return (byte[])this.aki.Clone();
			}
		}

		// Token: 0x06000100 RID: 256 RVA: 0x0000848C File Offset: 0x0000668C
		public override string ToString()
		{
			StringBuilder stringBuilder = new StringBuilder();
			if (this.aki != null)
			{
				int i = 0;
				stringBuilder.Append("KeyID=");
				while (i < this.aki.Length)
				{
					stringBuilder.Append(this.aki[i].ToString("X2", CultureInfo.InvariantCulture));
					if (i % 2 == 1)
					{
						stringBuilder.Append(" ");
					}
					i++;
				}
			}
			return stringBuilder.ToString();
		}

		// Token: 0x04000083 RID: 131
		private byte[] aki;
	}
}
