using System;
using System.Globalization;
using System.Text;

namespace Mono.Security.X509
{
	// Token: 0x02000016 RID: 22
	public class X509Extension
	{
		// Token: 0x060000C5 RID: 197 RVA: 0x00007908 File Offset: 0x00005B08
		public X509Extension(ASN1 asn1)
		{
			if (asn1.Tag != 48 || asn1.Count < 2)
			{
				throw new ArgumentException(Locale.GetText("Invalid X.509 extension."));
			}
			if (asn1[0].Tag != 6)
			{
				throw new ArgumentException(Locale.GetText("Invalid X.509 extension."));
			}
			this.extnOid = ASN1Convert.ToOid(asn1[0]);
			this.extnCritical = (asn1[1].Tag == 1 && asn1[1].Value[0] == byte.MaxValue);
			this.extnValue = asn1[asn1.Count - 1];
			if (this.extnValue.Tag == 4 && this.extnValue.Length > 0 && this.extnValue.Count == 0)
			{
				try
				{
					ASN1 asn2 = new ASN1(this.extnValue.Value);
					this.extnValue.Value = null;
					this.extnValue.Add(asn2);
				}
				catch
				{
				}
			}
			this.Decode();
		}

		// Token: 0x060000C6 RID: 198 RVA: 0x00007A20 File Offset: 0x00005C20
		public X509Extension(X509Extension extension)
		{
			if (extension == null)
			{
				throw new ArgumentNullException("extension");
			}
			if (extension.Value == null || extension.Value.Tag != 4 || extension.Value.Count != 1)
			{
				throw new ArgumentException(Locale.GetText("Invalid X.509 extension."));
			}
			this.extnOid = extension.Oid;
			this.extnCritical = extension.Critical;
			this.extnValue = extension.Value;
			this.Decode();
		}

		// Token: 0x060000C7 RID: 199 RVA: 0x00007A9F File Offset: 0x00005C9F
		protected virtual void Decode()
		{
		}

		// Token: 0x060000C8 RID: 200 RVA: 0x00007A9F File Offset: 0x00005C9F
		protected virtual void Encode()
		{
		}

		// Token: 0x1700003E RID: 62
		// (get) Token: 0x060000C9 RID: 201 RVA: 0x00007AA1 File Offset: 0x00005CA1
		public string Oid
		{
			get
			{
				return this.extnOid;
			}
		}

		// Token: 0x1700003F RID: 63
		// (get) Token: 0x060000CA RID: 202 RVA: 0x00007AA9 File Offset: 0x00005CA9
		public bool Critical
		{
			get
			{
				return this.extnCritical;
			}
		}

		// Token: 0x17000040 RID: 64
		// (get) Token: 0x060000CB RID: 203 RVA: 0x00007AB1 File Offset: 0x00005CB1
		public ASN1 Value
		{
			get
			{
				if (this.extnValue == null)
				{
					this.Encode();
				}
				return this.extnValue;
			}
		}

		// Token: 0x060000CC RID: 204 RVA: 0x00007AC8 File Offset: 0x00005CC8
		public override bool Equals(object obj)
		{
			if (obj == null)
			{
				return false;
			}
			X509Extension x509Extension = obj as X509Extension;
			if (x509Extension == null)
			{
				return false;
			}
			if (this.extnCritical != x509Extension.extnCritical)
			{
				return false;
			}
			if (this.extnOid != x509Extension.extnOid)
			{
				return false;
			}
			if (this.extnValue.Length != x509Extension.extnValue.Length)
			{
				return false;
			}
			for (int i = 0; i < this.extnValue.Length; i++)
			{
				if (this.extnValue[i] != x509Extension.extnValue[i])
				{
					return false;
				}
			}
			return true;
		}

		// Token: 0x060000CD RID: 205 RVA: 0x00007B58 File Offset: 0x00005D58
		public override int GetHashCode()
		{
			return this.extnOid.GetHashCode();
		}

		// Token: 0x060000CE RID: 206 RVA: 0x00007B68 File Offset: 0x00005D68
		private void WriteLine(StringBuilder sb, int n, int pos)
		{
			byte[] value = this.extnValue.Value;
			int num = pos;
			for (int i = 0; i < 8; i++)
			{
				if (i < n)
				{
					sb.Append(value[num++].ToString("X2", CultureInfo.InvariantCulture));
					sb.Append(" ");
				}
				else
				{
					sb.Append("   ");
				}
			}
			sb.Append("  ");
			num = pos;
			for (int j = 0; j < n; j++)
			{
				byte b = value[num++];
				if (b < 32)
				{
					sb.Append(".");
				}
				else
				{
					sb.Append(Convert.ToChar(b));
				}
			}
			sb.Append(Environment.NewLine);
		}

		// Token: 0x060000CF RID: 207 RVA: 0x00007C20 File Offset: 0x00005E20
		public override string ToString()
		{
			StringBuilder stringBuilder = new StringBuilder();
			int num = this.extnValue.Length >> 3;
			int n = this.extnValue.Length - (num << 3);
			int num2 = 0;
			for (int i = 0; i < num; i++)
			{
				this.WriteLine(stringBuilder, 8, num2);
				num2 += 8;
			}
			this.WriteLine(stringBuilder, n, num2);
			return stringBuilder.ToString();
		}

		// Token: 0x0400006F RID: 111
		protected string extnOid;

		// Token: 0x04000070 RID: 112
		protected bool extnCritical;

		// Token: 0x04000071 RID: 113
		protected ASN1 extnValue;
	}
}
