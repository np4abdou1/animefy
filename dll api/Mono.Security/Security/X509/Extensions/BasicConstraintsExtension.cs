using System;
using System.Globalization;
using System.Text;

namespace Mono.Security.X509.Extensions
{
	// Token: 0x0200002E RID: 46
	public class BasicConstraintsExtension : X509Extension
	{
		// Token: 0x06000101 RID: 257 RVA: 0x000083A4 File Offset: 0x000065A4
		public BasicConstraintsExtension(X509Extension extension) : base(extension)
		{
		}

		// Token: 0x06000102 RID: 258 RVA: 0x00008500 File Offset: 0x00006700
		protected override void Decode()
		{
			this.cA = false;
			this.pathLenConstraint = -1;
			ASN1 asn = new ASN1(this.extnValue.Value);
			if (asn.Tag != 48)
			{
				throw new ArgumentException("Invalid BasicConstraints extension");
			}
			int num = 0;
			ASN1 asn2 = asn[num++];
			if (asn2 != null && asn2.Tag == 1)
			{
				this.cA = (asn2.Value[0] == byte.MaxValue);
				asn2 = asn[num++];
			}
			if (asn2 != null && asn2.Tag == 2)
			{
				this.pathLenConstraint = ASN1Convert.ToInt32(asn2);
			}
		}

		// Token: 0x06000103 RID: 259 RVA: 0x00008594 File Offset: 0x00006794
		protected override void Encode()
		{
			ASN1 asn = new ASN1(48);
			if (this.cA)
			{
				asn.Add(new ASN1(1, new byte[]
				{
					byte.MaxValue
				}));
			}
			if (this.cA && this.pathLenConstraint >= 0)
			{
				asn.Add(ASN1Convert.FromInt32(this.pathLenConstraint));
			}
			this.extnValue = new ASN1(4);
			this.extnValue.Add(asn);
		}

		// Token: 0x1700004C RID: 76
		// (get) Token: 0x06000104 RID: 260 RVA: 0x00008608 File Offset: 0x00006808
		public bool CertificateAuthority
		{
			get
			{
				return this.cA;
			}
		}

		// Token: 0x06000105 RID: 261 RVA: 0x00008610 File Offset: 0x00006810
		public override string ToString()
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("Subject Type=");
			stringBuilder.Append(this.cA ? "CA" : "End Entity");
			stringBuilder.Append(Environment.NewLine);
			stringBuilder.Append("Path Length Constraint=");
			if (this.pathLenConstraint == -1)
			{
				stringBuilder.Append("None");
			}
			else
			{
				stringBuilder.Append(this.pathLenConstraint.ToString(CultureInfo.InvariantCulture));
			}
			stringBuilder.Append(Environment.NewLine);
			return stringBuilder.ToString();
		}

		// Token: 0x04000084 RID: 132
		private bool cA;

		// Token: 0x04000085 RID: 133
		private int pathLenConstraint;
	}
}
